Imports System.Security.Cryptography

Public Class frm_Empleados

    Private Sub EMPLEADOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EMPLEADOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub frm_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.DS.EMPLEADO)

       


    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim hash As String

        Using md5Hash As MD5 = MD5.Create()
            hash = _ObtieneMd5Hash(md5Hash, CONTRASENATextBox.Text)
        End Using
        MsgBox(hash)
        Me.EMPLEADOTableAdapter.SP_ADD_EMPLEADO(IDPUESTOComboBox.SelectedValue, IDEPTOPComboBox.SelectedValue, NOMBRETextBox.Text, APELLIDOTextBox.Text, DPITextBox.Text, USUARIOTextBox.Text, hash)

    End Sub
End Class