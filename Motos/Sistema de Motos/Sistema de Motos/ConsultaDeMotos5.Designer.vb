<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaDeMotos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaDeMotos))
        Me.LblInformeModelo = New System.Windows.Forms.Label()
        Me.LblConsultaMotos = New System.Windows.Forms.Label()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblInformeModelo
        '
        Me.LblInformeModelo.AutoSize = True
        Me.LblInformeModelo.BackColor = System.Drawing.Color.Transparent
        Me.LblInformeModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformeModelo.ForeColor = System.Drawing.Color.Black
        Me.LblInformeModelo.Location = New System.Drawing.Point(673, 11)
        Me.LblInformeModelo.Name = "LblInformeModelo"
        Me.LblInformeModelo.Size = New System.Drawing.Size(128, 16)
        Me.LblInformeModelo.TabIndex = 0
        Me.LblInformeModelo.Text = "Informe o Modelo"
        '
        'LblConsultaMotos
        '
        Me.LblConsultaMotos.AutoSize = True
        Me.LblConsultaMotos.BackColor = System.Drawing.Color.Transparent
        Me.LblConsultaMotos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultaMotos.Location = New System.Drawing.Point(835, 9)
        Me.LblConsultaMotos.Name = "LblConsultaMotos"
        Me.LblConsultaMotos.Size = New System.Drawing.Size(128, 18)
        Me.LblConsultaMotos.TabIndex = 2
        Me.LblConsultaMotos.Text = "Consulta Motos"
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(816, 37)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(167, 169)
        Me.PicFoto.TabIndex = 3
        Me.PicFoto.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(680, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'FrmConsultaDeMotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1234, 581)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.LblConsultaMotos)
        Me.Controls.Add(Me.LblInformeModelo)
        Me.Name = "FrmConsultaDeMotos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaDeMotos"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblInformeModelo As System.Windows.Forms.Label
    Friend WithEvents LblConsultaMotos As System.Windows.Forms.Label
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
