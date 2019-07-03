<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSorteo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarTipoSorteo = New System.Windows.Forms.Button()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoSorteo = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lvlTiSorteo = New System.Windows.Forms.Label()
        Me.lvlFechaSorteo = New System.Windows.Forms.Label()
        Me.lvlID = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataSorteo = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.lvlFecha = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnSortear = New System.Windows.Forms.Button()
        Me.ErrProvSorteo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataSorteo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvSorteo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgregarTipoSorteo)
        Me.GroupBox1.Controls.Add(Me.dtpHora)
        Me.GroupBox1.Controls.Add(Me.cboTipoSorteo)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lvlTiSorteo)
        Me.GroupBox1.Controls.Add(Me.lvlFechaSorteo)
        Me.GroupBox1.Controls.Add(Me.lvlID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnAgregarTipoSorteo
        '
        Me.btnAgregarTipoSorteo.Location = New System.Drawing.Point(273, 69)
        Me.btnAgregarTipoSorteo.Name = "btnAgregarTipoSorteo"
        Me.btnAgregarTipoSorteo.Size = New System.Drawing.Size(147, 23)
        Me.btnAgregarTipoSorteo.TabIndex = 13
        Me.btnAgregarTipoSorteo.Text = "Agregar Tipo de Sorteo"
        Me.btnAgregarTipoSorteo.UseVisualStyleBackColor = True
        '
        'dtpHora
        '
        Me.dtpHora.CustomFormat = "HH:mm"
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHora.Location = New System.Drawing.Point(352, 45)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.ShowUpDown = True
        Me.dtpHora.Size = New System.Drawing.Size(68, 20)
        Me.dtpHora.TabIndex = 3
        Me.dtpHora.Value = New Date(2019, 6, 23, 0, 0, 0, 0)
        '
        'cboTipoSorteo
        '
        Me.cboTipoSorteo.FormattingEnabled = True
        Me.cboTipoSorteo.Location = New System.Drawing.Point(146, 71)
        Me.cboTipoSorteo.Name = "cboTipoSorteo"
        Me.cboTipoSorteo.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoSorteo.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(146, 45)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.Value = New Date(2019, 6, 30, 16, 20, 17, 0)
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(146, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 4
        '
        'lvlTiSorteo
        '
        Me.lvlTiSorteo.AutoSize = True
        Me.lvlTiSorteo.Location = New System.Drawing.Point(63, 74)
        Me.lvlTiSorteo.Name = "lvlTiSorteo"
        Me.lvlTiSorteo.Size = New System.Drawing.Size(77, 13)
        Me.lvlTiSorteo.TabIndex = 3
        Me.lvlTiSorteo.Text = "Tipo de Sorteo"
        '
        'lvlFechaSorteo
        '
        Me.lvlFechaSorteo.AutoSize = True
        Me.lvlFechaSorteo.Location = New System.Drawing.Point(54, 51)
        Me.lvlFechaSorteo.Name = "lvlFechaSorteo"
        Me.lvlFechaSorteo.Size = New System.Drawing.Size(86, 13)
        Me.lvlFechaSorteo.TabIndex = 2
        Me.lvlFechaSorteo.Text = "Fecha de Sorteo"
        '
        'lvlID
        '
        Me.lvlID.AutoSize = True
        Me.lvlID.Location = New System.Drawing.Point(122, 22)
        Me.lvlID.Name = "lvlID"
        Me.lvlID.Size = New System.Drawing.Size(18, 13)
        Me.lvlID.TabIndex = 0
        Me.lvlID.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Location = New System.Drawing.Point(485, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 111)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(42, 76)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(42, 48)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(42, 19)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dataSorteo)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.txtBuscar)
        Me.GroupBox3.Controls.Add(Me.cboBuscar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(632, 236)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'dataSorteo
        '
        Me.dataSorteo.AllowUserToAddRows = False
        Me.dataSorteo.AllowUserToDeleteRows = False
        Me.dataSorteo.Location = New System.Drawing.Point(6, 46)
        Me.dataSorteo.MultiSelect = False
        Me.dataSorteo.Name = "dataSorteo"
        Me.dataSorteo.ReadOnly = True
        Me.dataSorteo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dataSorteo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataSorteo.Size = New System.Drawing.Size(620, 184)
        Me.dataSorteo.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(515, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(146, 20)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(363, 20)
        Me.txtBuscar.TabIndex = 5
        '
        'cboBuscar
        '
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"ID", "Fecha", "Nombre"})
        Me.cboBuscar.Location = New System.Drawing.Point(40, 19)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(100, 21)
        Me.cboBuscar.TabIndex = 4
        Me.cboBuscar.Text = "ID"
        '
        'lvlFecha
        '
        Me.lvlFecha.AutoSize = True
        Me.lvlFecha.Location = New System.Drawing.Point(12, 442)
        Me.lvlFecha.Name = "lvlFecha"
        Me.lvlFecha.Size = New System.Drawing.Size(37, 13)
        Me.lvlFecha.TabIndex = 1
        Me.lvlFecha.Text = "Fecha"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(563, 437)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Timer
        '
        '
        'btnSortear
        '
        Me.btnSortear.Location = New System.Drawing.Point(482, 437)
        Me.btnSortear.Name = "btnSortear"
        Me.btnSortear.Size = New System.Drawing.Size(75, 23)
        Me.btnSortear.TabIndex = 14
        Me.btnSortear.Text = "Sortear"
        Me.btnSortear.UseVisualStyleBackColor = True
        '
        'ErrProvSorteo
        '
        Me.ErrProvSorteo.ContainerControl = Me
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(632, 68)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(476, 30)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "...::: Administracion de los Sorteos :::..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Con esta opcion podrá dar de Alta, M" &
    "odificar, Eliminar y Consultar los sorteos  Sistema"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSorteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 472)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnSortear)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lvlFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmSorteo"
        Me.Text = ".:. Sorteo .:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dataSorteo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvSorteo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lvlTiSorteo As Label
    Friend WithEvents lvlFechaSorteo As Label
    Friend WithEvents lvlID As Label
    Friend WithEvents lvlFecha As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cboTipoSorteo As ComboBox
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents dataSorteo As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cboBuscar As ComboBox
    Friend WithEvents btnAgregarTipoSorteo As Button
    Friend WithEvents btnSortear As Button
    Friend WithEvents ErrProvSorteo As ErrorProvider
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
End Class
