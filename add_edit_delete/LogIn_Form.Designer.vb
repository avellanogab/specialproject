<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBoxlogin = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Login_btn = New System.Windows.Forms.Button()
        Me.Cancel_btn = New System.Windows.Forms.Button()
        Me.CheckBoxPass = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBoxlogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxlogin
        '
        Me.PictureBoxlogin.Location = New System.Drawing.Point(12, 24)
        Me.PictureBoxlogin.Name = "PictureBoxlogin"
        Me.PictureBoxlogin.Size = New System.Drawing.Size(260, 204)
        Me.PictureBoxlogin.TabIndex = 0
        Me.PictureBoxlogin.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(359, 63)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(100, 20)
        Me.txt_username.TabIndex = 3
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(359, 99)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(100, 20)
        Me.txt_password.TabIndex = 4
        Me.txt_password.UseSystemPasswordChar = True
        '
        'Login_btn
        '
        Me.Login_btn.Location = New System.Drawing.Point(303, 178)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.Size = New System.Drawing.Size(75, 23)
        Me.Login_btn.TabIndex = 5
        Me.Login_btn.Text = "Log In"
        Me.Login_btn.UseVisualStyleBackColor = True
        '
        'Cancel_btn
        '
        Me.Cancel_btn.Location = New System.Drawing.Point(384, 178)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_btn.TabIndex = 6
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.UseVisualStyleBackColor = True
        '
        'CheckBoxPass
        '
        Me.CheckBoxPass.AutoSize = True
        Me.CheckBoxPass.Location = New System.Drawing.Point(316, 138)
        Me.CheckBoxPass.Name = "CheckBoxPass"
        Me.CheckBoxPass.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxPass.TabIndex = 7
        Me.CheckBoxPass.Text = "Show password"
        Me.CheckBoxPass.UseVisualStyleBackColor = True
        '
        'LogIn_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 247)
        Me.Controls.Add(Me.CheckBoxPass)
        Me.Controls.Add(Me.Cancel_btn)
        Me.Controls.Add(Me.Login_btn)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxlogin)
        Me.Name = "LogIn_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn_Form"
        CType(Me.PictureBoxlogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxlogin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Login_btn As Button
    Friend WithEvents Cancel_btn As Button
    Friend WithEvents CheckBoxPass As CheckBox
End Class
