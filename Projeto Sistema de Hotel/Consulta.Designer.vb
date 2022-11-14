<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tb_cadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_cadastroDataSet = New Projeto_Sistema_de_Hotel.tb_cadastroDataSet()
        Me.Tb_cadastroTableAdapter = New Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.tb_cadastroTableAdapter()
        Me.TableAdapterManager = New Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.TableAdapterManager()
        Me.Tb_cadastroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.Tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_cadastroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_cadastroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tb_cadastroBindingSource
        Me.ComboBox1.DisplayMember = "RG"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(282, 157)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Tb_cadastroBindingSource
        '
        Me.Tb_cadastroBindingSource.DataMember = "tb_cadastro"
        Me.Tb_cadastroBindingSource.DataSource = Me.Tb_cadastroDataSet
        '
        'Tb_cadastroDataSet
        '
        Me.Tb_cadastroDataSet.DataSetName = "tb_cadastroDataSet"
        Me.Tb_cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_cadastroTableAdapter
        '
        Me.Tb_cadastroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_cadastroTableAdapter = Me.Tb_cadastroTableAdapter
        Me.TableAdapterManager.UpdateOrder = Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_cadastroDataGridView
        '
        Me.Tb_cadastroDataGridView.AutoGenerateColumns = False
        Me.Tb_cadastroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_cadastroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Tb_cadastroDataGridView.DataSource = Me.Tb_cadastroBindingSource
        Me.Tb_cadastroDataGridView.Location = New System.Drawing.Point(156, 234)
        Me.Tb_cadastroDataGridView.Name = "Tb_cadastroDataGridView"
        Me.Tb_cadastroDataGridView.Size = New System.Drawing.Size(744, 211)
        Me.Tb_cadastroDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RG"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CPF"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Telefone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Telefone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Placa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataSource = Me.Tb_cadastroBindingSource
        Me.ComboBox2.DisplayMember = "Placa"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(538, 157)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 594)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Tb_cadastroDataGridView)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        CType(Me.Tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_cadastroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_cadastroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Tb_cadastroDataSet As Projeto_Sistema_de_Hotel.tb_cadastroDataSet
    Friend WithEvents Tb_cadastroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_cadastroTableAdapter As Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.tb_cadastroTableAdapter
    Friend WithEvents TableAdapterManager As Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_cadastroDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
