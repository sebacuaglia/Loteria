<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMAgenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMCTiposDeSorteoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMCSorteosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMCApuestasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListadosYReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeSorteosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SorteosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApuestasPorSorteosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteConElTop10DeNrosPremiadosPorSorteoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradorDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGanadores = New System.Windows.Forms.Button()
        Me.btnApuestas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSorteo = New System.Windows.Forms.ComboBox()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.LightGray
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditMenu, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.CerrarSesiónToolStripMenuItem, Me.HelpMenu, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMAgenciasToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(67, 20)
        Me.EditMenu.Text = "Agencias"
        '
        'ABMAgenciasToolStripMenuItem
        '
        Me.ABMAgenciasToolStripMenuItem.Name = "ABMAgenciasToolStripMenuItem"
        Me.ABMAgenciasToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ABMAgenciasToolStripMenuItem.Text = "ABMC Agencias"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMCTiposDeSorteoToolStripMenuItem, Me.ABMCSorteosToolStripMenuItem, Me.ABMCApuestasToolStripMenuItem, Me.ToolStripSeparator3, Me.ListadosYReportesToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(118, 20)
        Me.ViewMenu.Text = "Sorteos y Apuestas"
        '
        'ABMCTiposDeSorteoToolStripMenuItem
        '
        Me.ABMCTiposDeSorteoToolStripMenuItem.Name = "ABMCTiposDeSorteoToolStripMenuItem"
        Me.ABMCTiposDeSorteoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ABMCTiposDeSorteoToolStripMenuItem.Text = "ABMC Tipos de sorteo"
        '
        'ABMCSorteosToolStripMenuItem
        '
        Me.ABMCSorteosToolStripMenuItem.Name = "ABMCSorteosToolStripMenuItem"
        Me.ABMCSorteosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ABMCSorteosToolStripMenuItem.Text = "ABMC Sorteos"
        '
        'ABMCApuestasToolStripMenuItem
        '
        Me.ABMCApuestasToolStripMenuItem.Name = "ABMCApuestasToolStripMenuItem"
        Me.ABMCApuestasToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ABMCApuestasToolStripMenuItem.Text = "ABMC Apuestas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(188, 6)
        '
        'ListadosYReportesToolStripMenuItem
        '
        Me.ListadosYReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiposDeSorteosToolStripMenuItem, Me.SorteosToolStripMenuItem, Me.ApuestasPorSorteosToolStripMenuItem, Me.ReporteConElTop10DeNrosPremiadosPorSorteoToolStripMenuItem})
        Me.ListadosYReportesToolStripMenuItem.Name = "ListadosYReportesToolStripMenuItem"
        Me.ListadosYReportesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ListadosYReportesToolStripMenuItem.Text = "Listados y Reportes"
        '
        'TiposDeSorteosToolStripMenuItem
        '
        Me.TiposDeSorteosToolStripMenuItem.Name = "TiposDeSorteosToolStripMenuItem"
        Me.TiposDeSorteosToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.TiposDeSorteosToolStripMenuItem.Text = "Tipos de Sorteos"
        '
        'SorteosToolStripMenuItem
        '
        Me.SorteosToolStripMenuItem.Name = "SorteosToolStripMenuItem"
        Me.SorteosToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.SorteosToolStripMenuItem.Text = "Sorteos"
        '
        'ApuestasPorSorteosToolStripMenuItem
        '
        Me.ApuestasPorSorteosToolStripMenuItem.Name = "ApuestasPorSorteosToolStripMenuItem"
        Me.ApuestasPorSorteosToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.ApuestasPorSorteosToolStripMenuItem.Text = "Apuestas por Sorteos"
        '
        'ReporteConElTop10DeNrosPremiadosPorSorteoToolStripMenuItem
        '
        Me.ReporteConElTop10DeNrosPremiadosPorSorteoToolStripMenuItem.Name = "ReporteConElTop10DeNrosPremiadosPorSorteoToolStripMenuItem"
        Me.ReporteConElTop10DeNrosPremiadosPorSorteoToolStripMenuItem.Size = New System.Drawing.Size(348, 22)
        Me.ReporteConElTop10DeNrosPremiadosPorSorteoToolStripMenuItem.Text = "Reporte con el top 10 de nros. premiados por Sorteo"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministradorDeUsuariosToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(72, 20)
        Me.ToolsMenu.Text = "Seguridad"
        '
        'AdministradorDeUsuariosToolStripMenuItem
        '
        Me.AdministradorDeUsuariosToolStripMenuItem.Name = "AdministradorDeUsuariosToolStripMenuItem"
        Me.AdministradorDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AdministradorDeUsuariosToolStripMenuItem.Text = "Administrador de Usuarios"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(66, 20)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(53, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(173, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGanadores)
        Me.GroupBox1.Controls.Add(Me.btnApuestas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboSorteo)
        Me.GroupBox1.Location = New System.Drawing.Point(185, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 78)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnGanadores
        '
        Me.btnGanadores.Location = New System.Drawing.Point(44, 49)
        Me.btnGanadores.Name = "btnGanadores"
        Me.btnGanadores.Size = New System.Drawing.Size(88, 23)
        Me.btnGanadores.TabIndex = 3
        Me.btnGanadores.Text = "Ver Ganadores"
        Me.btnGanadores.UseVisualStyleBackColor = True
        '
        'btnApuestas
        '
        Me.btnApuestas.Location = New System.Drawing.Point(138, 49)
        Me.btnApuestas.Name = "btnApuestas"
        Me.btnApuestas.Size = New System.Drawing.Size(95, 23)
        Me.btnApuestas.TabIndex = 2
        Me.btnApuestas.Text = "Ver Apuestas"
        Me.btnApuestas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecciones un Sorteo"
        '
        'cboSorteo
        '
        Me.cboSorteo.FormattingEnabled = True
        Me.cboSorteo.Location = New System.Drawing.Point(6, 19)
        Me.cboSorteo.Name = "cboSorteo"
        Me.cboSorteo.Size = New System.Drawing.Size(258, 21)
        Me.cboSorteo.TabIndex = 0
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Loteria.My.Resources.Resources.fondoo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmPrincipal"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMAgenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMCTiposDeSorteoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMCSorteosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMCApuestasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ListadosYReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeSorteosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SorteosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApuestasPorSorteosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteConElTop10DeNrosPremiadosPorSorteoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministradorDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSorteo As ComboBox
    Friend WithEvents btnApuestas As Button
    Friend WithEvents btnGanadores As Button
End Class
