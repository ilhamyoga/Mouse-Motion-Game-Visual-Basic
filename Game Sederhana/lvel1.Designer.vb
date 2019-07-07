<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lvel1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.b7 = New System.Windows.Forms.PictureBox()
        Me.tmr = New System.Windows.Forms.Label()
        Me.foul = New System.Windows.Forms.TextBox()
        Me.finish = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.b5 = New System.Windows.Forms.PictureBox()
        Me.kembali = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Panel()
        Me.b1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b6 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.b4 = New System.Windows.Forms.Panel()
        CType(Me.b7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'b7
        '
        Me.b7.BackColor = System.Drawing.Color.Black
        Me.b7.Location = New System.Drawing.Point(383, 247)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(605, 255)
        Me.b7.TabIndex = 215
        Me.b7.TabStop = False
        '
        'tmr
        '
        Me.tmr.AutoSize = True
        Me.tmr.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmr.Location = New System.Drawing.Point(52, 668)
        Me.tmr.Name = "tmr"
        Me.tmr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tmr.Size = New System.Drawing.Size(159, 65)
        Me.tmr.TabIndex = 214
        Me.tmr.Text = "00:00"
        '
        'foul
        '
        Me.foul.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foul.Location = New System.Drawing.Point(250, 668)
        Me.foul.Multiline = True
        Me.foul.Name = "foul"
        Me.foul.ReadOnly = True
        Me.foul.Size = New System.Drawing.Size(100, 61)
        Me.foul.TabIndex = 213
        Me.foul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'finish
        '
        Me.finish.BackColor = System.Drawing.Color.White
        Me.finish.BackgroundImage = Global.Game_Sederhana.My.Resources.Resources.full1
        Me.finish.Location = New System.Drawing.Point(1250, 537)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(91, 67)
        Me.finish.TabIndex = 212
        Me.finish.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(542, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 65)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "LEVEL 1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox1.Location = New System.Drawing.Point(25, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1316, 76)
        Me.PictureBox1.TabIndex = 210
        Me.PictureBox1.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Blue
        Me.Player.Location = New System.Drawing.Point(66, 185)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(25, 25)
        Me.Player.TabIndex = 209
        Me.Player.TabStop = False
        '
        'b5
        '
        Me.b5.BackColor = System.Drawing.Color.Black
        Me.b5.Location = New System.Drawing.Point(129, 151)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(125, 351)
        Me.b5.TabIndex = 208
        Me.b5.TabStop = False
        '
        'kembali
        '
        Me.kembali.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.kembali.FlatAppearance.BorderSize = 0
        Me.kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kembali.ForeColor = System.Drawing.SystemColors.Window
        Me.kembali.Location = New System.Drawing.Point(1143, 674)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(168, 51)
        Me.kembali.TabIndex = 205
        Me.kembali.Text = "BACK"
        Me.kembali.UseVisualStyleBackColor = False
        '
        'b2
        '
        Me.b2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.b2.Location = New System.Drawing.Point(0, 25)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(25, 718)
        Me.b2.TabIndex = 204
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.b3.Location = New System.Drawing.Point(1341, 25)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(25, 718)
        Me.b3.TabIndex = 203
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.b1.Location = New System.Drawing.Point(25, 101)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(1316, 50)
        Me.b1.TabIndex = 201
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(0, 743)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 25)
        Me.Panel2.TabIndex = 202
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 25)
        Me.Panel1.TabIndex = 200
        '
        'b6
        '
        Me.b6.BackColor = System.Drawing.Color.Black
        Me.b6.Location = New System.Drawing.Point(1115, 247)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(135, 357)
        Me.b6.TabIndex = 207
        Me.b6.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'b4
        '
        Me.b4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.b4.Location = New System.Drawing.Point(25, 604)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(1316, 50)
        Me.b4.TabIndex = 206
        '
        'lvel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.b7)
        Me.Controls.Add(Me.tmr)
        Me.Controls.Add(Me.foul)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.b5)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.b6)
        Me.Controls.Add(Me.b4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "lvel1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lvel1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.b7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b4 As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents b6 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents b1 As Panel
    Friend WithEvents b3 As Panel
    Friend WithEvents b2 As Panel
    Friend WithEvents kembali As Button
    Friend WithEvents b5 As PictureBox
    Friend WithEvents Player As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents finish As PictureBox
    Friend WithEvents foul As TextBox
    Friend WithEvents tmr As Label
    Friend WithEvents b7 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
