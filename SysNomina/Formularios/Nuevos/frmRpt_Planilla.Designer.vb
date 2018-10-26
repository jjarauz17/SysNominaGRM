<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpt_Planilla
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
        Me.cbLocalidad = New DevExpress.XtraEditors.LookUpEdit
        Me.chkAgrupar = New DevExpress.XtraEditors.CheckEdit
        Me.cbTIngreso = New DevExpress.XtraEditors.LookUpEdit
        Me.cbTDeduccion = New DevExpress.XtraEditors.LookUpEdit
        Me.dgreportes = New DevExpress.XtraGrid.GridControl
        Me.vLista = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dtfecha = New DevExpress.XtraEditors.DateEdit
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cbPlanillas = New DevExpress.XtraEditors.LookUpEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.lci_planilla = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.lci_fecha = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem
        Me.lci_tdeduccion = New DevExpress.XtraLayout.LayoutControlItem
        Me.lci_tingreso = New DevExpress.XtraLayout.LayoutControlItem
        Me.lci_agrupar = New DevExpress.XtraLayout.LayoutControlItem
        Me.lci_localidad = New DevExpress.XtraLayout.LayoutControlItem
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbLocalidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAgrupar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTDeduccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgreportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtfecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPlanillas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lci_planilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lci_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lci_tdeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lci_tingreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lci_agrupar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lci_localidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbLocalidad)
        Me.LayoutControl1.Controls.Add(Me.chkAgrupar)
        Me.LayoutControl1.Controls.Add(Me.cbTIngreso)
        Me.LayoutControl1.Controls.Add(Me.cbTDeduccion)
        Me.LayoutControl1.Controls.Add(Me.dgreportes)
        Me.LayoutControl1.Controls.Add(Me.dtfecha)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.cbPlanillas)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(629, 493)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbLocalidad
        '
        Me.cbLocalidad.Location = New System.Drawing.Point(402, 60)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLocalidad.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.cbLocalidad.Properties.NullText = "[Seleccione la sucursal]"
        Me.cbLocalidad.Size = New System.Drawing.Size(215, 20)
        Me.cbLocalidad.StyleController = Me.LayoutControl1
        Me.cbLocalidad.TabIndex = 13
        '
        'chkAgrupar
        '
        Me.chkAgrupar.Location = New System.Drawing.Point(288, 132)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Properties.Caption = "Agrupar"
        Me.chkAgrupar.Size = New System.Drawing.Size(329, 19)
        Me.chkAgrupar.StyleController = Me.LayoutControl1
        Me.chkAgrupar.TabIndex = 12
        '
        'cbTIngreso
        '
        Me.cbTIngreso.Location = New System.Drawing.Point(402, 108)
        Me.cbTIngreso.Name = "cbTIngreso"
        Me.cbTIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTIngreso.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.cbTIngreso.Properties.NullText = "[Seleccione un Tipo de Ingreso]"
        Me.cbTIngreso.Size = New System.Drawing.Size(215, 20)
        Me.cbTIngreso.StyleController = Me.LayoutControl1
        Me.cbTIngreso.TabIndex = 11
        '
        'cbTDeduccion
        '
        Me.cbTDeduccion.Location = New System.Drawing.Point(402, 84)
        Me.cbTDeduccion.Name = "cbTDeduccion"
        Me.cbTDeduccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTDeduccion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.cbTDeduccion.Properties.NullText = "[Seleccione un Tipo de Deduccion]"
        Me.cbTDeduccion.Size = New System.Drawing.Size(215, 20)
        Me.cbTDeduccion.StyleController = Me.LayoutControl1
        Me.cbTDeduccion.TabIndex = 10
        '
        'dgreportes
        '
        Me.dgreportes.Location = New System.Drawing.Point(12, 12)
        Me.dgreportes.MainView = Me.vLista
        Me.dgreportes.Name = "dgreportes"
        Me.dgreportes.Size = New System.Drawing.Size(266, 443)
        Me.dgreportes.TabIndex = 9
        Me.dgreportes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vLista})
        '
        'vLista
        '
        Me.vLista.GridControl = Me.dgreportes
        Me.vLista.Name = "vLista"
        Me.vLista.OptionsBehavior.Editable = False
        Me.vLista.OptionsSelection.MultiSelect = True
        Me.vLista.OptionsView.ShowAutoFilterRow = True
        Me.vLista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vLista.OptionsView.ShowGroupPanel = False
        '
        'dtfecha
        '
        Me.dtfecha.EditValue = Nothing
        Me.dtfecha.EnterMoveNextControl = True
        Me.dtfecha.Location = New System.Drawing.Point(402, 36)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtfecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtfecha.Size = New System.Drawing.Size(215, 20)
        Me.dtfecha.StyleController = Me.LayoutControl1
        Me.dtfecha.TabIndex = 8
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(538, 459)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(79, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(455, 459)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(79, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Imprimir"
        '
        'cbPlanillas
        '
        Me.cbPlanillas.Location = New System.Drawing.Point(402, 12)
        Me.cbPlanillas.Name = "cbPlanillas"
        Me.cbPlanillas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPlanillas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("per_descripcion", "Descripcion")})
        Me.cbPlanillas.Properties.NullText = "[Seleccione un Periodo de Nomina]"
        Me.cbPlanillas.Size = New System.Drawing.Size(215, 20)
        Me.cbPlanillas.StyleController = Me.LayoutControl1
        Me.cbPlanillas.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lci_planilla, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.lci_fecha, Me.LayoutControlItem5, Me.SplitterItem1, Me.lci_tdeduccion, Me.lci_tingreso, Me.lci_agrupar, Me.lci_localidad})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(629, 493)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lci_planilla
        '
        Me.lci_planilla.Control = Me.cbPlanillas
        Me.lci_planilla.CustomizationFormText = "Seleccione una Planilla:"
        Me.lci_planilla.Location = New System.Drawing.Point(276, 0)
        Me.lci_planilla.Name = "lci_planilla"
        Me.lci_planilla.Size = New System.Drawing.Size(333, 24)
        Me.lci_planilla.Text = "Seleccione una Planilla:"
        Me.lci_planilla.TextSize = New System.Drawing.Size(110, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 447)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(443, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(276, 143)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(333, 304)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(443, 447)
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
        Me.LayoutControlItem3.Control = Me.SimpleButton2
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(526, 447)
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
        'lci_fecha
        '
        Me.lci_fecha.Control = Me.dtfecha
        Me.lci_fecha.CustomizationFormText = "Fecha"
        Me.lci_fecha.Location = New System.Drawing.Point(276, 24)
        Me.lci_fecha.Name = "lci_fecha"
        Me.lci_fecha.Size = New System.Drawing.Size(333, 24)
        Me.lci_fecha.Text = "Fecha"
        Me.lci_fecha.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dgreportes
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(270, 447)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(270, 0)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(6, 447)
        '
        'lci_tdeduccion
        '
        Me.lci_tdeduccion.Control = Me.cbTDeduccion
        Me.lci_tdeduccion.CustomizationFormText = "Tipo Deduccion:"
        Me.lci_tdeduccion.Location = New System.Drawing.Point(276, 72)
        Me.lci_tdeduccion.Name = "lci_tdeduccion"
        Me.lci_tdeduccion.Size = New System.Drawing.Size(333, 24)
        Me.lci_tdeduccion.Text = "Tipo Deduccion:"
        Me.lci_tdeduccion.TextSize = New System.Drawing.Size(110, 13)
        '
        'lci_tingreso
        '
        Me.lci_tingreso.Control = Me.cbTIngreso
        Me.lci_tingreso.CustomizationFormText = "Tipo Ingreso:"
        Me.lci_tingreso.Location = New System.Drawing.Point(276, 96)
        Me.lci_tingreso.Name = "lci_tingreso"
        Me.lci_tingreso.Size = New System.Drawing.Size(333, 24)
        Me.lci_tingreso.Text = "Tipo Ingreso:"
        Me.lci_tingreso.TextSize = New System.Drawing.Size(110, 13)
        '
        'lci_agrupar
        '
        Me.lci_agrupar.Control = Me.chkAgrupar
        Me.lci_agrupar.CustomizationFormText = "lci_agrupar"
        Me.lci_agrupar.Location = New System.Drawing.Point(276, 120)
        Me.lci_agrupar.Name = "lci_agrupar"
        Me.lci_agrupar.Size = New System.Drawing.Size(333, 23)
        Me.lci_agrupar.Text = "lci_agrupar"
        Me.lci_agrupar.TextSize = New System.Drawing.Size(0, 0)
        Me.lci_agrupar.TextToControlDistance = 0
        Me.lci_agrupar.TextVisible = False
        '
        'lci_localidad
        '
        Me.lci_localidad.Control = Me.cbLocalidad
        Me.lci_localidad.CustomizationFormText = "Sucursal"
        Me.lci_localidad.Location = New System.Drawing.Point(276, 48)
        Me.lci_localidad.Name = "lci_localidad"
        Me.lci_localidad.Size = New System.Drawing.Size(333, 24)
        Me.lci_localidad.Text = "Sucursal"
        Me.lci_localidad.TextSize = New System.Drawing.Size(110, 13)
        '
        'frmRpt_Planilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 493)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmRpt_Planilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes de Planilla: "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbLocalidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAgrupar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTDeduccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgreportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtfecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPlanillas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lci_planilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lci_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lci_tdeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lci_tingreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lci_agrupar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lci_localidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbPlanillas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lci_planilla As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dtfecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lci_fecha As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgreportes As DevExpress.XtraGrid.GridControl
    Friend WithEvents vLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents cbTDeduccion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lci_tdeduccion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTIngreso As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lci_tingreso As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkAgrupar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lci_agrupar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbLocalidad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lci_localidad As DevExpress.XtraLayout.LayoutControlItem
End Class
