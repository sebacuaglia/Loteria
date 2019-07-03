Imports System.Data.SqlClient

Public Class fAgencia
    Inherits clsConexion
    Dim cmd As SqlCommand

    Public Function Mostrar_Agencias() As DataTable
        Try
            If funcConectarDB() Then
                cmd = New SqlCommand("procMostrar_Agencia")
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
            MessageBox.Show("No se han podido mostrar las agencias." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Insertar_Agencia(ByVal dts As logAgencia) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("InsertarAgencia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            'cmd.Parameters.AddWithValue("@ID", dts.pID)
            cmd.Parameters.AddWithValue("@Nombre", dts.pNombre)
            cmd.Parameters.AddWithValue("@Porc_ganancia", dts.pGanancia)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar registrar una agencia" &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Modificar_Agencia(ByVal dts As logAgencia) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("EditarAgencia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@ID", dts.pID)
            cmd.Parameters.AddWithValue("@Nombre", dts.pNombre)
            cmd.Parameters.AddWithValue("@Porc_ganancia", dts.pGanancia)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de modificar la Agencia seleccionada." &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Eliminar_Agencia(ByVal dts As logAgencia) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("EliminarAgencia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@ID", dts.pID)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("No se ha podido eliminar la agencia seleccionada" &
                            Environment.NewLine & "Descripcion del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function
End Class
