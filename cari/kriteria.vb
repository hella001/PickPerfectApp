Imports MySql.Data.MySqlClient

Public Class kriteria
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formKriteria As New kriteria()
        Me.Hide()
        formKriteria.Show()
    End Sub

    Private Sub TampilkanSemuaData()
        'Dim conn As MySqlConnection = connect()
        Call connect()

        Dim query As String = "SELECT bulan AS 'Bulan', penjualan AS 'Penjualan' FROM data_penjualan"

        Dim dt As New DataTable()

        Dim adapter As New MySqlDataAdapter(query, conn)

        adapter.Fill(dt)

        DataGridView1.DataSource = dt
        ' Atur teks di tengah untuk kolom DataGridView tertentu
        DataGridView1.Columns("Bulan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("Penjualan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        AddHandler DataGridView1.CellClick, AddressOf DataGridView1_CellClick
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            selectedID = DataGridView1.Rows(e.RowIndex).Cells("Bulan").Value.ToString()

            txtBulan.Text = selectedID
            txtJumlah.Text = DataGridView1.Rows(e.RowIndex).Cells("Penjualan").Value.ToString()
            'txtBulan.Text = DataGridView1.Rows(e.RowIndex).Cells("Kategori").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataForm As New data()
        Me.Hide()
        dataForm.Show()
    End Sub

    Private Sub kriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanSemuaData()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim bulan As String = txtBulan.Text
            Dim selectedbulan As String = txtJumlah.Text

            ' Validasi input
            If String.IsNullOrWhiteSpace(bulan) OrElse String.IsNullOrWhiteSpace(selectedbulan) Then
                MessageBox.Show("Harap isi semua kolom yang ada.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Call connect()

            ' Periksa apakah bulan sudah ada dalam database
            Dim queryCheckBulan As String = "SELECT COUNT(*) FROM data_penjualan WHERE bulan = @Bulan"
            Using cmdCheckBulan As New MySqlCommand(queryCheckBulan, conn)
                cmdCheckBulan.Parameters.AddWithValue("@Bulan", bulan)
                Dim existingRowCount As Integer = Convert.ToInt32(cmdCheckBulan.ExecuteScalar())

                If existingRowCount > 0 Then
                    ' Bulan sudah ada dalam database, tampilkan pesan kesalahan
                    MessageBox.Show("Bulan ini sudah ada dalam database.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Bulan belum ada dalam database, simpan data
                    Dim insertQuery As String = "INSERT INTO data_penjualan (bulan, penjualan) VALUES (@Bulan, @Penjualan)"
                    Using cmd As New MySqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@Bulan", bulan)
                        cmd.Parameters.AddWithValue("@Penjualan", selectedbulan)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Data berhasil ditambahkan!")
                    TampilkanSemuaData()

                    ' Kosongkan semua TextBox
                    txtJumlah.Text = ""
                    txtBulan.Text = "Pilih Item"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus semua data?", "Konfirmasi Hapus Semua", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Dim query As String = "DELETE FROM data_penjualan"

            Using cmd As New MySqlCommand(query, conn)
                ' Buka koneksi database
                'conn.Open()

                cmd.ExecuteNonQuery()

                ' Tutup koneksi database
                conn.Close()
            End Using

            MessageBox.Show("Seluruh data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TampilkanSemuaData() ' Memuat ulang data setelah penghapusan
        End If
    End Sub

    Private selectedID As String = ""
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            'Dim kdKriteria As String = txtIdkriteria.Text
            Dim selectedBulan As String = txtBulan.Text
            Dim jumlah As String = txtJumlah.Text

            ' Validasi input
            If String.IsNullOrWhiteSpace(jumlah) OrElse String.IsNullOrWhiteSpace(selectedBulan) Then
                MessageBox.Show("Harap isi semua kolom kriteria.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Call connect()

            Dim query As String = "UPDATE data_penjualan SET bulan = @Bulan, penjualan = @Penjualan WHERE bulan = @SelectedID"

            Using cmd As New MySqlCommand(query, conn)
                'cmd.Parameters.AddWithValue("@Kd", kdKriteria)
                cmd.Parameters.AddWithValue("@Penjualan", jumlah)
                cmd.Parameters.AddWithValue("@Bulan", selectedBulan)
                cmd.Parameters.AddWithValue("@SelectedID", selectedID)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil diupdate!")

            ' Kosongkan semua TextBox
            'txtIdkriteria.Text = ""
            txtJumlah.Text = ""
            txtBulan.Text = "Pilih Item"

            TampilkanSemuaData()

            ' Set ulang selectedID ke nilai kosong
            selectedID = ""
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Dim subForm As New subKriteria()
        'Me.Hide()
        subForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hitungForm As New hitung()
        Me.Hide()
        hitungForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim keluarForm As New login()
        Me.Hide()
        keluarForm.Show()
    End Sub

    'Private Sub kriteria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    Application.Exit()
    'End Sub
End Class
