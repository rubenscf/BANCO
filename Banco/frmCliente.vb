Public Class frmCliente

    Private Sub CLIENTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CLIENTEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.DS.CLIENTE)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DPITextBox.Text <> "" And NOMBRETextBox.Text <> "" Then
            Me.CLIENTETableAdapter.SP_ADD_CLIENTE(NOMBRETextBox.Text, APELLIDOTextBox.Text, DIRECCIONTextBox.Text, TELEFONOTextBox.Text, DPITextBox.Text)
            DPITextBox.Text = ""
            NOMBRETextBox.Text = ""
            APELLIDOTextBox.Text = ""
            DIRECCIONTextBox.Text = ""
            TELEFONOTextBox.Text = ""
            Me.TableAdapterManager.UpdateAll(Me.DS)
            MsgBox("Datos Guardados", vbInformation)
            Me.CLIENTETableAdapter.Fill(Me.DS.CLIENTE)
            CLIENTEDataGridView.Refresh()
        Else
            MsgBox("No pueden haber campos vacios", vbCritical)
        End If
    End Sub
End Class