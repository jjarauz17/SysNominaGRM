<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleConstancia
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
        Me.cbEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.rgFirmas = New DevExpress.XtraEditors.RadioGroup()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdContinuar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cbEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFirmas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbEmpleado
        '
        Me.cbEmpleado.Location = New System.Drawing.Point(156, 86)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleado.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", 100, "Nombre")})
        Me.cbEmpleado.Properties.NullText = ""
        Me.cbEmpleado.Size = New System.Drawing.Size(228, 20)
        Me.cbEmpleado.TabIndex = 8
        '
        'rgFirmas
        '
        Me.rgFirmas.Location = New System.Drawing.Point(25, 29)
        Me.rgFirmas.Name = "rgFirmas"
        Me.rgFirmas.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgFirmas.Properties.Appearance.Options.UseBackColor = True
        Me.rgFirmas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgFirmas.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Representante Legal"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Departamento")})
        Me.rgFirmas.Size = New System.Drawing.Size(138, 96)
        Me.rgFirmas.TabIndex = 10
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(11, 30)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(372, 20)
        Me.txtDescripcion.TabIndex = 11
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Quien firma?:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(140, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Descripción de la Constancia:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 84)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.cbEmpleado)
        Me.GroupBox2.Controls.Add(Me.rgFirmas)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 134)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'cmdContinuar
        '
        Me.cmdContinuar.Location = New System.Drawing.Point(266, 232)
        Me.cmdContinuar.Name = "cmdContinuar"
        Me.cmdContinuar.Size = New System.Drawing.Size(75, 23)
        Me.cmdContinuar.TabIndex = 16
        Me.cmdContinuar.Text = "&Continuar >>"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(347, 232)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 17
        Me.SimpleButton1.Text = "C&ancelar"
        '
        'frmDetalleConstancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(437, 260)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdContinuar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleConstancia"
        Me.Text = "Detalle Constancia"
        CType(Me.cbEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgFirmas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rgFirmas As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdContinuar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
