Imports Datos

Public Class AgregarPermiso
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Using container As New Chequeo_de_VehiculosEntities1()
                Dim permiso = New permiso With {
                    .activo = True,
                    .nombre = txtNombre.Text,
                    .detalles = txtDetalles.Text,
                    .periodos_renovacion = Integer.Parse(Me.txtMeses.Text)
                }

                container.permisoes.Add(permiso)
                container.SaveChanges()

                Me.Close()
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class