Imports System.Data.Odbc

Public Class ModuloServicios
    Inherits MouloConexion

    Public id As String
    Public nombre As String
    Public costo As String
    Public tipo As String
    Public fechaHoraCreacion As String
    Public activo As Boolean


    Public Sub GuardarServicio()
        Dim c As New MouloConexion
        c.conectar()
        Try
            c.Comando.CommandText = "INSERT INTO servicio (id,nombre, costoMensual, tipo, fechaHoraCreacion, activo ) 
            VALUES ( " & Me.id & " ,'" & Me.nombre & "', " & Me.costo & ", '" & Me.tipo & "', '" & Me.fechaHoraCreacion & "', " & Me.activo & " )"
            c.Comando.ExecuteNonQuery()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub ModificarServicio()
        Dim c As New MouloConexion
        c.conectar()
        Try
            c.Comando.CommandText = "UPDATE servicio SET nombre ='" & Me.nombre & "', costoMensual =" & Me.costo & ", tipo ='" & Me.tipo & "', fechaHoraCreacion ='" & Me.fechaHoraCreacion & "', activo =" & Me.activo & " WHERE id = " & Me.id & ""



            c.Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub EliminarServicio()
        Dim c As New MouloConexion
        c.conectar()
        Try
            c.Comando.CommandText = "DELETE FROM servicio WHERE id = " & Me.id & ""
            c.Comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function listarServicios()
        Dim c As New MouloConexion
        c.conectar()
        c.Comando.CommandText = "SELECT id, nombre, costoMensual, tipo, fechaHoraCreacion, activo   
        FROM practico3.servicio"
        Reader = c.Comando.ExecuteReader()
        Return Reader
    End Function
End Class
