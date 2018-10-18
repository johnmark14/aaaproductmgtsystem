Public Class frmsetmenu
    Private Sub btnaddemployee_MouseHover(sender As Object, e As EventArgs) Handles btnaddemployee.MouseHover
        stlabel.Text = "Add New Employee, Edit Employees information"
    End Sub

    Private Sub btnaddemployee_MouseLeave(sender As Object, e As EventArgs) Handles btnaddemployee.MouseLeave
        stlabel.Text = "Amber and Ambrose Ent."
    End Sub

    Private Sub btnaddproducts_MouseHover(sender As Object, e As EventArgs) Handles btnaddproducts.MouseHover
        stlabel.Text = "Add New Products, Edit Products Information"
    End Sub

    Private Sub btnaddproducts_MouseLeave(sender As Object, e As EventArgs) Handles btnaddproducts.MouseLeave
        stlabel.Text = "Amber and Ambrose Ent."
    End Sub

    Private Sub btnaddemployee_Click(sender As Object, e As EventArgs) Handles btnaddemployee.Click
        frmaddemployees.ShowDialog()
    End Sub

    Private Sub btnaddproducts_Click(sender As Object, e As EventArgs) Handles btnaddproducts.Click
        frmaddproducts.ShowDialog()
    End Sub

    Private Sub frmsetmenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmmain.fillListview()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        btnaddproducts.Focus()
        btnaddproducts.PerformClick()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        btnaddemployee.Focus()
        btnaddemployee.PerformClick()
    End Sub

End Class