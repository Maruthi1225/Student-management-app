<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        textbox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1921, 146)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(745, 325)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 36)
        Label2.TabIndex = 4
        Label2.Text = "USER ID   :"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' textbox1
        ' 
        textbox1.BorderStyle = BorderStyle.FixedSingle
        textbox1.Cursor = Cursors.IBeam
        textbox1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        textbox1.Location = New Point(957, 322)
        textbox1.Margin = New Padding(2)
        textbox1.Name = "textbox1"
        textbox1.Size = New Size(286, 47)
        textbox1.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(927, 554)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 48)
        Button1.TabIndex = 8
        Button1.Text = "Get Password"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(11, 11)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 28)
        Button2.TabIndex = 9
        Button2.Text = "<--BACK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(745, 434)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 36)
        Label1.TabIndex = 10
        Label1.Text = "NAME       :"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(957, 431)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(286, 47)
        TextBox2.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Arial", 46F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(811, 197)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(388, 74)
        Label3.TabIndex = 12
        Label3.Text = "PASSWORD"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(767, 657)
        TextBox3.Margin = New Padding(2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(537, 40)
        TextBox3.TabIndex = 14
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1876, -2)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(46, 33)
        Button3.TabIndex = 15
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1940, 1080)
        Controls.Add(Button3)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(textbox1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form5"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textbox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
End Class
