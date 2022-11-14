Public Class fRMMENU2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmCadastrodeMotos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem3.Click
        FrmCadastroDeClientes.Show()
    End Sub

    Private Sub MotosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotosToolStripMenuItem.Click
        FrmConsultaDeMotos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        FrmConsultaDeCliente.Show()
    End Sub

    Private Sub MotosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MotosToolStripMenuItem1.Click
        FrmRelatórioDeMotos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem2.Click
        FrmRelatório_De_Clientes.Show()
    End Sub

    Private Sub SistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemaToolStripMenuItem.Click
        FrmSistema.Show()
    End Sub

    Private Sub DesenvolvedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesenvolvedorToolStripMenuItem.Click
        FrmDesenvolvedor.Show()
    End Sub
End Class
