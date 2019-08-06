Public Class rptTipoSorteo
    Private Sub rptTipoSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetLoteria.procMostrar_TipoSorteo' Puede moverla o quitarla según sea necesario.
        Me.procMostrar_TipoSorteoTableAdapter.Fill(Me.DataSetLoteria.procMostrar_TipoSorteo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class