Public Class FrmPrincipal

    Private Sub BtnSuites_Click(sender As Object, e As EventArgs) Handles BtnSuites.Click
        FrmSuites.Show()
    End Sub

    
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnvagas.Click
        FrmEstacionamento.Show()
    End Sub

    Private Sub BtnCadastroCliente_Click(sender As Object, e As EventArgs) Handles BtnCadastroCliente.Click
        FrmCadastrarCliente.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnrestaurante.Click
        FRMRestaurante.Show()
    End Sub

  
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        frmRelatoriocliente.Show()

    End Sub

  
End Class