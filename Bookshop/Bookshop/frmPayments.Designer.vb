<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Me.dgvDisplay = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbSupplier = New System.Windows.Forms.RadioButton
        Me.rdbRetailer = New System.Windows.Forms.RadioButton
        Me.lblID = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnPayNow = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShopName = New System.Windows.Forms.TextBox
        Me.txtChequeNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtChequeAcc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnClearAll = New System.Windows.Forms.Button
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDisplay
        '
        Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplay.Location = New System.Drawing.Point(2, 61)
        Me.dgvDisplay.Name = "dgvDisplay"
        Me.dgvDisplay.Size = New System.Drawing.Size(595, 227)
        Me.dgvDisplay.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbSupplier)
        Me.GroupBox1.Controls.Add(Me.rdbRetailer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 43)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Option"
        '
        'rdbSupplier
        '
        Me.rdbSupplier.AutoSize = True
        Me.rdbSupplier.Location = New System.Drawing.Point(130, 18)
        Me.rdbSupplier.Name = "rdbSupplier"
        Me.rdbSupplier.Size = New System.Drawing.Size(112, 17)
        Me.rdbSupplier.TabIndex = 4
        Me.rdbSupplier.Text = "Supplier Payments"
        Me.rdbSupplier.UseVisualStyleBackColor = True
        '
        'rdbRetailer
        '
        Me.rdbRetailer.AutoSize = True
        Me.rdbRetailer.Location = New System.Drawing.Point(7, 18)
        Me.rdbRetailer.Name = "rdbRetailer"
        Me.rdbRetailer.Size = New System.Drawing.Size(110, 17)
        Me.rdbRetailer.TabIndex = 3
        Me.rdbRetailer.Text = "Retailer Payments"
        Me.rdbRetailer.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(300, 30)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(110, 13)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "Retailer or Supplier ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(425, 27)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 5
        '
        'btnPayNow
        '
        Me.btnPayNow.Location = New System.Drawing.Point(720, 257)
        Me.btnPayNow.Name = "btnPayNow"
        Me.btnPayNow.Size = New System.Drawing.Size(75, 23)
        Me.btnPayNow.TabIndex = 6
        Me.btnPayNow.Text = "Pay Now"
        Me.btnPayNow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(547, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Shop Name"
        Me.Label1.Visible = False
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(617, 27)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(178, 20)
        Me.txtShopName.TabIndex = 8
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Location = New System.Drawing.Point(695, 72)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(100, 20)
        Me.txtChequeNo.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(607, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Cheque No"
        '
        'txtChequeAcc
        '
        Me.txtChequeAcc.Location = New System.Drawing.Point(695, 108)
        Me.txtChequeAcc.Name = "txtChequeAcc"
        Me.txtChequeAcc.Size = New System.Drawing.Size(100, 20)
        Me.txtChequeAcc.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(606, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cheque Account"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(695, 144)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(100, 20)
        Me.txtBank.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(607, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Bank Name"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(695, 180)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(606, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cheque Amount"
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(617, 257)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAll.TabIndex = 17
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(695, 216)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(607, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cheque Date"
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 292)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBank)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtChequeAcc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtChequeNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtShopName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPayNow)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvDisplay)
        Me.Name = "frmPayments"
        Me.Text = "Payments"
        CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDisplay As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRetailer As System.Windows.Forms.RadioButton
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnPayNow As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShopName As System.Windows.Forms.TextBox
    Friend WithEvents txtChequeNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtChequeAcc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
