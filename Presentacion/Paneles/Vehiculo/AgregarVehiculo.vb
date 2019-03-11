Imports Datos

Public Class AgregarVehiculo
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Using container As New Chequeo_de_VehiculosEntities1()
                Dim vehiculo = New vehiculo()

                vehiculo.ano = Integer.Parse(Me.txtAno.Text)
                vehiculo.chasis = txtChasis.Text
                vehiculo.color = txtColor.Text
                vehiculo.marca = txtMarca.Text
                vehiculo.modelo = txtModelo.Text
                vehiculo.matricula = txtMatricula.Text
                vehiculo.puertas = Integer.Parse(txtPuertas.Text)

                container.vehiculoes.Add(vehiculo)
                container.SaveChanges()

                Me.Dispose()
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class