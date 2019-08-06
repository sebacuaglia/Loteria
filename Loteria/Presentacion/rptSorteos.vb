Public Class rptSorteos
    Private Sub rptSorteos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetLoteria.MostrarSorteos' Puede moverla o quitarla según sea necesario.
        Me.MostrarSorteosTableAdapter.Fill(Me.DataSetLoteria.MostrarSorteos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class