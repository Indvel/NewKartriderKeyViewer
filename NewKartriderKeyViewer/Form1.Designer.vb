<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.info = New System.Windows.Forms.Label()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.alt = New System.Windows.Forms.PictureBox()
        Me.down = New System.Windows.Forms.PictureBox()
        Me.right = New System.Windows.Forms.PictureBox()
        Me.up = New System.Windows.Forms.PictureBox()
        Me.ctrl = New System.Windows.Forms.PictureBox()
        Me.shift = New System.Windows.Forms.PictureBox()
        Me.left = New System.Windows.Forms.PictureBox()
        Me.keyZ = New System.Windows.Forms.PictureBox()
        Me.keyR = New System.Windows.Forms.PictureBox()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.down, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.up, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.info.ForeColor = System.Drawing.Color.Gray
        Me.info.Location = New System.Drawing.Point(11, 152)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(0, 13)
        Me.info.TabIndex = 11
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Processor"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "_Total"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'alt
        '
        Me.alt.Image = Global.NewKartriderKeyViewer.My.Resources.Resources.key_alt_normal1
        Me.alt.Location = New System.Drawing.Point(107, 95)
        Me.alt.Name = "alt"
        Me.alt.Size = New System.Drawing.Size(79, 50)
        Me.alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alt.TabIndex = 12
        Me.alt.TabStop = False
        '
        'down
        '
        Me.down.BackColor = System.Drawing.Color.Transparent
        Me.down.Image = Global.NewKartriderKeyViewer.My.Resources.Resources.key_down_normal
        Me.down.Location = New System.Drawing.Point(265, 95)
        Me.down.Name = "down"
        Me.down.Size = New System.Drawing.Size(50, 50)
        Me.down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.down.TabIndex = 5
        Me.down.TabStop = False
        '
        'right
        '
        Me.right.BackColor = System.Drawing.Color.Transparent
        Me.right.Image = Global.NewKartriderKeyViewer.My.Resources.Resources.key_right_normal
        Me.right.Location = New System.Drawing.Point(321, 95)
        Me.right.Name = "right"
        Me.right.Size = New System.Drawing.Size(50, 50)
        Me.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.right.TabIndex = 7
        Me.right.TabStop = False
        '
        'up
        '
        Me.up.BackColor = System.Drawing.Color.Transparent
        Me.up.Image = Global.NewKartriderKeyViewer.My.Resources.Resources.key_up_normal
        Me.up.Location = New System.Drawing.Point(265, 39)
        Me.up.Name = "up"
        Me.up.Size = New System.Drawing.Size(50, 50)
        Me.up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.up.TabIndex = 8
        Me.up.TabStop = False
        '
        'ctrl
        '
        Me.ctrl.BackColor = System.Drawing.Color.Transparent
        Me.ctrl.Image = Global.NewKartriderKeyViewer.My.Resources.Resources.key_ctrl_normal
        Me.ctrl.Location = New System.Drawing.Point(22, 95)
        Me.ctrl.Name = "ctrl"
        Me.ctrl.Size = New System.Drawing.Size(79, 50)
        Me.ctrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ctrl.TabIndex = 6
        Me.ctrl.TabStop = False
        '
        'shift
        '
        Me.shift.BackColor = System.Drawing.Color.Transparent
        Me.shift.Image = Global.NewKartriderKeyViewer.My.Resources.Resources.key_shift_normal
        Me.shift.Location = New System.Drawing.Point(22, 39)
        Me.shift.Name = "shift"
        Me.shift.Size = New System.Drawing.Size(110, 50)
        Me.shift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shift.TabIndex = 9
        Me.shift.TabStop = False
        '
        'left
        '
        Me.left.BackColor = System.Drawing.Color.Transparent
        Me.left.Image = Global.NewKartriderKeyViewer.My.Resources.Resources.key_left_normal
        Me.left.Location = New System.Drawing.Point(209, 95)
        Me.left.Name = "left"
        Me.left.Size = New System.Drawing.Size(50, 50)
        Me.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.left.TabIndex = 10
        Me.left.TabStop = False
        '
        'keyZ
        '
        Me.keyZ.Image = Global.NewKartriderKeyViewer.My.Resources.Resources.key_z_normal
        Me.keyZ.Location = New System.Drawing.Point(145, 39)
        Me.keyZ.Name = "keyZ"
        Me.keyZ.Size = New System.Drawing.Size(50, 50)
        Me.keyZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.keyZ.TabIndex = 13
        Me.keyZ.TabStop = False
        '
        'keyR
        '
        Me.keyR.Image = Global.NewKartriderKeyViewer.My.Resources.Resources.key_r_normal
        Me.keyR.Location = New System.Drawing.Point(201, 39)
        Me.keyR.Name = "keyR"
        Me.keyR.Size = New System.Drawing.Size(50, 50)
        Me.keyR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.keyR.TabIndex = 13
        Me.keyR.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(393, 169)
        Me.Controls.Add(Me.keyR)
        Me.Controls.Add(Me.keyZ)
        Me.Controls.Add(Me.alt)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.down)
        Me.Controls.Add(Me.right)
        Me.Controls.Add(Me.up)
        Me.Controls.Add(Me.ctrl)
        Me.Controls.Add(Me.shift)
        Me.Controls.Add(Me.left)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Kartrider Keyboard Viewer"
        Me.TransparencyKey = System.Drawing.Color.Silver
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.down, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.up, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents down As System.Windows.Forms.PictureBox
    Friend WithEvents PerformanceCounter1 As System.Diagnostics.PerformanceCounter
    Friend WithEvents right As System.Windows.Forms.PictureBox
    Friend WithEvents up As System.Windows.Forms.PictureBox
    Friend WithEvents ctrl As System.Windows.Forms.PictureBox
    Friend WithEvents shift As System.Windows.Forms.PictureBox
    Friend WithEvents left As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents alt As System.Windows.Forms.PictureBox
    Friend WithEvents keyZ As System.Windows.Forms.PictureBox
    Friend WithEvents keyR As System.Windows.Forms.PictureBox

End Class
