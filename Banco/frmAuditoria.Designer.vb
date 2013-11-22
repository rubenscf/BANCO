<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditoria
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.DS = New Banco.DS()
        Me.TRANSACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRANSACIONTableAdapter = New Banco.DSTableAdapters.TRANSACIONTableAdapter()
        Me.DTPI = New System.Windows.Forms.DateTimePicker()
        Me.DTPF = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(-3, 63)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(744, 245)
        Me.dg.TabIndex = 0
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRANSACIONBindingSource
        '
        Me.TRANSACIONBindingSource.DataMember = "TRANSACION"
        Me.TRANSACIONBindingSource.DataSource = Me.DS
        '
        'TRANSACIONTableAdapter
        '
        Me.TRANSACIONTableAdapter.ClearBeforeFill = True
        '
        'DTPI
        '
        Me.DTPI.Location = New System.Drawing.Point(127, 17)
        Me.DTPI.Name = "DTPI"
        Me.DTPI.Size = New System.Drawing.Size(186, 20)
        Me.DTPI.TabIndex = 1
        '
        'DTPF
        '
        Me.DTPF.Location = New System.Drawing.Point(394, 17)
        Me.DTPF.Name = "DTPF"
        Me.DTPF.Size = New System.Drawing.Size(186, 20)
        Me.DTPF.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = Global.Banco.My.Resources.Resources._16
        Me.Button1.Location = New System.Drawing.Point(634, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 55)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha de inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha de Fin"
        '
        'frmAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(744, 317)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTPF)
        Me.Controls.Add(Me.DTPI)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmAuditoria"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents DS As Banco.DS
    Friend WithEvents TRANSACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TRANSACIONTableAdapter As Banco.DSTableAdapters.TRANSACIONTableAdapter
    Friend WithEvents DTPI As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
