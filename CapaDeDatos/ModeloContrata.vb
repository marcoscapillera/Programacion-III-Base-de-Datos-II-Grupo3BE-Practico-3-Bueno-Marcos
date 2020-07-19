Imports System.Data.Odbc

Public Class ModeloContrata
    Inherits ModeloConexion

    Public idPersona As String
    Public idServicio As String
    Public fechaContrata As String
    Public fechaContrato As String
    Public fechaFinContrato As String
    Public idP As String
    Public idS As String
    Public fechaC1 As String

    Public Sub GuardarContrata()
        Dim c As New ModeloConexion
        c.conectar()
        Try
            c.Comando.CommandText = "INSERT INTO contrata (idPersona, idServicio, fechaCreacion, fechaContratacion, fechaFinContrato ) 
            VALUES ( " & Me.idPersona & " ," & Me.idServicio & ", '" & Me.fechaContrata & "','" & Me.fechaContrato & "', '" & Me.fechaFinContrato & "')"
            c.Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ModificaContrata()
        Dim c As New ModeloConexion
        c.conectar()
        Try
            c.Comando.CommandText = "UPDATE practico3.contrata SET idPersona=" & Me.idPersona & ", idServicio=" & Me.idServicio & ", fechaCreacion='" & Me.fechaContrata & "', fechaContratacion='" & Me.fechaContrato & "', fechaFinContrato='" & Me.fechaFinContrato & "'  WHERE idPersona = " & Me.idP & " And idServicio = " & Me.idS & " And fechaCreacion ='" & Me.fechaC1 & "'"
            MsgBox(c.Comando.CommandText)
            c.Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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

    Public Function ListaTablaContrata()
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "SELECT idPersona, idServicio, DATE_FORMAT(fechaCreacion, '%Y-%m-%d'), DATE_FORMAT(fechaContratacion, '%Y-%m-%d'), DATE_FORMAT(fechaFinContrato, '%Y-%m-%d')
            FROM contrata;"
        Reader = c.Comando.ExecuteReader()
        Return Reader
    End Function
End Class
