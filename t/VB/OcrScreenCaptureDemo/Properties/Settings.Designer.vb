﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


   <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
   Partial Friend NotInheritable Class Settings : Inherits Global.System.Configuration.ApplicationSettingsBase

      Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

      Public Shared ReadOnly Property [Default]() As Settings
         Get
            Return defaultInstance
         End Get
      End Property

      <Global.System.Configuration.UserScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.DefaultSettingValueAttribute("False")> _
      Public Property UseHotKey() As Boolean
         Get
            Return (CBool(Me("UseHotKey")))
         End Get
         Set(value As Boolean)
            Me("UseHotKey") = Value
         End Set
      End Property

      <Global.System.Configuration.UserScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.DefaultSettingValueAttribute("rectangleArea")> _
      Public Property CaptureArea() As String
         Get
            Return (CStr(Me("CaptureArea")))
         End Get
         Set(value As String)
            Me("CaptureArea") = Value
         End Set
      End Property
   End Class
End Namespace
