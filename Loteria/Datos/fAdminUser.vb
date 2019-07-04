Imports System.Data.SqlClient

Public Class fAdminUser
    Inherits clsConexion 'la clase o interfaz actual heredan los atributos, variables, propiedades, procedimientos y eventos de otra clase o conjunto de interfaces
    Dim cmd As SqlCommand

    Public Function mostrar_Usuarios() As DataTable
        'funcion que caragara en memoria la tabla TipoSorteo

        Try
            funcConectarDB()
            cmd = New SqlCommand("procMostrar_Usuario")
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
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de mostrar los tipos de sorteo" +
                            Environment.NewLine + "Descripcion del error: " +
                            Environment.NewLine +
                            ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function insertar_tipoSorteo(ByVal dts As logTipoSorteo) As Boolean
        'la funcion retornara verdadero si se inserta ok en el registro sino devolvera falso'

        Try
            funcConectarDB()
            cmd = New SqlCommand("Insertar_TipoSorteo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@Nombre", dts.pNombre)
            cmd.Parameters.AddWithValue("@Descripcion", dts.pDescripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de registrar el tipo de sorteo." & Environment.NewLine &
                            "Descripcion del error: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function
    Public Function Eliminar_tipoSorteo(ByVal dts As logTipoSorteo) As Boolean
        'la funcion retornara verdadero si se elimina el registro sino devolvera falso'

        Try
            funcConectarDB()
            cmd = New SqlCommand("Eliminar_TipoSorteo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@ID", dts.pID)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error tratando de eliminar el tipo de sorteo." & Environment.NewLine &
                            "Descripcion del error: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Modificar_TipoSorteo(ByVal dts As logTipoSorteo) As Boolean
        'La función retornará VERDADERO si se actualiza ok el registro. 'Sino, devolverá FALSO.
        Try
            funcConectarDB()
            cmd = New SqlCommand("EDITAR_TipoSorteo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN
            cmd.Parameters.AddWithValue("@ID", dts.pID)
            cmd.Parameters.AddWithValue("@Nombre", dts.pNombre)
            cmd.Parameters.AddWithValue("@Descripcion", dts.pDescripcion)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de registrar el tipo de sorteo." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function
End Class
