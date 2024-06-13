<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDeleteStudentForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtLastname = New System.Windows.Forms.TextBox()
        Me.TxtFirstname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.btnupload = New System.Windows.Forms.Button()
        Me.PictureBoxStudent = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtStudentID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonFemale)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMale)
        Me.GroupBox1.Location = New System.Drawing.Point(95, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 48)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Location = New System.Drawing.Point(124, 13)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonFemale.TabIndex = 1
        Me.RadioButtonFemale.TabStop = True
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Location = New System.Drawing.Point(7, 13)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonMale.TabIndex = 0
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Gender:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 143)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(272, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(95, 270)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(272, 118)
        Me.TxtAddress.TabIndex = 22
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(95, 237)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(272, 20)
        Me.TxtPhone.TabIndex = 20
        '
        'TxtLastname
        '
        Me.TxtLastname.Location = New System.Drawing.Point(96, 110)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.Size = New System.Drawing.Size(271, 20)
        Me.TxtLastname.TabIndex = 16
        '
        'TxtFirstname
        '
        Me.TxtFirstname.Location = New System.Drawing.Point(96, 77)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.Size = New System.Drawing.Size(271, 20)
        Me.TxtFirstname.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Phone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Birth Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "First name:"
        '
        'BtnRemove
        '
        Me.BtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRemove.Location = New System.Drawing.Point(571, 278)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 29
        Me.BtnRemove.Text = "REMOVE"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(490, 278)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 28
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'btnupload
        '
        Me.btnupload.Location = New System.Drawing.Point(447, 228)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(272, 23)
        Me.btnupload.TabIndex = 27
        Me.btnupload.Text = "Upload Image"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'PictureBoxStudent
        '
        Me.PictureBoxStudent.Location = New System.Drawing.Point(449, 51)
        Me.PictureBoxStudent.Name = "PictureBoxStudent"
        Me.PictureBoxStudent.Size = New System.Drawing.Size(270, 177)
        Me.PictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxStudent.TabIndex = 26
        Me.PictureBoxStudent.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(400, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Picture:"
        '
        'TxtStudentID
        '
        Me.TxtStudentID.Location = New System.Drawing.Point(95, 44)
        Me.TxtStudentID.Name = "TxtStudentID"
        Me.TxtStudentID.Size = New System.Drawing.Size(70, 20)
        Me.TxtStudentID.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "ID:"
        '
        'UpdateDeleteStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 434)
        Me.Controls.Add(Me.TxtStudentID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.btnupload)
        Me.Controls.Add(Me.PictureBoxStudent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.TxtLastname)
        Me.Controls.Add(Me.TxtFirstname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateDeleteStudentForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateDeleteStudentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtLastname As TextBox
    Friend WithEvents TxtFirstname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents btnupload As Button
    Friend WithEvents PictureBoxStudent As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtStudentID As TextBox
    Friend WithEvents Label8 As Label
End Class
