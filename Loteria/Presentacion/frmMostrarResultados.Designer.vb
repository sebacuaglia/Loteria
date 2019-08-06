<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarResultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMostrarResultados))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataGanadores = New System.Windows.Forms.DataGridView()
        Me.dataResultado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dataGanadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.LightGray
        Me.btnCerrar.Location = New System.Drawing.Point(522, 264)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(109, 26)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(411, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ganadores"
        '
        'dataGanadores
        '
        Me.dataGanadores.AllowUserToAddRows = False
        Me.dataGanadores.AllowUserToDeleteRows = False
        Me.dataGanadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dataGanadores.BackgroundColor = System.Drawing.Color.LightGray
        Me.dataGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGanadores.Location = New System.Drawing.Point(249, 25)
        Me.dataGanadores.Name = "dataGanadores"
        Me.dataGanadores.ReadOnly = True
        Me.dataGanadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGanadores.Size = New System.Drawing.Size(383, 233)
        Me.dataGanadores.TabIndex = 12
        '
        'dataResultado
        '
        Me.dataResultado.AllowUserToAddRows = False
        Me.dataResultado.AllowUserToDeleteRows = False
        Me.dataResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dataResultado.BackgroundColor = System.Drawing.Color.LightGray
        Me.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataResultado.Location = New System.Drawing.Point(12, 25)
        Me.dataResultado.Name = "dataResultado"
        Me.dataResultado.ReadOnly = True
        Me.dataResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataResultado.Size = New System.Drawing.Size(217, 265)
        Me.dataResultado.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Resultado Sorteo:"
        '
        'frmMostrarResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(643, 294)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dataGanadores)
        Me.Controls.Add(Me.dataResultado)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(659, 333)
        Me.MinimumSize = New System.Drawing.Size(659, 333)
        Me.Name = "frmMostrarResultados"
        Me.Text = ".:. Resultados .:."
        CType(Me.dataGanadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dataGanadores As DataGridView
    Friend WithEvents dataResultado As DataGridView
    Friend WithEvents Label1 As Label
End Class
