<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmempleado
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
        Dim IDEMPLEADOLabel As System.Windows.Forms.Label
        Dim IDPUESTOLabel As System.Windows.Forms.Label
        Dim IDEPTOPLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim APELLIDOLabel As System.Windows.Forms.Label
        Dim DPILabel As System.Windows.Forms.Label
        Dim USUARIOLabel As System.Windows.Forms.Label
        Dim CONTRASENALabel As System.Windows.Forms.Label
        Me.DS = New Banco.DS()
        Me.EMPLEADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADOTableAdapter = New Banco.DSTableAdapters.EMPLEADOTableAdapter()
        Me.TableAdapterManager = New Banco.DSTableAdapters.TableAdapterManager()
        Me.IDEMPLEADOComboBox = New System.Windows.Forms.ComboBox()
        Me.IDPUESTOComboBox = New System.Windows.Forms.ComboBox()
        Me.PUESTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PUESTOTableAdapter = New Banco.DSTableAdapters.PUESTOTableAdapter()
        Me.EMPLEADOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDEPTOPComboBox = New System.Windows.Forms.ComboBox()
        Me.DEPARTAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEPARTAMENTOTableAdapter = New Banco.DSTableAdapters.DEPARTAMENTOTableAdapter()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOTextBox = New System.Windows.Forms.TextBox()
        Me.DPITextBox = New System.Windows.Forms.TextBox()
        Me.USUARIOTextBox = New System.Windows.Forms.TextBox()
        Me.CONTRASENATextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        IDEMPLEADOLabel = New System.Windows.Forms.Label()
        IDPUESTOLabel = New System.Windows.Forms.Label()
        IDEPTOPLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        APELLIDOLabel = New System.Windows.Forms.Label()
        DPILabel = New System.Windows.Forms.Label()
        USUARIOLabel = New System.Windows.Forms.Label()
        CONTRASENALabel = New System.Windows.Forms.Label()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUESTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADOBindingSource
        '
        Me.EMPLEADOBindingSource.DataMember = "EMPLEADO"
        Me.EMPLEADOBindingSource.DataSource = Me.DS
        '
        'EMPLEADOTableAdapter
        '
        Me.EMPLEADOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CUENTATableAdapter = Nothing
        Me.TableAdapterManager.DEPARTAMENTOTableAdapter = Me.DEPARTAMENTOTableAdapter
        Me.TableAdapterManager.EMPLEADOTableAdapter = Me.EMPLEADOTableAdapter
        Me.TableAdapterManager.PUESTOTableAdapter = Me.PUESTOTableAdapter
        Me.TableAdapterManager.TARJETATableAdapter = Nothing
        Me.TableAdapterManager.TIPOCUENTATableAdapter = Nothing
        Me.TableAdapterManager.TRANSACIONTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Banco.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        '
        'IDEMPLEADOLabel
        '
        IDEMPLEADOLabel.AutoSize = True
        IDEMPLEADOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDEMPLEADOLabel.Location = New System.Drawing.Point(48, 21)
        IDEMPLEADOLabel.Name = "IDEMPLEADOLabel"
        IDEMPLEADOLabel.Size = New System.Drawing.Size(109, 18)
        IDEMPLEADOLabel.TabIndex = 1
        IDEMPLEADOLabel.Text = "IDEMPLEADO:"
        '
        'IDEMPLEADOComboBox
        '
        Me.IDEMPLEADOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IDEMPLEADO", True))
        Me.IDEMPLEADOComboBox.DataSource = Me.EMPLEADOBindingSource
        Me.IDEMPLEADOComboBox.DisplayMember = "NOMBRE"
        Me.IDEMPLEADOComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDEMPLEADOComboBox.FormattingEnabled = True
        Me.IDEMPLEADOComboBox.Location = New System.Drawing.Point(41, 42)
        Me.IDEMPLEADOComboBox.Name = "IDEMPLEADOComboBox"
        Me.IDEMPLEADOComboBox.Size = New System.Drawing.Size(196, 26)
        Me.IDEMPLEADOComboBox.TabIndex = 2
        Me.IDEMPLEADOComboBox.ValueMember = "IDEMPLEADO"
        '
        'IDPUESTOLabel
        '
        IDPUESTOLabel.AutoSize = True
        IDPUESTOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDPUESTOLabel.Location = New System.Drawing.Point(38, 84)
        IDPUESTOLabel.Name = "IDPUESTOLabel"
        IDPUESTOLabel.Size = New System.Drawing.Size(88, 18)
        IDPUESTOLabel.TabIndex = 2
        IDPUESTOLabel.Text = "IDPUESTO:"
        '
        'IDPUESTOComboBox
        '
        Me.IDPUESTOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IDPUESTO", True))
        Me.IDPUESTOComboBox.DataSource = Me.PUESTOBindingSource
        Me.IDPUESTOComboBox.DisplayMember = "DESCRIPCION"
        Me.IDPUESTOComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDPUESTOComboBox.FormattingEnabled = True
        Me.IDPUESTOComboBox.Location = New System.Drawing.Point(41, 105)
        Me.IDPUESTOComboBox.Name = "IDPUESTOComboBox"
        Me.IDPUESTOComboBox.Size = New System.Drawing.Size(196, 26)
        Me.IDPUESTOComboBox.TabIndex = 3
        Me.IDPUESTOComboBox.ValueMember = "IDPUESTO"
        '
        'PUESTOBindingSource
        '
        Me.PUESTOBindingSource.DataMember = "PUESTO"
        Me.PUESTOBindingSource.DataSource = Me.DS
        '
        'PUESTOTableAdapter
        '
        Me.PUESTOTableAdapter.ClearBeforeFill = True
        '
        'EMPLEADOBindingSource1
        '
        Me.EMPLEADOBindingSource1.DataMember = "EMPLEADO"
        Me.EMPLEADOBindingSource1.DataSource = Me.DS
        '
        'IDEPTOPLabel
        '
        IDEPTOPLabel.AutoSize = True
        IDEPTOPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDEPTOPLabel.Location = New System.Drawing.Point(38, 158)
        IDEPTOPLabel.Name = "IDEPTOPLabel"
        IDEPTOPLabel.Size = New System.Drawing.Size(77, 18)
        IDEPTOPLabel.TabIndex = 4
        IDEPTOPLabel.Text = "IDEPTOP:"
        '
        'IDEPTOPComboBox
        '
        Me.IDEPTOPComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IDEPTOP", True))
        Me.IDEPTOPComboBox.DataSource = Me.DEPARTAMENTOBindingSource
        Me.IDEPTOPComboBox.DisplayMember = "DESCRIPCION"
        Me.IDEPTOPComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDEPTOPComboBox.FormattingEnabled = True
        Me.IDEPTOPComboBox.Location = New System.Drawing.Point(41, 179)
        Me.IDEPTOPComboBox.Name = "IDEPTOPComboBox"
        Me.IDEPTOPComboBox.Size = New System.Drawing.Size(196, 26)
        Me.IDEPTOPComboBox.TabIndex = 5
        Me.IDEPTOPComboBox.ValueMember = "IDDEPTO"
        '
        'DEPARTAMENTOBindingSource
        '
        Me.DEPARTAMENTOBindingSource.DataMember = "DEPARTAMENTO"
        Me.DEPARTAMENTOBindingSource.DataSource = Me.DS
        '
        'DEPARTAMENTOTableAdapter
        '
        Me.DEPARTAMENTOTableAdapter.ClearBeforeFill = True
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRELabel.Location = New System.Drawing.Point(265, 21)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(79, 18)
        NOMBRELabel.TabIndex = 6
        NOMBRELabel.Text = "NOMBRE:"
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(268, 42)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(196, 24)
        Me.NOMBRETextBox.TabIndex = 7
        '
        'APELLIDOLabel
        '
        APELLIDOLabel.AutoSize = True
        APELLIDOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        APELLIDOLabel.Location = New System.Drawing.Point(265, 84)
        APELLIDOLabel.Name = "APELLIDOLabel"
        APELLIDOLabel.Size = New System.Drawing.Size(83, 18)
        APELLIDOLabel.TabIndex = 8
        APELLIDOLabel.Text = "APELLIDO:"
        '
        'APELLIDOTextBox
        '
        Me.APELLIDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "APELLIDO", True))
        Me.APELLIDOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APELLIDOTextBox.Location = New System.Drawing.Point(268, 107)
        Me.APELLIDOTextBox.Name = "APELLIDOTextBox"
        Me.APELLIDOTextBox.Size = New System.Drawing.Size(196, 24)
        Me.APELLIDOTextBox.TabIndex = 9
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DPILabel.Location = New System.Drawing.Point(47, 229)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(36, 18)
        DPILabel.TabIndex = 10
        DPILabel.Text = "DPI:"
        '
        'DPITextBox
        '
        Me.DPITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "DPI", True))
        Me.DPITextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPITextBox.Location = New System.Drawing.Point(41, 250)
        Me.DPITextBox.Name = "DPITextBox"
        Me.DPITextBox.Size = New System.Drawing.Size(196, 24)
        Me.DPITextBox.TabIndex = 11
        '
        'USUARIOLabel
        '
        USUARIOLabel.AutoSize = True
        USUARIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        USUARIOLabel.Location = New System.Drawing.Point(269, 161)
        USUARIOLabel.Name = "USUARIOLabel"
        USUARIOLabel.Size = New System.Drawing.Size(79, 18)
        USUARIOLabel.TabIndex = 12
        USUARIOLabel.Text = "USUARIO:"
        '
        'USUARIOTextBox
        '
        Me.USUARIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "USUARIO", True))
        Me.USUARIOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USUARIOTextBox.Location = New System.Drawing.Point(268, 179)
        Me.USUARIOTextBox.Name = "USUARIOTextBox"
        Me.USUARIOTextBox.Size = New System.Drawing.Size(196, 24)
        Me.USUARIOTextBox.TabIndex = 13
        '
        'CONTRASENALabel
        '
        CONTRASENALabel.AutoSize = True
        CONTRASENALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CONTRASENALabel.Location = New System.Drawing.Point(265, 229)
        CONTRASENALabel.Name = "CONTRASENALabel"
        CONTRASENALabel.Size = New System.Drawing.Size(115, 18)
        CONTRASENALabel.TabIndex = 14
        CONTRASENALabel.Text = "CONTRASENA:"
        '
        'CONTRASENATextBox
        '
        Me.CONTRASENATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "CONTRASENA", True))
        Me.CONTRASENATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTRASENATextBox.Location = New System.Drawing.Point(268, 250)
        Me.CONTRASENATextBox.Name = "CONTRASENATextBox"
        Me.CONTRASENATextBox.Size = New System.Drawing.Size(196, 24)
        Me.CONTRASENATextBox.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(354, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 38)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmempleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 350)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CONTRASENALabel)
        Me.Controls.Add(Me.CONTRASENATextBox)
        Me.Controls.Add(USUARIOLabel)
        Me.Controls.Add(Me.USUARIOTextBox)
        Me.Controls.Add(DPILabel)
        Me.Controls.Add(Me.DPITextBox)
        Me.Controls.Add(APELLIDOLabel)
        Me.Controls.Add(Me.APELLIDOTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(IDEPTOPLabel)
        Me.Controls.Add(Me.IDEPTOPComboBox)
        Me.Controls.Add(IDPUESTOLabel)
        Me.Controls.Add(Me.IDPUESTOComboBox)
        Me.Controls.Add(IDEMPLEADOLabel)
        Me.Controls.Add(Me.IDEMPLEADOComboBox)
        Me.Name = "frmempleado"
        Me.Text = "frmempleado"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUESTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As Banco.DS
    Friend WithEvents EMPLEADOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPLEADOTableAdapter As Banco.DSTableAdapters.EMPLEADOTableAdapter
    Friend WithEvents TableAdapterManager As Banco.DSTableAdapters.TableAdapterManager
    Friend WithEvents IDEMPLEADOComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PUESTOTableAdapter As Banco.DSTableAdapters.PUESTOTableAdapter
    Friend WithEvents IDPUESTOComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PUESTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DEPARTAMENTOTableAdapter As Banco.DSTableAdapters.DEPARTAMENTOTableAdapter
    Friend WithEvents EMPLEADOBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IDEPTOPComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DEPARTAMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DPITextBox As System.Windows.Forms.TextBox
    Friend WithEvents USUARIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CONTRASENATextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
