Public Class Login

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conectarse()
    End Sub

    Public Sub Conectarse()
        Try
            conn.Open()
            EstadoTxt.ForeColor = Color.Green
            EstadoTxt.Text = "Conectado"
        Catch ex As Exception
            EstadoTxt.ForeColor = Color.Red
            EstadoTxt.Text = "Error"
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub entraBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles entraBtn.Click
        Dim us, ps As String
        us = ursTxt.Text
        ps = passTxt.Text
        entrar(us, ps)
    End Sub

    Public Sub entrar(ByRef uss As String, ByRef pass As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Acceso WHERE user = '" + uss + "' AND pass ='" + pass + "'"
        Try
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                'MsgBox(dr(0).ToString + " , " + dr(1).ToString)
                dr.Close()
                conn.Close()
                Principal.Show()
                Me.Hide()
            Else
                MsgBox("Usuario o Contraseña Incorrectas")
                ursTxt.Text = ""
                passTxt.Text = ""
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
