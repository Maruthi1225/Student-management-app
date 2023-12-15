<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        MenuStrip1 = New MenuStrip()
        StudentDetialsToolStripMenuItem = New ToolStripMenuItem()
        NewStudentToolStripMenuItem = New ToolStripMenuItem()
        UpdateStudentToolStripMenuItem = New ToolStripMenuItem()
        DeleteStudentToolStripMenuItem = New ToolStripMenuItem()
        UpdatePasswordToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        PictureBox5 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.MenuHighlight
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(1594, 213)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 38)
        Button2.TabIndex = 7
        Button2.Text = "NEW STUDENT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(1594, 160)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 38)
        Button1.TabIndex = 3
        Button1.Text = "STUDENT DETIALS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-20, 1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1996, 1088)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(151, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(10)
        PictureBox1.Size = New Size(618, 132)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Firebrick
        Button4.Cursor = Cursors.Hand
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(1594, 290)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(158, 42)
        Button4.TabIndex = 21
        Button4.Text = "Update Password"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Firebrick
        Button5.Cursor = Cursors.Hand
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(1915, 3)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(46, 33)
        Button5.TabIndex = 22
        Button5.Text = "X"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Firebrick
        Button6.Cursor = Cursors.Hand
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(1834, 101)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(113, 30)
        Button6.TabIndex = 23
        Button6.Text = "LOG OUT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {StudentDetialsToolStripMenuItem, NewStudentToolStripMenuItem, UpdateStudentToolStripMenuItem, DeleteStudentToolStripMenuItem, UpdatePasswordToolStripMenuItem})
        MenuStrip1.Location = New Point(1071, 99)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(760, 33)
        MenuStrip1.TabIndex = 24
        MenuStrip1.Text = "MenuStrip1"
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
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Location = New Point(-20, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1980, 137)
        Panel1.TabIndex = 25
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(764, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(157, 132)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 25
        PictureBox5.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1940, 1080)
        Controls.Add(Panel1)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StudentDetialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdatePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
End Class
