Imports MySql.Data.MySqlClient
Public Class frmupdateadmincredentials
    Private myDbConnect As New Dbconnect
    Private switch As Boolean = False

    Private Sub before()
        GroupBox2.Location = New Point(12, 201)
        btnsave.Location = New Point(133, 151)
        btncancel.Location = New Point(275, 151)
        GroupBox2.Enabled = False
        Me.Size = New Size(394, 258)
        btnsave.Text = "Ok"
    End Sub

    Private Sub after()
        GroupBox2.Location = New Point(12, 161)
        btnsave.Location = New Point(133, 360)
        btncancel.Location = New Point(275, 360)
        GroupBox2.Enabled = True
        Me.Size = New Size(394, 458)
        btnsave.Text = "Save"
    End Sub

    Private Sub frmupdateadmincredentials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
        before()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Not switch Then
            If Not isEmpty(0) Then

                Try
                    myDbConnect.openConnect()

                    Dim sqlString As String = "SELECT username, password FROM tbladmin WHERE employees_id ='" & frmaddemployees.getId() & "'"
                    Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                    Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

                    Dim username As String = ""
                    Dim password As String = ""
                    While sqlReader.Read
                        username = sqlReader("username")
                        password = sqlReader("password")
                    End While
                    sqlReader.Close()
                    sqlCmd.Dispose()
                    sqlReader.Dispose()

                    If txtusername.Text = username And txtpassword.Text = password Then
                        after()
                        GroupBox1.Enabled = False
                        txtnusername.Focus()
                        switch = True
                    Else
                        MessageBox.Show("Username or Password is incorrect for this employee!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    myDbConnect.closeConnect()
                    GC.Collect()
                End Try
            Else
                MessageBox.Show("Username and Password are required!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf Not isEmpty(1) Then
            If txtnpassword.Text = txtncpassword.Text Then
                frmaddemployees.updateEmployees(txtnusername.Text, txtnpassword.Text)
                btncancel.PerformClick()
                Me.Close()
            Else
                MessageBox.Show("Password did not match!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        before()
        GroupBox1.Enabled = True
        clearText()
        switch = False
        txtusername.Focus()
    End Sub

    Private Function isEmpty(ByVal param As Boolean) As Boolean
        Dim empty1 = From txt In Me.GroupBox1.Controls.OfType(Of TextBox)()
                     Where txt.Text = String.Empty
                     Select txt.Name

        Dim empty2 = From txt In Me.GroupBox2.Controls.OfType(Of TextBox)()
                     Where txt.Text = String.Empty
                     Select txt.Name

        If param Then
            If empty2.Any Then
                Return True
            Else
                Return False
            End If
        Else
            If empty1.Any Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub clearText()
        Dim ctl As Control
        For Each ctl In Me.GroupBox1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = String.Empty
        Next

        For Each ctl In Me.GroupBox2.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = String.Empty
        Next
    End Sub

    Private Sub frmupdateadmincredentials_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearText()
        GroupBox1.Enabled = True
    End Sub
End Class