Public Class Form1


    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuCuenta.Click
        Dim ventana As New frmCuenta
        ventana.MdiParent = Me
        ventana.Show()
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
End Class
