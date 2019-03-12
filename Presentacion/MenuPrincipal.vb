Public Class MenuPrincipal
    Private Sub PanelCabecera_Paint(sender As Object, e As PaintEventArgs) Handles PanelCabecera.Paint

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim usauriosForm = New Usuarios()

        Me.setFormIntoPanel(usauriosForm)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        Dim vehiculosForm = New Vehiculos()

        Me.setFormIntoPanel(vehiculosForm)
    End Sub

    Private Sub btnChofer_Click(sender As Object, e As EventArgs) Handles btnChofer.Click
        Dim permisosForm = New Permisos()

        Me.setFormIntoPanel(permisosForm)
    End Sub

    Private Sub btnCkVehiculos_Click(sender As Object, e As EventArgs) Handles btnCkVehiculos.Click
        Dim form = New Chequeos()

        Me.setFormIntoPanel(form)
    End Sub

    Private Sub setFormIntoPanel(content As Form)
        PanelContenedor.Controls.Clear()
        content.TopLevel = False
        PanelContenedor.Controls.Add(content)
        PanelContenedor.Controls.Add(content)

        content.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        content.Dock = DockStyle.Fill
        content.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click
        Dim form = New Accesorio()

        Me.setFormIntoPanel(form)
    End Sub

    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        Dim form = New Dashboard()

        Me.setFormIntoPanel(form)
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dashboard_Click(sender, e)
    End Sub
End Class