﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4927
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class Resources
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Returns the cached ResourceManager instance used by this class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Overrides the current thread's CurrentUICulture property for all
    '''  resource lookups using this strongly typed resource class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    Friend Shared ReadOnly Property AppSettings() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("AppSettings", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property ClearDICOM() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("ClearDICOM", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property DeleteImage() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("DeleteImage", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property DeleteSelectImage() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("DeleteSelectImage", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property Help() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("Help", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property LoadRaster() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("LoadRaster", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property Minus() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("Minus", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property Plus() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("Plus", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property Rotate() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("Rotate", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property SaveDICOM() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("SaveDICOM", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property ScreenCapture() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("ScreenCapture", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property StorePACS_32() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("StorePACS_32", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property StorePACS_48() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("StorePACS_48", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property TransferPatientInfo() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("TransferPatientInfo", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property TransferStudy() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("TransferStudy", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property TransferWorkItem() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("TransferWorkItem", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property TWAINAquire() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("TWAINAquire", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property ViewLog() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("ViewLog", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    Friend Shared ReadOnly Property WIAAcquire() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("WIAAcquire", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
End Class
