Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Consultas
    Inherits Conexiones
    Private id_ As Integer
    Private idUsuario_ As Integer
    Private fechaIngreso_ As Date
    Private fechaEgreso_ As Date
    Private cantAdultos_ As Integer
    Private cantMenores_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property idUsuario() As Integer
        Get
            Return idUsuario_
        End Get
        Set(ByVal value As Integer)
            idUsuario_ = value
        End Set
    End Property

    Public Property fechaIngreso() As Date
        Get
            Return fechaIngreso_
        End Get
        Set(ByVal value As Date)
            fechaIngreso_ = value
        End Set
    End Property

    Public Property fechaEgreso() As Date
        Get
            Return fechaEgreso_
        End Get
        Set(ByVal value As Date)
            fechaEgreso_ = value
        End Set
    End Property

    Public Property cantAdultos() As Integer
        Get
            Return cantAdultos_
        End Get
        Set(ByVal value As Integer)
            cantAdultos_ = value
        End Set
    End Property

    Public Property cantMenores() As Integer
        Get
            Return cantMenores_
        End Get
        Set(ByVal value As Integer)
            cantMenores_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT c.id, c.idUsuario, u.nombre, u.email, c.fechaIngreso, c.fechaEgreso, " & _
        "c.cantAdultos, c.cantMenores FROM Consultas C " & _
        "INNER JOIN Usuarios u ON u.id=c.idUsuario " & _
        "ORDER BY c.id DESC"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("id").Width = 50
        grilla.Columns("idUsuario").Visible = False
        grilla.Columns("fechaIngreso").Width = 70
        grilla.Columns("fechaEgreso").Width = 70
        grilla.Columns("email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grilla.Columns("nombre").Width = 200
        grilla.Columns("cantAdultos").Width = 70
        grilla.Columns("cantMenores").Width = 70
        Cerrar()
    End Sub

    Public Sub ActualizarConsulta(ByVal consulta As Consultas)
        Abrir()
        Dim strComando As String = "UPDATE Consultas SET WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", consulta.id)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

End Class
