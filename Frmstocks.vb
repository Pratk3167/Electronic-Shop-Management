Imports System.Data
Imports System.Data.SqlClient

Public Class Frmstocks
    Private Sub Frmstocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select  * from stock"
        Try
            command = New SqlCommand(sql, cnn)
            adapter.SelectCommand = command
            adapter.Fill(ds, "Create DataView")
            adapter.Dispose()
            command.Dispose()
            dv = ds.Tables(0).DefaultView
            DataGridView2.DataSource = dv

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        stockid()

    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txtsid.Text = "" Then
            MessageBox.Show("Please enter value for Stock ID")
        ElseIf txticode.Text = "" Then
            MessageBox.Show("Please enter value for Item Code")
        ElseIf txttotqun.Text = "" Then
            MessageBox.Show("Please Enter value for Total quntity")
        ElseIf txttotsold.Text = "" Then
            MessageBox.Show("Please Enter value for Total Sold")
        ElseIf txtprost.Text = "" Then
            MessageBox.Show("Please Enter value for Problem Stock")
        ElseIf txtcomname.Text = "" Then
            MessageBox.Show("Please Enter value for Comapny name")
        Else
            sql = "insert into stock values(" & txtsid.Text & ",'" & txticode.Text & "','" & txttotqun.Text & "','" & stdate.Text & "','" & txttotsold.Text & "','" & txtprost.Text & "','" & txtcomname.Text & "')"
            Try
                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()
                MsgBox("Records are inserted...  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            txticode.Clear()
            txttotqun.Clear()
            txttotsold.Clear()
            txtprost.Clear()
            txtcomname.Clear()

        End If
        stockid()

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
    End Sub
    Sub stockid()
        connectiondb()
        sql = "Select * from stock"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txtsid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Stock id! ")
        End Try
    End Sub

    Private Sub txticode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txticode.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txticode.Text) < 10 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtprost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprost.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtprost.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcomname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcomname.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtcomname.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txttotqun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotqun.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txttotqun.Text) < 4 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txttotsold_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotsold.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txttotsold.Text) < 4 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub



End Class