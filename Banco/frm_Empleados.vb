Imports System.Security.Cryptography
Imports Oracle.ManagedDataAccess.Client


Public Class frm_Empleados
    Dim _cnn As New OracleConnection(Banco.My.Settings._cnnBanco)
    Dim _cmd As OracleCommand

    Public Sub _LLENAR_CMB(ByVal sql As String, ByRef _cmb As ComboBox)
        Dim Dt As DataTable
        Dim Da As New OracleDataAdapter
        _cmd = New OracleCommand
        With _cmd
            .CommandType = CommandType.Text
            .CommandText = sql
            .Connection = _cnn
        End With
        Da.SelectCommand = _cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With _cmb
            .DataSource = Dt
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
    End Sub

    Private Sub EMPLEADOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


        Me.Validate()
        Me.EMPLEADOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub frm_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.DS.EMPLEADO)

        Dim query As String = "Select iddepto as id, descripcion as nombre from departamento"
        _LLENAR_CMB(query, IDEPTOPComboBox)


    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim hash As String

        Using md5Hash As MD5 = MD5.Create()
            hash = _ObtieneMd5Hash(md5Hash, CONTRASENATextBox.Text)
        End Using

        Me.EMPLEADOTableAdapter.SP_ADD_EMPLEADO(IDPUESTOComboBox.SelectedValue, IDEPTOPComboBox.SelectedValue, NOMBRETextBox.Text, APELLIDOTextBox.Text, DPITextBox.Text, USUARIOTextBox.Text, hash)
        NOMBRETextBox.Text = ""
        APELLIDOTextBox.Text = ""
        DPITextBox.Text = ""
        USUARIOTextBox.Text = ""
        CONTRASENATextBox.Text = ""
    End Sub

    Private Sub IDEPTOPComboBox_LostFocus(sender As Object, e As EventArgs) Handles IDEPTOPComboBox.LostFocus
        Dim query As String = "Select idpuesto as id, descripcion as nombre from puesto where iddepto='" & IDEPTOPComboBox.SelectedValue & "'"
        _LLENAR_CMB(query, IDPUESTOComboBox)
    End Sub

   
   
    Private Sub btUPDATE_Click(sender As Object, e As EventArgs) Handles btUPDATE.Click
        Me.EMPLEADOTableAdapter.Update(Me.DS.EMPLEADO)
    End Sub

   
    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        Me.EMPLEADOTableAdapter.Fill(Me.DS.EMPLEADO)
        EMPLEADODataGridView.Refresh()



    End Sub


    Private Sub EMPLEADODataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EMPLEADODataGridView.CellContentClick

    End Sub
End Class