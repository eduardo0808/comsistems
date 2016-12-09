<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Municipio
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancelarMc = New System.Windows.Forms.Button()
        Me.btnguardarMc = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbprovinciaMc = New System.Windows.Forms.ComboBox()
        Me.txtnotaMc = New System.Windows.Forms.TextBox()
        Me.txtnombreMc = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btncancelarMc)
        Me.Panel1.Controls.Add(Me.btnguardarMc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbprovinciaMc)
        Me.Panel1.Controls.Add(Me.txtnotaMc)
        Me.Panel1.Controls.Add(Me.txtnombreMc)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 207)
        Me.Panel1.TabIndex = 1
        '
        'btncancelarMc
        '
        Me.btncancelarMc.Location = New System.Drawing.Point(195, 161)
        Me.btncancelarMc.Name = "btncancelarMc"
        Me.btncancelarMc.Size = New System.Drawing.Size(75, 23)
        Me.btncancelarMc.TabIndex = 7
        Me.btncancelarMc.Text = "Cancelar"
        Me.btncancelarMc.UseVisualStyleBackColor = True
        '
        'btnguardarMc
        '
        Me.btnguardarMc.Location = New System.Drawing.Point(75, 161)
        Me.btnguardarMc.Name = "btnguardarMc"
        Me.btnguardarMc.Size = New System.Drawing.Size(75, 23)
        Me.btnguardarMc.TabIndex = 6
        Me.btnguardarMc.Text = "Guardar"
        Me.btnguardarMc.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Municipio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Provincia"
        '
        'cbprovinciaMc
        '
        Me.cbprovinciaMc.FormattingEnabled = True
        Me.cbprovinciaMc.Location = New System.Drawing.Point(85, 18)
        Me.cbprovinciaMc.Name = "cbprovinciaMc"
        Me.cbprovinciaMc.Size = New System.Drawing.Size(245, 21)
        Me.cbprovinciaMc.TabIndex = 2
        '
        'txtnotaMc
        '
        Me.txtnotaMc.Location = New System.Drawing.Point(85, 101)
        Me.txtnotaMc.Name = "txtnotaMc"
        Me.txtnotaMc.Size = New System.Drawing.Size(164, 20)
        Me.txtnotaMc.TabIndex = 1
        '
        'txtnombreMc
        '
        Me.txtnombreMc.Location = New System.Drawing.Point(85, 60)
        Me.txtnombreMc.Name = "txtnombreMc"
        Me.txtnombreMc.Size = New System.Drawing.Size(100, 20)
        Me.txtnombreMc.TabIndex = 0
        '
        'Municipio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 277)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Municipio"
        Me.Text = "Municipio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btncancelarMc As System.Windows.Forms.Button
    Friend WithEvents btnguardarMc As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbprovinciaMc As System.Windows.Forms.ComboBox
    Friend WithEvents txtnotaMc As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreMc As System.Windows.Forms.TextBox
End Class
