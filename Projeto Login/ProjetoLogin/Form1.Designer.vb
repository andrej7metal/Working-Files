<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelaDeLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelaDeLogin))
        Me.LblControleAcesso = New System.Windows.Forms.Label()
        Me.LblDigiteSenha = New System.Windows.Forms.Label()
        Me.TxtDigiteASenha = New System.Windows.Forms.TextBox()
        Me.ChkMostrarSenha = New System.Windows.Forms.CheckBox()
        Me.PicControleDeAcesso = New System.Windows.Forms.PictureBox()
        CType(Me.PicControleDeAcesso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblControleAcesso
        '
        Me.LblControleAcesso.AutoSize = True
        Me.LblControleAcesso.BackColor = System.Drawing.Color.Transparent
        Me.LblControleAcesso.Font = New System.Drawing.Font("Brush Script MT", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblControleAcesso.ForeColor = System.Drawing.Color.Black
        Me.LblControleAcesso.Location = New System.Drawing.Point(12, 9)
        Me.LblControleAcesso.Name = "LblControleAcesso"
        Me.LblControleAcesso.Size = New System.Drawing.Size(227, 39)
        Me.LblControleAcesso.TabIndex = 0
        Me.LblControleAcesso.Text = "Controle de Acesso"
        '
        'LblDigiteSenha
        '
        Me.LblDigiteSenha.AutoSize = True
        Me.LblDigiteSenha.BackColor = System.Drawing.Color.Transparent
        Me.LblDigiteSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDigiteSenha.ForeColor = System.Drawing.Color.Black
        Me.LblDigiteSenha.Location = New System.Drawing.Point(2, 117)
        Me.LblDigiteSenha.Name = "LblDigiteSenha"
        Me.LblDigiteSenha.Size = New System.Drawing.Size(127, 18)
        Me.LblDigiteSenha.TabIndex = 1
        Me.LblDigiteSenha.Text = "Digite a Senha :"
        '
        'TxtDigiteASenha
        '
        Me.TxtDigiteASenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDigiteASenha.Location = New System.Drawing.Point(135, 117)
        Me.TxtDigiteASenha.MaxLength = 3
        Me.TxtDigiteASenha.Name = "TxtDigiteASenha"
        Me.TxtDigiteASenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtDigiteASenha.Size = New System.Drawing.Size(115, 21)
        Me.TxtDigiteASenha.TabIndex = 2
        '
        'ChkMostrarSenha
        '
        Me.ChkMostrarSenha.AutoSize = True
        Me.ChkMostrarSenha.BackColor = System.Drawing.Color.Transparent
        Me.ChkMostrarSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMostrarSenha.ForeColor = System.Drawing.Color.Black
        Me.ChkMostrarSenha.Location = New System.Drawing.Point(123, 144)
        Me.ChkMostrarSenha.Name = "ChkMostrarSenha"
        Me.ChkMostrarSenha.Size = New System.Drawing.Size(127, 20)
        Me.ChkMostrarSenha.TabIndex = 3
        Me.ChkMostrarSenha.Text = "Mostrar Senha"
        Me.ChkMostrarSenha.UseVisualStyleBackColor = False
        '
        'PicControleDeAcesso
        '
        Me.PicControleDeAcesso.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PicControleDeAcesso.Image = CType(resources.GetObject("PicControleDeAcesso.Image"), System.Drawing.Image)
        Me.PicControleDeAcesso.Location = New System.Drawing.Point(169, 66)
        Me.PicControleDeAcesso.Name = "PicControleDeAcesso"
        Me.PicControleDeAcesso.Size = New System.Drawing.Size(52, 45)
        Me.PicControleDeAcesso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicControleDeAcesso.TabIndex = 4
        Me.PicControleDeAcesso.TabStop = False
        '
        'FrmTelaDeLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(473, 336)
        Me.Controls.Add(Me.PicControleDeAcesso)
        Me.Controls.Add(Me.ChkMostrarSenha)
        Me.Controls.Add(Me.TxtDigiteASenha)
        Me.Controls.Add(Me.LblDigiteSenha)
        Me.Controls.Add(Me.LblControleAcesso)
        Me.KeyPreview = True
        Me.Name = "FrmTelaDeLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela de Login"
        CType(Me.PicControleDeAcesso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblControleAcesso As System.Windows.Forms.Label
    Friend WithEvents LblDigiteSenha As System.Windows.Forms.Label
    Friend WithEvents TxtDigiteASenha As System.Windows.Forms.TextBox
    Friend WithEvents ChkMostrarSenha As System.Windows.Forms.CheckBox
    Friend WithEvents PicControleDeAcesso As System.Windows.Forms.PictureBox

End Class
