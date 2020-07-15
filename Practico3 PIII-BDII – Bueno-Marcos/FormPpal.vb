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

    Private Sub ContratarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratarToolStripMenuItem.Click
        ContratarServicio.Show()
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        UpdateCliente.Show()
    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarClienteToolStripMenuItem.Click
        EliminarCliente.Show()
    End Sub
End Class
