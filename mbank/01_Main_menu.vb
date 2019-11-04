Public Class Main_menu

    Private Sub Binfo_Click(sender As Object, e As EventArgs) Handles Binfo.Click
        Dim x As New Info_rek
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Btrans_Click(sender As Object, e As EventArgs) Handles Btrans.Click
        Dim x As New transfer
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Bpay_Click(sender As Object, e As EventArgs) Handles Bpay.Click
        Dim x As New Pay_up
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Bacc_Click(sender As Object, e As EventArgs) Handles Bacc.Click
        Dim x As New U_Sett
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Bwall_Click(sender As Object, e As EventArgs) Handles Bwall.Click
        Dim x As New E_Wallet
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Bcomm_Click(sender As Object, e As EventArgs) Handles Bcomm.Click
        Dim x As New E_Commerce
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New Inbox
        x.Show()
        Me.Hide()
    End Sub

End Class