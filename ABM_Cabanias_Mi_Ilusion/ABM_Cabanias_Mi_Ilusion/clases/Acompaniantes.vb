Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Acompaniantes
    Inherits Conexiones
    Private id_ As Integer
    Private nombreApellido_ As String
    Private dni_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property nombreApellido() As String
        Get
            Return nombreApellido_
        End Get
        Set(ByVal value As String)
            nombreApellido_ = value
        End Set
    End Property

    Public Property dni() As Integer
        Get
            Return dni_
        End Get
        Set(ByVal value As Integer)
            dni_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Acompaniantes"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("id").Width = 50
        grilla.Columns("nombreApellido").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grilla.Columns("dni").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal acompaniante As Acompaniantes)
        Abrir()
        Dim strComando As String = "INSERT INTO Acompaniantes (nombreApellido, dni) VALUES (@nombreApellido, @dni)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@nombreApellido", acompaniante.nombreApellido_)
        mysqlComando.Parameters.AddWithValue("@dni", acompaniante.dni)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Modificar(ByVal acompaniante As Acompaniantes)
        Abrir()
        Dim strComando As String = "UPDATE Acompaniantes SET nombreApellido=@nombreApellido, dni=@dni WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", acompaniante.id)
        mysqlComando.Parameters.AddWithValue("@nombreApellido", acompaniante.nombreApellido_)
        mysqlComando.Parameters.AddWithValue("@dni", acompaniante.dni)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal idAcompaniante As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Acompaniantes WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", idAcompaniante)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
