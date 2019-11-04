Public Class Pay_up_trf
    Dim source As Pay_up

    Public Sub New(type, x)
        InitializeComponent()
        If type = "Email" Then
            Mn_Lab.Text = "====== Pay Up Via " & type & " ======"
        Else
            Mn_Lab.Text = "== Pay Up Via " & type & " =="
        End If

        Ch_Lab.Text = type & " :"
        source = x
    End Sub

    Private Sub _06A_EmailTelpNorek_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        source.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class