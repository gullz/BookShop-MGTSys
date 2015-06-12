Public Class frmCustomerOrders

    Dim paid As String = "Unpaid"
    Dim xpos As Integer = 0

    Private Sub cmbCustomerName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCustomerName.SelectedIndexChanged
        Dim ds As DataSet
        ds = getData("CustomerID", "Customer WHERE Name LIKE '%" + Trim(cmbCustomerName.Text) + "%'")
        txtCustomerID.Text = ds.Tables(0).Rows(0).Item(0).ToString
    End Sub


    Private Sub cmbCustomerName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCustomerName.TextChanged
        Dim ds As DataSet
        ds = getData("CustomerID,Name", "Customer WHERE Name LIKE '%" + Trim(cmbCustomerName.Text) + "%'")
        Try
            For Each row In ds.Tables(0).Rows
                If Not cmbCustomerName.Items.Contains(row.Item(1).ToString) Then
                    cmbCustomerName.Items.Add(row.Item(1).ToString)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProduct.SelectedIndexChanged
        Dim ds As DataSet
        If chkStationary.Checked = False Then
            ds = getData("ItemNo,UnitPrice", "Books WHERE Book LIKE '%" + Trim(cmbProduct.Text) + "%'")
            txtItemNo.Text = ds.Tables(0).Rows(0).Item(0).ToString
            txtUnitPrice.Text = ds.Tables(0).Rows(0).Item(1).ToString
        Else
            ds = getData("ItemNo,UnitPrice", "Stationaries WHERE Description LIKE '%" + Trim(cmbProduct.Text) + "%'")
            txtItemNo.Text = ds.Tables(0).Rows(0).Item(0).ToString
            txtUnitPrice.Text = ds.Tables(0).Rows(0).Item(1).ToString
        End If
    End Sub

    Private Sub cmbProduct_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProduct.TextChanged
        Dim ds As DataSet
        If chkStationary.Checked = False Then
            ds = getData("Book", "Books WHERE Book LIKE '%" + Trim(cmbProduct.Text) + "%'")
            Try
                For Each row In ds.Tables(0).Rows
                    If Not cmbProduct.Items.Contains(row.Item(0).ToString) Then
                        cmbProduct.Items.Add(row.Item(0).ToString)
                    End If
                Next
            Catch ex As Exception
            End Try
        Else
            ds = getData("Description", "Stationaries WHERE Description LIKE '%" + Trim(cmbProduct.Text) + "%'")
            Try
                For Each row In ds.Tables(0).Rows
                    If Not cmbProduct.Items.Contains(row.Item(0).ToString) Then
                        cmbProduct.Items.Add(row.Item(0).ToString)
                    End If
                Next
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub chkStationary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStationary.CheckedChanged
        If chkStationary.Checked = True Then
            lblProduct.Text = "Stationary"
            gpOrder.Text = "Stationaries"
            cmbProduct.Items.Clear()
        Else
            lblProduct.Text = "Book"
            gpOrder.Text = "Book Details"
            cmbProduct.Items.Clear()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Sub getNewOtherID()
        Dim ds As New DataSet
        ConnectDB("BookShop")
        ds = getData("MAX(OrderNo) AS OrderNo", "cOrder")
        Try
            txtOrderID.Text = generateCode(ds.Tables(0).Rows(0).Item(0).ToString)
        Catch
            txtOrderID.Text = "ORD1"
        End Try
    End Sub
    Function generateCode(ByVal code As String) As String
        Dim str As String
        Dim integ As Integer = Integer.Parse(code.Substring(3, code.Length - 3))
        str = code.Substring(0, 3)
        Return str & (Integer.Parse(integ) + 1)
    End Function
    Sub clearText()
        Dim emptyText As Boolean = False
        For Each con In Me.gpOrder.Controls
            If con.Name.ToString.Substring(0, 3) = "txt" Then
                con.text = ""
            End If
        Next
        cmbProduct.Text = ""
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearText()
    End Sub

    Private Sub frmCustomerOrders_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clearText()
        getNewOtherID()
        txtDate.Text = FormatDateTime(Now, DateFormat.ShortDate)
    End Sub
    Function checkTextGRP() As Boolean
        Dim emptyText As Boolean = False
        For Each con In Me.gpOrder.Controls
            If con.Name.ToString.Substring(0, 3) = "txt" Then
                If con.Text = "" Then
                    emptyText = True
                End If
            End If
        Next
        If emptyText Then
            MsgBox("Mandatory fields are empty.")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If checkTextGRP() Then Return
        If getInventory(txtItemNo.Text) >= txtQuantity.Text Then
            If btnEdit.Enabled = False Then

                updateData("Consists", "Quantity='" + txtQuantity.Text + "'", "OrderNo='" + txtOrderID.Text + "' AND ItemNo='" + txtItemNo.Text + "'")
                MsgBox("Successfully Updated")
                updateData("Inventory", "Quantity='" + Format(getInventory(txtItemNo.Text) - txtQuantity.Text) + "'", "ItemNo='" + txtItemNo.Text + "'")

                btnEdit.Enabled = True
                cmdAdd.Text = "Add"
            Else
                setData("cOrder", quote + txtOrderID.Text + commawithquote + txtDate.Text + commawithquote + txtTotalCost.Text + quote)
                setData("CMOrder", "'" + txtCustomerID.Text + commawithquote + txtOrderID.Text + commawithquote + "" + quote)
                setData("Consists", quote + txtOrderID.Text + commawithquote + txtItemNo.Text + commawithquote + txtQuantity.Text + quote)
                updateData("Inventory", "Quantity='" + Format(getInventory(txtItemNo.Text) - txtQuantity.Text) + "'", "ItemNo='" + txtItemNo.Text + "'")
            End If
            setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + "Add Customer Orders" + quote)

            refreshGrid()
            updateTotal()
            clearText()
        Else
            MsgBox("Not Enough Inventory, Maximum availability is " + Format(getInventory(txtItemNo.Text)))
        End If
    End Sub
    Sub refreshGrid()
        Dim ds As DataSet
        ds = getData("ItemNo,Description,UnitPrice,Quantity", "CustomerOrders WHERE OrderNo='" + txtOrderID.Text + "'")
        dgvCustomerOrders.DataSource = ds.Tables(0)
        dgvCustomerOrders.Refresh()
    End Sub
    Function getInventory(ByVal arg As String) As Integer
        Dim ds As DataSet
        ds = getData("Quantity", "Inventory WHERE ItemNo='" + arg + "'")
        Return ds.Tables(0).Rows(0).Item(0).ToString
    End Function
    Sub updateTotal()
        Dim ds As DataSet
        ds = getData("SUM(UnitPrice*Quantity) as TotalCost", "CustomerOrders WHERE CustomerID='" + txtCustomerID.Text + "' AND OrderNo='" + txtOrderID.Text + "'")
        Dim dstr As String
        dstr = ds.Tables(0).Rows(0).Item(0).ToString
        If dstr = "" Then dstr = "0"
        txtTotalCost.Text = Math.Round(CDbl(dstr), 2)
    End Sub
    Sub getDate()

    End Sub
    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If txtQuantity.Text.Length <> 9 Then
                If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
            If txtQuantity.Text.Length = 10 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        If txtQuantity.Text <> "" Then
            txtTotal.Text = Single.Parse(txtUnitPrice.Text) * Integer.Parse(txtQuantity.Text)
        End If
    End Sub
    Function checkText() As Boolean
        Dim emptyText As Boolean = False
        For Each con In Me.Controls
            If con.Name.ToString.Substring(0, 3) = "txt" Then
                If con.enabled = True Then
                    If con.Text = "" Then
                        emptyText = True
                    End If
                End If
            End If
        Next
        If emptyText Then
            MsgBox("Mandatory fields are empty")
            Return True
        Else
            Return False
        End If
    End Function
    Sub getCusBill()
        Dim supplierRep As New reptCusBill, strsupid As String, ds As DataSet
        strsupid = txtOrderID.Text
        ds = getData("*", "CusBill WHERE OrderNo='" + strsupid + "'")
        supplierRep.SetDataSource(ds.Tables(0))
        frmSimpleReport.rvSimple.ReportSource = supplierRep
        frmSimpleReport.rvSimple.DisplayGroupTree = False
        frmSimpleReport.Text = "Billing"
        frmSimpleReport.Show()
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not checktext Then
            updateData("cOrder", "Price='" + txtTotalCost.Text + "'", "OrderNo='" + txtOrderID.Text + "'")
            updateData("CMOrder", "Status='" + paid + "'", "OrderNo='" + txtOrderID.Text + "' AND OrderNo='" + txtOrderID.Text + "'")
            setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + "Customer Orders" + quote)

            MsgBox("Successfully saved")
        End If
        getCusBill()
    End Sub

    Private Sub chkPaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPaid.CheckedChanged
        If chkPaid.Checked = True Then
            paid = "Paid"
        Else
            paid = "Unpaid"
        End If
    End Sub

    Private Sub dgvCustomerOrders_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomerOrders.CellClick
        xpos = e.RowIndex
    End Sub

    Private Sub dgvCustomerOrders_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCustomerOrders.SelectionChanged

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Enabled = False Then
        Else
            btnEdit.Enabled = False
        End If
        cmdAdd.Text = "Save"
        txtItemNo.Text = dgvCustomerOrders.Rows(xpos).Cells(0).Value
        cmbProduct.Text = dgvCustomerOrders.Rows(xpos).Cells(1).Value
        txtUnitPrice.Text = dgvCustomerOrders.Rows(xpos).Cells(2).Value
        txtQuantity.Text = dgvCustomerOrders.Rows(xpos).Cells(3).Value
        updateData("Inventory", "Quantity='" + Format(txtQuantity.Text + getInventory(txtItemNo.Text)) + "'", "ItemNo='" + txtItemNo.Text + "'")

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        delData("Consists", "OrderNo='" + txtOrderID.Text + "'")
        delData("CMOrder", "OrderNo='" + txtOrderID.Text + "'")
        delData("cOrder", "OrderNo='" + txtOrderID.Text + "'")
        setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + "Delete Cust Orders" + quote)

        MsgBox("Successfully deleted.")
    End Sub
    Sub getCustomer()
        Dim ds As DataSet
        ds = getData("*", "CustomOrders WHERE OrderNo='" + txtOrderID.Text + "'")
        txtCustomerID.Text = ds.Tables(0).Rows(0).Item(0)
        cmbCustomerName.Text = ds.Tables(0).Rows(0).Item(1)
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        refreshGrid()
        getCustomer()
        updateTotal()
    End Sub

End Class