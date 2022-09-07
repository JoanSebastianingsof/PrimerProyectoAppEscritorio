Imports MySql.Data.MySqlClient
Module ConexMySQL
    Dim con As String = "server=localhost;Port=3306;database=ejemplobdvisual;user id=root;password=;"
    Public MysqlConex As MySqlConnection = New MySqlConnection(con)
    Sub openConn()
        MsgBox("Entre")
        MsgBox("Entre")
        Try
            If MysqlConex.State = 0 Then

                MysqlConex.Open()
                MsgBox("Hay conexion")
            End If
        Catch ex As Exception
            MsgBox("Error conexion")
            Console.WriteLine(ex)


        End Try

    End Sub
    Sub closeConn()
        mysqlConex.Close()
    End Sub
End Module
