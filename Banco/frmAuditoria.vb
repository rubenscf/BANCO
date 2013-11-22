Imports Oracle.ManagedDataAccess.Client
Public Class frmAuditoria
    Dim datos As New funcionesvarias
    Dim DTS As New DataTable

    Dim cadena, ID As String
    Private Sub frmAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga()



    End Sub
    Private Sub carga()
        Try


            cadena = "SELECT * FROM TRANSACCION WHERE TRANSACCION.FECHA BETWEEN '" + DTPI.Value.ToShortDateString + "' AND '" + DTPF.Value.ToShortDateString + "'"
            DTS = datos.llenarDGV(cadena)
            dg.DataSource = DTS




        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        carga()

    End Sub

    Private Sub DTPF_ValueChanged(sender As Object, e As EventArgs) Handles DTPF.ValueChanged
        If DTPI.Value > DTPF.Value Then
            MsgBox("Rango de fechas invalido", vbCritical)
            DTPF.Value = DTPI.Value
            DTPF.Focus()
        End If
    End Sub
End Class