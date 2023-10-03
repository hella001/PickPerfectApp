Imports System.Security.Claims
Imports MySql.Data.MySqlClient

Public Class subKriteria
    Private Sub subKriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanSemuaData()
        bobot1.Items.Add("Sangat Tinggi")
        bobot1.Items.Add("Tinggi")
        bobot1.Items.Add("Sedang")
        bobot1.Items.Add("Rendah")
        bobot1.Items.Add("Sangat Rendah")
        bobot1.Text = "Pilih Item"
        bobot2.Items.Add("A")
        bobot2.Items.Add("B")
        bobot2.Items.Add("C")
        bobot2.Items.Add("D")
        bobot2.Items.Add("E")
        bobot2.Text = "Pilih Item"
        bobot3.Items.Add("A")
        bobot3.Items.Add("B")
        bobot3.Items.Add("C")
        bobot3.Items.Add("D")
        bobot3.Items.Add("E")
        bobot3.Text = "Pilih Item"
    End Sub

    Private Sub TampilkanSemuaData()
        'Dim conn As MySqlConnection = connect()
        Call connect()

        ' Buat perintah SQL untuk mengambil semua data dari tabel tertentu
        Dim query As String = "SELECT bobot AS 'Bobot', nilai AS 'Nilai' FROM nilai_bobot"
        Dim query1 As String = "SELECT efektif AS 'Afektif', nilai AS 'Nilai' FROM ekstrakurikuler"
        Dim query2 As String = "SELECT efektif AS 'Afektif', nilai AS 'Nilai' FROM tingkah_laku"

        ' Buat objek DataTable untuk menyimpan hasil query
        Dim dt As New DataTable()
        Dim dt1 As New DataTable()
        Dim dt2 As New DataTable()

        ' Adapter MySQL untuk mengambil data dari database
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim adapter1 As New MySqlDataAdapter(query1, conn)
        Dim adapter2 As New MySqlDataAdapter(query2, conn)

        ' Isi objek DataTable dengan data
        adapter.Fill(dt)
        adapter1.Fill(dt1)
        adapter2.Fill(dt2)

        DataGridView1.DataSource = dt
        DataGridView2.DataSource = dt1
        DataGridView3.DataSource = dt2

        ' Atur teks di tengah untuk kolom DataGridView tertentu
        DataGridView1.Columns("Bobot").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns("Nilai").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns("Afektif").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns("Nilai").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView3.Columns("Afektif").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView3.Columns("Nilai").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            selectedID = DataGridView1.Rows(e.RowIndex).Cells("Bobot").Value.ToString()

            bobot1.Text = selectedID
            'nilai1.Text = DataGridView1.Rows(e.RowIndex).Cells("Nilai").Value.ToString()
        End If
    End Sub

    Private Sub btnHapus1_Click(sender As Object, e As EventArgs) Handles btnHapus1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus data terpilih?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
                Dim selectedID As String = DataGridView1.Rows(selectedRowIndex).Cells("Bobot").Value.ToString()

                Dim query As String = "DELETE FROM nilai_bobot WHERE bobot = @SelectedID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SelectedID", selectedID)

                    ' Buka koneksi database
                    'conn.Open()

                    cmd.ExecuteNonQuery()

                    ' Tutup koneksi database
                    conn.Close()
                End Using

                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TampilkanSemuaData()
            End If
        Else
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnTambah1_Click(sender As Object, e As EventArgs) Handles btnTambah1.Click
        Try
            Dim bobot As String = bobot1.Text
            Dim nilai As String = ""

            ' Validasi input
            If String.IsNullOrWhiteSpace(bobot) Then
                MessageBox.Show("Harap pilih bobot.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Mengatur nilai berdasarkan bobot yang dipilih
            Select Case bobot
                Case "Sangat Tinggi"
                    nilai = "5"
                Case "Tinggi"
                    nilai = "4"
                Case "Sedang"
                    nilai = "3"
                Case "Rendah"
                    nilai = "2"
                Case "Sangat Rendah"
                    nilai = "1"
                Case Else
                    MessageBox.Show("Bobot tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
            End Select

            Call connect()

            Dim query As String = "INSERT INTO nilai_bobot (bobot, nilai) VALUES (@Bobot, @Nilai)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Bobot", bobot)
                cmd.Parameters.AddWithValue("@Nilai", nilai)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil Ditambahkan!")
            TampilkanSemuaData()

            ' Kosongkan ComboBox bobot1
            bobot1.SelectedItem = Nothing
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnTambah2_Click(sender As Object, e As EventArgs) Handles btnTambah2.Click
        Try
            Dim bobot As String = bobot2.Text
            Dim nilai As String = ""

            ' Validasi input
            If String.IsNullOrWhiteSpace(bobot) Then
                MessageBox.Show("Harap pilih bobot.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Mengatur nilai berdasarkan bobot yang dipilih
            Select Case bobot
                Case "A"
                    nilai = "5"
                Case "B"
                    nilai = "4"
                Case "C"
                    nilai = "3"
                Case "D"
                    nilai = "2"
                Case "E"
                    nilai = "1"
                Case Else
                    MessageBox.Show("Bobot tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
            End Select

            Call connect()

            Dim query As String = "INSERT INTO ekstrakurikuler (efektif, nilai) VALUES (@Bobot, @Nilai)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Bobot", bobot)
                cmd.Parameters.AddWithValue("@Nilai", nilai)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil Ditambahkan!")
            TampilkanSemuaData()

            ' Kosongkan ComboBox bobot1
            bobot2.SelectedItem = Nothing
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus2_Click(sender As Object, e As EventArgs) Handles btnHapus2.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus data terpilih?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim selectedRowIndex As Integer = DataGridView2.SelectedRows(0).Index
                Dim selectedID As String = DataGridView2.Rows(selectedRowIndex).Cells("Afektif").Value.ToString()

                Dim query As String = "DELETE FROM ekstrakurikuler WHERE efektif = @SelectedID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SelectedID", selectedID)

                    ' Buka koneksi database
                    'conn.Open()

                    ' Eksekusi perintah SQL untuk menghapus data
                    cmd.ExecuteNonQuery()

                    ' Tutup koneksi database
                    conn.Close()
                End Using

                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TampilkanSemuaData()
            End If
        Else
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnTambah3_Click(sender As Object, e As EventArgs) Handles btnTambah3.Click
        Try
            Dim bobot As String = bobot3.Text
            Dim nilai As String = ""

            ' Validasi input
            If String.IsNullOrWhiteSpace(bobot) Then
                MessageBox.Show("Harap pilih bobot.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Mengatur nilai berdasarkan bobot yang dipilih
            Select Case bobot
                Case "A"
                    nilai = "5"
                Case "B"
                    nilai = "4"
                Case "C"
                    nilai = "3"
                Case "D"
                    nilai = "2"
                Case "E"
                    nilai = "1"
                Case Else
                    MessageBox.Show("Bobot tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
            End Select

            Call connect()

            Dim query As String = "INSERT INTO tingkah_laku (efektif, nilai) VALUES (@Bobot, @Nilai)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Bobot", bobot)
                cmd.Parameters.AddWithValue("@Nilai", nilai)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil Ditambahkan!")
            TampilkanSemuaData()

            ' Kosongkan ComboBox bobot1
            bobot3.SelectedItem = Nothing
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus3_Click(sender As Object, e As EventArgs) Handles btnHapus3.Click
        If DataGridView3.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus data terpilih?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim selectedRowIndex As Integer = DataGridView3.SelectedRows(0).Index
                Dim selectedID As String = DataGridView3.Rows(selectedRowIndex).Cells("Afektif").Value.ToString()

                Dim query As String = "DELETE FROM tingkah_laku WHERE efektif = @SelectedID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SelectedID", selectedID)

                    ' Buka koneksi database
                    'conn.Open()

                    ' Eksekusi perintah SQL untuk menghapus data
                    cmd.ExecuteNonQuery()

                    ' Tutup koneksi database
                    conn.Close()
                End Using

                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TampilkanSemuaData()
            End If
        Else
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class