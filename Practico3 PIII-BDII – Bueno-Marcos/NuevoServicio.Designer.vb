<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoServicio
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
        Me.lblAgregarUsuario = New System.Windows.Forms.Label()
        Me.lblIdServicio = New System.Windows.Forms.Label()
        Me.txtFechaNuevoServicio = New System.Windows.Forms.TextBox()
        Me.txtCostoMensualNuevoServicio = New System.Windows.Forms.TextBox()
        Me.txtNombreNuevoServicio = New System.Windows.Forms.TextBox()
        Me.txtIdNuevoServicio = New System.Windows.Forms.TextBox()
        Me.lblNombreServicio = New System.Windows.Forms.Label()
        Me.lblCostoMensual = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblFechaServicio = New System.Windows.Forms.Label()
        Me.checkActivoNuevoServicio = New System.Windows.Forms.CheckBox()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cmbTipos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblAgregarUsuario
        '
        Me.lblAgregarUsuario.AutoSize = True
        Me.lblAgregarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblAgregarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarUsuario.Location = New System.Drawing.Point(170, 50)
        Me.lblAgregarUsuario.Name = "lblAgregarUsuario"
        Me.lblAgregarUsuario.Size = New System.Drawing.Size(146, 22)
        Me.lblAgregarUsuario.TabIndex = 1
        Me.lblAgregarUsuario.Text = "Nuevo Servicio"
        '
        'lblIdServicio
        '
        Me.lblIdServicio.AutoSize = True
        Me.lblIdServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblIdServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdServicio.Location = New System.Drawing.Point(33, 126)
        Me.lblIdServicio.Name = "lblIdServicio"
        Me.lblIdServicio.Size = New System.Drawing.Size(23, 18)
        Me.lblIdServicio.TabIndex = 25
        Me.lblIdServicio.Text = "Id"
        '
        'txtFechaNuevoServicio
        '
        Me.txtFechaNuevoServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNuevoServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaNuevoServicio.Location = New System.Drawing.Point(95, 331)
        Me.txtFechaNuevoServicio.Multiline = True
        Me.txtFechaNuevoServicio.Name = "txtFechaNuevoServicio"
        Me.txtFechaNuevoServicio.Size = New System.Drawing.Size(347, 26)
        Me.txtFechaNuevoServicio.TabIndex = 23
        '
        'txtCostoMensualNuevoServicio
        '
        Me.txtCostoMensualNuevoServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoMensualNuevoServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCostoMensualNuevoServicio.Location = New System.Drawing.Point(164, 233)
        Me.txtCostoMensualNuevoServicio.Multiline = True
        Me.txtCostoMensualNuevoServicio.Name = "txtCostoMensualNuevoServicio"
        Me.txtCostoMensualNuevoServicio.Size = New System.Drawing.Size(278, 26)
        Me.txtCostoMensualNuevoServicio.TabIndex = 20
        '
        'txtNombreNuevoServicio
        '
        Me.txtNombreNuevoServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreNuevoServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreNuevoServicio.Location = New System.Drawing.Point(164, 177)
        Me.txtNombreNuevoServicio.Multiline = True
        Me.txtNombreNuevoServicio.Name = "txtNombreNuevoServicio"
        Me.txtNombreNuevoServicio.Size = New System.Drawing.Size(278, 26)
        Me.txtNombreNuevoServicio.TabIndex = 18
        '
        'txtIdNuevoServicio
        '
        Me.txtIdNuevoServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdNuevoServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdNuevoServicio.Location = New System.Drawing.Point(164, 126)
        Me.txtIdNuevoServicio.Multiline = True
        Me.txtIdNuevoServicio.Name = "txtIdNuevoServicio"
        Me.txtIdNuevoServicio.Size = New System.Drawing.Size(278, 26)
        Me.txtIdNuevoServicio.TabIndex = 17
        '
        'lblNombreServicio
        '
        Me.lblNombreServicio.AutoSize = True
        Me.lblNombreServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreServicio.Location = New System.Drawing.Point(33, 180)
        Me.lblNombreServicio.Name = "lblNombreServicio"
        Me.lblNombreServicio.Size = New System.Drawing.Size(71, 18)
        Me.lblNombreServicio.TabIndex = 26
        Me.lblNombreServicio.Text = "Nombre"
        '
        'lblCostoMensual
        '
        Me.lblCostoMensual.AutoSize = True
        Me.lblCostoMensual.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoMensual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoMensual.Location = New System.Drawing.Point(33, 236)
        Me.lblCostoMensual.Name = "lblCostoMensual"
        Me.lblCostoMensual.Size = New System.Drawing.Size(125, 18)
        Me.lblCostoMensual.TabIndex = 27
        Me.lblCostoMensual.Text = "Costo Mensual"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(33, 285)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(42, 18)
        Me.lblTipo.TabIndex = 28
        Me.lblTipo.Text = "Tipo"
        '
        'lblFechaServicio
        '
        Me.lblFechaServicio.AutoSize = True
        Me.lblFechaServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaServicio.Location = New System.Drawing.Point(33, 334)
        Me.lblFechaServicio.Name = "lblFechaServicio"
        Me.lblFechaServicio.Size = New System.Drawing.Size(58, 18)
        Me.lblFechaServicio.TabIndex = 29
        Me.lblFechaServicio.Text = "Fecha"
        '
        'checkActivoNuevoServicio
        '
        Me.checkActivoNuevoServicio.AutoSize = True
        Me.checkActivoNuevoServicio.BackColor = System.Drawing.Color.Transparent
        Me.checkActivoNuevoServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkActivoNuevoServicio.Location = New System.Drawing.Point(95, 381)
        Me.checkActivoNuevoServicio.Name = "checkActivoNuevoServicio"
        Me.checkActivoNuevoServicio.Size = New System.Drawing.Size(78, 22)
        Me.checkActivoNuevoServicio.TabIndex = 30
        Me.checkActivoNuevoServicio.Text = "Activo"
        Me.checkActivoNuevoServicio.UseVisualStyleBackColor = False
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = System.Drawing.Color.Transparent
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnable.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.ForeColor = System.Drawing.Color.Indigo
        Me.btnEnable.Location = New System.Drawing.Point(258, 403)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(89, 34)
        Me.btnEnable.TabIndex = 66
        Me.btnEnable.Text = "Habilitar"
        Me.btnEnable.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnGuardar.Location = New System.Drawing.Point(353, 403)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 34)
        Me.btnGuardar.TabIndex = 65
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'cmbTipos
        '
        Me.cmbTipos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipos.FormattingEnabled = True
        Me.cmbTipos.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciones", "Informática"})
        Me.cmbTipos.Location = New System.Drawing.Point(95, 286)
        Me.cmbTipos.Name = "cmbTipos"
        Me.cmbTipos.Size = New System.Drawing.Size(347, 26)
        Me.cmbTipos.TabIndex = 67
        Me.cmbTipos.Text = "Seleccione un tipo"
        '
        'NuevoServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backAgregar
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.cmbTipos)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.checkActivoNuevoServicio)
        Me.Controls.Add(Me.lblFechaServicio)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblCostoMensual)
        Me.Controls.Add(Me.lblNombreServicio)
        Me.Controls.Add(Me.lblIdServicio)
        Me.Controls.Add(Me.txtFechaNuevoServicio)
        Me.Controls.Add(Me.txtCostoMensualNuevoServicio)
        Me.Controls.Add(Me.txtNombreNuevoServicio)
        Me.Controls.Add(Me.txtIdNuevoServicio)
        Me.Controls.Add(Me.lblAgregarUsuario)
        Me.Name = "NuevoServicio"
        Me.Text = "NuevoServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarUsuario As Label
    Friend WithEvents lblIdServicio As Label
    Friend WithEvents txtFechaNuevoServicio As TextBox
    Friend WithEvents txtCostoMensualNuevoServicio As TextBox
    Friend WithEvents txtNombreNuevoServicio As TextBox
    Friend WithEvents txtIdNuevoServicio As TextBox
    Friend WithEvents lblNombreServicio As Label
    Friend WithEvents lblCostoMensual As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblFechaServicio As Label
    Friend WithEvents checkActivoNuevoServicio As CheckBox
    Friend WithEvents btnEnable As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cmbTipos As ComboBox
End Class
