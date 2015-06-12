Public Class frmInventory
    Dim dsBook, dsStationary As DataSet
    Dim Desc As String = "Add to Inventory"
    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        getID()
    End Sub
    Sub getID()
        If cmbType.Text = "Stationary" Then
            txtAuthor1.Enabled = False
            otxtAuthor2.Enabled = False
            txtISBN.Enabled = False
            txtPublisher.Enabled = False
            lblBook.Text = "Description"
            txtItemNo.Text = getNewOtherID("STS1", "STS")
        ElseIf cmbType.Text = "Book" Then
            txtItemNo.Text = getNewOtherID("BKS1", "BKS")
        End If
    End Sub
    Sub clearText()
        Dim emptyText As Boolean = False
        For Each con In Me.Controls
            If con.Name.ToString.Substring(0, 3) = "txt" Then
                con.text = ""
            End If
        Next
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
    Function getNewOtherID(ByVal init As String, ByVal condition As String) As String
        Dim ds As New DataSet
        ConnectDB("BookShop")
        ds = getData("MAX(ItemNo) AS ItemNo", "Inventory WHERE ItemNo LIKE '" + condition + "%'")
        Try
            Return generateCode(ds.Tables(0).Rows(0).Item("ItemNo").ToString)
        Catch
            Return init
        End Try
    End Function
    Function generateCode(ByVal code As String) As String
        Dim str As String
        Dim integ As Integer = Integer.Parse(code.Substring(3, code.Length - 3))
        str = code.Substring(0, 3)
        Return str & (Integer.Parse(integ) + 1)
    End Function
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearText()
        getID()
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Sub refreshData()
        Try
            dsBook.Reset()
        Catch ex As Exception

        End Try
        dsBook = getData("*", "Books")
        dsStationary = getData("*", "Stationaries")
        dgvBooks.DataSource = dsBook.Tables(0)
        dgvStationary.DataSource = dsStationary.Tables(0)
        dgvBooks.Refresh()
        dgvStationary.Refresh()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If checkText() Then
        Else
            If cmdEdit.Enabled = False Then
                If cmbType.Text = "Edit Book" Then
                    updateData("Books", "Book='" + txtBook.Text + "',ISBN='" + txtISBN.Text + "',Author1='" + txtAuthor1.Text + "',Author2='" + otxtAuthor2.Text + "',Publisher='" + txtPublisher.Text + quote, "ItemNo='" + txtItemNo.Text + "'")
                    updateData("Inventory", "UnitPrice='" + txtUnitPrice.Text + "'", "ItemNo='" + txtItemNo.Text + "'")
                ElseIf cmbType.Text = "Edit Stationary" Then
                    updateData("Stationary", "Description='" + txtBook.Text + quote, "ItemNo='" + txtItemNo.Text + "'")
                    updateData("Inventory", "UnitPrice='" + txtUnitPrice.Text + "'", "ItemNo='" + txtItemNo.Text + "'")
                End If
                setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + Desc + quote)
                Desc = "Add to Inventory"
                refreshData()
                cmdEdit.Enabled = True
            Else
                If cmbType.Text = "Book" Then
                    setData("Inventory", quote + txtItemNo.Text + commawithquote + txtUnitPrice.Text + commawithquote + "0" + quote)
                    setData("Book", quote + txtItemNo.Text + commawithquote + txtBook.Text + commawithquote + txtISBN.Text + commawithquote + txtAuthor1.Text + commawithquote + otxtAuthor2.Text + commawithquote + txtPublisher.Text + quote)
                ElseIf cmbType.Text = "Stationary" Then
                    setData("Inventory", quote + txtItemNo.Text + commawithquote + txtUnitPrice.Text + commawithquote + "0" + quote)
                    setData("Stationary", quote + txtItemNo.Text + commawithquote + txtBook.Text + quote)
                End If
                setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + Desc + quote)
                MsgBox("Successfully Added.")
                refreshData()
            End If

        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        cmdEdit.Enabled = False
        cmdSave.Text = "Save"
        Desc = "Edit Inventory"
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Desc = "Delete from Inventory"
        'delData("", "CustomerID='" + txtCustomerID.Text + "'")
        setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + Desc + quote)
        refreshData()
        Desc = "Add to Inventory"
    End Sub

    Private Sub frmInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        refreshData()
    End Sub

    Private Sub txtUnitPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgvStationary_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStationary.CellDoubleClick
        If cmdEdit.Enabled = False Then
            txtItemNo.Text = dgvStationary.Item(0, e.RowIndex).Value
            txtBook.Text = dgvStationary.Item(1, e.RowIndex).Value
            txtUnitPrice.Text = dgvStationary.Item(2, e.RowIndex).Value
            cmbType.Text = "Edit Stationary"
            txtISBN.Text = ""
            txtISBN.Enabled = False
            txtAuthor1.Text = ""
            txtAuthor1.Enabled = False
            otxtAuthor2.Text = ""
            otxtAuthor2.Enabled = False
            txtPublisher.Text = ""
            txtPublisher.Enabled = False
        End If
    End Sub

    Private Sub dgvBooks_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBooks.CellDoubleClick
        If cmdEdit.Enabled = False Then
            txtItemNo.Text = dgvBooks.Item(0, e.RowIndex).Value
            txtBook.Text = dgvBooks.Item(1, e.RowIndex).Value
            txtUnitPrice.Text = dgvBooks.Item(2, e.RowIndex).Value
            txtISBN.Text = dgvBooks.Item(3, e.RowIndex).Value
            txtAuthor1.Text = dgvBooks.Item(4, e.RowIndex).Value
            otxtAuthor2.Text = dgvBooks.Item(5, e.RowIndex).Value
            txtPublisher.Text = dgvBooks.Item(6, e.RowIndex).Value
            cmbType.Text = "Edit Book"
        End If
    End Sub

End Class