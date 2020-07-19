Imports CapaLogica
Public Class AgregarCliente

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If habilitaGuardar() = True Then
            Try
                ControladorPersonas.GuardarPersona(txtIdAgregarCliente.Text, txtNombreAgregarCliente.Text, txtApellidoAgregarCliente.Text,
                                                    txtMailAgregarCliente.Text, checkActivo.CheckState,
                                                    txtTelefono1AgregarCliente.Text, txtTelefono2AgregarCliente.Text)
                MsgBox("Datos de cliente guardado correctamente")
                limpiarCajas()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Campos Vacios")
        End If
    End Sub


    Public Function habilitaGuardar() As Boolean
        If txtIdAgregarCliente.Text <> "" And txtNombreAgregarCliente.Text <> "" And txtApellidoAgregarCliente.Text <> "" And
           txtMailAgregarCliente.Text <> "" And txtTelefono1AgregarCliente.Text <> "" And
           txtTelefono2AgregarCliente.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub limpiarCajas()
        txtIdAgregarCliente.Text = 0
        txtNombreAgregarCliente.Text = ""
        txtApellidoAgregarCliente.Text = ""
        txtMailAgregarCliente.Text = ""
        checkActivo.CheckState = CheckState.Checked
        txtTelefono1AgregarCliente.Text = ""
        txtTelefono2AgregarCliente.Text = ""
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        If habilitaGuardar() = False Then
            limpiarCajas()
        End If
    End Sub
End Class