<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cetak
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
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCetak
        '
        Me.btnCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.Location = New System.Drawing.Point(12, 12)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 31)
        Me.btnCetak.TabIndex = 0
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'cetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCetak)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cetak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCetak As Button
End Class
