<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadosTwo
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdDel = New System.Windows.Forms.TextBox()
        Me.txtIdS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRC = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txRC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txIdS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txDir = New System.Windows.Forms.TextBox()
        Me.txGen = New System.Windows.Forms.TextBox()
        Me.txEdad = New System.Windows.Forms.TextBox()
        Me.txNomb = New System.Windows.Forms.TextBox()
        Me.txId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(460, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(460, 299)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtRC)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txtTel)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtIdS)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.txtGenero)
        Me.TabPage1.Controls.Add(Me.txtEdad)
        Me.TabPage1.Controls.Add(Me.txtDireccion)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.txtId)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnInsertar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(452, 273)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(358, 244)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(114, 114)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(224, 20)
        Me.txtGenero.TabIndex = 10
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(114, 88)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(224, 20)
        Me.txtEdad.TabIndex = 9
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(114, 140)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(224, 20)
        Me.txtDireccion.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(114, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(224, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(114, 10)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(224, 20)
        Me.txtId.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Genero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Edad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id"
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(358, 215)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(88, 23)
        Me.btnInsertar.TabIndex = 0
        Me.btnInsertar.Text = "Ingresar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txRC)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txTel)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txIdS)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txDir)
        Me.TabPage2.Controls.Add(Me.txGen)
        Me.TabPage2.Controls.Add(Me.txEdad)
        Me.TabPage2.Controls.Add(Me.txNomb)
        Me.TabPage2.Controls.Add(Me.txId)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.btnActualizar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(452, 273)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Actualizar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(359, 244)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Limpiar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(359, 215)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(81, 23)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txtIdDel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(452, 273)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Eliminar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(345, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(345, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Id Empleado"
        '
        'txtIdDel
        '
        Me.txtIdDel.Location = New System.Drawing.Point(18, 46)
        Me.txtIdDel.Name = "txtIdDel"
        Me.txtIdDel.Size = New System.Drawing.Size(158, 20)
        Me.txtIdDel.TabIndex = 0
        '
        'txtIdS
        '
        Me.txtIdS.Location = New System.Drawing.Point(114, 36)
        Me.txtIdS.Name = "txtIdS"
        Me.txtIdS.Size = New System.Drawing.Size(224, 20)
        Me.txtIdS.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Codigo de Surcursal"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(114, 167)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(224, 20)
        Me.txtTel.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Telefono"
        '
        'txtRC
        '
        Me.txtRC.Location = New System.Drawing.Point(114, 193)
        Me.txtRC.Name = "txtRC"
        Me.txtRC.Size = New System.Drawing.Size(224, 20)
        Me.txtRC.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Ref. Comerciales"
        '
        'txRC
        '
        Me.txRC.Location = New System.Drawing.Point(114, 193)
        Me.txRC.Name = "txRC"
        Me.txRC.Size = New System.Drawing.Size(223, 20)
        Me.txRC.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Ref. Comerciales"
        '
        'txTel
        '
        Me.txTel.Location = New System.Drawing.Point(114, 167)
        Me.txTel.Name = "txTel"
        Me.txTel.Size = New System.Drawing.Size(223, 20)
        Me.txTel.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Telefono"
        '
        'txIdS
        '
        Me.txIdS.Location = New System.Drawing.Point(114, 36)
        Me.txIdS.Name = "txIdS"
        Me.txIdS.Size = New System.Drawing.Size(223, 20)
        Me.txIdS.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Codigo de Surcursal"
        '
        'txDir
        '
        Me.txDir.Location = New System.Drawing.Point(114, 140)
        Me.txDir.Name = "txDir"
        Me.txDir.Size = New System.Drawing.Size(223, 20)
        Me.txDir.TabIndex = 27
        '
        'txGen
        '
        Me.txGen.Location = New System.Drawing.Point(114, 114)
        Me.txGen.Name = "txGen"
        Me.txGen.Size = New System.Drawing.Size(223, 20)
        Me.txGen.TabIndex = 26
        '
        'txEdad
        '
        Me.txEdad.Location = New System.Drawing.Point(114, 88)
        Me.txEdad.Name = "txEdad"
        Me.txEdad.Size = New System.Drawing.Size(223, 20)
        Me.txEdad.TabIndex = 25
        '
        'txNomb
        '
        Me.txNomb.Location = New System.Drawing.Point(114, 62)
        Me.txNomb.Name = "txNomb"
        Me.txNomb.Size = New System.Drawing.Size(223, 20)
        Me.txNomb.TabIndex = 24
        '
        'txId
        '
        Me.txId.Location = New System.Drawing.Point(114, 10)
        Me.txId.Name = "txId"
        Me.txId.Size = New System.Drawing.Size(223, 20)
        Me.txId.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Direccion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Genero"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Edad"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Nombre Empleado"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Id"
        '
        'EmpleadosTwo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 352)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "EmpleadosTwo"
        Me.Text = "EmpleadosTwo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtRC As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtIdS As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdDel As System.Windows.Forms.TextBox
    Friend WithEvents txRC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txTel As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txIdS As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txDir As System.Windows.Forms.TextBox
    Friend WithEvents txGen As System.Windows.Forms.TextBox
    Friend WithEvents txEdad As System.Windows.Forms.TextBox
    Friend WithEvents txNomb As System.Windows.Forms.TextBox
    Friend WithEvents txId As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
