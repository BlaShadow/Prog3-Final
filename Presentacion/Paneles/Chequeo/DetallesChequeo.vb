Imports Datos

Public Class DetallesChequeo
    Private chequeoActual As Datos.chequeo
    Private vehiculo As Datos.vehiculo
    Private vehiculosChequeo As List(Of Datos.chequeo)

    Public Sub setChequeo(chequeo As Datos.chequeo)
        Me.chequeoActual = chequeo
        Me.vehiculo = DataAccess.Vehiculo(chequeo.id_vehiculo)
    End Sub

    Private Sub llenarInformacionInicial()

        Me.llenarChequeActual(Me.chequeoActual)

        Dim source = New BindingSource()
        Using context = New Chequeo_de_VehiculosEntities1()
            Dim queryResult = From item In context.chequeos.Include("vehiculo_estado")
                              Order By item.id Descending
                              Where item.id_vehiculo = Me.vehiculo.id
                              Select item

            Me.vehiculosChequeo = queryResult.ToList()
            Dim vehiculosChequeo = From chequeo In queryResult
                                   Select New With {
                                       Key .ID = chequeo.id,
                                       Key .Fecha = chequeo.fecha,
                                       Key .Estado = chequeo.vehiculo_estado.nombre,
                                       Key .Tipo = chequeo.tipo,
                                       Key .Detalles = chequeo.detalles
                                   }

            Dim chequeosSource = New BindingSource()
            chequeosSource.DataSource = vehiculosChequeo.ToList()

            llenarVehiculoActual()

            grid.DataSource = chequeosSource
        End Using
    End Sub

    Private Sub llenarChequeActual(chequeo As Datos.chequeo)
        lblTipo.Text = chequeo.tipo
        lblEstado.Text = chequeo.vehiculo_estado.nombre
        lblKilometraje.Text = chequeo.kilometraje.ToString()
        lblCombustible.Text = chequeo.combustible.ToString()
        lblDetalles.Text = chequeo.detalles
    End Sub

    Private Sub llenarVehiculoActual()
        lblAno.Text = Me.vehiculo.ano.ToString()
        lblColor.Text = Me.vehiculo.color
        lblMatricula.Text = Me.vehiculo.matricula
        lblModelo.Text = Me.vehiculo.modelo
        lblMarca.Text = Me.vehiculo.marca
        lblPuertas.Text = Me.vehiculo.puertas.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DetallesChequeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarInformacionInicial()

        llenarVehiculoActual()
    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        Dim row = grid.SelectedRows.Item(0)
        Dim selectedChequeo = Me.vehiculosChequeo.Item(row.Index)

        llenarChequeActual(selectedChequeo)
    End Sub
End Class