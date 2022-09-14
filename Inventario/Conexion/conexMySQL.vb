Imports MySql.Data.MySqlClient
Module conexMySQL
    Dim con As String = "server=localhost;Port=3306;database=ejemplobdvisual; user id=root;password=;"
    'conex = "server=inventario-ue.mysql.database.azure.com; Port=3306;database=inventario-ue; user id=studentsAD@inventario-ue;password=estudiantesAE.;"
    Public MysqlConex As MySqlConnection = New MySqlConnection(con)
    Private command As New MySqlCommand
    Private result As String
    Private adapter As MySqlDataAdapter
    Private daTable As DataTable
    Sub openConn()
        Try
            If MysqlConex.State = 0 Then
                MysqlConex.Open()
                MsgBox("Hay conexión")
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            MsgBox("Error conexión")
        End Try
    End Sub
    Sub closeConn()
        MysqlConex.Close()

    End Sub
    Public Sub createRegister(query As String)
        Try
            openConn()
            With command
                .Connection = MysqlConex
                .CommandText = query
                result = command.ExecuteNonQuery
                Console.WriteLine(result)
                If result > 0 Then
                    MsgBox("Succes")
                Else
                    MsgBox("Not Succes")
                End If
            End With
        Catch ex As Exception
            Console.WriteLine("Se ha producido un error:{0}", ex)
        End Try

    End Sub
    Public Sub consultaData(ByVal query As String, ByVal data As Object)
        Try
            daTable = New DataTable
            adapter = New MySqlDataAdapter
            openConn()
            With command
                .Connection = MysqlConex
                .CommandText = query
            End With
            adapter.SelectCommand = command
            adapter.Fill(daTable)
            data.datasource = daTable

        Catch ex As Exception
            Console.WriteLine("Se ha producido un error:${0}", ex)

        End Try
        closeConn()
        daTable.Dispose()
    End Sub
End Module
