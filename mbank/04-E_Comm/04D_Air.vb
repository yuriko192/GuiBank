Public Class Air
    Dim source As E_Commerce

    Public Sub New(x)
        source = x
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Air_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        source.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New Biaya_air(Me)
        x.Show()
        Me.Hide()
    End Sub

End Class