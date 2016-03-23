Public Class Empleados

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ide As String
        ide = TextBox1.Text
        Consultar(ide)
    End Sub

    Public Sub Consultar(ByRef identificacion As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If identificacion <> " " Then
            cmd.CommandText = "SELECT id_empleado, suc_codigo, nom_empleado, edad, genero, direccion, tel_empleado, referencias_comerciales FROM Empleados WHERE id_empleado=" + identificacion
        Else
            cmd.CommandText = "SELECT id_empleado, suc_codigo, nom_empleado, edad, genero, direccion, tel_empleado, referencias_comerciales FROM Empleados"
        End If
        Try
            dr = cmd.ExecuteReader()
            ' pregunta si tiene filas o reglones
            If dr.HasRows Then
                While dr.Read
                    MsgBox(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString + " " + dr(4).ToString + " " + dr(5).ToString + " " + dr(6).ToString + " " + dr(7).ToString)
                End While
            Else
                MsgBox("No existen registros para la consulta")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Se llama a la funcion conectarse
        Conectarse()
        'Se llama a la funcion de llenado del dataGrid
        llenarGrid()
    End Sub

    Public Sub Conectarse()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub llenarGrid()
        Dim ds As New DataSet
        Dim ddt As New DataTable
        Dim strSql As String = "SELECT id_empleado, suc_codigo, nom_empleado, edad, genero, direccion, tel_empleado, referencias_comerciales FROM Empleados"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
        'Al DataSet de le agrega una tabla
        ds.Tables.Add("tabla")
        ' Para el llenado de esta tabla con la informacion que se tiene, por medio del adaptador
        adp.Fill(ds.Tables("tabla"))
        'El DataGrid debera tomar lo valores del apd
        Me.DataGridView1.DataSource = ds.Tables("tabla")
        'Cambiarle el encabezado a la columna del DataGrid
        Me.DataGridView1.Columns(0).HeaderText = "Clave"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        conn.Close()
        Principal.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        llenarGrid()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        EmpleadosTwo.Show()
        Me.Hide()
    End Sub
End Class