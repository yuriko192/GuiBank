Public Class U_Sett

    Private Sub U_Sett_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        main_m.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As New atur_kartu(Me)
        x.Show()
        Me.Hide()
    End Sub

End Class