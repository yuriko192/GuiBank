Public Class Inbox

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Inbox_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        main_m.Show()
    End Sub

End Class