Imports System.Data.SqlClient

Public Class frmLogin
    Dim sqlrdrData As SqlDataReader
    Dim boolLog = False
    Dim users(100) As String
    Dim passwords(100) As String
    Dim levels(100) As String
    Dim i As Integer

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim mainForm As Form
        Dim strl As String = ""
        For j = 0 To i - 1
            If Trim(passwords(j)) = Trim(txtPassword.Text) And Trim(users(j)) = Trim(cmbUser.Text) Then
                boolLog = True
                strl = levels(j)
            End If
        Next
        mainForm = New frmMain()
        If boolLog = True Then
            If Trim(strl) = "User" Then
                mainForm.Controls("btnAddUser").Enabled = False
                mainForm.Controls("btnEmployee").Enabled = False
            End If

            login = cmbUser.Text
            mainForm.Show()
            Me.Hide()
            boolLog = False
        Else
            MsgBox("Enter a valid password.")
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Public Sub loadData()
        ConnectDB("Bookshop")
        sqlrdrData = getData("Employee")
        i = 0
        cmbUser.Items.Clear()
        While (sqlrdrData.Read())
            cmbUser.Items.Add(sqlrdrData.GetValue(5).ToString())
            passwords(i) = sqlrdrData.GetValue(8).ToString()
            levels(i) = sqlrdrData.GetValue(1).ToString
            users(i) = sqlrdrData.GetValue(5).ToString
            i = i + 1
        End While
        sqlrdrData.Close()
    End Sub
End Class