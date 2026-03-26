<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BoarderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoarderMaintananceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomMaintananceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacilityMaintananceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityMaintananceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentTerminationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_dash_term = New System.Windows.Forms.Button()
        Me.btn_dash_boarders = New System.Windows.Forms.Button()
        Me.btn_dash_payments = New System.Windows.Forms.Button()
        Me.btn_dash_utilities = New System.Windows.Forms.Button()
        Me.btn_dash_fc = New System.Windows.Forms.Button()
        Me.btn_dash_rooms = New System.Windows.Forms.Button()
        Me.dgv_dashboard = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_termination = New System.Windows.Forms.Label()
        Me.lbl_fc_count = New System.Windows.Forms.Label()
        Me.lbl_boardercount = New System.Windows.Forms.Label()
        Me.lbl_occupied = New System.Windows.Forms.Label()
        Me.lbl_unoccupied = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_dashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoarderToolStripMenuItem, Me.FacilityToolStripMenuItem, Me.UtilitiesToolStripMenuItem, Me.LeaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1235, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BoarderToolStripMenuItem
        '
        Me.BoarderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoarderMaintananceToolStripMenuItem, Me.RoomMaintananceToolStripMenuItem, Me.UtilityManagementToolStripMenuItem})
        Me.BoarderToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoarderToolStripMenuItem.Name = "BoarderToolStripMenuItem"
        Me.BoarderToolStripMenuItem.Size = New System.Drawing.Size(53, 23)
        Me.BoarderToolStripMenuItem.Text = "Rent"
        '
        'BoarderMaintananceToolStripMenuItem
        '
        Me.BoarderMaintananceToolStripMenuItem.Name = "BoarderMaintananceToolStripMenuItem"
        Me.BoarderMaintananceToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.BoarderMaintananceToolStripMenuItem.Text = "Boarder Maintanance"
        '
        'RoomMaintananceToolStripMenuItem
        '
        Me.RoomMaintananceToolStripMenuItem.Name = "RoomMaintananceToolStripMenuItem"
        Me.RoomMaintananceToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.RoomMaintananceToolStripMenuItem.Text = "Room Maintanance"
        '
        'UtilityManagementToolStripMenuItem
        '
        Me.UtilityManagementToolStripMenuItem.Name = "UtilityManagementToolStripMenuItem"
        Me.UtilityManagementToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.UtilityManagementToolStripMenuItem.Text = "Utility Management"
        '
        'FacilityToolStripMenuItem
        '
        Me.FacilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacilityMaintananceToolStripMenuItem, Me.ComplaintsToolStripMenuItem})
        Me.FacilityToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilityToolStripMenuItem.Name = "FacilityToolStripMenuItem"
        Me.FacilityToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.FacilityToolStripMenuItem.Text = "Facility"
        '
        'FacilityMaintananceToolStripMenuItem
        '
        Me.FacilityMaintananceToolStripMenuItem.Name = "FacilityMaintananceToolStripMenuItem"
        Me.FacilityMaintananceToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.FacilityMaintananceToolStripMenuItem.Text = "Facility Maintanance"
        '
        'ComplaintsToolStripMenuItem
        '
        Me.ComplaintsToolStripMenuItem.Name = "ComplaintsToolStripMenuItem"
        Me.ComplaintsToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.ComplaintsToolStripMenuItem.Text = "Complaints"
        '
        'UtilitiesToolStripMenuItem
        '
        Me.UtilitiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilityMaintananceToolStripMenuItem, Me.UtilityPaymentToolStripMenuItem})
        Me.UtilitiesToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UtilitiesToolStripMenuItem.Name = "UtilitiesToolStripMenuItem"
        Me.UtilitiesToolStripMenuItem.Size = New System.Drawing.Size(72, 23)
        Me.UtilitiesToolStripMenuItem.Text = "Utilities"
        '
        'UtilityMaintananceToolStripMenuItem
        '
        Me.UtilityMaintananceToolStripMenuItem.Name = "UtilityMaintananceToolStripMenuItem"
        Me.UtilityMaintananceToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.UtilityMaintananceToolStripMenuItem.Text = "Utility Maintanance"
        '
        'UtilityPaymentToolStripMenuItem
        '
        Me.UtilityPaymentToolStripMenuItem.Name = "UtilityPaymentToolStripMenuItem"
        Me.UtilityPaymentToolStripMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.UtilityPaymentToolStripMenuItem.Text = "Utility Payment"
        '
        'LeaseToolStripMenuItem
        '
        Me.LeaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RentPaymentToolStripMenuItem, Me.RentTerminationToolStripMenuItem})
        Me.LeaseToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeaseToolStripMenuItem.Name = "LeaseToolStripMenuItem"
        Me.LeaseToolStripMenuItem.Size = New System.Drawing.Size(61, 23)
        Me.LeaseToolStripMenuItem.Text = "Lease"
        '
        'RentPaymentToolStripMenuItem
        '
        Me.RentPaymentToolStripMenuItem.Name = "RentPaymentToolStripMenuItem"
        Me.RentPaymentToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.RentPaymentToolStripMenuItem.Text = "Rent Payment"
        '
        'RentTerminationToolStripMenuItem
        '
        Me.RentTerminationToolStripMenuItem.Name = "RentTerminationToolStripMenuItem"
        Me.RentTerminationToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.RentTerminationToolStripMenuItem.Text = "Rent Termination"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_dash_term)
        Me.Panel1.Controls.Add(Me.btn_dash_boarders)
        Me.Panel1.Controls.Add(Me.btn_dash_payments)
        Me.Panel1.Controls.Add(Me.btn_dash_utilities)
        Me.Panel1.Controls.Add(Me.btn_dash_fc)
        Me.Panel1.Controls.Add(Me.btn_dash_rooms)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 670)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.Button1.Size = New System.Drawing.Size(183, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Close App"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_dash_term
        '
        Me.btn_dash_term.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_dash_term.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dash_term.Image = Global.BoardingHouse_.My.Resources.Resources.contract_termination_line_svgrepo_com
        Me.btn_dash_term.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_term.Location = New System.Drawing.Point(12, 260)
        Me.btn_dash_term.Name = "btn_dash_term"
        Me.btn_dash_term.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.btn_dash_term.Size = New System.Drawing.Size(183, 43)
        Me.btn_dash_term.TabIndex = 8
        Me.btn_dash_term.Text = "&Termination"
        Me.btn_dash_term.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_term.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash_term.UseVisualStyleBackColor = False
        '
        'btn_dash_boarders
        '
        Me.btn_dash_boarders.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_dash_boarders.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dash_boarders.Image = Global.BoardingHouse_.My.Resources.Resources.person_silhouette_svgrepo_com__1_
        Me.btn_dash_boarders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_boarders.Location = New System.Drawing.Point(12, 13)
        Me.btn_dash_boarders.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_dash_boarders.Name = "btn_dash_boarders"
        Me.btn_dash_boarders.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.btn_dash_boarders.Size = New System.Drawing.Size(183, 43)
        Me.btn_dash_boarders.TabIndex = 7
        Me.btn_dash_boarders.Text = "&Boarders"
        Me.btn_dash_boarders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_boarders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash_boarders.UseVisualStyleBackColor = False
        '
        'btn_dash_payments
        '
        Me.btn_dash_payments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_dash_payments.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dash_payments.Image = Global.BoardingHouse_.My.Resources.Resources.money_dollar_svgrepo_com
        Me.btn_dash_payments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_payments.Location = New System.Drawing.Point(12, 211)
        Me.btn_dash_payments.Name = "btn_dash_payments"
        Me.btn_dash_payments.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.btn_dash_payments.Size = New System.Drawing.Size(183, 43)
        Me.btn_dash_payments.TabIndex = 6
        Me.btn_dash_payments.Text = "&Payments"
        Me.btn_dash_payments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_payments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash_payments.UseVisualStyleBackColor = False
        '
        'btn_dash_utilities
        '
        Me.btn_dash_utilities.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_dash_utilities.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dash_utilities.Image = Global.BoardingHouse_.My.Resources.Resources.electricity_svgrepo_com
        Me.btn_dash_utilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_utilities.Location = New System.Drawing.Point(12, 162)
        Me.btn_dash_utilities.Name = "btn_dash_utilities"
        Me.btn_dash_utilities.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.btn_dash_utilities.Size = New System.Drawing.Size(183, 43)
        Me.btn_dash_utilities.TabIndex = 5
        Me.btn_dash_utilities.Text = "&Utilities"
        Me.btn_dash_utilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_utilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash_utilities.UseVisualStyleBackColor = False
        '
        'btn_dash_fc
        '
        Me.btn_dash_fc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_dash_fc.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dash_fc.Image = Global.BoardingHouse_.My.Resources.Resources.clipboard_list_svgrepo_com
        Me.btn_dash_fc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_fc.Location = New System.Drawing.Point(12, 113)
        Me.btn_dash_fc.Name = "btn_dash_fc"
        Me.btn_dash_fc.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.btn_dash_fc.Size = New System.Drawing.Size(183, 43)
        Me.btn_dash_fc.TabIndex = 4
        Me.btn_dash_fc.Text = "&Facility Complaints"
        Me.btn_dash_fc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_fc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash_fc.UseVisualStyleBackColor = False
        '
        'btn_dash_rooms
        '
        Me.btn_dash_rooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_dash_rooms.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dash_rooms.Image = CType(resources.GetObject("btn_dash_rooms.Image"), System.Drawing.Image)
        Me.btn_dash_rooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_rooms.Location = New System.Drawing.Point(12, 64)
        Me.btn_dash_rooms.Name = "btn_dash_rooms"
        Me.btn_dash_rooms.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.btn_dash_rooms.Size = New System.Drawing.Size(183, 43)
        Me.btn_dash_rooms.TabIndex = 3
        Me.btn_dash_rooms.Text = "&Rooms"
        Me.btn_dash_rooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash_rooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash_rooms.UseVisualStyleBackColor = False
        '
        'dgv_dashboard
        '
        Me.dgv_dashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dashboard.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_dashboard.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_dashboard.Location = New System.Drawing.Point(254, 265)
        Me.dgv_dashboard.Name = "dgv_dashboard"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dashboard.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_dashboard.Size = New System.Drawing.Size(969, 446)
        Me.dgv_dashboard.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(974, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DASHBOARD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Boarder Count:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Occupied Rooms:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(249, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unoccupied Rooms:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(713, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Facility Complaints:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(713, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Terminations To Clear:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "View"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(250, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "View"
        '
        'lbl_termination
        '
        Me.lbl_termination.AutoSize = True
        Me.lbl_termination.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_termination.ForeColor = System.Drawing.Color.Red
        Me.lbl_termination.Location = New System.Drawing.Point(884, 143)
        Me.lbl_termination.Name = "lbl_termination"
        Me.lbl_termination.Size = New System.Drawing.Size(15, 19)
        Me.lbl_termination.TabIndex = 11
        Me.lbl_termination.Text = "_"
        '
        'lbl_fc_count
        '
        Me.lbl_fc_count.AutoSize = True
        Me.lbl_fc_count.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fc_count.ForeColor = System.Drawing.Color.Red
        Me.lbl_fc_count.Location = New System.Drawing.Point(861, 103)
        Me.lbl_fc_count.Name = "lbl_fc_count"
        Me.lbl_fc_count.Size = New System.Drawing.Size(15, 19)
        Me.lbl_fc_count.TabIndex = 12
        Me.lbl_fc_count.Text = "_"
        '
        'lbl_boardercount
        '
        Me.lbl_boardercount.AutoSize = True
        Me.lbl_boardercount.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_boardercount.Location = New System.Drawing.Point(371, 103)
        Me.lbl_boardercount.Name = "lbl_boardercount"
        Me.lbl_boardercount.Size = New System.Drawing.Size(15, 19)
        Me.lbl_boardercount.TabIndex = 13
        Me.lbl_boardercount.Text = "_"
        '
        'lbl_occupied
        '
        Me.lbl_occupied.AutoSize = True
        Me.lbl_occupied.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_occupied.Location = New System.Drawing.Point(384, 143)
        Me.lbl_occupied.Name = "lbl_occupied"
        Me.lbl_occupied.Size = New System.Drawing.Size(15, 19)
        Me.lbl_occupied.TabIndex = 14
        Me.lbl_occupied.Text = "_"
        '
        'lbl_unoccupied
        '
        Me.lbl_unoccupied.AutoSize = True
        Me.lbl_unoccupied.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unoccupied.Location = New System.Drawing.Point(401, 186)
        Me.lbl_unoccupied.Name = "lbl_unoccupied"
        Me.lbl_unoccupied.Size = New System.Drawing.Size(15, 19)
        Me.lbl_unoccupied.TabIndex = 15
        Me.lbl_unoccupied.Text = "_"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 733)
        Me.Controls.Add(Me.lbl_unoccupied)
        Me.Controls.Add(Me.lbl_occupied)
        Me.Controls.Add(Me.lbl_boardercount)
        Me.Controls.Add(Me.lbl_fc_count)
        Me.Controls.Add(Me.lbl_termination)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_dashboard)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BoarderBase"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_dashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BoarderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoarderMaintananceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomMaintananceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilityManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacilityMaintananceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComplaintsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilitiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilityMaintananceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilityPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentTerminationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_dash_payments As Button
    Friend WithEvents btn_dash_utilities As Button
    Friend WithEvents btn_dash_fc As Button
    Friend WithEvents btn_dash_rooms As Button
    Friend WithEvents btn_dash_boarders As Button
    Friend WithEvents dgv_dashboard As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_dash_term As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_termination As Label
    Friend WithEvents lbl_fc_count As Label
    Friend WithEvents lbl_boardercount As Label
    Friend WithEvents lbl_occupied As Label
    Friend WithEvents lbl_unoccupied As Label
    Friend WithEvents Button1 As Button
End Class
