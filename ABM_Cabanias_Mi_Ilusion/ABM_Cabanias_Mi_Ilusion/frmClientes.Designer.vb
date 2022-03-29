<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFechaEgreso = New System.Windows.Forms.TextBox
        Me.txtFechaIngreso = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtHoraEgreso = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtVehiculoColor = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtVehiculoMarca = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtVehiculoPatente = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtTelCel = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtLocalidad = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCP = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEdad = New System.Windows.Forms.TextBox
        Me.txtDNI = New System.Windows.Forms.TextBox
        Me.Label = New System.Windows.Forms.Label
        Me.txtEstadoCivil = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNacionalidad = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtApellidoNombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBorrarAcomp = New System.Windows.Forms.Button
        Me.dgvAcompaniantes = New System.Windows.Forms.DataGridView
        Me.btnAgregarAcomp = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.pcbCliente = New System.Windows.Forms.PictureBox
        Me.btnCargarImagen = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCabania = New System.Windows.Forms.ComboBox
        Me.cmbProvincia = New System.Windows.Forms.ComboBox
        CType(Me.dgvAcompaniantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFechaEgreso
        '
        Me.txtFechaEgreso.Location = New System.Drawing.Point(857, 80)
        Me.txtFechaEgreso.Name = "txtFechaEgreso"
        Me.txtFechaEgreso.Size = New System.Drawing.Size(109, 20)
        Me.txtFechaEgreso.TabIndex = 88
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Location = New System.Drawing.Point(857, 50)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Size = New System.Drawing.Size(109, 20)
        Me.txtFechaIngreso.TabIndex = 87
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(780, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 86
        Me.Label18.Text = "Hora Egreso:"
        '
        'txtHoraEgreso
        '
        Me.txtHoraEgreso.Location = New System.Drawing.Point(857, 106)
        Me.txtHoraEgreso.Name = "txtHoraEgreso"
        Me.txtHoraEgreso.Size = New System.Drawing.Size(109, 20)
        Me.txtHoraEgreso.TabIndex = 85
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(773, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Fecha Egreso:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(773, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Fecha Ingreso:"
        '
        'txtVehiculoColor
        '
        Me.txtVehiculoColor.Location = New System.Drawing.Point(674, 203)
        Me.txtVehiculoColor.Name = "txtVehiculoColor"
        Me.txtVehiculoColor.Size = New System.Drawing.Size(90, 20)
        Me.txtVehiculoColor.TabIndex = 82
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(571, 206)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Vehiculo - Color:"
        '
        'txtVehiculoMarca
        '
        Me.txtVehiculoMarca.Location = New System.Drawing.Point(475, 202)
        Me.txtVehiculoMarca.Name = "txtVehiculoMarca"
        Me.txtVehiculoMarca.Size = New System.Drawing.Size(90, 20)
        Me.txtVehiculoMarca.TabIndex = 80
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(379, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Vehiculo - Marca:"
        '
        'txtVehiculoPatente
        '
        Me.txtVehiculoPatente.Location = New System.Drawing.Point(292, 203)
        Me.txtVehiculoPatente.Name = "txtVehiculoPatente"
        Me.txtVehiculoPatente.Size = New System.Drawing.Size(79, 20)
        Me.txtVehiculoPatente.TabIndex = 78
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(191, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Vehiculo - Patente:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(489, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "E-mail:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(567, 153)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(197, 20)
        Me.txtEmail.TabIndex = 75
        '
        'txtTelCel
        '
        Me.txtTelCel.Location = New System.Drawing.Point(292, 157)
        Me.txtTelCel.Name = "txtTelCel"
        Me.txtTelCel.Size = New System.Drawing.Size(191, 20)
        Me.txtTelCel.TabIndex = 74
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(191, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Tel./Cel:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(489, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Provincia:"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(292, 130)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(191, 20)
        Me.txtLocalidad.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(191, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Localidad:"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(567, 102)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(197, 20)
        Me.txtCP.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(489, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "CP:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(292, 102)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(191, 20)
        Me.txtDireccion.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(191, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Dirección:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(489, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Edad:"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(567, 77)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(197, 20)
        Me.txtEdad.TabIndex = 64
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(292, 74)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(191, 20)
        Me.txtDNI.TabIndex = 63
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(191, 77)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(29, 13)
        Me.Label.TabIndex = 62
        Me.Label.Text = "DNI:"
        '
        'txtEstadoCivil
        '
        Me.txtEstadoCivil.Location = New System.Drawing.Point(567, 47)
        Me.txtEstadoCivil.Name = "txtEstadoCivil"
        Me.txtEstadoCivil.Size = New System.Drawing.Size(197, 20)
        Me.txtEstadoCivil.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Estado Civil:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(637, 21)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(127, 20)
        Me.txtId.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(612, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Id:"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(292, 47)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(191, 20)
        Me.txtNacionalidad.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Nacionalidad:"
        '
        'txtApellidoNombre
        '
        Me.txtApellidoNombre.Location = New System.Drawing.Point(292, 21)
        Me.txtApellidoNombre.Name = "txtApellidoNombre"
        Me.txtApellidoNombre.Size = New System.Drawing.Size(314, 20)
        Me.txtApellidoNombre.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Apellido y Nombre:"
        '
        'btnBorrarAcomp
        '
        Me.btnBorrarAcomp.Location = New System.Drawing.Point(707, 349)
        Me.btnBorrarAcomp.Name = "btnBorrarAcomp"
        Me.btnBorrarAcomp.Size = New System.Drawing.Size(109, 34)
        Me.btnBorrarAcomp.TabIndex = 96
        Me.btnBorrarAcomp.Text = "Borrar Acompañante"
        Me.btnBorrarAcomp.UseVisualStyleBackColor = True
        '
        'dgvAcompaniantes
        '
        Me.dgvAcompaniantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAcompaniantes.Location = New System.Drawing.Point(306, 276)
        Me.dgvAcompaniantes.Name = "dgvAcompaniantes"
        Me.dgvAcompaniantes.Size = New System.Drawing.Size(395, 177)
        Me.dgvAcompaniantes.TabIndex = 95
        '
        'btnAgregarAcomp
        '
        Me.btnAgregarAcomp.Location = New System.Drawing.Point(705, 299)
        Me.btnAgregarAcomp.Name = "btnAgregarAcomp"
        Me.btnAgregarAcomp.Size = New System.Drawing.Size(109, 34)
        Me.btnAgregarAcomp.TabIndex = 94
        Me.btnAgregarAcomp.Text = "Acompañante"
        Me.btnAgregarAcomp.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(897, 471)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 93
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(804, 471)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 92
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'pcbCliente
        '
        Me.pcbCliente.Location = New System.Drawing.Point(12, 20)
        Me.pcbCliente.Name = "pcbCliente"
        Me.pcbCliente.Size = New System.Drawing.Size(151, 176)
        Me.pcbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbCliente.TabIndex = 97
        Me.pcbCliente.TabStop = False
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.Location = New System.Drawing.Point(12, 206)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(144, 23)
        Me.btnCargarImagen.TabIndex = 98
        Me.btnCargarImagen.Text = "Cargar foto de perfil"
        Me.btnCargarImagen.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(773, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Cabaña:"
        '
        'cmbCabania
        '
        Me.cmbCabania.FormattingEnabled = True
        Me.cmbCabania.Location = New System.Drawing.Point(857, 20)
        Me.cmbCabania.Name = "cmbCabania"
        Me.cmbCabania.Size = New System.Drawing.Size(109, 21)
        Me.cmbCabania.TabIndex = 90
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(567, 125)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(197, 21)
        Me.cmbProvincia.TabIndex = 91
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 513)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCargarImagen)
        Me.Controls.Add(Me.pcbCliente)
        Me.Controls.Add(Me.btnBorrarAcomp)
        Me.Controls.Add(Me.dgvAcompaniantes)
        Me.Controls.Add(Me.btnAgregarAcomp)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbProvincia)
        Me.Controls.Add(Me.cmbCabania)
        Me.Controls.Add(Me.txtFechaEgreso)
        Me.Controls.Add(Me.txtFechaIngreso)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtHoraEgreso)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtVehiculoColor)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtVehiculoMarca)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtVehiculoPatente)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelCel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.txtEstadoCivil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNacionalidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApellidoNombre)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmClientes"
        Me.Text = "Cliente"
        CType(Me.dgvAcompaniantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFechaEgreso As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtHoraEgreso As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtVehiculoColor As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtVehiculoMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtVehiculoPatente As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelCel As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents txtEstadoCivil As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBorrarAcomp As System.Windows.Forms.Button
    Friend WithEvents dgvAcompaniantes As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregarAcomp As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents pcbCliente As System.Windows.Forms.PictureBox
    Friend WithEvents btnCargarImagen As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCabania As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
End Class
