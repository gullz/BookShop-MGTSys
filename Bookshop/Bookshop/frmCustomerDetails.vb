Public Class frmCustomerDetails
    Dim dsCustomers As DataSet
    Dim Desc As String = "Add Customer"
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
    Sub clearText()
        Dim emptyText As Boolean = False
        For Each con In Me.Controls
            If con.Name.ToString.Substring(0, 3) = "txt" Then
                con.text = ""
            End If
        Next
    End Sub
    Sub getNewOtherID()
        Dim ds As New DataSet
        ConnectDB("BookShop")
        ds = getData("MAX(CustomerID) AS EmpNo", "Customer")
        Try
            txtCustomerID.Text = generateCode(ds.Tables(0).Rows(0).Item(0).ToString)
        Catch
            txtCustomerID.Text = "CUID1"
        End Try
    End Sub
    Function generateCode(ByVal code As String) As String
        Dim str As String
        Dim integ As Integer = Integer.Parse(code.Substring(4, code.Length - 4))
        str = code.Substring(0, 4)
        Return str & (Integer.Parse(integ) + 1)
    End Function
    Private Sub frmCustomerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getNewOtherID()
        refreshData()
    End Sub
    Sub refreshData()
        Try
            dsCustomers.Reset()
        Catch ex As Exception

        End Try

        dsCustomers = getData("*", "Customer")
        dgvCustomer.DataSource = dsCustomers.Tables(0)
        dgvCustomer.Refresh()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If checkText() Then
        Else
            If cmdEdit.Enabled = False Then
                updateData("Customer", "ContactNo='" + txtContactNo.Text + "',Address='" + txtAddress.Text + "',Name='" + txtName.Text + "'", "CustomerID='" + txtCustomerID.Text + "'")
                setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + Desc + quote)
                Desc = "Add Customer"
                refreshData()
                cmdEdit.Enabled = True
                dgvCustomer.Enabled = False
            Else
                setData("Customer", quote + txtCustomerID.Text + commawithquote + txtContactNo.Text + commawithquote + txtAddress.Text + commawithquote + txtName.Text + quote)
                setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + Desc + quote)
                refreshData()
            End If

        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub dgvCustomer_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellClick
        txtCustomerID.Text = dgvCustomer.Item(0, e.RowIndex).Value
        txtContactNo.Text = dgvCustomer.Item(1, e.RowIndex).Value
        txtAddress.Text = dgvCustomer.Item(2, e.RowIndex).Value
        txtName.Text = dgvCustomer.Item(3, e.RowIndex).Value
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        dgvCustomer.Enabled = True
        cmdEdit.Enabled = False
        cmdSave.Text = "Save"
        Desc = "Edit Customer"
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Desc = "Delete Customer"
        delData("Customer", "CustomerID='" + txtCustomerID.Text + "'")
        setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + Desc + quote)
        refreshData()
        Desc = "Add Customer"
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearText()
    End Sub

    Private Sub txtContactNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If txtContactNo.Text.Length = 10 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtContactNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContactNo.TextChanged

    End Sub
End Class