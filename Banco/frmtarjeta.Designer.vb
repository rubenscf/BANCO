<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtarjeta
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
        Dim IDCLIENTELabel As System.Windows.Forms.Label
        Me.DS = New Banco.DS()
        Me.TARJETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TARJETATableAdapter = New Banco.DSTableAdapters.TARJETATableAdapter()
        Me.TableAdapterManager = New Banco.DSTableAdapters.TableAdapterManager()
        Me.IDCLIENTEComboBox = New System.Windows.Forms.ComboBox()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTETableAdapter = New Banco.DSTableAdapters.CLIENTETableAdapter()
        IDCLIENTELabel = New System.Windows.Forms.Label()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TARJETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TARJETABindingSource
        '
        Me.TARJETABindingSource.DataMember = "TARJETA"
        Me.TARJETABindingSource.DataSource = Me.DS
        '
        'TARJETATableAdapter
        '
        Me.TARJETATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Me.CLIENTETableAdapter
        Me.TableAdapterManager.CUENTATableAdapter = Nothing
        Me.TableAdapterManager.DEPARTAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOTableAdapter = Nothing
        Me.TableAdapterManager.PUESTOTableAdapter = Nothing
        Me.TableAdapterManager.TARJETATableAdapter = Me.TARJETATableAdapter
        Me.TableAdapterManager.TIPOCUENTATableAdapter = Nothing
        Me.TableAdapterManager.TRANSACIONTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Banco.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        '
        'IDCLIENTELabel
        '
        IDCLIENTELabel.AutoSize = True
        IDCLIENTELabel.Location = New System.Drawing.Point(56, 79)
        IDCLIENTELabel.Name = "IDCLIENTELabel"
        IDCLIENTELabel.Size = New System.Drawing.Size(66, 13)
        IDCLIENTELabel.TabIndex = 1
        IDCLIENTELabel.Text = "IDCLIENTE:"
        '
        'IDCLIENTEComboBox
        '
        Me.IDCLIENTEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TARJETABindingSource, "IDCLIENTE", True))
        Me.IDCLIENTEComboBox.DataSource = Me.CLIENTEBindingSource
        Me.IDCLIENTEComboBox.DisplayMember = "NOMBRE"
        Me.IDCLIENTEComboBox.FormattingEnabled = True
        Me.IDCLIENTEComboBox.Location = New System.Drawing.Point(128, 76)
        Me.IDCLIENTEComboBox.Name = "IDCLIENTEComboBox"
        Me.IDCLIENTEComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IDCLIENTEComboBox.TabIndex = 2
        Me.IDCLIENTEComboBox.ValueMember = "IDCLIENTE"
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
        'frmtarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 359)
        Me.Controls.Add(IDCLIENTELabel)
        Me.Controls.Add(Me.IDCLIENTEComboBox)
        Me.Name = "frmtarjeta"
        Me.Text = "Tarjeta"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TARJETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As Banco.DS
    Friend WithEvents TARJETABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TARJETATableAdapter As Banco.DSTableAdapters.TARJETATableAdapter
    Friend WithEvents TableAdapterManager As Banco.DSTableAdapters.TableAdapterManager
    Friend WithEvents CLIENTETableAdapter As Banco.DSTableAdapters.CLIENTETableAdapter
    Friend WithEvents IDCLIENTEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CLIENTEBindingSource As System.Windows.Forms.BindingSource
End Class
