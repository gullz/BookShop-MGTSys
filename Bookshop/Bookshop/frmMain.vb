Public Class frmMain
    Dim drag As Boolean = False
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If vbYes = MsgBox("Do you want to exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) Then
            End
        Else
            Return
        End If
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        frmLogin.loadData()
        Me.Close()
        frmLogin.Show()
    End Sub
    Sub hideAllSubButtons()
        For Each sbtn In Me.Controls
            If sbtn.Name.ToString.Substring(0, 3) = "sbt" Then
                sbtn.visible = False
            End If
        Next
    End Sub
    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        frmCustomerDetails.Show()
    End Sub

    Private Sub btnRetailer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetailer.Click
        frmRetailer.Show()
    End Sub

    Private Sub btnSuppier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuppier.Click
        frmSupplier.Show()
    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        frmEmployee.Show()
    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        frmAddNewUser.Show()
    End Sub

    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        btnTime.Text = FormatDateTime(Now, DateFormat.GeneralDate)
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblLogin.Text = login
    End Sub


    Private Sub btnRepSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepSupplier.Click
        Dim supplierRep As New reptSupplier, strsupid As String, ds As DataSet
        strsupid = InputBox("Enter the supplier id")
        ds = getData("*", "Supplier INNER JOIN Contact ON Supplier.ContactID = Contact.ContactID WHERE SupplierID='" + strsupid + "'")
        supplierRep.SetDataSource(ds.Tables(0))
        frmSimpleReport.rvSimple.ReportSource = supplierRep
        frmSimpleReport.rvSimple.DisplayGroupTree = False
        frmSimpleReport.Text = "Supplier Details"
        frmSimpleReport.Show()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmInventory.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        If gpReports.Visible = True Then
            gpReports.Visible = False
            Me.Height = 170
        Else
            gpReports.Visible = True
            Me.Height = 365
        End If
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        frmPayments.Show()
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        If gpOrders.Visible = False Then
            gpOrders.Visible = True
            If Me.Height = 170 Then Me.Height = 290
        Else
            gpOrders.Visible = False
            If Me.Height = 290 And gpPayments.Visible = False Then Me.Height = 170
        End If
    End Sub

    Private Sub btnCustomerOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerOrder.Click
        frmCustomerOrders.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplierOrder.Click
        frmInventoryInvoice.Show()
    End Sub

    Private Sub btnRetailerOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetailerOrder.Click
        frmRetailerInvoice.Show()
    End Sub

    Private Sub btnRepRetailer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepRetailer.Click
        Dim retailerRep As New reptRetailer, strsupid As String, ds As DataSet
        strsupid = InputBox("Enter the retailer id")
        ds = getData("*", "RetailerFull WHERE RetailerID='" + strsupid + "'")
        retailerRep.SetDataSource(ds.Tables(0))
        frmSimpleReport.rvSimple.ReportSource = retailerRep
        frmSimpleReport.rvSimple.DisplayGroupTree = False
        frmSimpleReport.Text = "Retailer Details"
        frmSimpleReport.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim InventoryRept As New ReptStockStatus
        frmSimpleReport.rvSimple.ReportSource = InventoryRept
        frmSimpleReport.rvSimple.DisplayGroupTree = False
        frmSimpleReport.Text = "Inventory Status Details"
        frmSimpleReport.Show()
    End Sub

    Private Sub btnAccessRept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccessRept.Click
        Dim accessdata As New reptAccessData, ds As DataSet
        ds = getData("*", "AccessData WHERE Month([Date Time]) =" + Month(Now).ToString + " AND YEAR([Date Time])=" + Year(Now).ToString)
        accessdata.SetDataSource(ds.Tables(0))
        frmSimpleReport.rvSimple.ReportSource = accessdata
        frmSimpleReport.rvSimple.DisplayGroupTree = False
        frmSimpleReport.Text = "Access Details of this Month"
        frmSimpleReport.Show()
    End Sub
End Class