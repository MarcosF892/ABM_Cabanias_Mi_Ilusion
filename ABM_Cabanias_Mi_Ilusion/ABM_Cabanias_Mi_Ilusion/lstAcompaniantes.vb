Public Class lstAcompaniantes
    Private acompanianteSel_ As Integer

    Public Property acompanianteSel() As Integer
        Get
            Return acompanianteSel_
        End Get
        Set(ByVal value As Integer)
            acompanianteSel_ = value
        End Set
    End Property

    Dim acompaniante As New Acompaniantes

    Private Sub lstCategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        acompaniante.Mostrar(dgvAcompaniantes)
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmAcompaniantes As New frmAcompaniantes
        frmAcompaniantes.modo = "Agregar"
        frmAcompaniantes.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub Modificar()
        acompaniante.id = dgvAcompaniantes.Item("id", dgvAcompaniantes.CurrentRow.Index).Value
        acompaniante.nombreApellido = dgvAcompaniantes.Item("nombreApellido", dgvAcompaniantes.CurrentRow.Index).Value
        acompaniante.dni = dgvAcompaniantes.Item("dni", dgvAcompaniantes.CurrentRow.Index).Value

        Dim frmAcompaniantes As New frmAcompaniantes
        frmAcompaniantes.modo = "Modificar"
        frmAcompaniantes.selAcompaniante = acompaniante
        frmAcompaniantes.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim respuesta As MessageBoxOptions = MessageBox.Show("¿Está seguro que quiere borrar...?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If respuesta = 1 Then
            acompaniante.id = dgvAcompaniantes.Item("id", dgvAcompaniantes.CurrentRow.Index).Value
            acompaniante.Borrar(acompaniante.id)
            acompaniante.Mostrar(dgvAcompaniantes)
        End If
    End Sub

    Private Sub dgvAcompaniantes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAcompaniantes.CellDoubleClick
        Modificar()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        acompanianteSel_ = dgvAcompaniantes.Item("id", dgvAcompaniantes.CurrentRow.Index).Value
        Close()
    End Sub
End Class