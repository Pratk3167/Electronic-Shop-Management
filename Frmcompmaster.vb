Imports System.Data
Imports System.Data.SqlClient

Public Class Frmcompmaster

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txtcid.Text = "" Then
            MessageBox.Show("Please enter value for Company ID")
        ElseIf txtcname.Text = "" Then
            MessageBox.Show("Please enter value for company name")
        ElseIf txtcdes.Text = "" Then
            MessageBox.Show("Please Enter value for Company description")

        Else
            sql = "insert into compmaster values(" & txtcid.Text & ",'" & txtcname.Text & "','" & txtcdes.Text & "')"
            Try

                adapter.InsertCommand = New SqlCommand(sql, cnn)
                adapter.InsertCommand.ExecuteNonQuery()

                MsgBox("Records are inserted.....  " & vbOK)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        companyid()

    End Sub

    Private Sub Frmcompmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        companyid()

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
    End Sub

    

    Private Sub txtcname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcid.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtcid.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Sub companyid()
        connectiondb()
        sql = "Select * from complaints"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                txtcid.Text = reader.Item(0) + 1
            End While
            reader.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Invalid Complant id! ")
        End Try
    End Sub

End Class