Imports Datos

Public Class Vehiculos
    Private Sub Vehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.llenarTablaVehiculos()
    End Sub

    Private Sub llenarTablaVehiculos()
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim vehiculos = From vehiculo In container.vehiculoes
                            Where vehiculo.activo = True
                            Order By vehiculo.id Descending
                            Select New With {
                                Key .ID = vehiculo.id,
                                Key .Matricula = vehiculo.matricula,
                                Key .Marca = vehiculo.marca,
                                Key .Modelo = vehiculo.modelo,
                                Key .Color = vehiculo.color
                            }

            Dim source = New BindingSource()
            source.DataSource = vehiculos.ToList()
            Me.grid.DataSource = source
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim agregarVehiculo = New AgregarVehiculo()

        agregarVehiculo.StartPosition = FormStartPosition.CenterScreen
        agregarVehiculo.ShowDialog()

        Me.llenarTablaVehiculos()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If grid.SelectedRows.Count = 0 Then
            Return
        End If

        Dim row = grid.SelectedRows.Item(0)
        Dim pregunta = "Estas seguro de eliminar este chequeo?"
        Dim result = MessageBox.Show(pregunta, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim id = Integer.Parse(row.Cells.Item(0).Value)

            DataAccess.DeleteVehiculo(id)

            Me.llenarTablaVehiculos()
        End If
    End Sub
End Class