<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetailerInvoice
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
        Me.btnExit = New System.Windows.Forms.Button
        Me.dgvCustomerOrders = New System.Windows.Forms.DataGridView
        Me.gpOrder = New System.Windows.Forms.GroupBox
        Me.chkStationary = New System.Windows.Forms.CheckBox
        Me.chkOrder = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbProduct = New System.Windows.Forms.ComboBox
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.lblProduct = New System.Windows.Forms.Label
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.lblreceived = New System.Windows.Forms.Label
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.cmbRetailerName = New System.Windows.Forms.ComboBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtTotalCost = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.txtRetailerID = New System.Windows.Forms.TextBox
        Me.lbltotalcost = New System.Windows.Forms.Label
        Me.lblempno = New System.Windows.Forms.Label
        Me.lblcustmrname = New System.Windows.Forms.Label
        Me.lblpaymntno = New System.Windows.Forms.Label
        Me.lblcustmid = New System.Windows.Forms.Label
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(547, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvCustomerOrders
        '
        Me.dgvCustomerOrders.AllowUserToAddRows = False
        Me.dgvCustomerOrders.AllowUserToDeleteRows = False
        Me.dgvCustomerOrders.AllowUserToResizeColumns = False
        Me.dgvCustomerOrders.AllowUserToResizeRows = False
        Me.dgvCustomerOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCustomerOrders.Location = New System.Drawing.Point(10, 146)
        Me.dgvCustomerOrders.Name = "dgvCustomerOrders"
        Me.dgvCustomerOrders.Size = New System.Drawing.Size(731, 110)
        Me.dgvCustomerOrders.TabIndex = 94
        '
        'gpOrder
        '
        Me.gpOrder.Controls.Add(Me.chkStationary)
        Me.gpOrder.Controls.Add(Me.chkOrder)
        Me.gpOrder.Controls.Add(Me.Label3)
        Me.gpOrder.Controls.Add(Me.txtTotal)
        Me.gpOrder.Controls.Add(Me.Label2)
        Me.gpOrder.Controls.Add(Me.txtUnitPrice)
        Me.gpOrder.Controls.Add(Me.Label1)
        Me.gpOrder.Controls.Add(Me.cmbProduct)
        Me.gpOrder.Controls.Add(Me.txtItemNo)
        Me.gpOrder.Controls.Add(Me.lblProduct)
        Me.gpOrder.Controls.Add(Me.cmdAdd)
        Me.gpOrder.Controls.Add(Me.lblreceived)
        Me.gpOrder.Controls.Add(Me.txtQuantity)
        Me.gpOrder.Location = New System.Drawing.Point(323, -1)
        Me.gpOrder.Name = "gpOrder"
        Me.gpOrder.Size = New System.Drawing.Size(418, 137)
        Me.gpOrder.TabIndex = 4
        Me.gpOrder.TabStop = False
        Me.gpOrder.Text = "Book Details"
        '
        'chkStationary
        '
        Me.chkStationary.AutoSize = True
        Me.chkStationary.Location = New System.Drawing.Point(217, 20)
        Me.chkStationary.Name = "chkStationary"
        Me.chkStationary.Size = New System.Drawing.Size(52, 17)
        Me.chkStationary.TabIndex = 0
        Me.chkStationary.Text = "Other"
        Me.chkStationary.UseVisualStyleBackColor = True
        '
        'chkOrder
        '
        Me.chkOrder.AutoSize = True
        Me.chkOrder.Location = New System.Drawing.Point(336, 18)
        Me.chkOrder.Name = "chkOrder"
        Me.chkOrder.Size = New System.Drawing.Size(52, 17)
        Me.chkOrder.TabIndex = 6
        Me.chkOrder.Text = "Order"
        Me.chkOrder.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(282, 98)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(97, 20)
        Me.txtTotal.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Unit Price"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(104, 72)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(83, 20)
        Me.txtUnitPrice.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "ItemNo"
        '
        'cmbProduct
        '
        Me.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(104, 45)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(165, 21)
        Me.cmbProduct.TabIndex = 2
        '
        'txtItemNo
        '
        Me.txtItemNo.Location = New System.Drawing.Point(104, 19)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(107, 20)
        Me.txtItemNo.TabIndex = 1
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(26, 46)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(35, 15)
        Me.lblProduct.TabIndex = 34
        Me.lblProduct.Text = "Book"
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(326, 43)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 5
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'lblreceived
        '
        Me.lblreceived.AutoSize = True
        Me.lblreceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreceived.Location = New System.Drawing.Point(26, 99)
        Me.lblreceived.Name = "lblreceived"
        Me.lblreceived.Size = New System.Drawing.Size(51, 15)
        Me.lblreceived.TabIndex = 36
        Me.lblreceived.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(104, 98)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(83, 20)
        Me.txtQuantity.TabIndex = 4
        '
        'cmbRetailerName
        '
        Me.cmbRetailerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRetailerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRetailerName.FormattingEnabled = True
        Me.cmbRetailerName.Location = New System.Drawing.Point(129, 38)
        Me.cmbRetailerName.Name = "cmbRetailerName"
        Me.cmbRetailerName.Size = New System.Drawing.Size(165, 21)
        Me.cmbRetailerName.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(466, 301)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(385, 301)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(223, 301)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(304, 301)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(142, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(466, 264)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalCost.TabIndex = 86
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(129, 91)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(165, 20)
        Me.txtDate.TabIndex = 3
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(129, 65)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(165, 20)
        Me.txtInvoiceNo.TabIndex = 2
        '
        'txtRetailerID
        '
        Me.txtRetailerID.Location = New System.Drawing.Point(129, 12)
        Me.txtRetailerID.Name = "txtRetailerID"
        Me.txtRetailerID.Size = New System.Drawing.Size(165, 20)
        Me.txtRetailerID.TabIndex = 0
        '
        'lbltotalcost
        '
        Me.lbltotalcost.AutoSize = True
        Me.lbltotalcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcost.Location = New System.Drawing.Point(383, 265)
        Me.lbltotalcost.Name = "lbltotalcost"
        Me.lbltotalcost.Size = New System.Drawing.Size(61, 15)
        Me.lbltotalcost.TabIndex = 82
        Me.lbltotalcost.Text = "Total Cost"
        '
        'lblempno
        '
        Me.lblempno.AutoSize = True
        Me.lblempno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempno.Location = New System.Drawing.Point(4, 92)
        Me.lblempno.Name = "lblempno"
        Me.lblempno.Size = New System.Drawing.Size(33, 15)
        Me.lblempno.TabIndex = 81
        Me.lblempno.Text = "Date"
        '
        'lblcustmrname
        '
        Me.lblcustmrname.AutoSize = True
        Me.lblcustmrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustmrname.Location = New System.Drawing.Point(4, 39)
        Me.lblcustmrname.Name = "lblcustmrname"
        Me.lblcustmrname.Size = New System.Drawing.Size(96, 15)
        Me.lblcustmrname.TabIndex = 80
        Me.lblcustmrname.Text = "Company Name"
        '
        'lblpaymntno
        '
        Me.lblpaymntno.AutoSize = True
        Me.lblpaymntno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaymntno.Location = New System.Drawing.Point(4, 66)
        Me.lblpaymntno.Name = "lblpaymntno"
        Me.lblpaymntno.Size = New System.Drawing.Size(64, 15)
        Me.lblpaymntno.TabIndex = 79
        Me.lblpaymntno.Text = "Invoice No"
        '
        'lblcustmid
        '
        Me.lblcustmid.AutoSize = True
        Me.lblcustmid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustmid.Location = New System.Drawing.Point(4, 13)
        Me.lblcustmid.Name = "lblcustmid"
        Me.lblcustmid.Size = New System.Drawing.Size(65, 15)
        Me.lblcustmid.TabIndex = 78
        Me.lblcustmid.Text = "Retailer ID"
        '
        'frmRetailerInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 352)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvCustomerOrders)
        Me.Controls.Add(Me.gpOrder)
        Me.Controls.Add(Me.cmbRetailerName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.txtRetailerID)
        Me.Controls.Add(Me.lbltotalcost)
        Me.Controls.Add(Me.lblempno)
        Me.Controls.Add(Me.lblcustmrname)
        Me.Controls.Add(Me.lblpaymntno)
        Me.Controls.Add(Me.lblcustmid)
        Me.Name = "frmRetailerInvoice"
        Me.Text = "Retailer Requests"
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpOrder.ResumeLayout(False)
        Me.gpOrder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgvCustomerOrders As System.Windows.Forms.DataGridView
    Friend WithEvents gpOrder As System.Windows.Forms.GroupBox
    Friend WithEvents chkStationary As System.Windows.Forms.CheckBox
    Friend WithEvents chkOrder As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents lblreceived As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents cmbRetailerName As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailerID As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalcost As System.Windows.Forms.Label
    Friend WithEvents lblempno As System.Windows.Forms.Label
    Friend WithEvents lblcustmrname As System.Windows.Forms.Label
    Friend WithEvents lblpaymntno As System.Windows.Forms.Label
    Friend WithEvents lblcustmid As System.Windows.Forms.Label
End Class
