Public Class Form1

    Private Sub Tabela1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tabela1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tabela1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CadastroClientesDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'CadastroClientesDataSet.Tabela1'. Você pode movê-la ou removê-la conforme necessário.
        Me.Tabela1TableAdapter.Fill(Me.CadastroClientesDataSet.Tabela1)

    End Sub

    Private Sub Btncadastro_Click(sender As Object, e As EventArgs) Handles Btncadastro.Click
        FrmCadastro.Show()
    End Sub
End Class
