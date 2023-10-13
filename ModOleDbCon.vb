Module ModOleDbCon
    Public conDB As New OleDb.OleDbConnection

    Public Sub connectDB()
        conDB.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0; Data Source=" & Application.StartupPath & "\DB\CCIDB.mdb"
        If conDB.State = ConnectionState.Closed Then
            Try
                conDB.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub closeDB()
        If conDB.State = ConnectionState.Open Then
            conDB.Close()
        End If
    End Sub
End Module
