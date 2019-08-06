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
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de mostrar los usuarios." +
                            Environment.NewLine + "Descripcion del error: " +
                            Environment.NewLine +
                            ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function ValidarLogin(ByVal dts As logAdminUser)
        'busco si el login nuevo ya existe
        Try
            funcConectarDB()
            cmd = New SqlCommand("ValidarLogin")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@id", dts.pID)
            cmd.Parameters.AddWithValue("@Login", dts.pLogin)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)

                da.Fill(dt)

                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de registrar el nuevo usuario." & Environment.NewLine &
                            "Descripcion del error: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function insertar_Usuario(ByVal dts As LogAdminUser) As Boolean
        'la funcion retornara verdadero si se inserta ok en el registro sino devolvera falso'
        Try
            funcConectarDB()
            cmd = New SqlCommand("Insertar_Usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@NombreUsu", dts.pNombreUsu)
            cmd.Parameters.AddWithValue("@Login", dts.pLogin)
            cmd.Parameters.AddWithValue("@Password", dts.pPassword)
            cmd.Parameters.AddWithValue("@habilitado", dts.pHabilitado)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de registrar el nuevo usuario." & Environment.NewLine &
                            "Descripcion del error: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function
    Public Function Eliminar_Usuario(ByVal dts As LogAdminUser) As Boolean
        'la funcion retornara verdadero si se elimina el registro sino devolvera falso'

        Try
            funcConectarDB()
            cmd = New SqlCommand("Eliminar_Usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@ID", dts.pID)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de eliminar el usuario selecionado." & Environment.NewLine &
                            "Descripcion del error: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function

    Public Function Modificar_Usuario(ByVal dts As LogAdminUser) As Boolean
        'La función retornará VERDADERO si se actualiza ok el registro. 'Sino, devolverá FALSO.
        Try
            funcConectarDB()
            cmd = New SqlCommand("EDITAR_Usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@ID", dts.pID)
            cmd.Parameters.AddWithValue("@NombreUsu", dts.pNombreUsu)
            cmd.Parameters.AddWithValue("@Login", dts.pLogin)
            cmd.Parameters.AddWithValue("@Password", dts.pPassword)
            cmd.Parameters.AddWithValue("@habilitado", dts.pHabilitado)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de registrar las modificaciones del usuario seleccionado." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function
End Class
