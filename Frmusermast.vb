Imports System.Data
Imports System.Data.SqlClient

Public Class Frmusermast

    Private Sub btnsubmitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmitt.Click
        If txtslid.Text = "" Then
            MessageBox.Show("Please enter value for SL ID")
        ElseIf txtfirst.Text = "" Then
            MessageBox.Show("Please enter value for first name")
        ElseIf txtlast.Text = "" Then
            MessageBox.Show("Please Enter value for Last Name")
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Please Enter value for password ")
        ElseIf txtdes.Text = "" Then
            MessageBox.Show("Please Enter value for Description")
        ElseIf txtuser.Text = "" Then
            MessageBox.Show("Please Enter value for User Name")
        ElseIf Len(txtpass.Text) < 8 Then
            MessageBox.Show("Password must be more than 8 character")
        Else
            sql = "insert into usermaster values('" & txtslid.Text & "','" & txtfirst.Text & "','" & txtlast.Text & "','" & txtdes.Text & "','" & txtuser.Text & "','" & txtpass.Text & "')"
            Try
                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()
                MsgBox("Records are inserted...  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        txtfirst.Clear()
        txtlast.Clear()
        txtuser.Clear()
        txtpass.Clear()

        userid()
    End Sub
    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub Frmusermast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select  * from usermaster"
        cnn = New SqlConnection(connetionString)
        Try
            command = New SqlCommand(sql, cnn)
            adapter.SelectCommand = command
            adapter.Fill(ds, "Create DataView")
            adapter.Dispose()
            command.Dispose()
            dv = ds.Tables(0).DefaultView
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtfirst.Focus()
        userid()
    End Sub

    Private Sub txtfirst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfirst.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtfirst.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    
    Private Sub txtslid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtslid.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtslid.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtlast_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlast.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtlast.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtdes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdes.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtdes.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtuser.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtpass.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Sub userid()
        connectiondb()
        sql = "Select * from usermaster"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txtslid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Userid! ")
        End Try
    End Sub

End Class