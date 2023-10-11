Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class register
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginForm As New login()
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Try
            ' Ambil nilai dari TextBox
            Dim email As String = txtEmail.Text
            Dim username As String = txtUsername.Text
            Dim password As String = txtPass.Text

            ' Validasi input
            If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("Harap isi semua kolom untuk registrasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub ' Keluar dari proses registrasi jika ada kolom yang kosong
            End If

            ' Validasi email dengan ekspresi reguler
            Dim emailPattern As String = "^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$"
            If Not Regex.IsMatch(email, emailPattern) Then
                MessageBox.Show("Format email tidak valid. Harap masukkan email yang benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub ' Keluar dari proses registrasi jika format email tidak valid
            End If

            ' Buat koneksi ke database menggunakan sub 'connect' dari module 'koneksi'
            Call connect()

            ' Buat perintah SQL untuk menyimpan data ke tabel
            Dim query As String = "INSERT INTO user (email, username, password) VALUES (@Email, @Username, @Password)"
            Using cmd As New MySqlCommand(query, conn)
                ' @Email, @Username, @Password sesuai dengan parameter yang Anda gunakan dalam perintah SQL
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)

                ' Eksekusi perintah SQL
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Registrasi berhasil!")

            ' Kosongkan semua TextBox
            txtEmail.Text = ""
            txtUsername.Text = ""
            txtPass.Text = ""

            'Me.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try

    End Sub

    Private Sub register_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class