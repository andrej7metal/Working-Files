<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPet))
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.RadFoto7 = New System.Windows.Forms.RadioButton()
        Me.RadFoto6 = New System.Windows.Forms.RadioButton()
        Me.RadFoto5 = New System.Windows.Forms.RadioButton()
        Me.RadFoto4 = New System.Windows.Forms.RadioButton()
        Me.RadFoto3 = New System.Windows.Forms.RadioButton()
        Me.RadFoto1 = New System.Windows.Forms.RadioButton()
        Me.RadFoto2 = New System.Windows.Forms.RadioButton()
        Me.BtnGaleriaFotos = New System.Windows.Forms.Button()
        Me.BtnAreaPet = New System.Windows.Forms.Button()
        Me.RadFoto11 = New System.Windows.Forms.RadioButton()
        Me.RadFoto10 = New System.Windows.Forms.RadioButton()
        Me.RadFoto9 = New System.Windows.Forms.RadioButton()
        Me.radFoto8 = New System.Windows.Forms.RadioButton()
        Me.BtnMedicamentos = New System.Windows.Forms.Button()
        Me.RadComprimido = New System.Windows.Forms.RadioButton()
        Me.RadLiquido = New System.Windows.Forms.RadioButton()
        Me.RadInjetavel = New System.Windows.Forms.RadioButton()
        Me.GrpTipoMedicamento = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpTipoMedicamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(12, 551)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 24
        Me.BtnVoltar.Text = "Sair"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'PicFoto
        '
        Me.PicFoto.BackColor = System.Drawing.Color.Transparent
        Me.PicFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicFoto.Location = New System.Drawing.Point(467, 25)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(719, 503)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFoto.TabIndex = 23
        Me.PicFoto.TabStop = False
        Me.PicFoto.Visible = False
        '
        'RadFoto7
        '
        Me.RadFoto7.AutoSize = True
        Me.RadFoto7.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto7.Location = New System.Drawing.Point(349, 236)
        Me.RadFoto7.Name = "RadFoto7"
        Me.RadFoto7.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto7.TabIndex = 22
        Me.RadFoto7.TabStop = True
        Me.RadFoto7.Text = "Galeria Foto"
        Me.RadFoto7.UseVisualStyleBackColor = False
        Me.RadFoto7.Visible = False
        '
        'RadFoto6
        '
        Me.RadFoto6.AutoSize = True
        Me.RadFoto6.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto6.Location = New System.Drawing.Point(349, 200)
        Me.RadFoto6.Name = "RadFoto6"
        Me.RadFoto6.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto6.TabIndex = 21
        Me.RadFoto6.TabStop = True
        Me.RadFoto6.Text = "Galeria Foto"
        Me.RadFoto6.UseVisualStyleBackColor = False
        Me.RadFoto6.Visible = False
        '
        'RadFoto5
        '
        Me.RadFoto5.AutoSize = True
        Me.RadFoto5.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto5.Location = New System.Drawing.Point(349, 163)
        Me.RadFoto5.Name = "RadFoto5"
        Me.RadFoto5.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto5.TabIndex = 20
        Me.RadFoto5.TabStop = True
        Me.RadFoto5.Text = "Galeria Foto"
        Me.RadFoto5.UseVisualStyleBackColor = False
        Me.RadFoto5.Visible = False
        '
        'RadFoto4
        '
        Me.RadFoto4.AutoSize = True
        Me.RadFoto4.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto4.Location = New System.Drawing.Point(349, 130)
        Me.RadFoto4.Name = "RadFoto4"
        Me.RadFoto4.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto4.TabIndex = 19
        Me.RadFoto4.TabStop = True
        Me.RadFoto4.Text = "Galeria Foto"
        Me.RadFoto4.UseVisualStyleBackColor = False
        Me.RadFoto4.Visible = False
        '
        'RadFoto3
        '
        Me.RadFoto3.AutoSize = True
        Me.RadFoto3.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto3.Location = New System.Drawing.Point(349, 92)
        Me.RadFoto3.Name = "RadFoto3"
        Me.RadFoto3.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto3.TabIndex = 18
        Me.RadFoto3.TabStop = True
        Me.RadFoto3.Text = "Galeria Foto"
        Me.RadFoto3.UseVisualStyleBackColor = False
        Me.RadFoto3.Visible = False
        '
        'RadFoto1
        '
        Me.RadFoto1.AutoSize = True
        Me.RadFoto1.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto1.Location = New System.Drawing.Point(349, 25)
        Me.RadFoto1.Name = "RadFoto1"
        Me.RadFoto1.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto1.TabIndex = 17
        Me.RadFoto1.TabStop = True
        Me.RadFoto1.Text = "Galeria Foto"
        Me.RadFoto1.UseVisualStyleBackColor = False
        Me.RadFoto1.Visible = False
        '
        'RadFoto2
        '
        Me.RadFoto2.AutoSize = True
        Me.RadFoto2.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto2.Location = New System.Drawing.Point(349, 57)
        Me.RadFoto2.Name = "RadFoto2"
        Me.RadFoto2.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto2.TabIndex = 16
        Me.RadFoto2.TabStop = True
        Me.RadFoto2.Text = "Galeria Foto"
        Me.RadFoto2.UseVisualStyleBackColor = False
        Me.RadFoto2.Visible = False
        '
        'BtnGaleriaFotos
        '
        Me.BtnGaleriaFotos.Location = New System.Drawing.Point(180, 36)
        Me.BtnGaleriaFotos.Name = "BtnGaleriaFotos"
        Me.BtnGaleriaFotos.Size = New System.Drawing.Size(99, 32)
        Me.BtnGaleriaFotos.TabIndex = 26
        Me.BtnGaleriaFotos.Text = "Galeria de Fotos"
        Me.BtnGaleriaFotos.UseVisualStyleBackColor = True
        Me.BtnGaleriaFotos.Visible = False
        '
        'BtnAreaPet
        '
        Me.BtnAreaPet.BackColor = System.Drawing.Color.DarkOrchid
        Me.BtnAreaPet.Location = New System.Drawing.Point(12, 31)
        Me.BtnAreaPet.Name = "BtnAreaPet"
        Me.BtnAreaPet.Size = New System.Drawing.Size(126, 45)
        Me.BtnAreaPet.TabIndex = 25
        Me.BtnAreaPet.Text = "Área Pet"
        Me.BtnAreaPet.UseVisualStyleBackColor = False
        '
        'RadFoto11
        '
        Me.RadFoto11.AutoSize = True
        Me.RadFoto11.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto11.Location = New System.Drawing.Point(349, 377)
        Me.RadFoto11.Name = "RadFoto11"
        Me.RadFoto11.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto11.TabIndex = 30
        Me.RadFoto11.TabStop = True
        Me.RadFoto11.Text = "Galeria Foto"
        Me.RadFoto11.UseVisualStyleBackColor = False
        Me.RadFoto11.Visible = False
        '
        'RadFoto10
        '
        Me.RadFoto10.AutoSize = True
        Me.RadFoto10.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto10.Location = New System.Drawing.Point(349, 341)
        Me.RadFoto10.Name = "RadFoto10"
        Me.RadFoto10.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto10.TabIndex = 29
        Me.RadFoto10.TabStop = True
        Me.RadFoto10.Text = "Galeria Foto"
        Me.RadFoto10.UseVisualStyleBackColor = False
        Me.RadFoto10.Visible = False
        '
        'RadFoto9
        '
        Me.RadFoto9.AutoSize = True
        Me.RadFoto9.BackColor = System.Drawing.Color.Transparent
        Me.RadFoto9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadFoto9.Location = New System.Drawing.Point(349, 304)
        Me.RadFoto9.Name = "RadFoto9"
        Me.RadFoto9.Size = New System.Drawing.Size(112, 20)
        Me.RadFoto9.TabIndex = 28
        Me.RadFoto9.TabStop = True
        Me.RadFoto9.Text = "Galeria Foto"
        Me.RadFoto9.UseVisualStyleBackColor = False
        Me.RadFoto9.Visible = False
        '
        'radFoto8
        '
        Me.radFoto8.AutoSize = True
        Me.radFoto8.BackColor = System.Drawing.Color.Transparent
        Me.radFoto8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFoto8.Location = New System.Drawing.Point(349, 271)
        Me.radFoto8.Name = "radFoto8"
        Me.radFoto8.Size = New System.Drawing.Size(112, 20)
        Me.radFoto8.TabIndex = 27
        Me.radFoto8.TabStop = True
        Me.radFoto8.Text = "Galeria Foto"
        Me.radFoto8.UseVisualStyleBackColor = False
        Me.radFoto8.Visible = False
        '
        'BtnMedicamentos
        '
        Me.BtnMedicamentos.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnMedicamentos.Location = New System.Drawing.Point(12, 98)
        Me.BtnMedicamentos.Name = "BtnMedicamentos"
        Me.BtnMedicamentos.Size = New System.Drawing.Size(126, 45)
        Me.BtnMedicamentos.TabIndex = 31
        Me.BtnMedicamentos.Text = "Medicamentos"
        Me.BtnMedicamentos.UseVisualStyleBackColor = False
        '
        'RadComprimido
        '
        Me.RadComprimido.AutoSize = True
        Me.RadComprimido.Location = New System.Drawing.Point(9, 34)
        Me.RadComprimido.Name = "RadComprimido"
        Me.RadComprimido.Size = New System.Drawing.Size(122, 25)
        Me.RadComprimido.TabIndex = 32
        Me.RadComprimido.TabStop = True
        Me.RadComprimido.Text = "Comprimido"
        Me.RadComprimido.UseVisualStyleBackColor = True
        '
        'RadLiquido
        '
        Me.RadLiquido.AutoSize = True
        Me.RadLiquido.Location = New System.Drawing.Point(9, 67)
        Me.RadLiquido.Name = "RadLiquido"
        Me.RadLiquido.Size = New System.Drawing.Size(87, 25)
        Me.RadLiquido.TabIndex = 33
        Me.RadLiquido.TabStop = True
        Me.RadLiquido.Text = "Liquído"
        Me.RadLiquido.UseVisualStyleBackColor = True
        '
        'RadInjetavel
        '
        Me.RadInjetavel.AutoSize = True
        Me.RadInjetavel.Location = New System.Drawing.Point(12, 105)
        Me.RadInjetavel.Name = "RadInjetavel"
        Me.RadInjetavel.Size = New System.Drawing.Size(92, 25)
        Me.RadInjetavel.TabIndex = 34
        Me.RadInjetavel.TabStop = True
        Me.RadInjetavel.Text = "Injetavel"
        Me.RadInjetavel.UseVisualStyleBackColor = True
        '
        'GrpTipoMedicamento
        '
        Me.GrpTipoMedicamento.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrpTipoMedicamento.Controls.Add(Me.LinkLabel1)
        Me.GrpTipoMedicamento.Controls.Add(Me.RadComprimido)
        Me.GrpTipoMedicamento.Controls.Add(Me.RadInjetavel)
        Me.GrpTipoMedicamento.Controls.Add(Me.RadLiquido)
        Me.GrpTipoMedicamento.Font = New System.Drawing.Font("Book Antiqua", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpTipoMedicamento.Location = New System.Drawing.Point(144, 12)
        Me.GrpTipoMedicamento.Name = "GrpTipoMedicamento"
        Me.GrpTipoMedicamento.Size = New System.Drawing.Size(185, 150)
        Me.GrpTipoMedicamento.TabIndex = 35
        Me.GrpTipoMedicamento.TabStop = False
        Me.GrpTipoMedicamento.Text = "Tipo de Medicamento"
        Me.GrpTipoMedicamento.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(135, 36)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(94, 21)
        Me.LinkLabel1.TabIndex = 35
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        Me.LinkLabel1.Visible = False
        '
        'FrmPet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1214, 643)
        Me.Controls.Add(Me.GrpTipoMedicamento)
        Me.Controls.Add(Me.BtnMedicamentos)
        Me.Controls.Add(Me.RadFoto11)
        Me.Controls.Add(Me.RadFoto10)
        Me.Controls.Add(Me.RadFoto9)
        Me.Controls.Add(Me.radFoto8)
        Me.Controls.Add(Me.BtnGaleriaFotos)
        Me.Controls.Add(Me.BtnAreaPet)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.RadFoto7)
        Me.Controls.Add(Me.RadFoto6)
        Me.Controls.Add(Me.RadFoto5)
        Me.Controls.Add(Me.RadFoto4)
        Me.Controls.Add(Me.RadFoto3)
        Me.Controls.Add(Me.RadFoto1)
        Me.Controls.Add(Me.RadFoto2)
        Me.Name = "FrmPet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pet"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpTipoMedicamento.ResumeLayout(False)
        Me.GrpTipoMedicamento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVoltar As System.Windows.Forms.Button
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents RadFoto7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadFoto6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadFoto5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadFoto4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadFoto3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadFoto1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadFoto2 As System.Windows.Forms.RadioButton
    Friend WithEvents BtnGaleriaFotos As System.Windows.Forms.Button
    Friend WithEvents BtnAreaPet As System.Windows.Forms.Button
    Friend WithEvents RadFoto11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadFoto10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadFoto9 As System.Windows.Forms.RadioButton
    Friend WithEvents radFoto8 As System.Windows.Forms.RadioButton
    Friend WithEvents BtnMedicamentos As System.Windows.Forms.Button
    Friend WithEvents RadComprimido As System.Windows.Forms.RadioButton
    Friend WithEvents RadLiquido As System.Windows.Forms.RadioButton
    Friend WithEvents RadInjetavel As System.Windows.Forms.RadioButton
    Friend WithEvents GrpTipoMedicamento As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
