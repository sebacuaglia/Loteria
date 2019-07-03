Public Class logAgencia
    Dim ID As Integer
    Dim Nombre As String
    Dim Ganancia As Double

    Public Property pID
        Get
            Return ID
        End Get
        Set(value)
            ID = value
        End Set
    End Property

    Public Property pNombre
        Get
            Return Nombre
        End Get
        Set(value)
            Nombre = value
        End Set
    End Property

    Public Property pGanancia
        Get
            Return Ganancia
        End Get
        Set(value)
            Ganancia = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal ID As Integer, ByVal Nombre As String, ByVal Ganancia As Double)
        pID = ID
        pNombre = Nombre
        pGanancia = Ganancia
    End Sub
End Class
