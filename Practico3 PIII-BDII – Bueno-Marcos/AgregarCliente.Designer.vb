<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Me.txtIdAgregarCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreAgregarCliente = New System.Windows.Forms.TextBox()
        Me.txtApellidoAgregarCliente = New System.Windows.Forms.TextBox()
        Me.txtMailAgregarCliente = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtFechaAgregarCliente = New System.Windows.Forms.TextBox()
        Me.checkActivo = New System.Windows.Forms.CheckBox()
        Me.txtTelefono1AgregarCliente = New System.Windows.Forms.TextBox()
        Me.lblIdServicio = New System.Windows.Forms.Label()
        Me.lblNombreAgregarCliente = New System.Windows.Forms.Label()
        Me.lblApellidosAgregarCliente = New System.Windows.Forms.Label()
        Me.lblTelefono1AgregarCliente = New System.Windows.Forms.Label()
        Me.lblMailAgregarCliente = New System.Windows.Forms.Label()
        Me.txtTelefono2AgregarCliente = New System.Windows.Forms.TextBox()
        Me.lblTelefono2AgregarCliente = New System.Windows.Forms.Label()
        Me.lblFechaAgregarCliente = New System.Windows.Forms.Label()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAgregarUsuario
        '
        Me.lblAgregarUsuario.AutoSize = True
        Me.lblAgregarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblAgregarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarUsuario.Location = New System.Drawing.Point(158, 45)
        Me.lblAgregarUsuario.Name = "lblAgregarUsuario"
        Me.lblAgregarUsuario.Size = New System.Drawing.Size(155, 22)
        Me.lblAgregarUsuario.TabIndex = 0
        Me.lblAgregarUsuario.Text = "Agregar Cliente"
        '
        'txtIdAgregarCliente
        '
        Me.txtIdAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdAgregarCliente.Location = New System.Drawing.Point(130, 140)
        Me.txtIdAgregarCliente.Multiline = True
        Me.txtIdAgregarCliente.Name = "txtIdAgregarCliente"
        Me.txtIdAgregarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtIdAgregarCliente.TabIndex = 1
        '
        'txtNombreAgregarCliente
        '
        Me.txtNombreAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreAgregarCliente.Location = New System.Drawing.Point(131, 199)
        Me.txtNombreAgregarCliente.Multiline = True
        Me.txtNombreAgregarCliente.Name = "txtNombreAgregarCliente"
        Me.txtNombreAgregarCliente.Size = New System.Drawing.Size(310, 30)
        Me.txtNombreAgregarCliente.TabIndex = 3
        '
        'txtApellidoAgregarCliente
        '
        Me.txtApellidoAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApellidoAgregarCliente.Location = New System.Drawing.Point(131, 256)
        Me.txtApellidoAgregarCliente.Multiline = True
        Me.txtApellidoAgregarCliente.Name = "txtApellidoAgregarCliente"
        Me.txtApellidoAgregarCliente.Size = New System.Drawing.Size(310, 30)
        Me.txtApellidoAgregarCliente.TabIndex = 5
        '
        'txtMailAgregarCliente
        '
        Me.txtMailAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMailAgregarCliente.Location = New System.Drawing.Point(129, 315)
        Me.txtMailAgregarCliente.Multiline = True
        Me.txtMailAgregarCliente.Name = "txtMailAgregarCliente"
        Me.txtMailAgregarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtMailAgregarCliente.TabIndex = 9
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backButton
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(352, 554)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 34)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtFechaAgregarCliente
        '
        Me.txtFechaAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaAgregarCliente.Location = New System.Drawing.Point(130, 482)
        Me.txtFechaAgregarCliente.Multiline = True
        Me.txtFechaAgregarCliente.Name = "txtFechaAgregarCliente"
        Me.txtFechaAgregarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtFechaAgregarCliente.TabIndex = 16
        '
        'checkActivo
        '
        Me.checkActivo.AutoSize = True
        Me.checkActivo.BackColor = System.Drawing.Color.Transparent
        Me.checkActivo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkActivo.Location = New System.Drawing.Point(130, 532)
        Me.checkActivo.Name = "checkActivo"
        Me.checkActivo.Size = New System.Drawing.Size(78, 22)
        Me.checkActivo.TabIndex = 31
        Me.checkActivo.Text = "Activo"
        Me.checkActivo.UseVisualStyleBackColor = False
        '
        'txtTelefono1AgregarCliente
        '
        Me.txtTelefono1AgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono1AgregarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefono1AgregarCliente.Location = New System.Drawing.Point(130, 371)
        Me.txtTelefono1AgregarCliente.Multiline = True
        Me.txtTelefono1AgregarCliente.Name = "txtTelefono1AgregarCliente"
        Me.txtTelefono1AgregarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtTelefono1AgregarCliente.TabIndex = 37
        '
        'lblIdServicio
        '
        Me.lblIdServicio.AutoSize = True
        Me.lblIdServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblIdServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdServicio.Location = New System.Drawing.Point(31, 140)
        Me.lblIdServicio.Name = "lblIdServicio"
        Me.lblIdServicio.Size = New System.Drawing.Size(23, 18)
        Me.lblIdServicio.TabIndex = 38
        Me.lblIdServicio.Text = "Id"
        '
        'lblNombreAgregarCliente
        '
        Me.lblNombreAgregarCliente.AutoSize = True
        Me.lblNombreAgregarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreAgregarCliente.Location = New System.Drawing.Point(31, 202)
        Me.lblNombreAgregarCliente.Name = "lblNombreAgregarCliente"
        Me.lblNombreAgregarCliente.Size = New System.Drawing.Size(71, 18)
        Me.lblNombreAgregarCliente.TabIndex = 39
        Me.lblNombreAgregarCliente.Text = "Nombre"
        '
        'lblApellidosAgregarCliente
        '
        Me.lblApellidosAgregarCliente.AutoSize = True
        Me.lblApellidosAgregarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidosAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosAgregarCliente.Location = New System.Drawing.Point(31, 268)
        Me.lblApellidosAgregarCliente.Name = "lblApellidosAgregarCliente"
        Me.lblApellidosAgregarCliente.Size = New System.Drawing.Size(81, 18)
        Me.lblApellidosAgregarCliente.TabIndex = 40
        Me.lblApellidosAgregarCliente.Text = "Apellidos"
        '
        'lblTelefono1AgregarCliente
        '
        Me.lblTelefono1AgregarCliente.AutoSize = True
        Me.lblTelefono1AgregarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono1AgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono1AgregarCliente.Location = New System.Drawing.Point(31, 375)
        Me.lblTelefono1AgregarCliente.Name = "lblTelefono1AgregarCliente"
        Me.lblTelefono1AgregarCliente.Size = New System.Drawing.Size(87, 18)
        Me.lblTelefono1AgregarCliente.TabIndex = 41
        Me.lblTelefono1AgregarCliente.Text = "Telefono1"
        '
        'lblMailAgregarCliente
        '
        Me.lblMailAgregarCliente.AutoSize = True
        Me.lblMailAgregarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblMailAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailAgregarCliente.Location = New System.Drawing.Point(31, 317)
        Me.lblMailAgregarCliente.Name = "lblMailAgregarCliente"
        Me.lblMailAgregarCliente.Size = New System.Drawing.Size(39, 18)
        Me.lblMailAgregarCliente.TabIndex = 42
        Me.lblMailAgregarCliente.Text = "Mail"
        '
        'txtTelefono2AgregarCliente
        '
        Me.txtTelefono2AgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono2AgregarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefono2AgregarCliente.Location = New System.Drawing.Point(129, 425)
        Me.txtTelefono2AgregarCliente.Multiline = True
        Me.txtTelefono2AgregarCliente.Name = "txtTelefono2AgregarCliente"
        Me.txtTelefono2AgregarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtTelefono2AgregarCliente.TabIndex = 43
        '
        'lblTelefono2AgregarCliente
        '
        Me.lblTelefono2AgregarCliente.AutoSize = True
        Me.lblTelefono2AgregarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono2AgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono2AgregarCliente.Location = New System.Drawing.Point(31, 430)
        Me.lblTelefono2AgregarCliente.Name = "lblTelefono2AgregarCliente"
        Me.lblTelefono2AgregarCliente.Size = New System.Drawing.Size(87, 18)
        Me.lblTelefono2AgregarCliente.TabIndex = 44
        Me.lblTelefono2AgregarCliente.Text = "Telefono2"
        '
        'lblFechaAgregarCliente
        '
        Me.lblFechaAgregarCliente.AutoSize = True
        Me.lblFechaAgregarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaAgregarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAgregarCliente.Location = New System.Drawing.Point(31, 485)
        Me.lblFechaAgregarCliente.Name = "lblFechaAgregarCliente"
        Me.lblFechaAgregarCliente.Size = New System.Drawing.Size(58, 18)
        Me.lblFechaAgregarCliente.TabIndex = 45
        Me.lblFechaAgregarCliente.Text = "Fecha"
        '
        'btnEnable
        '
        Me.btnEnable.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backButton
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnable.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.ForeColor = System.Drawing.Color.White
        Me.btnEnable.Location = New System.Drawing.Point(257, 554)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(89, 34)
        Me.btnEnable.TabIndex = 46
        Me.btnEnable.Text = "Habilitar"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backAgregar1
        Me.ClientSize = New System.Drawing.Size(484, 661)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.lblFechaAgregarCliente)
        Me.Controls.Add(Me.lblTelefono2AgregarCliente)
        Me.Controls.Add(Me.txtTelefono2AgregarCliente)
        Me.Controls.Add(Me.lblMailAgregarCliente)
        Me.Controls.Add(Me.lblTelefono1AgregarCliente)
        Me.Controls.Add(Me.lblApellidosAgregarCliente)
        Me.Controls.Add(Me.lblNombreAgregarCliente)
        Me.Controls.Add(Me.lblIdServicio)
        Me.Controls.Add(Me.txtTelefono1AgregarCliente)
        Me.Controls.Add(Me.checkActivo)
        Me.Controls.Add(Me.txtFechaAgregarCliente)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtMailAgregarCliente)
        Me.Controls.Add(Me.txtApellidoAgregarCliente)
        Me.Controls.Add(Me.txtNombreAgregarCliente)
        Me.Controls.Add(Me.txtIdAgregarCliente)
        Me.Controls.Add(Me.lblAgregarUsuario)
        Me.Name = "AgregarCliente"
        Me.Text = "Agregar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarUsuario As Label
    Friend WithEvents txtIdAgregarCliente As TextBox
    Friend WithEvents txtNombreAgregarCliente As TextBox
    Friend WithEvents txtApellidoAgregarCliente As TextBox
    Friend WithEvents txtMailAgregarCliente As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtFechaAgregarCliente As TextBox
    Friend WithEvents checkActivo As CheckBox
    Friend WithEvents txtTelefono1AgregarCliente As TextBox
    Friend WithEvents lblIdServicio As Label
    Friend WithEvents lblNombreAgregarCliente As Label
    Friend WithEvents lblApellidosAgregarCliente As Label
    Friend WithEvents lblTelefono1AgregarCliente As Label
    Friend WithEvents lblMailAgregarCliente As Label
    Friend WithEvents txtTelefono2AgregarCliente As TextBox
    Friend WithEvents lblTelefono2AgregarCliente As Label
    Friend WithEvents lblFechaAgregarCliente As Label
    Friend WithEvents btnEnable As Button
End Class
