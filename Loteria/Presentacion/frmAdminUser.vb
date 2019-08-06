Public Class frmAdminUser
    Private dt As New DataTable
    Dim ModoPantallaAdminUser As ModoPantalla

    Private Sub frmAdminUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Datos()
        inicia_pantalla()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Mostrar_Datos()
        Try
            Dim FuncionMostrar As New fAdminUser
            dt = FuncionMostrar.mostrar_Usuarios

            If dt.Rows.Count <> 0 Then
                dataUsuario.DataSource = dt
            Else
                dataUsuario.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar los usuarios." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub inicia_pantalla()
        DeshabilitarTextos(Me)
        DeshabilitarCombos(Me)
        chbHabilitado.Enabled = False

        If dt.Rows.Count = 0 Then
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            btnAgregar.Focus()
        Else
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnBuscar.Enabled = True
            cboBuscar.Enabled = True : cboBuscar.SelectedIndex = 1
            txtBuscar.Enabled = True
            txtBuscar.Focus()
        End If
    End Sub

    Private Sub Buscar_Datos()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)

            Dim dv As New DataView(ds.Tables(0))

            If cboBuscar.SelectedItem = "Nombreusu" Then
                dv.RowFilter = cboBuscar.Text & " Like '%" & txtBuscar.Text & "%'"
            ElseIf cboBuscar.SelectedItem = "Login" Then
                dv.RowFilter = cboBuscar.Text & " Like '%" & txtBuscar.Text & "%'"
            Else
                dv.RowFilter = cboBuscar.Text & " = " & txtBuscar.Text
            End If

            If dv.Count <> 0 Then
                dataUsuario.DataSource = dv
            Else
                dataUsuario.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de buscar el usuario deseado." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar_Datos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Agregar" Then
            ModoPantallaAdminUser = ModoPantalla.ModoALTA
            LimpiarTextos(Me)
            HabilitarTextos(Me)
            chbHabilitado.Enabled = True

            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            btnCerrar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            dataUsuario.Enabled = False
            txtID.Enabled = False


            btnAgregar.Text = "Confirmar"
            btnModificar.Text = "Cancelar"

            txtNombreUsu.Focus()
        Else
            'validamos controles
            If txtNombreUsu.Text = "" Then
                ErrProvAdminUser.SetError(txtNombreUsu, "Debe ingresar el nombre completo de usuario")
                txtNombreUsu.Focus()
                Exit Sub
            Else
                ErrProvAdminUser.SetError(txtNombreUsu, String.Empty)
            End If

            If txtLogin.Text = "" Then
                ErrProvAdminUser.SetError(txtLogin, "Debe ingresar un login valido")
                txtLogin.Focus()
                Exit Sub
            Else
                If ModoPantallaAdminUser = ModoPantalla.ModoALTA Then
                    Try
                        Dim dts As New logAdminUser
                        Dim Funcion As New fAdminUser

                        dts.pID = -1
                        dts.pLogin = txtLogin.Text

                        dt = Funcion.ValidarLogin(dts)

                        If dt.Rows.Count <> 0 Then 'si existen datos de login iguales devuelve el siguiente msj
                            ErrProvAdminUser.SetError(txtLogin, "Login existente, por favor ingrese otro")
                            Exit Sub
                        Else 'sino no muestro error alguno, y en caso de haber existido el error y luego corregirlo, quito el error y este queda como valido 
                            ErrProvAdminUser.SetError(txtLogin, String.Empty)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("ATENCIÓN: se ha generado un error tratando de comprobar la validez del login ingresado." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                ElseIf ModoPantallaAdminUser = ModoPantalla.ModoMODIFICACION Then
                    Try
                        Dim dts As New logAdminUser
                        Dim Funcion As New fAdminUser

                        dts.pID = txtID.Text
                        dts.pLogin = txtLogin.Text

                        dt = Funcion.ValidarLogin(dts)

                        If dt.Rows.Count <> 0 Then 'si existen datos de login iguales devuelve el siguiente msj
                            ErrProvAdminUser.SetError(txtLogin, "Login existente, por favor ingrese otro")
                            Exit Sub
                        Else 'sino no muestro error alguno, y en caso de haber existido el error y luego corregirlo, quito el error y este queda como valido 
                            ErrProvAdminUser.SetError(txtLogin, String.Empty)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("ATENCIÓN: se ha generado un error tratando de comprobar la validez del login ingresado." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If

                If txtPass.Text = "" Then
                ErrProvAdminUser.SetError(txtPass, "Debe ingresar una password valida")
                txtPass.Focus()
                Exit Sub
            Else
                ErrProvAdminUser.SetError(txtPass, String.Empty)
            End If

            If ModoPantallaAdminUser = ModoPantalla.ModoALTA Then
                Try

                    Dim dts As New logAdminUser
                    Dim FuncionInsertar As New fAdminUser

                    dts.pNombreUsu = txtNombreUsu.Text
                    dts.pLogin = txtLogin.Text
                    dts.pPassword = txtPass.Text
                    dts.pHabilitado = chbHabilitado.Checked

                    If FuncionInsertar.insertar_Usuario(dts) Then
                        Mostrar_Datos()
                        LimpiarTextos(Me)
                        inicia_pantalla()

                        btnAgregar.Text = "Agregar"
                        btnModificar.Text = "Modificar"
                        btnCerrar.Enabled = True
                        dataUsuario.Enabled = True
                    Else
                        MessageBox.Show("ATENCIÓN: El usuario no se ha registrado. Vuelva a intentarlo.",
                                    "Confirmar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("ATENCIÓN: se ha generado un error tratando de registrar el usuario." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf ModoPantallaAdminUser = ModoPantalla.ModoMODIFICACION Then
                Try
                    Dim dts As New logAdminUser
                    Dim FuncionInsertar As New fAdminUser

                    dts.pID = txtID.Text
                    dts.pNombreUsu = txtNombreUsu.Text
                    dts.pLogin = txtLogin.Text
                    dts.pPassword = txtPass.Text
                    dts.pHabilitado = chbHabilitado.Checked
                    'validar cambio con la cntraseña del usuario a modificar
                    If FuncionInsertar.Modificar_Usuario(dts) Then
                        Mostrar_Datos()
                        LimpiarTextos(Me)
                        inicia_pantalla()

                        btnAgregar.Text = "Agregar"
                        btnModificar.Text = "Modificar"
                        btnCerrar.Enabled = True
                        dataUsuario.Enabled = True
                    Else
                        MessageBox.Show("El usuario no se ha Modificado. Vuelva a intentarlo.",
                                            "Confirmar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("ATENCIÓN: se ha generado un error tratando de registrar las modificaciones del usuario." &
                                    Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub dataUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataUsuario.CellClick
        txtID.Text = dataUsuario.SelectedCells.Item(0).Value
        txtNombreUsu.Text = dataUsuario.SelectedCells.Item(1).Value
        txtLogin.Text = dataUsuario.SelectedCells.Item(2).Value
        chbHabilitado.Checked = dataUsuario.SelectedCells.Item(3).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If btnModificar.Text = "Cancelar" Then
            ModoPantallaAdminUser = ModoPantalla.ModoCONSULTA
            ErrProvAdminUser.SetError(txtNombreUsu, String.Empty)
            ErrProvAdminUser.SetError(txtLogin, String.Empty)
            ErrProvAdminUser.SetError(txtPass, String.Empty)
            inicia_pantalla()

            btnAgregar.Text = "Agregar"
            btnModificar.Text = "Modificar"

            btnCerrar.Enabled = True
            dataUsuario.Enabled = True
        Else
            ModoPantallaAdminUser = ModoPantalla.ModoMODIFICACION

            txtID.Text = dataUsuario.SelectedCells.Item(0).Value
            txtNombreUsu.Text = dataUsuario.SelectedCells.Item(1).Value
            txtLogin.Text = dataUsuario.SelectedCells.Item(2).Value
            chbHabilitado.Checked = dataUsuario.SelectedCells.Item(3).Value

            HabilitarTextos(Me)
            chbHabilitado.Enabled = True

            txtID.Enabled = False
            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            btnCerrar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            dataUsuario.Enabled = False

            btnAgregar.Text = "Confirmar"
            btnModificar.Text = "Cancelar"

            txtNombreUsu.Focus()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Respuesta As Integer = MessageBox.Show("ATENCIÓN: ha seleccionado eliminar usuario. " &
                                                   Environment.NewLine & "¿Confirma la eliminacion?", "Eliminacion de usuario",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        If Respuesta = MsgBoxResult.Yes Then
            Try
                Dim dts As New logAdminUser
                Dim FuncionInsertar As New fAdminUser

                txtID.Text = dataUsuario.SelectedCells.Item(0).Value

                dts.pID = txtID.Text

                If FuncionInsertar.Eliminar_Usuario(dts) Then
                    Mostrar_Datos()
                    LimpiarTextos(Me)
                    inicia_pantalla()
                Else
                    MessageBox.Show("La Agencia no se ha eliminado. Vuelva a intentarlo.",
                                    "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("ATENCIÓN: se ha generado un error tratando de eliminar el usuario seleccionado." &
                                    Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class