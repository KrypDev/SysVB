Module FuncionesDB
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public sql As String = " "
End Module