<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnmultiplicacion = New System.Windows.Forms.Button()
        Me.btndivision = New System.Windows.Forms.Button()
        Me.btnresta = New System.Windows.Forms.Button()
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.txtnumero2 = New System.Windows.Forms.TextBox()
        Me.txtnumero1 = New System.Windows.Forms.TextBox()
        Me.Numero2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnfuncion = New System.Windows.Forms.Button()
        Me.btnprocedimiento = New System.Windows.Forms.Button()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.btnmultiplicacion)
        Me.GroupBox1.Controls.Add(Me.btndivision)
        Me.GroupBox1.Controls.Add(Me.btnresta)
        Me.GroupBox1.Controls.Add(Me.btnsuma)
        Me.GroupBox1.Controls.Add(Me.txtnumero2)
        Me.GroupBox1.Controls.Add(Me.txtnumero1)
        Me.GroupBox1.Controls.Add(Me.Numero2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(26, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 397)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlimpiar.Location = New System.Drawing.Point(176, 304)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 8
        Me.btnlimpiar.Text = "limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnmultiplicacion
        '
        Me.btnmultiplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnmultiplicacion.Location = New System.Drawing.Point(95, 304)
        Me.btnmultiplicacion.Name = "btnmultiplicacion"
        Me.btnmultiplicacion.Size = New System.Drawing.Size(75, 23)
        Me.btnmultiplicacion.TabIndex = 7
        Me.btnmultiplicacion.Text = "multiplicacion"
        Me.btnmultiplicacion.UseVisualStyleBackColor = True
        '
        'btndivision
        '
        Me.btndivision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndivision.Location = New System.Drawing.Point(220, 261)
        Me.btndivision.Name = "btndivision"
        Me.btndivision.Size = New System.Drawing.Size(75, 23)
        Me.btndivision.TabIndex = 6
        Me.btndivision.Text = "division"
        Me.btndivision.UseVisualStyleBackColor = True
        '
        'btnresta
        '
        Me.btnresta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnresta.Location = New System.Drawing.Point(139, 261)
        Me.btnresta.Name = "btnresta"
        Me.btnresta.Size = New System.Drawing.Size(75, 23)
        Me.btnresta.TabIndex = 5
        Me.btnresta.Text = "resta"
        Me.btnresta.UseVisualStyleBackColor = True
        '
        'btnsuma
        '
        Me.btnsuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsuma.Location = New System.Drawing.Point(58, 261)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(75, 23)
        Me.btnsuma.TabIndex = 4
        Me.btnsuma.Text = "suma"
        Me.btnsuma.UseVisualStyleBackColor = True
        '
        'txtnumero2
        '
        Me.txtnumero2.Location = New System.Drawing.Point(126, 169)
        Me.txtnumero2.Name = "txtnumero2"
        Me.txtnumero2.Size = New System.Drawing.Size(100, 23)
        Me.txtnumero2.TabIndex = 3
        '
        'txtnumero1
        '
        Me.txtnumero1.Location = New System.Drawing.Point(126, 98)
        Me.txtnumero1.Name = "txtnumero1"
        Me.txtnumero1.Size = New System.Drawing.Size(100, 23)
        Me.txtnumero1.TabIndex = 2
        '
        'Numero2
        '
        Me.Numero2.AutoSize = True
        Me.Numero2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Numero2.Location = New System.Drawing.Point(152, 139)
        Me.Numero2.Name = "Numero2"
        Me.Numero2.Size = New System.Drawing.Size(85, 20)
        Me.Numero2.TabIndex = 1
        Me.Numero2.Text = "Numero2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(152, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "numero1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.btnfuncion)
        Me.GroupBox2.Controls.Add(Me.btnprocedimiento)
        Me.GroupBox2.Controls.Add(Me.txtresultado)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(396, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 397)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnsalir
        '
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsalir.Location = New System.Drawing.Point(155, 370)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 11
        Me.btnsalir.Text = "EXIT"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnfuncion
        '
        Me.btnfuncion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnfuncion.Location = New System.Drawing.Point(223, 261)
        Me.btnfuncion.Name = "btnfuncion"
        Me.btnfuncion.Size = New System.Drawing.Size(75, 23)
        Me.btnfuncion.TabIndex = 10
        Me.btnfuncion.Text = "funcion"
        Me.btnfuncion.UseVisualStyleBackColor = True
        '
        'btnprocedimiento
        '
        Me.btnprocedimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnprocedimiento.Location = New System.Drawing.Point(61, 261)
        Me.btnprocedimiento.Name = "btnprocedimiento"
        Me.btnprocedimiento.Size = New System.Drawing.Size(98, 23)
        Me.btnprocedimiento.TabIndex = 9
        Me.btnprocedimiento.Text = "procedimiento"
        Me.btnprocedimiento.UseVisualStyleBackColor = True
        '
        'txtresultado
        '
        Me.txtresultado.Location = New System.Drawing.Point(134, 107)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(127, 23)
        Me.txtresultado.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(151, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(791, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnmultiplicacion As Button
    Friend WithEvents btndivision As Button
    Friend WithEvents btnresta As Button
    Friend WithEvents btnsuma As Button
    Friend WithEvents txtnumero2 As TextBox
    Friend WithEvents txtnumero1 As TextBox
    Friend WithEvents Numero2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnfuncion As Button
    Friend WithEvents btnprocedimiento As Button
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsalir As Button
End Class
