Imports Oracle.ManagedDataAccess.Client
Public Class frmCliente
    Dim datos As New funcionesvarias
    Dim DTS As New DataSet
    Dim cadena As String

    Dim idc As String
    Dim conex As String = "Data Source=localhost; User Id=BANCO; Password=BANCO;"
    Dim Conexionbanco As New OracleConnection(conex)
    Dim com As New OracleCommand
    Dim cos As String
    Dim codigoc As String
    Dim codigoc1 As String

    Private Sub CLIENTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)
    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.DS.CLIENTE)
        combotipo()
        codigo1()





    End Sub
    Private Sub codigo1()
        cadena = "SELECT MAX(idcliente) FROM cliente"
        codigoc1 = datos.consulta(cadena).ToString
        Tbnc.Text = codigoc1 + 1

    End Sub


    Private Sub codigo()
        cadena = "SELECT MAX(idcliente) FROM cliente"
        codigoc = datos.consulta(cadena).ToString
        If codigoc = 0 Then
            codigoc = codigoc + 1
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DPITextBox.Text <> "" And NOMBRETextBox.Text <> "" Then
            Me.CLIENTETableAdapter.SP_ADD_CLIENTE(NOMBRETextBox.Text, APELLIDOTextBox.Text, DIRECCIONTextBox.Text, TELEFONOTextBox.Text, DPITextBox.Text)

            cuenta()
            DPITextBox.Text = ""
            NOMBRETextBox.Text = ""
            APELLIDOTextBox.Text = ""
            DIRECCIONTextBox.Text = ""
            TELEFONOTextBox.Text = ""
            TBMONTOA.Text = ""
            codigo1()


            Me.TableAdapterManager.UpdateAll(Me.DS)
            MsgBox("Datos Guardados", vbInformation)
            Me.CLIENTETableAdapter.Fill(Me.DS.CLIENTE)

        Else
            MsgBox("No pueden haber campos vacios", vbCritical)
        End If
    End Sub
    Private Sub cuenta()
        Dim x As Exception
        codigo()
        If datos.conectar = True Then
            Try
                Conexionbanco.Open()

                com = New OracleCommand()

                com.CommandType = CommandType.StoredProcedure
                com.Connection = Conexionbanco
                com.CommandText = "SP_ADD_CUENTA"
                com.Parameters.Add(New OracleParameter("VCLIENTE", OracleDbType.Varchar2, ParameterDirection.Input)).Value = codigoc
                com.Parameters.Add(New OracleParameter("VTIPOCUENTA", OracleDbType.Varchar2, ParameterDirection.Input)).Value = CBTCUENTA.SelectedValue
                com.Parameters.Add(New OracleParameter("VSALDO", OracleDbType.Varchar2, ParameterDirection.Input)).Value = TBMONTOA.Text
                com.Parameters.Add(New OracleParameter("VESTADO", OracleDbType.Varchar2, ParameterDirection.Input)).Value = 1

                com.ExecuteNonQuery()
                MsgBox("solicitud enviada")
                datos.desconexion()




            Catch x

                MessageBox.Show(x.Message.ToString())
                datos.desconexion()

            Finally
                Conexionbanco.Close()
            End Try
        Else
            MessageBox.Show("ERROR EN EL SERVIDOR")

        End If

    End Sub

    Private Sub combotipo()
        cadena = "SELECT idtipocuenta,tipocuenta FROM tipocuenta"
        DTS = datos.llenar(cadena)

        CBTCUENTA.DataSource = DTS.Tables(0)
        CBTCUENTA.DisplayMember = "tipocuenta"
        CBTCUENTA.ValueMember = "idtipocuenta"
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBMONTOA.KeyPress
        If InStr(1, "1234567890." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TELEFONOTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TELEFONOTextBox.KeyPress
        If InStr(1, "1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If TextBox8.Text = "" Then

            MsgBox("El campo Numero de Cuenta  NO puede estar Vacio")

        Else
            Try

                cadena = "SELECT  CLIENTE.DPI, CLIENTE.NOMBRE, CLIENTE.APELLIDO,CLIENTE.TELEFONO,CLIENTE.DIRECCION, TIPOCUENTA.TIPOCUENTA,  CUENTA.SALDO FROM CLIENTE, CUENTA,TIPOCUENTA WHERE CLIENTE.IDCLIENTE = CUENTA.IDCLIENTE AND CUENTA.ESTADO= 1 AND  CUENTA.IDTIPOCUENTA  = TIPOCUENTA.IDTIPOCUENTA  AND  CUENTA.IDCUENTA  = '" + TextBox8.Text.ToString() + "' "


                DTS = datos.llenar(cadena)
                TBDPI.Text = DTS.Tables(0).Rows(0)(0).ToString
                TBNOMBRE.Text = DTS.Tables(0).Rows(0)(1).ToString
                TBAPELLIDO.Text = DTS.Tables(0).Rows(0)(2).ToString
                TBTEL.Text = DTS.Tables(0).Rows(0)(3).ToString
                TBDIR.Text = DTS.Tables(0).Rows(0)(4).ToString
                TBTCUENTA.Text = DTS.Tables(0).Rows(0)(5).ToString
                TBSALDO.Text = DTS.Tables(0).Rows(0)(6).ToString


                Button2.Enabled = True


            Catch ex As Exception

                MessageBox.Show("Cuenta Desabilitada", ex.Message.ToString())


                Return
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            cadena = "UPDATE  CUENTA SET ESTADO =  '0' where IDCUENTA =" + TextBox8.Text + ""

            cos = datos.insertar(cadena)
            MessageBox.Show("Su Cuenta ha sido dada de baja Exitosamente")
            

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())

            Return
        End Try
    End Sub
    Private Sub limpiar()
        DPITextBox.Text = ""
        NOMBRETextBox.Text = ""
        APELLIDOTextBox.Text = ""
        DIRECCIONTextBox.Text = ""
        TELEFONOTextBox.Text = ""
        TBSALDO.Text = ""
        TBAPELLIDO.Text = ""
        TBDIR.Text = ""
        TBDPI.Text = ""
        TBMONTOA.Text = ""
        TBNOMBRE.Text = ""
        TBTCUENTA.Text = ""
        TBTEL.Text = ""
        CBTCUENTA.Text = ""
        TextBox8.Text = ""
        TBDPI2.Text = ""
        TBN.Text = ""
        TBA.Text = ""
        TBT.Text = ""
        TBD.Text = ""
        TBTC.Text = ""
        TBS.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar()
        Button2.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        limpiar()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If TBC.Text = "" Then

            MsgBox("El campo Numero de Cuenta  NO puede estar Vacio")

        Else
            Try

                cadena = "SELECT  CLIENTE.DPI, CLIENTE.NOMBRE, CLIENTE.APELLIDO,CLIENTE.TELEFONO,CLIENTE.DIRECCION, TIPOCUENTA.TIPOCUENTA,  CUENTA.SALDO FROM CLIENTE, CUENTA,TIPOCUENTA WHERE CLIENTE.IDCLIENTE = CUENTA.IDCLIENTE AND CUENTA.ESTADO= 0 AND  CUENTA.IDTIPOCUENTA  = TIPOCUENTA.IDTIPOCUENTA  AND  CUENTA.IDCUENTA  = '" + TBC.Text.ToString() + "' "


                DTS = datos.llenar(cadena)
                TBDPI2.Text = DTS.Tables(0).Rows(0)(0).ToString
                TBN.Text = DTS.Tables(0).Rows(0)(1).ToString
                TBA.Text = DTS.Tables(0).Rows(0)(2).ToString
                TBT.Text = DTS.Tables(0).Rows(0)(3).ToString
                TBD.Text = DTS.Tables(0).Rows(0)(4).ToString
                TBTC.Text = DTS.Tables(0).Rows(0)(5).ToString
                TBS.Text = DTS.Tables(0).Rows(0)(6).ToString


                Button8.Enabled = True


            Catch ex As Exception

                MessageBox.Show("La cuenta esta activa", ex.Message.ToString())


                Return
            End Try

        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try

            cadena = "UPDATE  CUENTA SET ESTADO =  '1' where IDCUENTA =" + TBC.Text + ""

            cos = datos.insertar(cadena)
            MessageBox.Show("Su Cuenta ha sido Habilitada Exitosamente")


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())

            Return
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        limpiar()
    End Sub

    Private Sub DPITextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DPITextBox.KeyPress
        If InStr(1, "1234567890" & Chr(15), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

  
   
    
    Private Sub TELEFONOTextBox_TextChanged(sender As Object, e As EventArgs) Handles TELEFONOTextBox.TextChanged

    End Sub
End Class