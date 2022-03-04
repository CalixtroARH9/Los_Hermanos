Imports System.IO
Imports System.Drawing.Bitmap


Public Class Pedidos
    'Public Mesero As Int32 = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgAlimentos.Items.Clear()
        dtAlimentos.RowTemplate.Height = 150
        dtAlimentos.ColumnHeadersHeight = 150

        Alimentos()
        Bebidas()

    End Sub

    Private Sub Bebidas()
        Try
            Dim refrescococacola As String = "Refresco coca cola"
            Dim refrescopepci As String = "Refresco Pepsi"
            Dim cafeamericano As String = "Café americano"
            Dim cafeexpreso As String = "Café expreso"
            Dim agua As String = "Agua"

            Dim q As Int32 = 15
            Dim v As Int32 = 20



            dgBebidas.RowTemplate.Height = 150


            Dim dc As New DataGridViewImageColumn() With {.HeaderText = "Imagen", .Name = "imagen"}
            dgBebidas.Columns.Add(dc)

            Dim dc2 As New DataGridViewTextBoxColumn() With {.HeaderText = "Bebida", .Name = "bebida"}
            dgBebidas.Columns.Add(dc2)

            Dim dc3 As New DataGridViewTextBoxColumn() With {.HeaderText = "Precio", .Name = "precio"}
            dgBebidas.Columns.Add(dc3)

            'Imagen
            dgBebidas.Rows.Add(4)
            dgBebidas.Rows(0).Cells(0).Value = My.Resources.Cocacola
            dgBebidas.Rows(1).Cells(0).Value = My.Resources.Pepsi
            dgBebidas.Rows(2).Cells(0).Value = My.Resources.CaféAmericano
            dgBebidas.Rows(3).Cells(0).Value = My.Resources.CaféExpreso
            dgBebidas.Rows(4).Cells(0).Value = My.Resources.VasoAgua

            'Bebidas
            dgBebidas.Rows(0).Cells(1).Value = refrescococacola
            dgBebidas.Rows(1).Cells(1).Value = refrescopepci
            dgBebidas.Rows(2).Cells(1).Value = cafeamericano
            dgBebidas.Rows(3).Cells(1).Value = cafeexpreso
            dgBebidas.Rows(4).Cells(1).Value = agua

            'Precio
            dgBebidas.Rows(0).Cells(2).Value = q
            dgBebidas.Rows(1).Cells(2).Value = q
            dgBebidas.Rows(2).Cells(2).Value = q
            dgBebidas.Rows(3).Cells(2).Value = q
            dgBebidas.Rows(4).Cells(2).Value = v

        Catch ex As Exception

        End Try
    End Sub
    Dim total As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Imprimir()
    End Sub

    Private Sub Imprimir()
        If cbMesa.Text = "" Then
            MessageBox.Show("Seleccione la mesa a enviar", "enviar")
        End If
        If cbMesa.Text <> "" Then
            dgAlimentos.Items.Add("Mesa número: ")
            dgAlimentos.Items.Add(cbMesa.Text)
            dgAlimentos.Items.Add("Total a pagar: ")
            dgAlimentos.Items.Add(total)

            Dim SetSave As SaveFileDialog = New SaveFileDialog
            Dim i As Integer
            SetSave.Title = "Salvar reporte.txt"
            SetSave.Filter = "Reorte.txt File (*.txt)|*.txt"

            If SetSave.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim s As New IO.StreamWriter(SetSave.FileName, True)
                For i = 0 To dgAlimentos.Items.Count - 1
                    s.WriteLine(dgAlimentos.Items.Item(i))
                Next
                s.Close()
            End If
            dgAlimentos.Items.Clear()
            total = 0
            lblt.Text = 0
        End If
    End Sub

    Public Sub Alimentos()

        Try
            Dim donachocolate As String = "Dona de chocolat"
            Dim donavainilla As String = "Dona de vainilla"
            Dim panini As String = "Panini"
            Dim brownies As String = "Brownies"
            Dim galletaschocolate As String = "Galletas de chocolate"

            Dim q As Int32 = 15
            Dim v As Int32 = 25
            Dim t As Int32 = 30
            Dim d As Int32 = 10

            Dim dc As New DataGridViewImageColumn() With {.HeaderText = "Imagen", .Name = "imagen"}
            dtAlimentos.Columns.Add(dc)

            Dim dc2 As New DataGridViewTextBoxColumn() With {.HeaderText = "Alimento", .Name = "alimento"}
            dtAlimentos.Columns.Add(dc2)

            Dim dc3 As New DataGridViewTextBoxColumn() With {.HeaderText = "Precio", .Name = "precio"}
            dtAlimentos.Columns.Add(dc3)

            'Imagen
            dtAlimentos.Rows.Add(4)
            dtAlimentos.Rows(0).Cells(0).Value = My.Resources.DonaChocolate
            dtAlimentos.Rows(1).Cells(0).Value = My.Resources.DonaVainilla
            dtAlimentos.Rows(2).Cells(0).Value = My.Resources.Panini
            dtAlimentos.Rows(3).Cells(0).Value = My.Resources.Brownie
            dtAlimentos.Rows(4).Cells(0).Value = My.Resources.GalletaChocolate

            'Alimento
            dtAlimentos.Rows(0).Cells(1).Value = donachocolate
            dtAlimentos.Rows(1).Cells(1).Value = donavainilla
            dtAlimentos.Rows(2).Cells(1).Value = panini
            dtAlimentos.Rows(3).Cells(1).Value = brownies
            dtAlimentos.Rows(4).Cells(1).Value = galletaschocolate

            'Precio
            dtAlimentos.Rows(0).Cells(2).Value = q
            dtAlimentos.Rows(1).Cells(2).Value = q
            dtAlimentos.Rows(2).Cells(2).Value = v
            dtAlimentos.Rows(3).Cells(2).Value = t
            dtAlimentos.Rows(4).Cells(2).Value = d

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtAlimentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtAlimentos.CellClick
        Select Case dtAlimentos.CurrentCell.RowIndex
            Case 0
                dgAlimentos.Items.Add("Dona de chocolate $15")
                total = total + 15
                lblt.Text = total
            Case 1
                dgAlimentos.Items.Add("Dona de vainilla $15")
                total = total + 15
                lblt.Text = total
            Case 2
                dgAlimentos.Items.Add("Panini $25")
                total = total + 25
                lblt.Text = total
            Case 3
                dgAlimentos.Items.Add("Brownies $30")
                total = total + 30
                lblt.Text = total
            Case 4
                dgAlimentos.Items.Add("Galletas de chocolate $10")
                total = total + 10
                lblt.Text = total
        End Select
    End Sub

    Private Sub dgBebidas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBebidas.CellClick
        Select Case dgBebidas.CurrentCell.RowIndex

            Case 0
                dgAlimentos.Items.Add("Refresco coca cola $15")
                total = total + 15
                lblt.Text = total
            Case 1
                dgAlimentos.Items.Add("Refresco Pepsi $15")
                total = total + 15
                lblt.Text = total
            Case 2
                dgAlimentos.Items.Add("Café americano $15")
                total = total + 15
                lblt.Text = total
            Case 3
                dgAlimentos.Items.Add("Café expreso $15")
                total = total + 15
                lblt.Text = total
            Case 4
                dgAlimentos.Items.Add("Agua $20")
                total = total + 20
                lblt.Text = total
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlCreditos.Visible = True
        pnlCreditos.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlCreditos.Visible = False
    End Sub
End Class
