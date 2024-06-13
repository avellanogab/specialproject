Imports System.IO

Public Class UpdateDeleteStudentForm
    Dim student As New STUDENT()
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        'delete studemt
        Try
            Dim studentid As Integer = Convert.ToInt32(TxtStudentID.Text)
            ' Display a confirmation message before the delete

            If MsgBox("Are you sure you want to delete this student", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then

                If student.deletestudent(studentid) Then
                    MsgBox("Student Deleted", MsgBoxStyle.Information, "Delete Student")

                    ' clear fields after delete

                    TxtStudentID.Text = ""
                    TxtFirstname.Text = ""
                    TxtLastname.Text = ""
                    TxtAddress.Text = ""
                    TxtPhone.Text = ""
                    DateTimePicker1.Value = Date.Now
                    PictureBoxStudent.Image = Nothing

                Else

                    MsgBox("Student not Deleted", MsgBoxStyle.Information, "Delete Student")

                End If



            End If

        Catch ex As Exception
            MsgBox("Please Enter A Valid ID", MsgBoxStyle.Information, "Delete Student")

        End Try







    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim student As New STUDENT()
        Dim id As Integer
        Dim fname As String = TxtFirstname.Text
        Dim lname As String = TxtLastname.Text
        Dim bdate As Date = DateTimePicker1.Value
        Dim phone As String = TxtPhone.Text
        Dim adrs As String = TxtAddress.Text

        Dim gender As String = "Male"

        If RadioButtonFemale.Checked Then gender = "Female"



        Dim pic As New MemoryStream

        'check if birhdate is high or to low

        Dim born_year As Integer = DateTimePicker1.Value.Year
        Dim this_year As Integer = Date.Now.Year

        'allow only students age between 10 - 25
        If this_year - born_year < 10 Or this_year - born_year > 25 Then

            MsgBox("The student age must be between 10 - 25 yrs old", MsgBoxStyle.Information, "Birt Date Error")

        Else

            If verif() Then
                Try
                    id = Convert.ToInt32(TxtStudentID.Text)
                Catch ex As Exception
                    MsgBox("Please enter a Valid Numberic Student ID", MsgBoxStyle.Exclamation, "Edit Student")
                End Try

                PictureBoxStudent.Image.Save(pic, PictureBoxStudent.Image.RawFormat)

                If student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic) Then

                    MsgBox("Student Information Updated", MsgBoxStyle.Information, "Edit Student")

                Else

                    MsgBox("Error", MsgBoxStyle.Critical, "Edit Student")

                End If
            Else

                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Edit Student")

            End If
        End If

    End Sub

    ' create a function to verify data
    Function verif() As Boolean

        If TxtStudentID.Text.Trim = "" Or TxtFirstname.Text.Trim = "" Or
           TxtLastname.Text.Trim = "" Or TxtPhone.Text.Trim = "" Or
           TxtAddress.Text.Trim = "" Or PictureBoxStudent.Image Is Nothing Then



            Return False

        Else
            Return True

        End If



    End Function

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then

            PictureBoxStudent.Image = Image.FromFile(opf.FileName)

        End If
    End Sub
End Class