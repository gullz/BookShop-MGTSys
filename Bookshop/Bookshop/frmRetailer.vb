Public Class frmRetailer
    Dim contID, Desc As String

    Function getNewOtherID(ByVal init As String, ByVal table As String) As String
        Dim ds As New DataSet
        ConnectDB("BookShop")
        ds = getData("MAX(" + table + "ID) AS ID", table)
        Try
            Return generateCode(ds.Tables(0).Rows(0).Item("ID").ToString)
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
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not checkText() Then
            Desc = "Add"
            contID = getNewOtherID("CON1", "Contact")
            setData("Contact", quote + contID + commawithquote + txtName.Text + commawithquote + txtNIC.Text + commawithquote + txtDesignation.Text + commawithquote + txtEmail.Text + commawithquote + txtFaxNo.Text + commawithquote + txtContactNo.Text + quote)
            setData("Retailer", quote + txtCompanyName.Text + commawithquote + "" + commawithquote + txtRetailerID.Text + commawithquote + txtNo.Text + commawithquote + txtStreet.Text + commawithquote + _
                    otxtCity1.Text + commawithquote + txtCity2.Text + commawithquote + contID + "'")
            setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + Desc + quote)
            MsgBox("Successfully added.")
        End If
        updateDGV()
    End Sub
    Sub clearText()
        Dim emptyText As Boolean = False
        For Each con In Me.Controls
            If con.Name.ToString.Substring(0, 3) = "txt" Then
                con.text = ""
            End If
        Next
        For Each con In Me.GroupBox1.Controls
            If con.Name.ToString.Substring(0, 3) = "txt" Then
                con.text = ""
            End If
        Next
        For Each con In Me.GroupBox2.Controls
            If con.Name.ToString.Substring(0, 3) = "txt" Then
                con.text = ""
            End If
        Next
    End Sub
    Private Sub frmRetailer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtRetailerID.Text = getNewOtherID("RET1", "Retailer")
        updateDGV()
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
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearText()
        txtRetailerID.Text = getNewOtherID("RET1", "Retailer")
    End Sub
    Sub updateDGV()
        Dim ds As DataSet
        ds = getData("*", "RetailerFull")
        dgvRetailer.DataSource = ds.Tables(0)
        dgvRetailer.Refresh()
    End Sub
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
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

    Private Sub txtFaxNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFaxNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If txtFaxNo.Text.Length = 10 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNIC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNIC.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If txtNIC.Text.Length <> 9 Then
                If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
            If txtNIC.Text.Length = 10 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class