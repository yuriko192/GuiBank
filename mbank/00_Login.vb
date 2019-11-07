Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = UIDbox.Text
        Dim password = Passbox.Text
        Me.UserTableTableAdapter.Typea()
        main_m = New Main_menu()
        main_m.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.UserTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.DataSet1.UserTable)

    End Sub

End Class