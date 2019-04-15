Public Class frmviewrecords
    Dim total_marks As Short
    Dim studentname As String
    Dim assignment1 As Short
    Dim assignmnet2 As Short
    Dim assignment3 As Short
    Dim exam As Short
    Dim allmarks As Short
    Dim grade As String
    Dim cao_point As Integer
    Dim norepeat As Integer
    Dim DOB As Date
    Dim counter As Integer

    Dim user As Object
    Dim mycounter As Byte
    Dim mark(10) As Integer
    Dim student(15) As String
    Dim bestmark As Integer
    Dim c As Byte

    Dim worst_mark As Integer
    Dim WorstStudent As String
    Dim BestStudent As String
    Dim sum As Single
    Dim average As Single
    Dim x As Integer




    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
        frmmenu.Show()



    End Sub

    Private Sub frmviewrecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnloop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloop.Click
        For Me.mycounter = 1 To 10
            ListBox9.Items.Add(Me.mycounter)



        Next
    End Sub

    Private Sub btnfilllistboxes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfilllistboxes.Click
        On Error Resume Next

        worst_mark = 101
        FileOpen(1, My.Application.Info.DirectoryPath & "\results.DAT", OpenMode.Input)
        Do Until EOF(1)
            Input(1, studentname)
            Input(1, assignment1)
            Input(1, assignmnet2)
            Input(1, assignment3)
            Input(1, exam)
            Input(1, grade)
            Input(1, cao_point)

            ListBox1.Items.Add(studentname)
            ListBox2.Items.Add(assignment1)
            ListBox3.Items.Add(assignmnet2)
            ListBox4.Items.Add(assignment3)
            ListBox5.Items.Add(exam)
            ListBox6.Items.Add(grade)
            ListBox7.Items.Add(cao_point)

            allmarks = assignment1 + assignmnet2 + assignment3 + exam


            sum = sum + allmarks
            ListBox8.Items.Add(allmarks)
            student(c) = Name

            If bestmark < allmarks Then
                bestmark = allmarks
                BestStudent = studentname
            End If

            If worst_mark > allmarks Then
                worst_mark = allmarks
                WorstStudent = studentname
            End If

            c = c + 1

            average = sum / c
            txttotalsum.Text = sum
            txtaveragemark.Text = average

        Loop

        txtbeststudent.Text = BestStudent
        txtbestmark.Text = bestmark
        txtworststudent.Text = WorstStudent
        txtworstmark.Text = worst_mark
        FileClose(1)




    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number.Click

    End Sub

    Private Sub ListBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox9.SelectedIndexChanged

    End Sub
End Class