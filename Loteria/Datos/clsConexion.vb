Imports System.Data.SqlClient

Public Class clsConexion
    Protected CNN As New SqlConnection
    'Representa una conexion a una base de datos SQL Server'
    'Protected especifica que solo se puede obtener acceso a uno o varios elementos de programas'
    Const strConexion As String = "Data Source=DESKTOP-FR0KGNS;User=sa;Password=7322;Initial Catalog=Loteria;Integrated Security=False"

    Public Sub New()

    End Sub

    Protected Function funcConectarDB() As Boolean
        'FUNCION QUE ESTABLECE LA CONEXION CON LA BASE DE DATOS, AL CONECTARSE DEVUELVE VERDADERO, SI NO SE CONECTA, DEVUELVE FALSO'
        Try
            CNN = New SqlConnection(strConexion)
            CNN.Open() 'abrimos la conexion'
            Return True
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de establecer la conexión con la base de datos" &
                            Environment.NewLine & "Descripcion del error: " &
                            Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Protected Function funcCerrarConnDB() As Boolean
        'Funcion que cierra la conexion con la base de datos. al cerrar devuelve VERDADERO. Si no se cierra, duvuelve FALSO'
        Try
            If CNN.State = ConnectionState.Open Then
                CNN.Close()
                Return True
            ElseIf CNN.State = ConnectionState.Closed Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("ATENCIÓN: se ha generado un error tratando de cerrar la " +
                            "conexión con la base de datos." &
                            Environment.NewLine & "Descripción del error: " &
                            Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try


    End Function
End Class

