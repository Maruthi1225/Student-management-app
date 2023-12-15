Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class login
    Dim con As New OleDbConnection("provider=OraOLEDB.Oracle;user id=system;password=sql")
    Dim cmd As OleDbCommand
    Dim temp As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idNo As Integer = textbox1.Text
        Dim password As String = TextBox2.Text


        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM faculty WHERE IDNO = " & idNo & " AND password = '" & password & "'", con)
            temp = cmd.ExecuteScalar()

            If temp > 0 Then
                MsgBox("login sucessfull!!")
                Form2.Show()
                Me.Hide()
            Else
                MsgBox("Invalid ID number or password. Please try again.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try


        textbox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        If e.Button = MouseButtons.Left Then
            TextBox2.PasswordChar = ControlChars.NullChar
        End If
    End Sub
    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form5.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Form11.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub RegisterNewFacToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterNewFacToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub FacultyLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyLoginToolStripMenuItem.Click
        Me.Show()
        textbox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form12.Show()
        Me.Hide()

    End Sub

    Private Sub DepartmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentsToolStripMenuItem.Click
        Form14.Show()
        Me.Hide()

    End Sub

    Private Sub GalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GalaryToolStripMenuItem.Click
        Form13.Show()
        Me.Hide()

    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        Form15.Show()
        Me.Hide()

    End Sub
End Class

