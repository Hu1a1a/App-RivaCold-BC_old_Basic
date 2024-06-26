<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFunc1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BoxProveedor = New System.Windows.Forms.ListBox()
        Me.BoxModelo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BoxGama = New System.Windows.Forms.ComboBox()
        Me.BoxTipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BoxEquivalencia = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BoxPropiedad = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BoxPrecio = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListTipo = New System.Windows.Forms.ListView()
        Me.BotonFicha = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BoxProveedor
        '
        Me.BoxProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxProveedor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoxProveedor.FormattingEnabled = True
        Me.BoxProveedor.ItemHeight = 29
        Me.BoxProveedor.Items.AddRange(New Object() {"IntarCon", "Zanotti", "Kide"})
        Me.BoxProveedor.Location = New System.Drawing.Point(18, 41)
        Me.BoxProveedor.Name = "BoxProveedor"
        Me.BoxProveedor.Size = New System.Drawing.Size(218, 120)
        Me.BoxProveedor.TabIndex = 0
        '
        'BoxModelo
        '
        Me.BoxModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxModelo.FormattingEnabled = True
        Me.BoxModelo.Location = New System.Drawing.Point(6, 107)
        Me.BoxModelo.Name = "BoxModelo"
        Me.BoxModelo.Size = New System.Drawing.Size(410, 33)
        Me.BoxModelo.TabIndex = 1
        Me.BoxModelo.Text = "Seleccionar Modelo de Producto"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedor"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox2.Controls.Add(Me.BoxGama)
        Me.GroupBox2.Controls.Add(Me.BoxTipo)
        Me.GroupBox2.Controls.Add(Me.BoxModelo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(248, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 149)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modelo Proveedor"
        '
        'BoxGama
        '
        Me.BoxGama.FormattingEnabled = True
        Me.BoxGama.Location = New System.Drawing.Point(6, 68)
        Me.BoxGama.Name = "BoxGama"
        Me.BoxGama.Size = New System.Drawing.Size(410, 33)
        Me.BoxGama.TabIndex = 9
        Me.BoxGama.Text = "Seleccionar Gama de Producto"
        '
        'BoxTipo
        '
        Me.BoxTipo.Enabled = False
        Me.BoxTipo.FormattingEnabled = True
        Me.BoxTipo.Items.AddRange(New Object() {"Equipo", "Evaporador", "Condensador"})
        Me.BoxTipo.Location = New System.Drawing.Point(6, 29)
        Me.BoxTipo.Name = "BoxTipo"
        Me.BoxTipo.Size = New System.Drawing.Size(410, 33)
        Me.BoxTipo.TabIndex = 8
        Me.BoxTipo.Text = "Seleccionar Tipo de Equipo"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox3.Controls.Add(Me.BoxEquivalencia)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(676, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(333, 463)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Modelo RivaCold"
        '
        'BoxEquivalencia
        '
        Me.BoxEquivalencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxEquivalencia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoxEquivalencia.FormattingEnabled = True
        Me.BoxEquivalencia.ItemHeight = 25
        Me.BoxEquivalencia.Location = New System.Drawing.Point(6, 29)
        Me.BoxEquivalencia.Name = "BoxEquivalencia"
        Me.BoxEquivalencia.Size = New System.Drawing.Size(321, 429)
        Me.BoxEquivalencia.TabIndex = 7
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox5.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(706, 482)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(303, 73)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rango de Comparación"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(238, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(24, 23)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "%"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(77, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(24, 23)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "%"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(168, 30)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 30)
        Me.NumericUpDown2.TabIndex = 0
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown2.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Cursor = System.Windows.Forms.Cursors.Default
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 30)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 30)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Tag = ""
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, -2147483648})
        '
        'BoxPropiedad
        '
        Me.BoxPropiedad.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.BoxPropiedad.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.BoxPropiedad.HideSelection = False
        Me.BoxPropiedad.Location = New System.Drawing.Point(6, 134)
        Me.BoxPropiedad.Name = "BoxPropiedad"
        Me.BoxPropiedad.Size = New System.Drawing.Size(646, 169)
        Me.BoxPropiedad.TabIndex = 6
        Me.BoxPropiedad.UseCompatibleStateImageBehavior = False
        Me.BoxPropiedad.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "T_Amb"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "T_Cámara"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "PF_Modelo"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "PF_Equiv"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Diff"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 75
        '
        'BoxPrecio
        '
        Me.BoxPrecio.AllowDrop = True
        Me.BoxPrecio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.BoxPrecio.HideSelection = False
        Me.BoxPrecio.Location = New System.Drawing.Point(6, 29)
        Me.BoxPrecio.Name = "BoxPrecio"
        Me.BoxPrecio.Size = New System.Drawing.Size(353, 99)
        Me.BoxPrecio.TabIndex = 6
        Me.BoxPrecio.UseCompatibleStateImageBehavior = False
        Me.BoxPrecio.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Precio Modelo"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Precio Equiv"
        Me.ColumnHeader2.Width = 100
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox4.Controls.Add(Me.ListTipo)
        Me.GroupBox4.Controls.Add(Me.BoxPrecio)
        Me.GroupBox4.Controls.Add(Me.BoxPropiedad)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(658, 309)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Comparación entre modelo"
        '
        'ListTipo
        '
        Me.ListTipo.HideSelection = False
        Me.ListTipo.Location = New System.Drawing.Point(364, 29)
        Me.ListTipo.Name = "ListTipo"
        Me.ListTipo.Size = New System.Drawing.Size(288, 99)
        Me.ListTipo.TabIndex = 7
        Me.ListTipo.UseCompatibleStateImageBehavior = False
        '
        'BotonFicha
        '
        Me.BotonFicha.Enabled = False
        Me.BotonFicha.Location = New System.Drawing.Point(158, 482)
        Me.BotonFicha.Name = "BotonFicha"
        Me.BotonFicha.Size = New System.Drawing.Size(140, 80)
        Me.BotonFicha.TabIndex = 7
        Me.BotonFicha.Text = "Ficha Técnica"
        Me.BotonFicha.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 80)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Return Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormFunc1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 574)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BotonFicha)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BoxProveedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormFunc1"
        Me.Text = "Form2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BoxProveedor As ListBox
    Friend WithEvents BoxModelo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BoxPropiedad As ListView
    Friend WithEvents BoxEquivalencia As ListBox
    Friend WithEvents BoxPrecio As ListView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BotonFicha As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ListTipo As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents BoxGama As ComboBox
    Friend WithEvents BoxTipo As ComboBox
    Friend WithEvents Button1 As Button
End Class
