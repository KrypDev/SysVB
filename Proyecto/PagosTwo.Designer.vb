<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosTwo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnum_cliente = New System.Windows.Forms.TextBox()
        Me.txtfecha_pago = New System.Windows.Forms.TextBox()
        Me.txtmercancia_id = New System.Windows.Forms.TextBox()
        Me.txtpago = New System.Windows.Forms.TextBox()
        Me.txtforma_pago = New System.Windows.Forms.TextBox()
        Me.txtfolio = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.txtpago1 = New System.Windows.Forms.TextBox()
        Me.txtforma_pago1 = New System.Windows.Forms.TextBox()
        Me.txtfolio1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtfolio2 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 552)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(528, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(532, 534)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnRegistro)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtnum_cliente)
        Me.TabPage1.Controls.Add(Me.txtfecha_pago)
        Me.TabPage1.Controls.Add(Me.txtmercancia_id)
        Me.TabPage1.Controls.Add(Me.txtpago)
        Me.TabPage1.Controls.Add(Me.txtforma_pago)
        Me.TabPage1.Controls.Add(Me.txtfolio)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(524, 364)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registra Pagos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(163, 194)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(115, 23)
        Me.btnRegistro.TabIndex = 12
        Me.btnRegistro.Text = "Registro de pago"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Clave de registro de los  clientes "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha del pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Clave de la Mercancia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(317, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Forma de pago"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Folio"
        '
        'txtnum_cliente
        '
        Me.txtnum_cliente.Location = New System.Drawing.Point(297, 135)
        Me.txtnum_cliente.Name = "txtnum_cliente"
        Me.txtnum_cliente.Size = New System.Drawing.Size(100, 20)
        Me.txtnum_cliente.TabIndex = 5
        '
        'txtfecha_pago
        '
        Me.txtfecha_pago.Location = New System.Drawing.Point(160, 135)
        Me.txtfecha_pago.Name = "txtfecha_pago"
        Me.txtfecha_pago.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha_pago.TabIndex = 4
        '
        'txtmercancia_id
        '
        Me.txtmercancia_id.Location = New System.Drawing.Point(19, 135)
        Me.txtmercancia_id.Name = "txtmercancia_id"
        Me.txtmercancia_id.Size = New System.Drawing.Size(100, 20)
        Me.txtmercancia_id.TabIndex = 3
        '
        'txtpago
        '
        Me.txtpago.Location = New System.Drawing.Point(288, 48)
        Me.txtpago.Name = "txtpago"
        Me.txtpago.Size = New System.Drawing.Size(100, 20)
        Me.txtpago.TabIndex = 2
        '
        'txtforma_pago
        '
        Me.txtforma_pago.Location = New System.Drawing.Point(163, 48)
        Me.txtforma_pago.Name = "txtforma_pago"
        Me.txtforma_pago.Size = New System.Drawing.Size(100, 20)
        Me.txtforma_pago.TabIndex = 1
        '
        'txtfolio
        '
        Me.txtfolio.Location = New System.Drawing.Point(19, 48)
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.Size = New System.Drawing.Size(100, 20)
        Me.txtfolio.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.btnModificar)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.TextBox7)
        Me.TabPage2.Controls.Add(Me.TextBox8)
        Me.TabPage2.Controls.Add(Me.txt)
        Me.TabPage2.Controls.Add(Me.txtpago1)
        Me.TabPage2.Controls.Add(Me.txtforma_pago1)
        Me.TabPage2.Controls.Add(Me.txtfolio1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(524, 508)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modificar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(420, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(420, 43)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 25
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Folio del cliente  "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Fecha del pago"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Clave de la Mercancia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Pago"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Forma de pago"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Clave"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(33, 469)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 18
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(33, 380)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 17
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(33, 309)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(100, 20)
        Me.txt.TabIndex = 16
        '
        'txtpago1
        '
        Me.txtpago1.Location = New System.Drawing.Point(33, 215)
        Me.txtpago1.Name = "txtpago1"
        Me.txtpago1.Size = New System.Drawing.Size(100, 20)
        Me.txtpago1.TabIndex = 15
        '
        'txtforma_pago1
        '
        Me.txtforma_pago1.Location = New System.Drawing.Point(33, 132)
        Me.txtforma_pago1.Name = "txtforma_pago1"
        Me.txtforma_pago1.Size = New System.Drawing.Size(100, 20)
        Me.txtforma_pago1.TabIndex = 14
        '
        'txtfolio1
        '
        Me.txtfolio1.Location = New System.Drawing.Point(33, 46)
        Me.txtfolio1.Name = "txtfolio1"
        Me.txtfolio1.Size = New System.Drawing.Size(100, 20)
        Me.txtfolio1.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.btnEliminar)
        Me.TabPage3.Controls.Add(Me.txtfolio2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(524, 364)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Eliminar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Folio para eliminar"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(261, 60)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Limpiar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(261, 16)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtfolio2
        '
        Me.txtfolio2.Location = New System.Drawing.Point(30, 37)
        Me.txtfolio2.Name = "txtfolio2"
        Me.txtfolio2.Size = New System.Drawing.Size(100, 20)
        Me.txtfolio2.TabIndex = 0
        '
        'PagosTwo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 583)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "PagosTwo"
        Me.Text = "PagosTwo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnRegistro As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnum_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha_pago As System.Windows.Forms.TextBox
    Friend WithEvents txtmercancia_id As System.Windows.Forms.TextBox
    Friend WithEvents txtpago As System.Windows.Forms.TextBox
    Friend WithEvents txtforma_pago As System.Windows.Forms.TextBox
    Friend WithEvents txtfolio As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents txtpago1 As System.Windows.Forms.TextBox
    Friend WithEvents txtforma_pago1 As System.Windows.Forms.TextBox
    Friend WithEvents txtfolio1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtfolio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
