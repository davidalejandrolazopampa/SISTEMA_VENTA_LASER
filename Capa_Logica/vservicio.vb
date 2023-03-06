Public Class vservicio
    Dim idservicio, idclinete, idproducto As Integer
    Dim descripcion As String
    Dim fecha_servicio As Date
    Public Property gidservicio
        Get
            Return idservicio
        End Get
        Set(ByVal value)
            idservicio = value
        End Set
    End Property
    Public Property gidcliente
        Get
            Return idclinete
        End Get
        Set(ByVal value)
            idclinete = value
        End Set
    End Property
    Public Property gidproducto
        Get
            Return idproducto
        End Get
        Set(ByVal value)
            idproducto = value
        End Set
    End Property
    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property
    Public Property gfecha_servicio
        Get
            Return fecha_servicio
        End Get
        Set(ByVal value)
            fecha_servicio = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(ByVal idservicio As Integer, ByVal idproducto As Integer, ByVal idcliente As Integer, ByVal descripcion As String, ByVal fecha_servicio As Date)
        gidservicio = idservicio
        gidcliente = idcliente
        gidproducto = idproducto
        gdescripcion = descripcion
        gfecha_servicio = fecha_servicio

    End Sub
End Class
