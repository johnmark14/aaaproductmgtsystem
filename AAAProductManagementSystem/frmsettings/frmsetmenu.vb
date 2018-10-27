﻿Public Class frmsetmenu
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        stlabel.Text = "Add New Employee, Edit Employees information"
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        stlabel.Text = "Amber and Ambrose Ent."
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        stlabel.Text = "Add New Products, Edit Products Information"
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        stlabel.Text = "Amber and Ambrose Ent."
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs)
        stlabel.Text = "Add Roles to Employees"
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs)
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