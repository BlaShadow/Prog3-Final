Imports Datos
Imports Entidades

Public Class Login

    Dim fu As New fUsuario
    Dim eu As New Eusuario

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnacceder_Click(sender As Object, e As EventArgs) Handles btnacceder.Click
        Me.intentarLogin()
    End Sub '

    Private Sub intentarLogin()
        Dim textUsuario = Me.txtUsuario.Text
        Dim textClave = Me.txtContrasena.Text

        If String.IsNullOrEmpty(textUsuario) Or
            String.IsNullOrEmpty(textClave) Then
            Return
        End If

        Using container = New Chequeo_de_VehiculosEntities1()
            Dim results = From item In container.usuarios
                          Select item
                          Where item.usuario1 = textUsuario And item.clave = textClave

            If results.Count = 0 Then
                MessageBox.Show("Usuario no encontrado")
                Return
            End If

            Dim usuario = results.First()

            DataAccess.Session = usuario

            MenuPrincipal.Show()
            Me.Hide()

            My.Forms.MenuPrincipal.btnCkVehiculos.Enabled = True
            My.Forms.MenuPrincipal.btnChofer.Enabled = True
            My.Forms.MenuPrincipal.btnVehiculos.Enabled = True
            My.Forms.MenuPrincipal.btnUsuarios.Enabled = True
        End Using
    End Sub


    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContrasena.Focus()
            Return
        End If
    End Sub

    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged

    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.intentarLogin()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
