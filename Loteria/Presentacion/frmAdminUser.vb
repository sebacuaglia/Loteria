Public Class frmAdminUser
    Private dt As New DataTable
    Dim ModoPantallaAgencias As ModoPantalla

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
            MessageBox.Show("Atencion: se ha generado un error tratando de mostrar las Agencias." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
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
            MessageBox.Show("Atencion: se ha generado un error tratando de buscar las Agencias." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar_Datos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Agregar" Then
            ModoPantallaAgencias = ModoPantalla.ModoALTA
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
                MsgBox("No ha ingresado un nombre de Usuario valido", MsgBoxStyle.Exclamation)
                'MsgBox("Ingrese un nombre de agencia")
                'ErrProvAgencias.SetError(txtNombre, "Debe ingresar un nombre para el Tipo de Sorteo")
                txtNombreUsu.Focus()
                Exit Sub
            End If
            If txtLogin.Text = "" Then
                MsgBox("No ha ingresado un nombre de Login valido", MsgBoxStyle.Exclamation)
                'ErrProvAgencias.SetError(txtGanancia, "Debe ingresar el porcentaje de ganancias")
                txtLogin.Focus()
                Exit Sub
            End If
            If txtPass.Text = "" Then
                MsgBox("No ha ingresado una Contraseña valida", MsgBoxStyle.Exclamation)
                'ErrProvAgencias.SetError(txtGanancia, "Debe ingresar el porcentaje de ganancias")
                txtPass.Focus()
                Exit Sub
            End If

            If ModoPantallaAgencias = ModoPantalla.ModoALTA Then
                Try

                    Dim dts As New LogAdminUser
                    Dim FuncionInsertar As New fAdminUser

                    dts.pNombreUsu = txtNombreUsu.Text
                    dts.pLogin = txtLogin.Text
                    dts.pPassword = txtPass.Text
                    dts.pHabilitado = chbHabilitado.Checked

                    If FuncionInsertar.Insertar_Usuario(dts) Then
                        Mostrar_Datos()
                        LimpiarTextos(Me)
                        inicia_pantalla()

                        btnAgregar.Text = "Agregar"
                        btnModificar.Text = "Modificar"
                        btnCerrar.Enabled = True
                        dataUsuario.Enabled = True
                    Else
                        MessageBox.Show("La agencia no se ha registrado. Vuelva a intentarlo.",
                                    "Confirmar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Atencion: se ha generado un error tratando de Registrar la agencia." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf ModoPantallaAgencias = ModoPantalla.ModoMODIFICACION Then
                Try
                    Dim dts As New LogAdminUser
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
                        MessageBox.Show("La agencia no se ha Modificado. Vuelva a intentarlo.",
                                            "Confirmar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Atencion: se ha generado un error tratando de Modificar la agencia." &
                                    Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub dataAgencia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataUsuario.CellClick
        txtID.Text = dataUsuario.SelectedCells.Item(0).Value
        txtNombreUsu.Text = dataUsuario.SelectedCells.Item(1).Value
        txtLogin.Text = dataUsuario.SelectedCells.Item(2).Value
        chbHabilitado.Checked = dataUsuario.SelectedCells.Item(3).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If btnModificar.Text = "Cancelar" Then
            ModoPantallaAgencias = ModoPantalla.ModoCONSULTA

            inicia_pantalla()

            btnAgregar.Text = "Agregar"
            btnModificar.Text = "Modificar"

            btnCerrar.Enabled = True
            dataUsuario.Enabled = True
        Else
            ModoPantallaAgencias = ModoPantalla.ModoMODIFICACION

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
        Dim Respuesta As Integer = MessageBox.Show("Atencion: ha seleccionado eliminar Agencia. " &
                                                   Environment.NewLine & "¿confirma la eliminacion?", "eliminacion de Agencias",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        If Respuesta = MsgBoxResult.Yes Then
            Try
                Dim dts As New LogAdminUser
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
                MessageBox.Show("Atencion: se ha generado un error tratando de Eliminar la Agencia." &
                                    Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class