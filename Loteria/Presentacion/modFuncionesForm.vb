Module modFuncionesForm
    Public Function AbmEvents_KP(ByVal Key As KeyEventArgs) As Integer

        'IMPORTATNTE = establecer la propiedad keyPreview del formulario en TRUE

        'KeyEventsArgs = proporciona datos para los evebtos KeyUp y KeyDown
        '.KeyCode = obtiene el codigo de teclado
        'Keys = especifica los codigos de tecla

        AbmEvents_KP = 0

        If Key.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf Key.KeyCode = Keys.Escape Then
            SendKeys.Send("+{TAB}")
        End If

    End Function

    Public Sub DeshabilitarTextos(ByVal frmFormulario As Form)

        For Each obObjeto As Windows.Forms.Control In frmFormulario.Controls
            If TypeOf obObjeto Is GroupBox Then
                For Each CajaTexto As Windows.Forms.Control In obObjeto.Controls
                    If TypeOf CajaTexto Is TextBox Then
                        CType(CajaTexto, TextBox).Enabled = False
                    End If
                Next
            ElseIf TypeOf obObjeto Is TextBox Then
                CType(obObjeto, TextBox).Enabled = False
            End If
        Next
    End Sub


    Public Sub LimpiarTextos(ByVal frmFormulario As Form)
        'limpia las cajas de texto del formulario
        For Each obObjeto As Windows.Forms.Control In frmFormulario.Controls
            If TypeOf obObjeto Is GroupBox Then
                For Each CajaTexto As Windows.Forms.Control In obObjeto.Controls
                    If TypeOf CajaTexto Is TextBox Then
                        CType(CajaTexto, TextBox).Text = ""
                    End If
                Next
            ElseIf TypeOf obObjeto Is TextBox Then
                CType(obObjeto, TextBox).Text = ""
            End If
        Next
    End Sub

    Public Sub DeshabilitarCombos(ByVal frmFormulario As Form)

        For Each obObjeto As Windows.Forms.Control In frmFormulario.Controls
            If TypeOf obObjeto Is GroupBox Then
                For Each Combo As Windows.Forms.Control In obObjeto.Controls
                    If TypeOf Combo Is ComboBox Then
                        CType(Combo, ComboBox).Enabled = False
                    End If
                Next
            ElseIf TypeOf obObjeto Is ComboBox Then
                CType(obObjeto, ComboBox).Enabled = False
            End If
        Next
    End Sub

    Public Sub HabilitarTextos(ByVal frmFormulario As Form)

        For Each obObjeto As Windows.Forms.Control In frmFormulario.Controls
            If TypeOf obObjeto Is GroupBox Then
                For Each CajaTexto As Windows.Forms.Control In obObjeto.Controls
                    If TypeOf CajaTexto Is TextBox Then
                        CType(CajaTexto, TextBox).Enabled = True
                    End If
                Next
            ElseIf TypeOf obObjeto Is TextBox Then
                CType(obObjeto, TextBox).Enabled = True
            End If
        Next
    End Sub

    Public Enum ModoPantalla As Byte
        ModoALTA = 0
        ModoMODIFICACION = 1
        ModoCONSULTA = 2
    End Enum

End Module
