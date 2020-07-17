<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarCliente
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
        Me.btnListarClientes = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.DataGridEliminarCliente = New System.Windows.Forms.DataGridView()
        Me.lblIdModificarCliente = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtIdEliminarCliente = New System.Windows.Forms.TextBox()
        Me.lblEliminarCliente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridEliminarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnListarClientes
        '
        Me.btnListarClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnListarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarClientes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarClientes.ForeColor = System.Drawing.Color.Crimson
        Me.btnListarClientes.Location = New System.Drawing.Point(306, 259)
        Me.btnListarClientes.Name = "btnListarClientes"
        Me.btnListarClientes.Size = New System.Drawing.Size(140, 34)
        Me.btnListarClientes.TabIndex = 91
        Me.btnListarClientes.Text = "Listar"
        Me.btnListarClientes.UseVisualStyleBackColor = False
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
        'DataGridEliminarCliente
        '
        Me.DataGridEliminarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridEliminarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEliminarCliente.Location = New System.Drawing.Point(499, 154)
        Me.DataGridEliminarCliente.Name = "DataGridEliminarCliente"
        Me.DataGridEliminarCliente.Size = New System.Drawing.Size(606, 372)
        Me.DataGridEliminarCliente.TabIndex = 88
        '
        'lblIdModificarCliente
        '
        Me.lblIdModificarCliente.AutoSize = True
        Me.lblIdModificarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblIdModificarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdModificarCliente.Location = New System.Drawing.Point(91, 180)
        Me.lblIdModificarCliente.Name = "lblIdModificarCliente"
        Me.lblIdModificarCliente.Size = New System.Drawing.Size(23, 18)
        Me.lblIdModificarCliente.TabIndex = 79
        Me.lblIdModificarCliente.Text = "Id"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEliminar.Location = New System.Drawing.Point(135, 259)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(135, 34)
        Me.btnEliminar.TabIndex = 75
        Me.btnEliminar.Text = "Baja"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'txtIdEliminarCliente
        '
        Me.txtIdEliminarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdEliminarCliente.Location = New System.Drawing.Point(135, 177)
        Me.txtIdEliminarCliente.Multiline = True
        Me.txtIdEliminarCliente.Name = "txtIdEliminarCliente"
        Me.txtIdEliminarCliente.Size = New System.Drawing.Size(311, 30)
        Me.txtIdEliminarCliente.TabIndex = 71
        '
        'lblEliminarCliente
        '
        Me.lblEliminarCliente.AutoSize = True
        Me.lblEliminarCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblEliminarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEliminarCliente.Location = New System.Drawing.Point(163, 59)
        Me.lblEliminarCliente.Name = "lblEliminarCliente"
        Me.lblEliminarCliente.Size = New System.Drawing.Size(154, 22)
        Me.lblEliminarCliente.TabIndex = 70
        Me.lblEliminarCliente.Text = "Eliminar Cliente"
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
        'EliminarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backmodiifcarCliente
        Me.ClientSize = New System.Drawing.Size(1141, 661)
        Me.Controls.Add(Me.lblTablaDatos)
        Me.Controls.Add(Me.btnListarClientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.DataGridEliminarCliente)
        Me.Controls.Add(Me.lblIdModificarCliente)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtIdEliminarCliente)
        Me.Controls.Add(Me.lblEliminarCliente)
        Me.Name = "EliminarCliente"
        Me.Text = "EliminarCliente"
        CType(Me.DataGridEliminarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTablaDatos As Label
    Friend WithEvents btnListarClientes As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buscar As TextBox
    Friend WithEvents DataGridEliminarCliente As DataGridView
    Friend WithEvents lblIdModificarCliente As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtIdEliminarCliente As TextBox
    Friend WithEvents lblEliminarCliente As Label
End Class
