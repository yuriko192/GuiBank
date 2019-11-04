Public Class E_Wallet

    Private Sub E_Wallet_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        main_m.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New Top_Up(Me)
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New Tambah_EWallet(Me)
        x.Show()
        Me.Hide()
    End Sub

End Class