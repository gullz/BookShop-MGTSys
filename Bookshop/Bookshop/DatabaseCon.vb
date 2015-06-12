Imports System.Data.SqlClient

Module DatabaseCon
    Dim con As SqlConnection
    Dim b As Boolean = False
    Dim cmd As New SqlCommand
    Public quote As String = "'"
    Public commawithquote As String = "','"
    Dim adapter As New SqlDataAdapter()
    Public login As String
    Public Sub ConnectDB(ByVal name As String)
        b = True
        con = New SqlConnection("Data Source=Bhathiya-PC\SQLExpress;Initial Catalog=" + name + ";Integrated Security=True")
        con.Open()
    End Sub
    Public Sub CloseDB()
        cmd.Cancel()
        If (b) Then
            con.Close()
            b = False
        End If
    End Sub
    Public Function getData(ByVal table As String) As SqlDataReader
        'Try
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM " + table + ";"
        'MsgBox(cmd.CommandText)
        Return cmd.ExecuteReader()
        'Catch ex As Exception
        'Return Nothing
        'End Try
    End Function
    Public Function getData(ByVal attributes As String, ByVal condition As String) As DataSet
        Try
            Dim ds As DataSet
            ds = New DataSet()
            cmd.Connection = con
            cmd.CommandText = "SELECT " + attributes + " FROM " + condition + ";"
            Debug.Print(cmd.CommandText)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(ds)
            Return ds
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function delData(ByVal table As String, ByVal key As String) As Integer
        Try
            cmd.CommandText = "DELETE FROM " + table + " WHERE " + key + ";"
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Sub setData(ByVal table As String, ByVal values As String)
        Try
            cmd.CommandText = "INSERT INTO " + table + " VALUES(" + values + ");"
            Debug.Print(cmd.CommandText)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.Print(ex.Message)
            Return
        End Try
    End Sub
    Public Function updateData(ByVal table As String, ByVal values As String, ByVal key As String) As Integer
        Try
            cmd.CommandText = "UPDATE " + table + " SET " + values + " WHERE " + key + ";"
            Debug.Print(cmd.CommandText)
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Return -1
        End Try
    End Function
    Public Function getConStatus() As Boolean
        Return con.ToString <> ""
    End Function
End Module
