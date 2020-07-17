Imports CapaLogica
Public Class ModificarServicio
    Private Sub btnListarClientes_Click(sender As Object, e As EventArgs) Handles btnListarServicios.Click
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorServicios.ListarServicios())
            DataGridCliente.DataSource = tabla
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub DataGridCliente_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridCliente.RowHeaderMouseClick
        txtIdModificarServicio.Text = DataGridCliente.Item(0, e.RowIndex).Value
        txtNombreModificarServicio.Text = DataGridCliente.Item(1, e.RowIndex).Value
        txtCostoMensualModificarServicio.Text = DataGridCliente.Item(2, e.RowIndex).Value
        cmbTiposModificarServicio.Text = DataGridCliente.Item(3, e.RowIndex).Value
        checkActivo.CheckState = DataGridCliente.Item(5, e.RowIndex).Value
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        limpiarCajas()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            ControladorServicios.ModificarServicios(txtIdModificarServicio.Text,
                                                    txtNombreModificarServicio.Text,
                                                    txtCostoMensualModificarServicio.Text,
                                                    cmbTiposModificarServicio.Text,
                                                    checkActivo.CheckState)
            MsgBox("Datos de servicios actualizado correctamente")
            limpiarCajas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub limpiarCajas()
        txtIdModificarServicio.Text = ""
        txtNombreModificarServicio.Text = ""
        txtCostoMensualModificarServicio.Text = ""
        cmbTiposModificarServicio.Text = ""
        checkActivo.CheckState = CheckState.Unchecked
    End Sub
End Class

