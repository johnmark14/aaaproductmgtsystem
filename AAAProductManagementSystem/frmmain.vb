Imports MySql.Data.MySqlClient
Public Class frmmain
    Dim myDBConnect As Dbconnect = New Dbconnect
    Private Sub frmmain_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        lvproductinfo.Columns(0).Width = lvproductinfo.Width * 0.3
        lvproductinfo.Columns(1).Width = lvproductinfo.Width * 0.5
        lvproductinfo.Columns(2).Width = lvproductinfo.Width * 0.1
        lvproductinfo.Columns(3).Width = lvproductinfo.Width * 0.1
    End Sub

    Private Sub btndeliveries_Click(sender As Object, e As EventArgs) Handles btndeliveries.Click
        frmdeliveries.ShowDialog()
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        frmsetmenu.ShowDialog()
    End Sub

    Private Sub frmmain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmlogin.Show()
        frmlogin.txtpassword.Clear()
        frmlogin.cbemployee_Add()
        Timer1.Stop()
    End Sub

    Public Sub fillListview()
        Try
            myDBConnect.openConnect()
            Dim sqlstring As String = "SELECT * FROM tblproducts"
            Dim sqlCmd As New MySqlCommand(sqlstring, myDBConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            lvproductinfo.Items.Clear()
            While (sqlReader.Read())
                With lvproductinfo.Items.Add(sqlReader("id"))
                    .Subitems.add(sqlReader("sku"))
                    .Subitems.add(sqlReader("price"))
                    .Subitems.add(sqlReader("stocks"))
                End With
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

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillListview()
        Timer1.Start()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            myDBConnect.openConnect()
            Dim sqlstring As String = "SELECT * FROM tblproducts where id like '%" & txtsearch.Text & "%'"
            Dim sqlCmd As New MySqlCommand(sqlstring, myDBConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            lvproductinfo.Items.Clear()
            While (sqlReader.Read())
                With lvproductinfo.Items.Add(sqlReader("id"))
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
            myDBConnect.closeConnect()
            GC.Collect()
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        btndeliveries.Focus()
        btndeliveries.PerformClick()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        btnsettings.Focus()
        btnsettings.PerformClick()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        frmloadiomenu.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        btnload.Focus()
        btnload.PerformClick()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = TimeOfDay.ToString("h:mm:ss tt")
        lbldate.Text = Date.Now.Date
    End Sub
End Class