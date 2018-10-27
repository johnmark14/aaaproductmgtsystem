Imports MySql.Data.MySqlClient
Public Class frmlogin
    Private myDBConnect As Dbconnect = New Dbconnect

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If txtusername.Text = String.Empty Or txtpassword.Text = String.Empty Then
                MessageBox.Show("Username and Password are required!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                myDBConnect.openConnect()
                Dim sqlString As String = "SELECT id FROM tblemployees WHERE firstname = '" & cbemployee.SelectedItem.ToString & "'"
                Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
                Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

                Dim employee As String = ""
                While sqlReader.Read
                    employee = sqlReader("id")
                End While
                sqlReader.Close()
                sqlCmd.Dispose()
                sqlReader.Dispose()

                Dim sqlString1 As String = "SELECT username, password FROM tbladmin WHERE employees_id ='" & employee & "'"
                Dim sqlCmd1 As New MySqlCommand(sqlString1, myDBConnect.mySqlConString)
                Dim sqlReader1 As MySqlDataReader = sqlCmd1.ExecuteReader

                Dim username As String = ""
                Dim password As String = ""
                While sqlReader1.Read
                    username = sqlReader1("username")
                    password = sqlReader1("password")
                End While
                sqlReader1.Close()
                sqlCmd1.Dispose()
                sqlReader1.Dispose()

                If txtusername.Text = username And txtpassword.Text = password Then
                    MessageBox.Show("Welcome user: " & cbemployee.SelectedItem.ToString, Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    frmmain.Show()
                Else
                    MessageBox.Show("Username or Password is incorrect for this employee!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDBConnect.closeConnect()
            btncancel.PerformClick()
            GC.Collect()
        End Try
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbemployee_Add()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        cbemployee.SelectedIndex = 0
        cbemployee.Focus()
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub frmlogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("You're not login yet! This will cause the program to close!", Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            frmmain.Close()
        ElseIf result = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Public Sub cbemployee_Add()
        Try
            myDBConnect.openConnect()
            Dim sqlString As String = "SELECT tblemployees.firstname FROM tbladmin JOIN tblemployees ON tbladmin.employees_id = tblemployees.id"
            Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            cbemployee.Items.Clear()
            cbemployee.Items.Add("---Select---")
            cbemployee.SelectedIndex = 0
            While (sqlReader.Read())
                cbemployee.Items.Add(sqlReader("firstname"))
            End While
            sqlCmd.Dispose()
            sqlReader.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDBConnect.closeConnect()
            GC.Collect()
        End Try
    End Sub

    Private Sub cbemployee_MouseHover(sender As Object, e As EventArgs) Handles cbemployee.MouseHover
        mouseHL("names")
    End Sub

    Private Sub txtusername_MouseHover(sender As Object, e As EventArgs) Handles txtusername.MouseHover
        mouseHL("username")
    End Sub
    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        mouseHL()
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        mouseHL("username")
    End Sub

    Private Sub txtpassword_MouseHover(sender As Object, e As EventArgs) Handles txtpassword.MouseHover
        mouseHL("password")
    End Sub
    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        mouseHL("names")
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        mouseHL("password")
    End Sub

    Private Sub cbemployee_MouseLeave(sender As Object, e As EventArgs) Handles cbemployee.MouseLeave
        mouseHL()
    End Sub
    Private Sub txtusername_MouseLeave(sender As Object, e As EventArgs) Handles txtusername.MouseLeave
        mouseHL()
    End Sub

    Private Sub txtpassword_MouseLeave(sender As Object, e As EventArgs) Handles txtpassword.MouseLeave
        mouseHL()
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        mouseHL()
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        mouseHL()
    End Sub

    Private Sub mouseHL(ByVal m As String)
        lblstatus.Text = "Input employee " & m
    End Sub

    Private Sub mouseHL()
        lblstatus.Text = "Amber and Ambrose Ent."
    End Sub


End Class
