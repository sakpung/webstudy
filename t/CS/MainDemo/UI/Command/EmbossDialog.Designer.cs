namespace MainDemo
{
   partial class EmbossDialog
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmbossDialog));
         this._btnCancel = new System.Windows.Forms.Button();
         this._btnOk = new System.Windows.Forms.Button();
         this._gbOptions = new System.Windows.Forms.GroupBox();
         this._cbDirection = new System.Windows.Forms.ComboBox();
         this._numDepth = new System.Windows.Forms.NumericUpDown();
         this._lblDirection = new System.Windows.Forms.Label();
         this._lblDepth = new System.Windows.Forms.Label();
         this._gbOptions.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._numDepth)).BeginInit();
         this.SuspendLayout();
         // 
         // _btnCancel
         // 
         this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         resources.ApplyResources(this._btnCancel, "_btnCancel");
         this._btnCancel.Name = "_btnCancel";
         this._btnCancel.UseVisualStyleBackColor = true;
         // 
         // _btnOk
         // 
         this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         resources.ApplyResources(this._btnOk, "_btnOk");
         this._btnOk.Name = "_btnOk";
         this._btnOk.UseVisualStyleBackColor = true;
         this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
         // 
         // _gbOptions
         // 
         this._gbOptions.Controls.Add(this._cbDirection);
         this._gbOptions.Controls.Add(this._numDepth);
         this._gbOptions.Controls.Add(this._lblDirection);
         this._gbOptions.Controls.Add(this._lblDepth);
         this._gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         resources.ApplyResources(this._gbOptions, "_gbOptions");
         this._gbOptions.Name = "_gbOptions";
         this._gbOptions.TabStop = false;
         // 
         // _cbDirection
         // 
         this._cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._cbDirection.FormattingEnabled = true;
         resources.ApplyResources(this._cbDirection, "_cbDirection");
         this._cbDirection.Name = "_cbDirection";
         // 
         // _numDepth
         // 
         resources.ApplyResources(this._numDepth, "_numDepth");
         this._numDepth.Name = "_numDepth";
         this._numDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._numDepth.Leave += new System.EventHandler(this._num_Leave);
         // 
         // _lblDirection
         // 
         this._lblDirection.FlatStyle = System.Windows.Forms.FlatStyle.System;
         resources.ApplyResources(this._lblDirection, "_lblDirection");
         this._lblDirection.Name = "_lblDirection";
         // 
         // _lblDepth
         // 
         this._lblDepth.FlatStyle = System.Windows.Forms.FlatStyle.System;
         resources.ApplyResources(this._lblDepth, "_lblDepth");
         this._lblDepth.Name = "_lblDepth";
         // 
         // EmbossDialog
         // 
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this._gbOptions);
         this.Controls.Add(this._btnCancel);
         this.Controls.Add(this._btnOk);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "EmbossDialog";
         this.ShowInTaskbar = false;
         this.Load += new System.EventHandler(this.EmbossDialog_Load);
         this._gbOptions.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this._numDepth)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
      private System.Windows.Forms.GroupBox _gbOptions;
      private System.Windows.Forms.ComboBox _cbDirection;
      private System.Windows.Forms.NumericUpDown _numDepth;
      private System.Windows.Forms.Label _lblDirection;
      private System.Windows.Forms.Label _lblDepth;
   }
}