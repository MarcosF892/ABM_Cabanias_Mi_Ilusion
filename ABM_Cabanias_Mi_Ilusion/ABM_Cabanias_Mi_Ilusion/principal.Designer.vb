<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CabaniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcompaniantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProvinciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 357)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(847, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(847, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.CabaniaToolStripMenuItem, Me.AcompaniantesToolStripMenuItem, Me.ProvinciasToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ArchivosToolStripMenuItem.Text = "Registros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CabaniaToolStripMenuItem
        '
        Me.CabaniaToolStripMenuItem.Name = "CabaniaToolStripMenuItem"
        Me.CabaniaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CabaniaToolStripMenuItem.Text = "Cabanias"
        '
        'AcompaniantesToolStripMenuItem
        '
        Me.AcompaniantesToolStripMenuItem.Name = "AcompaniantesToolStripMenuItem"
        Me.AcompaniantesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AcompaniantesToolStripMenuItem.Text = "Acompaniantes"
        '
        'ProvinciasToolStripMenuItem
        '
        Me.ProvinciasToolStripMenuItem.Name = "ProvinciasToolStripMenuItem"
        Me.ProvinciasToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProvinciasToolStripMenuItem.Text = "Provincias"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 379)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "principal"
        Me.Text = "Cabañas Mi Ilusion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CabaniaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcompaniantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProvinciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
