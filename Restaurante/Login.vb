Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtPass.Text = "admin" And txtUser.Text = "admin" Then
            Me.Hide()
            Pedidos.Show()
            Pedidos.cbMesero.Text = 1
            Pedidos.rbManana.Checked = True
        Else
            MessageBox.Show("Contraseña o Administrador incorrectos")
        End If
    End Sub
End Class