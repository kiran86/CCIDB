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
        Try
            ' Inset into CCI
            ModOleDbCon.connectDB()
            sql = "
            insert into CCI
                (District, CCI_NAME, RUN_BY, CCI_UNIT_NO, CCI_UNIT_GENDER, CCI_UNIT_STRENGTH, Address, PIN, CONTACT_NAME, CONTACT_DESG, CONTACT_PHNO, PAB_APPROVED, REG_NO, REG_DATE, REG_VALID_UPTO, REG_STATUS)
            values
                ('" & cmbxDistrict.SelectedItem & "',
                '" & txtbxCCIName.Text & "',
                '" & cmbxCCIRunBy.SelectedItem & "',
                " & Int(txtbxUnitNo.Text) & ", 
                '" & cmbxGender.SelectedItem & "',
                " & Int(txtbxStrength.Text) & ",
                '" & txtbxAddress.Text & "',
                " & Int(txtbxPIN.Text) & ",
                '" & txtbxContactName.Text & "',
                '" & txtbxDesignation.Text & "',
                " & Int(txtbxPhNo.Text) & ",
                " & rdobtnPABYes.Checked & ",
                '" & txtbxRegNo.Text & "',
                #" & dtmpValidFrom.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") & "#,
                #" & dtmpValidTo.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") & "#,
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
                CCI_ID = reader.Item("ID")
            End While
            ' Insert into UNIT_TYPES Relation
            Dim prefix = "insert into UNIT_TYPES
                    (CCI_ID, TYPE_ID)
                    values "
            ' Dumb MS ACCESS does not support multiple row inserts
            ' Loop and execute each row inserts in a single sql
            cmd = ModOleDbCon.conDB.CreateCommand()
            For Each i In lstbxUnitType.SelectedIndices
                sql = prefix & "(" & CCI_ID & ", " & i + 1 & ");"
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
            Next
            MsgBox("CCI Data Added!", MsgBoxStyle.Information, "CCI Added")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(sql)
            MsgBox(ex.Message & ": " & sql)
        Finally
            ModOleDbCon.closeDB()
            Me.Close()
        End Try
    End Sub
End Class
