<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuenta
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
        Dim ESTADOLabel As System.Windows.Forms.Label
        Dim SALDOLabel As System.Windows.Forms.Label
        Dim IDTIPOCUENTALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuenta))
        Dim IDCLIENTELabel As System.Windows.Forms.Label
        Me.DS = New Banco.DS()
        Me.CUENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUENTATableAdapter = New Banco.DSTableAdapters.CUENTATableAdapter()
        Me.TableAdapterManager = New Banco.DSTableAdapters.TableAdapterManager()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTETableAdapter = New Banco.DSTableAdapters.CLIENTETableAdapter()
        Me.FKTARJETACUENTA1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TARJETATableAdapter = New Banco.DSTableAdapters.TARJETATableAdapter()
        Me.TIPOCUENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPOCUENTATableAdapter = New Banco.DSTableAdapters.TIPOCUENTATableAdapter()
        Me.ESTADOTextBox = New System.Windows.Forms.TextBox()
        Me.SALDOTextBox = New System.Windows.Forms.TextBox()
        Me.IDTIPOCUENTAComboBox = New System.Windows.Forms.ComboBox()
        Me.CUENTABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CUENTABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDCLIENTEComboBox = New System.Windows.Forms.ComboBox()
        Me.btGuardar = New System.Windows.Forms.Button()
        ESTADOLabel = New System.Windows.Forms.Label()
        SALDOLabel = New System.Windows.Forms.Label()
        IDTIPOCUENTALabel = New System.Windows.Forms.Label()
        IDCLIENTELabel = New System.Windows.Forms.Label()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTARJETACUENTA1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOCUENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUENTABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CUENTABindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUENTABindingSource
        '
        Me.CUENTABindingSource.DataMember = "CUENTA"
        Me.CUENTABindingSource.DataSource = Me.DS
        '
        'CUENTATableAdapter
        '
        Me.CUENTATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Me.CLIENTETableAdapter
        Me.TableAdapterManager.CUENTATableAdapter = Me.CUENTATableAdapter
        Me.TableAdapterManager.DEPARTAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOTableAdapter = Nothing
        Me.TableAdapterManager.PUESTOTableAdapter = Nothing
        Me.TableAdapterManager.TARJETATableAdapter = Me.TARJETATableAdapter
        Me.TableAdapterManager.TIPOCUENTATableAdapter = Me.TIPOCUENTATableAdapter
        Me.TableAdapterManager.TRANSACIONTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Banco.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.DS
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'FKTARJETACUENTA1BindingSource
        '
        Me.FKTARJETACUENTA1BindingSource.DataMember = "FK_TARJETA_CUENTA_1"
        Me.FKTARJETACUENTA1BindingSource.DataSource = Me.CUENTABindingSource
        '
        'TARJETATableAdapter
        '
        Me.TARJETATableAdapter.ClearBeforeFill = True
        '
        'TIPOCUENTABindingSource
        '
        Me.TIPOCUENTABindingSource.DataMember = "TIPOCUENTA"
        Me.TIPOCUENTABindingSource.DataSource = Me.DS
        '
        'TIPOCUENTATableAdapter
        '
        Me.TIPOCUENTATableAdapter.ClearBeforeFill = True
        '
        'ESTADOLabel
        '
        ESTADOLabel.AutoSize = True
        ESTADOLabel.Location = New System.Drawing.Point(84, 295)
        ESTADOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ESTADOLabel.Name = "ESTADOLabel"
        ESTADOLabel.Size = New System.Drawing.Size(73, 18)
        ESTADOLabel.TabIndex = 16
        ESTADOLabel.Text = "ESTADO:"
        '
        'ESTADOTextBox
        '
        Me.ESTADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUENTABindingSource, "ESTADO", True))
        Me.ESTADOTextBox.Location = New System.Drawing.Point(202, 292)
        Me.ESTADOTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ESTADOTextBox.Name = "ESTADOTextBox"
        Me.ESTADOTextBox.Size = New System.Drawing.Size(180, 24)
        Me.ESTADOTextBox.TabIndex = 17
        '
        'SALDOLabel
        '
        SALDOLabel.AutoSize = True
        SALDOLabel.Location = New System.Drawing.Point(84, 234)
        SALDOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SALDOLabel.Name = "SALDOLabel"
        SALDOLabel.Size = New System.Drawing.Size(62, 18)
        SALDOLabel.TabIndex = 14
        SALDOLabel.Text = "SALDO:"
        '
        'SALDOTextBox
        '
        Me.SALDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUENTABindingSource, "SALDO", True))
        Me.SALDOTextBox.Location = New System.Drawing.Point(202, 231)
        Me.SALDOTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SALDOTextBox.Name = "SALDOTextBox"
        Me.SALDOTextBox.Size = New System.Drawing.Size(180, 24)
        Me.SALDOTextBox.TabIndex = 15
        '
        'IDTIPOCUENTALabel
        '
        IDTIPOCUENTALabel.AutoSize = True
        IDTIPOCUENTALabel.Location = New System.Drawing.Point(84, 164)
        IDTIPOCUENTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDTIPOCUENTALabel.Name = "IDTIPOCUENTALabel"
        IDTIPOCUENTALabel.Size = New System.Drawing.Size(111, 18)
        IDTIPOCUENTALabel.TabIndex = 12
        IDTIPOCUENTALabel.Text = "TIPO CUENTA:"
        '
        'IDTIPOCUENTAComboBox
        '
        Me.IDTIPOCUENTAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUENTABindingSource, "IDTIPOCUENTA", True))
        Me.IDTIPOCUENTAComboBox.DataSource = Me.TIPOCUENTABindingSource
        Me.IDTIPOCUENTAComboBox.DisplayMember = "TIPOCUENTA"
        Me.IDTIPOCUENTAComboBox.FormattingEnabled = True
        Me.IDTIPOCUENTAComboBox.Location = New System.Drawing.Point(203, 161)
        Me.IDTIPOCUENTAComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IDTIPOCUENTAComboBox.Name = "IDTIPOCUENTAComboBox"
        Me.IDTIPOCUENTAComboBox.Size = New System.Drawing.Size(180, 26)
        Me.IDTIPOCUENTAComboBox.TabIndex = 13
        Me.IDTIPOCUENTAComboBox.ValueMember = "IDTIPOCUENTA"
        '
        'CUENTABindingNavigator
        '
        Me.CUENTABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CUENTABindingNavigator.BindingSource = Me.CUENTABindingSource
        Me.CUENTABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CUENTABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CUENTABindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CUENTABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CUENTABindingNavigatorSaveItem})
        Me.CUENTABindingNavigator.Location = New System.Drawing.Point(36, 23)
        Me.CUENTABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CUENTABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CUENTABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CUENTABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CUENTABindingNavigator.Name = "CUENTABindingNavigator"
        Me.CUENTABindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.CUENTABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CUENTABindingNavigator.Size = New System.Drawing.Size(335, 25)
        Me.CUENTABindingNavigator.TabIndex = 10
        Me.CUENTABindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CUENTABindingNavigatorSaveItem
        '
        Me.CUENTABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CUENTABindingNavigatorSaveItem.Image = CType(resources.GetObject("CUENTABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CUENTABindingNavigatorSaveItem.Name = "CUENTABindingNavigatorSaveItem"
        Me.CUENTABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CUENTABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IDCLIENTELabel
        '
        IDCLIENTELabel.AutoSize = True
        IDCLIENTELabel.Location = New System.Drawing.Point(84, 110)
        IDCLIENTELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDCLIENTELabel.Name = "IDCLIENTELabel"
        IDCLIENTELabel.Size = New System.Drawing.Size(74, 18)
        IDCLIENTELabel.TabIndex = 9
        IDCLIENTELabel.Text = "CLIENTE:"
        '
        'IDCLIENTEComboBox
        '
        Me.IDCLIENTEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUENTABindingSource, "IDCLIENTE", True))
        Me.IDCLIENTEComboBox.DataSource = Me.CLIENTEBindingSource
        Me.IDCLIENTEComboBox.DisplayMember = "NOMBRE"
        Me.IDCLIENTEComboBox.FormattingEnabled = True
        Me.IDCLIENTEComboBox.Location = New System.Drawing.Point(202, 107)
        Me.IDCLIENTEComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IDCLIENTEComboBox.Name = "IDCLIENTEComboBox"
        Me.IDCLIENTEComboBox.Size = New System.Drawing.Size(180, 26)
        Me.IDCLIENTEComboBox.TabIndex = 11
        Me.IDCLIENTEComboBox.ValueMember = "IDCLIENTE"
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(453, 272)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(127, 41)
        Me.btGuardar.TabIndex = 18
        Me.btGuardar.Text = "Crear Cuenta"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'frmCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 371)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(ESTADOLabel)
        Me.Controls.Add(Me.ESTADOTextBox)
        Me.Controls.Add(SALDOLabel)
        Me.Controls.Add(Me.SALDOTextBox)
        Me.Controls.Add(IDTIPOCUENTALabel)
        Me.Controls.Add(Me.IDTIPOCUENTAComboBox)
        Me.Controls.Add(Me.CUENTABindingNavigator)
        Me.Controls.Add(IDCLIENTELabel)
        Me.Controls.Add(Me.IDCLIENTEComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCuenta"
        Me.Text = "Funciones Con Cuentas"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTARJETACUENTA1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOCUENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUENTABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CUENTABindingNavigator.ResumeLayout(False)
        Me.CUENTABindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As Banco.DS
    Friend WithEvents CUENTABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUENTATableAdapter As Banco.DSTableAdapters.CUENTATableAdapter
    Friend WithEvents TableAdapterManager As Banco.DSTableAdapters.TableAdapterManager
    Friend WithEvents CLIENTETableAdapter As Banco.DSTableAdapters.CLIENTETableAdapter
    Friend WithEvents CLIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TARJETATableAdapter As Banco.DSTableAdapters.TARJETATableAdapter
    Friend WithEvents FKTARJETACUENTA1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIPOCUENTATableAdapter As Banco.DSTableAdapters.TIPOCUENTATableAdapter
    Friend WithEvents TIPOCUENTABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ESTADOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SALDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTIPOCUENTAComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CUENTABindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CUENTABindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDCLIENTEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btGuardar As System.Windows.Forms.Button
End Class
