﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leadtools.Medical.Winforms.EventBrokerArgs
{
   public class DicomFileDeletedEventArgs : FileInformationEventArgs
   {
      public DicomFileDeletedEventArgs ( string filePath ) 
      : base ( filePath ) 
      {
         
      }
   }
}
