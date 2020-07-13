Imports CapaDeDatos
Public Module ControladorPersonas


    Public Sub GuardarPersona(Id As String, nombre As String, apellido As String, mail As String, fechaHoraCreacion As String, activo As Boolean)
        'Guarda los datos de Persona 
        Dim p As New ModeloPersona
        p.id = Id
        p.nombre = nombre
        p.apellido = apellido
        p.mail = mail
        p.fechaHoraCreacion = fechaHoraCreacion
        p.activo = activo
        p.GuardarPersona()
    End Sub
End Module
