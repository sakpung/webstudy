Namespace MedicalViewerDemo
   Partial Class StackPropertiesDialog
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
         Me.groupBox2 = New System.Windows.Forms.GroupBox()
         Me.label5 = New System.Windows.Forms.Label()
         Me._cmbModifiers = New System.Windows.Forms.ComboBox()
         Me.label4 = New System.Windows.Forms.Label()
         Me.label3 = New System.Windows.Forms.Label()
         Me._cmbBottomKey = New System.Windows.Forms.ComboBox()
         Me._cmbTopKey = New System.Windows.Forms.ComboBox()
         Me.label8 = New System.Windows.Forms.Label()
         Me.label1 = New System.Windows.Forms.Label()
         Me._cmbApplyToCells = New System.Windows.Forms.ComboBox()
         Me.groupBox1 = New System.Windows.Forms.GroupBox()
         Me._txtSensitivity = New MedicalViewerDemo.NumericTextBox()
         Me._btnActionCursor = New MedicalViewerDemo.CursorButton()
         Me._chkCircular = New System.Windows.Forms.CheckBox()
         Me.label2 = New System.Windows.Forms.Label()
         Me.groupBox3 = New System.Windows.Forms.GroupBox()
         Me._txtActiveSubCell = New MedicalViewerDemo.NumericTextBox()
         Me.label9 = New System.Windows.Forms.Label()
         Me._txtStack = New MedicalViewerDemo.NumericTextBox()
         Me._txtCellIndex = New MedicalViewerDemo.NumericTextBox()
         Me.label7 = New System.Windows.Forms.Label()
         Me.label6 = New System.Windows.Forms.Label()
         Me._btnApply = New System.Windows.Forms.Button()
         Me._btnCancel = New System.Windows.Forms.Button()
         Me._btnOK = New System.Windows.Forms.Button()
         Me.groupBox2.SuspendLayout()
         Me.groupBox1.SuspendLayout()
         Me.groupBox3.SuspendLayout()
         Me.SuspendLayout()
         ' 
         ' groupBox2
         ' 
         Me.groupBox2.BackColor = System.Drawing.Color.Transparent
         Me.groupBox2.Controls.Add(Me.label5)
         Me.groupBox2.Controls.Add(Me._cmbModifiers)
         Me.groupBox2.Controls.Add(Me.label4)
         Me.groupBox2.Controls.Add(Me.label3)
         Me.groupBox2.Controls.Add(Me._cmbBottomKey)
         Me.groupBox2.Controls.Add(Me._cmbTopKey)
         Me.groupBox2.Location = New System.Drawing.Point(11, 127)
         Me.groupBox2.Name = "groupBox2"
         Me.groupBox2.Size = New System.Drawing.Size(196, 118)
         Me.groupBox2.TabIndex = 16
         Me.groupBox2.TabStop = False
         Me.groupBox2.Text = "Keyboard &Shortcut"
         ' 
         ' label5
         ' 
         Me.label5.AutoSize = True
         Me.label5.Location = New System.Drawing.Point(12, 95)
         Me.label5.Name = "label5"
         Me.label5.Size = New System.Drawing.Size(49, 13)
         Me.label5.TabIndex = 5
         Me.label5.Text = "&Modifiers"
         ' 
         ' _cmbModifiers
         ' 
         Me._cmbModifiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbModifiers.FormattingEnabled = True
         Me._cmbModifiers.Location = New System.Drawing.Point(70, 91)
         Me._cmbModifiers.Name = "_cmbModifiers"
         Me._cmbModifiers.Size = New System.Drawing.Size(59, 21)
         Me._cmbModifiers.TabIndex = 4
         ' 
         ' label4
         ' 
         Me.label4.AutoSize = True
         Me.label4.Location = New System.Drawing.Point(18, 63)
         Me.label4.Name = "label4"
         Me.label4.Size = New System.Drawing.Size(40, 13)
         Me.label4.TabIndex = 3
         Me.label4.Text = "&Bottom"
         ' 
         ' label3
         ' 
         Me.label3.AutoSize = True
         Me.label3.Location = New System.Drawing.Point(20, 29)
         Me.label3.Name = "label3"
         Me.label3.Size = New System.Drawing.Size(26, 13)
         Me.label3.TabIndex = 2
         Me.label3.Text = "&Top"
         ' 
         ' _cmbBottomKey
         ' 
         Me._cmbBottomKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbBottomKey.FormattingEnabled = True
         Me._cmbBottomKey.Location = New System.Drawing.Point(70, 60)
         Me._cmbBottomKey.Name = "_cmbBottomKey"
         Me._cmbBottomKey.Size = New System.Drawing.Size(109, 21)
         Me._cmbBottomKey.TabIndex = 1
         ' 
         ' _cmbTopKey
         ' 
         Me._cmbTopKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbTopKey.FormattingEnabled = True
         Me._cmbTopKey.Location = New System.Drawing.Point(70, 25)
         Me._cmbTopKey.Name = "_cmbTopKey"
         Me._cmbTopKey.Size = New System.Drawing.Size(109, 21)
         Me._cmbTopKey.TabIndex = 0
         ' 
         ' label8
         ' 
         Me.label8.AutoSize = True
         Me.label8.Location = New System.Drawing.Point(28, 125)
         Me.label8.Name = "label8"
         Me.label8.Size = New System.Drawing.Size(35, 13)
         Me.label8.TabIndex = 13
         Me.label8.Text = "&Stack"
         ' 
         ' label1
         ' 
         Me.label1.AutoSize = True
         Me.label1.Location = New System.Drawing.Point(16, 31)
         Me.label1.Name = "label1"
         Me.label1.Size = New System.Drawing.Size(70, 13)
         Me.label1.TabIndex = 0
         Me.label1.Text = "Action &Cursor"
         ' 
         ' _cmbApplyToCells
         ' 
         Me._cmbApplyToCells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
         Me._cmbApplyToCells.FormattingEnabled = True
         Me._cmbApplyToCells.Items.AddRange(New Object() {"None", "Selected", "All", "Custom"})
         Me._cmbApplyToCells.Location = New System.Drawing.Point(93, 25)
         Me._cmbApplyToCells.Name = "_cmbApplyToCells"
         Me._cmbApplyToCells.Size = New System.Drawing.Size(109, 21)
         Me._cmbApplyToCells.TabIndex = 12
         ' 
         ' groupBox1
         ' 
         Me.groupBox1.Controls.Add(Me._txtSensitivity)
         Me.groupBox1.Controls.Add(Me._btnActionCursor)
         Me.groupBox1.Controls.Add(Me._chkCircular)
         Me.groupBox1.Controls.Add(Me.label2)
         Me.groupBox1.Controls.Add(Me.label1)
         Me.groupBox1.Location = New System.Drawing.Point(11, 8)
         Me.groupBox1.Name = "groupBox1"
         Me.groupBox1.Size = New System.Drawing.Size(196, 126)
         Me.groupBox1.TabIndex = 15
         Me.groupBox1.TabStop = False
         Me.groupBox1.Text = "&General Action Properties"
         ' 
         ' _txtSensitivity
         ' 
         Me._txtSensitivity.Location = New System.Drawing.Point(103, 64)
         Me._txtSensitivity.MaximumAllowed = 10000
         Me._txtSensitivity.MaxLength = 3
         Me._txtSensitivity.MinimumAllowed = 1
         Me._txtSensitivity.Name = "_txtSensitivity"
         Me._txtSensitivity.Size = New System.Drawing.Size(40, 20)
         Me._txtSensitivity.TabIndex = 4
         Me._txtSensitivity.Value = 0
         ' 
         ' _btnActionCursor
         ' 
         Me._btnActionCursor.ButtonCursor = Nothing
         Me._btnActionCursor.Location = New System.Drawing.Point(103, 24)
         Me._btnActionCursor.Name = "_btnActionCursor"
         Me._btnActionCursor.Size = New System.Drawing.Size(61, 31)
         Me._btnActionCursor.TabIndex = 3
         Me._btnActionCursor.UseVisualStyleBackColor = True
         ' 
         ' _chkCircular
         ' 
         Me._chkCircular.AutoSize = True
         Me._chkCircular.Location = New System.Drawing.Point(17, 96)
         Me._chkCircular.Name = "_chkCircular"
         Me._chkCircular.Size = New System.Drawing.Size(126, 17)
         Me._chkCircular.TabIndex = 2
         Me._chkCircular.Text = "&Circular Mouse Move"
         Me._chkCircular.UseVisualStyleBackColor = True
         ' 
         ' label2
         ' 
         Me.label2.AutoSize = True
         Me.label2.Location = New System.Drawing.Point(16, 65)
         Me.label2.Name = "label2"
         Me.label2.Size = New System.Drawing.Size(54, 13)
         Me.label2.TabIndex = 1
         Me.label2.Text = "&Sensitivity"
         ' 
         ' groupBox3
         ' 
         Me.groupBox3.Controls.Add(Me._txtActiveSubCell)
         Me.groupBox3.Controls.Add(Me.label9)
         Me.groupBox3.Controls.Add(Me._txtStack)
         Me.groupBox3.Controls.Add(Me.label8)
         Me.groupBox3.Controls.Add(Me._cmbApplyToCells)
         Me.groupBox3.Controls.Add(Me._txtCellIndex)
         Me.groupBox3.Controls.Add(Me.label7)
         Me.groupBox3.Controls.Add(Me.label6)
         Me.groupBox3.Location = New System.Drawing.Point(213, 8)
         Me.groupBox3.Name = "groupBox3"
         Me.groupBox3.Size = New System.Drawing.Size(223, 200)
         Me.groupBox3.TabIndex = 17
         Me.groupBox3.TabStop = False
         Me.groupBox3.Text = "Cell &Properties"
         ' 
         ' _txtActiveSubCell
         ' 
         Me._txtActiveSubCell.Location = New System.Drawing.Point(93, 166)
         Me._txtActiveSubCell.MaximumAllowed = 100
         Me._txtActiveSubCell.MinimumAllowed = 0
         Me._txtActiveSubCell.Name = "_txtActiveSubCell"
         Me._txtActiveSubCell.Size = New System.Drawing.Size(41, 20)
         Me._txtActiveSubCell.TabIndex = 16
         Me._txtActiveSubCell.Text = "0"
         Me._txtActiveSubCell.Value = 0
         ' 
         ' label9
         ' 
         Me.label9.AutoSize = True
         Me.label9.Location = New System.Drawing.Point(12, 170)
         Me.label9.Name = "label9"
         Me.label9.Size = New System.Drawing.Size(76, 13)
         Me.label9.TabIndex = 15
         Me.label9.Text = "Acti&ve sub-cell"
         ' 
         ' _txtStack
         ' 
         Me._txtStack.Location = New System.Drawing.Point(93, 122)
         Me._txtStack.MaximumAllowed = 100
         Me._txtStack.MinimumAllowed = 0
         Me._txtStack.Name = "_txtStack"
         Me._txtStack.Size = New System.Drawing.Size(41, 20)
         Me._txtStack.TabIndex = 14
         Me._txtStack.Text = "0"
         Me._txtStack.Value = 0
         ' 
         ' _txtCellIndex
         ' 
         Me._txtCellIndex.Location = New System.Drawing.Point(93, 75)
         Me._txtCellIndex.MaximumAllowed = 100
         Me._txtCellIndex.MinimumAllowed = 0
         Me._txtCellIndex.Name = "_txtCellIndex"
         Me._txtCellIndex.Size = New System.Drawing.Size(41, 20)
         Me._txtCellIndex.TabIndex = 10
         Me._txtCellIndex.Text = "0"
         Me._txtCellIndex.Value = 0
         ' 
         ' label7
         ' 
         Me.label7.AutoSize = True
         Me.label7.Location = New System.Drawing.Point(21, 78)
         Me.label7.Name = "label7"
         Me.label7.Size = New System.Drawing.Size(53, 13)
         Me.label7.TabIndex = 4
         Me.label7.Text = "&Cell Index"
         ' 
         ' label6
         ' 
         Me.label6.AutoSize = True
         Me.label6.Location = New System.Drawing.Point(25, 28)
         Me.label6.Name = "label6"
         Me.label6.Size = New System.Drawing.Size(45, 13)
         Me.label6.TabIndex = 3
         Me.label6.Text = "&Apply to"
         ' 
         ' _btnApply
         ' 
         Me._btnApply.Location = New System.Drawing.Point(366, 216)
         Me._btnApply.Name = "_btnApply"
         Me._btnApply.Size = New System.Drawing.Size(70, 29)
         Me._btnApply.TabIndex = 20
         Me._btnApply.Text = "App&ly"
         Me._btnApply.UseVisualStyleBackColor = True
         ' 
         ' _btnCancel
         ' 
         Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
         Me._btnCancel.Location = New System.Drawing.Point(289, 216)
         Me._btnCancel.Name = "_btnCancel"
         Me._btnCancel.Size = New System.Drawing.Size(70, 29)
         Me._btnCancel.TabIndex = 19
         Me._btnCancel.Text = "Canc&el"
         Me._btnCancel.UseVisualStyleBackColor = True
         ' 
         ' _btnOK
         ' 
         Me._btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
         Me._btnOK.Location = New System.Drawing.Point(213, 216)
         Me._btnOK.Name = "_btnOK"
         Me._btnOK.Size = New System.Drawing.Size(70, 29)
         Me._btnOK.TabIndex = 18
         Me._btnOK.Text = "&OK"
         Me._btnOK.UseVisualStyleBackColor = True
         ' 
         ' StackPropertiesDialog
         ' 
         Me.AcceptButton = Me._btnOK
         Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
         Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
         Me.CancelButton = Me._btnCancel
         Me.ClientSize = New System.Drawing.Size(447, 253)
         Me.Controls.Add(Me.groupBox2)
         Me.Controls.Add(Me.groupBox1)
         Me.Controls.Add(Me.groupBox3)
         Me.Controls.Add(Me._btnApply)
         Me.Controls.Add(Me._btnCancel)
         Me.Controls.Add(Me._btnOK)
         Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
         Me.MaximizeBox = False
         Me.MinimizeBox = False
         Me.Name = "StackPropertiesDialog"
         Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
         Me.Text = "Stack Dialog"
         Me.groupBox2.ResumeLayout(False)
         Me.groupBox2.PerformLayout()
         Me.groupBox1.ResumeLayout(False)
         Me.groupBox1.PerformLayout()
         Me.groupBox3.ResumeLayout(False)
         Me.groupBox3.PerformLayout()
         Me.ResumeLayout(False)

      End Sub

#End Region

      Private _txtStack As NumericTextBox
      Private groupBox2 As System.Windows.Forms.GroupBox
      Private label5 As System.Windows.Forms.Label
      Private _cmbModifiers As System.Windows.Forms.ComboBox
      Private label4 As System.Windows.Forms.Label
      Private label3 As System.Windows.Forms.Label
      Private _cmbBottomKey As System.Windows.Forms.ComboBox
      Private _cmbTopKey As System.Windows.Forms.ComboBox
      Private label8 As System.Windows.Forms.Label
      Private label1 As System.Windows.Forms.Label
      Private WithEvents _cmbApplyToCells As System.Windows.Forms.ComboBox
      Private groupBox1 As System.Windows.Forms.GroupBox
      Private _txtSensitivity As NumericTextBox
      Private _btnActionCursor As CursorButton
      Private _chkCircular As System.Windows.Forms.CheckBox
      Private label2 As System.Windows.Forms.Label
      Private groupBox3 As System.Windows.Forms.GroupBox
      Private _txtCellIndex As NumericTextBox
      Private label7 As System.Windows.Forms.Label
      Private label6 As System.Windows.Forms.Label
      Private WithEvents _btnApply As System.Windows.Forms.Button
      Private _btnCancel As System.Windows.Forms.Button
      Private WithEvents _btnOK As System.Windows.Forms.Button
      Private _txtActiveSubCell As NumericTextBox
      Private label9 As System.Windows.Forms.Label
   End Class
End Namespace
