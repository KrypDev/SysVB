Public Class Pagos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ide As String
        ide = TextBox1.Text
        Consultar(ide)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PagosTwo.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        llenarGrid()
    End Sub

    Public Sub llenarGrid()
        Dim ds As New DataSet
        Dim ddt As New DataTable
        Dim strSql As String = "SELECT folio, forma_pago, pago, mercancia_id, fecha_pago, num_cliente  FROM Pagos"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
        'Al Dataset se le agrega una nueva tabla
        ds.Tables.Add("tabla")
        'para el llenado de esa tabla con la informacion que se tiene por el medio del adaptador
        adp.Fill(ds.Tables("tabla"))
        'El DataGrid debera tomar los valores del adp
        Me.DataGridView1.DataSource = ds.Tables("tabla")
        'Cambiar el encabezado a la columna del DataGrid
        Me.DataGridView1.Columns(0).HeaderText = ("Folio ")
    End Sub
    Public Sub Conectarse()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Public Sub Consultar(ByRef identificacion As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If identificacion <> " " Then
            cmd.CommandText = "SELECT  folio, forma_pago, pago, mercancia_id, fecha_pago,num_cliente  FROM Pagos WHERE folio=" + identificacion
        Else
            cmd.CommandText = "SELECT folio, forma_pago, mercancia_id, fecha_pago ,num_cliente  FROM Pagos "
        End If
        Try
            dr = cmd.ExecuteReader()
            'pregrunta si tiene filas o renglones 
            If dr.HasRows Then
                While dr.Read
                    MsgBox(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString + " " + dr(4).ToString)
                End While
            Else
                MsgBox("No existen Registros para la consulta")

            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub Pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se llama a la funcion conectarse 
        Conectarse()
        'Se llama a la funcion de llenado del DataGrid
        llenarGrid()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        conn.Close()
        Principal.Show()
        Me.Hide()
    End Sub
End Class