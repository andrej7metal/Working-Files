<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkSenha = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnlogar = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.BackColor = System.Drawing.Color.Transparent
        Me.LblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblLogin.Location = New System.Drawing.Point(468, 213)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(43, 15)
        Me.LblLogin.TabIndex = 1
        Me.LblLogin.Text = "Login"
        '
        'TxtSenha
        '
        Me.TxtSenha.Enabled = False
        Me.TxtSenha.Location = New System.Drawing.Point(517, 236)
        Me.TxtSenha.Multiline = True
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtSenha.Size = New System.Drawing.Size(100, 16)
        Me.TxtSenha.TabIndex = 2
        Me.TxtSenha.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(463, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha"
        '
        'ChkSenha
        '
        Me.ChkSenha.AutoSize = True
        Me.ChkSenha.BackColor = System.Drawing.Color.Transparent
        Me.ChkSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSenha.ForeColor = System.Drawing.Color.Maroon
        Me.ChkSenha.Location = New System.Drawing.Point(485, 306)
        Me.ChkSenha.Name = "ChkSenha"
        Me.ChkSenha.Size = New System.Drawing.Size(108, 17)
        Me.ChkSenha.TabIndex = 4
        Me.ChkSenha.TabStop = False
        Me.ChkSenha.Text = "Mostrar Senha"
        Me.ChkSenha.UseVisualStyleBackColor = False
        '
        'btnlogar
        '
        Me.btnlogar.Location = New System.Drawing.Point(597, 305)
        Me.btnlogar.Name = "btnlogar"
        Me.btnlogar.Size = New System.Drawing.Size(75, 23)
        Me.btnlogar.TabIndex = 5
        Me.btnlogar.TabStop = False
        Me.btnlogar.Text = "logar"
        Me.btnlogar.UseVisualStyleBackColor = True
        '
        'txtlogin
        '
        Me.txtlogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlogin.Location = New System.Drawing.Point(517, 213)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(100, 20)
        Me.txtlogin.TabIndex = 6
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(770, 530)
        Me.Controls.Add(Me.txtlogin)
        Me.Controls.Add(Me.btnlogar)
        Me.Controls.Add(Me.ChkSenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.LblLogin)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLogin As System.Windows.Forms.Label
    Friend WithEvents TxtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChkSenha As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnlogar As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
End Class
