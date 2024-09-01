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
        LBLCARGA = New Label()
        btnCarga = New Button()
        cmbProductos = New ComboBox()
        Label1 = New Label()
        txtDescripcion = New TextBox()
        txtPrecio = New TextBox()
        txtStock = New TextBox()
        lblDetalle = New Label()
        lblNombre = New Label()
        lblPrecio = New Label()
        lblStock = New Label()
        SuspendLayout()
        ' 
        ' LBLCARGA
        ' 
        LBLCARGA.AutoSize = True
        LBLCARGA.Location = New Point(141, 62)
        LBLCARGA.Name = "LBLCARGA"
        LBLCARGA.Size = New Size(89, 15)
        LBLCARGA.TabIndex = 0
        LBLCARGA.Text = "Boton de Carga"
        ' 
        ' btnCarga
        ' 
        btnCarga.Location = New Point(407, 62)
        btnCarga.Name = "btnCarga"
        btnCarga.Size = New Size(137, 23)
        btnCarga.TabIndex = 1
        btnCarga.Text = "Cargar Productos"
        btnCarga.UseVisualStyleBackColor = True
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(407, 124)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(137, 23)
        cmbProductos.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(141, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 15)
        Label1.TabIndex = 3
        Label1.Text = "Seleccionar Codigo Producto"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(40, 341)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(302, 23)
        txtDescripcion.TabIndex = 4
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(387, 341)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(180, 23)
        txtPrecio.TabIndex = 5
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(615, 341)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(171, 23)
        txtStock.TabIndex = 6
        ' 
        ' lblDetalle
        ' 
        lblDetalle.AutoSize = True
        lblDetalle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblDetalle.Location = New Point(91, 219)
        lblDetalle.Name = "lblDetalle"
        lblDetalle.Size = New Size(147, 17)
        lblDetalle.TabIndex = 7
        lblDetalle.Text = "Detalle del Producto : "
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(40, 296)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(128, 15)
        lblNombre.TabIndex = 8
        lblNombre.Text = "Nombre del Producto: "
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Location = New Point(387, 296)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(117, 15)
        lblPrecio.TabIndex = 9
        lblPrecio.Text = "Precio del Producto: "
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Location = New Point(615, 296)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(110, 15)
        lblStock.TabIndex = 10
        lblStock.Text = "Stock del Producto:"
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        ClientSize = New Size(834, 461)
        Controls.Add(lblStock)
        Controls.Add(lblPrecio)
        Controls.Add(lblNombre)
        Controls.Add(lblDetalle)
        Controls.Add(txtStock)
        Controls.Add(txtPrecio)
        Controls.Add(txtDescripcion)
        Controls.Add(Label1)
        Controls.Add(cmbProductos)
        Controls.Add(btnCarga)
        Controls.Add(LBLCARGA)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "EPE1_JASNA_RAMIREZ"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBLCARGA As Label
    Friend WithEvents btnCarga As Button
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblStock As Label

End Class
