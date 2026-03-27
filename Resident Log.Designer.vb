<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResident_Log
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResident_Log))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_boarder = New System.Windows.Forms.ComboBox()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.txt_recordID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_timeout = New System.Windows.Forms.DateTimePicker()
        Me.cal_logdate = New System.Windows.Forms.MonthCalendar()
        Me.dtp_timein = New System.Windows.Forms.DateTimePicker()
        Me.dgv_log = New System.Windows.Forms.DataGridView()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MediumPurple
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1056, 30)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Resident Log"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_boarder)
        Me.GroupBox1.Controls.Add(Me.txt_remarks)
        Me.GroupBox1.Controls.Add(Me.txt_recordID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 242)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cb_boarder
        '
        Me.cb_boarder.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_boarder.FormattingEnabled = True
        Me.cb_boarder.Location = New System.Drawing.Point(264, 71)
        Me.cb_boarder.Name = "cb_boarder"
        Me.cb_boarder.Size = New System.Drawing.Size(172, 27)
        Me.cb_boarder.TabIndex = 8
        '
        'txt_remarks
        '
        Me.txt_remarks.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.Location = New System.Drawing.Point(264, 163)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(172, 50)
        Me.txt_remarks.TabIndex = 7
        '
        'txt_recordID
        '
        Me.txt_recordID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recordID.Location = New System.Drawing.Point(264, 30)
        Me.txt_recordID.Name = "txt_recordID"
        Me.txt_recordID.Size = New System.Drawing.Size(172, 26)
        Me.txt_recordID.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Remark:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Cambria", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(260, 116)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(15, 19)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "_"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Boarder Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BoarderID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RecordID (10000-99999):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtp_timeout)
        Me.GroupBox2.Controls.Add(Me.cal_logdate)
        Me.GroupBox2.Controls.Add(Me.dtp_timein)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(561, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 242)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(284, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 19)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Time Out:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(284, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Time In:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Log Date:"
        '
        'dtp_timeout
        '
        Me.dtp_timeout.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_timeout.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_timeout.Location = New System.Drawing.Point(288, 157)
        Me.dtp_timeout.Name = "dtp_timeout"
        Me.dtp_timeout.Size = New System.Drawing.Size(194, 23)
        Me.dtp_timeout.TabIndex = 2
        '
        'cal_logdate
        '
        Me.cal_logdate.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cal_logdate.Location = New System.Drawing.Point(29, 49)
        Me.cal_logdate.Name = "cal_logdate"
        Me.cal_logdate.TabIndex = 1
        '
        'dtp_timein
        '
        Me.dtp_timein.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_timein.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_timein.Location = New System.Drawing.Point(288, 59)
        Me.dtp_timein.Name = "dtp_timein"
        Me.dtp_timein.Size = New System.Drawing.Size(194, 23)
        Me.dtp_timein.TabIndex = 0
        '
        'dgv_log
        '
        Me.dgv_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_log.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_log.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_log.Location = New System.Drawing.Point(16, 305)
        Me.dgv_log.Name = "dgv_log"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_log.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_log.Size = New System.Drawing.Size(1056, 412)
        Me.dgv_log.TabIndex = 44
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Clear.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(794, 736)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(136, 53)
        Me.btn_Clear.TabIndex = 48
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Exit.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(936, 736)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(136, 53)
        Me.btn_Exit.TabIndex = 49
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Image = Global.BoardingHouse_.My.Resources.Resources.trash_bin_trash_svgrepo_com
        Me.btn_delete.Location = New System.Drawing.Point(300, 736)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(136, 53)
        Me.btn_delete.TabIndex = 47
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Image = Global.BoardingHouse_.My.Resources.Resources.update_svgrepo_com
        Me.btn_update.Location = New System.Drawing.Point(158, 736)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(136, 53)
        Me.btn_update.TabIndex = 46
        Me.btn_update.Text = "Update"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = Global.BoardingHouse_.My.Resources.Resources.add_circle_svgrepo_com
        Me.btn_add.Location = New System.Drawing.Point(16, 736)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(136, 53)
        Me.btn_add.TabIndex = 45
        Me.btn_add.Text = "Add"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'frmResident_Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 801)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_log)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResident_Log"
        Me.Text = "Resident Log"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtp_timein As DateTimePicker
    Friend WithEvents cb_boarder As ComboBox
    Friend WithEvents txt_remarks As TextBox
    Friend WithEvents txt_recordID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_timeout As DateTimePicker
    Friend WithEvents cal_logdate As MonthCalendar
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_log As DataGridView
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
End Class
