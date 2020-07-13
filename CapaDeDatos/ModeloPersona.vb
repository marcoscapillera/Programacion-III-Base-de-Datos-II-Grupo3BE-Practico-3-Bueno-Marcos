Imports System.Data.Odbc

Public Class ModeloPersona

    Public id As String
    Public nombre As String
    Public apellido As String
    Public mail As String
    Public fechaHoraCreacion As String
    Public activo As Boolean

    Public Sub GuardarPersona()
        Dim c As New ModeloConexion

        c.conectar()
        c.Comando.CommandText = "INSERT INTO persona (id,nombre, apellido, mail, fechaHoraCreacion, activo ) 
            VALUES ( " & Me.id & " ,'" & Me.nombre & "', '" & Me.apellido & "', '" & Me.mail & "', '" & Me.fechaHoraCreacion & "', " & Me.activo & " ) 
            ON DUPLICATE KEY UPDATE nombre ='" & Me.nombre & "',apellido ='" & Me.apellido & "',mail ='" & Me.mail & "',fechaHoraCreacion ='" & Me.fechaHoraCreacion & "', activo= " & Me.activo
        c.Comando.ExecuteNonQuery()
    End Sub


End Class
