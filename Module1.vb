Imports System.Data.SqlClient
Module Module1
    Public Sub connectiondb()

        connetionString = "Data Source=TECHNOPU\SQL;Initial Catalog=electronicshop;User ID=guruleslie;Password=technology123"
        cnn = New SqlConnection(connetionString)
        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try

    End Sub
End Module
