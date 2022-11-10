Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton3.Checked = True Then
            MsgBox("You completed the world's worst game hooray")
            Form1.ProgressBar1.Value = 100
            Form1.Show()
        End If
    End Sub
End Class