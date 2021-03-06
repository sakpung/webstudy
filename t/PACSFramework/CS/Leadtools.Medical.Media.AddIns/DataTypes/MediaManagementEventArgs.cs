﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Leadtools.Dicom.Common.DataTypes.MediaCreation;

namespace Leadtools.Medical.Media.AddIns
{
   public class MediaManagementEventArgs : EventArgs
   {
      public MediaManagementEventArgs ( MediaCreationManagement[] mediaObjects ) 
      {
         MediaObjects = mediaObjects ;
      }
      
      public MediaCreationManagement[] MediaObjects
      {
         get ;
         private set ;
      }
   }
}
