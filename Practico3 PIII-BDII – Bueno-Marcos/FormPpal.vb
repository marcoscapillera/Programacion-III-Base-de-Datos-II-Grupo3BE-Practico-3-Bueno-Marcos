Imports CapaLogica

Public Class Gestor

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorPersonas.ListarTodo())
            listadoClientes.DataSource = tabla
            Dim tablaServicios As New DataTable
            tablaServicios.Load(ControladorServicios.ListarServicios())
            listadoServicios.DataSource = tablaServicios
            Dim tablaContrata As New DataTable
            tablaContrata.Load(ControladorContrata.ListarContrata())
            DataGridContrata.DataSource = tablaContrata
            DataGridContrata.Columns(0).HeaderText = "Id Persona"
            DataGridContrata.Columns(1).HeaderText = "Id Servicio"
            DataGridContrata.Columns(2).HeaderText = "Fecha Contrata"
            DataGridContrata.Columns(3).HeaderText = "Fecha del Contrato"
            DataGridContrata.Columns(4).HeaderText = "Fecha Fin Contrato"
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    'MenuStrip
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModificarServicio.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarServicio.Show()

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        ContratarServicio.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        ModificarContrata.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        AgregarCliente.Show()
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        AgregarCliente.Show()
    End Sub

    Private Sub ContratarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContratarToolStripMenuItem1.Click
        NuevoServicio.Show()
    End Sub

    Private Sub ContratarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ContratarServicio.Show()
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        UpdateCliente.Show()
    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarClienteToolStripMenuItem.Click
        EliminarCliente.Show()
    End Sub
End Class
