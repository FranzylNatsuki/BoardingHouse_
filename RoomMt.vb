Imports MySql.Data.MySqlClient

Public Class frmRoomMt
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
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim baseDT As DataTable = baseDS.Tables("room")
        Dim newRow As DataRow
        Try
            'a new empty row will be created where the data in the textboxes will be stored
            'check the names of your textbox controls
            newRow = baseDT.NewRow()
            newRow("RoomID") = txt_roomID.Text
            newRow("RoomNo") = txt_RoomNo.Text
            newRow("RoomType") = cb_roomtype.Text
            newRow("MonthlyRate") = txt_rate.Text
            newRow("Capacity") = txt_capacity.Text
            newRow("Occupying") = txt_occupying.Text
            'add the new record to the BORROWER table via the borrDataTable (virtual table)
            baseDT.Rows.Add(newRow)
            'update the borrower table with the inserted new record
            baseDA.Update(baseDS, "room")
            'output a pop-up message (informative) on screen
            MsgBox("The record was successfully saved.", MsgBoxStyle.Information, "Room Maintanance")
            'clear the textboxes and the combobox
            clear()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RoomMt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_update.Enabled = False
        btn_delete.Enabled = False
        'Specify the connection string and the query
        MyConnectionString = "server=localhost;user id=root;password=;database=boardinghouse;"
        'Note that we have already discussed SQL in our previous lecture
        'Create a connection to your database using the connection string specified in the first statement above
        commonSQLQuery = "SELECT * FROM room ORDER BY RoomID"
        MyConnection = New MySqlConnection(MyConnectionString)

        baseDS.Tables.Clear()
        baseDA = New MySqlDataAdapter()
        Try
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If

            baseDA.SelectCommand = New MySqlCommand(commonSQLQuery, MyConnection)
            Dim cb1 As MySqlCommandBuilder = New MySqlCommandBuilder(baseDA)
            baseDA.Fill(baseDS, "room")
            bsSearch.DataSource = baseDS.Tables("room")
            dgv_rooms.DataSource = bsSearch
            dgv_rooms.AutoResizeColumns()
        Catch ex As Common.DbException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'Declare dt as a temporary holder/table for the BORROWER table
        'Take note that we used the variable borrDataTable in the “Add Records” module
        Dim dt As DataTable = baseDS.Tables("room")
        'try to execute the following codes
        Try
            'Using the row index of "row" from the dgvBorrower_MouseUp event, update the Tuple indicated by'"row" in the temporary table (dt) with data from the textboxes/combo box
            'The names in red and enclosed in double quotes are your attributes in phpMyAdmin
            'Take note of the spelling of your attributes because the name is case sensitive
            dt.Rows(row)("RoomID") = txt_roomID.Text
            dt.Rows(row)("RoomNo") = txt_RoomNo.Text
            dt.Rows(row)("RoomType") = cb_roomtype.Text
            dt.Rows(row)("MonthlyRate") = txt_rate.Text
            dt.Rows(row)("Capacity") = txt_capacity.Text
            dt.Rows(row)("Occupying") = txt_occupying.Text
            'save permanently in the department table (in your database)
            baseDA.Update(baseDS, "room")
            'output an informative message to the user
            MsgBox("The changes in the record were successfully saved.", MsgBoxStyle.Information, "Room Maintanance")
            'Clear out the text boxes/combo box for new input/s
            clear()
            'set the cursor on the first textbox (borrower number)
            txt_roomID.Focus()
            txt_roomID.Enabled = True
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
        Dim dt As DataTable = baseDS.Tables("room")
        Dim answer As MsgBoxResult
        'confirmation message
        answer = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Boarder Maintanance")
        If (answer = MsgBoxResult.Yes) Then
            Try
                'delete the record that is indicated by the "row" which was taken note of in dgvBorrower_MouseUp
                dt.Rows(row).Delete()
                'update the employee table with one less tuple
                baseDA.Update(baseDS, "boarder")
                'output an informational message to the user
                MsgBox("The record was successfully deleted.", MsgBoxStyle.Information, "Boarder Maintanance")
                'Blank out the text boxes/combo box for new input/s
                clear()
                'set the cursor on the first textbox
                txt_roomID.Focus()
                txt_roomID.Enabled = True
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
            txt_roomID.Focus()
            txt_roomID.Enabled = True
            btn_add.Enabled = True
            btn_delete.Enabled = False
            btn_update.Enabled = False
        End If
    End Sub
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        clear()
    End Sub

    Private Sub frmRoomMt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    End Sub


    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub dgv_rooms_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_rooms.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_roomID.Text = dgv_rooms.CurrentRow.Cells(0).Value.ToString
        txt_RoomNo.Text = dgv_rooms.CurrentRow.Cells(1).Value.ToString
        cb_roomtype.Text = dgv_rooms.CurrentRow.Cells(2).Value.ToString
        txt_rate.Text = dgv_rooms.CurrentRow.Cells(3).Value.ToString
        txt_capacity.Text = dgv_rooms.CurrentRow.Cells(4).Value.ToString
        txt_occupying.Text = dgv_rooms.CurrentRow.Cells(5).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        'this was previously declared in the Public Class frmBorrower
        row = dgv_rooms.CurrentRow.Index
        'the Add button is disabled and the Update and Delete buttons are enabled
        'the record that was chosen can either be edited or deleted (not added as a new record)
        btn_add.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        txt_roomID.Enabled = False
    End Sub

    Private Sub clear()
        txt_roomID.Clear()
        txt_RoomNo.Clear()
        txt_rate.Clear()
        txt_capacity.Clear()
        txt_occupying.Clear()
        cb_roomtype.SelectedIndex = -1
        cb_roomtype.SelectedItem = Nothing
        cb_roomtype.Text = ""
        cb_search.SelectedIndex = -1
        cb_search.SelectedItem = Nothing
        cb_search.Text = ""
        txt_numbersearch.Clear()
    End Sub

    Private Sub frmRoomMt_Click(sender As Object, e As EventArgs) Handles Me.Click
        btn_add.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        clear()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_numbersearch.TextChanged
        Search()
    End Sub

    Private Sub cb_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_search.SelectedIndexChanged
        Search()
    End Sub

    Sub Search()
        Dim search As String = txt_numbersearch.Text
        Dim roomType As String = cb_search.Text

        search = search.Replace("'", "''")
        search = search.Replace("[", "[[]")
        search = search.Replace("%", "[%]")
        search = search.Replace("_", "[_]")

        Dim filter As String = ""

        If search <> "" Then
            filter = $"(Convert(RoomNo, 'System.String') LIKE '{search}%' OR RoomType LIKE '{search}%')"
        End If

        If roomType <> "" Then
            If filter <> "" Then
                filter &= " AND "
            End If
            filter &= $"RoomType = '{roomType}'"
        End If


        bsSearch.Filter = filter
    End Sub
End Class