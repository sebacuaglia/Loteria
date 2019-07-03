<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvinciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.CerrarSesiónToolStripMenuItem, Me.HelpMenu, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ProvinciasToolStripMenuItem, Me.LocalidadesToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(60, 20)
        Me.FileMenu.Text = "&Archivo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem1.Text = "Paises"
        '
        'ProvinciasToolStripMenuItem
        '
        Me.ProvinciasToolStripMenuItem.Name = "ProvinciasToolStripMenuItem"
        Me.ProvinciasToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ProvinciasToolStripMenuItem.Text = "Provincias"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.LocalidadesToolStripMenuItem.Text = "Localidades"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(133, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
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
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(66, 20)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.NewWindowToolStripMenuItem.Text = "&Nueva ventana"
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
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
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
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmPrincipal"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProvinciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As ToolStripMenuItem
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
End Class
