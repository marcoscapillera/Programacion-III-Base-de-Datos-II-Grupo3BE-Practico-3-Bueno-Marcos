Imports CapaLogica
Public Class AgregarCliente
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblAgregarUsuario.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNombreAgregarCliente.TextChanged

    End Sub

    Private Sub Activo_CheckedChanged(sender As Object, e As EventArgs) Handles checkActivo.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Try
            ControladorPersonas.GuardarPersona(txtIdAgregarCliente.Text, txtNombreAgregarCliente.Text, txtApellidoAgregarCliente.Text,
                                                txtMailAgregarCliente.Text, txtFechaAgregarCliente.Text, checkActivo.CheckState)
            MsgBox("Datos de cliente guardado correctamente")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class