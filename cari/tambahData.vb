Imports MySql.Data.MySqlClient

Public Class tambahData
    Private Sub tambahData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBulan.Items.Add("Januari")
        txtBulan.Items.Add("Februari")
        txtBulan.Items.Add("Maret")
        txtBulan.Items.Add("April")
        txtBulan.Items.Add("Mei")
        txtBulan.Items.Add("Juni")
        txtBulan.Items.Add("Juli")
        txtBulan.Items.Add("Agustus")
        txtBulan.Items.Add("September")
        txtBulan.Items.Add("Oktober")
        txtBulan.Items.Add("November")
        txtBulan.Items.Add("Desember")
        txtBulan.Text = "Pilih Item"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim bulan As String = txtBulan.Text
            Dim selectedbulan As String = txtJumlah.Text

            ' Validasi input
            If String.IsNullOrWhiteSpace(bulan) OrElse String.IsNullOrWhiteSpace(selectedbulan) Then
                MessageBox.Show("Harap isi semua kolom yang ada.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Call connect()

            Dim query As String = "INSERT INTO data_penjualan (bulan, penjualan) VALUES (@Bulan, @Penjualan)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Bulan", bulan)
                cmd.Parameters.AddWithValue("@Penjualan", selectedbulan)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil Ditambahkan!")
            'TampilkanSemuaData()

            ' Kosongkan semua TextBox
            txtJumlah.Text = ""
            txtBulan.Text = "Pilih Item"
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub
End Class