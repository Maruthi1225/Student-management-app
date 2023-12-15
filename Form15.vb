Public Class Form15
    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Form11.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form12.Show()
        Me.Hide()

    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub DepartmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentsToolStripMenuItem.Click
        Form14.Show()
        Me.Hide()

    End Sub

    Private Sub GalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GalaryToolStripMenuItem.Click
        Form13.Show()
        Me.Hide()

    End Sub

    Private Sub FacultyLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyLoginToolStripMenuItem.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub RegisterNewFacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterNewFacultyToolStripMenuItem.Click
        Form4.Hide()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form16.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form17.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form18.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Form19.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Form20.Show()
        Me.Hide()

    End Sub
End Class