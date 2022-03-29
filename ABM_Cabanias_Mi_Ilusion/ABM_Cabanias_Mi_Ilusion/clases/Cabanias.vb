Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Cabanias
    Inherits Conexiones
    Private id_ As Integer
    Private numero_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property numero() As Integer
        Get
            Return numero_
        End Get
        Set(ByVal value As Integer)
            numero_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM gentecabanias"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("id").Width = 50
        grilla.Columns("numero").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal cabania As Cabanias)
        Abrir()
        Dim strComando As String = "INSERT INTO gentecabanias (numero) VALUES (@numero)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@numero", cabania.numero)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Modificar(ByVal cabania As Cabanias)
        Abrir()
        Dim strComando As String = "UPDATE gentecabanias SET numero=@numero WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", cabania.id)
        mysqlComando.Parameters.AddWithValue("@numero", cabania.numero)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal idCabania As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM gentecabanias WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", idCabania)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

End Class
