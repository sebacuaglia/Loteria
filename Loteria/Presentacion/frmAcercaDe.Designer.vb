<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercaDe
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
        Me.GroupBoxProfesor = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxAlumnos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBoxCatedra = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBoxProfesor.SuspendLayout()
        Me.GroupBoxAlumnos.SuspendLayout()
        Me.GroupBoxCatedra.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxProfesor
        '
        Me.GroupBoxProfesor.Controls.Add(Me.Label1)
        Me.GroupBoxProfesor.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxProfesor.Name = "GroupBoxProfesor"
        Me.GroupBoxProfesor.Size = New System.Drawing.Size(270, 49)
        Me.GroupBoxProfesor.TabIndex = 0
        Me.GroupBoxProfesor.TabStop = False
        Me.GroupBoxProfesor.Text = "Profesor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ing Villafañe Christián"
        '
        'GroupBoxAlumnos
        '
        Me.GroupBoxAlumnos.Controls.Add(Me.Label2)
        Me.GroupBoxAlumnos.Location = New System.Drawing.Point(12, 67)
        Me.GroupBoxAlumnos.Name = "GroupBoxAlumnos"
        Me.GroupBoxAlumnos.Size = New System.Drawing.Size(270, 67)
        Me.GroupBoxAlumnos.TabIndex = 1
        Me.GroupBoxAlumnos.TabStop = False
        Me.GroupBoxAlumnos.Text = "Alumnos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Basualdo Agostina" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12415 - Cuaglia Sebastian Ariel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Drapata Agostina"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(107, 204)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBoxCatedra
        '
        Me.GroupBoxCatedra.Controls.Add(Me.Label5)
        Me.GroupBoxCatedra.Location = New System.Drawing.Point(12, 140)
        Me.GroupBoxCatedra.Name = "GroupBoxCatedra"
        Me.GroupBoxCatedra.Size = New System.Drawing.Size(270, 58)
        Me.GroupBoxCatedra.TabIndex = 4
        Me.GroupBoxCatedra.TabStop = False
        Me.GroupBoxCatedra.Text = "Catedra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Taller de Programación I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Facultad Regional Villa María"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 238)
        Me.Controls.Add(Me.GroupBoxCatedra)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBoxAlumnos)
        Me.Controls.Add(Me.GroupBoxProfesor)
        Me.MaximizeBox = False
        Me.Name = "frmAcercaDe"
        Me.Text = "Acerca de..."
        Me.GroupBoxProfesor.ResumeLayout(False)
        Me.GroupBoxProfesor.PerformLayout()
        Me.GroupBoxAlumnos.ResumeLayout(False)
        Me.GroupBoxAlumnos.PerformLayout()
        Me.GroupBoxCatedra.ResumeLayout(False)
        Me.GroupBoxCatedra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxProfesor As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxAlumnos As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents GroupBoxCatedra As GroupBox
    Friend WithEvents Label5 As Label
End Class
