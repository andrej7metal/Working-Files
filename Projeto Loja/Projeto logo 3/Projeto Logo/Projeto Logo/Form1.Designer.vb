<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogo))
        Me.LblLogo = New System.Windows.Forms.Label()
        Me.radMostrar = New System.Windows.Forms.RadioButton()
        Me.RadNaoMostrar = New System.Windows.Forms.RadioButton()
        Me.RadDesativar = New System.Windows.Forms.RadioButton()
        Me.RadAtivar = New System.Windows.Forms.RadioButton()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLogo
        '
        Me.LblLogo.AutoSize = True
        Me.LblLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogo.Location = New System.Drawing.Point(313, 9)
        Me.LblLogo.Name = "LblLogo"
        Me.LblLogo.Size = New System.Drawing.Size(43, 16)
        Me.LblLogo.TabIndex = 0
        Me.LblLogo.Text = "Logo"
        '
        'radMostrar
        '
        Me.radMostrar.AutoSize = True
        Me.radMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.radMostrar.FlatAppearance.BorderSize = 2
        Me.radMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMostrar.Location = New System.Drawing.Point(20, 58)
        Me.radMostrar.Name = "radMostrar"
        Me.radMostrar.Size = New System.Drawing.Size(71, 20)
        Me.radMostrar.TabIndex = 1
        Me.radMostrar.Text = "Mostrar"
        Me.radMostrar.UseVisualStyleBackColor = True
        '
        'RadNaoMostrar
        '
        Me.RadNaoMostrar.AutoSize = True
        Me.RadNaoMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadNaoMostrar.FlatAppearance.BorderSize = 2
        Me.RadNaoMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNaoMostrar.Location = New System.Drawing.Point(20, 105)
        Me.RadNaoMostrar.Name = "RadNaoMostrar"
        Me.RadNaoMostrar.Size = New System.Drawing.Size(100, 20)
        Me.RadNaoMostrar.TabIndex = 2
        Me.RadNaoMostrar.Text = "Não Mostrar"
        Me.RadNaoMostrar.UseVisualStyleBackColor = True
        '
        'RadDesativar
        '
        Me.RadDesativar.AutoSize = True
        Me.RadDesativar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadDesativar.FlatAppearance.BorderSize = 2
        Me.RadDesativar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDesativar.Location = New System.Drawing.Point(20, 150)
        Me.RadDesativar.Name = "RadDesativar"
        Me.RadDesativar.Size = New System.Drawing.Size(84, 20)
        Me.RadDesativar.TabIndex = 3
        Me.RadDesativar.Text = "Desativar"
        Me.RadDesativar.UseVisualStyleBackColor = True
        '
        'RadAtivar
        '
        Me.RadAtivar.AutoSize = True
        Me.RadAtivar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadAtivar.FlatAppearance.BorderSize = 2
        Me.RadAtivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAtivar.Location = New System.Drawing.Point(20, 196)
        Me.RadAtivar.Name = "RadAtivar"
        Me.RadAtivar.Size = New System.Drawing.Size(60, 20)
        Me.RadAtivar.TabIndex = 4
        Me.RadAtivar.Text = "Ativar"
        Me.RadAtivar.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.Location = New System.Drawing.Point(291, 256)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(75, 23)
        Me.BtnFechar.TabIndex = 5
        Me.BtnFechar.Text = "fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(219, 28)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(224, 222)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 6
        Me.PicLogo.TabStop = False
        Me.PicLogo.Visible = False
        '
        'frmLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(454, 284)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.RadAtivar)
        Me.Controls.Add(Me.RadDesativar)
        Me.Controls.Add(Me.RadNaoMostrar)
        Me.Controls.Add(Me.radMostrar)
        Me.Controls.Add(Me.LblLogo)
        Me.Name = "frmLogo"
        Me.Text = "ProjetoLogo"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLogo As System.Windows.Forms.Label
    Friend WithEvents radMostrar As System.Windows.Forms.RadioButton
    Friend WithEvents RadNaoMostrar As System.Windows.Forms.RadioButton
    Friend WithEvents RadDesativar As System.Windows.Forms.RadioButton
    Friend WithEvents RadAtivar As System.Windows.Forms.RadioButton
    Friend WithEvents BtnFechar As System.Windows.Forms.Button
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
