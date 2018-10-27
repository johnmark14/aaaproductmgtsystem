Imports MySql.Data.MySqlClient
Public Class frmloadin
    Private myDBConnect As Dbconnect = New Dbconnect
    'Items limit that a salesman can handle per item
    Private itemsLimit As Integer = 200
    'holds the totalamount the a salesman get for a particular loadin
    ' Private totalAmount As Double = 0.0

    Private Sub cbsalesman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsalesman.SelectedIndexChanged
        If cbsalesman.SelectedIndex <> 0 Then
            clearText()
            txtcode.Clear()
            txtcode.Enabled = True
            txtcode.Focus()
        Else
            txtcode.Enabled = False
            txtcode.Clear()
            txtqty.Enabled = False
            clearText()
        End If
    End Sub

    ''' <summary>
    ''' Add item to cbsalesman comboBox
    ''' </summary>
    Private Sub cbsalesman_Add()
        Try
            myDBConnect.openConnect()
            Dim sqlString As String = "SELECT tblemployees.firstname from tblsalesman JOIN tblemployees ON tblsalesman.employees_id = tblemployees.id WHERE tblsalesman.inLoad != '1'"
            Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

            cbsalesman.Items.Clear()
            cbsalesman.Items.Add("---Select---")
            cbsalesman.SelectedIndex = 0
            While (sqlReader.Read())
                cbsalesman.Items.Add(sqlReader("firstname"))
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

    '''<summary>
    ''' This clear the label and textbox from
    ''' code.
    ''' </summary>
    Private Sub clearText()
        txtqty.Clear()
        lblcode.Text = String.Empty
        lblproduct.Text = String.Empty
        lblstocks.Text = String.Empty
        lblprice.Text = String.Empty
        lbltotalprice.Text = String.Empty
    End Sub

    Private Sub frmloadin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add items to cbsalesman combo box
        cbsalesman_Add()
        'set the form focus to cbsalesman combo box
        cbsalesman.Focus()
    End Sub

    Private Sub btnvalidate_Click(sender As Object, e As EventArgs) Handles btnvalidate.Click
        If txtcode.Text <> String.Empty Then
            Try
                ' Search the particular product from the database 
                ' base on the id in the txtcode
                myDBConnect.openConnect()
                Dim sqlstring As String = "SELECT * FROM tblproducts where id='" & txtcode.Text & "'"
                Dim sqlCmd As New MySqlCommand(sqlstring, myDBConnect.mySqlConString)
                Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader

                'create a temporary holder of data
                Dim product_code As String = ""
                Dim product_name As String = ""
                Dim product_stocks As String = ""
                Dim product_price As String = ""

                'read data from the database
                While (sqlReader.Read())
                    product_code = sqlReader!id
                    product_name = sqlReader!sku
                    product_stocks = sqlReader!stocks
                    product_price = sqlReader!price
                End While

                'dispose all the command used
                sqlCmd.Dispose()
                sqlReader.Dispose()

                'check if the product is provided in the txtcode is valid or 
                'exist from the database
                If product_code.Any Then
                    If product_stocks <> "0" Then
                        'clear the text field first
                        clearText()

                        'set text to the form field
                        lblcode.Text = product_code
                        lblproduct.Text = product_name
                        lblstocks.Text = product_stocks
                        lblprice.Text = product_price

                        'set txtqty.text field
                        txtqty_quantityChecker()
                        txtqty.Enabled = True

                        'set lbltotalprice text
                        lbltotalprice_checker()

                        'clear txtcode.text 
                        txtcode.Clear()

                        'set btnadd enable and acceptbutton
                        If Not btnadd.Enabled Then btnadd.Enabled = True
                        Me.AcceptButton = btnadd
                    Else
                        'display message so users know!
                        MessageBox.Show("Out of stocks item!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'clear the text field first
                        clearText()

                        'disable txtqty if enable
                        If txtqty.Enabled Then txtqty.Enabled = False

                        'set text to the form field
                        lblcode.Text = product_code
                        lblproduct.Text = product_name
                        lblstocks.Text = "Out of stocks"
                        lblprice.Text = product_price
                        lbltotalprice.Text = 0

                        'clear txtcode.text 
                        txtcode.Clear()

                        'set add disabble and btnvalidate as accept button
                        If btnadd.Enabled Then btnadd.Enabled = False
                        Me.AcceptButton = btnvalidate

                    End If
                Else
                    'clear the text field first
                    clearText()

                    'if item is unavailable or does not exist from the database
                    Dim text As String = "Unavailable item"
                    lblcode.Text = text
                    lblproduct.Text = text
                    lblstocks.Text = text
                    lblprice.Text = text
                    lbltotalprice.Text = text

                    'disable txtquanty.text
                    txtqty.Enabled = False

                    'clear txtcode.text
                    txtcode.Clear()

                    'set add disabble and btnvalidate as accept button
                    If btnadd.Enabled Then btnadd.Enabled = False
                    Me.AcceptButton = btnvalidate
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                myDBConnect.closeConnect()
                GC.Collect()
            End Try
        End If
    End Sub
    ''' <summary>
    ''' set the default item in the txtqty.text
    ''' </summary>
    Private Sub txtqty_quantityChecker()
        If lblstocks.Text <> "Out of stocks" Then
            Dim stocks As Integer
            Dim qty As Integer
            Integer.TryParse(lblstocks.Text, stocks)
            Integer.TryParse(txtqty.Text, qty)

            If stocks > itemsLimit Then
                txtqty.Text = itemsLimit
            ElseIf stocks <= itemsLimit Then
                txtqty.Text = stocks
            End If
        End If
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
        If txtqty.Enabled Then
            lbltotalprice_checker()

            Dim qty As Integer
            Dim stocks As Integer

            Integer.TryParse(txtqty.Text, qty)
            Integer.TryParse(lblstocks.Text, stocks)

            If qty > stocks Then
                MessageBox.Show("Number of quantity cannot be more than the number of stocks", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtqty.Text = itemsLimit
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        clearText()
        txtqty.Enabled = False
        txtcode.Focus()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Try
            ' Subtract quantity from the database
            Dim stocks As Integer, qty As Integer, upQty As Integer

            Integer.TryParse(lblstocks.Text, stocks)
            Integer.TryParse(txtqty.Text, qty)

            upQty = stocks - qty

            ' Update table of products which is get by the salesman
            myDBConnect.openConnect()
            Dim sqlString As String = "UPDATE tblproducts SET stocks='" & upQty & "' WHERE (id='" & lblcode.Text & "')"
            Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()

            'search listview item first

            If lvproductsinfo.Items.Count <> 0 Then

                Dim item As ListViewItem

                item = lvproductsinfo.FindItemWithText(lblcode.Text, True, 0)

                If Not item Is Nothing Then
                    Dim n_stocks As Integer
                    Dim d_stocks As Integer

                    Integer.TryParse(txtqty.Text, n_stocks)
                    Integer.TryParse(lvproductsinfo.Items(item.Index).SubItems(2).Text, d_stocks)

                    lvproductsinfo.Items(item.Index).SubItems(2).Text = n_stocks + d_stocks

                    Dim n_totalPrice As Double = 0.0
                    Dim d_totalPrice As Double = 0.0

                    Double.TryParse(lvproductsinfo.Items(item.Index).SubItems(3).Text, d_totalPrice)
                    Double.TryParse(lbltotalprice.Text, n_totalPrice)

                    lvproductsinfo.Items(item.Index).SubItems(3).Text = n_totalPrice + d_totalPrice
                Else
                    'set listview the item
                    With lvproductsinfo.Items.Add(lblcode.Text)
                        .SubItems.Add(lblproduct.Text)
                        .SubItems.Add(txtqty.Text)
                        .SubItems.Add(lbltotalprice.Text)
                    End With
                End If
            Else
                'set listview the item
                With lvproductsinfo.Items.Add(lblcode.Text)
                    .SubItems.Add(lblproduct.Text)
                    .SubItems.Add(txtqty.Text)
                    .SubItems.Add(lbltotalprice.Text)
                End With
            End If
            ' if btnadd was click 
            If txtcode.Text = String.Empty Then clearText() : txtcode.Focus()

            'set the additional information
            setInformation()

            'bring back btnvalidate as accept button
            Me.AcceptButton = btnvalidate

            'disable add button
            If btnadd.Enabled Then btnadd.Enabled = False

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myDBConnect.closeConnect()
            GC.Collect()

            'disable txtqty.text
            If txtqty.Enabled Then txtqty.Enabled = False

            'loop to validate
            btnvalidate.PerformClick()

        End Try

    End Sub

    ''' <summary>
    ''' Set the additional information at the bottom of the form
    ''' </summary>
    Public Sub setInformation()

        lblsalesman.Text = cbsalesman.SelectedItem.ToString
        lbltotalNumberOfProducts.Text = lvproductsinfo.Items.Count

        Dim amount As Double = 0.0
        Dim totalAmount As Double = 0.0
        For item = 0 To lvproductsinfo.Items.Count - 1
            Double.TryParse(lvproductsinfo.Items(item).SubItems(3).Text, amount)
            totalAmount += amount
        Next
        lbltotalamount.Text = totalAmount
    End Sub

    Private Sub lvproductsinfo_DoubleClick(sender As Object, e As EventArgs) Handles lvproductsinfo.DoubleClick
        Dim item As ListViewItem
        For Each item In lvproductsinfo.SelectedItems
            frmloadinEditDialog.Text = lvproductsinfo.Items(item.Index).SubItems(0).Text
            lv_code = lvproductsinfo.Items(item.Index).SubItems(0).Text
            lv_product = lvproductsinfo.Items(item.Index).SubItems(1).Text
            lv_qty = lvproductsinfo.Items(item.Index).SubItems(2).Text
        Next
        txtcode.Focus()
        frmloadinEditDialog.ShowDialog()
    End Sub
#Region "Setter & Getter"
    Private lv_code As String
    Private lv_product As String
    Private lv_qty As String

    Public Function getLvIndex() As Integer
        Return Me.lvproductsinfo.FocusedItem.Index
    End Function
    Public Function getLvCode() As String
        Return lv_code
    End Function

    Public Function getLvProduct() As String
        Return lv_product
    End Function

    Public Function getLvQty() As String
        Return lv_qty
    End Function

    Public Sub setLvItems(ByVal qty As String, totalPrice As String)
        Dim index As Integer = lvproductsinfo.FocusedItem.Index
        lvproductsinfo.Items(index).SubItems(2).Text = qty
        lvproductsinfo.Items(index).SubItems(3).Text = totalPrice
    End Sub

    Private Sub psave_Click(sender As Object, e As EventArgs) Handles psave.Click
        If lvproductsinfo.Items.Count <> 0 Then
            Dim result As DialogResult = MessageBox.Show("This will confirm the loadin transactions for this employee, Please verify the informatio first. Select Ok if you want to preceed.", Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                'ADD SPLASH SCREEN HERE
                splash.Visible = True

                Dim i As Integer = 6
                Dim xl As New Microsoft.Office.Interop.Excel.Application
                Dim wkb As Microsoft.Office.Interop.Excel.Workbook
                Dim wks As Microsoft.Office.Interop.Excel.Worksheet
                wkb = xl.Workbooks.Open(System.IO.Directory.GetCurrentDirectory & "\excel\loadinout\loadin.xlsx")
                wks = wkb.Sheets.Item("Loadin")

                Dim dateTime = Now.ToString("yyyy:MM:dd hh:mm:ss")
                Try
                    myDBConnect.openConnect()
                    Dim sqlString1 As String = "SELECT id FROM tblemployees WHERE firstname = '" & cbsalesman.SelectedItem.ToString & "'"
                    Dim sqlCmd1 As New MySqlCommand(sqlString1, myDBConnect.mySqlConString)
                    Dim sqlReader1 As MySqlDataReader = sqlCmd1.ExecuteReader

                    Dim employee As String = ""
                    While sqlReader1.Read
                        employee = sqlReader1("id")
                    End While
                    sqlReader1.Close()
                    sqlCmd1.Dispose()
                    sqlReader1.Dispose()

                    Dim sqlString4 As String = "SELECT id FROM tblsalesman WHERE employees_id = '" & employee & "'"
                    Dim sqlCmd4 As New MySqlCommand(sqlString4, myDBConnect.mySqlConString)
                    Dim sqlReader4 As MySqlDataReader = sqlCmd4.ExecuteReader

                    Dim salesman As String = ""
                    While sqlReader4.Read
                        salesman = sqlReader4("id")
                    End While
                    sqlReader4.Close()
                    sqlCmd4.Dispose()
                    sqlReader4.Dispose()

                    Dim sqlString3 As String = "UPDATE tblsalesman set inLoad='1' WHERE(id='" & salesman & "')"
                    Dim sqlCmd3 As New MySqlCommand(sqlString3, myDBConnect.mySqlConString)
                    sqlCmd3.ExecuteNonQuery()
                    sqlCmd3.Dispose()

                    Dim item As ListViewItem
                    For Each item In lvproductsinfo.Items
                        Dim p_code = lvproductsinfo.Items(item.Index).SubItems(0).Text
                        Dim p_name = lvproductsinfo.Items(item.Index).SubItems(1).Text
                        Dim p_qty = lvproductsinfo.Items(item.Index).SubItems(2).Text
                        Dim p_price = lvproductsinfo.Items(item.Index).SubItems(3).Text

                        Dim sqlString2 As String = "INSERT INTO tblloadin (products_id, totalQuantity, totalPrice, dateTime, salesman_id) VALUES ('" _
                            & p_code & "','" & p_qty & "','" & p_price & "','" & dateTime & "','" & salesman & "')"
                        Dim sqlCmd2 As New MySqlCommand(sqlString2, myDBConnect.mySqlConString)
                        sqlCmd2.ExecuteNonQuery()
                        sqlCmd2.Dispose()

                        wks.Cells(i, 1) = p_code
                        wks.Cells(i, 2) = p_name
                        wks.Cells(i, 3) = p_qty
                        wks.Cells(4, 3) = Now.ToString("yyy:MM:dd hh:mm:ss")

                        i += 1

                    Next

                    'Close splash screen here
                    splash.Visible = False

                    MessageBox.Show("Successfully save employee " & cbsalesman.SelectedItem.ToString & " records", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    xl.Visible = True
                    'wkb.PrintPreview()
                    wks = Nothing
                    wkb = Nothing
                    xl = Nothing

                    lvproductsinfo.Items.Clear()
                    clearText()
                    txtcode.Clear()

                    'clear additional information at the bottom
                    lblsalesman.Text = "#"
                    lbltotalNumberOfProducts.Text = "#"
                    lbltotalamount.Text = "#"

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    myDBConnect.closeConnect()
                    cbsalesman_Add()
                    cbsalesman.SelectedIndex = 0
                    cbsalesman.Focus()
                    GC.Collect()
                End Try
            ElseIf result = DialogResult.Cancel Then
                Return
            End If
        Else
            MessageBox.Show("No loadin transaction available.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region
End Class