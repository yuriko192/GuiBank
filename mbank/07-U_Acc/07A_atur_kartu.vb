Public Class atur_kartu
    Dim source As U_Sett

    Public Sub New(x)
        source = x
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New info_kartu(Me)
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub atur_kartu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        source.Show()
    End Sub

End Class