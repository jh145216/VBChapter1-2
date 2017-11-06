Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnJoke_Click(sender As Object, e As EventArgs) Handles btnJoke.Click
        lblJoke.Visible = True
    End Sub

    Private Sub btnPunchline_Click(sender As Object, e As EventArgs) Handles btnPunchline.Click
        lblPunchline.Visible = True
    End Sub
End Class
