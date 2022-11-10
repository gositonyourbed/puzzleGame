Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = ("Windows 7") Then
            Form7.Show()
            Form1.ProgressBar1.Value = 75
        Else
            MsgBox("nope")
        End If
    End Sub
End Class