Public Class frmloadiomenu
    Private Sub btnloadin_Click(sender As Object, e As EventArgs) Handles btnloadin.Click
        frmloadin.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmloadin.ShowDialog()
    End Sub

    Private Sub frmloadiomenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmmain.fillListview()
    End Sub
End Class