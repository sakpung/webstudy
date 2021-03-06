namespace ImageProcessingDemo
{
   partial class GammaCorrectDialog
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GammaCorrectDialog));
          this._gbGamma = new System.Windows.Forms.GroupBox();
          this._txbGamma = new System.Windows.Forms.TextBox();
          this._tbGamma = new System.Windows.Forms.TrackBar();
          this._btnCancel = new System.Windows.Forms.Button();
          this._btnOk = new System.Windows.Forms.Button();
          this._gbGamma.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this._tbGamma)).BeginInit();
          this.SuspendLayout();
          // 
          // _gbGamma
          // 
          this._gbGamma.Controls.Add(this._txbGamma);
          this._gbGamma.Controls.Add(this._tbGamma);
          this._gbGamma.FlatStyle = System.Windows.Forms.FlatStyle.System;
          resources.ApplyResources(this._gbGamma, "_gbGamma");
          this._gbGamma.Name = "_gbGamma";
          this._gbGamma.TabStop = false;
          // 
          // _txbGamma
          // 
          this._txbGamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          resources.ApplyResources(this._txbGamma, "_txbGamma");
          this._txbGamma.Name = "_txbGamma";
          this._txbGamma.TextChanged += new System.EventHandler(this._txbGamma_TextChanged);
          // 
          // _tbGamma
          // 
          resources.ApplyResources(this._tbGamma, "_tbGamma");
          this._tbGamma.Maximum = 500;
          this._tbGamma.Minimum = 1;
          this._tbGamma.Name = "_tbGamma";
          this._tbGamma.TickStyle = System.Windows.Forms.TickStyle.None;
          this._tbGamma.Value = 1;
          this._tbGamma.Scroll += new System.EventHandler(this._tbGamma_Scroll);
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
          this._btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          resources.ApplyResources(this._btnOk, "_btnOk");
          this._btnOk.Name = "_btnOk";
          this._btnOk.UseVisualStyleBackColor = true;
          this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
          // 
          // GammaCorrectDialog
          // 
          this.AcceptButton = this._btnOk;
          resources.ApplyResources(this, "$this");
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.CancelButton = this._btnCancel;
          this.Controls.Add(this._btnCancel);
          this.Controls.Add(this._btnOk);
          this.Controls.Add(this._gbGamma);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "GammaCorrectDialog";
          this.ShowIcon = false;
          this._gbGamma.ResumeLayout(false);
          this._gbGamma.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this._tbGamma)).EndInit();
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox _gbGamma;
      private System.Windows.Forms.TextBox _txbGamma;
      public System.Windows.Forms.TrackBar _tbGamma;
      private System.Windows.Forms.Button _btnCancel;
      private System.Windows.Forms.Button _btnOk;
   }
}