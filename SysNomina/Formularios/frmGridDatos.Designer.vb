<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGridDatos
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
        Me.components = New System.ComponentModel.Container()
        Me.PGDatos = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.DGDatos = New DevExpress.XtraGrid.GridControl()
        Me.VDGDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbMeses = New DevExpress.XtraEditors.LookUpEdit()
        Me.frmGridDatosConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmResumen = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmResumenxDepto = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdResumenxdeptoxarea = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmDetallexEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmDesgloseMoneda = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkTotals = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSelector = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lcchktotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcHasta = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPGrid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciVDGDatos = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LCAcciones = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PGDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VDGDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmGridDatosConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmGridDatosConvertedLayout.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.chkTotals.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcchktotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciVDGDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PGDatos
        '
        Me.PGDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PGDatos.Cursor = System.Windows.Forms.Cursors.Default
        Me.PGDatos.Location = New System.Drawing.Point(12, 91)
        Me.PGDatos.Name = "PGDatos"
        Me.PGDatos.OptionsLayout.Columns.AddNewColumns = False
        Me.PGDatos.OptionsView.ShowColumnHeaders = False
        Me.PGDatos.OptionsView.ShowDataHeaders = False
        Me.PGDatos.Size = New System.Drawing.Size(989, 163)
        Me.PGDatos.TabIndex = 5
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.CellFormat.FormatString = "d"
        Me.PivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'DGDatos
        '
        Me.DGDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGDatos.Location = New System.Drawing.Point(12, 258)
        Me.DGDatos.MainView = Me.VDGDatos
        Me.DGDatos.Name = "DGDatos"
        Me.DGDatos.Size = New System.Drawing.Size(989, 262)
        Me.DGDatos.TabIndex = 6
        Me.DGDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VDGDatos})
        '
        'VDGDatos
        '
        Me.VDGDatos.GridControl = Me.DGDatos
        Me.VDGDatos.Name = "VDGDatos"
        Me.VDGDatos.OptionsBehavior.Editable = False
        Me.VDGDatos.OptionsView.ShowAutoFilterRow = True
        Me.VDGDatos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VDGDatos.OptionsView.ShowFooter = True
        Me.VDGDatos.OptionsView.ShowGroupPanel = False
        '
        'cbMeses
        '
        Me.cbMeses.Location = New System.Drawing.Point(47, 58)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMeses.Properties.NullText = ""
        Me.cbMeses.Size = New System.Drawing.Size(173, 20)
        Me.cbMeses.StyleController = Me.frmGridDatosConvertedLayout
        Me.cbMeses.TabIndex = 9
        '
        'frmGridDatosConvertedLayout
        '
        Me.frmGridDatosConvertedLayout.Controls.Add(Me.cmdCancelar)
        Me.frmGridDatosConvertedLayout.Controls.Add(Me.cmdAceptar)
        Me.frmGridDatosConvertedLayout.Controls.Add(Me.chkTotals)
        Me.frmGridDatosConvertedLayout.Controls.Add(Me.chkSelector)
        Me.frmGridDatosConvertedLayout.Controls.Add(Me.cbMeses)
        Me.frmGridDatosConvertedLayout.Controls.Add(Me.PGDatos)
        Me.frmGridDatosConvertedLayout.Controls.Add(Me.DGDatos)
        Me.frmGridDatosConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmGridDatosConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmGridDatosConvertedLayout.Name = "frmGridDatosConvertedLayout"
        Me.frmGridDatosConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmGridDatosConvertedLayout.Size = New System.Drawing.Size(1013, 532)
        Me.frmGridDatosConvertedLayout.TabIndex = 12
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(912, 58)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(89, 29)
        Me.cmdCancelar.StyleController = Me.frmGridDatosConvertedLayout
        Me.cmdCancelar.TabIndex = 14
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.ContextMenuStrip = Me.ContextMenuStrip1
        Me.cmdAceptar.Location = New System.Drawing.Point(819, 58)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(89, 29)
        Me.cmdAceptar.StyleController = Me.frmGridDatosConvertedLayout
        Me.cmdAceptar.TabIndex = 12
        Me.cmdAceptar.Text = "Acciones"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmResumen, Me.cmResumenxDepto, Me.cmdResumenxdeptoxarea, Me.cmDetallexEmpleado, Me.cmDesgloseMoneda, Me.ToolStripSeparator1, Me.cmExportar, Me.cmImprimir})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(218, 164)
        '
        'cmResumen
        '
        Me.cmResumen.Name = "cmResumen"
        Me.cmResumen.Size = New System.Drawing.Size(217, 22)
        Me.cmResumen.Text = "Resumen"
        '
        'cmResumenxDepto
        '
        Me.cmResumenxDepto.Name = "cmResumenxDepto"
        Me.cmResumenxDepto.Size = New System.Drawing.Size(217, 22)
        Me.cmResumenxDepto.Text = "Resumen x Depto"
        '
        'cmdResumenxdeptoxarea
        '
        Me.cmdResumenxdeptoxarea.Name = "cmdResumenxdeptoxarea"
        Me.cmdResumenxdeptoxarea.Size = New System.Drawing.Size(217, 22)
        Me.cmdResumenxdeptoxarea.Text = "Resumen x Depto x Area"
        '
        'cmDetallexEmpleado
        '
        Me.cmDetallexEmpleado.Name = "cmDetallexEmpleado"
        Me.cmDetallexEmpleado.Size = New System.Drawing.Size(217, 22)
        Me.cmDetallexEmpleado.Text = "Detalle x Depto x Empleado"
        '
        'cmDesgloseMoneda
        '
        Me.cmDesgloseMoneda.Name = "cmDesgloseMoneda"
        Me.cmDesgloseMoneda.Size = New System.Drawing.Size(217, 22)
        Me.cmDesgloseMoneda.Text = "Deglose de Moneda"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'cmExportar
        '
        Me.cmExportar.Name = "cmExportar"
        Me.cmExportar.Size = New System.Drawing.Size(217, 22)
        Me.cmExportar.Text = "Exportar"
        '
        'cmImprimir
        '
        Me.cmImprimir.Name = "cmImprimir"
        Me.cmImprimir.Size = New System.Drawing.Size(217, 22)
        Me.cmImprimir.Text = "Imprimir"
        '
        'chkTotals
        '
        Me.chkTotals.Location = New System.Drawing.Point(12, 35)
        Me.chkTotals.Name = "chkTotals"
        Me.chkTotals.Properties.Caption = "Mostrar Conteo y Suma"
        Me.chkTotals.Size = New System.Drawing.Size(208, 19)
        Me.chkTotals.StyleController = Me.frmGridDatosConvertedLayout
        Me.chkTotals.TabIndex = 11
        '
        'chkSelector
        '
        Me.chkSelector.Location = New System.Drawing.Point(12, 12)
        Me.chkSelector.Name = "chkSelector"
        Me.chkSelector.Properties.Caption = "Mostrar Selector de Campos"
        Me.chkSelector.Size = New System.Drawing.Size(208, 19)
        Me.chkSelector.StyleController = Me.frmGridDatosConvertedLayout
        Me.chkSelector.TabIndex = 10
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcchktotal, Me.LayoutControlItem2, Me.lcHasta, Me.lciPGrid, Me.lciVDGDatos, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LCAcciones, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1013, 532)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lcchktotal
        '
        Me.lcchktotal.Control = Me.chkTotals
        Me.lcchktotal.CustomizationFormText = "Hasta:"
        Me.lcchktotal.Location = New System.Drawing.Point(0, 23)
        Me.lcchktotal.Name = "lcchktotal"
        Me.lcchktotal.Size = New System.Drawing.Size(212, 23)
        Me.lcchktotal.Text = "Hasta:"
        Me.lcchktotal.TextLocation = DevExpress.Utils.Locations.Bottom
        Me.lcchktotal.TextSize = New System.Drawing.Size(0, 0)
        Me.lcchktotal.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.chkSelector
        Me.LayoutControlItem2.CustomizationFormText = "chkSelectoritem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "chkSelectoritem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(212, 23)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'lcHasta
        '
        Me.lcHasta.Control = Me.cbMeses
        Me.lcHasta.CustomizationFormText = "cbMesesitem"
        Me.lcHasta.Location = New System.Drawing.Point(0, 46)
        Me.lcHasta.Name = "lcHasta"
        Me.lcHasta.Size = New System.Drawing.Size(212, 33)
        Me.lcHasta.Text = "Hasta:"
        Me.lcHasta.TextSize = New System.Drawing.Size(32, 13)
        Me.lcHasta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lciPGrid
        '
        Me.lciPGrid.Control = Me.PGDatos
        Me.lciPGrid.CustomizationFormText = "lciPGrid"
        Me.lciPGrid.Location = New System.Drawing.Point(0, 79)
        Me.lciPGrid.Name = "lciPGrid"
        Me.lciPGrid.Size = New System.Drawing.Size(993, 167)
        Me.lciPGrid.TextSize = New System.Drawing.Size(0, 0)
        Me.lciPGrid.TextVisible = False
        '
        'lciVDGDatos
        '
        Me.lciVDGDatos.Control = Me.DGDatos
        Me.lciVDGDatos.CustomizationFormText = "lciVDGDatos"
        Me.lciVDGDatos.Location = New System.Drawing.Point(0, 246)
        Me.lciVDGDatos.Name = "lciVDGDatos"
        Me.lciVDGDatos.Size = New System.Drawing.Size(993, 266)
        Me.lciVDGDatos.TextSize = New System.Drawing.Size(0, 0)
        Me.lciVDGDatos.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(212, 46)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(595, 33)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(212, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(781, 46)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LCAcciones
        '
        Me.LCAcciones.Control = Me.cmdAceptar
        Me.LCAcciones.CustomizationFormText = "LayoutControlItem4"
        Me.LCAcciones.Location = New System.Drawing.Point(807, 46)
        Me.LCAcciones.MaxSize = New System.Drawing.Size(93, 33)
        Me.LCAcciones.MinSize = New System.Drawing.Size(93, 33)
        Me.LCAcciones.Name = "LCAcciones"
        Me.LCAcciones.Size = New System.Drawing.Size(93, 33)
        Me.LCAcciones.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LCAcciones.TextSize = New System.Drawing.Size(0, 0)
        Me.LCAcciones.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdCancelar
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(900, 46)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(93, 33)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(93, 33)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(93, 33)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.PGDatos
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String(-1) {}, New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String(-1) {}, New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A3
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'frmGridDatos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1013, 532)
        Me.Controls.Add(Me.frmGridDatosConvertedLayout)
        Me.Name = "frmGridDatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PGDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VDGDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmGridDatosConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmGridDatosConvertedLayout.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.chkTotals.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcchktotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciVDGDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PGDatos As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents DGDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents VDGDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbMeses As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkSelector As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTotals As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents frmGridDatosConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lcchktotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcHasta As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciPGrid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciVDGDatos As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LCAcciones As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmResumenxDepto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdResumenxdeptoxarea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmDetallexEmpleado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmExportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents cmDesgloseMoneda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmResumen As System.Windows.Forms.ToolStripMenuItem
End Class
