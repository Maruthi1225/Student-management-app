Imports System.Data.OleDb

Public Class Form7
    Dim con As New OleDbConnection("provider=OraOLEDB.Oracle;user id=system;password=sql")
    Dim cmd As OleDbCommand
    Dim temp As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idNo As String = TextBox1.Text
        Dim name As String = TextBox2.Text
        Dim course As String = TextBox3.Text
        Dim gender As String = ""

        If RadioButton1.Checked Then
            gender = "Male"
        ElseIf RadioButton2.Checked Then
            gender = "Female"
        End If



        Dim fathername As String = TextBox4.Text
        Dim mail As String = TextBox5.Text
        Dim contact As String = TextBox6.Text
        Dim address As String = RichTextBox1.Text
        Dim dob As String = TextBox7.Text
        'Dim dob As String = DateTimePicker1.Value

        If TextBox6.Text.Length > 10 Then
            TextBox6.Text = TextBox6.Text.Substring(0, 10)
            TextBox6.SelectionStart = 10
            MessageBox.Show("Contact No. should not be more than ten digits.")
            Exit Sub
        End If



        Try
            con.Open()
            Dim cmd As New OleDbCommand("INSERT INTO student1 VALUES ('" & idNo & "', '" & name & "','" & course & "','" & gender & "', '" & dob & "','" & fathername & "','" & mail & "','" & contact & "','" & address & "')", con)
            cmd.CommandType = CommandType.Text
            temp = cmd.ExecuteNonQuery

            If temp > 0 Then
                MsgBox("NEW STUDENT REGISTERED SUCCESSFULLY!!")
            Else
                MsgBox("NOT REGISTERED / CHECK THE DETAILS AND TRY AGAIN!!")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try


        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RichTextBox1.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        login.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.ShowDialog()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RichTextBox1.Clear()
    End Sub


    Private Sub StudentDetialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetialsToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        Me.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RichTextBox1.Clear()

    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub DeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub UpdatePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePasswordToolStripMenuItem.Click
        Form8.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RichTextBox1.Clear()
    End Sub
End Class