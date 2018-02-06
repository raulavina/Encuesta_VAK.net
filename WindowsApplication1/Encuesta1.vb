Public Class Encuesta1

    Public Property puntaje As Integer
    Public Shared res1 As Integer


    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Module1.res1 = TextBox1.Text

        Dim f2 As New Encuesta2
        Encuesta2.Show()
        Dim puntaje = 0
        If RadioButton1.Checked = True Then puntaje = puntaje + 1
        If RadioButton2.Checked = True Then puntaje = puntaje + 2
        If RadioButton3.Checked = True Then puntaje = puntaje + 3
        If RadioButton4.Checked = True Then puntaje = puntaje + 4
        If RadioButton5.Checked = True Then puntaje = puntaje + 1
        If RadioButton6.Checked = True Then puntaje = puntaje + 2
        If RadioButton7.Checked = True Then puntaje = puntaje + 3
        If RadioButton8.Checked = True Then puntaje = puntaje + 4
        If RadioButton9.Checked = True Then puntaje = puntaje + 1
        If RadioButton10.Checked = True Then puntaje = puntaje + 4
        If RadioButton11.Checked = True Then puntaje = puntaje + 3
        If RadioButton12.Checked = True Then puntaje = puntaje + 2
        If RadioButton13.Checked = True Then puntaje = puntaje + 3
        If RadioButton14.Checked = True Then puntaje = puntaje + 4
        If RadioButton15.Checked = True Then puntaje = puntaje + 2
        If RadioButton16.Checked = True Then puntaje = puntaje + 1
        If RadioButton17.Checked = True Then puntaje = puntaje + 4
        If RadioButton18.Checked = True Then puntaje = puntaje + 3
        If RadioButton19.Checked = True Then puntaje = puntaje + 1
        If RadioButton20.Checked = True Then puntaje = puntaje + 2
        If RadioButton21.Checked = True Then puntaje = puntaje + 4
        If RadioButton22.Checked = True Then puntaje = puntaje + 2
        If RadioButton23.Checked = True Then puntaje = puntaje + 3
        If RadioButton24.Checked = True Then puntaje = puntaje + 1

        puntaje = res1

        'Int(res1 = Class1.res4)


    End Sub

    Private Sub Encuesta1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class