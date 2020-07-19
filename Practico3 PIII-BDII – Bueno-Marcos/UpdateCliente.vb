Imports CapaLogica
Public Class UpdateCliente
    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        If habilitaModificar() = False Then
            limpiarCajas()
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If habilitaModificar() = True Then
            Try
                ControladorPersonas.ModificarPersona(txtIdModificarCliente.Text, txtNombreModificarCliente.Text, txtApellidoModificarCliente.Text,
                                                    txtMailModificarCliente.Text, checkActivo.CheckState,
                                                    txtTelefono1ModificarCliente.Text, txtTelefono2ModificarCliente.Text)
                MsgBox("Datos de cliente guardado correctamente")
                limpiarCajas()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Campos Vacios")
        End If
    End Sub


    Public Function habilitaModificar() As Boolean
        If txtIdModificarCliente.Text <> "" And
           txtNombreModificarCliente.Text <> "" And
           txtApellidoModificarCliente.Text <> "" And
           txtMailModificarCliente.Text <> "" And
           txtTelefono1ModificarCliente.Text <> "" And
           txtTelefono2ModificarCliente.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub limpiarCajas()
        txtIdModificarCliente.Text = 0
        txtNombreModificarCliente.Text = ""
        txtApellidoModificarCliente.Text = ""
        txtMailModificarCliente.Text = ""
        checkActivo.CheckState = CheckState.Checked
        txtTelefono1ModificarCliente.Text = ""
        txtTelefono2ModificarCliente.Text = ""
    End Sub

    Private Sub btnListarClientes_Click(sender As Object, e As EventArgs) Handles btnListarClientes.Click
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorPersonas.ListarTodo())
            DataGridCliente.DataSource = tabla
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub


    Private Sub DataGridCliente_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridCliente.RowHeaderMouseClick
        txtIdModificarCliente.Text = DataGridCliente.Item(0, e.RowIndex).Value
        txtNombreModificarCliente.Text = DataGridCliente.Item(1, e.RowIndex).Value
        txtApellidoModificarCliente.Text = DataGridCliente.Item(2, e.RowIndex).Value
        txtMailModificarCliente.Text = DataGridCliente.Item(3, e.RowIndex).Value
        checkActivo.CheckState = DataGridCliente.Item(5, e.RowIndex).Value

    End Sub
End Class