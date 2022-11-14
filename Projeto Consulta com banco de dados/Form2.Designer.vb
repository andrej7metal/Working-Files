<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CadastroClientesDataSet = New WindowsApplication1.CadastroClientesDataSet()
        Me.Tabela1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabela1TableAdapter = New WindowsApplication1.CadastroClientesDataSetTableAdapters.Tabela1TableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.CadastroClientesDataSetTableAdapters.TableAdapterManager()
        Me.Tabela1DataGridView = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CadastroClientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabela1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabela1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CadastroClientesDataSet
        '
        Me.CadastroClientesDataSet.DataSetName = "CadastroClientesDataSet"
        Me.CadastroClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabela1BindingSource
        '
        Me.Tabela1BindingSource.DataMember = "Tabela1"
        Me.Tabela1BindingSource.DataSource = Me.CadastroClientesDataSet
        '
        'Tabela1TableAdapter
        '
        Me.Tabela1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tabela1TableAdapter = Me.Tabela1TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.CadastroClientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tabela1DataGridView
        '
        Me.Tabela1DataGridView.AllowUserToAddRows = False
        Me.Tabela1DataGridView.AllowUserToDeleteRows = False
        Me.Tabela1DataGridView.AutoGenerateColumns = False
        Me.Tabela1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabela1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1})
        Me.Tabela1DataGridView.DataSource = Me.Tabela1BindingSource
        Me.Tabela1DataGridView.Location = New System.Drawing.Point(274, 101)
        Me.Tabela1DataGridView.Name = "Tabela1DataGridView"
        Me.Tabela1DataGridView.ReadOnly = True
        Me.Tabela1DataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Tabela1DataGridView.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tabela1BindingSource
        Me.ComboBox1.DisplayMember = "Nome"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(83, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Número Matricula"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Número Matricula"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FrmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 341)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Tabela1DataGridView)
        Me.Name = "FrmCadastro"
        Me.Text = "Cadastro"
        CType(Me.CadastroClientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabela1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabela1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CadastroClientesDataSet As WindowsApplication1.CadastroClientesDataSet
    Friend WithEvents Tabela1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabela1TableAdapter As WindowsApplication1.CadastroClientesDataSetTableAdapters.Tabela1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.CadastroClientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tabela1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
