Imports CapaLogica
Public Class ContratarServicio
    Private Sub lblAgregarUsuario_Click(sender As Object, e As EventArgs) Handles lblAgregarUsuario.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

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
End Class