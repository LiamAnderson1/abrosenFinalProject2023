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
        Me.PB1Grass = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PBCar = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBFin = New System.Windows.Forms.PictureBox()
        Me.LBHalf = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.PB1Grass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB1Grass
        '
        Me.PB1Grass.Image = Global.Anderson_Racer.My.Resources.Resources.Grass
        Me.PB1Grass.Location = New System.Drawing.Point(0, 27)
        Me.PB1Grass.Name = "PB1Grass"
        Me.PB1Grass.Size = New System.Drawing.Size(64, 750)
        Me.PB1Grass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB1Grass.TabIndex = 0
        Me.PB1Grass.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anderson_Racer.My.Resources.Resources.Grass
        Me.PictureBox1.Location = New System.Drawing.Point(60, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1311, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Anderson_Racer.My.Resources.Resources.Grass
        Me.PictureBox2.Location = New System.Drawing.Point(1307, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 750)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Anderson_Racer.My.Resources.Resources.Grass
        Me.PictureBox3.Location = New System.Drawing.Point(60, 718)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1311, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Anderson_Racer.My.Resources.Resources.Grass
        Me.PictureBox4.Location = New System.Drawing.Point(276, 294)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(690, 204)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PBCar
        '
        Me.PBCar.BackColor = System.Drawing.Color.Transparent
        Me.PBCar.Image = Global.Anderson_Racer.My.Resources.Resources.carLEFT
        Me.PBCar.Location = New System.Drawing.Point(601, 143)
        Me.PBCar.Name = "PBCar"
        Me.PBCar.Size = New System.Drawing.Size(128, 64)
        Me.PBCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBCar.TabIndex = 5
        Me.PBCar.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 52)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "0"
        '
        'PBFin
        '
        Me.PBFin.Image = Global.Anderson_Racer.My.Resources.Resources.Finish_Line
        Me.PBFin.Location = New System.Drawing.Point(764, 55)
        Me.PBFin.Name = "PBFin"
        Me.PBFin.Size = New System.Drawing.Size(133, 242)
        Me.PBFin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFin.TabIndex = 8
        Me.PBFin.TabStop = False
        '
        'LBHalf
        '
        Me.LBHalf.BackColor = System.Drawing.Color.Transparent
        Me.LBHalf.Location = New System.Drawing.Point(687, 501)
        Me.LBHalf.Name = "LBHalf"
        Me.LBHalf.Size = New System.Drawing.Size(23, 214)
        Me.LBHalf.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anderson_Racer.My.Resources.Resources.Asphalt
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBCar)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PB1Grass)
        Me.Controls.Add(Me.LBHalf)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PBFin)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PB1Grass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB1Grass As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PBCar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PBFin As PictureBox
    Friend WithEvents LBHalf As Label
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
