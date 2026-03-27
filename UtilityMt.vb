Imports MySql.Data.MySqlClient

Public Class frmUtilityMt
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
    Private Sub UtilityMt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_update.Enabled = False
        btn_delete.Enabled = False
        'Specify the connection string and the query
        MyConnectionString = "server=localhost;user id=root;password=;database=boardinghouse;"
        'Note that we have already discussed SQL in our previous lecture
        'Create a connection to your database using the connection string specified in the first statement above
        commonSQLQuery = "SELECT * FROM utility ORDER BY UtilityName"
        MyConnection = New MySqlConnection(MyConnectionString)

        baseDS.Tables.Clear()
        baseDA = New MySqlDataAdapter()
        Try
            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If

            baseDA.SelectCommand = New MySqlCommand(commonSQLQuery, MyConnection)
            Dim cb1 As MySqlCommandBuilder = New MySqlCommandBuilder(baseDA)
            baseDA.Fill(baseDS, "utility")
            dgv_utility.DataSource = baseDS
            dgv_utility.DataMember = "utility"
            dgv_utility.AutoResizeColumns()
        Catch ex As Common.DbException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim baseDT As DataTable = baseDS.Tables("utility")
        Dim newRow As DataRow
        Try
            'a new empty row will be created where the data in the textboxes will be stored
            'check the names of your textbox controls
            newRow = baseDT.NewRow()
            newRow("UtilityID") = txt_utilityID.Text
            newRow("UtilityName") = txt_utilityName.Text
            newRow("UnitRate") = txt_unitRate.Text
            'add the new record to the BORROWER table via the borrDataTable (virtual table)
            baseDT.Rows.Add(newRow)
            'update the borrower table with the inserted new record
            baseDA.Update(baseDS, "utility")
            'output a pop-up message (informative) on screen
            MsgBox("The record was successfully saved.", MsgBoxStyle.Information, "Utility Maintanance")
            'clear the textboxes and the combobox
            clear()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'Declare dt as a temporary holder/table for the BORROWER table
        'Take note that we used the variable borrDataTable in the “Add Records” module
        Dim dt As DataTable = baseDS.Tables("utility")
        'try to execute the following codes
        Try
            'Using the row index of "row" from the dgvBorrower_MouseUp event, update the Tuple indicated by'"row" in the temporary table (dt) with data from the textboxes/combo box
            'The names in red and enclosed in double quotes are your attributes in phpMyAdmin
            'Take note of the spelling of your attributes because the name is case sensitive
            dt.Rows(row)("UtilityID") = txt_utilityID.Text
            dt.Rows(row)("UtilityName") = txt_utilityName.Text
            dt.Rows(row)("UnitRate") = txt_unitRate.Text
            'save permanently in the department table (in your database)
            baseDA.Update(baseDS, "utility")
            'output an informative message to the user
            MsgBox("The changes in the record were successfully saved.", MsgBoxStyle.Information, "Utility Maintanance")
            'Clear out the text boxes/combo box for new input/s
            clear()
            'set the cursor on the first textbox (borrower number)
            txt_utilityID.Focus()
            txt_utilityID.Enabled = True
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
        Dim dt As DataTable = baseDS.Tables("utility")
        Dim answer As MsgBoxResult
        'confirmation message
        answer = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Utility Maintanance")
        If (answer = MsgBoxResult.Yes) Then
            Try
                'delete the record that is indicated by the "row" which was taken note of in dgvBorrower_MouseUp
                dt.Rows(row).Delete()
                'update the employee table with one less tuple
                baseDA.Update(baseDS, "utility")
                'output an informational message to the user
                MsgBox("The record was successfully deleted.", MsgBoxStyle.Information, "Utility Maintanance")
                'Blank out the text boxes/combo box for new input/s
                clear()
                'set the cursor on the first textbox
                txt_utilityID.Focus()
                txt_utilityID.Enabled = True
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
            txt_utilityID.Focus()
            txt_utilityID.Enabled = True
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

    Private Sub clear()
        txt_utilityID.Clear()
        txt_utilityName.Clear()
        txt_unitRate.Clear()
        txt_utilitysearch.Clear()
    End Sub

    Private Sub dgv_utility_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_utility.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_utilityID.Text = dgv_utility.CurrentRow.Cells(0).Value.ToString
        txt_utilityName.Text = dgv_utility.CurrentRow.Cells(1).Value.ToString
        txt_unitRate.Text = dgv_utility.CurrentRow.Cells(2).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        'this was previously declared in the Public Class frmBorrower
        row = dgv_utility.CurrentRow.Index
        'the Add button is disabled and the Update and Delete buttons are enabled
        'the record that was chosen can either be edited or deleted (not added as a new record)
        btn_add.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        txt_utilityID.Enabled = False
    End Sub

    Private Sub frmUtilityMt_Click(sender As Object, e As EventArgs) Handles Me.Click
        btn_add.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        txt_utilityID.Enabled = True
        clear()
    End Sub

    Private Sub txt_utilitysearch_TextChanged(sender As Object, e As EventArgs) Handles txt_utilitysearch.TextChanged
        'declare a data table that will hold the content of the borrower table
        Dim dt As DataTable = baseDS.Tables("utility")
        'connect the data table as the data source of the BindingSource control (bsSearchBorrower)
        bsSearch.DataSource = dt
        'set the data source of the DataGridView control (dgvBorrower) to the BindingSource
        dgv_utility.DataSource = bsSearch
        'filter the BindingSource with every change that happens in the textbox (TextChangedEvent)
        Dim search As String = txt_utilitysearch.Text

        search = search.Replace("'", "''")
        search = search.Replace("[", "[[]")
        search = search.Replace("%", "[%]")
        search = search.Replace("_", "[_]")

        bsSearch.Filter = $"UtilityName LIKE '{search}%'"
    End Sub
End Class