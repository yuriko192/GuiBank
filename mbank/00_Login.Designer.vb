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
        Me.UIDbox = New System.Windows.Forms.TextBox()
        Me.Passbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NoRekeningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandphoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New mbank.DataSet1()
        Me.UserTableTableAdapter = New mbank.DataSet1TableAdapters.UserTableTableAdapter()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UserTableBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataSet1,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID"
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
        'UIDbox
        '
        Me.UIDbox.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UIDbox.Location = New System.Drawing.Point(111, 328)
        Me.UIDbox.Name = "UIDbox"
        Me.UIDbox.Size = New System.Drawing.Size(207, 23)
        Me.UIDbox.TabIndex = 3
        '
        'Passbox
        '
        Me.Passbox.Font = New System.Drawing.Font("MS Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Passbox.Location = New System.Drawing.Point(111, 357)
        Me.Passbox.Name = "Passbox"
        Me.Passbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passbox.Size = New System.Drawing.Size(207, 23)
        Me.Passbox.TabIndex = 4
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = false
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoRekeningDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.HandphoneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(361, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'NoRekeningDataGridViewTextBoxColumn
        '
        Me.NoRekeningDataGridViewTextBoxColumn.DataPropertyName = "NoRekening"
        Me.NoRekeningDataGridViewTextBoxColumn.HeaderText = "NoRekening"
        Me.NoRekeningDataGridViewTextBoxColumn.Name = "NoRekeningDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'HandphoneDataGridViewTextBoxColumn
        '
        Me.HandphoneDataGridViewTextBoxColumn.DataPropertyName = "Handphone"
        Me.HandphoneDataGridViewTextBoxColumn.HeaderText = "Handphone"
        Me.HandphoneDataGridViewTextBoxColumn.Name = "HandphoneDataGridViewTextBoxColumn"
        '
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "UserTable"
        Me.UserTableBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableTableAdapter
        '
        Me.UserTableTableAdapter.ClearBeforeFill = true
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(330, 431)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Passbox)
        Me.Controls.Add(Me.UIDbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UserTableBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataSet1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UIDbox As TextBox
    Friend WithEvents Passbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents UserTableBindingSource As BindingSource
    Friend WithEvents UserTableTableAdapter As DataSet1TableAdapters.UserTableTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NoRekeningDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HandphoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
