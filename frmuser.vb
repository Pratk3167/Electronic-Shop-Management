Imports System.Data.SqlClient
Public Class frmuser

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Txtuser.Text = "" Then
            MsgBox("please enter the user name" & vbOK)
        ElseIf Txtpass.Text = "" Then
            MsgBox("PLease enter password" & vbOK)
        ElseIf txtconpass.Text = "" Then
            MsgBox("Please enter confirmation password" & vbOK)
        Else

            sql = "update usermaster set password='" & Txtpass.Text & "' where username='" & Txtuser.Text & "'"
            Try
                adapter.UpdateCommand = cnn.CreateCommand
                adapter.UpdateCommand.CommandText = sql
                adapter.UpdateCommand.ExecuteNonQuery()
                MsgBox("Password updated Successfully....  !! ")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub


    Private Sub frmuser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connectiondb()
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class