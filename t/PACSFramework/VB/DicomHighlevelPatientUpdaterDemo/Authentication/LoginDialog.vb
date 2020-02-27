﻿' *************************************************************
' Copyright (c) 1991-2019 LEAD Technologies, Inc.              
' All Rights Reserved.                                         
' *************************************************************
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Security

Namespace DicomDemo.Authentication
   Partial Class LoginDialog : Inherits Form
      Public Event AuthenticateUser As EventHandler(Of AuthenticateUserEventArgs)

      Public ReadOnly Property Username() As String
         Get
            Return textBoxUserName.Text
         End Get
      End Property

      Public Sub New()
         InitializeComponent()
      End Sub

      Private Sub buttonLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonLogin.Click
         Dim ea As AuthenticateUserEventArgs = New AuthenticateUserEventArgs(textBoxUserName.Text, Extensions.ToSecureString(textBoxPassword.Text))
         RaiseEvent AuthenticateUser(Me, ea)
         If ea.Cancel Then
            DialogResult = DialogResult.Cancel
         End If
         If ea.InvalidCredentials Then
            DialogResult = DialogResult.None
            textBoxPassword.Text = String.Empty
            textBoxUserName.Focus()
         End If
      End Sub

      Private Sub Credentials_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles textBoxUserName.TextChanged, textBoxPassword.TextChanged
         buttonLogin.Enabled = textBoxUserName.Text.Length > 0 AndAlso textBoxPassword.Text.Length > 0
      End Sub
   End Class
End Namespace
