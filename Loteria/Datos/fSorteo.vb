Imports System.Data.SqlClient
Public Class fSorteo
    Inherits clsConexion
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
            MessageBox.Show("Atencion: se ha generado un error tratando de mostrar los Sorteos." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
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

            'cmd.Parameters.AddWithValue("@ID", dts.pID)
            cmd.Parameters.AddWithValue("@FECHA", dts.pFechaHora)
            cmd.Parameters.AddWithValue("@IDTIPOSORTEO", dts.pIDTipoSorteo)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de registrar el Sorteo." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
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
            MessageBox.Show("Atencion: se ha generado un error tratando de modificar el Sorteo." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
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
            MessageBox.Show("Atencion: se ha generado un error tratando de eliminar el Sorteo." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
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
            MessageBox.Show("Atencion: se ha generado un error tratando de mostrar los nombres de los tipos de sorteos." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

End Class
