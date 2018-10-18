Imports MySql.Data.MySqlClient
Public Class frmlogin
    Dim myDBConnect As Dbconnect = New Dbconnect
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If txtpassword.Text = String.Empty Then
                MessageBox.Show("Username and Password are required!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                myDBConnect.openConnect()
                Dim sqlString As String = "SELECT * FROM tblemployees WHERE names = '" & cbemployee.SelectedItem.ToString & "' AND password='" & txtpassword.Text & "'"
                Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
                Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

                Dim password As String = ""

                While sqlReader.Read
                    password = sqlReader!password
                End While
                sqlReader.Close()
                sqlCmd.Dispose()
                sqlReader.Dispose()

                If txtpassword.Text = password Then
                    MessageBox.Show("Welcome user: " & cbemployee.SelectedItem.ToString, Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    frmmain.Show()
                Else
                    MessageBox.Show("Username or Password is incorrect!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Dim sqlString As String = "SELECT names FROM tblemployees"
            Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            cbemployee.Items.Clear()
            cbemployee.Items.Add("---Select---")
            cbemployee.SelectedIndex = 0
            While (sqlReader.Read())
                cbemployee.Items.Add(sqlReader("names"))
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
        lblstatus.Text = "Select Employee names"
    End Sub

    Private Sub txtpassword_MouseHover(sender As Object, e As EventArgs) Handles txtpassword.MouseHover
        lblstatus.Text = "Input employee password"
    End Sub
    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        lblstatus.Text = "Select Employee names"
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        lblstatus.Text = "Input employee password"
    End Sub

    Private Sub cbemployee_MouseLeave(sender As Object, e As EventArgs) Handles cbemployee.MouseLeave
        lblstatus.Text = "Amber and Ambrose Ent."
    End Sub

    Private Sub txtpassword_MouseLeave(sender As Object, e As EventArgs) Handles txtpassword.MouseLeave
        lblstatus.Text = "Amber and Ambrose Ent."
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        lblstatus.Text = "Amber and Ambrose Ent."
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        lblstatus.Text = "Amber and Ambrose Ent."
    End Sub
End Class
