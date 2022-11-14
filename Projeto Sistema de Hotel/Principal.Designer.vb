<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.BtnSuites = New System.Windows.Forms.Button()
        Me.btnrestaurante = New System.Windows.Forms.Button()
        Me.btnvagas = New System.Windows.Forms.Button()
        Me.BtnCadastroCliente = New System.Windows.Forms.Button()
        Me.btnrelatorio = New System.Windows.Forms.Button()
        Me.BtnAreaPet = New System.Windows.Forms.Button()
        Me.btnconsulta = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btninfosistema = New System.Windows.Forms.Button()
        Me.btninfodesen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSuites
        '
        Me.BtnSuites.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSuites.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuites.Location = New System.Drawing.Point(98, 137)
        Me.BtnSuites.Name = "BtnSuites"
        Me.BtnSuites.Size = New System.Drawing.Size(231, 424)
        Me.BtnSuites.TabIndex = 0
        Me.BtnSuites.Text = "Suites"
        Me.BtnSuites.UseVisualStyleBackColor = False
        '
        'btnrestaurante
        '
        Me.btnrestaurante.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnrestaurante.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestaurante.Location = New System.Drawing.Point(667, 352)
        Me.btnrestaurante.Name = "btnrestaurante"
        Me.btnrestaurante.Size = New System.Drawing.Size(113, 109)
        Me.btnrestaurante.TabIndex = 1
        Me.btnrestaurante.Text = "Restaurante"
        Me.btnrestaurante.UseVisualStyleBackColor = False
        '
        'btnvagas
        '
        Me.btnvagas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnvagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvagas.Location = New System.Drawing.Point(824, 137)
        Me.btnvagas.Name = "btnvagas"
        Me.btnvagas.Size = New System.Drawing.Size(227, 217)
        Me.btnvagas.TabIndex = 9
        Me.btnvagas.Text = "Vaga Estacionamento"
        Me.btnvagas.UseVisualStyleBackColor = False
        '
        'BtnCadastroCliente
        '
        Me.BtnCadastroCliente.BackColor = System.Drawing.Color.Lime
        Me.BtnCadastroCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastroCliente.Location = New System.Drawing.Point(335, 137)
        Me.BtnCadastroCliente.Name = "BtnCadastroCliente"
        Me.BtnCadastroCliente.Size = New System.Drawing.Size(220, 211)
        Me.BtnCadastroCliente.TabIndex = 10
        Me.BtnCadastroCliente.Text = "Cadastro De Cliente"
        Me.BtnCadastroCliente.UseVisualStyleBackColor = False
        '
        'btnrelatorio
        '
        Me.btnrelatorio.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnrelatorio.Location = New System.Drawing.Point(335, 361)
        Me.btnrelatorio.Name = "btnrelatorio"
        Me.btnrelatorio.Size = New System.Drawing.Size(220, 203)
        Me.btnrelatorio.TabIndex = 11
        Me.btnrelatorio.Text = "Relatorio"
        Me.btnrelatorio.UseVisualStyleBackColor = False
        '
        'BtnAreaPet
        '
        Me.BtnAreaPet.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnAreaPet.Location = New System.Drawing.Point(824, 352)
        Me.BtnAreaPet.Name = "BtnAreaPet"
        Me.BtnAreaPet.Size = New System.Drawing.Size(227, 212)
        Me.BtnAreaPet.TabIndex = 12
        Me.BtnAreaPet.Text = "Área Pet"
        Me.BtnAreaPet.UseVisualStyleBackColor = False
        '
        'btnconsulta
        '
        Me.btnconsulta.BackColor = System.Drawing.Color.Coral
        Me.btnconsulta.Location = New System.Drawing.Point(554, 137)
        Me.btnconsulta.Name = "btnconsulta"
        Me.btnconsulta.Size = New System.Drawing.Size(226, 218)
        Me.btnconsulta.TabIndex = 16
        Me.btnconsulta.Text = "Consulta"
        Me.btnconsulta.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(108, 585)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(295, 21)
        Me.DateTimePicker1.TabIndex = 27
        '
        'btninfosistema
        '
        Me.btninfosistema.BackColor = System.Drawing.Color.Lime
        Me.btninfosistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninfosistema.Location = New System.Drawing.Point(554, 352)
        Me.btninfosistema.Name = "btninfosistema"
        Me.btninfosistema.Size = New System.Drawing.Size(118, 109)
        Me.btninfosistema.TabIndex = 28
        Me.btninfosistema.Text = "informações do sistema"
        Me.btninfosistema.UseVisualStyleBackColor = False
        '
        'btninfodesen
        '
        Me.btninfodesen.BackColor = System.Drawing.Color.Lime
        Me.btninfodesen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninfodesen.Location = New System.Drawing.Point(554, 455)
        Me.btninfodesen.Name = "btninfodesen"
        Me.btninfodesen.Size = New System.Drawing.Size(226, 109)
        Me.btninfodesen.TabIndex = 29
        Me.btninfodesen.Text = "informações dos desenvolvedores"
        Me.btninfodesen.UseVisualStyleBackColor = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1210, 639)
        Me.Controls.Add(Me.btninfodesen)
        Me.Controls.Add(Me.btninfosistema)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnconsulta)
        Me.Controls.Add(Me.BtnAreaPet)
        Me.Controls.Add(Me.btnrelatorio)
        Me.Controls.Add(Me.BtnCadastroCliente)
        Me.Controls.Add(Me.btnvagas)
        Me.Controls.Add(Me.btnrestaurante)
        Me.Controls.Add(Me.BtnSuites)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSuites As System.Windows.Forms.Button
    Friend WithEvents btnrestaurante As System.Windows.Forms.Button
    Friend WithEvents btnvagas As System.Windows.Forms.Button
    Friend WithEvents BtnCadastroCliente As System.Windows.Forms.Button
    Friend WithEvents btnrelatorio As System.Windows.Forms.Button
    Friend WithEvents BtnAreaPet As System.Windows.Forms.Button
    Friend WithEvents btnconsulta As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btninfosistema As System.Windows.Forms.Button
    Friend WithEvents btninfodesen As System.Windows.Forms.Button
End Class
