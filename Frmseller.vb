
Imports System.Data
Imports System.Data.SqlClient


Public Class Frmseller



    Private Sub Frmseller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select  * from seller"

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

    End Sub

    Private Sub Btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsubmit.Click
        If txtslid.Text = "" Then
            MessageBox.Show("Please enter value for Seller id")
        ElseIf txtsellname.Text = "" Then
            MessageBox.Show("Please enter value for Seller name")
        ElseIf txtcomcode.Text = "" Then
            MessageBox.Show("Please Enter value for Company name")
        ElseIf txtadd.Text = "" Then
            MessageBox.Show("Please Enter value for Seller Address")
        ElseIf txtcont.Text = "" Then
            MessageBox.Show("Please Enter value for Seller  Contact")

        Else
            sql = "insert into seller values(" & txtslid.Text & ",'" & txtsellname.Text & "','" & txtcomcode.Text & "','" & txtadd.Text & "','" & txtcont.Text & "')"
            Try

                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()

                MsgBox("Sales details placed successfully...  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        sellerid()
    End Sub

    Sub sellerid()
        connectiondb()
        sql = "Select * from seller"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txtslid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Seller id! ")
        End Try
    End Sub

    
    
    
   


    Private Sub txtsellname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsellname.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtsellname.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub




    Private Sub txtcont_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcont.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtcont.Text) < 13 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtadd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtadd.Text) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtcomcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcomcode.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtcomcode.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub
End Class