Imports System.IO

Public Class studentlistForm
    Private Sub studentlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim student As New STUDENT()

        DataGridView1.ReadOnly = True

        Dim picColo As New DataGridViewImageColumn()

        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = student.getstudent

        picColo = DataGridView1.Columns(7)

        picColo.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False








    End Sub

    Private Sub studentlistForm_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        'display the selected row data into update delete student form on double click

        Dim updateDeletestdf As New UpdateDeleteStudentForm()
        ' DATA ORDER -> id - fn - ln - bdt - gdr - phn - adrs - pic

        updateDeletestdf.TxtStudentID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        updateDeletestdf.TxtFirstname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        updateDeletestdf.TxtLastname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        updateDeletestdf.DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value
        ' gender
        If DataGridView1.CurrentRow.Cells(4).Value.ToString() = "Female" Then
            updateDeletestdf.RadioButtonFemale.Checked = True
        End If

        updateDeletestdf.TxtPhone.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        updateDeletestdf.TxtAddress.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()

        ' Display the image of datagridview to picturebox

        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        updateDeletestdf.PictureBoxStudent.Image = Image.FromStream(picture)



        updateDeletestdf.Show()

    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click

        Dim student As New STUDENT()

        DataGridView1.ReadOnly = True

        Dim picColo As New DataGridViewImageColumn()

        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = student.getstudent

        picColo = DataGridView1.Columns(7)

        picColo.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False


    End Sub
End Class