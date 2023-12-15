Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form8.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub StudentDetialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetialsToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub UpdatePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePasswordToolStripMenuItem.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub DeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        Form10.ShowDialog()
        Me.Hide()

    End Sub
End Class