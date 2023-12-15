<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button3 = New Button()
        Button6 = New Button()
        PictureBox5 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-35, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1973, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bodoni MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(742, 197)
        Label1.Name = "Label1"
        Label1.Size = New Size(475, 57)
        Label1.TabIndex = 1
        Label1.Text = "NEW FACULTY REGISTRATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(765, 301)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 32)
        Label2.TabIndex = 2
        Label2.Text = "ID no.   :"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(916, 301)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(285, 39)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(761, 383)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 32)
        Label3.TabIndex = 4
        Label3.Text = "NAME   :"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(916, 381)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(285, 39)
        TextBox2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(768, 462)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 32)
        Label4.TabIndex = 6
        Label4.Text = "DEPT.   :"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(916, 460)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(285, 39)
        TextBox3.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(660, 544)
        Label5.Name = "Label5"
        Label5.Size = New Size(208, 32)
        Label5.TabIndex = 8
        Label5.Text = "SET PASSWORD   :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(594, 619)
        Label6.Name = "Label6"
        Label6.Size = New Size(274, 32)
        Label6.TabIndex = 9
        Label6.Text = "CONFIRM PASSWORD   :"
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(916, 542)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(285, 39)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(916, 619)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(285, 39)
        TextBox5.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(920, 720)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 46)
        Button1.TabIndex = 12
        Button1.Text = "SUBMIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1892, 2)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(46, 33)
        Button3.TabIndex = 14
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Firebrick
        Button6.Cursor = Cursors.Hand
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(1816, 118)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(113, 30)
        Button6.TabIndex = 24
        Button6.Text = "LOG OUT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(1277, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(157, 132)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 26
        PictureBox5.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1940, 1080)
        Controls.Add(PictureBox5)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
