﻿Imports MySql.Data.MySqlClient
Public Class MY_DB

    Private con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vbnet_student_db")
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return con

        End Get

    End Property

    Sub openConnection()

        If con.State = ConnectionState.Closed Then
            con.Open()

        End If


    End Sub

    Sub closeconnection()

        If con.State = ConnectionState.Open Then
            con.Close()

        End If

    End Sub

End Class
