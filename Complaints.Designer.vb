<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComplaints
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
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComplaints))
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.cal_request = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_facilityID = New System.Windows.Forms.ComboBox()
        Me.cb_boarderID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_requestID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_facility = New System.Windows.Forms.DataGridView()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox1.SuspendLayout()
        CType(Me.dgv_facility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.Controls.Add(Me.txt_desc)
        GroupBox1.Controls.Add(Me.cal_request)
        GroupBox1.Controls.Add(Me.Label1)
        GroupBox1.Controls.Add(Me.cb_facilityID)
        GroupBox1.Controls.Add(Me.cb_boarderID)
        GroupBox1.Controls.Add(Me.Label6)
        GroupBox1.Controls.Add(Me.txt_requestID)
        GroupBox1.Controls.Add(Me.Label4)
        GroupBox1.Controls.Add(Me.Label3)
        GroupBox1.Controls.Add(Me.Label2)
        GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GroupBox1.Location = New System.Drawing.Point(16, 67)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(471, 638)
        GroupBox1.TabIndex = 42
        GroupBox1.TabStop = False
        GroupBox1.Text = "Information"
        '
        'txt_desc
        '
        Me.txt_desc.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(226, 354)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(227, 256)
        Me.txt_desc.TabIndex = 21
        '
        'cal_request
        '
        Me.cal_request.Location = New System.Drawing.Point(225, 166)
        Me.cal_request.Name = "cal_request"
        Me.cal_request.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(36, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Request Description:"
        '
        'cb_facilityID
        '
        Me.cb_facilityID.FormattingEnabled = True
        Me.cb_facilityID.Location = New System.Drawing.Point(225, 79)
        Me.cb_facilityID.Name = "cb_facilityID"
        Me.cb_facilityID.Size = New System.Drawing.Size(227, 27)
        Me.cb_facilityID.TabIndex = 18
        '
        'cb_boarderID
        '
        Me.cb_boarderID.FormattingEnabled = True
        Me.cb_boarderID.Location = New System.Drawing.Point(225, 120)
        Me.cb_boarderID.Name = "cb_boarderID"
        Me.cb_boarderID.Size = New System.Drawing.Size(227, 27)
        Me.cb_boarderID.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(36, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Request Date:"
        '
        'txt_requestID
        '
        Me.txt_requestID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_requestID.Location = New System.Drawing.Point(225, 39)
        Me.txt_requestID.Name = "txt_requestID"
        Me.txt_requestID.Size = New System.Drawing.Size(227, 26)
        Me.txt_requestID.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(36, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "BoarderID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FacilityID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RequestID (1000-9999):"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightBlue
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1152, 30)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Facility Complaints and Requests"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_facility
        '
        Me.dgv_facility.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_facility.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_facility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_facility.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_facility.Location = New System.Drawing.Point(493, 77)
        Me.dgv_facility.Name = "dgv_facility"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_facility.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_facility.Size = New System.Drawing.Size(671, 628)
        Me.dgv_facility.TabIndex = 43
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Clear.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(886, 720)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(136, 53)
        Me.btn_Clear.TabIndex = 47
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Exit.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(1028, 720)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(136, 53)
        Me.btn_Exit.TabIndex = 48
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Image = Global.BoardingHouse_.My.Resources.Resources.trash_bin_trash_svgrepo_com
        Me.btn_delete.Location = New System.Drawing.Point(300, 720)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(136, 53)
        Me.btn_delete.TabIndex = 46
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Image = Global.BoardingHouse_.My.Resources.Resources.update_svgrepo_com
        Me.btn_update.Location = New System.Drawing.Point(158, 720)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(136, 53)
        Me.btn_update.TabIndex = 45
        Me.btn_update.Text = "Update"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = Global.BoardingHouse_.My.Resources.Resources.add_circle_svgrepo_com
        Me.btn_add.Location = New System.Drawing.Point(16, 720)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(136, 53)
        Me.btn_add.TabIndex = 44
        Me.btn_add.Text = "Add"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'frmComplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 795)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_facility)
        Me.Controls.Add(GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComplaints"
        Me.Text = "Complaints"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(Me.dgv_facility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cb_boarderID As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_requestID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_facilityID As ComboBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents cal_request As MonthCalendar
    Friend WithEvents dgv_facility As DataGridView
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
End Class
