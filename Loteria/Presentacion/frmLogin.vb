Public Class frmLogin

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim dts As New LogUsuario
            Dim funcionValidar As New fUsuario

            dts.pLogin = UsernameTextBox.Text
            dts.pPassword = PasswordTextBox.Text

            If funcionValidar.Validar_Usuario(dts) = True Then
                frmPrincipal.Show()
                Me.Hide()
            Else
                MessageBox.Show("Atencion: El usuario y/o la contrase�a ingresados no son correctos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                UsernameTextBox.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: se ha generado un error en el inicio de sesion." &
                    Environment.NewLine & "Descripcion del error: " & Environment.NewLine +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
