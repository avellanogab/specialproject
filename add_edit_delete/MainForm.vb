Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click

        Dim AddStdf As New Addstudentform()
        AddStdf.Show(Me)






    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click

        Dim stdListf As New studentlistForm()
        stdListf.Show(Me)


    End Sub

    Private Sub STUDENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTToolStripMenuItem.Click

    End Sub

    Private Sub StaticsStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaticsStudentsToolStripMenuItem.Click

        Dim stcF As New Statics_student()
        stcF.Show(Me)

    End Sub
End Class