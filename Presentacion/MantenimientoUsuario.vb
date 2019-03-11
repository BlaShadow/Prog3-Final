Public Class MantenimientoUsuario
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chequeo_de_VehiculosDataSet)

    End Sub

    Private Sub MantenimientoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Chequeo_de_VehiculosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.Chequeo_de_VehiculosDataSet.Usuarios)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.UsuariosTableAdapter.AgregarUsuario(UsuarioTextBox.Text, ContraseñaTextBox.Text, NivelesComboBox.Text)
        Me.UsuariosTableAdapter.Fill(Me.Chequeo_de_VehiculosDataSet.Usuarios)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.UsuariosTableAdapter.ModificarUsuario(UsuarioTextBox.Text, ContraseñaTextBox.Text, NivelesComboBox.Text, id:=IdTextBox.Text, Original_id:=IdTextBox.Text)
        Me.UsuariosTableAdapter.Fill(Me.Chequeo_de_VehiculosDataSet.Usuarios)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.UsuariosTableAdapter.EliminarUsuario(IdTextBox.Text)
        Me.UsuariosTableAdapter.Fill(Me.Chequeo_de_VehiculosDataSet.Usuarios)
    End Sub

    Private Sub btnabuscar_Click(sender As Object, e As EventArgs) Handles btnabuscar.Click
        Me.UsuariosTableAdapter.BuscarUsuario(Chequeo_de_VehiculosDataSet.Usuarios, UsuarioTextBox.Text)
    End Sub

    Private Sub btnMostrarUsuario_Click(sender As Object, e As EventArgs) Handles btnMostrarUsuario.Click
        Me.UsuariosTableAdapter.Fill(Me.Chequeo_de_VehiculosDataSet.Usuarios)
    End Sub
End Class