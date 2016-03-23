<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.entraBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ursTxt = New System.Windows.Forms.TextBox()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EstadoTxt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'entraBtn
        '
        Me.entraBtn.Location = New System.Drawing.Point(96, 114)
        Me.entraBtn.Name = "entraBtn"
        Me.entraBtn.Size = New System.Drawing.Size(75, 23)
        Me.entraBtn.TabIndex = 0
        Me.entraBtn.Text = "Entrar"
        Me.entraBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ursTxt
        '
        Me.ursTxt.Location = New System.Drawing.Point(15, 25)
        Me.ursTxt.Name = "ursTxt"
        Me.ursTxt.Size = New System.Drawing.Size(156, 20)
        Me.ursTxt.TabIndex = 2
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(15, 77)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(156, 20)
        Me.passTxt.TabIndex = 3
        Me.passTxt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.EstadoTxt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 146)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(186, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 6
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(24, 17)
        Me.ToolStripStatusLabel1.Text = "DB:"
        '
        'EstadoTxt
        '
        Me.EstadoTxt.Name = "EstadoTxt"
        Me.EstadoTxt.Size = New System.Drawing.Size(40, 17)
        Me.EstadoTxt.Text = "Estado"
        '
        'Login
        '
        Me.AcceptButton = Me.entraBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 168)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.ursTxt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.entraBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents entraBtn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ursTxt As System.Windows.Forms.TextBox
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EstadoTxt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
