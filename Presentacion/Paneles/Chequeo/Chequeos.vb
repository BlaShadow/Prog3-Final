Imports Datos

Public Class Chequeos

    Private Sub cargarChequeos()
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim chequeos = From chequeo In container.chequeos
                           Where chequeo.activo = True
                           Order By chequeo.id Descending
                           Select New With {
                               Key .ID = chequeo.id,
                               Key .Fecha = chequeo.fecha,
                               Key .Vehiculo = chequeo.vehiculo.matricula,
                               Key .Estado = chequeo.vehiculo_estado.nombre,
                               Key .Tipo = chequeo.tipo,
                               Key .Detalles = chequeo.detalles
                           }

            Dim source = New BindingSource()
            source.DataSource = chequeos.ToList()

            grid.DataSource = source
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form = New Chequeo With {
            .StartPosition = FormStartPosition.CenterScreen
        }

        form.ShowDialog()

        Me.cargarChequeos()
    End Sub

    Private Sub Chequeos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarChequeos()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If grid.SelectedRows.Count = 0 Then
            Return
        End If

        Dim row = grid.SelectedRows.Item(0)
        Dim pregunta = "Seguro de eliminar este chequeo?"
        Dim result = MessageBox.Show(pregunta, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim id = Integer.Parse(row.Cells.Item(0).Value)

            DataAccess.DeleteChequeo(id)

            Me.cargarChequeos()
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If grid.SelectedRows.Count = 0 Then
            Return
        End If

        Dim row = grid.SelectedRows.Item(0)
        Dim id = Integer.Parse(row.Cells.Item(0).Value)
        Dim chequeo = DataAccess.Chequeo(id, True)

        Dim form = New DetallesChequeo() With {
            .StartPosition = FormStartPosition.CenterScreen
        }
        form.setChequeo(chequeo)

        form.ShowDialog()
    End Sub
End Class