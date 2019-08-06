Imports System.Data.SqlClient
Public Class fSortear
    Inherits clsConexion
    Dim cmd As SqlCommand

    Public Function Mostrar_Resultados(ByVal dts As logSortear) As DataTable

        Try
            If funcConectarDB() Then
                cmd = New SqlCommand("MostrarResultadosSorteos") 'Resultados del sorteo (posicion y numero)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = CNN

                cmd.Parameters.AddWithValue("@IDSorteo", dts.pIDSorteo)

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
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar los resultados del sorteo seleccionado." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Mostrar_Ganadores(ByVal dts As logSortear) As DataTable
        'funcion que carga en memoria la tabla Apuestas
        Try
            If funcConectarDB() Then
                cmd = New SqlCommand("MostrarGanadores")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = CNN

                cmd.Parameters.AddWithValue("@IDSORTEO", dts.pIDSorteo)

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
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar los ganadores del sorteo seleccionado." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Insertar_Sorteados(ByVal dts As logSortear) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("InsertarSorteados")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@IDSorteo", dts.pIDSorteo)
            cmd.Parameters.AddWithValue("@Numero", dts.pNumero)
            cmd.Parameters.AddWithValue("@Posicion", dts.pPosicion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de registrar los resultados del sorteo." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

End Class
