<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeducciones_Tipo
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
        Me.dgDeducciones = New DevExpress.XtraGrid.GridControl()
        Me.VDeducciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Valor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Calculadora = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Monto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cuotas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spCuotas = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Comentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbTipoDeduccion = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkMantenimiento = New System.Windows.Forms.CheckBox()
        Me.lblMantenimiento = New DevExpress.XtraEditors.LabelControl()
        Me.chkEmpleados = New DevExpress.XtraEditors.CheckEdit()
        Me.ceMontoGeneral = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ceCuotas = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkRegular = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.dgDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoDeduccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceMontoGeneral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRegular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDeducciones
        '
        Me.dgDeducciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDeducciones.Location = New System.Drawing.Point(12, 124)
        Me.dgDeducciones.MainView = Me.VDeducciones
        Me.dgDeducciones.Name = "dgDeducciones"
        Me.dgDeducciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbEmpleados, Me.Calculadora, Me.spCuotas})
        Me.dgDeducciones.Size = New System.Drawing.Size(786, 227)
        Me.dgDeducciones.TabIndex = 0
        Me.dgDeducciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VDeducciones})
        '
        'VDeducciones
        '
        Me.VDeducciones.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VDeducciones.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VDeducciones.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VDeducciones.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VDeducciones.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VDeducciones.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VDeducciones.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VDeducciones.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VDeducciones.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VDeducciones.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VDeducciones.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VDeducciones.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VDeducciones.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VDeducciones.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VDeducciones.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDeducciones.Appearance.Empty.Options.UseBackColor = True
        Me.VDeducciones.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VDeducciones.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VDeducciones.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VDeducciones.Appearance.EvenRow.Options.UseBackColor = True
        Me.VDeducciones.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VDeducciones.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VDeducciones.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VDeducciones.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VDeducciones.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VDeducciones.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VDeducciones.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VDeducciones.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDeducciones.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VDeducciones.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VDeducciones.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VDeducciones.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VDeducciones.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VDeducciones.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VDeducciones.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VDeducciones.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VDeducciones.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VDeducciones.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VDeducciones.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VDeducciones.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VDeducciones.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VDeducciones.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VDeducciones.Appearance.GroupButton.Options.UseBackColor = True
        Me.VDeducciones.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VDeducciones.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VDeducciones.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VDeducciones.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VDeducciones.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VDeducciones.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VDeducciones.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VDeducciones.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VDeducciones.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VDeducciones.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VDeducciones.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VDeducciones.Appearance.GroupRow.Options.UseBackColor = True
        Me.VDeducciones.Appearance.GroupRow.Options.UseFont = True
        Me.VDeducciones.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VDeducciones.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VDeducciones.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VDeducciones.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VDeducciones.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VDeducciones.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VDeducciones.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VDeducciones.Appearance.HorzLine.Options.UseBackColor = True
        Me.VDeducciones.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VDeducciones.Appearance.OddRow.Options.UseBackColor = True
        Me.VDeducciones.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VDeducciones.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VDeducciones.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VDeducciones.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VDeducciones.Appearance.Preview.Options.UseBackColor = True
        Me.VDeducciones.Appearance.Preview.Options.UseFont = True
        Me.VDeducciones.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VDeducciones.Appearance.Row.Options.UseBackColor = True
        Me.VDeducciones.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VDeducciones.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VDeducciones.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VDeducciones.Appearance.VertLine.Options.UseBackColor = True
        Me.VDeducciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Empleado, Me.Valor, Me.Monto, Me.Cuotas, Me.Comentarios})
        Me.VDeducciones.GridControl = Me.dgDeducciones
        Me.VDeducciones.Name = "VDeducciones"
        Me.VDeducciones.OptionsCustomization.AllowColumnMoving = False
        Me.VDeducciones.OptionsCustomization.AllowFilter = False
        Me.VDeducciones.OptionsCustomization.AllowGroup = False
        Me.VDeducciones.OptionsView.EnableAppearanceEvenRow = True
        Me.VDeducciones.OptionsView.EnableAppearanceOddRow = True
        Me.VDeducciones.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.VDeducciones.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VDeducciones.OptionsView.ShowFooter = True
        Me.VDeducciones.OptionsView.ShowGroupPanel = False
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
        Me.cbEmpleados.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.NullText = ""
        Me.cbEmpleados.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        '
        'Valor
        '
        Me.Valor.Caption = "Valor"
        Me.Valor.ColumnEdit = Me.Calculadora
        Me.Valor.FieldName = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.Visible = True
        Me.Valor.VisibleIndex = 1
        '
        'Calculadora
        '
        Me.Calculadora.AutoHeight = False
        Me.Calculadora.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Calculadora.DisplayFormat.FormatString = "n2"
        Me.Calculadora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Calculadora.Name = "Calculadora"
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
        'Cuotas
        '
        Me.Cuotas.Caption = "Cuotas"
        Me.Cuotas.ColumnEdit = Me.spCuotas
        Me.Cuotas.FieldName = "Cuota"
        Me.Cuotas.Name = "Cuotas"
        Me.Cuotas.Visible = True
        Me.Cuotas.VisibleIndex = 3
        '
        'spCuotas
        '
        Me.spCuotas.AutoHeight = False
        Me.spCuotas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.spCuotas.DisplayFormat.FormatString = "n"
        Me.spCuotas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spCuotas.Name = "spCuotas"
        '
        'Comentarios
        '
        Me.Comentarios.Caption = "Comentarios"
        Me.Comentarios.FieldName = "ptm_comentarios"
        Me.Comentarios.MaxWidth = 250
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Visible = True
        Me.Comentarios.VisibleIndex = 4
        '
        'cbTipoDeduccion
        '
        Me.cbTipoDeduccion.Location = New System.Drawing.Point(94, 26)
        Me.cbTipoDeduccion.Name = "cbTipoDeduccion"
        Me.cbTipoDeduccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoDeduccion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 150, "Descripcion")})
        Me.cbTipoDeduccion.Properties.NullText = ""
        Me.cbTipoDeduccion.Size = New System.Drawing.Size(309, 20)
        Me.cbTipoDeduccion.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Tipo Deducción:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(6, 11)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(705, 11)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 40)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(87, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Limpiar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Moneda:"
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(94, 52)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 150, "Descripcion")})
        Me.cbMoneda.Properties.NullText = ""
        Me.cbMoneda.Size = New System.Drawing.Size(309, 20)
        Me.cbMoneda.TabIndex = 1
        '
        'chkMantenimiento
        '
        Me.chkMantenimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMantenimiento.Location = New System.Drawing.Point(12, 94)
        Me.chkMantenimiento.Name = "chkMantenimiento"
        Me.chkMantenimiento.Size = New System.Drawing.Size(20, 24)
        Me.chkMantenimiento.TabIndex = 176
        Me.chkMantenimiento.UseVisualStyleBackColor = False
        '
        'lblMantenimiento
        '
        Me.lblMantenimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMantenimiento.Location = New System.Drawing.Point(35, 99)
        Me.lblMantenimiento.Name = "lblMantenimiento"
        Me.lblMantenimiento.Size = New System.Drawing.Size(121, 13)
        Me.lblMantenimiento.TabIndex = 4
        Me.lblMantenimiento.Text = "Mantenimiento de Valor?:"
        '
        'chkEmpleados
        '
        Me.chkEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEmpleados.Location = New System.Drawing.Point(618, 96)
        Me.chkEmpleados.Name = "chkEmpleados"
        Me.chkEmpleados.Properties.Caption = "Cargar Empleados "
        Me.chkEmpleados.Size = New System.Drawing.Size(180, 19)
        Me.chkEmpleados.TabIndex = 3
        '
        'ceMontoGeneral
        '
        Me.ceMontoGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ceMontoGeneral.Location = New System.Drawing.Point(698, 22)
        Me.ceMontoGeneral.Name = "ceMontoGeneral"
        Me.ceMontoGeneral.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceMontoGeneral.Size = New System.Drawing.Size(100, 20)
        Me.ceMontoGeneral.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(618, 29)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 180
        Me.LabelControl3.Text = "Monto General:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(618, 55)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 182
        Me.LabelControl4.Text = "Cuotas:"
        '
        'ceCuotas
        '
        Me.ceCuotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ceCuotas.Location = New System.Drawing.Point(698, 48)
        Me.ceCuotas.Name = "ceCuotas"
        Me.ceCuotas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceCuotas.Properties.NullText = "1"
        Me.ceCuotas.Size = New System.Drawing.Size(100, 20)
        Me.ceCuotas.TabIndex = 181
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Location = New System.Drawing.Point(572, 77)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl5.TabIndex = 190
        Me.LabelControl5.Text = "Forma Pago Empl"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFormaPago.Location = New System.Drawing.Point(660, 74)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Properties.NullText = "[Seleccione]"
        Me.cbFormaPago.Size = New System.Drawing.Size(138, 20)
        Me.cbFormaPago.TabIndex = 189
        '
        'chkRegular
        '
        Me.chkRegular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkRegular.Location = New System.Drawing.Point(10, 78)
        Me.chkRegular.Name = "chkRegular"
        Me.chkRegular.Properties.Caption = "Nomina Regular"
        Me.chkRegular.Size = New System.Drawing.Size(180, 19)
        Me.chkRegular.TabIndex = 191
        '
        'frmDeducciones_Tipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 409)
        Me.Controls.Add(Me.chkRegular)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cbFormaPago)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.ceCuotas)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ceMontoGeneral)
        Me.Controls.Add(Me.chkEmpleados)
        Me.Controls.Add(Me.lblMantenimiento)
        Me.Controls.Add(Me.chkMantenimiento)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbMoneda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbTipoDeduccion)
        Me.Controls.Add(Me.dgDeducciones)
        Me.Name = "frmDeducciones_Tipo"
        Me.Text = "Deducciones por Tipo"
        CType(Me.dgDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoDeduccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceMontoGeneral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRegular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgDeducciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents VDeducciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbTipoDeduccion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Monto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Calculadora As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Cuotas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spCuotas As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkMantenimiento As System.Windows.Forms.CheckBox
    Friend WithEvents lblMantenimiento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Valor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkEmpleados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ceMontoGeneral As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceCuotas As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkRegular As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Comentarios As DevExpress.XtraGrid.Columns.GridColumn
End Class
