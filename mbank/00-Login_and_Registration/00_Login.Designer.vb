<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnameBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.USERACCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TugasBankUasDataSet = New mbank.TugasBankUasDataSet()
        Me.USER_ACCTableAdapter = New mbank.TugasBankUasDataSetTableAdapters.USER_ACCTableAdapter()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.USERACCBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TugasBankUasDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.PictureBox1.Image = Global.mbank.My.Resources.Resources.SPW
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 292)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'UnameBox
        '
        Me.UnameBox.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UnameBox.Location = New System.Drawing.Point(111, 328)
        Me.UnameBox.Name = "UnameBox"
        Me.UnameBox.Size = New System.Drawing.Size(207, 23)
        Me.UnameBox.TabIndex = 3
        '
        'PassBox
        '
        Me.PassBox.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PassBox.Location = New System.Drawing.Point(111, 357)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassBox.Size = New System.Drawing.Size(207, 23)
        Me.PassBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.Location = New System.Drawing.Point(235, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 31)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.Location = New System.Drawing.Point(11, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 31)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Daftar"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'USERACCBindingSource
        '
        Me.USERACCBindingSource.DataMember = "USER_ACC"
        Me.USERACCBindingSource.DataSource = Me.TugasBankUasDataSet
        '
        'TugasBankUasDataSet
        '
        Me.TugasBankUasDataSet.DataSetName = "TugasBankUasDataSet"
        Me.TugasBankUasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USER_ACCTableAdapter
        '
        Me.USER_ACCTableAdapter.ClearBeforeFill = true
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(330, 431)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UnameBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.USERACCBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TugasBankUasDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UnameBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TugasBankUasDataSet As TugasBankUasDataSet
    Friend WithEvents USERACCBindingSource As BindingSource
    Friend WithEvents USER_ACCTableAdapter As TugasBankUasDataSetTableAdapters.USER_ACCTableAdapter
End Class
