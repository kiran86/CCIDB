Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks.Dataflow

Public Class frmCCIMain
    Dim sql As String
    Dim cmd As OleDb.OleDbCommand
    Dim reader As OleDb.OleDbDataReader
    Private _CCI_ID As Integer
    Friend Property CCI_ID As Integer
        Get
            Return _CCI_ID
        End Get
        Set(value As Integer)
            _CCI_ID = value
        End Set
    End Property
    Private Sub frmCCIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModOleDbCon.connectDB()

        'Populate Districts ComboBox
        sql = "select * from DISTRICTS"
        cmd = ModOleDbCon.conDB.CreateCommand()
        cmd.CommandText = sql
        reader = cmd.ExecuteReader()

        While reader.Read()
            cmbxDistrict.Items.Add(reader.Item("DISTRICT"))
        End While
        cmd.Dispose()

        'Populate CCI Unit Type ListBox
        sql = "select * from CCI_UNIT_TYPE"
        cmd = ModOleDbCon.conDB.CreateCommand()
        cmd.CommandText = sql
        reader = cmd.ExecuteReader()

        While reader.Read()
            lstbxUnitType.Items.Add(reader.Item("CATEGORY"))
        End While
        cmd.Dispose()

        'Populate Registration Status ComboBox
        sql = "select * from STATUS"
        cmd = ModOleDbCon.conDB.CreateCommand()
        cmd.CommandText = sql
        reader = cmd.ExecuteReader()

        While reader.Read()
            cmbxRegFileStatus.Items.Add(reader.Item("REG_STATUS"))
        End While
        cmd.Dispose()

        ModOleDbCon.closeDB()
    End Sub

    Private Sub cmbxDistrict_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbxDistrict.SelectionChangeCommitted
        cmbxCCI.Items.Clear()
        cmbxCCI.ResetText()
        ModOleDbCon.connectDB()
        sql = "select distinct CCI_NAME from CCI where District = '" & cmbxDistrict.SelectedItem & "'"
        Try
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader()
            While reader.Read()
                cmbxCCI.Items.Add(reader.Item("CCI_NAME"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ModOleDbCon.closeDB()
        End Try
    End Sub

    Private Sub cmbxCCI_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbxCCI.SelectionChangeCommitted
        cmbxUnitNo.ResetText()
        ModOleDbCon.connectDB()
        sql = "select distinct CCI.ID as CCI_ID, CCI.CCI_UNIT_NO & ' ' & CCI_UNIT_TYPE.type_of_child as CATEGORY
                from CCI, UNIT_TYPES, CCI_UNIT_TYPE
                where 
                    CCI.District = '" & cmbxDistrict.SelectedItem & "' and 
                    CCI.CCI_NAME = '" & cmbxCCI.SelectedItem & "' and
                    CCI.ID = UNIT_TYPES.CCI_ID and UNIT_TYPES.TYPE_ID = CCI_UNIT_TYPE.ID"
        'System.Diagnostics.Debug.WriteLine(sql)

        Dim dict As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
        Try
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader()
            While reader.Read()
                dict.Add(reader.Item("CCI_ID"), reader.Item("CATEGORY"))
            End While
            cmbxUnitNo.DataSource = New BindingSource(dict, Nothing)
            cmbxUnitNo.ValueMember = "Key"
            cmbxUnitNo.DisplayMember = "Value"
            cmbxUnitNo.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ModOleDbCon.closeDB()
        End Try
    End Sub

    Private Sub cmbxUnitNo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbxUnitNo.SelectionChangeCommitted
        tlpCCIDetails.Enabled = True
        ModOleDbCon.connectDB()
        'Set values as per selections
        sql = "select *  
                from CCI
                left join STATUS
                on CCI.REG_STATUS = STATUS.ID
                where 
                    CCI.ID = " & cmbxUnitNo.SelectedValue & ";"
        Try
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader()

            While reader.Read()
                CCI_ID = reader.Item("CCI.ID")
                cmbxCCIRunBy.SelectedItem = reader.Item("RUN_BY")
                cmbxGender.SelectedItem = reader.Item("CCI_UNIT_GENDER")
                If reader.Item("PAB_APPROVED") = True Then
                    rdobtnPABYes.Select()
                Else
                    rdobtnPABNo.Select()
                End If
                txtbxStrength.Text = reader.Item("CCI_UNIT_STRENGTH")
                txtbxAddress.Text = reader.Item("Address")
                txtbxPIN.Text = reader.Item("PIN")
                txtbxRegNo.Text = reader.Item("REG_NO")
                txtbxContactName.Text = reader.Item("CONTACT_NAME").ToString
                txtbxDesignation.Text = reader.Item("CONTACT_DESG").ToString
                txtbxPhNo.Text = reader.Item("CONTACT_PHNO").ToString
                dtmpValidFrom.Value = reader.Item("REG_DATE")
                dtmpValidTo.Value = reader.Item("REG_VALID_UPTO")
                cmbxRegFileStatus.SelectedItem = reader.Item("STATUS.REG_STATUS")
            End While
            cmd.Dispose()

            'Get CCI category
            lstbxUnitType.ClearSelected()
            sql = "select * 
                    from UNIT_TYPES, CCI_UNIT_TYPE
                    where CCI_ID = " & CCI_ID & " AND
                    UNIT_TYPES.TYPE_ID = CCI_UNIT_TYPE.ID"
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader()
            Dim i = 0
            While reader.Read()
                'MsgBox(lstbxUnitType.Items.Item(i).ToString & " AND " & reader.Item("category").ToString)
                lstbxUnitType.SelectedItem = reader.Item("category")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString & Environment.NewLine & "SQL: " & sql)
        Finally
            ModOleDbCon.closeDB()
            bttnUpdate.Enabled = True
            bttnAddUnit.Enabled = True
        End Try
    End Sub

    Private Sub bttnUpdate_Click(sender As Object, e As EventArgs) Handles bttnUpdate.Click
        ' Update CCI Table
        sql = "update CCI set
                RUN_BY = '" & cmbxCCIRunBy.SelectedItem & "',
                CCI_UNIT_GENDER = '" & cmbxGender.SelectedItem & "',
                CCI_UNIT_STRENGTH = " & Int(txtbxStrength.Text) & ",
                Address = '" & txtbxAddress.Text & "',
                PIN = " & Int(txtbxPIN.Text) & ",
                CONTACT_NAME = '" & txtbxContactName.Text & "',
                CONTACT_DESG = '" & txtbxDesignation.Text & "',
                CONTACT_PHNO = " & If(txtbxPhNo.Text = "", 0, Int(txtbxPhNo.Text)) & ",
                PAB_APPROVED = " & rdobtnPABYes.Checked & ",
                REG_NO = '" & txtbxRegNo.Text & "',
                REG_DATE = #" & dtmpValidFrom.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") & "#,
                REG_VALID_UPTO = #" & dtmpValidTo.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") & "#,
                REG_STATUS = " & cmbxRegFileStatus.SelectedIndex + 1 & "
                where ID = " & cmbxUnitNo.SelectedValue & ";"
        Try
            ModOleDbCon.connectDB()
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(sql)
            MsgBox(ex.Message & ": " & sql)
        Finally
            MsgBox("CCI Data Updated!", , "Updated")
            UtilityFunctions.ClearForm(Me)
            ModOleDbCon.closeDB()
        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        frmNewCCIMain.ShowDialog()
    End Sub

    Private Sub bttnAddUnit_Click(sender As Object, e As EventArgs) Handles bttnAddUnit.Click
        frmNewCCIUnit.ShowDialog()
    End Sub

    Private Sub TestFuncToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestFuncToolStripMenuItem.Click
        UtilityFunctions.ClearForm(Me)
    End Sub
End Class
