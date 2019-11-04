Public Class Pay_up

    Private Sub Pay_up_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        main_m.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New OpenFileDialog
        x.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As New Pay_up_trf("Email", Me)
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New Pay_up_trf("No Telephone", Me)
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim x As New Pay_up_trf("No Rekening", Me)
        x.Show()
        Me.Hide()
    End Sub

End Class