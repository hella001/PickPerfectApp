<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSeleksi = New System.Windows.Forms.Button()
        Me.btnKriteria = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(123, 151)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(834, 73)
        Label5.TabIndex = 0
        Label5.Text = "Selamat Datang Di Aplikasi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Grafik"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hitung"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(445, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Keluar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(154, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1109, 500)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(381, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(368, 73)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "PickPerfect"
        '
        'btnSeleksi
        '
        Me.btnSeleksi.BackgroundImage = Global.cari.My.Resources.Resources.seleksi
        Me.btnSeleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSeleksi.Location = New System.Drawing.Point(339, 12)
        Me.btnSeleksi.Name = "btnSeleksi"
        Me.btnSeleksi.Size = New System.Drawing.Size(75, 54)
        Me.btnSeleksi.TabIndex = 2
        Me.btnSeleksi.UseVisualStyleBackColor = True
        '
        'btnKriteria
        '
        Me.btnKriteria.BackgroundImage = Global.cari.My.Resources.Resources.kriteria
        Me.btnKriteria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnKriteria.Location = New System.Drawing.Point(246, 12)
        Me.btnKriteria.Name = "btnKriteria"
        Me.btnKriteria.Size = New System.Drawing.Size(75, 54)
        Me.btnKriteria.TabIndex = 1
        Me.btnKriteria.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.BackgroundImage = Global.cari.My.Resources.Resources.traffic
        Me.btnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnData.Location = New System.Drawing.Point(154, 12)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(75, 54)
        Me.btnData.TabIndex = 0
        Me.btnData.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.Location = New System.Drawing.Point(434, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 54)
        Me.Button5.TabIndex = 24
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSeleksi)
        Me.Controls.Add(Me.btnKriteria)
        Me.Controls.Add(Me.btnData)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard- PickPerfect"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnData As Button
    Friend WithEvents btnKriteria As Button
    Friend WithEvents btnSeleksi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
End Class
