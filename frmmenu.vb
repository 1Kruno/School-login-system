Public Class frmmenu
    Dim studentname As String
    Dim Assignment1 As Short
    Dim Assignment2 As Short
    Dim assignment3 As Short
    Dim Exam As Short
    Dim allMarksInput As Short
    Dim DOB As Date
    Dim grade As String
    Dim cao_points As Short
    Dim cmbusername As String

    


    Private Sub cmdaddrecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddrecords.Click

        On Error Resume Next
        FileOpen(5, My.Application.Info.DirectoryPath & "\results.dat", OpenMode.Append)
        studentname = InputBox("Enter name (or click cancel to stop):")
        Do Until studentname = ""
            Assignment1 = (InputBox("Enter a mark between 1 and 20 ", "Assignment 1"))
            If Assignment1 < 1 Or Assignment1 > 20 Then
                MsgBox("Please enter a Mark between 1 and 20 ")
            End If
            Assignment2 = (InputBox("Enter a mark between 1 and 20 ", "Assignment 2"))
            If Assignment2 < 1 Or Assignment2 > 20 Then
                MsgBox("Please enter a Mark between 1 and 20 ")
            End If
            assignment3 = (InputBox("Enter a mark between 1 and 30 ", "Assignment 3"))
            If assignment3 < 1 Or Assignment2 > 30 Then
                MsgBox("Please enter a Mark between 1 and 30 ")
            End If
            Exam = (InputBox("Enter a mark between 1 and 30 ", "Exam"))
            If Exam < 1 Or Exam > 30 Then
                MsgBox("Please enter a Mark between 1 and 30 ")
            End If
            allMarksInput = Assignment1 + Assignment2 + assignment3 + Exam
            If allMarksInput < 50 Then
                grade = "U"
                cao_points = 0
            End If
            If allMarksInput >= 50 And allMarksInput < 65 Then
                grade = "P"
                cao_points = 16.67
            End If

            If allMarksInput >= 65 And allMarksInput < 80 Then
                grade = "M"
                cao_points = 33.33
            End If

            If allMarksInput >= 80 Then
                grade = "D"
                cao_points = 50
            End If


            WriteLine(5, studentname, Assignment1, Assignment2, assignment3, Exam, grade, cao_points)
            studentname = InputBox("Enter name ( or click cancel to stop ):")

        Loop




    End Sub

    Private Sub cmdviewrecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdviewrecords.Click
        frmviewrecords.Show()
        Me.Hide()

    End Sub

    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click

        Close()


    End Sub


    
    Private Sub frmmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cmbusername = "GUEST" Then
            cmdaddrecords.Enabled = False
        Else
            cmdaddrecords.Enabled = True
        End If

    End Sub
End Class