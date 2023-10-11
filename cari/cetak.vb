Imports System.Data
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class cetak
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            ' Lokasi dan nama file PDF yang akan dihasilkan
            Dim outputPDFPath As String = "Report.pdf"

            ' Mengambil data dari database 'hasil'
            Dim dataFromDatabase As List(Of Hasil) = GetDataFromDatabase()

            ' Membuat dokumen PDF
            Using doc As New Document()
                Using writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(outputPDFPath, FileMode.Create))
                    doc.Open()

                    ' Membuat tabel untuk menampilkan data
                    Dim table As New PdfPTable(7) ' Tabel dengan 7 kolom
                    table.WidthPercentage = 100

                    ' Header Tabel
                    Dim headerFont As Font = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK)
                    Dim headerCells As New List(Of PdfPCell)()
                    headerCells.Add(New PdfPCell(New Phrase("Bulan", headerFont)))
                    headerCells.Add(New PdfPCell(New Phrase("Penjualan", headerFont)))
                    headerCells.Add(New PdfPCell(New Phrase("Phi", headerFont)))
                    headerCells.Add(New PdfPCell(New Phrase("Forecast", headerFont)))
                    headerCells.Add(New PdfPCell(New Phrase("MAE", headerFont)))
                    headerCells.Add(New PdfPCell(New Phrase("MSE", headerFont)))
                    headerCells.Add(New PdfPCell(New Phrase("MAPE", headerFont)))

                    For Each cell In headerCells
                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                        table.AddCell(cell)
                    Next

                    ' Mengisi tabel dengan data dari database 'hasil'
                    For Each row In dataFromDatabase
                        table.AddCell(New Phrase(row.Bulan))
                        table.AddCell(New Phrase(row.Penjualan.ToString()))
                        table.AddCell(New Phrase(row.Phi.ToString()))
                        table.AddCell(New Phrase(row.Forecast))
                        table.AddCell(New Phrase(row.Mae))
                        table.AddCell(New Phrase(row.Mse))
                        table.AddCell(New Phrase(row.Mape))
                    Next

                    doc.Add(table)
                End Using
            End Using

            MessageBox.Show("File PDF telah berhasil dibuat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fungsi untuk mengambil data dari database 'hasil'
    Private Function GetDataFromDatabase() As List(Of Hasil)
        'Dim connectionString As String = "YourConnectionString" ' Ganti dengan koneksi database MySQL Anda
        Dim data As New List(Of Hasil)()

        'Using conn As MySqlConnection = New MySqlConnection(connectionString)
        'conn.Open()
        Call connect()
        Dim query As String = "SELECT * FROM hasil"
        Using cmd As MySqlCommand = New MySqlCommand(query, conn)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim hasilData As New Hasil()
                    hasilData.Bulan = reader("bulan").ToString()
                    hasilData.Penjualan = Integer.Parse(reader("penjualan").ToString())
                    hasilData.Phi = Double.Parse(reader("phi").ToString())
                    hasilData.Forecast = reader("forecast").ToString()
                    hasilData.Mae = reader("mae").ToString()
                    hasilData.Mse = reader("mse").ToString()
                    hasilData.Mape = reader("mape").ToString()
                    data.Add(hasilData)
                End While
            End Using
        End Using
        'End Using

        Return data
    End Function
End Class

' Kelas model untuk data dari tabel 'hasil'
Public Class Hasil
    Public Property Bulan As String
    Public Property Penjualan As Integer
    Public Property Phi As Double
    Public Property Forecast As String
    Public Property Mae As String
    Public Property Mse As String
    Public Property Mape As String
End Class
