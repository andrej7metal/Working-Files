<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoja))
        Me.lblTrocaMercadoria = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblMercadoria = New System.Windows.Forms.Label()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.lblTroca = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTrocaMercadoria
        '
        Me.lblTrocaMercadoria.AutoSize = True
        Me.lblTrocaMercadoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrocaMercadoria.ForeColor = System.Drawing.Color.Red
        Me.lblTrocaMercadoria.Location = New System.Drawing.Point(156, 38)
        Me.lblTrocaMercadoria.Name = "lblTrocaMercadoria"
        Me.lblTrocaMercadoria.Size = New System.Drawing.Size(189, 16)
        Me.lblTrocaMercadoria.TabIndex = 0
        Me.lblTrocaMercadoria.Text = "TROCA DE MERCADORIA"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(35, 86)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(100, 13)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Nome do Cliente"
        '
        'lblMercadoria
        '
        Me.lblMercadoria.AutoSize = True
        Me.lblMercadoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMercadoria.Location = New System.Drawing.Point(35, 127)
        Me.lblMercadoria.Name = "lblMercadoria"
        Me.lblMercadoria.Size = New System.Drawing.Size(124, 13)
        Me.lblMercadoria.TabIndex = 2
        Me.lblMercadoria.Text = "Nome da Mercadoria"
        '
        'lblCompra
        '
        Me.lblCompra.AutoSize = True
        Me.lblCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompra.Location = New System.Drawing.Point(35, 167)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(90, 13)
        Me.lblCompra.TabIndex = 3
        Me.lblCompra.Text = "Dia da Compra"
        '
        'lblTroca
        '
        Me.lblTroca.AutoSize = True
        Me.lblTroca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroca.Location = New System.Drawing.Point(35, 208)
        Me.lblTroca.Name = "lblTroca"
        Me.lblTroca.Size = New System.Drawing.Size(81, 13)
        Me.lblTroca.TabIndex = 4
        Me.lblTroca.Text = "Dia da Troca"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(165, 127)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(165, 164)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(165, 208)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'frmLoja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(508, 374)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTroca)
        Me.Controls.Add(Me.lblCompra)
        Me.Controls.Add(Me.lblMercadoria)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblTrocaMercadoria)
        Me.Name = "frmLoja"
        Me.Text = "Projeto Loja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTrocaMercadoria As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblMercadoria As System.Windows.Forms.Label
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents lblTroca As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox

End Class
