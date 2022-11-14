<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcessoGerencial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcessoGerencial))
        Me.lblDigiteaSenha = New System.Windows.Forms.Label()
        Me.txtDigiteaSenha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblDigiteaSenha
        '
        Me.lblDigiteaSenha.AutoSize = True
        Me.lblDigiteaSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigiteaSenha.ForeColor = System.Drawing.Color.Black
        Me.lblDigiteaSenha.Location = New System.Drawing.Point(88, 265)
        Me.lblDigiteaSenha.Name = "lblDigiteaSenha"
        Me.lblDigiteaSenha.Size = New System.Drawing.Size(106, 15)
        Me.lblDigiteaSenha.TabIndex = 0
        Me.lblDigiteaSenha.Text = "Digite a Senha:"
        '
        'txtDigiteaSenha
        '
        Me.txtDigiteaSenha.Location = New System.Drawing.Point(211, 260)
        Me.txtDigiteaSenha.MaxLength = 6
        Me.txtDigiteaSenha.Name = "txtDigiteaSenha"
        Me.txtDigiteaSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtDigiteaSenha.TabIndex = 1
        '
        'frmAcessoGerencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(471, 334)
        Me.Controls.Add(Me.txtDigiteaSenha)
        Me.Controls.Add(Me.lblDigiteaSenha)
        Me.Name = "frmAcessoGerencial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acesso Gerencial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDigiteaSenha As System.Windows.Forms.Label
    Friend WithEvents txtDigiteaSenha As System.Windows.Forms.TextBox

End Class
