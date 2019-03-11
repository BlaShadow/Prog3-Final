Imports Datos

Public Class AgregarAccesorio
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim accesorio = New Datos.accesorio With {
                .nombre = txtNombre.Text,
                .tipo_accesorio = comboTipo.SelectedValue,
                .detalles = txtDetalles.Text
            }

            container.accesorios.Add(accesorio)
            container.SaveChanges()

            MessageBox.Show("Accesorio guardado")
            Me.Dispose()
        End Using
    End Sub

    Private Sub AgregarAccesorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim tiposAccesorio = From tipo In container.tipo_accesorio
                                 Select tipo

            Dim source = New BindingSource With {
                .DataSource = tiposAccesorio.ToList()
            }

            comboTipo.DataSource = source
            comboTipo.DisplayMember = "nombre"
            comboTipo.ValueMember = "id"
        End Using
    End Sub
End Class