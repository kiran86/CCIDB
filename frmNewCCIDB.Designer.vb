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
        lblDistrict.Location = New Point(3, 0)
        lblDistrict.Name = "lblDistrict"
        lblDistrict.Size = New Size(67, 25)
        lblDistrict.TabIndex = 1
        lblDistrict.Text = "District"
        ' 
        ' cmbxDistrict
        ' 
        cmbxDistrict.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxDistrict.FormattingEnabled = True
        cmbxDistrict.Location = New Point(129, 3)
        cmbxDistrict.Name = "cmbxDistrict"
        cmbxDistrict.Size = New Size(291, 33)
        cmbxDistrict.TabIndex = 2
        ' 
        ' lblCCIName
        ' 
        lblCCIName.AutoSize = True
        lblCCIName.Location = New Point(428, 0)
        lblCCIName.Name = "lblCCIName"
        lblCCIName.Size = New Size(91, 25)
        lblCCIName.TabIndex = 3
        lblCCIName.Text = "CCI Name"
        ' 
        ' lblStrength
        ' 
        lblStrength.AutoSize = True
        lblStrength.Location = New Point(3, 123)
        lblStrength.Name = "lblStrength"
        lblStrength.Size = New Size(79, 25)
        lblStrength.TabIndex = 11
        lblStrength.Text = "Strength"
        ' 
        ' cmbxGender
        ' 
        cmbxGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxGender.FormattingEnabled = True
        cmbxGender.Items.AddRange(New Object() {"Male", "Female", "Combined", "Transgender"})
        cmbxGender.Location = New Point(129, 87)
        cmbxGender.Name = "cmbxGender"
        cmbxGender.Size = New Size(291, 33)
        cmbxGender.TabIndex = 8
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(3, 84)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(69, 25)
        lblGender.TabIndex = 7
        lblGender.Text = "Gender"
        ' 
        ' bttnAddCCI
        ' 
        bttnAddCCI.Location = New Point(879, 117)
        bttnAddCCI.Name = "bttnAddCCI"
        bttnAddCCI.Size = New Size(111, 58)
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
        tlpCCIDetails.Location = New Point(16, 18)
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
        tlpCCIDetails.RowStyles.Add(New RowStyle(SizeType.Absolute, 33F))
        tlpCCIDetails.Size = New Size(857, 523)
        tlpCCIDetails.TabIndex = 12
        ' 
        ' txtbxStrength
        ' 
        txtbxStrength.Location = New Point(129, 126)
        txtbxStrength.Name = "txtbxStrength"
        txtbxStrength.Size = New Size(291, 31)
        txtbxStrength.TabIndex = 12
        ' 
        ' lblUnitType
        ' 
        lblUnitType.AutoSize = True
        lblUnitType.Location = New Point(3, 160)
        lblUnitType.Name = "lblUnitType"
        lblUnitType.Size = New Size(118, 25)
        lblUnitType.TabIndex = 13
        lblUnitType.Text = "CCI Unit Type"
        ' 
        ' lstbxUnitType
        ' 
        lstbxUnitType.FormattingEnabled = True
        lstbxUnitType.ItemHeight = 25
        lstbxUnitType.Location = New Point(129, 163)
        lstbxUnitType.Name = "lstbxUnitType"
        tlpCCIDetails.SetRowSpan(lstbxUnitType, 3)
        lstbxUnitType.SelectionMode = SelectionMode.MultiSimple
        lstbxUnitType.Size = New Size(291, 129)
        lstbxUnitType.TabIndex = 14
        ' 
        ' grpbxPABStatus
        ' 
        tlpCCIDetails.SetColumnSpan(grpbxPABStatus, 2)
        grpbxPABStatus.Controls.Add(rdobtnPABYes)
        grpbxPABStatus.Controls.Add(rdobtnPABNo)
        grpbxPABStatus.Location = New Point(428, 44)
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
        rdobtnPABYes.Location = New Point(6, 33)
        rdobtnPABYes.Name = "rdobtnPABYes"
        rdobtnPABYes.Size = New Size(62, 29)
        rdobtnPABYes.TabIndex = 9
        rdobtnPABYes.TabStop = True
        rdobtnPABYes.Text = "Yes"
        rdobtnPABYes.UseVisualStyleBackColor = True
        ' 
        ' rdobtnPABNo
        ' 
        rdobtnPABNo.AutoSize = True
        rdobtnPABNo.Location = New Point(74, 33)
        rdobtnPABNo.Name = "rdobtnPABNo"
        rdobtnPABNo.Size = New Size(61, 29)
        rdobtnPABNo.TabIndex = 10
        rdobtnPABNo.TabStop = True
        rdobtnPABNo.Text = "No"
        rdobtnPABNo.UseVisualStyleBackColor = True
        ' 
        ' lblCCIAddress
        ' 
        lblCCIAddress.AutoSize = True
        lblCCIAddress.Location = New Point(3, 295)
        lblCCIAddress.Name = "lblCCIAddress"
        lblCCIAddress.Size = New Size(77, 25)
        lblCCIAddress.TabIndex = 23
        lblCCIAddress.Text = "Address"
        ' 
        ' txtbxAddress
        ' 
        txtbxAddress.Location = New Point(129, 298)
        txtbxAddress.Multiline = True
        txtbxAddress.Name = "txtbxAddress"
        tlpCCIDetails.SetRowSpan(txtbxAddress, 2)
        txtbxAddress.Size = New Size(291, 129)
        txtbxAddress.TabIndex = 24
        ' 
        ' lblPIN
        ' 
        lblPIN.AutoSize = True
        lblPIN.Location = New Point(3, 430)
        lblPIN.Name = "lblPIN"
        lblPIN.Size = New Size(40, 25)
        lblPIN.TabIndex = 25
        lblPIN.Text = "PIN"
        ' 
        ' txtbxPIN
        ' 
        txtbxPIN.Location = New Point(129, 433)
        txtbxPIN.Name = "txtbxPIN"
        txtbxPIN.Size = New Size(291, 31)
        txtbxPIN.TabIndex = 26
        ' 
        ' lblRegNo
        ' 
        lblRegNo.AutoSize = True
        lblRegNo.Location = New Point(428, 123)
        lblRegNo.Name = "lblRegNo"
        lblRegNo.Size = New Size(135, 25)
        lblRegNo.TabIndex = 15
        lblRegNo.Text = "Registration No"
        ' 
        ' txtbxRegNo
        ' 
        txtbxRegNo.Location = New Point(575, 126)
        txtbxRegNo.Name = "txtbxRegNo"
        txtbxRegNo.Size = New Size(278, 31)
        txtbxRegNo.TabIndex = 16
        ' 
        ' lblValidFrom
        ' 
        lblValidFrom.AutoSize = True
        lblValidFrom.Location = New Point(428, 160)
        lblValidFrom.Name = "lblValidFrom"
        lblValidFrom.Size = New Size(97, 25)
        lblValidFrom.TabIndex = 17
        lblValidFrom.Text = "Valid From"
        ' 
        ' dtmpValidFrom
        ' 
        dtmpValidFrom.Location = New Point(575, 163)
        dtmpValidFrom.Name = "dtmpValidFrom"
        dtmpValidFrom.Size = New Size(278, 31)
        dtmpValidFrom.TabIndex = 18
        ' 
        ' lblVlidTo
        ' 
        lblVlidTo.AutoSize = True
        lblVlidTo.Location = New Point(428, 197)
        lblVlidTo.Name = "lblVlidTo"
        lblVlidTo.Size = New Size(100, 25)
        lblVlidTo.TabIndex = 19
        lblVlidTo.Text = "Valid Up to"
        ' 
        ' dtmpValidTo
        ' 
        dtmpValidTo.Location = New Point(575, 200)
        dtmpValidTo.Name = "dtmpValidTo"
        dtmpValidTo.Size = New Size(278, 31)
        dtmpValidTo.TabIndex = 20
        ' 
        ' lblContactPhNo
        ' 
        lblContactPhNo.AutoSize = True
        lblContactPhNo.Location = New Point(428, 430)
        lblContactPhNo.Name = "lblContactPhNo"
        lblContactPhNo.Size = New Size(95, 25)
        lblContactPhNo.TabIndex = 31
        lblContactPhNo.Text = "Phone No."
        ' 
        ' txtbxPhNo
        ' 
        txtbxPhNo.Location = New Point(575, 433)
        txtbxPhNo.Name = "txtbxPhNo"
        txtbxPhNo.Size = New Size(278, 31)
        txtbxPhNo.TabIndex = 32
        ' 
        ' lblContactDesg
        ' 
        lblContactDesg.AutoSize = True
        lblContactDesg.Location = New Point(428, 332)
        lblContactDesg.Name = "lblContactDesg"
        lblContactDesg.Size = New Size(107, 25)
        lblContactDesg.TabIndex = 29
        lblContactDesg.Text = "Designation"
        ' 
        ' txtbxDesignation
        ' 
        txtbxDesignation.Location = New Point(575, 335)
        txtbxDesignation.Name = "txtbxDesignation"
        txtbxDesignation.Size = New Size(278, 31)
        txtbxDesignation.TabIndex = 30
        ' 
        ' lblContactName
        ' 
        lblContactName.AutoSize = True
        lblContactName.Location = New Point(428, 295)
        lblContactName.Name = "lblContactName"
        lblContactName.Size = New Size(125, 25)
        lblContactName.TabIndex = 27
        lblContactName.Text = "Contact Name"
        ' 
        ' txtbxContactName
        ' 
        txtbxContactName.Location = New Point(575, 298)
        txtbxContactName.Name = "txtbxContactName"
        txtbxContactName.Size = New Size(278, 31)
        txtbxContactName.TabIndex = 28
        ' 
        ' lblRegStatus
        ' 
        lblRegStatus.AutoSize = True
        lblRegStatus.Location = New Point(428, 234)
        lblRegStatus.Name = "lblRegStatus"
        lblRegStatus.Size = New Size(91, 25)
        lblRegStatus.TabIndex = 21
        lblRegStatus.Text = "File Status"
        ' 
        ' cmbxRegFileStatus
        ' 
        cmbxRegFileStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxRegFileStatus.FormattingEnabled = True
        cmbxRegFileStatus.ItemHeight = 25
        cmbxRegFileStatus.Location = New Point(575, 237)
        cmbxRegFileStatus.Name = "cmbxRegFileStatus"
        cmbxRegFileStatus.Size = New Size(278, 33)
        cmbxRegFileStatus.TabIndex = 22
        ' 
        ' txtbxCCIName
        ' 
        txtbxCCIName.Location = New Point(576, 5)
        txtbxCCIName.Margin = New Padding(4, 5, 4, 5)
        txtbxCCIName.Name = "txtbxCCIName"
        txtbxCCIName.Size = New Size(275, 31)
        txtbxCCIName.TabIndex = 4
        ' 
        ' cmbxCCIRunBy
        ' 
        cmbxCCIRunBy.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxCCIRunBy.FormattingEnabled = True
        cmbxCCIRunBy.Items.AddRange(New Object() {"Government", "Non-Government Organisation"})
        cmbxCCIRunBy.Location = New Point(130, 46)
        cmbxCCIRunBy.Margin = New Padding(4, 5, 4, 5)
        cmbxCCIRunBy.Name = "cmbxCCIRunBy"
        cmbxCCIRunBy.Size = New Size(288, 33)
        cmbxCCIRunBy.TabIndex = 6
        ' 
        ' lblCCIRunBy
        ' 
        lblCCIRunBy.AutoSize = True
        lblCCIRunBy.Location = New Point(4, 41)
        lblCCIRunBy.Margin = New Padding(4, 0, 4, 0)
        lblCCIRunBy.Name = "lblCCIRunBy"
        lblCCIRunBy.Size = New Size(67, 25)
        lblCCIRunBy.TabIndex = 5
        lblCCIRunBy.Text = "Run By"
        ' 
        ' frmNewCCIMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1001, 547)
        Controls.Add(tlpCCIDetails)
        Controls.Add(bttnAddCCI)
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
