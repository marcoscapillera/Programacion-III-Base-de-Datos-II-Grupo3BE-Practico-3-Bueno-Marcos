Imports CapaDeDatos

Public Module ControladorServicios

    Public Sub GuardarServicios(Id As String, nombre As String, costo As String, tipo As String, fechaHoraCreacion As String, activo As Boolean)
        'Guarda los datos de Servicio
        Dim s As New ModeloServicios
        s.id = Id
        s.nombre = nombre
        s.costo = costo
        s.tipo = tipo
        s.fechaHoraCreacion = fechaHoraCreacion
        s.activo = activo
        s.GuardarServicio()
    End Sub

    Public Sub ModificarServicios(Id As String, nombre As String, costo As String, tipo As String, activo As Boolean)
        'Modifica los datos de Servicio
        Dim s As New ModeloServicios
        s.id = Id
        s.nombre = nombre
        s.costo = costo
        s.tipo = tipo
        s.activo = activo
        s.ModificarServicio()
    End Sub

    Public Sub EliminarServicios(Id As String)
        'Baja los datos de Servicio
        Dim s As New ModeloServicios
        s.id = Id
        s.EliminarServicio()
    End Sub
    Public Function ListarServicios()
        Dim s As New ModeloServicios
        Return s.listarServicios()
    End Function
End Module
