Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class frmBoarderMt
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

    Private Sub frmBoarderMt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_update.Enabled = False
        btn_delete.Enabled = False
        'Specify the connection string and the query
        MyConnectionString = "server=localhost;user id=root;password=;database=boardinghouse;"
        'Note that we have already discussed SQL in our previous lecture
        'Create a connection to your database using the connection string specified in the first statement above
        commonSQLQuery = "SELECT * FROM boarder ORDER BY LastName"
        MyConnection = New MySqlConnection(MyConnectionString)

        ComboBoxContent()
        cb_roomID.SelectedIndex = -1

        baseDS.Tables.Clear()
        baseDA = New MySqlDataAdapter()
        Try
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If

            baseDA.SelectCommand = New MySqlCommand(commonSQLQuery, MyConnection)
            Dim cb1 As MySqlCommandBuilder = New MySqlCommandBuilder(baseDA)
            baseDA.Fill(baseDS, "boarder")
            bsSearch.DataSource = baseDS.Tables("boarder")
            dgv_boarders.DataSource = bsSearch
            dgv_boarders.AutoResizeColumns()
        Catch ex As Common.DbException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub ComboBoxContent()
        Dim dt As New DataTable()
        Dim Query As String = "SELECT RoomID FROM room"

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If

        Dim adapter As New MySqlDataAdapter(Query, MyConnection)
        adapter.Fill(dt)

        cb_roomID.DataSource = dt
        cb_roomID.DisplayMember = "RoomID"
        cb_roomID.ValueMember = "RoomID"
        MyConnection.Close()
    End Sub

    Private Sub frmBoarderMt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        clear()
    End Sub

    Private Sub clear()
        txt_boarderID.Clear()
        txt_contact.Clear()
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_emergencyname.Clear()
        txt_emergencyno.Clear()
        cb_roomID.SelectedIndex = -1
        txt_search.Clear()
    End Sub

    Sub UpdateRoomOccupancy(roomID As String)
        Dim query As String = "SELECT COUNT(*) FROM boarder WHERE RoomID = @roomID"
        Dim cmd As New MySqlCommand(query, MyConnection)
        cmd.Parameters.AddWithValue("@roomID", roomID)

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        Dim updateQuery As String = "UPDATE room SET Occupying = @count WHERE RoomID = @roomID"
        Dim updateCmd As New MySqlCommand(updateQuery, MyConnection)
        updateCmd.Parameters.AddWithValue("@count", count)
        updateCmd.Parameters.AddWithValue("@roomID", roomID)

        updateCmd.ExecuteNonQuery()

        MyConnection.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim baseDT As DataTable = baseDS.Tables("boarder")
        Dim newRow As DataRow
        Try
            'a new empty row will be created where the data in the textboxes will be stored
            'check the names of your textbox controls
            newRow = baseDT.NewRow()
            newRow("BoarderID") = txt_boarderID.Text
            newRow("FirstName") = txt_firstname.Text
            newRow("LastName") = txt_lastname.Text
            newRow("ContactNo") = txt_contact.Text
            newRow("EmergencyContactName") = txt_emergencyname.Text
            newRow("EmergencyContactNo") = txt_emergencyno.Text
            newRow("RoomID") = cb_roomID.Text
            'add the new record to the BORROWER table via the borrDataTable (virtual table)
            baseDT.Rows.Add(newRow)
            'update the borrower table with the inserted new record
            baseDA.Update(baseDS, "boarder")
            'output a pop-up message (informative) on screen
            MsgBox("The record was successfully saved.", MsgBoxStyle.Information, "Boarder Maintanance")
            'clear the textboxes and the combobox
            UpdateRoomOccupancy(cb_roomID.Text)
            clear()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'Declare dt as a temporary holder/table for the BORROWER table
        'Take note that we used the variable borrDataTable in the “Add Records” module
        Dim dt As DataTable = baseDS.Tables("boarder")
        'try to execute the following codes
        Try
            Dim oldRoomID As String = ""
            If dt.Rows(row)("RoomID") IsNot DBNull.Value Then
                oldRoomID = dt.Rows(row)("RoomID").ToString()
            End If
            'Using the row index of "row" from the dgvBorrower_MouseUp event, update the Tuple indicated by'"row" in the temporary table (dt) with data from the textboxes/combo box
            'The names in red and enclosed in double quotes are your attributes in phpMyAdmin
            'Take note of the spelling of your attributes because the name is case sensitive
            dt.Rows(row)("BoarderID") = txt_boarderID.Text
            dt.Rows(row)("FirstName") = txt_firstname.Text
            dt.Rows(row)("LastName") = txt_lastname.Text
            dt.Rows(row)("ContactNo") = txt_contact.Text
            dt.Rows(row)("EmergencyContactName") = txt_emergencyname.Text
            dt.Rows(row)("EmergencyContactNo") = txt_emergencyno.Text
            dt.Rows(row)("RoomID") = cb_roomID.Text
            'save permanently in the department table (in your database)
            baseDA.Update(baseDS, "boarder")

            If oldRoomID <> "" Then
                UpdateRoomOccupancy(oldRoomID) ' decrease old room
            End If

            If cb_roomID.Text <> "" Then
                UpdateRoomOccupancy(cb_roomID.Text) ' increase new room
            End If

            'output an informative message to the user
            MsgBox("The changes in the record were successfully saved.", MsgBoxStyle.Information, "Boarder Maintanance")
            'Clear out the text boxes/combo box for new input/s
            clear()
            'set the cursor on the first textbox (borrower number)
            txt_boarderID.Focus()
            txt_boarderID.Enabled = True
            'enable the Add button
            btn_add.Enabled = True
            'disable (cannot be clicked) the Delete and Update buttons
            btn_delete.Enabled = False
            btn_update.Enabled = False
            'if an error occurs, output an error message to the user ("catch" the error)
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        'create a temporary table (dt) that will hold the rows from the borrower table
        Dim dt As DataTable = baseDS.Tables("boarder")
        Dim answer As MsgBoxResult
        'confirmation message
        answer = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Boarder Maintanance")
        If (answer = MsgBoxResult.Yes) Then
            Try
                Dim oldRoomID As String = ""

                If dt.Rows(row)("RoomID") IsNot DBNull.Value Then
                    oldRoomID = dt.Rows(row)("RoomID").ToString()
                End If
                'delete the record that is indicated by the "row" which was taken note of in dgvBorrower_MouseUp
                dt.Rows(row).Delete()
                'update the employee table with one less tuple
                baseDA.Update(baseDS, "boarder")
                'output an informational message to the user
                MsgBox("The record was successfully deleted.", MsgBoxStyle.Information, "Boarder Maintanance")
                'Blank out the text boxes/combo box for new input/s
                clear()
                UpdateRoomOccupancy(oldRoomID)
                'set the cursor on the first textbox
                txt_boarderID.Focus()
                txt_boarderID.Enabled = True
                btn_add.Enabled = True
                btn_delete.Enabled = False
                btn_update.Enabled = False
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            End Try
            'if the deletion process is aborted
        ElseIf answer = MsgBoxResult.No Then
            MsgBox("Aborting deletion process...", MsgBoxStyle.OkOnly)
            'Blank out the text boxes/combo box for new input/s
            clear()
            'set the cursor on the first textbox
            txt_boarderID.Focus()
            txt_boarderID.Enabled = True
            btn_add.Enabled = True
            btn_delete.Enabled = False
            btn_update.Enabled = False
        End If
    End Sub

    Private Sub dgv_boarders_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_boarders.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_boarderID.Text = dgv_boarders.CurrentRow.Cells(0).Value.ToString
        txt_firstname.Text = dgv_boarders.CurrentRow.Cells(1).Value.ToString
        txt_lastname.Text = dgv_boarders.CurrentRow.Cells(2).Value.ToString
        txt_contact.Text = dgv_boarders.CurrentRow.Cells(3).Value.ToString
        txt_emergencyname.Text = dgv_boarders.CurrentRow.Cells(4).Value.ToString
        txt_emergencyno.Text = dgv_boarders.CurrentRow.Cells(5).Value.ToString
        cb_roomID.Text = dgv_boarders.CurrentRow.Cells(6).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        'this was previously declared in the Public Class frmBorrower
        row = dgv_boarders.CurrentRow.Index
        'the Add button is disabled and the Update and Delete buttons are enabled
        'the record that was chosen can either be edited or deleted (not added as a new record)
        btn_add.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        txt_boarderID.Enabled = False
    End Sub

    Private Sub frmBoarderMt_Click(sender As Object, e As EventArgs) Handles Me.Click
        btn_add.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        txt_boarderID.Enabled = True
        clear()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        'declare a data table that will hold the content of the borrower table
        Dim dt As DataTable = baseDS.Tables("boarder")
        'connect the data table as the data source of the BindingSource control (bsSearchBorrower)
        bsSearch.DataSource = dt
        'set the data source of the DataGridView control (dgvBorrower) to the BindingSource
        'filter the BindingSource with every change that happens in the textbox (TextChangedEvent)
        Dim search As String = txt_search.Text

        search = search.Replace("'", "''")
        search = search.Replace("[", "[[]")
        search = search.Replace("%", "[%]")
        search = search.Replace("_", "[_]")

        bsSearch.Filter = $"FirstName LIKE '{search}%' OR LastName LIKE '{search}%'"
    End Sub
End Class