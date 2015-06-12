<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnCustomer = New System.Windows.Forms.Button
        Me.btnRetailer = New System.Windows.Forms.Button
        Me.btnSuppier = New System.Windows.Forms.Button
        Me.btnEmployee = New System.Windows.Forms.Button
        Me.btnInventory = New System.Windows.Forms.Button
        Me.btnPayment = New System.Windows.Forms.Button
        Me.btnOrder = New System.Windows.Forms.Button
        Me.btnLogout = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnAddUser = New System.Windows.Forms.Button
        Me.btnTime = New System.Windows.Forms.Button
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnRepRetailer = New System.Windows.Forms.Button
        Me.btnRepSupplier = New System.Windows.Forms.Button
        Me.btnAccessRept = New System.Windows.Forms.Button
        Me.lblLogin = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.gpPayments = New System.Windows.Forms.GroupBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.gpOrders = New System.Windows.Forms.GroupBox
        Me.btnRetailerOrder = New System.Windows.Forms.Button
        Me.btnSupplierOrder = New System.Windows.Forms.Button
        Me.btnCustomerOrder = New System.Windows.Forms.Button
        Me.btnReports = New System.Windows.Forms.Button
        Me.gpReports = New System.Windows.Forms.GroupBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpPayments.SuspendLayout()
        Me.gpOrders.SuspendLayout()
        Me.gpReports.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCustomer
        '
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCustomer.Location = New System.Drawing.Point(130, 0)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCustomer.Size = New System.Drawing.Size(100, 121)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnRetailer
        '
        Me.btnRetailer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRetailer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetailer.Image = CType(resources.GetObject("btnRetailer.Image"), System.Drawing.Image)
        Me.btnRetailer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRetailer.Location = New System.Drawing.Point(230, 0)
        Me.btnRetailer.Name = "btnRetailer"
        Me.btnRetailer.Size = New System.Drawing.Size(100, 121)
        Me.btnRetailer.TabIndex = 2
        Me.btnRetailer.Text = "Retailer"
        Me.btnRetailer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRetailer.UseVisualStyleBackColor = True
        '
        'btnSuppier
        '
        Me.btnSuppier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSuppier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppier.Image = CType(resources.GetObject("btnSuppier.Image"), System.Drawing.Image)
        Me.btnSuppier.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSuppier.Location = New System.Drawing.Point(330, 0)
        Me.btnSuppier.Name = "btnSuppier"
        Me.btnSuppier.Size = New System.Drawing.Size(100, 121)
        Me.btnSuppier.TabIndex = 3
        Me.btnSuppier.Text = "Supplier"
        Me.btnSuppier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSuppier.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.Image = CType(resources.GetObject("btnEmployee.Image"), System.Drawing.Image)
        Me.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmployee.Location = New System.Drawing.Point(430, 0)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(100, 121)
        Me.btnEmployee.TabIndex = 4
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInventory.Location = New System.Drawing.Point(530, 0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(100, 121)
        Me.btnInventory.TabIndex = 5
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), System.Drawing.Image)
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPayment.Location = New System.Drawing.Point(630, 0)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(100, 121)
        Me.btnPayment.TabIndex = 6
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Image = CType(resources.GetObject("btnOrder.Image"), System.Drawing.Image)
        Me.btnOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOrder.Location = New System.Drawing.Point(730, 0)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(100, 121)
        Me.btnOrder.TabIndex = 7
        Me.btnOrder.Text = "Order"
        Me.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogout.Location = New System.Drawing.Point(830, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 121)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(930, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 121)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1030, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 121)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), System.Drawing.Image)
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddUser.Location = New System.Drawing.Point(1260, 0)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(103, 121)
        Me.btnAddUser.TabIndex = 10
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTime.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTime.Location = New System.Drawing.Point(1030, 0)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(230, 121)
        Me.btnTime.TabIndex = 11
        Me.btnTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'tmr
        '
        Me.tmr.Enabled = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 40)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Inventory Status"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRepRetailer
        '
        Me.btnRepRetailer.Image = CType(resources.GetObject("btnRepRetailer.Image"), System.Drawing.Image)
        Me.btnRepRetailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepRetailer.Location = New System.Drawing.Point(0, 54)
        Me.btnRepRetailer.Name = "btnRepRetailer"
        Me.btnRepRetailer.Size = New System.Drawing.Size(127, 40)
        Me.btnRepRetailer.TabIndex = 19
        Me.btnRepRetailer.Text = "Retailer Details"
        Me.btnRepRetailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRepRetailer.UseVisualStyleBackColor = True
        '
        'btnRepSupplier
        '
        Me.btnRepSupplier.Image = CType(resources.GetObject("btnRepSupplier.Image"), System.Drawing.Image)
        Me.btnRepSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepSupplier.Location = New System.Drawing.Point(0, 8)
        Me.btnRepSupplier.Name = "btnRepSupplier"
        Me.btnRepSupplier.Size = New System.Drawing.Size(127, 40)
        Me.btnRepSupplier.TabIndex = 20
        Me.btnRepSupplier.Text = "Supplier Details"
        Me.btnRepSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRepSupplier.UseVisualStyleBackColor = True
        '
        'btnAccessRept
        '
        Me.btnAccessRept.Image = CType(resources.GetObject("btnAccessRept.Image"), System.Drawing.Image)
        Me.btnAccessRept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccessRept.Location = New System.Drawing.Point(0, 146)
        Me.btnAccessRept.Name = "btnAccessRept"
        Me.btnAccessRept.Size = New System.Drawing.Size(127, 40)
        Me.btnAccessRept.TabIndex = 23
        Me.btnAccessRept.Text = "Access Report"
        Me.btnAccessRept.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccessRept.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.BackColor = System.Drawing.Color.Black
        Me.lblLogin.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblLogin.Location = New System.Drawing.Point(23, 91)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(101, 18)
        Me.lblLogin.TabIndex = 24
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(127, 121)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'gpPayments
        '
        Me.gpPayments.Controls.Add(Me.Button8)
        Me.gpPayments.Controls.Add(Me.Button7)
        Me.gpPayments.Controls.Add(Me.Button3)
        Me.gpPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpPayments.Location = New System.Drawing.Point(630, 127)
        Me.gpPayments.Name = "gpPayments"
        Me.gpPayments.Size = New System.Drawing.Size(100, 160)
        Me.gpPayments.TabIndex = 26
        Me.gpPayments.TabStop = False
        Me.gpPayments.Text = "Payments"
        Me.gpPayments.Visible = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(6, 113)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 40)
        Me.Button8.TabIndex = 29
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(6, 66)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 40)
        Me.Button7.TabIndex = 28
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(6, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 40)
        Me.Button3.TabIndex = 27
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'gpOrders
        '
        Me.gpOrders.Controls.Add(Me.btnRetailerOrder)
        Me.gpOrders.Controls.Add(Me.btnSupplierOrder)
        Me.gpOrders.Controls.Add(Me.btnCustomerOrder)
        Me.gpOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpOrders.Location = New System.Drawing.Point(730, 127)
        Me.gpOrders.Name = "gpOrders"
        Me.gpOrders.Size = New System.Drawing.Size(100, 160)
        Me.gpOrders.TabIndex = 27
        Me.gpOrders.TabStop = False
        Me.gpOrders.Text = "Orders"
        Me.gpOrders.Visible = False
        '
        'btnRetailerOrder
        '
        Me.btnRetailerOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetailerOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRetailerOrder.Location = New System.Drawing.Point(6, 113)
        Me.btnRetailerOrder.Name = "btnRetailerOrder"
        Me.btnRetailerOrder.Size = New System.Drawing.Size(88, 40)
        Me.btnRetailerOrder.TabIndex = 29
        Me.btnRetailerOrder.Text = "Retailer"
        Me.btnRetailerOrder.UseVisualStyleBackColor = True
        '
        'btnSupplierOrder
        '
        Me.btnSupplierOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplierOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplierOrder.Location = New System.Drawing.Point(6, 66)
        Me.btnSupplierOrder.Name = "btnSupplierOrder"
        Me.btnSupplierOrder.Size = New System.Drawing.Size(88, 40)
        Me.btnSupplierOrder.TabIndex = 28
        Me.btnSupplierOrder.Text = "Supplier"
        Me.btnSupplierOrder.UseVisualStyleBackColor = True
        '
        'btnCustomerOrder
        '
        Me.btnCustomerOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomerOrder.Location = New System.Drawing.Point(6, 19)
        Me.btnCustomerOrder.Name = "btnCustomerOrder"
        Me.btnCustomerOrder.Size = New System.Drawing.Size(88, 40)
        Me.btnCustomerOrder.TabIndex = 27
        Me.btnCustomerOrder.Text = "Customer"
        Me.btnCustomerOrder.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(3, 127)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(127, 40)
        Me.btnReports.TabIndex = 28
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'gpReports
        '
        Me.gpReports.Controls.Add(Me.btnRepSupplier)
        Me.gpReports.Controls.Add(Me.btnRepRetailer)
        Me.gpReports.Controls.Add(Me.Button1)
        Me.gpReports.Controls.Add(Me.btnAccessRept)
        Me.gpReports.Location = New System.Drawing.Point(4, 173)
        Me.gpReports.Name = "gpReports"
        Me.gpReports.Size = New System.Drawing.Size(126, 189)
        Me.gpReports.TabIndex = 29
        Me.gpReports.TabStop = False
        Me.gpReports.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1363, 369)
        Me.Controls.Add(Me.gpReports)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.gpOrders)
        Me.Controls.Add(Me.gpPayments)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnSuppier)
        Me.Controls.Add(Me.btnRetailer)
        Me.Controls.Add(Me.btnCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Main"
        Me.TransparencyKey = System.Drawing.Color.Beige
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpPayments.ResumeLayout(False)
        Me.gpOrders.ResumeLayout(False)
        Me.gpReports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnRetailer As System.Windows.Forms.Button
    Friend WithEvents btnSuppier As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnTime As System.Windows.Forms.Button
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRepRetailer As System.Windows.Forms.Button
    Friend WithEvents btnRepSupplier As System.Windows.Forms.Button
    Friend WithEvents btnAccessRept As System.Windows.Forms.Button
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents gpPayments As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents gpOrders As System.Windows.Forms.GroupBox
    Friend WithEvents btnRetailerOrder As System.Windows.Forms.Button
    Friend WithEvents btnSupplierOrder As System.Windows.Forms.Button
    Friend WithEvents btnCustomerOrder As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents gpReports As System.Windows.Forms.GroupBox
End Class
