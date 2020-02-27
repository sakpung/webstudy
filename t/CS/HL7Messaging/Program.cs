﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Leadtools.Demos;
using Leadtools;

namespace HL7Messaging
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         if (!Support.SetLicense())
            return;

         if (RasterSupport.IsLocked(RasterSupportType.Hl7))
         {
            MessageBox.Show(String.Format("{0} Support is locked!", RasterSupportType.Hl7.ToString()), "Warning");
            return;
         }

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainView());
      }
   }
}
