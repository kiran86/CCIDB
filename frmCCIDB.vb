Public Class frmCCIMain
    Dim sql As String
    Dim cmd As OleDb.OleDbCommand
    Dim reader As OleDb.OleDbDataReader
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

    Private Sub cmbxDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxDistrict.SelectedIndexChanged
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

    Private Sub cmbxCCI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCCI.SelectedIndexChanged
        cmbxUnitNo.Items.Clear()
        cmbxUnitNo.ResetText()
        ModOleDbCon.connectDB()
        sql = "select CCI_UNIT_NO 
                from CCI
                where 
                    District = '" & cmbxDistrict.SelectedItem & "' AND 
                    CCI_NAME = '" & cmbxCCI.SelectedItem & "'"
        Try
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader()
            While reader.Read()
                cmbxUnitNo.Items.Add(reader.Item("CCI_UNIT_NO"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ModOleDbCon.closeDB()
        End Try
    End Sub

    Private Sub cmbxUnitNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxUnitNo.SelectedIndexChanged
        tlpCCIDetails.Enabled = True
        ModOleDbCon.connectDB()
        'Set values as per selections
        sql = "select *  
                from CCI, CCI_UNIT_TYPE, STATUS
                where 
                    CCI.District = '" & cmbxDistrict.SelectedItem & "' AND 
                    CCI.CCI_NAME = '" & cmbxCCI.SelectedItem & "' AND
                    CCI.CCI_UNIT_NO = " & cmbxUnitNo.SelectedItem & " AND
                    CCI.CCI_UNIT_TYPE = CCI_UNIT_TYPE.ID" & " AND
                    CCI.REG_STATUS = STATUS.ID"
        Try
            cmd = ModOleDbCon.conDB.CreateCommand()
            cmd.CommandText = sql
            reader = cmd.ExecuteReader()

            While reader.Read()
                cmbxGender.SelectedItem = reader.Item("CCI_UNIT_GENDER")
                If reader.Item("PAB_APPROVED") = True Then
                    rdobtnPABYes.Select()
                Else
                    rdobtnPABNo.Select()
                End If
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ModOleDbCon.closeDB()
        End Try
    End Sub
End Class
