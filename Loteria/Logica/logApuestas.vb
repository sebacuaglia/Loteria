Public Class logApuestas
    Dim ID As Integer
    Dim NUMERO, MONTO, TIPOSORTEO, IDSORTEO, IDAGENCIA As String

    Public Property pID
        Get
            Return ID
        End Get
        Set(value)
            ID = value
        End Set
    End Property

    Public Property pIDAGENCIA
        Get
            Return IDAGENCIA
        End Get
        Set(Value)
            IDAGENCIA = Value
        End Set
    End Property

    Public Property pIDSORTEO
        Get
            Return IDSORTEO
        End Get
        Set(value)
            IDSORTEO = value
        End Set
    End Property

    Public Property pTIPOSORTEO
        Get
            Return TIPOSORTEO
        End Get
        Set(value)
            TIPOSORTEO = value
        End Set
    End Property

    Public Property pNUMERO
        Get
            Return NUMERO
        End Get
        Set(value)
            NUMERO = value
        End Set
    End Property

    Public Property pMONTO
        Get
            Return MONTO
        End Get
        Set(value)
            MONTO = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal ID As Integer, ByVal IDSORTEO As String, ByVal NUMERO As String, ByVal TIPOSORTEO As String, ByVal MONTO As String, ByVal IDAGENCIA As String)
        pID = ID
        pNUMERO = NUMERO
        pMONTO = MONTO
        pTIPOSORTEO = TIPOSORTEO
        pIDSORTEO = IDSORTEO
        pIDAGENCIA = IDAGENCIA
    End Sub
End Class
