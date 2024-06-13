Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net


Public Class STUDENT

    Dim db As New MY_DB()



    'FUNCTION TO INSERT A NEW STUDENT'

    Public Function InsertStudent(ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal phone As String, ByVal address As String, ByVal picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `student`(`First_name`, `Last_name`, `Birthdate`, `Gender`, `Phone`, `Address`, `Picture`) VALUES (@fn, @ln, @bdt, @gndr, @phn, @adrs, @pic)", db.getConnection)
        '@fn, @ln, @bdt, @gndr,  @phn, @adrs, @pic'
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gndr", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If
        db.closeconnection()

    End Function

    ' function to get all users from database
    Function getstudent() As DataTable

        Dim command As New MySqlCommand("SELECT * FROM `student`")
        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        Return table


    End Function

    Public Function deletestudent(ByVal id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `student` WHERE `id` = @studentID", db.getConnection)
        '
        command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id



        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If
        db.closeconnection()

    End Function

    'FUNCTION TO UPDATE A STUDENT INFORMATION'

    Public Function updateStudent(ByVal id As Integer, ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal phone As String, ByVal address As String, ByVal picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("UPDATE `student` SET `first_name`=@fn,`last_name`=@ln,`birthdate`=@bdt,`gender`=@gndr,`phone`=@phn,`address`=@adrs,`picture`=@pic WHERE id = @ID", db.getConnection)
        '@fn, @ln, @bdt, @gndr,  @phn, @adrs, @pic'

        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gndr", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If
        db.closeconnection()

    End Function

    Function execCount(ByVal query As String) As String
        'function to execute count query

        Dim command As New MySqlCommand(query, db.getConnection)

        db.openConnection()
        Return command.ExecuteScalar().ToString()
        db.closeconnection()


    End Function
    'function to return the total students in the database
    Function totalstudent() As String

        Return execCount("SELECT COUNT(*) FROM `student`")

    End Function
    'function to return the male students in the database
    Function totalMalestudent() As String

        Return execCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Male'")

    End Function
    'function to return the female students in the database
    Function totalFemalestudent() As String

        Return execCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Female'")

    End Function
End Class
