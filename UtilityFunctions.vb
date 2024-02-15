Module UtilityFunctions
    Public Sub ClearForm(ByVal TargetForm As Form)
        'System.Diagnostics.Debug.WriteLine(TargetForm.Controls.Item(0).GetType())
        For Each control In TargetForm.Controls
            If TypeName(control) = "ComboBox" Then
                CType(control, ComboBox).SelectedIndex = -1
            End If
            If TypeName(control) = "TableLayoutPanel" Then
                Dim controls = CType(control, TableLayoutPanel).Controls
                For Each c In controls
                    System.Diagnostics.Debug.WriteLine(c.GetType)
                    If TypeName(c) = "ComboBox" Then
                        CType(c, ComboBox).SelectedIndex = -1
                    End If
                    If TypeName(c) = "TextBox" Then
                        CType(c, TextBox).Clear()
                    End If
                    If TypeName(c) = "ListBox" Then
                        CType(c, ListBox).ClearSelected()
                    End If
                Next
            End If
        Next
    End Sub
End Module
