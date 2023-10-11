Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class hitung
    'Dim connStr As String = "server=nama_server;user=username;password=password;database=nama_database;"
    'Dim conn As New MySqlConnection(connStr)
    Dim forecastValues As New List(Of Double)()
    Dim maeValues As New List(Of Double)()
    Dim mseValues As New List(Of Double)()
    Dim mapeValues As New List(Of Double)()

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Try
            ' Ambil nilai 'a' dari input pengguna pada TextBox txtPhi
            Dim a As Double
            If Double.TryParse(txtPhi.Text, a) Then
                ' Input 'a' valid, lanjutkan perhitungan

                ' Cek data dalam database
                Dim dataPenjualanCount As Integer = 0
                Call connect()
                Dim queryDataPenjualanCount As String = "SELECT COUNT(*) FROM data_penjualan"
                Using cmdDataPenjualanCount As New MySqlCommand(queryDataPenjualanCount, conn)
                    dataPenjualanCount = Convert.ToInt32(cmdDataPenjualanCount.ExecuteScalar())
                End Using

                If dataPenjualanCount > 0 Then
                    ' Data penjualan ada, lanjutkan perhitungan

                    ' Ambil data penjualan dari database
                    Dim dataPenjualan As New List(Of Double)()
                    Call connect()
                    Dim query As String = "SELECT penjualan FROM data_penjualan"
                    Using cmd As New MySqlCommand(query, conn)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                dataPenjualan.Add(Double.Parse(reader("penjualan").ToString()))
                            End While
                        End Using
                    End Using

                    Dim forecast As New List(Of Double)()
                    Dim actual As New List(Of Double)()

                    Dim totalAbsoluteError As Double = 0.0
                    Dim totalSquaredError As Double = 0.0

                    ' Inisialisasi kolom-kolom DataGridView
                    DataGridView1.Columns.Clear()
                    DataGridView1.Columns.Add("Bulan", "Bulan")
                    DataGridView1.Columns.Add("Penjualan", "Penjualan")
                    DataGridView1.Columns.Add("Nilai a", "Nilai a")
                    DataGridView1.Columns.Add("Forecast", "Forecast")
                    DataGridView1.Columns.Add("MAE", "MAE")
                    DataGridView1.Columns.Add("MSE", "MSE")
                    DataGridView1.Columns.Add("MAPE", "MAPE")

                    Dim monthNames As String() = New DateTimeFormatInfo().MonthNames ' Nama-nama bulan
                    Dim maeValues As New List(Of Double)()
                    Dim mseValues As New List(Of Double)()
                    Dim mapeValues As New List(Of Double)()

                    For i As Integer = 0 To dataPenjualan.Count - 1
                        If i = 0 Then
                            forecast.Add(dataPenjualan(i))
                        Else
                            Dim forecastValue As Double = a * dataPenjualan(i - 1) + (1 - a) * forecast(i - 1)
                            forecast.Add(forecastValue)
                        End If

                        ' Menghitung MAE
                        Dim absoluteError As Double = Math.Abs(forecast(i) - dataPenjualan(i))
                        totalAbsoluteError += absoluteError
                        maeValues.Add(absoluteError)

                        ' Menghitung MSE
                        Dim squaredError As Double = Math.Pow(forecast(i) - dataPenjualan(i), 2)
                        totalSquaredError += squaredError
                        mseValues.Add(squaredError)

                        actual.Add(dataPenjualan(i))
                    Next

                    Dim mae As Double = totalAbsoluteError / dataPenjualan.Count
                    Dim mse As Double = totalSquaredError / dataPenjualan.Count

                    Dim mape As Double = 0.0
                    For i As Integer = 0 To dataPenjualan.Count - 1
                        mapeValues.Add((Math.Abs(actual(i) - forecast(i)) / actual(i)) * 100)
                        mape += mapeValues(i)
                    Next
                    mape /= dataPenjualan.Count

                    ' Mengisi DataGridView dengan hasil perhitungan
                    DataGridView1.Rows.Clear()
                    For i As Integer = 0 To dataPenjualan.Count - 1
                        Dim monthName As String = monthNames(i) ' Mengambil nama bulan berdasarkan indeks
                        DataGridView1.Rows.Add(monthName, dataPenjualan(i), a, forecast(i), maeValues(i), mseValues(i), mapeValues(i))
                        'DataGridView1.Refresh()
                    Next

                    MessageBox.Show("Perhitungan selesai.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Anda belum mengisi data penjualan. Harap tambahkan data penjualan sebelum melakukan perhitungan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Nilai 'a' yang dimasukkan tidak valid. Harap masukkan nilai yang benar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            ' Ambil nilai 'a' dari input pengguna pada TextBox txtPhi
            Dim a As Double
            If Double.TryParse(txtPhi.Text, a) Then
                ' Input 'a' valid, lanjutkan perhitungan

                ' Check tabel 'hasil'
                Call connect()
                Dim queryCheckHasil As String = "SELECT COUNT(*) FROM hasil"
                Using cmdCheckHasil As New MySqlCommand(queryCheckHasil, conn)
                    Dim hasilRowCount As Integer = Convert.ToInt32(cmdCheckHasil.ExecuteScalar())

                    ' Check tabel 'rata_rata'
                    Dim queryCheckRataRata As String = "SELECT COUNT(*) FROM rata_rata"
                    Using cmdCheckRataRata As New MySqlCommand(queryCheckRataRata, conn)
                        Dim rataRataRowCount As Integer = Convert.ToInt32(cmdCheckRataRata.ExecuteScalar())

                        ' Cek apakah kedua tabel sudah berisi data
                        If hasilRowCount > 0 Or rataRataRowCount > 0 Then
                            MessageBox.Show("Terdapat data yang telah disimpan sebelumnya. Hapus data sebelum menambahkan yang baru.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ' Ambil data penjualan dari database
                            Dim dataPenjualan As New List(Of Double)()
                            Call connect()
                            Dim query As String = "SELECT penjualan FROM data_penjualan"
                            Using cmd As New MySqlCommand(query, conn)
                                Using reader As MySqlDataReader = cmd.ExecuteReader()
                                    While reader.Read()
                                        dataPenjualan.Add(Double.Parse(reader("penjualan").ToString()))
                                    End While
                                End Using
                            End Using

                            Dim forecast As New List(Of Double)()
                            Dim actual As New List(Of Double)()

                            Dim totalAbsoluteError As Double = 0.0
                            Dim totalSquaredError As Double = 0.0

                            For i As Integer = 0 To dataPenjualan.Count - 1
                                If i = 0 Then
                                    forecast.Add(dataPenjualan(i))
                                Else
                                    Dim forecastValue As Double = a * dataPenjualan(i - 1) + (1 - a) * forecast(i - 1)
                                    forecast.Add(forecastValue)
                                End If

                                ' Menghitung MAE
                                Dim absoluteError As Double = Math.Abs(forecast(i) - dataPenjualan(i))
                                totalAbsoluteError += absoluteError

                                ' Menghitung MSE
                                Dim squaredError As Double = Math.Pow(forecast(i) - dataPenjualan(i), 2)
                                totalSquaredError += squaredError

                                actual.Add(dataPenjualan(i))
                            Next

                            ' Simpan hasil perhitungan asli ke database hasil
                            Call connect()
                            Dim queryInsert As String = "INSERT INTO hasil (bulan, penjualan, phi, forecast, mae, mse, mape) VALUES (@bulan, @penjualan, @phi, @forecast, @mae, @mse, @mape)"
                            Using cmdInsert As New MySqlCommand(queryInsert, conn)
                                'conn.Open()
                                cmdInsert.Parameters.Clear()
                                For i As Integer = 0 To dataPenjualan.Count - 1
                                    Dim monthName As String = New System.Globalization.CultureInfo("id-ID").DateTimeFormat.GetMonthName(i + 1)
                                    cmdInsert.Parameters.AddWithValue("@bulan", monthName)
                                    cmdInsert.Parameters.AddWithValue("@penjualan", dataPenjualan(i))
                                    cmdInsert.Parameters.AddWithValue("@phi", a)
                                    cmdInsert.Parameters.AddWithValue("@forecast", Math.Round(forecast(i))) ' Bulatkan forecast
                                    cmdInsert.Parameters.AddWithValue("@mae", Math.Round(Math.Abs(forecast(i) - dataPenjualan(i)))) ' Bulatkan MAE
                                    cmdInsert.Parameters.AddWithValue("@mse", Math.Round(Math.Pow(forecast(i) - dataPenjualan(i), 2))) ' Bulatkan MSE
                                    cmdInsert.Parameters.AddWithValue("@mape", Math.Round((Math.Abs(forecast(i) - dataPenjualan(i)) / dataPenjualan(i)) * 100)) ' Bulatkan MAPE
                                    cmdInsert.ExecuteNonQuery()
                                    cmdInsert.Parameters.Clear() ' Bersihkan parameter
                                Next
                            End Using

                            ' Menghitung rata-rata MAE, MSE, dan MAPE
                            Dim mae As Double = Math.Round(totalAbsoluteError / dataPenjualan.Count) ' Bulatkan MAE
                            Dim mse As Double = Math.Round(totalSquaredError / dataPenjualan.Count) ' Bulatkan MSE
                            Dim mape As Double = 0.0
                            For i As Integer = 0 To dataPenjualan.Count - 1
                                mape += Math.Round((Math.Abs(actual(i) - forecast(i)) / actual(i)) * 100) ' Bulatkan MAPE
                            Next
                            mape = Math.Round(mape / dataPenjualan.Count) ' Bulatkan MAPE

                            ' Simpan rata-rata ke database rata_rata
                            Call connect()
                            Dim queryRataRata As String = "INSERT INTO rata_rata (mae, mse, mape) VALUES (@mae, @mse, @mape)"
                            Using cmdRataRata As New MySqlCommand(queryRataRata, conn)
                                cmdRataRata.Parameters.AddWithValue("@mae", mae)
                                cmdRataRata.Parameters.AddWithValue("@mse", mse)
                                cmdRataRata.Parameters.AddWithValue("@mape", mape)
                                cmdRataRata.ExecuteNonQuery()
                            End Using

                            MessageBox.Show("Data hasil perhitungan telah disimpan ke database.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Nilai 'a' yang dimasukkan tidak valid. Harap masukkan nilai yang benar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try



    End Sub

    Private Sub hitung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("Bulan", "Bulan")
        DataGridView1.Columns.Add("Penjualan", "Penjualan")
        DataGridView1.Columns.Add("Nilai a", "Nilai a")
        DataGridView1.Columns.Add("Forecast", "Forecast")
        DataGridView1.Columns.Add("MAE", "MAE")
        DataGridView1.Columns.Add("MSE", "MSE")
        DataGridView1.Columns.Add("MAPE", "MAPE")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataForm As New data()
        Me.Hide()
        dataForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kriteriaForm As New kriteria()
        Me.Hide()
        kriteriaForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hitungForm As New hitung()
        Me.Hide()
        hitungForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim keluarForm As New login()
        Me.Hide()
        keluarForm.Show()
    End Sub

    'Private Sub hitung_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    Application.Exit()
    'End Sub
End Class
