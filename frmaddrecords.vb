Public Class frmaddrecords

    Dim studentname As String
    Dim assignment1 As Short
    Dim assignment2 As Short
    Dim assignment3 As Short
    Dim exam As Short
    Dim allMarksInput As Short
    Dim grade As String
    Dim cao_points As Short


    Private Sub frmaddrecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        FileOpen(5, My.Application.Info.DirectoryPath & "\results.dat", OpenMode.Append)
        studentname = InputBox("Enter name (or click cancel to stop):")
        Do Until studentname = ""
            assignment1 = (InputBox("Enter a mark between 1 and 20 ", "Assignment 1"))
            If assignment1 < 1 Or assignment1 > 20 Then
                MsgBox("Please enter a Mark between 1 and 20 ")
            End If
            assignment2 = (InputBox("Enter a mark between 1 and 20 ", "Assignment 2"))
            If assignment2 < 1 Or assignment2 > 20 Then
                MsgBox("Please enter a Mark between 1 and 20 ")
            End If
            assignment3 = (InputBox("Enter a mark between 1 and 30 ", "Assignment 3"))
            If assignment3 < 1 Or assignment2 > 30 Then
                MsgBox("Please enter a Mark between 1 and 30 ")
            End If
            exam = (InputBox("Enter a mark between 1 and 30 ", "Exam"))
            If exam < 1 Or exam > 30 Then
                MsgBox("Please enter a Mark between 1 and 30 ")
            End If
            allMarksInput = assignment1 + assignment2 + assignment3 + exam
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


            WriteLine(5, studentname, assignment1, assignment2, assignment3, exam, grade, cao_points)
            studentname = InputBox("Enter name ( or click cancel to stop ):")

        Loop
    End Sub
End Class