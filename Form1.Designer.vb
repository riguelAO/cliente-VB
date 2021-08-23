<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.txtNro1 = New System.Windows.Forms.TextBox()
        Me.txtNro2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnSeno = New System.Windows.Forms.Button()
        Me.btnRaizCua = New System.Windows.Forms.Button()
        Me.btnTangente = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnRaizN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(51, 179)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(75, 27)
        Me.btnSuma.TabIndex = 0
        Me.btnSuma.Text = "Sumar"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(160, 179)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(75, 27)
        Me.btnResta.TabIndex = 1
        Me.btnResta.Text = "Resta"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'txtNro1
        '
        Me.txtNro1.Location = New System.Drawing.Point(220, 50)
        Me.txtNro1.Name = "txtNro1"
        Me.txtNro1.Size = New System.Drawing.Size(100, 22)
        Me.txtNro1.TabIndex = 2
        '
        'txtNro2
        '
        Me.txtNro2.Location = New System.Drawing.Point(220, 117)
        Me.txtNro2.Name = "txtNro2"
        Me.txtNro2.Size = New System.Drawing.Size(100, 22)
        Me.txtNro2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nro1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nro2:"
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Location = New System.Drawing.Point(263, 176)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(107, 30)
        Me.btnMultiplicacion.TabIndex = 6
        Me.btnMultiplicacion.Text = "Multiplicacion"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnSeno
        '
        Me.btnSeno.Location = New System.Drawing.Point(277, 233)
        Me.btnSeno.Name = "btnSeno"
        Me.btnSeno.Size = New System.Drawing.Size(75, 29)
        Me.btnSeno.TabIndex = 7
        Me.btnSeno.Text = "Seno"
        Me.btnSeno.UseVisualStyleBackColor = True
        '
        'btnRaizCua
        '
        Me.btnRaizCua.Location = New System.Drawing.Point(117, 291)
        Me.btnRaizCua.Name = "btnRaizCua"
        Me.btnRaizCua.Size = New System.Drawing.Size(118, 33)
        Me.btnRaizCua.TabIndex = 9
        Me.btnRaizCua.Text = "Raiz Cuadrada"
        Me.btnRaizCua.UseVisualStyleBackColor = True
        '
        'btnTangente
        '
        Me.btnTangente.Location = New System.Drawing.Point(374, 230)
        Me.btnTangente.Name = "btnTangente"
        Me.btnTangente.Size = New System.Drawing.Size(91, 32)
        Me.btnTangente.TabIndex = 10
        Me.btnTangente.Text = "Tangente"
        Me.btnTangente.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.Location = New System.Drawing.Point(160, 233)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(75, 29)
        Me.btnPotencia.TabIndex = 11
        Me.btnPotencia.Text = "Potencia"
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(390, 176)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(75, 30)
        Me.btnDivision.TabIndex = 12
        Me.btnDivision.Text = "Division"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Location = New System.Drawing.Point(51, 233)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(75, 29)
        Me.btnFactorial.TabIndex = 13
        Me.btnFactorial.Text = "Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnRaizN
        '
        Me.btnRaizN.Location = New System.Drawing.Point(295, 291)
        Me.btnRaizN.Name = "btnRaizN"
        Me.btnRaizN.Size = New System.Drawing.Size(75, 33)
        Me.btnRaizN.TabIndex = 14
        Me.btnRaizN.Text = "Raiz"
        Me.btnRaizN.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 402)
        Me.Controls.Add(Me.btnRaizN)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnTangente)
        Me.Controls.Add(Me.btnRaizCua)
        Me.Controls.Add(Me.btnSeno)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNro2)
        Me.Controls.Add(Me.txtNro1)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents txtNro1 As TextBox
    Friend WithEvents txtNro2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnSeno As Button
    Friend WithEvents btnRaizCua As Button
    Friend WithEvents btnTangente As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnRaizN As Button
End Class
