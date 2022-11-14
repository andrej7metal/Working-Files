Public Class frmRelatoriocliente

    Private Sub Relatoriocliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'tb_cadastroDataSet.tb_cadastro'. Você pode movê-la ou removê-la conforme necessário.
        Me.tb_cadastroTableAdapter.Fill(Me.tb_cadastroDataSet.tb_cadastro)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class