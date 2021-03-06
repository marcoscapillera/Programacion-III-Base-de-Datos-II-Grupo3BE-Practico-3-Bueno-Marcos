﻿Imports System.Data.Odbc

Public Class ModeloPersona
    Inherits ModeloConexion

    Public id As String
    Public nombre As String
    Public apellido As String
    Public telefono1 As String
    Public telefono2 As String
    Public mail As String
    Public activo As Boolean

    Public Sub GuardarPersona()
        Dim c As New ModeloConexion
        Dim sqlText As String
        c.conectar()
        If Me.id = 0 Then sqlText = "last_insert_id()" Else sqlText = Me.id
        Try
            c.Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "START TRANSACTION;"
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "INSERT INTO persona (id,nombre, apellido, mail, activo ) 
                                    VALUES ( " & Me.id & " ,'" & Me.nombre & "', '" & Me.apellido & "', '" & Me.mail & "', " & Me.activo & " )"
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "INSERT INTO personatelefono (id,telefono) VALUES (" & sqlText & " , " & Me.telefono1 & ")"
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "INSERT INTO personatelefono (id,telefono) VALUES (" & sqlText & " , " & Me.telefono2 & ")"
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "COMMIT;"
            c.Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            c.Comando.CommandText = "ROLLBACK;"
            c.Comando.ExecuteNonQuery()
        End Try
    End Sub

    Public Sub ModificarPersona()
        Dim c As New ModeloConexion
        c.conectar()
        Try
            c.Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "START TRANSACTION;"
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "INSERT INTO persona (id,nombre, apellido, mail, activo ) 
            VALUES ( " & Me.id & " ,'" & Me.nombre & "', '" & Me.apellido & "', '" & Me.mail & "', " & Me.activo & " ) ON DUPLICATE KEY UPDATE nombre='" & Me.nombre & "', apellido='" & Me.apellido & "', mail='" & Me.mail & "', activo=" & Me.activo
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "DELETE FROM personatelefono WHERE id=" & Me.id & ""
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "INSERT INTO personatelefono (id,telefono) VALUES (" & Me.id & " , " & Me.telefono1 & ")"
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "INSERT INTO personatelefono (id,telefono) VALUES (" & Me.id & " , " & Me.telefono2 & ")"
            c.Comando.ExecuteNonQuery()
            c.Comando.CommandText = "COMMIT;"
            c.Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            c.Comando.CommandText = "ROLLBACK;"
            c.Comando.ExecuteNonQuery()
        End Try
    End Sub

    Public Sub EliminarPersona()
        'Da de baja de forma logica a persona
        Dim c As New ModeloConexion
        c.conectar()
        Try
            c.Comando.CommandText = "UPDATE persona SET  activo=0 WHERE id = " & Me.id
            c.Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            c.Comando.CommandText = "ROLLBACK;"
            c.Comando.ExecuteNonQuery()
        End Try
    End Sub

    Public Function listarClientes()
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "SELECT persona.*, personatelefono.*
        FROM practico3.persona persona, practico3.personatelefono personatelefono
        WHERE personatelefono.id = persona.id"
        Reader = c.Comando.ExecuteReader()
        Return Reader
    End Function

End Class
