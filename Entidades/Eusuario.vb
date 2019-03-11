Public Class Eusuario
    Private Usuario As String
    Private Contraseña As String
    Private Niveles As String

    Public Property _Usuario
        Get
            Return Usuario

        End Get
        Set(value)
            Usuario = value
        End Set
    End Property

    Public Property _Contraseña
        Get
            Return Contraseña

        End Get
        Set(value)
            Contraseña = value
        End Set
    End Property

    Public Property _Niveles
        Get
            Return Niveles

        End Get
        Set(value)
            Niveles = value
        End Set
    End Property
    Public Sub New()

    End Sub

End Class
