﻿
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------



<System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
<System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
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
   Public Property SourceLTDFolder() As String
      Get
         Return CType(Me("SourceLTDFolder"), String)
      End Get
      Set(value As String)
         Me("SourceLTDFolder") = value
      End Set
   End Property

   <System.Configuration.UserScopedSettingAttribute()> _
   <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
   <System.Configuration.DefaultSettingValueAttribute("")> _
   Public Property Format() As String
      Get
         Return CType(Me("Format"), String)
      End Get
      Set(value As String)
         Me("Format") = value
      End Set
   End Property

   <System.Configuration.UserScopedSettingAttribute()> _
   <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
   <System.Configuration.DefaultSettingValueAttribute("")> _
   Public Property FormatOptionsXml() As String
      Get
         Return CType(Me("FormatOptionsXml"), String)
      End Get
      Set(value As String)
         Me("FormatOptionsXml") = value
      End Set
   End Property

   <System.Configuration.UserScopedSettingAttribute()> _
   <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
   <System.Configuration.DefaultSettingValueAttribute("False")> _
   Public Property ViewFinalDocument() As Boolean
      Get
         Return CBool(Me("ViewFinalDocument"))
      End Get
      Set(value As Boolean)
         Me("ViewFinalDocument") = value
      End Set
   End Property

   <System.Configuration.UserScopedSettingAttribute()> _
   <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
   <System.Configuration.DefaultSettingValueAttribute("")> _
   Public Property OutputFileName() As String
      Get
         Return CType(Me("OutputFileName"), String)
      End Get
      Set(value As String)
         Me("OutputFileName") = value
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

   <System.Configuration.UserScopedSettingAttribute()> _
   <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
   <System.Configuration.DefaultSettingValueAttribute("")> _
   Public Property SaveDialogLastPath() As String
      Get
         Return CType(Me("SaveDialogLastPath"), String)
      End Get
      Set(value As String)
         Me("SaveDialogLastPath") = value
      End Set
   End Property

   <System.Configuration.UserScopedSettingAttribute()> _
   <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
   <System.Configuration.DefaultSettingValueAttribute("0")> _
   Public Property LTDDocumentTypeIndex() As Integer
      Get
         Return CInt(Me("LTDDocumentTypeIndex"))
      End Get
      Set(value As Integer)
         Me("LTDDocumentTypeIndex") = value
      End Set
   End Property
End Class