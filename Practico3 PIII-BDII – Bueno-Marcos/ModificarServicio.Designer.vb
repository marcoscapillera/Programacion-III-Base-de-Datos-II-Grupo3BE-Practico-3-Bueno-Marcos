<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarServicio
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
        Me.btnListarServicios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.DataGridCliente = New System.Windows.Forms.DataGridView()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.lblNombreModificarServicio = New System.Windows.Forms.Label()
        Me.lblIdModificarServicio = New System.Windows.Forms.Label()
        Me.checkActivo = New System.Windows.Forms.CheckBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtNombreModificarServicio = New System.Windows.Forms.TextBox()
        Me.txtIdModificarServicio = New System.Windows.Forms.TextBox()
        Me.lblModificarUsuario = New System.Windows.Forms.Label()
        Me.cmbTiposModificarServicio = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblCostoMensual = New System.Windows.Forms.Label()
        Me.txtCostoMensualModificarServicio = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTablaDatos
        '
        Me.lblTablaDatos.AutoSize = True
        Me.lblTablaDatos.BackColor = System.Drawing.Color.Transparent
        Me.lblTablaDatos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTablaDatos.Location = New System.Drawing.Point(496, 122)
        Me.lblTablaDatos.Name = "lblTablaDatos"
        Me.lblTablaDatos.Size = New System.Drawing.Size(55, 18)
        Me.lblTablaDatos.TabIndex = 92
        Me.lblTablaDatos.Text = "Datos"
        '
        'btnListarServicios
        '
        Me.btnListarServicios.BackColor = System.Drawing.Color.Transparent
        Me.btnListarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarServicios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarServicios.ForeColor = System.Drawing.Color.Crimson
        Me.btnListarServicios.Location = New System.Drawing.Point(1016, 577)
        Me.btnListarServicios.Name = "btnListarServicios"
        Me.btnListarServicios.Size = New System.Drawing.Size(89, 34)
        Me.btnListarServicios.TabIndex = 91
        Me.btnListarServicios.Text = "Listar"
        Me.btnListarServicios.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.search_6_16
        Me.PictureBox1.Location = New System.Drawing.Point(561, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'buscar
        '
        Me.buscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buscar.Location = New System.Drawing.Point(595, 49)
        Me.buscar.Multiline = True
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(417, 32)
        Me.buscar.TabIndex = 89
        '
        'DataGridCliente
        '
        Me.DataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCliente.Location = New System.Drawing.Point(499, 154)
        Me.DataGridCliente.Name = "DataGridCliente"
        Me.DataGridCliente.Size = New System.Drawing.Size(606, 372)
        Me.DataGridCliente.TabIndex = 88
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = System.Drawing.Color.Transparent
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnable.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.ForeColor = System.Drawing.Color.Indigo
        Me.btnEnable.Location = New System.Drawing.Point(88, 429)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(150, 34)
        Me.btnEnable.TabIndex = 87
        Me.btnEnable.Text = "Limpiar"
        Me.btnEnable.UseVisualStyleBackColor = False
        '
        'lblNombreModificarServicio
        '
        Me.lblNombreModificarServicio.AutoSize = True
        Me.lblNombreModificarServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreModificarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreModificarServicio.Location = New System.Drawing.Point(36, 216)
        Me.lblNombreModificarServicio.Name = "lblNombreModificarServicio"
        Me.lblNombreModificarServicio.Size = New System.Drawing.Size(71, 18)
        Me.lblNombreModificarServicio.TabIndex = 80
        Me.lblNombreModificarServicio.Text = "Nombre"
        '
        'lblIdModificarServicio
        '
        Me.lblIdModificarServicio.AutoSize = True
        Me.lblIdModificarServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblIdModificarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdModificarServicio.Location = New System.Drawing.Point(36, 154)
        Me.lblIdModificarServicio.Name = "lblIdModificarServicio"
        Me.lblIdModificarServicio.Size = New System.Drawing.Size(23, 18)
        Me.lblIdModificarServicio.TabIndex = 79
        Me.lblIdModificarServicio.Text = "Id"
        '
        'checkActivo
        '
        Me.checkActivo.AutoSize = True
        Me.checkActivo.BackColor = System.Drawing.Color.Transparent
        Me.checkActivo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkActivo.Location = New System.Drawing.Point(99, 387)
        Me.checkActivo.Name = "checkActivo"
        Me.checkActivo.Size = New System.Drawing.Size(78, 22)
        Me.checkActivo.TabIndex = 77
        Me.checkActivo.Text = "Activo"
        Me.checkActivo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.Location = New System.Drawing.Point(276, 429)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(170, 34)
        Me.btnModificar.TabIndex = 75
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtNombreModificarServicio
        '
        Me.txtNombreModificarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreModificarServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreModificarServicio.Location = New System.Drawing.Point(136, 213)
        Me.txtNombreModificarServicio.Multiline = True
        Me.txtNombreModificarServicio.Name = "txtNombreModificarServicio"
        Me.txtNombreModificarServicio.Size = New System.Drawing.Size(310, 26)
        Me.txtNombreModificarServicio.TabIndex = 72
        '
        'txtIdModificarServicio
        '
        Me.txtIdModificarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdModificarServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdModificarServicio.Location = New System.Drawing.Point(135, 154)
        Me.txtIdModificarServicio.Multiline = True
        Me.txtIdModificarServicio.Name = "txtIdModificarServicio"
        Me.txtIdModificarServicio.Size = New System.Drawing.Size(311, 26)
        Me.txtIdModificarServicio.TabIndex = 71
        '
        'lblModificarUsuario
        '
        Me.lblModificarUsuario.AutoSize = True
        Me.lblModificarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblModificarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarUsuario.Location = New System.Drawing.Point(163, 59)
        Me.lblModificarUsuario.Name = "lblModificarUsuario"
        Me.lblModificarUsuario.Size = New System.Drawing.Size(184, 22)
        Me.lblModificarUsuario.TabIndex = 70
        Me.lblModificarUsuario.Text = "Modificar Servicios"
        '
        'cmbTiposModificarServicio
        '
        Me.cmbTiposModificarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTiposModificarServicio.FormattingEnabled = True
        Me.cmbTiposModificarServicio.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciones", "Informática"})
        Me.cmbTiposModificarServicio.Location = New System.Drawing.Point(99, 331)
        Me.cmbTiposModificarServicio.Name = "cmbTiposModificarServicio"
        Me.cmbTiposModificarServicio.Size = New System.Drawing.Size(347, 26)
        Me.cmbTiposModificarServicio.TabIndex = 98
        Me.cmbTiposModificarServicio.Text = "Seleccione un tipo"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(37, 330)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(42, 18)
        Me.lblTipo.TabIndex = 96
        Me.lblTipo.Text = "Tipo"
        '
        'lblCostoMensual
        '
        Me.lblCostoMensual.AutoSize = True
        Me.lblCostoMensual.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoMensual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoMensual.Location = New System.Drawing.Point(37, 277)
        Me.lblCostoMensual.Name = "lblCostoMensual"
        Me.lblCostoMensual.Size = New System.Drawing.Size(125, 18)
        Me.lblCostoMensual.TabIndex = 95
        Me.lblCostoMensual.Text = "Costo Mensual"
        '
        'txtCostoMensualModificarServicio
        '
        Me.txtCostoMensualModificarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoMensualModificarServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCostoMensualModificarServicio.Location = New System.Drawing.Point(168, 274)
        Me.txtCostoMensualModificarServicio.Multiline = True
        Me.txtCostoMensualModificarServicio.Name = "txtCostoMensualModificarServicio"
        Me.txtCostoMensualModificarServicio.Size = New System.Drawing.Size(278, 26)
        Me.txtCostoMensualModificarServicio.TabIndex = 93
        '
        'ModificarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backmodiifcarCliente
        Me.ClientSize = New System.Drawing.Size(1141, 661)
        Me.Controls.Add(Me.cmbTiposModificarServicio)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblCostoMensual)
        Me.Controls.Add(Me.txtCostoMensualModificarServicio)
        Me.Controls.Add(Me.lblTablaDatos)
        Me.Controls.Add(Me.btnListarServicios)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.DataGridCliente)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.lblNombreModificarServicio)
        Me.Controls.Add(Me.lblIdModificarServicio)
        Me.Controls.Add(Me.checkActivo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtNombreModificarServicio)
        Me.Controls.Add(Me.txtIdModificarServicio)
        Me.Controls.Add(Me.lblModificarUsuario)
        Me.Name = "ModificarServicio"
        Me.Text = "Modificar Servicios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTablaDatos As Label
    Friend WithEvents btnListarServicios As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buscar As TextBox
    Friend WithEvents DataGridCliente As DataGridView
    Friend WithEvents btnEnable As Button
    Friend WithEvents lblNombreModificarServicio As Label
    Friend WithEvents lblIdModificarServicio As Label
    Friend WithEvents checkActivo As CheckBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtNombreModificarServicio As TextBox
    Friend WithEvents txtIdModificarServicio As TextBox
    Friend WithEvents lblModificarUsuario As Label
    Friend WithEvents cmbTiposModificarServicio As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblCostoMensual As Label
    Friend WithEvents txtCostoMensualModificarServicio As TextBox
End Class
