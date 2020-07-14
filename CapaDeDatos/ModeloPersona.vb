Imports System.Data.Odbc

Public Class ModeloPersona

    Public id As String
    Public nombre As String
    Public apellido As String
    Public telefono1 As String
    Public telefono2 As String
    Public mail As String
    Public fechaHoraCreacion As String
    Public activo As Boolean


    Public Sub GuardarPersona()
        Dim c As New ModeloConexion

        c.conectar()
        Try

            c.Comando.CommandText = "SET AUTOCOMMIT = OFF;"
            c.Comando.ExecuteNonQuery()

            c.Comando.CommandText = "START TRANSACTION;"
            c.Comando.ExecuteNonQuery()

            c.Comando.CommandText = "INSERT INTO persona (id,nombre, apellido, mail, fechaHoraCreacion, activo ) 
            VALUES ( " & Me.id & " ,'" & Me.nombre & "', '" & Me.apellido & "', '" & Me.mail & "', '" & Me.fechaHoraCreacion & "', " & Me.activo & " )"

            c.Comando.ExecuteNonQuery()

            'c.Comando.CommandText = "INSERT INTO personatelefono (id,telefono) VALUES (" & Me.id & " , " & Me.telefono1 & ")"
            'c.Comando.ExecuteNonQuery()

            'c.Comando.CommandText = "INSERT INTO personatelefono (id,telefono) VALUES (" & Me.id & " , " & Me.telefono2 & ")"
            'c.Comando.ExecuteNonQuery()

            c.Comando.CommandText = "COMMIT;"
            c.Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            c.Comando.CommandText = "ROLLBACK;"
            c.Comando.ExecuteNonQuery()

        End Try

    End Sub


End Class
