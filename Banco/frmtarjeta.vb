Public Class frmtarjeta

    Private Sub TARJETABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TARJETABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub frmtarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.DS.CLIENTE)
        'TODO: esta línea de código carga datos en la tabla 'DS.TARJETA' Puede moverla o quitarla según sea necesario.
        Me.TARJETATableAdapter.Fill(Me.DS.TARJETA)

    End Sub
End Class