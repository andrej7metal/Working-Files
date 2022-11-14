<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelaLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelaLogin))
        Me.LblIniciar = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ChkVerSenha = New System.Windows.Forms.CheckBox()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.LblNomeUsuario = New System.Windows.Forms.Label()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.LblPorcentagem = New System.Windows.Forms.Label()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIniciar
        '
        Me.LblIniciar.AutoSize = True
        Me.LblIniciar.Location = New System.Drawing.Point(723, 254)
        Me.LblIniciar.Name = "LblIniciar"
        Me.LblIniciar.Size = New System.Drawing.Size(35, 13)
        Me.LblIniciar.TabIndex = 22
        Me.LblIniciar.Text = "Iniciar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(564, 270)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(221, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'ChkVerSenha
        '
        Me.ChkVerSenha.AutoSize = True
        Me.ChkVerSenha.BackColor = System.Drawing.Color.Transparent
        Me.ChkVerSenha.Enabled = False
        Me.ChkVerSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVerSenha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ChkVerSenha.Location = New System.Drawing.Point(870, 9)
        Me.ChkVerSenha.Name = "ChkVerSenha"
        Me.ChkVerSenha.Size = New System.Drawing.Size(99, 20)
        Me.ChkVerSenha.TabIndex = 20
        Me.ChkVerSenha.Text = "Ver Senha"
        Me.ChkVerSenha.UseVisualStyleBackColor = False
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.Transparent
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.SystemColors.Control
        Me.LblHora.Location = New System.Drawing.Point(441, 97)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(45, 18)
        Me.LblHora.TabIndex = 19
        Me.LblHora.Text = "Hora"
        '
        'TxtSenha
        '
        Me.TxtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSenha.Enabled = False
        Me.TxtSenha.Location = New System.Drawing.Point(754, 35)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(220, 20)
        Me.TxtSenha.TabIndex = 16
        '
        'LblSenha
        '
        Me.LblSenha.BackColor = System.Drawing.Color.Transparent
        Me.LblSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSenha.Location = New System.Drawing.Point(751, 6)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(132, 23)
        Me.LblSenha.TabIndex = 15
        Me.LblSenha.Text = "Senha"
        Me.LblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNomeUsuario
        '
        Me.LblNomeUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblNomeUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomeUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNomeUsuario.Location = New System.Drawing.Point(194, 9)
        Me.LblNomeUsuario.Name = "LblNomeUsuario"
        Me.LblNomeUsuario.Size = New System.Drawing.Size(145, 23)
        Me.LblNomeUsuario.TabIndex = 13
        Me.LblNomeUsuario.Text = "&Nome de Usuário"
        Me.LblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(12, 9)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(133, 187)
        Me.PicFoto.TabIndex = 14
        Me.PicFoto.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Location = New System.Drawing.Point(197, 38)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
        Me.txtUsuario.TabIndex = 23
        '
        'LblPorcentagem
        '
        Me.LblPorcentagem.AutoSize = True
        Me.LblPorcentagem.Location = New System.Drawing.Point(764, 254)
        Me.LblPorcentagem.Name = "LblPorcentagem"
        Me.LblPorcentagem.Size = New System.Drawing.Size(21, 13)
        Me.LblPorcentagem.TabIndex = 24
        Me.LblPorcentagem.Text = "0%"
        '
        'frmTelaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1234, 581)
        Me.Controls.Add(Me.LblPorcentagem)
        Me.Controls.Add(Me.LblIniciar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ChkVerSenha)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.LblSenha)
        Me.Controls.Add(Me.LblNomeUsuario)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.txtUsuario)
        Me.KeyPreview = True
        Me.Name = "frmTelaLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TelaLogin"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblIniciar As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ChkVerSenha As System.Windows.Forms.CheckBox
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents TxtSenha As System.Windows.Forms.TextBox
    Friend WithEvents LblSenha As System.Windows.Forms.Label
    Friend WithEvents LblNomeUsuario As System.Windows.Forms.Label
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LblPorcentagem As System.Windows.Forms.Label
End Class
