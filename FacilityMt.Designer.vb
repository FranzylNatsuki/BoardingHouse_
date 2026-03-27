<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacilityMt
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
        Me.components = New System.ComponentModel.Container()
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacilityMt))
        Me.cb_roomID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_facilityCost = New System.Windows.Forms.TextBox()
        Me.txt_facilityID = New System.Windows.Forms.TextBox()
        Me.txt_facilityName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dgv_facility = New System.Windows.Forms.DataGridView()
        Me.bsSearch = New System.Windows.Forms.BindingSource(Me.components)
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox1.SuspendLayout()
        CType(Me.dgv_facility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.Controls.Add(Me.cb_roomID)
        GroupBox1.Controls.Add(Me.Label6)
        GroupBox1.Controls.Add(Me.txt_facilityCost)
        GroupBox1.Controls.Add(Me.txt_facilityID)
        GroupBox1.Controls.Add(Me.txt_facilityName)
        GroupBox1.Controls.Add(Me.Label4)
        GroupBox1.Controls.Add(Me.Label3)
        GroupBox1.Controls.Add(Me.Label2)
        GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GroupBox1.Location = New System.Drawing.Point(21, 183)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(457, 228)
        GroupBox1.TabIndex = 35
        GroupBox1.TabStop = False
        GroupBox1.Text = "Information"
        '
        'cb_roomID
        '
        Me.cb_roomID.FormattingEnabled = True
        Me.cb_roomID.Location = New System.Drawing.Point(225, 163)
        Me.cb_roomID.Name = "cb_roomID"
        Me.cb_roomID.Size = New System.Drawing.Size(212, 27)
        Me.cb_roomID.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(36, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "RoomID:"
        '
        'txt_facilityCost
        '
        Me.txt_facilityCost.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_facilityCost.Location = New System.Drawing.Point(225, 123)
        Me.txt_facilityCost.Name = "txt_facilityCost"
        Me.txt_facilityCost.Size = New System.Drawing.Size(212, 26)
        Me.txt_facilityCost.TabIndex = 15
        '
        'txt_facilityID
        '
        Me.txt_facilityID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_facilityID.Location = New System.Drawing.Point(225, 39)
        Me.txt_facilityID.Name = "txt_facilityID"
        Me.txt_facilityID.Size = New System.Drawing.Size(212, 26)
        Me.txt_facilityID.TabIndex = 9
        '
        'txt_facilityName
        '
        Me.txt_facilityName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_facilityName.Location = New System.Drawing.Point(225, 79)
        Me.txt_facilityName.Name = "txt_facilityName"
        Me.txt_facilityName.Size = New System.Drawing.Size(212, 26)
        Me.txt_facilityName.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(36, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Facility Cost:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Facility Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "FacilityID (1000-9999):"
        '
        'txt_fsearch
        '
        Me.txt_fsearch.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fsearch.Location = New System.Drawing.Point(246, 117)
        Me.txt_fsearch.Name = "txt_fsearch"
        Me.txt_fsearch.Size = New System.Drawing.Size(212, 26)
        Me.txt_fsearch.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Search by Facility Name:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1063, 30)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Facility Maintanance"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Clear.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(802, 690)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(136, 53)
        Me.btn_Clear.TabIndex = 38
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Exit.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(944, 690)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(136, 53)
        Me.btn_Exit.TabIndex = 39
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Image = Global.BoardingHouse_.My.Resources.Resources.trash_bin_trash_svgrepo_com
        Me.btn_delete.Location = New System.Drawing.Point(301, 690)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(136, 53)
        Me.btn_delete.TabIndex = 37
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Image = Global.BoardingHouse_.My.Resources.Resources.update_svgrepo_com
        Me.btn_update.Location = New System.Drawing.Point(159, 690)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(136, 53)
        Me.btn_update.TabIndex = 36
        Me.btn_update.Text = "Update"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = Global.BoardingHouse_.My.Resources.Resources.add_circle_svgrepo_com
        Me.btn_add.Location = New System.Drawing.Point(17, 690)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(136, 53)
        Me.btn_add.TabIndex = 34
        Me.btn_add.Text = "Add"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_add.UseVisualStyleBackColor = True
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
        Me.dgv_facility.Location = New System.Drawing.Point(502, 117)
        Me.dgv_facility.Name = "dgv_facility"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_facility.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_facility.Size = New System.Drawing.Size(579, 547)
        Me.dgv_facility.TabIndex = 33
        '
        'frmFacilityMt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 757)
        Me.Controls.Add(Me.txt_fsearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(GroupBox1)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_facility)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFacilityMt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facility Maintanance"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(Me.dgv_facility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_fsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_facilityCost As TextBox
    Friend WithEvents txt_facilityID As TextBox
    Friend WithEvents txt_facilityName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_facility As DataGridView
    Friend WithEvents cb_roomID As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bsSearch As BindingSource
End Class
