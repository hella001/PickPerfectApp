Public Class dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnData.Click
        Dim dataForm As New data()
        Me.Hide()
        dataForm.Show()
    End Sub

    Private Sub btnKriteria_Click(sender As Object, e As EventArgs) Handles btnKriteria.Click
        Dim kriteriaForm As New kriteria()
        Me.Hide()
        kriteriaForm.Show()
    End Sub

    Private Sub btnSeleksi_Click(sender As Object, e As EventArgs) Handles btnSeleksi.Click
        Dim hitungForm As New hitung()
        Me.Hide()
        hitungForm.Show()
    End Sub
End Class