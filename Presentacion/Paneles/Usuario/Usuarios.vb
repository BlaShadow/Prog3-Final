Imports Datos

Public Class Usuarios
    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.llenarTableusuarios()
    End Sub

    Private Sub llenarTableusuarios()
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim usuarios = From usuario In container.usuarios
                           Where usuario.activo = True
                           Select New With {
                               Key .ID = usuario.id,
                               Key .Usuario = usuario.usuario1,
                               Key .CantidadChequeos = usuario.chequeos.Count
                           }

            Dim source = New BindingSource With {
                .DataSource = usuarios.ToList()
            }
            Me.grid.DataSource = source
        End Using
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim agregarUsuario = New AgregarUsuario()

        agregarUsuario.StartPosition = FormStartPosition.CenterScreen
        agregarUsuario.ShowDialog()

        Me.llenarTableusuarios()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Me.grid.SelectedRows.Count = 0 Then
            Return
        End If

        Dim row = grid.SelectedRows.Item(0)
        Dim pregunta = "Seguro de eliminar este usuario?"
        Dim result = MessageBox.Show(pregunta, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim id = Integer.Parse(row.Cells.Item(0).Value)

            DataAccess.DeleteUsuario(id)

            llenarTableusuarios()
        End If
    End Sub
End Class