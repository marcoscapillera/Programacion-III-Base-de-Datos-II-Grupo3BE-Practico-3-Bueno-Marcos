Imports CapaLogica

Public Class Gestor
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorPersonas.ListarTodo())
            listadoClientes.DataSource = tabla
            Dim tablaServicios As New DataTable
            tablaServicios.Load(ControladorServicios.ListarServicios())
            listadoServicios.DataSource = tablaServicios

        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModificarServicio.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarServicio.Show()

    End Sub
End Class
