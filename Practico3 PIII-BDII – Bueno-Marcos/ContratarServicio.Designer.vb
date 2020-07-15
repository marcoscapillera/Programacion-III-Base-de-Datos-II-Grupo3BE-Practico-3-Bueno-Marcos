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
        Me.lblTipoServicio = New System.Windows.Forms.Label()
        Me.lblCostoMensual = New System.Windows.Forms.Label()
        Me.lblNombreContrado = New System.Windows.Forms.Label()
        Me.lblIdSContratado = New System.Windows.Forms.Label()
        Me.txtTipoContratarServicio = New System.Windows.Forms.TextBox()
        Me.txtCostoMensual = New System.Windows.Forms.TextBox()
        Me.txtNombreContratarSrvicio = New System.Windows.Forms.TextBox()
        Me.txtIdContratarServicio = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
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
        'lblTipoServicio
        '
        Me.lblTipoServicio.AutoSize = True
        Me.lblTipoServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoServicio.Location = New System.Drawing.Point(34, 288)
        Me.lblTipoServicio.Name = "lblTipoServicio"
        Me.lblTipoServicio.Size = New System.Drawing.Size(42, 18)
        Me.lblTipoServicio.TabIndex = 38
        Me.lblTipoServicio.Text = "Tipo"
        '
        'lblCostoMensual
        '
        Me.lblCostoMensual.AutoSize = True
        Me.lblCostoMensual.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoMensual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoMensual.Location = New System.Drawing.Point(34, 239)
        Me.lblCostoMensual.Name = "lblCostoMensual"
        Me.lblCostoMensual.Size = New System.Drawing.Size(125, 18)
        Me.lblCostoMensual.TabIndex = 37
        Me.lblCostoMensual.Text = "Costo Mensual"
        '
        'lblNombreContrado
        '
        Me.lblNombreContrado.AutoSize = True
        Me.lblNombreContrado.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreContrado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreContrado.Location = New System.Drawing.Point(34, 183)
        Me.lblNombreContrado.Name = "lblNombreContrado"
        Me.lblNombreContrado.Size = New System.Drawing.Size(71, 18)
        Me.lblNombreContrado.TabIndex = 36
        Me.lblNombreContrado.Text = "Nombre"
        '
        'lblIdSContratado
        '
        Me.lblIdSContratado.AutoSize = True
        Me.lblIdSContratado.BackColor = System.Drawing.Color.Transparent
        Me.lblIdSContratado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdSContratado.Location = New System.Drawing.Point(34, 129)
        Me.lblIdSContratado.Name = "lblIdSContratado"
        Me.lblIdSContratado.Size = New System.Drawing.Size(23, 18)
        Me.lblIdSContratado.TabIndex = 35
        Me.lblIdSContratado.Text = "Id"
        '
        'txtTipoContratarServicio
        '
        Me.txtTipoContratarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoContratarServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTipoContratarServicio.Location = New System.Drawing.Point(96, 285)
        Me.txtTipoContratarServicio.Multiline = True
        Me.txtTipoContratarServicio.Name = "txtTipoContratarServicio"
        Me.txtTipoContratarServicio.Size = New System.Drawing.Size(347, 30)
        Me.txtTipoContratarServicio.TabIndex = 33
        '
        'txtCostoMensual
        '
        Me.txtCostoMensual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoMensual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCostoMensual.Location = New System.Drawing.Point(165, 236)
        Me.txtCostoMensual.Multiline = True
        Me.txtCostoMensual.Name = "txtCostoMensual"
        Me.txtCostoMensual.Size = New System.Drawing.Size(278, 30)
        Me.txtCostoMensual.TabIndex = 32
        '
        'txtNombreContratarSrvicio
        '
        Me.txtNombreContratarSrvicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreContratarSrvicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreContratarSrvicio.Location = New System.Drawing.Point(165, 180)
        Me.txtNombreContratarSrvicio.Multiline = True
        Me.txtNombreContratarSrvicio.Name = "txtNombreContratarSrvicio"
        Me.txtNombreContratarSrvicio.Size = New System.Drawing.Size(278, 30)
        Me.txtNombreContratarSrvicio.TabIndex = 31
        '
        'txtIdContratarServicio
        '
        Me.txtIdContratarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdContratarServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdContratarServicio.Location = New System.Drawing.Point(165, 129)
        Me.txtIdContratarServicio.Multiline = True
        Me.txtIdContratarServicio.Name = "txtIdContratarServicio"
        Me.txtIdContratarServicio.Size = New System.Drawing.Size(278, 30)
        Me.txtIdContratarServicio.TabIndex = 30
        '
        'Guardar
        '
        Me.Guardar.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backButton
        Me.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.ForeColor = System.Drawing.Color.White
        Me.Guardar.Location = New System.Drawing.Point(354, 398)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(89, 34)
        Me.Guardar.TabIndex = 40
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'ContratarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backAgregar
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.lblTipoServicio)
        Me.Controls.Add(Me.lblCostoMensual)
        Me.Controls.Add(Me.lblNombreContrado)
        Me.Controls.Add(Me.lblIdSContratado)
        Me.Controls.Add(Me.txtTipoContratarServicio)
        Me.Controls.Add(Me.txtCostoMensual)
        Me.Controls.Add(Me.txtNombreContratarSrvicio)
        Me.Controls.Add(Me.txtIdContratarServicio)
        Me.Controls.Add(Me.lblAgregarUsuario)
        Me.Name = "ContratarServicio"
        Me.Text = "ContratarServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarUsuario As Label
    Friend WithEvents lblTipoServicio As Label
    Friend WithEvents lblCostoMensual As Label
    Friend WithEvents lblNombreContrado As Label
    Friend WithEvents lblIdSContratado As Label
    Friend WithEvents txtTipoContratarServicio As TextBox
    Friend WithEvents txtCostoMensual As TextBox
    Friend WithEvents txtNombreContratarSrvicio As TextBox
    Friend WithEvents txtIdContratarServicio As TextBox
    Friend WithEvents Guardar As Button
End Class
