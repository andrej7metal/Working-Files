<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroDeClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastroDeClientes))
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.LblEndereco = New System.Windows.Forms.Label()
        Me.LblRG = New System.Windows.Forms.Label()
        Me.LblBairro = New System.Windows.Forms.Label()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.LblCpf = New System.Windows.Forms.Label()
        Me.LblCelular = New System.Windows.Forms.Label()
        Me.LblCEP = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblTelefone = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.MskCELULAR = New System.Windows.Forms.MaskedTextBox()
        Me.MskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.MskRG = New System.Windows.Forms.MaskedTextBox()
        Me.MskTELEFONE = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.Location = New System.Drawing.Point(533, 84)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(46, 13)
        Me.LblCodigo.TabIndex = 0
        Me.LblCodigo.Text = "Código"
        '
        'LblEndereco
        '
        Me.LblEndereco.AutoSize = True
        Me.LblEndereco.BackColor = System.Drawing.Color.Transparent
        Me.LblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndereco.Location = New System.Drawing.Point(520, 123)
        Me.LblEndereco.Name = "LblEndereco"
        Me.LblEndereco.Size = New System.Drawing.Size(61, 13)
        Me.LblEndereco.TabIndex = 1
        Me.LblEndereco.Text = "Endereço"
        '
        'LblRG
        '
        Me.LblRG.AutoSize = True
        Me.LblRG.BackColor = System.Drawing.Color.Transparent
        Me.LblRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRG.Location = New System.Drawing.Point(547, 201)
        Me.LblRG.Name = "LblRG"
        Me.LblRG.Size = New System.Drawing.Size(25, 13)
        Me.LblRG.TabIndex = 3
        Me.LblRG.Text = "RG"
        '
        'LblBairro
        '
        Me.LblBairro.AutoSize = True
        Me.LblBairro.BackColor = System.Drawing.Color.Transparent
        Me.LblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBairro.Location = New System.Drawing.Point(535, 168)
        Me.LblBairro.Name = "LblBairro"
        Me.LblBairro.Size = New System.Drawing.Size(40, 13)
        Me.LblBairro.TabIndex = 2
        Me.LblBairro.Text = "Bairro"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Location = New System.Drawing.Point(587, 123)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(100, 20)
        Me.TxtEndereco.TabIndex = 8
        '
        'TxtBairro
        '
        Me.TxtBairro.Location = New System.Drawing.Point(590, 165)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(100, 20)
        Me.TxtBairro.TabIndex = 9
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(590, 81)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 14
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(590, 318)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(100, 20)
        Me.TxtNome.TabIndex = 22
        '
        'LblCpf
        '
        Me.LblCpf.AutoSize = True
        Me.LblCpf.BackColor = System.Drawing.Color.Transparent
        Me.LblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCpf.Location = New System.Drawing.Point(542, 410)
        Me.LblCpf.Name = "LblCpf"
        Me.LblCpf.Size = New System.Drawing.Size(30, 13)
        Me.LblCpf.TabIndex = 18
        Me.LblCpf.Text = "CPF"
        '
        'LblCelular
        '
        Me.LblCelular.AutoSize = True
        Me.LblCelular.BackColor = System.Drawing.Color.Transparent
        Me.LblCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCelular.Location = New System.Drawing.Point(533, 448)
        Me.LblCelular.Name = "LblCelular"
        Me.LblCelular.Size = New System.Drawing.Size(46, 13)
        Me.LblCelular.TabIndex = 17
        Me.LblCelular.Text = "Celular"
        '
        'LblCEP
        '
        Me.LblCEP.AutoSize = True
        Me.LblCEP.BackColor = System.Drawing.Color.Transparent
        Me.LblCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCEP.Location = New System.Drawing.Point(543, 368)
        Me.LblCEP.Name = "LblCEP"
        Me.LblCEP.Size = New System.Drawing.Size(29, 13)
        Me.LblCEP.TabIndex = 16
        Me.LblCEP.Text = "Cep"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.BackColor = System.Drawing.Color.Transparent
        Me.LblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNome.Location = New System.Drawing.Point(533, 325)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(39, 13)
        Me.LblNome.TabIndex = 15
        Me.LblNome.Text = "Nome"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(590, 277)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(100, 20)
        Me.TxtEmail.TabIndex = 26
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(535, 280)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(37, 13)
        Me.LblEmail.TabIndex = 24
        Me.LblEmail.Text = "Email"
        '
        'LblTelefone
        '
        Me.LblTelefone.AutoSize = True
        Me.LblTelefone.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefone.Location = New System.Drawing.Point(515, 235)
        Me.LblTelefone.Name = "LblTelefone"
        Me.LblTelefone.Size = New System.Drawing.Size(57, 13)
        Me.LblTelefone.TabIndex = 23
        Me.LblTelefone.Text = "Telefone"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(822, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 200)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'MskCEP
        '
        Me.MskCEP.Location = New System.Drawing.Point(590, 365)
        Me.MskCEP.Mask = "00000-000"
        Me.MskCEP.Name = "MskCEP"
        Me.MskCEP.Size = New System.Drawing.Size(100, 20)
        Me.MskCEP.TabIndex = 28
        '
        'MskCELULAR
        '
        Me.MskCELULAR.Location = New System.Drawing.Point(590, 445)
        Me.MskCELULAR.Mask = "(00)00000-0000"
        Me.MskCELULAR.Name = "MskCELULAR"
        Me.MskCELULAR.Size = New System.Drawing.Size(100, 20)
        Me.MskCELULAR.TabIndex = 29
        '
        'MskCPF
        '
        Me.MskCPF.Location = New System.Drawing.Point(590, 407)
        Me.MskCPF.Mask = "000,000,00-00"
        Me.MskCPF.Name = "MskCPF"
        Me.MskCPF.Size = New System.Drawing.Size(100, 20)
        Me.MskCPF.TabIndex = 30
        '
        'MskRG
        '
        Me.MskRG.Location = New System.Drawing.Point(590, 198)
        Me.MskRG.Mask = "00,000,000->a"
        Me.MskRG.Name = "MskRG"
        Me.MskRG.Size = New System.Drawing.Size(100, 20)
        Me.MskRG.TabIndex = 31
        '
        'MskTELEFONE
        '
        Me.MskTELEFONE.Location = New System.Drawing.Point(590, 232)
        Me.MskTELEFONE.Mask = "(99) 0000-0000"
        Me.MskTELEFONE.Name = "MskTELEFONE"
        Me.MskTELEFONE.Size = New System.Drawing.Size(100, 20)
        Me.MskTELEFONE.TabIndex = 32
        '
        'FrmCadastroDeClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1234, 581)
        Me.Controls.Add(Me.MskTELEFONE)
        Me.Controls.Add(Me.MskRG)
        Me.Controls.Add(Me.MskCPF)
        Me.Controls.Add(Me.MskCELULAR)
        Me.Controls.Add(Me.MskCEP)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblTelefone)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblCpf)
        Me.Controls.Add(Me.LblCelular)
        Me.Controls.Add(Me.LblCEP)
        Me.Controls.Add(Me.LblNome)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TxtBairro)
        Me.Controls.Add(Me.TxtEndereco)
        Me.Controls.Add(Me.LblRG)
        Me.Controls.Add(Me.LblBairro)
        Me.Controls.Add(Me.LblEndereco)
        Me.Controls.Add(Me.LblCodigo)
        Me.Name = "FrmCadastroDeClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadastroDeClientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents LblEndereco As System.Windows.Forms.Label
    Friend WithEvents LblRG As System.Windows.Forms.Label
    Friend WithEvents LblBairro As System.Windows.Forms.Label
    Friend WithEvents TxtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents TxtBairro As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents LblCpf As System.Windows.Forms.Label
    Friend WithEvents LblCelular As System.Windows.Forms.Label
    Friend WithEvents LblCEP As System.Windows.Forms.Label
    Friend WithEvents LblNome As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents LblTelefone As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MskCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MskCELULAR As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MskRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MskTELEFONE As System.Windows.Forms.MaskedTextBox
End Class
