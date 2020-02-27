Namespace MedicalViewerDemo
   Partial Class ViewerPropertiesDialog
      ''' <summary>
      ''' Required designer variable.
      ''' </summary>
      Private components As System.ComponentModel.IContainer = Nothing

      ''' <summary>
      ''' Clean up any resources being used.
      ''' </summary>
      ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      Protected Overrides Sub Dispose(ByVal disposing As Boolean)
         If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
         End If
         MyBase.Dispose(disposing)
      End Sub

#Region "Windows Form Designer generated code"

      ''' <summary>
      ''' Required method for Designer support - do not modify
      ''' the contents of this method with the code editor.
      ''' </summary>
      Private Sub InitializeComponent()
         Me._tabViewer = New System.Windows.Forms.TabControl()
         Me._tabGeneral = New System.Windows.Forms.TabPage()
         Me._chkShowCellScroll = New System.Windows.Forms.CheckBox()
         Me._chkMaintainSize = New System.Windows.Forms.CheckBox()
         Me._chkShowViewerScroll = New System.Windows.Forms.CheckBox()
         Me._chkShowFreeze = New System.Windows.Forms.CheckBox()
         Me._chkUseExtraSplitters = New System.Windows.Forms.CheckBox()
         Me.label6 = New System.Windows.Forms.Label()
         Me.label7 = New System.Windows.Forms.Label()
         Me.label8 = New System.Windows.Forms.Label()
         Me.label5 = New System.Windows.Forms.Label()
         Me.label4 = New System.Windows.Forms.Label()
         Me.label3 = New System.Windows.Forms.Label()
         Me._cmbMeasurmentUnit = New System.Windows.Forms.ComboBox()
         Me._cmbBorderStyle = New System.Windows.Forms.ComboBox()
         Me._cmbTextQuality = New System.Windows.Forms.ComboBox()
         Me._cmbPaintMethod = New System.Windows.Forms.ComboBox()
         Me._cmbSplitterType = New System.Windows.Forms.ComboBox()
         Me._cmbRuler = New System.Windows.Forms.ComboBox()
         Me._chkModifyRowsColumns = New System.Windows.Forms.CheckBox()
         Me._lblColumns = New System.Windows.Forms.Label()
         Me._lblRows = New System.Windows.Forms.Label()
         Me._txtColumns = New MedicalViewerDemo.NumericTextBox()
         Me._txtRows = New MedicalViewerDemo.NumericTextBox()
         Me._tabColors = New System.Windows.Forms.TabPage()
         Me._chkCustomSplitterColor = New System.Windows.Forms.CheckBox()
         Me._lblSplitterColor = New MedicalViewerDemo.ColorBox()
         Me._btnSplitterColor = New System.Windows.Forms.Button()
         Me._lblNonActiveBorderColor = New MedicalViewerDemo.ColorBox()
         Me._btnNonActiveBorderColor = New System.Windows.Forms.Button()
         Me._lblRulerOutColor = New MedicalViewerDemo.ColorBox()
         Me._btnRulerOutColor = New System.Windows.Forms.Button()
         Me._lblRulerInColor = New MedicalViewerDemo.ColorBox()
         Me._btnRulerInColor = New System.Windows.Forms.Button()
         Me._lblBackgroundColor = New MedicalViewerDemo.ColorBox()
         Me._btnBackgroundColor = New System.Windows.Forms.Button()
         Me._lblActiveSubcellColor = New MedicalViewerDemo.ColorBox()
         Me._btnActiveSubcellColor = New System.Windows.Forms.Button()
         Me._lblActiveBorderColor = New MedicalViewerDemo.ColorBox()
         Me._btnActiveBorderColor = New System.Windows.Forms.Button()
         Me._lblShadowColor = New MedicalViewerDemo.ColorBox()
         Me._btnShadowColor = New System.Windows.Forms.Button()
         Me._lblText = New MedicalViewerDemo.ColorBox()
         Me._btnText = New System.Windows.Forms.Button()
         Me._lblEmptyCellBackColor = New MedicalViewerDemo.ColorBox()
         Me._btnEmptyCellBackColor = New System.Windows.Forms.Button()
         Me._tabCursor = New System.Windows.Forms.TabPage()
         Me.label24 = New System.Windows.Forms.Label()
         Me.label21 = New System.Windows.Forms.Label()
         Me.label20 = New System.Windows.Forms.Label()
         Me.label19 = New System.Windows.Forms.Label()
         Me._btnVerticalCursor = New MedicalViewerDemo.CursorButton()
         Me._btnBothCursor = New MedicalViewerDemo.CursorButton()
         Me._btnHorizontalCursor = New MedicalViewerDemo.CursorButton()
         Me._btnDefaultCursor = New MedicalViewerDemo.CursorButton()
         Me._tabTitlebar = New System.Windows.Forms.TabPage()
         Me._chkReadOnly1 = New System.Windows.Forms.CheckBox()
         Me._chkReadOnly2 = New System.Windows.Forms.CheckBox()
         Me._chkReadOnly3 = New System.Windows.Forms.CheckBox()
         Me._chkReadOnly4 = New System.Windows.Forms.CheckBox()
         Me._chkReadOnly5 = New System.Windows.Forms.CheckBox()
         Me._chkReadOnly6 = New System.Windows.Forms.CheckBox()
         Me._chkReadOnly7 = New System.Windows.Forms.CheckBox()
         Me._chkReadOnly8 = New System.Windows.Forms.CheckBox()
         Me._lblColorHover1 = New MedicalViewerDemo.ColorBox()
         Me._lblColorHover2 = New MedicalViewerDemo.ColorBox()
         Me._lblColorHover3 = New MedicalViewerDemo.ColorBox()
         Me._lblColorHover4 = New MedicalViewerDemo.ColorBox()
         Me._lblColorHover5 = New MedicalViewerDemo.ColorBox()
         Me._lblColorHover6 = New MedicalViewerDemo.ColorBox()
         Me._lblColorHover7 = New MedicalViewerDemo.ColorBox()
         Me._lblColorHover8 = New MedicalViewerDemo.ColorBox()
         Me._lblColorPressed1 = New MedicalViewerDemo.ColorBox()
         Me._lblColorPressed2 = New MedicalViewerDemo.ColorBox()
         Me._lblColorPressed3 = New MedicalViewerDemo.ColorBox()
         Me._lblColorPressed4 = New MedicalViewerDemo.ColorBox()
         Me._lblColorPressed5 = New MedicalViewerDemo.ColorBox()
         Me._lblColorPressed6 = New MedicalViewerDemo.ColorBox()
         Me._lblColorPressed7 = New MedicalViewerDemo.ColorBox()
         Me._lblColorPressed8 = New MedicalViewerDemo.ColorBox()
         Me._chkShowIcon1 = New System.Windows.Forms.CheckBox()
         Me._chkShowIcon2 = New System.Windows.Forms.CheckBox()
         Me._chkShowIcon3 = New System.Windows.Forms.CheckBox()
         Me._chkShowIcon4 = New System.Windows.Forms.CheckBox()
         Me._chkShowIcon5 = New System.Windows.Forms.CheckBox()
         Me._chkShowIcon6 = New System.Windows.Forms.CheckBox()
         Me._chkShowIcon7 = New System.Windows.Forms.CheckBox()
         Me._chkShowIcon8 = New System.Windows.Forms.CheckBox()
         Me._lblColor1 = New MedicalViewerDemo.ColorBox()
         Me._lblColor2 = New MedicalViewerDemo.ColorBox()
         Me._lblColor3 = New MedicalViewerDemo.ColorBox()
         Me._lblColor4 = New MedicalViewerDemo.ColorBox()
         Me._lblColor5 = New MedicalViewerDemo.ColorBox()
         Me._lblColor6 = New MedicalViewerDemo.ColorBox()
         Me._lblColor7 = New MedicalViewerDemo.ColorBox()
         Me._lblColor8 = New MedicalViewerDemo.ColorBox()
         Me.label56 = New System.Windows.Forms.Label()
         Me.label55 = New System.Windows.Forms.Label()
         Me.label54 = New System.Windows.Forms.Label()
         Me.label53 = New System.Windows.Forms.Label()
         Me.label52 = New System.Windows.Forms.Label()
         Me._lblTitlebarColor = New MedicalViewerDemo.ColorBox()
         Me._btnTitlebarColor = New System.Windows.Forms.Button()
         Me._chkCustomTitlebarColor = New System.Windows.Forms.CheckBox()
         Me._chkShowTitlebar = New System.Windows.Forms.CheckBox()
         Me._btnApply = New System.Windows.Forms.Button()
         Me._btnCancel = New System.Windows.Forms.Button()
         Me._btnOK = New System.Windows.Forms.Button()
         Me._btnReset = New System.Windows.Forms.Button()
         Me._tabViewer.SuspendLayout()
         Me._tabGeneral.SuspendLayout()
         Me._tabColors.SuspendLayout()
         Me._tabCursor.SuspendLayout()
         Me._tabTitlebar.SuspendLayout()
         Me.SuspendLayout()
         ' 
         ' _tabViewer
         ' 
         Me._tabViewer.Controls.Add(Me._tabGeneral)
         Me._tabViewer.Controls.Add(Me._tabColors)
         Me._tabViewer.Controls.Add(Me._tabCursor)
         Me._tabViewer.Controls.Add(Me._tabTitlebar)
         Me._tabViewer.Location = New System.Drawing.Point(9, 9)
         Me._tabViewer.Name = "_tabViewer"
         Me._tabViewer.SelectedIndex = 0
         Me._tabViewer.Size = New System.Drawing.Size(353, 272)
         Me._tabViewer.TabIndex = 0
         ' 
         ' _tabGeneral
         ' 
         Me._tabGeneral.Controls.Add(Me._chkShowCellScroll)
         Me._tabGeneral.Controls.Add(Me._chkMaintainSize)
         Me._tabGeneral.Controls.Add(Me._chkShowViewerScroll)
         Me._tabGeneral.Controls.Add(Me._chkShowFreeze)
         Me._tabGeneral.Controls.Add(Me._chkUseExtraSplitters)
         Me._tabGeneral.Controls.Add(Me.label6)
         Me._tabGeneral.Controls.Add(Me.label7)
         Me._tabGeneral.Controls.Add(Me.label8)
         Me._tabGeneral.Controls.Add(Me.label5)
         Me._tabGeneral.Controls.Add(Me.label4)
         Me._tabGeneral.Controls.Add(Me.label3)
         Me._tabGeneral.Controls.Add(Me._cmbMeasurmentUnit)
         Me._tabGeneral.Controls.Add(Me._cmbBorderStyle)
         Me._tabGeneral.Controls.Add(Me._cmbTextQuality)
         Me._tabGeneral.Controls.Add(Me._cmbPaintMethod)
         Me._tabGeneral.Controls.Add(Me._cmbSplitterType)
         Me._tabGeneral.Controls.Add(Me._cmbRuler)
         Me._tabGeneral.Controls.Add(Me._chkModifyRowsColumns)
         Me._tabGeneral.Controls.Add(Me._lblColumns)
         Me._tabGeneral.Controls.Add(Me._lblRows)
         Me._tabGeneral.Controls.Add(Me._txtColumns)
         Me._tabGeneral.Controls.Add(Me._txtRows)
         Me._tabGeneral.Location = New System.Drawing.Point(4, 22)
         Me._tabGeneral.Name = "_tabGeneral"
         Me._tabGeneral.Padding = New System.Windows.Forms.Padding(3)
         Me._tabGeneral.Size = New System.Drawing.Size(345, 246)
         Me._tabGeneral.TabIndex = 0
         Me._tabGeneral.Text = "General"
         Me._tabGeneral.UseVisualStyleBackColor = True
         ' 
         ' _chkShowCellScroll
         ' 
         Me._chkShowCellScroll.AutoSize = True
         Me._chkShowCellScroll.Location = New System.Drawing.Point(128, 220)
         Me._chkShowCellScroll.Name = "_chkShowCellScroll"
         Me._chkShowCellScroll.Size = New System.Drawing.Size(99, 17)
         Me._chkShowCellScroll.TabIndex = 43
         Me._chkShowCellScroll.Text = "Sho&w cell scroll"
         Me._chkShowCellScroll.UseVisualStyleBackColor = True
         ' 
         ' _chkMaintainSize
         ' 
         Me._chkMaintainSize.AutoSize = True
         Me._chkMaintainSize.Location = New System.Drawing.Point(189, 195)
         Me._chkMaintainSize.Name = "_chkMaintainSize"
         Me._chkMaintainSize.Size = New System.Drawing.Size(87, 17)
         Me._chkMaintainSize.TabIndex = 42
         Me._chkMaintainSize.Text = "&Maintain size"
         Me._chkMaintainSize.UseVisualStyleBackColor = True
         ' 
         ' _chkShowViewerScroll
         ' 
         Me._chkShowViewerScroll.AutoSize = True
         Me._chkShowViewerScroll.Location = New System.Drawing.Point(50, 195)
         Me._chkShowViewerScroll.Name = "_chkShowViewerScroll"
         Me._chkShowViewerScroll.Size = New System.Drawing.Size(114, 17)
         Me._chkShowViewerScroll.TabIndex = 41
         Me._chkShowViewerScroll.Text = "Show &viewer scroll"
         Me._chkShowViewerScroll.UseVisualStyleBackColor = True
         ' 
         ' _chkShowFreeze
         ' 
         Me._chkShowFreeze.AutoSize = True
         Me._chkShowFreeze.Location = New System.Drawing.Point(189, 168)
         Me._chkShowFreeze.Name = "_chkShowFreeze"
         Me._chkShowFreeze.Size = New System.Drawing.Size(105, 17)
         Me._chkShowFreeze.TabIndex = 40
         Me._chkShowFreeze.Text = "Show free&ze text"
         Me._chkShowFreeze.UseVisualStyleBackColor = True
         ' 
         ' _chkUseExtraSplitters
         ' 
         Me._chkUseExtraSplitters.AutoSize = True
         Me._chkUseExtraSplitters.Location = New System.Drawing.Point(50, 168)
         Me._chkUseExtraSplitters.Name = "_chkUseExtraSplitters"
         Me._chkUseExtraSplitters.Size = New System.Drawing.Size(109, 17)
         Me._chkUseExtraSplitters.TabIndex = 39
         Me._chkUseExtraSplitters.Text = "Use e&xtra splitters"
         Me._chkUseExtraSplitters.UseVisualStyleBackColor = True
         ' 
         ' label6
         ' 
         Me.label6.AutoSize = True
         Me.label6.Location = New System.Drawing.Point(183, 138)
         Me.label6.Name = "label6"
         Me.label6.Size = New System.Drawing.Size(58, 13)
         Me.label6.TabIndex = 38
         Me.label6.Text = "Meas. &Unit"
         ' 
         ' label7
         ' 
         Me.label7.AutoSize = True
         Me.label7.Location = New System.Drawing.Point(183, 99)
         Me.label7.Name = "label7"
         Me.label7.Size = New System.Drawing.Size(62, 13)
         Me.label7.TabIndex = 37
         Me.label7.Text = "&Border style"
         ' 
         ' label8
         ' 
         Me.label8.AutoSize = True
         Me.label8.Location = New System.Drawing.Point(183, 61)
         Me.label8.Name = "label8"
         Me.label8.Size = New System.Drawing.Size(61, 13)
         Me.label8.TabIndex = 36
         Me.label8.Text = "&Text quality"
         ' 
         ' label5
         ' 
         Me.label5.AutoSize = True
         Me.label5.Location = New System.Drawing.Point(5, 139)
         Me.label5.Name = "label5"
         Me.label5.Size = New System.Drawing.Size(69, 13)
         Me.label5.TabIndex = 35
         Me.label5.Text = "&Paint method"
         ' 
         ' label4
         ' 
         Me.label4.AutoSize = True
         Me.label4.Location = New System.Drawing.Point(7, 101)
         Me.label4.Name = "label4"
         Me.label4.Size = New System.Drawing.Size(62, 13)
         Me.label4.TabIndex = 34
         Me.label4.Text = "&Splitter type"
         ' 
         ' label3
         ' 
         Me.label3.AutoSize = True
         Me.label3.Location = New System.Drawing.Point(10, 62)
         Me.label3.Name = "label3"
         Me.label3.Size = New System.Drawing.Size(56, 13)
         Me.label3.TabIndex = 33
         Me.label3.Text = "Ruler s&ytle"
         ' 
         ' _cmbMeasurmentUnit
         ' 
         Me._cmbMeasurmentUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbMeasurmentUnit.FormattingEnabled = True
         Me._cmbMeasurmentUnit.Items.AddRange(New Object() {"Inches", "Feet", "Micrometers", "Millimeters", "Centimeters", "Meters"})
         Me._cmbMeasurmentUnit.Location = New System.Drawing.Point(246, 134)
         Me._cmbMeasurmentUnit.Name = "_cmbMeasurmentUnit"
         Me._cmbMeasurmentUnit.Size = New System.Drawing.Size(93, 21)
         Me._cmbMeasurmentUnit.TabIndex = 32
         ' 
         ' _cmbBorderStyle
         ' 
         Me._cmbBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbBorderStyle.FormattingEnabled = True
         Me._cmbBorderStyle.Items.AddRange(New Object() {"Solid", "Dashed", "Dotted", "Dash-Dot", "Dash-Dot-Dot"})
         Me._cmbBorderStyle.Location = New System.Drawing.Point(246, 95)
         Me._cmbBorderStyle.Name = "_cmbBorderStyle"
         Me._cmbBorderStyle.Size = New System.Drawing.Size(93, 21)
         Me._cmbBorderStyle.TabIndex = 31
         ' 
         ' _cmbTextQuality
         ' 
         Me._cmbTextQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbTextQuality.FormattingEnabled = True
         Me._cmbTextQuality.Items.AddRange(New Object() {"Default", "Draft", "Proof", "Force draft", "Force Anti-Alias"})
         Me._cmbTextQuality.Location = New System.Drawing.Point(246, 57)
         Me._cmbTextQuality.Name = "_cmbTextQuality"
         Me._cmbTextQuality.Size = New System.Drawing.Size(93, 21)
         Me._cmbTextQuality.TabIndex = 30
         ' 
         ' _cmbPaintMethod
         ' 
         Me._cmbPaintMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbPaintMethod.FormattingEnabled = True
         Me._cmbPaintMethod.Items.AddRange(New Object() {"Normal", "Resample", "Bicubic"})
         Me._cmbPaintMethod.Location = New System.Drawing.Point(78, 135)
         Me._cmbPaintMethod.Name = "_cmbPaintMethod"
         Me._cmbPaintMethod.Size = New System.Drawing.Size(91, 21)
         Me._cmbPaintMethod.TabIndex = 29
         ' 
         ' _cmbSplitterType
         ' 
         Me._cmbSplitterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbSplitterType.FormattingEnabled = True
         Me._cmbSplitterType.Items.AddRange(New Object() {"None", "Thin", "Thick"})
         Me._cmbSplitterType.Location = New System.Drawing.Point(78, 96)
         Me._cmbSplitterType.Name = "_cmbSplitterType"
         Me._cmbSplitterType.Size = New System.Drawing.Size(91, 21)
         Me._cmbSplitterType.TabIndex = 28
         ' 
         ' _cmbRuler
         ' 
         Me._cmbRuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbRuler.FormattingEnabled = True
         Me._cmbRuler.Items.AddRange(New Object() {"Inverted", "Bordered"})
         Me._cmbRuler.Location = New System.Drawing.Point(78, 58)
         Me._cmbRuler.Name = "_cmbRuler"
         Me._cmbRuler.Size = New System.Drawing.Size(91, 21)
         Me._cmbRuler.TabIndex = 27
         ' 
         ' _chkModifyRowsColumns
         ' 
         Me._chkModifyRowsColumns.Checked = True
         Me._chkModifyRowsColumns.CheckState = System.Windows.Forms.CheckState.Checked
         Me._chkModifyRowsColumns.Location = New System.Drawing.Point(200, 9)
         Me._chkModifyRowsColumns.Name = "_chkModifyRowsColumns"
         Me._chkModifyRowsColumns.Size = New System.Drawing.Size(137, 32)
         Me._chkModifyRowsColumns.TabIndex = 26
         Me._chkModifyRowsColumns.Text = "Modi&fy Row/Columns"
         Me._chkModifyRowsColumns.UseVisualStyleBackColor = True
         ' 
         ' _lblColumns
         ' 
         Me._lblColumns.AutoSize = True
         Me._lblColumns.Location = New System.Drawing.Point(91, 19)
         Me._lblColumns.Name = "_lblColumns"
         Me._lblColumns.Size = New System.Drawing.Size(47, 13)
         Me._lblColumns.TabIndex = 25
         Me._lblColumns.Text = "&Columns"
         ' 
         ' _lblRows
         ' 
         Me._lblRows.AutoSize = True
         Me._lblRows.Location = New System.Drawing.Point(13, 19)
         Me._lblRows.Name = "_lblRows"
         Me._lblRows.Size = New System.Drawing.Size(34, 13)
         Me._lblRows.TabIndex = 24
         Me._lblRows.Text = "&Rows"
         ' 
         ' _txtColumns
         ' 
         Me._txtColumns.Location = New System.Drawing.Point(142, 15)
         Me._txtColumns.MaximumAllowed = 20
         Me._txtColumns.MinimumAllowed = 1
         Me._txtColumns.Name = "_txtColumns"
         Me._txtColumns.Size = New System.Drawing.Size(36, 20)
         Me._txtColumns.TabIndex = 23
         Me._txtColumns.Text = "1"
         Me._txtColumns.Value = 1
         ' 
         ' _txtRows
         ' 
         Me._txtRows.Location = New System.Drawing.Point(51, 15)
         Me._txtRows.MaximumAllowed = 20
         Me._txtRows.MinimumAllowed = 1
         Me._txtRows.Name = "_txtRows"
         Me._txtRows.Size = New System.Drawing.Size(39, 20)
         Me._txtRows.TabIndex = 22
         Me._txtRows.Text = "1"
         Me._txtRows.Value = 1
         ' 
         ' _tabColors
         ' 
         Me._tabColors.Controls.Add(Me._chkCustomSplitterColor)
         Me._tabColors.Controls.Add(Me._lblSplitterColor)
         Me._tabColors.Controls.Add(Me._btnSplitterColor)
         Me._tabColors.Controls.Add(Me._lblNonActiveBorderColor)
         Me._tabColors.Controls.Add(Me._btnNonActiveBorderColor)
         Me._tabColors.Controls.Add(Me._lblRulerOutColor)
         Me._tabColors.Controls.Add(Me._btnRulerOutColor)
         Me._tabColors.Controls.Add(Me._lblRulerInColor)
         Me._tabColors.Controls.Add(Me._btnRulerInColor)
         Me._tabColors.Controls.Add(Me._lblBackgroundColor)
         Me._tabColors.Controls.Add(Me._btnBackgroundColor)
         Me._tabColors.Controls.Add(Me._lblActiveSubcellColor)
         Me._tabColors.Controls.Add(Me._btnActiveSubcellColor)
         Me._tabColors.Controls.Add(Me._lblActiveBorderColor)
         Me._tabColors.Controls.Add(Me._btnActiveBorderColor)
         Me._tabColors.Controls.Add(Me._lblShadowColor)
         Me._tabColors.Controls.Add(Me._btnShadowColor)
         Me._tabColors.Controls.Add(Me._lblText)
         Me._tabColors.Controls.Add(Me._btnText)
         Me._tabColors.Controls.Add(Me._lblEmptyCellBackColor)
         Me._tabColors.Controls.Add(Me._btnEmptyCellBackColor)
         Me._tabColors.Location = New System.Drawing.Point(4, 22)
         Me._tabColors.Name = "_tabColors"
         Me._tabColors.Padding = New System.Windows.Forms.Padding(3)
         Me._tabColors.Size = New System.Drawing.Size(345, 246)
         Me._tabColors.TabIndex = 1
         Me._tabColors.Text = "Colors"
         Me._tabColors.UseVisualStyleBackColor = True
         ' 
         ' _chkCustomSplitterColor
         ' 
         Me._chkCustomSplitterColor.AutoSize = True
         Me._chkCustomSplitterColor.Location = New System.Drawing.Point(199, 219)
         Me._chkCustomSplitterColor.Name = "_chkCustomSplitterColor"
         Me._chkCustomSplitterColor.Size = New System.Drawing.Size(120, 17)
         Me._chkCustomSplitterColor.TabIndex = 20
         Me._chkCustomSplitterColor.Text = "&Custom splitter color"
         Me._chkCustomSplitterColor.UseVisualStyleBackColor = True
         ' 
         ' _lblSplitterColor
         ' 
         Me._lblSplitterColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblSplitterColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblSplitterColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblSplitterColor.Location = New System.Drawing.Point(266, 178)
         Me._lblSplitterColor.Name = "_lblSplitterColor"
         Me._lblSplitterColor.Size = New System.Drawing.Size(63, 26)
         Me._lblSplitterColor.TabIndex = 19
         ' 
         ' _btnSplitterColor
         ' 
         Me._btnSplitterColor.Location = New System.Drawing.Point(187, 175)
         Me._btnSplitterColor.Name = "_btnSplitterColor"
         Me._btnSplitterColor.Size = New System.Drawing.Size(73, 34)
         Me._btnSplitterColor.TabIndex = 18
         Me._btnSplitterColor.Text = "Splitter"
         Me._btnSplitterColor.UseVisualStyleBackColor = True
         ' 
         ' _lblNonActiveBorderColor
         ' 
         Me._lblNonActiveBorderColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblNonActiveBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblNonActiveBorderColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblNonActiveBorderColor.Location = New System.Drawing.Point(266, 139)
         Me._lblNonActiveBorderColor.Name = "_lblNonActiveBorderColor"
         Me._lblNonActiveBorderColor.Size = New System.Drawing.Size(63, 26)
         Me._lblNonActiveBorderColor.TabIndex = 17
         ' 
         ' _btnNonActiveBorderColor
         ' 
         Me._btnNonActiveBorderColor.Location = New System.Drawing.Point(187, 135)
         Me._btnNonActiveBorderColor.Name = "_btnNonActiveBorderColor"
         Me._btnNonActiveBorderColor.Size = New System.Drawing.Size(73, 34)
         Me._btnNonActiveBorderColor.TabIndex = 16
         Me._btnNonActiveBorderColor.Text = "Non-active border"
         Me._btnNonActiveBorderColor.UseVisualStyleBackColor = True
         ' 
         ' _lblRulerOutColor
         ' 
         Me._lblRulerOutColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblRulerOutColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblRulerOutColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblRulerOutColor.Location = New System.Drawing.Point(266, 100)
         Me._lblRulerOutColor.Name = "_lblRulerOutColor"
         Me._lblRulerOutColor.Size = New System.Drawing.Size(63, 26)
         Me._lblRulerOutColor.TabIndex = 15
         ' 
         ' _btnRulerOutColor
         ' 
         Me._btnRulerOutColor.Location = New System.Drawing.Point(187, 95)
         Me._btnRulerOutColor.Name = "_btnRulerOutColor"
         Me._btnRulerOutColor.Size = New System.Drawing.Size(73, 34)
         Me._btnRulerOutColor.TabIndex = 14
         Me._btnRulerOutColor.Text = "Ruler &out"
         Me._btnRulerOutColor.UseVisualStyleBackColor = True
         ' 
         ' _lblRulerInColor
         ' 
         Me._lblRulerInColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblRulerInColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblRulerInColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblRulerInColor.Location = New System.Drawing.Point(266, 59)
         Me._lblRulerInColor.Name = "_lblRulerInColor"
         Me._lblRulerInColor.Size = New System.Drawing.Size(63, 26)
         Me._lblRulerInColor.TabIndex = 13
         ' 
         ' _btnRulerInColor
         ' 
         Me._btnRulerInColor.Location = New System.Drawing.Point(187, 55)
         Me._btnRulerInColor.Name = "_btnRulerInColor"
         Me._btnRulerInColor.Size = New System.Drawing.Size(73, 34)
         Me._btnRulerInColor.TabIndex = 12
         Me._btnRulerInColor.Text = "&Ruler in"
         Me._btnRulerInColor.UseVisualStyleBackColor = True
         ' 
         ' _lblBackgroundColor
         ' 
         Me._lblBackgroundColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblBackgroundColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblBackgroundColor.Location = New System.Drawing.Point(266, 19)
         Me._lblBackgroundColor.Name = "_lblBackgroundColor"
         Me._lblBackgroundColor.Size = New System.Drawing.Size(63, 26)
         Me._lblBackgroundColor.TabIndex = 11
         ' 
         ' _btnBackgroundColor
         ' 
         Me._btnBackgroundColor.Location = New System.Drawing.Point(187, 15)
         Me._btnBackgroundColor.Name = "_btnBackgroundColor"
         Me._btnBackgroundColor.Size = New System.Drawing.Size(73, 34)
         Me._btnBackgroundColor.TabIndex = 10
         Me._btnBackgroundColor.Text = "&Background"
         Me._btnBackgroundColor.UseVisualStyleBackColor = True
         ' 
         ' _lblActiveSubcellColor
         ' 
         Me._lblActiveSubcellColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblActiveSubcellColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblActiveSubcellColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblActiveSubcellColor.Location = New System.Drawing.Point(95, 178)
         Me._lblActiveSubcellColor.Name = "_lblActiveSubcellColor"
         Me._lblActiveSubcellColor.Size = New System.Drawing.Size(63, 26)
         Me._lblActiveSubcellColor.TabIndex = 9
         ' 
         ' _btnActiveSubcellColor
         ' 
         Me._btnActiveSubcellColor.Location = New System.Drawing.Point(15, 174)
         Me._btnActiveSubcellColor.Name = "_btnActiveSubcellColor"
         Me._btnActiveSubcellColor.Size = New System.Drawing.Size(73, 34)
         Me._btnActiveSubcellColor.TabIndex = 8
         Me._btnActiveSubcellColor.Text = "Active subcell"
         Me._btnActiveSubcellColor.UseVisualStyleBackColor = True
         ' 
         ' _lblActiveBorderColor
         ' 
         Me._lblActiveBorderColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblActiveBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblActiveBorderColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblActiveBorderColor.Location = New System.Drawing.Point(95, 139)
         Me._lblActiveBorderColor.Name = "_lblActiveBorderColor"
         Me._lblActiveBorderColor.Size = New System.Drawing.Size(63, 26)
         Me._lblActiveBorderColor.TabIndex = 7
         ' 
         ' _btnActiveBorderColor
         ' 
         Me._btnActiveBorderColor.Location = New System.Drawing.Point(15, 134)
         Me._btnActiveBorderColor.Name = "_btnActiveBorderColor"
         Me._btnActiveBorderColor.Size = New System.Drawing.Size(73, 34)
         Me._btnActiveBorderColor.TabIndex = 6
         Me._btnActiveBorderColor.Text = "&Active border"
         Me._btnActiveBorderColor.UseVisualStyleBackColor = True
         ' 
         ' _lblShadowColor
         ' 
         Me._lblShadowColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblShadowColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblShadowColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblShadowColor.Location = New System.Drawing.Point(95, 98)
         Me._lblShadowColor.Name = "_lblShadowColor"
         Me._lblShadowColor.Size = New System.Drawing.Size(63, 26)
         Me._lblShadowColor.TabIndex = 5
         ' 
         ' _btnShadowColor
         ' 
         Me._btnShadowColor.Location = New System.Drawing.Point(15, 94)
         Me._btnShadowColor.Name = "_btnShadowColor"
         Me._btnShadowColor.Size = New System.Drawing.Size(73, 34)
         Me._btnShadowColor.TabIndex = 4
         Me._btnShadowColor.Text = "&Shadow"
         Me._btnShadowColor.UseVisualStyleBackColor = True
         ' 
         ' _lblText
         ' 
         Me._lblText.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblText.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblText.Location = New System.Drawing.Point(95, 58)
         Me._lblText.Name = "_lblText"
         Me._lblText.Size = New System.Drawing.Size(63, 26)
         Me._lblText.TabIndex = 3
         ' 
         ' _btnText
         ' 
         Me._btnText.Location = New System.Drawing.Point(15, 54)
         Me._btnText.Name = "_btnText"
         Me._btnText.Size = New System.Drawing.Size(73, 34)
         Me._btnText.TabIndex = 2
         Me._btnText.Text = "&Text"
         Me._btnText.UseVisualStyleBackColor = True
         ' 
         ' _lblEmptyCellBackColor
         ' 
         Me._lblEmptyCellBackColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblEmptyCellBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblEmptyCellBackColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblEmptyCellBackColor.Location = New System.Drawing.Point(95, 18)
         Me._lblEmptyCellBackColor.Name = "_lblEmptyCellBackColor"
         Me._lblEmptyCellBackColor.Size = New System.Drawing.Size(63, 26)
         Me._lblEmptyCellBackColor.TabIndex = 1
         ' 
         ' _btnEmptyCellBackColor
         ' 
         Me._btnEmptyCellBackColor.Location = New System.Drawing.Point(15, 14)
         Me._btnEmptyCellBackColor.Name = "_btnEmptyCellBackColor"
         Me._btnEmptyCellBackColor.Size = New System.Drawing.Size(73, 34)
         Me._btnEmptyCellBackColor.TabIndex = 0
         Me._btnEmptyCellBackColor.Text = "&Empty cell"
         Me._btnEmptyCellBackColor.UseVisualStyleBackColor = True
         ' 
         ' _tabCursor
         ' 
         Me._tabCursor.Controls.Add(Me.label24)
         Me._tabCursor.Controls.Add(Me.label21)
         Me._tabCursor.Controls.Add(Me.label20)
         Me._tabCursor.Controls.Add(Me.label19)
         Me._tabCursor.Controls.Add(Me._btnVerticalCursor)
         Me._tabCursor.Controls.Add(Me._btnBothCursor)
         Me._tabCursor.Controls.Add(Me._btnHorizontalCursor)
         Me._tabCursor.Controls.Add(Me._btnDefaultCursor)
         Me._tabCursor.Location = New System.Drawing.Point(4, 22)
         Me._tabCursor.Name = "_tabCursor"
         Me._tabCursor.Padding = New System.Windows.Forms.Padding(3)
         Me._tabCursor.Size = New System.Drawing.Size(345, 246)
         Me._tabCursor.TabIndex = 2
         Me._tabCursor.Text = "Cursors"
         Me._tabCursor.UseVisualStyleBackColor = True
         ' 
         ' label24
         ' 
         Me.label24.AutoSize = True
         Me.label24.Location = New System.Drawing.Point(270, 160)
         Me.label24.Name = "label24"
         Me.label24.Size = New System.Drawing.Size(29, 13)
         Me.label24.TabIndex = 13
         Me.label24.Text = "&Both"
         ' 
         ' label21
         ' 
         Me.label21.AutoSize = True
         Me.label21.Location = New System.Drawing.Point(270, 73)
         Me.label21.Name = "label21"
         Me.label21.Size = New System.Drawing.Size(42, 13)
         Me.label21.TabIndex = 10
         Me.label21.Text = "&Vertical"
         ' 
         ' label20
         ' 
         Me.label20.AutoSize = True
         Me.label20.Location = New System.Drawing.Point(110, 160)
         Me.label20.Name = "label20"
         Me.label20.Size = New System.Drawing.Size(54, 13)
         Me.label20.TabIndex = 9
         Me.label20.Text = "&Horizontal"
         ' 
         ' label19
         ' 
         Me.label19.AutoSize = True
         Me.label19.Location = New System.Drawing.Point(110, 73)
         Me.label19.Name = "label19"
         Me.label19.Size = New System.Drawing.Size(41, 13)
         Me.label19.TabIndex = 8
         Me.label19.Text = "&Default"
         ' 
         ' _btnVerticalCursor
         ' 
         Me._btnVerticalCursor.ButtonCursor = Nothing
         Me._btnVerticalCursor.Location = New System.Drawing.Point(191, 60)
         Me._btnVerticalCursor.Name = "_btnVerticalCursor"
         Me._btnVerticalCursor.Size = New System.Drawing.Size(64, 39)
         Me._btnVerticalCursor.TabIndex = 7
         Me._btnVerticalCursor.UseVisualStyleBackColor = True
         ' 
         ' _btnBothCursor
         ' 
         Me._btnBothCursor.ButtonCursor = Nothing
         Me._btnBothCursor.Location = New System.Drawing.Point(191, 147)
         Me._btnBothCursor.Name = "_btnBothCursor"
         Me._btnBothCursor.Size = New System.Drawing.Size(64, 39)
         Me._btnBothCursor.TabIndex = 6
         Me._btnBothCursor.UseVisualStyleBackColor = True
         ' 
         ' _btnHorizontalCursor
         ' 
         Me._btnHorizontalCursor.ButtonCursor = Nothing
         Me._btnHorizontalCursor.Location = New System.Drawing.Point(31, 147)
         Me._btnHorizontalCursor.Name = "_btnHorizontalCursor"
         Me._btnHorizontalCursor.Size = New System.Drawing.Size(64, 39)
         Me._btnHorizontalCursor.TabIndex = 3
         Me._btnHorizontalCursor.UseVisualStyleBackColor = True
         ' 
         ' _btnDefaultCursor
         ' 
         Me._btnDefaultCursor.ButtonCursor = Nothing
         Me._btnDefaultCursor.Location = New System.Drawing.Point(31, 60)
         Me._btnDefaultCursor.Name = "_btnDefaultCursor"
         Me._btnDefaultCursor.Size = New System.Drawing.Size(64, 39)
         Me._btnDefaultCursor.TabIndex = 0
         Me._btnDefaultCursor.UseVisualStyleBackColor = True
         ' 
         ' _tabTitlebar
         ' 
         Me._tabTitlebar.Controls.Add(Me._chkReadOnly1)
         Me._tabTitlebar.Controls.Add(Me._chkReadOnly2)
         Me._tabTitlebar.Controls.Add(Me._chkReadOnly3)
         Me._tabTitlebar.Controls.Add(Me._chkReadOnly4)
         Me._tabTitlebar.Controls.Add(Me._chkReadOnly5)
         Me._tabTitlebar.Controls.Add(Me._chkReadOnly6)
         Me._tabTitlebar.Controls.Add(Me._chkReadOnly7)
         Me._tabTitlebar.Controls.Add(Me._chkReadOnly8)
         Me._tabTitlebar.Controls.Add(Me._lblColorHover1)
         Me._tabTitlebar.Controls.Add(Me._lblColorHover2)
         Me._tabTitlebar.Controls.Add(Me._lblColorHover3)
         Me._tabTitlebar.Controls.Add(Me._lblColorHover4)
         Me._tabTitlebar.Controls.Add(Me._lblColorHover5)
         Me._tabTitlebar.Controls.Add(Me._lblColorHover6)
         Me._tabTitlebar.Controls.Add(Me._lblColorHover7)
         Me._tabTitlebar.Controls.Add(Me._lblColorHover8)
         Me._tabTitlebar.Controls.Add(Me._lblColorPressed1)
         Me._tabTitlebar.Controls.Add(Me._lblColorPressed2)
         Me._tabTitlebar.Controls.Add(Me._lblColorPressed3)
         Me._tabTitlebar.Controls.Add(Me._lblColorPressed4)
         Me._tabTitlebar.Controls.Add(Me._lblColorPressed5)
         Me._tabTitlebar.Controls.Add(Me._lblColorPressed6)
         Me._tabTitlebar.Controls.Add(Me._lblColorPressed7)
         Me._tabTitlebar.Controls.Add(Me._lblColorPressed8)
         Me._tabTitlebar.Controls.Add(Me._chkShowIcon1)
         Me._tabTitlebar.Controls.Add(Me._chkShowIcon2)
         Me._tabTitlebar.Controls.Add(Me._chkShowIcon3)
         Me._tabTitlebar.Controls.Add(Me._chkShowIcon4)
         Me._tabTitlebar.Controls.Add(Me._chkShowIcon5)
         Me._tabTitlebar.Controls.Add(Me._chkShowIcon6)
         Me._tabTitlebar.Controls.Add(Me._chkShowIcon7)
         Me._tabTitlebar.Controls.Add(Me._chkShowIcon8)
         Me._tabTitlebar.Controls.Add(Me._lblColor1)
         Me._tabTitlebar.Controls.Add(Me._lblColor2)
         Me._tabTitlebar.Controls.Add(Me._lblColor3)
         Me._tabTitlebar.Controls.Add(Me._lblColor4)
         Me._tabTitlebar.Controls.Add(Me._lblColor5)
         Me._tabTitlebar.Controls.Add(Me._lblColor6)
         Me._tabTitlebar.Controls.Add(Me._lblColor7)
         Me._tabTitlebar.Controls.Add(Me._lblColor8)
         Me._tabTitlebar.Controls.Add(Me.label56)
         Me._tabTitlebar.Controls.Add(Me.label55)
         Me._tabTitlebar.Controls.Add(Me.label54)
         Me._tabTitlebar.Controls.Add(Me.label53)
         Me._tabTitlebar.Controls.Add(Me.label52)
         Me._tabTitlebar.Controls.Add(Me._lblTitlebarColor)
         Me._tabTitlebar.Controls.Add(Me._btnTitlebarColor)
         Me._tabTitlebar.Controls.Add(Me._chkCustomTitlebarColor)
         Me._tabTitlebar.Controls.Add(Me._chkShowTitlebar)
         Me._tabTitlebar.Location = New System.Drawing.Point(4, 22)
         Me._tabTitlebar.Name = "_tabTitlebar"
         Me._tabTitlebar.Padding = New System.Windows.Forms.Padding(3)
         Me._tabTitlebar.Size = New System.Drawing.Size(345, 246)
         Me._tabTitlebar.TabIndex = 3
         Me._tabTitlebar.Text = "Titlebar"
         Me._tabTitlebar.UseVisualStyleBackColor = True
         ' 
         ' _chkReadOnly1
         ' 
         Me._chkReadOnly1.AutoSize = True
         Me._chkReadOnly1.Location = New System.Drawing.Point(93, 213)
         Me._chkReadOnly1.Name = "_chkReadOnly1"
         Me._chkReadOnly1.Size = New System.Drawing.Size(15, 14)
         Me._chkReadOnly1.TabIndex = 13
         Me._chkReadOnly1.UseVisualStyleBackColor = True
         ' 
         ' _chkReadOnly2
         ' 
         Me._chkReadOnly2.AutoSize = True
         Me._chkReadOnly2.Location = New System.Drawing.Point(123, 213)
         Me._chkReadOnly2.Name = "_chkReadOnly2"
         Me._chkReadOnly2.Size = New System.Drawing.Size(15, 14)
         Me._chkReadOnly2.TabIndex = 18
         Me._chkReadOnly2.UseVisualStyleBackColor = True
         ' 
         ' _chkReadOnly3
         ' 
         Me._chkReadOnly3.AutoSize = True
         Me._chkReadOnly3.Location = New System.Drawing.Point(153, 213)
         Me._chkReadOnly3.Name = "_chkReadOnly3"
         Me._chkReadOnly3.Size = New System.Drawing.Size(15, 14)
         Me._chkReadOnly3.TabIndex = 23
         Me._chkReadOnly3.UseVisualStyleBackColor = True
         ' 
         ' _chkReadOnly4
         ' 
         Me._chkReadOnly4.AutoSize = True
         Me._chkReadOnly4.Location = New System.Drawing.Point(183, 213)
         Me._chkReadOnly4.Name = "_chkReadOnly4"
         Me._chkReadOnly4.Size = New System.Drawing.Size(15, 14)
         Me._chkReadOnly4.TabIndex = 28
         Me._chkReadOnly4.UseVisualStyleBackColor = True
         ' 
         ' _chkReadOnly5
         ' 
         Me._chkReadOnly5.AutoSize = True
         Me._chkReadOnly5.Location = New System.Drawing.Point(215, 213)
         Me._chkReadOnly5.Name = "_chkReadOnly5"
         Me._chkReadOnly5.Size = New System.Drawing.Size(15, 14)
         Me._chkReadOnly5.TabIndex = 33
         Me._chkReadOnly5.UseVisualStyleBackColor = True
         ' 
         ' _chkReadOnly6
         ' 
         Me._chkReadOnly6.AutoSize = True
         Me._chkReadOnly6.Location = New System.Drawing.Point(245, 213)
         Me._chkReadOnly6.Name = "_chkReadOnly6"
         Me._chkReadOnly6.Size = New System.Drawing.Size(15, 14)
         Me._chkReadOnly6.TabIndex = 38
         Me._chkReadOnly6.UseVisualStyleBackColor = True
         ' 
         ' _chkReadOnly7
         ' 
         Me._chkReadOnly7.AutoSize = True
         Me._chkReadOnly7.Location = New System.Drawing.Point(275, 213)
         Me._chkReadOnly7.Name = "_chkReadOnly7"
         Me._chkReadOnly7.Size = New System.Drawing.Size(15, 14)
         Me._chkReadOnly7.TabIndex = 43
         Me._chkReadOnly7.UseVisualStyleBackColor = True
         ' 
         ' _chkReadOnly8
         ' 
         Me._chkReadOnly8.AutoSize = True
         Me._chkReadOnly8.Location = New System.Drawing.Point(305, 213)
         Me._chkReadOnly8.Name = "_chkReadOnly8"
         Me._chkReadOnly8.Size = New System.Drawing.Size(15, 14)
         Me._chkReadOnly8.TabIndex = 48
         Me._chkReadOnly8.UseVisualStyleBackColor = True
         ' 
         ' _lblColorHover1
         ' 
         Me._lblColorHover1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorHover1.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover1.Location = New System.Drawing.Point(87, 183)
         Me._lblColorHover1.Name = "_lblColorHover1"
         Me._lblColorHover1.Size = New System.Drawing.Size(24, 23)
         Me._lblColorHover1.TabIndex = 12
         ' 
         ' _lblColorHover2
         ' 
         Me._lblColorHover2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorHover2.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover2.Location = New System.Drawing.Point(117, 183)
         Me._lblColorHover2.Name = "_lblColorHover2"
         Me._lblColorHover2.Size = New System.Drawing.Size(24, 23)
         Me._lblColorHover2.TabIndex = 17
         ' 
         ' _lblColorHover3
         ' 
         Me._lblColorHover3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorHover3.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover3.Location = New System.Drawing.Point(147, 183)
         Me._lblColorHover3.Name = "_lblColorHover3"
         Me._lblColorHover3.Size = New System.Drawing.Size(24, 23)
         Me._lblColorHover3.TabIndex = 22
         ' 
         ' _lblColorHover4
         ' 
         Me._lblColorHover4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorHover4.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover4.Location = New System.Drawing.Point(177, 183)
         Me._lblColorHover4.Name = "_lblColorHover4"
         Me._lblColorHover4.Size = New System.Drawing.Size(24, 23)
         Me._lblColorHover4.TabIndex = 27
         ' 
         ' _lblColorHover5
         ' 
         Me._lblColorHover5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorHover5.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover5.Location = New System.Drawing.Point(209, 183)
         Me._lblColorHover5.Name = "_lblColorHover5"
         Me._lblColorHover5.Size = New System.Drawing.Size(24, 23)
         Me._lblColorHover5.TabIndex = 32
         ' 
         ' _lblColorHover6
         ' 
         Me._lblColorHover6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorHover6.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover6.Location = New System.Drawing.Point(239, 183)
         Me._lblColorHover6.Name = "_lblColorHover6"
         Me._lblColorHover6.Size = New System.Drawing.Size(24, 23)
         Me._lblColorHover6.TabIndex = 37
         ' 
         ' _lblColorHover7
         ' 
         Me._lblColorHover7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorHover7.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover7.Location = New System.Drawing.Point(269, 183)
         Me._lblColorHover7.Name = "_lblColorHover7"
         Me._lblColorHover7.Size = New System.Drawing.Size(24, 23)
         Me._lblColorHover7.TabIndex = 42
         ' 
         ' _lblColorHover8
         ' 
         Me._lblColorHover8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorHover8.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorHover8.Location = New System.Drawing.Point(299, 183)
         Me._lblColorHover8.Name = "_lblColorHover8"
         Me._lblColorHover8.Size = New System.Drawing.Size(24, 23)
         Me._lblColorHover8.TabIndex = 47
         ' 
         ' _lblColorPressed1
         ' 
         Me._lblColorPressed1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorPressed1.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed1.Location = New System.Drawing.Point(87, 152)
         Me._lblColorPressed1.Name = "_lblColorPressed1"
         Me._lblColorPressed1.Size = New System.Drawing.Size(24, 23)
         Me._lblColorPressed1.TabIndex = 11
         ' 
         ' _lblColorPressed2
         ' 
         Me._lblColorPressed2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorPressed2.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed2.Location = New System.Drawing.Point(117, 152)
         Me._lblColorPressed2.Name = "_lblColorPressed2"
         Me._lblColorPressed2.Size = New System.Drawing.Size(24, 23)
         Me._lblColorPressed2.TabIndex = 16
         ' 
         ' _lblColorPressed3
         ' 
         Me._lblColorPressed3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorPressed3.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed3.Location = New System.Drawing.Point(147, 152)
         Me._lblColorPressed3.Name = "_lblColorPressed3"
         Me._lblColorPressed3.Size = New System.Drawing.Size(24, 23)
         Me._lblColorPressed3.TabIndex = 21
         ' 
         ' _lblColorPressed4
         ' 
         Me._lblColorPressed4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorPressed4.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed4.Location = New System.Drawing.Point(177, 152)
         Me._lblColorPressed4.Name = "_lblColorPressed4"
         Me._lblColorPressed4.Size = New System.Drawing.Size(24, 23)
         Me._lblColorPressed4.TabIndex = 26
         ' 
         ' _lblColorPressed5
         ' 
         Me._lblColorPressed5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorPressed5.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed5.Location = New System.Drawing.Point(209, 152)
         Me._lblColorPressed5.Name = "_lblColorPressed5"
         Me._lblColorPressed5.Size = New System.Drawing.Size(24, 23)
         Me._lblColorPressed5.TabIndex = 31
         ' 
         ' _lblColorPressed6
         ' 
         Me._lblColorPressed6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorPressed6.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed6.Location = New System.Drawing.Point(239, 152)
         Me._lblColorPressed6.Name = "_lblColorPressed6"
         Me._lblColorPressed6.Size = New System.Drawing.Size(24, 23)
         Me._lblColorPressed6.TabIndex = 36
         ' 
         ' _lblColorPressed7
         ' 
         Me._lblColorPressed7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorPressed7.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed7.Location = New System.Drawing.Point(269, 152)
         Me._lblColorPressed7.Name = "_lblColorPressed7"
         Me._lblColorPressed7.Size = New System.Drawing.Size(24, 23)
         Me._lblColorPressed7.TabIndex = 41
         ' 
         ' _lblColorPressed8
         ' 
         Me._lblColorPressed8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColorPressed8.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColorPressed8.Location = New System.Drawing.Point(299, 152)
         Me._lblColorPressed8.Name = "_lblColorPressed8"
         Me._lblColorPressed8.Size = New System.Drawing.Size(24, 23)
         Me._lblColorPressed8.TabIndex = 46
         ' 
         ' _chkShowIcon1
         ' 
         Me._chkShowIcon1.AutoSize = True
         Me._chkShowIcon1.Location = New System.Drawing.Point(93, 96)
         Me._chkShowIcon1.Name = "_chkShowIcon1"
         Me._chkShowIcon1.Size = New System.Drawing.Size(15, 14)
         Me._chkShowIcon1.TabIndex = 9
         Me._chkShowIcon1.UseVisualStyleBackColor = True
         ' 
         ' _chkShowIcon2
         ' 
         Me._chkShowIcon2.AutoSize = True
         Me._chkShowIcon2.Location = New System.Drawing.Point(123, 96)
         Me._chkShowIcon2.Name = "_chkShowIcon2"
         Me._chkShowIcon2.Size = New System.Drawing.Size(15, 14)
         Me._chkShowIcon2.TabIndex = 14
         Me._chkShowIcon2.UseVisualStyleBackColor = True
         ' 
         ' _chkShowIcon3
         ' 
         Me._chkShowIcon3.AutoSize = True
         Me._chkShowIcon3.Location = New System.Drawing.Point(153, 96)
         Me._chkShowIcon3.Name = "_chkShowIcon3"
         Me._chkShowIcon3.Size = New System.Drawing.Size(15, 14)
         Me._chkShowIcon3.TabIndex = 19
         Me._chkShowIcon3.UseVisualStyleBackColor = True
         ' 
         ' _chkShowIcon4
         ' 
         Me._chkShowIcon4.AutoSize = True
         Me._chkShowIcon4.Location = New System.Drawing.Point(183, 96)
         Me._chkShowIcon4.Name = "_chkShowIcon4"
         Me._chkShowIcon4.Size = New System.Drawing.Size(15, 14)
         Me._chkShowIcon4.TabIndex = 24
         Me._chkShowIcon4.UseVisualStyleBackColor = True
         ' 
         ' _chkShowIcon5
         ' 
         Me._chkShowIcon5.AutoSize = True
         Me._chkShowIcon5.Location = New System.Drawing.Point(215, 96)
         Me._chkShowIcon5.Name = "_chkShowIcon5"
         Me._chkShowIcon5.Size = New System.Drawing.Size(15, 14)
         Me._chkShowIcon5.TabIndex = 29
         Me._chkShowIcon5.UseVisualStyleBackColor = True
         ' 
         ' _chkShowIcon6
         ' 
         Me._chkShowIcon6.AutoSize = True
         Me._chkShowIcon6.Location = New System.Drawing.Point(245, 96)
         Me._chkShowIcon6.Name = "_chkShowIcon6"
         Me._chkShowIcon6.Size = New System.Drawing.Size(15, 14)
         Me._chkShowIcon6.TabIndex = 34
         Me._chkShowIcon6.UseVisualStyleBackColor = True
         ' 
         ' _chkShowIcon7
         ' 
         Me._chkShowIcon7.AutoSize = True
         Me._chkShowIcon7.Location = New System.Drawing.Point(275, 96)
         Me._chkShowIcon7.Name = "_chkShowIcon7"
         Me._chkShowIcon7.Size = New System.Drawing.Size(15, 14)
         Me._chkShowIcon7.TabIndex = 39
         Me._chkShowIcon7.UseVisualStyleBackColor = True
         ' 
         ' _chkShowIcon8
         ' 
         Me._chkShowIcon8.AutoSize = True
         Me._chkShowIcon8.Location = New System.Drawing.Point(305, 96)
         Me._chkShowIcon8.Name = "_chkShowIcon8"
         Me._chkShowIcon8.Size = New System.Drawing.Size(15, 14)
         Me._chkShowIcon8.TabIndex = 44
         Me._chkShowIcon8.UseVisualStyleBackColor = True
         ' 
         ' _lblColor1
         ' 
         Me._lblColor1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColor1.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor1.Location = New System.Drawing.Point(87, 119)
         Me._lblColor1.Name = "_lblColor1"
         Me._lblColor1.Size = New System.Drawing.Size(24, 23)
         Me._lblColor1.TabIndex = 10
         ' 
         ' _lblColor2
         ' 
         Me._lblColor2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColor2.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor2.Location = New System.Drawing.Point(117, 119)
         Me._lblColor2.Name = "_lblColor2"
         Me._lblColor2.Size = New System.Drawing.Size(24, 23)
         Me._lblColor2.TabIndex = 15
         ' 
         ' _lblColor3
         ' 
         Me._lblColor3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColor3.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor3.Location = New System.Drawing.Point(147, 119)
         Me._lblColor3.Name = "_lblColor3"
         Me._lblColor3.Size = New System.Drawing.Size(24, 23)
         Me._lblColor3.TabIndex = 20
         ' 
         ' _lblColor4
         ' 
         Me._lblColor4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColor4.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor4.Location = New System.Drawing.Point(177, 119)
         Me._lblColor4.Name = "_lblColor4"
         Me._lblColor4.Size = New System.Drawing.Size(24, 23)
         Me._lblColor4.TabIndex = 25
         ' 
         ' _lblColor5
         ' 
         Me._lblColor5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColor5.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor5.Location = New System.Drawing.Point(209, 119)
         Me._lblColor5.Name = "_lblColor5"
         Me._lblColor5.Size = New System.Drawing.Size(24, 23)
         Me._lblColor5.TabIndex = 30
         ' 
         ' _lblColor6
         ' 
         Me._lblColor6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColor6.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor6.Location = New System.Drawing.Point(239, 119)
         Me._lblColor6.Name = "_lblColor6"
         Me._lblColor6.Size = New System.Drawing.Size(24, 23)
         Me._lblColor6.TabIndex = 35
         ' 
         ' _lblColor7
         ' 
         Me._lblColor7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColor7.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor7.Location = New System.Drawing.Point(269, 119)
         Me._lblColor7.Name = "_lblColor7"
         Me._lblColor7.Size = New System.Drawing.Size(24, 23)
         Me._lblColor7.TabIndex = 40
         ' 
         ' _lblColor8
         ' 
         Me._lblColor8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblColor8.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblColor8.Location = New System.Drawing.Point(299, 119)
         Me._lblColor8.Name = "_lblColor8"
         Me._lblColor8.Size = New System.Drawing.Size(24, 23)
         Me._lblColor8.TabIndex = 45
         ' 
         ' label56
         ' 
         Me.label56.AutoSize = True
         Me.label56.Location = New System.Drawing.Point(7, 213)
         Me.label56.Name = "label56"
         Me.label56.Size = New System.Drawing.Size(55, 13)
         Me.label56.TabIndex = 53
         Me.label56.Text = "&Read only"
         ' 
         ' label55
         ' 
         Me.label55.AutoSize = True
         Me.label55.Location = New System.Drawing.Point(7, 184)
         Me.label55.Name = "label55"
         Me.label55.Size = New System.Drawing.Size(61, 13)
         Me.label55.TabIndex = 52
         Me.label55.Text = "Color &hover"
         ' 
         ' label54
         ' 
         Me.label54.AutoSize = True
         Me.label54.Location = New System.Drawing.Point(7, 157)
         Me.label54.Name = "label54"
         Me.label54.Size = New System.Drawing.Size(71, 13)
         Me.label54.TabIndex = 51
         Me.label54.Text = "Color &pressed"
         ' 
         ' label53
         ' 
         Me.label53.AutoSize = True
         Me.label53.Location = New System.Drawing.Point(7, 127)
         Me.label53.Name = "label53"
         Me.label53.Size = New System.Drawing.Size(31, 13)
         Me.label53.TabIndex = 50
         Me.label53.Text = "&Color"
         ' 
         ' label52
         ' 
         Me.label52.AutoSize = True
         Me.label52.Location = New System.Drawing.Point(7, 96)
         Me.label52.Name = "label52"
         Me.label52.Size = New System.Drawing.Size(57, 13)
         Me.label52.TabIndex = 49
         Me.label52.Text = "&Show icon"
         ' 
         ' _lblTitlebarColor
         ' 
         Me._lblTitlebarColor.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblTitlebarColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me._lblTitlebarColor.BoxColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
         Me._lblTitlebarColor.Location = New System.Drawing.Point(265, 44)
         Me._lblTitlebarColor.Name = "_lblTitlebarColor"
         Me._lblTitlebarColor.Size = New System.Drawing.Size(58, 29)
         Me._lblTitlebarColor.TabIndex = 3
         ' 
         ' _btnTitlebarColor
         ' 
         Me._btnTitlebarColor.Location = New System.Drawing.Point(186, 43)
         Me._btnTitlebarColor.Name = "_btnTitlebarColor"
         Me._btnTitlebarColor.Size = New System.Drawing.Size(77, 31)
         Me._btnTitlebarColor.TabIndex = 2
         Me._btnTitlebarColor.Text = "Titlebar color"
         Me._btnTitlebarColor.UseVisualStyleBackColor = True
         ' 
         ' _chkCustomTitlebarColor
         ' 
         Me._chkCustomTitlebarColor.AutoSize = True
         Me._chkCustomTitlebarColor.Location = New System.Drawing.Point(198, 21)
         Me._chkCustomTitlebarColor.Name = "_chkCustomTitlebarColor"
         Me._chkCustomTitlebarColor.Size = New System.Drawing.Size(121, 17)
         Me._chkCustomTitlebarColor.TabIndex = 1
         Me._chkCustomTitlebarColor.Text = "Cus&tom titlebar color"
         Me._chkCustomTitlebarColor.UseVisualStyleBackColor = True
         ' 
         ' _chkShowTitlebar
         ' 
         Me._chkShowTitlebar.AutoSize = True
         Me._chkShowTitlebar.Location = New System.Drawing.Point(17, 32)
         Me._chkShowTitlebar.Name = "_chkShowTitlebar"
         Me._chkShowTitlebar.Size = New System.Drawing.Size(87, 17)
         Me._chkShowTitlebar.TabIndex = 0
         Me._chkShowTitlebar.Text = "Show &titlebar"
         Me._chkShowTitlebar.UseVisualStyleBackColor = True
         ' 
         ' _btnApply
         ' 
         Me._btnApply.Location = New System.Drawing.Point(185, 287)
         Me._btnApply.Name = "_btnApply"
         Me._btnApply.Size = New System.Drawing.Size(70, 29)
         Me._btnApply.TabIndex = 11
         Me._btnApply.Text = "App&ly"
         Me._btnApply.UseVisualStyleBackColor = True
         ' 
         ' _btnCancel
         ' 
         Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
         Me._btnCancel.Location = New System.Drawing.Point(109, 287)
         Me._btnCancel.Name = "_btnCancel"
         Me._btnCancel.Size = New System.Drawing.Size(70, 29)
         Me._btnCancel.TabIndex = 10
         Me._btnCancel.Text = "Canc&el"
         Me._btnCancel.UseVisualStyleBackColor = True
         ' 
         ' _btnOK
         ' 
         Me._btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
         Me._btnOK.Location = New System.Drawing.Point(33, 287)
         Me._btnOK.Name = "_btnOK"
         Me._btnOK.Size = New System.Drawing.Size(70, 29)
         Me._btnOK.TabIndex = 9
         Me._btnOK.Text = "&OK"
         Me._btnOK.UseVisualStyleBackColor = True
         ' 
         ' _btnReset
         ' 
         Me._btnReset.Location = New System.Drawing.Point(264, 287)
         Me._btnReset.Name = "_btnReset"
         Me._btnReset.Size = New System.Drawing.Size(70, 29)
         Me._btnReset.TabIndex = 12
         Me._btnReset.Text = "&Reset"
         Me._btnReset.UseVisualStyleBackColor = True
         ' 
         ' ViewerPropertiesDialog
         ' 
         Me.AcceptButton = Me._btnOK
         Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
         Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
         Me.CancelButton = Me._btnCancel
         Me.ClientSize = New System.Drawing.Size(374, 324)
         Me.Controls.Add(Me._btnReset)
         Me.Controls.Add(Me._btnApply)
         Me.Controls.Add(Me._btnCancel)
         Me.Controls.Add(Me._btnOK)
         Me.Controls.Add(Me._tabViewer)
         Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
         Me.MaximizeBox = False
         Me.MinimizeBox = False
         Me.Name = "ViewerPropertiesDialog"
         Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
         Me.Text = "ViewerProperties"
         Me._tabViewer.ResumeLayout(False)
         Me._tabGeneral.ResumeLayout(False)
         Me._tabGeneral.PerformLayout()
         Me._tabColors.ResumeLayout(False)
         Me._tabColors.PerformLayout()
         Me._tabCursor.ResumeLayout(False)
         Me._tabCursor.PerformLayout()
         Me._tabTitlebar.ResumeLayout(False)
         Me._tabTitlebar.PerformLayout()
         Me.ResumeLayout(False)

      End Sub

#End Region

      Private _tabViewer As System.Windows.Forms.TabControl
      Private _tabGeneral As System.Windows.Forms.TabPage
      Private _tabColors As System.Windows.Forms.TabPage
      Private _tabCursor As System.Windows.Forms.TabPage
      Private _tabTitlebar As System.Windows.Forms.TabPage
      Private WithEvents _btnApply As System.Windows.Forms.Button
      Private _btnCancel As System.Windows.Forms.Button
      Private WithEvents _btnOK As System.Windows.Forms.Button
      Private WithEvents _btnReset As System.Windows.Forms.Button
      Private _chkShowCellScroll As System.Windows.Forms.CheckBox
      Private _chkMaintainSize As System.Windows.Forms.CheckBox
      Private _chkShowViewerScroll As System.Windows.Forms.CheckBox
      Private _chkShowFreeze As System.Windows.Forms.CheckBox
      Private _chkUseExtraSplitters As System.Windows.Forms.CheckBox
      Private label6 As System.Windows.Forms.Label
      Private label7 As System.Windows.Forms.Label
      Private label8 As System.Windows.Forms.Label
      Private label5 As System.Windows.Forms.Label
      Private label4 As System.Windows.Forms.Label
      Private label3 As System.Windows.Forms.Label
      Private _cmbMeasurmentUnit As System.Windows.Forms.ComboBox
      Private _cmbBorderStyle As System.Windows.Forms.ComboBox
      Private _cmbTextQuality As System.Windows.Forms.ComboBox
      Private _cmbPaintMethod As System.Windows.Forms.ComboBox
      Private _cmbSplitterType As System.Windows.Forms.ComboBox
      Private _cmbRuler As System.Windows.Forms.ComboBox
      Private WithEvents _chkModifyRowsColumns As System.Windows.Forms.CheckBox
      Private _lblColumns As System.Windows.Forms.Label
      Private _lblRows As System.Windows.Forms.Label
      Private _txtColumns As NumericTextBox
      Private _txtRows As NumericTextBox
      Private WithEvents _btnEmptyCellBackColor As System.Windows.Forms.Button
      Private WithEvents _chkCustomSplitterColor As System.Windows.Forms.CheckBox
      Private _lblSplitterColor As MedicalViewerDemo.ColorBox
      Private WithEvents _btnSplitterColor As System.Windows.Forms.Button
      Private _lblNonActiveBorderColor As MedicalViewerDemo.ColorBox
      Private WithEvents _btnNonActiveBorderColor As System.Windows.Forms.Button
      Private _lblRulerOutColor As MedicalViewerDemo.ColorBox
      Private WithEvents _btnRulerOutColor As System.Windows.Forms.Button
      Private _lblRulerInColor As MedicalViewerDemo.ColorBox
      Private WithEvents _btnRulerInColor As System.Windows.Forms.Button
      Private _lblBackgroundColor As MedicalViewerDemo.ColorBox
      Private WithEvents _btnBackgroundColor As System.Windows.Forms.Button
      Private _lblActiveSubcellColor As MedicalViewerDemo.ColorBox
      Private WithEvents _btnActiveSubcellColor As System.Windows.Forms.Button
      Private _lblActiveBorderColor As MedicalViewerDemo.ColorBox
      Private WithEvents _btnActiveBorderColor As System.Windows.Forms.Button
      Private _lblShadowColor As MedicalViewerDemo.ColorBox
      Private WithEvents _btnShadowColor As System.Windows.Forms.Button
      Private _lblText As MedicalViewerDemo.ColorBox
      Private WithEvents _btnText As System.Windows.Forms.Button
      Private _lblEmptyCellBackColor As MedicalViewerDemo.ColorBox
      Private label24 As System.Windows.Forms.Label
      Private label21 As System.Windows.Forms.Label
      Private label20 As System.Windows.Forms.Label
      Private label19 As System.Windows.Forms.Label
      Private _btnVerticalCursor As MedicalViewerDemo.CursorButton
      Private _btnBothCursor As MedicalViewerDemo.CursorButton
      Private _btnHorizontalCursor As MedicalViewerDemo.CursorButton
      Private _btnDefaultCursor As MedicalViewerDemo.CursorButton
      Private _lblTitlebarColor As MedicalViewerDemo.ColorBox
      Private WithEvents _btnTitlebarColor As System.Windows.Forms.Button
      Private WithEvents _chkCustomTitlebarColor As System.Windows.Forms.CheckBox
      Private WithEvents _chkShowTitlebar As System.Windows.Forms.CheckBox
      Private label56 As System.Windows.Forms.Label
      Private label55 As System.Windows.Forms.Label
      Private label54 As System.Windows.Forms.Label
      Private label53 As System.Windows.Forms.Label
      Private label52 As System.Windows.Forms.Label
      Private _chkReadOnly8 As System.Windows.Forms.CheckBox
      Private _lblColorHover8 As ColorBox
      Private _lblColorPressed8 As ColorBox
      Private _lblColor8 As ColorBox
      Private WithEvents _chkShowIcon8 As System.Windows.Forms.CheckBox
      Private _chkReadOnly7 As System.Windows.Forms.CheckBox
      Private _lblColorHover7 As ColorBox
      Private _lblColorPressed7 As ColorBox
      Private _lblColor7 As ColorBox
      Private WithEvents _chkShowIcon7 As System.Windows.Forms.CheckBox
      Private _chkReadOnly6 As System.Windows.Forms.CheckBox
      Private _lblColorHover6 As ColorBox
      Private _lblColorPressed6 As ColorBox
      Private _lblColor6 As ColorBox
      Private WithEvents _chkShowIcon6 As System.Windows.Forms.CheckBox
      Private _chkReadOnly5 As System.Windows.Forms.CheckBox
      Private _lblColorHover5 As ColorBox
      Private _lblColorPressed5 As ColorBox
      Private _lblColor5 As ColorBox
      Private WithEvents _chkShowIcon5 As System.Windows.Forms.CheckBox
      Private _chkReadOnly4 As System.Windows.Forms.CheckBox
      Private _lblColorHover4 As ColorBox
      Private _lblColorPressed4 As ColorBox
      Private _lblColor4 As ColorBox
      Private WithEvents _chkShowIcon4 As System.Windows.Forms.CheckBox
      Private _chkReadOnly3 As System.Windows.Forms.CheckBox
      Private _lblColorHover3 As ColorBox
      Private _lblColorPressed3 As ColorBox
      Private _lblColor3 As ColorBox
      Private WithEvents _chkShowIcon3 As System.Windows.Forms.CheckBox
      Private _chkReadOnly2 As System.Windows.Forms.CheckBox
      Private _lblColorHover2 As ColorBox
      Private _lblColorPressed2 As ColorBox
      Private _lblColor2 As ColorBox
      Private WithEvents _chkShowIcon2 As System.Windows.Forms.CheckBox
      Private _chkReadOnly1 As System.Windows.Forms.CheckBox
      Private _lblColorHover1 As ColorBox
      Private _lblColorPressed1 As ColorBox
      Private _lblColor1 As ColorBox
      Private WithEvents _chkShowIcon1 As System.Windows.Forms.CheckBox
   End Class
End Namespace
