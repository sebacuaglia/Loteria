Public Class rptApuestasPorSorteo
    Private id As Integer
    Public Sub Mostrar(cboId)
        id = CInt(cboId)
    End Sub
    Private Sub rptApuestasPorSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetLoteria.ApuestasPorSorteo' Puede moverla o quitarla según sea necesario.
        Me.ApuestasPorSorteoTableAdapter.Fill(Me.DataSetLoteria.ApuestasPorSorteo, idSorteo:=id)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class