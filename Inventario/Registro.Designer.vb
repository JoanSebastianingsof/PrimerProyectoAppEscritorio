<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.column0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(67, 95)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(112, 13)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Nombre Del Producto:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(67, 126)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblCategoria.TabIndex = 1
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(67, 168)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(38, 13)
        Me.lblStock.TabIndex = 2
        Me.lblStock.Text = "Stock:"
        '
        'TxtProducto
        '
        Me.TxtProducto.Location = New System.Drawing.Point(212, 92)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtProducto.TabIndex = 3
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Fisicos", "Digitales"})
        Me.cboTipo.Location = New System.Drawing.Point(212, 123)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 21)
        Me.cboTipo.TabIndex = 7
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(212, 165)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(100, 20)
        Me.TxtStock.TabIndex = 9
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(123, 223)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 10
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(263, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column0, Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(420, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(325, 179)
        Me.DataGridView1.TabIndex = 12
        '
        'column0
        '
        Me.column0.DataPropertyName = "id"
        Me.column0.HeaderText = "ID"
        Me.column0.Name = "column0"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "nombreproducto"
        Me.Column1.HeaderText = "Producto"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "categoria"
        Me.Column2.HeaderText = "Categoria"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "stock"
        Me.Column3.HeaderText = "Stock"
        Me.Column3.Name = "Column3"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Location = New System.Drawing.Point(420, 261)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(75, 23)
        Me.btnRefrescar.TabIndex = 13
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.TxtProducto)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblProducto)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProducto As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnRefrescar As Button
End Class
