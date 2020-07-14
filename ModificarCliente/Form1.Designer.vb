<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.lblFechaModificarCliente = New System.Windows.Forms.Label()
        Me.lblTelefono2ModificarCliente = New System.Windows.Forms.Label()
        Me.txtTelefono2ModificarCliente = New System.Windows.Forms.TextBox()
        Me.lblMailModificarCliente = New System.Windows.Forms.Label()
        Me.lblTelefono1ModificarCliente = New System.Windows.Forms.Label()
        Me.lblApellidosModificarCliente = New System.Windows.Forms.Label()
        Me.lblNombreModificarCliente = New System.Windows.Forms.Label()
        Me.lblIdModificarCliente = New System.Windows.Forms.Label()
        Me.txtTelefono1ModificarCliente = New System.Windows.Forms.TextBox()
        Me.checkActivo = New System.Windows.Forms.CheckBox()
        Me.txtFechaModificarCliente = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtMailModificarCliente = New System.Windows.Forms.TextBox()
        Me.txtApellidoModificarCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreModificarCliente = New System.Windows.Forms.TextBox()
        Me.txtIdModificarCliente = New System.Windows.Forms.TextBox()
        Me.lblAgregarUsuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnable
        '
        Me.btnEnable.BackgroundImage = Global.ModificarCliente.My.Resources.Resources.backButton
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnable.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.ForeColor = System.Drawing.Color.White
        Me.btnEnable.Location = New System.Drawing.Point(263, 568)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(89, 34)
        Me.btnEnable.TabIndex = 64
        Me.btnEnable.Text = "Habilitar"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'lblFechaModificarCliente
        '
        Me.lblFechaModificarCliente.AutoSize = True
        Me.lblFechaModificarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaModificarCliente.Location = New System.Drawing.Point(37, 499)
        Me.lblFechaModificarCliente.Name = "lblFechaModificarCliente"
        Me.lblFechaModificarCliente.Size = New System.Drawing.Size(58, 18)
        Me.lblFechaModificarCliente.TabIndex = 63
        Me.lblFechaModificarCliente.Text = "Fecha"
        '
        'lblTelefono2ModificarCliente
        '
        Me.lblTelefono2ModificarCliente.AutoSize = True
        Me.lblTelefono2ModificarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono2ModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono2ModificarCliente.Location = New System.Drawing.Point(37, 444)
        Me.lblTelefono2ModificarCliente.Name = "lblTelefono2ModificarCliente"
        Me.lblTelefono2ModificarCliente.Size = New System.Drawing.Size(87, 18)
        Me.lblTelefono2ModificarCliente.TabIndex = 62
        Me.lblTelefono2ModificarCliente.Text = "Telefono2"
        '
        'txtTelefono2ModificarCliente
        '
        Me.txtTelefono2ModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono2ModificarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefono2ModificarCliente.Location = New System.Drawing.Point(135, 439)
        Me.txtTelefono2ModificarCliente.Multiline = True
        Me.txtTelefono2ModificarCliente.Name = "txtTelefono2ModificarCliente"
        Me.txtTelefono2ModificarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtTelefono2ModificarCliente.TabIndex = 61
        '
        'lblMailModificarCliente
        '
        Me.lblMailModificarCliente.AutoSize = True
        Me.lblMailModificarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblMailModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailModificarCliente.Location = New System.Drawing.Point(37, 331)
        Me.lblMailModificarCliente.Name = "lblMailModificarCliente"
        Me.lblMailModificarCliente.Size = New System.Drawing.Size(39, 18)
        Me.lblMailModificarCliente.TabIndex = 60
        Me.lblMailModificarCliente.Text = "Mail"
        '
        'lblTelefono1ModificarCliente
        '
        Me.lblTelefono1ModificarCliente.AutoSize = True
        Me.lblTelefono1ModificarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono1ModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono1ModificarCliente.Location = New System.Drawing.Point(37, 389)
        Me.lblTelefono1ModificarCliente.Name = "lblTelefono1ModificarCliente"
        Me.lblTelefono1ModificarCliente.Size = New System.Drawing.Size(87, 18)
        Me.lblTelefono1ModificarCliente.TabIndex = 59
        Me.lblTelefono1ModificarCliente.Text = "Telefono1"
        '
        'lblApellidosModificarCliente
        '
        Me.lblApellidosModificarCliente.AutoSize = True
        Me.lblApellidosModificarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidosModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosModificarCliente.Location = New System.Drawing.Point(37, 282)
        Me.lblApellidosModificarCliente.Name = "lblApellidosModificarCliente"
        Me.lblApellidosModificarCliente.Size = New System.Drawing.Size(81, 18)
        Me.lblApellidosModificarCliente.TabIndex = 58
        Me.lblApellidosModificarCliente.Text = "Apellidos"
        '
        'lblNombreModificarCliente
        '
        Me.lblNombreModificarCliente.AutoSize = True
        Me.lblNombreModificarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreModificarCliente.Location = New System.Drawing.Point(37, 216)
        Me.lblNombreModificarCliente.Name = "lblNombreModificarCliente"
        Me.lblNombreModificarCliente.Size = New System.Drawing.Size(71, 18)
        Me.lblNombreModificarCliente.TabIndex = 57
        Me.lblNombreModificarCliente.Text = "Nombre"
        '
        'lblIdModificarCliente
        '
        Me.lblIdModificarCliente.AutoSize = True
        Me.lblIdModificarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblIdModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdModificarCliente.Location = New System.Drawing.Point(37, 154)
        Me.lblIdModificarCliente.Name = "lblIdModificarCliente"
        Me.lblIdModificarCliente.Size = New System.Drawing.Size(23, 18)
        Me.lblIdModificarCliente.TabIndex = 56
        Me.lblIdModificarCliente.Text = "Id"
        '
        'txtTelefono1ModificarCliente
        '
        Me.txtTelefono1ModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono1ModificarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefono1ModificarCliente.Location = New System.Drawing.Point(136, 385)
        Me.txtTelefono1ModificarCliente.Multiline = True
        Me.txtTelefono1ModificarCliente.Name = "txtTelefono1ModificarCliente"
        Me.txtTelefono1ModificarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtTelefono1ModificarCliente.TabIndex = 55
        '
        'checkActivo
        '
        Me.checkActivo.AutoSize = True
        Me.checkActivo.BackColor = System.Drawing.Color.Transparent
        Me.checkActivo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkActivo.Location = New System.Drawing.Point(136, 546)
        Me.checkActivo.Name = "checkActivo"
        Me.checkActivo.Size = New System.Drawing.Size(78, 22)
        Me.checkActivo.TabIndex = 54
        Me.checkActivo.Text = "Activo"
        Me.checkActivo.UseVisualStyleBackColor = False
        '
        'txtFechaModificarCliente
        '
        Me.txtFechaModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaModificarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaModificarCliente.Location = New System.Drawing.Point(136, 496)
        Me.txtFechaModificarCliente.Multiline = True
        Me.txtFechaModificarCliente.Name = "txtFechaModificarCliente"
        Me.txtFechaModificarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtFechaModificarCliente.TabIndex = 53
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.ModificarCliente.My.Resources.Resources.backButton
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(358, 568)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 34)
        Me.btnGuardar.TabIndex = 52
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtMailModificarCliente
        '
        Me.txtMailModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailModificarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMailModificarCliente.Location = New System.Drawing.Point(135, 329)
        Me.txtMailModificarCliente.Multiline = True
        Me.txtMailModificarCliente.Name = "txtMailModificarCliente"
        Me.txtMailModificarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtMailModificarCliente.TabIndex = 51
        '
        'txtApellidoModificarCliente
        '
        Me.txtApellidoModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoModificarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApellidoModificarCliente.Location = New System.Drawing.Point(137, 270)
        Me.txtApellidoModificarCliente.Multiline = True
        Me.txtApellidoModificarCliente.Name = "txtApellidoModificarCliente"
        Me.txtApellidoModificarCliente.Size = New System.Drawing.Size(310, 30)
        Me.txtApellidoModificarCliente.TabIndex = 50
        '
        'txtNombreModificarCliente
        '
        Me.txtNombreModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreModificarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreModificarCliente.Location = New System.Drawing.Point(137, 213)
        Me.txtNombreModificarCliente.Multiline = True
        Me.txtNombreModificarCliente.Name = "txtNombreModificarCliente"
        Me.txtNombreModificarCliente.Size = New System.Drawing.Size(310, 30)
        Me.txtNombreModificarCliente.TabIndex = 49
        '
        'txtIdModificarCliente
        '
        Me.txtIdModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdModificarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdModificarCliente.Location = New System.Drawing.Point(136, 154)
        Me.txtIdModificarCliente.Multiline = True
        Me.txtIdModificarCliente.Name = "txtIdModificarCliente"
        Me.txtIdModificarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtIdModificarCliente.TabIndex = 48
        '
        'lblAgregarUsuario
        '
        Me.lblAgregarUsuario.AutoSize = True
        Me.lblAgregarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblAgregarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarUsuario.Location = New System.Drawing.Point(164, 59)
        Me.lblAgregarUsuario.Name = "lblAgregarUsuario"
        Me.lblAgregarUsuario.Size = New System.Drawing.Size(164, 22)
        Me.lblAgregarUsuario.TabIndex = 47
        Me.lblAgregarUsuario.Text = "Modificar Cliente"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ModificarCliente.My.Resources.Resources.backAgregar
        Me.ClientSize = New System.Drawing.Size(484, 661)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.lblFechaModificarCliente)
        Me.Controls.Add(Me.lblTelefono2ModificarCliente)
        Me.Controls.Add(Me.txtTelefono2ModificarCliente)
        Me.Controls.Add(Me.lblMailModificarCliente)
        Me.Controls.Add(Me.lblTelefono1ModificarCliente)
        Me.Controls.Add(Me.lblApellidosModificarCliente)
        Me.Controls.Add(Me.lblNombreModificarCliente)
        Me.Controls.Add(Me.lblIdModificarCliente)
        Me.Controls.Add(Me.txtTelefono1ModificarCliente)
        Me.Controls.Add(Me.checkActivo)
        Me.Controls.Add(Me.txtFechaModificarCliente)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtMailModificarCliente)
        Me.Controls.Add(Me.txtApellidoModificarCliente)
        Me.Controls.Add(Me.txtNombreModificarCliente)
        Me.Controls.Add(Me.txtIdModificarCliente)
        Me.Controls.Add(Me.lblAgregarUsuario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnable As Button
    Friend WithEvents lblFechaModificarCliente As Label
    Friend WithEvents lblTelefono2ModificarCliente As Label
    Friend WithEvents txtTelefono2ModificarCliente As TextBox
    Friend WithEvents lblMailModificarCliente As Label
    Friend WithEvents lblTelefono1ModificarCliente As Label
    Friend WithEvents lblApellidosModificarCliente As Label
    Friend WithEvents lblNombreModificarCliente As Label
    Friend WithEvents lblIdModificarCliente As Label
    Friend WithEvents txtTelefono1ModificarCliente As TextBox
    Friend WithEvents checkActivo As CheckBox
    Friend WithEvents txtFechaModificarCliente As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtMailModificarCliente As TextBox
    Friend WithEvents txtApellidoModificarCliente As TextBox
    Friend WithEvents txtNombreModificarCliente As TextBox
    Friend WithEvents txtIdModificarCliente As TextBox
    Friend WithEvents lblAgregarUsuario As Label
End Class
