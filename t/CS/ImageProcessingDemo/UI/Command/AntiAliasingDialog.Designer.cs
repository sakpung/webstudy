namespace ImageProcessingDemo
{
   partial class AntiAliasingDialog
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntiAliasingDialog));
          this._gbThreshold = new System.Windows.Forms.GroupBox();
          this._tbThreshold = new System.Windows.Forms.TrackBar();
          this._txbThreshold = new System.Windows.Forms.TextBox();
          this._gbMaskSize = new System.Windows.Forms.GroupBox();
          this._tbMaskSize = new System.Windows.Forms.TrackBar();
          this._txbMaskSize = new System.Windows.Forms.TextBox();
          this._lblFilter = new System.Windows.Forms.Label();
          this._cmbFilter = new System.Windows.Forms.ComboBox();
          this._btnCancel = new System.Windows.Forms.Button();
          this._btnOk = new System.Windows.Forms.Button();
          this._gbThreshold.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this._tbThreshold)).BeginInit();
          this._gbMaskSize.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this._tbMaskSize)).BeginInit();
          this.SuspendLayout();
          // 
          // _gbThreshold
          // 
          this._gbThreshold.Controls.Add(this._tbThreshold);
          this._gbThreshold.Controls.Add(this._txbThreshold);
          this._gbThreshold.FlatStyle = System.Windows.Forms.FlatStyle.System;
          resources.ApplyResources(this._gbThreshold, "_gbThreshold");
          this._gbThreshold.Name = "_gbThreshold";
          this._gbThreshold.TabStop = false;
          // 
          // _tbThreshold
          // 
          resources.ApplyResources(this._tbThreshold, "_tbThreshold");
          this._tbThreshold.Maximum = 255;
          this._tbThreshold.Name = "_tbThreshold";
          this._tbThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
          this._tbThreshold.Scroll += new System.EventHandler(this._tbThreshold_Scroll);
          // 
          // _txbThreshold
          // 
          this._txbThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          resources.ApplyResources(this._txbThreshold, "_txbThreshold");
          this._txbThreshold.Name = "_txbThreshold";
          this._txbThreshold.TextChanged += new System.EventHandler(this._txbThreshold_TextChanged);
          // 
          // _gbMaskSize
          // 
          this._gbMaskSize.Controls.Add(this._tbMaskSize);
          this._gbMaskSize.Controls.Add(this._txbMaskSize);
          this._gbMaskSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
          resources.ApplyResources(this._gbMaskSize, "_gbMaskSize");
          this._gbMaskSize.Name = "_gbMaskSize";
          this._gbMaskSize.TabStop = false;
          // 
          // _tbMaskSize
          // 
          resources.ApplyResources(this._tbMaskSize, "_tbMaskSize");
          this._tbMaskSize.Maximum = 100;
          this._tbMaskSize.Minimum = 2;
          this._tbMaskSize.Name = "_tbMaskSize";
          this._tbMaskSize.TickStyle = System.Windows.Forms.TickStyle.None;
          this._tbMaskSize.Value = 2;
          this._tbMaskSize.Scroll += new System.EventHandler(this._tbMaskSize_Scroll);
          // 
          // _txbMaskSize
          // 
          this._txbMaskSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          resources.ApplyResources(this._txbMaskSize, "_txbMaskSize");
          this._txbMaskSize.Name = "_txbMaskSize";
          this._txbMaskSize.TextChanged += new System.EventHandler(this._txbMaskSize_TextChanged);
          // 
          // _lblFilter
          // 
          resources.ApplyResources(this._lblFilter, "_lblFilter");
          this._lblFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
          this._lblFilter.Name = "_lblFilter";
          // 
          // _cmbFilter
          // 
          this._cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this._cmbFilter.FormattingEnabled = true;
          resources.ApplyResources(this._cmbFilter, "_cmbFilter");
          this._cmbFilter.Name = "_cmbFilter";
          // 
          // _btnCancel
          // 
          this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          resources.ApplyResources(this._btnCancel, "_btnCancel");
          this._btnCancel.Name = "_btnCancel";
          this._btnCancel.UseVisualStyleBackColor = true;
          this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
          // 
          // _btnOk
          // 
          resources.ApplyResources(this._btnOk, "_btnOk");
          this._btnOk.Name = "_btnOk";
          this._btnOk.UseVisualStyleBackColor = true;
          this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
          // 
          // AntiAliasingDialog
          // 
          this.AcceptButton = this._btnOk;
          resources.ApplyResources(this, "$this");
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.CancelButton = this._btnCancel;
          this.Controls.Add(this._btnCancel);
          this.Controls.Add(this._btnOk);
          this.Controls.Add(this._cmbFilter);
          this.Controls.Add(this._lblFilter);
          this.Controls.Add(this._gbMaskSize);
          this.Controls.Add(this._gbThreshold);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "AntiAliasingDialog";
          this.ShowIcon = false;
          this._gbThreshold.ResumeLayout(false);
          this._gbThreshold.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this._tbThreshold)).EndInit();
          this._gbMaskSize.ResumeLayout(false);
          this._gbMaskSize.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this._tbMaskSize)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox _gbThreshold;
      private System.Windows.Forms.TextBox _txbThreshold;
      private System.Windows.Forms.GroupBox _gbMaskSize;
      private System.Windows.Forms.TextBox _txbMaskSize;
      private System.Windows.Forms.Label _lblFilter;
      private System.Windows.Forms.ComboBox _cmbFilter;
      public System.Windows.Forms.TrackBar _tbThreshold;
      public System.Windows.Forms.TrackBar _tbMaskSize;
      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
   }
}