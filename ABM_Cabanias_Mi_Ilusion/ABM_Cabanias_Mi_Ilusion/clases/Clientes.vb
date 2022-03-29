Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Clientes
    Inherits Conexiones
    Private id_ As Integer
    Private apellidoNombre_ As String
    Private nacionalidad_ As String
    Private estadoCivil_ As String
    Private dni_ As Integer
    Private edad_ As Integer
    Private direccion_ As String
    Private cp_ As Integer
    Private localidad_ As String
    Private telCel_ As String
    Private email_ As String
    Private vehiculoPatente_ As String
    Private vehiculoMarca_ As String
    Private vehiculoColor_ As String
    Private fechaIngreso_ As String
    Private fechaEgreso_ As String
    Private horaEgreso_ As String
    Private idCabania_ As Integer
    Private idProvincia_ As Integer
    Private imagen_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property apellidoNombre() As String
        Get
            Return apellidoNombre_
        End Get
        Set(ByVal value As String)
            apellidoNombre_ = value
        End Set
    End Property

    Public Property nacionalidad() As String
        Get
            Return nacionalidad_
        End Get
        Set(ByVal value As String)
            nacionalidad_ = value
        End Set
    End Property

    Public Property estadoCivil() As String
        Get
            Return estadoCivil_
        End Get
        Set(ByVal value As String)
            estadoCivil_ = value
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

    Public Property edad() As Integer
        Get
            Return edad_
        End Get
        Set(ByVal value As Integer)
            edad_ = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property

    Public Property cp() As Integer
        Get
            Return cp_
        End Get
        Set(ByVal value As Integer)
            cp_ = value
        End Set
    End Property

    Public Property localidad() As String
        Get
            Return localidad_
        End Get
        Set(ByVal value As String)
            localidad_ = value
        End Set
    End Property

    Public Property telCel() As String
        Get
            Return telCel_
        End Get
        Set(ByVal value As String)
            telCel_ = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return email_
        End Get
        Set(ByVal value As String)
            email_ = value
        End Set
    End Property

    Public Property vehiculoPatente() As String
        Get
            Return vehiculoPatente_
        End Get
        Set(ByVal value As String)
            vehiculoPatente_ = value
        End Set
    End Property

    Public Property vehiculoMarca() As String
        Get
            Return vehiculoMarca_
        End Get
        Set(ByVal value As String)
            vehiculoMarca_ = value
        End Set
    End Property

    Public Property vehiculoColor() As String
        Get
            Return vehiculoColor_
        End Get
        Set(ByVal value As String)
            vehiculoColor_ = value
        End Set
    End Property

    Public Property fechaIngreso() As String
        Get
            Return fechaIngreso_
        End Get
        Set(ByVal value As String)
            fechaIngreso_ = value
        End Set
    End Property

    Public Property fechaEgreso() As String
        Get
            Return fechaEgreso_
        End Get
        Set(ByVal value As String)
            fechaEgreso_ = value
        End Set
    End Property

    Public Property horaEgreso() As String
        Get
            Return horaEgreso_
        End Get
        Set(ByVal value As String)
            horaEgreso_ = value
        End Set
    End Property

    Public Property idCabania() As Integer
        Get
            Return idCabania_
        End Get
        Set(ByVal value As Integer)
            idCabania_ = value
        End Set
    End Property

    Public Property idProvincia() As Integer
        Get
            Return idProvincia_
        End Get
        Set(ByVal value As Integer)
            idProvincia_ = value
        End Set
    End Property

    Public Property imagen() As String
        Get
            Return imagen_
        End Get
        Set(ByVal value As String)
            imagen_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT c.id, c.apellidoNombre, c.nacionalidad, c.estadoCivil, c.dni, c.edad, c.direccion, c.cp, c.localidad, " & _
        "c.telCel, c.email, c.vehiculoPatente, c.vehiculoMarca, c.vehiculoColor, c.fechaIngreso, c.fechaEgreso, c.horaEgreso, c.idCabania, c.idProvincia, c.imagen, g.numero cabania, p.nombre provincia FROM clientes c " & _
        "INNER JOIN gentecabanias g ON g.id=c.idCabania " & _
        "INNER JOIN provincias p ON p.id=c.idProvincia"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        'esto cambia el ancho de las columnas
        grilla.Columns("id").Width = 54
        grilla.Columns("imagen").Visible = False
        grilla.Columns("idCabania").Visible = False
        grilla.Columns("idProvincia").Visible = False
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal cliente As Clientes)
        Abrir()
        Dim strComando As String = "INSERT INTO clientes (apellidoNombre, nacionalidad, estadoCivil, dni, edad, direccion, cp, localidad, telCel, email, vehiculoPatente, vehiculoMarca, vehiculoColor, fechaIngreso, fechaEgreso, horaEgreso, idCabania, idProvincia, imagen) " & _
        "VALUES (@apellidoNombre, @nacionalidad, @estadoCivil, @dni, @edad, @direccion, @cp, @localidad, @telCel, @email, @vehiculoPatente, @vehiculoMarca, @vehiculoColor, @fechaIngreso, @fechaEgreso, @horaEgreso, @idCabania, @idProvincia, @imagen)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@apellidoNombre", cliente.apellidoNombre)
        mysqlComando.Parameters.AddWithValue("@nacionalidad", cliente.nacionalidad)
        mysqlComando.Parameters.AddWithValue("@estadoCivil", cliente.estadoCivil)
        mysqlComando.Parameters.AddWithValue("@dni", cliente.dni)
        mysqlComando.Parameters.AddWithValue("@edad", cliente.edad)
        mysqlComando.Parameters.AddWithValue("@direccion", cliente.direccion)
        mysqlComando.Parameters.AddWithValue("@cp", cliente.cp)
        mysqlComando.Parameters.AddWithValue("@localidad", cliente.localidad)
        mysqlComando.Parameters.AddWithValue("@telCel", cliente.telCel)
        mysqlComando.Parameters.AddWithValue("@email", cliente.email)
        mysqlComando.Parameters.AddWithValue("@vehiculoPatente", cliente.vehiculoPatente)
        mysqlComando.Parameters.AddWithValue("@vehiculoMarca", cliente.vehiculoMarca)
        mysqlComando.Parameters.AddWithValue("@vehiculoColor", cliente.vehiculoColor)
        mysqlComando.Parameters.AddWithValue("@fechaIngreso", cliente.fechaIngreso)
        mysqlComando.Parameters.AddWithValue("@fechaEgreso", cliente.fechaEgreso)
        mysqlComando.Parameters.AddWithValue("@horaEgreso", cliente.horaEgreso)
        mysqlComando.Parameters.AddWithValue("@idCabania", cliente.idCabania)
        mysqlComando.Parameters.AddWithValue("@idProvincia", cliente.idProvincia)
        mysqlComando.Parameters.AddWithValue("@imagen", cliente.imagen)

        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Modificar(ByVal cliente As Clientes)
        Abrir()
        Dim strComando As String = "UPDATE clientes SET apellidoNombre=@apellidoNombre, nacionalidad=@nacionalidad, estadoCivil=@estadoCivil, dni=@dni, " & _
        "edad=@edad, direccion=@direccion, cp=@cp, localidad=@localidad, telCel=@telCel, email=@email, vehiculoPatente=@vehiculoPatente, vehiculoMarca=@vehiculoMarca, " & _
        "vehiculoColor=@vehiculoColor, fechaIngreso=@fechaIngreso, fechaEgreso=@fechaEgreso, horaEgreso=@horaEgreso, idCabania=@idCabania, idProvincia=@idProvincia, imagen=@imagen WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", cliente.id)
        mysqlComando.Parameters.AddWithValue("@apellidoNombre", cliente.apellidoNombre)
        mysqlComando.Parameters.AddWithValue("@nacionalidad", cliente.nacionalidad)
        mysqlComando.Parameters.AddWithValue("@estadoCivil", cliente.estadoCivil)
        mysqlComando.Parameters.AddWithValue("@dni", cliente.dni)
        mysqlComando.Parameters.AddWithValue("@edad", cliente.edad)
        mysqlComando.Parameters.AddWithValue("@direccion", cliente.direccion)
        mysqlComando.Parameters.AddWithValue("@cp", cliente.cp)
        mysqlComando.Parameters.AddWithValue("@localidad", cliente.localidad)
        mysqlComando.Parameters.AddWithValue("@telCel", cliente.telCel)
        mysqlComando.Parameters.AddWithValue("@email", cliente.email)
        mysqlComando.Parameters.AddWithValue("@vehiculoPatente", cliente.vehiculoPatente)
        mysqlComando.Parameters.AddWithValue("@vehiculoMarca", cliente.vehiculoMarca)
        mysqlComando.Parameters.AddWithValue("@vehiculoColor", cliente.vehiculoColor)
        mysqlComando.Parameters.AddWithValue("@fechaIngreso", cliente.fechaIngreso)
        mysqlComando.Parameters.AddWithValue("@fechaEgreso", cliente.fechaEgreso)
        mysqlComando.Parameters.AddWithValue("@horaEgreso", cliente.horaEgreso)
        mysqlComando.Parameters.AddWithValue("@idCabania", cliente.idCabania)
        mysqlComando.Parameters.AddWithValue("@idProvincia", cliente.idProvincia)
        mysqlComando.Parameters.AddWithValue("@imagen", cliente.imagen)

        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal idCliente As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM clientes WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", idCliente)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub CargarComboProvinciasTable(ByVal comboActual As ComboBox, ByVal idProvincia As Integer)
        Try
            Abrir()
            Dim strComando As String = "SELECT id, nombre FROM provincias ORDER BY nombre"
            Dim mysqlComando As New MySqlCommand(strComando, conexion)
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New MySqlDataAdapter(mysqlComando)
            objDataAdapter.Fill(objDataTable)
            With comboActual
                .DataSource = objDataTable
                .DisplayMember = "nombre"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub CargarComboProvinciasReader(ByVal comboActual As ComboBox, ByVal idProvincia As Integer)
        Try
            Abrir()
            Dim strComando As String = "SELECT id, nombre FROM provincias ORDER BY nombre"
            Dim mysqlComando As New MySqlCommand(strComando, conexion)
            Dim tabla As New Data.DataTable
            tabla.Load(mysqlComando.ExecuteReader)
            With comboActual
                .DataSource = tabla
                .DisplayMember = "nombre"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub CargarComboCabanias(ByVal comboActual As ComboBox, ByVal idCabania As Integer)
        Try
            Abrir()
            Dim strComando As String = "SELECT id, numero FROM gentecabanias ORDER BY numero"
            Dim mysqlComando As New MySqlCommand(strComando, conexion)
            Dim tabla As New Data.DataTable
            tabla.Load(mysqlComando.ExecuteReader)
            With comboActual
                .DataSource = tabla
                .DisplayMember = "numero"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
End Class
