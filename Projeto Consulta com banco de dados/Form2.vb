Public Class FrmCadastro

    Private Sub Tabela1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tabela1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CadastroClientesDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'CadastroClientesDataSet.Tabela1'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tabela1TableAdapter.Fill(Me.CadastroClientesDataSet.Tabela1)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class