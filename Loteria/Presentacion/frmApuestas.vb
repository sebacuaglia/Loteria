Public Class frmApuestas
    Private dt As New DataTable
    Private da As New DataTable
    Private dj As New DataTable
    Dim ModoPantallaApuesta As ModoPantalla

    Private Sub frmApuestas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Datos()
        inicia_pantalla()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub Mostrar_Datos()
        Try
            Dim FuncionMostrar As New fApuestas
            dt = FuncionMostrar.Mostrar_Apuesta

            If dt.Rows.Count <> 0 Then
                dataApuesta.DataSource = dt
            Else
                dataApuesta.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de mostrar las Apuestas." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub inicia_pantalla()
        txtID.Enabled = False
        DeshabilitarTextos(Me)
        DeshabilitarCombos(Me)


        If dt.Rows.Count = 0 Then
            btnCancelar.Enabled = False
            btnBuscar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            cboSorteo.Enabled = False
            cboAgencia.Enabled = False
            cboMonto.Enabled = False
            btnAgregar.Focus()
        Else
            btnCancelar.Enabled = False
            btnBuscar.Enabled = True
            cboBuscar.Enabled = True ': cboBuscar.SelectedIndex = 1
            cboTipoSorteo.Enabled = False
            cboSorteo.Enabled = False
            cboSorteo.SelectedIndex = -1
            cboAgencia.Enabled = False
            cboAgencia.SelectedIndex = -1
            cboMonto.Enabled = False
            txtBuscar.Enabled = True
            txtBuscar.Focus()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar_Datos()
    End Sub

    Private Sub Buscar_Datos()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)

            Dim dv As New DataView(ds.Tables(0))

            If cboBuscar.SelectedItem = "Nombre" Then
                dv.RowFilter = cboBuscar.Text & " Like '%" & txtBuscar.Text & "%'"
            Else
                If cboBuscar.SelectedItem = "Tiposorteo" Then
                    dv.RowFilter = cboBuscar.Text & " Like '%" & txtBuscar.Text & "%'"
                ElseIf cboBuscar.SelectedItem = "ID" Then
                    dv.RowFilter = cboBuscar.Text & " = " & txtBuscar.Text
                End If
            End If

            If dv.Count <> 0 Then
                dataApuesta.DataSource = dv
            Else
                dataApuesta.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de buscar las apuestas." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Agregar" Then
            ModoPantallaApuesta = ModoPantalla.ModoALTA
            LimpiarTextos(Me)
            HabilitarTextos(Me)

            Mostrar_NombreAgencia()
            Mostrar_TipoSorteo()
            Mostrar_SorteosHabilitados()

            txtID.Enabled = False
            btnBuscar.Enabled = False
            btnCerrar.Enabled = False
            cboBuscar.Enabled = False
            ' ComboBox1.Enabled = True
            txtBuscar.Enabled = False
            dataApuesta.Enabled = False
            cboAgencia.Enabled = True
            cboTipoSorteo.Enabled = True
            cboSorteo.Enabled = True
            cboMonto.Enabled = True

            btnAgregar.Text = "Confirmar"
            btnCancelar.Enabled = True
            txtNumero.Focus()
        Else
            cboTipoSorteo.Enabled = True
            cboSorteo.Enabled = True
            cboAgencia.Enabled = True
            btnCancelar.Enabled = False

            'validamos controles
            If cboAgencia.Text = "" Then
                ErrProvApuesta.SetError(cboAgencia, "No se ha seleccionado una agencia")
                cboAgencia.Focus()
                Exit Sub
            Else
                ErrProvApuesta.SetError(cboAgencia, String.Empty)
            End If
            If cboTipoSorteo.Text = "" Then
                ErrProvApuesta.SetError(cboTipoSorteo, "No se ha seleccionado un tipo de sorteo")
                cboTipoSorteo.Focus()
                Exit Sub
            Else
                ErrProvApuesta.SetError(cboTipoSorteo, String.Empty)
            End If
            If cboSorteo.Text = "" Then
                ErrProvApuesta.SetError(cboSorteo, "No se ha seleccionado un sorteo")
                cboSorteo.Focus()
                Exit Sub
            Else
                ErrProvApuesta.SetError(cboSorteo, String.Empty)
            End If
            If txtNumero.Text = "" Then
                ErrProvApuesta.SetError(txtNumero, "No se ha ingresado un numero")
                txtNumero.Focus()
                Exit Sub
            Else
                ErrProvApuesta.SetError(txtNumero, String.Empty)
            End If

            If ModoPantallaApuesta = ModoPantalla.ModoALTA Then
                Try
                    Dim dts As New logApuestas
                    Dim FuncionInsertar As New fApuestas
                    'AGREGO
                    dts.pID = FuncionInsertar.RetornaNumId
                    dts.pNUMERO = txtNumero.Text
                    dts.pMONTO = cboMonto.Text
                    dts.pIDSORTEO = cboSorteo.SelectedValue
                    dts.pIDAGENCIA = cboAgencia.SelectedValue

                    If FuncionInsertar.Insertar_Apuesta(dts) Then

                        LimpiarTextos(Me)
                        Mostrar_Datos()
                        inicia_pantalla()
                        cboTipoSorteo.Text = ""
                        cboMonto.Text = ""

                        btnAgregar.Text = "Agregar"
                        btnCerrar.Enabled = True
                        dataApuesta.Enabled = True
                    Else
                        MessageBox.Show("La apuesta no se ha registrado. Vuelva a intentarlo.",
                                    "Confirmar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Atencion: se ha generado un error tratando de registrar la apuesta." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If btnCancelar.Text = "Cancelar" Then
            ModoPantallaApuesta = ModoPantalla.ModoCONSULTA

            btnAgregar.Text = "Agregar"

            btnCerrar.Enabled = True
            dataApuesta.Enabled = True
            Mostrar_Datos()
            LimpiarTextos(Me)
            inicia_pantalla()
        End If
    End Sub

    Private Sub Mostrar_NombreAgencia()
        Try
            Dim FuncionMostrar As New fAgencia
            da = FuncionMostrar.Mostrar_Agencias

            If da.Rows.Count <> 0 Then
                cboAgencia.DataSource = da
                cboAgencia.DisplayMember = "Nombre"
                cboAgencia.ValueMember = "ID"
            Else
                cboAgencia.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar los nombre de la agencia." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar los tipos de sorteos en el combobox." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim entradas As Integer = 0
    Private Sub Mostrar_SorteosHabilitados()
        'al vambiar el tipo de sorteo se muestran los sorteos habilitados

        If entradas = 0 Or entradas = 1 Then
            entradas += 1
            Exit Sub
        Else
            Try
                Dim funcion As New fApuestas
                Dim dts As New logApuestas
                dts.pTIPOSORTEO = cboTipoSorteo.SelectedValue
                dj = funcion.MostrarSorteosHabilitados(DateTime.Now, dts)

                If dj.Rows.Count <> 0 Then
                    cboSorteo.DataSource = dj
                    cboSorteo.DisplayMember = "Fecha"
                    cboSorteo.ValueMember = "ID"
                Else
                    cboSorteo.DataSource = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar los sorteos." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cboTipoSorteo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoSorteo.SelectedIndexChanged
        If ModoPantallaApuesta <> ModoPantalla.ModoCONSULTA & ModoPantallaApuesta <> ModoPantalla.ModoMODIFICACION Then
            Mostrar_SorteosHabilitados()
        End If
    End Sub

    Private Sub dataApuesta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataApuesta.CellContentClick
        ModoPantallaApuesta = ModoPantalla.ModoCONSULTA
        Mostrar_TipoSorteo()
        txtID.Text = dataApuesta.SelectedCells.Item(0).Value
        cboTipoSorteo.SelectedIndex = cboTipoSorteo.FindString(dataApuesta.SelectedCells.Item(3).Value)
        cboSorteo.Text = dataApuesta.SelectedCells.Item(2).Value
        txtNumero.Text = dataApuesta.SelectedCells.Item(5).Value
        cboMonto.Text = dataApuesta.SelectedCells.Item(4).Value
        cboAgencia.Text = dataApuesta.SelectedCells.Item(1).Value
        cboSorteo.Enabled = False
    End Sub

End Class