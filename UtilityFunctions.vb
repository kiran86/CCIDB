Module UtilityFunctions
    Public Sub ClearForm(ByVal TargetForm As Form)
        For Each control In TargetForm.Controls
            If TypeName(control) = "TextBox" Then
                System.Diagnostics.Debug.WriteLine(control.Text)
            End If
        Next
    End Sub
End Module
