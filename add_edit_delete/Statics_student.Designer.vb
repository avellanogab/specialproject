<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statics_student
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
        Me.PanelTotalStudents = New System.Windows.Forms.Panel()
        Me.LabelTotalStudents = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelMale = New System.Windows.Forms.Panel()
        Me.LabelMale = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelFemale = New System.Windows.Forms.Panel()
        Me.LabelFemale = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PanelTotalStudents.SuspendLayout()
        Me.PanelMale.SuspendLayout()
        Me.PanelFemale.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTotalStudents
        '
        Me.PanelTotalStudents.Controls.Add(Me.LabelTotalStudents)
        Me.PanelTotalStudents.Controls.Add(Me.Panel2)
        Me.PanelTotalStudents.Location = New System.Drawing.Point(0, 1)
        Me.PanelTotalStudents.Name = "PanelTotalStudents"
        Me.PanelTotalStudents.Size = New System.Drawing.Size(380, 143)
        Me.PanelTotalStudents.TabIndex = 0
        '
        'LabelTotalStudents
        '
        Me.LabelTotalStudents.AutoSize = True
        Me.LabelTotalStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalStudents.Location = New System.Drawing.Point(46, 41)
        Me.LabelTotalStudents.Name = "LabelTotalStudents"
        Me.LabelTotalStudents.Size = New System.Drawing.Size(198, 31)
        Me.LabelTotalStudents.TabIndex = 2
        Me.LabelTotalStudents.Text = "Total Students:"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 143)
        Me.Panel2.TabIndex = 1
        '
        'PanelMale
        '
        Me.PanelMale.Controls.Add(Me.LabelMale)
        Me.PanelMale.Controls.Add(Me.Panel4)
        Me.PanelMale.Location = New System.Drawing.Point(0, 146)
        Me.PanelMale.Name = "PanelMale"
        Me.PanelMale.Size = New System.Drawing.Size(189, 143)
        Me.PanelMale.TabIndex = 2
        '
        'LabelMale
        '
        Me.LabelMale.AutoSize = True
        Me.LabelMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMale.Location = New System.Drawing.Point(28, 39)
        Me.LabelMale.Name = "LabelMale"
        Me.LabelMale.Size = New System.Drawing.Size(142, 39)
        Me.LabelMale.TabIndex = 3
        Me.LabelMale.Text = "Male: %"
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 145)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(195, 143)
        Me.Panel4.TabIndex = 1
        '
        'PanelFemale
        '
        Me.PanelFemale.Controls.Add(Me.LabelFemale)
        Me.PanelFemale.Controls.Add(Me.Panel6)
        Me.PanelFemale.Location = New System.Drawing.Point(191, 146)
        Me.PanelFemale.Name = "PanelFemale"
        Me.PanelFemale.Size = New System.Drawing.Size(189, 143)
        Me.PanelFemale.TabIndex = 3
        '
        'LabelFemale
        '
        Me.LabelFemale.AutoSize = True
        Me.LabelFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFemale.Location = New System.Drawing.Point(10, 39)
        Me.LabelFemale.Name = "LabelFemale"
        Me.LabelFemale.Size = New System.Drawing.Size(155, 33)
        Me.LabelFemale.TabIndex = 3
        Me.LabelFemale.Text = "Female: %"
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(0, 145)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(195, 143)
        Me.Panel6.TabIndex = 1
        '
        'Statics_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 296)
        Me.Controls.Add(Me.PanelFemale)
        Me.Controls.Add(Me.PanelMale)
        Me.Controls.Add(Me.PanelTotalStudents)
        Me.Name = "Statics_student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statics"
        Me.PanelTotalStudents.ResumeLayout(False)
        Me.PanelTotalStudents.PerformLayout()
        Me.PanelMale.ResumeLayout(False)
        Me.PanelMale.PerformLayout()
        Me.PanelFemale.ResumeLayout(False)
        Me.PanelFemale.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTotalStudents As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelMale As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelFemale As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LabelTotalStudents As Label
    Friend WithEvents LabelMale As Label
    Friend WithEvents LabelFemale As Label
End Class
