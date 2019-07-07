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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        resources.ApplyResources(Me.btnCerrar, "btnCerrar")
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEliminar)
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Controls.Add(Me.btnModificar)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'btnEliminar
        '
        resources.ApplyResources(Me.btnEliminar, "btnEliminar")
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        resources.ApplyResources(Me.btnModificar, "btnModificar")
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.UseVisualStyleBackColor = True
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
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'chbHabilitado
        '
        resources.ApplyResources(Me.chbHabilitado, "chbHabilitado")
        Me.chbHabilitado.Name = "chbHabilitado"
        Me.chbHabilitado.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        resources.ApplyResources(Me.lblLogin, "lblLogin")
        Me.lblLogin.Name = "lblLogin"
        '
        'txtPass
        '
        resources.ApplyResources(Me.txtPass, "txtPass")
        Me.txtPass.Name = "txtPass"
        '
        'txtLogin
        '
        resources.ApplyResources(Me.txtLogin, "txtLogin")
        Me.txtLogin.Name = "txtLogin"
        '
        'txtNombreUsu
        '
        resources.ApplyResources(Me.txtNombreUsu, "txtNombreUsu")
        Me.txtNombreUsu.Name = "txtNombreUsu"
        '
        'txtID
        '
        resources.ApplyResources(Me.txtID, "txtID")
        Me.txtID.Name = "txtID"
        '
        'lblPass
        '
        resources.ApplyResources(Me.lblPass, "lblPass")
        Me.lblPass.Name = "lblPass"
        '
        'lblNombreUsu
        '
        resources.ApplyResources(Me.lblNombreUsu, "lblNombreUsu")
        Me.lblNombreUsu.Name = "lblNombreUsu"
        '
        'lblID
        '
        resources.ApplyResources(Me.lblID, "lblID")
        Me.lblID.Name = "lblID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dataUsuario)
        Me.GroupBox3.Controls.Add(Me.cboBuscar)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.txtBuscar)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'dataUsuario
        '
        Me.dataUsuario.AllowUserToAddRows = False
        Me.dataUsuario.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.dataUsuario, "dataUsuario")
        Me.dataUsuario.MultiSelect = False
        Me.dataUsuario.Name = "dataUsuario"
        Me.dataUsuario.ReadOnly = True
        Me.dataUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dataUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'cboBuscar
        '
        Me.cboBuscar.ForeColor = System.Drawing.Color.Black
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {resources.GetString("cboBuscar.Items"), resources.GetString("cboBuscar.Items1"), resources.GetString("cboBuscar.Items2")})
        resources.ApplyResources(Me.cboBuscar, "cboBuscar")
        Me.cboBuscar.Name = "cboBuscar"
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        resources.ApplyResources(Me.txtBuscar, "txtBuscar")
        Me.txtBuscar.Name = "txtBuscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label4)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmAdminUser
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmAdminUser"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dataUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents chbHabilitado As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
