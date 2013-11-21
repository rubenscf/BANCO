Imports Oracle.ManagedDataAccess.Client
Imports System.Security.Cryptography
Public Class login
    Dim datos As New funcionesvarias
    Dim DTS As New DataSet
    Dim cadena, ID As String
    Dim com As New OracleCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()

    End Sub
    Private Sub login()
        Dim hash As String

        Using md5Hash As MD5 = MD5.Create()
            hash = _ObtieneMd5Hash(md5Hash, passbox.Text)
        End Using
        Try

            If (userbox.Text <> "" And passbox.Text <> "") Then

                cadena = "SELECT EMPLEADO.IDEMPLEADO,EMPLEADO.USUARIO,PUESTO.DESCRIPCION FROM EMPLEADO, PUESTO,DEPARTAMENTO WHERE EMPLEADO.USUARIO = '" + datos.limpia(userbox.Text) + "'AND EMPLEADO.IDEPTOP = DEPARTAMENTO.IDDEPTO AND EMPLEADO.IDPUESTO = PUESTO.IDPUESTO"
                DTS = datos.llenar(cadena)

                Form1.IDEMPLEADO = DTS.Tables(0).Rows(0)(0).ToString
                Form1.TBUSER.Text = DTS.Tables(0).Rows(0)(1).ToString
                Form1.TBRANGO.Text = DTS.Tables(0).Rows(0)(2).ToString

                cadena = "SELECT EMPLEADO.IDPUESTO FROM EMPLEADO, USUARIO WHERE EMPLEADO.USUARIO = '" + datos.limpia(userbox.Text) + "'AND EMPLEADO.CONTRASENA ='" + hash + "'"
                ID = datos.consulta(cadena)
                If ID Is Nothing Then
                    userbox.Text = ""
                    passbox.Text = ""
                    MsgBox("Usuario y/o contrasena inválida")
                    userbox.Focus()

                Else
                    Form1.CerarS.Enabled = True


                    If ID = 1 Then
                        Form1.mnuAuditoria.Enabled = True
                        Form1.mnuConsultarSaldo.Enabled = True
                        Form1.mnuCuenta.Enabled = True
                        Form1.mnuTransaccion.Enabled = True
                        Form1.mnuEmpleados.Enabled = True

                        Form1.mnuAuditoria.Visible = True
                        Form1.mnuConsultarSaldo.Visible = True
                        Form1.mnuCuenta.Visible = True
                        Form1.mnuTransaccion.Visible = True
                        Form1.mnuEmpleados.Visible = True
                        Form1.IniciaS.Visible = False
                        Form1.CerarS.Visible = True
                        Form1.CerarS.Enabled = True
                        Close()

                    ElseIf ID = 2 Then
                        Form1.mnuAuditoria.Enabled = False
                        Form1.mnuConsultarSaldo.Enabled = True
                        Form1.mnuCuenta.Enabled = True
                        Form1.mnuTransaccion.Enabled = False
                        Form1.mnuEmpleados.Enabled = False

                        Form1.mnuAuditoria.Visible = False
                        Form1.mnuConsultarSaldo.Visible = True
                        Form1.mnuCuenta.Visible = True
                        Form1.mnuTransaccion.Visible = False
                        Form1.mnuEmpleados.Visible = False
                        Form1.IniciaS.Visible = False
                        Form1.CerarS.Visible = True
                        Form1.CerarS.Enabled = True
                        Close()

                    ElseIf ID = 3 Then
                        Form1.mnuAuditoria.Enabled = True
                        Form1.mnuConsultarSaldo.Enabled = True
                        Form1.mnuCuenta.Enabled = True
                        Form1.mnuTransaccion.Enabled = True
                        Form1.mnuEmpleados.Enabled = True

                        Form1.mnuAuditoria.Visible = True
                        Form1.mnuConsultarSaldo.Visible = True
                        Form1.mnuCuenta.Visible = True
                        Form1.mnuTransaccion.Visible = True
                        Form1.mnuEmpleados.Visible = True
                        Form1.IniciaS.Visible = False
                        Form1.CerarS.Visible = True
                        Form1.CerarS.Enabled = True
                        Close()
                    ElseIf ID = 4 Then
                        Form1.mnuAuditoria.Enabled = False
                        Form1.mnuConsultarSaldo.Enabled = True
                        Form1.mnuCuenta.Enabled = True
                        Form1.mnuTransaccion.Enabled = False
                        Form1.mnuEmpleados.Enabled = False

                        Form1.mnuAuditoria.Visible = False
                        Form1.mnuConsultarSaldo.Visible = True
                        Form1.mnuCuenta.Visible = True
                        Form1.mnuTransaccion.Visible = False
                        Form1.mnuEmpleados.Visible = False
                        Form1.IniciaS.Visible = False
                        Form1.CerarS.Visible = True
                        Form1.CerarS.Enabled = True
                        Close()
                    ElseIf ID = 5 Then
                        Form1.mnuAuditoria.Enabled = False
                        Form1.mnuConsultarSaldo.Enabled = True
                        Form1.mnuCuenta.Enabled = True
                        Form1.mnuTransaccion.Enabled = False
                        Form1.mnuEmpleados.Enabled = False

                        Form1.mnuAuditoria.Visible = False
                        Form1.mnuConsultarSaldo.Visible = True
                        Form1.mnuCuenta.Visible = True
                        Form1.mnuTransaccion.Visible = False
                        Form1.mnuEmpleados.Visible = False
                        Form1.IniciaS.Visible = False
                        Form1.CerarS.Visible = True
                        Form1.CerarS.Enabled = True
                        Close()

                    ElseIf ID = 6 Then
                        Form1.mnuAuditoria.Enabled = False
                        Form1.mnuConsultarSaldo.Enabled = True
                        Form1.mnuCuenta.Enabled = False
                        Form1.mnuTransaccion.Enabled = True
                        Form1.mnuEmpleados.Enabled = False

                        Form1.mnuAuditoria.Visible = False
                        Form1.mnuConsultarSaldo.Visible = True
                        Form1.mnuCuenta.Visible = False
                        Form1.mnuTransaccion.Visible = True
                        Form1.mnuEmpleados.Visible = False
                        Form1.IniciaS.Visible = False
                        Form1.CerarS.Visible = True
                        Form1.CerarS.Enabled = True

                        Close()


                    End If




                End If


            Else

                MessageBox.Show("Uno o más campos estan vacios")
                userbox.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show("Error")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class