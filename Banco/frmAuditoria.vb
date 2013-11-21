Imports Oracle.ManagedDataAccess.Client
Public Class frmAuditoria
    Dim datos As New funcionesvarias
    Dim DTS As New DataSet
    Dim cadena, ID As String
    Private Sub frmAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        carga()

    End Sub
    Private Sub carga()
        Try
            cadena = "SELECT * FROM TRANSACCION  ORDER BY IDTRANSACCION"
            DTS = datos.llenar(cadena)
            DataGridView1.DataSource = DTS.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())

        End Try

    End Sub
   
End Class