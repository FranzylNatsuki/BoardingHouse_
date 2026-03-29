Imports MySql.Data.MySqlClient

Public Class frmResident_Log
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
    Private Sub frmResident_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_update.Enabled = False
        btn_delete.Enabled = False
        'Specify the connection string and the query
        MyConnectionString = "server=localhost;user id=root;password=;database=boardinghouse;"
        'Note that we have already discussed SQL in our previous lecture
        'Create a connection to your database using the connection string specified in the first statement above
        commonSQLQuery = "SELECT * FROM resident_log ORDER BY LogDate"
        MyConnection = New MySqlConnection(MyConnectionString)

        ComboBoxContent()
        cb_boarder.SelectedIndex = -1
        lbl_name.Text = "_"

        baseDS.Tables.Clear()
        baseDA = New MySqlDataAdapter()
        Try
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If

            baseDA.SelectCommand = New MySqlCommand(commonSQLQuery, MyConnection)
            Dim cb1 As MySqlCommandBuilder = New MySqlCommandBuilder(baseDA)
            baseDA.Fill(baseDS, "resident_log")
            dgv_log.DataSource = baseDS
            dgv_log.DataMember = "resident_log"
            dgv_log.AutoResizeColumns()
        Catch ex As Common.DbException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub ComboBoxContent()
        Dim dt As New DataTable()
        Dim Query As String = "SELECT BoarderID FROM boarder"

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If

        Dim adapter As New MySqlDataAdapter(Query, MyConnection)
        adapter.Fill(dt)

        cb_boarder.DataSource = dt
        cb_boarder.DisplayMember = "BoarderID"
        cb_boarder.ValueMember = "BoarderID"
        MyConnection.Close()
    End Sub

    Private Sub clear()
        txt_recordID.Clear()
        txt_remarks.Clear()
        cal_logdate.SetDate(DateTime.Today)
        dtp_timein.Value = DateTime.Now
        dtp_timeout.Value = DateTime.Now
        cb_boarder.SelectedIndex = -1
        cb_boarder.SelectedItem = Nothing
        cb_boarder.Text = ""
        lbl_name.Text = "_"
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim baseDT As DataTable = baseDS.Tables("resident_log")
        Dim newRow As DataRow
        Try
            'a new empty row will be created where the data in the textboxes will be stored
            'check the names of your textbox controls
            newRow = baseDT.NewRow()
            newRow("RecordID") = txt_recordID.Text
            newRow("LogDate") = cal_logdate.SelectionStart.Date
            newRow("TimeIn") = dtp_timein.Value.ToString("HH:mm:ss")
            newRow("TimeOut") = dtp_timeout.Value.ToString("HH:mm:ss")
            newRow("Remarks") = txt_remarks.Text
            newRow("BoarderID") = cb_boarder.Text
            'add the new record to the BORROWER table via the borrDataTable (virtual table)
            baseDT.Rows.Add(newRow)
            'update the borrower table with the inserted new record
            baseDA.Update(baseDS, "resident_log")
            'output a pop-up message (informative) on screen
            MsgBox("The record was successfully saved.", MsgBoxStyle.Information, "Resident Log")
            'clear the textboxes and the combobox
            clear()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'Declare dt as a temporary holder/table for the BORROWER table
        'Take note that we used the variable borrDataTable in the “Add Records” module
        Dim dt As DataTable = baseDS.Tables("resident_log")
        'try to execute the following codes
        Try
            'Using the row index of "row" from the dgvBorrower_MouseUp event, update the Tuple indicated by'"row" in the temporary table (dt) with data from the textboxes/combo box
            'The names in red and enclosed in double quotes are your attributes in phpMyAdmin
            'Take note of the spelling of your attributes because the name is case sensitive
            dt.Rows(row)("RecordID") = txt_recordID.Text
            dt.Rows(row)("LogDate") = cal_logdate.SelectionStart.Date
            dt.Rows(row)("TimeIn") = dtp_timein.Value.ToString("HH:mm:ss")
            dt.Rows(row)("TimeOut") = dtp_timeout.Value.ToString("HH:mm:ss")
            dt.Rows(row)("Remarks") = txt_remarks.Text
            dt.Rows(row)("BoarderID") = cb_boarder.Text
            'save permanently in the department table (in your database)
            baseDA.Update(baseDS, "resident_log")
            'output an informative message to the user
            MsgBox("The changes in the record were successfully saved.", MsgBoxStyle.Information, "Resident Log")
            'Clear out the text boxes/combo box for new input/s
            clear()
            'set the cursor on the first textbox (borrower number)
            txt_recordID.Focus()
            txt_recordID.Enabled = True
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
        Dim dt As DataTable = baseDS.Tables("resident_log")
        Dim answer As MsgBoxResult
        'confirmation message
        answer = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Resident Log")
        If (answer = MsgBoxResult.Yes) Then
            Try
                'delete the record that is indicated by the "row" which was taken note of in dgvBorrower_MouseUp
                dt.Rows(row).Delete()
                'update the employee table with one less tuple
                baseDA.Update(baseDS, "resident_log")
                'output an informational message to the user
                MsgBox("The record was successfully deleted.", MsgBoxStyle.Information, "Resident Log")
                'Blank out the text boxes/combo box for new input/s
                clear()
                'set the cursor on the first textbox
                txt_recordID.Focus()
                txt_recordID.Enabled = True
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
            txt_recordID.Focus()
            txt_recordID.Enabled = True
            btn_add.Enabled = True
            btn_delete.Enabled = False
            btn_update.Enabled = False
        End If
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        lbl_name.Text = "_"
        clear()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub cb_boarder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_boarder.SelectedIndexChanged
        If cb_boarder.SelectedValue Is Nothing Then Exit Sub

        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If

        Dim cmd As New MySqlCommand("SELECT FirstName, LastName FROM boarder WHERE BoarderID = @id", MyConnection)
        cmd.Parameters.AddWithValue("@id", cb_boarder.SelectedValue)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            lbl_name.Text = reader("FirstName").ToString() & " " & reader("LastName").ToString()
        End If

        reader.Close()
        MyConnection.Close()
    End Sub

    Private Sub dgv_log_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_log.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_recordID.Text = dgv_log.CurrentRow.Cells(0).Value.ToString
        If dgv_log.CurrentRow.Cells(1).Value IsNot DBNull.Value Then
            cal_logdate.SetDate(Convert.ToDateTime(dgv_log.CurrentRow.Cells(1).Value))
        Else
            cal_logdate.SetDate(DateTime.Today)
        End If
        Dim timeIn As TimeSpan = CType(dgv_log.CurrentRow.Cells(2).Value, TimeSpan)
        dtp_timein.Value = DateTime.Today.Add(timeIn)
        Dim timeOut As TimeSpan = CType(dgv_log.CurrentRow.Cells(3).Value, TimeSpan)
        dtp_timeout.Value = DateTime.Today.Add(timeOut)
        txt_remarks.Text = dgv_log.CurrentRow.Cells(4).Value.ToString
        cb_boarder.Text = dgv_log.CurrentRow.Cells(5).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        'this was previously declared in the Public Class frmBorrower
        row = dgv_log.CurrentRow.Index
        'the Add button is disabled and the Update and Delete buttons are enabled
        'the record that was chosen can either be edited or deleted (not added as a new record)
        btn_add.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        txt_recordID.Enabled = False
    End Sub

    Private Sub frmResident_Log_Click(sender As Object, e As EventArgs) Handles Me.Click
        btn_add.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        txt_recordID.Enabled = True
        lbl_name.Text = "_"
        clear()
    End Sub
End Class