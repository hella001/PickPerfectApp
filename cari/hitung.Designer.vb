<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hitung
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtPhi = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(603, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menghitung MAE, MSE, dan MAPE Dengan Metode SES"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(498, 403)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(116, 39)
        Me.btnHitung.TabIndex = 1
        Me.btnHitung.Text = "Mulai Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtPhi
        '
        Me.txtPhi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhi.Location = New System.Drawing.Point(342, 405)
        Me.txtPhi.Name = "txtPhi"
        Me.txtPhi.Size = New System.Drawing.Size(100, 26)
        Me.txtPhi.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.txtPhi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(194, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1010, 500)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(171, 352)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(348, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "dalam menginputkan pada kolom dibawah."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(171, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(421, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Pada kolom input a harap tuliskan koma bukan titik "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(176, 408)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Masukkan Nilai a:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(375, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sebagai contoh a= ( 0,1 )."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nilai (a) harus dibawah 1."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Note:"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(639, 403)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(116, 39)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan Data"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(107, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(801, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(407, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cetak"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Hitung"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(129, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Grafik"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.cari.My.Resources.Resources.cetak
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Location = New System.Drawing.Point(394, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 54)
        Me.Button4.TabIndex = 22
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.cari.My.Resources.Resources.seleksi
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Location = New System.Drawing.Point(301, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 54)
        Me.Button3.TabIndex = 21
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.cari.My.Resources.Resources.kriteria
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(208, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 54)
        Me.Button2.TabIndex = 20
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.cari.My.Resources.Resources.traffic
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(116, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 54)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = True
        '
        'hitung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "hitung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hitung SES- PickPerfectApp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtPhi As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
