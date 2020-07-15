Imports CapaLogica

Public Class EliminarCliente
    Private Sub btnListarClientes_Click(sender As Object, e As EventArgs) Handles btnListarClientes.Click
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorPersonas.ListarTodo())
            DataGridEliminarCliente.DataSource = tabla
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub DataGridEliminarCliente_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridEliminarCliente.RowHeaderMouseClick
        txtIdEliminarCliente.Text = DataGridEliminarCliente.Item(0, e.RowIndex).Value
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdEliminarCliente.Text <> "" Then
            Try
                ControladorPersonas.EliminarPersona(txtIdEliminarCliente.Text)
                MsgBox("Cliente dado de baja")
                txtIdEliminarCliente.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Campos Vacios")
        End If
    End Sub
End Class