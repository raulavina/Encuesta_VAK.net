Public Class Encuesta3

    Private Property puntaje As Integer
    Public Shared res3 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        puntaje = res3 + res2 + Encuesta1.puntaje

        If puntaje >= 48 Then
            Me.Hide()
            Kinestesico.Show()

        End If

        If puntaje >= 64 Then
            Me.Hide()
            Leer_Escribir.Show()
        End If

        If puntaje <= 32 Then
            Me.Hide()
            Visual.Show()
        End If

        If puntaje <= 16 Then
            Me.Hide()
            Auditivo.Show()
        End If

        puntaje = 0
        If RadioButton1.Checked = True Then puntaje = puntaje + 4
        If RadioButton2.Checked = True Then puntaje = puntaje + 3
        If RadioButton3.Checked = True Then puntaje = puntaje + 1
        If RadioButton4.Checked = True Then puntaje = puntaje + 2
        If RadioButton5.Checked = True Then puntaje = puntaje + 4
        If RadioButton6.Checked = True Then puntaje = puntaje + 3
        If RadioButton7.Checked = True Then puntaje = puntaje + 2
        If RadioButton8.Checked = True Then puntaje = puntaje + 1
        If RadioButton9.Checked = True Then puntaje = puntaje + 4
        If RadioButton10.Checked = True Then puntaje = puntaje + 3
        If RadioButton11.Checked = True Then puntaje = puntaje + 2
        If RadioButton12.Checked = True Then puntaje = puntaje + 1
        If RadioButton13.Checked = True Then puntaje = puntaje + 3
        If RadioButton14.Checked = True Then puntaje = puntaje + 4
        If RadioButton15.Checked = True Then puntaje = puntaje + 2
        If RadioButton16.Checked = True Then puntaje = puntaje + 1

        puntaje = res3

        



    End Sub

   

End Class