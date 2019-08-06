Imports System.Data.SqlClient
Public Class fSorteo
    Inherits clsConexion

    Friend Buscar_NombreTipoSorteos As DataTable
    Dim cmd As SqlCommand

    Public Function Mostrar_Sorteo() As DataTable
        'funcion que carga en memoria la tabla Agencias
        Try
            If funcConectarDB() Then
                cmd = New SqlCommand("MostrarSorteos")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = CNN

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(cmd)

                    da.Fill(dt)

                    Return dt
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar los sorteos." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Insertar_Sorteo(ByVal dts As logSorteo) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("InsertarSorteo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@FECHA", dts.pFechaHora)
            cmd.Parameters.AddWithValue("@IDTIPOSORTEO", dts.pIDTipoSorteo)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de registrar el sorteo." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Modificar_Sorteo(ByVal dts As logSorteo) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("EditarSorteo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@ID", dts.pID)
            cmd.Parameters.AddWithValue("@FECHA", dts.pFechaHora)
            cmd.Parameters.AddWithValue("@IDTIPOSORTEO", dts.pIDTipoSorteo)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de registrar las modificaciones del sorteo seleccionado." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Eliminar_Sorteo(ByVal dts As logSorteo) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("EliminarSorteo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@ID", dts.pID)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de eliminar el sorteo seleccionado." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Mostrar_NombreTipoSorteos() As DataTable
        'funcion que carga en memoria los tipos de sorteos
        Try
            If funcConectarDB() Then
                cmd = New SqlCommand("MostrarNombreTipoSorteo")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = CNN

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar los nombres de los tipos de sorteos." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function
End Class
