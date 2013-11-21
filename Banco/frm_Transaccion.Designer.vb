<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Transaccion
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DPILabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim APELLIDOLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.cobros = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CBDOC = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBAPELLIDO = New System.Windows.Forms.TextBox()
        Me.TBSALDO = New System.Windows.Forms.TextBox()
        Me.TBNOMBRE = New System.Windows.Forms.TextBox()
        Me.TBFECHA = New System.Windows.Forms.TextBox()
        Me.TBCUENTA = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBMONTOR = New System.Windows.Forms.TextBox()
        Me.pagos = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CBDOC1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBAPELLIDO1 = New System.Windows.Forms.TextBox()
        Me.TBSALDO1 = New System.Windows.Forms.TextBox()
        Me.TBNOMBRE1 = New System.Windows.Forms.TextBox()
        Me.TBFECHA1 = New System.Windows.Forms.TextBox()
        Me.TBCUENTA1 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBMONTOD = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        DPILabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        APELLIDOLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.cobros.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pagos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(436, 79)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(122, 13)
        Label6.TabIndex = 4
        Label6.Text = "MONTO A DEPOSITAR"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(200, 65)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(43, 13)
        Label1.TabIndex = 26
        Label1.Text = "SALDO"
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Location = New System.Drawing.Point(16, 31)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(54, 13)
        DPILabel.TabIndex = 20
        DPILabel.Text = "NOMBRE"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(16, 105)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(42, 13)
        DIRECCIONLabel.TabIndex = 18
        DIRECCIONLabel.Text = "FECHA"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(17, 65)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(51, 13)
        NOMBRELabel.TabIndex = 12
        NOMBRELabel.Text = "CUENTA"
        '
        'APELLIDOLabel
        '
        APELLIDOLabel.AutoSize = True
        APELLIDOLabel.Location = New System.Drawing.Point(446, 82)
        APELLIDOLabel.Name = "APELLIDOLabel"
        APELLIDOLabel.Size = New System.Drawing.Size(108, 13)
        APELLIDOLabel.TabIndex = 4
        APELLIDOLabel.Text = "MONTO A RETIRAR"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(200, 31)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(59, 13)
        Label9.TabIndex = 28
        Label9.Text = "APELLIDO"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(199, 29)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(59, 13)
        Label2.TabIndex = 38
        Label2.Text = "APELLIDO"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(199, 63)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 13)
        Label3.TabIndex = 36
        Label3.Text = "SALDO"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(15, 29)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(54, 13)
        Label4.TabIndex = 34
        Label4.Text = "NOMBRE"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(15, 103)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(42, 13)
        Label8.TabIndex = 33
        Label8.Text = "FECHA"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(16, 63)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(51, 13)
        Label10.TabIndex = 32
        Label10.Text = "CUENTA"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(465, 142)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(77, 13)
        Label11.TabIndex = 30
        Label11.Text = "DOCUMENTO"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(455, 122)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(77, 13)
        Label12.TabIndex = 32
        Label12.Text = "DOCUMENTO"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.cobros)
        Me.TabControl1.Controls.Add(Me.pagos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(615, 336)
        Me.TabControl1.TabIndex = 0
        '
        'cobros
        '
        Me.cobros.Controls.Add(Me.Button2)
        Me.cobros.Controls.Add(Label11)
        Me.cobros.Controls.Add(Me.CBDOC)
        Me.cobros.Controls.Add(Me.GroupBox2)
        Me.cobros.Controls.Add(Me.Button5)
        Me.cobros.Controls.Add(Me.TextBox8)
        Me.cobros.Controls.Add(Me.Button6)
        Me.cobros.Controls.Add(Me.Label7)
        Me.cobros.Controls.Add(APELLIDOLabel)
        Me.cobros.Controls.Add(Me.TBMONTOR)
        Me.cobros.Location = New System.Drawing.Point(4, 22)
        Me.cobros.Name = "cobros"
        Me.cobros.Padding = New System.Windows.Forms.Padding(3)
        Me.cobros.Size = New System.Drawing.Size(607, 310)
        Me.cobros.TabIndex = 0
        Me.cobros.Text = "RETIROS"
        Me.cobros.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Banco.My.Resources.Resources._38
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(383, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 41)
        Me.Button2.TabIndex = 44
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CBDOC
        '
        Me.CBDOC.FormattingEnabled = True
        Me.CBDOC.Items.AddRange(New Object() {"cheque", "boleta de retiro"})
        Me.CBDOC.Location = New System.Drawing.Point(435, 158)
        Me.CBDOC.Name = "CBDOC"
        Me.CBDOC.Size = New System.Drawing.Size(141, 21)
        Me.CBDOC.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label9)
        Me.GroupBox2.Controls.Add(Me.TBAPELLIDO)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.TBSALDO)
        Me.GroupBox2.Controls.Add(DPILabel)
        Me.GroupBox2.Controls.Add(Me.TBNOMBRE)
        Me.GroupBox2.Controls.Add(DIRECCIONLabel)
        Me.GroupBox2.Controls.Add(Me.TBFECHA)
        Me.GroupBox2.Controls.Add(NOMBRELabel)
        Me.GroupBox2.Controls.Add(Me.TBCUENTA)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(10, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 198)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'TBAPELLIDO
        '
        Me.TBAPELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAPELLIDO.Location = New System.Drawing.Point(270, 24)
        Me.TBAPELLIDO.Name = "TBAPELLIDO"
        Me.TBAPELLIDO.Size = New System.Drawing.Size(100, 24)
        Me.TBAPELLIDO.TabIndex = 27
        '
        'TBSALDO
        '
        Me.TBSALDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSALDO.Location = New System.Drawing.Point(270, 61)
        Me.TBSALDO.Name = "TBSALDO"
        Me.TBSALDO.Size = New System.Drawing.Size(100, 24)
        Me.TBSALDO.TabIndex = 25
        '
        'TBNOMBRE
        '
        Me.TBNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNOMBRE.Location = New System.Drawing.Point(90, 24)
        Me.TBNOMBRE.Name = "TBNOMBRE"
        Me.TBNOMBRE.Size = New System.Drawing.Size(100, 24)
        Me.TBNOMBRE.TabIndex = 0
        '
        'TBFECHA
        '
        Me.TBFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFECHA.Location = New System.Drawing.Point(91, 98)
        Me.TBFECHA.Name = "TBFECHA"
        Me.TBFECHA.Size = New System.Drawing.Size(100, 24)
        Me.TBFECHA.TabIndex = 2
        '
        'TBCUENTA
        '
        Me.TBCUENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCUENTA.Location = New System.Drawing.Point(90, 61)
        Me.TBCUENTA.Name = "TBCUENTA"
        Me.TBCUENTA.Size = New System.Drawing.Size(100, 24)
        Me.TBCUENTA.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.Banco.My.Resources.Resources.search
        Me.Button5.Location = New System.Drawing.Point(327, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 41)
        Me.Button5.TabIndex = 2
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(159, 24)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(155, 24)
        Me.TextBox8.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(435, 241)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 39)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Realizar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "NO. CUENTA"
        '
        'TBMONTOR
        '
        Me.TBMONTOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMONTOR.Location = New System.Drawing.Point(435, 98)
        Me.TBMONTOR.Name = "TBMONTOR"
        Me.TBMONTOR.Size = New System.Drawing.Size(141, 24)
        Me.TBMONTOR.TabIndex = 5
        '
        'pagos
        '
        Me.pagos.Controls.Add(Me.Button4)
        Me.pagos.Controls.Add(Label12)
        Me.pagos.Controls.Add(Me.CBDOC1)
        Me.pagos.Controls.Add(Me.GroupBox1)
        Me.pagos.Controls.Add(Me.TextBox6)
        Me.pagos.Controls.Add(Me.Button1)
        Me.pagos.Controls.Add(Me.Label5)
        Me.pagos.Controls.Add(Label6)
        Me.pagos.Controls.Add(Me.TBMONTOD)
        Me.pagos.Controls.Add(Me.Button3)
        Me.pagos.Location = New System.Drawing.Point(4, 22)
        Me.pagos.Name = "pagos"
        Me.pagos.Padding = New System.Windows.Forms.Padding(3)
        Me.pagos.Size = New System.Drawing.Size(607, 310)
        Me.pagos.TabIndex = 1
        Me.pagos.Text = "DEPOSITOS"
        Me.pagos.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Banco.My.Resources.Resources._38
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(383, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 41)
        Me.Button4.TabIndex = 45
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CBDOC1
        '
        Me.CBDOC1.FormattingEnabled = True
        Me.CBDOC1.Items.AddRange(New Object() {"cheque", "boleta de deposito"})
        Me.CBDOC1.Location = New System.Drawing.Point(425, 138)
        Me.CBDOC1.Name = "CBDOC1"
        Me.CBDOC1.Size = New System.Drawing.Size(141, 21)
        Me.CBDOC1.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TBAPELLIDO1)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.TBSALDO1)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.TBNOMBRE1)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.TBFECHA1)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Me.TBCUENTA1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(10, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 194)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'TBAPELLIDO1
        '
        Me.TBAPELLIDO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAPELLIDO1.Location = New System.Drawing.Point(269, 22)
        Me.TBAPELLIDO1.Name = "TBAPELLIDO1"
        Me.TBAPELLIDO1.Size = New System.Drawing.Size(100, 24)
        Me.TBAPELLIDO1.TabIndex = 37
        '
        'TBSALDO1
        '
        Me.TBSALDO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSALDO1.Location = New System.Drawing.Point(269, 59)
        Me.TBSALDO1.Name = "TBSALDO1"
        Me.TBSALDO1.Size = New System.Drawing.Size(100, 24)
        Me.TBSALDO1.TabIndex = 35
        '
        'TBNOMBRE1
        '
        Me.TBNOMBRE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNOMBRE1.Location = New System.Drawing.Point(89, 22)
        Me.TBNOMBRE1.Name = "TBNOMBRE1"
        Me.TBNOMBRE1.Size = New System.Drawing.Size(100, 24)
        Me.TBNOMBRE1.TabIndex = 29
        '
        'TBFECHA1
        '
        Me.TBFECHA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFECHA1.Location = New System.Drawing.Point(90, 96)
        Me.TBFECHA1.Name = "TBFECHA1"
        Me.TBFECHA1.Size = New System.Drawing.Size(100, 24)
        Me.TBFECHA1.TabIndex = 31
        '
        'TBCUENTA1
        '
        Me.TBCUENTA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCUENTA1.Location = New System.Drawing.Point(89, 59)
        Me.TBCUENTA1.Name = "TBCUENTA1"
        Me.TBCUENTA1.Size = New System.Drawing.Size(100, 24)
        Me.TBCUENTA1.TabIndex = 30
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(159, 21)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(155, 24)
        Me.TextBox6.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(425, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Realizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "NO. CUENTA"
        '
        'TBMONTOD
        '
        Me.TBMONTOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMONTOD.Location = New System.Drawing.Point(425, 95)
        Me.TBMONTOD.Name = "TBMONTOD"
        Me.TBMONTOD.Size = New System.Drawing.Size(141, 24)
        Me.TBMONTOD.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Banco.My.Resources.Resources.search
        Me.Button3.Location = New System.Drawing.Point(327, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frm_Transaccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 336)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_Transaccion"
        Me.Text = "TRANSACCIONES"
        Me.TabControl1.ResumeLayout(False)
        Me.cobros.ResumeLayout(False)
        Me.cobros.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pagos.ResumeLayout(False)
        Me.pagos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents cobros As System.Windows.Forms.TabPage
    Friend WithEvents pagos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TBSALDO As System.Windows.Forms.TextBox
    Friend WithEvents TBNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TBFECHA As System.Windows.Forms.TextBox
    Friend WithEvents TBCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBMONTOR As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBMONTOD As System.Windows.Forms.TextBox
    Friend WithEvents TBAPELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents TBAPELLIDO1 As System.Windows.Forms.TextBox
    Friend WithEvents TBSALDO1 As System.Windows.Forms.TextBox
    Friend WithEvents TBNOMBRE1 As System.Windows.Forms.TextBox
    Friend WithEvents TBFECHA1 As System.Windows.Forms.TextBox
    Friend WithEvents TBCUENTA1 As System.Windows.Forms.TextBox
    Friend WithEvents CBDOC As System.Windows.Forms.ComboBox
    Friend WithEvents CBDOC1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
