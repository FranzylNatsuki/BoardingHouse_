Imports MySql.Data.MySqlClient

Public Class Form1
    'Create connection variable/object named "MyConnection"

    Dim MyConnection As Common.DbConnection
    'Create a Data Adapter variable/object
    '---A Data Adapter is the go-between for the connection object (MyConnection)
    'and the Dataset (borrowerDA)

    Dim borrowerDA As New MySqlDataAdapter

    'Create a Dataset variable/object
    '---A Data Set is a place holder for the table in your database

    '---There should be one data set for each table in your database
    Dim borrowerDS As New DataSet()
    'Declare the connection string and query variables/objects
    Dim MyConnectionString As String
    Dim borrowerSQLQuery As String
    'We will use this later in the update and delete modules
    Dim row As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_dash_boarders_Click(sender As Object, e As EventArgs) Handles btn_dash_boarders.Click

    End Sub

    Private Sub btn_dash_rooms_Click(sender As Object, e As EventArgs) Handles btn_dash_rooms.Click

    End Sub

    Private Sub btn_dash_fc_Click(sender As Object, e As EventArgs) Handles btn_dash_fc.Click

    End Sub

    Private Sub btn_dash_utilities_Click(sender As Object, e As EventArgs) Handles btn_dash_utilities.Click

    End Sub

    Private Sub btn_dash_payments_Click(sender As Object, e As EventArgs) Handles btn_dash_payments.Click

    End Sub

    Private Sub btn_dash_term_Click(sender As Object, e As EventArgs) Handles btn_dash_term.Click

    End Sub
End Class
