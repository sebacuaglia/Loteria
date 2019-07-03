Public Class frmTipoSorteo
    Private dt As New DataTable
    Dim ModoPantalla As ModoPantalla

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'frmPrincipal.Show()
        Close()
    End Sub

    Private Sub Mostrar_Datos()
        Try
            Dim FuncionMostrar As New fTipoSorteo
            dt = FuncionMostrar.mostrar_TipoSorteo

            If dt.Rows.Count <> 0 Then
                dataTipoSorteo.DataSource = dt
            Else
                dataTipoSorteo.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tartando de mostrar los tipos de sorteo" +
                Environment.NewLine + "Descripcion del error" +
                Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Inicia_Pantalla()
        DeshabilitarTextos(Me)
        DeshabilitarCombos(Me)

        If dt.Rows.Count = 0 Then
            'AL no encontrar datos en la tabla [TipoSorteo]
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
            Dim ds As New DataSet 'Representa una memoria caché de datos en memoria
            ds.Tables.Add(dt.Copy) ' Se realiza una copia de la tabla en memoria

            Dim dv As New DataView(ds.Tables(0))
            'DataView representa una vista personalizada que puede enlazar datos de una DataTable para
            'Ordenacion, filtrado, busqueda, edicion y navegacion
            'El DataView no almacena datos, sino que representa una vista conectada al dataTable correspondiente
            'Los cambios en los datos de DataView afectaran a DataTable
            'Los cambios en los datos de DataTable afectaran a toda los data...
            If cboBuscar.SelectedItem = "Nombre" Then
                dv.RowFilter = cboBuscar.Text & " Like '%" & txtBuscar.Text & "%'"
            Else
                dv.RowFilter = cboBuscar.Text & " = " & txtBuscar.Text
            End If

            If dv.Count <> 0 Then
                dataTipoSorteo.DataSource = dv
            Else
                dataTipoSorteo.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tartando de mostrar los tipos de sorteo." +
                Environment.NewLine + "Descripcion del error" + Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmTipoSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Datos()
        Inicia_Pantalla()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar_Datos()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Agregar" Then
            ModoPantalla = ModoPantalla.ModoALTA
            LimpiarTextos(Me)
            HabilitarTextos(Me)

            'Deshabilitar los objetos que no pueden ser utilizados mientras el form esta en estado alta'
            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            btnCerrar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            dataTipoSorteo.Enabled = False
            txtID.Enabled = False
            'El botoon agregar pasa a ser confirmar'
            'el boton modificar pasa a ser cancelar'

            btnAgregar.Text = "Confirmar"
            btnModificar.Text = "Cancelar"

            txtNombre.Focus()

        Else
            'Validamos los controles'
            If txtNombre.Text = "" Then
                ErrProvTipoSorteo.SetError(txtNombre, "Debe Ingresar un nombre para el tipo de sorteo")
                txtNombre.Focus()
                Exit Sub
            Else
                ErrProvTipoSorteo.SetError(txtNombre, "")
            End If
            If ModoPantalla = ModoPantalla.ModoALTA Then
                Try
                    Dim dts As New logTipoSorteo
                    Dim FuncionInsertar As New fTipoSorteo

                    dts.pNombre = txtNombre.Text
                    dts.pDescripcion = txtDescripcion.Text

                    If FuncionInsertar.insertar_TipoSorteo(dts) Then
                        Mostrar_Datos()
                        LimpiarTextos(Me)
                        Inicia_Pantalla()


                        btnAgregar.Text = "Agregar"
                        btnModificar.Text = "Modificar"
                        btnCerrar.Enabled = True
                        dataTipoSorteo.Enabled = True
                    Else
                        MessageBox.Show("El tipo de sorteo no se ha registrado. vuelva a intentarlo.", "Confirmar registros", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Atencion: se ha generado un error tartando de registrar el tipos de sorteo." +
                    Environment.NewLine + "Descripcion del error" + Environment.NewLine +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf ModoPantalla = ModoPantalla.ModoMODIFICACION Then
                Try
                    Dim dts As New logTipoSorteo
                    Dim FuncionInsertar As New fTipoSorteo

                    dts.pID = txtID.Text
                    dts.pNombre = txtNombre.Text
                    dts.pDescripcion = txtDescripcion.Text
                    If FuncionInsertar.Modificar_TipoSorteo(dts) Then
                        Mostrar_Datos()
                        LimpiarTextos(Me)
                        Inicia_Pantalla()
                        btnAgregar.Text = "Agregar"
                        btnModificar.Text = "Modificar"
                        btnCerrar.Enabled = True
                        dataTipoSorteo.Enabled = True
                    Else
                        MessageBox.Show("El tipo de sorteo no se ha modificado. Vuelva a intentarlo.",
                                        "Confirmar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Atención: se ha generado un error tratando de modificar el tipo de sorteo." &
                                    Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Cancelar" Then
            ModoPantalla = ModoPantalla.ModoCONSULTA
            Inicia_Pantalla()
            btnAgregar.Text = "Agregar"
            btnModificar.Text = "Modificar"
            btnCerrar.Enabled = True
            dataTipoSorteo.Enabled = True
            ErrProvTipoSorteo.SetError(txtNombre, "")
        Else
            ModoPantalla = ModoPantalla.ModoMODIFICACION
            txtID.Text = dataTipoSorteo.SelectedCells.Item(0).Value

            HabilitarTextos(Me)
            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            btnCerrar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            dataTipoSorteo.Enabled = False
            btnAgregar.Text = "Confirmar"
            btnModificar.Text = "Cancelar"
            txtNombre.Focus()

        End If
    End Sub

    Private Sub dataTipoSorteo_cellClick(sender As Object, e As DataGridViewCellEventArgs)
        txtID.Text = dataTipoSorteo.SelectedCells.Item(0).Value
        txtNombre.Text = dataTipoSorteo.SelectedCells.Item(1).Value
        txtDescripcion.Text = dataTipoSorteo.SelectedCells.Item(2).Value
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As Integer = MessageBox.Show("Atencion: ha seleccionado eliminar un tipo de sorteo" + Environment.NewLine + "Confirma la eliminacion?", "eliminacion de tipo de sorteo", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        If respuesta = MsgBoxResult.Yes Then
            Try
                Dim dts As New logTipoSorteo
                Dim funcionInsertar As New fTipoSorteo

                dts.pID = txtID.Text

                If funcionInsertar.Eliminar_tipoSorteo(dts) Then
                    Mostrar_Datos()
                    LimpiarTextos(Me)
                    Inicia_Pantalla()

                Else
                    MessageBox.Show("El tipo de sorteo no se ha eliminado. vuelva a intentarlo", "Eliminar registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Atencion se ha generado un error tratando de eliminar el tipo de sorteo." + Environment.NewLine + "Descripcion del error: " + Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class