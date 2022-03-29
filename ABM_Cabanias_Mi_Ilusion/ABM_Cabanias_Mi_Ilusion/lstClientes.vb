Public Class lstClientes
    Dim cliente As New Clientes

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmClientes As New frmClientes
        frmClientes.modo = "Agregar"
        frmClientes.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub lstClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cliente.Mostrar(dgvClientes)
    End Sub

    Private Sub Modificar()
        cliente.id = dgvClientes.Item("id", dgvClientes.CurrentRow.Index).Value
        cliente.apellidoNombre = dgvClientes.Item("apellidoNombre", dgvClientes.CurrentRow.Index).Value
        cliente.nacionalidad = dgvClientes.Item("nacionalidad", dgvClientes.CurrentRow.Index).Value
        cliente.estadoCivil = dgvClientes.Item("estadoCivil", dgvClientes.CurrentRow.Index).Value
        cliente.dni = dgvClientes.Item("dni", dgvClientes.CurrentRow.Index).Value
        cliente.edad = dgvClientes.Item("edad", dgvClientes.CurrentRow.Index).Value
        cliente.direccion = dgvClientes.Item("direccion", dgvClientes.CurrentRow.Index).Value
        cliente.cp = dgvClientes.Item("cp", dgvClientes.CurrentRow.Index).Value
        cliente.localidad = dgvClientes.Item("localidad", dgvClientes.CurrentRow.Index).Value
        cliente.telCel = dgvClientes.Item("telCel", dgvClientes.CurrentRow.Index).Value
        cliente.email = dgvClientes.Item("email", dgvClientes.CurrentRow.Index).Value
        cliente.vehiculoPatente = dgvClientes.Item("vehiculoPatente", dgvClientes.CurrentRow.Index).Value
        cliente.vehiculoMarca = dgvClientes.Item("vehiculoMarca", dgvClientes.CurrentRow.Index).Value
        cliente.vehiculoColor = dgvClientes.Item("vehiculoColor", dgvClientes.CurrentRow.Index).Value
        cliente.fechaIngreso = dgvClientes.Item("fechaIngreso", dgvClientes.CurrentRow.Index).Value
        cliente.fechaEgreso = dgvClientes.Item("fechaEgreso", dgvClientes.CurrentRow.Index).Value
        cliente.horaEgreso = dgvClientes.Item("horaEgreso", dgvClientes.CurrentRow.Index).Value
        cliente.idCabania = dgvClientes.Item("idCabania", dgvClientes.CurrentRow.Index).Value
        cliente.idProvincia = dgvClientes.Item("idProvincia", dgvClientes.CurrentRow.Index).Value
        cliente.imagen = dgvClientes.Item("imagen", dgvClientes.CurrentRow.Index).Value

        Dim frmClientes As New frmClientes
        frmClientes.modo = "Modificar"
        frmClientes.selCliente = cliente
        frmClientes.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim respuesta As MessageBoxOptions = MessageBox.Show("¿Está seguro que quiere borrar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If respuesta = 1 Then
            cliente.id = dgvClientes.Item("id", dgvClientes.CurrentRow.Index).Value
            cliente.Borrar(cliente.id)
            cliente.Mostrar(dgvClientes)
        End If
    End Sub

    Private Sub dgvClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        Modificar()
    End Sub
End Class