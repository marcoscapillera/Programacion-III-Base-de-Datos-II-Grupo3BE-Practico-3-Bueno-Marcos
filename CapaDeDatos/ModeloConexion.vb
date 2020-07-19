Imports System.Data.Odbc

Public Class ModeloConexion

    Public DbDriver As String = "MySQL ODBC 5.3 ANSI Driver"
    Public DbUser As String = "marcos"
    Public DbPassword As String = "admin"
    Public DbPort As String = "3306"
    Public DbName As String = "practico3"
    Public DbHost As String = "localhost"

    Public Conexion As New OdbcConnection("DRIVER=" + Me.DbDriver +
                                          ";UID=" + Me.DbUser +
                                          ";PWD=" + Me.DbPassword +
                                          ";PORT=" + Me.DbPort +
                                          ";DATABASE=" + Me.DbName +
                                          ";SERVER=" + Me.DbHost)
    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub conectar()
        Me.Conexion.Open()
        Me.Comando.Connection = Me.Conexion
    End Sub

    Public Sub CerrarConexion()
        Me.Conexion.Close()
    End Sub
End Class

