<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormulario2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormulario2))
        Me.picFelipe = New System.Windows.Forms.PictureBox()
        Me.lblFelipe = New System.Windows.Forms.Label()
        Me.lblFormasdeContato = New System.Windows.Forms.Label()
        Me.picMensagem = New System.Windows.Forms.PictureBox()
        Me.picWhats = New System.Windows.Forms.PictureBox()
        Me.picFacebook = New System.Windows.Forms.PictureBox()
        Me.linkMensagem = New System.Windows.Forms.LinkLabel()
        Me.linkFacebook = New System.Windows.Forms.LinkLabel()
        Me.linkWhats = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.picFelipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMensagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWhats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFacebook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFelipe
        '
        Me.picFelipe.Image = CType(resources.GetObject("picFelipe.Image"), System.Drawing.Image)
        Me.picFelipe.Location = New System.Drawing.Point(24, 12)
        Me.picFelipe.Name = "picFelipe"
        Me.picFelipe.Size = New System.Drawing.Size(182, 194)
        Me.picFelipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFelipe.TabIndex = 0
        Me.picFelipe.TabStop = False
        '
        'lblFelipe
        '
        Me.lblFelipe.AutoSize = True
        Me.lblFelipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFelipe.ForeColor = System.Drawing.Color.Red
        Me.lblFelipe.Location = New System.Drawing.Point(235, 22)
        Me.lblFelipe.Name = "lblFelipe"
        Me.lblFelipe.Size = New System.Drawing.Size(194, 16)
        Me.lblFelipe.TabIndex = 1
        Me.lblFelipe.Text = "FELIPE CAMPOS FREITAS"
        '
        'lblFormasdeContato
        '
        Me.lblFormasdeContato.AutoSize = True
        Me.lblFormasdeContato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormasdeContato.Location = New System.Drawing.Point(235, 56)
        Me.lblFormasdeContato.Name = "lblFormasdeContato"
        Me.lblFormasdeContato.Size = New System.Drawing.Size(136, 15)
        Me.lblFormasdeContato.TabIndex = 2
        Me.lblFormasdeContato.Text = "Formas de Contato :"
        '
        'picMensagem
        '
        Me.picMensagem.Image = CType(resources.GetObject("picMensagem.Image"), System.Drawing.Image)
        Me.picMensagem.Location = New System.Drawing.Point(238, 82)
        Me.picMensagem.Name = "picMensagem"
        Me.picMensagem.Size = New System.Drawing.Size(52, 33)
        Me.picMensagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMensagem.TabIndex = 3
        Me.picMensagem.TabStop = False
        '
        'picWhats
        '
        Me.picWhats.Image = CType(resources.GetObject("picWhats.Image"), System.Drawing.Image)
        Me.picWhats.Location = New System.Drawing.Point(238, 121)
        Me.picWhats.Name = "picWhats"
        Me.picWhats.Size = New System.Drawing.Size(52, 35)
        Me.picWhats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWhats.TabIndex = 4
        Me.picWhats.TabStop = False
        '
        'picFacebook
        '
        Me.picFacebook.Image = CType(resources.GetObject("picFacebook.Image"), System.Drawing.Image)
        Me.picFacebook.Location = New System.Drawing.Point(238, 162)
        Me.picFacebook.Name = "picFacebook"
        Me.picFacebook.Size = New System.Drawing.Size(52, 32)
        Me.picFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFacebook.TabIndex = 5
        Me.picFacebook.TabStop = False
        '
        'linkMensagem
        '
        Me.linkMensagem.AutoSize = True
        Me.linkMensagem.Location = New System.Drawing.Point(296, 102)
        Me.linkMensagem.Name = "linkMensagem"
        Me.linkMensagem.Size = New System.Drawing.Size(99, 13)
        Me.linkMensagem.TabIndex = 6
        Me.linkMensagem.TabStop = True
        Me.linkMensagem.Text = "felipe@hotmail.com"
        '
        'linkFacebook
        '
        Me.linkFacebook.AutoSize = True
        Me.linkFacebook.Location = New System.Drawing.Point(296, 181)
        Me.linkFacebook.Name = "linkFacebook"
        Me.linkFacebook.Size = New System.Drawing.Size(171, 13)
        Me.linkFacebook.TabIndex = 7
        Me.linkFacebook.TabStop = True
        Me.linkFacebook.Text = "https ://www.facebook.com/felipe"
        '
        'linkWhats
        '
        Me.linkWhats.AutoSize = True
        Me.linkWhats.Location = New System.Drawing.Point(296, 143)
        Me.linkWhats.Name = "linkWhats"
        Me.linkWhats.Size = New System.Drawing.Size(85, 13)
        Me.linkWhats.TabIndex = 8
        Me.linkWhats.Text = "(11) 99123-4567"
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(270, 274)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmFormulario2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 355)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.linkWhats)
        Me.Controls.Add(Me.linkFacebook)
        Me.Controls.Add(Me.linkMensagem)
        Me.Controls.Add(Me.picFacebook)
        Me.Controls.Add(Me.picWhats)
        Me.Controls.Add(Me.picMensagem)
        Me.Controls.Add(Me.lblFormasdeContato)
        Me.Controls.Add(Me.lblFelipe)
        Me.Controls.Add(Me.picFelipe)
        Me.Name = "frmFormulario2"
        Me.Text = "Informações sobre o Gerente"
        CType(Me.picFelipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMensagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWhats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFacebook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picFelipe As System.Windows.Forms.PictureBox
    Friend WithEvents lblFelipe As System.Windows.Forms.Label
    Friend WithEvents lblFormasdeContato As System.Windows.Forms.Label
    Friend WithEvents picMensagem As System.Windows.Forms.PictureBox
    Friend WithEvents picWhats As System.Windows.Forms.PictureBox
    Friend WithEvents picFacebook As System.Windows.Forms.PictureBox
    Friend WithEvents linkMensagem As System.Windows.Forms.LinkLabel
    Friend WithEvents linkFacebook As System.Windows.Forms.LinkLabel
    Friend WithEvents linkWhats As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
