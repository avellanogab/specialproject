Imports System.IO
Public Class Addstudentform
    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress
        ' allow only numbers on this textbox ' 

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then

            PictureBoxStudent.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        Close()



    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Dim student As New STUDENT()
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

                PictureBoxStudent.Image.Save(pic, PictureBoxStudent.Image.RawFormat)

                If student.InsertStudent(fname, lname, bdate, gender, phone, adrs, pic) Then

                    MsgBox("New Student Added", MsgBoxStyle.Information, "Add Student")

                Else

                    MsgBox("Error", MsgBoxStyle.Critical, "Add Student")

                End If
            Else

                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Student")

            End If
        End If

    End Sub

    ' create a function to verify data
    Function verif() As Boolean

        If TxtFirstname.Text.Trim = "" Or TxtLastname.Text.Trim = "" Or
        TxtPhone.Text.Trim = "" Or TxtAddress.Text.Trim = "" Or
        PictureBoxStudent.Image Is Nothing Then



            Return False

        Else
            Return True

        End If



    End Function



End Class