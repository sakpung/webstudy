﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leadtools.Dicom.Services.ErrorHandler
{
   public class JsonFault
   {
      public string Message  { get ; set ; } 
      public string Detail  { get ; set ; } 
      public string FaultType  { get ; set ; } 
   }
}
