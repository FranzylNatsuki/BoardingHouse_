Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class frmDashboard
    'Create connection variable/object named "MyConnection"

    Dim MyConnection As Common.DbConnection

    'Create a Data Adapter variable/object
    '---A Data Adapter is the go-between for the connection object (MyConnection)
    'and the Dataset (borrowerDA)

    Dim baseDA As New MySqlDataAdapter

    'Create a Dataset variable/object
    '---A Data Set is a place holder for the table in your database

    '---There should be one data set for each table in your database
    Dim baseDS As New DataSet()
    'Declare the connection string and query variables/objects
    Dim MyConnectionString As String
    Dim commonSQLQuery As String
    'We will use this later in the update and delete modules
    Dim row As Integer


    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Specify the connection string and the query
        MyConnectionString = "server=localhost;user id=root;password=;database=boardinghouse;"
        'Note that we have already discussed SQL in our previous lecture
        'Create a connection to your database using the connection string specified in the first statement above
        MyConnection = New MySqlConnection(MyConnectionString)

        lbl_boardercount.Text = DashboardRetrieve("SELECT COUNT(BoarderID) FROM boarder")
        lbl_occupied.Text = DashboardRetrieve("SELECT COUNT(RoomID) FROM room WHERE Occupying > 0")
        lbl_unoccupied.Text = DashboardRetrieve("SELECT COUNT(RoomID) FROM room WHERE Occupying = 0")
        lbl_fc_count.Text = DashboardRetrieve("SELECT COUNT(RequestID) FROM facility_request")
        lbl_termination.Text = DashboardRetrieve("SELECT COUNT(TerminationID) FROM rent_termination WHERE Cleared = 0")

        commonSQLQuery = "SELECT * FROM boarder ORDER BY LastName"
        DGVContext(commonSQLQuery, "boarder")
    End Sub

    Function DashboardRetrieve(query As String) As String
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If

        Dim cmd As MySqlCommand = New MySqlCommand(query, MyConnection)
        Dim info As String = cmd.ExecuteScalar().ToString()
        Return info
    End Function

    Function DGVContext(query As String, table As String)
        baseDS.Tables.Clear()
        baseDA = New MySqlDataAdapter()
        Try
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If

            baseDA.SelectCommand = New MySqlCommand(query, MyConnection)
            Dim cb1 As MySqlCommandBuilder = New MySqlCommandBuilder(baseDA)
            baseDA.Fill(baseDS, table)
            dgv_dashboard.DataSource = baseDS
            dgv_dashboard.DataMember = table
            If dgv_dashboard.Columns.Contains("BillingPeriod") Then
                dgv_dashboard.Columns("BillingPeriod").DefaultCellStyle.Format = "yyyy-MM"
            End If
            dgv_dashboard.AutoResizeColumns()
        Catch ex As Common.DbException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Function

    Private Sub btn_dash_boarders_Click(sender As Object, e As EventArgs) Handles btn_dash_boarders.Click
        commonSQLQuery = "SELECT * FROM boarder ORDER BY LastName"
        DGVContext(commonSQLQuery, "boarder")
    End Sub

    Private Sub btn_dash_rooms_Click(sender As Object, e As EventArgs) Handles btn_dash_rooms.Click
        commonSQLQuery = "SELECT * FROM room ORDER BY RoomID"
        DGVContext(commonSQLQuery, "room")
    End Sub

    Private Sub btn_dash_fc_Click(sender As Object, e As EventArgs) Handles btn_dash_fc.Click
        commonSQLQuery = "SELECT * FROM facility_request ORDER BY RequestID"
        DGVContext(commonSQLQuery, "facility_request")
    End Sub

    Private Sub btn_dash_utilities_Click(sender As Object, e As EventArgs) Handles btn_dash_utilities.Click
        commonSQLQuery = "SELECT * FROM utility ORDER BY UtilityID"
        DGVContext(commonSQLQuery, "utility")
    End Sub

    Private Sub btn_dash_payments_Click(sender As Object, e As EventArgs) Handles btn_dash_payments.Click
        commonSQLQuery = "SELECT * FROM rental_payment ORDER BY TransactionID"
        DGVContext(commonSQLQuery, "rental_payment")
    End Sub

    Private Sub btn_dash_term_Click(sender As Object, e As EventArgs) Handles btn_dash_term.Click
        commonSQLQuery = "SELECT * FROM rent_termination ORDER BY TerminationID"
        DGVContext(commonSQLQuery, "rent_termination")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BoarderMaintananceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoarderMaintananceToolStripMenuItem.Click
        frmBoarderMt.ShowDialog()
        RefreshDashboard()
    End Sub

    Private Sub RoomMaintananceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomMaintananceToolStripMenuItem.Click
        frmRoomMt.ShowDialog()
        RefreshDashboard()
    End Sub

    Sub RefreshDashboard()
        lbl_boardercount.Text = DashboardRetrieve("SELECT COUNT(BoarderID) FROM boarder")
        lbl_occupied.Text = DashboardRetrieve("SELECT COUNT(RoomID) FROM room WHERE Occupying > 0")
        lbl_unoccupied.Text = DashboardRetrieve("SELECT COUNT(RoomID) FROM room WHERE Occupying = 0")
        lbl_fc_count.Text = DashboardRetrieve("SELECT COUNT(RequestID) FROM facility_request")
        lbl_termination.Text = DashboardRetrieve("SELECT COUNT(TerminationID) FROM rent_termination WHERE Cleared = 0")

        DGVContext(commonSQLQuery, dgv_dashboard.DataMember)
    End Sub
End Class
