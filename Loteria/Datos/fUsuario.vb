Imports System.Data.SqlClient

Public Class fUsuario
    Inherits clsConexion
    Dim cmd As SqlCommand

    Public Function Validar_Usuario(dts As LogUsuario) As Boolean
        Try
            funcConectarDB()
            cmd = New SqlCommand("Validar_Usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = CNN

            cmd.Parameters.AddWithValue("@Login", dts.pLogin)
            cmd.Parameters.AddWithValue("@Passw", dts.pPassword)

            Dim dr As SqlDataReader 'Esta clase proporciona una forma de leer una secuencia de filas sola hacia adelante en una base de datos de sql server'

            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de validar los datos del usuario." +
                    Environment.NewLine + "Descripción del error" + Environment.NewLine +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            funcCerrarConnDB()
        End Try
    End Function
End Class
