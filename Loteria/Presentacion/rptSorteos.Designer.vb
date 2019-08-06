<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptSorteos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSorteos))
        Me.MostrarSorteosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLoteria = New Loteria.DataSetLoteria()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MostrarSorteosTableAdapter = New Loteria.DataSetLoteriaTableAdapters.MostrarSorteosTableAdapter()
        CType(Me.MostrarSorteosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLoteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MostrarSorteosBindingSource
        '
        Me.MostrarSorteosBindingSource.DataMember = "MostrarSorteos"
        Me.MostrarSorteosBindingSource.DataSource = Me.DataSetLoteria
        '
        'DataSetLoteria
        '
        Me.DataSetLoteria.DataSetName = "DataSetLoteria"
        Me.DataSetLoteria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MostrarSorteosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Loteria.Sorteos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'MostrarSorteosTableAdapter
        '
        Me.MostrarSorteosTableAdapter.ClearBeforeFill = True
        '
        'rptSorteos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptSorteos"
        Me.Text = "Reporte de Sorteos"
        CType(Me.MostrarSorteosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLoteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MostrarSorteosBindingSource As BindingSource
    Friend WithEvents DataSetLoteria As DataSetLoteria
    Friend WithEvents MostrarSorteosTableAdapter As DataSetLoteriaTableAdapters.MostrarSorteosTableAdapter
End Class
