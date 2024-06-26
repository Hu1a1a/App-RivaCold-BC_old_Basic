Public Class MainForm
    Private Sub ConsultaEquivalenciaModelo(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        FormFunc1.ShowDialog()
    End Sub
    Private Sub ConsultaFichaTecnica(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        FormFT.ShowDialog()
    End Sub
    Private Sub ConsultaEquivalenciaEvaporador(sender As Object, e As EventArgs)
        Me.Dispose()
        FormFunc2.ShowDialog()
    End Sub
    Private Sub ConsultaEquivalenciaCondensador(sender As Object, e As EventArgs)
        Me.Dispose()
        FormFunc3.ShowDialog()
    End Sub
End Class
