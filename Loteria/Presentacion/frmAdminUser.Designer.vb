<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminUser))
        Me.ErrProvAdminUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chbHabilitado = New System.Windows.Forms.CheckBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtNombreUsu = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblNombreUsu = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataUsuario = New System.Windows.Forms.DataGridView()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ErrProvAdminUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrProvAdminUser
        '
        Me.ErrProvAdminUser.ContainerControl = Me
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.LightGray
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(534, 435)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(109, 26)
        Me.btnCerrar.TabIndex = 23
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEliminar)
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Controls.Add(Me.btnModificar)
        Me.GroupBox4.Location = New System.Drawing.Point(522, 76)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(127, 183)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightGray
        Me.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEliminar.Location = New System.Drawing.Point(12, 129)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(109, 26)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.LightGray
        Me.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgregar.Location = New System.Drawing.Point(12, 33)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(109, 26)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.LightGray
        Me.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnModificar.Location = New System.Drawing.Point(12, 81)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 26)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chbHabilitado)
        Me.GroupBox2.Controls.Add(Me.lblLogin)
        Me.GroupBox2.Controls.Add(Me.txtPass)
        Me.GroupBox2.Controls.Add(Me.txtLogin)
        Me.GroupBox2.Controls.Add(Me.txtNombreUsu)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.lblPass)
        Me.GroupBox2.Controls.Add(Me.lblNombreUsu)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 183)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'chbHabilitado
        '
        Me.chbHabilitado.AutoSize = True
        Me.chbHabilitado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chbHabilitado.Location = New System.Drawing.Point(363, 154)
        Me.chbHabilitado.Name = "chbHabilitado"
        Me.chbHabilitado.Size = New System.Drawing.Size(103, 17)
        Me.chbHabilitado.TabIndex = 8
        Me.chbHabilitado.Text = "Habilitar Usuario"
        Me.chbHabilitado.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLogin.Location = New System.Drawing.Point(71, 95)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(33, 13)
        Me.lblLogin.TabIndex = 7
        Me.lblLogin.Text = "Login"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(110, 121)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(356, 20)
        Me.txtPass.TabIndex = 6
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(110, 92)
        Me.txtLogin.Multiline = True
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(356, 22)
        Me.txtLogin.TabIndex = 5
        '
        'txtNombreUsu
        '
        Me.txtNombreUsu.Location = New System.Drawing.Point(110, 60)
        Me.txtNombreUsu.Name = "txtNombreUsu"
        Me.txtNombreUsu.Size = New System.Drawing.Size(356, 20)
        Me.txtNombreUsu.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(110, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 3
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPass.Location = New System.Drawing.Point(51, 124)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 13)
        Me.lblPass.TabIndex = 2
        Me.lblPass.Text = "Password"
        '
        'lblNombreUsu
        '
        Me.lblNombreUsu.AutoSize = True
        Me.lblNombreUsu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNombreUsu.Location = New System.Drawing.Point(21, 63)
        Me.lblNombreUsu.Name = "lblNombreUsu"
        Me.lblNombreUsu.Size = New System.Drawing.Size(83, 13)
        Me.lblNombreUsu.TabIndex = 1
        Me.lblNombreUsu.Text = "Nombre Usuario"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblID.Location = New System.Drawing.Point(86, 37)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dataUsuario)
        Me.GroupBox3.Controls.Add(Me.cboBuscar)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.txtBuscar)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(644, 170)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'dataUsuario
        '
        Me.dataUsuario.AllowUserToAddRows = False
        Me.dataUsuario.AllowUserToDeleteRows = False
        Me.dataUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dataUsuario.BackgroundColor = System.Drawing.Color.LightGray
        Me.dataUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataUsuario.Location = New System.Drawing.Point(12, 50)
        Me.dataUsuario.MultiSelect = False
        Me.dataUsuario.Name = "dataUsuario"
        Me.dataUsuario.ReadOnly = True
        Me.dataUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dataUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataUsuario.Size = New System.Drawing.Size(626, 102)
        Me.dataUsuario.TabIndex = 12
        '
        'cboBuscar
        '
        Me.cboBuscar.ForeColor = System.Drawing.Color.Black
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"ID", "Nombreusu", "Login"})
        Me.cboBuscar.Location = New System.Drawing.Point(12, 15)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(121, 21)
        Me.cboBuscar.TabIndex = 11
        Me.cboBuscar.Text = "Nombreusu"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.LightGray
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(529, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(109, 26)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(139, 16)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(372, 20)
        Me.txtBuscar.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 68)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(21, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(572, 30)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "...::: Administracion de Usuarios:::..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Con esta opcion podrá dar de Alta, Modif" &
    "icar, Eliminar y Consultar los Usuarios que utilizaran el Sistema"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAdminUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(656, 472)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(672, 511)
        Me.MinimumSize = New System.Drawing.Size(672, 511)
        Me.Name = "frmAdminUser"
        Me.Text = ".:. Administracion de Usuarios .:."
        CType(Me.ErrProvAdminUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dataUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrProvAdminUser As ErrorProvider
    Friend WithEvents btnCerrar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chbHabilitado As CheckBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtNombreUsu As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblNombreUsu As Label
    Friend WithEvents lblID As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dataUsuario As DataGridView
    Friend WithEvents cboBuscar As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
End Class