Imports Datos

Public Class AgregarUsuario
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim nuevoUsuario = New usuario()
            nuevoUsuario.usuario1 = Me.txtUsuario.Text
            nuevoUsuario.clave = Me.txtClave.Text
            nuevoUsuario.nivel = Me.combo.SelectedValue
            nuevoUsuario.activo = True

            container.usuarios.Add(nuevoUsuario)

            container.SaveChanges()

            Me.Dispose()
        End Using
    End Sub

    Private Sub AgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim niveles = From nivel In container.nivels
                          Select New With {Key .id = nivel.id, .nombre = nivel.nombre}

            Me.combo.DataSource = niveles.ToList()
            Me.combo.ValueMember = "id"
            Me.combo.DisplayMember = "nombre"
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class