Imports CapaLogica
Public Class ContratarServicio

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If habilitaGuardar() = True Then
            Try
                ControladorContrata.GuardaContrata(cbxIdPersona.Text, cbxIdServicio.Text, txtFechaCreacion.Text, FechaContrato.Text,
                                                       txtFechaFinContrato.Text)

                MsgBox("Servicio Contratado ingresado correctamente")
                limpiarCajas()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Campos Vacios")
        End If
    End Sub

    Public Function habilitaGuardar() As Boolean
        If cbxIdPersona.Text <> "" And cbxIdServicio.Text <> "" And txtFechaCreacion.Text <> "" And
           FechaContrato.Text <> "" And txtFechaFinContrato.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub limpiarCajas()
        cbxIdPersona.Text = ""
        cbxIdServicio.Text = ""
        txtFechaCreacion.Text = ""
        FechaContrato.Text = ""
        txtFechaFinContrato.Text = ""
    End Sub


    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        cargarComboIdPersona()
        cargarComboIdServicio()

    End Sub

    Public Sub cargarComboIdPersona()
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorContrata.ListarPersonaId())
            cbxIdPersona.DataSource = tabla
            cbxIdPersona.DisplayMember = "persona"
            cbxIdPersona.ValueMember = "id"
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Public Sub cargarComboIdServicio()
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorContrata.ListarServicioId())
            cbxIdServicio.DataSource = tabla
            cbxIdServicio.DisplayMember = "servicio"
            cbxIdServicio.ValueMember = "id"
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        If habilitaGuardar() = False Then
            limpiarCajas()
        Else
            limpiarCajas()
        End If
    End Sub
End Class