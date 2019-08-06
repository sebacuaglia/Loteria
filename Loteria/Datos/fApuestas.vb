Imports System.Data.SqlClient
Public Class fApuestas
    Inherits clsConexion
    Dim cmd As SqlCommand
    Dim ultId As Integer
    Public Function Mostrar_Apuesta() As DataTable
        'funcion que carga en memoria la tabla Apuesta
        Try
            If funcConectarDB() Then
                cmd = New SqlCommand("MostrarApuestas")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = CNN

                cmd.Parameters.AddWithValue("@datetime", DateTime.Now)
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
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar las apuestas." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Insertar_Apuesta(ByVal dts As logApuestas) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("InsertarApuesta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@ID", dts.pID)
            cmd.Parameters.AddWithValue("@IDAGENCIA", dts.pIDAGENCIA)
            cmd.Parameters.AddWithValue("@IDSORTEO", dts.pIDSORTEO)
            cmd.Parameters.AddWithValue("@NUMERO", dts.pNUMERO)
            cmd.Parameters.AddWithValue("@MONTO", dts.pMONTO)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: No se ha podido registrar la apuesta." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Modificar_Apuesta(ByVal dts As logApuestas) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("EditarApuesta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@ID", dts.pID)
            cmd.Parameters.AddWithValue("@IDAPUESTA", dts.pID)
            cmd.Parameters.AddWithValue("@IDAGENCIA", dts.pIDAGENCIA)
            cmd.Parameters.AddWithValue("@NUMERO", dts.pNUMERO)
            cmd.Parameters.AddWithValue("@MONTO", dts.pMONTO)
            cmd.Parameters.AddWithValue("@IDSORTEO", dts.pIDSORTEO)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de registrar las modificaciones de la apuesta seleccionada." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Eliminar_Apuesta(ByVal dts As logApuestas) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("EliminarApuesta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@id", dts.pID)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de eliminar la apuesta seleccionada." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function MostrarSorteosHabilitados(ByVal fecha As DateTime, ByVal dts As logApuestas) As DataTable
        'ver!!!!!!!!

        'funcion que carga en memoria la tabla Apuesta
        Try
            If funcConectarDB() Then
                cmd = New SqlCommand("MostrarSorteosHabilitados")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = CNN
                cmd.Parameters.AddWithValue("@Datetime", fecha)
                cmd.Parameters.AddWithValue("@TipoSorteo", dts.pTIPOSORTEO)

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
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Mostrar_NombreTipoSorteos() As DataTable

        'ver!!!!!!!

        'funcion que carga en memoria la tabla Apuesta
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
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar el nombre de tipo de sorteo." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function RetornaNumId() As Integer
        Dim dt As New DataTable
        Dim id As Integer
        Try
            If funcConectarDB() Then
                cmd = New SqlCommand("RetornaID")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = CNN

                If cmd.ExecuteNonQuery Then

                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)

                    id = dt.Rows.Count + 2
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar el nombre de la agencia" &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Finally
            funcCerrarConnDB()
        End Try
        Return id
    End Function 'falta autoincremento en db por eso se crea este lento proceso :'(    

End Class
