﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4952
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
    
    '''<summary>
    '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
    '''&lt;actionsDisplayName&gt;
    '''   &lt;entry&gt;
    '''      &lt;action&gt;None&lt;/action&gt;
    '''      &lt;displayName&gt;Selección&lt;/displayName&gt;
    '''   &lt;/entry&gt;
    '''   &lt;entry&gt;
    '''      &lt;action&gt;WindowLevel&lt;/action&gt;
    '''      &lt;displayName&gt;Nivel de Ventana&lt;/displayName&gt;
    '''   &lt;/entry&gt;
    '''   &lt;entry&gt;
    '''      &lt;action&gt;Scale&lt;/action&gt;
    '''      &lt;displayName&gt;Acercamiento&lt;/displayName&gt;
    '''   &lt;/entry&gt;
    '''   &lt;entry&gt;
    '''      &lt;action&gt;Offset&lt;/action&gt;
    '''      &lt;displayName&gt;Compensar&lt;/displayName&gt;
    '''   &lt;/entry&gt;
    '''   &lt;entry&gt;
    '''      &lt;action&gt;Stack&lt;/actio [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property actionName_Spanish() As String
        Get
            Return ResourceManager.GetString("actionName_Spanish", resourceCulture)
        End Get
    End Property
    
    Friend Shared ReadOnly Property folder_open() As System.Drawing.Icon
        Get
            Dim obj As Object = ResourceManager.GetObject("folder_open", resourceCulture)
            Return CType(obj,System.Drawing.Icon)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
    '''&lt;WorkstationMessages&gt;
    '''  &lt;ViewerNotExistError&gt;El visor no existe.&lt;/ViewerNotExistError&gt;
    '''  &lt;ViewerNotBelongToViewError&gt;El visor no le pertenece a este panorama.&lt;/ViewerNotBelongToViewError&gt;
    '''  &lt;StudyExistsError&gt;El estudio ya existe.&lt;/StudyExistsError&gt;
    '''  &lt;VolumeLoadedError&gt;El volumen ya esta cargado.&lt;/VolumeLoadedError&gt;
    '''  &lt;LoaderNotFoundError&gt;No se ha encontrado un cargador para la serie.&lt;/LoaderNotFoundError&gt;
    '''  &lt;VolumeViewerFormattedTitle&gt;{0} Volumen&lt;/VolumeViewerF [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property Messages_Spanish() As String
        Get
            Return ResourceManager.GetString("Messages_Spanish", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
    '''&lt;loaderStatusMessage&gt;
    '''   &lt;RetrievingSeries&gt;
    '''      &lt;message&gt;Recuperando la serie de imagenes...&lt;/message&gt;
    '''   &lt;/RetrievingSeries&gt;
    '''   &lt;LoadingSeries&gt;
    '''      &lt;message&gt;Cargando la serie de imagenes...&lt;/message&gt;
    '''   &lt;/LoadingSeries&gt;
    '''   &lt;CreatingSeries&gt;
    '''      &lt;message&gt;Creando la serie de celdas...&lt;/message&gt;
    '''   &lt;/CreatingSeries&gt;
    '''   &lt;LoadingImages&gt;
    '''      &lt;message&gt;Cargando imagenes...&lt;/message&gt;
    '''   &lt;/LoadingImages&gt;
    '''   &lt;LoadingTags&gt;
    '''      &lt;message&gt;Cargando etiquetas s [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property StatusMessages_Spanish() As String
        Get
            Return ResourceManager.GetString("StatusMessages_Spanish", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
    '''&lt;toolStripMenuProperties&gt;
    '''   &lt;SaveToolStripButton&gt;
    '''      &lt;text&gt;&amp;amp;Guardar&lt;/text&gt;
    '''      &lt;shortcutKeys&gt;None&lt;/shortcutKeys&gt;
    '''   &lt;/SaveToolStripButton&gt;
    '''   &lt;CopyToolStripButton&gt;
    '''      &lt;text&gt;&amp;amp;Copia&lt;/text&gt;
    '''      &lt;shortcutKeys&gt;None&lt;/shortcutKeys&gt;
    '''   &lt;/CopyToolStripButton&gt;
    '''   &lt;PrintToolStripButton&gt;
    '''      &lt;text&gt;&amp;amp;Imprimir&lt;/text&gt;
    '''      &lt;shortcutKeys&gt;None&lt;/shortcutKeys&gt;
    '''   &lt;/PrintToolStripButton&gt;
    '''   &lt;AnnotationsSaveLoadDropDownButton&gt;
    '''      &lt;text&gt;Guardar/Car [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property Toolstrip_Spanish() As String
        Get
            Return ResourceManager.GetString("Toolstrip_Spanish", resourceCulture)
        End Get
    End Property
End Class
