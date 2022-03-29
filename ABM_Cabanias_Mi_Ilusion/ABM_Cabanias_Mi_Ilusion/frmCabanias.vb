Public Class frmCabanias
    Private modo_ As String
    Private selCabania_ As Cabanias

    Public WriteOnly Property modo() As String
        Set(ByVal value As String)
            modo_ = value
        End Set
    End Property

    Public WriteOnly Property selCabania() As Cabanias
        Set(ByVal value As Cabanias)
            selCabania_ = value
        End Set
    End Property

    Dim cat As New Cabanias

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        cat.numero = txtNumero.Text
        If modo_ = "Agregar" Then
            cat.Agregar(cat)
        Else
            cat.id = txtId.Text
            cat.Modificar(cat)
        End If
        cat.Mostrar(lstCabanias.dgvCabanias)
        Close()
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = modo_ + " gentecabania"

        If modo_ = "Modificar" Then
            txtId.Text = selCabania_.id
            txtNumero.Text = selCabania_.numero
        End If

    End Sub
End Class