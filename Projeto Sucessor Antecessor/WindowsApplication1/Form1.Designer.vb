<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTitulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTitulo))
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnSucessor = New System.Windows.Forms.Button()
        Me.btnAntecessor = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblDigite = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(504, 222)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 71)
        Me.btnSair.TabIndex = 13
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.Location = New System.Drawing.Point(370, 222)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 71)
        Me.btnLimpar.TabIndex = 12
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSucessor
        '
        Me.btnSucessor.Image = CType(resources.GetObject("btnSucessor.Image"), System.Drawing.Image)
        Me.btnSucessor.Location = New System.Drawing.Point(233, 222)
        Me.btnSucessor.Name = "btnSucessor"
        Me.btnSucessor.Size = New System.Drawing.Size(75, 71)
        Me.btnSucessor.TabIndex = 11
        Me.btnSucessor.Text = "Sucessor"
        Me.btnSucessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSucessor.UseVisualStyleBackColor = True
        '
        'btnAntecessor
        '
        Me.btnAntecessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAntecessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAntecessor.Image = CType(resources.GetObject("btnAntecessor.Image"), System.Drawing.Image)
        Me.btnAntecessor.Location = New System.Drawing.Point(95, 222)
        Me.btnAntecessor.Name = "btnAntecessor"
        Me.btnAntecessor.Size = New System.Drawing.Size(75, 71)
        Me.btnAntecessor.TabIndex = 10
        Me.btnAntecessor.Text = "Antecessor"
        Me.btnAntecessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAntecessor.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(315, 180)
        Me.txtNumero.MaxLength = 9
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(152, 20)
        Me.txtNumero.TabIndex = 9
        '
        'lblDigite
        '
        Me.lblDigite.AutoSize = True
        Me.lblDigite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigite.Location = New System.Drawing.Point(164, 181)
        Me.lblDigite.Name = "lblDigite"
        Me.lblDigite.Size = New System.Drawing.Size(135, 16)
        Me.lblDigite.TabIndex = 8
        Me.lblDigite.Text = "Digite um Número:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Red
        Me.lblTitulo.Location = New System.Drawing.Point(136, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(337, 24)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Mostrar o Antecessor e o Sucessor"
        '
        'FrmTitulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(629, 438)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnSucessor)
        Me.Controls.Add(Me.btnAntecessor)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblDigite)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FrmTitulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSucessor As System.Windows.Forms.Button
    Friend WithEvents btnAntecessor As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblDigite As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label

End Class
