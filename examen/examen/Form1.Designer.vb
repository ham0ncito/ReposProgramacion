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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnplay = New System.Windows.Forms.Button()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.pcb1 = New System.Windows.Forms.PictureBox()
        Me.pcb2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.txtsuma = New System.Windows.Forms.Label()
        Me.cmbsuma = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnplay
        '
        Me.btnplay.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnplay.Location = New System.Drawing.Point(106, 92)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(151, 51)
        Me.btnplay.TabIndex = 0
        Me.btnplay.Text = "PLAY"
        Me.btnplay.UseVisualStyleBackColor = True
        '
        'btnstop
        '
        Me.btnstop.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnstop.Location = New System.Drawing.Point(511, 93)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(151, 51)
        Me.btnstop.TabIndex = 1
        Me.btnstop.Text = "STOP"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl1.ForeColor = System.Drawing.Color.Red
        Me.lbl1.Location = New System.Drawing.Point(30, 12)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(92, 30)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "timer"
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsalir.Location = New System.Drawing.Point(345, 401)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(129, 37)
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnuevo
        '
        Me.btnuevo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnuevo.Location = New System.Drawing.Point(536, 323)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(129, 37)
        Me.btnuevo.TabIndex = 4
        Me.btnuevo.Text = "NUEVO"
        Me.btnuevo.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btncalcular.Location = New System.Drawing.Point(536, 385)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(129, 37)
        Me.btncalcular.TabIndex = 5
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'pcb1
        '
        Me.pcb1.Image = CType(resources.GetObject("pcb1.Image"), System.Drawing.Image)
        Me.pcb1.Location = New System.Drawing.Point(50, 180)
        Me.pcb1.Name = "pcb1"
        Me.pcb1.Size = New System.Drawing.Size(224, 225)
        Me.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcb1.TabIndex = 6
        Me.pcb1.TabStop = False
        '
        'pcb2
        '
        Me.pcb2.Image = CType(resources.GetObject("pcb2.Image"), System.Drawing.Image)
        Me.pcb2.Location = New System.Drawing.Point(12, 199)
        Me.pcb2.Name = "pcb2"
        Me.pcb2.Size = New System.Drawing.Size(313, 161)
        Me.pcb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcb2.TabIndex = 7
        Me.pcb2.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(562, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Numero"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(525, 268)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(149, 23)
        Me.txtnumero.TabIndex = 9
        '
        'txtsuma
        '
        Me.txtsuma.AutoSize = True
        Me.txtsuma.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtsuma.Location = New System.Drawing.Point(815, 227)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(61, 24)
        Me.txtsuma.TabIndex = 10
        Me.txtsuma.Text = "Suma"
        '
        'cmbsuma
        '
        Me.cmbsuma.FormattingEnabled = True
        Me.cmbsuma.Location = New System.Drawing.Point(789, 268)
        Me.cmbsuma.Name = "cmbsuma"
        Me.cmbsuma.Size = New System.Drawing.Size(121, 23)
        Me.cmbsuma.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(501, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 239)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(88, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 94)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1003, 450)
        Me.Controls.Add(Me.cmbsuma)
        Me.Controls.Add(Me.txtsuma)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcb2)
        Me.Controls.Add(Me.pcb1)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.btnuevo)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.btnplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnplay As Button
    Friend WithEvents btnstop As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnuevo As Button
    Friend WithEvents btncalcular As Button
    Friend WithEvents pcb1 As PictureBox
    Friend WithEvents pcb2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents txtsuma As Label
    Friend WithEvents cmbsuma As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
