Public Class trans_a_rekening
    Private source As transfer

    Public Sub New(x)
        source = x
        InitializeComponent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub trans_a_rekening_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        source.Show()
    End Sub

End Class