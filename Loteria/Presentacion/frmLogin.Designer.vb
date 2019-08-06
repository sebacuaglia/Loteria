<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frmLogin
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim OK As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        OK = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK
        '
        resources.ApplyResources(OK, "OK")
        OK.BackColor = System.Drawing.Color.LightGray
        OK.Cursor = System.Windows.Forms.Cursors.WaitCursor
        OK.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        OK.FlatAppearance.BorderSize = 2
        OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        OK.ForeColor = System.Drawing.Color.Black
        OK.Name = "OK"
        OK.TabStop = False
        OK.UseVisualStyleBackColor = True
        AddHandler OK.Click, AddressOf Me.OK_Click
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.PasswordLabel, "PasswordLabel")
        Me.PasswordLabel.Name = "PasswordLabel"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.UsernameTextBox, "UsernameTextBox")
        Me.UsernameTextBox.Name = "UsernameTextBox"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.PasswordTextBox, "PasswordTextBox")
        Me.PasswordTextBox.Name = "PasswordTextBox"
        '
        'Cancel
        '
        Me.Cancel.AutoEllipsis = True
        Me.Cancel.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.Cancel, "Cancel")
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.No
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Cancel.FlatAppearance.BorderSize = 2
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Cancel.ForeColor = System.Drawing.Color.Black
        Me.Cancel.Name = "Cancel"
        Me.Cancel.TabStop = False
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoEllipsis = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.UsernameLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.UsernameLabel, "UsernameLabel")
        Me.UsernameLabel.Name = "UsernameLabel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkOliveGreen
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.Loteria.My.Resources.Resources.circulo_verd
        Me.PictureBox1.InitialImage = Global.Loteria.My.Resources.Resources.circulo_verd
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Sin nombre.png")
        Me.ImageList1.Images.SetKeyName(1, "circulo verd.png")
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'frmLogin
        '
        Me.AcceptButton = OK
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.CancelButton = Me.Cancel
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.TransparencyKey = System.Drawing.Color.DarkOliveGreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
