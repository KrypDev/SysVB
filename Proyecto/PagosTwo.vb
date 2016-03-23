Public Class PagosTwo

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Pagos.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        Dim Sql As String = ""
        If (Me.txtfolio.Text = "") Then
            MsgBox("El campo de folio no debe estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtfolio.Select()
        Else
            Dim folio As Integer
            Dim forma_de_pago As String = ""
            Dim pago As Double
            Dim clave_de_la_mercancia As Integer
            Dim fecha_de_pago As String = ""
            Dim clave_de_cliente As Integer

            folio = Me.txtfolio.Text
            forma_de_pago = Me.txtforma_pago.Text
            pago = Me.txtpago.Text
            clave_de_la_mercancia = Me.txtmercancia_id.Text
            fecha_de_pago = Me.txtfecha_pago.Text
            clave_de_cliente = Me.txtnum_cliente.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            Sql += "INSERT INTO Pagos (folio,forma_pago,pago, mercancia_id,fecha_pago,num_cliente)"
            Sql += "VALUES(" & folio & ",'" & forma_de_pago & "'," & Convert.ToDouble(pago) & ",'" & clave_de_la_mercancia & "','" & fecha_de_pago & "','" & clave_de_cliente & "')"

            'MsgBox(Sql)
            cmd.CommandText = Sql
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro  registrado Exitosamente")

            Catch ex As Exception
                If ex.ToString.Contains("Valores Duplicados") Then
                    MsgBox("El registro ya existe en la base de datos")
                Else
                    MsgBox(ex.ToString)
                End If

            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtfolio.Text = " "
        txtforma_pago.Text = " "
        txtpago.Text = " "
        txtmercancia_id.Text = " "
        txtfecha_pago.Text = " "
        txtnum_cliente.Text = " "
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If (Me.txtfolio1.Text = "") Then
            MsgBox("El campo identificación no debe estar vacío", MsgBoxStyle.Critical, "Atención")
            Me.txtfolio1.Select()
        Else
            Dim folio1 As Integer
            Dim forma_pago1 As String = ""
            Dim pago1 As Double
            Dim mercancia_id1 As Integer
            Dim fecha_pago1 As String = ""
            Dim num_cliente1 As Integer



            folio1 = Me.txtfolio1.Text
            forma_pago1 = Me.txtforma_pago1.Text
            pago1 = Me.txtpago1.Text
            mercancia_id1 = Me.txt.Text
            fecha_pago1 = Me.TextBox8.Text
            num_cliente1 = Me.TextBox7.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn


            'Se utiliza el comando UPDATE que es para actualizar los datos de una DB
            sql = "UPDATE Pagos SET "

            sql += " forma_pago = ' " & forma_pago1 & "',"
            sql += " pago = ' " & pago1 & "',"
            sql += " mercancia_id = ' " & mercancia_id1 & "' ,"
            sql += " fecha_pago = ' " & fecha_pago1 & "',"
            sql += " num_cliente = ' " & num_cliente1 & "' "
            sql += " WHERE folio = " & folio1 & " "

            'Se establece un texto de comando para cmd
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Actualizado exitosamente")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtfolio1.Text = " "
        txtforma_pago1.Text = " "
        txtpago1.Text = " "
        txt.Text = " "
        TextBox7.Text = " "
        TextBox8.Text = " "
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim folio2 As Integer
        folio2 = Me.txtfolio2.Text
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        sql = "DELETE FROM Pagos WHERE folio = " & folio2 & " "
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro ELIMINADO exitosamente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtfolio2.Text = " "
    End Sub
End Class