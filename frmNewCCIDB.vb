Imports System.ComponentModel
Imports System.Threading.Tasks.Dataflow

Public Class frmNewCCIMain
    Dim sql As String
    Dim cmd As OleDb.OleDbCommand
    Dim reader As OleDb.OleDbDataReader
    Dim CCI_ID As Integer
    Private Sub frmNewCCIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub bttnAddCCI_Click(sender As Object, e As EventArgs) Handles bttnAddCCI.Click, bttnAddCCI.Click
        ' Update CCI Table
        sql = "
            insert into CCI
                (District, CCI_NAME, CCI_UNIT_NO, CCI_UNIT_GENDER, CCI_UNIT_STRENGTH, Address, PIN, CONTACT_NAME, CONTACT_DESG, CONTACT_PHNO, PAB_APPROVED, REG_NO, REG_DATE, REG_VALID_UPTO, REG_STATUS)
            values
                ('" & cmbxDistrict.SelectedItem & "',
                '" & txtbxCCIName.Text & "', 1,
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
        Try
            ModOleDbCon.connectDB()
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(sql)
            MsgBox(ex.Message & ": " & sql)
        Finally
            MsgBox("CCI Data Added!", , "CCI Added")
            ModOleDbCon.closeDB()
        End Try
    End Sub
End Class
