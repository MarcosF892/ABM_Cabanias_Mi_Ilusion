Public Class FrmProvincias
    Private modo_ As String
    Private selProvincia_ As Provincias

    Public WriteOnly Property modo() As String
        Set(ByVal value As String)
            modo_ = value
        End Set
    End Property

    Public WriteOnly Property selProvincia() As Provincias
        Set(ByVal value As Provincias)
            selProvincia_ = value
        End Set
    End Property

    Dim pro As New Provincias

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        pro.nombre = txtNombreProv.Text
        If modo_ = "Agregar" Then
            pro.Agregar(pro)
        Else
            pro.id = txtId.Text
            pro.Modificar(pro)
        End If
        pro.Mostrar(lstProvincias.dgvProvincias)
        Close()
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = modo_ + " Provincia"

        If modo_ = "Modificar" Then
            txtId.Text = selProvincia_.id
            txtNombreProv.Text = selProvincia_.nombre
        End If
    End Sub
End Class