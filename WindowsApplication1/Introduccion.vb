Public Class Introduccion

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Menu_2.Show()

    End Sub

    Private Sub Introduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class