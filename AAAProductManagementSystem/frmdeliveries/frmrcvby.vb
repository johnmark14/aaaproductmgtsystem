﻿Imports MySql.Data.MySqlClient
Public Class frmrcvby
    Dim myDbConnect As Dbconnect = New Dbconnect

    Private Sub btnrcv_Click(sender As Object, e As EventArgs) Handles btnrcv.Click
        Try
            If txtpassword.Text = String.Empty Then
                MessageBox.Show("Select Recieved And Password!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                myDbConnect.openConnect()
                Dim sqlString As String = "SELECT * FROM tblemployees WHERE names = '" & cbrcv.SelectedItem.ToString & "' AND password='" & txtpassword.Text & "'"
                Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

                Dim password As String = ""

                While sqlReader.Read
                    password = sqlReader!password
                End While
                sqlReader.Close()
                sqlReader.Dispose()
                sqlCmd.Dispose()

                If txtpassword.Text = password Then
                    Dim item As ListViewItem
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

                    Next

                    MessageBox.Show(frmdeliveries.lblcount.Text & " Items added to the database", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim sqlString As String = "SELECT names FROM tblemployees"
            Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            While (sqlReader.Read())
                cbrcv.Items.Add(sqlReader("names"))
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