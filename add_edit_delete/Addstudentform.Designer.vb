<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addstudentform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFirstname = New System.Windows.Forms.TextBox()
        Me.TxtLastname = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBoxStudent = New System.Windows.Forms.PictureBox()
        Me.btnupload = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Birth Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address"
        '
        'TxtFirstname
        '
        Me.TxtFirstname.Location = New System.Drawing.Point(98, 34)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.Size = New System.Drawing.Size(271, 20)
        Me.TxtFirstname.TabIndex = 1
        '
        'TxtLastname
        '
        Me.TxtLastname.Location = New System.Drawing.Point(98, 67)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.Size = New System.Drawing.Size(271, 20)
        Me.TxtLastname.TabIndex = 2
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(97, 181)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(272, 20)
        Me.TxtPhone.TabIndex = 4
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(97, 214)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(272, 118)
        Me.TxtAddress.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(97, 100)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(272, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Picture:"
        '
        'PictureBoxStudent
        '
        Me.PictureBoxStudent.Location = New System.Drawing.Point(99, 358)
        Me.PictureBoxStudent.Name = "PictureBoxStudent"
        Me.PictureBoxStudent.Size = New System.Drawing.Size(270, 177)
        Me.PictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxStudent.TabIndex = 7
        Me.PictureBoxStudent.TabStop = False
        '
        'btnupload
        '
        Me.btnupload.Location = New System.Drawing.Point(97, 535)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(272, 23)
        Me.btnupload.TabIndex = 8
        Me.btnupload.Text = "Upload Image"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(140, 585)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancel.Location = New System.Drawing.Point(221, 585)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Gender:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonFemale)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMale)
        Me.GroupBox1.Location = New System.Drawing.Point(97, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 48)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
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
        'Addstudentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 642)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.btnupload)
        Me.Controls.Add(Me.PictureBoxStudent)
        Me.Controls.Add(Me.Label6)
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
        Me.Name = "Addstudentform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addstudentform"
        CType(Me.PictureBoxStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFirstname As TextBox
    Friend WithEvents TxtLastname As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBoxStudent As PictureBox
    Friend WithEvents btnupload As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
End Class
