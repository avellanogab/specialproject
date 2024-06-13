Public Class Statics_student
    Dim pantotalColor As Color
    Dim panmaleColor As Color
    Dim panfemaleColor As Color
    Private Sub Statics_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' get panels color

        pantotalColor = PanelTotalStudents.BackColor
        panmaleColor = PanelMale.BackColor
        panfemaleColor = PanelFemale.BackColor


        Dim student As New STUDENT()
        Dim total As Integer = Convert.ToInt32(student.totalstudent())
        Dim totalMale As Integer = Convert.ToInt32(student.totalMalestudent())
        Dim totalFemale As Integer = Convert.ToInt32(student.totalFemalestudent())

        ' count the %
        ' (total Male students X 100) / (total students)
        ' (total Female students X 100) / (total students)
        Dim maleStudentsPercentage As Double = totalMale * 100 / total
        Dim FemaleStudentsPercentage As Double = totalFemale * 100 / total


        LabelTotalStudents.Text = "Total Students: " & total.ToString()
        LabelMale.Text = "Male: " & maleStudentsPercentage.ToString(0.00) & "%"
        LabelFemale.Text = "Female: " & FemaleStudentsPercentage.ToString(0.00) & "%"




    End Sub
    Private Sub LabelTotal_MouseEnter(sender As Object, e As EventArgs) Handles PanelTotalStudents.MouseEnter

        LabelTotalStudents.ForeColor = pantotalColor
        PanelTotalStudents.BackColor = Color.Black

    End Sub

    Private Sub PanelTotalStudents_MouseHover(sender As Object, e As EventArgs) Handles PanelTotalStudents.MouseHover

        LabelTotalStudents.ForeColor = Color.Blue
        PanelTotalStudents.BackColor = pantotalColor

    End Sub


End Class