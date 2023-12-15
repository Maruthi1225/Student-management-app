<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Button2 = New Button()
        Label4 = New Label()
        Button1 = New Button()
        TextBox2 = New TextBox()
        textbox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Button4 = New Button()
        MenuStrip1 = New MenuStrip()
        HOMEToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        FacultyToolStripMenuItem = New ToolStripMenuItem()
        DepartmentsToolStripMenuItem = New ToolStripMenuItem()
        GalaryToolStripMenuItem = New ToolStripMenuItem()
        FacultyLoginToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 151)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1993, 1066)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(textbox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(898, 153)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1046, 821)
        Panel1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Location = New Point(758, 427)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 12
        Button2.Text = "Show"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Baskerville Old Face", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ImageAlign = ContentAlignment.TopCenter
        Label4.Location = New Point(24, 22)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(387, 36)
        Label4.TabIndex = 9
        Label4.Text = "Login to Register new Faculty"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(412, 534)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 54)
        Button1.TabIndex = 8
        Button1.Text = "LOG IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(445, 411)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(286, 47)
        TextBox2.TabIndex = 7
        ' 
        ' textbox1
        ' 
        textbox1.BorderStyle = BorderStyle.FixedSingle
        textbox1.Cursor = Cursors.IBeam
        textbox1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        textbox1.Location = New Point(445, 292)
        textbox1.Margin = New Padding(2)
        textbox1.Name = "textbox1"
        textbox1.Size = New Size(286, 47)
        textbox1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(214, 416)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(218, 36)
        Label3.TabIndex = 5
        Label3.Text = "PASSWORD :"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(207, 297)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 36)
        Label2.TabIndex = 4
        Label2.Text = "USER ID        :"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Arial", 46F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(214, 162)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(524, 74)
        Label1.TabIndex = 3
        Label1.Text = "FACULTY LOGIN"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(80, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(725, 145)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Firebrick
        Button4.Cursor = Cursors.Hand
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(1875, -7)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(46, 33)
        Button4.TabIndex = 15
        Button4.Text = "X"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HOMEToolStripMenuItem, ToolStripMenuItem1, FacultyToolStripMenuItem, DepartmentsToolStripMenuItem, GalaryToolStripMenuItem, FacultyLoginToolStripMenuItem})
        MenuStrip1.Location = New Point(1212, 94)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(804, 40)
        MenuStrip1.TabIndex = 16
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
        GalaryToolStripMenuItem.Size = New Size(92, 36)
        GalaryToolStripMenuItem.Text = "Galary"
        ' 
        ' FacultyLoginToolStripMenuItem
        ' 
        FacultyLoginToolStripMenuItem.BackColor = Color.White
        FacultyLoginToolStripMenuItem.ForeColor = Color.Red
        FacultyLoginToolStripMenuItem.Name = "FacultyLoginToolStripMenuItem"
        FacultyLoginToolStripMenuItem.Size = New Size(161, 36)
        FacultyLoginToolStripMenuItem.Text = "Faculty login"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1940, 1080)
        Controls.Add(MenuStrip1)
        Controls.Add(Button4)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents textbox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacultyLoginToolStripMenuItem As ToolStripMenuItem
End Class
