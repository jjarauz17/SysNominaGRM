Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    'Inherits XtraForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.iHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.siStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.siInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.alignButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iBoldFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iItalicFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iUnderlinedFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.fontStyleButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iLeftTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iCenterTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iRightTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BarButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarMdiChildrenListItem1 = New DevExpress.XtraBars.BarMdiChildrenListItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnList = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.bAnexos = New DevExpress.XtraBars.BarButtonItem()
        Me.bUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.bTasa = New DevExpress.XtraBars.BarButtonItem()
        Me.lblEstilo = New DevExpress.XtraBars.BarStaticItem()
        Me.lblVersion = New DevExpress.XtraBars.BarStaticItem()
        Me.lblUsuario = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem36 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem37 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem39 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem40 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem42 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem43 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem41 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem44 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem45 = New DevExpress.XtraBars.BarButtonItem()
        Me.bDocumentosFuentes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem46 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem47 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem48 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem49 = New DevExpress.XtraBars.BarButtonItem()
        Me.bBalanza = New DevExpress.XtraBars.BarButtonItem()
        Me.bCambiarPass = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem51 = New DevExpress.XtraBars.BarButtonItem()
        Me.bBalance = New DevExpress.XtraBars.BarButtonItem()
        Me.bEstadoResultado = New DevExpress.XtraBars.BarButtonItem()
        Me.bConfigurarBalance = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem50 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem52 = New DevExpress.XtraBars.BarButtonItem()
        Me.bCierreMes = New DevExpress.XtraBars.BarButtonItem()
        Me.bMovimientosContables = New DevExpress.XtraBars.BarButtonItem()
        Me.bRazonesFinancieras = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem53 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem55 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem56 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem32 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem33 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem34 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem35 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem38 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem54 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem57 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem58 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem59 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem60 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem61 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem62 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem63 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem64 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem65 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem66 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem67 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem69 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem70 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem71 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem72 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem73 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem75 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem76 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem77 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem78 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem79 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem80 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.rCatalogo = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup14 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup17 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.homeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup15 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.helpRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.helpRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.iNew = New DevExpress.XtraBars.BarButtonItem()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'navbarImageCollectionLarge
        '
        Me.navbarImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.navbarImageCollectionLarge.ImageStream = CType(resources.GetObject("navbarImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_32x32.png")
        Me.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_32x32.png")
        '
        'navbarImageCollection
        '
        Me.navbarImageCollection.ImageStream = CType(resources.GetObject("navbarImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(6, "ActiveCustomersList_16x16.png")
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonAccessibleDescription = "General Configurations"
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ApplicationCaption = "SysNomina v3.0.0.1"
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.iExit, Me.iHelp, Me.iAbout, Me.siStatus, Me.siInfo, Me.alignButtonGroup, Me.iBoldFontStyle, Me.iItalicFontStyle, Me.iUnderlinedFontStyle, Me.fontStyleButtonGroup, Me.iLeftTextAlign, Me.iCenterTextAlign, Me.iRightTextAlign, Me.rgbiSkins, Me.BarButtonGroup1, Me.BarButtonGroup2, Me.BarButtonItem2, Me.BarMdiChildrenListItem1, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnRefresh, Me.btnClose, Me.btnList, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.btnSave, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.btnPrint, Me.btnExport, Me.BarButtonItem23, Me.BarButtonItem16, Me.BarButtonItem22, Me.BarButtonItem24, Me.BarButtonItem25, Me.BarButtonItem26, Me.BarButtonItem27, Me.BarButtonItem28, Me.BarButtonItem30, Me.BarButtonItem31, Me.bAnexos, Me.bUsuario, Me.bTasa, Me.lblEstilo, Me.lblVersion, Me.lblUsuario, Me.BarButtonItem29, Me.BarButtonItem36, Me.BarButtonItem37, Me.BarButtonItem39, Me.BarButtonItem40, Me.BarButtonItem42, Me.BarButtonItem43, Me.BarButtonItem41, Me.BarButtonItem44, Me.BarButtonItem45, Me.bDocumentosFuentes, Me.BarButtonItem46, Me.BarButtonItem47, Me.BarButtonItem48, Me.BarButtonItem49, Me.bBalanza, Me.bCambiarPass, Me.BarButtonItem51, Me.bBalance, Me.bEstadoResultado, Me.bConfigurarBalance, Me.BarButtonItem50, Me.BarButtonItem52, Me.bCierreMes, Me.bMovimientosContables, Me.bRazonesFinancieras, Me.BarButtonItem53, Me.BarButtonItem55, Me.BarButtonItem56, Me.BarButtonItem15, Me.BarButtonItem32, Me.BarButtonItem33, Me.BarButtonItem34, Me.BarButtonItem35, Me.BarButtonItem38, Me.BarButtonItem54, Me.BarButtonItem57, Me.BarButtonItem58, Me.BarButtonItem59, Me.BarButtonItem60, Me.BarButtonItem61, Me.BarButtonItem62, Me.BarButtonItem63, Me.BarButtonItem64, Me.BarButtonItem65, Me.BarButtonItem66, Me.BarButtonItem67, Me.BarButtonItem69, Me.BarButtonItem70, Me.BarButtonItem71, Me.BarButtonItem72, Me.BarButtonItem73, Me.BarButtonItem75, Me.BarButtonItem76, Me.BarButtonItem77, Me.BarButtonItem78, Me.BarButtonItem79, Me.BarButtonItem80})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 195
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.lblEstilo)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rCatalogo, Me.RibbonPage3, Me.RibbonPage4, Me.RibbonPage1, Me.RibbonPage2, Me.homeRibbonPage, Me.RibbonPage5, Me.helpRibbonPage})
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.lblVersion)
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(1025, 143)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        Me.ribbonControl.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[True]
        '
        'appMenu
        '
        Me.appMenu.ItemLinks.Add(Me.iHelp)
        Me.appMenu.ItemLinks.Add(Me.BarButtonItem16)
        Me.appMenu.ItemLinks.Add(Me.iAbout)
        Me.appMenu.ItemLinks.Add(Me.iExit)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.ShowRightPane = True
        '
        'iHelp
        '
        Me.iHelp.Caption = "Manual de Usuario"
        Me.iHelp.Description = "Start the program help system."
        Me.iHelp.Hint = "Start the program help system"
        Me.iHelp.Id = 22
        Me.iHelp.ImageOptions.ImageIndex = 7
        Me.iHelp.ImageOptions.LargeImageIndex = 7
        Me.iHelp.Name = "iHelp"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Conexión Nomina con Otros Modulos"
        Me.BarButtonItem16.Id = 102
        Me.BarButtonItem16.ImageOptions.Image = CType(resources.GetObject("BarButtonItem16.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem16.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem16.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'iAbout
        '
        Me.iAbout.Caption = "Acerca de..."
        Me.iAbout.Description = "Displays general program information."
        Me.iAbout.Hint = "Displays general program information"
        Me.iAbout.Id = 24
        Me.iAbout.ImageOptions.ImageIndex = 8
        Me.iAbout.ImageOptions.LargeImageIndex = 8
        Me.iAbout.Name = "iAbout"
        '
        'iExit
        '
        Me.iExit.Caption = "Salir del Sistema"
        Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
        Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
        Me.iExit.Id = 20
        Me.iExit.ImageOptions.ImageIndex = 6
        Me.iExit.ImageOptions.LargeImageIndex = 6
        Me.iExit.LargeWidth = 80
        Me.iExit.Name = "iExit"
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        '
        'siStatus
        '
        Me.siStatus.Id = 31
        Me.siStatus.ImageOptions.Image = CType(resources.GetObject("siStatus.ImageOptions.Image"), System.Drawing.Image)
        Me.siStatus.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siStatus.ItemAppearance.Normal.Options.UseFont = True
        Me.siStatus.Name = "siStatus"
        '
        'siInfo
        '
        Me.siInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.siInfo.Id = 32
        Me.siInfo.ImageOptions.Image = CType(resources.GetObject("siInfo.ImageOptions.Image"), System.Drawing.Image)
        Me.siInfo.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siInfo.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkRed
        Me.siInfo.ItemAppearance.Normal.Options.UseFont = True
        Me.siInfo.ItemAppearance.Normal.Options.UseForeColor = True
        Me.siInfo.Name = "siInfo"
        '
        'alignButtonGroup
        '
        Me.alignButtonGroup.Caption = "Align Commands"
        Me.alignButtonGroup.Id = 52
        Me.alignButtonGroup.ItemLinks.Add(Me.iBoldFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iItalicFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iUnderlinedFontStyle)
        Me.alignButtonGroup.Name = "alignButtonGroup"
        '
        'iBoldFontStyle
        '
        Me.iBoldFontStyle.Caption = "Bold"
        Me.iBoldFontStyle.Id = 53
        Me.iBoldFontStyle.ImageOptions.ImageIndex = 9
        Me.iBoldFontStyle.Name = "iBoldFontStyle"
        '
        'iItalicFontStyle
        '
        Me.iItalicFontStyle.Caption = "Italic"
        Me.iItalicFontStyle.Id = 54
        Me.iItalicFontStyle.ImageOptions.ImageIndex = 10
        Me.iItalicFontStyle.Name = "iItalicFontStyle"
        '
        'iUnderlinedFontStyle
        '
        Me.iUnderlinedFontStyle.Caption = "Underlined"
        Me.iUnderlinedFontStyle.Id = 55
        Me.iUnderlinedFontStyle.ImageOptions.ImageIndex = 11
        Me.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle"
        '
        'fontStyleButtonGroup
        '
        Me.fontStyleButtonGroup.Caption = "Font Style"
        Me.fontStyleButtonGroup.Id = 56
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iLeftTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iCenterTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iRightTextAlign)
        Me.fontStyleButtonGroup.Name = "fontStyleButtonGroup"
        '
        'iLeftTextAlign
        '
        Me.iLeftTextAlign.Caption = "Left"
        Me.iLeftTextAlign.Id = 57
        Me.iLeftTextAlign.ImageOptions.ImageIndex = 12
        Me.iLeftTextAlign.Name = "iLeftTextAlign"
        '
        'iCenterTextAlign
        '
        Me.iCenterTextAlign.Caption = "Center"
        Me.iCenterTextAlign.Id = 58
        Me.iCenterTextAlign.ImageOptions.ImageIndex = 13
        Me.iCenterTextAlign.Name = "iCenterTextAlign"
        '
        'iRightTextAlign
        '
        Me.iRightTextAlign.Caption = "Right"
        Me.iRightTextAlign.Id = 59
        Me.iRightTextAlign.ImageOptions.ImageIndex = 14
        Me.iRightTextAlign.Name = "iRightTextAlign"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        '
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = False
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 60
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'BarButtonGroup1
        '
        Me.BarButtonGroup1.Caption = "BarButtonGroup1"
        Me.BarButtonGroup1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonGroup1.Id = 63
        Me.BarButtonGroup1.Name = "BarButtonGroup1"
        '
        'BarButtonGroup2
        '
        Me.BarButtonGroup2.Caption = "BarButtonGroup2"
        Me.BarButtonGroup2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonGroup2.Id = 64
        Me.BarButtonGroup2.Name = "BarButtonGroup2"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem2.Id = 65
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarMdiChildrenListItem1
        '
        Me.BarMdiChildrenListItem1.Caption = "BarMdiChildrenListItem1"
        Me.BarMdiChildrenListItem1.Id = 66
        Me.BarMdiChildrenListItem1.Name = "BarMdiChildrenListItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sucursales"
        Me.BarButtonItem3.Id = 68
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.LargeWidth = 70
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.Tag = "frmCuentas"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Articles"
        Me.BarButtonItem4.Id = 69
        Me.BarButtonItem4.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.product_16x16
        Me.BarButtonItem4.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.product_32x32
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.Tag = "frmArticles"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Parts"
        Me.BarButtonItem5.Id = 70
        Me.BarButtonItem5.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.tag_16x16
        Me.BarButtonItem5.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.tag_32x32
        Me.BarButtonItem5.Name = "BarButtonItem5"
        Me.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Fabrics"
        Me.BarButtonItem6.Id = 71
        Me.BarButtonItem6.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.clip_16x16
        Me.BarButtonItem6.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.clip_32x32
        Me.BarButtonItem6.LargeWidth = 70
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Agregar"
        Me.btnAdd.Id = 72
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.Add_32x32
        Me.btnAdd.Name = "btnAdd"
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Editar"
        Me.btnEdit.Id = 73
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.Edit_32x32
        Me.btnEdit.Name = "btnEdit"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Borrar"
        Me.btnDelete.Id = 74
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.Delete_32x32
        Me.btnDelete.Name = "btnDelete"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Actualizar Datos"
        Me.btnRefresh.Id = 75
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.Refresh_32x32
        Me.btnRefresh.Name = "btnRefresh"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Salir del Sistema"
        Me.btnClose.Id = 76
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.close_32x32
        Me.btnClose.Name = "btnClose"
        '
        'btnList
        '
        Me.btnList.Caption = "List"
        Me.btnList.Id = 77
        Me.btnList.ImageOptions.Image = CType(resources.GetObject("btnList.ImageOptions.Image"), System.Drawing.Image)
        Me.btnList.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.Home_32x32
        Me.btnList.LargeWidth = 50
        Me.btnList.Name = "btnList"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Save"
        Me.BarButtonItem7.Id = 78
        Me.BarButtonItem7.ImageOptions.Image = CType(resources.GetObject("BarButtonItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem7.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.Save_32x32
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Save Close"
        Me.BarButtonItem8.Id = 79
        Me.BarButtonItem8.ImageOptions.Image = CType(resources.GetObject("BarButtonItem8.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem8.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.SaveAndClose_32x32
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Close"
        Me.BarButtonItem9.Id = 80
        Me.BarButtonItem9.ImageOptions.Image = CType(resources.GetObject("BarButtonItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem9.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.close_32x32
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 81
        Me.btnSave.Name = "btnSave"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Purchase Orders"
        Me.BarButtonItem10.Id = 82
        Me.BarButtonItem10.ImageOptions.Image = CType(resources.GetObject("BarButtonItem10.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem10.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem10.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem10.LargeWidth = 100
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "3-Production Planning"
        Me.BarButtonItem11.Id = 83
        Me.BarButtonItem11.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.design_16x16
        Me.BarButtonItem11.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.design_32x32
        Me.BarButtonItem11.LargeWidth = 120
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "1-Enlisting Production "
        Me.BarButtonItem12.Id = 84
        Me.BarButtonItem12.ImageOptions.Image = CType(resources.GetObject("BarButtonItem12.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem12.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem12.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem12.LargeWidth = 120
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "2-Production Check"
        Me.BarButtonItem13.Id = 85
        Me.BarButtonItem13.ImageOptions.Image = CType(resources.GetObject("BarButtonItem13.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem13.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem13.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem13.LargeWidth = 110
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Register Rolls"
        Me.BarButtonItem14.Id = 86
        Me.BarButtonItem14.ImageOptions.Image = CType(resources.GetObject("BarButtonItem14.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem14.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem14.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem14.LargeWidth = 78
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Rolls"
        Me.BarButtonItem17.Id = 90
        Me.BarButtonItem17.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.database_16x16
        Me.BarButtonItem17.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.database_32x32
        Me.BarButtonItem17.Name = "BarButtonItem17"
        Me.BarButtonItem17.Tag = "frmRolls"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Departamentos"
        Me.BarButtonItem18.Id = 91
        Me.BarButtonItem18.ImageOptions.Image = CType(resources.GetObject("BarButtonItem18.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem18.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem18.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem18.Name = "BarButtonItem18"
        Me.BarButtonItem18.Tag = "frmMonedas"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Areas"
        Me.BarButtonItem19.Id = 92
        Me.BarButtonItem19.ImageOptions.Image = CType(resources.GetObject("BarButtonItem19.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem19.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem19.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem19.Name = "BarButtonItem19"
        Me.BarButtonItem19.Tag = "frmTipoCuentas"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Cargos"
        Me.BarButtonItem20.Id = 93
        Me.BarButtonItem20.ImageOptions.Image = CType(resources.GetObject("BarButtonItem20.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem20.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem20.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem20.Name = "BarButtonItem20"
        Me.BarButtonItem20.Tag = "frmTipoDocumentos"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Requisition Order"
        Me.BarButtonItem21.Id = 94
        Me.BarButtonItem21.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.forcetesting_16x16
        Me.BarButtonItem21.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.forcetesting_32x32
        Me.BarButtonItem21.LargeWidth = 95
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Vista Previa"
        Me.btnPrint.Id = 95
        Me.btnPrint.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.preview_16x16
        Me.btnPrint.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.preview_32x32
        Me.btnPrint.LargeWidth = 60
        Me.btnPrint.Name = "btnPrint"
        '
        'btnExport
        '
        Me.btnExport.Caption = "Exportar Información"
        Me.btnExport.Id = 96
        Me.btnExport.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.exportfile_16x16
        Me.btnExport.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.exportfile_32x32
        Me.btnExport.LargeWidth = 50
        Me.btnExport.Name = "btnExport"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Process Order"
        Me.BarButtonItem23.Id = 101
        Me.BarButtonItem23.ImageOptions.Image = CType(resources.GetObject("BarButtonItem23.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem23.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem23.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem23.LargeWidth = 100
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Assigned Order"
        Me.BarButtonItem22.Id = 103
        Me.BarButtonItem22.ImageOptions.Image = CType(resources.GetObject("BarButtonItem22.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem22.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem22.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem22.LargeWidth = 90
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Request Orders "
        Me.BarButtonItem24.Id = 104
        Me.BarButtonItem24.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.parameters_16x16
        Me.BarButtonItem24.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.parameters_32x32
        Me.BarButtonItem24.LargeWidth = 95
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Cutting Ticket"
        Me.BarButtonItem25.Id = 105
        Me.BarButtonItem25.ImageOptions.Image = CType(resources.GetObject("BarButtonItem25.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem25.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem25.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem25.LargeWidth = 90
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "PO"
        Me.BarButtonItem26.Id = 106
        Me.BarButtonItem26.ImageOptions.Image = CType(resources.GetObject("BarButtonItem26.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem26.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem26.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Articles"
        Me.BarButtonItem27.Id = 107
        Me.BarButtonItem27.ImageOptions.Image = CType(resources.GetObject("BarButtonItem27.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem27.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem27.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.Caption = "Roles"
        Me.BarButtonItem28.Id = 108
        Me.BarButtonItem28.ImageOptions.Image = CType(resources.GetObject("BarButtonItem28.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem28.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem28.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem28.Name = "BarButtonItem28"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "Planilla"
        Me.BarButtonItem30.Id = 110
        Me.BarButtonItem30.ImageOptions.Image = CType(resources.GetObject("BarButtonItem30.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem30.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem30.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem30.Name = "BarButtonItem30"
        Me.BarButtonItem30.Tag = "frmReporteAuxiliar"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "Rolls"
        Me.BarButtonItem31.Id = 111
        Me.BarButtonItem31.ImageOptions.Image = CType(resources.GetObject("BarButtonItem31.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem31.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem31.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'bAnexos
        '
        Me.bAnexos.Caption = "Comparativo"
        Me.bAnexos.Id = 112
        Me.bAnexos.ImageOptions.Image = CType(resources.GetObject("bAnexos.ImageOptions.Image"), System.Drawing.Image)
        Me.bAnexos.ImageOptions.LargeImage = CType(resources.GetObject("bAnexos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bAnexos.Name = "bAnexos"
        Me.bAnexos.Tag = "frmReporteAnexos"
        '
        'bUsuario
        '
        Me.bUsuario.Caption = "Usuarios"
        Me.bUsuario.Id = 113
        Me.bUsuario.ImageOptions.Image = CType(resources.GetObject("bUsuario.ImageOptions.Image"), System.Drawing.Image)
        Me.bUsuario.ImageOptions.LargeImage = CType(resources.GetObject("bUsuario.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bUsuario.Name = "bUsuario"
        Me.bUsuario.Tag = "frmUsuarios"
        '
        'bTasa
        '
        Me.bTasa.Caption = "Profesiones"
        Me.bTasa.Id = 115
        Me.bTasa.ImageOptions.Image = CType(resources.GetObject("bTasa.ImageOptions.Image"), System.Drawing.Image)
        Me.bTasa.ImageOptions.LargeImage = CType(resources.GetObject("bTasa.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bTasa.Name = "bTasa"
        '
        'lblEstilo
        '
        Me.lblEstilo.Id = 117
        Me.lblEstilo.ImageOptions.Image = CType(resources.GetObject("lblEstilo.ImageOptions.Image"), System.Drawing.Image)
        Me.lblEstilo.Name = "lblEstilo"
        '
        'lblVersion
        '
        Me.lblVersion.Id = 118
        Me.lblVersion.ImageOptions.Image = CType(resources.GetObject("lblVersion.ImageOptions.Image"), System.Drawing.Image)
        Me.lblVersion.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red
        Me.lblVersion.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblVersion.Name = "lblVersion"
        '
        'lblUsuario
        '
        Me.lblUsuario.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblUsuario.Id = 119
        Me.lblUsuario.ImageOptions.Image = CType(resources.GetObject("lblUsuario.ImageOptions.Image"), System.Drawing.Image)
        Me.lblUsuario.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ItemAppearance.Normal.Options.UseFont = True
        Me.lblUsuario.Name = "lblUsuario"
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Organigrama"
        Me.BarButtonItem29.Id = 120
        Me.BarButtonItem29.ImageOptions.Image = CType(resources.GetObject("BarButtonItem29.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem29.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem29.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem29.Name = "BarButtonItem29"
        Me.BarButtonItem29.Tag = "frmPeriodos"
        '
        'BarButtonItem36
        '
        Me.BarButtonItem36.Caption = "Presupuesto"
        Me.BarButtonItem36.Id = 125
        Me.BarButtonItem36.ImageOptions.Image = CType(resources.GetObject("BarButtonItem36.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem36.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem36.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem36.Name = "BarButtonItem36"
        Me.BarButtonItem36.Tag = "frmPresupuesto"
        '
        'BarButtonItem37
        '
        Me.BarButtonItem37.Caption = "Razones Financieras"
        Me.BarButtonItem37.Id = 126
        Me.BarButtonItem37.ImageOptions.Image = CType(resources.GetObject("BarButtonItem37.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem37.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem37.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem37.Name = "BarButtonItem37"
        '
        'BarButtonItem39
        '
        Me.BarButtonItem39.Caption = "Importar Registros"
        Me.BarButtonItem39.Id = 129
        Me.BarButtonItem39.ImageOptions.Image = CType(resources.GetObject("BarButtonItem39.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem39.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem39.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem39.Name = "BarButtonItem39"
        '
        'BarButtonItem40
        '
        Me.BarButtonItem40.Caption = "LENAZO"
        Me.BarButtonItem40.Id = 130
        Me.BarButtonItem40.Name = "BarButtonItem40"
        '
        'BarButtonItem42
        '
        Me.BarButtonItem42.Caption = "Bases Distribucion"
        Me.BarButtonItem42.Id = 132
        Me.BarButtonItem42.ImageOptions.Image = CType(resources.GetObject("BarButtonItem42.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem42.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem42.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem42.Name = "BarButtonItem42"
        '
        'BarButtonItem43
        '
        Me.BarButtonItem43.Caption = "Articulos Costo"
        Me.BarButtonItem43.Id = 133
        Me.BarButtonItem43.ImageOptions.Image = CType(resources.GetObject("BarButtonItem43.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem43.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem43.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem43.Name = "BarButtonItem43"
        '
        'BarButtonItem41
        '
        Me.BarButtonItem41.Caption = "Cuentas Costos"
        Me.BarButtonItem41.Id = 134
        Me.BarButtonItem41.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.cellsautoheight__16x16
        Me.BarButtonItem41.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.cellsautoheight__32x32
        Me.BarButtonItem41.Name = "BarButtonItem41"
        '
        'BarButtonItem44
        '
        Me.BarButtonItem44.Caption = "Valores Relativos"
        Me.BarButtonItem44.Id = 135
        Me.BarButtonItem44.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.groupfieldcollection_16x16
        Me.BarButtonItem44.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.groupfieldcollection_32x32
        Me.BarButtonItem44.Name = "BarButtonItem44"
        '
        'BarButtonItem45
        '
        Me.BarButtonItem45.Caption = "Lista de Movimiento"
        Me.BarButtonItem45.Id = 136
        Me.BarButtonItem45.ImageOptions.Image = CType(resources.GetObject("BarButtonItem45.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem45.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem45.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem45.Name = "BarButtonItem45"
        '
        'bDocumentosFuentes
        '
        Me.bDocumentosFuentes.Caption = "Funciones"
        Me.bDocumentosFuentes.Id = 137
        Me.bDocumentosFuentes.ImageOptions.Image = CType(resources.GetObject("bDocumentosFuentes.ImageOptions.Image"), System.Drawing.Image)
        Me.bDocumentosFuentes.ImageOptions.LargeImage = CType(resources.GetObject("bDocumentosFuentes.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bDocumentosFuentes.Name = "bDocumentosFuentes"
        Me.bDocumentosFuentes.Tag = "frmDocumentosFuentes"
        '
        'BarButtonItem46
        '
        Me.BarButtonItem46.Caption = "Genera Comprobantes"
        Me.BarButtonItem46.Id = 138
        Me.BarButtonItem46.ImageOptions.Image = CType(resources.GetObject("BarButtonItem46.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem46.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem46.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem46.Name = "BarButtonItem46"
        '
        'BarButtonItem47
        '
        Me.BarButtonItem47.Caption = "Pistas de Auditoria"
        Me.BarButtonItem47.Id = 139
        Me.BarButtonItem47.ImageOptions.Image = CType(resources.GetObject("BarButtonItem47.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem47.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem47.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem47.Name = "BarButtonItem47"
        '
        'BarButtonItem48
        '
        Me.BarButtonItem48.Caption = "Cambiar Empresa"
        Me.BarButtonItem48.Id = 140
        Me.BarButtonItem48.ImageOptions.Image = CType(resources.GetObject("BarButtonItem48.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem48.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem48.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem48.Name = "BarButtonItem48"
        '
        'BarButtonItem49
        '
        Me.BarButtonItem49.Caption = "Master Kardex"
        Me.BarButtonItem49.Id = 141
        Me.BarButtonItem49.ImageOptions.Image = CType(resources.GetObject("BarButtonItem49.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem49.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem49.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem49.LargeWidth = 80
        Me.BarButtonItem49.Name = "BarButtonItem49"
        '
        'bBalanza
        '
        Me.bBalanza.Caption = "Horas Extras"
        Me.bBalanza.Id = 143
        Me.bBalanza.ImageOptions.Image = CType(resources.GetObject("bBalanza.ImageOptions.Image"), System.Drawing.Image)
        Me.bBalanza.ImageOptions.LargeImage = CType(resources.GetObject("bBalanza.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bBalanza.Name = "bBalanza"
        Me.bBalanza.Tag = "frmReporteBalanza"
        '
        'bCambiarPass
        '
        Me.bCambiarPass.Caption = "Cambiar Contraseña"
        Me.bCambiarPass.Id = 145
        Me.bCambiarPass.ImageOptions.Image = CType(resources.GetObject("bCambiarPass.ImageOptions.Image"), System.Drawing.Image)
        Me.bCambiarPass.ImageOptions.LargeImage = CType(resources.GetObject("bCambiarPass.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bCambiarPass.Name = "bCambiarPass"
        '
        'BarButtonItem51
        '
        Me.BarButtonItem51.Caption = "Fuentes"
        Me.BarButtonItem51.Id = 146
        Me.BarButtonItem51.ImageOptions.Image = Global.SysNominav3.My.Resources.Resources.editpagehf_16x16
        Me.BarButtonItem51.ImageOptions.LargeImage = Global.SysNominav3.My.Resources.Resources.editpagehf_32x32
        Me.BarButtonItem51.Name = "BarButtonItem51"
        '
        'bBalance
        '
        Me.bBalance.Caption = "Estado Cuenta Deducciones"
        Me.bBalance.Id = 147
        Me.bBalance.ImageOptions.Image = CType(resources.GetObject("bBalance.ImageOptions.Image"), System.Drawing.Image)
        Me.bBalance.ImageOptions.LargeImage = CType(resources.GetObject("bBalance.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bBalance.Name = "bBalance"
        Me.bBalance.Tag = "frmReporteBalanceGeneral"
        '
        'bEstadoResultado
        '
        Me.bEstadoResultado.Caption = "Consultas"
        Me.bEstadoResultado.Id = 148
        Me.bEstadoResultado.ImageOptions.Image = CType(resources.GetObject("bEstadoResultado.ImageOptions.Image"), System.Drawing.Image)
        Me.bEstadoResultado.ImageOptions.LargeImage = CType(resources.GetObject("bEstadoResultado.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bEstadoResultado.Name = "bEstadoResultado"
        Me.bEstadoResultado.Tag = "frmReporteEstadoResultado"
        '
        'bConfigurarBalance
        '
        Me.bConfigurarBalance.Caption = "Importar Archivos"
        Me.bConfigurarBalance.Id = 149
        Me.bConfigurarBalance.ImageOptions.Image = CType(resources.GetObject("bConfigurarBalance.ImageOptions.Image"), System.Drawing.Image)
        Me.bConfigurarBalance.ImageOptions.LargeImage = CType(resources.GetObject("bConfigurarBalance.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bConfigurarBalance.Name = "bConfigurarBalance"
        Me.bConfigurarBalance.Tag = "frmGruposBalance"
        '
        'BarButtonItem50
        '
        Me.BarButtonItem50.Caption = "Nivel Academico"
        Me.BarButtonItem50.Id = 151
        Me.BarButtonItem50.ImageOptions.Image = CType(resources.GetObject("BarButtonItem50.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem50.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem50.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem50.Name = "BarButtonItem50"
        Me.BarButtonItem50.Tag = "frmTipoPlantillas"
        '
        'BarButtonItem52
        '
        Me.BarButtonItem52.Caption = "Costo de Visceras"
        Me.BarButtonItem52.Id = 152
        Me.BarButtonItem52.ImageOptions.Image = CType(resources.GetObject("BarButtonItem52.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem52.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem52.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem52.Name = "BarButtonItem52"
        '
        'bCierreMes
        '
        Me.bCierreMes.Caption = "Antiguedad"
        Me.bCierreMes.Id = 153
        Me.bCierreMes.ImageOptions.Image = CType(resources.GetObject("bCierreMes.ImageOptions.Image"), System.Drawing.Image)
        Me.bCierreMes.ImageOptions.LargeImage = CType(resources.GetObject("bCierreMes.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bCierreMes.Name = "bCierreMes"
        Me.bCierreMes.Tag = "frmCierresList"
        '
        'bMovimientosContables
        '
        Me.bMovimientosContables.Caption = "Panel de Solicitudes"
        Me.bMovimientosContables.Id = 154
        Me.bMovimientosContables.ImageOptions.Image = CType(resources.GetObject("bMovimientosContables.ImageOptions.Image"), System.Drawing.Image)
        Me.bMovimientosContables.ImageOptions.LargeImage = CType(resources.GetObject("bMovimientosContables.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bMovimientosContables.Name = "bMovimientosContables"
        Me.bMovimientosContables.Tag = "frmDinamicoContable"
        '
        'bRazonesFinancieras
        '
        Me.bRazonesFinancieras.Caption = "Listado de Reportes"
        Me.bRazonesFinancieras.Id = 156
        Me.bRazonesFinancieras.ImageOptions.Image = CType(resources.GetObject("bRazonesFinancieras.ImageOptions.Image"), System.Drawing.Image)
        Me.bRazonesFinancieras.ImageOptions.LargeImage = CType(resources.GetObject("bRazonesFinancieras.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bRazonesFinancieras.Name = "bRazonesFinancieras"
        Me.bRazonesFinancieras.Tag = "frmRazonesFinancieras"
        '
        'BarButtonItem53
        '
        Me.BarButtonItem53.Caption = "Costos y Gastos Fijos y Variables"
        Me.BarButtonItem53.Id = 159
        Me.BarButtonItem53.ImageOptions.Image = CType(resources.GetObject("BarButtonItem53.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem53.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem53.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem53.Name = "BarButtonItem53"
        '
        'BarButtonItem55
        '
        Me.BarButtonItem55.Caption = "Catalogo"
        Me.BarButtonItem55.Id = 161
        Me.BarButtonItem55.ImageOptions.Image = CType(resources.GetObject("BarButtonItem55.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem55.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem55.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem55.Name = "BarButtonItem55"
        '
        'BarButtonItem56
        '
        Me.BarButtonItem56.Caption = "Pa&ises"
        Me.BarButtonItem56.Id = 162
        Me.BarButtonItem56.ImageOptions.Image = CType(resources.GetObject("BarButtonItem56.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem56.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem56.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem56.Name = "BarButtonItem56"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Pago de Aguinaldo"
        Me.BarButtonItem15.Id = 163
        Me.BarButtonItem15.ImageOptions.Image = CType(resources.GetObject("BarButtonItem15.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem15.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem15.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem32
        '
        Me.BarButtonItem32.Caption = "Pago de Vacaciones"
        Me.BarButtonItem32.Id = 164
        Me.BarButtonItem32.ImageOptions.Image = CType(resources.GetObject("BarButtonItem32.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem32.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem32.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem32.Name = "BarButtonItem32"
        '
        'BarButtonItem33
        '
        Me.BarButtonItem33.Caption = "Tasa Cambio"
        Me.BarButtonItem33.Id = 165
        Me.BarButtonItem33.ImageOptions.Image = CType(resources.GetObject("BarButtonItem33.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem33.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem33.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem33.Name = "BarButtonItem33"
        '
        'BarButtonItem34
        '
        Me.BarButtonItem34.Caption = "Monedas"
        Me.BarButtonItem34.Id = 166
        Me.BarButtonItem34.ImageOptions.Image = CType(resources.GetObject("BarButtonItem34.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem34.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem34.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem34.Name = "BarButtonItem34"
        '
        'BarButtonItem35
        '
        Me.BarButtonItem35.Caption = "Configuraciones"
        Me.BarButtonItem35.Id = 167
        Me.BarButtonItem35.ImageOptions.Image = CType(resources.GetObject("BarButtonItem35.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem35.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem35.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem35.Name = "BarButtonItem35"
        '
        'BarButtonItem38
        '
        Me.BarButtonItem38.Caption = "Horarios"
        Me.BarButtonItem38.Id = 168
        Me.BarButtonItem38.ImageOptions.Image = CType(resources.GetObject("BarButtonItem38.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem38.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem38.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem38.Name = "BarButtonItem38"
        '
        'BarButtonItem54
        '
        Me.BarButtonItem54.Caption = "Feriados"
        Me.BarButtonItem54.Id = 169
        Me.BarButtonItem54.ImageOptions.Image = CType(resources.GetObject("BarButtonItem54.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem54.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem54.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem54.Name = "BarButtonItem54"
        '
        'BarButtonItem57
        '
        Me.BarButtonItem57.Caption = "Constancias"
        Me.BarButtonItem57.Id = 170
        Me.BarButtonItem57.ImageOptions.Image = CType(resources.GetObject("BarButtonItem57.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem57.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem57.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem57.Name = "BarButtonItem57"
        '
        'BarButtonItem58
        '
        Me.BarButtonItem58.Caption = "Empleados"
        Me.BarButtonItem58.Id = 171
        Me.BarButtonItem58.ImageOptions.Image = CType(resources.GetObject("BarButtonItem58.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem58.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem58.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem58.Name = "BarButtonItem58"
        '
        'BarButtonItem59
        '
        Me.BarButtonItem59.Caption = "Cambio Salario Minimo"
        Me.BarButtonItem59.Id = 172
        Me.BarButtonItem59.ImageOptions.Image = CType(resources.GetObject("BarButtonItem59.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem59.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem59.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem59.Name = "BarButtonItem59"
        '
        'BarButtonItem60
        '
        Me.BarButtonItem60.Caption = "Periodos Nomina"
        Me.BarButtonItem60.Id = 173
        Me.BarButtonItem60.ImageOptions.Image = CType(resources.GetObject("BarButtonItem60.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem60.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem60.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem60.Name = "BarButtonItem60"
        '
        'BarButtonItem61
        '
        Me.BarButtonItem61.Caption = "Periodo Fiscal"
        Me.BarButtonItem61.Id = 174
        Me.BarButtonItem61.ImageOptions.Image = CType(resources.GetObject("BarButtonItem61.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem61.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem61.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem61.Name = "BarButtonItem61"
        '
        'BarButtonItem62
        '
        Me.BarButtonItem62.Caption = "Generar Movimientos"
        Me.BarButtonItem62.Id = 175
        Me.BarButtonItem62.ImageOptions.Image = CType(resources.GetObject("BarButtonItem62.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem62.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem62.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem62.Name = "BarButtonItem62"
        '
        'BarButtonItem63
        '
        Me.BarButtonItem63.Caption = "Generar Planilla"
        Me.BarButtonItem63.Id = 176
        Me.BarButtonItem63.ImageOptions.Image = CType(resources.GetObject("BarButtonItem63.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem63.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem63.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem63.Name = "BarButtonItem63"
        '
        'BarButtonItem64
        '
        Me.BarButtonItem64.Caption = "Revisar/Autorizar"
        Me.BarButtonItem64.Id = 177
        Me.BarButtonItem64.ImageOptions.Image = CType(resources.GetObject("BarButtonItem64.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem64.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem64.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem64.Name = "BarButtonItem64"
        '
        'BarButtonItem65
        '
        Me.BarButtonItem65.Caption = "Motivos de Baja"
        Me.BarButtonItem65.Id = 178
        Me.BarButtonItem65.ImageOptions.Image = CType(resources.GetObject("BarButtonItem65.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem65.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem65.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem65.Name = "BarButtonItem65"
        '
        'BarButtonItem66
        '
        Me.BarButtonItem66.Caption = "Tipos de Ingresos"
        Me.BarButtonItem66.Id = 179
        Me.BarButtonItem66.ImageOptions.Image = CType(resources.GetObject("BarButtonItem66.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem66.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem66.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem66.Name = "BarButtonItem66"
        '
        'BarButtonItem67
        '
        Me.BarButtonItem67.Caption = "Tipos de Deducciones"
        Me.BarButtonItem67.Id = 180
        Me.BarButtonItem67.ImageOptions.Image = CType(resources.GetObject("BarButtonItem67.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem67.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem67.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem67.Name = "BarButtonItem67"
        '
        'BarButtonItem69
        '
        Me.BarButtonItem69.Caption = "Bancos"
        Me.BarButtonItem69.Id = 182
        Me.BarButtonItem69.ImageOptions.Image = CType(resources.GetObject("BarButtonItem69.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem69.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem69.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem69.Name = "BarButtonItem69"
        '
        'BarButtonItem70
        '
        Me.BarButtonItem70.Caption = "Rubros de Empresa"
        Me.BarButtonItem70.Id = 183
        Me.BarButtonItem70.ImageOptions.Image = CType(resources.GetObject("BarButtonItem70.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem70.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem70.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem70.Name = "BarButtonItem70"
        '
        'BarButtonItem71
        '
        Me.BarButtonItem71.Caption = "Generar Horas Extras"
        Me.BarButtonItem71.Id = 184
        Me.BarButtonItem71.ImageOptions.Image = CType(resources.GetObject("BarButtonItem71.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem71.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem71.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem71.Name = "BarButtonItem71"
        '
        'BarButtonItem72
        '
        Me.BarButtonItem72.Caption = "Autorizar Horas Extras"
        Me.BarButtonItem72.Id = 185
        Me.BarButtonItem72.ImageOptions.Image = CType(resources.GetObject("BarButtonItem72.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem72.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem72.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem72.Name = "BarButtonItem72"
        '
        'BarButtonItem73
        '
        Me.BarButtonItem73.Caption = "Ingresos"
        Me.BarButtonItem73.Id = 188
        Me.BarButtonItem73.ImageOptions.Image = CType(resources.GetObject("BarButtonItem73.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem73.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem73.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem73.Name = "BarButtonItem73"
        '
        'BarButtonItem75
        '
        Me.BarButtonItem75.Caption = "Deducciones"
        Me.BarButtonItem75.Id = 189
        Me.BarButtonItem75.ImageOptions.Image = CType(resources.GetObject("BarButtonItem75.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem75.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem75.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem75.Name = "BarButtonItem75"
        '
        'BarButtonItem76
        '
        Me.BarButtonItem76.Caption = "Revisión"
        Me.BarButtonItem76.Id = 190
        Me.BarButtonItem76.ImageOptions.Image = CType(resources.GetObject("BarButtonItem76.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem76.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem76.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem76.Name = "BarButtonItem76"
        '
        'BarButtonItem77
        '
        Me.BarButtonItem77.Caption = "Aprobación"
        Me.BarButtonItem77.Id = 191
        Me.BarButtonItem77.ImageOptions.Image = CType(resources.GetObject("BarButtonItem77.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem77.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem77.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem77.Name = "BarButtonItem77"
        '
        'BarButtonItem78
        '
        Me.BarButtonItem78.Caption = "Liquidación"
        Me.BarButtonItem78.Id = 192
        Me.BarButtonItem78.ImageOptions.Image = CType(resources.GetObject("BarButtonItem78.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem78.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem78.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem78.Name = "BarButtonItem78"
        '
        'BarButtonItem79
        '
        Me.BarButtonItem79.Caption = "Permisos"
        Me.BarButtonItem79.Id = 193
        Me.BarButtonItem79.ImageOptions.Image = CType(resources.GetObject("BarButtonItem79.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem79.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem79.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem79.Name = "BarButtonItem79"
        '
        'BarButtonItem80
        '
        Me.BarButtonItem80.Caption = "Reportes"
        Me.BarButtonItem80.Id = 194
        Me.BarButtonItem80.ImageOptions.Image = CType(resources.GetObject("BarButtonItem80.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem80.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem80.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem80.Name = "BarButtonItem80"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        '
        'rCatalogo
        '
        Me.rCatalogo.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup7})
        Me.rCatalogo.Name = "rCatalogo"
        Me.rCatalogo.Text = "Catalogos"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem18)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem19)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem20)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.bDocumentosFuentes)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.bTasa)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem56)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem50)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.bCierreMes)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Catalogos Genereales"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem29)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem55)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Contables"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem38)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem54)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem57)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Laborales"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem66)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem67)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Tipos de Movimientos"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Personal"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem58)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem59)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem79)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Empleados"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup10, Me.RibbonPageGroup5})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Planilla"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.AllowTextClipping = False
        Me.RibbonPageGroup10.ItemLinks.Add(Me.BarButtonItem73)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.BarButtonItem75)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.ShowCaptionButton = False
        Me.RibbonPageGroup10.Text = "Movimientos"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem60)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem61)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem62)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem63)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem64)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Nomina"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup8, Me.RibbonPageGroup9, Me.RibbonPageGroup11})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Procesos"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem71)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem72)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Horas Extras"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.BarButtonItem32)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.BarButtonItem15)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.ShowCaptionButton = False
        Me.RibbonPageGroup9.Text = "Prestaciones"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.AllowTextClipping = False
        Me.RibbonPageGroup11.ItemLinks.Add(Me.BarButtonItem76)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.BarButtonItem77)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.BarButtonItem78)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.BarButtonItem80)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        Me.RibbonPageGroup11.ShowCaptionButton = False
        Me.RibbonPageGroup11.Text = "Baja de Empleado"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup14, Me.RibbonPageGroup17})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Reportes"
        '
        'RibbonPageGroup14
        '
        Me.RibbonPageGroup14.AllowTextClipping = False
        Me.RibbonPageGroup14.ItemLinks.Add(Me.BarButtonItem30)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.bAnexos)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.bBalanza)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.bBalance)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.bEstadoResultado)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.bRazonesFinancieras)
        Me.RibbonPageGroup14.Name = "RibbonPageGroup14"
        Me.RibbonPageGroup14.ShowCaptionButton = False
        Me.RibbonPageGroup14.Text = "Reportes"
        '
        'RibbonPageGroup17
        '
        Me.RibbonPageGroup17.AllowTextClipping = False
        Me.RibbonPageGroup17.ItemLinks.Add(Me.bMovimientosContables)
        Me.RibbonPageGroup17.Name = "RibbonPageGroup17"
        Me.RibbonPageGroup17.ShowCaptionButton = False
        Me.RibbonPageGroup17.Text = "Solicitudes"
        '
        'homeRibbonPage
        '
        Me.homeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup12, Me.RibbonPageGroup2, Me.skinsRibbonPageGroup})
        Me.homeRibbonPage.Name = "homeRibbonPage"
        Me.homeRibbonPage.Text = "Herramientas"
        '
        'RibbonPageGroup12
        '
        Me.RibbonPageGroup12.AllowTextClipping = False
        Me.RibbonPageGroup12.ItemLinks.Add(Me.BarButtonItem48)
        Me.RibbonPageGroup12.ItemLinks.Add(Me.BarButtonItem16)
        Me.RibbonPageGroup12.ItemLinks.Add(Me.bConfigurarBalance)
        Me.RibbonPageGroup12.Name = "RibbonPageGroup12"
        Me.RibbonPageGroup12.ShowCaptionButton = False
        Me.RibbonPageGroup12.Text = "Herramientas"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem69)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem34)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem33)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem65)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem70)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem35)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Configuraciones"
        '
        'skinsRibbonPageGroup
        '
        Me.skinsRibbonPageGroup.AllowTextClipping = False
        Me.skinsRibbonPageGroup.ItemLinks.Add(Me.rgbiSkins)
        Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
        Me.skinsRibbonPageGroup.ShowCaptionButton = False
        Me.skinsRibbonPageGroup.Text = "Estilos"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup15})
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Text = "Seguridad"
        '
        'RibbonPageGroup15
        '
        Me.RibbonPageGroup15.AllowTextClipping = False
        Me.RibbonPageGroup15.ItemLinks.Add(Me.bUsuario)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.BarButtonItem28)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.bCambiarPass)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.BarButtonItem47)
        Me.RibbonPageGroup15.Name = "RibbonPageGroup15"
        Me.RibbonPageGroup15.ShowCaptionButton = False
        Me.RibbonPageGroup15.Text = "Banco"
        '
        'helpRibbonPage
        '
        Me.helpRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.helpRibbonPageGroup})
        Me.helpRibbonPage.Name = "helpRibbonPage"
        Me.helpRibbonPage.Text = "Ayuda"
        '
        'helpRibbonPageGroup
        '
        Me.helpRibbonPageGroup.ItemLinks.Add(Me.iHelp)
        Me.helpRibbonPageGroup.ItemLinks.Add(Me.iAbout)
        Me.helpRibbonPageGroup.Name = "helpRibbonPageGroup"
        Me.helpRibbonPageGroup.ShowCaptionButton = False
        Me.helpRibbonPageGroup.Text = "Ayuda"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.siStatus)
        Me.ribbonStatusBar.ItemLinks.Add(Me.lblUsuario)
        Me.ribbonStatusBar.ItemLinks.Add(Me.siInfo)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 434)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1025, 31)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.Images = Me.navbarImageCollection
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Customers"
        Me.BarButtonItem1.Id = 62
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.LargeWidth = 65
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'iNew
        '
        Me.iNew.Caption = "Configurations"
        Me.iNew.Description = "Creates a new, blank file."
        Me.iNew.Hint = "Creates a new, blank file"
        Me.iNew.Id = 1
        Me.iNew.ImageOptions.Image = CType(resources.GetObject("iNew.ImageOptions.Image"), System.Drawing.Image)
        Me.iNew.ImageOptions.ImageIndex = 0
        Me.iNew.ImageOptions.LargeImage = CType(resources.GetObject("iNew.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.iNew.ImageOptions.LargeImageIndex = 0
        Me.iNew.Name = "iNew"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(845, 446)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl1.TabIndex = 14
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 465)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "SysNomina v3.0.0.1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents siStatus As DevExpress.XtraBars.BarStaticItem
    Private WithEvents siInfo As DevExpress.XtraBars.BarStaticItem
    Private WithEvents homeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents alignButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iBoldFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iItalicFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iUnderlinedFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents fontStyleButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iLeftTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iCenterTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iRightTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents helpRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents helpRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents iHelp As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents rCatalogo As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarMdiChildrenListItem1 As DevExpress.XtraBars.BarMdiChildrenListItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup14 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bAnexos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bTasa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblEstilo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblVersion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblUsuario As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup15 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem36 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem37 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem39 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem40 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem42 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem43 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem41 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem44 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem45 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bDocumentosFuentes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem46 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem47 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem48 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem49 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bBalanza As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bCambiarPass As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem51 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bBalance As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bEstadoResultado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bConfigurarBalance As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem50 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem52 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bCierreMes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bMovimientosContables As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup17 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bRazonesFinancieras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem53 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem55 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem56 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem32 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem33 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem34 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem35 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem38 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem54 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem57 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem58 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem59 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem60 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem61 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem62 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem63 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem64 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem65 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem66 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem67 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem69 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem70 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem71 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem72 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem73 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem75 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem76 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem77 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem78 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem79 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem80 As DevExpress.XtraBars.BarButtonItem

End Class
