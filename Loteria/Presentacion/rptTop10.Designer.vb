<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Top10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Top10))
        Me.Top10BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLoteria = New Loteria.DataSetLoteria()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Top10TableAdapter = New Loteria.DataSetLoteriaTableAdapters.Top10TableAdapter()
        CType(Me.Top10BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLoteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Top10BindingSource
        '
        Me.Top10BindingSource.DataMember = "Top10"
        Me.Top10BindingSource.DataSource = Me.DataSetLoteria
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
        ReportDataSource1.Value = Me.Top10BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Loteria.Top10.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Top10TableAdapter
        '
        Me.Top10TableAdapter.ClearBeforeFill = True
        '
        'Top10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Top10"
        Me.Text = "Top10"
        CType(Me.Top10BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLoteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Top10BindingSource As BindingSource
    Friend WithEvents DataSetLoteria As DataSetLoteria
    Friend WithEvents Top10TableAdapter As DataSetLoteriaTableAdapters.Top10TableAdapter
End Class
