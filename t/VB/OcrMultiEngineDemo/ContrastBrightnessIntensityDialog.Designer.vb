﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContrastBrightnessIntensityDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me._intensityValueLabel = New System.Windows.Forms.Label
      Me._brightnessValueLabel = New System.Windows.Forms.Label
      Me._contrastValueLabel = New System.Windows.Forms.Label
      Me._intensityLabel = New System.Windows.Forms.Label
      Me._brightnessLabel = New System.Windows.Forms.Label
      Me._intensityTrackBar = New System.Windows.Forms.TrackBar
      Me._brightnessTrackBar = New System.Windows.Forms.TrackBar
      Me._okButton = New System.Windows.Forms.Button
      Me._contrastTrackBar = New System.Windows.Forms.TrackBar
      Me._contrastLabel = New System.Windows.Forms.Label
      Me._valuesGroupBox = New System.Windows.Forms.GroupBox
      Me._cancelButton = New System.Windows.Forms.Button
      CType(Me._intensityTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me._brightnessTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me._contrastTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
      Me._valuesGroupBox.SuspendLayout()
      Me.SuspendLayout()
      '
      '_intensityValueLabel
      '
      Me._intensityValueLabel.AutoSize = True
      Me._intensityValueLabel.Location = New System.Drawing.Point(338, 118)
      Me._intensityValueLabel.Name = "_intensityValueLabel"
      Me._intensityValueLabel.Size = New System.Drawing.Size(46, 13)
      Me._intensityValueLabel.TabIndex = 8
      Me._intensityValueLabel.Text = "Intensity"
      '
      '_brightnessValueLabel
      '
      Me._brightnessValueLabel.AutoSize = True
      Me._brightnessValueLabel.Location = New System.Drawing.Point(338, 67)
      Me._brightnessValueLabel.Name = "_brightnessValueLabel"
      Me._brightnessValueLabel.Size = New System.Drawing.Size(56, 13)
      Me._brightnessValueLabel.TabIndex = 5
      Me._brightnessValueLabel.Text = "Brightness"
      '
      '_contrastValueLabel
      '
      Me._contrastValueLabel.AutoSize = True
      Me._contrastValueLabel.Location = New System.Drawing.Point(338, 16)
      Me._contrastValueLabel.Name = "_contrastValueLabel"
      Me._contrastValueLabel.Size = New System.Drawing.Size(46, 13)
      Me._contrastValueLabel.TabIndex = 2
      Me._contrastValueLabel.Text = "Contrast"
      '
      '_intensityLabel
      '
      Me._intensityLabel.AutoSize = True
      Me._intensityLabel.Location = New System.Drawing.Point(6, 118)
      Me._intensityLabel.Name = "_intensityLabel"
      Me._intensityLabel.Size = New System.Drawing.Size(46, 13)
      Me._intensityLabel.TabIndex = 6
      Me._intensityLabel.Text = "&Intensity"
      '
      '_brightnessLabel
      '
      Me._brightnessLabel.AutoSize = True
      Me._brightnessLabel.Location = New System.Drawing.Point(6, 67)
      Me._brightnessLabel.Name = "_brightnessLabel"
      Me._brightnessLabel.Size = New System.Drawing.Size(56, 13)
      Me._brightnessLabel.TabIndex = 3
      Me._brightnessLabel.Text = "&Brightness"
      '
      '_intensityTrackBar
      '
      Me._intensityTrackBar.LargeChange = 10
      Me._intensityTrackBar.Location = New System.Drawing.Point(58, 118)
      Me._intensityTrackBar.Maximum = 100
      Me._intensityTrackBar.Minimum = -100
      Me._intensityTrackBar.Name = "_intensityTrackBar"
      Me._intensityTrackBar.Size = New System.Drawing.Size(274, 45)
      Me._intensityTrackBar.TabIndex = 7
      Me._intensityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
      '
      '_brightnessTrackBar
      '
      Me._brightnessTrackBar.LargeChange = 10
      Me._brightnessTrackBar.Location = New System.Drawing.Point(58, 67)
      Me._brightnessTrackBar.Maximum = 100
      Me._brightnessTrackBar.Minimum = -100
      Me._brightnessTrackBar.Name = "_brightnessTrackBar"
      Me._brightnessTrackBar.Size = New System.Drawing.Size(274, 45)
      Me._brightnessTrackBar.TabIndex = 4
      Me._brightnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
      '
      '_okButton
      '
      Me._okButton.DialogResult = System.Windows.Forms.DialogResult.OK
      Me._okButton.Location = New System.Drawing.Point(340, 200)
      Me._okButton.Name = "_okButton"
      Me._okButton.Size = New System.Drawing.Size(75, 23)
      Me._okButton.TabIndex = 2
      Me._okButton.Text = "OK"
      Me._okButton.UseVisualStyleBackColor = True
      '
      '_contrastTrackBar
      '
      Me._contrastTrackBar.LargeChange = 10
      Me._contrastTrackBar.Location = New System.Drawing.Point(58, 16)
      Me._contrastTrackBar.Maximum = 100
      Me._contrastTrackBar.Minimum = -100
      Me._contrastTrackBar.Name = "_contrastTrackBar"
      Me._contrastTrackBar.Size = New System.Drawing.Size(274, 45)
      Me._contrastTrackBar.TabIndex = 1
      Me._contrastTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
      '
      '_contrastLabel
      '
      Me._contrastLabel.AutoSize = True
      Me._contrastLabel.Location = New System.Drawing.Point(6, 16)
      Me._contrastLabel.Name = "_contrastLabel"
      Me._contrastLabel.Size = New System.Drawing.Size(46, 13)
      Me._contrastLabel.TabIndex = 0
      Me._contrastLabel.Text = "&Contrast"
      '
      '_valuesGroupBox
      '
      Me._valuesGroupBox.Controls.Add(Me._intensityValueLabel)
      Me._valuesGroupBox.Controls.Add(Me._brightnessValueLabel)
      Me._valuesGroupBox.Controls.Add(Me._contrastValueLabel)
      Me._valuesGroupBox.Controls.Add(Me._intensityLabel)
      Me._valuesGroupBox.Controls.Add(Me._brightnessLabel)
      Me._valuesGroupBox.Controls.Add(Me._intensityTrackBar)
      Me._valuesGroupBox.Controls.Add(Me._brightnessTrackBar)
      Me._valuesGroupBox.Controls.Add(Me._contrastTrackBar)
      Me._valuesGroupBox.Controls.Add(Me._contrastLabel)
      Me._valuesGroupBox.Location = New System.Drawing.Point(12, 12)
      Me._valuesGroupBox.Name = "_valuesGroupBox"
      Me._valuesGroupBox.Size = New System.Drawing.Size(403, 182)
      Me._valuesGroupBox.TabIndex = 0
      Me._valuesGroupBox.TabStop = False
      '
      '_cancelButton
      '
      Me._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me._cancelButton.Location = New System.Drawing.Point(259, 200)
      Me._cancelButton.Name = "_cancelButton"
      Me._cancelButton.Size = New System.Drawing.Size(75, 23)
      Me._cancelButton.TabIndex = 1
      Me._cancelButton.Text = "Cancel"
      Me._cancelButton.UseVisualStyleBackColor = True
      '
      'ContrastBrightnessIntensityDialog
      '
      Me.AcceptButton = Me._okButton
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me._cancelButton
      Me.ClientSize = New System.Drawing.Size(426, 234)
      Me.Controls.Add(Me._okButton)
      Me.Controls.Add(Me._valuesGroupBox)
      Me.Controls.Add(Me._cancelButton)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "ContrastBrightnessIntensityDialog"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Contrast Brightness Intensity"
      CType(Me._intensityTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me._brightnessTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me._contrastTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
      Me._valuesGroupBox.ResumeLayout(False)
      Me._valuesGroupBox.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents _intensityValueLabel As System.Windows.Forms.Label
   Private WithEvents _brightnessValueLabel As System.Windows.Forms.Label
   Private WithEvents _contrastValueLabel As System.Windows.Forms.Label
   Private WithEvents _intensityLabel As System.Windows.Forms.Label
   Private WithEvents _brightnessLabel As System.Windows.Forms.Label
   Private WithEvents _intensityTrackBar As System.Windows.Forms.TrackBar
   Private WithEvents _brightnessTrackBar As System.Windows.Forms.TrackBar
   Private WithEvents _okButton As System.Windows.Forms.Button
   Private WithEvents _contrastTrackBar As System.Windows.Forms.TrackBar
   Private WithEvents _contrastLabel As System.Windows.Forms.Label
   Private WithEvents _valuesGroupBox As System.Windows.Forms.GroupBox
   Private WithEvents _cancelButton As System.Windows.Forms.Button
End Class
