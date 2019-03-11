Imports Datos

Public Class TipoAccesorio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim tipoAccesorio = New tipo_accesorio()

            tipoAccesorio.nombre = txtNombre.Text
            tipoAccesorio.detalles = txtDetalles.Text

            container.tipo_accesorio.Add(tipoAccesorio)
            container.SaveChanges()

            MessageBox.Show("Tipo accesorio guardado")
            Me.Close()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class