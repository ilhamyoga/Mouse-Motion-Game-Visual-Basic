<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.judul = New System.Windows.Forms.Label()
        Me.play = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.player2 = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.player3 = New System.Windows.Forms.Panel()
        Me.rpl = New System.Windows.Forms.Label()
        Me.tutorial = New System.Windows.Forms.Button()
        Me.keluar = New System.Windows.Forms.Button()
        Me.player1 = New System.Windows.Forms.Panel()
        Me.player4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 25)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(0, 743)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 25)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(25, 75)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1316, 50)
        Me.Panel5.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Location = New System.Drawing.Point(25, 648)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1316, 50)
        Me.Panel6.TabIndex = 2
        '
        'judul
        '
        Me.judul.AutoSize = True
        Me.judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul.Location = New System.Drawing.Point(257, 234)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(820, 108)
        Me.judul.TabIndex = 3
        Me.judul.Text = "MOUSE MOTION"
        '
        'play
        '
        Me.play.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.play.FlatAppearance.BorderSize = 0
        Me.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.play.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.play.ForeColor = System.Drawing.SystemColors.Window
        Me.play.Location = New System.Drawing.Point(153, 447)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(300, 75)
        Me.play.TabIndex = 4
        Me.play.Text = "PLAY"
        Me.play.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'player2
        '
        Me.player2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.player2.Location = New System.Drawing.Point(1316, 138)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(25, 25)
        Me.player2.TabIndex = 6
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 25
        '
        'player3
        '
        Me.player3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.player3.Location = New System.Drawing.Point(25, 608)
        Me.player3.Name = "player3"
        Me.player3.Size = New System.Drawing.Size(25, 25)
        Me.player3.TabIndex = 7
        '
        'rpl
        '
        Me.rpl.AutoSize = True
        Me.rpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rpl.Location = New System.Drawing.Point(25, 365)
        Me.rpl.Name = "rpl"
        Me.rpl.Size = New System.Drawing.Size(361, 25)
        Me.rpl.TabIndex = 8
        Me.rpl.Text = "REKAYASA PERANGKAT LUNAK"
        '
        'tutorial
        '
        Me.tutorial.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tutorial.FlatAppearance.BorderSize = 0
        Me.tutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tutorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tutorial.ForeColor = System.Drawing.SystemColors.Window
        Me.tutorial.Location = New System.Drawing.Point(518, 447)
        Me.tutorial.Name = "tutorial"
        Me.tutorial.Size = New System.Drawing.Size(300, 75)
        Me.tutorial.TabIndex = 9
        Me.tutorial.Text = "TUTORIAL"
        Me.tutorial.UseVisualStyleBackColor = False
        '
        'keluar
        '
        Me.keluar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.keluar.FlatAppearance.BorderSize = 0
        Me.keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluar.ForeColor = System.Drawing.SystemColors.Window
        Me.keluar.Location = New System.Drawing.Point(882, 447)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(300, 75)
        Me.keluar.TabIndex = 10
        Me.keluar.Text = "EXIT"
        Me.keluar.UseVisualStyleBackColor = False
        '
        'player1
        '
        Me.player1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.player1.Location = New System.Drawing.Point(25, 38)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(25, 25)
        Me.player1.TabIndex = 11
        '
        'player4
        '
        Me.player4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.player4.Location = New System.Drawing.Point(1316, 708)
        Me.player4.Name = "player4"
        Me.player4.Size = New System.Drawing.Size(25, 25)
        Me.player4.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(1341, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(25, 718)
        Me.Panel3.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(0, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(25, 718)
        Me.Panel4.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.player4)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.tutorial)
        Me.Controls.Add(Me.rpl)
        Me.Controls.Add(Me.player3)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.judul)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents judul As Label
    Friend WithEvents play As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents player2 As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents player3 As Panel
    Friend WithEvents rpl As Label
    Friend WithEvents tutorial As Button
    Friend WithEvents keluar As Button
    Friend WithEvents player1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents player4 As Panel
    Friend WithEvents Panel4 As Panel
End Class
