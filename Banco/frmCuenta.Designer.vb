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
        Dim IDCLIENTELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.DS = New Banco.DS()
        Me.CUENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUENTATableAdapter = New Banco.DSTableAdapters.CUENTATableAdapter()
        Me.TableAdapterManager = New Banco.DSTableAdapters.TableAdapterManager()
        Me.CLIENTETableAdapter = New Banco.DSTableAdapters.CLIENTETableAdapter()
        Me.TARJETATableAdapter = New Banco.DSTableAdapters.TARJETATableAdapter()
        Me.TIPOCUENTATableAdapter = New Banco.DSTableAdapters.TIPOCUENTATableAdapter()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKTARJETACUENTA1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPOCUENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESTADOTextBox = New System.Windows.Forms.TextBox()
        Me.SALDOTextBox = New System.Windows.Forms.TextBox()
        Me.IDTIPOCUENTAComboBox = New System.Windows.Forms.ComboBox()
        Me.IDCLIENTEComboBox = New System.Windows.Forms.ComboBox()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        ESTADOLabel = New System.Windows.Forms.Label()
        SALDOLabel = New System.Windows.Forms.Label()
        IDTIPOCUENTALabel = New System.Windows.Forms.Label()
        IDCLIENTELabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTARJETACUENTA1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOCUENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ESTADOLabel
        '
        ESTADOLabel.AutoSize = True
        ESTADOLabel.Location = New System.Drawing.Point(73, 242)
        ESTADOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ESTADOLabel.Name = "ESTADOLabel"
        ESTADOLabel.Size = New System.Drawing.Size(73, 18)
        ESTADOLabel.TabIndex = 16
        ESTADOLabel.Text = "ESTADO:"
        '
        'SALDOLabel
        '
        SALDOLabel.AutoSize = True
        SALDOLabel.Location = New System.Drawing.Point(73, 181)
        SALDOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SALDOLabel.Name = "SALDOLabel"
        SALDOLabel.Size = New System.Drawing.Size(62, 18)
        SALDOLabel.TabIndex = 14
        SALDOLabel.Text = "SALDO:"
        '
        'IDTIPOCUENTALabel
        '
        IDTIPOCUENTALabel.AutoSize = True
        IDTIPOCUENTALabel.Location = New System.Drawing.Point(73, 111)
        IDTIPOCUENTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDTIPOCUENTALabel.Name = "IDTIPOCUENTALabel"
        IDTIPOCUENTALabel.Size = New System.Drawing.Size(111, 18)
        IDTIPOCUENTALabel.TabIndex = 12
        IDTIPOCUENTALabel.Text = "TIPO CUENTA:"
        '
        'IDCLIENTELabel
        '
        IDCLIENTELabel.AutoSize = True
        IDCLIENTELabel.Location = New System.Drawing.Point(73, 57)
        IDCLIENTELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDCLIENTELabel.Name = "IDCLIENTELabel"
        IDCLIENTELabel.Size = New System.Drawing.Size(74, 18)
        IDCLIENTELabel.TabIndex = 9
        IDCLIENTELabel.Text = "CLIENTE:"
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
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'TARJETATableAdapter
        '
        Me.TARJETATableAdapter.ClearBeforeFill = True
        '
        'TIPOCUENTATableAdapter
        '
        Me.TIPOCUENTATableAdapter.ClearBeforeFill = True
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.DS
        '
        'FKTARJETACUENTA1BindingSource
        '
        Me.FKTARJETACUENTA1BindingSource.DataMember = "FK_TARJETA_CUENTA_1"
        Me.FKTARJETACUENTA1BindingSource.DataSource = Me.CUENTABindingSource
        '
        'TIPOCUENTABindingSource
        '
        Me.TIPOCUENTABindingSource.DataMember = "TIPOCUENTA"
        Me.TIPOCUENTABindingSource.DataSource = Me.DS
        '
        'ESTADOTextBox
        '
        Me.ESTADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUENTABindingSource, "ESTADO", True))
        Me.ESTADOTextBox.Location = New System.Drawing.Point(191, 239)
        Me.ESTADOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ESTADOTextBox.Name = "ESTADOTextBox"
        Me.ESTADOTextBox.Size = New System.Drawing.Size(180, 24)
        Me.ESTADOTextBox.TabIndex = 3
        '
        'SALDOTextBox
        '
        Me.SALDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUENTABindingSource, "SALDO", True))
        Me.SALDOTextBox.Location = New System.Drawing.Point(191, 178)
        Me.SALDOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SALDOTextBox.Name = "SALDOTextBox"
        Me.SALDOTextBox.Size = New System.Drawing.Size(180, 24)
        Me.SALDOTextBox.TabIndex = 2
        '
        'IDTIPOCUENTAComboBox
        '
        Me.IDTIPOCUENTAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUENTABindingSource, "IDTIPOCUENTA", True))
        Me.IDTIPOCUENTAComboBox.DataSource = Me.TIPOCUENTABindingSource
        Me.IDTIPOCUENTAComboBox.DisplayMember = "TIPOCUENTA"
        Me.IDTIPOCUENTAComboBox.FormattingEnabled = True
        Me.IDTIPOCUENTAComboBox.Location = New System.Drawing.Point(192, 108)
        Me.IDTIPOCUENTAComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTIPOCUENTAComboBox.Name = "IDTIPOCUENTAComboBox"
        Me.IDTIPOCUENTAComboBox.Size = New System.Drawing.Size(180, 26)
        Me.IDTIPOCUENTAComboBox.TabIndex = 1
        Me.IDTIPOCUENTAComboBox.ValueMember = "IDTIPOCUENTA"
        '
        'IDCLIENTEComboBox
        '
        Me.IDCLIENTEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUENTABindingSource, "IDCLIENTE", True))
        Me.IDCLIENTEComboBox.DataSource = Me.CLIENTEBindingSource
        Me.IDCLIENTEComboBox.DisplayMember = "NOMBRE"
        Me.IDCLIENTEComboBox.FormattingEnabled = True
        Me.IDCLIENTEComboBox.Location = New System.Drawing.Point(191, 54)
        Me.IDCLIENTEComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDCLIENTEComboBox.Name = "IDCLIENTEComboBox"
        Me.IDCLIENTEComboBox.Size = New System.Drawing.Size(180, 26)
        Me.IDCLIENTEComboBox.TabIndex = 0
        Me.IDCLIENTEComboBox.ValueMember = "IDCLIENTE"
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(423, 222)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(127, 41)
        Me.btGuardar.TabIndex = 4
        Me.btGuardar.Text = "Crear Cuenta"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(638, 371)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.IDCLIENTEComboBox)
        Me.TabPage1.Controls.Add(Me.btGuardar)
        Me.TabPage1.Controls.Add(IDCLIENTELabel)
        Me.TabPage1.Controls.Add(ESTADOLabel)
        Me.TabPage1.Controls.Add(Me.IDTIPOCUENTAComboBox)
        Me.TabPage1.Controls.Add(Me.ESTADOTextBox)
        Me.TabPage1.Controls.Add(IDTIPOCUENTALabel)
        Me.TabPage1.Controls.Add(SALDOLabel)
        Me.TabPage1.Controls.Add(Me.SALDOTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(630, 340)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(630, 340)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(420, 80)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(73, 18)
        Label1.TabIndex = 17
        Label1.Text = "BORAME"
        '
        'frmCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 371)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCuenta"
        Me.Text = "Funciones Con Cuentas"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTARJETACUENTA1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOCUENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents IDCLIENTEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
