<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transfer))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mbank.My.Resources.Resources.tran
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.mbank.My.Resources.Resources.tran
        Me.PictureBox2.Location = New System.Drawing.Point(377, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "=== Transfer ==="
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(432, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Tambah Daftar Rekening"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Button12)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.VScrollBar1)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 251)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Daftar Rekening"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(6, 219)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(391, 23)
        Me.Button12.TabIndex = 8
        Me.Button12.Text = "No Rekening H - Nama"
        Me.Button12.UseVisualStyleBackColor = true
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(6, 191)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(391, 23)
        Me.Button10.TabIndex = 7
        Me.Button10.Text = "No Rekening G - Nama"
        Me.Button10.UseVisualStyleBackColor = true
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 163)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(391, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "No Rekening F - Nama"
        Me.Button7.UseVisualStyleBackColor = true
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 135)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(391, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "No Rekening E - Nama"
        Me.Button6.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 107)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(391, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "No Rekening D - Nama"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 79)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(391, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "No Rekening C - Nama"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(391, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "No Rekening B - Nama"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(390, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "No Rekening A - Nama"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(400, 19)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(26, 225)
        Me.VScrollBar1.TabIndex = 0
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button8.Location = New System.Drawing.Point(12, 483)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 37)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Back"
        Me.Button8.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 26)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "Search Here"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button9.Location = New System.Drawing.Point(357, 142)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(88, 26)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Search"
        Me.Button9.UseVisualStyleBackColor = true
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button11.Location = New System.Drawing.Point(12, 436)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(427, 41)
        Me.Button11.TabIndex = 12
        Me.Button11.Text = "Transfer Antar Bank"
        Me.Button11.UseVisualStyleBackColor = true
        '
        'transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(457, 532)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "transfer"
        Me.Text = "Transfer"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
End Class
