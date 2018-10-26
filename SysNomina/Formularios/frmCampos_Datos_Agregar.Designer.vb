<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampos_Datos_Agregar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCadena = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.spValor = New DevExpress.XtraEditors.SpinEdit
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtCadena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCadena
        '
        Me.txtCadena.Location = New System.Drawing.Point(87, 34)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Properties.MaxLength = 50
        Me.txtCadena.Size = New System.Drawing.Size(191, 20)
        Me.txtCadena.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Digite el valor:"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(224, 91)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        '
        'spValor
        '
        Me.spValor.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spValor.Location = New System.Drawing.Point(87, 34)
        Me.spValor.Name = "spValor"
        Me.spValor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spValor.Size = New System.Drawing.Size(100, 20)
        Me.spValor.TabIndex = 3
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(143, 91)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Text = "Guardar"
        '
        'frmCampos_Datos_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(311, 126)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.spValor)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCadena)
        Me.Name = "frmCampos_Datos_Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos"
        CType(Me.txtCadena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCadena As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spValor As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
End Class
