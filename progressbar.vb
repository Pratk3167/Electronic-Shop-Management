Public Class progressbar

    Private Sub progressbar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            Me.Hide()
            main.Show()
            Timer1.Enabled = False
            Exit Sub
        Else
            ProgressBar1.Value += 5
        End If
    End Sub

    
End Class