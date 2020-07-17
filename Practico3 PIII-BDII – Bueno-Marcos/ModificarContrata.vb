Imports CapaLogica
Public Class ModificarContrata
    Dim PkPersona As String
    Dim PkServicios As String
    Dim PkFechaCreacion As String


    Private Sub DataGridContrata_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridContrata.RowHeaderMouseClick
        PkPersona = DataGridContrata.Item(0, e.RowIndex).Value
        PkServicios = DataGridContrata.Item(1, e.RowIndex).Value
        PkFechaCreacion = DataGridContrata.Item(2, e.RowIndex).Value
        cbxIdPersona.Text = DataGridContrata.Item(0, e.RowIndex).Value
        cbxIdServicio.Text = DataGridContrata.Item(1, e.RowIndex).Value
        txtFechaCreacion.Text = DataGridContrata.Item(2, e.RowIndex).Value
        txtFechaContrato.Text = DataGridContrata.Item(3, e.RowIndex).Value
        txtFechaFinContrato.Text = DataGridContrata.Item(4, e.RowIndex).Value
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If habilitaModificar() = True Then
            Try
                ControladorContrata.ModificarContrata(cbxIdPersona.Text,
                                                     cbxIdServicio.Text,
                                                     txtFechaCreacion.Text,
                                                     txtFechaContrato.Text,
                                                     txtFechaFinContrato.Text,
                                                     PkPersona,
                                                     PkServicios,
                                                     PkFechaCreacion)
                MsgBox("Datos de cliente guardado correctamente")
                limpiarCajas()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Campos Vacios")
        End If
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarCajas()
    End Sub

    Private Sub btnListarClientes_Click(sender As Object, e As EventArgs) Handles btnListarContrata.Click
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorContrata.ListarContrata())

            DataGridContrata.DataSource = tabla
            DataGridContrata.Columns(0).HeaderText = "Id Persona"
            DataGridContrata.Columns(1).HeaderText = "Id Servicio"
            DataGridContrata.Columns(2).HeaderText = "Fecha Contrata"
            DataGridContrata.Columns(3).HeaderText = "Fecha del Contrato"
            DataGridContrata.Columns(4).HeaderText = "Fecha Fin Contrato"
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Public Sub limpiarCajas()
        cbxIdPersona.Text = ""
        cbxIdServicio.Text = ""
        txtFechaCreacion.Text = ""
        txtFechaContrato.Text = ""
        txtFechaFinContrato.Text = ""
    End Sub
    Public Function habilitaModificar() As Boolean
        If cbxIdPersona.Text <> "" And cbxIdServicio.Text <> "" And txtFechaCreacion.Text <> "" And
           txtFechaContrato.Text <> "" And txtFechaFinContrato.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnEnable_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
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