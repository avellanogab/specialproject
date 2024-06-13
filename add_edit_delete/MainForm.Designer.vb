<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.STUDENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COURSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaticsStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTToolStripMenuItem, Me.COURSEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'STUDENTToolStripMenuItem
        '
        Me.STUDENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolStripMenuItem, Me.StudentListToolStripMenuItem, Me.StaticsStudentsToolStripMenuItem})
        Me.STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        Me.STUDENTToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.STUDENTToolStripMenuItem.Text = "STUDENT"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddStudentToolStripMenuItem.Text = "Add New Student"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StudentListToolStripMenuItem.Text = "Student Lists"
        '
        'COURSEToolStripMenuItem
        '
        Me.COURSEToolStripMenuItem.Name = "COURSEToolStripMenuItem"
        Me.COURSEToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.COURSEToolStripMenuItem.Text = "COURSE"
        '
        'StaticsStudentsToolStripMenuItem
        '
        Me.StaticsStudentsToolStripMenuItem.Name = "StaticsStudentsToolStripMenuItem"
        Me.StaticsStudentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StaticsStudentsToolStripMenuItem.Text = "Statics Students"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents STUDENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COURSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaticsStudentsToolStripMenuItem As ToolStripMenuItem
End Class
