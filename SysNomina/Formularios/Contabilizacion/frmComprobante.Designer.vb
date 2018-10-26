<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobante
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSysContab = New DevExpress.XtraEditors.SimpleButton()
        Me.txtXe7 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.chkAgrupar = New DevExpress.XtraEditors.CheckEdit()
        Me.cbmoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnDataSet = New DevExpress.XtraEditors.SimpleButton()
        Me.RG = New DevExpress.XtraEditors.RadioGroup()
        Me.cbPlanillas = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.dgComprobante = New DevExpress.XtraGrid.GridControl()
        Me.vLista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbGastos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtXe7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAgrupar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPlanillas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSysContab)
        Me.LayoutControl1.Controls.Add(Me.txtXe7)
        Me.LayoutControl1.Controls.Add(Me.cmdReporte)
        Me.LayoutControl1.Controls.Add(Me.chkAgrupar)
        Me.LayoutControl1.Controls.Add(Me.cbmoneda)
        Me.LayoutControl1.Controls.Add(Me.btnDataSet)
        Me.LayoutControl1.Controls.Add(Me.RG)
        Me.LayoutControl1.Controls.Add(Me.cbPlanillas)
        Me.LayoutControl1.Controls.Add(Me.cmdExportar)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.dgComprobante)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(648, 548)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "Comprobante Nomina"
        '
        'cmdSysContab
        '
        Me.cmdSysContab.Location = New System.Drawing.Point(161, 507)
        Me.cmdSysContab.Name = "cmdSysContab"
        Me.cmdSysContab.Size = New System.Drawing.Size(88, 29)
        Me.cmdSysContab.StyleController = Me.LayoutControl1
        Me.cmdSysContab.TabIndex = 15
        Me.cmdSysContab.Text = "STS.Contab"
        '
        'txtXe7
        '
        Me.txtXe7.Location = New System.Drawing.Point(12, 207)
        Me.txtXe7.Name = "txtXe7"
        Me.txtXe7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtXe7.Properties.NullText = "[Seleccione una Cuenta]"
        Me.txtXe7.Size = New System.Drawing.Size(158, 20)
        Me.txtXe7.StyleController = Me.LayoutControl1
        Me.txtXe7.TabIndex = 14
        '
        'cmdReporte
        '
        Me.cmdReporte.Location = New System.Drawing.Point(253, 507)
        Me.cmdReporte.Name = "cmdReporte"
        Me.cmdReporte.Size = New System.Drawing.Size(88, 29)
        Me.cmdReporte.StyleController = Me.LayoutControl1
        Me.cmdReporte.TabIndex = 13
        Me.cmdReporte.Text = "Imprimir"
        '
        'chkAgrupar
        '
        Me.chkAgrupar.Location = New System.Drawing.Point(12, 168)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Properties.Caption = "Agrupar Cuentas"
        Me.chkAgrupar.Size = New System.Drawing.Size(158, 19)
        Me.chkAgrupar.StyleController = Me.LayoutControl1
        Me.chkAgrupar.TabIndex = 12
        '
        'cbmoneda
        '
        Me.cbmoneda.Location = New System.Drawing.Point(12, 144)
        Me.cbmoneda.Name = "cbmoneda"
        Me.cbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbmoneda.Properties.NullText = ""
        Me.cbmoneda.Size = New System.Drawing.Size(158, 20)
        Me.cbmoneda.StyleController = Me.LayoutControl1
        Me.cbmoneda.TabIndex = 11
        '
        'btnDataSet
        '
        Me.btnDataSet.Location = New System.Drawing.Point(437, 507)
        Me.btnDataSet.Name = "btnDataSet"
        Me.btnDataSet.Size = New System.Drawing.Size(107, 29)
        Me.btnDataSet.StyleController = Me.LayoutControl1
        Me.btnDataSet.TabIndex = 10
        Me.btnDataSet.Text = "Guardar en GP"
        '
        'RG
        '
        Me.RG.Location = New System.Drawing.Point(12, 28)
        Me.RG.Name = "RG"
        Me.RG.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "CSV"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Ancho Fijo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "XML"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "DBF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "XLS"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(6, Short), "SysContab")})
        Me.RG.Size = New System.Drawing.Size(158, 96)
        Me.RG.StyleController = Me.LayoutControl1
        Me.RG.TabIndex = 9
        '
        'cbPlanillas
        '
        Me.cbPlanillas.Location = New System.Drawing.Point(295, 12)
        Me.cbPlanillas.Name = "cbPlanillas"
        Me.cbPlanillas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPlanillas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("per_codigo", "Name1"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("per_descripcion", 200, "Name2")})
        Me.cbPlanillas.Properties.NullText = "[Sin Valor]"
        Me.cbPlanillas.Properties.ShowFooter = False
        Me.cbPlanillas.Properties.ShowHeader = False
        Me.cbPlanillas.Size = New System.Drawing.Size(341, 20)
        Me.cbPlanillas.StyleController = Me.LayoutControl1
        Me.cbPlanillas.TabIndex = 7
        '
        'cmdExportar
        '
        Me.cmdExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExportar.Location = New System.Drawing.Point(345, 507)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(88, 29)
        Me.cmdExportar.StyleController = Me.LayoutControl1
        Me.cmdExportar.TabIndex = 6
        Me.cmdExportar.Text = "Exportar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(548, 507)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(88, 29)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 5
        Me.cmdSalir.Text = "Salir"
        '
        'dgComprobante
        '
        Me.dgComprobante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgComprobante.Location = New System.Drawing.Point(174, 36)
        Me.dgComprobante.MainView = Me.vLista
        Me.dgComprobante.Name = "dgComprobante"
        Me.dgComprobante.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbGastos})
        Me.dgComprobante.Size = New System.Drawing.Size(462, 467)
        Me.dgComprobante.TabIndex = 4
        Me.dgComprobante.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vLista})
        '
        'vLista
        '
        Me.vLista.GridControl = Me.dgComprobante
        Me.vLista.Name = "vLista"
        Me.vLista.OptionsBehavior.Editable = False
        Me.vLista.OptionsSelection.MultiSelect = True
        Me.vLista.OptionsView.ShowAutoFilterRow = True
        Me.vLista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vLista.OptionsView.ShowFooter = True
        Me.vLista.OptionsView.ShowGroupPanel = False
        '
        'cbGastos
        '
        Me.cbGastos.AutoHeight = False
        Me.cbGastos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGastos.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")})
        Me.cbGastos.Name = "cbGastos"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem3, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(648, 548)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgComprobante
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(162, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(111, 31)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(466, 471)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdSalir
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(536, 495)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbPlanillas
        Me.LayoutControlItem4.CustomizationFormText = "Seleccione Planilla"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(162, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(466, 24)
        Me.LayoutControlItem4.Text = "Seleccione Planilla"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(118, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 495)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(149, 33)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 219)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(110, 30)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(162, 276)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.RG
        Me.LayoutControlItem6.CustomizationFormText = "Formato Archivo Export:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(162, 116)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(162, 116)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(162, 116)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Formato Archivo Export:"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnDataSet
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(425, 495)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(111, 33)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(111, 33)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(111, 33)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        Me.LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdExportar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(333, 495)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbmoneda
        Me.LayoutControlItem7.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 116)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(162, 40)
        Me.LayoutControlItem7.Text = "Moneda:"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.chkAgrupar
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(162, 23)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdReporte
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(241, 495)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtXe7
        Me.LayoutControlItem10.CustomizationFormText = "Cuenta Descuadre"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 179)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(162, 40)
        Me.LayoutControlItem10.Text = "Cuenta Descuadre"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdSysContab
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(149, 495)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'frmComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 548)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmComprobante"
        Me.Text = "Comprobante Contable de Planilla"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtXe7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAgrupar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPlanillas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgComprobante As DevExpress.XtraGrid.GridControl
    Friend WithEvents vLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbPlanillas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RG As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnDataSet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbmoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkAgrupar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtXe7 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSysContab As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbGastos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
