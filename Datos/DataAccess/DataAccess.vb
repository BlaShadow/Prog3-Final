Public Class DataAccess

    Private Shared _Session As usuario
    Public Shared Property Session() As usuario
        Get
            Return _Session
        End Get
        Set(ByVal value As usuario)
            _Session = value
        End Set
    End Property

    Public Shared Sub CargarChequeos()

    End Sub

    Public Shared Function AccesorioCategoria(id As Integer) As tipo_accesorio
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim result = From tipo In container.tipo_accesorio
                         Where tipo.id = id
                         Select tipo
            Return result.First
        End Using
    End Function

    Public Shared Sub DeleteAccesorioCategoria(id As Integer)
        Using container As New Chequeo_de_VehiculosEntities1()

            Dim item = DataAccess.AccesorioCategoria(id)
            container.tipo_accesorio.Attach(item)
            container.accesorios.RemoveRange(item.accesorios)
            container.tipo_accesorio.Remove(item)
            container.SaveChanges()
        End Using
    End Sub

    Public Shared Function Usuario(id As Integer) As usuario
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim result = From item In container.usuarios
                         Where item.id = id
                         Select item
            Return result.First
        End Using
    End Function

    Public Shared Sub DeleteUsuario(id As Integer)
        Using container As New Chequeo_de_VehiculosEntities1()

            Dim item = DataAccess.Usuario(id)
            container.usuarios.Attach(item)
            item.activo = False
            container.SaveChanges()
        End Using
    End Sub

    Public Shared Function Chequeo(id As Integer) As chequeo
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim result = From item In container.chequeos
                         Where item.id = id
                         Select item
            Return result.First
        End Using
    End Function

    Public Shared Sub DeleteVehiculo(id As Integer)
        Using container As New Chequeo_de_VehiculosEntities1()

            Dim item = DataAccess.Vehiculo(id)
            container.vehiculoes.Attach(item)
            item.activo = False
            container.SaveChanges()
        End Using
    End Sub

    Public Shared Function Vehiculo(id As Integer) As vehiculo
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim result = From item In container.vehiculoes
                         Where item.id = id
                         Select item
            Return result.First
        End Using
    End Function

    Public Shared Sub DeleteChequeo(id As Integer)
        Using container As New Chequeo_de_VehiculosEntities1()

            Dim item = DataAccess.Chequeo(id)
            container.chequeos.Attach(item)
            item.activo = False
            container.SaveChanges()
        End Using
    End Sub

    Public Shared Function Permiso(id As Integer) As permiso
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim result = From item In container.permisoes
                         Where item.id = id
                         Select item
            Return result.First
        End Using
    End Function

    Public Shared Sub DeletePermiso(id As Integer)
        Using container As New Chequeo_de_VehiculosEntities1()

            Dim item = DataAccess.Permiso(id)
            container.permisoes.Attach(item)
            item.activo = False
            container.SaveChanges()
        End Using
    End Sub

    Public Shared Function Accesorio(id As Integer) As accesorio
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim result = From item In container.accesorios
                         Where item.id = id
                         Select item
            Return result.First
        End Using
    End Function

    Public Shared Sub DeleteAccesorio(id As Integer)
        Using container As New Chequeo_de_VehiculosEntities1()

            Dim item = DataAccess.Accesorio(id)
            container.accesorios.Attach(item)
            container.accesorios.Remove(item)
            container.SaveChanges()
        End Using
    End Sub

End Class
