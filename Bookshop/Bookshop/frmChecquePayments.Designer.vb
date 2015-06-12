<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChecquePayments
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
        Me.btncuspaymentexit = New System.Windows.Forms.Button
        Me.btncuspaymentsearch = New System.Windows.Forms.Button
        Me.btncuspaymentdelete = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btncuspaymentexit
        '
        Me.btncuspaymentexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncuspaymentexit.Location = New System.Drawing.Point(320, 394)
        Me.btncuspaymentexit.Name = "btncuspaymentexit"
        Me.btncuspaymentexit.Size = New System.Drawing.Size(75, 23)
        Me.btncuspaymentexit.TabIndex = 66
        Me.btncuspaymentexit.Text = "Exit"
        Me.btncuspaymentexit.UseVisualStyleBackColor = True
        '
        'btncuspaymentsearch
        '
        Me.btncuspaymentsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncuspaymentsearch.Location = New System.Drawing.Point(165, 394)
        Me.btncuspaymentsearch.Name = "btncuspaymentsearch"
        Me.btncuspaymentsearch.Size = New System.Drawing.Size(75, 23)
        Me.btncuspaymentsearch.TabIndex = 65
        Me.btncuspaymentsearch.Text = "Search"
        Me.btncuspaymentsearch.UseVisualStyleBackColor = True
        '
        'btncuspaymentdelete
        '
        Me.btncuspaymentdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncuspaymentdelete.Location = New System.Drawing.Point(10, 394)
        Me.btncuspaymentdelete.Name = "btncuspaymentdelete"
        Me.btncuspaymentdelete.Size = New System.Drawing.Size(75, 23)
        Me.btncuspaymentdelete.TabIndex = 64
        Me.btncuspaymentdelete.Text = "Delete"
        Me.btncuspaymentdelete.UseVisualStyleBackColor = True
        '
        'frmChecquePayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 429)
        Me.Controls.Add(Me.btncuspaymentexit)
        Me.Controls.Add(Me.btncuspaymentsearch)
        Me.Controls.Add(Me.btncuspaymentdelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmChecquePayments"
        Me.Text = "Order"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncuspaymentexit As System.Windows.Forms.Button
    Friend WithEvents btncuspaymentsearch As System.Windows.Forms.Button
    Friend WithEvents btncuspaymentdelete As System.Windows.Forms.Button
End Class
