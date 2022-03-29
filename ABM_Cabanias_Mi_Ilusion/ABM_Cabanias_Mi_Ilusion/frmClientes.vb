Imports System.IO
Public Class frmClientes
    Private modo_ As String
    Private selCliente_ As New Clientes

    Public WriteOnly Property modo() As String
        Set(ByVal value As String)
            modo_ = value
        End Set
    End Property

    Public WriteOnly Property selCliente() As Clientes
        Set(ByVal value As Clientes)
            selCliente_ = value
        End Set
    End Property


    Dim cliente As New Clientes
    Dim ac As New AcompaniantesCliente
    Dim carpetaInicial As String = "C:\wamp64\www\ABMCabanias_Mi_Ilusion\images\"
    'Dim carpetaInicial As String = "c:\wamp\www\ABMCabanias_Mi_Ilusion\images\" 'cambiar la ubicacion de la carpeta

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        cliente.apellidoNombre = txtApellidoNombre.Text
        cliente.nacionalidad = txtNacionalidad.Text
        cliente.estadoCivil = txtEstadoCivil.Text
        cliente.dni = txtDNI.Text
        cliente.edad = txtEdad.Text
        cliente.direccion = txtDireccion.Text
        cliente.cp = txtCP.Text
        cliente.localidad = txtLocalidad.Text
        cliente.telCel = txtTelCel.Text
        cliente.email = txtEmail.Text
        cliente.vehiculoPatente = txtVehiculoPatente.Text
        cliente.vehiculoMarca = txtVehiculoMarca.Text
        cliente.Vehiculocolor = txtVehiculoColor.Text
        cliente.fechaIngreso = txtFechaIngreso.Text
        cliente.fechaEgreso = txtFechaEgreso.Text
        cliente.horaEgreso = txtHoraEgreso.Text
        cliente.idCabania = cmbCabania.SelectedValue
        cliente.idProvincia = cmbProvincia.SelectedValue

        Try
            cliente.imagen = pcbCliente.ImageLocation.Substring(InStrRev(pcbCliente.ImageLocation, "\"))
        Catch ex As Exception
            cliente.imagen = ""
        End Try

        If modo_ = "Agregar" Then
            cliente.Agregar(cliente)
        Else
            cliente.id = txtId.Text
            cliente.Modificar(cliente)
        End If
        cliente.Mostrar(lstClientes.dgvClientes)
        Close()
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbProvincia.SelectedValue = selCliente_.idProvincia
        Text = modo_ + " Cliente"
        cliente.CargarComboProvinciasReader(cmbProvincia, selCliente_.idProvincia)
        cliente.CargarComboCabanias(cmbCabania, selCliente_.idCabania)

        If modo_ = "Modificar" Then
            ac.Mostrar(dgvAcompaniantes, selCliente_.id)
            txtId.Text = selCliente_.id
            txtApellidoNombre.Text = selCliente_.apellidoNombre
            txtNacionalidad.Text = selCliente_.nacionalidad
            txtEstadoCivil.Text = selCliente_.estadoCivil
            txtDNI.Text = selCliente_.dni
            txtEdad.Text = selCliente_.edad
            txtDireccion.Text = selCliente_.direccion
            txtCP.Text = selCliente_.cp
            txtLocalidad.Text = selCliente_.localidad
            cmbProvincia.SelectedValue = selCliente_.idProvincia
            txtTelCel.Text = selCliente_.telCel
            txtEmail.Text = selCliente_.email
            txtVehiculoPatente.Text = selCliente_.vehiculoPatente
            txtVehiculoMarca.Text = selCliente_.vehiculoMarca
            txtVehiculoColor.Text = selCliente_.vehiculoColor
            txtFechaIngreso.Text = selCliente_.fechaIngreso
            txtFechaEgreso.Text = selCliente_.fechaEgreso
            txtHoraEgreso.Text = selCliente_.horaEgreso
            cmbCabania.SelectedValue = selCliente_.idCabania
            pcbCliente.ImageLocation = carpetaInicial & selCliente_.imagen
        End If
    End Sub

    Private Sub btnAgregarAcomp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregarAcomp.Click
        Dim lstAcompaniantes As New lstAcompaniantes
        lstAcompaniantes.ShowDialog()
        If lstAcompaniantes.acompanianteSel > 0 Then
            ac.Agregar(lstAcompaniantes.acompanianteSel, txtId.Text)
            ac.Mostrar(dgvAcompaniantes, selCliente_.id)
        End If
    End Sub

    Private Sub btnBorrarAcomp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrarAcomp.Click
        Dim idAcompanianteCliente As Integer
        idAcompanianteCliente = dgvAcompaniantes.Item("id", dgvAcompaniantes.CurrentRow.Index).Value
        ac.Borrar(idAcompanianteCliente)
        ac.Mostrar(dgvAcompaniantes, selCliente_.id)
    End Sub

    Private Sub btnCargarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarImagen.Click
        Dim archivoImagen As String

        Dim ofdImagen As New OpenFileDialog
        ofdImagen.InitialDirectory = carpetaInicial
        ofdImagen.Filter = "Imagenes (*.jpg,*.gif)|*.jpg;*.gif"
        ofdImagen.FilterIndex = 2
        ofdImagen.RestoreDirectory = True

        If ofdImagen.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim carpetaActual As String = ofdImagen.FileName.Substring(0, InStrRev(ofdImagen.FileName, "\"))
            Dim archivoActual As String = ofdImagen.FileName.Substring(InStrRev(ofdImagen.FileName, "\"))
            If UCase(carpetaActual) = UCase(carpetaInicial) Then
                archivoImagen = ofdImagen.FileName
                pcbCliente.ImageLocation = archivoImagen
            Else
                Dim msgCopiar As DialogResult = MessageBox.Show("¿Quiere copiar la imagen a la carpeta de Imágenes...?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If msgCopiar = Windows.Forms.DialogResult.OK Then
                    File.Copy(ofdImagen.FileName, carpetaInicial + archivoActual)
                    archivoImagen = ofdImagen.FileName
                    pcbCliente.ImageLocation = archivoImagen
                End If
            End If
        End If
    End Sub

End Class