Imports MySql.Data.MySqlClient
Public Class frmdeliveries
    Dim myDbConnect As New Dbconnect
    Dim id As String
    Dim isEdit As Boolean = False
    Private Sub frmdeliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btncancel.PerformClick()
        lblcount.Text = 0
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        If isEdit Then
            Dim result As DialogResult = MessageBox.Show("The selected item will be remove from the list, are you sure you want to delete the selected item?", Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                isEdit = False
                btncancel.PerformClick()
            End If
        Else
            txtcode.Enabled = True
            txtcode.Focus()
            txtcode.Clear()
            txtcode.ReadOnly = False
            lblcode.Text = String.Empty
            lblprice.Text = String.Empty
            lblproduct.Text = String.Empty
            cbdelivery.Enabled = False
            txtqty.Text = 1
            txtqty.Enabled = False
            btnadd.Enabled = False
            txtqty.Text = 0
            lvproductsinfo.Enabled = True
        End If

        GC.Collect()
    End Sub

    Private Sub btnvalidate_Click(sender As Object, e As EventArgs) Handles btnvalidate.Click
        If txtcode.Text <> String.Empty Then
            Try
                myDbConnect.openConnect()
                Dim sqlstring As String = "SELECT * FROM tblproducts where id='" & txtcode.Text & "'"
                Dim sqlCmd As New MySqlCommand(sqlstring, myDbConnect.mySqlConString)
                Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

                While (sqlReader.Read())
                    lblcode.Text = sqlReader!id
                    lblproduct.Text = sqlReader!sku
                    lblprice.Text = sqlReader!price
                End While
                sqlCmd.Dispose()
                sqlReader.Dispose()

                If lblcode.Text <> String.Empty And lblcode.Text <> "Unavailable item!" Then
                    txtcode.ReadOnly = True
                    cbdelivery.Enabled = True
                    btnadd.Enabled = True
                    txtqty.Enabled = True
                    lvproductsinfo.Enabled = False
                ElseIf lblcode.Text = String.Empty Then
                    lblcode.Text = "Unavailable item!"
                    lblproduct.Text = "Unavailable item!"
                    lblprice.Text = "Unavailable item!"
                    txtcode.Text = String.Empty
                    txtcode.Focus()
                ElseIf lblcode.Text = "Unavailable item!"
                    txtcode.Text = String.Empty
                    txtcode.Focus()
                End If

            Catch ex As MySqlException
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                myDbConnect.closeConnect()
                GC.Collect()
            End Try
        End If

        If btnadd.Enabled = True Then
            btnadd.PerformClick()
        End If


    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If cbdelivery.SelectedIndex >= 0 And txtqty.Text <> 0 Then
            lvproductsinfo.Enabled = True
            With lvproductsinfo.Items.Add(lblcode.Text)
                .SubItems.Add(lblproduct.Text)
                .SubItems.Add(lblprice.Text)
                .SubItems.Add(txtqty.Text)
                .SubItems.Add(cbdelivery.SelectedItem.ToString)
            End With
            lblcount.Text = lvproductsinfo.Items.Count
            isEdit = False
            btncancel.PerformClick()

        Else
            MessageBox.Show("Add delivery details", Name, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If cbdelivery.SelectedIndex < 0 Then
                cbdelivery.Focus()
            Else
                txtqty.Focus()
            End If
        End If
    End Sub

    Private Sub lvproductsinfo_DoubleClick(sender As Object, e As EventArgs) Handles lvproductsinfo.DoubleClick
        Dim item As ListViewItem
        For Each item In lvproductsinfo.SelectedItems
            id = lvproductsinfo.Items(item.Index).SubItems(0).Text
            lblcode.Text = lvproductsinfo.Items(item.Index).SubItems(0).Text
            lblproduct.Text = lvproductsinfo.Items(item.Index).SubItems(1).Text
            lblprice.Text = lvproductsinfo.Items(item.Index).SubItems(2).Text
            txtqty.Text = lvproductsinfo.Items(item.Index).SubItems(3).Text
            cbdelivery.Text = lvproductsinfo.Items(item.Index).SubItems(4).Text

            lvproductsinfo.Items(item.Index).Remove()
        Next
        lblcount.Text = lvproductsinfo.Items.Count
        isEdit = True
        btnadd.Enabled = True
        txtcode.Enabled = False
        cbdelivery.Enabled = True
        txtqty.Enabled = True
        lvproductsinfo.Enabled = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If lblcount.Text <> 0 Then
            frmrcvby.ShowDialog()
        End If
    End Sub

    Public Sub lvproductsinfo_Reset()
        lvproductsinfo.Items.Clear()
        lblcount.Text = lvproductsinfo.Items.Count
    End Sub

    Private Sub frmdeliveries_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmmain.fillListview()
    End Sub
End Class