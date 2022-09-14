Public Class Registro
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblProducto.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblCategoria.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtProducto.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim query As String = "INSERT INTO productos VALUES(null,'"
        query += TxtProducto.Text & "','"
        query += TxtStock.Text & "','"
        query += cboTipo.SelectedIndex + 1 & "');"
        Console.WriteLine(query)
        createRegister(query)
        closeConn()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtProducto.Text = ""
        TxtStock.Text = ""
        cboTipo.Text = 0
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Try
            Dim query As String = "SELECT id, nombreProducto,categoria,stock FROM productos"
            consultaData(query, DataGridView1)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        TxtProducto.Text = DataGridView1.CurrentRow.Cells(1).Value
        TxtStock.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub
End Class