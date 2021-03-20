Imports System.Data
Imports System.Data.SqlClient

Public Class frmlogin


    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        sql = "Select * from usermaster where username='" & txtuser.Text & "' and password='" & txtpass.Text & "'"

        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                Me.Hide()
                progressbar.Show()
            End While
            reader.Close()
            cmd.Dispose()
            cnn.Close()
        Catch ex As Exception
            MsgBox("Invalid Username and Password! ")
        End Try

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuser.Text = ""
        txtpass.Text = ""
        connectiondb()
    End Sub


    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub
End Class
