Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form6
    Dim con As New OleDbConnection("provider=OraOLEDB.Oracle;user id=system;password=sql")
    Dim cmd As OleDbCommand
    Dim d As OleDbDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

            TextBox2.Show()
            TextBox3.Show()
            TextBox4.Show()
            TextBox5.Show()
            TextBox6.Show()
            TextBox7.Show()
            TextBox8.Show()
            TextBox9.Show()
            RichTextBox1.Show()

            Button3.Show()
            Button4.Show()


            TextBox2.Text = d(0)
            TextBox3.Text = d(1)
            TextBox4.Text = d(2)
            TextBox5.Text = d(3)
            TextBox6.Text = d(4)
            TextBox7.Text = d(5)
            TextBox8.Text = d(6)
            TextBox9.Text = d(7)
            RichTextBox1.Text = d(8)

            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox5.ReadOnly = True
            TextBox6.ReadOnly = True
            TextBox7.ReadOnly = True
            TextBox8.ReadOnly = True
            TextBox9.ReadOnly = True
            RichTextBox1.ReadOnly = True



        Else
            MsgBox("No matching record found try again")
        End If
        d.Close()
        con.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form9.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form10.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        login.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()


    End Sub


    Private Sub StudentDetialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetialsToolStripMenuItem.Click
        Me.Show()

        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()

    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()

    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()

    End Sub

    Private Sub DeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()

    End Sub

    Private Sub UpdatePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePasswordToolStripMenuItem.Click
        Form8.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.Show()
        Me.Hide()
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
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

        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox8.Hide()
        TextBox9.Hide()
        RichTextBox1.Hide()

        Button3.Hide()
        Button4.Hide()
    End Sub
End Class