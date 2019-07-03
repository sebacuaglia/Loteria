Public Class frmAgencia
    Private dt As New DataTable
    Dim ModoPantallaAgencias As ModoPantalla

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Mostrar_Datos()
        Try
            Dim FuncionMostrar As New fAgencia
            dt = FuncionMostrar.Mostrar_Agencias

            If dt.Rows.Count <> 0 Then
                DataAgencia.DataSource = dt
            Else
                DataAgencia.DataSource = Nothing
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

    Private Sub frmAgencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Datos()
        inicia_pantalla()
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
                DataAgencia.DataSource = dv
            Else
                DataAgencia.DataSource = Nothing
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
            ' Dim funcion As New fAgencia
            HabilitarTextos(Me)

            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            btnCerrar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            DataAgencia.Enabled = False
            txtID.Enabled = False

            btnAgregar.Text = "Confirmar"
            btnModificar.Text = "Cancelar"

            txtNombre.Focus()
        Else
            'validamos controles
            If txtNombre.Text = "" Then
                MsgBox("No ha ingresado un nombre para la agencia", MsgBoxStyle.Exclamation)
                'MsgBox("Ingrese un nombre de agencia")
                'ErrProvAgencias.SetError(txtNombre, "Debe ingresar un nombre para el Tipo de Sorteo")
                txtNombre.Focus()
                Exit Sub
            End If
            If txtGanancia.Text = "" Then
                MsgBox("No ha ingresado un porcentaje de ganancias", MsgBoxStyle.Exclamation)
                'ErrProvAgencias.SetError(txtGanancia, "Debe ingresar el porcentaje de ganancias")
                txtGanancia.Focus()
                Exit Sub
            End If


            If ModoPantallaAgencias = ModoPantalla.ModoALTA Then
                Try
                    Dim funcion As New fAgencia
                    Dim dts As New logAgencia
                    Dim FuncionInsertar As New fAgencia

                    'dts.pID = txtID.Text
                    dts.pNombre = txtNombre.Text
                    dts.pGanancia = txtGanancia.Text

                    If FuncionInsertar.Insertar_Agencia(dts) Then
                        Mostrar_Datos()
                        LimpiarTextos(Me)
                        inicia_pantalla()

                        btnAgregar.Text = "Agregar"
                        btnModificar.Text = "Modificar"
                        btnCerrar.Enabled = True
                        DataAgencia.Enabled = True
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
                    Dim dts As New logAgencia
                    Dim FuncionInsertar As New fAgencia

                    dts.pID = txtID.Text
                    dts.pNombre = txtNombre.Text
                    dts.pGanancia = txtGanancia.Text

                    If FuncionInsertar.Modificar_Agencia(dts) Then
                        Mostrar_Datos()
                        LimpiarTextos(Me)
                        inicia_pantalla()

                        btnAgregar.Text = "Agregar"
                        btnModificar.Text = "Modificar"
                        btnCerrar.Enabled = True
                        DataAgencia.Enabled = True
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


    'validar que solo ingrese numeros
    Private Sub txtGanancia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGanancia.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = ","
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = "," And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub

    Private Sub dataAgencia_CellClick(sender As Object, e As DataGridViewCellEventArgs) 'Handles DataAgencia.CellClick
        txtID.Text = DataAgencia.SelectedCells.Item(0).Value
        txtNombre.Text = DataAgencia.SelectedCells.Item(1).Value
        txtGanancia.Text = DataAgencia.SelectedCells.Item(2).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If btnModificar.Text = "Cancelar" Then
            ModoPantallaAgencias = ModoPantalla.ModoCONSULTA

            inicia_pantalla()

            btnAgregar.Text = "Agregar"
            btnModificar.Text = "Modificar"

            btnCerrar.Enabled = True
            DataAgencia.Enabled = True
            ErrProvAgencia.SetError(txtNombre, "")
        Else
            ModoPantallaAgencias = ModoPantalla.ModoMODIFICACION

            txtID.Text = DataAgencia.SelectedCells.Item(0).Value
            txtNombre.Text = DataAgencia.SelectedCells.Item(1).Value
            txtGanancia.Text = DataAgencia.SelectedCells.Item(2).Value

            HabilitarTextos(Me)

            txtID.Enabled = False
            btnEliminar.Enabled = False
            btnBuscar.Enabled = False
            btnCerrar.Enabled = False
            cboBuscar.Enabled = False
            txtBuscar.Enabled = False
            DataAgencia.Enabled = False

            btnAgregar.Text = "Confirmar"
            btnModificar.Text = "Cancelar"

            txtNombre.Focus()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Respuesta As Integer = MessageBox.Show("Atencion: ha seleccionado eliminar Agencia. " &
                                                   Environment.NewLine & "¿confirma la eliminacion?", "eliminacion de Agencias",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        If Respuesta = MsgBoxResult.Yes Then
            Try
                Dim dts As New logAgencia
                Dim FuncionInsertar As New fAgencia

                txtID.Text = DataAgencia.SelectedCells.Item(0).Value

                dts.pID = txtID.Text

                If FuncionInsertar.Eliminar_Agencia(dts) Then
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

    Private Sub cboBuscar_TextChanged(sender As Object, e As EventArgs) Handles cboBuscar.TextChanged
        txtBuscar.Text = ""
    End Sub
End Class