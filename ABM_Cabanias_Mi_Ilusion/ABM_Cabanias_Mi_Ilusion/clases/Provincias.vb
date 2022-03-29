Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Provincias
    Inherits Conexiones
    Private id_ As Integer
    Private nombre_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Provincias"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("id").Width = 50
        grilla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal provincia As Provincias)
        Abrir()
        Dim strComando As String = "INSERT INTO Provincias (nombre) VALUES (@nombre)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@nombre", provincia.nombre)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Modificar(ByVal provincia As Provincias)
        Abrir()
        Dim strComando As String = "UPDATE Provincias SET nombre=@nombre WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", provincia.id)
        mysqlComando.Parameters.AddWithValue("@nombre", provincia.nombre)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal idProvincia As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Provincias WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", idProvincia)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub
End Class
