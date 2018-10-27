Imports MySql.Data.MySqlClient
Public Class frmaddemployees
    Private myDbConnect As New Dbconnect
    Private id As String

    Private administrator As String = "Select tblemployees.id, tblemployees.firstname, tblemployees.lastname, tblemployees.address, tblemployees.contact, tblemployees.email from tbladmin JOIN tblemployees ON tbladmin.employees_id = tblemployees.id"
    Private salesman As String = "Select * from tblsalesman JOIN tblemployees ON tblsalesman.employees_id = tblemployees.id"

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If Not isEmpty() Then

            If cbrole.SelectedIndex = 0 Then
                frmadmincredentials.ShowDialog()
            ElseIf cbrole.SelectedIndex = 1 Then
                saveEmployee()
                saveAsSalesman()
            End If
        Else
            MessageBox.Show("Missing required information!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        clearText()
        btnSet(1)
        queryDecide()
    End Sub

    Private Sub fillView(ByVal query As String)
        Try
            myDbConnect.openConnect()
            Dim sqlString As String = query
            Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

            lvaddempinfo.Items.Clear()
            While sqlReader.Read
                With lvaddempinfo.Items.Add(sqlReader("id"))
                    .subitems.add(sqlReader("firstname"))
                    .subitems.add(sqlReader("lastname"))
                    .subitems.add(sqlReader("address"))
                    .subitems.add(sqlReader("contact"))
                    .subitems.add(sqlReader("email"))
                End With
            End While

            sqlReader.Close()
            sqlReader.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            GC.Collect()
        End Try
    End Sub

    Private Sub queryDecide()
        If cbrole.SelectedIndex = 0 Then
            clearText()
            btnSet(1)
            fillView(administrator)
        Else
            clearText()
            btnSet(1)
            fillView(salesman)
        End If
    End Sub

    Private Sub frmaddemployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbrole.SelectedIndex = 0
        btncancel.PerformClick()
    End Sub

    Private Sub lvaddempinfo_DoubleClick(sender As Object, e As EventArgs) Handles lvaddempinfo.DoubleClick
        Dim item As ListViewItem
        For Each item In lvaddempinfo.SelectedItems
            id = lvaddempinfo.Items(item.Index).SubItems(0).Text
            txtfirstname.Text = lvaddempinfo.Items(item.Index).SubItems(1).Text
            txtlastname.Text = lvaddempinfo.Items(item.Index).SubItems(2).Text
            txtaddress.Text = lvaddempinfo.Items(item.Index).SubItems(3).Text
            txtcontact.Text = lvaddempinfo.Items(item.Index).SubItems(4).Text
            txtemail.Text = lvaddempinfo.Items(item.Index).SubItems(5).Text
        Next

        btnSet(0)
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If Not isEmpty() Then
            If cbrole.SelectedIndex = 0 Then
                Dim result As DialogResult = MessageBox.Show("Would you like to update Username and Password for this employee?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = vbYes Then
                    frmupdateadmincredentials.ShowDialog()
                Else
                    updateEmployees()
                End If
            Else
                updateEmployees()
            End If
        Else
            MessageBox.Show("Missing required information!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function isEmpty() As Boolean
        Dim empty = From txt In Me.GroupBox1.Controls.OfType(Of TextBox)()
                    Where txt.Text = String.Empty
                    Select txt.Name

        If empty.Any Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If Not isEmpty() Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this employee ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If cbrole.SelectedIndex = 0 Then
                    Try
                        myDbConnect.openConnect()
                        Dim sqlString As String = "DELETE FROM tblemployees WHERE (id='" & id & "')"
                        Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                        sqlCmd.ExecuteNonQuery()
                        sqlCmd.Dispose()

                        MessageBox.Show("Employee successfully Deleted!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        myDbConnect.closeConnect()
                        btncancel.PerformClick()
                        GC.Collect()
                    End Try
                Else
                    Try
                        myDbConnect.openConnect()
                        Dim sqlString As String = "DELETE FROM tbladmin WHERE (id='" & id & "')"
                        Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                        sqlCmd.ExecuteNonQuery()
                        sqlCmd.Dispose()

                        MessageBox.Show("Employee successfully Deleted!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        myDbConnect.closeConnect()
                        btncancel.PerformClick()
                        GC.Collect()
                    End Try
                End If
            Else
                btncancel.PerformClick()
            End If
        End If
    End Sub

    Public Sub saveAsAdmin(ByVal username As String, ByVal password As String)
        Try
            myDbConnect.openConnect()
            Dim sqlString As String = "INSERT INTO tbladmin (username, password, employees_id) VALUES ('" & username & "','" & password & "','" & id & "')"
            Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()

            MessageBox.Show("New employee successfully added!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            btncancel.PerformClick()
            GC.Collect()
        End Try
    End Sub

    Public Sub saveAsSalesman()
        Try
            myDbConnect.openConnect()
            Dim sqlString As String = "INSERT INTO tblsalesman (employees_id) VALUES ('" & id & "')"
            Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()

            MessageBox.Show("New employee successfully added!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            btncancel.PerformClick()
            GC.Collect()
        End Try
    End Sub

    Private Sub cbrole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbrole.SelectedIndexChanged
        queryDecide()
    End Sub

    Public Sub saveEmployee()
        Try
            myDbConnect.openConnect()
            Dim sqlString As String = "INSERT INTO tblemployees (id, firstname, lastname, address, contact, email) VALUES ('" _
            & generateID() & "','" & txtfirstname.Text & "','" & txtlastname.Text & "','" & txtaddress.Text & "','" & txtcontact.Text & "','" & txtemail.Text & "')"
            Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            GC.Collect()
        End Try
    End Sub

    Private Sub updateEmployees()
        Try
            myDbConnect.openConnect()
            Dim sqlString As String = "UPDATE tblemployees SET firstname='" & txtfirstname.Text & "', lastname='" & txtlastname.Text & "', address='" & txtaddress.Text & "', contact='" & txtcontact.Text & "', email='" & txtemail.Text & "' WHERE(id='" & id & "')"
            Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()

            MessageBox.Show("Employee successfully Updated!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            btncancel.PerformClick()
            GC.Collect()
        End Try
    End Sub

    Public Sub updateEmployees(ByVal uname As String, ByVal upass As String)
        Try
            myDbConnect.openConnect()
            Dim sqlString As String = "UPDATE tblemployees SET firstname='" & txtfirstname.Text & "', lastname='" & txtlastname.Text & "', address='" & txtaddress.Text & "', contact='" & txtcontact.Text & "', email='" & txtemail.Text & "' WHERE(id='" & id & "')"
            Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()

            Dim sqlString1 As String = "SELECT id FROM tbladmin WHERE employees_id = '" & id & "'"
            Dim sqlCmd1 As New MySqlCommand(sqlString1, myDbConnect.mySqlConString)
            Dim sqlReader1 As MySqlDataReader = sqlCmd1.ExecuteReader

            Dim employee As String = ""
            While sqlReader1.Read
                employee = sqlReader1("id")
            End While
            sqlReader1.Close()
            sqlCmd1.Dispose()
            sqlReader1.Dispose()

            Dim sqlString2 As String = "UPDATE tbladmin SET username='" & uname & "', password='" & upass & "' WHERE(id='" & employee & "')"
            Dim sqlCmd2 As New MySqlCommand(sqlString2, myDbConnect.mySqlConString)
            sqlCmd2.ExecuteNonQuery()
            sqlCmd2.Dispose()


            MessageBox.Show("Employee successfully Updated!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            btncancel.PerformClick()
            GC.Collect()
        End Try
    End Sub

    Private Function generateID() As String
        Dim s As String = Now.ToString("yyMMddhhmmss")
        id = s
        Return s
    End Function

    Private Sub clearText()
        Dim ctl As Control
        For Each ctl In Me.GroupBox1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = String.Empty
        Next
    End Sub

    Private Sub btnSet(ByVal isSet As Boolean)
        If isSet Then
            btnadd.Enabled = True
            btnupdate.Enabled = False
            btndelete.Enabled = False
            Me.AcceptButton = btnadd
        Else
            btnadd.Enabled = False
            btnupdate.Enabled = True
            btndelete.Enabled = True
            Me.AcceptButton = btnupdate
        End If
    End Sub

    Private Sub frmaddemployees_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearText()
        btnSet(1)
    End Sub

    Public Function getId() As String
        Return id
    End Function
End Class