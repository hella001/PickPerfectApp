<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class data
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMape = New System.Windows.Forms.Label()
        Me.txtMse = New System.Windows.Forms.Label()
        Me.txtMae = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtMape)
        Me.GroupBox1.Controls.Add(Me.txtMse)
        Me.GroupBox1.Controls.Add(Me.txtMae)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Chart1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1287, 500)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'txtMape
        '
        Me.txtMape.AutoSize = True
        Me.txtMape.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMape.Location = New System.Drawing.Point(126, 465)
        Me.txtMape.Name = "txtMape"
        Me.txtMape.Size = New System.Drawing.Size(18, 20)
        Me.txtMape.TabIndex = 11
        Me.txtMape.Text = "0"
        '
        'txtMse
        '
        Me.txtMse.AutoSize = True
        Me.txtMse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMse.Location = New System.Drawing.Point(126, 435)
        Me.txtMse.Name = "txtMse"
        Me.txtMse.Size = New System.Drawing.Size(18, 20)
        Me.txtMse.TabIndex = 10
        Me.txtMse.Text = "0"
        '
        'txtMae
        '
        Me.txtMae.AutoSize = True
        Me.txtMae.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMae.Location = New System.Drawing.Point(126, 405)
        Me.txtMae.Name = "txtMae"
        Me.txtMae.Size = New System.Drawing.Size(18, 20)
        Me.txtMae.TabIndex = 9
        Me.txtMae.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "MAPE :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 435)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "MSE :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "MAE :"
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(56, 86)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(401, 316)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(476, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(472, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Data MAE, MSE, dan MAPE yang tersimpan"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(1147, 19)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(103, 38)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(501, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(749, 316)
        Me.DataGridView1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cetak"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Hitung"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Grafik"
        '
        'Timer1
        '
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.cari.My.Resources.Resources.cetak
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Location = New System.Drawing.Point(403, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 54)
        Me.Button4.TabIndex = 13
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.cari.My.Resources.Resources.seleksi
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Location = New System.Drawing.Point(310, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 54)
        Me.Button3.TabIndex = 12
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.cari.My.Resources.Resources.kriteria
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(217, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 54)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.cari.My.Resources.Resources.traffic
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(125, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 54)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "data"
        Me.Text = "Grafik- PickPerfectApp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMape As Label
    Friend WithEvents txtMse As Label
    Friend WithEvents txtMae As Label
    Friend WithEvents Label8 As Label
End Class
