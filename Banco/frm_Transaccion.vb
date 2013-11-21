
Imports Oracle.ManagedDataAccess.Client


Public Class frm_Transaccion
    Dim datos As New funcionesvarias
    Dim DTS As New DataSet
    Dim cadena As String

    Dim idc As String
    Dim conex As String = "Data Source=localhost; User Id=BANCO; Password=BANCO;"
    Dim Conexionbanco As New OracleConnection(conex)
    Dim com As New OracleCommand


    

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
      
        If TextBox8.Text = "" Then

            MsgBox("El campo Numero de Cuenta  NO puede estar Vacio")

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

                MessageBox.Show(ex.Message.ToString(), "No. de Cuenta no existe")


                Return
            End Try

        End If

    End Sub
    Private Sub limpiar()
        TBAPELLIDO.Text = ""
        TBNOMBRE.Text = ""
        TBCUENTA.Text = ""
        TBMONTOR.Text = ""
        TBSALDO.Text = ""
        TBAPELLIDO1.Text = ""
        TBNOMBRE1.Text = ""
        TBCUENTA1.Text = ""
        TBMONTOD.Text = ""
        TBSALDO1.Text = ""
        TextBox6.Text = ""
        CBDOC.Text = ""
        CBDOC1.Text = ""

    End Sub

   

    Private Sub frm_Transaccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBFECHA.Text = DateTime.Now.ToString("dd/MM/yyyy").ToString
        TBFECHA1.Text = DateTime.Now.ToString("dd/MM/yyyy").ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox6.Text = "" Then

            MsgBox("El campo Numero de Cuenta  NO puede estar Vacio")

        Else


            cadena = "SELECT  CLIENTE.NOMBRE, CLIENTE.APELLIDO, CUENTA.IDCUENTA, CUENTA.SALDO, CLIENTE.IDCLIENTE FROM CLIENTE, CUENTA WHERE CLIENTE.IDCLIENTE = CUENTA.IDCLIENTE AND  CUENTA.IDCUENTA  = '" + TextBox6.Text.ToString() + "' "

            Try

                DTS = datos.llenar(cadena)
                TBNOMBRE1.Text = DTS.Tables(0).Rows(0)(0).ToString
                TBAPELLIDO1.Text = DTS.Tables(0).Rows(0)(1).ToString
                TBCUENTA1.Text = DTS.Tables(0).Rows(0)(2).ToString
                TBSALDO1.Text = DTS.Tables(0).Rows(0)(3).ToString
                idc = DTS.Tables(0).Rows(0)(4).ToString

            Catch ex As Exception

                MessageBox.Show(ex.Message.ToString(), "No. de Cuenta no existe")


                Return
            End Try

        End If

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If InStr(1, "1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If InStr(1, "1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    
    
   
    Private Sub TBMONTOR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBMONTOR.KeyPress
        If InStr(1, "1234567890." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TBMONTOD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBMONTOD.KeyPress
        If InStr(1, "1234567890." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim x As Exception
        If datos.conectar = True Then
            Try
                Conexionbanco.Open()

                com = New OracleCommand()

                com.CommandType = CommandType.StoredProcedure
                com.Connection = Conexionbanco
                com.CommandText = "SP_ADD_TRANSACCION"
                com.Parameters.Add(New OracleParameter("VCLIENTE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = idc
                com.Parameters.Add(New OracleParameter("VCUENTA", OracleDbType.Varchar2, ParameterDirection.Input)).Value = TBCUENTA.Text
                com.Parameters.Add(New OracleParameter("VTIPO", OracleDbType.Varchar2, ParameterDirection.Input)).Value = 1
                com.Parameters.Add(New OracleParameter("VVALOR", OracleDbType.Varchar2, ParameterDirection.Input)).Value = TBMONTOR.Text
                com.Parameters.Add(New OracleParameter("VDETALLE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = CBDOC.SelectedItem
                com.Parameters.Add(New OracleParameter("VEMPLEADO", OracleDbType.Varchar2, ParameterDirection.Input)).Value = Form1.IDEMPLEADO
                com.Parameters.Add(New OracleParameter("VEstado", OracleDbType.Varchar2, ParameterDirection.Output))

                com.ExecuteNonQuery()
                MsgBox("solicitud enviada")
                datos.desconexion()

                limpiar()


            Catch x

                MessageBox.Show(x.Message.ToString())
                datos.desconexion()
                limpiar()
            Finally
                Conexionbanco.Close()
            End Try
        Else
            MessageBox.Show("ERROR EN EL SERVIDOR")

        End If



    End Sub

    

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Exception
        If datos.conectar = True Then
            Try
                Conexionbanco.Open()

                com = New OracleCommand()

                com.CommandType = CommandType.StoredProcedure
                com.Connection = Conexionbanco
                com.CommandText = "SP_ADD_TRANSACCION"
                com.Parameters.Add(New OracleParameter("VCLIENTE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = idc
                com.Parameters.Add(New OracleParameter("VCUENTA", OracleDbType.Varchar2, ParameterDirection.Input)).Value = TBCUENTA1.Text
                com.Parameters.Add(New OracleParameter("VTIPO", OracleDbType.Varchar2, ParameterDirection.Input)).Value = 0
                com.Parameters.Add(New OracleParameter("VVALOR", OracleDbType.Varchar2, ParameterDirection.Input)).Value = TBMONTOD.Text
                com.Parameters.Add(New OracleParameter("VDETALLE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = CBDOC1.SelectedItem
                com.Parameters.Add(New OracleParameter("VEMPLEADO", OracleDbType.Varchar2, ParameterDirection.Input)).Value = Form1.IDEMPLEADO
                com.Parameters.Add(New OracleParameter("VEstado", OracleDbType.Varchar2, ParameterDirection.Output))

                com.ExecuteNonQuery()
                MsgBox("solicitud enviada")
                datos.desconexion()

                limpiar()


            Catch x

                MessageBox.Show(x.Message.ToString())
                datos.desconexion()
                limpiar()
            Finally
                Conexionbanco.Close()
            End Try
        Else
            MessageBox.Show("ERROR EN EL SERVIDOR")

        End If
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        limpiar()

    End Sub

    
End Class