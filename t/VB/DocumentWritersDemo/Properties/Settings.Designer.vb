﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace DocumentWritersDemo.Properties


   <System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
   <System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")> _
   Partial Friend NotInheritable Class Settings
      Inherits Global.System.Configuration.ApplicationSettingsBase

      Private Shared defaultInstance As Settings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings)

      Public Shared ReadOnly Property [Default]() As Settings
         Get
            Return defaultInstance
         End Get
      End Property

      <System.Configuration.UserScopedSettingAttribute()> _
      <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
      <System.Configuration.DefaultSettingValueAttribute("")> _
      Public Property NewDocumentWidth() As String
         Get
            Return CType(Me("NewDocumentWidth"), String)
         End Get
         Set(value As String)
            Me("NewDocumentWidth") = value
         End Set
      End Property

      <System.Configuration.UserScopedSettingAttribute()> _
      <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
      <System.Configuration.DefaultSettingValueAttribute("")> _
      Public Property NewDocumentHeight() As String
         Get
            Return CType(Me("NewDocumentHeight"), String)
         End Get
         Set(value As String)
            Me("NewDocumentHeight") = value
         End Set
      End Property

      <System.Configuration.UserScopedSettingAttribute()> _
      <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
      <System.Configuration.DefaultSettingValueAttribute("")> _
      Public Property NewDocumentResolution() As String
         Get
            Return CType(Me("NewDocumentResolution"), String)
         End Get
         Set(value As String)
            Me("NewDocumentResolution") = value
         End Set
      End Property

      <System.Configuration.UserScopedSettingAttribute()> _
      <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
      <System.Configuration.DefaultSettingValueAttribute("0")> _
      Public Property AdvancedPdfOptionsSelectedTabIndex() As Integer
         Get
            Return CInt(Me("AdvancedPdfOptionsSelectedTabIndex"))
         End Get
         Set(value As Integer)
            Me("AdvancedPdfOptionsSelectedTabIndex") = value
         End Set
      End Property
   End Class
End Namespace