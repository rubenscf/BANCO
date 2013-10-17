Imports Oracle.ManagedDataAccess.Client

Public Class Form1

    'declaracion de variables para la conexion a la base de datos 
    Public _strcnn As String = "DATA SOURCE=localhost:1521/XE; PERSIST SECURITY INFO=True;USER ID=agencia;PASSWORD=sistemas;"
    '_strcnn = "DATA SOURCE=;PERSIST SECURITY INFO=True;USER ID=taller;Password=sistemas;" 
    Public _cnn As New OracleConnection(_strcnn)
    Public _cmd As New OracleCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim ventana As New frmCliente
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        Dim ventana As New frmempleado
        ventana.MdiParent = Me
        ventana.Show()
    End Sub
End Class
