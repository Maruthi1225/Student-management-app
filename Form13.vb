Public Class Form13
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Form11.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form12.Show()
        Me.Hide()

    End Sub

    Private Sub GalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GalaryToolStripMenuItem.Click
        Me.Show()

    End Sub
    Private Sub FacultyLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyLoginToolStripMenuItem.Click

        login.Show()
        Me.Hide()

    End Sub

    Private Sub RegisterNewFacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterNewFacultyToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End

    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        Form15.Show()
        Me.Hide()


    End Sub
End Class