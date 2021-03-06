﻿' *************************************************************
' Copyright (c) 1991-2019 LEAD Technologies, Inc.              
' All Rights Reserved.                                         
' *************************************************************
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace JpipWinFormsDemo
   Friend Class Program
      ''' <summary>
      ''' The main entry point for the application.
      ''' </summary>
      Private Sub New()
      End Sub
      <STAThread()> _
      Shared Sub Main(ByVal  args As String())
         If Not Support.SetLicense() Then
            Application.Exit()
            Return
         End If

         If DemosGlobal.MustRestartElevated() Then
            DemosGlobal.TryRestartElevated(args)
            Return
         End If
         Application.EnableVisualStyles()
         Application.SetCompatibleTextRenderingDefault(False)
         Application.Run(New MainForm())
      End Sub
   End Class
End Namespace
