<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewrecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmviewrecords))
        Me.cmdexit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.ListBox4 = New System.Windows.Forms.ListBox
        Me.ListBox5 = New System.Windows.Forms.ListBox
        Me.ListBox6 = New System.Windows.Forms.ListBox
        Me.ListBox7 = New System.Windows.Forms.ListBox
        Me.ListBox8 = New System.Windows.Forms.ListBox
        Me.txtaveragemark = New System.Windows.Forms.TextBox
        Me.txtworststudent = New System.Windows.Forms.TextBox
        Me.txtbeststudent = New System.Windows.Forms.TextBox
        Me.txttotalsum = New System.Windows.Forms.TextBox
        Me.btnfilllistboxes = New System.Windows.Forms.Button
        Me.btnloop = New System.Windows.Forms.Button
        Me.lblbeststudent = New System.Windows.Forms.Label
        Me.lblworststudent = New System.Windows.Forms.Label
        Me.lblaveragemark = New System.Windows.Forms.Label
        Me.lbltotalsum = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtbestmark = New System.Windows.Forms.TextBox
        Me.txtworstmark = New System.Windows.Forms.TextBox
        Me.ListBox9 = New System.Windows.Forms.ListBox
        Me.Number = New System.Windows.Forms.Label
        Me.cmbhelp = New System.Windows.Forms.ComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cmdexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(320, 479)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(141, 49)
        Me.cmdexit.TabIndex = 0
        Me.cmdexit.Text = "&Go back"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "A1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "A2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "A3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(428, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Exam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(603, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Mark %"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(509, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Grade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(694, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "CAO points"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(64, 161)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(102, 173)
        Me.ListBox1.TabIndex = 9
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(172, 161)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(70, 173)
        Me.ListBox2.TabIndex = 10
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(248, 161)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(66, 173)
        Me.ListBox3.TabIndex = 11
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(320, 161)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(67, 173)
        Me.ListBox4.TabIndex = 12
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(402, 161)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(81, 173)
        Me.ListBox5.TabIndex = 13
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.Location = New System.Drawing.Point(495, 161)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(75, 173)
        Me.ListBox6.TabIndex = 14
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.Location = New System.Drawing.Point(588, 162)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(74, 173)
        Me.ListBox7.TabIndex = 15
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.Location = New System.Drawing.Point(683, 161)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(71, 173)
        Me.ListBox8.TabIndex = 16
        '
        'txtaveragemark
        '
        Me.txtaveragemark.Location = New System.Drawing.Point(402, 422)
        Me.txtaveragemark.Name = "txtaveragemark"
        Me.txtaveragemark.Size = New System.Drawing.Size(108, 20)
        Me.txtaveragemark.TabIndex = 17
        '
        'txtworststudent
        '
        Me.txtworststudent.Location = New System.Drawing.Point(402, 379)
        Me.txtworststudent.Name = "txtworststudent"
        Me.txtworststudent.Size = New System.Drawing.Size(108, 20)
        Me.txtworststudent.TabIndex = 18
        '
        'txtbeststudent
        '
        Me.txtbeststudent.Location = New System.Drawing.Point(402, 353)
        Me.txtbeststudent.Name = "txtbeststudent"
        Me.txtbeststudent.Size = New System.Drawing.Size(108, 20)
        Me.txtbeststudent.TabIndex = 19
        '
        'txttotalsum
        '
        Me.txttotalsum.Location = New System.Drawing.Point(654, 443)
        Me.txttotalsum.Name = "txttotalsum"
        Me.txttotalsum.Size = New System.Drawing.Size(100, 20)
        Me.txttotalsum.TabIndex = 20
        '
        'btnfilllistboxes
        '
        Me.btnfilllistboxes.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnfilllistboxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfilllistboxes.Location = New System.Drawing.Point(39, 479)
        Me.btnfilllistboxes.Name = "btnfilllistboxes"
        Me.btnfilllistboxes.Size = New System.Drawing.Size(128, 49)
        Me.btnfilllistboxes.TabIndex = 22
        Me.btnfilllistboxes.Text = "&Display report"
        Me.btnfilllistboxes.UseVisualStyleBackColor = False
        '
        'btnloop
        '
        Me.btnloop.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnloop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloop.Location = New System.Drawing.Point(173, 479)
        Me.btnloop.Name = "btnloop"
        Me.btnloop.Size = New System.Drawing.Size(141, 49)
        Me.btnloop.TabIndex = 23
        Me.btnloop.Text = "&Print 1 to 10"
        Me.btnloop.UseVisualStyleBackColor = False
        '
        'lblbeststudent
        '
        Me.lblbeststudent.AutoSize = True
        Me.lblbeststudent.Location = New System.Drawing.Point(324, 356)
        Me.lblbeststudent.Name = "lblbeststudent"
        Me.lblbeststudent.Size = New System.Drawing.Size(66, 13)
        Me.lblbeststudent.TabIndex = 25
        Me.lblbeststudent.Text = "Best student"
        '
        'lblworststudent
        '
        Me.lblworststudent.AutoSize = True
        Me.lblworststudent.Location = New System.Drawing.Point(323, 382)
        Me.lblworststudent.Name = "lblworststudent"
        Me.lblworststudent.Size = New System.Drawing.Size(73, 13)
        Me.lblworststudent.TabIndex = 26
        Me.lblworststudent.Text = "Worst student"
        '
        'lblaveragemark
        '
        Me.lblaveragemark.AutoSize = True
        Me.lblaveragemark.Location = New System.Drawing.Point(324, 425)
        Me.lblaveragemark.Name = "lblaveragemark"
        Me.lblaveragemark.Size = New System.Drawing.Size(73, 13)
        Me.lblaveragemark.TabIndex = 27
        Me.lblaveragemark.Text = "Average mark"
        '
        'lbltotalsum
        '
        Me.lbltotalsum.AutoSize = True
        Me.lbltotalsum.Location = New System.Drawing.Point(582, 448)
        Me.lbltotalsum.Name = "lbltotalsum"
        Me.lbltotalsum.Size = New System.Drawing.Size(53, 13)
        Me.lbltotalsum.TabIndex = 28
        Me.lbltotalsum.Text = "Total sum"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(190, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(389, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'txtbestmark
        '
        Me.txtbestmark.Location = New System.Drawing.Point(516, 353)
        Me.txtbestmark.Name = "txtbestmark"
        Me.txtbestmark.Size = New System.Drawing.Size(111, 20)
        Me.txtbestmark.TabIndex = 31
        '
        'txtworstmark
        '
        Me.txtworstmark.Location = New System.Drawing.Point(516, 379)
        Me.txtworstmark.Name = "txtworstmark"
        Me.txtworstmark.Size = New System.Drawing.Size(111, 20)
        Me.txtworstmark.TabIndex = 32
        '
        'ListBox9
        '
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.Location = New System.Drawing.Point(12, 161)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(46, 173)
        Me.ListBox9.TabIndex = 33
        '
        'Number
        '
        Me.Number.AllowDrop = True
        Me.Number.AutoSize = True
        Me.Number.Location = New System.Drawing.Point(14, 130)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(44, 13)
        Me.Number.TabIndex = 34
        Me.Number.Text = "Number"
        '
        'cmbhelp
        '
        Me.cmbhelp.FormattingEnabled = True
        Me.cmbhelp.Items.AddRange(New Object() {"Click on ""Display report"" to view report", "Click on ""Print 1 to 10"" to get numbers", "Click on ""Go back"" to exit"})
        Me.cmbhelp.Location = New System.Drawing.Point(37, 371)
        Me.cmbhelp.Name = "cmbhelp"
        Me.cmbhelp.Size = New System.Drawing.Size(220, 21)
        Me.cmbhelp.TabIndex = 35
        Me.cmbhelp.Text = "Click here to get help"
        '
        'frmviewrecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.cmbhelp)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.txtworstmark)
        Me.Controls.Add(Me.txtbestmark)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbltotalsum)
        Me.Controls.Add(Me.lblaveragemark)
        Me.Controls.Add(Me.lblworststudent)
        Me.Controls.Add(Me.lblbeststudent)
        Me.Controls.Add(Me.btnloop)
        Me.Controls.Add(Me.btnfilllistboxes)
        Me.Controls.Add(Me.txttotalsum)
        Me.Controls.Add(Me.txtbeststudent)
        Me.Controls.Add(Me.txtworststudent)
        Me.Controls.Add(Me.txtaveragemark)
        Me.Controls.Add(Me.ListBox8)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdexit)
        Me.Name = "frmviewrecords"
        Me.Text = "frmviewrecords"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox6 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox7 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox8 As System.Windows.Forms.ListBox
    Friend WithEvents txtaveragemark As System.Windows.Forms.TextBox
    Friend WithEvents txtworststudent As System.Windows.Forms.TextBox
    Friend WithEvents txtbeststudent As System.Windows.Forms.TextBox
    Friend WithEvents txttotalsum As System.Windows.Forms.TextBox
    Friend WithEvents btnfilllistboxes As System.Windows.Forms.Button
    Friend WithEvents btnloop As System.Windows.Forms.Button
    Friend WithEvents lblbeststudent As System.Windows.Forms.Label
    Friend WithEvents lblworststudent As System.Windows.Forms.Label
    Friend WithEvents lblaveragemark As System.Windows.Forms.Label
    Friend WithEvents lbltotalsum As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtbestmark As System.Windows.Forms.TextBox
    Friend WithEvents txtworstmark As System.Windows.Forms.TextBox
    Friend WithEvents ListBox9 As System.Windows.Forms.ListBox
    Friend WithEvents Number As System.Windows.Forms.Label
    Friend WithEvents cmbhelp As System.Windows.Forms.ComboBox
End Class
