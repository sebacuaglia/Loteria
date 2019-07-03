Public Class LogUsuario
    Dim ID As Integer
    Dim nombreUsu, Login, Password As String
    Dim Habilitado As Byte

    Public Property pID
        Get
            Return ID
        End Get
        Set(value)
            ID = value
        End Set
    End Property

    Public Property pNombreUsu
        Get
            Return nombreUsu
        End Get
        Set(value)
            nombreUsu = value
        End Set
    End Property

    Public Property pLogin
        Get
            Return Login
        End Get
        Set(value)
            Login = value
        End Set
    End Property

    Public Property pPassword
        Get
            Return Password
        End Get
        Set(value)
            Password = value
        End Set
    End Property

    Public Property pHabilitado
        Get
            Return Habilitado
        End Get
        Set(value)
            Habilitado = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal ID As Integer, ByVal NombreUsu As String, ByVal Login As String, ByVal password As String, ByVal Habilitado As Byte)
        pID = ID
        pNombreUsu = NombreUsu
        pLogin = Login
        pPassword = password
        pHabilitado = Habilitado
    End Sub
End Class
