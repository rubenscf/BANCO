<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim TELEFONOLabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim DPILabel As System.Windows.Forms.Label
        Dim APELLIDOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.DS = New Banco.DS()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTETableAdapter = New Banco.DSTableAdapters.CLIENTETableAdapter()
        Me.TableAdapterManager = New Banco.DSTableAdapters.TableAdapterManager()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBTEL = New System.Windows.Forms.TextBox()
        Me.TBDIR = New System.Windows.Forms.TextBox()
        Me.TBAPELLIDO = New System.Windows.Forms.TextBox()
        Me.TBSALDO = New System.Windows.Forms.TextBox()
        Me.TBNOMBRE = New System.Windows.Forms.TextBox()
        Me.TBDPI = New System.Windows.Forms.TextBox()
        Me.TBTCUENTA = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TBMONTOA = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TELEFONOTextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCIONTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.DPITextBox = New System.Windows.Forms.TextBox()
        Me.CBTCUENTA = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        TELEFONOLabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        DPILabel = New System.Windows.Forms.Label()
        APELLIDOLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Me.CLIENTETableAdapter
        Me.TableAdapterManager.CUENTATableAdapter = Nothing
        Me.TableAdapterManager.DEPARTAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOTableAdapter = Nothing
        Me.TableAdapterManager.PUESTOTableAdapter = Nothing
        Me.TableAdapterManager.TARJETATableAdapter = Nothing
        Me.TableAdapterManager.TIPOCUENTATableAdapter = Nothing
        Me.TableAdapterManager.TRANSACIONTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Banco.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.TextBox8)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(590, 315)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cancelar cuenta"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(461, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "ACEPTAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TBTCUENTA)
        Me.GroupBox2.Controls.Add(Me.TBDPI)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.TBNOMBRE)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Label10)
        Me.GroupBox2.Controls.Add(Me.TBSALDO)
        Me.GroupBox2.Controls.Add(Me.TBAPELLIDO)
        Me.GroupBox2.Controls.Add(Label6)
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(Me.TBDIR)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Label9)
        Me.GroupBox2.Controls.Add(Me.TBTEL)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(26, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 216)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMACION DE LA CUENTA"
        '
        'TBTEL
        '
        Me.TBTEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTEL.Location = New System.Drawing.Point(281, 90)
        Me.TBTEL.Name = "TBTEL"
        Me.TBTEL.Size = New System.Drawing.Size(121, 24)
        Me.TBTEL.TabIndex = 9
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(181, 101)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(67, 13)
        Label9.TabIndex = 8
        Label9.Text = "TELEFONO:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(1, 97)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(69, 13)
        Label8.TabIndex = 6
        Label8.Text = "DIRECCION:"
        '
        'TBDIR
        '
        Me.TBDIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDIR.Location = New System.Drawing.Point(76, 94)
        Me.TBDIR.Name = "TBDIR"
        Me.TBDIR.Size = New System.Drawing.Size(100, 24)
        Me.TBDIR.TabIndex = 7
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(42, 22)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(28, 13)
        Label7.TabIndex = 0
        Label7.Text = "DPI:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(181, 59)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(62, 13)
        Label6.TabIndex = 4
        Label6.Text = "APELLIDO:"
        '
        'TBAPELLIDO
        '
        Me.TBAPELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAPELLIDO.Location = New System.Drawing.Point(281, 52)
        Me.TBAPELLIDO.Name = "TBAPELLIDO"
        Me.TBAPELLIDO.Size = New System.Drawing.Size(121, 24)
        Me.TBAPELLIDO.TabIndex = 5
        '
        'TBSALDO
        '
        Me.TBSALDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSALDO.Location = New System.Drawing.Point(76, 132)
        Me.TBSALDO.Name = "TBSALDO"
        Me.TBSALDO.Size = New System.Drawing.Size(100, 24)
        Me.TBSALDO.TabIndex = 11
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(13, 132)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(43, 13)
        Label10.TabIndex = 10
        Label10.Text = "SALDO"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(13, 59)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(57, 13)
        Label5.TabIndex = 2
        Label5.Text = "NOMBRE:"
        '
        'TBNOMBRE
        '
        Me.TBNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNOMBRE.Location = New System.Drawing.Point(76, 56)
        Me.TBNOMBRE.Name = "TBNOMBRE"
        Me.TBNOMBRE.Size = New System.Drawing.Size(100, 24)
        Me.TBNOMBRE.TabIndex = 3
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(178, 139)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(97, 13)
        Label3.TabIndex = 12
        Label3.Text = "TIPO DE CUENTA"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TBDPI
        '
        Me.TBDPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDPI.Location = New System.Drawing.Point(76, 19)
        Me.TBDPI.Name = "TBDPI"
        Me.TBDPI.Size = New System.Drawing.Size(100, 24)
        Me.TBDPI.TabIndex = 1
        '
        'TBTCUENTA
        '
        Me.TBTCUENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTCUENTA.Location = New System.Drawing.Point(281, 132)
        Me.TBTCUENTA.Name = "TBTCUENTA"
        Me.TBTCUENTA.Size = New System.Drawing.Size(121, 24)
        Me.TBTCUENTA.TabIndex = 13
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(127, 30)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(201, 20)
        Me.TextBox8.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Banco.My.Resources.Resources.search
        Me.Button4.Location = New System.Drawing.Point(334, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 41)
        Me.Button4.TabIndex = 2
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Banco.My.Resources.Resources._38
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(390, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 41)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "No. de Cuenta"
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.CBTCUENTA)
        Me.TabPage1.Controls.Add(Label2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Label4)
        Me.TabPage1.Controls.Add(Me.TBMONTOA)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(590, 315)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Aperturar Cuenta"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "APERTURA DE CUENTA"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(435, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TBMONTOA
        '
        Me.TBMONTOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMONTOA.Location = New System.Drawing.Point(262, 96)
        Me.TBMONTOA.Name = "TBMONTOA"
        Me.TBMONTOA.Size = New System.Drawing.Size(121, 24)
        Me.TBMONTOA.TabIndex = 3
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(255, 77)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(130, 13)
        Label4.TabIndex = 2
        Label4.Text = "MONTO  DE APERTURA"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DPITextBox)
        Me.GroupBox1.Controls.Add(Me.NOMBRETextBox)
        Me.GroupBox1.Controls.Add(NOMBRELabel)
        Me.GroupBox1.Controls.Add(Me.APELLIDOTextBox)
        Me.GroupBox1.Controls.Add(APELLIDOLabel)
        Me.GroupBox1.Controls.Add(DPILabel)
        Me.GroupBox1.Controls.Add(Me.DIRECCIONTextBox)
        Me.GroupBox1.Controls.Add(DIRECCIONLabel)
        Me.GroupBox1.Controls.Add(TELEFONOLabel)
        Me.GroupBox1.Controls.Add(Me.TELEFONOTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 243)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos personales"
        '
        'TELEFONOTextBox
        '
        Me.TELEFONOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TELEFONOTextBox.Location = New System.Drawing.Point(76, 185)
        Me.TELEFONOTextBox.Name = "TELEFONOTextBox"
        Me.TELEFONOTextBox.Size = New System.Drawing.Size(100, 24)
        Me.TELEFONOTextBox.TabIndex = 9
        '
        'TELEFONOLabel
        '
        TELEFONOLabel.AutoSize = True
        TELEFONOLabel.Location = New System.Drawing.Point(8, 185)
        TELEFONOLabel.Name = "TELEFONOLabel"
        TELEFONOLabel.Size = New System.Drawing.Size(67, 13)
        TELEFONOLabel.TabIndex = 8
        TELEFONOLabel.Text = "TELEFONO:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(1, 142)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(69, 13)
        DIRECCIONLabel.TabIndex = 6
        DIRECCIONLabel.Text = "DIRECCION:"
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(76, 139)
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(100, 24)
        Me.DIRECCIONTextBox.TabIndex = 7
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Location = New System.Drawing.Point(42, 22)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(28, 13)
        DPILabel.TabIndex = 0
        DPILabel.Text = "DPI:"
        '
        'APELLIDOLabel
        '
        APELLIDOLabel.AutoSize = True
        APELLIDOLabel.Location = New System.Drawing.Point(8, 100)
        APELLIDOLabel.Name = "APELLIDOLabel"
        APELLIDOLabel.Size = New System.Drawing.Size(62, 13)
        APELLIDOLabel.TabIndex = 4
        APELLIDOLabel.Text = "APELLIDO:"
        '
        'APELLIDOTextBox
        '
        Me.APELLIDOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APELLIDOTextBox.Location = New System.Drawing.Point(76, 97)
        Me.APELLIDOTextBox.Name = "APELLIDOTextBox"
        Me.APELLIDOTextBox.Size = New System.Drawing.Size(100, 24)
        Me.APELLIDOTextBox.TabIndex = 5
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(13, 59)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 2
        NOMBRELabel.Text = "NOMBRE:"
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(76, 56)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(100, 24)
        Me.NOMBRETextBox.TabIndex = 3
        '
        'DPITextBox
        '
        Me.DPITextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPITextBox.Location = New System.Drawing.Point(76, 19)
        Me.DPITextBox.Name = "DPITextBox"
        Me.DPITextBox.Size = New System.Drawing.Size(100, 24)
        Me.DPITextBox.TabIndex = 1
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(266, 152)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(97, 13)
        Label2.TabIndex = 4
        Label2.Text = "TIPO DE CUENTA"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBTCUENTA
        '
        Me.CBTCUENTA.FormattingEnabled = True
        Me.CBTCUENTA.Items.AddRange(New Object() {"Cuenta de ahorros", "Cuenta de mercado monetario"})
        Me.CBTCUENTA.Location = New System.Drawing.Point(264, 169)
        Me.CBTCUENTA.Name = "CBTCUENTA"
        Me.CBTCUENTA.Size = New System.Drawing.Size(121, 21)
        Me.CBTCUENTA.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Banco.My.Resources.Resources._38
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(435, 137)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 41)
        Me.Button5.TabIndex = 7
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(598, 341)
        Me.TabControl1.TabIndex = 0
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 341)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmCliente"
        Me.Text = "Apertura de cuenta"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS As Banco.DS
    Friend WithEvents CLIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTETableAdapter As Banco.DSTableAdapters.CLIENTETableAdapter
    Friend WithEvents TableAdapterManager As Banco.DSTableAdapters.TableAdapterManager
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TBTCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents TBDPI As System.Windows.Forms.TextBox
    Friend WithEvents TBNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TBSALDO As System.Windows.Forms.TextBox
    Friend WithEvents TBAPELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents TBDIR As System.Windows.Forms.TextBox
    Friend WithEvents TBTEL As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CBTCUENTA As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DPITextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIRECCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TELEFONOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TBMONTOA As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
