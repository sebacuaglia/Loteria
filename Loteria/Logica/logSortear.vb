Public Class logSortear
    Dim ID, IDSorteo, Numero, Posicion As Integer
    Public Property pID
        Get
            Return ID
        End Get
        Set(value)
            ID = value
        End Set
    End Property

    Public Property pIDSorteo
        Get
            Return IDSorteo
        End Get
        Set(value)
            IDSorteo = value
        End Set
    End Property

    Public Property pNumero
        Get
            Return Numero
        End Get
        Set(value)
            Numero = value
        End Set
    End Property

    Public Property pPosicion
        Get
            Return Posicion
        End Get
        Set(value)
            Posicion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal ID As Integer, ByVal Numero As Integer, ByVal Posicion As Integer, ByVal IDSorteo As Integer)
        pID = ID
        pNumero = Numero
        pPosicion = Posicion
        pIDSorteo = IDSorteo
    End Sub
End Class
