﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        bttnReset = New Button()
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
        MenuStrip1.Size = New Size(1002, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(149, 34)
        NewToolStripMenuItem.Text = "&New"
        ' 
        ' lblDistrict
        ' 
        lblDistrict.AutoSize = True
        lblDistrict.Location = New Point(12, 53)
        lblDistrict.Name = "lblDistrict"
        lblDistrict.Size = New Size(67, 25)
        lblDistrict.TabIndex = 1
        lblDistrict.Text = "District"
        ' 
        ' cmbxDistrict
        ' 
        cmbxDistrict.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxDistrict.FormattingEnabled = True
        cmbxDistrict.Location = New Point(85, 50)
        cmbxDistrict.Name = "cmbxDistrict"
        cmbxDistrict.Size = New Size(210, 33)
        cmbxDistrict.TabIndex = 2
        ' 
        ' lblCCI
        ' 
        lblCCI.AutoSize = True
        lblCCI.Location = New Point(301, 53)
        lblCCI.Name = "lblCCI"
        lblCCI.Size = New Size(177, 25)
        lblCCI.TabIndex = 3
        lblCCI.Text = "Child Care Institution"
        ' 
        ' cmbxCCI
        ' 
        cmbxCCI.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxCCI.FormattingEnabled = True
        cmbxCCI.Location = New Point(484, 50)
        cmbxCCI.Name = "cmbxCCI"
        cmbxCCI.Size = New Size(385, 33)
        cmbxCCI.TabIndex = 4
        ' 
        ' lblUnitNo
        ' 
        lblUnitNo.AutoSize = True
        lblUnitNo.Location = New Point(875, 53)
        lblUnitNo.Name = "lblUnitNo"
        lblUnitNo.Size = New Size(44, 25)
        lblUnitNo.TabIndex = 5
        lblUnitNo.Text = "Unit"
        ' 
        ' cmbxUnitNo
        ' 
        cmbxUnitNo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxUnitNo.FormattingEnabled = True
        cmbxUnitNo.Location = New Point(925, 50)
        cmbxUnitNo.Name = "cmbxUnitNo"
        cmbxUnitNo.Size = New Size(65, 33)
        cmbxUnitNo.TabIndex = 6
        ' 
        ' lblStrength
        ' 
        lblStrength.AutoSize = True
        lblStrength.Location = New Point(3, 39)
        lblStrength.Name = "lblStrength"
        lblStrength.Size = New Size(79, 25)
        lblStrength.TabIndex = 2
        lblStrength.Text = "Strength"
        ' 
        ' cmbxGender
        ' 
        cmbxGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxGender.FormattingEnabled = True
        cmbxGender.Items.AddRange(New Object() {"Male", "Female", "Transgender"})
        cmbxGender.Location = New Point(129, 3)
        cmbxGender.Name = "cmbxGender"
        cmbxGender.Size = New Size(293, 33)
        cmbxGender.TabIndex = 1
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(3, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(69, 25)
        lblGender.TabIndex = 0
        lblGender.Text = "Gender"
        ' 
        ' bttnUpdate
        ' 
        bttnUpdate.Enabled = False
        bttnUpdate.Location = New Point(878, 117)
        bttnUpdate.Name = "bttnUpdate"
        bttnUpdate.Size = New Size(112, 34)
        bttnUpdate.TabIndex = 9
        bttnUpdate.Text = "Update"
        bttnUpdate.UseVisualStyleBackColor = True
        ' 
        ' bttnAddUnit
        ' 
        bttnAddUnit.Enabled = False
        bttnAddUnit.Location = New Point(878, 157)
        bttnAddUnit.Name = "bttnAddUnit"
        bttnAddUnit.Size = New Size(112, 34)
        bttnAddUnit.TabIndex = 10
        bttnAddUnit.Text = "Add Unit"
        bttnAddUnit.UseVisualStyleBackColor = True
        ' 
        ' bttnReset
        ' 
        bttnReset.Location = New Point(878, 197)
        bttnReset.Name = "bttnReset"
        bttnReset.Size = New Size(112, 34)
        bttnReset.TabIndex = 11
        bttnReset.Text = "Reset"
        bttnReset.UseVisualStyleBackColor = True
        ' 
        ' tlpCCIDetails
        ' 
        tlpCCIDetails.ColumnCount = 4
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.73284F))
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34.9179573F))
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.2492657F))
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.0999374F))
        tlpCCIDetails.Controls.Add(lblStrength, 0, 1)
        tlpCCIDetails.Controls.Add(lblGender, 0, 0)
        tlpCCIDetails.Controls.Add(cmbxGender, 1, 0)
        tlpCCIDetails.Controls.Add(txtbxStrength, 1, 1)
        tlpCCIDetails.Controls.Add(lblUnitType, 0, 2)
        tlpCCIDetails.Controls.Add(lstbxUnitType, 1, 2)
        tlpCCIDetails.Controls.Add(grpbxPABStatus, 2, 0)
        tlpCCIDetails.Controls.Add(lblCCIAddress, 0, 5)
        tlpCCIDetails.Controls.Add(txtbxAddress, 1, 5)
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
        tlpCCIDetails.Enabled = False
        tlpCCIDetails.Location = New Point(12, 89)
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
        tlpCCIDetails.Size = New Size(857, 394)
        tlpCCIDetails.TabIndex = 12
        ' 
        ' txtbxStrength
        ' 
        txtbxStrength.Location = New Point(129, 42)
        txtbxStrength.Name = "txtbxStrength"
        txtbxStrength.Size = New Size(293, 31)
        txtbxStrength.TabIndex = 3
        ' 
        ' lblUnitType
        ' 
        lblUnitType.AutoSize = True
        lblUnitType.Location = New Point(3, 76)
        lblUnitType.Name = "lblUnitType"
        lblUnitType.Size = New Size(118, 25)
        lblUnitType.TabIndex = 5
        lblUnitType.Text = "CCI Unit Type"
        ' 
        ' lstbxUnitType
        ' 
        lstbxUnitType.FormattingEnabled = True
        lstbxUnitType.ItemHeight = 25
        lstbxUnitType.Location = New Point(129, 79)
        lstbxUnitType.Name = "lstbxUnitType"
        tlpCCIDetails.SetRowSpan(lstbxUnitType, 3)
        lstbxUnitType.Size = New Size(293, 129)
        lstbxUnitType.TabIndex = 6
        ' 
        ' grpbxPABStatus
        ' 
        tlpCCIDetails.SetColumnSpan(grpbxPABStatus, 2)
        grpbxPABStatus.Controls.Add(rdobtnPABYes)
        grpbxPABStatus.Controls.Add(rdobtnPABNo)
        grpbxPABStatus.Location = New Point(428, 3)
        grpbxPABStatus.Name = "grpbxPABStatus"
        tlpCCIDetails.SetRowSpan(grpbxPABStatus, 2)
        grpbxPABStatus.Size = New Size(426, 70)
        grpbxPABStatus.TabIndex = 13
        grpbxPABStatus.TabStop = False
        grpbxPABStatus.Text = "PAB Approved"
        ' 
        ' rdobtnPABYes
        ' 
        rdobtnPABYes.AutoSize = True
        rdobtnPABYes.Location = New Point(6, 34)
        rdobtnPABYes.Name = "rdobtnPABYes"
        rdobtnPABYes.Size = New Size(62, 29)
        rdobtnPABYes.TabIndex = 11
        rdobtnPABYes.TabStop = True
        rdobtnPABYes.Text = "Yes"
        rdobtnPABYes.UseVisualStyleBackColor = True
        ' 
        ' rdobtnPABNo
        ' 
        rdobtnPABNo.AutoSize = True
        rdobtnPABNo.Location = New Point(74, 34)
        rdobtnPABNo.Name = "rdobtnPABNo"
        rdobtnPABNo.Size = New Size(61, 29)
        rdobtnPABNo.TabIndex = 12
        rdobtnPABNo.TabStop = True
        rdobtnPABNo.Text = "No"
        rdobtnPABNo.UseVisualStyleBackColor = True
        ' 
        ' lblCCIAddress
        ' 
        lblCCIAddress.AutoSize = True
        lblCCIAddress.Location = New Point(3, 211)
        lblCCIAddress.Name = "lblCCIAddress"
        lblCCIAddress.Size = New Size(77, 25)
        lblCCIAddress.TabIndex = 4
        lblCCIAddress.Text = "Address"
        ' 
        ' txtbxAddress
        ' 
        txtbxAddress.Location = New Point(129, 214)
        txtbxAddress.Multiline = True
        txtbxAddress.Name = "txtbxAddress"
        tlpCCIDetails.SetRowSpan(txtbxAddress, 3)
        txtbxAddress.Size = New Size(291, 129)
        txtbxAddress.TabIndex = 7
        ' 
        ' lblPIN
        ' 
        lblPIN.AutoSize = True
        lblPIN.Location = New Point(3, 346)
        lblPIN.Name = "lblPIN"
        lblPIN.Size = New Size(40, 25)
        lblPIN.TabIndex = 8
        lblPIN.Text = "PIN"
        ' 
        ' txtbxPIN
        ' 
        txtbxPIN.Location = New Point(129, 349)
        txtbxPIN.Name = "txtbxPIN"
        txtbxPIN.Size = New Size(291, 31)
        txtbxPIN.TabIndex = 9
        ' 
        ' lblRegNo
        ' 
        lblRegNo.AutoSize = True
        lblRegNo.Location = New Point(428, 76)
        lblRegNo.Name = "lblRegNo"
        lblRegNo.Size = New Size(135, 25)
        lblRegNo.TabIndex = 14
        lblRegNo.Text = "Registration No"
        ' 
        ' txtbxRegNo
        ' 
        txtbxRegNo.Location = New Point(575, 79)
        txtbxRegNo.Name = "txtbxRegNo"
        txtbxRegNo.Size = New Size(279, 31)
        txtbxRegNo.TabIndex = 15
        ' 
        ' lblValidFrom
        ' 
        lblValidFrom.AutoSize = True
        lblValidFrom.Location = New Point(428, 113)
        lblValidFrom.Name = "lblValidFrom"
        lblValidFrom.Size = New Size(97, 25)
        lblValidFrom.TabIndex = 16
        lblValidFrom.Text = "Valid From"
        ' 
        ' dtmpValidFrom
        ' 
        dtmpValidFrom.Location = New Point(575, 116)
        dtmpValidFrom.Name = "dtmpValidFrom"
        dtmpValidFrom.Size = New Size(279, 31)
        dtmpValidFrom.TabIndex = 17
        ' 
        ' lblVlidTo
        ' 
        lblVlidTo.AutoSize = True
        lblVlidTo.Location = New Point(428, 150)
        lblVlidTo.Name = "lblVlidTo"
        lblVlidTo.Size = New Size(100, 25)
        lblVlidTo.TabIndex = 18
        lblVlidTo.Text = "Valid Up to"
        ' 
        ' dtmpValidTo
        ' 
        dtmpValidTo.Location = New Point(575, 153)
        dtmpValidTo.Name = "dtmpValidTo"
        dtmpValidTo.Size = New Size(279, 31)
        dtmpValidTo.TabIndex = 19
        ' 
        ' lblContactPhNo
        ' 
        lblContactPhNo.AutoSize = True
        lblContactPhNo.Location = New Point(428, 346)
        lblContactPhNo.Name = "lblContactPhNo"
        lblContactPhNo.Size = New Size(95, 25)
        lblContactPhNo.TabIndex = 24
        lblContactPhNo.Text = "Phone No."
        ' 
        ' txtbxPhNo
        ' 
        txtbxPhNo.Location = New Point(575, 349)
        txtbxPhNo.Name = "txtbxPhNo"
        txtbxPhNo.Size = New Size(279, 31)
        txtbxPhNo.TabIndex = 25
        ' 
        ' lblContactDesg
        ' 
        lblContactDesg.AutoSize = True
        lblContactDesg.Location = New Point(428, 287)
        lblContactDesg.Name = "lblContactDesg"
        lblContactDesg.Size = New Size(107, 25)
        lblContactDesg.TabIndex = 22
        lblContactDesg.Text = "Designation"
        ' 
        ' txtbxDesignation
        ' 
        txtbxDesignation.Location = New Point(575, 290)
        txtbxDesignation.Name = "txtbxDesignation"
        txtbxDesignation.Size = New Size(279, 31)
        txtbxDesignation.TabIndex = 23
        ' 
        ' lblContactName
        ' 
        lblContactName.AutoSize = True
        lblContactName.Location = New Point(428, 250)
        lblContactName.Name = "lblContactName"
        lblContactName.Size = New Size(125, 25)
        lblContactName.TabIndex = 20
        lblContactName.Text = "Contact Name"
        ' 
        ' txtbxContactName
        ' 
        txtbxContactName.Location = New Point(575, 253)
        txtbxContactName.Name = "txtbxContactName"
        txtbxContactName.Size = New Size(279, 31)
        txtbxContactName.TabIndex = 21
        ' 
        ' lblRegStatus
        ' 
        lblRegStatus.AutoSize = True
        lblRegStatus.Location = New Point(428, 211)
        lblRegStatus.Name = "lblRegStatus"
        lblRegStatus.Size = New Size(91, 25)
        lblRegStatus.TabIndex = 26
        lblRegStatus.Text = "File Status"
        ' 
        ' cmbxRegFileStatus
        ' 
        cmbxRegFileStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxRegFileStatus.FormattingEnabled = True
        cmbxRegFileStatus.ItemHeight = 25
        cmbxRegFileStatus.Location = New Point(575, 214)
        cmbxRegFileStatus.Name = "cmbxRegFileStatus"
        cmbxRegFileStatus.Size = New Size(279, 33)
        cmbxRegFileStatus.TabIndex = 27
        ' 
        ' frmCCIMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1002, 712)
        Controls.Add(tlpCCIDetails)
        Controls.Add(bttnReset)
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
    Friend WithEvents bttnReset As Button
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
End Class