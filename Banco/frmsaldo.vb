﻿Public Class frmsaldo
    Dim datos As New funcionesvarias
    Dim DTS As New DataSet
    Dim cadena As String

    Dim idc As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox8.Text = "" Then

            MsgBox("El campo Numero de Cuenta  NO puede estar Vacio", MsgBoxStyle.Exclamation)
            TextBox8.Focus()


        Else


            cadena = "SELECT  CLIENTE.NOMBRE, CLIENTE.APELLIDO, CUENTA.IDCUENTA, CUENTA.SALDO, CLIENTE.IDCLIENTE FROM CLIENTE, CUENTA WHERE CLIENTE.IDCLIENTE = CUENTA.IDCLIENTE AND  CUENTA.IDCUENTA  = '" + TextBox8.Text.ToString() + "' "
            Try

                DTS = datos.llenar(cadena)
                TBNOMBRE.Text = DTS.Tables(0).Rows(0)(0).ToString
                TBAPELLIDO.Text = DTS.Tables(0).Rows(0)(1).ToString
                TBCUENTA.Text = DTS.Tables(0).Rows(0)(2).ToString
                TBSALDO.Text = DTS.Tables(0).Rows(0)(3).ToString
                idc = DTS.Tables(0).Rows(0)(4).ToString



            Catch ex As Exception

                MsgBox("No. de Cuenta no existe", MsgBoxStyle.Critical)


                Return
            End Try

        End If
    End Sub

    Private Sub frmsaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBFECHA.Text = DateTime.Now.ToString("dd/MM/yyyy").ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TBAPELLIDO.Text = ""
        TBNOMBRE.Text = ""
        TBCUENTA.Text = ""
        TextBox8.Text = ""
        TBSALDO.Text = ""
       

    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If InStr(1, "1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    
End Class