
Imports System.Data.SqlClient

Module variables
    Public connetionString As String
    Public cnn As SqlConnection
    Public cmd As SqlCommand
    Public sql As String
    Public reader As SqlDataReader
    Public adapter As New SqlDataAdapter
    Public command As SqlCommand
    Public ds As New DataSet
    Public dv As DataView
End Module
