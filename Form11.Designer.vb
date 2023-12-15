<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form11))
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        HOMEToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        FacultyToolStripMenuItem = New ToolStripMenuItem()
        DepartmentsToolStripMenuItem = New ToolStripMenuItem()
        GalaryToolStripMenuItem = New ToolStripMenuItem()
        FacultyLoginToolStripMenuItem = New ToolStripMenuItem()
        RegisterNewFacultyToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        Button5 = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(24, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(10)
        PictureBox1.Size = New Size(856, 158)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HOMEToolStripMenuItem, ToolStripMenuItem1, FacultyToolStripMenuItem, DepartmentsToolStripMenuItem, GalaryToolStripMenuItem, FacultyLoginToolStripMenuItem, RegisterNewFacultyToolStripMenuItem})
        MenuStrip1.Location = New Point(985, 110)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1051, 40)
        MenuStrip1.TabIndex = 13
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HOMEToolStripMenuItem
        ' 
        HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        HOMEToolStripMenuItem.Size = New Size(91, 36)
        HOMEToolStripMenuItem.Text = "Home"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(122, 36)
        ToolStripMenuItem1.Text = "About us"
        ' 
        ' FacultyToolStripMenuItem
        ' 
        FacultyToolStripMenuItem.Name = "FacultyToolStripMenuItem"
        FacultyToolStripMenuItem.Size = New Size(100, 36)
        FacultyToolStripMenuItem.Text = "Faculty"
        ' 
        ' DepartmentsToolStripMenuItem
        ' 
        DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        DepartmentsToolStripMenuItem.Size = New Size(110, 36)
        DepartmentsToolStripMenuItem.Text = "Courses"
        ' 
        ' GalaryToolStripMenuItem
        ' 
        GalaryToolStripMenuItem.Name = "GalaryToolStripMenuItem"
        GalaryToolStripMenuItem.Size = New Size(99, 36)
        GalaryToolStripMenuItem.Text = "Gallery"
        ' 
        ' FacultyLoginToolStripMenuItem
        ' 
        FacultyLoginToolStripMenuItem.BackColor = Color.White
        FacultyLoginToolStripMenuItem.ForeColor = Color.Red
        FacultyLoginToolStripMenuItem.Name = "FacultyLoginToolStripMenuItem"
        FacultyLoginToolStripMenuItem.Size = New Size(161, 36)
        FacultyLoginToolStripMenuItem.Text = "Faculty login"
        ' 
        ' RegisterNewFacultyToolStripMenuItem
        ' 
        RegisterNewFacultyToolStripMenuItem.ForeColor = Color.Red
        RegisterNewFacultyToolStripMenuItem.Name = "RegisterNewFacultyToolStripMenuItem"
        RegisterNewFacultyToolStripMenuItem.Size = New Size(240, 36)
        RegisterNewFacultyToolStripMenuItem.Text = "Register new faculty"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1939, 155)
        Panel1.TabIndex = 14
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Firebrick
        Button5.Cursor = Cursors.Hand
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(1878, 2)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(46, 33)
        Button5.TabIndex = 23
        Button5.Text = "X"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-23, 156)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1989, 945)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1267, 213)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(196, 166)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' Form11
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1940, 1080)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "Form11"
        Text = "Form11"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacultyLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RegisterNewFacultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button5 As Button
End Class
