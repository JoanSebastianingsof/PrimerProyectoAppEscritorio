Public Class Escritorio
    Private Sub Opcion1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Opcion1ToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Dim forRegistro As New Registro
        forRegistro.MdiParent = Me
        forRegistro.Show()
    End Sub

    Private Sub Escritorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class