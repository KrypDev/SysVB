Public Class ClientesTwo

    Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click
        Dim Sql As String = ""
        If (Me.txtIdentificacion.Text = "") Then
            MsgBox("El campo de identificacion no debe estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtIdentificacion.Select()
        Else
            Dim Identificacion As Integer
            Dim Nombre As String = ""
            Dim Direccion As String = ""
            Dim Telefono As String = ""
            Dim Correo As String = ""

            Identificacion = Me.txtIdentificacion.Text
            Nombre = Me.txtNombre.Text
            Direccion = Me.txtDireccion.Text
            Telefono = Me.txtTelefono.Text
            Correo = Me.txtCorreo.Text
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Sql += "INSERT INTO Clientes (num_cliente, nom_cliente, direc_cliente, tel_cliente, imbox_cliente)"
            Sql += "VALUES (" & Identificacion & ",'" & Nombre & "','" & Direccion & "','" & Telefono & "','" & Correo & "')"
            'MsgBox(Sql)
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtNombre.Text = " "
        txtDireccion.Text = " "
        txtIdentificacion.Text = " "
        txtCorreo.Text = " "
        txtTelefono.Text = " "
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        If (Me.txtIdentificacion1.Text = "") Then
            MsgBox("El campo identificación no debe estar vacío", MsgBoxStyle.Critical, "Atención")
            Me.txtIdentificacion1.Select()
        Else
            Dim identificación As Integer
            Dim nombre As String = ""
            Dim dirección As String = ""
            Dim teléfono As String = ""
            Dim correo As String = ""


            identificación = Me.txtIdentificacion1.Text
            nombre = Me.txtNombre1.Text
            dirección = Me.txtDireccion1.Text
            teléfono = Me.txtTelefono1.Text
            correo = Me.txtCorreo1.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn


            'Se utiliza el comando UPDATE que es para actualizar los datos de una DB
            sql = "UPDATE CLIENTES SET "
            sql += " nom_cliente = ' " & nombre & "',"
            sql += " direc_cliente = ' " & dirección & "',"
            sql += " tel_cliente = ' " & teléfono & "',"
            sql += " imbox_cliente = ' " & correo & "' "
            sql += "WHERE num_cliente = " & identificación & " "

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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtNombre1.Text = " "
        txtDireccion1.Text = " "
        txtIdentificacion1.Text = " "
        txtCorreo1.Text = " "
        txtTelefono1.Text = " "
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Se declara la variable para hacer la validacion
        Dim identificacion As Integer
        'A la variable identificaion se le asigna el valor del textbox2
        identificacion = Convert.ToInt32(Me.txtIdentificacion2.Text)
        cmd.CommandType = CommandType.Text
        'Se hacen las aclaraciones para la interpretacion de la cadena de comandos
        cmd.Connection = conn
        'Se le hace la asignacion del valor del Sql como la cadena de comando Sql
        sql = "DELETE FROM CLIENTES WHERE num_cliente =" & identificacion & ""
        'Se establece un texto de comando para cmd
        cmd.CommandText = sql
        Try
            'Se captura la exception de error o exito del proceso
            cmd.ExecuteNonQuery()
            MsgBox("Registro eliminado exitosamente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtIdentificacion2.Text = " "
    End Sub
End Class