Public Class frmMostrarResultados
    Private dt As New DataTable
    Private ds As New DataTable

    Public Sub inicio(ByVal id As Integer)
        Mostrar_Datos(id)
    End Sub

    Private Sub Mostrar_Datos(ByVal ID As Integer)
        Try
            Dim FuncionMostrar As New fSortear
            Dim dts As New logSortear

            dts.pIDSorteo = ID

            'dt = FuncionMostrar.Mostrar_Premios(dts)
            dt = FuncionMostrar.Mostrar_Resultados(dts)

            If dt.Rows.Count <> 0 Then
                dataResultado.DataSource = dt
            Else
                dataResultado.DataSource = Nothing
            End If
            'aca se calcula el monto de los ganadores
            ds = FuncionMostrar.Mostrar_Ganadores(dts)

            If ds.Rows.Count <> 0 Then
                dataGanadores.DataSource = ds
            Else
                dataGanadores.DataSource = Nothing
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class