<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogos
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
        Me.chkAgrupar = New DevExpress.XtraEditors.CheckEdit()
        Me.cbTIngreso = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbTDeduccion = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbHasta = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbDesde = New DevExpress.XtraEditors.LookUpEdit()
        Me.gcReportes = New DevExpress.XtraGrid.GridControl()
        Me.vReportes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbEstatusEmpleados = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.pgCatalogo = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.vCatalogo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chkMasDatos = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcGrid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lcPivot = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcEstatus = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.lcMostrarDatos = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcDesde = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcHasta = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcTipoDeduccion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcTipoIngreso = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcAgrupar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Espacio = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkAgrupar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTDeduccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEstatusEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pgCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMasDatos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcPivot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcEstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcMostrarDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcTipoDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcTipoIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcAgrupar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Espacio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkAgrupar)
        Me.LayoutControl1.Controls.Add(Me.cbTIngreso)
        Me.LayoutControl1.Controls.Add(Me.cbTDeduccion)
        Me.LayoutControl1.Controls.Add(Me.cbHasta)
        Me.LayoutControl1.Controls.Add(Me.cbDesde)
        Me.LayoutControl1.Controls.Add(Me.gcReportes)
        Me.LayoutControl1.Controls.Add(Me.cmdConsultar)
        Me.LayoutControl1.Controls.Add(Me.cbEstatusEmpleados)
        Me.LayoutControl1.Controls.Add(Me.pgCatalogo)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdExportar)
        Me.LayoutControl1.Controls.Add(Me.gcCatalogo)
        Me.LayoutControl1.Controls.Add(Me.chkMasDatos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(829, 401)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkAgrupar
        '
        Me.chkAgrupar.Location = New System.Drawing.Point(187, 155)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Properties.Caption = "Agrupar"
        Me.chkAgrupar.Size = New System.Drawing.Size(359, 19)
        Me.chkAgrupar.StyleController = Me.LayoutControl1
        Me.chkAgrupar.TabIndex = 13
        '
        'cbTIngreso
        '
        Me.cbTIngreso.Location = New System.Drawing.Point(285, 131)
        Me.cbTIngreso.Name = "cbTIngreso"
        Me.cbTIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTIngreso.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.cbTIngreso.Properties.NullText = "[Seleccione un Tipo de Ingreso]"
        Me.cbTIngreso.Size = New System.Drawing.Size(261, 20)
        Me.cbTIngreso.StyleController = Me.LayoutControl1
        Me.cbTIngreso.TabIndex = 12
        '
        'cbTDeduccion
        '
        Me.cbTDeduccion.Location = New System.Drawing.Point(285, 107)
        Me.cbTDeduccion.Name = "cbTDeduccion"
        Me.cbTDeduccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTDeduccion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.cbTDeduccion.Properties.NullText = "[Seleccione un Tipo de Deduccion]"
        Me.cbTDeduccion.Size = New System.Drawing.Size(261, 20)
        Me.cbTDeduccion.StyleController = Me.LayoutControl1
        Me.cbTDeduccion.TabIndex = 14
        '
        'cbHasta
        '
        Me.cbHasta.Location = New System.Drawing.Point(285, 83)
        Me.cbHasta.Name = "cbHasta"
        Me.cbHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbHasta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("per_descripcion", "Descripcion")})
        Me.cbHasta.Properties.NullText = "[Seleccione un periodo]"
        Me.cbHasta.Size = New System.Drawing.Size(261, 20)
        Me.cbHasta.StyleController = Me.LayoutControl1
        Me.cbHasta.TabIndex = 13
        '
        'cbDesde
        '
        Me.cbDesde.Location = New System.Drawing.Point(285, 59)
        Me.cbDesde.Name = "cbDesde"
        Me.cbDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDesde.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("per_descripcion", "Descripcion")})
        Me.cbDesde.Properties.NullText = "[Seleccione un periodo]"
        Me.cbDesde.Size = New System.Drawing.Size(261, 20)
        Me.cbDesde.StyleController = Me.LayoutControl1
        Me.cbDesde.TabIndex = 12
        '
        'gcReportes
        '
        Me.gcReportes.Location = New System.Drawing.Point(12, 12)
        Me.gcReportes.MainView = Me.vReportes
        Me.gcReportes.Name = "gcReportes"
        Me.gcReportes.Size = New System.Drawing.Size(166, 377)
        Me.gcReportes.TabIndex = 11
        Me.gcReportes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vReportes})
        '
        'vReportes
        '
        Me.vReportes.GridControl = Me.gcReportes
        Me.vReportes.Name = "vReportes"
        Me.vReportes.OptionsBehavior.Editable = False
        Me.vReportes.OptionsView.ShowAutoFilterRow = True
        Me.vReportes.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vReportes.OptionsView.ShowGroupedColumns = True
        Me.vReportes.OptionsView.ShowGroupPanel = False
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(572, 367)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(79, 22)
        Me.cmdConsultar.StyleController = Me.LayoutControl1
        Me.cmdConsultar.TabIndex = 10
        Me.cmdConsultar.Text = "Consultar"
        '
        'cbEstatusEmpleados
        '
        Me.cbEstatusEmpleados.Location = New System.Drawing.Point(285, 35)
        Me.cbEstatusEmpleados.Name = "cbEstatusEmpleados"
        Me.cbEstatusEmpleados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEstatusEmpleados.Properties.Items.AddRange(New Object() {"0-InActivo", "1-Activo", "2-Todos"})
        Me.cbEstatusEmpleados.Size = New System.Drawing.Size(261, 20)
        Me.cbEstatusEmpleados.StyleController = Me.LayoutControl1
        Me.cbEstatusEmpleados.TabIndex = 9
        '
        'pgCatalogo
        '
        Me.pgCatalogo.Location = New System.Drawing.Point(187, 228)
        Me.pgCatalogo.Name = "pgCatalogo"
        Me.pgCatalogo.Size = New System.Drawing.Size(630, 111)
        Me.pgCatalogo.TabIndex = 8
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(738, 367)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(79, 22)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(655, 367)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(79, 22)
        Me.cmdExportar.StyleController = Me.LayoutControl1
        Me.cmdExportar.TabIndex = 5
        Me.cmdExportar.Text = "Exportar"
        '
        'gcCatalogo
        '
        Me.gcCatalogo.Location = New System.Drawing.Point(187, 178)
        Me.gcCatalogo.MainView = Me.vCatalogo
        Me.gcCatalogo.Name = "gcCatalogo"
        Me.gcCatalogo.Size = New System.Drawing.Size(630, 46)
        Me.gcCatalogo.TabIndex = 4
        Me.gcCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vCatalogo})
        '
        'vCatalogo
        '
        Me.vCatalogo.GridControl = Me.gcCatalogo
        Me.vCatalogo.Name = "vCatalogo"
        Me.vCatalogo.OptionsBehavior.Editable = False
        Me.vCatalogo.OptionsView.ShowAutoFilterRow = True
        '
        'chkMasDatos
        '
        Me.chkMasDatos.Location = New System.Drawing.Point(187, 12)
        Me.chkMasDatos.Name = "chkMasDatos"
        Me.chkMasDatos.Properties.Caption = "Mostrar Mas Datos"
        Me.chkMasDatos.Size = New System.Drawing.Size(630, 19)
        Me.chkMasDatos.StyleController = Me.LayoutControl1
        Me.chkMasDatos.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcGrid, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.lcPivot, Me.lcEstatus, Me.EmptySpaceItem2, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.SplitterItem1, Me.lcMostrarDatos, Me.lcDesde, Me.lcHasta, Me.lcTipoDeduccion, Me.lcTipoIngreso, Me.lcAgrupar, Me.Espacio})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(829, 401)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lcGrid
        '
        Me.lcGrid.Control = Me.gcCatalogo
        Me.lcGrid.CustomizationFormText = "LayoutControlItem1"
        Me.lcGrid.Location = New System.Drawing.Point(175, 166)
        Me.lcGrid.Name = "lcGrid"
        Me.lcGrid.Size = New System.Drawing.Size(634, 50)
        Me.lcGrid.Text = "lcGrid"
        Me.lcGrid.TextSize = New System.Drawing.Size(0, 0)
        Me.lcGrid.TextToControlDistance = 0
        Me.lcGrid.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdExportar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(643, 355)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdSalir
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(726, 355)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(175, 355)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(385, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lcPivot
        '
        Me.lcPivot.Control = Me.pgCatalogo
        Me.lcPivot.CustomizationFormText = "LayoutControlItem1"
        Me.lcPivot.Location = New System.Drawing.Point(175, 216)
        Me.lcPivot.Name = "lcPivot"
        Me.lcPivot.Size = New System.Drawing.Size(634, 115)
        Me.lcPivot.Text = "lcPivot"
        Me.lcPivot.TextSize = New System.Drawing.Size(0, 0)
        Me.lcPivot.TextToControlDistance = 0
        Me.lcPivot.TextVisible = False
        '
        'lcEstatus
        '
        Me.lcEstatus.Control = Me.cbEstatusEmpleados
        Me.lcEstatus.CustomizationFormText = "Estatus Empleados:"
        Me.lcEstatus.Location = New System.Drawing.Point(175, 23)
        Me.lcEstatus.MaxSize = New System.Drawing.Size(363, 24)
        Me.lcEstatus.MinSize = New System.Drawing.Size(363, 24)
        Me.lcEstatus.Name = "lcEstatus"
        Me.lcEstatus.Size = New System.Drawing.Size(363, 24)
        Me.lcEstatus.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lcEstatus.Text = "Estatus Empleados:"
        Me.lcEstatus.TextSize = New System.Drawing.Size(94, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(538, 23)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(271, 143)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdConsultar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(560, 355)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.gcReportes
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(170, 381)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(170, 0)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(5, 381)
        '
        'lcMostrarDatos
        '
        Me.lcMostrarDatos.Control = Me.chkMasDatos
        Me.lcMostrarDatos.CustomizationFormText = "LayoutControlItem4"
        Me.lcMostrarDatos.Location = New System.Drawing.Point(175, 0)
        Me.lcMostrarDatos.Name = "lcMostrarDatos"
        Me.lcMostrarDatos.Size = New System.Drawing.Size(634, 23)
        Me.lcMostrarDatos.Text = "lcMostrarDatos"
        Me.lcMostrarDatos.TextSize = New System.Drawing.Size(0, 0)
        Me.lcMostrarDatos.TextToControlDistance = 0
        Me.lcMostrarDatos.TextVisible = False
        '
        'lcDesde
        '
        Me.lcDesde.Control = Me.cbDesde
        Me.lcDesde.CustomizationFormText = "Desde:"
        Me.lcDesde.Location = New System.Drawing.Point(175, 47)
        Me.lcDesde.Name = "lcDesde"
        Me.lcDesde.Size = New System.Drawing.Size(363, 24)
        Me.lcDesde.Text = "Desde:"
        Me.lcDesde.TextSize = New System.Drawing.Size(94, 13)
        '
        'lcHasta
        '
        Me.lcHasta.Control = Me.cbHasta
        Me.lcHasta.CustomizationFormText = "Hasta:"
        Me.lcHasta.Location = New System.Drawing.Point(175, 71)
        Me.lcHasta.Name = "lcHasta"
        Me.lcHasta.Size = New System.Drawing.Size(363, 24)
        Me.lcHasta.Text = "Hasta:"
        Me.lcHasta.TextSize = New System.Drawing.Size(94, 13)
        '
        'lcTipoDeduccion
        '
        Me.lcTipoDeduccion.Control = Me.cbTDeduccion
        Me.lcTipoDeduccion.CustomizationFormText = "Tipo de Deduccion:"
        Me.lcTipoDeduccion.Location = New System.Drawing.Point(175, 95)
        Me.lcTipoDeduccion.Name = "lcTipoDeduccion"
        Me.lcTipoDeduccion.Size = New System.Drawing.Size(363, 24)
        Me.lcTipoDeduccion.Text = "Tipo de Deduccion:"
        Me.lcTipoDeduccion.TextSize = New System.Drawing.Size(94, 13)
        '
        'lcTipoIngreso
        '
        Me.lcTipoIngreso.Control = Me.cbTIngreso
        Me.lcTipoIngreso.CustomizationFormText = "Tipo de Ingreso:"
        Me.lcTipoIngreso.Location = New System.Drawing.Point(175, 119)
        Me.lcTipoIngreso.Name = "lcTipoIngreso"
        Me.lcTipoIngreso.Size = New System.Drawing.Size(363, 24)
        Me.lcTipoIngreso.Text = "Tipo de Ingreso:"
        Me.lcTipoIngreso.TextSize = New System.Drawing.Size(94, 13)
        '
        'lcAgrupar
        '
        Me.lcAgrupar.Control = Me.chkAgrupar
        Me.lcAgrupar.CustomizationFormText = "lcAgrupar"
        Me.lcAgrupar.Location = New System.Drawing.Point(175, 143)
        Me.lcAgrupar.Name = "lcAgrupar"
        Me.lcAgrupar.Size = New System.Drawing.Size(363, 23)
        Me.lcAgrupar.Text = "lcAgrupar"
        Me.lcAgrupar.TextSize = New System.Drawing.Size(0, 0)
        Me.lcAgrupar.TextToControlDistance = 0
        Me.lcAgrupar.TextVisible = False
        '
        'Espacio
        '
        Me.Espacio.AllowHotTrack = False
        Me.Espacio.CustomizationFormText = "EmptySpaceItem3"
        Me.Espacio.Location = New System.Drawing.Point(175, 331)
        Me.Espacio.MinSize = New System.Drawing.Size(104, 24)
        Me.Espacio.Name = "Espacio"
        Me.Espacio.Size = New System.Drawing.Size(634, 24)
        Me.Espacio.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.Espacio.Text = "Espacio"
        Me.Espacio.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 401)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmCatalogos"
        Me.Text = "Reportes"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkAgrupar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTDeduccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEstatusEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pgCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMasDatos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcPivot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcEstatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcMostrarDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcTipoDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcTipoIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcAgrupar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Espacio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents gcCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents vCatalogo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lcGrid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkMasDatos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lcMostrarDatos As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents pgCatalogo As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents lcPivot As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbEstatusEmpleados As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lcEstatus As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gcReportes As DevExpress.XtraGrid.GridControl
    Friend WithEvents vReportes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbHasta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbDesde As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lcDesde As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcHasta As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTDeduccion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lcTipoDeduccion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTIngreso As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lcTipoIngreso As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkAgrupar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lcAgrupar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Espacio As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
End Class
