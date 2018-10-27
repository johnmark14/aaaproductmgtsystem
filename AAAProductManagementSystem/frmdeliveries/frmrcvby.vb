Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel

Public Class frmrcvby
    Dim myDbConnect As Dbconnect = New Dbconnect

    Private Sub showWaitFlash(ByVal isShow As Boolean)
        If isShow Then
            label1.Visible = True
            label2.Visible = True
            label3.Visible = True

            cbrcv.Visible = True
            txtusername.Visible = True
            txtpassword.Visible = True
            btnrcv.Visible = True

            lblflash.Visible = False
        Else
            label1.Visible = False
            label2.Visible = False
            label3.Visible = False

            cbrcv.Visible = False
            txtusername.Visible = False
            txtpassword.Visible = False
            btnrcv.Visible = False

            lblflash.Visible = True
        End If
    End Sub

    Private Sub btnrcv_Click(sender As Object, e As EventArgs) Handles btnrcv.Click
        Try
            If txtpassword.Text = String.Empty Then
                MessageBox.Show("Select Recieved And Password!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                myDbConnect.openConnect()
                Dim sqlString As String = "SELECT id FROM tblemployees WHERE firstname = '" & cbrcv.SelectedItem.ToString & "'"
                Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

                Dim employee As String = ""
                While sqlReader.Read
                    employee = sqlReader("id")
                End While
                sqlReader.Close()
                sqlCmd.Dispose()
                sqlReader.Dispose()

                Dim sqlString1 As String = "SELECT username, password FROM tbladmin WHERE employees_id ='" & employee & "'"
                Dim sqlCmd1 As New MySqlCommand(sqlString1, myDbConnect.mySqlConString)
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

                    showWaitFlash(0)

                    Dim item As ListViewItem
                    Dim i As Integer = 6
                    Dim xl As New Microsoft.Office.Interop.Excel.Application
                    Dim wkb As Microsoft.Office.Interop.Excel.Workbook
                    Dim wks As Microsoft.Office.Interop.Excel.Worksheet
                    wkb = xl.Workbooks.Open(System.IO.Directory.GetCurrentDirectory & "\excel\deliveries\delivery.xlsx")
                    wks = wkb.Sheets.Item("Delivery")

                    For Each item In frmdeliveries.lvproductsinfo.Items


                        Dim pcode As String = frmdeliveries.lvproductsinfo.Items(item.Index).SubItems(0).Text
                        Dim pname As String = frmdeliveries.lvproductsinfo.Items(item.Index).SubItems(1).Text
                        Dim pprice As String = frmdeliveries.lvproductsinfo.Items(item.Index).SubItems(2).Text
                        Dim pqty As String = frmdeliveries.lvproductsinfo.Items(item.Index).SubItems(3).Text
                        Dim pdelivery As String = frmdeliveries.lvproductsinfo.Items(item.Index).SubItems(4).Text

                        Dim sqlStringSelect As String = "SELECT * FROM tblproducts WHERE id = '" & pcode & "'"
                        Dim sqlCmdSelect As New MySqlCommand(sqlStringSelect, myDbConnect.mySqlConString)
                        Dim sqlReaderSelect As MySqlDataReader = sqlCmdSelect.ExecuteReader

                        Dim pstocks As Integer = 0

                        While sqlReaderSelect.Read
                            pstocks = sqlReaderSelect!stocks
                        End While

                        Dim pqtyInt As Integer = 0

                        Integer.TryParse(pqty, pqtyInt)

                        pstocks = pstocks + pqtyInt

                        sqlReaderSelect.Close()
                        sqlReaderSelect.Dispose()
                        sqlCmdSelect.Dispose()

                        Dim sqlStringUpdate As String = "UPDATE tblproducts SET stocks='" & pstocks & "' WHERE(id='" & pcode & "')"
                        Dim sqlCmdUpdate As New MySqlCommand(sqlStringUpdate, myDbConnect.mySqlConString)
                        sqlCmdUpdate.ExecuteNonQuery()
                        sqlCmdUpdate.Dispose()

                        wks.Cells(i, 1) = pcode
                        wks.Cells(i, 2) = pname
                        wks.Cells(i, 3) = pqty
                        wks.Cells(i, 6) = cbrcv.SelectedItem.ToString
                        wks.Cells(i, 7) = Now.ToString("yyy:MM:dd hh:mm:ss")

                        i += 1

                    Next

                    showWaitFlash(1)

                    MessageBox.Show(frmdeliveries.lblcount.Text & " Items added to the database", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    xl.Visible = True
                    'wkb.PrintPreview()
                    wks = Nothing
                    wkb = Nothing
                    xl = Nothing
                    Me.Close()
                Else
                    MessageBox.Show("Incorrect password!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            GC.Collect()
        End Try
    End Sub

    Private Sub cbrcv_add()
        Try
            myDbConnect.openConnect()
            Dim sqlString As String = "SELECT tblemployees.firstname FROM tbladmin JOIN tblemployees ON tbladmin.employees_id = tblemployees.id"
            Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

            cbrcv.Items.Clear()
            cbrcv.Items.Add("---Select---")
            cbrcv.SelectedIndex = 0
            While (sqlReader.Read())
                cbrcv.Items.Add(sqlReader("firstname"))
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

    Private Sub frmrcvby_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbrcv_add()
        cbrcv.SelectedIndex = 0
    End Sub

    Private Sub controls_Reset()
        cbrcv.SelectedIndex = 0
        txtpassword.Clear()
    End Sub

    Private Sub frmrcvby_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        controls_Reset()
        frmdeliveries.lvproductsinfo_Reset()
    End Sub

    Private Sub btnrcv_Click_1(sender As Object, e As EventArgs) Handles btnrcv.Click

    End Sub
End Class