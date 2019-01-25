
Imports MySql.Data.MySqlClient
Public Class LoginForm
    Private connect As New MysqlConnect
    Dim reader As MySqlDataReader


    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim query As String
        query = "select * from et.user where userID='" & userTxt.Text & "' and password='" & passTxt.Text & "' "
        connect.execquery(query)

    End Sub
End Class
