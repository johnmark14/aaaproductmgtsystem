Imports MySql.Data.MySqlClient
Public Class frmadmincredentials
    Dim myDbConnect As New Dbconnect
    Private Function isEmpty() As Boolean
        Dim empty = From txt In Me.Controls.OfType(Of TextBox)()
                    Where txt.Text = String.Empty
                    Select txt.Name

        If empty.Any Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Not isEmpty() Then
            If txtpassword.Text = txtcpassword.Text Then
                frmaddemployees.saveEmployee()
                frmaddemployees.saveAsAdmin(txtusername.Text, txtpassword.Text)
                btncancel.PerformClick()
                Me.Close()
            Else
                MessageBox.Show("Password did not match!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Missing required information!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = String.Empty
        Next
    End Sub
End Class