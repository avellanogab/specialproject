Imports MySql.Data.MySqlClient
Public Class LogIn_Form
    Private Sub LogIn_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cancel_btn_Click(sender As Object, e As EventArgs) Handles Cancel_btn.Click
        Close()

    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click

        Dim db As New MY_DB()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn AND `password` = @pass", db.getConnection)

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txt_username.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txt_password.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            Dim fmain As New MainForm()
            fmain.Show()
            Me.Close()


        Else

            MsgBox("Invalid Username and Password", MsgBoxStyle.Critical, "Login Error")


        End If



    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        If txt_password.UseSystemPasswordChar Then

            txt_password.UseSystemPasswordChar = False

        Else
            txt_password.UseSystemPasswordChar = True

        End If

    End Sub
End Class