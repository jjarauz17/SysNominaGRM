Imports System
Imports System.IO
Imports DbConnect
Imports System.Drawing
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class FrmConfiguraReporte
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents XrDesignPanel1 As DevExpress.XtraReports.UserDesigner.XRDesignPanel
    Friend WithEvents XrDesignBarManager1 As DevExpress.XtraReports.UserDesigner.XRDesignBarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RecentlyUsedItemsComboBox1 As DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox
    Friend WithEvents DesignRepositoryItemComboBox1 As DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox
    Friend WithEvents DesignRepositoryItemComboBox2 As DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox
    Friend WithEvents DesignBar2 As DevExpress.XtraReports.UserDesigner.DesignBar
    Friend WithEvents DesignBar3 As DevExpress.XtraReports.UserDesigner.DesignBar
    Friend WithEvents DesignBar4 As DevExpress.XtraReports.UserDesigner.DesignBar
    Friend WithEvents DesignBar5 As DevExpress.XtraReports.UserDesigner.DesignBar
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents CommandBarItem1 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem2 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem3 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandColorBarItem1 As DevExpress.XtraReports.UserDesigner.CommandColorBarItem
    Friend WithEvents CommandColorBarItem2 As DevExpress.XtraReports.UserDesigner.CommandColorBarItem
    Friend WithEvents CommandBarItem4 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem5 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem6 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem7 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem8 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem9 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem10 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem11 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem12 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem13 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem14 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem15 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem16 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem17 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem18 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem19 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem20 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem21 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem22 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem23 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem24 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem25 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem26 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem27 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem28 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem29 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem30 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem33 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem34 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem35 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem36 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarReportTabButtonsListItem1 As DevExpress.XtraReports.UserDesigner.BarReportTabButtonsListItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents XrBarToolbarsListItem1 As DevExpress.XtraReports.UserDesigner.XRBarToolbarsListItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarDockPanelsListItem1 As DevExpress.XtraReports.UserDesigner.BarDockPanelsListItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem7 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem8 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem9 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem10 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem11 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem12 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem13 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem14 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents CommandBarItem39 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem40 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem41 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem42 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem43 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents CommandBarItem44 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents XrZoomBarEditItem1 As DevExpress.XtraReports.UserDesigner.XRZoomBarEditItem
    Friend WithEvents CommandBarItem45 As DevExpress.XtraReports.UserDesigner.CommandBarItem
    Friend WithEvents cmdoriginal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XrDesignDockManager1 As DevExpress.XtraReports.UserDesigner.XRDesignDockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbboolean As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbfecha As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbbordes As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbimpresa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbcambio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents XrDesignDockManager2 As DevExpress.XtraReports.UserDesigner.XRDesignDockManager
    Friend WithEvents PropertyGridDockPanel1 As DevExpress.XtraReports.UserDesigner.PropertyGridDockPanel
    Friend WithEvents AutoHideContainer1 As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents PropertyGridDockPanel1_Container As DevExpress.XtraReports.UserDesigner.DesignControlContainer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguraReporte))
        Me.XrDesignPanel1 = New DevExpress.XtraReports.UserDesigner.XRDesignPanel()
        Me.XrDesignBarManager1 = New DevExpress.XtraReports.UserDesigner.XRDesignBarManager(Me.components)
        Me.DesignBar2 = New DevExpress.XtraReports.UserDesigner.DesignBar()
        Me.CommandBarItem33 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem34 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem35 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem36 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.DesignBar3 = New DevExpress.XtraReports.UserDesigner.DesignBar()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RecentlyUsedItemsComboBox1 = New DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.DesignRepositoryItemComboBox1 = New DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox()
        Me.CommandBarItem1 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem2 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem3 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandColorBarItem1 = New DevExpress.XtraReports.UserDesigner.CommandColorBarItem()
        Me.CommandColorBarItem2 = New DevExpress.XtraReports.UserDesigner.CommandColorBarItem()
        Me.CommandBarItem4 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem5 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem6 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem7 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.DesignBar4 = New DevExpress.XtraReports.UserDesigner.DesignBar()
        Me.CommandBarItem8 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem9 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem10 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem11 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem12 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem13 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem14 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem15 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem16 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem17 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem18 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem19 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem20 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem21 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem22 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem23 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem24 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem25 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem26 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem27 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem28 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem29 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem30 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.DesignBar5 = New DevExpress.XtraReports.UserDesigner.DesignBar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.CommandBarItem39 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem40 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem41 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.CommandBarItem42 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.CommandBarItem43 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarReportTabButtonsListItem1 = New DevExpress.XtraReports.UserDesigner.BarReportTabButtonsListItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.XrBarToolbarsListItem1 = New DevExpress.XtraReports.UserDesigner.XRBarToolbarsListItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarDockPanelsListItem1 = New DevExpress.XtraReports.UserDesigner.BarDockPanelsListItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem8 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem9 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem10 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem11 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem12 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem13 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem14 = New DevExpress.XtraBars.BarSubItem()
        Me.CommandBarItem44 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.XrZoomBarEditItem1 = New DevExpress.XtraReports.UserDesigner.XRZoomBarEditItem()
        Me.DesignRepositoryItemComboBox2 = New DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox()
        Me.CommandBarItem45 = New DevExpress.XtraReports.UserDesigner.CommandBarItem()
        Me.cmdoriginal = New DevExpress.XtraEditors.SimpleButton()
        Me.XrDesignDockManager1 = New DevExpress.XtraReports.UserDesigner.XRDesignDockManager(Me.components)
        Me.AutoHideContainer1 = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.cmbimpresa = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbboolean = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbfecha = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbbordes = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbcambio = New DevExpress.XtraEditors.LookUpEdit()
        Me.XrDesignDockManager2 = New DevExpress.XtraReports.UserDesigner.XRDesignDockManager(Me.components)
        Me.PropertyGridDockPanel1 = New DevExpress.XtraReports.UserDesigner.PropertyGridDockPanel()
        Me.PropertyGridDockPanel1_Container = New DevExpress.XtraReports.UserDesigner.DesignControlContainer()
        CType(Me.XrDesignPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrDesignBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecentlyUsedItemsComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignRepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrDesignDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AutoHideContainer1.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.cmbimpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbboolean.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbfecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbbordes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbcambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrDesignDockManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PropertyGridDockPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XrDesignPanel1
        '
        Me.XrDesignPanel1.ComponentVisibility = CType((DevExpress.XtraReports.Design.ComponentVisibility.ComponentTray Or DevExpress.XtraReports.Design.ComponentVisibility.ReportExplorer), DevExpress.XtraReports.Design.ComponentVisibility)
        Me.XrDesignPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XrDesignPanel1.Location = New System.Drawing.Point(0, 62)
        Me.XrDesignPanel1.Name = "XrDesignPanel1"
        Me.XrDesignPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.XrDesignPanel1.ShowComponentTray = True
        Me.XrDesignPanel1.Size = New System.Drawing.Size(501, 467)
        Me.XrDesignPanel1.TabIndex = 5
        '
        'XrDesignBarManager1
        '
        Me.XrDesignBarManager1.AllowCustomization = False
        Me.XrDesignBarManager1.AllowQuickCustomization = False
        Me.XrDesignBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.DesignBar2, Me.DesignBar3, Me.DesignBar4, Me.DesignBar5})
        Me.XrDesignBarManager1.DockControls.Add(Me.barDockControlTop)
        Me.XrDesignBarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.XrDesignBarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.XrDesignBarManager1.DockControls.Add(Me.barDockControlRight)
        Me.XrDesignBarManager1.FontNameBox = Me.RecentlyUsedItemsComboBox1
        Me.XrDesignBarManager1.FontNameEdit = Me.BarEditItem1
        Me.XrDesignBarManager1.FontSizeBox = Me.DesignRepositoryItemComboBox1
        Me.XrDesignBarManager1.FontSizeEdit = Me.BarEditItem2
        Me.XrDesignBarManager1.Form = Me
        Me.XrDesignBarManager1.FormattingToolbar = Me.DesignBar3
        Me.XrDesignBarManager1.HintStaticItem = Me.BarStaticItem1
        Me.XrDesignBarManager1.ImageStream = CType(resources.GetObject("XrDesignBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.XrDesignBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarEditItem1, Me.BarEditItem2, Me.CommandBarItem1, Me.CommandBarItem2, Me.CommandBarItem3, Me.CommandColorBarItem1, Me.CommandColorBarItem2, Me.CommandBarItem4, Me.CommandBarItem5, Me.CommandBarItem6, Me.CommandBarItem7, Me.CommandBarItem8, Me.CommandBarItem9, Me.CommandBarItem10, Me.CommandBarItem11, Me.CommandBarItem12, Me.CommandBarItem13, Me.CommandBarItem14, Me.CommandBarItem15, Me.CommandBarItem16, Me.CommandBarItem17, Me.CommandBarItem18, Me.CommandBarItem19, Me.CommandBarItem20, Me.CommandBarItem21, Me.CommandBarItem22, Me.CommandBarItem23, Me.CommandBarItem24, Me.CommandBarItem25, Me.CommandBarItem26, Me.CommandBarItem27, Me.CommandBarItem28, Me.CommandBarItem29, Me.CommandBarItem30, Me.CommandBarItem33, Me.CommandBarItem34, Me.CommandBarItem35, Me.CommandBarItem36, Me.BarStaticItem1, Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarReportTabButtonsListItem1, Me.BarSubItem4, Me.XrBarToolbarsListItem1, Me.BarSubItem5, Me.BarDockPanelsListItem1, Me.BarSubItem6, Me.BarSubItem7, Me.BarSubItem8, Me.BarSubItem9, Me.BarSubItem10, Me.BarSubItem11, Me.BarSubItem12, Me.BarSubItem13, Me.BarSubItem14, Me.CommandBarItem39, Me.CommandBarItem40, Me.CommandBarItem41, Me.CommandBarItem42, Me.CommandBarItem43, Me.CommandBarItem44, Me.XrZoomBarEditItem1, Me.CommandBarItem45})
        Me.XrDesignBarManager1.LayoutToolbar = Me.DesignBar4
        Me.XrDesignBarManager1.MaxItemId = 68
        Me.XrDesignBarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RecentlyUsedItemsComboBox1, Me.DesignRepositoryItemComboBox1, Me.DesignRepositoryItemComboBox2})
        Me.XrDesignBarManager1.StatusBar = Me.DesignBar5
        Me.XrDesignBarManager1.Toolbar = Me.DesignBar2
        Me.XrDesignBarManager1.XRDesignPanel = Me.XrDesignPanel1
        Me.XrDesignBarManager1.ZoomItem = Me.XrZoomBarEditItem1
        '
        'DesignBar2
        '
        Me.DesignBar2.BarName = "Toolbar"
        Me.DesignBar2.DockCol = 0
        Me.DesignBar2.DockRow = 0
        Me.DesignBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.DesignBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem33), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem34, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem35), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem36)})
        Me.DesignBar2.Text = "Main Toolbar"
        '
        'CommandBarItem33
        '
        Me.CommandBarItem33.Caption = "&Save"
        Me.CommandBarItem33.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SaveFile
        Me.CommandBarItem33.Enabled = False
        Me.CommandBarItem33.Hint = "Save a report"
        Me.CommandBarItem33.Id = 36
        Me.CommandBarItem33.ImageIndex = 11
        Me.CommandBarItem33.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.CommandBarItem33.Name = "CommandBarItem33"
        '
        'CommandBarItem34
        '
        Me.CommandBarItem34.Caption = "Cu&t"
        Me.CommandBarItem34.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Cut
        Me.CommandBarItem34.Enabled = False
        Me.CommandBarItem34.Hint = "Delete the control and copy it to the clipboard"
        Me.CommandBarItem34.Id = 37
        Me.CommandBarItem34.ImageIndex = 12
        Me.CommandBarItem34.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
        Me.CommandBarItem34.Name = "CommandBarItem34"
        '
        'CommandBarItem35
        '
        Me.CommandBarItem35.Caption = "&Copy"
        Me.CommandBarItem35.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Copy
        Me.CommandBarItem35.Enabled = False
        Me.CommandBarItem35.Hint = "Copy the control to the clipboard"
        Me.CommandBarItem35.Id = 38
        Me.CommandBarItem35.ImageIndex = 13
        Me.CommandBarItem35.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
        Me.CommandBarItem35.Name = "CommandBarItem35"
        '
        'CommandBarItem36
        '
        Me.CommandBarItem36.Caption = "&Paste"
        Me.CommandBarItem36.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Paste
        Me.CommandBarItem36.Enabled = False
        Me.CommandBarItem36.Hint = "Add the control from the clipboard"
        Me.CommandBarItem36.Id = 39
        Me.CommandBarItem36.ImageIndex = 14
        Me.CommandBarItem36.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
        Me.CommandBarItem36.Name = "CommandBarItem36"
        '
        'DesignBar3
        '
        Me.DesignBar3.BarName = "Formatting Toolbar"
        Me.DesignBar3.DockCol = 1
        Me.DesignBar3.DockRow = 0
        Me.DesignBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.DesignBar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandColorBarItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandColorBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem7)})
        Me.DesignBar3.Text = "Formatting Toolbar"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Font Name"
        Me.BarEditItem1.Edit = Me.RecentlyUsedItemsComboBox1
        Me.BarEditItem1.Hint = "Font Name"
        Me.BarEditItem1.Id = 0
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 120
        '
        'RecentlyUsedItemsComboBox1
        '
        Me.RecentlyUsedItemsComboBox1.AutoHeight = False
        Me.RecentlyUsedItemsComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RecentlyUsedItemsComboBox1.DropDownRows = 12
        Me.RecentlyUsedItemsComboBox1.Name = "RecentlyUsedItemsComboBox1"
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Caption = "Font Size"
        Me.BarEditItem2.Edit = Me.DesignRepositoryItemComboBox1
        Me.BarEditItem2.Hint = "Font Size"
        Me.BarEditItem2.Id = 1
        Me.BarEditItem2.Name = "BarEditItem2"
        '
        'DesignRepositoryItemComboBox1
        '
        Me.DesignRepositoryItemComboBox1.AutoHeight = False
        Me.DesignRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DesignRepositoryItemComboBox1.Name = "DesignRepositoryItemComboBox1"
        '
        'CommandBarItem1
        '
        Me.CommandBarItem1.Caption = "&Bold"
        Me.CommandBarItem1.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.FontBold
        Me.CommandBarItem1.Enabled = False
        Me.CommandBarItem1.Hint = "Make the font bold"
        Me.CommandBarItem1.Id = 2
        Me.CommandBarItem1.ImageIndex = 0
        Me.CommandBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
        Me.CommandBarItem1.Name = "CommandBarItem1"
        '
        'CommandBarItem2
        '
        Me.CommandBarItem2.Caption = "&Italic"
        Me.CommandBarItem2.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.FontItalic
        Me.CommandBarItem2.Enabled = False
        Me.CommandBarItem2.Hint = "Make the font italic"
        Me.CommandBarItem2.Id = 3
        Me.CommandBarItem2.ImageIndex = 1
        Me.CommandBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
        Me.CommandBarItem2.Name = "CommandBarItem2"
        '
        'CommandBarItem3
        '
        Me.CommandBarItem3.Caption = "&Underline"
        Me.CommandBarItem3.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.FontUnderline
        Me.CommandBarItem3.Enabled = False
        Me.CommandBarItem3.Hint = "Underline the font"
        Me.CommandBarItem3.Id = 4
        Me.CommandBarItem3.ImageIndex = 2
        Me.CommandBarItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
        Me.CommandBarItem3.Name = "CommandBarItem3"
        '
        'CommandColorBarItem1
        '
        Me.CommandColorBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.CommandColorBarItem1.Caption = "For&eground Color"
        Me.CommandColorBarItem1.CloseSubMenuOnClick = False
        Me.CommandColorBarItem1.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.ForeColor
        Me.CommandColorBarItem1.Enabled = False
        Me.CommandColorBarItem1.Glyph = CType(resources.GetObject("CommandColorBarItem1.Glyph"), System.Drawing.Image)
        Me.CommandColorBarItem1.Hint = "Set the foreground color of the control"
        Me.CommandColorBarItem1.Id = 5
        Me.CommandColorBarItem1.Name = "CommandColorBarItem1"
        '
        'CommandColorBarItem2
        '
        Me.CommandColorBarItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.CommandColorBarItem2.Caption = "Bac&kground Color"
        Me.CommandColorBarItem2.CloseSubMenuOnClick = False
        Me.CommandColorBarItem2.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.BackColor
        Me.CommandColorBarItem2.Enabled = False
        Me.CommandColorBarItem2.Glyph = CType(resources.GetObject("CommandColorBarItem2.Glyph"), System.Drawing.Image)
        Me.CommandColorBarItem2.Hint = "Set the background color of the control"
        Me.CommandColorBarItem2.Id = 6
        Me.CommandColorBarItem2.Name = "CommandColorBarItem2"
        '
        'CommandBarItem4
        '
        Me.CommandBarItem4.Caption = "&Left"
        Me.CommandBarItem4.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyLeft
        Me.CommandBarItem4.Enabled = False
        Me.CommandBarItem4.Hint = "Align the control's text to the left"
        Me.CommandBarItem4.Id = 7
        Me.CommandBarItem4.ImageIndex = 5
        Me.CommandBarItem4.Name = "CommandBarItem4"
        '
        'CommandBarItem5
        '
        Me.CommandBarItem5.Caption = "&Center"
        Me.CommandBarItem5.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyCenter
        Me.CommandBarItem5.Enabled = False
        Me.CommandBarItem5.Hint = "Align the control's text to the center"
        Me.CommandBarItem5.Id = 8
        Me.CommandBarItem5.ImageIndex = 6
        Me.CommandBarItem5.Name = "CommandBarItem5"
        '
        'CommandBarItem6
        '
        Me.CommandBarItem6.Caption = "&Right"
        Me.CommandBarItem6.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyRight
        Me.CommandBarItem6.Enabled = False
        Me.CommandBarItem6.Hint = "Align the control's text to the right"
        Me.CommandBarItem6.Id = 9
        Me.CommandBarItem6.ImageIndex = 7
        Me.CommandBarItem6.Name = "CommandBarItem6"
        '
        'CommandBarItem7
        '
        Me.CommandBarItem7.Caption = "&Justify"
        Me.CommandBarItem7.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyJustify
        Me.CommandBarItem7.Enabled = False
        Me.CommandBarItem7.Hint = "Justify the control's text"
        Me.CommandBarItem7.Id = 10
        Me.CommandBarItem7.ImageIndex = 8
        Me.CommandBarItem7.Name = "CommandBarItem7"
        '
        'DesignBar4
        '
        Me.DesignBar4.BarName = "Layout Toolbar"
        Me.DesignBar4.DockCol = 0
        Me.DesignBar4.DockRow = 1
        Me.DesignBar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.DesignBar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem15, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem19, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem23, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem27, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem28), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem29, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem30)})
        Me.DesignBar4.Text = "Layout Toolbar"
        '
        'CommandBarItem8
        '
        Me.CommandBarItem8.Caption = "to &Grid"
        Me.CommandBarItem8.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignToGrid
        Me.CommandBarItem8.Enabled = False
        Me.CommandBarItem8.Hint = "Align the positions of the selected controls to the grid"
        Me.CommandBarItem8.Id = 11
        Me.CommandBarItem8.ImageIndex = 17
        Me.CommandBarItem8.Name = "CommandBarItem8"
        '
        'CommandBarItem9
        '
        Me.CommandBarItem9.Caption = "&Lefts"
        Me.CommandBarItem9.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignLeft
        Me.CommandBarItem9.Enabled = False
        Me.CommandBarItem9.Hint = "Left align the selected controls"
        Me.CommandBarItem9.Id = 12
        Me.CommandBarItem9.ImageIndex = 18
        Me.CommandBarItem9.Name = "CommandBarItem9"
        '
        'CommandBarItem10
        '
        Me.CommandBarItem10.Caption = "&Centers"
        Me.CommandBarItem10.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignVerticalCenters
        Me.CommandBarItem10.Enabled = False
        Me.CommandBarItem10.Hint = "Align the centers of the selected controls vertically"
        Me.CommandBarItem10.Id = 13
        Me.CommandBarItem10.ImageIndex = 19
        Me.CommandBarItem10.Name = "CommandBarItem10"
        '
        'CommandBarItem11
        '
        Me.CommandBarItem11.Caption = "&Rights"
        Me.CommandBarItem11.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignRight
        Me.CommandBarItem11.Enabled = False
        Me.CommandBarItem11.Hint = "Right align the selected controls"
        Me.CommandBarItem11.Id = 14
        Me.CommandBarItem11.ImageIndex = 20
        Me.CommandBarItem11.Name = "CommandBarItem11"
        '
        'CommandBarItem12
        '
        Me.CommandBarItem12.Caption = "&Tops"
        Me.CommandBarItem12.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignTop
        Me.CommandBarItem12.Enabled = False
        Me.CommandBarItem12.Hint = "Align the tops of the selected controls"
        Me.CommandBarItem12.Id = 15
        Me.CommandBarItem12.ImageIndex = 21
        Me.CommandBarItem12.Name = "CommandBarItem12"
        '
        'CommandBarItem13
        '
        Me.CommandBarItem13.Caption = "&Middles"
        Me.CommandBarItem13.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignHorizontalCenters
        Me.CommandBarItem13.Enabled = False
        Me.CommandBarItem13.Hint = "Align the centers of the selected controls horizontally"
        Me.CommandBarItem13.Id = 16
        Me.CommandBarItem13.ImageIndex = 22
        Me.CommandBarItem13.Name = "CommandBarItem13"
        '
        'CommandBarItem14
        '
        Me.CommandBarItem14.Caption = "&Bottoms"
        Me.CommandBarItem14.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignBottom
        Me.CommandBarItem14.Enabled = False
        Me.CommandBarItem14.Hint = "Align the bottoms of the selected controls"
        Me.CommandBarItem14.Id = 17
        Me.CommandBarItem14.ImageIndex = 23
        Me.CommandBarItem14.Name = "CommandBarItem14"
        '
        'CommandBarItem15
        '
        Me.CommandBarItem15.Caption = "&Width"
        Me.CommandBarItem15.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToControlWidth
        Me.CommandBarItem15.Enabled = False
        Me.CommandBarItem15.Hint = "Make the selected controls have the same width"
        Me.CommandBarItem15.Id = 18
        Me.CommandBarItem15.ImageIndex = 24
        Me.CommandBarItem15.Name = "CommandBarItem15"
        '
        'CommandBarItem16
        '
        Me.CommandBarItem16.Caption = "Size to Gri&d"
        Me.CommandBarItem16.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToGrid
        Me.CommandBarItem16.Enabled = False
        Me.CommandBarItem16.Hint = "Size the selected controls to the grid"
        Me.CommandBarItem16.Id = 19
        Me.CommandBarItem16.ImageIndex = 25
        Me.CommandBarItem16.Name = "CommandBarItem16"
        '
        'CommandBarItem17
        '
        Me.CommandBarItem17.Caption = "&Height"
        Me.CommandBarItem17.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToControlHeight
        Me.CommandBarItem17.Enabled = False
        Me.CommandBarItem17.Hint = "Make the selected controls have the same height"
        Me.CommandBarItem17.Id = 20
        Me.CommandBarItem17.ImageIndex = 26
        Me.CommandBarItem17.Name = "CommandBarItem17"
        '
        'CommandBarItem18
        '
        Me.CommandBarItem18.Caption = "&Both"
        Me.CommandBarItem18.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToControl
        Me.CommandBarItem18.Enabled = False
        Me.CommandBarItem18.Hint = "Make the selected controls the same size"
        Me.CommandBarItem18.Id = 21
        Me.CommandBarItem18.ImageIndex = 27
        Me.CommandBarItem18.Name = "CommandBarItem18"
        '
        'CommandBarItem19
        '
        Me.CommandBarItem19.Caption = "Make &Equal"
        Me.CommandBarItem19.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceMakeEqual
        Me.CommandBarItem19.Enabled = False
        Me.CommandBarItem19.Hint = "Make the spacing between the selected controls equal"
        Me.CommandBarItem19.Id = 22
        Me.CommandBarItem19.ImageIndex = 28
        Me.CommandBarItem19.Name = "CommandBarItem19"
        '
        'CommandBarItem20
        '
        Me.CommandBarItem20.Caption = "&Increase"
        Me.CommandBarItem20.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceIncrease
        Me.CommandBarItem20.Enabled = False
        Me.CommandBarItem20.Hint = "Increase the spacing between the selected controls"
        Me.CommandBarItem20.Id = 23
        Me.CommandBarItem20.ImageIndex = 29
        Me.CommandBarItem20.Name = "CommandBarItem20"
        '
        'CommandBarItem21
        '
        Me.CommandBarItem21.Caption = "&Decrease"
        Me.CommandBarItem21.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceDecrease
        Me.CommandBarItem21.Enabled = False
        Me.CommandBarItem21.Hint = "Decrease the spacing between the selected controls"
        Me.CommandBarItem21.Id = 24
        Me.CommandBarItem21.ImageIndex = 30
        Me.CommandBarItem21.Name = "CommandBarItem21"
        '
        'CommandBarItem22
        '
        Me.CommandBarItem22.Caption = "&Remove"
        Me.CommandBarItem22.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceConcatenate
        Me.CommandBarItem22.Enabled = False
        Me.CommandBarItem22.Hint = "Remove the spacing between the selected controls"
        Me.CommandBarItem22.Id = 25
        Me.CommandBarItem22.ImageIndex = 31
        Me.CommandBarItem22.Name = "CommandBarItem22"
        '
        'CommandBarItem23
        '
        Me.CommandBarItem23.Caption = "Make &Equal"
        Me.CommandBarItem23.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceMakeEqual
        Me.CommandBarItem23.Enabled = False
        Me.CommandBarItem23.Hint = "Make the spacing between the selected controls equal"
        Me.CommandBarItem23.Id = 26
        Me.CommandBarItem23.ImageIndex = 32
        Me.CommandBarItem23.Name = "CommandBarItem23"
        '
        'CommandBarItem24
        '
        Me.CommandBarItem24.Caption = "&Increase"
        Me.CommandBarItem24.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceIncrease
        Me.CommandBarItem24.Enabled = False
        Me.CommandBarItem24.Hint = "Increase the spacing between the selected controls"
        Me.CommandBarItem24.Id = 27
        Me.CommandBarItem24.ImageIndex = 33
        Me.CommandBarItem24.Name = "CommandBarItem24"
        '
        'CommandBarItem25
        '
        Me.CommandBarItem25.Caption = "&Decrease"
        Me.CommandBarItem25.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceDecrease
        Me.CommandBarItem25.Enabled = False
        Me.CommandBarItem25.Hint = "Decrease the spacing between the selected controls"
        Me.CommandBarItem25.Id = 28
        Me.CommandBarItem25.ImageIndex = 34
        Me.CommandBarItem25.Name = "CommandBarItem25"
        '
        'CommandBarItem26
        '
        Me.CommandBarItem26.Caption = "&Remove"
        Me.CommandBarItem26.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceConcatenate
        Me.CommandBarItem26.Enabled = False
        Me.CommandBarItem26.Hint = "Remove the spacing between the selected controls"
        Me.CommandBarItem26.Id = 29
        Me.CommandBarItem26.ImageIndex = 35
        Me.CommandBarItem26.Name = "CommandBarItem26"
        '
        'CommandBarItem27
        '
        Me.CommandBarItem27.Caption = "&Horizontally"
        Me.CommandBarItem27.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.CenterHorizontally
        Me.CommandBarItem27.Enabled = False
        Me.CommandBarItem27.Hint = "Horizontally center the selected controls within a band"
        Me.CommandBarItem27.Id = 30
        Me.CommandBarItem27.ImageIndex = 36
        Me.CommandBarItem27.Name = "CommandBarItem27"
        '
        'CommandBarItem28
        '
        Me.CommandBarItem28.Caption = "&Vertically"
        Me.CommandBarItem28.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.CenterVertically
        Me.CommandBarItem28.Enabled = False
        Me.CommandBarItem28.Hint = "Vertically center the selected controls within a band"
        Me.CommandBarItem28.Id = 31
        Me.CommandBarItem28.ImageIndex = 37
        Me.CommandBarItem28.Name = "CommandBarItem28"
        '
        'CommandBarItem29
        '
        Me.CommandBarItem29.Caption = "&Bring to Front"
        Me.CommandBarItem29.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.BringToFront
        Me.CommandBarItem29.Enabled = False
        Me.CommandBarItem29.Hint = "Bring the selected controls to the front"
        Me.CommandBarItem29.Id = 32
        Me.CommandBarItem29.ImageIndex = 38
        Me.CommandBarItem29.Name = "CommandBarItem29"
        '
        'CommandBarItem30
        '
        Me.CommandBarItem30.Caption = "&Send to Back"
        Me.CommandBarItem30.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SendToBack
        Me.CommandBarItem30.Enabled = False
        Me.CommandBarItem30.Hint = "Move the selected controls to the back"
        Me.CommandBarItem30.Id = 33
        Me.CommandBarItem30.ImageIndex = 39
        Me.CommandBarItem30.Name = "CommandBarItem30"
        '
        'DesignBar5
        '
        Me.DesignBar5.BarName = "Status Bar"
        Me.DesignBar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.DesignBar5.DockCol = 0
        Me.DesignBar5.DockRow = 0
        Me.DesignBar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.DesignBar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1)})
        Me.DesignBar5.OptionsBar.AllowQuickCustomization = False
        Me.DesignBar5.OptionsBar.DrawDragBorder = False
        Me.DesignBar5.OptionsBar.UseWholeRow = True
        Me.DesignBar5.Text = "Status Bar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        Me.BarStaticItem1.Id = 42
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem1.Width = 32
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(770, 62)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 529)
        Me.barDockControlBottom.Size = New System.Drawing.Size(770, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 62)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 467)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(770, 62)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 467)
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "&File"
        Me.BarSubItem1.Id = 43
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem39), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem33, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem40), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem41, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'CommandBarItem39
        '
        Me.CommandBarItem39.Caption = "New with &Wizard..."
        Me.CommandBarItem39.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.NewReportWizard
        Me.CommandBarItem39.Hint = "Create a new report using the Wizard"
        Me.CommandBarItem39.Id = 60
        Me.CommandBarItem39.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W))
        Me.CommandBarItem39.Name = "CommandBarItem39"
        '
        'CommandBarItem40
        '
        Me.CommandBarItem40.Caption = "Save &As..."
        Me.CommandBarItem40.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SaveFileAs
        Me.CommandBarItem40.Enabled = False
        Me.CommandBarItem40.Hint = "Save a report with a new name"
        Me.CommandBarItem40.Id = 61
        Me.CommandBarItem40.Name = "CommandBarItem40"
        '
        'CommandBarItem41
        '
        Me.CommandBarItem41.Caption = "E&xit"
        Me.CommandBarItem41.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.[Exit]
        Me.CommandBarItem41.Hint = "Close the designer"
        Me.CommandBarItem41.Id = 62
        Me.CommandBarItem41.Name = "CommandBarItem41"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "&Edit"
        Me.BarSubItem2.Id = 44
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem34, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem35), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem36), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem42), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem43, True)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'CommandBarItem42
        '
        Me.CommandBarItem42.Caption = "&Delete"
        Me.CommandBarItem42.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Delete
        Me.CommandBarItem42.Enabled = False
        Me.CommandBarItem42.Hint = "Delete the control"
        Me.CommandBarItem42.Id = 63
        Me.CommandBarItem42.Name = "CommandBarItem42"
        '
        'CommandBarItem43
        '
        Me.CommandBarItem43.Caption = "Select &All"
        Me.CommandBarItem43.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SelectAll
        Me.CommandBarItem43.Enabled = False
        Me.CommandBarItem43.Hint = "Select all the controls in the document"
        Me.CommandBarItem43.Id = 64
        Me.CommandBarItem43.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A))
        Me.CommandBarItem43.Name = "CommandBarItem43"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "&View"
        Me.BarSubItem3.Id = 45
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarReportTabButtonsListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5, True)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarReportTabButtonsListItem1
        '
        Me.BarReportTabButtonsListItem1.Caption = "Tab Buttons"
        Me.BarReportTabButtonsListItem1.Id = 46
        Me.BarReportTabButtonsListItem1.Name = "BarReportTabButtonsListItem1"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "&Toolbars"
        Me.BarSubItem4.Id = 47
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.XrBarToolbarsListItem1)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'XrBarToolbarsListItem1
        '
        Me.XrBarToolbarsListItem1.Caption = "&Toolbars"
        Me.XrBarToolbarsListItem1.Id = 48
        Me.XrBarToolbarsListItem1.Name = "XrBarToolbarsListItem1"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "&Windows"
        Me.BarSubItem5.Id = 49
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarDockPanelsListItem1)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarDockPanelsListItem1
        '
        Me.BarDockPanelsListItem1.Caption = "&Windows"
        Me.BarDockPanelsListItem1.Id = 50
        Me.BarDockPanelsListItem1.Name = "BarDockPanelsListItem1"
        Me.BarDockPanelsListItem1.ShowCustomizationItem = False
        Me.BarDockPanelsListItem1.ShowDockPanels = True
        Me.BarDockPanelsListItem1.ShowToolbars = False
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Fo&rmat"
        Me.BarSubItem6.Id = 51
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandColorBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandColorBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem14, True)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarSubItem7
        '
        Me.BarSubItem7.Caption = "&Font"
        Me.BarSubItem7.Id = 52
        Me.BarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem3)})
        Me.BarSubItem7.Name = "BarSubItem7"
        '
        'BarSubItem8
        '
        Me.BarSubItem8.Caption = "&Justify"
        Me.BarSubItem8.Id = 53
        Me.BarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem7)})
        Me.BarSubItem8.Name = "BarSubItem8"
        '
        'BarSubItem9
        '
        Me.BarSubItem9.Caption = "&Align"
        Me.BarSubItem9.Id = 54
        Me.BarSubItem9.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem8, True)})
        Me.BarSubItem9.Name = "BarSubItem9"
        '
        'BarSubItem10
        '
        Me.BarSubItem10.Caption = "&Make Same Size"
        Me.BarSubItem10.Id = 55
        Me.BarSubItem10.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem15, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem18)})
        Me.BarSubItem10.Name = "BarSubItem10"
        '
        'BarSubItem11
        '
        Me.BarSubItem11.Caption = "&Horizontal Spacing"
        Me.BarSubItem11.Id = 56
        Me.BarSubItem11.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem19, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem22)})
        Me.BarSubItem11.Name = "BarSubItem11"
        '
        'BarSubItem12
        '
        Me.BarSubItem12.Caption = "&Vertical Spacing"
        Me.BarSubItem12.Id = 57
        Me.BarSubItem12.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem23, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem26)})
        Me.BarSubItem12.Name = "BarSubItem12"
        '
        'BarSubItem13
        '
        Me.BarSubItem13.Caption = "&Center in Form"
        Me.BarSubItem13.Id = 58
        Me.BarSubItem13.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem27, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem28)})
        Me.BarSubItem13.Name = "BarSubItem13"
        '
        'BarSubItem14
        '
        Me.BarSubItem14.Caption = "&Order"
        Me.BarSubItem14.Id = 59
        Me.BarSubItem14.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem29, True), New DevExpress.XtraBars.LinkPersistInfo(Me.CommandBarItem30)})
        Me.BarSubItem14.Name = "BarSubItem14"
        '
        'CommandBarItem44
        '
        Me.CommandBarItem44.Caption = "Zoom Out"
        Me.CommandBarItem44.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.ZoomOut
        Me.CommandBarItem44.Enabled = False
        Me.CommandBarItem44.Hint = "Zoom out the design surface"
        Me.CommandBarItem44.Id = 65
        Me.CommandBarItem44.ImageIndex = 40
        Me.CommandBarItem44.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Subtract))
        Me.CommandBarItem44.Name = "CommandBarItem44"
        '
        'XrZoomBarEditItem1
        '
        Me.XrZoomBarEditItem1.Caption = "Zoom"
        Me.XrZoomBarEditItem1.Edit = Me.DesignRepositoryItemComboBox2
        Me.XrZoomBarEditItem1.Enabled = False
        Me.XrZoomBarEditItem1.Hint = "Select or input the zoom factor"
        Me.XrZoomBarEditItem1.Id = 66
        Me.XrZoomBarEditItem1.Name = "XrZoomBarEditItem1"
        Me.XrZoomBarEditItem1.Width = 70
        '
        'DesignRepositoryItemComboBox2
        '
        Me.DesignRepositoryItemComboBox2.AutoComplete = False
        Me.DesignRepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DesignRepositoryItemComboBox2.Name = "DesignRepositoryItemComboBox2"
        '
        'CommandBarItem45
        '
        Me.CommandBarItem45.Caption = "Zoom In"
        Me.CommandBarItem45.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.ZoomIn
        Me.CommandBarItem45.Enabled = False
        Me.CommandBarItem45.Hint = "Zoom in the design surface"
        Me.CommandBarItem45.Id = 67
        Me.CommandBarItem45.ImageIndex = 41
        Me.CommandBarItem45.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Add))
        Me.CommandBarItem45.Name = "CommandBarItem45"
        '
        'cmdoriginal
        '
        Me.cmdoriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdoriginal.Location = New System.Drawing.Point(671, 19)
        Me.cmdoriginal.Name = "cmdoriginal"
        Me.cmdoriginal.Size = New System.Drawing.Size(96, 34)
        Me.cmdoriginal.TabIndex = 6
        Me.cmdoriginal.Text = "Formato Original"
        '
        'XrDesignDockManager1
        '
        Me.XrDesignDockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.AutoHideContainer1})
        Me.XrDesignDockManager1.Form = Me
        Me.XrDesignDockManager1.ImageStream = CType(resources.GetObject("XrDesignDockManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.XrDesignDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        Me.XrDesignDockManager1.XRDesignPanel = Me.XrDesignPanel1
        '
        'AutoHideContainer1
        '
        Me.AutoHideContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.AutoHideContainer1.Controls.Add(Me.DockPanel1)
        Me.AutoHideContainer1.Dock = System.Windows.Forms.DockStyle.Right
        Me.AutoHideContainer1.Location = New System.Drawing.Point(751, 62)
        Me.AutoHideContainer1.Name = "AutoHideContainer1"
        Me.AutoHideContainer1.Size = New System.Drawing.Size(19, 467)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("7f603330-77d0-4783-bbec-f86161f4e7d5")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(0, 0)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(200, 478)
        Me.DockPanel1.Text = "Opciones del Texto"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.cmbimpresa)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.cmbboolean)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.cmbfecha)
        Me.DockPanel1_Container.Controls.Add(Me.cmbbordes)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl4)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl5)
        Me.DockPanel1_Container.Controls.Add(Me.cmbcambio)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 25)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(194, 450)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'cmbimpresa
        '
        Me.cmbimpresa.Location = New System.Drawing.Point(24, 155)
        Me.cmbimpresa.Name = "cmbimpresa"
        Me.cmbimpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbimpresa.Properties.NullText = ""
        Me.cmbimpresa.Properties.ShowFooter = False
        Me.cmbimpresa.Properties.ShowHeader = False
        Me.cmbimpresa.Size = New System.Drawing.Size(152, 20)
        Me.cmbimpresa.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Visible:"
        '
        'cmbboolean
        '
        Me.cmbboolean.EditValue = "Si"
        Me.cmbboolean.Location = New System.Drawing.Point(79, 13)
        Me.cmbboolean.Name = "cmbboolean"
        Me.cmbboolean.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbboolean.Properties.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbboolean.Size = New System.Drawing.Size(100, 20)
        Me.cmbboolean.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Formato:"
        '
        'cmbfecha
        '
        Me.cmbfecha.EditValue = "Fecha Corta"
        Me.cmbfecha.Location = New System.Drawing.Point(80, 52)
        Me.cmbfecha.Name = "cmbfecha"
        Me.cmbfecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbfecha.Properties.Items.AddRange(New Object() {"Fecha Corta", "Fecha Larga", "Dia", "Mes", "Año", "Numero"})
        Me.cmbfecha.Size = New System.Drawing.Size(100, 20)
        Me.cmbfecha.TabIndex = 0
        '
        'cmbbordes
        '
        Me.cmbbordes.EditValue = "Todos"
        Me.cmbbordes.Location = New System.Drawing.Point(80, 86)
        Me.cmbbordes.Name = "cmbbordes"
        Me.cmbbordes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbordes.Properties.Items.AddRange(New Object() {"Todos", "Ninguno", "Superior", "Inferior", "Derecho", "Izquierdo"})
        Me.cmbbordes.Size = New System.Drawing.Size(100, 20)
        Me.cmbbordes.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 86)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Bordes:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(24, 138)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Moneda Impresa :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 190)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Moneda Tipo Cambio :"
        '
        'cmbcambio
        '
        Me.cmbcambio.Location = New System.Drawing.Point(24, 207)
        Me.cmbcambio.Name = "cmbcambio"
        Me.cmbcambio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcambio.Properties.NullText = ""
        Me.cmbcambio.Properties.ShowFooter = False
        Me.cmbcambio.Properties.ShowHeader = False
        Me.cmbcambio.Size = New System.Drawing.Size(152, 20)
        Me.cmbcambio.TabIndex = 2
        '
        'XrDesignDockManager2
        '
        Me.XrDesignDockManager2.Form = Me
        Me.XrDesignDockManager2.ImageStream = CType(resources.GetObject("XrDesignDockManager2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.XrDesignDockManager2.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.PropertyGridDockPanel1})
        Me.XrDesignDockManager2.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        Me.XrDesignDockManager2.XRDesignPanel = Me.XrDesignPanel1
        '
        'PropertyGridDockPanel1
        '
        Me.PropertyGridDockPanel1.Controls.Add(Me.PropertyGridDockPanel1_Container)
        Me.PropertyGridDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.PropertyGridDockPanel1.ID = New System.Guid("b38d12c3-cd06-4dec-b93d-63a0088e495a")
        Me.PropertyGridDockPanel1.ImageIndex = 1
        Me.PropertyGridDockPanel1.Location = New System.Drawing.Point(501, 62)
        Me.PropertyGridDockPanel1.Name = "PropertyGridDockPanel1"
        Me.PropertyGridDockPanel1.OriginalSize = New System.Drawing.Size(250, 467)
        Me.PropertyGridDockPanel1.ShowCategories = False
        Me.PropertyGridDockPanel1.Size = New System.Drawing.Size(250, 467)
        Me.PropertyGridDockPanel1.Text = "Propiedades"
        Me.PropertyGridDockPanel1.XRDesignPanel = Me.XrDesignPanel1
        '
        'PropertyGridDockPanel1_Container
        '
        Me.PropertyGridDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.PropertyGridDockPanel1_Container.Name = "PropertyGridDockPanel1_Container"
        Me.PropertyGridDockPanel1_Container.Size = New System.Drawing.Size(242, 440)
        Me.PropertyGridDockPanel1_Container.TabIndex = 0
        '
        'FrmConfiguraReporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(770, 554)
        Me.Controls.Add(Me.cmdoriginal)
        Me.Controls.Add(Me.XrDesignPanel1)
        Me.Controls.Add(Me.PropertyGridDockPanel1)
        Me.Controls.Add(Me.AutoHideContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmConfiguraReporte"
        Me.Text = "Configurar Cheque"
        CType(Me.XrDesignPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrDesignBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecentlyUsedItemsComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignRepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrDesignDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AutoHideContainer1.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.cmbimpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbboolean.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbfecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbbordes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbcambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrDesignDockManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PropertyGridDockPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _Tipo As Integer
    Private _Agregar As Integer
    Private _Constancia As Integer
    Private _Descripcion As String
    Private _Departamento As String

    Public Property Tipo()
        Get
            Return _Tipo
        End Get
        Set(ByVal value)
            _Tipo = value
        End Set
    End Property
    Public Property Agregar()
        Get
            Return _Agregar
        End Get
        Set(ByVal value)
            _Agregar = value
        End Set
    End Property

    Public Property Constancia()
        Get
            Return _Constancia
        End Get
        Set(ByVal value)
            _Constancia = value
        End Set
    End Property

    Public Property Descripcion()
        Get
            Return _Descripcion
        End Get
        Set(ByVal value)
            _Descripcion = value
        End Set
    End Property
    Public Property Departamento()
        Get
            Return _Departamento
        End Get
        Set(ByVal value)
            _Departamento = value
        End Set
    End Property


    Private Sub FrmConfiguraCheque_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Rep As XtraReport

        If Agregar = 0 Then 'Nuevo
            Rep = New Constancias
        Else
            Try
                Dim Data() As Byte = CType(ObtieneData("SELECT cons_formato FROM rh_Constancias WHERE cons_codigo = " & Constancia & " and empr_codigo = " & EmpresaActual).Rows(0).Item(0), Byte())
                Dim Tamano As Integer
                Tamano = Data.GetUpperBound(0)
                Cadena = Application.StartupPath & "\Reporte.repx"
                If File.Exists(Cadena) Then Kill(Cadena)
                Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
                Archivo.Write(Data, 0, Tamano)
                Archivo.Close()
                Temp = True
            Catch ex As Exception
            End Try

        End If
        If Temp Then
            Rep = New XtraReport
            Rep.LoadLayout(Application.StartupPath & "\Reporte.repx")
        Else
            Rep = New Constancias
        End If
        Me.XrDesignPanel1.OpenReport(Rep)
        Me.XrDesignPanel1.Show()
    End Sub

    'Sub CargarCombos()
    '    Me.cmbimpresa.Properties.DataSource = ObtieneDatos("_GetListTasaCambioDisponibles " & EmpresaActual)
    '    Me.cmbimpresa.Properties.ValueMember = "MonedaCambio"
    '    Me.cmbimpresa.Properties.DisplayMember = "Nombre"
    '    Me.cmbimpresa.Properties.PopulateColumns()
    '    cmbimpresa.EditValue = MonedaBase

    '    Me.cmbcambio.Properties.DataSource = ObtieneDatos("_GetListTasaCambioDisponibles " & EmpresaActual)
    '    Me.cmbcambio.Properties.ValueMember = "MonedaCambio"
    '    Me.cmbcambio.Properties.DisplayMember = "Nombre"
    '    Me.cmbcambio.Properties.PopulateColumns()
    '    cmbcambio.EditValue = MonedaBase

    '    'GetMonedasList(cmbimpresa)
    '    'GetMonedasList(cmbcambio)
    'End Sub

    Private Sub CommandBarItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandBarItem33.ItemClick
        GuardaDiseño()
        Close()
        'If File.Exists(Application.StartupPath & "\RptCheque.repx") Then
        '    Kill(Application.StartupPath & "\RptCheque.repx")
        'End If

        'Me.XrDesignPanel1.FileName = Application.StartupPath & "\RptCheque.repx"
        'Me.XrDesignPanel1.SaveReport()

        'Dim cn As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        'Dim cmd As New SqlCommand("SPChequeDesign", cn)
        'cmd.CommandType = CommandType.StoredProcedure

        'Dim Data As New SqlParameter("@Cheque", SqlDbType.VarBinary)
        'Dim Codigo As New SqlParameter("@Codigo", SqlDbType.Int)
        'Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.Int)
        'Dim Impresa As New SqlParameter("@Impresa", SqlDbType.NVarChar)
        'Dim Cambio As New SqlParameter("@Cambio", SqlDbType.NVarChar)
        'Dim Empresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)
        'Dim Archivo As New FileStream(Application.StartupPath & "\RptCheque.repx", _
        '                    FileMode.Open, FileAccess.Read)
        'Dim ArchivoData(Archivo.Length() - 1) As Byte

        'Archivo.Read(ArchivoData, 0, ArchivoData.Length)
        'Archivo.Close()
        'Data.Value = ArchivoData
        'Codigo.Value = Codigos
        '_Tipo.Value = Tipo
        'Impresa.Value = IsNull(cmbimpresa.EditValue, MonedaBase)
        'Cambio.Value = IsNull(cmbcambio.EditValue, MonedaBase)
        'Empresa.Value = EmpresaActual
        'cmd.Parameters.Add(Data)
        'cmd.Parameters.Add(Codigo)
        'cmd.Parameters.Add(_Tipo)
        'cmd.Parameters.Add(Impresa)
        'cmd.Parameters.Add(Cambio)
        'cmd.Parameters.Add(Empresa)

        'Try
        '    cn.Open()
        '    cmd.ExecuteNonQuery()
        '    cn.Close()
        'Catch Ex As Exception
        '    MsgBox(Ex.Message)
        'Finally
        '    Kill(Application.StartupPath & "\RptCheque.repx")
        'End Try
    End Sub

    Private Sub GuardaDiseño()
        If Agregar = 0 Then 'Nuevo
            If Departamento Is Nothing Then
                XtraMsg("No se puede guardar el reporte, Hace Falta el Departamento")
                Exit Sub
            End If

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 1, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("tipo", SqlDbType.Int, 1, ParameterDirection.Input, Tipo)
            v.AddParameter("descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Descripcion)
            v.AddParameter("codigo", SqlDbType.Int, 1, ParameterDirection.Output, 0)
            v.AddParameter("Departamento", SqlDbType.NVarChar, 4, ParameterDirection.Input, Departamento)
            v.EjecutarComando("_RH_Constancias_Add")
            Constancia = v.GetParameter("codigo").Valor
            v = Nothing
        Else

        End If

        If File.Exists(Application.StartupPath & "\Reporte.repx") Then
            Kill(Application.StartupPath & "\Reporte.repx")
        End If

        Me.XrDesignPanel1.FileName = Application.StartupPath & "\Reporte.repx"
        Me.XrDesignPanel1.SaveReport()
        Dim cn As New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
        Dim cmd As New SqlCommand("_RH_Constancias_Design", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Data As New SqlParameter("@Diseno", SqlDbType.VarBinary)
        Dim Codigo As New SqlParameter("@ID", SqlDbType.Int)
        Dim Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
        Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar, 4)
        Dim pDescripcion As New SqlParameter("@Descripcion", SqlDbType.Text)
        Dim Archivo As New FileStream(Application.StartupPath & "\Reporte.repx", _
                            FileMode.Open, FileAccess.Read)
        Dim ArchivoData(Archivo.Length() - 1) As Byte
        Archivo.Read(ArchivoData, 0, ArchivoData.Length)
        Archivo.Close()
        Data.Value = ArchivoData
        Codigo.Value = Constancia
        Empresa.Value = EmpresaActual
        pDepartamento.Value = Me.Departamento
        pDescripcion.Value = Me.Descripcion
        cmd.Parameters.Add(Data)
        cmd.Parameters.Add(Codigo)
        cmd.Parameters.Add(Empresa)
        cmd.Parameters.Add(pDepartamento)
        cmd.Parameters.Add(pDescripcion)
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Kill(Application.StartupPath & "\Reporte.repx")
        End Try
    End Sub

    Private Sub cmdoriginal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoriginal.Click
        Dim Rep As XtraReport
        Rep = New Constancias
        Me.XrDesignPanel1.OpenReport(Rep)
        Me.XrDesignPanel1.Show()

        'If Tipo = 0 Then
        '    Dim Rep As New RptCheque
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 1 Then
        '    Dim Rep As New RptFormatoAlcaldia
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 2 Then
        '    Dim Rep As New RptFacturaNew
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 3 Then
        '    Dim Rep As New RptRecibo
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 4 Then
        '    Dim Rep As New RptCotizacionNew
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 5 Then
        '    Dim Rep As New RptRetencion
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 9 Then   '' Factura de Credito RAMAC
        '    Dim Rep As New RptFacturaNewCredito
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 10 Then   '' Remisiones de Bodega RAMAC
        '    Dim Rep As New rptRemisiones
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 11 Then   '' Notas de Traslado RAMAC
        '    Dim Rep As New rptRemisiones
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 12 Then   '' Orden de Entrega RAMAC
        '    Dim Rep As New rptOrdenEntrega
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 15 Then
        '    Dim Rep As New rptOrdenCompra  'Orden de Compra
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 16 Then   '' Codigos de Barra (EQUIPSA)
        '    Dim Rep As New rtpCodigoBarra  'Configurar Codigos de Barra
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 17 Then
        '    Dim Rep As New rptComprobantesALL   'Comprobante Contable
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 18 Then
        '    Dim Rep As New rptOrdenPago   'Orden de Pago
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 19 Then
        '    Dim Rep As New rptOrdenCompra  'Pedido de Compra
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'ElseIf Tipo = 20 Then
        '    Dim Rep As New rptEstadoResultado  'Estado de Resultado Consolidado
        '    Me.XrDesignPanel1.OpenReport(Rep)
        'End If


    End Sub

End Class
