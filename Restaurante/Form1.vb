Public Class Pedidos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Dim total As Double
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
    Private Sub lbAlimentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAlimentos.SelectedIndexChanged
        Select Case lbAlimentos.SelectedIndex
            Case 0
                lbPedido.Items.Add("Dona de chocolate $15")
                total = total + 15
                lblt.Text = total
            Case 1
                lbPedido.Items.Add("Dona de vainilla $15")
                total = total + 15
                lblt.Text = total
            Case 2
                lbPedido.Items.Add("Panini $25")
                total = total + 25
                lblt.Text = total
            Case 3
                lbPedido.Items.Add("Brownies $30")
                total = total + 30
                lblt.Text = total
            Case 4
                lbPedido.Items.Add("Galletas de chocolate $10")
                total = total + 10
                lblt.Text = total
        End Select
    End Sub

    Private Sub lbBebidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBebidas.SelectedIndexChanged
        Select Case lbAlimentos.SelectedIndex

            Case 0
                lbPedido.Items.Add("Refresco coca cola $15")
                total = total + 15
                lblt.Text = total
            Case 1
                lbPedido.Items.Add("Refresco Pepsi $15")
                total = total + 15
                lblt.Text = total
            Case 2
                lbPedido.Items.Add("Café americano $15")
                total = total + 15
                lblt.Text = total
            Case 3
                lbPedido.Items.Add("Café expreso $15")
                total = total + 15
                lblt.Text = total
            Case 4
                lbPedido.Items.Add("Agua $20")
                total = total + 20
                lblt.Text = total

        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(total, "El total a pagar es: ")

    End Sub
End Class
