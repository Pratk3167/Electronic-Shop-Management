
Imports System.Data
Imports System.Data.SqlClient
Public Class Frminstallment

    Private Sub btnsubmitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmitt.Click
        If txtiid.Text = "" Then
            MessageBox.Show("Please enter value for Installment ID")
        ElseIf txtsid.Text = "" Then
            MessageBox.Show("Please enter value for Sales id")
        ElseIf txtcustname.Text = "" Then
            MessageBox.Show("Please Enter value for Customer Name")
        ElseIf txttocost.Text = "" Then
            MessageBox.Show("Please Enter value for Total cost")
        ElseIf txtinstype.Text = "" Then
            MessageBox.Show("Please Enter value for Installment type")
        ElseIf txtpre.Text = "" Then
            MessageBox.Show("Please Enter value for Premium installment")

        ElseIf txtinscost.Text = "" Then
            MessageBox.Show("Please enter value for Installment cost")
        ElseIf txtpaidins.Text = "" Then
            MessageBox.Show("Please Enter value for Paid installment")

        Else

            sql = "insert into installment values(" & txtiid.Text & ",'" & txtsid.Text & "','" & txtcustname.Text & "','" & stdate.Value & "','" & txttocost.Text & "','" & txtinstype.Text & "','" & txtpre.Text & "','" & txtinscost.Text & "','" & txtpaidins.Text & "')"
            Try

                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()

                MsgBox("Installment details placed successfully...  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            txtsid.Text = ""
            txtcustname.Text = ""
            txttocost.Text = ""
            txtinstype.Text = ""
            txtpre.Text = ""
            txtinscost.Text = ""
            txtpaidins.Text = ""
            installmentid()
        End If
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtsid.Text = ""
        txtcustname.Text = ""
        txttocost.Text = ""
        txtinstype.Text = ""
        txtpre.Text = ""
        txtinscost.Text = ""
        txtpaidins.Text = ""
    End Sub

    Private Sub Frminstallment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select  * from installment"
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
        installmentid()

    End Sub

    Private Sub txtsid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsid.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtsid.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcustname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustname.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtcustname.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtinscost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtinscost.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtinscost.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtinstype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtinstype.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtinstype.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtpaidins_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpaidins.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtpaidins.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtpre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpre.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtpre.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txttocost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttocost.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txttocost.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Sub installmentid()
        connectiondb()
        sql = "Select * from installments"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txtiid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Installment id! ")
        End Try
    End Sub
End Class