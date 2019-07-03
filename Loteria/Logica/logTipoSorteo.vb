Public Class logTipoSorteo
    Dim ID As Integer
    Dim Nombre, descripcion As String

    Public Property pID
        'declara el nombre de una propiedad y los procedimientos de propiedad usados para almacenar y recuperar el valor de la propiedad
        'la instruccion Property introduce la declaracion de una propiedad'
        'Una propiedad puede tener un procedimiento Get (solo lectura), un procedimiento set (solo escritura) o ambos (lectura y escritura)'
        Get 'Inicia un procedimiento de propiedad Get que se usa para devolver el valor de la propiedad'
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

    Public Property pDescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property

    Public Sub New()
        'ver hoja profe ahi hay una documentacion del proque este constructor vacio'
    End Sub
    Public Sub New(ByVal ID As Integer, ByVal Nombre As String, ByVal Descripcion As String)
        pID = ID
        pNombre = Nombre
        pDescripcion = Descripcion
    End Sub

End Class
