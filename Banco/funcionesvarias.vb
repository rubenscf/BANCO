Imports Oracle.ManagedDataAccess.Client

Public Class funcionesvarias
    Dim conex As String = "Data Source=localhost; User Id=BANCO; Password=BANCO;"
    Dim oracle As New OracleConnection(conex)
    Dim com As New OracleCommand
    Dim da As New OracleDataAdapter
    Dim dst As New DataSet



    Public Function conectar() As Boolean
        Try
            oracle.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error en la conexión" + ex.Message)
            Return False
            oracle.Close()
        End Try
    End Function
    Public Function llenar(ByVal cadena As String)
        Dim resultado As New DataSet

        Try
            If conectar() = True Then
                da = New OracleDataAdapter(cadena, oracle)
                da.Fill(resultado)

                'MessageBox.Show("si proceso consulta=" + resultado)
                desconexion()
                Return resultado
            Else
                'MessageBox.Show("no se conecto clase cone")
                oracle.Close()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            oracle.Close()

        End Try
    End Function
    Public Function desconexion() As Boolean
        Try
            oracle.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error en la desconexión")
            Return False
        Finally
            oracle.Close()
        End Try
    End Function
    Public Function consulta(ByVal cadena As String) As String
        Dim resultado As String
        Try
            If conectar() = True Then
                com = New OracleCommand(cadena, oracle)
                resultado = com.ExecuteScalar()
                'MessageBox.Show("si proceso consulta=" + resultado)
                desconexion()
                Return resultado
            Else
                'MessageBox.Show("no se conecto clase cone")
                oracle.Close()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            oracle.Close()
        End Try
    End Function
    Public Function insertar(ByVal cadena As String) As String
        Dim resultado As String
        Try
            If conectar() = True Then
                com = New OracleCommand(cadena, oracle)
                resultado = com.ExecuteNonQuery()
                'MessageBox.Show("si proceso consulta=" + resultado)
                desconexion()
                Return resultado
            Else
                'MessageBox.Show("no se conecto clase cone")
                oracle.Close()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            oracle.Close()
        End Try
    End Function

    Public Function llenarDGV(ByVal cadena As String)
        Dim resultado As New DataTable
        Try
            If conectar() = True Then
                da = New OracleDataAdapter(cadena, oracle)
                da.Fill(resultado)

                MessageBox.Show("si proceso consulta=", resultado.ToString)
                desconexion()
                Return resultado
            Else
                MessageBox.Show("no se conecto clase cone")
                oracle.Close()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            oracle.Close()
        End Try
    End Function

    Public Function llenarDS(ByVal cadena As String)
        Dim resultado As New DataSet
        Try
            If conectar() = True Then
                da = New OracleDataAdapter(cadena, oracle)
                da.Fill(resultado)

                'MessageBox.Show("si proceso consulta=" + resultado)
                desconexion()
                Return resultado
            Else
                'MessageBox.Show("no se conecto clase cone")
                oracle.Close()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            oracle.Close()
        End Try
    End Function
    Public Function Buscar(ByVal cadena As String)
        Dim resultado As New DataSet
        Try
            If conectar() = True Then
                da = New OracleDataAdapter(cadena, oracle)
                da.Fill(dst, "clientes")



                'MessageBox.Show("si proceso consulta=" + resultado)
                desconexion()
                Return resultado
            Else
                'MessageBox.Show("no se conecto clase cone")
                oracle.Close()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            oracle.Close()
        End Try
    End Function
    'Funcion para limpiar las cadenas de entrada
    Public Function limpia(ByVal t As String)
        Dim tt As String
        tt = t
        tt = Replace(tt, """", "")
        tt = Replace(tt, "'", "")
        tt = Replace(tt, "--", "")
        Return tt
    End Function
End Class