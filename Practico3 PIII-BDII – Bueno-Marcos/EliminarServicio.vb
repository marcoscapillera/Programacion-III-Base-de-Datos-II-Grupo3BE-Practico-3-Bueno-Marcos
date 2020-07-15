Imports CapaLogica
Public Class EliminarServicio
    Private Sub btnListarClientes_Click(sender As Object, e As EventArgs) Handles btnListarServicios.Click
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorServicios.ListarServicios())
            DataGridEliminarServicio.DataSource = tabla
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub btnEliminarServicios_Click(sender As Object, e As EventArgs) Handles btnEliminarServicios.Click
        If txtIdEliminarServicio.Text <> "" Then
            Try
                ControladorServicios.EliminarServicios(txtIdEliminarServicio.Text)
                MsgBox("Servicio dado de baja")
                txtIdEliminarServicio.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Campos Vacios")
        End If
    End Sub

    Private Sub DataGridEliminarServicio_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridEliminarServicio.RowHeaderMouseClick
        txtIdEliminarServicio.Text = DataGridEliminarServicio.Item(0, e.RowIndex).Value
    End Sub
End Class