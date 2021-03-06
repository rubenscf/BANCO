﻿Imports System.Security.Cryptography
Imports Oracle.ManagedDataAccess.Client
Public Class frmtarjeta
    Dim datos As New funcionesvarias
    Dim DTS As New DataSet
    Dim cadena As String

    Dim idc As String
    Dim conex As String = "Data Source=localhost; User Id=BANCO; Password=BANCO;"
    Dim Conexionbanco As New OracleConnection(conex)
    Dim com As New OracleCommand
    Dim cos As String
    Dim codigoc As String

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hash As String

        Using umgmazate As MD5 = MD5.Create()
            hash = _ObtieneMd5Hash(umgmazate, TBPIN.Text)
        End Using
        Dim x As Exception
        If datos.conectar = True Then
            Try
                Conexionbanco.Open()

                com = New OracleCommand()

                com.CommandType = CommandType.StoredProcedure
                com.Connection = Conexionbanco
                com.CommandText = "SP_ADD_TARJETA"
                com.Parameters.Add(New OracleParameter("VIDCLIENTE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = idc
                com.Parameters.Add(New OracleParameter("VIDCUENTA", OracleDbType.Varchar2, ParameterDirection.Input)).Value = TBNCUENTA.Text
                com.Parameters.Add(New OracleParameter("VIDTIPO", OracleDbType.Varchar2, ParameterDirection.Input)).Value = CBTTARJETA.SelectedItem
                com.Parameters.Add(New OracleParameter("VLIMITE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = TBLIMITE.Text
                com.Parameters.Add(New OracleParameter("VESTADO", OracleDbType.Varchar2, ParameterDirection.Input)).Value = 1
                com.Parameters.Add(New OracleParameter("VPIN", OracleDbType.Varchar2, ParameterDirection.Input)).Value = hash

                com.ExecuteNonQuery()
               
                MsgBox("Procesando Solicitud", MsgBoxStyle.Information)


                datos.desconexion()
                limpiar()
                codigo()






            Catch x

                MessageBox.Show(x.Message.ToString())
                datos.desconexion()
                limpiar()

            Finally
                Conexionbanco.Close()
            End Try
        Else
            MsgBox("ERROR EN EL SERVIDOR", MsgBoxStyle.Critical)
            limpiar()

        End If



    End Sub
    Private Sub codigo()
        cadena = "SELECT MAX(idtarjeta) FROM tarjeta"
        codigoc = datos.consulta(cadena).ToString
          MsgBox("Su numero de Tarjeta es:"+codigoc)
        If codigoc = 0 Then
            codigoc = codigoc + 1
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox8.Text = "" Then

            MsgBox("El campo Numero de Cuenta  NO puede estar Vacio", MsgBoxStyle.Exclamation)

        Else


            cadena = "SELECT  CLIENTE.IDCLIENTE, CLIENTE.NOMBRE, CUENTA.IDCUENTA, CLIENTE.APELLIDO FROM CLIENTE, CUENTA WHERE CLIENTE.IDCLIENTE = CUENTA.IDCLIENTE  AND  CUENTA.IDCUENTA  = '" + TextBox8.Text.ToString() + "' "
            Try

                DTS = datos.llenar(cadena)
                idc = DTS.Tables(0).Rows(0)(0).ToString
                TBCLIENTE.Text = DTS.Tables(0).Rows(0)(1).ToString
                TBNCUENTA.Text = DTS.Tables(0).Rows(0)(2).ToString
                TBAPELLIDO.Text = DTS.Tables(0).Rows(0)(3).ToString


                
            Catch ex As Exception

                MsgBox("No. de Cuenta no existe", MsgBoxStyle.Critical)


                Return
            End Try

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TBBCUENTA.Text = "" Then

            MsgBox("El campo Numero de Cuenta  NO puede estar Vacio", MsgBoxStyle.Exclamation)

        Else


            cadena = "SELECT   CLIENTE.NOMBRE, CUENTA.IDCUENTA, CLIENTE.APELLIDO, TARJETA.LIMITE, TARJETA.TIPO FROM CLIENTE, CUENTA,TARJETA WHERE CLIENTE.IDCLIENTE = CUENTA.IDCLIENTE AND CLIENTE.IDCLIENTE = TARJETA.IDCLIENTE AND TARJETA.ESTADO=1 AND  TARJETA.IDTARJETA  = '" + TBBCUENTA.Text.ToString() + "' "
            Try

                DTS = datos.llenar(cadena)
                TBNOMBRE1.Text = DTS.Tables(0).Rows(0)(0).ToString
                TBNCUENTA1.Text = DTS.Tables(0).Rows(0)(1).ToString
                TBAPELLIDO1.Text = DTS.Tables(0).Rows(0)(2).ToString
                TBLIMITE1.Text = DTS.Tables(0).Rows(0)(3).ToString
                TBTTARJETA.Text = DTS.Tables(0).Rows(0)(4).ToString

            Catch ex As Exception

                MsgBox("No. de Cuenta no existe", MsgBoxStyle.Critical)


                Return
            End Try

        End If

    End Sub

    Private Sub limpiar()
        TBNOMBRE1.Text = ""
        TBNCUENTA1.Text = ""
        TBAPELLIDO1.Text = ""
        TBLIMITE.Text = ""
        TBLIMITE1.Text = ""
        TBTTARJETA.Text = ""
        TBCLIENTE.Text = ""
        TBNCUENTA.Text = ""
        TBAPELLIDO.Text = ""
        TBBCUENTA.Text = ""
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try

            cadena = "UPDATE  TARJETA SET ESTADO =  '0' where IDTARJETA =" + TBBCUENTA.Text + ""

            cos = datos.insertar(cadena)
            MsgBox("SU TARJETA A SIDO BLOQUEADA EXITOSAMENTE", MsgBoxStyle.Information)

            limpiar()

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
            limpiar()

            Return
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TBBTARJERA.Text = "" Then

            MsgBox("Ingrese un numero de tarjeta", MsgBoxStyle.Exclamation)
            TBBTARJERA.Focus()

        Else


            cadena = "SELECT   CLIENTE.NOMBRE, CUENTA.IDCUENTA, CLIENTE.APELLIDO, TARJETA.LIMITE, TARJETA.TIPO FROM CLIENTE, CUENTA,TARJETA WHERE CLIENTE.IDCLIENTE = CUENTA.IDCLIENTE AND CLIENTE.IDCLIENTE = TARJETA.IDCLIENTE AND TARJETA.ESTADO=0 AND  TARJETA.IDTARJETA  = '" + TBBTARJERA.Text.ToString() + "' "
            Try

                DTS = datos.llenar(cadena)
                TBNOM.Text = DTS.Tables(0).Rows(0)(0).ToString
                TBNC.Text = DTS.Tables(0).Rows(0)(1).ToString
                TBAPE.Text = DTS.Tables(0).Rows(0)(2).ToString
                TBLIM.Text = DTS.Tables(0).Rows(0)(3).ToString
                TBTIPO.Text = DTS.Tables(0).Rows(0)(4).ToString

            Catch ex As Exception

                MessageBox.Show(ex.Message.ToString(), "No. de Cuenta no existe")


                Return
            End Try

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try

            cadena = "UPDATE  TARJETA SET ESTADO =  '1' where IDTARJETA =" + TBBTARJERA.Text + ""

            cos = datos.insertar(cadena)
            cadena = "UPDATE  TARJETA SET LIMITE =  '" + TBLIM.Text.ToString + "' where IDTARJETA =" + TBBTARJERA.Text + ""
            cos = datos.insertar(cadena)
            MessageBox.Show("SU TARJETA A SIDO BLOQUEADA EXITOSAMENTE")

            limpiar()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
            limpiar()

            Return
        End Try
    End Sub

    Private Sub TBBTARJERA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBTARJERA.KeyPress
        If InStr(1, "1234567890" & Chr(6), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TBBCUENTA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBCUENTA.KeyPress
        If InStr(1, "1234567890" & Chr(6), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If InStr(1, "1234567890" & Chr(6), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TBLIMITE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBLIMITE.KeyPress
        If InStr(1, "1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TBPIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPIN.KeyPress
        If InStr(1, "1234567890" & Chr(4), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    
    
    
    
    
End Class