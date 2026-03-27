<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilityMt
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_unitRate = New System.Windows.Forms.TextBox()
        Me.txt_utilityID = New System.Windows.Forms.TextBox()
        Me.txt_utilityName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_utilitysearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dgv_utility = New System.Windows.Forms.DataGridView()
        Me.bsSearch = New System.Windows.Forms.BindingSource(Me.components)
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox1.SuspendLayout()
        CType(Me.dgv_utility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.Controls.Add(Me.txt_unitRate)
        GroupBox1.Controls.Add(Me.txt_utilityID)
        GroupBox1.Controls.Add(Me.txt_utilityName)
        GroupBox1.Controls.Add(Me.Label4)
        GroupBox1.Controls.Add(Me.Label3)
        GroupBox1.Controls.Add(Me.Label2)
        GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GroupBox1.Location = New System.Drawing.Point(18, 182)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(457, 190)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        GroupBox1.Text = "Information"
        '
        'txt_unitRate
        '
        Me.txt_unitRate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unitRate.Location = New System.Drawing.Point(225, 123)
        Me.txt_unitRate.Name = "txt_unitRate"
        Me.txt_unitRate.Size = New System.Drawing.Size(212, 26)
        Me.txt_unitRate.TabIndex = 15
        '
        'txt_utilityID
        '
        Me.txt_utilityID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_utilityID.Location = New System.Drawing.Point(225, 39)
        Me.txt_utilityID.Name = "txt_utilityID"
        Me.txt_utilityID.Size = New System.Drawing.Size(212, 26)
        Me.txt_utilityID.TabIndex = 9
        '
        'txt_utilityName
        '
        Me.txt_utilityName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_utilityName.Location = New System.Drawing.Point(225, 79)
        Me.txt_utilityName.Name = "txt_utilityName"
        Me.txt_utilityName.Size = New System.Drawing.Size(212, 26)
        Me.txt_utilityName.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(36, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Unit Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Utility Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "UtilityID (1000-9999):"
        '
        'txt_utilitysearch
        '
        Me.txt_utilitysearch.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_utilitysearch.Location = New System.Drawing.Point(243, 116)
        Me.txt_utilitysearch.Name = "txt_utilitysearch"
        Me.txt_utilitysearch.Size = New System.Drawing.Size(212, 26)
        Me.txt_utilitysearch.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Search by Utility Name:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1063, 30)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Utility Maintanance"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Clear.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(799, 689)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(136, 53)
        Me.btn_Clear.TabIndex = 28
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Exit.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(941, 689)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(136, 53)
        Me.btn_Exit.TabIndex = 29
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Image = Global.BoardingHouse_.My.Resources.Resources.trash_bin_trash_svgrepo_com
        Me.btn_delete.Location = New System.Drawing.Point(298, 689)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(136, 53)
        Me.btn_delete.TabIndex = 27
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Image = Global.BoardingHouse_.My.Resources.Resources.update_svgrepo_com
        Me.btn_update.Location = New System.Drawing.Point(156, 689)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(136, 53)
        Me.btn_update.TabIndex = 26
        Me.btn_update.Text = "Update"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = Global.BoardingHouse_.My.Resources.Resources.add_circle_svgrepo_com
        Me.btn_add.Location = New System.Drawing.Point(14, 689)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(136, 53)
        Me.btn_add.TabIndex = 24
        Me.btn_add.Text = "Add"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'dgv_utility
        '
        Me.dgv_utility.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_utility.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_utility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_utility.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_utility.Location = New System.Drawing.Point(499, 116)
        Me.dgv_utility.Name = "dgv_utility"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_utility.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_utility.Size = New System.Drawing.Size(579, 547)
        Me.dgv_utility.TabIndex = 23
        '
        'frmUtilityMt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 754)
        Me.Controls.Add(Me.txt_utilitysearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(GroupBox1)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_utility)
        Me.Name = "frmUtilityMt"
        Me.Text = "Utility Maintanance"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(Me.dgv_utility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_utilitysearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_utilityID As TextBox
    Friend WithEvents txt_utilityName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_utility As DataGridView
    Friend WithEvents txt_unitRate As TextBox
    Friend WithEvents bsSearch As BindingSource
End Class
