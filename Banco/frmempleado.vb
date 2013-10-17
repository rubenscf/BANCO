Public Class frmempleado

    Private Sub EMPLEADOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EMPLEADOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub frmempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS.DEPARTAMENTO' Puede moverla o quitarla según sea necesario.
        Me.DEPARTAMENTOTableAdapter.Fill(Me.DS.DEPARTAMENTO)
        'TODO: esta línea de código carga datos en la tabla 'DS.PUESTO' Puede moverla o quitarla según sea necesario.
        Me.PUESTOTableAdapter.Fill(Me.DS.PUESTO)
        'TODO: esta línea de código carga datos en la tabla 'DS.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.DS.EMPLEADO)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DPITextBox.Text <> "" And NOMBRETextBox.Text <> "" Then
            Me.EMPLEADOTableAdapter.SP_ADD_EMPLEADO(IDPUESTOComboBox.SelectedValue, IDEPTOPComboBox.SelectedValue, NOMBRETextBox.Text, APELLIDOTextBox.Text, DPITextBox.Text, USUARIOTextBox.Text, CONTRASENATextBox.Text)

            'IDEMPLEADOComboBox.Text = ""
            IDPUESTOComboBox.SelectedValue = ""
            IDEPTOPComboBox.SelectedValue = ""
            NOMBRETextBox.Text = ""
            APELLIDOTextBox.Text = ""
            DPITextBox.Text = ""
            USUARIOTextBox.Text = ""
            CONTRASENATextBox.Text = ""


            Me.TableAdapterManager.UpdateAll(Me.DS)
            MsgBox("Datos Guardados", vbInformation)
            Me.EMPLEADOTableAdapter.Fill(Me.DS.EMPLEADO)

        Else
            MsgBox("No pueden haber campos vacios", vbCritical)
        End If
    End Sub
End Class