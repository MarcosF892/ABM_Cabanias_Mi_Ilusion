Public Class principal
    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        lstClientes.ShowDialog()
    End Sub

    Private Sub CabaniasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CabaniaToolStripMenuItem.Click
        lstCabanias.ShowDialog()
    End Sub

    Private Sub ProvinciasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProvinciasToolStripMenuItem.Click
        lstProvincias.ShowDialog()
    End Sub

    Private Sub AcompaniantesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AcompaniantesToolStripMenuItem.Click
        Dim lsAcompaniantes As New lstAcompaniantes
        lstAcompaniantes.ShowDialog()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        lstConsultas.ShowDialog()
    End Sub
End Class
