<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCat_Produccion_Detalle
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.cat_activo = New DevExpress.XtraEditors.CheckEdit
        Me.cat_factor = New DevExpress.XtraEditors.TextEdit
        Me.cat_minimo = New DevExpress.XtraEditors.TextEdit
        Me.cat_salarioxdia = New DevExpress.XtraEditors.TextEdit
        Me.cat_dias = New DevExpress.XtraEditors.TextEdit
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.cat_valor = New DevExpress.XtraEditors.TextEdit
        Me.cat_descripcion = New DevExpress.XtraEditors.TextEdit
        Me.cat_descCorta = New DevExpress.XtraEditors.TextEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cat_activo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cat_factor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cat_minimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cat_salarioxdia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cat_dias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cat_valor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cat_descripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cat_descCorta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cat_activo)
        Me.LayoutControl1.Controls.Add(Me.cat_factor)
        Me.LayoutControl1.Controls.Add(Me.cat_minimo)
        Me.LayoutControl1.Controls.Add(Me.cat_salarioxdia)
        Me.LayoutControl1.Controls.Add(Me.cat_dias)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdGuardar)
        Me.LayoutControl1.Controls.Add(Me.cat_valor)
        Me.LayoutControl1.Controls.Add(Me.cat_descripcion)
        Me.LayoutControl1.Controls.Add(Me.cat_descCorta)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(559, 234)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cat_activo
        '
        Me.cat_activo.Location = New System.Drawing.Point(276, 108)
        Me.cat_activo.Name = "cat_activo"
        Me.cat_activo.Properties.Caption = "Activo?"
        Me.cat_activo.Size = New System.Drawing.Size(256, 19)
        Me.cat_activo.StyleController = Me.LayoutControl1
        Me.cat_activo.TabIndex = 5
        '
        'cat_factor
        '
        Me.cat_factor.Location = New System.Drawing.Point(107, 108)
        Me.cat_factor.Name = "cat_factor"
        Me.cat_factor.Properties.DisplayFormat.FormatString = "n4"
        Me.cat_factor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_factor.Properties.EditFormat.FormatString = "n4"
        Me.cat_factor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_factor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.cat_factor.Properties.ReadOnly = True
        Me.cat_factor.Size = New System.Drawing.Size(165, 20)
        Me.cat_factor.StyleController = Me.LayoutControl1
        Me.cat_factor.TabIndex = 9
        Me.cat_factor.TabStop = False
        '
        'cat_minimo
        '
        Me.cat_minimo.Location = New System.Drawing.Point(371, 84)
        Me.cat_minimo.Name = "cat_minimo"
        Me.cat_minimo.Properties.DisplayFormat.FormatString = "n0"
        Me.cat_minimo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_minimo.Properties.EditFormat.FormatString = "n0"
        Me.cat_minimo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_minimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.cat_minimo.Size = New System.Drawing.Size(161, 20)
        Me.cat_minimo.StyleController = Me.LayoutControl1
        Me.cat_minimo.TabIndex = 4
        '
        'cat_salarioxdia
        '
        Me.cat_salarioxdia.Location = New System.Drawing.Point(107, 84)
        Me.cat_salarioxdia.Name = "cat_salarioxdia"
        Me.cat_salarioxdia.Properties.DisplayFormat.FormatString = "n2"
        Me.cat_salarioxdia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_salarioxdia.Properties.EditFormat.FormatString = "n2"
        Me.cat_salarioxdia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_salarioxdia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.cat_salarioxdia.Properties.ReadOnly = True
        Me.cat_salarioxdia.Size = New System.Drawing.Size(165, 20)
        Me.cat_salarioxdia.StyleController = Me.LayoutControl1
        Me.cat_salarioxdia.TabIndex = 8
        Me.cat_salarioxdia.TabStop = False
        '
        'cat_dias
        '
        Me.cat_dias.Location = New System.Drawing.Point(371, 60)
        Me.cat_dias.Name = "cat_dias"
        Me.cat_dias.Properties.DisplayFormat.FormatString = "n0"
        Me.cat_dias.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_dias.Properties.EditFormat.FormatString = "n0"
        Me.cat_dias.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_dias.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.cat_dias.Size = New System.Drawing.Size(161, 20)
        Me.cat_dias.StyleController = Me.LayoutControl1
        Me.cat_dias.TabIndex = 3
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(468, 200)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(79, 22)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(385, 200)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(79, 22)
        Me.cmdGuardar.StyleController = Me.LayoutControl1
        Me.cmdGuardar.TabIndex = 6
        Me.cmdGuardar.Text = "&Guardar"
        '
        'cat_valor
        '
        Me.cat_valor.Location = New System.Drawing.Point(107, 60)
        Me.cat_valor.Name = "cat_valor"
        Me.cat_valor.Properties.DisplayFormat.FormatString = "n2"
        Me.cat_valor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_valor.Properties.EditFormat.FormatString = "n2"
        Me.cat_valor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cat_valor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.cat_valor.Size = New System.Drawing.Size(165, 20)
        Me.cat_valor.StyleController = Me.LayoutControl1
        Me.cat_valor.TabIndex = 2
        '
        'cat_descripcion
        '
        Me.cat_descripcion.Location = New System.Drawing.Point(107, 36)
        Me.cat_descripcion.Name = "cat_descripcion"
        Me.cat_descripcion.Properties.MaxLength = 50
        Me.cat_descripcion.Size = New System.Drawing.Size(197, 20)
        Me.cat_descripcion.StyleController = Me.LayoutControl1
        Me.cat_descripcion.TabIndex = 1
        '
        'cat_descCorta
        '
        Me.cat_descCorta.Location = New System.Drawing.Point(107, 12)
        Me.cat_descCorta.Name = "cat_descCorta"
        Me.cat_descCorta.Properties.MaxLength = 10
        Me.cat_descCorta.Size = New System.Drawing.Size(197, 20)
        Me.cat_descCorta.StyleController = Me.LayoutControl1
        Me.cat_descCorta.TabIndex = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem3, Me.EmptySpaceItem2, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(559, 234)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cat_descCorta
        Me.LayoutControlItem1.CustomizationFormText = "Descripcion Corta:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Descripcion Corta:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cat_descripcion
        Me.LayoutControlItem2.CustomizationFormText = "Descripcion:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Descripcion:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(91, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 120)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(539, 68)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdGuardar
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(373, 188)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdSalir
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(456, 188)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 188)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(373, 26)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(296, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(228, 48)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cat_valor
        Me.LayoutControlItem3.CustomizationFormText = "Valor:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Valor:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cat_dias
        Me.LayoutControlItem6.CustomizationFormText = "Dias:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(264, 48)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(260, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(260, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(260, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Dias:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cat_salarioxdia
        Me.LayoutControlItem7.CustomizationFormText = "Salario x Dia:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Salario x Dia:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cat_minimo
        Me.LayoutControlItem8.CustomizationFormText = "Produccion Minima:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(264, 72)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(260, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(260, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(260, 24)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Produccion Minima:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cat_factor
        Me.LayoutControlItem9.CustomizationFormText = "Factor:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Factor:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cat_activo
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(264, 96)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(260, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(260, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(260, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(524, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(15, 120)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmCat_Produccion_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 234)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmCat_Produccion_Detalle"
        Me.Text = "Agregando / Modificando Categoria de Produccion"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cat_activo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cat_factor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cat_minimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cat_salarioxdia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cat_dias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cat_valor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cat_descripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cat_descCorta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cat_valor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cat_descripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cat_descCorta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cat_salarioxdia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cat_dias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cat_minimo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cat_activo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cat_factor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
End Class
