Imports System.Data.SqlClient

Public Class frmPayments
    Dim optionSave As String = ""
    Sub alignForm()
        Me.Width = 815 '614
        Label1.Visible = True
        txtDate.Text = FormatDateTime(Now, DateFormat.ShortDate)
    End Sub
    Sub dealignForm()
        Me.Width = 615
        Label1.Visible = False
    End Sub
    Private Sub rdbRetailer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbRetailer.CheckedChanged
        Dim ds1, ds2 As New DataSet
        Dim dVal As Double
        Dim dt As New DataTable
        ds1 = getData("*", "Receivable")
        ds2 = getData("*", "ReceivedRec")
        dt.Columns.Add("Retailer ID")
        dt.Columns.Add("Retailer Name")
        dt.Columns.Add("Receivables")
        If rdbRetailer.Checked Then
            For Each row In ds1.Tables(0).Rows
                Try
                    dVal = row.item(2).ToString
                    For Each row2 In ds2.Tables(0).Rows
                        If row.item(0).ToString = row2.item(0).ToString Then
                            dVal = row.item(2) - row2.item(2)
                        End If
                    Next
                Catch ex As Exception

                End Try
                dt.Rows.Add(row.item(0), row.item(1), dVal)
            Next
            dgvDisplay.DataSource = dt
            dgvDisplay.Refresh()
            lblID.Text = "Retailer ID"
            optionSave = "Ret"
        End If
        dealignForm()
    End Sub

    Private Sub rdbSupplier_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbSupplier.CheckedChanged
        Dim ds1, ds2 As New DataSet
        Dim dVal As Double
        Dim dt As New DataTable
        ds1 = getData("*", "Payable")
        ds2 = getData("*", "PaidPayables")
        dt.Columns.Add("Supplier ID")
        dt.Columns.Add("Supplier Name")
        dt.Columns.Add("Payables")
        If rdbSupplier.Checked Then
            For Each row In ds1.Tables(0).Rows
                Try
                    dVal = row.item(2).ToString
                    For Each row2 In ds2.Tables(0).Rows
                        If row.item(0).ToString = row2.item(0).ToString Then
                            dVal = row.item(2) - row2.item(2)
                        End If
                    Next
                Catch ex As Exception

                End Try
                dt.Rows.Add(row.item(0), row.item(1), dVal)
            Next
            dgvDisplay.DataSource = dt
            dgvDisplay.Refresh()
            lblID.Text = "Supplier ID"
            optionSave = "Sup"
        End If
        dealignForm()
    End Sub
    Sub refreshGridRet()
        Dim ds1, ds2 As New DataSet
        Dim dVal As Double
        Dim dt As New DataTable
        ds1 = getData("*", "Receivable")
        ds2 = getData("*", "ReceivedRec")
        dt.Columns.Add("Retailer ID")
        dt.Columns.Add("Retailer Name")
        dt.Columns.Add("Receivables")
        If rdbRetailer.Checked Then
            For Each row In ds1.Tables(0).Rows
                Try
                    dVal = row.item(2).ToString
                    For Each row2 In ds2.Tables(0).Rows
                        If row.item(0).ToString = row2.item(0).ToString Then
                            dVal = row.item(2) - row2.item(2)
                        End If
                    Next
                Catch ex As Exception

                End Try
                dt.Rows.Add(row.item(0), row.item(1), dVal)
            Next
            dgvDisplay.DataSource = dt
            dgvDisplay.Refresh()
            lblID.Text = "Retailer ID"
            optionSave = "Ret"
        End If
        dealignForm()
    End Sub
    Sub refreshGridSup()
        Dim ds1, ds2 As New DataSet
        Dim dVal As Double
        Dim dt As New DataTable
        ds1 = getData("*", "Payable")
        ds2 = getData("*", "PaidPayables")
        dt.Columns.Add("Supplier ID")
        dt.Columns.Add("Supplier Name")
        dt.Columns.Add("Payables")
        If rdbSupplier.Checked Then
            For Each row In ds1.Tables(0).Rows
                Try
                    dVal = row.item(2).ToString
                    For Each row2 In ds2.Tables(0).Rows
                        If row.item(0).ToString = row2.item(0).ToString Then
                            dVal = row.item(2) - row2.item(2)
                        End If
                    Next
                Catch ex As Exception

                End Try
                dt.Rows.Add(row.item(0), row.item(1), dVal)
            Next
            dgvDisplay.DataSource = dt
            dgvDisplay.Refresh()
            lblID.Text = "Supplier ID"
            optionSave = "Sup"
        End If
        dealignForm()
    End Sub
    Private Sub dgvDisplay_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDisplay.CellClick
        Try
            txtID.Text = dgvDisplay.Item(0, e.RowIndex).Value
            txtShopName.Text = dgvDisplay.Item(1, e.RowIndex).Value
        Catch ex As Exception
            MsgBox("No data filled.")
        End Try
        alignForm()
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        clearText()
    End Sub
    Sub clearText()
        For Each txtObject In Me.Controls
            If txtObject.name.ToString.Contains("txt") Then
                If txtObject.name.ToString <> "txtID" Then
                    txtObject.text = ""
                End If
            End If
        Next
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
            MsgBox("Mandatory fields are empty")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnPayNow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPayNow.Click
        If Not checkText() Then
            If optionSave = "Ret" Then
                Try
                    setData("CheqPayments", quote + txtChequeNo.Text + commawithquote + txtChequeAcc.Text + commawithquote + txtBank.Text + commawithquote + txtAmount.Text + commawithquote + FormatDateTime(txtDate.Text, DateFormat.ShortDate) + quote)
                    Try
                        setData("PaidRet", quote + txtID.Text + commawithquote + txtChequeNo.Text + commawithquote + FormatDateTime(Now, DateFormat.ShortDate) + quote)
                        MsgBox("Successfully Paid.")
                        refreshGridRet()
                        clearText()
                    Catch ex As Exception
                        MsgBox("Invalid Retailer")
                    End Try
                Catch ex As Exception
                    MsgBox("Error in cheque details.")
                End Try
            End If
            If optionSave = "Sup" Then
                Try
                    setData("CheqPayments", quote + txtChequeNo.Text + commawithquote + txtChequeAcc.Text + commawithquote + txtBank.Text + commawithquote + txtAmount.Text + commawithquote + FormatDateTime(txtDate.Text, DateFormat.ShortDate) + quote)
                    Try
                        setData("PaidSup", quote + txtID.Text + commawithquote + txtChequeNo.Text + commawithquote + FormatDateTime(Now, DateFormat.ShortDate) + quote)
                        MsgBox("Successfully Paid.")
                        refreshGridSup()
                        clearText()
                    Catch ex As Exception
                        MsgBox("Invalid Supplier")
                    End Try
                Catch ex As Exception
                    MsgBox("Error in cheque details.")
                End Try
            End If
        End If
    End Sub
End Class