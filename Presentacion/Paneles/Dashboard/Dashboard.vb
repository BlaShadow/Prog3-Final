Imports Datos

Public Class Dashboard
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using container = New Chequeo_de_VehiculosEntities1()
            Dim averias = From item In container.chequeos
                          Where item.id_estado = 1
                          Order By item.id Descending
                          Select New With {
                               Key .ID = item.id,
                               Key .Fecha = item.fecha,
                               Key .Vehiculo = item.vehiculo.matricula,
                               Key .Estado = item.vehiculo_estado.nombre,
                               Key .Tipo = item.tipo,
                               Key .Detalles = item.detalles
                           }

            Dim source = New BindingSource()
            source.DataSource = averias.ToList()

            gridAverias.DataSource = source

            Dim now = DateTime.Now
            Dim fecha = New DateTime(now.Year, now.Month, now.Day)
            Dim permisos = From item In container.vehiculo_permiso
                           Where item.vencimiento > fecha
                           Order By item.vencimiento Ascending
                           Select New With {
                                Key .Fecha = item.vencimiento,
                                Key .Marca = item.vehiculo.marca,
                                Key .Modelo = item.vehiculo.modelo,
                                Key .Matricula = item.vehiculo.matricula
                               }

            Dim permisosSource = New BindingSource()
            permisosSource.DataSource = permisos.ToList()

            permisosGrid.DataSource = permisosSource

            llenarLabels()
        End Using
    End Sub

    Private Sub llenarLabels()
        Using container = New Chequeo_de_VehiculosEntities1()
            Dim now = DateTime.Now
            Dim limitDate = New DateTime(now.Year, now.Month, now.Day)
            lblChequeos.Text = (From item In container.chequeos
                                Where item.fecha > limitDate
                                Select item).Count.ToString()
            lblEntrada.Text = (From item In container.chequeos
                               Where item.tipo = "ENTRADA"
                               Select item).Count.ToString()
            lblSalida.Text = (From item In container.chequeos
                              Where item.tipo = "SALIDA"
                              Select item).Count.ToString()

            lblVehiculos.Text = container.vehiculoes.Count.ToString()
        End Using
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblVehiculos.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblChequeos.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class