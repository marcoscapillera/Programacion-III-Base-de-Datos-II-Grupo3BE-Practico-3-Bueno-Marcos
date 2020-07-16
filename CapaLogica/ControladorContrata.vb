Imports CapaDeDatos
Public Module ControladorContrata

    Public Sub GuardaContrata(IdPersona As String, idServicio As String, fechaContrata As String, fechaContrato As String, fechaFinContrato As String)
        'Guarda los datos de Contrata
        Dim c As New ModuloContrata
        c.idPersona = IdPersona
        c.idServicio = idServicio
        c.fechaContrata = fechaContrata
        c.fechaContrato = fechaContrato
        c.fechaFinContrato = fechaFinContrato
        c.GuardarContrata()
    End Sub

    Public Sub ModificarContrata(IdPersona As String, idServicio As String, fechaContrata As String, fechaContrato As String, fechaFinContrato As String)
        'Modifica los datos de Contrata
        Dim c As New ModuloContrata
        c.idPersona = IdPersona
        c.idServicio = idServicio
        c.fechaContrata = fechaContrata
        c.fechaContrato = fechaContrato
        c.fechaFinContrato = fechaFinContrato
        c.ModificaContrata()
    End Sub

    Public Sub GuardaPKContrata()

    End Sub

    Public Function ListarPersonaId()
        Dim c As New ModuloContrata
        Return c.listarId()
    End Function

    Public Function ListarServicioId()
        Dim c As New ModuloContrata
        Return c.ListarIdServicio()
    End Function

    Public Function ListarContrata()
        Dim c As New ModuloContrata
        Return c.ListaTablaContrata()
    End Function
End Module
