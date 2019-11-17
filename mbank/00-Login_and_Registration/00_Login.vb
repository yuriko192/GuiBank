Imports System.Security.Cryptography
Imports System.Text

Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim x = Me.USER_ACCTableAdapter.GetUserBy( vbNull, vbNull)

        'Dim password = PassBox.Text
        'Dim sha As SHA1 = New SHA1Managed()
        'Dim result As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes(password))
        'UnameBox.Text = Encoding.Default.GetString(result).Length

        main_m = New Main_menu()
        main_m.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TugasBankUasDataSet.USER_ACC' table. You can move, or remove it, as needed.
        Me.USER_ACCTableAdapter.Fill(Me.TugasBankUasDataSet.USER_ACC)

    End Sub

End Class