<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatoriocliente
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tb_cadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_cadastroDataSet = New Projeto_Sistema_de_Hotel.tb_cadastroDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tb_cadastroTableAdapter = New Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.tb_cadastroTableAdapter()
        CType(Me.tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_cadastroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_cadastroBindingSource
        '
        Me.tb_cadastroBindingSource.DataMember = "tb_cadastro"
        Me.tb_cadastroBindingSource.DataSource = Me.tb_cadastroDataSet
        '
        'tb_cadastroDataSet
        '
        Me.tb_cadastroDataSet.DataSetName = "tb_cadastroDataSet"
        Me.tb_cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "relatoriocliente"
        ReportDataSource1.Value = Me.tb_cadastroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Sistema_de_Hotel.Sistemahotel.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1093, 631)
        Me.ReportViewer1.TabIndex = 0
        '
        'tb_cadastroTableAdapter
        '
        Me.tb_cadastroTableAdapter.ClearBeforeFill = True
        '
        'frmRelatoriocliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 631)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRelatoriocliente"
        Me.Text = "Relatoriocliente"
        CType(Me.tb_cadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_cadastroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_cadastroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tb_cadastroDataSet As Projeto_Sistema_de_Hotel.tb_cadastroDataSet
    Friend WithEvents tb_cadastroTableAdapter As Projeto_Sistema_de_Hotel.tb_cadastroDataSetTableAdapters.tb_cadastroTableAdapter
End Class
