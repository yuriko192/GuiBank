Public Class info_kartu
    Dim source As atur_kartu

    Public Sub New(x)
        source = x
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Label2.Text = "401" Then
            Label2.Text = "CVV"
        Else
            Label2.Text = "401"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub info_kartu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        source.Show()
    End Sub

End Class