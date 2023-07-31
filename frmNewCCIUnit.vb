Imports System.ComponentModel
Imports System.Threading.Tasks.Dataflow

Public Class frmNewCCIUnit
    Dim sql As String
    Dim cmd As OleDb.OleDbCommand
    Dim reader As OleDb.OleDbDataReader
    Dim CCI_ID = frmCCIMain.CCI_ID
    Dim unit_no As Integer
    Private Sub frmNewCCIUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Set values from the main CCI unit
        sql = "select * from CCI where ID = " & CCI_ID & ";"
        cmd = ModOleDbCon.conDB.CreateCommand()
        cmd.CommandText = sql
        reader = cmd.ExecuteReader()

        While reader.Read()
            cmbxDistrict.SelectedItem = reader.Item("District")
            txtbxCCIName.Text = reader.Item("CCI_NAME")
            cmbxCCIRunBy.SelectedItem = reader.Item("RUN_BY")
            txtbxAddress.Text = reader.Item("Address")
            txtbxPIN.Text = reader.Item("PIN")
            unit_no = reader.Item("CCI_UNIT_NO")
        End While

        ModOleDbCon.closeDB()
    End Sub

    Private Sub bttnAddCCI_Click(sender As Object, e As EventArgs) Handles bttnAddCCIUnit.Click
        Dim cci_id As Integer
        Try
            ModOleDbCon.connectDB()
            ' Find no. of units of selected category functioning
            sql = "select count(*)  
                from CCI, UNIT_TYPES
                where 
                    CCI.District = '" & cmbxDistrict.SelectedItem & "' AND
                    CCI.CCI_NAME = '" & txtbxCCIName.Text & "' AND
                    UNIT_TYPES.TYPE_ID = " &  & "
                    CCI.ID = UNIT_TYPES.CCI_ID
CCI.CCI_UNIT_TYPE = CCI_UNIT_TYPE.ID AND
                    CCI.REG_STATUS = STATUS.ID"
            Try
                cmd = ModOleDbCon.conDB.CreateCommand()
                cmd.CommandText = sql
                reader = cmd.ExecuteReader()
                ' Inset into CCI Table
                sql = "
            insert into CCI
                (District, CCI_NAME, RUN_BY, CCI_UNIT_NO, CCI_UNIT_GENDER, CCI_UNIT_STRENGTH, Address, PIN, CONTACT_NAME, CONTACT_DESG, CONTACT_PHNO, PAB_APPROVED, REG_NO, REG_DATE, REG_VALID_UPTO, REG_STATUS)
            values
                ('" & cmbxDistrict.SelectedItem & "',
                '" & txtbxCCIName.Text & "',
                '" & cmbxCCIRunBy.SelectedItem & "',
                " & unit_no + 1 & ", 
                '" & cmbxGender.SelectedItem & "',
                " & Int(txtbxStrength.Text) & ",
                '" & txtbxAddress.Text & "',
                " & Int(txtbxPIN.Text) & ",
                '" & txtbxContactName.Text & "',
                '" & txtbxDesignation.Text & "',
                " & Int(txtbxPhNo.Text) & ",
                " & rdobtnPABYes.Checked & ",
                '" & txtbxRegNo.Text & "',
                #" & dtmpValidFrom.Value.Date.ToString & "#,
                #" & dtmpValidTo.Value.Date.ToString & "#,
                " & cmbxRegFileStatus.SelectedIndex + 1 & ");"
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            ' get last inserted record id
            sql = "select ID from CCI where District = '" & cmbxDistrict.SelectedItem & "' and CCI_NAME = '" & txtbxCCIName.Text & "'"
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader()
            While reader.Read()
                cci_id = reader.Item("ID")
            End While
            ' Insert into UNIT_TYPES Relation
            sql = "insert into UNIT_TYPES
                    (CCI_ID, TYPE_ID)
                    values"
            For Each i In lstbxUnitType.SelectedIndices
                sql = sql & "(" & cci_id & ", " & i + 1 & "),"
            Next
            sql = sql.Remove(sql.Length - 1, 1)
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MsgBox("CCI Data Added!", MsgBoxStyle.Information, "CCI Added")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(sql)
            MsgBox(ex.Message & ": " & sql)
        Finally
            ModOleDbCon.closeDB()
        End Try
    End Sub
End Class
