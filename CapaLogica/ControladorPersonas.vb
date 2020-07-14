Imports CapaDeDatos
Public Module ControladorPersonas


    Public Sub GuardarPersona(Id As String, nombre As String, apellido As String, mail As String, fechaHoraCreacion As String, activo As Boolean, telefono1 As String, telefono2 As String)
        'Guarda los datos de Persona 
        Dim p As New ModeloPersona
        p.id = Id
        p.nombre = nombre
        p.apellido = apellido
        p.telefono1 = telefono1
        p.telefono2 = telefono2
        p.mail = mail
        p.fechaHoraCreacion = fechaHoraCreacion
        p.activo = activo
        p.GuardarPersona()
    End Sub
End Module
