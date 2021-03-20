Imports System.Data
Imports System.Data.SqlClient


Public Class Frmvat

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txtvatid.Text = "" Then
            MessageBox.Show("Please enter value for VAT ID")
        ElseIf txtvattype.Text = "" Then
            MessageBox.Show("Please enter value for VAT Type")
        ElseIf txtpervat.Text = "" Then
            MessageBox.Show("Please Enter value for Per VAT")
        ElseIf txtvatdesc.Text = "" Then
            MessageBox.Show("Please Enter value for VAT Description")

        Else
            sql = "insert into vatmaster values(" & txtvatid.Text & ",'" & txtvattype.Text & "','" & txtpervat.Text & "','" & txtvatdesc.Text & "')"
            Try
                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()
                MsgBox("Records are inserted...  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        txtvattype.Clear()
        txtvatdesc.Clear()
        txtpervat.Clear()

        vatid()

    End Sub

    Private Sub Frmvat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select  * from vatmaster"
        cnn = New SqlConnection(connetionString)
        Try
            cnn.Open()
            command = New SqlCommand(sql, cnn)
            adapter.SelectCommand = command
            adapter.Fill(ds, "Create DataView")
            adapter.Dispose()
            command.Dispose()
            cnn.Close()

            dv = ds.Tables(0).DefaultView
            DataGridView2.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        vatid()

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtvatid.Text = ""
        txtvattype.Text = ""
        txtpervat.Text = ""
        txtvatdesc.Text = ""

    End Sub


    Private Sub txtpervat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpervat.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtpervat.Text) < 4 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtvattype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvattype.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtvattype.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Sub vatid()
        connectiondb()
        sql = "Select * from vatmaster"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txtvatid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid VAT id! ")
        End Try
    End Sub

End Class