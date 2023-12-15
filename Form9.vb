Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form9

    Dim con As New OleDbConnection("provider=OraOLEDB.Oracle;user id=system;password=sql")
    Dim cmd As OleDbCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim d As OleDbDataReader

        con.Open()
        cmd = New OleDbCommand("SELECT * FROM student1 WHERE IDNO=" & textbox1.Text, con)
        cmd.CommandType = CommandType.Text
        d = cmd.ExecuteReader
        If d.Read Then


            Label3.Show()
            Label4.Show()
            Label5.Show()
            Label6.Show()
            Label7.Show()
            Label8.Show()
            Label9.Show()
            Label10.Show()
            Label11.Show()
            Label12.Show()

            TextBox2.Show()
            TextBox3.Show()
            TextBox4.Show()

            RadioButton1.Show()
            RadioButton2.Show()

            TextBox5.Show()
            TextBox6.Show()
            TextBox7.Show()
            TextBox8.Show()

            RichTextBox1.Show()

            Button2.Show()

            TextBox2.Text = d(0)
            TextBox3.Text = d(1)
            TextBox4.Text = d(2)

            Dim gender As String = d(3).ToString()
            RadioButton1.Checked = (gender = "Male")
            RadioButton2.Checked = (gender = "Female")

            TextBox5.Text = d(4)
            TextBox6.Text = d(5)
            TextBox7.Text = d(6)
            TextBox8.Text = d(7)

            RichTextBox1.Text = d(8)

        Else
            TextBox3.Text = "No matching record found try again"
        End If
        d.Close()
        con.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Dim temp As Integer

        Dim idNo As String = TextBox2.Text
        Dim name As String = TextBox3.Text
        Dim course As String = TextBox4.Text
        Dim gender As String = ""

        If RadioButton1.Checked Then
            gender = "Male"
        ElseIf RadioButton2.Checked Then
            gender = "Female"
        End If

        Dim dob As String = TextBox5.Text
        Dim fathername As String = TextBox6.Text
        Dim mail As String = TextBox7.Text
        Dim contact As String = TextBox8.Text
        Dim address As String = RichTextBox1.Text


        If TextBox6.Text.Length > 10 Then
            TextBox6.Text = TextBox6.Text.Substring(0, 10)
            TextBox6.SelectionStart = 10
            MessageBox.Show("Contact No. should not be more than ten digits.")
            Exit Sub
        End If

        Try
            con.Open()
            Dim cmd As New OleDbCommand("update student1 set IDNO=" & idNo & ", NAME='" & name & "', COURSE='" & course & "', GENDER='" & gender & "', DOB='" & dob & "', FATHERNAME='" & fathername & "', EMAIL='" & mail & "', CONTACT='" & contact & "', address='" & address & "' where IDNO='" & idNo & "'", con)
            cmd.CommandType = CommandType.Text
            temp = cmd.ExecuteNonQuery

            If temp > 0 Then
                MsgBox("UPDATED SUCCESSFULLY!!")
            Else
                MsgBox("NOT UPDATED , TRY AGAIN!!")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try

        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        RichTextBox1.Clear()


    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()

        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()

        RichTextBox1.Hide()

        Button2.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        RichTextBox1.Clear()


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()

        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()

        RichTextBox1.Hide()

        Button2.Hide()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        login.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        RichTextBox1.Clear()


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()

        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()

        RichTextBox1.Hide()

        Button2.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        RichTextBox1.Clear()


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()

        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()

        RichTextBox1.Hide()

        Button2.Hide()
    End Sub


    Private Sub StudentDetialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetialsToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        RichTextBox1.Clear()


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()

        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()

        RichTextBox1.Hide()

        Button2.Hide()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        RichTextBox1.Clear()


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()

        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()

        RichTextBox1.Hide()

        Button2.Hide()
    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click

        Me.Show()

        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        RichTextBox1.Clear()


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()

        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()

        RichTextBox1.Hide()

        Button2.Hide()

    End Sub

    Private Sub DeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        RichTextBox1.Clear()


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()

        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()

        RichTextBox1.Hide()

        Button2.Hide()
    End Sub

    Private Sub UpdatePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePasswordToolStripMenuItem.Click
        Form8.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        RichTextBox1.Clear()


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()

        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()

        RichTextBox1.Hide()

        Button2.Hide()
    End Sub
End Class