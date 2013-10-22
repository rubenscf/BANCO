<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCuenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaTarjetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultarSaldo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAuditoria = New System.Windows.Forms.ToolStripMenuItem()
        Me.SISTEMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCuenta, Me.mnuConsultarSaldo, Me.mnuTransaccion, Me.mnuAuditoria, Me.SISTEMAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCuenta
        '
        Me.mnuCuenta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.NuevaCuentaToolStripMenuItem, Me.NuevaTarjetaToolStripMenuItem})
        Me.mnuCuenta.Name = "mnuCuenta"
        Me.mnuCuenta.Size = New System.Drawing.Size(65, 20)
        Me.mnuCuenta.Text = "CUENTA"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'NuevaCuentaToolStripMenuItem
        '
        Me.NuevaCuentaToolStripMenuItem.Name = "NuevaCuentaToolStripMenuItem"
        Me.NuevaCuentaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaCuentaToolStripMenuItem.Text = "Nueva Cuenta"
        '
        'NuevaTarjetaToolStripMenuItem
        '
        Me.NuevaTarjetaToolStripMenuItem.Name = "NuevaTarjetaToolStripMenuItem"
        Me.NuevaTarjetaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaTarjetaToolStripMenuItem.Text = "Nueva Tarjeta"
        '
        'mnuConsultarSaldo
        '
        Me.mnuConsultarSaldo.Name = "mnuConsultarSaldo"
        Me.mnuConsultarSaldo.Size = New System.Drawing.Size(127, 20)
        Me.mnuConsultarSaldo.Text = "CONSULTAR SALDO"
        '
        'mnuTransaccion
        '
        Me.mnuTransaccion.Name = "mnuTransaccion"
        Me.mnuTransaccion.Size = New System.Drawing.Size(113, 20)
        Me.mnuTransaccion.Text = "TRANSACCIONES"
        '
        'mnuAuditoria
        '
        Me.mnuAuditoria.Name = "mnuAuditoria"
        Me.mnuAuditoria.Size = New System.Drawing.Size(80, 20)
        Me.mnuAuditoria.Text = "AUDITORIA"
        '
        'SISTEMAToolStripMenuItem
        '
        Me.SISTEMAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem})
        Me.SISTEMAToolStripMenuItem.Name = "SISTEMAToolStripMenuItem"
        Me.SISTEMAToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.SISTEMAToolStripMenuItem.Text = "SISTEMA"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 403)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuCuenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaTarjetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultarSaldo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAuditoria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SISTEMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
