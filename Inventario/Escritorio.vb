Public Class Escritorio
    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Dim forRegistro As New Registro
        forRegistro.MdiParent = Me
        forRegistro.Show()
    End Sub
End Class