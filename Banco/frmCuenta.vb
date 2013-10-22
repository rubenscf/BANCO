Public Class frmCuenta

    Private Sub CUENTABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CUENTABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub



    Private Sub frmCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS.TIPOCUENTA' Puede moverla o quitarla según sea necesario.
        Me.TIPOCUENTATableAdapter.Fill(Me.DS.TIPOCUENTA)
        'TODO: esta línea de código carga datos en la tabla 'DS.TARJETA' Puede moverla o quitarla según sea necesario.
        Me.TARJETATableAdapter.Fill(Me.DS.TARJETA)
        'TODO: esta línea de código carga datos en la tabla 'DS.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.DS.CLIENTE)
        'TODO: esta línea de código carga datos en la tabla 'DS.CUENTA' Puede moverla o quitarla según sea necesario.
        Me.CUENTATableAdapter.Fill(Me.DS.CUENTA)

    End Sub


    Private Sub CUENTABindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CUENTABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)
    End Sub

    Private Sub SALDOTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SALDOTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class