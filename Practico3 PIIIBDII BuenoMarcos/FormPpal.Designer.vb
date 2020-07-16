<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestor
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tabConListados = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.listadoClientes = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.listadoServicios = New System.Windows.Forms.DataGridView()
        Me.ListadoContratados = New System.Windows.Forms.TabPage()
        Me.DataGridContrata = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConListados.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.listadoClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.listadoServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListadoContratados.SuspendLayout()
        CType(Me.DataGridContrata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.PersonasToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.ContratarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1141, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.LoginToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'IniciarToolStripMenuItem
        '
        Me.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem"
        Me.IniciarToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.IniciarToolStripMenuItem.Text = "Iniciar"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem, Me.EliminarClienteToolStripMenuItem})
        Me.PersonasToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PersonasToolStripMenuItem.Text = "Clientes"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.NuevoClienteToolStripMenuItem.Text = "Nuevo Cliente"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar Cliente"
        '
        'EliminarClienteToolStripMenuItem
        '
        Me.EliminarClienteToolStripMenuItem.Name = "EliminarClienteToolStripMenuItem"
        Me.EliminarClienteToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.EliminarClienteToolStripMenuItem.Text = "Baja Cliente"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratarToolStripMenuItem1, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ServiciosToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'ContratarToolStripMenuItem1
        '
        Me.ContratarToolStripMenuItem1.Name = "ContratarToolStripMenuItem1"
        Me.ContratarToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.ContratarToolStripMenuItem1.Text = "Nuevo Servicio"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar Servicio"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarToolStripMenuItem.Text = "Baja Servicio"
        '
        'ContratarToolStripMenuItem
        '
        Me.ContratarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem1})
        Me.ContratarToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContratarToolStripMenuItem.Name = "ContratarToolStripMenuItem"
        Me.ContratarToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ContratarToolStripMenuItem.Text = "Contratar"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(139, 110)
        Me.buscar.Multiline = True
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(881, 32)
        Me.buscar.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.search_12_16
        Me.PictureBox1.Location = New System.Drawing.Point(105, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'tabConListados
        '
        Me.tabConListados.Controls.Add(Me.TabPage1)
        Me.tabConListados.Controls.Add(Me.TabPage2)
        Me.tabConListados.Controls.Add(Me.ListadoContratados)
        Me.tabConListados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabConListados.Location = New System.Drawing.Point(129, 222)
        Me.tabConListados.Name = "tabConListados"
        Me.tabConListados.SelectedIndex = 0
        Me.tabConListados.Size = New System.Drawing.Size(901, 351)
        Me.tabConListados.TabIndex = 34
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.listadoClientes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(893, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Clientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'listadoClientes
        '
        Me.listadoClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listadoClientes.Location = New System.Drawing.Point(6, 6)
        Me.listadoClientes.Name = "listadoClientes"
        Me.listadoClientes.Size = New System.Drawing.Size(881, 311)
        Me.listadoClientes.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.listadoServicios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(893, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listado de Servicios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'listadoServicios
        '
        Me.listadoServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.listadoServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listadoServicios.Location = New System.Drawing.Point(6, 3)
        Me.listadoServicios.Name = "listadoServicios"
        Me.listadoServicios.Size = New System.Drawing.Size(881, 317)
        Me.listadoServicios.TabIndex = 0
        '
        'ListadoContratados
        '
        Me.ListadoContratados.Controls.Add(Me.DataGridContrata)
        Me.ListadoContratados.Location = New System.Drawing.Point(4, 24)
        Me.ListadoContratados.Name = "ListadoContratados"
        Me.ListadoContratados.Padding = New System.Windows.Forms.Padding(3)
        Me.ListadoContratados.Size = New System.Drawing.Size(893, 323)
        Me.ListadoContratados.TabIndex = 2
        Me.ListadoContratados.Text = "Listado Servicios Contratados"
        Me.ListadoContratados.UseVisualStyleBackColor = True
        '
        'DataGridContrata
        '
        Me.DataGridContrata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridContrata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridContrata.Location = New System.Drawing.Point(6, 6)
        Me.DataGridContrata.Name = "DataGridContrata"
        Me.DataGridContrata.Size = New System.Drawing.Size(881, 311)
        Me.DataGridContrata.TabIndex = 0
        '
        'btnActualizar
        '
        Me.btnActualizar.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backButton
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(506, 590)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(155, 34)
        Me.btnActualizar.TabIndex = 35
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Gestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practico3_PIII_BDII___Bueno_Marcos.My.Resources.Resources.backgroundFormPpal
        Me.ClientSize = New System.Drawing.Size(1141, 661)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.tabConListados)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Gestor"
        Me.Text = "Gestor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConListados.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.listadoClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.listadoServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListadoContratados.ResumeLayout(False)
        CType(Me.DataGridContrata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents buscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ModificarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tabConListados As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents listadoClientes As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents listadoServicios As DataGridView
    Friend WithEvents ListadoContratados As TabPage
    Friend WithEvents DataGridContrata As DataGridView
End Class
