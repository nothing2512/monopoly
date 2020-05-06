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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Dice1 = New System.Windows.Forms.PictureBox()
        Me.Dice2 = New System.Windows.Forms.PictureBox()
        Me.BtRollDice = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(664, 667)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Monopoly.My.Resources.Resources.player_black
        Me.PictureBox2.Location = New System.Drawing.Point(615, 614)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Dice1
        '
        Me.Dice1.Image = Global.Monopoly.My.Resources.Resources.dice_1
        Me.Dice1.Location = New System.Drawing.Point(173, 125)
        Me.Dice1.Name = "Dice1"
        Me.Dice1.Size = New System.Drawing.Size(126, 121)
        Me.Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Dice1.TabIndex = 2
        Me.Dice1.TabStop = False
        '
        'Dice2
        '
        Me.Dice2.Image = Global.Monopoly.My.Resources.Resources.dice_1
        Me.Dice2.Location = New System.Drawing.Point(374, 267)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(126, 121)
        Me.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Dice2.TabIndex = 3
        Me.Dice2.TabStop = False
        '
        'BtRollDice
        '
        Me.BtRollDice.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!)
        Me.BtRollDice.Location = New System.Drawing.Point(144, 434)
        Me.BtRollDice.Name = "BtRollDice"
        Me.BtRollDice.Size = New System.Drawing.Size(412, 121)
        Me.BtRollDice.TabIndex = 4
        Me.BtRollDice.Text = "Roll Dice"
        Me.BtRollDice.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.BtRollDice)
        Me.Controls.Add(Me.Dice2)
        Me.Controls.Add(Me.Dice1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Dice1 As PictureBox
    Friend WithEvents Dice2 As PictureBox
    Friend WithEvents BtRollDice As Button
End Class
