<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptTipoSorteo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptTipoSorteo))
        Me.procMostrar_TipoSorteoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLoteria = New Loteria.DataSetLoteria()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.procMostrar_TipoSorteoTableAdapter = New Loteria.DataSetLoteriaTableAdapters.procMostrar_TipoSorteoTableAdapter()
        CType(Me.procMostrar_TipoSorteoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLoteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'procMostrar_TipoSorteoBindingSource
        '
        Me.procMostrar_TipoSorteoBindingSource.DataMember = "procMostrar_TipoSorteo"
        Me.procMostrar_TipoSorteoBindingSource.DataSource = Me.DataSetLoteria
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
        ReportDataSource1.Value = Me.procMostrar_TipoSorteoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Loteria.TiposSorteos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'procMostrar_TipoSorteoTableAdapter
        '
        Me.procMostrar_TipoSorteoTableAdapter.ClearBeforeFill = True
        '
        'rptTipoSorteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptTipoSorteo"
        Me.Text = "Reporte Tipos de Sorteos"
        CType(Me.procMostrar_TipoSorteoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLoteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents procMostrar_TipoSorteoBindingSource As BindingSource
    Friend WithEvents DataSetLoteria As DataSetLoteria
    Friend WithEvents procMostrar_TipoSorteoTableAdapter As DataSetLoteriaTableAdapters.procMostrar_TipoSorteoTableAdapter
End Class
