'Imports Oracle.Da
Imports Oracle.ManagedDataAccess.Client

Module modulofunciones


    Public Sub _LLENAR_CMB(ByVal sql As String, ByRef _cmb As ComboBox)
        Dim Dt As DataTable
        Dim Da As New OracleDataAdapter
        With Form1._cmd
            .CommandType = CommandType.Text
            .CommandText = sql
            .Connection = Form1._cnn
        End With
        Da.SelectCommand = Form1._cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With _cmb
            .DataSource = Dt
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
    End Sub


End Module
