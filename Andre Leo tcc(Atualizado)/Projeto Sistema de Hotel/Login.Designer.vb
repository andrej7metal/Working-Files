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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkSenha = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TxtLogin
        '
        Me.TxtLogin.Location = New System.Drawing.Point(517, 213)
        Me.TxtLogin.Multiline = True
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(100, 17)
        Me.TxtLogin.TabIndex = 0
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
        Me.TxtSenha.Location = New System.Drawing.Point(517, 236)
        Me.TxtSenha.Multiline = True
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Size = New System.Drawing.Size(100, 16)
        Me.TxtSenha.TabIndex = 2
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
        Me.ChkSenha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ChkSenha.Location = New System.Drawing.Point(642, 202)
        Me.ChkSenha.Name = "ChkSenha"
        Me.ChkSenha.Size = New System.Drawing.Size(108, 17)
        Me.ChkSenha.TabIndex = 4
        Me.ChkSenha.Text = "Mostrar Senha"
        Me.ChkSenha.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(751, 530)
        Me.Controls.Add(Me.ChkSenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.TxtLogin)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtLogin As System.Windows.Forms.TextBox
    Friend WithEvents LblLogin As System.Windows.Forms.Label
    Friend WithEvents TxtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChkSenha As System.Windows.Forms.CheckBox
End Class
