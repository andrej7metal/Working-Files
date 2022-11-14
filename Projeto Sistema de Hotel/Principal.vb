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







    Private Sub BtnAreaPet_Click(sender As Object, e As EventArgs) Handles BtnAreaPet.Click
        FrmPet.Show()
    End Sub

    Private Sub btnrelatorio_Click(sender As Object, e As EventArgs) Handles btnrelatorio.Click
        frmRelatoriocliente.Show()

    End Sub

    Private Sub btnconsulta_Click(sender As Object, e As EventArgs) Handles btnconsulta.Click
        Consulta.Show()
    End Sub

    Private Sub btnrestaurante_Click(sender As Object, e As EventArgs) Handles btnrestaurante.Click
        FRMRestaurante.Show()
    End Sub

   
    Private Sub btninfosistema_Click(sender As Object, e As EventArgs) Handles btninfosistema.Click
        infosistema.Show()
    End Sub

    Private Sub btninfodesen_Click(sender As Object, e As EventArgs) Handles btninfodesen.Click
        Desenvolvedores.Show()
    End Sub
End Class