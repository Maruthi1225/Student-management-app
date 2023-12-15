<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form10))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        textbox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button3 = New Button()
        Button6 = New Button()
        PictureBox5 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        StudentDetialsToolStripMenuItem = New ToolStripMenuItem()
        NewStudentToolStripMenuItem = New ToolStripMenuItem()
        UpdateStudentToolStripMenuItem = New ToolStripMenuItem()
        DeleteStudentToolStripMenuItem = New ToolStripMenuItem()
        UpdatePasswordToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(775, 179)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Arial", 46F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(693, 256)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(586, 74)
        Label1.TabIndex = 13
        Label1.Text = "DELETE STUDENT"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(777, 397)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 36)
        Label2.TabIndex = 14
        Label2.Text = "ID no.   :"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' textbox1
        ' 
        textbox1.BorderStyle = BorderStyle.FixedSingle
        textbox1.Cursor = Cursors.IBeam
        textbox1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        textbox1.Location = New Point(921, 394)
        textbox1.Margin = New Padding(2)
        textbox1.Name = "textbox1"
        textbox1.Size = New Size(344, 47)
        textbox1.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(671, 494)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(242, 36)
        Label3.TabIndex = 16
        Label3.Text = "CONFIRM ID   :"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(921, 494)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(344, 47)
        TextBox2.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(896, 614)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 48)
        Button1.TabIndex = 18
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1876, 1)
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
        Button6.Location = New Point(1789, 84)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(113, 30)
        Button6.TabIndex = 47
        Button6.Text = "LOG OUT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(746, 27)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(177, 140)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 63
        PictureBox5.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, StudentDetialsToolStripMenuItem, NewStudentToolStripMenuItem, UpdateStudentToolStripMenuItem, DeleteStudentToolStripMenuItem, UpdatePasswordToolStripMenuItem})
        MenuStrip1.Location = New Point(1093, 134)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(834, 33)
        MenuStrip1.TabIndex = 64
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
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1940, 1080)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox5)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(textbox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form10"
        Text = "Form10"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textbox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StudentDetialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdatePasswordToolStripMenuItem As ToolStripMenuItem
End Class
