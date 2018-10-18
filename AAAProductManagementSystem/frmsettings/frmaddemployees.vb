Imports MySql.Data.MySqlClient
Public Class frmaddemployees
    Dim myDbConnect As New Dbconnect
    Dim id As String

    Private Sub fillview()
        Try
            myDbConnect.openConnect()
            Dim sqlstring As String = "SELECT * FROM tblemployees"
            Dim sqlCmd As New MySqlCommand(sqlstring, myDbConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            lvaddempinfo.Items.Clear()
            While (sqlReader.Read())
                lvaddempinfo.Items.Add(sqlReader("names"))
            End While
            sqlCmd.Dispose()
            sqlReader.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            GC.Collect()
        End Try
    End Sub

    Private Sub frmaddemployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillview()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtempname.Text <> String.Empty And txtpassword.Text <> String.Empty Then
            If txtcpassword.Text <> String.Empty Then
                If txtpassword.Text = txtcpassword.Text Then
                    Try
                        myDbConnect.openConnect()
                        Dim sqlString As String = "INSERT INTO tblemployees (names, password) VALUES ('" & txtempname.Text & "','" & txtcpassword.Text & "')"
                        Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                        sqlCmd.ExecuteNonQuery()
                        sqlCmd.Dispose()

                        MessageBox.Show("New Employee added!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        myDbConnect.closeConnect()
                        fillview()
                        btncancel.PerformClick()
                        GC.Collect()
                    End Try
                Else
                    MessageBox.Show("Password did not match!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Confirm your password to continue!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Missing required information", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim ctl As Control
        For Each ctl In Me.GroupBox1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = String.Empty
        Next
        btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub lvaddempinfo_DoubleClick(sender As Object, e As EventArgs) Handles lvaddempinfo.DoubleClick
        Dim item As ListViewItem
        For Each item In lvaddempinfo.SelectedItems
            txtempname.Text = lvaddempinfo.Items(item.Index).SubItems(0).Text
        Next

        Try
            myDbConnect.openConnect()
            Dim sqlString As String = "SELECT * FROM tblemployees where names ='" & txtempname.Text & "'"
            Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader
            sqlReader = sqlCmd.ExecuteReader

            While sqlReader.Read
                id = sqlReader!id
                txtpassword.Text = sqlReader!password
                txtcpassword.Text = sqlReader!password
            End While

            sqlCmd.Dispose()
            sqlReader.Close()
            sqlReader.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            GC.Collect()
        End Try

        btnadd.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtempname.Text <> String.Empty And txtpassword.Text <> String.Empty Then
            If txtcpassword.Text <> String.Empty Then
                If txtpassword.Text = txtcpassword.Text Then
                    Try
                        myDbConnect.openConnect()
                        Dim sqlString As String = "UPDATE tblemployees set names='" & txtempname.Text & "', password='" & txtcpassword.Text & "' WHERE(id='" & id & "')"
                        Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                        sqlCmd.ExecuteNonQuery()
                        sqlCmd.Dispose()

                        MessageBox.Show("1 Employee Updated!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        myDbConnect.closeConnect()
                        fillview()
                        btncancel.PerformClick()
                        GC.Collect()
                    End Try
                Else
                    MessageBox.Show("Password did not match!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Confirm your password to continue!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Missing required information", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete Employee " & txtempname.Text & "?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                myDbConnect.openConnect()
                Dim sqlString As String = "DELETE FROM tblemployees WHERE (id='" & id & "')"
                Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                sqlCmd.ExecuteNonQuery()
                sqlCmd.Dispose()
                MessageBox.Show("1 record successfully Deleted!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                myDbConnect.closeConnect()
                fillview()
                btncancel.PerformClick()
                GC.Collect()
            End Try
        Else
            btncancel.PerformClick()
        End If
    End Sub
End Class