<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCCIMain
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        lblDistrict = New Label()
        cmbxDistrict = New ComboBox()
        lblCCI = New Label()
        cmbxCCI = New ComboBox()
        lblUnitNo = New Label()
        cmbxUnitNo = New ComboBox()
        lblStrength = New Label()
        cmbxGender = New ComboBox()
        lblGender = New Label()
        bttnUpdate = New Button()
        bttnAddUnit = New Button()
        tlpCCIDetails = New TableLayoutPanel()
        txtbxStrength = New TextBox()
        lblUnitType = New Label()
        lstbxUnitType = New ListBox()
        grpbxPABStatus = New GroupBox()
        rdobtnPABYes = New RadioButton()
        rdobtnPABNo = New RadioButton()
        lblCCIAddress = New Label()
        txtbxAddress = New TextBox()
        lblPIN = New Label()
        txtbxPIN = New TextBox()
        lblRegNo = New Label()
        txtbxRegNo = New TextBox()
        lblValidFrom = New Label()
        dtmpValidFrom = New DateTimePicker()
        lblVlidTo = New Label()
        dtmpValidTo = New DateTimePicker()
        lblContactPhNo = New Label()
        txtbxPhNo = New TextBox()
        lblContactDesg = New Label()
        txtbxDesignation = New TextBox()
        lblContactName = New Label()
        txtbxContactName = New TextBox()
        lblRegStatus = New Label()
        cmbxRegFileStatus = New ComboBox()
        cmbxCCIRunBy = New ComboBox()
        lblCCIRunBy = New Label()
        TestFuncToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        tlpCCIDetails.SuspendLayout()
        grpbxPABStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(4, 1, 0, 1)
        MenuStrip1.Size = New Size(701, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, TestFuncToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 22)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(180, 22)
        NewToolStripMenuItem.Text = "&New"
        ' 
        ' lblDistrict
        ' 
        lblDistrict.AutoSize = True
        lblDistrict.Location = New Point(8, 32)
        lblDistrict.Margin = New Padding(2, 0, 2, 0)
        lblDistrict.Name = "lblDistrict"
        lblDistrict.Size = New Size(44, 15)
        lblDistrict.TabIndex = 1
        lblDistrict.Text = "District"
        ' 
        ' cmbxDistrict
        ' 
        cmbxDistrict.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxDistrict.FormattingEnabled = True
        cmbxDistrict.Location = New Point(60, 30)
        cmbxDistrict.Margin = New Padding(2)
        cmbxDistrict.Name = "cmbxDistrict"
        cmbxDistrict.Size = New Size(148, 23)
        cmbxDistrict.TabIndex = 2
        ' 
        ' lblCCI
        ' 
        lblCCI.AutoSize = True
        lblCCI.Location = New Point(211, 32)
        lblCCI.Margin = New Padding(2, 0, 2, 0)
        lblCCI.Name = "lblCCI"
        lblCCI.Size = New Size(26, 15)
        lblCCI.TabIndex = 3
        lblCCI.Text = "CCI"
        ' 
        ' cmbxCCI
        ' 
        cmbxCCI.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxCCI.FormattingEnabled = True
        cmbxCCI.Location = New Point(242, 30)
        cmbxCCI.Margin = New Padding(2)
        cmbxCCI.Name = "cmbxCCI"
        cmbxCCI.Size = New Size(271, 23)
        cmbxCCI.TabIndex = 4
        ' 
        ' lblUnitNo
        ' 
        lblUnitNo.AutoSize = True
        lblUnitNo.Location = New Point(516, 32)
        lblUnitNo.Margin = New Padding(2, 0, 2, 0)
        lblUnitNo.Name = "lblUnitNo"
        lblUnitNo.Size = New Size(29, 15)
        lblUnitNo.TabIndex = 5
        lblUnitNo.Text = "Unit"
        ' 
        ' cmbxUnitNo
        ' 
        cmbxUnitNo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxUnitNo.FormattingEnabled = True
        cmbxUnitNo.Location = New Point(551, 30)
        cmbxUnitNo.Margin = New Padding(2)
        cmbxUnitNo.Name = "cmbxUnitNo"
        cmbxUnitNo.Size = New Size(143, 23)
        cmbxUnitNo.TabIndex = 6
        ' 
        ' lblStrength
        ' 
        lblStrength.AutoSize = True
        lblStrength.Location = New Point(2, 56)
        lblStrength.Margin = New Padding(2, 0, 2, 0)
        lblStrength.Name = "lblStrength"
        lblStrength.Size = New Size(52, 15)
        lblStrength.TabIndex = 11
        lblStrength.Text = "Strength"
        ' 
        ' cmbxGender
        ' 
        cmbxGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxGender.FormattingEnabled = True
        cmbxGender.Items.AddRange(New Object() {"Male", "Female", "Combined", "Transgender"})
        cmbxGender.Location = New Point(90, 31)
        cmbxGender.Margin = New Padding(2)
        cmbxGender.Name = "cmbxGender"
        cmbxGender.Size = New Size(205, 23)
        cmbxGender.TabIndex = 10
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(2, 29)
        lblGender.Margin = New Padding(2, 0, 2, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(45, 15)
        lblGender.TabIndex = 9
        lblGender.Text = "Gender"
        ' 
        ' bttnUpdate
        ' 
        bttnUpdate.Enabled = False
        bttnUpdate.Location = New Point(615, 70)
        bttnUpdate.Margin = New Padding(2)
        bttnUpdate.Name = "bttnUpdate"
        bttnUpdate.Size = New Size(78, 35)
        bttnUpdate.TabIndex = 9
        bttnUpdate.Text = "Update"
        bttnUpdate.UseVisualStyleBackColor = True
        ' 
        ' bttnAddUnit
        ' 
        bttnAddUnit.Enabled = False
        bttnAddUnit.Location = New Point(615, 109)
        bttnAddUnit.Margin = New Padding(2)
        bttnAddUnit.Name = "bttnAddUnit"
        bttnAddUnit.Size = New Size(78, 35)
        bttnAddUnit.TabIndex = 10
        bttnAddUnit.Text = "Add Unit"
        bttnAddUnit.UseVisualStyleBackColor = True
        ' 
        ' tlpCCIDetails
        ' 
        tlpCCIDetails.ColumnCount = 4
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.73284F))
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34.9179573F))
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.2492657F))
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.0999374F))
        tlpCCIDetails.Controls.Add(lblStrength, 0, 2)
        tlpCCIDetails.Controls.Add(lblGender, 0, 1)
        tlpCCIDetails.Controls.Add(cmbxGender, 1, 1)
        tlpCCIDetails.Controls.Add(txtbxStrength, 1, 2)
        tlpCCIDetails.Controls.Add(lblUnitType, 0, 3)
        tlpCCIDetails.Controls.Add(lstbxUnitType, 1, 3)
        tlpCCIDetails.Controls.Add(grpbxPABStatus, 2, 0)
        tlpCCIDetails.Controls.Add(lblCCIAddress, 0, 6)
        tlpCCIDetails.Controls.Add(txtbxAddress, 1, 6)
        tlpCCIDetails.Controls.Add(lblPIN, 0, 8)
        tlpCCIDetails.Controls.Add(txtbxPIN, 1, 8)
        tlpCCIDetails.Controls.Add(lblRegNo, 2, 2)
        tlpCCIDetails.Controls.Add(txtbxRegNo, 3, 2)
        tlpCCIDetails.Controls.Add(lblValidFrom, 2, 3)
        tlpCCIDetails.Controls.Add(dtmpValidFrom, 3, 3)
        tlpCCIDetails.Controls.Add(lblVlidTo, 2, 4)
        tlpCCIDetails.Controls.Add(dtmpValidTo, 3, 4)
        tlpCCIDetails.Controls.Add(lblContactPhNo, 2, 8)
        tlpCCIDetails.Controls.Add(txtbxPhNo, 3, 8)
        tlpCCIDetails.Controls.Add(lblContactDesg, 2, 7)
        tlpCCIDetails.Controls.Add(txtbxDesignation, 3, 7)
        tlpCCIDetails.Controls.Add(lblContactName, 2, 6)
        tlpCCIDetails.Controls.Add(txtbxContactName, 3, 6)
        tlpCCIDetails.Controls.Add(lblRegStatus, 2, 5)
        tlpCCIDetails.Controls.Add(cmbxRegFileStatus, 3, 5)
        tlpCCIDetails.Controls.Add(cmbxCCIRunBy, 1, 0)
        tlpCCIDetails.Controls.Add(lblCCIRunBy, 0, 0)
        tlpCCIDetails.Enabled = False
        tlpCCIDetails.Location = New Point(8, 57)
        tlpCCIDetails.Margin = New Padding(2)
        tlpCCIDetails.Name = "tlpCCIDetails"
        tlpCCIDetails.RowCount = 9
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.Size = New Size(600, 255)
        tlpCCIDetails.TabIndex = 12
        ' 
        ' txtbxStrength
        ' 
        txtbxStrength.Location = New Point(90, 58)
        txtbxStrength.Margin = New Padding(2)
        txtbxStrength.Name = "txtbxStrength"
        txtbxStrength.Size = New Size(205, 23)
        txtbxStrength.TabIndex = 12
        ' 
        ' lblUnitType
        ' 
        lblUnitType.AutoSize = True
        lblUnitType.Location = New Point(2, 83)
        lblUnitType.Margin = New Padding(2, 0, 2, 0)
        lblUnitType.Name = "lblUnitType"
        lblUnitType.Size = New Size(78, 15)
        lblUnitType.TabIndex = 13
        lblUnitType.Text = "CCI Unit Type"
        ' 
        ' lstbxUnitType
        ' 
        lstbxUnitType.FormattingEnabled = True
        lstbxUnitType.ItemHeight = 15
        lstbxUnitType.Location = New Point(90, 85)
        lstbxUnitType.Margin = New Padding(2)
        lstbxUnitType.Name = "lstbxUnitType"
        tlpCCIDetails.SetRowSpan(lstbxUnitType, 3)
        lstbxUnitType.SelectionMode = SelectionMode.MultiSimple
        lstbxUnitType.Size = New Size(205, 79)
        lstbxUnitType.TabIndex = 14
        ' 
        ' grpbxPABStatus
        ' 
        tlpCCIDetails.SetColumnSpan(grpbxPABStatus, 2)
        grpbxPABStatus.Controls.Add(rdobtnPABYes)
        grpbxPABStatus.Controls.Add(rdobtnPABNo)
        grpbxPABStatus.Location = New Point(299, 2)
        grpbxPABStatus.Margin = New Padding(2)
        grpbxPABStatus.Name = "grpbxPABStatus"
        grpbxPABStatus.Padding = New Padding(2)
        tlpCCIDetails.SetRowSpan(grpbxPABStatus, 2)
        grpbxPABStatus.Size = New Size(298, 42)
        grpbxPABStatus.TabIndex = 13
        grpbxPABStatus.TabStop = False
        grpbxPABStatus.Text = "PAB Approved"
        ' 
        ' rdobtnPABYes
        ' 
        rdobtnPABYes.AutoSize = True
        rdobtnPABYes.Location = New Point(4, 20)
        rdobtnPABYes.Margin = New Padding(2)
        rdobtnPABYes.Name = "rdobtnPABYes"
        rdobtnPABYes.Size = New Size(42, 19)
        rdobtnPABYes.TabIndex = 19
        rdobtnPABYes.TabStop = True
        rdobtnPABYes.Text = "Yes"
        rdobtnPABYes.UseVisualStyleBackColor = True
        ' 
        ' rdobtnPABNo
        ' 
        rdobtnPABNo.AutoSize = True
        rdobtnPABNo.Location = New Point(52, 20)
        rdobtnPABNo.Margin = New Padding(2)
        rdobtnPABNo.Name = "rdobtnPABNo"
        rdobtnPABNo.Size = New Size(41, 19)
        rdobtnPABNo.TabIndex = 20
        rdobtnPABNo.TabStop = True
        rdobtnPABNo.Text = "No"
        rdobtnPABNo.UseVisualStyleBackColor = True
        ' 
        ' lblCCIAddress
        ' 
        lblCCIAddress.AutoSize = True
        lblCCIAddress.Location = New Point(2, 166)
        lblCCIAddress.Margin = New Padding(2, 0, 2, 0)
        lblCCIAddress.Name = "lblCCIAddress"
        lblCCIAddress.Size = New Size(49, 15)
        lblCCIAddress.TabIndex = 15
        lblCCIAddress.Text = "Address"
        ' 
        ' txtbxAddress
        ' 
        txtbxAddress.Location = New Point(90, 168)
        txtbxAddress.Margin = New Padding(2)
        txtbxAddress.Multiline = True
        txtbxAddress.Name = "txtbxAddress"
        tlpCCIDetails.SetRowSpan(txtbxAddress, 2)
        txtbxAddress.Size = New Size(205, 50)
        txtbxAddress.TabIndex = 16
        ' 
        ' lblPIN
        ' 
        lblPIN.AutoSize = True
        lblPIN.Location = New Point(2, 220)
        lblPIN.Margin = New Padding(2, 0, 2, 0)
        lblPIN.Name = "lblPIN"
        lblPIN.Size = New Size(26, 15)
        lblPIN.TabIndex = 17
        lblPIN.Text = "PIN"
        ' 
        ' txtbxPIN
        ' 
        txtbxPIN.Location = New Point(90, 222)
        txtbxPIN.Margin = New Padding(2)
        txtbxPIN.Name = "txtbxPIN"
        txtbxPIN.Size = New Size(205, 23)
        txtbxPIN.TabIndex = 18
        ' 
        ' lblRegNo
        ' 
        lblRegNo.AutoSize = True
        lblRegNo.Location = New Point(299, 56)
        lblRegNo.Margin = New Padding(2, 0, 2, 0)
        lblRegNo.Name = "lblRegNo"
        lblRegNo.Size = New Size(89, 15)
        lblRegNo.TabIndex = 21
        lblRegNo.Text = "Registration No"
        ' 
        ' txtbxRegNo
        ' 
        txtbxRegNo.Location = New Point(402, 58)
        txtbxRegNo.Margin = New Padding(2)
        txtbxRegNo.Name = "txtbxRegNo"
        txtbxRegNo.Size = New Size(196, 23)
        txtbxRegNo.TabIndex = 22
        ' 
        ' lblValidFrom
        ' 
        lblValidFrom.AutoSize = True
        lblValidFrom.Location = New Point(299, 83)
        lblValidFrom.Margin = New Padding(2, 0, 2, 0)
        lblValidFrom.Name = "lblValidFrom"
        lblValidFrom.Size = New Size(63, 15)
        lblValidFrom.TabIndex = 23
        lblValidFrom.Text = "Valid From"
        ' 
        ' dtmpValidFrom
        ' 
        dtmpValidFrom.Location = New Point(402, 85)
        dtmpValidFrom.Margin = New Padding(2)
        dtmpValidFrom.Name = "dtmpValidFrom"
        dtmpValidFrom.Size = New Size(196, 23)
        dtmpValidFrom.TabIndex = 24
        ' 
        ' lblVlidTo
        ' 
        lblVlidTo.AutoSize = True
        lblVlidTo.Location = New Point(299, 110)
        lblVlidTo.Margin = New Padding(2, 0, 2, 0)
        lblVlidTo.Name = "lblVlidTo"
        lblVlidTo.Size = New Size(64, 15)
        lblVlidTo.TabIndex = 25
        lblVlidTo.Text = "Valid Up to"
        ' 
        ' dtmpValidTo
        ' 
        dtmpValidTo.Location = New Point(402, 112)
        dtmpValidTo.Margin = New Padding(2)
        dtmpValidTo.Name = "dtmpValidTo"
        dtmpValidTo.Size = New Size(196, 23)
        dtmpValidTo.TabIndex = 26
        ' 
        ' lblContactPhNo
        ' 
        lblContactPhNo.AutoSize = True
        lblContactPhNo.Location = New Point(299, 220)
        lblContactPhNo.Margin = New Padding(2, 0, 2, 0)
        lblContactPhNo.Name = "lblContactPhNo"
        lblContactPhNo.Size = New Size(63, 15)
        lblContactPhNo.TabIndex = 33
        lblContactPhNo.Text = "Phone No."
        ' 
        ' txtbxPhNo
        ' 
        txtbxPhNo.Location = New Point(402, 222)
        txtbxPhNo.Margin = New Padding(2)
        txtbxPhNo.Name = "txtbxPhNo"
        txtbxPhNo.Size = New Size(196, 23)
        txtbxPhNo.TabIndex = 34
        ' 
        ' lblContactDesg
        ' 
        lblContactDesg.AutoSize = True
        lblContactDesg.Location = New Point(299, 193)
        lblContactDesg.Margin = New Padding(2, 0, 2, 0)
        lblContactDesg.Name = "lblContactDesg"
        lblContactDesg.Size = New Size(70, 15)
        lblContactDesg.TabIndex = 31
        lblContactDesg.Text = "Designation"
        ' 
        ' txtbxDesignation
        ' 
        txtbxDesignation.Location = New Point(402, 195)
        txtbxDesignation.Margin = New Padding(2)
        txtbxDesignation.Name = "txtbxDesignation"
        txtbxDesignation.Size = New Size(196, 23)
        txtbxDesignation.TabIndex = 32
        ' 
        ' lblContactName
        ' 
        lblContactName.AutoSize = True
        lblContactName.Location = New Point(299, 166)
        lblContactName.Margin = New Padding(2, 0, 2, 0)
        lblContactName.Name = "lblContactName"
        lblContactName.Size = New Size(84, 15)
        lblContactName.TabIndex = 29
        lblContactName.Text = "Contact Name"
        ' 
        ' txtbxContactName
        ' 
        txtbxContactName.Location = New Point(402, 168)
        txtbxContactName.Margin = New Padding(2)
        txtbxContactName.Name = "txtbxContactName"
        txtbxContactName.Size = New Size(196, 23)
        txtbxContactName.TabIndex = 30
        ' 
        ' lblRegStatus
        ' 
        lblRegStatus.AutoSize = True
        lblRegStatus.Location = New Point(299, 137)
        lblRegStatus.Margin = New Padding(2, 0, 2, 0)
        lblRegStatus.Name = "lblRegStatus"
        lblRegStatus.Size = New Size(60, 15)
        lblRegStatus.TabIndex = 27
        lblRegStatus.Text = "File Status"
        ' 
        ' cmbxRegFileStatus
        ' 
        cmbxRegFileStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxRegFileStatus.FormattingEnabled = True
        cmbxRegFileStatus.ItemHeight = 15
        cmbxRegFileStatus.Location = New Point(402, 139)
        cmbxRegFileStatus.Margin = New Padding(2)
        cmbxRegFileStatus.Name = "cmbxRegFileStatus"
        cmbxRegFileStatus.Size = New Size(196, 23)
        cmbxRegFileStatus.TabIndex = 28
        ' 
        ' cmbxCCIRunBy
        ' 
        cmbxCCIRunBy.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxCCIRunBy.FormattingEnabled = True
        cmbxCCIRunBy.Items.AddRange(New Object() {"Government", "Non-Government Organisation"})
        cmbxCCIRunBy.Location = New Point(91, 3)
        cmbxCCIRunBy.Name = "cmbxCCIRunBy"
        cmbxCCIRunBy.Size = New Size(203, 23)
        cmbxCCIRunBy.TabIndex = 8
        ' 
        ' lblCCIRunBy
        ' 
        lblCCIRunBy.AutoSize = True
        lblCCIRunBy.Location = New Point(3, 0)
        lblCCIRunBy.Name = "lblCCIRunBy"
        lblCCIRunBy.Size = New Size(44, 15)
        lblCCIRunBy.TabIndex = 7
        lblCCIRunBy.Text = "Run By"
        ' 
        ' TestFuncToolStripMenuItem
        ' 
        TestFuncToolStripMenuItem.Name = "TestFuncToolStripMenuItem"
        TestFuncToolStripMenuItem.Size = New Size(180, 22)
        TestFuncToolStripMenuItem.Text = "TestFunc"
        ' 
        ' frmCCIMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(701, 427)
        Controls.Add(tlpCCIDetails)
        Controls.Add(bttnAddUnit)
        Controls.Add(bttnUpdate)
        Controls.Add(cmbxUnitNo)
        Controls.Add(lblUnitNo)
        Controls.Add(cmbxCCI)
        Controls.Add(lblCCI)
        Controls.Add(cmbxDistrict)
        Controls.Add(lblDistrict)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2)
        Name = "frmCCIMain"
        Text = "Child Care Institutions"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        tlpCCIDetails.ResumeLayout(False)
        tlpCCIDetails.PerformLayout()
        grpbxPABStatus.ResumeLayout(False)
        grpbxPABStatus.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDistrict As Label
    Friend WithEvents cmbxDistrict As ComboBox
    Friend WithEvents lblCCI As Label
    Friend WithEvents cmbxCCI As ComboBox
    Friend WithEvents lblUnitNo As Label
    Friend WithEvents cmbxUnitNo As ComboBox
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bttnUpdate As Button
    Friend WithEvents bttnAddUnit As Button
    Friend WithEvents lblGender As Label
    Friend WithEvents cmbxGender As ComboBox
    Friend WithEvents lblStrength As Label
    Friend WithEvents tlpCCIDetails As TableLayoutPanel
    Friend WithEvents txtbxStrength As TextBox
    Friend WithEvents lblCCIAddress As Label
    Friend WithEvents lblUnitType As Label
    Friend WithEvents lstbxUnitType As ListBox
    Friend WithEvents txtbxAddress As TextBox
    Friend WithEvents lblPIN As Label
    Friend WithEvents txtbxPIN As TextBox
    Friend WithEvents rdobtnPABYes As RadioButton
    Friend WithEvents rdobtnPABNo As RadioButton
    Friend WithEvents grpbxPABStatus As GroupBox
    Friend WithEvents lblRegNo As Label
    Friend WithEvents txtbxRegNo As TextBox
    Friend WithEvents lblValidFrom As Label
    Friend WithEvents dtmpValidFrom As DateTimePicker
    Friend WithEvents lblVlidTo As Label
    Friend WithEvents dtmpValidTo As DateTimePicker
    Friend WithEvents lblContactName As Label
    Friend WithEvents txtbxContactName As TextBox
    Friend WithEvents lblContactDesg As Label
    Friend WithEvents lblContactPhNo As Label
    Friend WithEvents txtbxPhNo As TextBox
    Friend WithEvents txtbxDesignation As TextBox
    Friend WithEvents lblRegStatus As Label
    Friend WithEvents cmbxRegFileStatus As ComboBox
    Friend WithEvents cmbxCCIRunBy As ComboBox
    Friend WithEvents lblCCIRunBy As Label
    Friend WithEvents TestFuncToolStripMenuItem As ToolStripMenuItem
End Class
