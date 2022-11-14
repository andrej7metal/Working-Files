<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblControledeAcesso = New System.Windows.Forms.Label()
        Me.lblDigiteSenha = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.chkSenha = New System.Windows.Forms.CheckBox()
        Me.picLogin = New System.Windows.Forms.PictureBox()
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblControledeAcesso
        '
        Me.lblControledeAcesso.AutoSize = True
        Me.lblControledeAcesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControledeAcesso.ForeColor = System.Drawing.Color.Red
        Me.lblControledeAcesso.Location = New System.Drawing.Point(200, 20)
        Me.lblControledeAcesso.Name = "lblControledeAcesso"
        Me.lblControledeAcesso.Size = New System.Drawing.Size(180, 16)
        Me.lblControledeAcesso.TabIndex = 0
        Me.lblControledeAcesso.Text = "CONTROLE DE ACESSO"
        '
        'lblDigiteSenha
        '
        Me.lblDigiteSenha.AutoSize = True
        Me.lblDigiteSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigiteSenha.Location = New System.Drawing.Point(110, 204)
        Me.lblDigiteSenha.Name = "lblDigiteSenha"
        Me.lblDigiteSenha.Size = New System.Drawing.Size(99, 13)
        Me.lblDigiteSenha.TabIndex = 1
        Me.lblDigiteSenha.Text = "Digite a Senha :"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(224, 197)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSenha.MaxLength = 3
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 2
        '
        'chkSenha
        '
        Me.chkSenha.AutoSize = True
        Me.chkSenha.Location = New System.Drawing.Point(338, 201)
        Me.chkSenha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkSenha.Name = "chkSenha"
        Me.chkSenha.Size = New System.Drawing.Size(104, 17)
        Me.chkSenha.TabIndex = 3
        Me.chkSenha.Text = "Mostrar a Senha"
        Me.chkSenha.UseVisualStyleBackColor = True
        '
        'picLogin
        '
        Me.picLogin.Image = CType(resources.GetObject("picLogin.Image"), System.Drawing.Image)
        Me.picLogin.Location = New System.Drawing.Point(224, 61)
        Me.picLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLogin.Name = "picLogin"
        Me.picLogin.Size = New System.Drawing.Size(117, 95)
        Me.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogin.TabIndex = 5
        Me.picLogin.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 321)
        Me.Controls.Add(Me.picLogin)
        Me.Controls.Add(Me.chkSenha)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.lblDigiteSenha)
        Me.Controls.Add(Me.lblControledeAcesso)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela de Login"
        CType(Me.picLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblControledeAcesso As System.Windows.Forms.Label
    Friend WithEvents lblDigiteSenha As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents chkSenha As System.Windows.Forms.CheckBox
    Friend WithEvents picLogin As System.Windows.Forms.PictureBox

End Class
