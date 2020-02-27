﻿// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Leadtools.Demos;
using Leadtools;
using Leadtools.ImageProcessing;

namespace DocumentCleanupDemo
{
   public partial class RotateDialog : Form
   {
      
      // The RotateCommandFlags are flags which control the behaviour of image resize methods. 
      // This dialog will check the flags used when rotating the image. Flags used are:
      // RotateCommandFlags.None, this flag will not resize the image or crop it.  
      // RotateCommandFlags.Resample, this flag will perform bilinear interpolation when rotating.
      // RotateCommandFlags.Bicubic, this flag will perform bicubic interpolation when rotating. 
      // RotateCommandFlags.Resize, this flag will size resulting image as needed. 
      // This dialog will also update the image Width and Height if resized option is enable.

      private static int _initialAngle = 0;
      private static RotateCommandFlags _initialFlags = RotateCommandFlags.None;
      private static RasterColor _initialFillColor = new RasterColor(255, 255, 255);

      public int Angle;
      public RotateCommandFlags Flags;
      public RasterColor FillColor;

      public RotateDialog()
      {
         InitializeComponent();
      }

      private void RotateDialog_Load(object sender, System.EventArgs e)
      {
         Angle = _initialAngle / 100;
         Flags = _initialFlags;
         FillColor = _initialFillColor;

         _numAngle.Value = Angle;
         _cbResize.Checked = (Flags & RotateCommandFlags.Resize) == RotateCommandFlags.Resize;

         if ((Flags & RotateCommandFlags.Resample) == RotateCommandFlags.Resample)
            _rbButtonResample.Checked = true;
         else if ((Flags & RotateCommandFlags.Bicubic) == RotateCommandFlags.Bicubic)
            _rbButtonBicubic.Checked = true;
         else
            _rbButtonNormal.Checked = true;
      }

      private void _num_Leave(object sender, System.EventArgs e)
      {
         DialogUtilities.NumericOnLeave(sender);
      }

      private void _pnlFillColor_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
      {
         e.Graphics.FillRectangle(new SolidBrush(Converters.ToGdiPlusColor(FillColor)), _pnlFillColor.ClientRectangle);
      }

      private void _btnFillColor_Click(object sender, System.EventArgs e)
      {
         if (Tools.ShowColorDialog(this, ref FillColor))
            _pnlFillColor.Refresh();
      }

      private void _btnOk_Click(object sender, System.EventArgs e)
      {
         // Set the new values for the selected RotateCommandFlags flags and apply to the loaded image.
         Angle = (int)_numAngle.Value * 100;

         Flags = RotateCommandFlags.None;

         if (_cbResize.Checked)
            Flags |= RotateCommandFlags.Resize;

         if (_rbButtonResample.Checked)
            Flags |= RotateCommandFlags.Resample;

         if (_rbButtonBicubic.Checked)
            Flags |= RotateCommandFlags.Bicubic;

         _initialAngle = Angle;
         _initialFlags = Flags;
         _initialFillColor = FillColor;
      }
   }
}
