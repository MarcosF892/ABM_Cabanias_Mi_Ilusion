Public Class lstConsultas
    Dim con As New Consultas

    Private Sub lstReservas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Actualizar()
    End Sub

    Private Sub lstReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub Actualizar()
        con.Mostrar(dgvReservas)
    End Sub

    Private Sub dgvReservas_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReservas.CellDoubleClick
        con.id = dgvReservas.Item("id", dgvReservas.CurrentRow.Index).Value
        con.idUsuario = dgvReservas.Item("idUsuario", dgvReservas.CurrentRow.Index).Value
        con.fechaIngreso = dgvReservas.Item("fechaIngreso", dgvReservas.CurrentRow.Index).Value
        con.fechaEgreso = dgvReservas.Item("fechaEgreso", dgvReservas.CurrentRow.Index).Value
        con.cantAdultos = dgvReservas.Item("cantAdultos", dgvReservas.CurrentRow.Index).Value
        con.cantMenores = dgvReservas.Item("cantMenores", dgvReservas.CurrentRow.Index).Value
    End Sub

    'Private Sub dgvReservas_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvReservas.RowPrePaint
    '    Try
    '        dgvReservas.DefaultCellStyle.SelectionForeColor = dgvReservas.CurrentRow.DefaultCellStyle.BackColor
    '    Catch ex As Exception
    '    End Try
    'End Sub
End Class