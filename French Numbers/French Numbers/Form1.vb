﻿Public Class Form1

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        MessageBox.Show("Un")
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        MessageBox.Show("Deux")
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        MessageBox.Show("Trois")
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        MessageBox.Show("Quatre")
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        MessageBox.Show("Cinq")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
