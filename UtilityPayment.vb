Imports MySql.Data.MySqlClient

Public Class frmUtilityPayment
    'Create connection variable/object named "MyConnection"
    Dim MyConnection As Common.DbConnection
    'Create a Data Adapter variable/object
    '---A Data Adapter is the go-between for the connection object (MyConnection)
    'and the Dataset (borrowerDA)
    Dim boarderDA As New MySqlDataAdapter
    Dim utilityDA As New MySqlDataAdapter
    Dim paymentDA As New MySqlDataAdapter
    'Create a Dataset variable/object
    '---A Data Set is a place holder for the table in your database
    '---There should be one data set for each table in your database
    Dim boarderDS As New DataSet()
    Dim utilityDS As New DataSet()
    Dim paymentDS As New DataSet()
    'Declare the connection string and query variables/objects
    Dim MyConnectionString As String
    Dim boarderSQLQuery As String
    Dim utilitySQLQuery As String
    Dim paymentSQLQuery As String
    'We will use this later in the update and delete modules
    Dim row As Integer
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'declare a data table variable (borrDataTable) that will serve as a virtual table
        'where the tuples of the BORROWER table will be loaded
        Dim DataTable As DataTable = paymentDS.Tables("utility_payment")
        Dim newRow As DataRow
        Try
            'a new empty row will be created where the data in the textboxes will be stored
            'check the names of your textbox controls
            newRow = DataTable.NewRow()
            newRow("UtilityPayID") = txt_upayID.Text
            newRow("UtilityID") = txt_utilityID.Text
            newRow("UP_BoarderID") = txt_boarderID.Text
            newRow("PaymentDate") = cal_paymentDate.SelectionStart.Date
            newRow("Usage_") = txt_usage.Text
            newRow("AmountToPay") = txt_amount.Text
            'add the new record to the BORROWER table via the borrDataTable (virtual table)
            DataTable.Rows.Add(newRow)
            'update the borrower table with the inserted new record
            paymentDA.Update(paymentDS, "utility_payment")
            MsgBox("The record was successfully saved.", MsgBoxStyle.Information, "Utility Payment")
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub clear()
        txt_upayID.Clear()
        txt_utilityID.Clear()
        txt_boarderID.Clear()
        txt_usage.Clear()
        cal_paymentDate.SetDate(Date.Now)
        txt_amount.Clear()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'Declare dt as a temporary holder/table for the BORROWER table
        'Take note that we used the variable borrDataTable in the “Add Records” module
        Dim dt As DataTable = paymentDS.Tables("utility_payment")
        'try to execute the following codes
        Try
            'Using the row index of "row" from the dgvBorrower_MouseUp event, update the Tuple indicated by'"row" in the temporary table (dt) with data from the textboxes/combo box
            'The names in red and enclosed in double quotes are your attributes in phpMyAdmin
            'Take note of the spelling of your attributes because the name is case sensitive
            dt.Rows(row)("UtilityPayID") = txt_upayID.Text
            dt.Rows(row)("UtilityID") = txt_utilityID.Text
            dt.Rows(row)("UP_BoarderID") = txt_boarderID.Text
            dt.Rows(row)("PaymentDate") = cal_paymentDate.SelectionStart.Date
            dt.Rows(row)("Usage_") = txt_usage.Text
            dt.Rows(row)("AmountToPay") = txt_amount.Text
            'save permanently in the department table (in your database)
            paymentDA.Update(paymentDS, "utility_payment")
            'output an informative message to the user
            MsgBox("The changes in the record were successfully saved.", MsgBoxStyle.Information, "Utility Payment")
            'Clear out the text boxes/combo box for new input/s
            clear()
            'set the cursor on the first textbox (borrower number)
            txt_upayID.Focus()
            txt_upayID.Enabled = True
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
        Dim dt As DataTable = paymentDS.Tables("utility_payment")
        Dim answer As MsgBoxResult
        'confirmation message
        answer = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Utility Payment")
        If (answer = MsgBoxResult.Yes) Then
            Try
                'delete the record that is indicated by the "row" which was taken note of in dgvBorrower_MouseUp
                dt.Rows(row).Delete()
                'update the employee table with one less tuple
                paymentDA.Update(paymentDS, "utility_payment")
                'output an informational message to the user
                MsgBox("The record was successfully deleted.", MsgBoxStyle.Information, "Utility Payment")
                'Blank out the text boxes/combo box for new input/s
                clear()
                'set the cursor on the first textbox
                txt_upayID.Focus()
                txt_upayID.Enabled = True
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
            txt_upayID.Focus()
            txt_upayID.Enabled = True
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

    Private Sub frmUtilityPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyConnectionString = "datasource=localhost;username=root;password=;database=boardinghouse"
        'Note that we have already discussed SQL in our previous lecture
        'This query is assigned to the borrSQLQuery variable and will be used in your DataGridView control/object
        boarderSQLQuery = "SELECT * FROM boarder ORDER BY LastName"
        utilitySQLQuery = "SELECT * FROM utility ORDER BY UtilityName"
        paymentSQLQuery = "SELECT * FROM utility_payment"
        'Create a connection to your database using the connection string specified in the first statement above
        MyConnection = New MySqlConnection(MyConnectionString)
        'Disable the MainMenu form so it cannot be clicked when another form is loaded
        'Also, disable the Edit/Update and Delete buttons (use the object names that you have in your form)
        'btn_update.Enabled = False
        'btn_delete.Enabled = False

        Try
            'Open the connection to the database
            MyConnection.Open()
            'Create a new SQL command based on the SQL query above and place in or assign to the data adapter
            boarderDA.SelectCommand = New MySqlCommand(boarderSQLQuery, MyConnection)
            utilityDA.SelectCommand = New MySqlCommand(utilitySQLQuery, MyConnection)
            paymentDA.SelectCommand = New MySqlCommand(paymentSQLQuery, MyConnection)
            'Create the command builder for adding a record to/updating the BORROWER table
            Dim cb1 As MySqlCommandBuilder = New MySqlCommandBuilder(paymentDA)
            'Populate the dataset "borrDataSet" (virtual table) with data from the database table (BORROWER—see phpmyadmin)
            boarderDA.Fill(boarderDS, "boarder")
            utilityDA.Fill(utilityDS, "utility")
            paymentDA.Fill(paymentDS, "utility_payment")
            'Show the borrower records in the datagridview control
            'The source of the data is colDataSet which was populated with records from the previous command
            dgv_boarder.DataSource = boarderDS
            dgv_boarder.DataMember = "boarder"
            dgv_boarder.AutoResizeColumns()
            'set the headers of the columns
            'modify this based on the number of attributes you have in the BORROWER table; attribute 1 starts at column 0

            dgv_utility.DataSource = utilityDS
            dgv_utility.DataMember = "utility"
            dgv_utility.AutoResizeColumns()
            'set the headers of the columns
            'modify this based on the number of attributes you have in the BORROWER table; attribute 1 starts at column 0

            dgv_upay.DataSource = paymentDS
            dgv_upay.DataMember = "utility_payment"
            dgv_upay.AutoResizeColumns()
            'set the headers of the columns
            'modify this based on the number of attributes you have in the BORROWER table; attribute 1 starts at column 0

        Catch ex As Common.DbException
            'In case of an error, output the standard error message
            MsgBox(ex.ToString)
        Finally
            'close the connection to the database
            MyConnection.Close()
        End Try
    End Sub

    Private Sub frmUtilityPayment_Click(sender As Object, e As EventArgs) Handles Me.Click
        btn_add.Enabled = True
        btn_delete.Enabled = False
        btn_update.Enabled = False
        txt_upayID.Enabled = True
        txt_boarderID.Enabled = True
        txt_utilityID.Enabled = True
        clear()
    End Sub

    Private Sub dgv_boarder_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_boarder.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_boarderID.Text = dgv_boarder.CurrentRow.Cells(0).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        row = dgv_boarder.CurrentRow.Index
        txt_boarderID.Enabled = False
    End Sub

    Private Sub dgv_utility_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_utility.MouseUp
        txt_utilityID.Text = dgv_utility.CurrentRow.Cells(0).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        row = dgv_utility.CurrentRow.Index
        txt_utilityID.Enabled = False
    End Sub

    Private Sub dgv_upay_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_upay.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_upayID.Text = dgv_upay.CurrentRow.Cells(0).Value.ToString
        txt_utilityID.Text = dgv_upay.CurrentRow.Cells(1).Value.ToString
        txt_boarderID.Text = dgv_upay.CurrentRow.Cells(2).Value.ToString
        If Not IsDBNull(dgv_upay.CurrentRow.Cells(3).Value) Then
            cal_paymentDate.SetDate(Convert.ToDateTime(dgv_upay.CurrentRow.Cells(3).Value))
        End If
        txt_usage.Text = dgv_upay.CurrentRow.Cells(4).Value.ToString
        txt_amount.Text = dgv_upay.CurrentRow.Cells(5).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        'this was previously declared in the Public Class frmBorrower
        row = dgv_upay.CurrentRow.Index
        'the Add button is disabled and the Update and Delete buttons are enabled
        'the record that was chosen can either be edited or deleted (not added as a new record)
        btn_add.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        txt_upayID.Enabled = False
    End Sub

    Private Sub txt_usage_TextChanged(sender As Object, e As EventArgs) Handles txt_usage.TextChanged
        If txt_usage.Text = "" Or txt_utilityID.Text = "" Then
            txt_amount.Clear()
            Exit Sub
        End If

        Dim usage As Double

        ' validate input
        If Not Double.TryParse(txt_usage.Text, usage) Then
            txt_amount.Clear()
            Exit Sub
        End If

        Dim dt As DataTable = utilityDS.Tables("utility")

        For Each r As DataRow In dt.Rows
            If r("UtilityID").ToString() = txt_utilityID.Text Then

                Dim rate As Double = Convert.ToDouble(r("UnitRate"))
                Dim total As Double = usage * rate

                txt_amount.Text = total.ToString("0.00")
                Exit For

            End If
        Next
    End Sub
End Class