﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
   <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

      Private resourceMan As Global.System.Resources.ResourceManager

      Private resourceCulture As Global.System.Globalization.CultureInfo

      '''<summary>
      '''  Returns the cached ResourceManager instance used by this class.
      '''</summary>
      <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
      Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
         Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
               Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DicomVideoCaptureDemo.Resources", GetType(Resources).Assembly)
               resourceMan = temp
            End If
            Return resourceMan
         End Get
      End Property

      '''<summary>
      '''  Overrides the current thread's CurrentUICulture property for all
      '''  resource lookups using this strongly typed resource class.
      '''</summary>
      <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
      Friend Property Culture() As Global.System.Globalization.CultureInfo
         Get
            Return resourceCulture
         End Get
         Set(value As Global.System.Globalization.CultureInfo)
            resourceCulture = value
         End Set
      End Property

      '''<summary>
      '''  Looks up a localized resource of type System.Byte[].
      '''</summary>
      Friend ReadOnly Property Multi_frame_SC() As Byte()
         Get
            Dim obj As Object = ResourceManager.GetObject("Multi_frame_SC", resourceCulture)
            Return CType(obj, Byte())
         End Get
      End Property

      '''<summary>
      '''  Looks up a localized resource of type System.Drawing.Bitmap.
      '''</summary>
      Friend ReadOnly Property STORAGE1() As System.Drawing.Bitmap
         Get
            Dim obj As Object = ResourceManager.GetObject("STORAGE1", resourceCulture)
            Return CType(obj, System.Drawing.Bitmap)
         End Get
      End Property

      '''<summary>
      '''  Looks up a localized resource of type System.Drawing.Bitmap.
      '''</summary>
      Friend ReadOnly Property STORAGE2() As System.Drawing.Bitmap
         Get
            Dim obj As Object = ResourceManager.GetObject("STORAGE2", resourceCulture)
            Return CType(obj, System.Drawing.Bitmap)
         End Get
      End Property

      '''<summary>
      '''  Looks up a localized resource of type System.Drawing.Bitmap.
      '''</summary>
      Friend ReadOnly Property STREAM() As System.Drawing.Bitmap
         Get
            Dim obj As Object = ResourceManager.GetObject("STREAM", resourceCulture)
            Return CType(obj, System.Drawing.Bitmap)
         End Get
      End Property

      '''<summary>
      '''  Looks up a localized resource of type System.Byte[].
      '''</summary>
      Friend ReadOnly Property Video_endoscopy() As Byte()
         Get
            Dim obj As Object = ResourceManager.GetObject("Video_endoscopy", resourceCulture)
            Return CType(obj, Byte())
         End Get
      End Property

      '''<summary>
      '''  Looks up a localized resource of type System.Byte[].
      '''</summary>
      Friend ReadOnly Property Video_microscopy() As Byte()
         Get
            Dim obj As Object = ResourceManager.GetObject("Video_microscopy", resourceCulture)
            Return CType(obj, Byte())
         End Get
      End Property

      '''<summary>
      '''  Looks up a localized resource of type System.Byte[].
      '''</summary>
      Friend ReadOnly Property Video_Photography() As Byte()
         Get
            Dim obj As Object = ResourceManager.GetObject("Video_Photography", resourceCulture)
            Return CType(obj, Byte())
         End Get
      End Property
   End Module
End Namespace
