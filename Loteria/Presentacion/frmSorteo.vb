Public Class frmSorteo
    Private dt As New DataTable
    'Private ds As New DataTable
    Dim ModoPantallaSorteo As ModoPantalla

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub frmSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Enabled = True
        Mostrar_Datos()
        inicia_pantalla()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        'Muestro la hora actual y se actualiza cada segundo
        lvlFecha.Text = DateTime.Now.ToString
    End Sub

    Private Sub Mostrar_TipoSorteo()
        Try
            Dim FuncionMostrar As New fSorteo
            dt = FuncionMostrar.Mostrar_NombreTipoSorteos

            If dt.Rows.Count <> 0 Then
                cboTipoSorteo.DataSource = dt
                cboTipoSorteo.DisplayMember = "Nombre"
                cboTipoSorteo.ValueMember = "ID"
            Else
                cboTipoSorteo.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de mostrar los sorteos." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Mostrar_Datos()
        Try
            Dim FuncionMostrar As New fSorteo
            dt = FuncionMostrar.Mostrar_Sorteo

            If dt.Rows.Count <> 0 Then
                dataSorteo.DataSource = dt
            Else
                dataSorteo.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de mostrar los sorteos." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Buscar_Datos()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            If cboBuscar.SelectedItem = "Nombre" Then
                dv.RowFilter = cboBuscar.Text & " Like '%" & txtBuscar.Text & "%'"
            Else
                dv.RowFilter = cboBuscar.Text & " = " & txtBuscar.Text
            End If


            If dv.Count <> 0 Then
                dataSorteo.DataSource = dv
            Else
                dataSorteo.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de buscar los sorteos." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub inicia_pantalla()
        dtpFecha.Value = DateTime.Now
        dtpHora.Value = DateTime.Now
        DeshabilitarTextos(Me)
        DeshabilitarCombos(Me)
        cboTipoSorteo.SelectedIndex = -1
        dtpFecha.CustomFormat = " "
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpHora.CustomFormat = " "
        dtpHora.Format = DateTimePickerFormat.Custom
        dtpFecha.Enabled = False
        dtpHora.Enabled = False
        btnActualizar.Enabled = False

        If dt.Rows.Count = 0 Then
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            btnSortear.Enabled = False
            btnAgregarTipoSorteo.Enabled = False
            btnAgregar.Focus()
        Else
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnBuscar.Enabled = True
            cboBuscar.Enabled = True : cboBuscar.SelectedIndex = 1
            cboTipoSorteo.Enabled = False
            txtBuscar.Enabled = True
            btnSortear.Enabled = False
            txtBuscar.Focus()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar_Datos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Agregar" Then
            ModoPantallaSorteo = ModoPantalla.ModoALTA

            Mostrar_TipoSorteo()
            LimpiarTextos(Me)
            HabilitarTextos(Me)
            Dim funcion As New fSorteo
            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            btnCerrar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            dataSorteo.Enabled = False
            txtID.Enabled = False
            cboTipoSorteo.Enabled = True
            dtpFecha.Enabled = True
            dtpHora.Enabled = True
            btnActualizar.Enabled = True

            btnAgregar.Text = "Confirmar"
            btnModificar.Text = "Cancelar"
            btnModificar.Enabled = True
            dtpFecha.Format = DateTimePickerFormat.Long
            dtpHora.CustomFormat = "HH:mm"
            dtpHora.Format = DateTimePickerFormat.Custom
            dtpFecha.Focus()
        Else
            cboTipoSorteo.Enabled = True

            'validamos controles

            If dtpFecha.Value.ToString("yyyy-MM-dd") + " " + dtpHora.Value.ToString("HH:mm:ss.fff") <= DateTime.Now Then
                MsgBox("No ha ingresado una fecha válida", MsgBoxStyle.Exclamation)
                MsgBox("No ha ingresado una hora válida", MsgBoxStyle.Exclamation)
                'ErrProvSorteo.SetError(dtpFecha, "Debe ingresar una fecha válida")
                'ErrProvSorteo.SetError(dtpHora, "Debe ingresar una fecha válida")
                dtpFecha.Focus()
                Exit Sub
            End If
            If cboTipoSorteo.Text = "" Then
                MsgBox("No ha seleccionado un tipo de sorteo", MsgBoxStyle.Exclamation)
                'ErrProvSorteo.SetError(cboTipoSorteo, "No se ha seleccionado un tipo de sorteo")
                cboTipoSorteo.Focus()
                Exit Sub
            End If
            ErrProvSorteo.SetError(dtpHora, "")
            ErrProvSorteo.SetError(dtpFecha, "")
            If ModoPantallaSorteo = ModoPantalla.ModoALTA Then
                Try
                    Dim dts As New logSorteo
                    Dim FuncionInsertar As New fSorteo

                    'dts.pID = txtID.Text
                    dts.pFechaHora = dtpFecha.Value.ToString("dd-MM-yyyy") + " " + dtpHora.Value.ToString("HH:mm:ss.fff")
                    dts.pIDTipoSorteo = cboTipoSorteo.SelectedValue
                    If FuncionInsertar.Insertar_Sorteo(dts) Then
                        Mostrar_Datos()
                        LimpiarTextos(Me)
                        inicia_pantalla()

                        cboTipoSorteo.SelectedIndex = -1

                        btnAgregar.Text = "Agregar"
                        btnModificar.Text = "Modificar"
                        btnCerrar.Enabled = True
                        dataSorteo.Enabled = True
                    Else
                        MessageBox.Show("El tipo de sorteo no se ha registrado. Vuelva a intentarlo.",
                                    "Confirmar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Atencion: se ha generado un error tratando de Registrar los tipos de sorteo." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf ModoPantallaSorteo = ModoPantalla.ModoMODIFICACION Then
                Try
                    Dim dts As New logSorteo
                    Dim FuncionInsertar As New fSorteo

                    dts.pID = txtID.Text
                    dts.pFechaHora = dtpFecha.Value.ToString("dd-MM-yyyy") + " " + dtpHora.Value.ToString("HH:mm:ss.fff")
                    dts.pIDTipoSorteo = cboTipoSorteo.SelectedValue

                    If FuncionInsertar.Modificar_Sorteo(dts) Then
                        Mostrar_Datos()
                        LimpiarTextos(Me)
                        inicia_pantalla()

                        btnAgregar.Text = "Agregar"
                        btnModificar.Text = "Modificar"
                        btnCerrar.Enabled = True
                        dataSorteo.Enabled = True
                    Else
                        MessageBox.Show("El tipo de sorteo no se ha modificado. Vuelva a intentarlo.",
                                            "Confirmar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Atencion: se ha generado un error tratando de Modificar los tipos de sorteo." &
                                    Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub dataTipoSorteo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataSorteo.CellClick
        Mostrar_TipoSorteo()
        dtpFecha.Format = DateTimePickerFormat.Long
        dtpHora.CustomFormat = "HH:mm"
        dtpHora.Format = DateTimePickerFormat.Custom
        txtID.Text = dataSorteo.SelectedCells.Item(0).Value
        dtpFecha.Text = Convert.ToString(dataSorteo.SelectedCells.Item(1).Value)
        dtpHora.Text = Convert.ToString(dataSorteo.SelectedCells.Item(1).Value)
        cboTipoSorteo.SelectedIndex = cboTipoSorteo.FindStringExact(dataSorteo.SelectedCells.Item(2).Value)
        btnSortear.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Cancelar" Then
            ModoPantallaSorteo = ModoPantalla.ModoCONSULTA

            btnAgregar.Text = "Agregar"
            btnModificar.Text = "Modificar"

            btnActualizar.Enabled = False
            btnCerrar.Enabled = True
            dataSorteo.Enabled = True
            Mostrar_Datos()
            LimpiarTextos(Me)
            inicia_pantalla()

            ErrProvSorteo.SetError(dtpFecha, "")
        Else
            cboTipoSorteo.Enabled = True
            dtpFecha.Enabled = True
            dtpHora.Enabled = True
            btnActualizar.Enabled = True
            dtpFecha.Format = DateTimePickerFormat.Long
            dtpHora.CustomFormat = "HH:mm"
            dtpHora.Format = DateTimePickerFormat.Custom
            Mostrar_TipoSorteo()

            txtID.Text = dataSorteo.SelectedCells.Item(0).Value
            dtpFecha.Text = Convert.ToString(dataSorteo.SelectedCells.Item(1).Value)
            dtpHora.Text = Convert.ToString(dataSorteo.SelectedCells.Item(1).Value)
            cboTipoSorteo.SelectedIndex = cboTipoSorteo.FindStringExact(dataSorteo.SelectedCells.Item(2).Value)

            ModoPantallaSorteo = ModoPantalla.ModoMODIFICACION

            HabilitarTextos(Me)

            txtID.Enabled = False
            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            btnCerrar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            dataSorteo.Enabled = False

            btnAgregar.Text = "Confirmar"
            btnModificar.Text = "Cancelar"

            dtpFecha.Focus()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        txtID.Text = dataSorteo.SelectedCells.Item(0).Value
        dtpFecha.Text = Convert.ToString(dataSorteo.SelectedCells.Item(1).Value)
        dtpHora.Text = Convert.ToString(dataSorteo.SelectedCells.Item(1).Value)
        cboTipoSorteo.SelectedIndex = cboTipoSorteo.FindStringExact(dataSorteo.SelectedCells.Item(2).Value)

        Dim Respuesta As Integer = MessageBox.Show("Atencion: ha seleccionado eliminar Agencia. " &
                                                   Environment.NewLine & "¿confirma la emiliminacion?", "eliminacion de tipos de sorteo",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        If Respuesta = MsgBoxResult.Yes Then
            Try
                Dim dts As New logSorteo
                Dim FuncionInsertar As New fSorteo

                dts.pID = txtID.Text

                If FuncionInsertar.Eliminar_Sorteo(dts) Then
                    Mostrar_Datos()
                    LimpiarTextos(Me)
                    inicia_pantalla()
                Else
                    MessageBox.Show("El sorteo no se ha eliminado. Vuelva a intentarlo.",
                                    "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Atencion: se ha generado un error tratando de Eliminar la Agencia." &
                                    Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnAgregarTipoSorteo_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoSorteo.Click
        frmTipoSorteo.MdiParent = frmPrincipal
        frmTipoSorteo.StartPosition = FormStartPosition.CenterScreen
        frmTipoSorteo.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Mostrar_TipoSorteo()
    End Sub
End Class