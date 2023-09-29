<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewCCIMain
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
        lblDistrict = New Label()
        cmbxDistrict = New ComboBox()
        lblCCIName = New Label()
        lblStrength = New Label()
        cmbxGender = New ComboBox()
        lblGender = New Label()
        bttnAddCCI = New Button()
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
        txtbxCCIName = New TextBox()
        cmbxCCIRunBy = New ComboBox()
        lblCCIRunBy = New Label()
        tlpCCIDetails.SuspendLayout()
        grpbxPABStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblDistrict
        ' 
        lblDistrict.AutoSize = True
        lblDistrict.Location = New Point(2, 0)
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
        cmbxDistrict.Location = New Point(90, 2)
        cmbxDistrict.Margin = New Padding(2)
        cmbxDistrict.Name = "cmbxDistrict"
        cmbxDistrict.Size = New Size(205, 23)
        cmbxDistrict.TabIndex = 2
        ' 
        ' lblCCIName
        ' 
        lblCCIName.AutoSize = True
        lblCCIName.Location = New Point(299, 0)
        lblCCIName.Margin = New Padding(2, 0, 2, 0)
        lblCCIName.Name = "lblCCIName"
        lblCCIName.Size = New Size(61, 15)
        lblCCIName.TabIndex = 3
        lblCCIName.Text = "CCI Name"
        ' 
        ' lblStrength
        ' 
        lblStrength.AutoSize = True
        lblStrength.Location = New Point(2, 85)
        lblStrength.Margin = New Padding(2, 0, 2, 0)
        lblStrength.Name = "lblStrength"
        lblStrength.Size = New Size(52, 15)
        lblStrength.TabIndex = 2
        lblStrength.Text = "Strength"
        ' 
        ' cmbxGender
        ' 
        cmbxGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxGender.FormattingEnabled = True
        cmbxGender.Items.AddRange(New Object() {"Male", "Female", "Combined", "Transgender"})
        cmbxGender.Location = New Point(90, 60)
        cmbxGender.Margin = New Padding(2)
        cmbxGender.Name = "cmbxGender"
        cmbxGender.Size = New Size(205, 23)
        cmbxGender.TabIndex = 1
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(2, 58)
        lblGender.Margin = New Padding(2, 0, 2, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(45, 15)
        lblGender.TabIndex = 0
        lblGender.Text = "Gender"
        ' 
        ' bttnAddCCI
        ' 
        bttnAddCCI.Location = New Point(615, 70)
        bttnAddCCI.Margin = New Padding(2)
        bttnAddCCI.Name = "bttnAddCCI"
        bttnAddCCI.Size = New Size(78, 35)
        bttnAddCCI.TabIndex = 9
        bttnAddCCI.Text = "Add CCI"
        bttnAddCCI.UseVisualStyleBackColor = True
        ' 
        ' tlpCCIDetails
        ' 
        tlpCCIDetails.ColumnCount = 4
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.73284F))
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34.9179573F))
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.2492657F))
        tlpCCIDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.0999374F))
        tlpCCIDetails.Controls.Add(lblStrength, 0, 3)
        tlpCCIDetails.Controls.Add(lblGender, 0, 2)
        tlpCCIDetails.Controls.Add(cmbxGender, 1, 2)
        tlpCCIDetails.Controls.Add(txtbxStrength, 1, 3)
        tlpCCIDetails.Controls.Add(lblUnitType, 0, 4)
        tlpCCIDetails.Controls.Add(lstbxUnitType, 1, 4)
        tlpCCIDetails.Controls.Add(grpbxPABStatus, 2, 1)
        tlpCCIDetails.Controls.Add(cmbxDistrict, 1, 0)
        tlpCCIDetails.Controls.Add(lblCCIAddress, 0, 7)
        tlpCCIDetails.Controls.Add(lblDistrict, 0, 0)
        tlpCCIDetails.Controls.Add(txtbxAddress, 1, 7)
        tlpCCIDetails.Controls.Add(lblPIN, 0, 9)
        tlpCCIDetails.Controls.Add(txtbxPIN, 1, 9)
        tlpCCIDetails.Controls.Add(lblRegNo, 2, 3)
        tlpCCIDetails.Controls.Add(txtbxRegNo, 3, 3)
        tlpCCIDetails.Controls.Add(lblValidFrom, 2, 4)
        tlpCCIDetails.Controls.Add(dtmpValidFrom, 3, 4)
        tlpCCIDetails.Controls.Add(lblVlidTo, 2, 5)
        tlpCCIDetails.Controls.Add(dtmpValidTo, 3, 5)
        tlpCCIDetails.Controls.Add(lblContactPhNo, 2, 9)
        tlpCCIDetails.Controls.Add(txtbxPhNo, 3, 9)
        tlpCCIDetails.Controls.Add(lblContactDesg, 2, 8)
        tlpCCIDetails.Controls.Add(txtbxDesignation, 3, 8)
        tlpCCIDetails.Controls.Add(lblContactName, 2, 7)
        tlpCCIDetails.Controls.Add(txtbxContactName, 3, 7)
        tlpCCIDetails.Controls.Add(lblRegStatus, 2, 6)
        tlpCCIDetails.Controls.Add(cmbxRegFileStatus, 3, 6)
        tlpCCIDetails.Controls.Add(txtbxCCIName, 3, 0)
        tlpCCIDetails.Controls.Add(lblCCIName, 2, 0)
        tlpCCIDetails.Controls.Add(cmbxCCIRunBy, 1, 1)
        tlpCCIDetails.Controls.Add(lblCCIRunBy, 0, 1)
        tlpCCIDetails.Location = New Point(11, 11)
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
        tlpCCIDetails.RowStyles.Add(New RowStyle())
        tlpCCIDetails.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpCCIDetails.Size = New Size(600, 314)
        tlpCCIDetails.TabIndex = 12
        ' 
        ' txtbxStrength
        ' 
        txtbxStrength.Location = New Point(90, 87)
        txtbxStrength.Margin = New Padding(2)
        txtbxStrength.Name = "txtbxStrength"
        txtbxStrength.Size = New Size(205, 23)
        txtbxStrength.TabIndex = 3
        ' 
        ' lblUnitType
        ' 
        lblUnitType.AutoSize = True
        lblUnitType.Location = New Point(2, 112)
        lblUnitType.Margin = New Padding(2, 0, 2, 0)
        lblUnitType.Name = "lblUnitType"
        lblUnitType.Size = New Size(78, 15)
        lblUnitType.TabIndex = 5
        lblUnitType.Text = "CCI Unit Type"
        ' 
        ' lstbxUnitType
        ' 
        lstbxUnitType.FormattingEnabled = True
        lstbxUnitType.ItemHeight = 15
        lstbxUnitType.Location = New Point(90, 114)
        lstbxUnitType.Margin = New Padding(2)
        lstbxUnitType.Name = "lstbxUnitType"
        tlpCCIDetails.SetRowSpan(lstbxUnitType, 3)
        lstbxUnitType.SelectionMode = SelectionMode.MultiSimple
        lstbxUnitType.Size = New Size(205, 79)
        lstbxUnitType.TabIndex = 6
        ' 
        ' grpbxPABStatus
        ' 
        tlpCCIDetails.SetColumnSpan(grpbxPABStatus, 2)
        grpbxPABStatus.Controls.Add(rdobtnPABYes)
        grpbxPABStatus.Controls.Add(rdobtnPABNo)
        grpbxPABStatus.Location = New Point(299, 31)
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
        rdobtnPABYes.TabIndex = 11
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
        rdobtnPABNo.TabIndex = 12
        rdobtnPABNo.TabStop = True
        rdobtnPABNo.Text = "No"
        rdobtnPABNo.UseVisualStyleBackColor = True
        ' 
        ' lblCCIAddress
        ' 
        lblCCIAddress.AutoSize = True
        lblCCIAddress.Location = New Point(2, 195)
        lblCCIAddress.Margin = New Padding(2, 0, 2, 0)
        lblCCIAddress.Name = "lblCCIAddress"
        lblCCIAddress.Size = New Size(49, 15)
        lblCCIAddress.TabIndex = 4
        lblCCIAddress.Text = "Address"
        ' 
        ' txtbxAddress
        ' 
        txtbxAddress.Location = New Point(90, 197)
        txtbxAddress.Margin = New Padding(2)
        txtbxAddress.Multiline = True
        txtbxAddress.Name = "txtbxAddress"
        tlpCCIDetails.SetRowSpan(txtbxAddress, 2)
        txtbxAddress.Size = New Size(205, 79)
        txtbxAddress.TabIndex = 7
        ' 
        ' lblPIN
        ' 
        lblPIN.AutoSize = True
        lblPIN.Location = New Point(2, 278)
        lblPIN.Margin = New Padding(2, 0, 2, 0)
        lblPIN.Name = "lblPIN"
        lblPIN.Size = New Size(26, 15)
        lblPIN.TabIndex = 8
        lblPIN.Text = "PIN"
        ' 
        ' txtbxPIN
        ' 
        txtbxPIN.Location = New Point(90, 280)
        txtbxPIN.Margin = New Padding(2)
        txtbxPIN.Name = "txtbxPIN"
        txtbxPIN.Size = New Size(205, 23)
        txtbxPIN.TabIndex = 9
        ' 
        ' lblRegNo
        ' 
        lblRegNo.AutoSize = True
        lblRegNo.Location = New Point(299, 85)
        lblRegNo.Margin = New Padding(2, 0, 2, 0)
        lblRegNo.Name = "lblRegNo"
        lblRegNo.Size = New Size(89, 15)
        lblRegNo.TabIndex = 14
        lblRegNo.Text = "Registration No"
        ' 
        ' txtbxRegNo
        ' 
        txtbxRegNo.Location = New Point(402, 87)
        txtbxRegNo.Margin = New Padding(2)
        txtbxRegNo.Name = "txtbxRegNo"
        txtbxRegNo.Size = New Size(196, 23)
        txtbxRegNo.TabIndex = 15
        ' 
        ' lblValidFrom
        ' 
        lblValidFrom.AutoSize = True
        lblValidFrom.Location = New Point(299, 112)
        lblValidFrom.Margin = New Padding(2, 0, 2, 0)
        lblValidFrom.Name = "lblValidFrom"
        lblValidFrom.Size = New Size(63, 15)
        lblValidFrom.TabIndex = 16
        lblValidFrom.Text = "Valid From"
        ' 
        ' dtmpValidFrom
        ' 
        dtmpValidFrom.Location = New Point(402, 114)
        dtmpValidFrom.Margin = New Padding(2)
        dtmpValidFrom.Name = "dtmpValidFrom"
        dtmpValidFrom.Size = New Size(196, 23)
        dtmpValidFrom.TabIndex = 17
        ' 
        ' lblVlidTo
        ' 
        lblVlidTo.AutoSize = True
        lblVlidTo.Location = New Point(299, 139)
        lblVlidTo.Margin = New Padding(2, 0, 2, 0)
        lblVlidTo.Name = "lblVlidTo"
        lblVlidTo.Size = New Size(64, 15)
        lblVlidTo.TabIndex = 18
        lblVlidTo.Text = "Valid Up to"
        ' 
        ' dtmpValidTo
        ' 
        dtmpValidTo.Location = New Point(402, 141)
        dtmpValidTo.Margin = New Padding(2)
        dtmpValidTo.Name = "dtmpValidTo"
        dtmpValidTo.Size = New Size(196, 23)
        dtmpValidTo.TabIndex = 19
        ' 
        ' lblContactPhNo
        ' 
        lblContactPhNo.AutoSize = True
        lblContactPhNo.Location = New Point(299, 278)
        lblContactPhNo.Margin = New Padding(2, 0, 2, 0)
        lblContactPhNo.Name = "lblContactPhNo"
        lblContactPhNo.Size = New Size(63, 15)
        lblContactPhNo.TabIndex = 24
        lblContactPhNo.Text = "Phone No."
        ' 
        ' txtbxPhNo
        ' 
        txtbxPhNo.Location = New Point(402, 280)
        txtbxPhNo.Margin = New Padding(2)
        txtbxPhNo.Name = "txtbxPhNo"
        txtbxPhNo.Size = New Size(196, 23)
        txtbxPhNo.TabIndex = 25
        ' 
        ' lblContactDesg
        ' 
        lblContactDesg.AutoSize = True
        lblContactDesg.Location = New Point(299, 222)
        lblContactDesg.Margin = New Padding(2, 0, 2, 0)
        lblContactDesg.Name = "lblContactDesg"
        lblContactDesg.Size = New Size(70, 15)
        lblContactDesg.TabIndex = 22
        lblContactDesg.Text = "Designation"
        ' 
        ' txtbxDesignation
        ' 
        txtbxDesignation.Location = New Point(402, 224)
        txtbxDesignation.Margin = New Padding(2)
        txtbxDesignation.Name = "txtbxDesignation"
        txtbxDesignation.Size = New Size(196, 23)
        txtbxDesignation.TabIndex = 23
        ' 
        ' lblContactName
        ' 
        lblContactName.AutoSize = True
        lblContactName.Location = New Point(299, 195)
        lblContactName.Margin = New Padding(2, 0, 2, 0)
        lblContactName.Name = "lblContactName"
        lblContactName.Size = New Size(84, 15)
        lblContactName.TabIndex = 20
        lblContactName.Text = "Contact Name"
        ' 
        ' txtbxContactName
        ' 
        txtbxContactName.Location = New Point(402, 197)
        txtbxContactName.Margin = New Padding(2)
        txtbxContactName.Name = "txtbxContactName"
        txtbxContactName.Size = New Size(196, 23)
        txtbxContactName.TabIndex = 21
        ' 
        ' lblRegStatus
        ' 
        lblRegStatus.AutoSize = True
        lblRegStatus.Location = New Point(299, 166)
        lblRegStatus.Margin = New Padding(2, 0, 2, 0)
        lblRegStatus.Name = "lblRegStatus"
        lblRegStatus.Size = New Size(60, 15)
        lblRegStatus.TabIndex = 26
        lblRegStatus.Text = "File Status"
        ' 
        ' cmbxRegFileStatus
        ' 
        cmbxRegFileStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxRegFileStatus.FormattingEnabled = True
        cmbxRegFileStatus.ItemHeight = 15
        cmbxRegFileStatus.Location = New Point(402, 168)
        cmbxRegFileStatus.Margin = New Padding(2)
        cmbxRegFileStatus.Name = "cmbxRegFileStatus"
        cmbxRegFileStatus.Size = New Size(196, 23)
        cmbxRegFileStatus.TabIndex = 27
        ' 
        ' txtbxCCIName
        ' 
        txtbxCCIName.Location = New Point(403, 3)
        txtbxCCIName.Name = "txtbxCCIName"
        txtbxCCIName.Size = New Size(194, 23)
        txtbxCCIName.TabIndex = 28
        ' 
        ' cmbxCCIRunBy
        ' 
        cmbxCCIRunBy.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxCCIRunBy.FormattingEnabled = True
        cmbxCCIRunBy.Items.AddRange(New Object() {"Government", "Non-Government Organisation"})
        cmbxCCIRunBy.Location = New Point(91, 32)
        cmbxCCIRunBy.Name = "cmbxCCIRunBy"
        cmbxCCIRunBy.Size = New Size(203, 23)
        cmbxCCIRunBy.TabIndex = 29
        ' 
        ' lblCCIRunBy
        ' 
        lblCCIRunBy.AutoSize = True
        lblCCIRunBy.Location = New Point(3, 29)
        lblCCIRunBy.Name = "lblCCIRunBy"
        lblCCIRunBy.Size = New Size(44, 15)
        lblCCIRunBy.TabIndex = 30
        lblCCIRunBy.Text = "Run By"
        ' 
        ' frmNewCCIMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(701, 328)
        Controls.Add(tlpCCIDetails)
        Controls.Add(bttnAddCCI)
        Margin = New Padding(2)
        Name = "frmNewCCIMain"
        Text = "Child Care Institutions"
        tlpCCIDetails.ResumeLayout(False)
        tlpCCIDetails.PerformLayout()
        grpbxPABStatus.ResumeLayout(False)
        grpbxPABStatus.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblDistrict As Label
    Friend WithEvents cmbxDistrict As ComboBox
    Friend WithEvents lblCCIName As Label
    Friend WithEvents lblUnitNo As Label
    Friend WithEvents cmbxUnitNo As ComboBox
    Friend WithEvents bttnAddCCI As Button
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
    Friend WithEvents txtbxCCIName As TextBox
    Friend WithEvents cmbxCCIRunBy As ComboBox
    Friend WithEvents lblCCIRunBy As Label
End Class
