<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPlanilla
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGPlanilla))
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.dgPeriodoNomina = New DevExpress.XtraGrid.GridControl()
        Me.vPlanillas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtEnvio = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCaldera = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsolidado = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXMLINSS = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFirmasPlanilla = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBAC = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVerFichas = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEmail = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdIRSairi = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVisor = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGenFirme = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.Location = New System.Drawing.Point(12, 12)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(839, 20)
        Me.chkTodos.TabIndex = 120
        Me.chkTodos.Text = "&Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'dgPeriodoNomina
        '
        Me.dgPeriodoNomina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPeriodoNomina.Location = New System.Drawing.Point(12, 36)
        Me.dgPeriodoNomina.MainView = Me.vPlanillas
        Me.dgPeriodoNomina.Name = "dgPeriodoNomina"
        Me.dgPeriodoNomina.Size = New System.Drawing.Size(839, 503)
        Me.dgPeriodoNomina.TabIndex = 121
        Me.dgPeriodoNomina.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vPlanillas})
        '
        'vPlanillas
        '
        Me.vPlanillas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.vPlanillas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vPlanillas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vPlanillas.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.vPlanillas.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.vPlanillas.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vPlanillas.Appearance.Empty.Options.UseBackColor = True
        Me.vPlanillas.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.vPlanillas.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.vPlanillas.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.vPlanillas.Appearance.EvenRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.vPlanillas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.vPlanillas.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vPlanillas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vPlanillas.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.vPlanillas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.vPlanillas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vPlanillas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vPlanillas.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vPlanillas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupButton.Options.UseBackColor = True
        Me.vPlanillas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vPlanillas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.vPlanillas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vPlanillas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vPlanillas.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.vPlanillas.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vPlanillas.Appearance.GroupRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.GroupRow.Options.UseFont = True
        Me.vPlanillas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.vPlanillas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.vPlanillas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.vPlanillas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.vPlanillas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.vPlanillas.Appearance.HorzLine.Options.UseBackColor = True
        Me.vPlanillas.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.OddRow.Options.UseBackColor = True
        Me.vPlanillas.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.vPlanillas.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.vPlanillas.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.vPlanillas.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vPlanillas.Appearance.Preview.Options.UseBackColor = True
        Me.vPlanillas.Appearance.Preview.Options.UseFont = True
        Me.vPlanillas.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.vPlanillas.Appearance.Row.Options.UseBackColor = True
        Me.vPlanillas.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.vPlanillas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vPlanillas.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.vPlanillas.Appearance.VertLine.Options.UseBackColor = True
        Me.vPlanillas.GridControl = Me.dgPeriodoNomina
        Me.vPlanillas.Name = "vPlanillas"
        Me.vPlanillas.OptionsBehavior.Editable = False
        Me.vPlanillas.OptionsView.EnableAppearanceEvenRow = True
        Me.vPlanillas.OptionsView.EnableAppearanceOddRow = True
        Me.vPlanillas.OptionsView.ShowAutoFilterRow = True
        Me.vPlanillas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vPlanillas.OptionsView.ShowGroupPanel = False
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 543)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(839, 20)
        Me.GridControl1.TabIndex = 123
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.GridControl1.Visible = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtEnvio)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.dgPeriodoNomina)
        Me.LayoutControl1.Controls.Add(Me.chkTodos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(668, 394, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(863, 592)
        Me.LayoutControl1.TabIndex = 124
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtEnvio
        '
        Me.txtEnvio.Location = New System.Drawing.Point(12, 567)
        Me.txtEnvio.Name = "txtEnvio"
        Me.txtEnvio.Size = New System.Drawing.Size(136, 13)
        Me.txtEnvio.StyleController = Me.LayoutControl1
        Me.txtEnvio.TabIndex = 124
        Me.txtEnvio.Text = "Enviado correo al empleado:"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem17})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(863, 592)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 531)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(843, 24)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        Me.LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dgPeriodoNomina
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(843, 507)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkTodos
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(843, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtEnvio
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 555)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(843, 17)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("05537fe1-1876-4136-9942-716fa4f6ef19")
        Me.DockPanel1.Location = New System.Drawing.Point(863, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 592)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 565)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton12)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton11)
        Me.LayoutControl2.Controls.Add(Me.cmdCaldera)
        Me.LayoutControl2.Controls.Add(Me.btnConsolidado)
        Me.LayoutControl2.Controls.Add(Me.btnXMLINSS)
        Me.LayoutControl2.Controls.Add(Me.btnFirmasPlanilla)
        Me.LayoutControl2.Controls.Add(Me.btnBAC)
        Me.LayoutControl2.Controls.Add(Me.cmdVerFichas)
        Me.LayoutControl2.Controls.Add(Me.btnEmail)
        Me.LayoutControl2.Controls.Add(Me.cmdIRSairi)
        Me.LayoutControl2.Controls.Add(Me.cmdVisor)
        Me.LayoutControl2.Controls.Add(Me.cmdGenFirme)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1204, 463, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(141, 565)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Appearance.Options.UseTextOptions = True
        Me.SimpleButton12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton12.ImageOptions.Image = CType(resources.GetObject("SimpleButton12.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton12.Location = New System.Drawing.Point(12, 456)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(118, 38)
        Me.SimpleButton12.StyleController = Me.LayoutControl2
        Me.SimpleButton12.TabIndex = 127
        Me.SimpleButton12.Text = "E&xportar"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Appearance.Options.UseTextOptions = True
        Me.SimpleButton11.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton11.ImageOptions.Image = CType(resources.GetObject("SimpleButton11.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton11.Location = New System.Drawing.Point(12, 498)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(118, 38)
        Me.SimpleButton11.StyleController = Me.LayoutControl2
        Me.SimpleButton11.TabIndex = 126
        Me.SimpleButton11.Text = "&Salir"
        '
        'cmdCaldera
        '
        Me.cmdCaldera.Appearance.Options.UseTextOptions = True
        Me.cmdCaldera.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdCaldera.ImageOptions.Image = CType(resources.GetObject("cmdCaldera.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCaldera.Location = New System.Drawing.Point(12, 414)
        Me.cmdCaldera.Name = "cmdCaldera"
        Me.cmdCaldera.Size = New System.Drawing.Size(118, 38)
        Me.cmdCaldera.StyleController = Me.LayoutControl2
        Me.cmdCaldera.TabIndex = 126
        Me.cmdCaldera.Text = "Consolidado + &Liquidación"
        '
        'btnConsolidado
        '
        Me.btnConsolidado.Appearance.Options.UseTextOptions = True
        Me.btnConsolidado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnConsolidado.ImageOptions.Image = CType(resources.GetObject("btnConsolidado.ImageOptions.Image"), System.Drawing.Image)
        Me.btnConsolidado.Location = New System.Drawing.Point(12, 372)
        Me.btnConsolidado.Name = "btnConsolidado"
        Me.btnConsolidado.Size = New System.Drawing.Size(118, 38)
        Me.btnConsolidado.StyleController = Me.LayoutControl2
        Me.btnConsolidado.TabIndex = 126
        Me.btnConsolidado.Text = "Con&solidado"
        '
        'btnXMLINSS
        '
        Me.btnXMLINSS.Appearance.Options.UseTextOptions = True
        Me.btnXMLINSS.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnXMLINSS.ImageOptions.Image = CType(resources.GetObject("btnXMLINSS.ImageOptions.Image"), System.Drawing.Image)
        Me.btnXMLINSS.Location = New System.Drawing.Point(12, 306)
        Me.btnXMLINSS.Name = "btnXMLINSS"
        Me.btnXMLINSS.Size = New System.Drawing.Size(118, 38)
        Me.btnXMLINSS.StyleController = Me.LayoutControl2
        Me.btnXMLINSS.TabIndex = 11
        Me.btnXMLINSS.Text = "Ge&nerar XML INSS"
        '
        'btnFirmasPlanilla
        '
        Me.btnFirmasPlanilla.Appearance.Options.UseTextOptions = True
        Me.btnFirmasPlanilla.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnFirmasPlanilla.ImageOptions.Image = CType(resources.GetObject("btnFirmasPlanilla.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFirmasPlanilla.Location = New System.Drawing.Point(12, 264)
        Me.btnFirmasPlanilla.Name = "btnFirmasPlanilla"
        Me.btnFirmasPlanilla.Size = New System.Drawing.Size(118, 38)
        Me.btnFirmasPlanilla.StyleController = Me.LayoutControl2
        Me.btnFirmasPlanilla.TabIndex = 10
        Me.btnFirmasPlanilla.Text = "&Firmas de Planilla"
        '
        'btnBAC
        '
        Me.btnBAC.Appearance.Options.UseTextOptions = True
        Me.btnBAC.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBAC.ImageOptions.Image = CType(resources.GetObject("btnBAC.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBAC.Location = New System.Drawing.Point(12, 222)
        Me.btnBAC.Name = "btnBAC"
        Me.btnBAC.Size = New System.Drawing.Size(118, 38)
        Me.btnBAC.StyleController = Me.LayoutControl2
        Me.btnBAC.TabIndex = 9
        Me.btnBAC.Text = "Generar &Archivo Elec."
        '
        'cmdVerFichas
        '
        Me.cmdVerFichas.Appearance.Options.UseTextOptions = True
        Me.cmdVerFichas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdVerFichas.ImageOptions.Image = CType(resources.GetObject("cmdVerFichas.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVerFichas.Location = New System.Drawing.Point(12, 180)
        Me.cmdVerFichas.Name = "cmdVerFichas"
        Me.cmdVerFichas.Size = New System.Drawing.Size(118, 38)
        Me.cmdVerFichas.StyleController = Me.LayoutControl2
        Me.cmdVerFichas.TabIndex = 8
        Me.cmdVerFichas.Text = "&Colilla de Pago"
        '
        'btnEmail
        '
        Me.btnEmail.Appearance.Options.UseTextOptions = True
        Me.btnEmail.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnEmail.ImageOptions.Image = CType(resources.GetObject("btnEmail.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEmail.Location = New System.Drawing.Point(12, 138)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(118, 38)
        Me.btnEmail.StyleController = Me.LayoutControl2
        Me.btnEmail.TabIndex = 7
        Me.btnEmail.Text = "&Enviar Colilla"
        '
        'cmdIRSairi
        '
        Me.cmdIRSairi.Appearance.Options.UseTextOptions = True
        Me.cmdIRSairi.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdIRSairi.ImageOptions.Image = CType(resources.GetObject("cmdIRSairi.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdIRSairi.Location = New System.Drawing.Point(12, 96)
        Me.cmdIRSairi.Name = "cmdIRSairi"
        Me.cmdIRSairi.Size = New System.Drawing.Size(118, 38)
        Me.cmdIRSairi.StyleController = Me.LayoutControl2
        Me.cmdIRSairi.TabIndex = 6
        Me.cmdIRSairi.Text = "&Generar IR"
        '
        'cmdVisor
        '
        Me.cmdVisor.Appearance.Options.UseTextOptions = True
        Me.cmdVisor.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdVisor.ImageOptions.Image = CType(resources.GetObject("cmdVisor.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVisor.Location = New System.Drawing.Point(12, 54)
        Me.cmdVisor.Name = "cmdVisor"
        Me.cmdVisor.Size = New System.Drawing.Size(118, 38)
        Me.cmdVisor.StyleController = Me.LayoutControl2
        Me.cmdVisor.TabIndex = 5
        Me.cmdVisor.Text = "&Ver Planilla"
        '
        'cmdGenFirme
        '
        Me.cmdGenFirme.Appearance.Options.UseTextOptions = True
        Me.cmdGenFirme.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdGenFirme.ImageOptions.Image = CType(resources.GetObject("cmdGenFirme.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGenFirme.Location = New System.Drawing.Point(12, 12)
        Me.cmdGenFirme.Name = "cmdGenFirme"
        Me.cmdGenFirme.Size = New System.Drawing.Size(118, 38)
        Me.cmdGenFirme.StyleController = Me.LayoutControl2
        Me.cmdGenFirme.TabIndex = 4
        Me.cmdGenFirme.Text = "&Generar Planilla"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(142, 548)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdGenFirme
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdVisor
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdIRSairi
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnEmail
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdVerFichas
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnBAC
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnFirmasPlanilla
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnXMLINSS
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnConsolidado
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 360)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdCaldera
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 402)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SimpleButton11
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 486)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.SimpleButton12
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 444)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 336)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(122, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmGPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 592)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmGPlanilla"
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents dgPeriodoNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents vPlanillas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnXMLINSS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFirmasPlanilla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBAC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVerFichas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEmail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdIRSairi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVisor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGenFirme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCaldera As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsolidado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtEnvio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
End Class
