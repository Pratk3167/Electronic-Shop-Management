Imports System.Data
Imports System.Data.SqlClient

Public Class Frmsales

    Private Sub Btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsubmit.Click
        If txtsid.Text = "" Then
            MessageBox.Show("Please enter value for Sales id")
        ElseIf txtcustname.Text = "" Then
        MessageBox.Show("Please enter value for Customer name")
        ElseIf txtitemcode.Text = "" Then
            MessageBox.Show("Please Enter value for Item Code")
        ElseIf txtqunt.Text = "" Then
        MessageBox.Show("Please Enter value for Item Quantity")
        ElseIf txtpaymeth.Text = "" Then
        MessageBox.Show("Please enter value for Pay Method")
        ElseIf txtpayinfo.Text = "" Then
        MessageBox.Show("Please Enter value for Pay Information")
        ElseIf txtvat.Text = "" Then
        MessageBox.Show("Please Enter value for Item vat")
        ElseIf txttotcost.Text = "" Then
        MessageBox.Show("Please Enter value for Total Cost")
        Else
            sql = "insert into sales values(" & txtsid.Text & ",'" & txtcustname.Text & "','" & stdate.Value & "','" & txtitemcode.Text & "','" & txtqunt.Text & "','" & txtpaymeth.Text & "','" & txtpayinfo.Text & "','" & txtvat.Text & "','" & txttotcost.Text & "')"
        Try

            adapter.InsertCommand = New SqlCommand(sql, cnn)
            adapter.InsertCommand.ExecuteNonQuery()

            MsgBox("Sales details placed successfully...  " & vbOK)
        Catch ex As Exception
            MsgBox(ex.ToString)
            End Try
        End If

        salesid()

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        
        txtitemcode.Text = ""
        txtqunt.Text = ""
        txtpaymeth.Text = ""
        txtpayinfo.Text = ""
        txtvat.Text = ""
        txttotcost.Text = ""
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

    End Sub

    Private Sub Frmsales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select  * from sales"

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
        salesid()

    End Sub

    Private Sub txtitemcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemcode.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtitemcode.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpayinfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayinfo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtpayinfo.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpaymeth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpaymeth.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtpaymeth.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtqunt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqunt.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtqunt.Text) < 4 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    
    Private Sub txttotcost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotcost.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txttotcost.Text) < 10 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtvat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvat.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtvat.Text) < 10 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Sub salesid()
        connectiondb()
        sql = "Select * from items"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txtsid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Item code! ")
        End Try
    End Sub
End Class