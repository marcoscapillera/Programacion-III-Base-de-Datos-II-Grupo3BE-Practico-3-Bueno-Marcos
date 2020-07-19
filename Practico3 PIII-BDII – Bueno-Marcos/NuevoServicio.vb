Imports CapaLogica

Public Class NuevoServicio

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If habilitaGuardar() = True Then
            Try
                ControladorServicios.GuardarServicios(txtIdNuevoServicio.Text, txtNombreNuevoServicio.Text, txtCostoMensualNuevoServicio.Text,
                                                      cmbTipos.Text, txtFechaNuevoServicio.Text, checkActivoNuevoServicio.CheckState)

                MsgBox("Servicio ingresado correctamente")
                limpiarCajas()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Campos Vacios")
        End If
    End Sub

    Public Function habilitaGuardar() As Boolean
        If txtIdNuevoServicio.Text <> "" And
           txtNombreNuevoServicio.Text <> "" And
           txtCostoMensualNuevoServicio.Text <> "" And
           cmbTipos.Text <> "" And
           txtFechaNuevoServicio.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub limpiarCajas()
        txtIdNuevoServicio.Text = 0
        txtNombreNuevoServicio.Text = ""
        txtCostoMensualNuevoServicio.Text = ""
        cmbTipos.Text = ""
        txtFechaNuevoServicio.Text = ""
        checkActivoNuevoServicio.CheckState = CheckState.Checked

    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        If habilitaGuardar() = False Then
            limpiarCajas()
        End If
    End Sub
End Class