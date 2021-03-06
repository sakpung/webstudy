﻿' *************************************************************
' Copyright (c) 1991-2019 LEAD Technologies, Inc.              
' All Rights Reserved.                                         
' *************************************************************
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Leadtools.Dicom.Common.Attributes
Imports Leadtools.Dicom
Imports Leadtools.Dicom.Common.Extensions

Namespace DicomDemo.Dicom
   <Instance(DicomClassType.Undefined, NActionScu.PatientUpdateClass)> _
   Public Class DeletePatient : Inherits PatientUpdate
      Private _PatientId As String = String.Empty

      <Element(DicomTag.PatientID)> _
      Public Property PatientId() As String
         Get
            Return _PatientId
         End Get
         Set(ByVal value As String)
            _PatientId = Value
         End Set
      End Property
   End Class
End Namespace
