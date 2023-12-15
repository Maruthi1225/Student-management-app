Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form8
    Dim con As New OleDbConnection("provider=OraOLEDB.Oracle;user id=system;password=sql")
    Dim cmd As OleDbCommand
    Dim temp As Integer

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idNo As Integer = textbox1.Text
        Dim password As String = TextBox2.Text
        Dim confirmpassword As String = TextBox3.Text
        If confirmpassword = password Then
            Try
                con.Open()
                Dim cmd As New OleDbCommand("update faculty set PASSWORD='" & password & "' where IDNO='" & idNo & "'", con)
                cmd.CommandType = CommandType.Text
                temp = cmd.ExecuteNonQuery

                If temp > 0 Then
                    MsgBox("PASSWORD UPDATED SUCCESSFULLY!!")
                Else
                    MsgBox("PASSWORD  NOT UPDATED SUCCESSFULLY!! / TRY AGAIN!!")
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        Else
            MsgBox("password is mismatch check the password and try again")
        End If
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        login.Show()
        Me.Hide()

        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub


    Private Sub StudentDetialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetialsToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub DeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub UpdatePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePasswordToolStripMenuItem.Click

        Me.Show()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub
End Class