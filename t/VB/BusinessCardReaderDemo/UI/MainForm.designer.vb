﻿Imports Leadtools.Controls
Partial Class MainForm
   Private components As System.ComponentModel.IContainer = Nothing

   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso (components IsNot Nothing) Then
         components.Dispose()
      End If

      MyBase.Dispose(disposing)
   End Sub

   Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
      Me._splMain = New System.Windows.Forms.SplitContainer()
      Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
      Me.dGV_Results = New System.Windows.Forms.DataGridView()
      Me._Field = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me._result = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me._confidence = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me._splViewerList = New System.Windows.Forms.SplitContainer()
      Me.rasterImageViewer1 = New ImageViewer()
      Me._tsViewer = New System.Windows.Forms.ToolStrip()
      Me._btnPanTool = New System.Windows.Forms.ToolStripButton()
      Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
      Me._btnZoomNormal = New System.Windows.Forms.ToolStripButton()
      Me._btnFit = New System.Windows.Forms.ToolStripButton()
      Me._btnFitWidth = New System.Windows.Forms.ToolStripButton()
      Me._btnRetry = New System.Windows.Forms.ToolStripButton()
      Me._btnRotateLeft = New System.Windows.Forms.ToolStripButton()
      Me._btnRotateRight = New System.Windows.Forms.ToolStripButton()
      Me._btnZoomIn = New System.Windows.Forms.ToolStripButton()
      Me._btnZoomOut = New System.Windows.Forms.ToolStripButton()
      Me._btnZoomDrawTool = New System.Windows.Forms.ToolStripButton()
      Me._btnUseDpi = New System.Windows.Forms.ToolStripButton()
      Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
      Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.scanImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
      Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me._menuItemHowTo = New System.Windows.Forms.ToolStripMenuItem()
      Me._menuItemAbout = New System.Windows.Forms.ToolStripMenuItem()
      CType((Me._splMain), System.ComponentModel.ISupportInitialize).BeginInit()
      Me._splMain.Panel1.SuspendLayout()
      Me._splMain.Panel2.SuspendLayout()
      Me._splMain.SuspendLayout()
      CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
      Me.splitContainer1.Panel1.SuspendLayout()
      Me.splitContainer1.SuspendLayout()
      CType((Me.dGV_Results), System.ComponentModel.ISupportInitialize).BeginInit()
      CType((Me._splViewerList), System.ComponentModel.ISupportInitialize).BeginInit()
      Me._splViewerList.Panel1.SuspendLayout()
      Me._splViewerList.SuspendLayout()
      Me._tsViewer.SuspendLayout()
      Me.menuStrip1.SuspendLayout()
      Me.SuspendLayout()
      Me._splMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me._splMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me._splMain.Location = New System.Drawing.Point(0, 24)
      Me._splMain.Name = "_splMain"
      Me._splMain.Panel1.Controls.Add(Me.splitContainer1)
      Me._splMain.Panel1MinSize = 484
      Me._splMain.Panel2.Controls.Add(Me._splViewerList)
      Me._splMain.Size = New System.Drawing.Size(1197, 721)
      Me._splMain.SplitterDistance = 484
      Me._splMain.TabIndex = 3
      Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
      Me.splitContainer1.Name = "splitContainer1"
      Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
      Me.splitContainer1.Panel1.Controls.Add(Me.dGV_Results)
      Me.splitContainer1.Panel2Collapsed = True
      Me.splitContainer1.Size = New System.Drawing.Size(480, 717)
      Me.splitContainer1.SplitterDistance = 358
      Me.splitContainer1.TabIndex = 1
      Me.dGV_Results.AllowUserToAddRows = False
      Me.dGV_Results.AllowUserToDeleteRows = False
      Me.dGV_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dGV_Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._Field, Me._result, Me._confidence})
      Me.dGV_Results.Dock = System.Windows.Forms.DockStyle.Fill
      Me.dGV_Results.Location = New System.Drawing.Point(0, 0)
      Me.dGV_Results.MultiSelect = False
      Me.dGV_Results.Name = "dGV_Results"
      Me.dGV_Results.[ReadOnly] = True
      Me.dGV_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dGV_Results.Size = New System.Drawing.Size(480, 717)
      Me.dGV_Results.TabIndex = 0
      Me._Field.FillWeight = 70.0F
      Me._Field.Frozen = True
      Me._Field.HeaderText = "Field"
      Me._Field.Name = "_Field"
      Me._Field.[ReadOnly] = True
      Me._Field.Width = 80
      Me._result.FillWeight = 70.0F
      Me._result.Frozen = True
      Me._result.HeaderText = "Result"
      Me._result.Name = "_result"
      Me._result.[ReadOnly] = True
      Me._result.Width = 150
      Me._confidence.FillWeight = 70.0F
      Me._confidence.HeaderText = "Confidence"
      Me._confidence.Name = "_confidence"
      Me._confidence.[ReadOnly] = True
      Me._confidence.Width = 150
      Me._splViewerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me._splViewerList.Dock = System.Windows.Forms.DockStyle.Fill
      Me._splViewerList.Location = New System.Drawing.Point(0, 0)
      Me._splViewerList.Name = "_splViewerList"
      Me._splViewerList.Orientation = System.Windows.Forms.Orientation.Horizontal
      Me._splViewerList.Panel1.Controls.Add(Me.rasterImageViewer1)
      Me._splViewerList.Panel1.Controls.Add(Me._tsViewer)
      Me._splViewerList.Panel2Collapsed = True
      Me._splViewerList.Size = New System.Drawing.Size(709, 721)
      Me._splViewerList.SplitterDistance = 443
      Me._splViewerList.TabIndex = 0
      Me.rasterImageViewer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.rasterImageViewer1.ImageHorizontalAlignment = ControlAlignment.Near
      Me.rasterImageViewer1.ImageVerticalAlignment = ControlAlignment.Near
      Me.rasterImageViewer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
      Me.rasterImageViewer1.IsSyncSource = True
      Me.rasterImageViewer1.IsSyncTarget = True
      Me.rasterImageViewer1.ItemPadding = New System.Windows.Forms.Padding(1)
      Me.rasterImageViewer1.Location = New System.Drawing.Point(0, 53)
      Me.rasterImageViewer1.Name = "rasterImageViewer1"
      Me.rasterImageViewer1.Size = New System.Drawing.Size(424, 411)
      Me.rasterImageViewer1.TabIndex = 5
      Me.rasterImageViewer1.UseDpi = True
      Me._tsViewer.ImageScalingSize = New System.Drawing.Size(20, 20)
      Me._tsViewer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._btnPanTool, Me.toolStripSeparator7, Me._btnZoomNormal, Me._btnFit, Me._btnFitWidth, Me._btnRetry, Me._btnRotateLeft, Me._btnRotateRight, Me._btnZoomIn, Me._btnZoomOut, Me._btnZoomDrawTool, Me._btnUseDpi, Me.toolStripSeparator2})
      Me._tsViewer.Location = New System.Drawing.Point(0, 0)
      Me._tsViewer.Name = "_tsViewer"
      Me._tsViewer.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me._tsViewer.Size = New System.Drawing.Size(705, 53)
      Me._tsViewer.TabIndex = 4
      Me._tsViewer.Text = "toolStrip2"
      Me._btnPanTool.AutoSize = False
      Me._btnPanTool.CheckOnClick = True
      Me._btnPanTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnPanTool.Image = (CType((resources.GetObject("_btnPanTool.Image")), System.Drawing.Image))
      Me._btnPanTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnPanTool.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnPanTool.Name = "_btnPanTool"
      Me._btnPanTool.Size = New System.Drawing.Size(50, 50)
      Me._btnPanTool.Text = "Pan"
      Me.toolStripSeparator7.Name = "toolStripSeparator7"
      Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 53)
      Me._btnZoomNormal.AutoSize = False
      Me._btnZoomNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnZoomNormal.Image = (CType((resources.GetObject("_btnZoomNormal.Image")), System.Drawing.Image))
      Me._btnZoomNormal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnZoomNormal.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnZoomNormal.Name = "_btnZoomNormal"
      Me._btnZoomNormal.Size = New System.Drawing.Size(50, 50)
      Me._btnZoomNormal.Text = "Normal"
      Me._btnFit.AutoSize = False
      Me._btnFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnFit.Image = (CType((resources.GetObject("_btnFit.Image")), System.Drawing.Image))
      Me._btnFit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnFit.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnFit.Name = "_btnFit"
      Me._btnFit.Size = New System.Drawing.Size(50, 50)
      Me._btnFit.Text = "Fit To Window"
      Me._btnFitWidth.AutoSize = False
      Me._btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnFitWidth.Image = (CType((resources.GetObject("_btnFitWidth.Image")), System.Drawing.Image))
      Me._btnFitWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnFitWidth.Name = "_btnFitWidth"
      Me._btnFitWidth.Size = New System.Drawing.Size(50, 50)
      Me._btnFitWidth.Text = "Fit To Image Width"
      Me._btnRetry.AutoSize = False
      Me._btnRetry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnRetry.Image = (CType((resources.GetObject("_btnRetry.Image")), System.Drawing.Image))
      Me._btnRetry.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnRetry.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnRetry.Name = "_btnRetry"
      Me._btnRetry.Size = New System.Drawing.Size(50, 50)
      Me._btnRetry.Text = "Retry"
      Me._btnRotateLeft.AutoSize = False
      Me._btnRotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnRotateLeft.Image = (CType((resources.GetObject("_btnRotateLeft.Image")), System.Drawing.Image))
      Me._btnRotateLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnRotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnRotateLeft.Name = "_btnRotateLeft"
      Me._btnRotateLeft.Size = New System.Drawing.Size(50, 50)
      Me._btnRotateLeft.Text = "Rotate Left"
      Me._btnRotateRight.AutoSize = False
      Me._btnRotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnRotateRight.Image = (CType((resources.GetObject("_btnRotateRight.Image")), System.Drawing.Image))
      Me._btnRotateRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnRotateRight.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnRotateRight.Name = "_btnRotateRight"
      Me._btnRotateRight.Size = New System.Drawing.Size(50, 50)
      Me._btnRotateRight.Text = "Rotate Right"
      Me._btnZoomIn.AutoSize = False
      Me._btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnZoomIn.Image = (CType((resources.GetObject("_btnZoomIn.Image")), System.Drawing.Image))
      Me._btnZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnZoomIn.Name = "_btnZoomIn"
      Me._btnZoomIn.Size = New System.Drawing.Size(50, 50)
      Me._btnZoomIn.Text = "Zoom In"
      Me._btnZoomOut.AutoSize = False
      Me._btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnZoomOut.Image = (CType((resources.GetObject("_btnZoomOut.Image")), System.Drawing.Image))
      Me._btnZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnZoomOut.Name = "_btnZoomOut"
      Me._btnZoomOut.Size = New System.Drawing.Size(50, 50)
      Me._btnZoomOut.Text = "Zoom Out"
      Me._btnZoomDrawTool.AutoSize = False
      Me._btnZoomDrawTool.CheckOnClick = True
      Me._btnZoomDrawTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnZoomDrawTool.Image = (CType((resources.GetObject("_btnZoomDrawTool.Image")), System.Drawing.Image))
      Me._btnZoomDrawTool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnZoomDrawTool.ImageTransparentColor = System.Drawing.Color.Magenta
      Me._btnZoomDrawTool.Name = "_btnZoomDrawTool"
      Me._btnZoomDrawTool.Size = New System.Drawing.Size(50, 50)
      Me._btnZoomDrawTool.Text = "Zoom To Selection"
      Me._btnUseDpi.AutoSize = False
      Me._btnUseDpi.Checked = True
      Me._btnUseDpi.CheckOnClick = True
      Me._btnUseDpi.CheckState = System.Windows.Forms.CheckState.Checked
      Me._btnUseDpi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me._btnUseDpi.Image = (CType((resources.GetObject("_btnUseDpi.Image")), System.Drawing.Image))
      Me._btnUseDpi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me._btnUseDpi.ImageTransparentColor = System.Drawing.Color.Black
      Me._btnUseDpi.Margin = New System.Windows.Forms.Padding(0)
      Me._btnUseDpi.Name = "_btnUseDpi"
      Me._btnUseDpi.Size = New System.Drawing.Size(50, 50)
      Me._btnUseDpi.Text = "toolStripButton1"
      Me._btnUseDpi.ToolTipText = "Ignore Image DPI When Viewing"
      Me.toolStripSeparator2.Name = "toolStripSeparator2"
      Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 53)
      Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.helpToolStripMenuItem})
      Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.menuStrip1.Name = "menuStrip1"
      Me.menuStrip1.Size = New System.Drawing.Size(1197, 24)
      Me.menuStrip1.TabIndex = 4
      Me.menuStrip1.Text = "menuStrip1"
      Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.scanImageToolStripMenuItem, Me.closeToolStripMenuItem, Me.toolStripMenuItem1, Me.exitToolStripMenuItem})
      Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
      Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.fileToolStripMenuItem.Text = "File"
      Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
      Me.openToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
      Me.openToolStripMenuItem.Text = "Open"
      Me.scanImageToolStripMenuItem.Name = "scanImageToolStripMenuItem"
      Me.scanImageToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
      Me.scanImageToolStripMenuItem.Text = "Scan Page"
      Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
      Me.closeToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
      Me.closeToolStripMenuItem.Text = "Close"
      Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
      Me.toolStripMenuItem1.Size = New System.Drawing.Size(125, 6)
      Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
      Me.exitToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
      Me.exitToolStripMenuItem.Text = "Exit"
      Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem})
      Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
      Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
      Me.helpToolStripMenuItem.Text = "Help"
      Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
      Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
      Me.aboutToolStripMenuItem.Text = "About"
      Me._menuItemHowTo.Name = "_menuItemHowTo"
      Me._menuItemHowTo.Size = New System.Drawing.Size(32, 19)
      Me._menuItemAbout.Name = "_menuItemAbout"
      Me._menuItemAbout.Size = New System.Drawing.Size(32, 19)
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1197, 745)
      Me.Controls.Add(Me._splMain)
      Me.Controls.Add(Me.menuStrip1)
      Me.Icon = (CType((resources.GetObject("$this.Icon")), System.Drawing.Icon))
      Me.MainMenuStrip = Me.menuStrip1
      Me.Name = "MainForm"
      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
      Me.Text = "LEADTOOLS Business Card Reader Demo"
      Me._splMain.Panel1.ResumeLayout(False)
      Me._splMain.Panel2.ResumeLayout(False)
      CType((Me._splMain), System.ComponentModel.ISupportInitialize).EndInit()
      Me._splMain.ResumeLayout(False)
      Me.splitContainer1.Panel1.ResumeLayout(False)
      CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).EndInit()
      Me.splitContainer1.ResumeLayout(False)
      CType((Me.dGV_Results), System.ComponentModel.ISupportInitialize).EndInit()
      Me._splViewerList.Panel1.ResumeLayout(False)
      Me._splViewerList.Panel1.PerformLayout()
      CType((Me._splViewerList), System.ComponentModel.ISupportInitialize).EndInit()
      Me._splViewerList.ResumeLayout(False)
      Me._tsViewer.ResumeLayout(False)
      Me._tsViewer.PerformLayout()
      Me.menuStrip1.ResumeLayout(False)
      Me.menuStrip1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()
   End Sub

   Private _splMain As System.Windows.Forms.SplitContainer
   Private _splViewerList As System.Windows.Forms.SplitContainer
   Private menuStrip1 As System.Windows.Forms.MenuStrip
   Private _menuItemHowTo As System.Windows.Forms.ToolStripMenuItem
   Private _menuItemAbout As System.Windows.Forms.ToolStripMenuItem
   Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents dGV_Results As System.Windows.Forms.DataGridView
   Private _tsViewer As System.Windows.Forms.ToolStrip
   Private WithEvents _btnZoomNormal As System.Windows.Forms.ToolStripButton
   Private WithEvents _btnFit As System.Windows.Forms.ToolStripButton
   Private WithEvents _btnFitWidth As System.Windows.Forms.ToolStripButton
   Private WithEvents _btnZoomIn As System.Windows.Forms.ToolStripButton
   Private WithEvents _btnZoomOut As System.Windows.Forms.ToolStripButton
   Private WithEvents _btnZoomDrawTool As System.Windows.Forms.ToolStripButton
   Private WithEvents _btnUseDpi As System.Windows.Forms.ToolStripButton
   Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Private WithEvents _btnPanTool As System.Windows.Forms.ToolStripButton
   Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
   Private rasterImageViewer1 As ImageViewer
   Private WithEvents closeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private splitContainer1 As System.Windows.Forms.SplitContainer
   Private WithEvents scanImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents _btnRetry As System.Windows.Forms.ToolStripButton
   Private WithEvents _btnRotateRight As System.Windows.Forms.ToolStripButton
   Private WithEvents _btnRotateLeft As System.Windows.Forms.ToolStripButton
   Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
   Private _Field As System.Windows.Forms.DataGridViewTextBoxColumn
   Private _result As System.Windows.Forms.DataGridViewTextBoxColumn
   Private _confidence As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
