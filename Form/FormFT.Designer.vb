<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFT
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Alta Velocidad", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Baja Velocidad", System.Windows.Forms.HorizontalAlignment.Left)
        Me.FichaTecnica = New System.Windows.Forms.ListView()
        Me.Propiedad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Datos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PFList = New System.Windows.Forms.ListView()
        Me.T1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BoxModelo = New System.Windows.Forms.ComboBox()
        Me.BoxModeloTipo = New System.Windows.Forms.ComboBox()
        Me.BoxGama = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'FichaTecnica
        '
        Me.FichaTecnica.AllowColumnReorder = True
        Me.FichaTecnica.AllowDrop = True
        Me.FichaTecnica.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Propiedad, Me.Datos})
        Me.FichaTecnica.HideSelection = False
        Me.FichaTecnica.Location = New System.Drawing.Point(12, 12)
        Me.FichaTecnica.Name = "FichaTecnica"
        Me.FichaTecnica.Size = New System.Drawing.Size(440, 620)
        Me.FichaTecnica.TabIndex = 0
        Me.FichaTecnica.UseCompatibleStateImageBehavior = False
        Me.FichaTecnica.View = System.Windows.Forms.View.Details
        '
        'Propiedad
        '
        Me.Propiedad.Text = "Propiedad"
        Me.Propiedad.Width = 190
        '
        'Datos
        '
        Me.Datos.Text = "Datos"
        Me.Datos.Width = 125
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1271, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 72)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Return Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PFList
        '
        Me.PFList.AllowColumnReorder = True
        Me.PFList.AllowDrop = True
        Me.PFList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.T1})
        ListViewGroup1.Header = "Alta Velocidad"
        ListViewGroup1.Name = "AV"
        ListViewGroup2.Header = "Baja Velocidad"
        ListViewGroup2.Name = "BV"
        Me.PFList.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.PFList.HideSelection = False
        Me.PFList.Location = New System.Drawing.Point(459, 90)
        Me.PFList.Name = "PFList"
        Me.PFList.Size = New System.Drawing.Size(907, 542)
        Me.PFList.TabIndex = 2
        Me.PFList.UseCompatibleStateImageBehavior = False
        Me.PFList.View = System.Windows.Forms.View.Details
        '
        'T1
        '
        Me.T1.Text = "Tamb\Tc"
        Me.T1.Width = 100
        '
        'BoxModelo
        '
        Me.BoxModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxModelo.FormattingEnabled = True
        Me.BoxModelo.Location = New System.Drawing.Point(459, 51)
        Me.BoxModelo.Name = "BoxModelo"
        Me.BoxModelo.Size = New System.Drawing.Size(806, 33)
        Me.BoxModelo.TabIndex = 3
        Me.BoxModelo.Text = "Seleccionar Modelo de Producto"
        '
        'BoxModeloTipo
        '
        Me.BoxModeloTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxModeloTipo.FormattingEnabled = True
        Me.BoxModeloTipo.Items.AddRange(New Object() {"RivaColdEq", "RivaColdEvap", "RivaColdCond", "RivaColdCentral"})
        Me.BoxModeloTipo.Location = New System.Drawing.Point(459, 12)
        Me.BoxModeloTipo.Name = "BoxModeloTipo"
        Me.BoxModeloTipo.Size = New System.Drawing.Size(400, 33)
        Me.BoxModeloTipo.TabIndex = 4
        Me.BoxModeloTipo.Text = "Seleccionar Tipo de Equipo"
        '
        'BoxGama
        '
        Me.BoxGama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxGama.FormattingEnabled = True
        Me.BoxGama.Location = New System.Drawing.Point(865, 12)
        Me.BoxGama.Name = "BoxGama"
        Me.BoxGama.Size = New System.Drawing.Size(400, 33)
        Me.BoxGama.TabIndex = 5
        Me.BoxGama.Text = "Seleccionar Gama de Producto"
        '
        'FormFT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 686)
        Me.Controls.Add(Me.BoxGama)
        Me.Controls.Add(Me.BoxModeloTipo)
        Me.Controls.Add(Me.BoxModelo)
        Me.Controls.Add(Me.PFList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FichaTecnica)
        Me.Name = "FormFT"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FichaTecnica As ListView
    Friend WithEvents Propiedad As ColumnHeader
    Friend WithEvents Datos As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents PFList As ListView
    Friend WithEvents T1 As ColumnHeader
    Friend WithEvents BoxModelo As ComboBox
    Friend WithEvents BoxModeloTipo As ComboBox
    Friend WithEvents BoxGama As ComboBox
End Class
