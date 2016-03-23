Public Class EmpleadosTwo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Empleados.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim identificacion As Integer
        identificacion = Convert.ToInt32(Me.txtIdDel.Text)
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        sql = "DELETE FROM Empleados WHERE id_empleado =" & identificacion & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro eliminado exitosamente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtIdDel.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtId.Text = ""
        txtIdS.Text = ""
        txtNombre.Text = ""
        txtEdad.Text = ""
        txtGenero.Text = ""
        txtDireccion.Text = ""
        txtTel.Text = ""
        txtRC.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txId.Text = ""
        txIdS.Text = ""
        txNomb.Text = ""
        txEdad.Text = ""
        txGen.Text = ""
        txDir.Text = ""
        txTel.Text = ""
        txRC.Text = ""
    End Sub

    Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click
        Dim Sql As String = ""
        If (Me.txtId.Text = "") Then
            MsgBox("El campo de identificacion no debe estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtId.Select()
        Else
            Dim Identificacion, IdentificacionSuc, Edad As Integer
            Dim Nombre As String = ""
            Dim RC As String = ""
            Dim Direccion As String = ""
            Dim Telefono As String = ""
            Dim Genero As String = ""

            Identificacion = Me.txtId.Text
            IdentificacionSuc = Me.txtIdS.Text
            Nombre = Me.txtNombre.Text
            Edad = Me.txtEdad.Text
            Genero = Me.txtGenero.Text
            Direccion = Me.txtDireccion.Text
            Telefono = Me.txtTel.Text
            RC = Me.txtRC.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Sql += "INSERT INTO Empleados (id_empleado, suc_codigo, nom_empleado, edad, genero, direccion, tel_empleado, referencias_comerciales ) "
            Sql += "VALUES (" & Identificacion & "," & IdentificacionSuc & ",'" & Nombre & "'," & Edad & ",'" & Genero & "','" & Direccion & "','" & Telefono & "','" & RC & "')"
            cmd.CommandText = Sql
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro registrado exitosamente")
            Catch ex As Exception
                If ex.ToString.Contains("Valores Duplicados") Then
                    MsgBox("El registro ya existe en la base de datos")
                Else
                    MsgBox(ex.ToString)
                End If

            End Try
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If (Me.txId.Text = "") Then
            MsgBox("El campo identificación no debe estar vacío", MsgBoxStyle.Critical, "Atención")
            Me.txId.Select()
        Else
            Dim Identificacion, IdentificacionSuc, Edad As Integer
            Dim Nombre As String = ""
            Dim RC As String = ""
            Dim Direccion As String = ""
            Dim Telefono As String = ""
            Dim Genero As String = ""

            Identificacion = Me.txId.Text
            IdentificacionSuc = Me.txIdS.Text
            Nombre = Me.txNomb.Text
            Edad = Me.txEdad.Text
            Genero = Me.txGen.Text
            Direccion = Me.txDir.Text
            Telefono = Me.txTel.Text
            RC = Me.txRC.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            sql = "UPDATE Empleados SET "
            sql += " suc_codigo =  " & IdentificacionSuc & ","
            sql += " nom_empleado = ' " & Nombre & "',"
            sql += " edad =  " & Edad & ", "
            sql += " genero = ' " & Genero & "',"
            sql += " direccion = ' " & Direccion & "',"
            sql += " tel_empleado = ' " & Telefono & "',"
            sql += " referencias_comerciales = ' " & RC & "' "
            sql += "WHERE id_empleado = " & Identificacion & " "
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Actualizado exitosamente")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class