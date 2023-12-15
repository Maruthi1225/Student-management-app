Public Class Form14
    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Form11.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form12.Show()
        Me.Hide()

    End Sub

    Private Sub GalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GalaryToolStripMenuItem.Click
        Form13.Show()
        Me.Hide()

    End Sub

    Private Sub DepartmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentsToolStripMenuItem.Click
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

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()


        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TextBox1.Show()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        Label10.Show()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TextBox2.Show()

        TextBox1.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        Label10.Hide()
        Label11.Show()
        Label12.Hide()
        Label13.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TextBox1.Hide()
        TextBox2.Hide()

        TextBox3.Show()

        TextBox4.Hide()

        Label10.Hide()
        Label11.Hide()
        Label12.Show()
        Label13.Hide()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()

        TextBox4.Show()

        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End

    End Sub

    Private Sub Form14_Click(sender As Object, e As EventArgs) Handles Me.Click
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
    End Sub
End Class