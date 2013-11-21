Public Class Form1
    Public IDEMPLEADO As String

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuCuenta.Click
       
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim ventana As New frmCliente
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim ventana As New frm_Empleados
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub mnuTransaccion_Click(sender As Object, e As EventArgs) Handles mnuTransaccion.Click
        Dim ventana As New frm_Transaccion
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

  
    Private Sub NuevaTarjetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaTarjetaToolStripMenuItem.Click
        Dim ventana As New frmtarjeta
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

   

   
    Private Sub mnuConsultarSaldo_Click(sender As Object, e As EventArgs) Handles mnuConsultarSaldo.Click
        Dim ventana As New frmsaldo
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSFECHA.Text = DateTime.Now.ToString("dd/MM/yyyy").ToString
        iniciar()

    End Sub

    Private Sub IniciarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciaS.Click
        Dim ventana As New login
        ventana.MdiParent = Me
        ventana.Show()
    End Sub
    Private Sub iniciar()
        mnuAuditoria.Enabled = False
        mnuConsultarSaldo.Enabled = False
        mnuCuenta.Enabled = False
        mnuTransaccion.Enabled = False
        mnuEmpleados.Enabled = False
        CerarS.Enabled = False

        mnuAuditoria.Visible = False
        mnuConsultarSaldo.Visible = False
        mnuCuenta.Visible = False
        mnuTransaccion.Visible = False
        mnuEmpleados.Visible = False
        CerarS.Visible = False
    End Sub

    Private Sub CerarS_Click(sender As Object, e As EventArgs) Handles CerarS.Click
        iniciar()
        TBRANGO.Text = ""
        TBUSER.Text = ""
        IniciaS.Visible = True
        IniciaS.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TBHORA.Text = TimeOfDay.TimeOfDay.ToString
    End Sub

    Private Sub mnuAuditoria_Click(sender As Object, e As EventArgs) Handles mnuAuditoria.Click
        Dim ventana As New frmAuditoria
        ventana.MdiParent = Me
        ventana.Show()
    End Sub
End Class
