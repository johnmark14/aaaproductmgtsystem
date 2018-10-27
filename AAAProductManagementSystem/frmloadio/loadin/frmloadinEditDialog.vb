
Imports MySql.Data.MySqlClient
Public Class frmloadinEditDialog
    Private myDBConnect As Dbconnect = New Dbconnect
    ''' <summary>
    ''' set content for the items
    ''' </summary>
    Private Sub addItems()
        lblcode.Text = frmloadin.getLvCode
        lblproduct.Text = frmloadin.getLvProduct
        txtqty.Text = frmloadin.getLvQty

        'get additional items
        readDb()

        'set total price content
        lbltotalprice_checker()
    End Sub

    Private Sub frmloadinEditDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addItems()
    End Sub

    Private Sub readDb()
        Try
            myDBConnect.openConnect()
            Dim sqlString As String = "SELECT price, stocks FROM tblproducts WHERE id ='" & Me.Text & "'"
            Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            Dim stocks As Integer
            While sqlReader.Read
                lblprice.Text = sqlReader("price")
                Integer.TryParse(sqlReader("stocks"), stocks)
            End While

            If stocks = 0 Then lblstocks.Text = "Out of stocks" Else lblstocks.Text = stocks

            sqlReader.Close()
            sqlReader.Dispose()
            sqlCmd.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            myDBConnect.closeConnect()
            GC.Collect()
        End Try
    End Sub
    ''' <summary>
    ''' add price to lbltotal price by calculating price * qty 
    ''' </summary>
    Private Sub lbltotalprice_checker()
        Dim qty As Integer
        Dim price As Double

        Integer.TryParse(txtqty.Text, qty)
        Double.TryParse(lblprice.Text, price)

        lbltotalprice.Text = price * qty
    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged
        Dim qty As Integer = 0
        Integer.TryParse(txtqty.Text, qty)

        If qty <> frmloadin.getLvQty Then
            btnupdate.Enabled = True
            btnremove.Enabled = False
            Me.AcceptButton = btnupdate

            Dim stocks As Integer
            Integer.TryParse(lblstocks.Text, stocks)

            If lblstocks.Text = "Out of stocks" Then
                If qty > frmloadin.getLvQty Then
                    MessageBox.Show("Quantity cannot be more than the number of the previously set quantity!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtqty.Text = frmloadin.getLvQty
                End If
            Else
                If qty > (stocks + frmloadin.getLvQty) Then
                    MessageBox.Show("Quantity cannot exceed the number of stocks available!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtqty.Text = frmloadin.getLvQty
                End If

            End If
        Else
            btnremove.Enabled = True
            btnupdate.Enabled = False
            Me.AcceptButton = btnremove
        End If

        lbltotalprice_checker()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim qty As Integer = 0
        Integer.TryParse(txtqty.Text, qty)

        If qty <> 0 Then
            Try
                Dim stocks As Integer
                Integer.TryParse(lblstocks.Text, stocks)
                Dim dbNewQty As Integer = 0

                If qty < frmloadin.getLvQty Then
                    dbNewQty = frmloadin.getLvQty - qty
                    dbNewQty = stocks + dbNewQty
                ElseIf qty > frmloadin.getLvQty Then
                    dbNewQty = qty - frmloadin.getLvQty
                    dbNewQty = stocks - dbNewQty
                End If

                myDBConnect.openConnect()
                Dim sqlString As String = "UPDATE tblproducts SET stocks ='" & dbNewQty & "' WHERE(id='" & Me.Text & "')"
                Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
                sqlCmd.ExecuteNonQuery()
                sqlCmd.Dispose()

                MessageBox.Show("Record successfully updated!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmloadin.setLvItems(txtqty.Text, lbltotalprice.Text)
                frmloadin.setInformation()
                Me.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                myDBConnect.closeConnect()
                GC.Collect()
            End Try
        Else
            txtqty.Text = frmloadin.getLvQty
        End If
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim stocks As Integer
        Dim qty As Integer

        Integer.TryParse(lblstocks.Text, stocks)
        Integer.TryParse(txtqty.Text, qty)

        stocks = qty + stocks
        Try
            myDBConnect.openConnect()
            Dim sqlString As String = "UPDATE tblproducts SET stocks ='" & stocks & "' WHERE(id='" & Me.Text & "')"
            Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()

            MessageBox.Show("Record successfully removed!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmloadin.lvproductsinfo.Items.RemoveAt(frmloadin.lvproductsinfo.SelectedIndices(0))
            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            myDBConnect.closeConnect()
            GC.Collect()
        End Try
    End Sub
End Class