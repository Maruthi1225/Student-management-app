Imports System.Data.OleDb

Public Class Form3
    Dim con As New OleDbConnection("provider=OraOLEDB.Oracle;user id=system;password=sql")
    Dim cmd As OleDbCommand
    Dim temp As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idNo As Integer = TextBox1.Text
        Dim name As String = TextBox2.Text
        Dim dept As String = TextBox3.Text
        Dim password As String = TextBox4.Text
        Dim confirmpassword As String = TextBox5.Text
        If confirmpassword = password Then
            Try
                con.Open()
                Dim cmd As New OleDbCommand("INSERT INTO faculty VALUES (" & idNo & ", '" & name & "','" & dept & "','" & password & "')", con)
                cmd.CommandType = CommandType.Text
                temp = cmd.ExecuteNonQuery

                If temp > 0 Then
                    MsgBox("NEW FACULTY REGISTERED SUCCESSFULLY!!")
                Else
                    MsgBox("NOT REGISTERED / CHECK THE DETAILS AND TRY AGAIN!!")
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        Else
            MsgBox("password is mismatch check the password and try again")
        End If
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.PasswordChar = "*"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        login.Show()
        Me.Hide()

    End Sub

End Class


