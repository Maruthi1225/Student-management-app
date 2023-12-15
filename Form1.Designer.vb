<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(login))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        textbox1 = New TextBox()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        TextBox2 = New TextBox()
        Button2 = New Button()
        LinkLabel2 = New LinkLabel()
        Button3 = New Button()
        MenuStrip1 = New MenuStrip()
        HOMEToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        FacultyToolStripMenuItem = New ToolStripMenuItem()
        DepartmentsToolStripMenuItem = New ToolStripMenuItem()
        GalaryToolStripMenuItem = New ToolStripMenuItem()
        FacultyLoginToolStripMenuItem = New ToolStripMenuItem()
        RegisterNewFacToolStripMenuItem = New ToolStripMenuItem()
        PictureBox5 = New PictureBox()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(179, 4)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(713, 163)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(373, 289)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(474, 521)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Arial", 46F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(968, 302)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(524, 74)
        Label1.TabIndex = 2
        Label1.Text = "FACULTY LOGIN"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(949, 451)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 36)
        Label2.TabIndex = 3
        Label2.Text = "USER ID        :"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(956, 569)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(218, 36)
        Label3.TabIndex = 4
        Label3.Text = "PASSWORD :"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' textbox1
        ' 
        textbox1.BorderStyle = BorderStyle.FixedSingle
        textbox1.Cursor = Cursors.IBeam
        textbox1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        textbox1.Location = New Point(1194, 448)
        textbox1.Margin = New Padding(2)
        textbox1.Name = "textbox1"
        textbox1.Size = New Size(286, 47)
        textbox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1101, 709)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 54)
        Button1.TabIndex = 7
        Button1.Text = "LOG IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Cursor = Cursors.Hand
        LinkLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(1044, 777)
        LinkLabel1.Margin = New Padding(2, 0, 2, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(130, 21)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "New Registration"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(1194, 566)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(286, 47)
        TextBox2.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Location = New Point(1548, 582)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 11
        Button2.Text = "Show"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Cursor = Cursors.Hand
        LinkLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel2.LinkColor = Color.Black
        LinkLabel2.Location = New Point(1194, 777)
        LinkLabel2.Margin = New Padding(2, 0, 2, 0)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(125, 21)
        LinkLabel2.TabIndex = 12
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Forget Password"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1871, 4)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(46, 33)
        Button3.TabIndex = 13
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HOMEToolStripMenuItem, ToolStripMenuItem1, FacultyToolStripMenuItem, DepartmentsToolStripMenuItem, GalaryToolStripMenuItem, FacultyLoginToolStripMenuItem, RegisterNewFacToolStripMenuItem})
        MenuStrip1.Location = New Point(1181, 134)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(876, 33)
        MenuStrip1.TabIndex = 14
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HOMEToolStripMenuItem
        ' 
        HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        HOMEToolStripMenuItem.Size = New Size(74, 29)
        HOMEToolStripMenuItem.Text = "Home"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(99, 29)
        ToolStripMenuItem1.Text = "About us"
        ' 
        ' FacultyToolStripMenuItem
        ' 
        FacultyToolStripMenuItem.Name = "FacultyToolStripMenuItem"
        FacultyToolStripMenuItem.Size = New Size(82, 29)
        FacultyToolStripMenuItem.Text = "Faculty"
        ' 
        ' DepartmentsToolStripMenuItem
        ' 
        DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        DepartmentsToolStripMenuItem.Size = New Size(91, 29)
        DepartmentsToolStripMenuItem.Text = "Courses"
        ' 
        ' GalaryToolStripMenuItem
        ' 
        GalaryToolStripMenuItem.Name = "GalaryToolStripMenuItem"
        GalaryToolStripMenuItem.Size = New Size(78, 29)
        GalaryToolStripMenuItem.Text = "Galary"
        ' 
        ' FacultyLoginToolStripMenuItem
        ' 
        FacultyLoginToolStripMenuItem.BackColor = Color.White
        FacultyLoginToolStripMenuItem.ForeColor = Color.Red
        FacultyLoginToolStripMenuItem.Name = "FacultyLoginToolStripMenuItem"
        FacultyLoginToolStripMenuItem.Size = New Size(130, 29)
        FacultyLoginToolStripMenuItem.Text = "Faculty login"
        ' 
        ' RegisterNewFacToolStripMenuItem
        ' 
        RegisterNewFacToolStripMenuItem.ForeColor = Color.Red
        RegisterNewFacToolStripMenuItem.Name = "RegisterNewFacToolStripMenuItem"
        RegisterNewFacToolStripMenuItem.Size = New Size(194, 29)
        RegisterNewFacToolStripMenuItem.Text = "Register new Faculty"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(71, 385)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(219, 251)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 26
        PictureBox5.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1946, 177)
        Panel1.TabIndex = 27
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        ClientSize = New Size(1940, 1080)
        Controls.Add(PictureBox5)
        Controls.Add(Button3)
        Controls.Add(LinkLabel2)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(textbox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "login"
        StartPosition = FormStartPosition.Manual
        Text = "login"
        WindowState = FormWindowState.Minimized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacultyLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterNewFacToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
