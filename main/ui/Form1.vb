Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        MaximizeBox = False
        'FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        MsgBox(e.X.ToString & ", " & e.Y.ToString)
    End Sub

    Private Sub Form1_OnClose(ByVal sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Environment.Exit(0)
    End Sub
End Class
