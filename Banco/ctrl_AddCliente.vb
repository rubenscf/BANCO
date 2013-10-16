Public Class ctrl_AddCliente



    Private Sub ctrl_AddCliente_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub CLIENTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CLIENTEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub
End Class
