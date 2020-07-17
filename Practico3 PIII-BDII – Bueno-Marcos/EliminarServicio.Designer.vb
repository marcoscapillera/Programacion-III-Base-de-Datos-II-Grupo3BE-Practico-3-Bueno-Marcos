<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarServicio
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
        Me.btnListarServicios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.DataGridEliminarServicio = New System.Windows.Forms.DataGridView()
        Me.lblIdModificarServicio = New System.Windows.Forms.Label()
        Me.btnEliminarServicios = New System.Windows.Forms.Button()
        Me.txtIdEliminarServicio = New System.Windows.Forms.TextBox()
        Me.lblEliminarServicio = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridEliminarServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListarServicios
        '
        Me.btnListarServicios.BackColor = System.Drawing.Color.Transparent
        Me.btnListarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarServicios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarServicios.ForeColor = System.Drawing.Color.Crimson
        Me.btnListarServicios.Location = New System.Drawing.Point(288, 264)
        Me.btnListarServicios.Name = "btnListarServicios"
        Me.btnListarServicios.Size = New System.Drawing.Size(140, 34)
        Me.btnListarServicios.TabIndex = 99
        Me.btnListarServicios.Text = "Listar"
        Me.btnListarServicios.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.search_6_16
        Me.PictureBox1.Location = New System.Drawing.Point(543, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        '
        'buscar
        '
        Me.buscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buscar.Location = New System.Drawing.Point(577, 54)
        Me.buscar.Multiline = True
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(417, 32)
        Me.buscar.TabIndex = 97
        '
        'DataGridEliminarServicio
        '
        Me.DataGridEliminarServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridEliminarServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEliminarServicio.Location = New System.Drawing.Point(481, 159)
        Me.DataGridEliminarServicio.Name = "DataGridEliminarServicio"
        Me.DataGridEliminarServicio.Size = New System.Drawing.Size(606, 372)
        Me.DataGridEliminarServicio.TabIndex = 96
        '
        'lblIdModificarServicio
        '
        Me.lblIdModificarServicio.AutoSize = True
        Me.lblIdModificarServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblIdModificarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdModificarServicio.Location = New System.Drawing.Point(73, 185)
        Me.lblIdModificarServicio.Name = "lblIdModificarServicio"
        Me.lblIdModificarServicio.Size = New System.Drawing.Size(23, 18)
        Me.lblIdModificarServicio.TabIndex = 95
        Me.lblIdModificarServicio.Text = "Id"
        '
        'btnEliminarServicios
        '
        Me.btnEliminarServicios.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarServicios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarServicios.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEliminarServicios.Location = New System.Drawing.Point(117, 264)
        Me.btnEliminarServicios.Name = "btnEliminarServicios"
        Me.btnEliminarServicios.Size = New System.Drawing.Size(135, 34)
        Me.btnEliminarServicios.TabIndex = 94
        Me.btnEliminarServicios.Text = "Baja"
        Me.btnEliminarServicios.UseVisualStyleBackColor = False
        '
        'txtIdEliminarServicio
        '
        Me.txtIdEliminarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEliminarServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdEliminarServicio.Location = New System.Drawing.Point(117, 182)
        Me.txtIdEliminarServicio.Multiline = True
        Me.txtIdEliminarServicio.Name = "txtIdEliminarServicio"
        Me.txtIdEliminarServicio.Size = New System.Drawing.Size(311, 30)
        Me.txtIdEliminarServicio.TabIndex = 93
        '
        'lblEliminarServicio
        '
        Me.lblEliminarServicio.AutoSize = True
        Me.lblEliminarServicio.BackColor = System.Drawing.Color.Transparent
        Me.lblEliminarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEliminarServicio.Location = New System.Drawing.Point(145, 64)
        Me.lblEliminarServicio.Name = "lblEliminarServicio"
        Me.lblEliminarServicio.Size = New System.Drawing.Size(164, 22)
        Me.lblEliminarServicio.TabIndex = 92
        Me.lblEliminarServicio.Text = "Eliminar Servicio"
        '
        'EliminarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backmodiifcarCliente
        Me.ClientSize = New System.Drawing.Size(1141, 661)
        Me.Controls.Add(Me.btnListarServicios)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.DataGridEliminarServicio)
        Me.Controls.Add(Me.lblIdModificarServicio)
        Me.Controls.Add(Me.btnEliminarServicios)
        Me.Controls.Add(Me.txtIdEliminarServicio)
        Me.Controls.Add(Me.lblEliminarServicio)
        Me.Name = "EliminarServicio"
        Me.Text = "EliminarServicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridEliminarServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnListarServicios As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buscar As TextBox
    Friend WithEvents DataGridEliminarServicio As DataGridView
    Friend WithEvents lblIdModificarServicio As Label
    Friend WithEvents btnEliminarServicios As Button
    Friend WithEvents txtIdEliminarServicio As TextBox
    Friend WithEvents lblEliminarServicio As Label
End Class
