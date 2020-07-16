Imports CapaDeDatos
Public Module ControladorContrata

    Public Function ListarPersonaId()
        Dim c As New ModuloContrata
        Return c.listarId()
    End Function

    Public Function ListarServicioId()
        Dim c As New ModuloContrata
        Return c.ListarIdServicio()
    End Function

End Module
