Imports Datos

Public Class Permisos
    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarPermisos()
    End Sub

    Private Sub CargarPermisos()
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim permisos = From permiso In container.permisoes
                           Where permiso.activo = True
                           Order By permiso.id Descending
                           Select New With {
                               Key .ID = permiso.id,
                               Key .Nombre = permiso.nombre,
                               Key .Detalles = permiso.detalles,
                               Key .PeriodosRenovacion = permiso.periodos_renovacion
                           }

            Dim source = New BindingSource With {
                .DataSource = permisos.ToList()
            }

            grid.DataSource = source
        End Using
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim agregarPermiso = New AgregarPermiso With {
            .StartPosition = FormStartPosition.CenterScreen
        }

        agregarPermiso.ShowDialog()

        Me.CargarPermisos()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If grid.SelectedRows.Count = 0 Then
            Return
        End If

        Dim row = grid.SelectedRows.Item(0)
        Dim pregunta = "Estas seguro de eliminar este permiso?"
        Dim result = MessageBox.Show(pregunta, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim id = Integer.Parse(row.Cells.Item(0).Value)

            DataAccess.DeletePermiso(id)

            Me.CargarPermisos()
        End If
    End Sub
End Class