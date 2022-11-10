Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("change to opposites")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (CheckBox1.Checked = False) And (CheckBox2.Checked = True) And (CheckBox3.Checked = True) And (CheckBox4.Checked = True) And (CheckBox5.Checked = False) Then
            Form6.Show()
            Form1.ProgressBar1.Value = 50
        Else
            MsgBox("Incorrect, try again")
        End If
    End Sub
End Class