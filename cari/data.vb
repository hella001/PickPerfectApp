Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.DataVisualization.Charting

Public Class data
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataForm As New data()
        Me.Hide()
        dataForm.Show()
    End Sub


    Private Sub TampilkanSemuaData()
        'Dim conn As MySqlConnection = connect()
        Call connect()

        'Dim query As String = "SELECT id AS 'Id Penerima', nama_siswa AS 'Nama Siswa', rata_rata AS 'Nilai Rata-Rata', tingkah_laku AS 'Nilai Tingkah Laku', ekstrakurikuler AS 'Nilai Ekstrakurikuler', pendapatan_ortu AS 'Pendapatan Orang Tua', tanggungan_ortu AS 'Tanggungan Orang Tua' FROM calon_penerima" 
        Dim query As String = "SELECT bulan AS 'Bulan', penjualan AS 'Total Penjualan', phi AS 'Nilai a', forecast AS 'Forecast', mae AS 'MAE', mse AS 'MSE', mape AS 'MAPE' FROM hasil"

        Dim dt As New DataTable()

        Dim adapter As New MySqlDataAdapter(query, conn)

        adapter.Fill(dt)

        DataGridView1.DataSource = dt
        ' Atur teks di tengah untuk kolom DataGridView tertentu
        DataGridView1.Columns("Bulan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("Total Penjualan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("Nilai a").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("Forecast").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("MAE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("MSE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("MAPE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()

        ' Tambahkan area chart
        Dim chartArea As New ChartArea()
        chartArea.Name = "ChartArea1"
        Chart1.ChartAreas.Add(chartArea)

        ' Tambahkan seri untuk Total Penjualan
        Dim seriesTotalPenjualan As New Series()
        seriesTotalPenjualan.Name = "Total Penjualan"
        seriesTotalPenjualan.ChartType = SeriesChartType.Line   'Menggunakan grafik garis
        'seriesTotalPenjualan.ChartType = SeriesChartType.Column ' Menggunakan grafik batang
        seriesTotalPenjualan.BorderWidth = 2
        Chart1.Series.Add(seriesTotalPenjualan)

        ' Tambahkan seri untuk Forecast
        Dim seriesForecast As New Series()
        seriesForecast.Name = "Forecast"
        seriesForecast.ChartType = SeriesChartType.Line  'Menggunakan grafik garis
        'seriesForecast.ChartType = SeriesChartType.Column ' Menggunakan grafik batang
        seriesForecast.BorderWidth = 2
        Chart1.Series.Add(seriesForecast)

        ' Isi data dari DataGridView ke Chart
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim bulan As String = row.Cells("Bulan").Value.ToString()
                Dim totalPenjualan As Double = Convert.ToDouble(row.Cells("Total Penjualan").Value)
                Dim forecast As Double = Convert.ToDouble(row.Cells("Forecast").Value)

                ' Tambahkan data ke seri yang sesuai
                Chart1.Series("Total Penjualan").Points.AddXY(bulan, totalPenjualan)
                Chart1.Series("Forecast").Points.AddXY(bulan, forecast)
            End If
        Next

        'Mengatur font bulan
        Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.Font = New Font("Arial", 10)

        '' Tambahkan seri untuk MAE
        'Dim seriesmae As New Series()
        'seriesmae.Name = "mae"
        'seriesmae.ChartType = SeriesChartType.Line
        'seriesmae.BorderWidth = 2
        'Chart1.Series.Add(seriesmae)

        '' Tambahkan seri untuk MSE
        'Dim seriesMSE As New Series()
        'seriesMSE.Name = "MSE"
        'seriesMSE.ChartType = SeriesChartType.Line
        'seriesMSE.BorderWidth = 2
        'Chart1.Series.Add(seriesMSE)

        '' Tambahkan seri untuk MAPE
        'Dim seriesMAPE As New Series()
        'seriesMAPE.Name = "MAPE"
        'seriesMAPE.ChartType = SeriesChartType.Line
        'seriesMAPE.BorderWidth = 2
        'Chart1.Series.Add(seriesMAPE)

        '' Isi data dari DataGridView ke chart
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    If Not row.IsNewRow Then
        '        Dim bulan As String = row.Cells("Bulan").Value.ToString()
        '        Dim mae As Double = Convert.ToDouble(row.Cells("MAE").Value)
        '        Dim mse As Double = Convert.ToDouble(row.Cells("MSE").Value)
        '        Dim mape As Double = Convert.ToDouble(row.Cells("MAPE").Value)

        '        ' Tambahkan data ke seri yang sesuai
        '        Chart1.Series("MAE").Points.AddXY(bulan, mae)
        '        Chart1.Series("MSE").Points.AddXY(bulan, mse)
        '        Chart1.Series("MAPE").Points.AddXY(bulan, mape)
        '    End If
        'Next
    End Sub

    Private Sub data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanSemuaData()
        TampilkanDataRataRata()

        Timer1.Interval = 15000 ' pembaruan data setiap 15 detik
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TampilkanSemuaData()
    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus semua data?", "Konfirmasi Hapus Semua", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Call connect()
            ' Hapus semua data dari database hasil
            Dim queryDeleteHasil As String = "DELETE FROM hasil"

            Using cmdDeleteHasil As New MySqlCommand(queryDeleteHasil, conn)
                ' Buka koneksi database
                'conn.Open()
                cmdDeleteHasil.ExecuteNonQuery()
                ' Tutup koneksi database
                conn.Close()
            End Using

            ' Hapus semua data dari database rata_rata
            Call connect()
            Dim queryDeleteRataRata As String = "DELETE FROM rata_rata"

            Using cmdDeleteRataRata As New MySqlCommand(queryDeleteRataRata, conn)
                ' Buka koneksi database
                'conn.Open()
                cmdDeleteRataRata.ExecuteNonQuery()
                ' Tutup koneksi database
                conn.Close()
            End Using

            ' Mengatur teks label menjadi "0"
            txtMae.Text = "0 %"
            txtMse.Text = "0 %"
            txtMape.Text = "0 %"

            MessageBox.Show("Seluruh data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TampilkanDataRataRata()
            TampilkanSemuaData() ' Memuat ulang data setelah penghapusan
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kriteriaForm As New kriteria()
        Me.Hide()
        kriteriaForm.Show()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs)
        Dim tambahForm As New tambahData()
        'Me.Hide()
        tambahForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hitungForm As New hitung()
        Me.Hide()
        hitungForm.Show()
    End Sub

    Private Sub TampilkanDataRataRata()
        ' Kode koneksi ke database rata_rata
        Call connect()
        Dim query As String = "SELECT mae, mse, mape FROM rata_rata"
        Using cmd As New MySqlCommand(query, conn)
            ' Buka koneksi ke database
            'conn.Open()

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' Isi label-label dengan data dari database rata_rata
                    txtMae.Text = reader("mae").ToString() & " %"
                    txtMse.Text = reader("mse").ToString() & " %"
                    txtMape.Text = reader("mape").ToString() & "%"
                End If
            End Using

            ' Tutup koneksi ke database
            conn.Close()
        End Using
    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Dim cetakForm As New cetak()
    '    'Me.Hide()
    '    cetakForm.ShowDialog()
    'End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim keluarForm As New login()
        Me.Hide()
        keluarForm.Show()
    End Sub

    'Private Sub data_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    Application.Exit()
    'End Sub
End Class