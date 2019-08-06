Public Class rptGanadoresPorSorteo
    Private id As Integer
    Public Sub Mostrar(cboId)
        id = CInt(cboId)
    End Sub
    Private Sub rptGanadoresPorSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetLoteria.MostrarGanadores' Puede moverla o quitarla según sea necesario.
        Me.MostrarGanadoresTableAdapter.Fill(Me.DataSetLoteria.MostrarGanadores, Idsorteo:=id)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class