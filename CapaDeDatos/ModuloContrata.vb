Imports System.Data.Odbc

Public Class ModuloContrata
    Inherits ModeloConexion

    Public Function ListarId()
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "SELECT id FROM persona"
        Reader = c.Comando.ExecuteReader()
        Return Reader
    End Function

    Public Function ListarIdServicio()
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "SELECT id FROM servicio"
        Reader = c.Comando.ExecuteReader()
        Return Reader
    End Function
End Class
