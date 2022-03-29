Imports System.Data
Imports MySql.Data.MySqlClient
Public Class AcompaniantesCliente
    Inherits Conexiones
    Private idAcompaniante_ As Integer
    Private idCliente_ As Integer

    Public Property idAcompaniante() As Integer
        Get
            Return idAcompaniante_
        End Get
        Set(ByVal value As Integer)
            idAcompaniante_ = value
        End Set
    End Property

    Public Property idCliente() As Integer
        Get
            Return idCliente_
        End Get
        Set(ByVal value As Integer)
            idCliente_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView, ByVal idCliente As Integer)
        Abrir()
        Dim strComando As String = "SELECT ac.id,ac.idcliente,ac.idacompaniante,a.nombreApellido, a.dni FROM acompaniantescliente ac " & _
        "INNER JOIN acompaniantes a ON ac.idacompaniante = a.id WHERE idcliente=@idCliente"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@idCliente", idCliente)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("idCliente").Visible = False
        grilla.Columns("idAcompaniante").Visible = False
        grilla.Columns("id").Width = 50
        grilla.Columns("nombreApellido").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grilla.Columns("dni").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal idAcompaniante As Integer, ByVal idCliente As Integer)
        Abrir()
        Dim strComando As String = "INSERT INTO AcompaniantesCliente (idAcompaniante, idCliente) VALUES (@idAcompaniante,@idCliente)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@idAcompaniante", idAcompaniante)
        mysqlComando.Parameters.AddWithValue("@idCliente", idCliente)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal idAcompanianteCliente As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM AcompaniantesCliente WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", idAcompanianteCliente)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
