Imports Datos

Public Class Chequeo

    Private vehiculo As vehiculo
    Private accesorios As List(Of CheckBox)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hacerbusqueda()
    End Sub

    Private Sub hacerbusqueda()
        Using container As New Chequeo_de_VehiculosEntities1()
            Dim value = txtSearch.Text
            Dim vehiculos = From vehiculo In container.vehiculoes
                            Where vehiculo.chasis = value Or vehiculo.matricula = value
                            Select vehiculo

            Dim list = vehiculos.ToList()

            If (list.Count = 0) Then
                MessageBox.Show("Vehiculo no encontrado")
                txtSearch.Focus()
                Return
            End If

            Dim primero = list.First()

            Me.vehiculo = primero
            limpiarLabes()

            llenarLabels(primero)

            txtSearch.Text = ""
            txtSearch.Enabled = False
            btnCrear.Enabled = True


        End Using
    End Sub

    Private Sub llenarLabels(vehiculo As vehiculo)
        lblMarca.Text = vehiculo.marca
        lblModelo.Text = vehiculo.modelo
        lblMatricula.Text = vehiculo.matricula
        lblAno.Text = vehiculo.ano.ToString()

        Using container As New Chequeo_de_VehiculosEntities1()
            Dim chequeos = From chequeo In container.chequeos
                           Where chequeo.id_vehiculo = vehiculo.id
                           Select New With {
                               Key .Fecha = chequeo.fecha,
                               Key .Tipo = chequeo.tipo,
                               Key .Detalles = chequeo.detalles
                           }

            Dim source = New BindingSource With {
                .DataSource = chequeos.ToList()
            }

            grid.DataSource = source
        End Using
    End Sub


    Private Sub limpiarLabes()
        Me.lblAno.Text = ""
        Me.lblMarca.Text = ""
        Me.lblMatricula.Text = ""
        Me.lblModelo.Text = ""
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            hacerbusqueda()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtSearch.Enabled = True
        limpiarLabes()
    End Sub

    Private Sub Chequeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCrear.Enabled = False

        Dim lista = {
            New With {Key .text = "ENTRADA", Key .id = 0},
            New With {Key .text = "SALIDA", Key .id = 1},
            New With {Key .text = "OTRO", Key .id = 2}
        }

        Dim source = New BindingSource()
        source.DataSource = lista

        combo.DisplayMember = "text"
        combo.ValueMember = "id"
        combo.DataSource = source

        Using container As New Chequeo_de_VehiculosEntities1()

            Dim tipos = container.tipo_accesorio.ToList()
            panel1.RowCount = 1
            panel1.ColumnCount = tipos.Count

            accesorios = New List(Of CheckBox)

            For Each item In tipos
                Dim label = New Label()
                label.Font = New Font("Trebuchet MS", 11)
                Dim column = tipos.IndexOf(item)
                Dim innerPanel = New FlowLayoutPanel()
                label.Text = item.nombre

                innerPanel.Dock = DockStyle.Fill
                innerPanel.Controls.Add(label)

                For Each subItem In item.accesorios
                    Dim check = New CheckBox()
                    accesorios.Add(check)
                    check.Text = subItem.nombre
                    check.Tag = subItem

                    innerPanel.Controls.Add(check)
                Next

                panel1.Controls.Add(innerPanel, column, 0)
            Next
        End Using
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            Using container As New Chequeo_de_VehiculosEntities1()

                Dim chequeo = New Datos.chequeo()
                chequeo.detalles = txtDetails.Text
                chequeo.combustible = Integer.Parse(txtCombustible.Text)
                chequeo.kilometraje = Integer.Parse(txtKM.Text)
                chequeo.tipo = combo.Text
                chequeo.id_usuario = DataAccess.Session.id
                chequeo.id_vehiculo = Me.vehiculo.id
                chequeo.fecha = DateTime.Now
                chequeo.activo = True

                container.chequeos.Add(chequeo)
                container.SaveChanges()

                For Each item In Me.accesorios
                    Dim tag = item.Tag

                    container.chequeo_accesorio.Add(New chequeo_accesorio With {
                        .accesorio_id = tag.id,
                        .chequeo_id = chequeo.id,
                        .valor = item.Checked
                    })
                Next

                container.SaveChanges()

                MessageBox.Show("Chequeo realizado!")
                Me.Close()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error creando chequeo " + ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class