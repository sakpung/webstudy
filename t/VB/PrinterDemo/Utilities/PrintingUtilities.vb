﻿' *************************************************************
' Copyright (c) 1991-2019 LEAD Technologies, Inc.              
' All Rights Reserved.                                         
' *************************************************************
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Text
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
Imports Leadtools.Printer

Friend Class PrintingUtilities
#Region "Methods..."
   <DllImport("shell32.dll")> _
   Public Shared Function IsUserAnAdmin() As Boolean
   End Function

   Friend Shared Function InstallNewPrinter(ByVal printerName As String, ByVal printerPassword As String) As Boolean
      Try
         If IsPrinterExist(printerName) Then
            Dim errorMessage As String = "Duplicated printer name. Please enter another name."
            MessageBox.Show(errorMessage, "LEADTOOLS Printer Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
         Else
#If LTV20_CONFIG Then
            Dim documentPrinterRegPath As String = "SOFTWARE\LEAD Technologies, Inc.\20\Printer\"
#ElseIf LTV19_CONFIG Then
            Dim documentPrinterRegPath As String = "SOFTWARE\LEAD Technologies, Inc.\19\Printer\"
#End If

            If (Environment.OSVersion.Version.Major >= 6 And Not PrintingUtilities.IsUserAnAdmin()) Then
               'On operating system vista or upper, demo requires to be ran with elevated rights
               MessageBox.Show("Installing New Printer Requires Administrative Rights", "LEADTOOLS Printer Demo", MessageBoxButtons.OK, MessageBoxIcon.Error)
               Return False
            End If

            Dim printerInfo As PrinterInfo = New PrinterInfo()
            printerInfo.PortName = printerName
            printerInfo.MonitorName = printerName
            printerInfo.ProductName = printerName
            printerInfo.PrinterName = printerName
            printerInfo.Password = printerPassword
            printerInfo.RegistryKey = documentPrinterRegPath & printerName
            printerInfo.RootDir = GetPrinterPath(documentPrinterRegPath)
            printerInfo.Url = "https://www.leadtools.com/support/default.htm"
            printerInfo.PrinterExe = Application.ExecutablePath
            printerInfo.AboutIcon = System.IO.Path.Combine(DemosGlobal.ImagesFolder, "PrinterDriver.ico")
            printerInfo.AboutString = "LEADTOOLS VB Printer Demo"

            'Function Requires administrative rights
            Printer.Install(printerInfo)
            MessageBox.Show("Installing New Printer Completed Successfully", "LEADTOOLS Printer Demo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True

         End If
      Catch
         Return False
      End Try
   End Function

   Friend Shared Function GetPrinterPath(ByVal registryPath As String) As String
      Try
         Dim connectionExe As String = String.Empty
         Dim subPathExe As String = String.Empty
         Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey(registryPath & "Data")

         If Not registryKey Is Nothing Then
            connectionExe = registryKey.GetValue("ConnectionExe").ToString()
            Dim pathExe As String() = connectionExe.Split("\"c)

            Dim iLoop As Integer = 0
            Do While iLoop < pathExe.Length - 2
               subPathExe &= pathExe(iLoop) & "\"
               iLoop += 1
            Loop
            subPathExe.Remove(subPathExe.Length - 1, 1)
         End If
         Return subPathExe
      Catch
         Return String.Empty
      End Try
   End Function

   Friend Shared Function GetLeadtoolsPrintersList() As String()
      Try
         Dim printersList As List(Of String) = New List(Of String)()

         For Each printerName As String In PrinterSettings.InstalledPrinters
            Try
               If Printer.IsLeadtoolsPrinter(printerName) Then
                  printersList.Add(printerName)
               End If
            Catch

            End Try
         Next printerName
         Return printersList.ToArray()
      Catch
         Return New List(Of String)().ToArray()
      End Try
   End Function

   Friend Shared Function GetAllPrintersList() As String()
      Try
         Dim allPrinterList As List(Of String) = New List(Of String)()

         For Each printerName As String In PrinterSettings.InstalledPrinters
            allPrinterList.Add(printerName)
         Next printerName
         Return allPrinterList.ToArray()
      Catch
         Return New List(Of String)().ToArray()
      End Try
   End Function

   Friend Shared Function IsPrinterExist(ByVal printerName As String) As Boolean
      Try
         Dim printers As String() = GetAllPrintersList()
         Dim printersList As List(Of String) = New List(Of String)()
         printersList.AddRange(printers)

         Dim exist As Boolean = False
         For Each name As String In printersList
            If String.Compare(printerName, name, True) = 0 Then
               exist = True
            End If
         Next
         Return exist
      Catch
         Return True
      End Try
   End Function
#End Region
End Class
