Public Class Info_rek

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Info_rek_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        main_m.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New muta_masuk(Me)
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New muta_keluar(Me)
        x.Show()
        Me.Hide()
    End Sub

End Class