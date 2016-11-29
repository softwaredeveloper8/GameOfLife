<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnOnOff = New System.Windows.Forms.Button()
        Me.btnStep = New System.Windows.Forms.Button()
        Me.scrollBarSpeed = New System.Windows.Forms.HScrollBar()
        Me.btnClearGrid = New System.Windows.Forms.Button()
        Me.scrollCellSize = New System.Windows.Forms.HScrollBar()
        Me.btnStepBack = New System.Windows.Forms.Button()
        Me.lblGeneration = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.stayAlive1 = New System.Windows.Forms.CheckBox()
        Me.StayAlive2 = New System.Windows.Forms.CheckBox()
        Me.stayAlive3 = New System.Windows.Forms.CheckBox()
        Me.stayAlive4 = New System.Windows.Forms.CheckBox()
        Me.stayAlive5 = New System.Windows.Forms.CheckBox()
        Me.stayAlive6 = New System.Windows.Forms.CheckBox()
        Me.stayAlive7 = New System.Windows.Forms.CheckBox()
        Me.stayAlive8 = New System.Windows.Forms.CheckBox()
        Me.stayAlive0 = New System.Windows.Forms.CheckBox()
        Me.Turn0n = New System.Windows.Forms.GroupBox()
        Me.TurnOn8 = New System.Windows.Forms.CheckBox()
        Me.TurnOn7 = New System.Windows.Forms.CheckBox()
        Me.TurnOn6 = New System.Windows.Forms.CheckBox()
        Me.TurnOn5 = New System.Windows.Forms.CheckBox()
        Me.TurnOn4 = New System.Windows.Forms.CheckBox()
        Me.TurnOn3 = New System.Windows.Forms.CheckBox()
        Me.TurnOn2 = New System.Windows.Forms.CheckBox()
        Me.TurnOn1 = New System.Windows.Forms.CheckBox()
        Me.StayAlive = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.Turn0n.SuspendLayout()
        Me.StayAlive.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        '
        'btnOnOff
        '
        Me.btnOnOff.Location = New System.Drawing.Point(244, 3)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.Size = New System.Drawing.Size(72, 20)
        Me.btnOnOff.TabIndex = 4
        Me.btnOnOff.Text = "Go"
        Me.btnOnOff.UseVisualStyleBackColor = True
        '
        'btnStep
        '
        Me.btnStep.Location = New System.Drawing.Point(322, 3)
        Me.btnStep.Name = "btnStep"
        Me.btnStep.Size = New System.Drawing.Size(65, 20)
        Me.btnStep.TabIndex = 5
        Me.btnStep.Text = "+1"
        Me.btnStep.UseVisualStyleBackColor = True
        '
        'scrollBarSpeed
        '
        Me.scrollBarSpeed.Location = New System.Drawing.Point(428, 2)
        Me.scrollBarSpeed.Minimum = 1
        Me.scrollBarSpeed.Name = "scrollBarSpeed"
        Me.scrollBarSpeed.Size = New System.Drawing.Size(102, 17)
        Me.scrollBarSpeed.TabIndex = 6
        Me.scrollBarSpeed.Value = 50
        '
        'btnClearGrid
        '
        Me.btnClearGrid.Location = New System.Drawing.Point(533, 2)
        Me.btnClearGrid.Name = "btnClearGrid"
        Me.btnClearGrid.Size = New System.Drawing.Size(66, 23)
        Me.btnClearGrid.TabIndex = 10
        Me.btnClearGrid.Text = "Clear"
        Me.btnClearGrid.UseVisualStyleBackColor = True
        '
        'scrollCellSize
        '
        Me.scrollCellSize.Location = New System.Drawing.Point(9, 3)
        Me.scrollCellSize.Maximum = 50
        Me.scrollCellSize.Minimum = 5
        Me.scrollCellSize.Name = "scrollCellSize"
        Me.scrollCellSize.Size = New System.Drawing.Size(102, 17)
        Me.scrollCellSize.TabIndex = 12
        Me.scrollCellSize.Value = 20
        '
        'btnStepBack
        '
        Me.btnStepBack.Location = New System.Drawing.Point(163, 3)
        Me.btnStepBack.Name = "btnStepBack"
        Me.btnStepBack.Size = New System.Drawing.Size(75, 20)
        Me.btnStepBack.TabIndex = 13
        Me.btnStepBack.Text = "-1"
        Me.btnStepBack.UseVisualStyleBackColor = True
        '
        'lblGeneration
        '
        Me.lblGeneration.AutoSize = True
        Me.lblGeneration.Location = New System.Drawing.Point(393, 7)
        Me.lblGeneration.Name = "lblGeneration"
        Me.lblGeneration.Size = New System.Drawing.Size(0, 13)
        Me.lblGeneration.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StayAlive)
        Me.GroupBox1.Controls.Add(Me.Turn0n)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(605, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 653)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rules"
        '
        'stayAlive1
        '
        Me.stayAlive1.AutoSize = True
        Me.stayAlive1.Location = New System.Drawing.Point(20, 42)
        Me.stayAlive1.Name = "stayAlive1"
        Me.stayAlive1.Size = New System.Drawing.Size(32, 17)
        Me.stayAlive1.TabIndex = 0
        Me.stayAlive1.Text = "1"
        Me.stayAlive1.UseVisualStyleBackColor = True
        '
        'StayAlive2
        '
        Me.StayAlive2.AutoSize = True
        Me.StayAlive2.Checked = True
        Me.StayAlive2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StayAlive2.Location = New System.Drawing.Point(20, 65)
        Me.StayAlive2.Name = "StayAlive2"
        Me.StayAlive2.Size = New System.Drawing.Size(32, 17)
        Me.StayAlive2.TabIndex = 1
        Me.StayAlive2.Text = "2"
        Me.StayAlive2.UseVisualStyleBackColor = True
        '
        'stayAlive3
        '
        Me.stayAlive3.AutoSize = True
        Me.stayAlive3.Checked = True
        Me.stayAlive3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.stayAlive3.Location = New System.Drawing.Point(20, 88)
        Me.stayAlive3.Name = "stayAlive3"
        Me.stayAlive3.Size = New System.Drawing.Size(32, 17)
        Me.stayAlive3.TabIndex = 2
        Me.stayAlive3.Text = "3"
        Me.stayAlive3.UseVisualStyleBackColor = True
        '
        'stayAlive4
        '
        Me.stayAlive4.AutoSize = True
        Me.stayAlive4.Location = New System.Drawing.Point(20, 111)
        Me.stayAlive4.Name = "stayAlive4"
        Me.stayAlive4.Size = New System.Drawing.Size(32, 17)
        Me.stayAlive4.TabIndex = 3
        Me.stayAlive4.Text = "4"
        Me.stayAlive4.UseVisualStyleBackColor = True
        '
        'stayAlive5
        '
        Me.stayAlive5.AutoSize = True
        Me.stayAlive5.Location = New System.Drawing.Point(20, 134)
        Me.stayAlive5.Name = "stayAlive5"
        Me.stayAlive5.Size = New System.Drawing.Size(32, 17)
        Me.stayAlive5.TabIndex = 4
        Me.stayAlive5.Text = "5"
        Me.stayAlive5.UseVisualStyleBackColor = True
        '
        'stayAlive6
        '
        Me.stayAlive6.AutoSize = True
        Me.stayAlive6.Location = New System.Drawing.Point(20, 157)
        Me.stayAlive6.Name = "stayAlive6"
        Me.stayAlive6.Size = New System.Drawing.Size(32, 17)
        Me.stayAlive6.TabIndex = 5
        Me.stayAlive6.Text = "6"
        Me.stayAlive6.UseVisualStyleBackColor = True
        '
        'stayAlive7
        '
        Me.stayAlive7.AutoSize = True
        Me.stayAlive7.Location = New System.Drawing.Point(20, 180)
        Me.stayAlive7.Name = "stayAlive7"
        Me.stayAlive7.Size = New System.Drawing.Size(32, 17)
        Me.stayAlive7.TabIndex = 6
        Me.stayAlive7.Text = "7"
        Me.stayAlive7.UseVisualStyleBackColor = True
        '
        'stayAlive8
        '
        Me.stayAlive8.AutoSize = True
        Me.stayAlive8.Location = New System.Drawing.Point(20, 203)
        Me.stayAlive8.Name = "stayAlive8"
        Me.stayAlive8.Size = New System.Drawing.Size(32, 17)
        Me.stayAlive8.TabIndex = 7
        Me.stayAlive8.Text = "8"
        Me.stayAlive8.UseVisualStyleBackColor = True
        '
        'stayAlive0
        '
        Me.stayAlive0.AutoSize = True
        Me.stayAlive0.Location = New System.Drawing.Point(20, 19)
        Me.stayAlive0.Name = "stayAlive0"
        Me.stayAlive0.Size = New System.Drawing.Size(32, 17)
        Me.stayAlive0.TabIndex = 8
        Me.stayAlive0.Text = "0"
        Me.stayAlive0.UseVisualStyleBackColor = True
        '
        'Turn0n
        '
        Me.Turn0n.Controls.Add(Me.TurnOn8)
        Me.Turn0n.Controls.Add(Me.TurnOn7)
        Me.Turn0n.Controls.Add(Me.TurnOn6)
        Me.Turn0n.Controls.Add(Me.TurnOn5)
        Me.Turn0n.Controls.Add(Me.TurnOn4)
        Me.Turn0n.Controls.Add(Me.TurnOn3)
        Me.Turn0n.Controls.Add(Me.TurnOn2)
        Me.Turn0n.Controls.Add(Me.TurnOn1)
        Me.Turn0n.Location = New System.Drawing.Point(14, 283)
        Me.Turn0n.Name = "Turn0n"
        Me.Turn0n.Size = New System.Drawing.Size(67, 212)
        Me.Turn0n.TabIndex = 16
        Me.Turn0n.TabStop = False
        Me.Turn0n.Text = "Turn on"
        '
        'TurnOn8
        '
        Me.TurnOn8.AutoSize = True
        Me.TurnOn8.Location = New System.Drawing.Point(20, 180)
        Me.TurnOn8.Name = "TurnOn8"
        Me.TurnOn8.Size = New System.Drawing.Size(32, 17)
        Me.TurnOn8.TabIndex = 7
        Me.TurnOn8.Text = "8"
        Me.TurnOn8.UseVisualStyleBackColor = True
        '
        'TurnOn7
        '
        Me.TurnOn7.AutoSize = True
        Me.TurnOn7.Location = New System.Drawing.Point(20, 157)
        Me.TurnOn7.Name = "TurnOn7"
        Me.TurnOn7.Size = New System.Drawing.Size(32, 17)
        Me.TurnOn7.TabIndex = 6
        Me.TurnOn7.Text = "7"
        Me.TurnOn7.UseVisualStyleBackColor = True
        '
        'TurnOn6
        '
        Me.TurnOn6.AutoSize = True
        Me.TurnOn6.Location = New System.Drawing.Point(20, 134)
        Me.TurnOn6.Name = "TurnOn6"
        Me.TurnOn6.Size = New System.Drawing.Size(32, 17)
        Me.TurnOn6.TabIndex = 5
        Me.TurnOn6.Text = "6"
        Me.TurnOn6.UseVisualStyleBackColor = True
        '
        'TurnOn5
        '
        Me.TurnOn5.AutoSize = True
        Me.TurnOn5.Location = New System.Drawing.Point(20, 111)
        Me.TurnOn5.Name = "TurnOn5"
        Me.TurnOn5.Size = New System.Drawing.Size(32, 17)
        Me.TurnOn5.TabIndex = 4
        Me.TurnOn5.Text = "5"
        Me.TurnOn5.UseVisualStyleBackColor = True
        '
        'TurnOn4
        '
        Me.TurnOn4.AutoSize = True
        Me.TurnOn4.Location = New System.Drawing.Point(20, 88)
        Me.TurnOn4.Name = "TurnOn4"
        Me.TurnOn4.Size = New System.Drawing.Size(32, 17)
        Me.TurnOn4.TabIndex = 3
        Me.TurnOn4.Text = "4"
        Me.TurnOn4.UseVisualStyleBackColor = True
        '
        'TurnOn3
        '
        Me.TurnOn3.AutoSize = True
        Me.TurnOn3.Checked = True
        Me.TurnOn3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TurnOn3.Location = New System.Drawing.Point(20, 65)
        Me.TurnOn3.Name = "TurnOn3"
        Me.TurnOn3.Size = New System.Drawing.Size(32, 17)
        Me.TurnOn3.TabIndex = 2
        Me.TurnOn3.Text = "3"
        Me.TurnOn3.UseVisualStyleBackColor = True
        '
        'TurnOn2
        '
        Me.TurnOn2.AutoSize = True
        Me.TurnOn2.Location = New System.Drawing.Point(20, 42)
        Me.TurnOn2.Name = "TurnOn2"
        Me.TurnOn2.Size = New System.Drawing.Size(32, 17)
        Me.TurnOn2.TabIndex = 1
        Me.TurnOn2.Text = "2"
        Me.TurnOn2.UseVisualStyleBackColor = True
        '
        'TurnOn1
        '
        Me.TurnOn1.AutoSize = True
        Me.TurnOn1.Location = New System.Drawing.Point(20, 19)
        Me.TurnOn1.Name = "TurnOn1"
        Me.TurnOn1.Size = New System.Drawing.Size(32, 17)
        Me.TurnOn1.TabIndex = 0
        Me.TurnOn1.Text = "1"
        Me.TurnOn1.UseVisualStyleBackColor = True
        '
        'StayAlive
        '
        Me.StayAlive.Controls.Add(Me.stayAlive0)
        Me.StayAlive.Controls.Add(Me.stayAlive1)
        Me.StayAlive.Controls.Add(Me.stayAlive8)
        Me.StayAlive.Controls.Add(Me.StayAlive2)
        Me.StayAlive.Controls.Add(Me.stayAlive7)
        Me.StayAlive.Controls.Add(Me.stayAlive3)
        Me.StayAlive.Controls.Add(Me.stayAlive6)
        Me.StayAlive.Controls.Add(Me.stayAlive4)
        Me.StayAlive.Controls.Add(Me.stayAlive5)
        Me.StayAlive.Location = New System.Drawing.Point(14, 19)
        Me.StayAlive.Name = "StayAlive"
        Me.StayAlive.Size = New System.Drawing.Size(67, 243)
        Me.StayAlive.TabIndex = 16
        Me.StayAlive.TabStop = False
        Me.StayAlive.Text = "Stay On"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 653)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblGeneration)
        Me.Controls.Add(Me.btnStepBack)
        Me.Controls.Add(Me.scrollCellSize)
        Me.Controls.Add(Me.btnClearGrid)
        Me.Controls.Add(Me.scrollBarSpeed)
        Me.Controls.Add(Me.btnStep)
        Me.Controls.Add(Me.btnOnOff)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game of Life"
        Me.GroupBox1.ResumeLayout(False)
        Me.Turn0n.ResumeLayout(False)
        Me.Turn0n.PerformLayout()
        Me.StayAlive.ResumeLayout(False)
        Me.StayAlive.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents btnOnOff As System.Windows.Forms.Button
    Friend WithEvents btnStep As System.Windows.Forms.Button
    Friend WithEvents scrollBarSpeed As System.Windows.Forms.HScrollBar
    Friend WithEvents btnClearGrid As System.Windows.Forms.Button
    Friend WithEvents scrollCellSize As System.Windows.Forms.HScrollBar
    Friend WithEvents btnStepBack As System.Windows.Forms.Button
    Friend WithEvents lblGeneration As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents stayAlive8 As System.Windows.Forms.CheckBox
    Friend WithEvents stayAlive7 As System.Windows.Forms.CheckBox
    Friend WithEvents stayAlive6 As System.Windows.Forms.CheckBox
    Friend WithEvents stayAlive5 As System.Windows.Forms.CheckBox
    Friend WithEvents stayAlive4 As System.Windows.Forms.CheckBox
    Friend WithEvents stayAlive3 As System.Windows.Forms.CheckBox
    Friend WithEvents StayAlive2 As System.Windows.Forms.CheckBox
    Friend WithEvents stayAlive1 As System.Windows.Forms.CheckBox
    Friend WithEvents stayAlive0 As System.Windows.Forms.CheckBox
    Friend WithEvents StayAlive As System.Windows.Forms.GroupBox
    Friend WithEvents Turn0n As System.Windows.Forms.GroupBox
    Friend WithEvents TurnOn8 As System.Windows.Forms.CheckBox
    Friend WithEvents TurnOn7 As System.Windows.Forms.CheckBox
    Friend WithEvents TurnOn6 As System.Windows.Forms.CheckBox
    Friend WithEvents TurnOn5 As System.Windows.Forms.CheckBox
    Friend WithEvents TurnOn4 As System.Windows.Forms.CheckBox
    Friend WithEvents TurnOn3 As System.Windows.Forms.CheckBox
    Friend WithEvents TurnOn2 As System.Windows.Forms.CheckBox
    Friend WithEvents TurnOn1 As System.Windows.Forms.CheckBox

End Class
