Imports System.Data.OleDb

Public Class Form5
    Dim con As New OleDbConnection("provider=OraOLEDB.Oracle;user id=system;password=sql")
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim idno As String = textbox1.Text
        Dim name As String = TextBox2.Text
        cmd = New OleDbCommand("SELECT password FROM faculty WHERE IDNO=" & idno & " AND NAME='" & name & "'", con)
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        If dr.Read Then
            TextBox3.Text = "password :" + dr(0)

        Else
            TextBox3.Text = "No matching record found try again"
        End If
        textbox1.Clear()
        TextBox2.Clear()

        dr.Close()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub Form5_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        TextBox3.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class