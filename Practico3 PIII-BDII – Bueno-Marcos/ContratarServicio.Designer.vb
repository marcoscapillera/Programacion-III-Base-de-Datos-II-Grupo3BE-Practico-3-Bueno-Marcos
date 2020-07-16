<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContratarServicio
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
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblFechaServicio = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblCostoMensual = New System.Windows.Forms.Label()
        Me.lblIdServicio = New System.Windows.Forms.Label()
        Me.txtFechaNuevoServicio = New System.Windows.Forms.TextBox()
        Me.txtCostoMensualNuevoServicio = New System.Windows.Forms.TextBox()
        Me.cbxIdPersona = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxIdServicio = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAgregarUsuario
        '
        Me.lblAgregarUsuario.AutoSize = True
        Me.lblAgregarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblAgregarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarUsuario.Location = New System.Drawing.Point(141, 38)
        Me.lblAgregarUsuario.Name = "lblAgregarUsuario"
        Me.lblAgregarUsuario.Size = New System.Drawing.Size(177, 22)
        Me.lblAgregarUsuario.TabIndex = 2
        Me.lblAgregarUsuario.Text = "Contratar Servicio"
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = System.Drawing.Color.Transparent
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnable.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.ForeColor = System.Drawing.Color.Indigo
        Me.btnEnable.Location = New System.Drawing.Point(260, 403)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(89, 34)
        Me.btnEnable.TabIndex = 79
        Me.btnEnable.Text = "Actualizar"
        Me.btnEnable.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnGuardar.Location = New System.Drawing.Point(355, 403)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 34)
        Me.btnGuardar.TabIndex = 78
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblFechaServicio
        '
        Me.lblFechaServicio.AutoSize = True
        Me.lblFechaServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaServicio.Location = New System.Drawing.Point(35, 334)
        Me.lblFechaServicio.Name = "lblFechaServicio"
        Me.lblFechaServicio.Size = New System.Drawing.Size(161, 18)
        Me.lblFechaServicio.TabIndex = 76
        Me.lblFechaServicio.Text = "Fecha Fin Contrato"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(35, 285)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(113, 18)
        Me.lblTipo.TabIndex = 75
        Me.lblTipo.Text = "Contratacion"
        '
        'lblCostoMensual
        '
        Me.lblCostoMensual.AutoSize = True
        Me.lblCostoMensual.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoMensual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoMensual.Location = New System.Drawing.Point(35, 236)
        Me.lblCostoMensual.Name = "lblCostoMensual"
        Me.lblCostoMensual.Size = New System.Drawing.Size(135, 18)
        Me.lblCostoMensual.TabIndex = 74
        Me.lblCostoMensual.Text = "Fecha Creacion"
        '
        'lblIdServicio
        '
        Me.lblIdServicio.AutoSize = True
        Me.lblIdServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblIdServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdServicio.Location = New System.Drawing.Point(35, 126)
        Me.lblIdServicio.Name = "lblIdServicio"
        Me.lblIdServicio.Size = New System.Drawing.Size(83, 18)
        Me.lblIdServicio.TabIndex = 72
        Me.lblIdServicio.Text = "Id Cliente"
        '
        'txtFechaNuevoServicio
        '
        Me.txtFechaNuevoServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNuevoServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaNuevoServicio.Location = New System.Drawing.Point(202, 331)
        Me.txtFechaNuevoServicio.Multiline = True
        Me.txtFechaNuevoServicio.Name = "txtFechaNuevoServicio"
        Me.txtFechaNuevoServicio.Size = New System.Drawing.Size(242, 26)
        Me.txtFechaNuevoServicio.TabIndex = 71
        '
        'txtCostoMensualNuevoServicio
        '
        Me.txtCostoMensualNuevoServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoMensualNuevoServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCostoMensualNuevoServicio.Location = New System.Drawing.Point(202, 233)
        Me.txtCostoMensualNuevoServicio.Multiline = True
        Me.txtCostoMensualNuevoServicio.Name = "txtCostoMensualNuevoServicio"
        Me.txtCostoMensualNuevoServicio.Size = New System.Drawing.Size(242, 26)
        Me.txtCostoMensualNuevoServicio.TabIndex = 70
        '
        'cbxIdPersona
        '
        Me.cbxIdPersona.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIdPersona.FormattingEnabled = True
        Me.cbxIdPersona.Location = New System.Drawing.Point(166, 126)
        Me.cbxIdPersona.Name = "cbxIdPersona"
        Me.cbxIdPersona.Size = New System.Drawing.Size(87, 26)
        Me.cbxIdPersona.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Id Servicio"
        '
        'cbxIdServicio
        '
        Me.cbxIdServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIdServicio.FormattingEnabled = True
        Me.cbxIdServicio.Location = New System.Drawing.Point(166, 174)
        Me.cbxIdServicio.Name = "cbxIdServicio"
        Me.cbxIdServicio.Size = New System.Drawing.Size(87, 26)
        Me.cbxIdServicio.TabIndex = 83
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(202, 285)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(242, 26)
        Me.TextBox1.TabIndex = 84
        '
        'ContratarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backAgregar
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cbxIdServicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxIdPersona)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblFechaServicio)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblCostoMensual)
        Me.Controls.Add(Me.lblIdServicio)
        Me.Controls.Add(Me.txtFechaNuevoServicio)
        Me.Controls.Add(Me.txtCostoMensualNuevoServicio)
        Me.Controls.Add(Me.lblAgregarUsuario)
        Me.Name = "ContratarServicio"
        Me.Text = "ContratarServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarUsuario As Label
    Friend WithEvents btnEnable As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblFechaServicio As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblCostoMensual As Label
    Friend WithEvents lblIdServicio As Label
    Friend WithEvents txtFechaNuevoServicio As TextBox
    Friend WithEvents txtCostoMensualNuevoServicio As TextBox
    Friend WithEvents cbxIdPersona As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxIdServicio As ComboBox
    Friend WithEvents TextBox1 As TextBox
End Class
