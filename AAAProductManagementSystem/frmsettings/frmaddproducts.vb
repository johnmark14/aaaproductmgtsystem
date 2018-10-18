Imports MySql.Data.MySqlClient
Public Class frmaddproducts
    Dim myDbConnect As New Dbconnect
    Dim id As String = ""
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtcode.Text <> String.Empty And txtsku.Text <> String.Empty And txtqty.Text <> String.Empty And txtprice.Text <> String.Empty Then
            Try
                myDbConnect.openConnect()
                Dim sqlString As String = "INSERT INTO tblproducts (id, sku, price, stocks) VALUES ('" _
                    & txtcode.Text & "','" _
                    & txtsku.Text & "','" _
                    & txtprice.Text & "','" _
                    & txtqty.Text & "')"
                Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                sqlCmd.ExecuteNonQuery()
                sqlCmd.Dispose()
                MessageBox.Show("1 record successfully saved!", "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                myDbConnect.closeConnect()
                fillListview()
                btncancel.PerformClick()
                GC.Collect()
            End Try
        Else
            MessageBox.Show("Missing required Information!", "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub fillListview()
        Try
            myDbConnect.openConnect()
            Dim sqlstring As String = "SELECT * FROM tblproducts"
            Dim sqlCmd As New MySqlCommand(sqlstring, myDbConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            lvproductsinfo.Items.Clear()
            While (sqlReader.Read())
                With lvproductsinfo.Items.Add(sqlReader("id"))
                    .Subitems.add(sqlReader("sku"))
                    .Subitems.add(sqlReader("price"))
                    .Subitems.add(sqlReader("stocks"))
                End With
            End While
            sqlCmd.Dispose()
            sqlReader.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            GC.Collect()
        End Try
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

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            myDbConnect.openConnect()
            Dim sqlstring As String = "SELECT * FROM tblproducts where id like '%" & txtsearch.Text & "%'"
            Dim sqlCmd As New MySqlCommand(sqlstring, myDbConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            lvproductsinfo.Items.Clear()
            While (sqlReader.Read())
                With lvproductsinfo.Items.Add(sqlReader("id"))
                    .Subitems.add(sqlReader("sku"))
                    .Subitems.add(sqlReader("price"))
                    .Subitems.add(sqlReader("stocks"))
                End With
            End While
            sqlCmd.Dispose()
            sqlReader.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDbConnect.closeConnect()
            GC.Collect()
        End Try
    End Sub

    Private Sub frmaddproducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillListview()
    End Sub

    Private Sub lvproductsinfo_DoubleClick(sender As Object, e As EventArgs) Handles lvproductsinfo.DoubleClick
        Dim item As ListViewItem
        For Each item In lvproductsinfo.SelectedItems
            id = lvproductsinfo.Items(item.Index).SubItems(0).Text
            txtcode.Text = lvproductsinfo.Items(item.Index).SubItems(0).Text
            txtsku.Text = lvproductsinfo.Items(item.Index).SubItems(1).Text
            txtprice.Text = lvproductsinfo.Items(item.Index).SubItems(2).Text
            txtqty.Text = lvproductsinfo.Items(item.Index).SubItems(3).Text
        Next
        btnadd.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtcode.Text <> String.Empty And txtsku.Text <> String.Empty And txtqty.Text <> String.Empty And txtprice.Text <> String.Empty Then
            Try
                myDbConnect.openConnect()
                Dim sqlString As String = "UPDATE tblproducts SET id='" & txtcode.Text & "', sku='" & txtsku.Text & "', price='" & txtprice.Text & "', stocks='" & txtqty.Text & "' WHERE(id='" & id & "')"
                Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                sqlCmd.ExecuteNonQuery()
                sqlCmd.Dispose()
                MessageBox.Show("1 record successfully Updated!", "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                myDbConnect.closeConnect()
                fillListview()
                btncancel.PerformClick()
                GC.Collect()
            End Try
        Else
            MessageBox.Show("Missing required Information!", "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged
        If txtcode.Text <> id Then btndelete.Enabled = False
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete item " & id & "?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                myDbConnect.openConnect()
                Dim sqlString As String = "DELETE FROM tblproducts WHERE (id='" & id & "')"
                Dim sqlCmd As New MySqlCommand(sqlString, myDbConnect.mySqlConString)
                sqlCmd.ExecuteNonQuery()
                sqlCmd.Dispose()
                MessageBox.Show("1 record successfully Deleted!", "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Add Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                myDbConnect.closeConnect()
                fillListview()
                btncancel.PerformClick()
                GC.Collect()
            End Try
        Else
            btncancel.PerformClick()
        End If
    End Sub


End Class