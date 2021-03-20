Imports System.Data
Imports System.Data.SqlClient

Public Class Frmitemmast

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txtid.Text = "" Then
            MessageBox.Show("Please enter value for Item ID")
        ElseIf txtname.Text = "" Then
            MessageBox.Show("Please enter value for Item name")
        ElseIf txtdes.Text = "" Then
            MessageBox.Show("Please Enter value for Item Description")

        Else

            sql = "insert into itemmaster values('" & txtid.Text & "','" & txtname.Text & "','" & txtdes.Text & "')"
            Try

                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()

                MsgBox("Records are inserted.....  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        txtname.Clear()
        txtdes.Clear()
        itemid()


    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub Frmitemmast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select  * from itemmaster"

        Try
            command = New SqlCommand(sql, cnn)
            adapter.SelectCommand = command
            adapter.Fill(ds, "Create DataView")
            adapter.Dispose()
            command.Dispose()
            cnn.Close()

            dv = ds.Tables(0).DefaultView
            DataGridView1.DataSource = dv

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        itemid()

    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtname.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Sub itemid()
        connectiondb()
        sql = "Select * from installments"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txtid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Item id! ")
        End Try
    End Sub
End Class