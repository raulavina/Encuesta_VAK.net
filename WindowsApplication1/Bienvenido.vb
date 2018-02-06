Public Class Bienvenido

    Dim resultado As MsgBoxResult
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Me.Hide()
        Menu_2.Show()




    End Sub

    Private Sub Bienvenido_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        resultado = CType(MessageBox.Show("Desea salir de la aplicacion", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
            e.Cancel = True

        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
