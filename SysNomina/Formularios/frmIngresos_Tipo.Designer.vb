<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresos_Tipo
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTipoIngreso = New DevExpress.XtraEditors.LookUpEdit()
        Me.dgIngresos = New DevExpress.XtraGrid.GridControl()
        Me.VIngresos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Valor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Monto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Calculadora = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Cuotas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spCuotas = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ceMontoGeneral = New DevExpress.XtraEditors.CalcEdit()
        Me.chkEmpleados = New DevExpress.XtraEditors.CheckEdit()
        Me.cbFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.chkRegular = New DevExpress.XtraEditors.CheckEdit()
        Me.Comentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbTipoIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceMontoGeneral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRegular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl2.TabIndex = 183
        Me.LabelControl2.Text = "Moneda:"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(92, 53)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 150, "Descripcion")})
        Me.cbMoneda.Properties.NullText = ""
        Me.cbMoneda.Size = New System.Drawing.Size(309, 20)
        Me.cbMoneda.TabIndex = 182
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 359)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 40)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(87, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Limpiar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(6, 11)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(678, 11)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl1.TabIndex = 180
        Me.LabelControl1.Text = "Tipo Ingreso:"
        '
        'cbTipoIngreso
        '
        Me.cbTipoIngreso.Location = New System.Drawing.Point(92, 27)
        Me.cbTipoIngreso.Name = "cbTipoIngreso"
        Me.cbTipoIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoIngreso.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 150, "Descripcion")})
        Me.cbTipoIngreso.Properties.NullText = ""
        Me.cbTipoIngreso.Size = New System.Drawing.Size(309, 20)
        Me.cbTipoIngreso.TabIndex = 179
        '
        'dgIngresos
        '
        Me.dgIngresos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgIngresos.Location = New System.Drawing.Point(10, 100)
        Me.dgIngresos.MainView = Me.VIngresos
        Me.dgIngresos.Name = "dgIngresos"
        Me.dgIngresos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbEmpleados, Me.Calculadora, Me.spCuotas})
        Me.dgIngresos.Size = New System.Drawing.Size(759, 252)
        Me.dgIngresos.TabIndex = 178
        Me.dgIngresos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VIngresos})
        '
        'VIngresos
        '
        Me.VIngresos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VIngresos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VIngresos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VIngresos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VIngresos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VIngresos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VIngresos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VIngresos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VIngresos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VIngresos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VIngresos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VIngresos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VIngresos.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VIngresos.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VIngresos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VIngresos.Appearance.Empty.Options.UseBackColor = True
        Me.VIngresos.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VIngresos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VIngresos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VIngresos.Appearance.EvenRow.Options.UseBackColor = True
        Me.VIngresos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VIngresos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VIngresos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VIngresos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VIngresos.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VIngresos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VIngresos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VIngresos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VIngresos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VIngresos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VIngresos.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VIngresos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VIngresos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VIngresos.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VIngresos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VIngresos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VIngresos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VIngresos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VIngresos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VIngresos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VIngresos.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VIngresos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VIngresos.Appearance.GroupButton.Options.UseBackColor = True
        Me.VIngresos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VIngresos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VIngresos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VIngresos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VIngresos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VIngresos.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VIngresos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VIngresos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VIngresos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VIngresos.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VIngresos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VIngresos.Appearance.GroupRow.Options.UseBackColor = True
        Me.VIngresos.Appearance.GroupRow.Options.UseFont = True
        Me.VIngresos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VIngresos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VIngresos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VIngresos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VIngresos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VIngresos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VIngresos.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VIngresos.Appearance.HorzLine.Options.UseBackColor = True
        Me.VIngresos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VIngresos.Appearance.OddRow.Options.UseBackColor = True
        Me.VIngresos.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VIngresos.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VIngresos.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VIngresos.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VIngresos.Appearance.Preview.Options.UseBackColor = True
        Me.VIngresos.Appearance.Preview.Options.UseFont = True
        Me.VIngresos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VIngresos.Appearance.Row.Options.UseBackColor = True
        Me.VIngresos.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VIngresos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VIngresos.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VIngresos.Appearance.VertLine.Options.UseBackColor = True
        Me.VIngresos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Empleado, Me.Valor, Me.Monto, Me.Cuotas, Me.Comentarios})
        Me.VIngresos.GridControl = Me.dgIngresos
        Me.VIngresos.Name = "VIngresos"
        Me.VIngresos.OptionsCustomization.AllowColumnMoving = False
        Me.VIngresos.OptionsCustomization.AllowFilter = False
        Me.VIngresos.OptionsCustomization.AllowGroup = False
        Me.VIngresos.OptionsView.EnableAppearanceEvenRow = True
        Me.VIngresos.OptionsView.EnableAppearanceOddRow = True
        Me.VIngresos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.VIngresos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VIngresos.OptionsView.ShowFooter = True
        Me.VIngresos.OptionsView.ShowGroupPanel = False
        '
        'Empleado
        '
        Me.Empleado.Caption = "Empleado"
        Me.Empleado.ColumnEdit = Me.cbEmpleados
        Me.Empleado.FieldName = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Visible = True
        Me.Empleado.VisibleIndex = 0
        '
        'cbEmpleados
        '
        Me.cbEmpleados.AutoHeight = False
        Me.cbEmpleados.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleados.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("emp_codigo", "emp_codigo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", 150, "nombre"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalarioxDia", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalarioxHora", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mon_codigo", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.NullText = ""
        Me.cbEmpleados.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        '
        'Valor
        '
        Me.Valor.Caption = "Valor"
        Me.Valor.FieldName = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.Visible = True
        Me.Valor.VisibleIndex = 1
        '
        'Monto
        '
        Me.Monto.Caption = "Monto/Dias/Horas"
        Me.Monto.ColumnEdit = Me.Calculadora
        Me.Monto.FieldName = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Visible = True
        Me.Monto.VisibleIndex = 2
        '
        'Calculadora
        '
        Me.Calculadora.AutoHeight = False
        Me.Calculadora.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Calculadora.DisplayFormat.FormatString = "n2"
        Me.Calculadora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Calculadora.Name = "Calculadora"
        '
        'Cuotas
        '
        Me.Cuotas.Caption = "Cuotas"
        Me.Cuotas.ColumnEdit = Me.spCuotas
        Me.Cuotas.FieldName = "Cuota"
        Me.Cuotas.Name = "Cuotas"
        '
        'spCuotas
        '
        Me.spCuotas.AutoHeight = False
        Me.spCuotas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spCuotas.DisplayFormat.FormatString = "n"
        Me.spCuotas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spCuotas.MaxValue = New Decimal(New Integer() {24, 0, 0, 0})
        Me.spCuotas.Name = "spCuotas"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(589, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 186
        Me.LabelControl3.Text = "Monto General:"
        '
        'ceMontoGeneral
        '
        Me.ceMontoGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ceMontoGeneral.Location = New System.Drawing.Point(669, 12)
        Me.ceMontoGeneral.Name = "ceMontoGeneral"
        Me.ceMontoGeneral.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceMontoGeneral.Size = New System.Drawing.Size(100, 20)
        Me.ceMontoGeneral.TabIndex = 184
        '
        'chkEmpleados
        '
        Me.chkEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEmpleados.Location = New System.Drawing.Point(589, 67)
        Me.chkEmpleados.Name = "chkEmpleados"
        Me.chkEmpleados.Properties.Caption = "Cargar Empleados "
        Me.chkEmpleados.Size = New System.Drawing.Size(180, 19)
        Me.chkEmpleados.TabIndex = 185
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFormaPago.Location = New System.Drawing.Point(631, 41)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Properties.NullText = "[Seleccione]"
        Me.cbFormaPago.Size = New System.Drawing.Size(138, 20)
        Me.cbFormaPago.TabIndex = 187
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(543, 44)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl4.TabIndex = 188
        Me.LabelControl4.Text = "Forma Pago Empl"
        '
        'chkRegular
        '
        Me.chkRegular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkRegular.Location = New System.Drawing.Point(8, 75)
        Me.chkRegular.Name = "chkRegular"
        Me.chkRegular.Properties.Caption = "Nomina Regular"
        Me.chkRegular.Size = New System.Drawing.Size(180, 19)
        Me.chkRegular.TabIndex = 189
        '
        'Comentarios
        '
        Me.Comentarios.Caption = "Comentarios"
        Me.Comentarios.FieldName = "ptm_comentarios"
        Me.Comentarios.MaxWidth = 250
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Visible = True
        Me.Comentarios.VisibleIndex = 3
        '
        'frmIngresos_Tipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 426)
        Me.Controls.Add(Me.chkRegular)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cbFormaPago)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ceMontoGeneral)
        Me.Controls.Add(Me.chkEmpleados)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbMoneda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbTipoIngreso)
        Me.Controls.Add(Me.dgIngresos)
        Me.Name = "frmIngresos_Tipo"
        Me.Text = "Ingresos por Tipo"
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cbTipoIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceMontoGeneral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRegular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTipoIngreso As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dgIngresos As DevExpress.XtraGrid.GridControl
    Friend WithEvents VIngresos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Monto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Calculadora As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Cuotas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spCuotas As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Valor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceMontoGeneral As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents chkEmpleados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkRegular As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Comentarios As DevExpress.XtraGrid.Columns.GridColumn
End Class
