
Imports System.Data.SqlClient

Public Class Frmcustomer

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewen.Click
        Me.Close()
    End Sub

    Private Sub Frmcustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        customerid()


    End Sub

    Private Sub Btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsubmit.Click
        If txtcustid.Text = "" Then
            MessageBox.Show("Please enter value for Customer id")
        ElseIf txtcfname.Text = "" Then
            MessageBox.Show("Please enter value for Customer First name")
        ElseIf txtclname.Text = "" Then
            MessageBox.Show("Please Enter value for Customer Last name")
        ElseIf txtcadd.Text = "" Then
            MessageBox.Show("Please Enter value for Customer Address")
        ElseIf txtcpin.Text = "" Then
            MessageBox.Show("Please Enter value for Customer  PIN")
        ElseIf txtcont.Text = "" Then
            MessageBox.Show("Please Enter value for Customer  Contact")

        Else
            sql = "insert into seller values(" & txtcustid.Text & ",'" & txtcfname.Text & "','" & txtclname.Text & "','" & txtcadd.Text & "','" & txtcpin.Text & "')"
            Try

                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()

                MsgBox("Sales details placed successfully...  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        customerid()

    End Sub

    Sub customerid()
        connectiondb()
        sql = "Select * from customer"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txtcustid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Customer id! ")
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Btnsubmit.Visible = False
        If btnedit.Text = "EDIT" Then
            btnedit.Text = "UPDATE"
        Else
            sql = "update customer set custfname='" & txtcfname.Text & "',custlname='" & txtclname.Text & "',custaddress='" & txtcadd.Text & "',pincode=" & txtcpin.Text & ",contactno=" & txtcont.Text & " where custid='" & txtcustid.Text & "'"
            Try
                adapter.UpdateCommand = cnn.CreateCommand
                adapter.UpdateCommand.CommandText = sql
                adapter.UpdateCommand.ExecuteNonQuery()
                MsgBox("Record updated Successfully....  !! ")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            btnedit.Text = "EDIT"
        End If

    End Sub
End Class