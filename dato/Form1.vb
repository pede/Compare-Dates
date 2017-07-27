Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim startDate As DateTime = DateTime.Parse(TextBox1.Text)
        Dim endDate As DateTime = DateTime.Parse(TextBox2.Text)
        Select Case DateTime.Compare(startDate, endDate)
            Case -1
                ' smaller
                MsgBox("Smaller")
            Case 1
                ' bigger
                MsgBox("Bigger")
            Case 0
                ' same
                MsgBox("same")

        End Select
    End Sub
End Class
