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
        Me.lblFechaFinContrato = New System.Windows.Forms.Label()
        Me.lblFechaContrato = New System.Windows.Forms.Label()
        Me.lblFechaCreacion = New System.Windows.Forms.Label()
        Me.lblIdContrata = New System.Windows.Forms.Label()
        Me.txtFechaFinContrato = New System.Windows.Forms.TextBox()
        Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
        Me.cbxIdPersona = New System.Windows.Forms.ComboBox()
        Me.lblIdServicio = New System.Windows.Forms.Label()
        Me.cbxIdServicio = New System.Windows.Forms.ComboBox()
        Me.FechaContrato = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
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
        Me.btnEnable.Location = New System.Drawing.Point(166, 403)
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
        'lblFechaFinContrato
        '
        Me.lblFechaFinContrato.AutoSize = True
        Me.lblFechaFinContrato.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaFinContrato.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinContrato.Location = New System.Drawing.Point(35, 334)
        Me.lblFechaFinContrato.Name = "lblFechaFinContrato"
        Me.lblFechaFinContrato.Size = New System.Drawing.Size(161, 18)
        Me.lblFechaFinContrato.TabIndex = 76
        Me.lblFechaFinContrato.Text = "Fecha Fin Contrato"
        '
        'lblFechaContrato
        '
        Me.lblFechaContrato.AutoSize = True
        Me.lblFechaContrato.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaContrato.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaContrato.Location = New System.Drawing.Point(35, 285)
        Me.lblFechaContrato.Name = "lblFechaContrato"
        Me.lblFechaContrato.Size = New System.Drawing.Size(133, 18)
        Me.lblFechaContrato.TabIndex = 75
        Me.lblFechaContrato.Text = "Fecha Contrato"
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaCreacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCreacion.Location = New System.Drawing.Point(35, 236)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(135, 18)
        Me.lblFechaCreacion.TabIndex = 74
        Me.lblFechaCreacion.Text = "Fecha Creacion"
        '
        'lblIdContrata
        '
        Me.lblIdContrata.AutoSize = True
        Me.lblIdContrata.BackColor = System.Drawing.Color.Transparent
        Me.lblIdContrata.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdContrata.Location = New System.Drawing.Point(35, 126)
        Me.lblIdContrata.Name = "lblIdContrata"
        Me.lblIdContrata.Size = New System.Drawing.Size(83, 18)
        Me.lblIdContrata.TabIndex = 72
        Me.lblIdContrata.Text = "Id Cliente"
        '
        'txtFechaFinContrato
        '
        Me.txtFechaFinContrato.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFinContrato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaFinContrato.Location = New System.Drawing.Point(202, 331)
        Me.txtFechaFinContrato.Multiline = True
        Me.txtFechaFinContrato.Name = "txtFechaFinContrato"
        Me.txtFechaFinContrato.Size = New System.Drawing.Size(242, 26)
        Me.txtFechaFinContrato.TabIndex = 71
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCreacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaCreacion.Location = New System.Drawing.Point(202, 233)
        Me.txtFechaCreacion.Multiline = True
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.Size = New System.Drawing.Size(242, 26)
        Me.txtFechaCreacion.TabIndex = 70
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
        'lblIdServicio
        '
        Me.lblIdServicio.AutoSize = True
        Me.lblIdServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblIdServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdServicio.Location = New System.Drawing.Point(35, 177)
        Me.lblIdServicio.Name = "lblIdServicio"
        Me.lblIdServicio.Size = New System.Drawing.Size(92, 18)
        Me.lblIdServicio.TabIndex = 82
        Me.lblIdServicio.Text = "Id Servicio"
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
        'FechaContrato
        '
        Me.FechaContrato.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaContrato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FechaContrato.Location = New System.Drawing.Point(202, 285)
        Me.FechaContrato.Multiline = True
        Me.FechaContrato.Name = "FechaContrato"
        Me.FechaContrato.Size = New System.Drawing.Size(242, 26)
        Me.FechaContrato.TabIndex = 84
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Indigo
        Me.btnLimpiar.Location = New System.Drawing.Point(260, 403)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(89, 34)
        Me.btnLimpiar.TabIndex = 85
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'ContratarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backAgregar
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.FechaContrato)
        Me.Controls.Add(Me.cbxIdServicio)
        Me.Controls.Add(Me.lblIdServicio)
        Me.Controls.Add(Me.cbxIdPersona)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblFechaFinContrato)
        Me.Controls.Add(Me.lblFechaContrato)
        Me.Controls.Add(Me.lblFechaCreacion)
        Me.Controls.Add(Me.lblIdContrata)
        Me.Controls.Add(Me.txtFechaFinContrato)
        Me.Controls.Add(Me.txtFechaCreacion)
        Me.Controls.Add(Me.lblAgregarUsuario)
        Me.Name = "ContratarServicio"
        Me.Text = "ContratarServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarUsuario As Label
    Friend WithEvents btnEnable As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblFechaFinContrato As Label
    Friend WithEvents lblFechaContrato As Label
    Friend WithEvents lblFechaCreacion As Label
    Friend WithEvents lblIdContrata As Label
    Friend WithEvents txtFechaFinContrato As TextBox
    Friend WithEvents txtFechaCreacion As TextBox
    Friend WithEvents cbxIdPersona As ComboBox
    Friend WithEvents lblIdServicio As Label
    Friend WithEvents cbxIdServicio As ComboBox
    Friend WithEvents FechaContrato As TextBox
    Friend WithEvents btnLimpiar As Button
End Class
