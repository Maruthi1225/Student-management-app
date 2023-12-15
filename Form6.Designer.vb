<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form6))
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        textbox1 = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        RichTextBox1 = New RichTextBox()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        StudentDetialsToolStripMenuItem = New ToolStripMenuItem()
        NewStudentToolStripMenuItem = New ToolStripMenuItem()
        UpdateStudentToolStripMenuItem = New ToolStripMenuItem()
        DeleteStudentToolStripMenuItem = New ToolStripMenuItem()
        UpdatePasswordToolStripMenuItem = New ToolStripMenuItem()
        PictureBox5 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-22, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(921, 173)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Baskerville Old Face", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(625, 218)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(793, 36)
        Label1.TabIndex = 10
        Label1.Text = "--> ENTER ID NUMBER TO GET STUDENT DETIALS" & vbCrLf
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(707, 279)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 36)
        Label2.TabIndex = 11
        Label2.Text = "ID no.  :"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' textbox1
        ' 
        textbox1.BorderStyle = BorderStyle.FixedSingle
        textbox1.Cursor = Cursors.IBeam
        textbox1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        textbox1.Location = New Point(853, 273)
        textbox1.Margin = New Padding(2)
        textbox1.Name = "textbox1"
        textbox1.Size = New Size(286, 47)
        textbox1.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1173, 279)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 44)
        Button1.TabIndex = 13
        Button1.Text = "Get Info"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(857, 376)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 27)
        Label3.TabIndex = 15
        Label3.Text = "ID no.  :"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ImageAlign = ContentAlignment.TopCenter
        Label4.Location = New Point(861, 434)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 27)
        Label4.TabIndex = 16
        Label4.Text = "NAME :"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ImageAlign = ContentAlignment.TopCenter
        Label5.Location = New Point(826, 483)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 27)
        Label5.TabIndex = 17
        Label5.Text = "COURSE :"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ImageAlign = ContentAlignment.TopCenter
        Label6.Location = New Point(829, 534)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 27)
        Label6.TabIndex = 18
        Label6.Text = "GENDER :"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ImageAlign = ContentAlignment.TopCenter
        Label7.Location = New Point(750, 592)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(204, 27)
        Label7.TabIndex = 19
        Label7.Text = "DATE OF BIRTH :"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ImageAlign = ContentAlignment.TopCenter
        Label8.Location = New Point(763, 647)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(191, 27)
        Label8.TabIndex = 20
        Label8.Text = "FATHER NAME :"
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ImageAlign = ContentAlignment.TopCenter
        Label9.Location = New Point(860, 707)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(94, 27)
        Label9.TabIndex = 21
        Label9.Text = "EMAIL :"
        Label9.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ImageAlign = ContentAlignment.TopCenter
        Label10.Location = New Point(817, 772)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(137, 27)
        Label10.TabIndex = 22
        Label10.Text = "CONTACT :"
        Label10.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ImageAlign = ContentAlignment.TopCenter
        Label11.Location = New Point(817, 819)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(140, 27)
        Label11.TabIndex = 23
        Label11.Text = "ADDRESS :"
        Label11.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(962, 373)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(448, 30)
        TextBox2.TabIndex = 24
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.White
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(962, 431)
        TextBox3.Margin = New Padding(2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(448, 30)
        TextBox3.TabIndex = 25
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.White
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(962, 480)
        TextBox4.Margin = New Padding(2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(448, 30)
        TextBox4.TabIndex = 26
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.White
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Cursor = Cursors.IBeam
        TextBox5.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(962, 534)
        TextBox5.Margin = New Padding(2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(448, 30)
        TextBox5.TabIndex = 27
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.White
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Cursor = Cursors.IBeam
        TextBox6.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(962, 590)
        TextBox6.Margin = New Padding(2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(447, 30)
        TextBox6.TabIndex = 28
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.White
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Cursor = Cursors.IBeam
        TextBox7.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(962, 644)
        TextBox7.Margin = New Padding(2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(448, 30)
        TextBox7.TabIndex = 29
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.White
        TextBox8.BorderStyle = BorderStyle.None
        TextBox8.Cursor = Cursors.IBeam
        TextBox8.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox8.Location = New Point(962, 707)
        TextBox8.Margin = New Padding(2)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(447, 30)
        TextBox8.TabIndex = 30
        ' 
        ' TextBox9
        ' 
        TextBox9.BackColor = Color.White
        TextBox9.BorderStyle = BorderStyle.None
        TextBox9.Cursor = Cursors.IBeam
        TextBox9.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox9.Location = New Point(962, 769)
        TextBox9.Margin = New Padding(2)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(447, 30)
        TextBox9.TabIndex = 31
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.White
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(962, 819)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(449, 96)
        RichTextBox1.TabIndex = 32
        RichTextBox1.Text = ""
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Highlight
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(879, 945)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(158, 44)
        Button3.TabIndex = 35
        Button3.Text = "UPDATE DETAILS"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.Highlight
        Button4.Cursor = Cursors.Hand
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(1063, 945)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(158, 44)
        Button4.TabIndex = 36
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Cursor = Cursors.Hand
        Button5.Location = New Point(1355, 289)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 37
        Button5.Text = "clear"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Firebrick
        Button6.Cursor = Cursors.Hand
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(1877, 0)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(46, 33)
        Button6.TabIndex = 38
        Button6.Text = "X"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Firebrick
        Button7.Cursor = Cursors.Hand
        Button7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = Color.White
        Button7.Location = New Point(1810, 85)
        Button7.Margin = New Padding(2)
        Button7.Name = "Button7"
        Button7.Size = New Size(113, 30)
        Button7.TabIndex = 39
        Button7.Text = "LOG OUT"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, StudentDetialsToolStripMenuItem, NewStudentToolStripMenuItem, UpdateStudentToolStripMenuItem, DeleteStudentToolStripMenuItem, UpdatePasswordToolStripMenuItem})
        MenuStrip1.Location = New Point(1098, 131)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(834, 33)
        MenuStrip1.TabIndex = 40
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(74, 29)
        ToolStripMenuItem1.Text = "Home"
        ' 
        ' StudentDetialsToolStripMenuItem
        ' 
        StudentDetialsToolStripMenuItem.Name = "StudentDetialsToolStripMenuItem"
        StudentDetialsToolStripMenuItem.Size = New Size(150, 29)
        StudentDetialsToolStripMenuItem.Text = "Student Detials"
        ' 
        ' NewStudentToolStripMenuItem
        ' 
        NewStudentToolStripMenuItem.Name = "NewStudentToolStripMenuItem"
        NewStudentToolStripMenuItem.Size = New Size(130, 29)
        NewStudentToolStripMenuItem.Text = "New student"
        ' 
        ' UpdateStudentToolStripMenuItem
        ' 
        UpdateStudentToolStripMenuItem.Name = "UpdateStudentToolStripMenuItem"
        UpdateStudentToolStripMenuItem.Size = New Size(156, 29)
        UpdateStudentToolStripMenuItem.Text = "update student "
        ' 
        ' DeleteStudentToolStripMenuItem
        ' 
        DeleteStudentToolStripMenuItem.Name = "DeleteStudentToolStripMenuItem"
        DeleteStudentToolStripMenuItem.Size = New Size(146, 29)
        DeleteStudentToolStripMenuItem.Text = "Delete student"
        ' 
        ' UpdatePasswordToolStripMenuItem
        ' 
        UpdatePasswordToolStripMenuItem.Name = "UpdatePasswordToolStripMenuItem"
        UpdatePasswordToolStripMenuItem.Size = New Size(170, 29)
        UpdatePasswordToolStripMenuItem.Text = "Update password"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(792, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(201, 152)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 41
        PictureBox5.TabStop = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1940, 1080)
        Controls.Add(PictureBox5)
        Controls.Add(MenuStrip1)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(RichTextBox1)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(textbox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form6"
        Text = "Form6"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textbox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StudentDetialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdatePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
