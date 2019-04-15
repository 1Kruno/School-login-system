Public Class Form1

    Dim username As String
    Dim password As String

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click

        username = cmbusername.SelectedItem.ToString()
        password = txtpassword.Text

        If username = "ADMIN" And password = "admin" Then
            MsgBox("Access granted")
            frmmenu.Show()
            frmmenu.cmdaddrecords.Enabled = True
            trmcountdown.Enabled = False


            Me.Hide()

        ElseIf username = "GUEST" And password = "password" Then
            MsgBox("Access granted")
            frmmenu.Show()
            frmmenu.cmdaddrecords.Enabled = False
            Me.Hide()
            trmcountdown.Enabled = False
        Else
            MsgBox("Access denied")



        End If

    End Sub

    Private Sub cmbusername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusername.SelectedIndexChanged



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trmcountdown.Tick
        counter = counter - 1
        lblcountdown.Text = counter & " seconds remaining "

        If counter = 19 Then
            img1.Visible = True
        End If
        If counter = 18 Then
            img1.Visible = False
            img2.Visible = True
        End If
        If counter = 17 Then
            img2.Visible = False
            img3.Visible = True
        End If
        If counter = 16 Then
            img3.Visible = False
            img4.Visible = True
        End If
        If counter = 15 Then
            img4.Visible = False
            img5.Visible = True
        End If
        If counter = 14 Then
            img5.Visible = False
            img6.Visible = True
        End If

        If counter = 13 Then
            img6.Visible = False
            img1.Visible = True
        End If
        If counter = 12 Then
            img1.Visible = False
            img2.Visible = True
        End If
        If counter = 11 Then
            img2.Visible = False
            img3.Visible = True
        End If
        If counter = 10 Then
            img3.Visible = False
            img4.Visible = True
        End If
        If counter = 9 Then
            img4.Visible = False
            img5.Visible = True
        End If
        If counter = 8 Then
            img5.Visible = False
            img6.Visible = True
        End If
        If counter = 7 Then
            img6.Visible = False
            img1.Visible = True
        End If
        If counter = 6 Then
            img1.Visible = False
            img2.Visible = True
        End If
        If counter = 5 Then
            img2.Visible = False
            img3.Visible = True
        End If
        If counter = 4 Then
            img3.Visible = False
            img4.Visible = True
        End If
        If counter = 3 Then
            img4.Visible = False
            img5.Visible = True
        End If
        If counter = 2 Then
            img5.Visible = False
            img6.Visible = True
        End If
        If counter = 1 Then
            img6.Visible = False
            img1.Visible = True
            trmcountdown.Enabled = False
            Me.Hide()
            MsgBox("Time is up!")



           

        End If

    End Sub

   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        counter = 20
        trmcountdown.Enabled = True



        
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()



    End Sub
End Class
