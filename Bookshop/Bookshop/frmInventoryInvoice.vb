Public Class frmInventoryInvoice

    Dim xpos As Integer = 0


    Private Sub cmbCustomerName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSupplierName.SelectedIndexChanged
        Dim ds As DataSet
        ds = getData("SupplierID", "Supplier WHERE CompanyName LIKE '%" + Trim(cmbSupplierName.Text) + "%'")
        txtSupplierID.Text = ds.Tables(0).Rows(0).Item(0).ToString
    End Sub


    Private Sub cmbCustomerName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSupplierName.TextChanged
        Dim ds As DataSet
        ds = getData("SupplierID,CompanyName", "Supplier WHERE CompanyName LIKE '%" + Trim(cmbSupplierName.Text) + "%'")
        Try
            For Each row In ds.Tables(0).Rows
                If Not cmbSupplierName.Items.Contains(row.Item(1).ToString) Then
                    cmbSupplierName.Items.Add(row.Item(1).ToString)
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
        ds = getData("MAX(InvoiceNo) AS InvoiceNo", "Invoice WHERE InvoiceNo LIKE 'INS%'")
        Try
            txtInvoiceNo.Text = generateCode(ds.Tables(0).Rows(0).Item(0).ToString)
        Catch
            txtInvoiceNo.Text = "INS1"
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
        If btnEdit.Enabled = False Then

            updateData("SInvoice", "Quantity='" + txtQuantity.Text + "'", "InvoiceNo='" + txtInvoiceNo.Text + "' AND ItemNo='" + txtItemNo.Text + "'")
            MsgBox("Successfully Updated")
            If chkOrder.Checked Then
                setData("Supplies", quote + txtSupplierID.Text + commawithquote + txtItemNo.Text + commawithquote + txtQuantity.Text + commawithquote + txtDate.Text + commawithquote + txtTotal.Text + quote)
                updateData("Inventory", "Quantity='" + Format(getInventory(txtItemNo.Text) + txtQuantity.Text) + "'", "ItemNo='" + txtItemNo.Text + "'")
            End If
            btnEdit.Enabled = True
            cmdAdd.Text = "Add"
        Else
            setData("Invoice", quote + txtInvoiceNo.Text + commawithquote + FormatDateTime(txtDate.Text, DateFormat.ShortDate) + commawithquote + txtDiscount.Text + commawithquote + txtTotalCost.Text + quote)
            setData("SInvoice", quote + txtInvoiceNo.Text + commawithquote + txtSupplierID.Text + commawithquote + Trim(txtItemNo.Text) + commawithquote + txtQuantity.Text + quote)
            If chkOrder.Checked Then
                setData("Supplies", quote + txtSupplierID.Text + commawithquote + txtItemNo.Text + commawithquote + txtQuantity.Text + commawithquote + txtDate.Text + commawithquote + txtTotal.Text + quote)
                updateData("Inventory", "Quantity='" + Format(getInventory(txtItemNo.Text) + txtQuantity.Text) + "'", "ItemNo='" + txtItemNo.Text + "'")
            End If
        End If
        setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + "Add Customer Orders" + quote)

        refreshGrid()
        updateTotal()
        clearText()
    End Sub
    Sub refreshGrid()
        Dim ds As DataSet
        ds = getData("ItemNo,Description,UnitPrice,Quantity", "SupplierInvoice WHERE InvoiceNo='" + txtInvoiceNo.Text + "'")
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
        ds = getData("SUM(UnitPrice*Quantity*(1-Discount)) as TotalCost", "SupplierInvoice WHERE SupplierID='" + txtSupplierID.Text + "' AND InvoiceNo='" + txtInvoiceNo.Text + "'")
        Dim dstr As String
        dstr = ds.Tables(0).Rows(0).Item(0).ToString
        If dstr = "" Then dstr = "0"
        txtTotalCost.Text = Math.Round(CDbl(dstr), 2)
    End Sub
    Sub updateDisc()
        Dim ds As DataSet
        ds = getData("Discount", "SupplierInvoice WHERE SupplierID='" + txtSupplierID.Text + "' AND InvoiceNo='" + txtInvoiceNo.Text + "'")
        txtDiscount.Text = ds.Tables(0).Rows(0).Item(0).ToString
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
    Sub calTotal()
        If txtQuantity.Text <> "" Then
            txtTotal.Text = Single.Parse(txtUnitPrice.Text) * Integer.Parse(txtQuantity.Text) * (1 - Double.Parse(txtDiscount.Text))
        End If
    End Sub
    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        calTotal()
    End Sub
    Function checkText() As Boolean
        Dim emptyText As Boolean = False
        For Each con In Me.Controls
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
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkText() Then Exit Sub
        updateData("Invoice", "Total='" + txtTotalCost.Text + "'", "InvoiceNo='" + txtInvoiceNo.Text + "'")
        setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + "Supplier Orders" + quote)

        MsgBox("Successfully saved")

    End Sub

    Private Sub chkPaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOrder.CheckedChanged

    End Sub

    Private Sub dgvCustomerOrders_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomerOrders.CellClick
        xpos = e.RowIndex
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
        updateData("Inventory", "Quantity='" + Format(getInventory(txtItemNo.Text) - txtQuantity.Text) + "'", "ItemNo='" + txtItemNo.Text + "'")

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        delData("SInvoice", "InvoiceNo='" + txtInvoiceNo.Text + "'")
        delData("Invoice", "InvoiceNo='" + txtInvoiceNo.Text + "'")
        setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + "Delete Sup Invoice" + quote)
        Try
            refreshGrid()
        Catch ex As Exception
        End Try
        MsgBox("Successfully deleted.")
    End Sub
    Sub getSupplier()
        Dim ds As DataSet
        ds = getData("*", "SupplierInvoice WHERE InvoiceNo='" + txtInvoiceNo.Text + "'")
        txtSupplierID.Text = ds.Tables(0).Rows(0).Item(7)
        cmbSupplierName.Text = ds.Tables(0).Rows(0).Item(8)
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            refreshGrid()
            getSupplier()
            updateTotal()
            updateDisc()
        Catch ex As Exception
            MsgBox("Entry not found")
        End Try

    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If txtQuantity.Text.Length <> 9 Then
                If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
            If txtDiscount.Text.Length = 10 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        If txtDiscount.Text <> "" Then
            calTotal()
        End If
    End Sub
End Class