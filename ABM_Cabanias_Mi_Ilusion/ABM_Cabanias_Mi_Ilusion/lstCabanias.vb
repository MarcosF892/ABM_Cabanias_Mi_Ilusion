Public Class lstCabanias
    Dim cat As New Cabanias

    Private Sub lstCabanias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cat.Mostrar(dgvCabanias)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmCabanias As New frmCabanias
        frmCabanias.modo = "Agregar"
        frmCabanias.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub Modificar()
        cat.id = dgvCabanias.Item("id", dgvCabanias.CurrentRow.Index).Value
        cat.numero = dgvCabanias.Item("numero", dgvCabanias.CurrentRow.Index).Value

        Dim frmCabanias As New frmCabanias
        frmCabanias.modo = "Modificar"
        frmCabanias.selCabania = cat
        frmCabanias.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim respuesta As MessageBoxOptions = MessageBox.Show("¿Está seguro que quiere borrar...?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If respuesta = 1 Then
            cat.id = dgvCabanias.Item("id", dgvCabanias.CurrentRow.Index).Value
            cat.Borrar(cat.id)
            cat.Mostrar(dgvCabanias)
        End If
    End Sub

    Private Sub dgvCabanias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCabanias.CellDoubleClick
        Modificar()
    End Sub
End Class