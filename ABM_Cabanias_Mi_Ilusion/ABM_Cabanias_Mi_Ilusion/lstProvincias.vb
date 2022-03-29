Public Class lstProvincias
    Dim cat As New Provincias

    Private Sub lstProvincias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cat.Mostrar(dgvProvincias)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmProvincias As New frmProvincias
        frmProvincias.modo = "Agregar"
        frmProvincias.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub Modificar()
        cat.id = dgvProvincias.Item("id", dgvProvincias.CurrentRow.Index).Value
        cat.nombre = dgvProvincias.Item("nombre", dgvProvincias.CurrentRow.Index).Value

        Dim frmProvincias As New frmProvincias
        frmProvincias.modo = "Modificar"
        frmProvincias.selProvincia = cat
        frmProvincias.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim respuesta As MessageBoxOptions = MessageBox.Show("¿Está seguro que quiere borrar...?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If respuesta = 1 Then
            cat.id = dgvProvincias.Item("id", dgvProvincias.CurrentRow.Index).Value
            cat.Borrar(cat.id)
            cat.Mostrar(dgvProvincias)
        End If
    End Sub

    Private Sub dgvProvincias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProvincias.CellDoubleClick
        Modificar()
    End Sub
End Class