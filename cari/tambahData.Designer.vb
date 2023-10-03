<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tambahData
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBulan = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(95, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(264, 25)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Tambah Data Penjualan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bulan"
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(178, 137)
        Me.txtJumlah.Multiline = True
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(229, 34)
        Me.txtJumlah.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Penjualan"
        '
        'txtBulan
        '
        Me.txtBulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBulan.FormattingEnabled = True
        Me.txtBulan.Location = New System.Drawing.Point(178, 88)
        Me.txtBulan.Name = "txtBulan"
        Me.txtBulan.Size = New System.Drawing.Size(229, 28)
        Me.txtBulan.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(332, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tambahData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(465, 308)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBulan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tambahData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Penjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBulan As ComboBox
    Friend WithEvents Button1 As Button
End Class
