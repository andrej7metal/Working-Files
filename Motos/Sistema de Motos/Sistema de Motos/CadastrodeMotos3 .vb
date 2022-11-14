Public Class FrmCadastrodeMotos

    Private Sub Tb_motosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_motosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_motosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_SistemaDataSet)

    End Sub

    Private Sub FrmCadastrodeMotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Bd_SistemaDataSet.Tb_motos'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_motosTableAdapter.Fill(Me.Bd_SistemaDataSet.Tb_motos)

    End Sub
End Class