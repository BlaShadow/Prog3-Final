Imports Datos

Public Class Accesorio
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cargarAccesorios()
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim accesorios = From accesorio In container.accesorios
                             Select New With {
                               Key .ID = accesorio.id,
                               Key .Nombre = accesorio.nombre,
                               Key .Detalles = accesorio.detalles,
                               Key .TipoAccesorio = accesorio.tipo_accesorio1.nombre
                             }

            Dim source = New BindingSource With {
                .DataSource = accesorios.ToList()
            }

            accesorioGrid.DataSource = source
        End Using
    End Sub

    Private Sub cargarTiposAccesorios()
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim tipos = From tipo In container.tipo_accesorio
                        Select New With {
                               Key .ID = tipo.id,
                               Key .Nombre = tipo.nombre,
                               Key .Detalles = tipo.detalles,
                               Key .CantidadAccesorios = tipo.accesorios.Count()
                             }

            Dim source = New BindingSource With {
                .DataSource = tipos.ToList()
            }

            tipoAccesorioGrid.DataSource = source
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form = New AgregarAccesorio()

        form.StartPosition = FormStartPosition.CenterScreen
        form.ShowDialog()
        updateInformacion()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New TipoAccesorio With {
            .StartPosition = FormStartPosition.CenterScreen
        }
        form.ShowDialog()
        updateInformacion()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Accesorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAccesorios()

        cargarTiposAccesorios()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If tipoAccesorioGrid.SelectedRows.Count = 0 Then
            Return
        End If

        Dim row = tipoAccesorioGrid.SelectedRows.Item(0)
        Dim pregunta = "Seguro de eliminar esta categoria de accesorio?"
        Dim result = MessageBox.Show(pregunta, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim id = Integer.Parse(row.Cells.Item(0).Value)

            DataAccess.DeleteAccesorioCategoria(id)

            updateInformacion()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If accesorioGrid.SelectedRows.Count = 0 Then
            Return
        End If

        Dim pregunta = "Seguro de eliminar este accesorio?"
        Dim row = accesorioGrid.SelectedRows.Item(0)
        Dim result = MessageBox.Show(pregunta, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then


            Dim id = Integer.Parse(row.Cells.Item(0).Value)

            DataAccess.DeleteAccesorio(id)

            updateInformacion()
        End If
    End Sub

    Private Sub updateInformacion()
        cargarAccesorios()
        cargarTiposAccesorios()
    End Sub
End Class