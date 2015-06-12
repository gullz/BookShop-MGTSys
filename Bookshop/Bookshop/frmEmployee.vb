Public Class frmEmployee
    Dim edit As Boolean = False
    Dim checkImage As Boolean = False
    Dim photo As Image
    Dim bm As Bitmap
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
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
    Sub clearText()
        Dim emptyText As Boolean = False
        For Each con In Me.Controls
            If con.Name.ToString.Substring(0, 3) = "txt" Then
                con.text = ""
            End If
        Next
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim gend As String
        If rbFemale.Checked Then
            gend = rbFemale.Text
        Else
            gend = "Male"
        End If

        If checkText() Then
            Exit Sub
        Else
            Try
                photo = pbPhoto.Image
                photo.Save(Trim(txtNIC.Text) + ".jpg")
            Catch ex As Exception
                MsgBox("Empty photo. Insert a photo.")
                Exit Sub
            End Try

            ConnectDB("BookShop")
            If edit Then
                updateData("Employee", "Name='" + txtName.Text + "',ContactNo='" + txtContactNo.Text + "',Gender='" + gend + "',NIC='" + txtNIC.Text + "',Address='" + txtAddress.Text + "',DOB='" + FormatDateTime(dtpDOB.Value, DateFormat.ShortDate) + "'", "EmpNo='" + txtEmpNo.Text + "'")
                setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + "Edit Employee" + quote)
                edit = False
                btnEdit.Enabled = True
                btnAdd.Text = "Add"
                MsgBox("Successfully saved.")
            Else
                setData("Employee", quote + txtEmpNo.Text + commawithquote + "User" + commawithquote + txtName.Text + commawithquote + FormatDateTime(dtpDOB.Value, DateFormat.ShortDate) + commawithquote + txtAddress.Text + commawithquote + _
                                    txtNIC.Text + commawithquote + gend + commawithquote + txtContactNo.Text + commawithquote + "" + quote)
                setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + "Add Employee" + quote)
                MsgBox("Entry successfully saved.")
            End If


        End If
    End Sub
    Sub getNewOtherID()
        Dim ds As New DataSet
        ConnectDB("BookShop")
        ds = getData("MAX(EmpNo) AS EmpNo", "Employee")
        Try
            txtEmpNo.Text = generateCode(ds.Tables(0).Rows(0).Item(0).ToString)
        Catch
            txtEmpNo.Text = "EMP1"
        End Try
    End Sub
    Function generateCode(ByVal code As String) As String
        Dim str As String
        Dim integ As Integer = Integer.Parse(code.Substring(3, code.Length - 3))
        str = code.Substring(0, 3)
        Return str & (Integer.Parse(integ) + 1)
    End Function
    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getNewOtherID()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim ds As DataSet
        edit = True
        If edit Then
            btnAdd.Text = "Save"
            btnEdit.Enabled = False
        End If

        ds = getData("*", "Employee WHERE EmpNo='" + txtEmpNo.Text + "'")
        Try
            txtAddress.Text = ds.Tables(0).Rows(0).Item("Address").ToString()
            txtContactNo.Text = ds.Tables(0).Rows(0).Item("ContactNo").ToString()
            dtpDOB.Text = ds.Tables(0).Rows(0).Item("DOB").ToString()
            txtNIC.Text = ds.Tables(0).Rows(0).Item("NIC")
            If Trim(ds.Tables(0).Rows(0).Item("Gender").ToString()) = "Male" Then
                rbMale.Checked = True
                rbFemale.Checked = False
            Else
                rbMale.Checked = False
                rbFemale.Checked = True
            End If
            txtName.Text = ds.Tables(0).Rows(0).Item("Name").ToString()
            loadImage(Trim(txtNIC.Text))
        Catch ex As Exception
            MsgBox("Person not found.")
            edit = False
            btnEdit.Enabled = True
        End Try
    End Sub

    Sub loadImage(ByVal name As String)

        If System.IO.File.Exists(name + ".jpg") Then
            photo = Image.FromFile(name + ".jpg")
        ElseIf System.IO.File.Exists(name + ".png") Then
            photo = Image.FromFile(name + ".png")
        ElseIf System.IO.File.Exists(name + ".bmp") Then
            photo = Image.FromFile(name + ".bmp")
        Else
            photo = Nothing
        End If
        bm = New Bitmap(photo)
        pbPhoto.Image = bm
        photo.Dispose()
    End Sub

    Private Sub btnPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoto.Click
        If OFDlg.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            photo = Image.FromFile(OFDlg.FileName)
            bm = New Bitmap(photo)
            pbPhoto.Image = bm
            photo.Dispose()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        clearText()
        getNewOtherID()
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

    Private Sub txtNIC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNIC.TextChanged

    End Sub
End Class