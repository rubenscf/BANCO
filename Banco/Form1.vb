Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim ventana As New frmCliente
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim ventana As New frmCuenta
        ventana.MdiParent = Me
        ventana.Show()
    End Sub
End Class
