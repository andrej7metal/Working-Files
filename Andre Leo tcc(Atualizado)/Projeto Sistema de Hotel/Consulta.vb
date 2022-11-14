Public Class Consulta

    Private Sub Tb_cadastroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_cadastroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tb_cadastroDataSet)

    End Sub

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Tb_cadastroDataSet.tb_cadastro'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tb_cadastroTableAdapter.Fill(Me.Tb_cadastroDataSet.tb_cadastro)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class