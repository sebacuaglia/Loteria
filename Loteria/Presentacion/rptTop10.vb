Public Class Top10
    Private Sub Top10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetLoteria.Top10' Puede moverla o quitarla según sea necesario.
        Me.Top10TableAdapter.Fill(Me.DataSetLoteria.Top10)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class