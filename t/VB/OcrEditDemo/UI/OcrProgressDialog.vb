﻿' *************************************************************
' Copyright (c) 1991-2019 LEAD Technologies, Inc.              
' All Rights Reserved.                                         
' *************************************************************
Imports System.Threading

Imports Leadtools.Ocr

''' <summary>
''' This is a dialog that handles the OCR progress callback
''' </summary>
Public Class OcrProgressDialog
   ' The user operation
   Public Delegate Sub ProcessDelegate(ByVal dlg As OcrProgressDialog, ByVal args As Dictionary(Of String, Object))
   Private _delegate As ProcessDelegate
   Private _args As Dictionary(Of String, Object)
   ' The OCR progress callback
   Private _ocrProgressCallback As OcrProgressCallback
   ' Has the operation been canceled?
   Private _isCanceled As Boolean
   ' Is the dialog working?
   Private _isWorking As Boolean
   ' Are we using a progress bar?
   Private _allowProgress As Boolean

   Public Sub New(ByVal allowProgress As Boolean, ByVal title As String, ByVal del As ProcessDelegate, ByVal args As Dictionary(Of String, Object))

      ' This call is required by the Windows Form Designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Text = title
      _delegate = del
      _args = args

      _allowProgress = allowProgress

      If _allowProgress Then
         _panel.BorderStyle = BorderStyle.None
      Else
         ' Hide the border and cancel button
         _panel.BorderStyle = BorderStyle.FixedSingle
         FormBorderStyle = FormBorderStyle.None
         _cancelButton.Visible = False
         _cancelButton.Enabled = False

         ' Use Marquee progress style
         _progressBar.Style = ProgressBarStyle.Marquee
      End If

      _isWorking = True
   End Sub

   Public ReadOnly Property IsCanceled() As Boolean
      Get
         Return _isCanceled
      End Get
   End Property

   Public ReadOnly Property OcrProgressCallback() As OcrProgressCallback
      Get
         Return _ocrProgressCallback
      End Get
   End Property

   Protected Overrides Sub OnLoad(ByVal e As EventArgs)
      ' Call the user to perform the operation, run it in a separate thread
      Dim t As New Thread(New ParameterizedThreadStart(AddressOf StartUp))
      t.Start()

      MyBase.OnLoad(e)
   End Sub

   Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
      ' Don't allow the form to close while the callback is still working
      If (_isWorking) Then
         e.Cancel = True
      End If

      MyBase.OnFormClosing(e)
   End Sub

   Private Sub StartUp(ByVal obj As Object)
      If _allowProgress Then
         _ocrProgressCallback = New OcrProgressCallback(AddressOf MyOcrProgressCallback)
      Else
         _ocrProgressCallback = Nothing
      End If

      Invoke(_delegate, New Object() {Me, _args})

      If _isCanceled Then
         DialogResult = DialogResult.Cancel
      Else
         DialogResult = DialogResult.OK
      End If

      _isWorking = False

      If InvokeRequired Then
         BeginInvoke(New MethodInvoker(AddressOf Close))
      Else
         Close()
      End If
   End Sub

   Private Sub DoUpdateStatus(ByVal str As String, ByVal percentage As Integer)
      _descriptionLabel.Text = str
      _progressBar.Value = percentage
   End Sub

   Private Delegate Sub DoUpdateStatusDelegate(ByVal str As String, ByVal percentage As Integer)

   Private Sub MyOcrProgressCallback(ByVal data As IOcrProgressData)
      ' Update the description label
      Dim pageNumber As Integer = data.CurrentPageIndex + 1
      Dim pagesCount As Integer = data.LastPageIndex + 1

      Dim str As String = String.Format("{0} - Page {1} of {2}", data.Operation.ToString(), pageNumber, pagesCount)
      Dim percentage As Integer = data.Percentage

      If InvokeRequired Then
         BeginInvoke(New DoUpdateStatusDelegate(AddressOf DoUpdateStatus), New Object() {str, percentage})
      Else
         DoUpdateStatus(str, percentage)
      End If

      If _isCanceled Then
         data.Status = OcrProgressStatus.Abort
      End If

      Application.DoEvents()
   End Sub

   Private Sub _cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cancelButton.Click
      ' Set the isCanceled variable to true
      ' This will break from the progress callback and 
      ' closes the dialog
      If _allowProgress Then
         _isCanceled = True
      End If
   End Sub

   Private Sub DoUpdateDescription(ByVal message As String)
      _descriptionLabel.Text = message
   End Sub

   Private Delegate Sub UpdateDescriptionDelegate(ByVal message As String)

   ''' <summary>
   ''' Called by the user to update the description label
   ''' </summary>
   Public Sub UpdateDescription(ByVal message As String)
      If InvokeRequired Then
         BeginInvoke(New UpdateDescriptionDelegate(AddressOf DoUpdateDescription), New Object() {message})
      Else
         DoUpdateDescription(message)
      End If
      Application.DoEvents()
   End Sub

   ''' <summary>
   ''' Called by the user when the operation is done to close the dialog
   ''' </summary>
   Public Sub EndOperation()
      _isWorking = False

      If InvokeRequired Then
         BeginInvoke(New MethodInvoker(AddressOf Close))
      Else
         Close()
      End If
   End Sub
End Class
