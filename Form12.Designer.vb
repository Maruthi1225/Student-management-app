<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form12))
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
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
        Panel2 = New Panel()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox4 = New PictureBox()
        RichTextBox5 = New RichTextBox()
        Label4 = New Label()
        RichTextBox4 = New RichTextBox()
        Label3 = New Label()
        Label2 = New Label()
        RichTextBox2 = New RichTextBox()
        RichTextBox1 = New RichTextBox()
        Label1 = New Label()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(9, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(10)
        PictureBox1.Size = New Size(507, 113)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(522, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(114, 109)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HOMEToolStripMenuItem, ToolStripMenuItem1, FacultyToolStripMenuItem, DepartmentsToolStripMenuItem, GalaryToolStripMenuItem, FacultyLoginToolStripMenuItem, RegisterNewFacultyToolStripMenuItem})
        MenuStrip1.Location = New Point(988, 81)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1051, 40)
        MenuStrip1.TabIndex = 18
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
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1942, 125)
        Panel1.TabIndex = 19
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Firebrick
        Button5.Cursor = Cursors.Hand
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(1870, -1)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(46, 33)
        Button5.TabIndex = 24
        Button5.Text = "X"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(PictureBox5)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(RichTextBox5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(RichTextBox4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(RichTextBox2)
        Panel2.Controls.Add(RichTextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(-14, 127)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1958, 952)
        Panel2.TabIndex = 20
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(1375, 138)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(476, 245)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(702, 138)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(499, 245)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(70, 138)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(476, 245)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(16, 1717)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1924, 68)
        Panel3.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1750, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 15)
        Label7.TabIndex = 2
        Label7.Text = "vaagdevicollages@edu.in"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1584, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 15)
        Label6.TabIndex = 1
        Label6.Text = "contact us : 00000000 /00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Location = New Point(42, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 17)
        Label5.TabIndex = 0
        Label5.Text = "@vaagdevicollages"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1047, 1341)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(818, 344)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' RichTextBox5
        ' 
        RichTextBox5.BackColor = Color.White
        RichTextBox5.BorderStyle = BorderStyle.None
        RichTextBox5.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox5.Location = New Point(44, 1350)
        RichTextBox5.Name = "RichTextBox5"
        RichTextBox5.ReadOnly = True
        RichTextBox5.Size = New Size(997, 310)
        RichTextBox5.TabIndex = 9
        RichTextBox5.Text = resources.GetString("RichTextBox5.Text")
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("Elephant", 21.7499962F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.Location = New Point(44, 1282)
        Label4.Name = "Label4"
        Label4.Size = New Size(319, 38)
        Label4.TabIndex = 8
        Label4.Text = "OUR OBJECTIVE"
        ' 
        ' RichTextBox4
        ' 
        RichTextBox4.BackColor = Color.White
        RichTextBox4.BorderStyle = BorderStyle.None
        RichTextBox4.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox4.Location = New Point(932, 992)
        RichTextBox4.Name = "RichTextBox4"
        RichTextBox4.ReadOnly = True
        RichTextBox4.Size = New Size(780, 391)
        RichTextBox4.TabIndex = 7
        RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Elephant", 21.7499962F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.Location = New Point(932, 938)
        Label3.Name = "Label3"
        Label3.Size = New Size(269, 38)
        Label3.TabIndex = 6
        Label3.Text = "OUR MISSION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("Elephant", 21.7499962F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.Location = New Point(44, 938)
        Label2.Name = "Label2"
        Label2.Size = New Size(238, 38)
        Label2.TabIndex = 4
        Label2.Text = "OUR VISION"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = Color.White
        RichTextBox2.BorderStyle = BorderStyle.None
        RichTextBox2.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox2.Location = New Point(44, 992)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.Size = New Size(780, 224)
        RichTextBox2.TabIndex = 3
        RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.White
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(44, 643)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(1885, 280)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Elephant", 21.7499962F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(44, 590)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 38)
        Label1.TabIndex = 1
        Label1.Text = "ABOUT VAAGDEVI"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 2000
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1940, 1080)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form12"
        Text = "Form12"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacultyLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterNewFacultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
