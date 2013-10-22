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
        Dim DPILabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim APELLIDOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.cobros = New System.Windows.Forms.TabPage()
        Me.pagos = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DPITextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCIONTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        DPILabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        APELLIDOLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.cobros.SuspendLayout()
        Me.pagos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.cobros)
        Me.TabControl1.Controls.Add(Me.pagos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(666, 336)
        Me.TabControl1.TabIndex = 0
        '
        'cobros
        '
        Me.cobros.Controls.Add(Me.Button2)
        Me.cobros.Controls.Add(Me.Label1)
        Me.cobros.Controls.Add(DPILabel)
        Me.cobros.Controls.Add(Me.DPITextBox)
        Me.cobros.Controls.Add(DIRECCIONLabel)
        Me.cobros.Controls.Add(Me.DIRECCIONTextBox)
        Me.cobros.Controls.Add(APELLIDOLabel)
        Me.cobros.Controls.Add(Me.APELLIDOTextBox)
        Me.cobros.Controls.Add(NOMBRELabel)
        Me.cobros.Controls.Add(Me.NOMBRETextBox)
        Me.cobros.Location = New System.Drawing.Point(4, 22)
        Me.cobros.Name = "cobros"
        Me.cobros.Padding = New System.Windows.Forms.Padding(3)
        Me.cobros.Size = New System.Drawing.Size(658, 310)
        Me.cobros.TabIndex = 0
        Me.cobros.Text = "Cobros"
        Me.cobros.UseVisualStyleBackColor = True
        '
        'pagos
        '
        Me.pagos.Controls.Add(Me.Button1)
        Me.pagos.Controls.Add(Me.Label2)
        Me.pagos.Controls.Add(Label3)
        Me.pagos.Controls.Add(Me.TextBox1)
        Me.pagos.Controls.Add(Label4)
        Me.pagos.Controls.Add(Me.TextBox2)
        Me.pagos.Controls.Add(Label5)
        Me.pagos.Controls.Add(Me.TextBox3)
        Me.pagos.Controls.Add(Label6)
        Me.pagos.Controls.Add(Me.TextBox4)
        Me.pagos.Controls.Add(Label7)
        Me.pagos.Controls.Add(Me.TextBox5)
        Me.pagos.Location = New System.Drawing.Point(4, 22)
        Me.pagos.Name = "pagos"
        Me.pagos.Padding = New System.Windows.Forms.Padding(3)
        Me.pagos.Size = New System.Drawing.Size(658, 310)
        Me.pagos.TabIndex = 1
        Me.pagos.Text = "TabPage2"
        Me.pagos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "COBRO EFECTIVO"
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Location = New System.Drawing.Point(59, 93)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(52, 13)
        DPILabel.TabIndex = 20
        DPILabel.Text = "CLIENTE"
        AddHandler DPILabel.Click, AddressOf Me.DPILabel_Click
        '
        'DPITextBox
        '
        Me.DPITextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPITextBox.Location = New System.Drawing.Point(133, 93)
        Me.DPITextBox.Name = "DPITextBox"
        Me.DPITextBox.Size = New System.Drawing.Size(100, 24)
        Me.DPITextBox.TabIndex = 0
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(59, 170)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(42, 13)
        DIRECCIONLabel.TabIndex = 18
        DIRECCIONLabel.Text = "FECHA"
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(134, 167)
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(100, 24)
        Me.DIRECCIONTextBox.TabIndex = 2
        '
        'APELLIDOLabel
        '
        APELLIDOLabel.AutoSize = True
        APELLIDOLabel.Location = New System.Drawing.Point(257, 137)
        APELLIDOLabel.Name = "APELLIDOLabel"
        APELLIDOLabel.Size = New System.Drawing.Size(55, 13)
        APELLIDOLabel.TabIndex = 14
        APELLIDOLabel.Text = "DETALLE"
        '
        'APELLIDOTextBox
        '
        Me.APELLIDOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APELLIDOTextBox.Location = New System.Drawing.Point(325, 134)
        Me.APELLIDOTextBox.Name = "APELLIDOTextBox"
        Me.APELLIDOTextBox.Size = New System.Drawing.Size(100, 24)
        Me.APELLIDOTextBox.TabIndex = 3
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(60, 134)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(51, 13)
        NOMBRELabel.TabIndex = 12
        NOMBRELabel.Text = "CUENTA"
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(133, 130)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(100, 24)
        Me.NOMBRETextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "PAGO EFECTIVO"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(65, 101)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(52, 13)
        Label3.TabIndex = 31
        Label3.Text = "CLIENTE"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(139, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 22
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(65, 178)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(42, 13)
        Label5.TabIndex = 29
        Label5.Text = "FECHA"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(140, 175)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 24)
        Me.TextBox3.TabIndex = 24
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(304, 101)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(55, 13)
        Label6.TabIndex = 28
        Label6.Text = "DETALLE"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(372, 98)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 24)
        Me.TextBox4.TabIndex = 25
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(66, 142)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(51, 13)
        Label7.TabIndex = 27
        Label7.Text = "CUENTA"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(139, 138)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 24)
        Me.TextBox5.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(242, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 54)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(372, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 54)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(288, 178)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(85, 13)
        Label4.TabIndex = 30
        Label4.Text = "MONTO TOTAL"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(379, 167)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 24)
        Me.TextBox2.TabIndex = 26
        '
        'frm_Transaccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 336)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_Transaccion"
        Me.Text = "TRANSACCIONES"
        Me.TabControl1.ResumeLayout(False)
        Me.cobros.ResumeLayout(False)
        Me.cobros.PerformLayout()
        Me.pagos.ResumeLayout(False)
        Me.pagos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents cobros As System.Windows.Forms.TabPage
    Friend WithEvents pagos As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DPITextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIRECCIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
