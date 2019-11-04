Public Class muta_masuk
    Dim source As Info_rek

    Public Sub New(x)
        source = x
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub muta_masuk_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        source.Show()
    End Sub

End Class