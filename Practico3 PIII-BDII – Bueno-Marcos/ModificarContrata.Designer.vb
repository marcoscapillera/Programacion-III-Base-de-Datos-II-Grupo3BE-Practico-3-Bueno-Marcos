<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarContrata
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
        Me.lblTablaDatos = New System.Windows.Forms.Label()
        Me.btnListarContrata = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.DataGridContrata = New System.Windows.Forms.DataGridView()
        Me.lblModificarUsuario = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtFechaContrato = New System.Windows.Forms.TextBox()
        Me.cbxIdServicio = New System.Windows.Forms.ComboBox()
        Me.lblIdServicio = New System.Windows.Forms.Label()
        Me.cbxIdPersona = New System.Windows.Forms.ComboBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblFechaFinContrato = New System.Windows.Forms.Label()
        Me.lblFechaContrato = New System.Windows.Forms.Label()
        Me.lblFechaCreacion = New System.Windows.Forms.Label()
        Me.lblIdContrata = New System.Windows.Forms.Label()
        Me.txtFechaFinContrato = New System.Windows.Forms.TextBox()
        Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridContrata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTablaDatos
        '
        Me.lblTablaDatos.AutoSize = True
        Me.lblTablaDatos.BackColor = System.Drawing.Color.Transparent
        Me.lblTablaDatos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTablaDatos.Location = New System.Drawing.Point(467, 132)
        Me.lblTablaDatos.Name = "lblTablaDatos"
        Me.lblTablaDatos.Size = New System.Drawing.Size(55, 18)
        Me.lblTablaDatos.TabIndex = 75
        Me.lblTablaDatos.Text = "Datos"
        '
        'btnListarContrata
        '
        Me.btnListarContrata.BackColor = System.Drawing.Color.Transparent
        Me.btnListarContrata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarContrata.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarContrata.ForeColor = System.Drawing.Color.Crimson
        Me.btnListarContrata.Location = New System.Drawing.Point(987, 587)
        Me.btnListarContrata.Name = "btnListarContrata"
        Me.btnListarContrata.Size = New System.Drawing.Size(89, 34)
        Me.btnListarContrata.TabIndex = 74
        Me.btnListarContrata.Text = "Listar"
        Me.btnListarContrata.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.search_6_16
        Me.PictureBox1.Location = New System.Drawing.Point(532, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'buscar
        '
        Me.buscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buscar.Location = New System.Drawing.Point(566, 59)
        Me.buscar.Multiline = True
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(417, 32)
        Me.buscar.TabIndex = 72
        '
        'DataGridContrata
        '
        Me.DataGridContrata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridContrata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridContrata.Location = New System.Drawing.Point(470, 164)
        Me.DataGridContrata.Name = "DataGridContrata"
        Me.DataGridContrata.Size = New System.Drawing.Size(606, 372)
        Me.DataGridContrata.TabIndex = 71
        '
        'lblModificarUsuario
        '
        Me.lblModificarUsuario.AutoSize = True
        Me.lblModificarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblModificarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarUsuario.Location = New System.Drawing.Point(134, 69)
        Me.lblModificarUsuario.Name = "lblModificarUsuario"
        Me.lblModificarUsuario.Size = New System.Drawing.Size(180, 22)
        Me.lblModificarUsuario.TabIndex = 70
        Me.lblModificarUsuario.Text = "Modificar Contrata"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Indigo
        Me.btnLimpiar.Location = New System.Drawing.Point(254, 502)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(89, 34)
        Me.btnLimpiar.TabIndex = 99
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtFechaContrato
        '
        Me.txtFechaContrato.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaContrato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaContrato.Location = New System.Drawing.Point(196, 384)
        Me.txtFechaContrato.Multiline = True
        Me.txtFechaContrato.Name = "txtFechaContrato"
        Me.txtFechaContrato.Size = New System.Drawing.Size(242, 26)
        Me.txtFechaContrato.TabIndex = 98
        '
        'cbxIdServicio
        '
        Me.cbxIdServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIdServicio.FormattingEnabled = True
        Me.cbxIdServicio.Location = New System.Drawing.Point(160, 273)
        Me.cbxIdServicio.Name = "cbxIdServicio"
        Me.cbxIdServicio.Size = New System.Drawing.Size(87, 26)
        Me.cbxIdServicio.TabIndex = 97
        '
        'lblIdServicio
        '
        Me.lblIdServicio.AutoSize = True
        Me.lblIdServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblIdServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdServicio.Location = New System.Drawing.Point(29, 276)
        Me.lblIdServicio.Name = "lblIdServicio"
        Me.lblIdServicio.Size = New System.Drawing.Size(92, 18)
        Me.lblIdServicio.TabIndex = 96
        Me.lblIdServicio.Text = "Id Servicio"
        '
        'cbxIdPersona
        '
        Me.cbxIdPersona.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIdPersona.FormattingEnabled = True
        Me.cbxIdPersona.Location = New System.Drawing.Point(160, 225)
        Me.cbxIdPersona.Name = "cbxIdPersona"
        Me.cbxIdPersona.Size = New System.Drawing.Size(87, 26)
        Me.cbxIdPersona.TabIndex = 95
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.Location = New System.Drawing.Point(349, 502)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(89, 34)
        Me.btnModificar.TabIndex = 93
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'lblFechaFinContrato
        '
        Me.lblFechaFinContrato.AutoSize = True
        Me.lblFechaFinContrato.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaFinContrato.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinContrato.Location = New System.Drawing.Point(29, 433)
        Me.lblFechaFinContrato.Name = "lblFechaFinContrato"
        Me.lblFechaFinContrato.Size = New System.Drawing.Size(161, 18)
        Me.lblFechaFinContrato.TabIndex = 92
        Me.lblFechaFinContrato.Text = "Fecha Fin Contrato"
        '
        'lblFechaContrato
        '
        Me.lblFechaContrato.AutoSize = True
        Me.lblFechaContrato.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaContrato.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaContrato.Location = New System.Drawing.Point(29, 384)
        Me.lblFechaContrato.Name = "lblFechaContrato"
        Me.lblFechaContrato.Size = New System.Drawing.Size(133, 18)
        Me.lblFechaContrato.TabIndex = 91
        Me.lblFechaContrato.Text = "Fecha Contrato"
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaCreacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCreacion.Location = New System.Drawing.Point(29, 335)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(135, 18)
        Me.lblFechaCreacion.TabIndex = 90
        Me.lblFechaCreacion.Text = "Fecha Creacion"
        '
        'lblIdContrata
        '
        Me.lblIdContrata.AutoSize = True
        Me.lblIdContrata.BackColor = System.Drawing.Color.Transparent
        Me.lblIdContrata.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdContrata.Location = New System.Drawing.Point(29, 225)
        Me.lblIdContrata.Name = "lblIdContrata"
        Me.lblIdContrata.Size = New System.Drawing.Size(83, 18)
        Me.lblIdContrata.TabIndex = 89
        Me.lblIdContrata.Text = "Id Cliente"
        '
        'txtFechaFinContrato
        '
        Me.txtFechaFinContrato.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFinContrato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaFinContrato.Location = New System.Drawing.Point(196, 430)
        Me.txtFechaFinContrato.Multiline = True
        Me.txtFechaFinContrato.Name = "txtFechaFinContrato"
        Me.txtFechaFinContrato.Size = New System.Drawing.Size(242, 26)
        Me.txtFechaFinContrato.TabIndex = 88
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCreacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaCreacion.Location = New System.Drawing.Point(196, 332)
        Me.txtFechaCreacion.Multiline = True
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.Size = New System.Drawing.Size(242, 26)
        Me.txtFechaCreacion.TabIndex = 87
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.BackColor = System.Drawing.Color.Transparent
        Me.lblForm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm.Location = New System.Drawing.Point(29, 142)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(94, 18)
        Me.lblForm.TabIndex = 100
        Me.lblForm.Text = "Formulario"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.Indigo
        Me.btnActualizar.Location = New System.Drawing.Point(158, 502)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(89, 34)
        Me.btnActualizar.TabIndex = 101
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'ModificarContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backmodiifcarCliente
        Me.ClientSize = New System.Drawing.Size(1141, 661)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtFechaContrato)
        Me.Controls.Add(Me.cbxIdServicio)
        Me.Controls.Add(Me.lblIdServicio)
        Me.Controls.Add(Me.cbxIdPersona)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblFechaFinContrato)
        Me.Controls.Add(Me.lblFechaContrato)
        Me.Controls.Add(Me.lblFechaCreacion)
        Me.Controls.Add(Me.lblIdContrata)
        Me.Controls.Add(Me.txtFechaFinContrato)
        Me.Controls.Add(Me.txtFechaCreacion)
        Me.Controls.Add(Me.lblTablaDatos)
        Me.Controls.Add(Me.btnListarContrata)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.DataGridContrata)
        Me.Controls.Add(Me.lblModificarUsuario)
        Me.Name = "ModificarContrata"
        Me.Text = "ModificarContrata"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridContrata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTablaDatos As Label
    Friend WithEvents btnListarContrata As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buscar As TextBox
    Friend WithEvents DataGridContrata As DataGridView
    Friend WithEvents lblModificarUsuario As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtFechaContrato As TextBox
    Friend WithEvents cbxIdServicio As ComboBox
    Friend WithEvents lblIdServicio As Label
    Friend WithEvents cbxIdPersona As ComboBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblFechaFinContrato As Label
    Friend WithEvents lblFechaContrato As Label
    Friend WithEvents lblFechaCreacion As Label
    Friend WithEvents lblIdContrata As Label
    Friend WithEvents txtFechaFinContrato As TextBox
    Friend WithEvents txtFechaCreacion As TextBox
    Friend WithEvents lblForm As Label
    Friend WithEvents btnActualizar As Button
End Class
