Imports System.Data.OleDb

Public Class Form10

    Dim con As New OleDbConnection("provider=OraOLEDB.Oracle;user id=system;password=sql")
    Dim cmd As OleDbCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim temp As Integer

        Dim idno As String = textbox1.Text
        Dim confirmid As String = TextBox2.Text

        If idno = confirmid Then

            Try
                con.Open()
                cmd = New OleDbCommand("delete from student1 where IDNO=" & textbox1.Text, con)
                cmd.CommandType = CommandType.Text
                temp = cmd.ExecuteNonQuery
                If temp > 0 Then
                    MsgBox("STUDENT DELETED SUCCESSFULLY!!")
                Else
                    MsgBox(" STUDENT NOT DELETED TRY AGAIN ")
                End If

            Catch ex As Exception
                MsgBox("error :" & ex.Message)
            Finally
                con.Close()
            End Try

        Else
            MsgBox("ID MISMATCH CHECK THE ID AND TRY AGAIN")
        End If
        textbox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        login.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
    End Sub


    Private Sub StudentDetialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetialsToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub DeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentToolStripMenuItem.Click

        Me.Show()
        textbox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub UpdatePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePasswordToolStripMenuItem.Click
        Form8.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
    End Sub
End Class