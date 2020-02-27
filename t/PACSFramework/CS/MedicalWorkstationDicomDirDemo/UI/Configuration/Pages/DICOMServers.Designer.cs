﻿namespace Leadtools.Demos.Workstation
{
   public partial class DICOMServers
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
         this.DICOMPACSGroupBox = new System.Windows.Forms.GroupBox();
         this.DICOMServersDataGridView = new System.Windows.Forms.DataGridView();
         this.AETitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.IPAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.PortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.TimeoutColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.DefaultQueryRetrieveColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         this.DefaultStoreServerColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         this.AeTitleToolStrip = new System.Windows.Forms.ToolStrip();
         this.AddDicomServerToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.DeleteDicomServerToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.DICOMPACSGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DICOMServersDataGridView)).BeginInit();
         this.AeTitleToolStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // DICOMPACSGroupBox
         // 
         this.DICOMPACSGroupBox.Controls.Add(this.DICOMServersDataGridView);
         this.DICOMPACSGroupBox.Controls.Add(this.AeTitleToolStrip);
         this.DICOMPACSGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.DICOMPACSGroupBox.ForeColor = System.Drawing.Color.White;
         this.DICOMPACSGroupBox.Location = new System.Drawing.Point(0, 0);
         this.DICOMPACSGroupBox.Name = "DICOMPACSGroupBox";
         this.DICOMPACSGroupBox.Size = new System.Drawing.Size(959, 489);
         this.DICOMPACSGroupBox.TabIndex = 0;
         this.DICOMPACSGroupBox.TabStop = false;
         this.DICOMPACSGroupBox.Text = "Remote PACS";
         // 
         // DICOMServersDataGridView
         // 
         this.DICOMServersDataGridView.AllowUserToAddRows = false;
         dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.DICOMServersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
         this.DICOMServersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.DICOMServersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
         dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
         dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
         dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.DICOMServersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
         this.DICOMServersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DICOMServersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AETitleColumn,
            this.IPAddressColumn,
            this.PortColumn,
            this.TimeoutColumn,
            this.DefaultQueryRetrieveColumn,
            this.DefaultStoreServerColumn});
         dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
         dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.DICOMServersDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
         this.DICOMServersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.DICOMServersDataGridView.EnableHeadersVisualStyles = false;
         this.DICOMServersDataGridView.GridColor = System.Drawing.Color.White;
         this.DICOMServersDataGridView.Location = new System.Drawing.Point(3, 55);
         this.DICOMServersDataGridView.MultiSelect = false;
         this.DICOMServersDataGridView.Name = "DICOMServersDataGridView";
         dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8F);
         dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightGray;
         dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.DICOMServersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
         dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
         dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
         this.DICOMServersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
         this.DICOMServersDataGridView.RowTemplate.Height = 26;
         this.DICOMServersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.DICOMServersDataGridView.Size = new System.Drawing.Size(953, 431);
         this.DICOMServersDataGridView.TabIndex = 1;
         // 
         // AETitleColumn
         // 
         this.AETitleColumn.FillWeight = 85.5619F;
         this.AETitleColumn.HeaderText = "AE Title";
         this.AETitleColumn.Name = "AETitleColumn";
         // 
         // IPAddressColumn
         // 
         dataGridViewCellStyle11.NullValue = null;
         this.IPAddressColumn.DefaultCellStyle = dataGridViewCellStyle11;
         this.IPAddressColumn.FillWeight = 85.5619F;
         this.IPAddressColumn.HeaderText = "Host Name/Address";
         this.IPAddressColumn.Name = "IPAddressColumn";
         // 
         // PortColumn
         // 
         dataGridViewCellStyle12.Format = "N0";
         dataGridViewCellStyle12.NullValue = null;
         this.PortColumn.DefaultCellStyle = dataGridViewCellStyle12;
         this.PortColumn.FillWeight = 85.5619F;
         this.PortColumn.HeaderText = "Port";
         this.PortColumn.Name = "PortColumn";
         // 
         // TimeoutColumn
         // 
         dataGridViewCellStyle13.Format = "N0";
         dataGridViewCellStyle13.NullValue = "30";
         this.TimeoutColumn.DefaultCellStyle = dataGridViewCellStyle13;
         this.TimeoutColumn.FillWeight = 126.9036F;
         this.TimeoutColumn.HeaderText = "Communication Timeout";
         this.TimeoutColumn.Name = "TimeoutColumn";
         // 
         // DefaultQueryRetrieveColumn
         // 
         this.DefaultQueryRetrieveColumn.HeaderText = "Default Query/Retrieve";
         this.DefaultQueryRetrieveColumn.Name = "DefaultQueryRetrieveColumn";
         // 
         // DefaultStoreServerColumn
         // 
         this.DefaultStoreServerColumn.HeaderText = "Default Storage";
         this.DefaultStoreServerColumn.Name = "DefaultStoreServerColumn";
         this.DefaultStoreServerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.DefaultStoreServerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         // 
         // AeTitleToolStrip
         // 
         this.AeTitleToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
         this.AeTitleToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
         this.AeTitleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDicomServerToolStripButton,
            this.DeleteDicomServerToolStripButton});
         this.AeTitleToolStrip.Location = new System.Drawing.Point(3, 16);
         this.AeTitleToolStrip.Name = "AeTitleToolStrip";
         this.AeTitleToolStrip.Size = new System.Drawing.Size(953, 39);
         this.AeTitleToolStrip.Stretch = true;
         this.AeTitleToolStrip.TabIndex = 0;
         // 
         // AddDicomServerToolStripButton
         // 
         this.AddDicomServerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.AddDicomServerToolStripButton.Image = global::Leadtools.Demos.Workstation.Properties.Resources.client_add_32;
         this.AddDicomServerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.AddDicomServerToolStripButton.Name = "AddDicomServerToolStripButton";
         this.AddDicomServerToolStripButton.Size = new System.Drawing.Size(36, 36);
         this.AddDicomServerToolStripButton.Text = "Add Remote PACS";
         // 
         // DeleteDicomServerToolStripButton
         // 
         this.DeleteDicomServerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.DeleteDicomServerToolStripButton.Image = global::Leadtools.Demos.Workstation.Properties.Resources.client_remove_32;
         this.DeleteDicomServerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.DeleteDicomServerToolStripButton.Name = "DeleteDicomServerToolStripButton";
         this.DeleteDicomServerToolStripButton.Size = new System.Drawing.Size(36, 36);
         this.DeleteDicomServerToolStripButton.Text = "Remove Remote PACS";
         // 
         // DICOMServers
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
         this.Controls.Add(this.DICOMPACSGroupBox);
         this.ForeColor = System.Drawing.Color.White;
         this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.Name = "DICOMServers";
         this.Size = new System.Drawing.Size(959, 489);
         this.DICOMPACSGroupBox.ResumeLayout(false);
         this.DICOMPACSGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DICOMServersDataGridView)).EndInit();
         this.AeTitleToolStrip.ResumeLayout(false);
         this.AeTitleToolStrip.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.GroupBox DICOMPACSGroupBox;
      protected System.Windows.Forms.DataGridView DICOMServersDataGridView;
      protected System.Windows.Forms.ToolStrip AeTitleToolStrip;
      protected System.Windows.Forms.ToolStripButton AddDicomServerToolStripButton;
      protected System.Windows.Forms.ToolStripButton DeleteDicomServerToolStripButton;
      private System.Windows.Forms.DataGridViewTextBoxColumn AETitleColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn IPAddressColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn PortColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn TimeoutColumn;
      private System.Windows.Forms.DataGridViewCheckBoxColumn DefaultQueryRetrieveColumn;
      private System.Windows.Forms.DataGridViewCheckBoxColumn DefaultStoreServerColumn;

   }
}
