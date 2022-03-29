Public Class frmAcompaniantes
    Private modo_ As String
    Private selAcompaniante_ As Acompaniantes

    Public WriteOnly Property modo() As String
        Set(ByVal value As String)
            modo_ = value
        End Set
    End Property

    Public WriteOnly Property selAcompaniante() As Acompaniantes
        Set(ByVal value As Acompaniantes)
            selAcompaniante_ = value
        End Set
    End Property

    Dim acompaniante As New Acompaniantes
    Dim ac As New AcompaniantesCliente

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        acompaniante.nombreApellido = txtNombre.Text
        acompaniante.dni = txtDni.Text
        If modo_ = "Agregar" Then
            acompaniante.Agregar(acompaniante)
        Else
            acompaniante.id = txtId.Text
            acompaniante.dni = txtDni.Text
            acompaniante.Modificar(acompaniante)
        End If
        acompaniante.Mostrar(lstAcompaniantes.dgvAcompaniantes)
        Close()
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = modo_ + " Acompaniante"

        If modo_ = "Modificar" Then
            txtId.Text = selAcompaniante_.id
            txtNombre.Text = selAcompaniante_.nombreApellido
            txtDni.Text = selAcompaniante_.dni
        End If

    End Sub
End Class