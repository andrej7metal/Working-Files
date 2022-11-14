<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastrarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastrarCliente))
        Me.GrpNovoCadastro = New System.Windows.Forms.GroupBox()
        Me.maskquarto = New System.Windows.Forms.MaskedTextBox()
        Me.Tb_cadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_cadastroDataSet = New Projeto_Sistema_de_Hotel.tb_cadastroDataSet()
        Me.MaskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.MaskRG = New System.Windows.Forms.MaskedTextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.LblDigitePlaca = New System.Windows.Forms.Label()
        Me.TxtPlaca = New System.Windows.Forms.TextBox()
        Me.ChkVagaEstacionar = New System.Windows.Forms.CheckBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnCadastrar = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.LblCpf = New System.Windows.Forms.Label()
        Me.LblRG = New System.Windows.Forms.Label()
        Me.LblTelefone = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.Tb_cadastroTableAdapter = New Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.tb_cadastroTableAdapter()
        Me.TableAdapterManager = New Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.TableAdapterManager()
        Me.Tb_cadastroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tb_cadastroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_cadastroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrpNovoCadastro.SuspendLayout()
        CType(Me.Tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_cadastroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_cadastroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_cadastroBindingNavigator.SuspendLayout()
        CType(Me.Tb_cadastroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpNovoCadastro
        '
        Me.GrpNovoCadastro.BackColor = System.Drawing.Color.Transparent
        Me.GrpNovoCadastro.Controls.Add(Me.maskquarto)
        Me.GrpNovoCadastro.Controls.Add(Me.MaskCPF)
        Me.GrpNovoCadastro.Controls.Add(Me.MaskRG)
        Me.GrpNovoCadastro.Controls.Add(Me.txtcodigo)
        Me.GrpNovoCadastro.Controls.Add(Me.lblcodigo)
        Me.GrpNovoCadastro.Controls.Add(Me.LblDigitePlaca)
        Me.GrpNovoCadastro.Controls.Add(Me.TxtPlaca)
        Me.GrpNovoCadastro.Controls.Add(Me.ChkVagaEstacionar)
        Me.GrpNovoCadastro.Controls.Add(Me.BtnCancelar)
        Me.GrpNovoCadastro.Controls.Add(Me.BtnCadastrar)
        Me.GrpNovoCadastro.Controls.Add(Me.TxtEmail)
        Me.GrpNovoCadastro.Controls.Add(Me.LblEmail)
        Me.GrpNovoCadastro.Controls.Add(Me.txtnome)
        Me.GrpNovoCadastro.Controls.Add(Me.LblCpf)
        Me.GrpNovoCadastro.Controls.Add(Me.LblRG)
        Me.GrpNovoCadastro.Controls.Add(Me.LblTelefone)
        Me.GrpNovoCadastro.Controls.Add(Me.LblNome)
        Me.GrpNovoCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpNovoCadastro.Location = New System.Drawing.Point(169, 81)
        Me.GrpNovoCadastro.Name = "GrpNovoCadastro"
        Me.GrpNovoCadastro.Size = New System.Drawing.Size(498, 246)
        Me.GrpNovoCadastro.TabIndex = 0
        Me.GrpNovoCadastro.TabStop = False
        Me.GrpNovoCadastro.Text = "Novo Cadastro"
        '
        'maskquarto
        '
        Me.maskquarto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cadastroBindingSource, "Quarto", True))
        Me.maskquarto.Enabled = False
        Me.maskquarto.Location = New System.Drawing.Point(96, 142)
        Me.maskquarto.Mask = "00"
        Me.maskquarto.Name = "maskquarto"
        Me.maskquarto.Size = New System.Drawing.Size(26, 20)
        Me.maskquarto.TabIndex = 28
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
        'MaskCPF
        '
        Me.MaskCPF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cadastroBindingSource, "CPF", True))
        Me.MaskCPF.Enabled = False
        Me.MaskCPF.Location = New System.Drawing.Point(96, 97)
        Me.MaskCPF.Mask = "000,000,000-00"
        Me.MaskCPF.Name = "MaskCPF"
        Me.MaskCPF.Size = New System.Drawing.Size(88, 20)
        Me.MaskCPF.TabIndex = 27
        '
        'MaskRG
        '
        Me.MaskRG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cadastroBindingSource, "RG", True))
        Me.MaskRG.Enabled = False
        Me.MaskRG.Location = New System.Drawing.Point(96, 62)
        Me.MaskRG.Mask = "00,000,000-0"
        Me.MaskRG.Name = "MaskRG"
        Me.MaskRG.Size = New System.Drawing.Size(90, 20)
        Me.MaskRG.TabIndex = 26
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cadastroBindingSource, "Código", True))
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(345, 115)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(101, 20)
        Me.txtcodigo.TabIndex = 25
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(276, 115)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 15)
        Me.lblcodigo.TabIndex = 24
        Me.lblcodigo.Text = "Codigo"
        '
        'LblDigitePlaca
        '
        Me.LblDigitePlaca.AutoSize = True
        Me.LblDigitePlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDigitePlaca.Location = New System.Drawing.Point(262, 70)
        Me.LblDigitePlaca.Name = "LblDigitePlaca"
        Me.LblDigitePlaca.Size = New System.Drawing.Size(85, 15)
        Me.LblDigitePlaca.TabIndex = 23
        Me.LblDigitePlaca.Text = "Digite Placa"
        Me.LblDigitePlaca.Visible = False
        '
        'TxtPlaca
        '
        Me.TxtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPlaca.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cadastroBindingSource, "Placa", True))
        Me.TxtPlaca.Enabled = False
        Me.TxtPlaca.Location = New System.Drawing.Point(349, 69)
        Me.TxtPlaca.Name = "TxtPlaca"
        Me.TxtPlaca.Size = New System.Drawing.Size(97, 20)
        Me.TxtPlaca.TabIndex = 22
        Me.TxtPlaca.Visible = False
        '
        'ChkVagaEstacionar
        '
        Me.ChkVagaEstacionar.AutoSize = True
        Me.ChkVagaEstacionar.Location = New System.Drawing.Point(305, 41)
        Me.ChkVagaEstacionar.Name = "ChkVagaEstacionar"
        Me.ChkVagaEstacionar.Size = New System.Drawing.Size(152, 17)
        Me.ChkVagaEstacionar.TabIndex = 21
        Me.ChkVagaEstacionar.Text = "Vaga para Estacionar "
        Me.ChkVagaEstacionar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(6, 217)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(87, 23)
        Me.BtnCancelar.TabIndex = 19
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Location = New System.Drawing.Point(99, 217)
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(87, 23)
        Me.BtnCadastrar.TabIndex = 18
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.UseVisualStyleBackColor = True
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cadastroBindingSource, "email", True))
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Location = New System.Drawing.Point(96, 168)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(147, 20)
        Me.TxtEmail.TabIndex = 16
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(27, 168)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(44, 15)
        Me.LblEmail.TabIndex = 15
        Me.LblEmail.Text = "Email"
        '
        'txtnome
        '
        Me.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cadastroBindingSource, "Nome", True))
        Me.txtnome.Location = New System.Drawing.Point(96, 26)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(147, 20)
        Me.txtnome.TabIndex = 8
        '
        'LblCpf
        '
        Me.LblCpf.AutoSize = True
        Me.LblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCpf.Location = New System.Drawing.Point(27, 97)
        Me.LblCpf.Name = "LblCpf"
        Me.LblCpf.Size = New System.Drawing.Size(33, 15)
        Me.LblCpf.TabIndex = 4
        Me.LblCpf.Text = "CPF"
        '
        'LblRG
        '
        Me.LblRG.AutoSize = True
        Me.LblRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRG.Location = New System.Drawing.Point(28, 63)
        Me.LblRG.Name = "LblRG"
        Me.LblRG.Size = New System.Drawing.Size(27, 15)
        Me.LblRG.TabIndex = 3
        Me.LblRG.Text = "RG"
        '
        'LblTelefone
        '
        Me.LblTelefone.AutoSize = True
        Me.LblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefone.Location = New System.Drawing.Point(27, 142)
        Me.LblTelefone.Name = "LblTelefone"
        Me.LblTelefone.Size = New System.Drawing.Size(50, 15)
        Me.LblTelefone.TabIndex = 2
        Me.LblTelefone.Text = "Quarto"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNome.Location = New System.Drawing.Point(28, 26)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(45, 15)
        Me.LblNome.TabIndex = 0
        Me.LblNome.Text = "Nome"
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(12, 482)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 17
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
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
        'Tb_cadastroBindingNavigator
        '
        Me.Tb_cadastroBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_cadastroBindingNavigator.BindingSource = Me.Tb_cadastroBindingSource
        Me.Tb_cadastroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_cadastroBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_cadastroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_cadastroBindingNavigatorSaveItem})
        Me.Tb_cadastroBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_cadastroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_cadastroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_cadastroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_cadastroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_cadastroBindingNavigator.Name = "Tb_cadastroBindingNavigator"
        Me.Tb_cadastroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_cadastroBindingNavigator.Size = New System.Drawing.Size(1126, 25)
        Me.Tb_cadastroBindingNavigator.TabIndex = 18
        Me.Tb_cadastroBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tb_cadastroBindingNavigatorSaveItem
        '
        Me.Tb_cadastroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_cadastroBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_cadastroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_cadastroBindingNavigatorSaveItem.Name = "Tb_cadastroBindingNavigatorSaveItem"
        Me.Tb_cadastroBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_cadastroBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'Tb_cadastroDataGridView
        '
        Me.Tb_cadastroDataGridView.AutoGenerateColumns = False
        Me.Tb_cadastroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_cadastroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Tb_cadastroDataGridView.DataSource = Me.Tb_cadastroBindingSource
        Me.Tb_cadastroDataGridView.Location = New System.Drawing.Point(673, 101)
        Me.Tb_cadastroDataGridView.Name = "Tb_cadastroDataGridView"
        Me.Tb_cadastroDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Tb_cadastroDataGridView.TabIndex = 18
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
        'FrmCadastrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1126, 525)
        Me.Controls.Add(Me.Tb_cadastroDataGridView)
        Me.Controls.Add(Me.Tb_cadastroBindingNavigator)
        Me.Controls.Add(Me.GrpNovoCadastro)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Name = "FrmCadastrarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadastrarCliente"
        Me.GrpNovoCadastro.ResumeLayout(False)
        Me.GrpNovoCadastro.PerformLayout()
        CType(Me.Tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_cadastroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_cadastroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_cadastroBindingNavigator.ResumeLayout(False)
        Me.Tb_cadastroBindingNavigator.PerformLayout()
        CType(Me.Tb_cadastroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpNovoCadastro As System.Windows.Forms.GroupBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents LblCpf As System.Windows.Forms.Label
    Friend WithEvents LblRG As System.Windows.Forms.Label
    Friend WithEvents LblTelefone As System.Windows.Forms.Label
    Friend WithEvents LblNome As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnCadastrar As System.Windows.Forms.Button
    Friend WithEvents BtnVoltar As System.Windows.Forms.Button
    Friend WithEvents LblDigitePlaca As System.Windows.Forms.Label
    Friend WithEvents TxtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents ChkVagaEstacionar As System.Windows.Forms.CheckBox
    Friend WithEvents Tb_cadastroDataSet As Projeto_Sistema_de_Hotel.tb_cadastroDataSet
    Friend WithEvents Tb_cadastroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_cadastroTableAdapter As Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.tb_cadastroTableAdapter
    Friend WithEvents TableAdapterManager As Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_cadastroBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_cadastroBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Tb_cadastroDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents maskquarto As System.Windows.Forms.MaskedTextBox
End Class
