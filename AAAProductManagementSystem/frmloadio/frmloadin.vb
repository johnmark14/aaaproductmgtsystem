Imports MySql.Data.MySqlClient
Public Class frmloadin
    Dim myDBConnect As Dbconnect = New Dbconnect

    Private Sub frmloadin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbsalesman_Add()
        cbsalesman.SelectedIndex = 0
    End Sub

    Private Sub cbsalesman_Add()
        Try
            myDBConnect.openConnect()
            Dim sqlString As String = "SELECT names FROM tblsalesman"
            Dim sqlCmd As New MySqlCommand(sqlString, myDBConnect.mySqlConString)
            Dim sqlReader As MySqlDataReader = sqlCmd.ExecuteReader
            While (sqlReader.Read())
                cbsalesman.Items.Add(sqlReader("names"))
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

    Private Sub cbsalesman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsalesman.SelectedIndexChanged
        If cbsalesman.SelectedIndex <> 0 Then

        End If
    End Sub
End Class