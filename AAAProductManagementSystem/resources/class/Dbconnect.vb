Imports MySql.Data.MySqlClient
Public Class Dbconnect
    Private mysqlConnect As MySqlConnection
    Private sqlcmd As MySqlCommand

    '''Constructor
    '''<summary>
    ''' This initialize database creadentials
    ''' 
    ''' </summary>
    Public Sub New()
        mysqlConnect = New MySqlConnection
        mysqlConnect.ConnectionString =
                    "server=localhost;" &
                    "port=3306;" &
                    "username=root;" &
                    "password=jmBeats14;" &
                    "database=productsdb;"
    End Sub

    Public Sub testCoonection()
        Try
            mysqlConnect.Open()
            MessageBox.Show("Connected to the Database!")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConnect.Close()
        End Try
    End Sub

    Public Function mySqlConString() As Object
        Return mysqlConnect
    End Function

    Public Sub openConnect()
        Try
            mysqlConnect.Open()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub closeConnect()
        Try
            mysqlConnect.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
