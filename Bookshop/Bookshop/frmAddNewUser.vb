Public Class frmAddNewUser

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        cbUserID.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim rslt As Integer
        If txtPassword.Text <> "" And cbUserID.Text <> "" Then
            rslt = updateData("Employee", "Password='" & txtPassword.Text & "',Level='" & cbLevel.Text & "'", "NIC='" & Trim(cbUserID.Text) & "'")
            setData("Access", quote + login + commawithquote + FormatDateTime(Now, DateFormat.GeneralDate) + commawithquote + "Add User" + quote)

        Else
            MsgBox("Incomplete data.")
            rslt = -1
        End If
        If rslt <> -1 Then
            MsgBox("Your system login is successfully created.")
        End If
        Me.Close()
    End Sub

    Private Sub frmAddNewUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CloseDB()
    End Sub

    Private Sub frmAddNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlr As SqlClient.SqlDataReader
        ConnectDB("Bookshop")
        sqlr = getData("Employee")
        While (sqlr.Read)
            cbUserID.Items.Add(sqlr.Item(5).ToString)
        End While
        sqlr.Close()
    End Sub
End Class