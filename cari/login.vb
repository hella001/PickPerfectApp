Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Call connect()
            Dim str As String
            str = "select * from user where username = '" & txtUsername.Text & "' and password = '" & txtPass.Text & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                'dashboard.Visible = True
                'dashboard.Enabled = True
                Dim dashboardForm As New dashboard()
                Me.Hide()
                dashboardForm.Show()
            Else
                rd.Close()
                MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPass.Text = ""
                txtUsername.Text = ""
                txtUsername.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim registerForm As New register()
        Me.Hide()
        registerForm.Show()
    End Sub

    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class
