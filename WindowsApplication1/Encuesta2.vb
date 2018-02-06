Public Class Encuesta2

    Private Property puntaje As Integer
    Public Shared res2 As Integer
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'TextBox1.Text = Module1.res1
        Encuesta3.Show()
        puntaje = 0
        If RadioButton1.Checked = True Then puntaje = puntaje + 4
        If RadioButton2.Checked = True Then puntaje = puntaje + 1
        If RadioButton3.Checked = True Then puntaje = puntaje + 3
        If RadioButton4.Checked = True Then puntaje = puntaje + 2
        If RadioButton5.Checked = True Then puntaje = puntaje + 3
        If RadioButton6.Checked = True Then puntaje = puntaje + 2
        If RadioButton7.Checked = True Then puntaje = puntaje + 4
        If RadioButton8.Checked = True Then puntaje = puntaje + 1
        If RadioButton9.Checked = True Then puntaje = puntaje + 3
        If RadioButton10.Checked = True Then puntaje = puntaje + 1
        If RadioButton11.Checked = True Then puntaje = puntaje + 2
        If RadioButton12.Checked = True Then puntaje = puntaje + 4
        If RadioButton13.Checked = True Then puntaje = puntaje + 1
        If RadioButton14.Checked = True Then puntaje = puntaje + 4
        If RadioButton15.Checked = True Then puntaje = puntaje + 2
        If RadioButton16.Checked = True Then puntaje = puntaje + 3
        If RadioButton17.Checked = True Then puntaje = puntaje + 1
        If RadioButton18.Checked = True Then puntaje = puntaje + 3
        If RadioButton19.Checked = True Then puntaje = puntaje + 2
        If RadioButton20.Checked = True Then puntaje = puntaje + 4
        If RadioButton21.Checked = True Then puntaje = puntaje + 4
        If RadioButton22.Checked = True Then puntaje = puntaje + 3
        If RadioButton23.Checked = True Then puntaje = puntaje + 1
        If RadioButton24.Checked = True Then puntaje = puntaje + 2

        puntaje = res2 + Encuesta1.puntaje

    End Sub
End Class