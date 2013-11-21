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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCuenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaTarjetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultarSaldo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAuditoria = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciaS = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerarS = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TBUSER = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TBRANGO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSFECHA = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TBHORA = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCuenta, Me.mnuConsultarSaldo, Me.mnuTransaccion, Me.mnuAuditoria, Me.mnuEmpleados, Me.SesionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 56)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCuenta
        '
        Me.mnuCuenta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.NuevaTarjetaToolStripMenuItem})
        Me.mnuCuenta.Image = Global.Banco.My.Resources.Resources._87
        Me.mnuCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuCuenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuCuenta.Name = "mnuCuenta"
        Me.mnuCuenta.Size = New System.Drawing.Size(113, 52)
        Me.mnuCuenta.Text = "CUENTA"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Image = Global.Banco.My.Resources.Resources.registro_icono_8748_32
        Me.ClientesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(181, 38)
        Me.ClientesToolStripMenuItem1.Text = "Aperturar Cuenta"
        '
        'NuevaTarjetaToolStripMenuItem
        '
        Me.NuevaTarjetaToolStripMenuItem.Image = Global.Banco.My.Resources.Resources.credit
        Me.NuevaTarjetaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevaTarjetaToolStripMenuItem.Name = "NuevaTarjetaToolStripMenuItem"
        Me.NuevaTarjetaToolStripMenuItem.Size = New System.Drawing.Size(181, 38)
        Me.NuevaTarjetaToolStripMenuItem.Text = "Nueva Tarjeta"
        '
        'mnuConsultarSaldo
        '
        Me.mnuConsultarSaldo.Image = Global.Banco.My.Resources.Resources._10
        Me.mnuConsultarSaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuConsultarSaldo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuConsultarSaldo.Name = "mnuConsultarSaldo"
        Me.mnuConsultarSaldo.Size = New System.Drawing.Size(175, 52)
        Me.mnuConsultarSaldo.Text = "CONSULTAR SALDO"
        '
        'mnuTransaccion
        '
        Me.mnuTransaccion.Image = Global.Banco.My.Resources.Resources._80
        Me.mnuTransaccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuTransaccion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuTransaccion.Name = "mnuTransaccion"
        Me.mnuTransaccion.Size = New System.Drawing.Size(161, 52)
        Me.mnuTransaccion.Text = "TRANSACCIONES"
        '
        'mnuAuditoria
        '
        Me.mnuAuditoria.Image = Global.Banco.My.Resources.Resources._15
        Me.mnuAuditoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuAuditoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuAuditoria.Name = "mnuAuditoria"
        Me.mnuAuditoria.Size = New System.Drawing.Size(128, 52)
        Me.mnuAuditoria.Text = "AUDITORIA"
        '
        'mnuEmpleados
        '
        Me.mnuEmpleados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem})
        Me.mnuEmpleados.Image = Global.Banco.My.Resources.Resources._120
        Me.mnuEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuEmpleados.Name = "mnuEmpleados"
        Me.mnuEmpleados.Size = New System.Drawing.Size(114, 52)
        Me.mnuEmpleados.Text = "SISTEMA"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'SesionToolStripMenuItem
        '
        Me.SesionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciaS, Me.CerarS})
        Me.SesionToolStripMenuItem.Image = Global.Banco.My.Resources.Resources.user
        Me.SesionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SesionToolStripMenuItem.Name = "SesionToolStripMenuItem"
        Me.SesionToolStripMenuItem.Size = New System.Drawing.Size(44, 52)
        '
        'IniciaS
        '
        Me.IniciaS.Image = Global.Banco.My.Resources.Resources.connect
        Me.IniciaS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IniciaS.Name = "IniciaS"
        Me.IniciaS.Size = New System.Drawing.Size(143, 22)
        Me.IniciaS.Text = "Iniciar Sesión"
        '
        'CerarS
        '
        Me.CerarS.Image = Global.Banco.My.Resources.Resources.cancel
        Me.CerarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CerarS.Name = "CerarS"
        Me.CerarS.Size = New System.Drawing.Size(143, 22)
        Me.CerarS.Text = "Cerrar Sesión"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.TBUSER, Me.TBRANGO, Me.ToolStripStatusLabel4, Me.TSFECHA, Me.TBHORA})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 381)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(792, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'TBUSER
        '
        Me.TBUSER.BackColor = System.Drawing.Color.Transparent
        Me.TBUSER.Name = "TBUSER"
        Me.TBUSER.Size = New System.Drawing.Size(57, 17)
        Me.TBUSER.Text = "----------"
        '
        'TBRANGO
        '
        Me.TBRANGO.BackColor = System.Drawing.Color.Transparent
        Me.TBRANGO.Name = "TBRANGO"
        Me.TBRANGO.Size = New System.Drawing.Size(77, 17)
        Me.TBRANGO.Text = "--------------"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel4.Text = "Fecha"
        '
        'TSFECHA
        '
        Me.TSFECHA.BackColor = System.Drawing.Color.Transparent
        Me.TSFECHA.Name = "TSFECHA"
        Me.TSFECHA.Size = New System.Drawing.Size(0, 17)
        '
        'TBHORA
        '
        Me.TBHORA.BackColor = System.Drawing.Color.Transparent
        Me.TBHORA.Name = "TBHORA"
        Me.TBHORA.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Banco.My.Resources.Resources.FONDO1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 403)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuCuenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaTarjetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConsultarSaldo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAuditoria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciaS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerarS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TBUSER As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSFECHA As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TBRANGO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TBHORA As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
