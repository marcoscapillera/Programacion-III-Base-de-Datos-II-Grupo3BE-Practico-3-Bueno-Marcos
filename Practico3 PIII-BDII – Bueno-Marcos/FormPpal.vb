Public Class Gestor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Agregar.Click
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
End Class
