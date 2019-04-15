<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdlogin = New System.Windows.Forms.Button
        Me.lblusername = New System.Windows.Forms.Label
        Me.lblpassword = New System.Windows.Forms.Label
        Me.lblcountdown = New System.Windows.Forms.Label
        Me.cmbusername = New System.Windows.Forms.ComboBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.img1 = New System.Windows.Forms.PictureBox
        Me.img2 = New System.Windows.Forms.PictureBox
        Me.img3 = New System.Windows.Forms.PictureBox
        Me.img4 = New System.Windows.Forms.PictureBox
        Me.img5 = New System.Windows.Forms.PictureBox
        Me.img6 = New System.Windows.Forms.PictureBox
        Me.trmcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.cmdexit = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdlogin
        '
        Me.cmdlogin.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cmdlogin.Location = New System.Drawing.Point(146, 196)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(92, 40)
        Me.cmdlogin.TabIndex = 0
        Me.cmdlogin.Text = "&Login"
        Me.cmdlogin.UseVisualStyleBackColor = False
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(86, 120)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(86, 13)
        Me.lblusername.TabIndex = 1
        Me.lblusername.Text = "Select username"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(88, 156)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(84, 13)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "Key in password"
        '
        'lblcountdown
        '
        Me.lblcountdown.AutoSize = True
        Me.lblcountdown.Location = New System.Drawing.Point(132, 259)
        Me.lblcountdown.Name = "lblcountdown"
        Me.lblcountdown.Size = New System.Drawing.Size(0, 13)
        Me.lblcountdown.TabIndex = 3
        '
        'cmbusername
        '
        Me.cmbusername.FormattingEnabled = True
        Me.cmbusername.Items.AddRange(New Object() {"GUEST", "ADMIN"})
        Me.cmbusername.Location = New System.Drawing.Point(177, 120)
        Me.cmbusername.Name = "cmbusername"
        Me.cmbusername.Size = New System.Drawing.Size(121, 21)
        Me.cmbusername.TabIndex = 5
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(177, 153)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(121, 20)
        Me.txtpassword.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'img1
        '
        Me.img1.Image = CType(resources.GetObject("img1.Image"), System.Drawing.Image)
        Me.img1.Location = New System.Drawing.Point(12, 133)
        Me.img1.Name = "img1"
        Me.img1.Size = New System.Drawing.Size(68, 57)
        Me.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img1.TabIndex = 8
        Me.img1.TabStop = False
        Me.img1.Visible = False
        '
        'img2
        '
        Me.img2.Image = CType(resources.GetObject("img2.Image"), System.Drawing.Image)
        Me.img2.Location = New System.Drawing.Point(12, 196)
        Me.img2.Name = "img2"
        Me.img2.Size = New System.Drawing.Size(68, 57)
        Me.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img2.TabIndex = 9
        Me.img2.TabStop = False
        Me.img2.Visible = False
        '
        'img3
        '
        Me.img3.Image = CType(resources.GetObject("img3.Image"), System.Drawing.Image)
        Me.img3.Location = New System.Drawing.Point(12, 259)
        Me.img3.Name = "img3"
        Me.img3.Size = New System.Drawing.Size(68, 57)
        Me.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img3.TabIndex = 10
        Me.img3.TabStop = False
        Me.img3.Visible = False
        '
        'img4
        '
        Me.img4.Image = CType(resources.GetObject("img4.Image"), System.Drawing.Image)
        Me.img4.Location = New System.Drawing.Point(304, 133)
        Me.img4.Name = "img4"
        Me.img4.Size = New System.Drawing.Size(68, 57)
        Me.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img4.TabIndex = 11
        Me.img4.TabStop = False
        Me.img4.Visible = False
        '
        'img5
        '
        Me.img5.Image = CType(resources.GetObject("img5.Image"), System.Drawing.Image)
        Me.img5.Location = New System.Drawing.Point(304, 196)
        Me.img5.Name = "img5"
        Me.img5.Size = New System.Drawing.Size(68, 57)
        Me.img5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img5.TabIndex = 12
        Me.img5.TabStop = False
        Me.img5.Visible = False
        '
        'img6
        '
        Me.img6.Image = CType(resources.GetObject("img6.Image"), System.Drawing.Image)
        Me.img6.Location = New System.Drawing.Point(304, 259)
        Me.img6.Name = "img6"
        Me.img6.Size = New System.Drawing.Size(68, 57)
        Me.img6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img6.TabIndex = 13
        Me.img6.TabStop = False
        Me.img6.Visible = False
        '
        'trmcountdown
        '
        Me.trmcountdown.Interval = 1000
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cmdexit.Location = New System.Drawing.Point(146, 293)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(92, 34)
        Me.cmdexit.TabIndex = 14
        Me.cmdexit.Text = "&Exit"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(28, 343)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(333, 73)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(385, 448)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.img6)
        Me.Controls.Add(Me.img5)
        Me.Controls.Add(Me.img4)
        Me.Controls.Add(Me.img3)
        Me.Controls.Add(Me.img2)
        Me.Controls.Add(Me.img1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.cmbusername)
        Me.Controls.Add(Me.lblcountdown)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.cmdlogin)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblcountdown As System.Windows.Forms.Label
    Friend WithEvents cmbusername As System.Windows.Forms.ComboBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents img1 As System.Windows.Forms.PictureBox
    Friend WithEvents img2 As System.Windows.Forms.PictureBox
    Friend WithEvents img3 As System.Windows.Forms.PictureBox
    Friend WithEvents img4 As System.Windows.Forms.PictureBox
    Friend WithEvents img5 As System.Windows.Forms.PictureBox
    Friend WithEvents img6 As System.Windows.Forms.PictureBox
    Friend WithEvents trmcountdown As System.Windows.Forms.Timer
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
