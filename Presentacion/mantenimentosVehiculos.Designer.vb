<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mantenimentosVehiculos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_VehiculoLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim Num_ChasisLabel As System.Windows.Forms.Label
        Dim Cant_PuertaLabel As System.Windows.Forms.Label
        Dim CombustibleLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim EstatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mantenimentosVehiculos))
        Me.Chequeo_de_VehiculosDataSet = New Presentacion.Chequeo_de_VehiculosDataSet()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculoTableAdapter = New Presentacion.Chequeo_de_VehiculosDataSetTableAdapters.VehiculoTableAdapter()
        Me.TableAdapterManager = New Presentacion.Chequeo_de_VehiculosDataSetTableAdapters.TableAdapterManager()
        Me.VehiculoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VehiculoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VehiculoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_VehiculoTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.AñoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.Num_ChasisTextBox = New System.Windows.Forms.TextBox()
        Me.Cant_PuertaTextBox = New System.Windows.Forms.TextBox()
        Me.CombustibleComboBox = New System.Windows.Forms.ComboBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.EstatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnMostrarVehiculo = New System.Windows.Forms.Button()
        Id_VehiculoLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        Num_ChasisLabel = New System.Windows.Forms.Label()
        Cant_PuertaLabel = New System.Windows.Forms.Label()
        CombustibleLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        EstatusLabel = New System.Windows.Forms.Label()
        CType(Me.Chequeo_de_VehiculosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VehiculoBindingNavigator.SuspendLayout()
        CType(Me.VehiculoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_VehiculoLabel
        '
        Id_VehiculoLabel.AutoSize = True
        Id_VehiculoLabel.Location = New System.Drawing.Point(19, 54)
        Id_VehiculoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Id_VehiculoLabel.Name = "Id_VehiculoLabel"
        Id_VehiculoLabel.Size = New System.Drawing.Size(62, 13)
        Id_VehiculoLabel.TabIndex = 2
        Id_VehiculoLabel.Text = "id Vehiculo:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Location = New System.Drawing.Point(19, 76)
        MatriculaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(53, 13)
        MatriculaLabel.TabIndex = 4
        MatriculaLabel.Text = "Matricula:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(19, 99)
        ColorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 6
        ColorLabel.Text = "Color:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(19, 123)
        AñoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(29, 13)
        AñoLabel.TabIndex = 8
        AñoLabel.Text = "Año:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(19, 145)
        MarcaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 10
        MarcaLabel.Text = "Marca:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(19, 167)
        ModeloLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(45, 13)
        ModeloLabel.TabIndex = 12
        ModeloLabel.Text = "Modelo:"
        '
        'Num_ChasisLabel
        '
        Num_ChasisLabel.AutoSize = True
        Num_ChasisLabel.Location = New System.Drawing.Point(19, 190)
        Num_ChasisLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Num_ChasisLabel.Name = "Num_ChasisLabel"
        Num_ChasisLabel.Size = New System.Drawing.Size(66, 13)
        Num_ChasisLabel.TabIndex = 14
        Num_ChasisLabel.Text = "Num Chasis:"
        '
        'Cant_PuertaLabel
        '
        Cant_PuertaLabel.AutoSize = True
        Cant_PuertaLabel.Location = New System.Drawing.Point(19, 213)
        Cant_PuertaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Cant_PuertaLabel.Name = "Cant_PuertaLabel"
        Cant_PuertaLabel.Size = New System.Drawing.Size(66, 13)
        Cant_PuertaLabel.TabIndex = 16
        Cant_PuertaLabel.Text = "Cant Puerta:"
        '
        'CombustibleLabel
        '
        CombustibleLabel.AutoSize = True
        CombustibleLabel.Location = New System.Drawing.Point(19, 236)
        CombustibleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CombustibleLabel.Name = "CombustibleLabel"
        CombustibleLabel.Size = New System.Drawing.Size(67, 13)
        CombustibleLabel.TabIndex = 18
        CombustibleLabel.Text = "Combustible:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(19, 261)
        ObservacionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(70, 13)
        ObservacionLabel.TabIndex = 20
        ObservacionLabel.Text = "Observacion:"
        '
        'EstatusLabel
        '
        EstatusLabel.AutoSize = True
        EstatusLabel.Location = New System.Drawing.Point(19, 284)
        EstatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EstatusLabel.Name = "EstatusLabel"
        EstatusLabel.Size = New System.Drawing.Size(45, 13)
        EstatusLabel.TabIndex = 22
        EstatusLabel.Text = "Estatus:"
        '
        'Chequeo_de_VehiculosDataSet
        '
        Me.Chequeo_de_VehiculosDataSet.DataSetName = "Chequeo_de_VehiculosDataSet"
        Me.Chequeo_de_VehiculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "Vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.Chequeo_de_VehiculosDataSet
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChoferTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Presentacion.Chequeo_de_VehiculosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VehiculoTableAdapter = Me.VehiculoTableAdapter
        '
        'VehiculoBindingNavigator
        '
        Me.VehiculoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VehiculoBindingNavigator.BindingSource = Me.VehiculoBindingSource
        Me.VehiculoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VehiculoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VehiculoBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VehiculoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VehiculoBindingNavigatorSaveItem})
        Me.VehiculoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VehiculoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VehiculoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VehiculoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VehiculoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VehiculoBindingNavigator.Name = "VehiculoBindingNavigator"
        Me.VehiculoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VehiculoBindingNavigator.Size = New System.Drawing.Size(669, 22)
        Me.VehiculoBindingNavigator.TabIndex = 0
        Me.VehiculoBindingNavigator.Text = "BindingNavigator1"
        Me.VehiculoBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 19)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 22)
        '
        'VehiculoBindingNavigatorSaveItem
        '
        Me.VehiculoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VehiculoBindingNavigatorSaveItem.Image = CType(resources.GetObject("VehiculoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VehiculoBindingNavigatorSaveItem.Name = "VehiculoBindingNavigatorSaveItem"
        Me.VehiculoBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 19)
        Me.VehiculoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'VehiculoDataGridView
        '
        Me.VehiculoDataGridView.AutoGenerateColumns = False
        Me.VehiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehiculoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.VehiculoDataGridView.DataSource = Me.VehiculoBindingSource
        Me.VehiculoDataGridView.Location = New System.Drawing.Point(253, 51)
        Me.VehiculoDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.VehiculoDataGridView.Name = "VehiculoDataGridView"
        Me.VehiculoDataGridView.RowTemplate.Height = 24
        Me.VehiculoDataGridView.Size = New System.Drawing.Size(407, 249)
        Me.VehiculoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_Vehiculo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_Vehiculo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Matricula"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Matricula"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Num_Chasis"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Num_Chasis"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cant_Puerta"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cant_Puerta"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Combustible"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Combustible"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Observacion"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Observacion"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Id_VehiculoTextBox
        '
        Me.Id_VehiculoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "id_Vehiculo", True))
        Me.Id_VehiculoTextBox.Location = New System.Drawing.Point(92, 51)
        Me.Id_VehiculoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Id_VehiculoTextBox.Name = "Id_VehiculoTextBox"
        Me.Id_VehiculoTextBox.Size = New System.Drawing.Size(151, 20)
        Me.Id_VehiculoTextBox.TabIndex = 3
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(92, 74)
        Me.MatriculaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.Size = New System.Drawing.Size(151, 20)
        Me.MatriculaTextBox.TabIndex = 5
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(92, 97)
        Me.ColorTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ColorTextBox.TabIndex = 7
        '
        'AñoDateTimePicker
        '
        Me.AñoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "Año", True))
        Me.AñoDateTimePicker.Location = New System.Drawing.Point(92, 119)
        Me.AñoDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.AñoDateTimePicker.Name = "AñoDateTimePicker"
        Me.AñoDateTimePicker.Size = New System.Drawing.Size(151, 20)
        Me.AñoDateTimePicker.TabIndex = 9
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(92, 142)
        Me.MarcaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(151, 20)
        Me.MarcaTextBox.TabIndex = 11
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "Modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(92, 165)
        Me.ModeloTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ModeloTextBox.TabIndex = 13
        '
        'Num_ChasisTextBox
        '
        Me.Num_ChasisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "Num_Chasis", True))
        Me.Num_ChasisTextBox.Location = New System.Drawing.Point(92, 188)
        Me.Num_ChasisTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Num_ChasisTextBox.Name = "Num_ChasisTextBox"
        Me.Num_ChasisTextBox.Size = New System.Drawing.Size(151, 20)
        Me.Num_ChasisTextBox.TabIndex = 15
        '
        'Cant_PuertaTextBox
        '
        Me.Cant_PuertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "Cant_Puerta", True))
        Me.Cant_PuertaTextBox.Location = New System.Drawing.Point(92, 210)
        Me.Cant_PuertaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Cant_PuertaTextBox.Name = "Cant_PuertaTextBox"
        Me.Cant_PuertaTextBox.Size = New System.Drawing.Size(151, 20)
        Me.Cant_PuertaTextBox.TabIndex = 17
        '
        'CombustibleComboBox
        '
        Me.CombustibleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "Combustible", True))
        Me.CombustibleComboBox.FormattingEnabled = True
        Me.CombustibleComboBox.Location = New System.Drawing.Point(92, 233)
        Me.CombustibleComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CombustibleComboBox.Name = "CombustibleComboBox"
        Me.CombustibleComboBox.Size = New System.Drawing.Size(151, 21)
        Me.CombustibleComboBox.TabIndex = 19
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "Observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(92, 258)
        Me.ObservacionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ObservacionTextBox.TabIndex = 21
        '
        'EstatusComboBox
        '
        Me.EstatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "Estatus", True))
        Me.EstatusComboBox.FormattingEnabled = True
        Me.EstatusComboBox.Location = New System.Drawing.Point(92, 281)
        Me.EstatusComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EstatusComboBox.Name = "EstatusComboBox"
        Me.EstatusComboBox.Size = New System.Drawing.Size(151, 21)
        Me.EstatusComboBox.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Registro Vehiculos"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(21, 324)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 25)
        Me.btnAgregar.TabIndex = 25
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(98, 324)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(73, 25)
        Me.btnModificar.TabIndex = 26
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(176, 324)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(73, 25)
        Me.btnBuscar.TabIndex = 27
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(253, 324)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 25)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnMostrarVehiculo
        '
        Me.btnMostrarVehiculo.Location = New System.Drawing.Point(330, 324)
        Me.btnMostrarVehiculo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrarVehiculo.Name = "btnMostrarVehiculo"
        Me.btnMostrarVehiculo.Size = New System.Drawing.Size(116, 25)
        Me.btnMostrarVehiculo.TabIndex = 29
        Me.btnMostrarVehiculo.Text = "Mostar Vehiculos"
        Me.btnMostrarVehiculo.UseVisualStyleBackColor = True
        '
        'mantenimentosVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 370)
        Me.Controls.Add(Me.btnMostrarVehiculo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_VehiculoLabel)
        Me.Controls.Add(Me.Id_VehiculoTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoDateTimePicker)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(Num_ChasisLabel)
        Me.Controls.Add(Me.Num_ChasisTextBox)
        Me.Controls.Add(Cant_PuertaLabel)
        Me.Controls.Add(Me.Cant_PuertaTextBox)
        Me.Controls.Add(CombustibleLabel)
        Me.Controls.Add(Me.CombustibleComboBox)
        Me.Controls.Add(ObservacionLabel)
        Me.Controls.Add(Me.ObservacionTextBox)
        Me.Controls.Add(EstatusLabel)
        Me.Controls.Add(Me.EstatusComboBox)
        Me.Controls.Add(Me.VehiculoDataGridView)
        Me.Controls.Add(Me.VehiculoBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "mantenimentosVehiculos"
        Me.Text = "mantenimentosVehiculos"
        CType(Me.Chequeo_de_VehiculosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VehiculoBindingNavigator.ResumeLayout(False)
        Me.VehiculoBindingNavigator.PerformLayout()
        CType(Me.VehiculoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chequeo_de_VehiculosDataSet As Chequeo_de_VehiculosDataSet
    Friend WithEvents VehiculoBindingSource As BindingSource
    Friend WithEvents VehiculoTableAdapter As Chequeo_de_VehiculosDataSetTableAdapters.VehiculoTableAdapter
    Friend WithEvents TableAdapterManager As Chequeo_de_VehiculosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehiculoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents VehiculoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VehiculoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Id_VehiculoTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents AñoDateTimePicker As DateTimePicker
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents Num_ChasisTextBox As TextBox
    Friend WithEvents Cant_PuertaTextBox As TextBox
    Friend WithEvents CombustibleComboBox As ComboBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents EstatusComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnMostrarVehiculo As Button
End Class
