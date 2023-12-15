Public Class Form12
    Dim n As Integer

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If ImageList1.Images.Count > 0 Then
        'Timer1.Start()
        'End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If n >= 0 AndAlso n < ImageList1.Images.Count Then
        'PictureBox2.Image = ImageList1.Images(n)
        '
        'If (n = ImageList1.Images.Count - 1) Then
        'n = 0
        'Else
        'n += 1
        'End If

        'End If
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Form11.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Show()

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End

    End Sub

    Private Sub GalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GalaryToolStripMenuItem.Click
        Form13.Show()
        Me.Hide()
    End Sub

    Private Sub DepartmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentsToolStripMenuItem.Click
        Form14.Show()
        Me.Hide()

    End Sub
    Private Sub FacultyLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyLoginToolStripMenuItem.Click

        login.Show()
        Me.Hide()

    End Sub

    Private Sub RegisterNewFacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterNewFacultyToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        Form15.Show()
        Me.Hide()

    End Sub
End Class