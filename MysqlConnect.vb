
Imports MySql.Data.MySqlClient
Public Class MysqlConnect
    Dim mysqlconn As New MySqlConnection("server=localhost;userid=root;password=9071;database=et")
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Public Sub execquery(query As String)


        Try
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count += 1

            End While
            If count = 1 Then
                emsform.Show()
                LoginForm.Hide()
            ElseIf count > 1 Then
                MsgBox("dublicate found")
            Else
                MsgBox("notecorrect")
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message)

        Finally
            mysqlconn.Dispose()
        End Try
    End Sub
    Public Sub addtodatabase(query As String)
        Dim mysqlconn As New MySqlConnection("server=localhost;userid=root;password=9071;database=et")
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Try
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
        Catch ex As MySqlException
            MsgBox(ex.Message)

        Finally
            mysqlconn.Dispose()
        End Try
    End Sub
End Class
