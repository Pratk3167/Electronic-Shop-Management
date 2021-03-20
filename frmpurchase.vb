Imports System.Data
Imports System.Data.SqlClient

Public Class frmpurchase

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txticode.Text = "" Then
            MessageBox.Show("Please enter value for Item code")
        ElseIf txtitemname.Text = "" Then
            MessageBox.Show("Please enter value for Item name")
        ElseIf txtitemcom.Text = "" Then
            MessageBox.Show("Please Enter value for Item company")
        ElseIf txtitemmod.Text = "" Then
            MessageBox.Show("Please Enter value for Item model")
        ElseIf txtitemdesc.Text = "" Then
            MessageBox.Show("Please Enter value for Item Description")
        ElseIf txtfeat.Text = "" Then
            MessageBox.Show("Please Enter value for Item feature")
        ElseIf txtvat.Text = "" Then
            MessageBox.Show("Please enter value for Item VAT")
        ElseIf txtscost.Text = "" Then
            MessageBox.Show("Please Enter value for Sell Cost")
        ElseIf txtpcost.Text = "" Then
            MessageBox.Show("Please Enter value for Purchase Cost")
        ElseIf txtwarranty.Text = "" Then
            MessageBox.Show("Please Enter value for Warranty")

        Else
            'Dim img As Image
            sql = "insert into items values(" & txticode.Text & ",'" & txtitemname.Text & "','" & txtitemcom.Text & "','" & txtitemmod.Text & "','" & txtitemdesc.Text & "','" & txtfeat.Text & "','" & txtvat.Text & "','" & txtpcost.Text & "','" & txtscost.Text & "','" & txtwarranty.Text & "','img')"
            Try

                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()

                MsgBox("Purchase details placed successfully...  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



            txtitemname.Text = ""
            txtitemcom.Text = ""
            txtitemmod.Text = ""
            txtitemdesc.Text = ""
            txtfeat.Text = ""
            txtvat.Text = ""
            txtscost.Text = ""
            txtwarranty.Text = ""
            PictureBox1.Refresh()
            itemcode()

        End If

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub

    Private Sub frmpurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select  * from items"

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

        itemcode()

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtitemname.Text = ""
        txtitemcom.Text = ""
        txtitemmod.Text = ""
        txtitemdesc.Text = ""
        txtfeat.Text = ""
        txtvat.Text = ""
        txtscost.Text = ""
        txtwarranty.Text = ""
        PictureBox1.Refresh()

    End Sub

    
    Private Sub txtitemcom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemcom.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtitemcom.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtitemname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemname.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtitemname.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtitemmod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemmod.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtitemmod.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtscost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtscost.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtscost.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtpcost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpcost.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtpcost.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Sub itemcode()
        connectiondb()
        sql = "Select * from items"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txticode.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Item code! ")
        End Try
    End Sub
End Class