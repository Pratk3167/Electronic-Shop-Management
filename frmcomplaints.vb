Imports System.Data
Imports System.Data.SqlClient
Public Class frmcomplaints
    Private Sub Btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsubmit.Click
        If Txtcid.Text = "" Then
            MessageBox.Show("Please enter value for Complaint id")
        ElseIf Txtsid.Text = "" Then
            MessageBox.Show("Please enter value for Sales id")
        ElseIf txtcomplaint.Text = "" Then
            MessageBox.Show("Please Enter value for Complaint")
        Else
            Dim var As String

            If RadioButton1.Checked = True Then
                var = "Recovered"
            Else
                var = "Non Recovered"
            End If

            sql = "insert into complaints values('" & Txtcid.Text & "','" & Txtsid.Text & "','" & txtcomplaint.Text & "','" & var & "')"
            Try

                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()

                MsgBox("Complaint placed successfully...  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Txtsid.Clear()
        txtcomplaint.Clear()
        complaintid()

    End Sub

    Private Sub frmcomplaints_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connectiondb()
        sql = "Select  * from complaints"

        Try

            command = New SqlCommand(sql, cnn)
            adapter.SelectCommand = command
            adapter.Fill(ds, "Create DataView")
            adapter.Dispose()
            Command.Dispose()

            dv = ds.Tables(0).DefaultView
            DataGridView1.DataSource = dv

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        complaintid()
    End Sub

    Private Sub Txtcid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcid.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(Txtcid.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    
    Private Sub Txtsid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtsid.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(Txtsid.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Sub complaintid()
        connectiondb()
        sql = "Select * from complaints"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                Txtcid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Complant id! ")
        End Try
    End Sub

End Class