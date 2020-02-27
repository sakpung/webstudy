﻿' *************************************************************
' Copyright (c) 1991-2019 LEAD Technologies, Inc.              
' All Rights Reserved.                                         
' *************************************************************
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Imports Leadtools
Imports Leadtools.Demos

#If LEADTOOLS_V17_OR_LATER Then
Imports Leadtools.Drawing
#End If ' #if LEADTOOLS_V17_OR_LATER

#If (Not LEADTOOLS_V17_OR_LATER) Then
Imports LeadPoint = System.Drawing.Point
Imports LeadSize = System.Drawing.Size
Imports LeadRect = System.Drawing.Rectangle
#End If ' #if !LEADTOOLS_V17_OR_LATER

Namespace AnimationDemo
   Public Class PanImageEvent : Inherits EventArgs
      Private _offset As Point

      Public Sub New(ByVal offset_Renamed As Point)
         _offset = offset_Renamed
      End Sub

      Public ReadOnly Property Offset() As Point
         Get
            Return _offset
         End Get
      End Property
   End Class

   Partial Public Class ImagePreviewCtrl : Inherits UserControl
      Private _image As RasterImage
      Private _fitView As Boolean
      Private _sourceRectangle As Rectangle
      Private _destinationRectangle As Rectangle
      Private _borderStyle As BorderStyle
      Private _isPanAllowed As Boolean
      Private _isPanModeBusy As Boolean
      Private _isCursorClipped As Boolean
      Private _rcClip As Rectangle
      Private _panPoint As Point
      Private _offset As Point

      Private Const WS_BORDER As Integer = &H800000
      Private Const WS_EX_CLIENTEDGE As Integer = &H200

      Public Sub New(ByVal image_Renamed As RasterImage, ByVal previewPosition As Point, ByVal previewSize As Size)
         Me.Location = previewPosition
         Me.Size = previewSize

         InitializeComponent()
         SetStyle(ControlStyles.ResizeRedraw, True)
         SetStyle(ControlStyles.AllPaintingInWmPaint, True)
         SetStyle(ControlStyles.ContainerControl, True)
         SetStyle(ControlStyles.SupportsTransparentBackColor, True)
         SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
         SetStyle(ControlStyles.UserPaint, True)

         _image = image_Renamed
         _fitView = False
         _sourceRectangle = Rectangle.Empty
         _destinationRectangle = Rectangle.Empty
         _borderStyle = BorderStyle.Fixed3D
         _isPanAllowed = False
         _isPanModeBusy = False
         _isCursorClipped = False
         _panPoint = Point.Empty
         _offset = Point.Empty

         CalculateAll()
      End Sub

      Public Property Image() As RasterImage
         Get
            Return _image
         End Get
         Set(value As RasterImage)
            If Not _image Is Value Then
               _image = Value
               OnImageChanged(EventArgs.Empty)
            End If
         End Set
      End Property

      Public Event ImageChanged As EventHandler

      Protected Overridable Sub OnImageChanged(ByVal e As EventArgs)
         CalculateAll()
         Invalidate()

         If Not ImageChangedEvent Is Nothing Then
            RaiseEvent ImageChanged(Me, e)
         End If
      End Sub

      Protected Overrides ReadOnly Property CreateParams() As CreateParams
         Get
            Dim cp As CreateParams = MyBase.CreateParams

            Select Case BorderStyle
               Case BorderStyle.None
                  cp.Style = cp.Style And Not WS_BORDER
                  cp.ExStyle = cp.ExStyle And Not WS_EX_CLIENTEDGE

               Case BorderStyle.FixedSingle
                  cp.Style = cp.Style Or WS_BORDER
                  cp.ExStyle = cp.ExStyle And Not WS_EX_CLIENTEDGE

               Case BorderStyle.Fixed3D
                  cp.Style = cp.Style And Not WS_BORDER
                  cp.ExStyle = cp.ExStyle Or WS_EX_CLIENTEDGE
            End Select

            Return cp
         End Get
      End Property

      Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
         Try
            Dim dstRect As LeadRect = Leadtools.Demos.Converters.ConvertRect(DestinationRectangle)

#If LEADTOOLS_V17_OR_LATER Then
            RasterImagePainter.Paint(_image, e.Graphics, Leadtools.Demos.Converters.ConvertRect(SourceRectangle), LeadRect.Empty, dstRect, Leadtools.Demos.Converters.ConvertRect(e.ClipRectangle), RasterPaintProperties.Default)
#Else
			RasterImagePainter.Paint(_image, e.Graphics,_image.Paint(e.Graphics,Leadtools.Demos.Converters.ConvertRect(SourceRectangle), LeadRect.Empty, dstRect, Leadtools.Demos.Converters.ConvertRect(e.ClipRectangle), RasterPaintProperties.Default)
#End If ' #if LEADTOOLS_V17_OR_LATER
         Catch
         End Try
      End Sub

      Public Event FitViewChanged As EventHandler

      Protected Overridable Sub OnFitViewChanged(ByVal e As EventArgs)
         CalculateAll()
         Invalidate()

         If Not FitViewChangedEvent Is Nothing Then
            RaiseEvent FitViewChanged(Me, e)
         End If
      End Sub

      Public Event BorderStyleChanged As EventHandler

      Protected Overridable Sub OnBorderStyleChanged(ByVal e As EventArgs)
         UpdateStyles()
         Invalidate()

         If Not BorderStyleChangedEvent Is Nothing Then
            RaiseEvent BorderStyleChanged(Me, e)
         End If
      End Sub

      Private Sub CalculateAll()
         Dim currentXScaleFactor As Double = 1
         Dim currentYScaleFactor As Double = 1

         Dim fitView_Renamed As Boolean = FitView
         _sourceRectangle = Rectangle.Empty
         If Not _image Is Nothing Then
            _sourceRectangle = New Rectangle(0, 0, _image.Width, _image.Height)
         End If

         _destinationRectangle = ClientRectangle

         If fitView_Renamed Then
            If _sourceRectangle.Width > 0 AndAlso _sourceRectangle.Height > 0 Then
               If _destinationRectangle.Width > 0 AndAlso _destinationRectangle.Height > 0 Then
                  Dim factor As Double

                  If _destinationRectangle.Width > _destinationRectangle.Height Then
                     factor = _destinationRectangle.Width / CDbl(_sourceRectangle.Width)
                     If (factor * CDbl(_sourceRectangle.Height)) > _destinationRectangle.Height Then
                        factor = _destinationRectangle.Height / CDbl(_sourceRectangle.Height)
                     End If
                  Else
                     factor = _destinationRectangle.Height / CDbl(_sourceRectangle.Height)
                     If (factor * CDbl(_sourceRectangle.Width)) > _destinationRectangle.Width Then
                        factor = _destinationRectangle.Width / CDbl(_sourceRectangle.Width)
                     End If
                  End If

                  currentXScaleFactor = factor
                  currentYScaleFactor = factor
               End If
            End If
         End If

         If currentXScaleFactor <= 0.0 Then
            currentXScaleFactor = 1
         End If
         If currentYScaleFactor <= 0.0 Then
            currentYScaleFactor = 1
         End If

         _destinationRectangle = New Rectangle(0, 0, CInt(SourceRectangle.Width * currentXScaleFactor), CInt(SourceRectangle.Height * currentYScaleFactor))
         Dim left As Integer = 0
         Dim top As Integer = 0

         ' Center the Image.
         left = CInt((ClientRectangle.Width - _destinationRectangle.Width) / 2)
         top = CInt((ClientRectangle.Height - _destinationRectangle.Height) / 2)

         _isPanAllowed = (Not FitView) AndAlso (SourceRectangle.Width > ClientRectangle.Width OrElse SourceRectangle.Height > ClientRectangle.Height)

         _offset = Point.Empty
         _destinationRectangle.Offset(left, top)
      End Sub

      Public Property FitView() As Boolean
         Get
            Return _fitView
         End Get
         Set(value As Boolean)
            If _fitView <> Value Then
               _fitView = Value
               OnFitViewChanged(EventArgs.Empty)
            End If
         End Set
      End Property

      Public Shadows Property BorderStyle() As BorderStyle
         Get
            Return _borderStyle
         End Get

         Set(value As BorderStyle)
            If Value <> BorderStyle Then
               _borderStyle = Value
               OnBorderStyleChanged(EventArgs.Empty)
            End If
         End Set
      End Property

      Public ReadOnly Property Offset() As Point
         Get
            Return _offset
         End Get
      End Property

      Private ReadOnly Property IsPanModeBusy() As Boolean
         Get
            Return _isPanModeBusy
         End Get
      End Property

      Private ReadOnly Property SourceRectangle() As Rectangle
         Get
            Return _sourceRectangle
         End Get
      End Property

      Private ReadOnly Property DestinationRectangle() As Rectangle
         Get
            Return _destinationRectangle
         End Get
      End Property

      Private ReadOnly Property IsPanAllowed() As Boolean
         Get
            Return _isPanAllowed
         End Get
      End Property

      Private Sub CancelPanMode()
         If IsPanModeBusy Then
            EndPanMode()
         End If
      End Sub

      Private Sub EndPanMode()
         If IsPanModeBusy Then
            Capture = False
            _isPanModeBusy = False

            EndClipCursor()
         End If
      End Sub

      Private Sub BeginPanMode(ByVal clipCursor As Boolean)
         _isPanModeBusy = True
         Capture = True

         If clipCursor Then
            BeginClipCursor()
         End If
      End Sub

      Private Sub BeginClipCursor()
         Dim rc As Rectangle = Rectangle.Intersect(DemosGlobal.FixRectangle(SourceRectangle), ClientRectangle)
         rc = RectangleToScreen(rc)
         Dim parentControl As Control = Parent
         Do While Not parentControl Is Nothing
            rc = Rectangle.Intersect(rc, Parent.RectangleToScreen(Parent.ClientRectangle))
            If TypeOf parentControl Is Form Then
               Dim form As Form = TryCast(parentControl, Form)
               If form.IsMdiChild AndAlso Not form.Owner Is Nothing Then
                  rc = Rectangle.Intersect(rc, form.Owner.RectangleToScreen(form.Owner.ClientRectangle))
               End If
            End If

            parentControl = parentControl.Parent
         Loop

         _rcClip = Cursor.Clip
         Cursor.Clip = rc
         _isCursorClipped = True
      End Sub

      Private Sub EndClipCursor()
         If _isCursorClipped Then
            Cursor.Clip = _rcClip
            _isCursorClipped = False
            _rcClip = Rectangle.Empty
         End If
      End Sub

      Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
         Focus()

         If Not Image Is Nothing Then
            If e.Button = MouseButtons.Left Then
               If IsPanAllowed Then
                  If IsPanModeBusy Then
                     CancelPanMode()
                  Else
                     Dim pt As Point = New Point(e.X, e.Y)
                     Dim rc As Rectangle = SourceRectangle
                     If rc.Contains(pt) Then
                        BeginPanMode(False)
                        _panPoint = pt
                     End If
                  End If
               End If
            ElseIf IsPanModeBusy Then
               CancelPanMode()
            End If
         End If

         MyBase.OnMouseDown(e)
      End Sub

      Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
         If IsPanModeBusy Then
            If (_panPoint.X - e.X) <> 0 OrElse (_panPoint.Y - e.Y) <> 0 Then

               Dim offset_Renamed As Point = New Point(-(_panPoint.X - e.X), -(_panPoint.Y - e.Y))

               UpdateDestinationRect(offset_Renamed)
               _panPoint = New Point(e.X, e.Y)
            End If
         End If
         MyBase.OnMouseMove(e)
      End Sub

      Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
         If IsPanAllowed Then
            EndPanMode()
         End If
         MyBase.OnMouseUp(e)
      End Sub


      Private Sub UpdateDestinationRect(ByVal offset_Renamed As Point)
         Dim updatePan As Boolean = False
         Dim panPoint As Point = Point.Empty

         If (_destinationRectangle.Left + offset_Renamed.X <= 0) AndAlso (Math.Abs(_destinationRectangle.Left) + ClientRectangle.Width - offset_Renamed.X <= SourceRectangle.Width) Then
            updatePan = True
            panPoint.X = offset_Renamed.X
         End If

         If (_destinationRectangle.Top + offset_Renamed.Y <= 0) AndAlso (Math.Abs(_destinationRectangle.Top) + ClientRectangle.Height - offset_Renamed.Y <= SourceRectangle.Height) Then
            updatePan = True
            panPoint.Y = offset_Renamed.Y
         End If

         If updatePan Then
            Dim e As PanImageEvent = New PanImageEvent(panPoint)
            OnPanImage(e)
         End If
      End Sub

      Public Event PanImage As EventHandler(Of PanImageEvent)

      Protected Overridable Sub OnPanImage(ByVal e As PanImageEvent)
         OffsetImage(e.Offset)
         If Not PanImageEvent Is Nothing Then
            RaiseEvent PanImage(Me, e)
         End If
      End Sub


      Public Sub OffsetImage(ByVal offset_Renamed As Point)
         _destinationRectangle.Offset(offset_Renamed)
         _offset.Offset(offset_Renamed)

         Invalidate()
      End Sub

   End Class
End Namespace
