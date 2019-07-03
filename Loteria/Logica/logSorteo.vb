Public Class logSorteo
    Dim ID As Integer
    Dim IDTipoSorteo As String
    Dim FechaHora As String

    Public Property pID
        Get
            Return ID
        End Get
        Set(value)
            ID = value
        End Set
    End Property

    Public Property pIDTipoSorteo
        Get
            Return IDTipoSorteo
        End Get
        Set(value)
            IDTipoSorteo = value
        End Set
    End Property

    Public Property pFechaHora
        Get
            Return FechaHora
        End Get
        Set(value)
            FechaHora = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal ID As Integer, ByVal FechaHora As DateTime, ByVal IDTipoSorteo As String)
        pID = ID
        pFechaHora = FechaHora
        pIDTipoSorteo = IDTipoSorteo
    End Sub
End Class