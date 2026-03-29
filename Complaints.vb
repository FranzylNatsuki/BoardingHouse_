Imports MySql.Data.MySqlClient

Public Class frmComplaints
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
    Private Sub frmComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_update.Enabled = False
        btn_delete.Enabled = False
        'Specify the connection string and the query
        MyConnectionString = "server=localhost;user id=root;password=;database=boardinghouse;"
        'Note that we have already discussed SQL in our previous lecture
        'Create a connection to your database using the connection string specified in the first statement above
        commonSQLQuery = "SELECT * FROM facility_request ORDER BY RequestID"
        MyConnection = New MySqlConnection(MyConnectionString)

        ComboBoxContent()
        cb_boarderID.SelectedIndex = -1
        cb_facilityID.SelectedIndex = -1

        baseDS.Tables.Clear()
        baseDA = New MySqlDataAdapter()
        Try
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If

            baseDA.SelectCommand = New MySqlCommand(commonSQLQuery, MyConnection)
            Dim cb1 As MySqlCommandBuilder = New MySqlCommandBuilder(baseDA)
            baseDA.Fill(baseDS, "facility_request")
            dgv_facility.DataSource = baseDS
            dgv_facility.DataMember = "facility_request"
            dgv_facility.AutoResizeColumns()
        Catch ex As Common.DbException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub ComboBoxContent()
        Dim dt As New DataTable()
        Dim dt2 As New DataTable()
        Dim Query As String = "SELECT BoarderID FROM boarder"
        Dim Query2 As String = "SELECT FacilityID FROM facility"

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If

        Dim adapter As New MySqlDataAdapter(Query, MyConnection)
        Dim adapter2 As New MySqlDataAdapter(Query2, MyConnection)
        adapter.Fill(dt)
        adapter2.Fill(dt2)

        cb_boarderID.DataSource = dt
        cb_boarderID.DisplayMember = "BoarderID"
        cb_boarderID.ValueMember = "BoarderID"
        cb_facilityID.DataSource = dt2
        cb_facilityID.DisplayMember = "FacilityID"
        cb_facilityID.ValueMember = "FacilityID"
        MyConnection.Close()
    End Sub

    Private Sub clear()
        txt_requestID.Clear()
        cb_facilityID.SelectedIndex = -1
        cb_facilityID.SelectedItem = Nothing
        cb_facilityID.Text = ""
        cal_request.SetDate(Date.Now)
        txt_desc.Clear()
        cb_boarderID.SelectedIndex = -1
        cb_boarderID.SelectedItem = Nothing
        cb_boarderID.Text = ""
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_requestID.Text.Trim() = "" Or cb_facilityID.Text.Trim() = "" Or cb_boarderID.Text.Trim() = "" Then
            MsgBox("Key/s cannot be empty.", MsgBoxStyle.Exclamation, "Validation Error")
            clear()
            Exit Sub
        End If

        If Not IsNumeric(txt_requestID.Text) Then
            MsgBox("Key/s must be a numeric value.", MsgBoxStyle.Critical, "Invalid Input")
            txt_requestID.Focus()
            clear()
            Exit Sub
        End If

        Dim baseDT As DataTable = baseDS.Tables("facility_request")
        Dim newRow As DataRow
        Try
            'a new empty row will be created where the data in the textboxes will be stored
            'check the names of your textbox controls
            newRow = baseDT.NewRow()
            newRow("RequestID") = txt_requestID.Text
            newRow("FacilityID") = cb_facilityID.Text
            newRow("RequestDate") = cal_request.SelectionStart.Date
            newRow("RequestDescription") = txt_desc.Text
            newRow("FR_BoarderID") = cb_boarderID.Text
            'add the new record to the BORROWER table via the borrDataTable (virtual table)
            baseDT.Rows.Add(newRow)
            'update the borrower table with the inserted new record
            baseDA.Update(baseDS, "facility_request")
            'output a pop-up message (informative) on screen
            MsgBox("The record was successfully saved.", MsgBoxStyle.Information, "Facility Requests")
            'clear the textboxes and the combobox
            clear()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_requestID.Text.Trim() = "" Or cb_facilityID.Text.Trim() = "" Or cb_boarderID.Text.Trim() = "" Then
            MsgBox("Key/s cannot be empty.", MsgBoxStyle.Exclamation, "Validation Error")
            clear()
            Exit Sub
        End If

        If Not IsNumeric(txt_requestID.Text) Then
            MsgBox("Key/s must be a numeric value.", MsgBoxStyle.Critical, "Invalid Input")
            txt_requestID.Focus()
            clear()
            Exit Sub
        End If
        'Declare dt as a temporary holder/table for the BORROWER table
        'Take note that we used the variable borrDataTable in the “Add Records” module
        Dim dt As DataTable = baseDS.Tables("facility_request")
        'try to execute the following codes
        Try
            'Using the row index of "row" from the dgvBorrower_MouseUp event, update the Tuple indicated by'"row" in the temporary table (dt) with data from the textboxes/combo box
            'The names in red and enclosed in double quotes are your attributes in phpMyAdmin
            'Take note of the spelling of your attributes because the name is case sensitive
            dt.Rows(row)("RequestID") = txt_requestID.Text
            dt.Rows(row)("FacilityID") = cb_facilityID.Text
            dt.Rows(row)("RequestDate") = cal_request.SelectionStart.Date
            dt.Rows(row)("RequestDescription") = txt_desc.Text
            dt.Rows(row)("FR_BoarderID") = cb_boarderID.Text
            'save permanently in the department table (in your database)
            baseDA.Update(baseDS, "facility_request")
            'output an informative message to the user
            MsgBox("The changes in the record were successfully saved.", MsgBoxStyle.Information, "Facility Requests")
            'Clear out the text boxes/combo box for new input/s
            clear()
            'set the cursor on the first textbox (borrower number)
            txt_requestID.Focus()
            txt_requestID.Enabled = True
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
        Dim dt As DataTable = baseDS.Tables("facility_request")
        Dim answer As MsgBoxResult
        'confirmation message
        answer = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Facility Requests")
        If (answer = MsgBoxResult.Yes) Then
            Try
                'delete the record that is indicated by the "row" which was taken note of in dgvBorrower_MouseUp
                dt.Rows(row).Delete()
                'update the employee table with one less tuple
                baseDA.Update(baseDS, "facility_request")
                'output an informational message to the user
                MsgBox("The record was successfully deleted.", MsgBoxStyle.Information, "Facility Requests")
                'Blank out the text boxes/combo box for new input/s
                clear()
                'set the cursor on the first textbox
                txt_requestID.Focus()
                txt_requestID.Enabled = True
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
            txt_requestID.Focus()
            txt_requestID.Enabled = True
            btn_add.Enabled = True
            btn_delete.Enabled = False
            btn_update.Enabled = False
        End If
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        clear()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub frmComplaints_Click(sender As Object, e As EventArgs) Handles Me.Click
        btn_add.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        txt_requestID.Enabled = True
        clear()
    End Sub

    Private Sub dgv_facility_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_facility.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_requestID.Text = dgv_facility.CurrentRow.Cells(0).Value.ToString
        cb_facilityID.Text = dgv_facility.CurrentRow.Cells(1).Value.ToString
        cal_request.SetDate(Convert.ToDateTime(dgv_facility.CurrentRow.Cells(2).Value))
        txt_desc.Text = dgv_facility.CurrentRow.Cells(3).Value.ToString
        cb_boarderID.Text = dgv_facility.CurrentRow.Cells(4).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        'this was previously declared in the Public Class frmBorrower
        row = dgv_facility.CurrentRow.Index
        'the Add button is disabled and the Update and Delete buttons are enabled
        'the record that was chosen can either be edited or deleted (not added as a new record)
        btn_add.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        txt_requestID.Enabled = False
    End Sub
End Class