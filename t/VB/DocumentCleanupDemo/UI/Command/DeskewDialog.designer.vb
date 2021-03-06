Imports Microsoft.VisualBasic
Imports System
Namespace DocumentCleanupDemo
   Public Partial Class DeskewDialog
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
         Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeskewDialog))
         Me._btnOk = New System.Windows.Forms.Button()
         Me._btnCancel = New System.Windows.Forms.Button()
         Me._gb1 = New System.Windows.Forms.GroupBox()
         Me._lblColor = New System.Windows.Forms.Label()
         Me._cbFillExposedArea = New System.Windows.Forms.CheckBox()
         Me._gb2 = New System.Windows.Forms.GroupBox()
         Me._lblThreshold = New System.Windows.Forms.Label()
         Me._label1 = New System.Windows.Forms.Label()
         Me._cbThreshold = New System.Windows.Forms.CheckBox()
         Me._gb3 = New System.Windows.Forms.GroupBox()
         Me._rbHigh = New System.Windows.Forms.RadioButton()
         Me._rbMedium = New System.Windows.Forms.RadioButton()
         Me._rbLow = New System.Windows.Forms.RadioButton()
         Me._gp4 = New System.Windows.Forms.GroupBox()
         Me._rbTextImages = New System.Windows.Forms.RadioButton()
         Me._rbTextOnly = New System.Windows.Forms.RadioButton()
         Me._gb5 = New System.Windows.Forms.GroupBox()
         Me._rbFast = New System.Windows.Forms.RadioButton()
         Me._rbNormal = New System.Windows.Forms.RadioButton()
         Me._gb1.SuspendLayout()
         Me._gb2.SuspendLayout()
         Me._gb3.SuspendLayout()
         Me._gp4.SuspendLayout()
         Me._gb5.SuspendLayout()
         Me.SuspendLayout()
         '
         '_btnOk
         '
         Me._btnOk.Location = New System.Drawing.Point(356, 12)
         Me._btnOk.Name = "_btnOk"
         Me._btnOk.Size = New System.Drawing.Size(75, 23)
         Me._btnOk.TabIndex = 0
         Me._btnOk.Text = "OK"
         Me._btnOk.UseVisualStyleBackColor = True
         '
         '_btnCancel
         '
         Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
         Me._btnCancel.Location = New System.Drawing.Point(356, 41)
         Me._btnCancel.Name = "_btnCancel"
         Me._btnCancel.Size = New System.Drawing.Size(75, 23)
         Me._btnCancel.TabIndex = 1
         Me._btnCancel.Text = "Cancel"
         Me._btnCancel.UseVisualStyleBackColor = True
         '
         '_gb1
         '
         Me._gb1.Controls.Add(Me._lblColor)
         Me._gb1.Controls.Add(Me._cbFillExposedArea)
         Me._gb1.Location = New System.Drawing.Point(12, 12)
         Me._gb1.Name = "_gb1"
         Me._gb1.Size = New System.Drawing.Size(338, 52)
         Me._gb1.TabIndex = 2
         Me._gb1.TabStop = False
         Me._gb1.Text = "Fill"
         '
         '_lblColor
         '
         Me._lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
         Me._lblColor.Enabled = False
         Me._lblColor.Location = New System.Drawing.Point(134, 16)
         Me._lblColor.Name = "_lblColor"
         Me._lblColor.Size = New System.Drawing.Size(100, 23)
         Me._lblColor.TabIndex = 1
         '
         '_cbFillExposedArea
         '
         Me._cbFillExposedArea.AutoSize = True
         Me._cbFillExposedArea.Location = New System.Drawing.Point(21, 19)
         Me._cbFillExposedArea.Name = "_cbFillExposedArea"
         Me._cbFillExposedArea.Size = New System.Drawing.Size(107, 17)
         Me._cbFillExposedArea.TabIndex = 0
         Me._cbFillExposedArea.Text = "Fill Exposed Area"
         Me._cbFillExposedArea.UseVisualStyleBackColor = True
         '
         '_gb2
         '
         Me._gb2.Controls.Add(Me._lblThreshold)
         Me._gb2.Controls.Add(Me._label1)
         Me._gb2.Controls.Add(Me._cbThreshold)
         Me._gb2.Location = New System.Drawing.Point(12, 70)
         Me._gb2.Name = "_gb2"
         Me._gb2.Size = New System.Drawing.Size(338, 58)
         Me._gb2.TabIndex = 3
         Me._gb2.TabStop = False
         Me._gb2.Text = "Threshold"
         '
         '_lblThreshold
         '
         Me._lblThreshold.Location = New System.Drawing.Point(42, 20)
         Me._lblThreshold.Name = "_lblThreshold"
         Me._lblThreshold.Size = New System.Drawing.Size(288, 35)
         Me._lblThreshold.TabIndex = 2
         Me._lblThreshold.Text = "Do not deskew the image if the deskew angle is very small (less than 0.5 degrees)" & _
             ". "
         '
         '_label1
         '
         Me._label1.Location = New System.Drawing.Point(42, 19)
         Me._label1.MaximumSize = New System.Drawing.Size(0, 50)
         Me._label1.Name = "_label1"
         Me._label1.Size = New System.Drawing.Size(0, 36)
         Me._label1.TabIndex = 1
         Me._label1.Text = "Do not deskew the image if the deskew angle is very small (less than 0.5 degrees)" & _
             ". "
         '
         '_cbThreshold
         '
         Me._cbThreshold.AutoSize = True
         Me._cbThreshold.Location = New System.Drawing.Point(21, 19)
         Me._cbThreshold.Name = "_cbThreshold"
         Me._cbThreshold.Size = New System.Drawing.Size(15, 14)
         Me._cbThreshold.TabIndex = 0
         Me._cbThreshold.UseVisualStyleBackColor = True
         '
         '_gb3
         '
         Me._gb3.Controls.Add(Me._rbHigh)
         Me._gb3.Controls.Add(Me._rbMedium)
         Me._gb3.Controls.Add(Me._rbLow)
         Me._gb3.Location = New System.Drawing.Point(12, 134)
         Me._gb3.Name = "_gb3"
         Me._gb3.Size = New System.Drawing.Size(338, 70)
         Me._gb3.TabIndex = 3
         Me._gb3.TabStop = False
         Me._gb3.Text = "Quality"
         '
         '_rbHigh
         '
         Me._rbHigh.AutoSize = True
         Me._rbHigh.Location = New System.Drawing.Point(149, 19)
         Me._rbHigh.Name = "_rbHigh"
         Me._rbHigh.Size = New System.Drawing.Size(47, 17)
         Me._rbHigh.TabIndex = 2
         Me._rbHigh.TabStop = True
         Me._rbHigh.Text = "High"
         Me._rbHigh.UseVisualStyleBackColor = True
         '
         '_rbMedium
         '
         Me._rbMedium.AutoSize = True
         Me._rbMedium.Location = New System.Drawing.Point(21, 42)
         Me._rbMedium.Name = "_rbMedium"
         Me._rbMedium.Size = New System.Drawing.Size(62, 17)
         Me._rbMedium.TabIndex = 1
         Me._rbMedium.TabStop = True
         Me._rbMedium.Text = "Medium"
         Me._rbMedium.UseVisualStyleBackColor = True
         '
         '_rbLow
         '
         Me._rbLow.AutoSize = True
         Me._rbLow.Location = New System.Drawing.Point(21, 19)
         Me._rbLow.Name = "_rbLow"
         Me._rbLow.Size = New System.Drawing.Size(45, 17)
         Me._rbLow.TabIndex = 0
         Me._rbLow.TabStop = True
         Me._rbLow.Text = "Low"
         Me._rbLow.UseVisualStyleBackColor = True
         '
         '_gp4
         '
         Me._gp4.Controls.Add(Me._rbTextImages)
         Me._gp4.Controls.Add(Me._rbTextOnly)
         Me._gp4.Location = New System.Drawing.Point(12, 210)
         Me._gp4.Name = "_gp4"
         Me._gp4.Size = New System.Drawing.Size(338, 56)
         Me._gp4.TabIndex = 3
         Me._gp4.TabStop = False
         Me._gp4.Text = "Type"
         '
         '_rbTextImages
         '
         Me._rbTextImages.AutoSize = True
         Me._rbTextImages.Location = New System.Drawing.Point(149, 19)
         Me._rbTextImages.Name = "_rbTextImages"
         Me._rbTextImages.Size = New System.Drawing.Size(104, 17)
         Me._rbTextImages.TabIndex = 1
         Me._rbTextImages.TabStop = True
         Me._rbTextImages.Text = "Text and Images"
         Me._rbTextImages.UseVisualStyleBackColor = True
         '
         '_rbTextOnly
         '
         Me._rbTextOnly.AutoSize = True
         Me._rbTextOnly.Location = New System.Drawing.Point(21, 19)
         Me._rbTextOnly.Name = "_rbTextOnly"
         Me._rbTextOnly.Size = New System.Drawing.Size(70, 17)
         Me._rbTextOnly.TabIndex = 0
         Me._rbTextOnly.TabStop = True
         Me._rbTextOnly.Text = "Text Only"
         Me._rbTextOnly.UseVisualStyleBackColor = True
         '
         '_gb5
         '
         Me._gb5.Controls.Add(Me._rbFast)
         Me._gb5.Controls.Add(Me._rbNormal)
         Me._gb5.Location = New System.Drawing.Point(12, 272)
         Me._gb5.Name = "_gb5"
         Me._gb5.Size = New System.Drawing.Size(338, 56)
         Me._gb5.TabIndex = 4
         Me._gb5.TabStop = False
         Me._gb5.Text = "Speed"
         '
         '_rbFast
         '
         Me._rbFast.AutoSize = True
         Me._rbFast.Location = New System.Drawing.Point(149, 19)
         Me._rbFast.Name = "_rbFast"
         Me._rbFast.Size = New System.Drawing.Size(181, 17)
         Me._rbFast.TabIndex = 1
         Me._rbFast.TabStop = True
         Me._rbFast.Text = "Fast (Intended for 1 bits per pixel)"
         Me._rbFast.UseVisualStyleBackColor = True
         '
         '_rbNormal
         '
         Me._rbNormal.AutoSize = True
         Me._rbNormal.Location = New System.Drawing.Point(21, 19)
         Me._rbNormal.Name = "_rbNormal"
         Me._rbNormal.Size = New System.Drawing.Size(123, 17)
         Me._rbNormal.TabIndex = 0
         Me._rbNormal.TabStop = True
         Me._rbNormal.Text = "Normal (Best Quality)"
         Me._rbNormal.UseVisualStyleBackColor = True
         '
         'DeskewDialog
         '
         Me.AcceptButton = Me._btnOk
         Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
         Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
         Me.CancelButton = Me._btnCancel
         Me.ClientSize = New System.Drawing.Size(440, 346)
         Me.Controls.Add(Me._gb5)
         Me.Controls.Add(Me._gb2)
         Me.Controls.Add(Me._gb3)
         Me.Controls.Add(Me._gp4)
         Me.Controls.Add(Me._gb1)
         Me.Controls.Add(Me._btnCancel)
         Me.Controls.Add(Me._btnOk)
         Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
         Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
         Me.MaximizeBox = False
         Me.MinimizeBox = False
         Me.Name = "DeskewDialog"
         Me.Text = "Deskew"
         Me._gb1.ResumeLayout(False)
         Me._gb1.PerformLayout()
         Me._gb2.ResumeLayout(False)
         Me._gb2.PerformLayout()
         Me._gb3.ResumeLayout(False)
         Me._gb3.PerformLayout()
         Me._gp4.ResumeLayout(False)
         Me._gp4.PerformLayout()
         Me._gb5.ResumeLayout(False)
         Me._gb5.PerformLayout()
         Me.ResumeLayout(False)

      End Sub

	  #End Region

	  Private WithEvents _btnOk As System.Windows.Forms.Button
	  Private WithEvents _btnCancel As System.Windows.Forms.Button
	  Private _gb1 As System.Windows.Forms.GroupBox
	  Private WithEvents _cbFillExposedArea As System.Windows.Forms.CheckBox
	  Private _gb2 As System.Windows.Forms.GroupBox
	  Private _gb3 As System.Windows.Forms.GroupBox
	  Private _gp4 As System.Windows.Forms.GroupBox
      Private WithEvents _lblColor As System.Windows.Forms.Label
	  Private _label1 As System.Windows.Forms.Label
	  Private _cbThreshold As System.Windows.Forms.CheckBox
	  Private _rbHigh As System.Windows.Forms.RadioButton
	  Private _rbMedium As System.Windows.Forms.RadioButton
	  Private _rbLow As System.Windows.Forms.RadioButton
	  Private _rbTextImages As System.Windows.Forms.RadioButton
	  Private _rbTextOnly As System.Windows.Forms.RadioButton
	  Private _gb5 As System.Windows.Forms.GroupBox
	  Private _rbFast As System.Windows.Forms.RadioButton
	  Private _rbNormal As System.Windows.Forms.RadioButton
	  Private _lblThreshold As System.Windows.Forms.Label
   End Class
End Namespace