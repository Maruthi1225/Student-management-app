<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form8))
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        textbox1 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button3 = New Button()
        Button6 = New Button()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        StudentDetialsToolStripMenuItem = New ToolStripMenuItem()
        NewStudentToolStripMenuItem = New ToolStripMenuItem()
        UpdateStudentToolStripMenuItem = New ToolStripMenuItem()
        DeleteStudentToolStripMenuItem = New ToolStripMenuItem()
        UpdatePasswordToolStripMenuItem = New ToolStripMenuItem()
        PictureBox5 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(736, 157)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Arial", 46F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(656, 226)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(653, 74)
        Label3.TabIndex = 13
        Label3.Text = "UPDATE PASSWORD"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(758, 358)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 36)
        Label2.TabIndex = 14
        Label2.Text = "USER ID   :"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(626, 452)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 36)
        Label1.TabIndex = 15
        Label1.Text = "NEW PASSWORD  :"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' textbox1
        ' 
        textbox1.BorderStyle = BorderStyle.FixedSingle
        textbox1.Cursor = Cursors.IBeam
        textbox1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        textbox1.Location = New Point(971, 355)
        textbox1.Margin = New Padding(2)
        textbox1.Name = "textbox1"
        textbox1.Size = New Size(322, 47)
        textbox1.TabIndex = 16
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(971, 452)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(322, 47)
        TextBox2.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ImageAlign = ContentAlignment.TopCenter
        Label4.Location = New Point(552, 543)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(386, 36)
        Label4.TabIndex = 18
        Label4.Text = "CONFIRM PASSWORD  :"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(971, 540)
        TextBox3.Margin = New Padding(2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(322, 47)
        TextBox3.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(878, 664)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 56)
        Button1.TabIndex = 20
        Button1.Text = "Update Password"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1882, 2)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(46, 33)
        Button3.TabIndex = 46
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Firebrick
        Button6.Cursor = Cursors.Hand
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(1791, 84)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(113, 30)
        Button6.TabIndex = 47
        Button6.Text = "LOG OUT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, StudentDetialsToolStripMenuItem, NewStudentToolStripMenuItem, UpdateStudentToolStripMenuItem, DeleteStudentToolStripMenuItem, UpdatePasswordToolStripMenuItem})
        MenuStrip1.Location = New Point(1097, 128)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(834, 33)
        MenuStrip1.TabIndex = 51
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
        PictureBox5.Location = New Point(698, 23)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(188, 138)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 52
        PictureBox5.TabStop = False
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1940, 1080)
        Controls.Add(PictureBox5)
        Controls.Add(MenuStrip1)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(textbox1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form8"
        Text = "Form8"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textbox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StudentDetialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdatePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox5 As PictureBox
End Class
