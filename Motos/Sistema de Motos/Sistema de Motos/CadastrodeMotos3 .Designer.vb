<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastrodeMotos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastrodeMotos))
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.Bd_SistemaDataSet = New Sistema_de_Motos.Bd_SistemaDataSet()
        Me.Tb_motosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_motosTableAdapter = New Sistema_de_Motos.Bd_SistemaDataSetTableAdapters.Tb_motosTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Motos.Bd_SistemaDataSetTableAdapters.TableAdapterManager()
        Me.Tb_motosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_motosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_motosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Bd_SistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_motosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_motosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_motosBindingNavigator.SuspendLayout()
        CType(Me.Tb_motosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(820, 233)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtMarca.Size = New System.Drawing.Size(120, 20)
        Me.TxtMarca.TabIndex = 7
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(820, 207)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(120, 20)
        Me.TxtCodigo.TabIndex = 5
        '
        'LblMarca
        '
        Me.LblMarca.BackColor = System.Drawing.Color.Transparent
        Me.LblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarca.ForeColor = System.Drawing.Color.Black
        Me.LblMarca.Location = New System.Drawing.Point(746, 230)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(220, 23)
        Me.LblMarca.TabIndex = 6
        Me.LblMarca.Text = "Marca"
        Me.LblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCodigo
        '
        Me.LblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.ForeColor = System.Drawing.Color.Black
        Me.LblCodigo.Location = New System.Drawing.Point(746, 204)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(220, 23)
        Me.LblCodigo.TabIndex = 4
        Me.LblCodigo.Text = "Código"
        Me.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblModelo
        '
        Me.LblModelo.BackColor = System.Drawing.Color.Transparent
        Me.LblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModelo.ForeColor = System.Drawing.Color.Black
        Me.LblModelo.Location = New System.Drawing.Point(746, 255)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(220, 23)
        Me.LblModelo.TabIndex = 8
        Me.LblModelo.Text = "Modelo"
        Me.LblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(820, 258)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtModelo.Size = New System.Drawing.Size(120, 20)
        Me.TxtModelo.TabIndex = 9
        '
        'Bd_SistemaDataSet
        '
        Me.Bd_SistemaDataSet.DataSetName = "Bd_SistemaDataSet"
        Me.Bd_SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_motosBindingSource
        '
        Me.Tb_motosBindingSource.DataMember = "Tb_motos"
        Me.Tb_motosBindingSource.DataSource = Me.Bd_SistemaDataSet
        '
        'Tb_motosTableAdapter
        '
        Me.Tb_motosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tb_ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Tb_motosTableAdapter = Me.Tb_motosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Motos.Bd_SistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_motosBindingNavigator
        '
        Me.Tb_motosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_motosBindingNavigator.BindingSource = Me.Tb_motosBindingSource
        Me.Tb_motosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_motosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_motosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_motosBindingNavigatorSaveItem})
        Me.Tb_motosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_motosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_motosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_motosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_motosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_motosBindingNavigator.Name = "Tb_motosBindingNavigator"
        Me.Tb_motosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_motosBindingNavigator.Size = New System.Drawing.Size(1234, 25)
        Me.Tb_motosBindingNavigator.TabIndex = 10
        Me.Tb_motosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(108, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(61, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'Tb_motosBindingNavigatorSaveItem
        '
        Me.Tb_motosBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_motosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_motosBindingNavigatorSaveItem.Name = "Tb_motosBindingNavigatorSaveItem"
        Me.Tb_motosBindingNavigatorSaveItem.Size = New System.Drawing.Size(94, 22)
        Me.Tb_motosBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'Tb_motosDataGridView
        '
        Me.Tb_motosDataGridView.AutoGenerateColumns = False
        Me.Tb_motosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_motosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Tb_motosDataGridView.DataSource = Me.Tb_motosBindingSource
        Me.Tb_motosDataGridView.Location = New System.Drawing.Point(371, 90)
        Me.Tb_motosDataGridView.Name = "Tb_motosDataGridView"
        Me.Tb_motosDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Tb_motosDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Moto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Moto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'FrmCadastrodeMotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1234, 581)
        Me.Controls.Add(Me.Tb_motosDataGridView)
        Me.Controls.Add(Me.Tb_motosBindingNavigator)
        Me.Controls.Add(Me.TxtModelo)
        Me.Controls.Add(Me.LblModelo)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.LblMarca)
        Me.Controls.Add(Me.LblCodigo)
        Me.Name = "FrmCadastrodeMotos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.Bd_SistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_motosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_motosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_motosBindingNavigator.ResumeLayout(False)
        Me.Tb_motosBindingNavigator.PerformLayout()
        CType(Me.Tb_motosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents LblMarca As System.Windows.Forms.Label
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents LblModelo As System.Windows.Forms.Label
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents Bd_SistemaDataSet As Sistema_de_Motos.Bd_SistemaDataSet
    Friend WithEvents Tb_motosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_motosTableAdapter As Sistema_de_Motos.Bd_SistemaDataSetTableAdapters.Tb_motosTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_de_Motos.Bd_SistemaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_motosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tb_motosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tb_motosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
