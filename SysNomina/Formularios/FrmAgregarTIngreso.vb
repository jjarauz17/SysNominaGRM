Public Class frmAgregarTIngreso
    Inherits System.Windows.Forms.Form


    Private Shared ChildInstance As frmAgregarTIngreso = Nothing
#Region "Calaches"
    Friend WithEvents cbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
#End Region

#Region "Variables"
    Private HEnt As String, HSal As String, LCodigo As String
    Friend WithEvents chkValorFijo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckbGravable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckbINSS As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkAguinaldo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkVacaciones As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkIndemnizacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents frmAgregarTIngresoConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents vLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTIngreso As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbTDeduccion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtsufijo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtprefijo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lcFactor As DevExpress.XtraLayout.LayoutControlItem
    Dim Detalles As VB.SysContab.TipoIngresoDetails
#End Region

    Public Shared Function Instance() As frmAgregarTIngreso
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarTIngreso()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem17 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem9 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem18 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem3 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem4 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem5 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem11 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem6 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem12 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem13 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem7 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem14 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem15 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem8 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem16 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.cbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.frmAgregarTIngresoConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit()
        Me.txtsufijo = New DevExpress.XtraEditors.TextEdit()
        Me.txtprefijo = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.vLista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbTIngreso = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbTDeduccion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkIndemnizacion = New DevExpress.XtraEditors.CheckEdit()
        Me.ckbINSS = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.ChkVacaciones = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkAguinaldo = New DevExpress.XtraEditors.CheckEdit()
        Me.ckbGravable = New DevExpress.XtraEditors.CheckEdit()
        Me.chkValorFijo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcFactor = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmAgregarTIngresoConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAgregarTIngresoConvertedLayout.SuspendLayout()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsufijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprefijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIndemnizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckbINSS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkVacaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAguinaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckbGravable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkValorFijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbTipo
        '
        Me.cbTipo.Location = New System.Drawing.Point(238, 60)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo.Properties.NullText = ""
        Me.cbTipo.Size = New System.Drawing.Size(328, 20)
        Me.cbTipo.StyleController = Me.frmAgregarTIngresoConvertedLayout
        ToolTipTitleItem17.Text = "Sts.Nomina"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Forma de Calcular las Cuotas de los Ingresos"
        ToolTipTitleItem18.LeftIndent = 6
        ToolTipTitleItem18.Text = "Ver la Ayuda para más información"
        SuperToolTip9.Items.Add(ToolTipTitleItem17)
        SuperToolTip9.Items.Add(ToolTipItem9)
        SuperToolTip9.Items.Add(ToolTipSeparatorItem9)
        SuperToolTip9.Items.Add(ToolTipTitleItem18)
        Me.cbTipo.SuperTip = SuperToolTip9
        Me.cbTipo.TabIndex = 144
        '
        'frmAgregarTIngresoConvertedLayout
        '
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.CalcEdit1)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.txtsufijo)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.txtprefijo)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.GridControl1)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.cmdAceptar)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.cmdCancelar)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.chkIndemnizacion)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.ckbINSS)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.txtDescripcion)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.ChkVacaciones)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.ChkAguinaldo)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.ckbGravable)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.chkValorFijo)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.cbTipo)
        Me.frmAgregarTIngresoConvertedLayout.Controls.Add(Me.txtCodigo)
        Me.frmAgregarTIngresoConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAgregarTIngresoConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAgregarTIngresoConvertedLayout.Name = "frmAgregarTIngresoConvertedLayout"
        Me.frmAgregarTIngresoConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAgregarTIngresoConvertedLayout.Size = New System.Drawing.Size(578, 416)
        Me.frmAgregarTIngresoConvertedLayout.TabIndex = 151
        '
        'CalcEdit1
        '
        Me.CalcEdit1.Location = New System.Drawing.Point(238, 201)
        Me.CalcEdit1.Name = "CalcEdit1"
        Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit1.Size = New System.Drawing.Size(182, 20)
        Me.CalcEdit1.StyleController = Me.frmAgregarTIngresoConvertedLayout
        Me.CalcEdit1.TabIndex = 156
        '
        'txtsufijo
        '
        Me.txtsufijo.Location = New System.Drawing.Point(238, 177)
        Me.txtsufijo.Name = "txtsufijo"
        Me.txtsufijo.Size = New System.Drawing.Size(182, 20)
        Me.txtsufijo.StyleController = Me.frmAgregarTIngresoConvertedLayout
        Me.txtsufijo.TabIndex = 155
        '
        'txtprefijo
        '
        Me.txtprefijo.Location = New System.Drawing.Point(238, 153)
        Me.txtprefijo.Name = "txtprefijo"
        Me.txtprefijo.Size = New System.Drawing.Size(182, 20)
        Me.txtprefijo.StyleController = Me.frmAgregarTIngresoConvertedLayout
        Me.txtprefijo.TabIndex = 154
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 256)
        Me.GridControl1.MainView = Me.vLista
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbTIngreso, Me.cbTDeduccion})
        Me.GridControl1.Size = New System.Drawing.Size(554, 122)
        Me.GridControl1.TabIndex = 153
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vLista})
        '
        'vLista
        '
        Me.vLista.GridControl = Me.GridControl1
        Me.vLista.Name = "vLista"
        Me.vLista.OptionsSelection.MultiSelect = True
        Me.vLista.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vLista.OptionsView.ShowAutoFilterRow = True
        Me.vLista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vLista.OptionsView.ShowFooter = True
        Me.vLista.OptionsView.ShowGroupPanel = False
        '
        'cbTIngreso
        '
        Me.cbTIngreso.AutoHeight = False
        Me.cbTIngreso.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTIngreso.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "TipoIngreso")})
        Me.cbTIngreso.Name = "cbTIngreso"
        Me.cbTIngreso.NullText = "[Seleccione Tipo de Ingreso]"
        '
        'cbTDeduccion
        '
        Me.cbTDeduccion.AutoHeight = False
        Me.cbTDeduccion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTDeduccion.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "TipoDeduccion")})
        Me.cbTDeduccion.Name = "cbTDeduccion"
        Me.cbTDeduccion.NullText = "[Seleccion el Tipo de Deduccion]"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(386, 382)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(88, 22)
        Me.cmdAceptar.StyleController = Me.frmAgregarTIngresoConvertedLayout
        Me.cmdAceptar.TabIndex = 152
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(478, 382)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(88, 22)
        Me.cmdCancelar.StyleController = Me.frmAgregarTIngresoConvertedLayout
        Me.cmdCancelar.TabIndex = 151
        Me.cmdCancelar.Text = "Salir"
        '
        'chkIndemnizacion
        '
        Me.chkIndemnizacion.Location = New System.Drawing.Point(135, 130)
        Me.chkIndemnizacion.Name = "chkIndemnizacion"
        Me.chkIndemnizacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.chkIndemnizacion.Properties.Appearance.Options.UseFont = True
        Me.chkIndemnizacion.Properties.Caption = "Agregar al Cálculo de Indemnizacion"
        Me.chkIndemnizacion.Size = New System.Drawing.Size(285, 19)
        Me.chkIndemnizacion.StyleController = Me.frmAgregarTIngresoConvertedLayout
        ToolTipTitleItem1.Text = "Sts.Nomina"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Marca el Ingreso como parte de los cálculos para el pago de las Vacaciones"
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "Ver la Ayuda para más información"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.chkIndemnizacion.SuperTip = SuperToolTip1
        Me.chkIndemnizacion.TabIndex = 150
        '
        'ckbINSS
        '
        Me.ckbINSS.Location = New System.Drawing.Point(12, 130)
        Me.ckbINSS.Name = "ckbINSS"
        Me.ckbINSS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ckbINSS.Properties.Appearance.Options.UseFont = True
        Me.ckbINSS.Properties.Caption = "Gravable INSS"
        Me.ckbINSS.Size = New System.Drawing.Size(119, 19)
        Me.ckbINSS.StyleController = Me.frmAgregarTIngresoConvertedLayout
        ToolTipTitleItem3.Text = "Sts.Nomina"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Marca el Tipo de Ingreso como Gravable por la Aportación al INSS"
        ToolTipTitleItem4.LeftIndent = 6
        ToolTipTitleItem4.Text = "Ver la Ayuda para más información"
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        SuperToolTip2.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip2.Items.Add(ToolTipTitleItem4)
        Me.ckbINSS.SuperTip = SuperToolTip2
        Me.ckbINSS.TabIndex = 147
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(238, 36)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.MaxLength = 50
        Me.txtDescripcion.Size = New System.Drawing.Size(328, 20)
        Me.txtDescripcion.StyleController = Me.frmAgregarTIngresoConvertedLayout
        ToolTipTitleItem5.Text = "Sts.Nomina"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Descripción del nuevo Tipo de Ingreso en Nómina"
        ToolTipTitleItem6.LeftIndent = 6
        ToolTipTitleItem6.Text = "Ver la Ayuda para más información"
        SuperToolTip3.Items.Add(ToolTipTitleItem5)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem3)
        SuperToolTip3.Items.Add(ToolTipTitleItem6)
        Me.txtDescripcion.SuperTip = SuperToolTip3
        Me.txtDescripcion.TabIndex = 143
        '
        'ChkVacaciones
        '
        Me.ChkVacaciones.Location = New System.Drawing.Point(135, 107)
        Me.ChkVacaciones.Name = "ChkVacaciones"
        Me.ChkVacaciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ChkVacaciones.Properties.Appearance.Options.UseFont = True
        Me.ChkVacaciones.Properties.Caption = "Agregar al Cálculo Vacaciones"
        Me.ChkVacaciones.Size = New System.Drawing.Size(285, 19)
        Me.ChkVacaciones.StyleController = Me.frmAgregarTIngresoConvertedLayout
        ToolTipTitleItem7.Text = "Sts.Nomina"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Marca el Ingreso como parte de los cálculos para el pago de las Vacaciones"
        ToolTipTitleItem8.LeftIndent = 6
        ToolTipTitleItem8.Text = "Ver la Ayuda para más información"
        SuperToolTip4.Items.Add(ToolTipTitleItem7)
        SuperToolTip4.Items.Add(ToolTipItem4)
        SuperToolTip4.Items.Add(ToolTipSeparatorItem4)
        SuperToolTip4.Items.Add(ToolTipTitleItem8)
        Me.ChkVacaciones.SuperTip = SuperToolTip4
        Me.ChkVacaciones.TabIndex = 149
        '
        'ChkAguinaldo
        '
        Me.ChkAguinaldo.Location = New System.Drawing.Point(135, 84)
        Me.ChkAguinaldo.Name = "ChkAguinaldo"
        Me.ChkAguinaldo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ChkAguinaldo.Properties.Appearance.Options.UseFont = True
        Me.ChkAguinaldo.Properties.Caption = "Agregar al Cálculo Aguinaldo"
        Me.ChkAguinaldo.Size = New System.Drawing.Size(285, 19)
        Me.ChkAguinaldo.StyleController = Me.frmAgregarTIngresoConvertedLayout
        ToolTipTitleItem9.Text = "Sts.Nomina"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Marca el Ingreso como parte de los cálculos para el Aguinaldo"
        ToolTipTitleItem10.LeftIndent = 6
        ToolTipTitleItem10.Text = "Ver la Ayuda para más información"
        SuperToolTip5.Items.Add(ToolTipTitleItem9)
        SuperToolTip5.Items.Add(ToolTipItem5)
        SuperToolTip5.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip5.Items.Add(ToolTipTitleItem10)
        Me.ChkAguinaldo.SuperTip = SuperToolTip5
        Me.ChkAguinaldo.TabIndex = 148
        '
        'ckbGravable
        '
        Me.ckbGravable.Location = New System.Drawing.Point(12, 107)
        Me.ckbGravable.Name = "ckbGravable"
        Me.ckbGravable.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ckbGravable.Properties.Appearance.Options.UseFont = True
        Me.ckbGravable.Properties.Caption = "Gravable IR"
        Me.ckbGravable.Size = New System.Drawing.Size(119, 19)
        Me.ckbGravable.StyleController = Me.frmAgregarTIngresoConvertedLayout
        ToolTipTitleItem11.Text = "Sts.Nomina"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Marca el Tipo de Ingreso como Gravable por el Impuesto sobre la Renta (IR)"
        ToolTipTitleItem12.LeftIndent = 6
        ToolTipTitleItem12.Text = "Ver la Ayuda para más información"
        SuperToolTip6.Items.Add(ToolTipTitleItem11)
        SuperToolTip6.Items.Add(ToolTipItem6)
        SuperToolTip6.Items.Add(ToolTipSeparatorItem6)
        SuperToolTip6.Items.Add(ToolTipTitleItem12)
        Me.ckbGravable.SuperTip = SuperToolTip6
        Me.ckbGravable.TabIndex = 146
        '
        'chkValorFijo
        '
        Me.chkValorFijo.Location = New System.Drawing.Point(12, 84)
        Me.chkValorFijo.Name = "chkValorFijo"
        Me.chkValorFijo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.chkValorFijo.Properties.Appearance.Options.UseFont = True
        Me.chkValorFijo.Properties.Caption = "Valor Digitado"
        Me.chkValorFijo.Size = New System.Drawing.Size(119, 19)
        Me.chkValorFijo.StyleController = Me.frmAgregarTIngresoConvertedLayout
        ToolTipTitleItem13.Text = "Sts.Nomina"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Si se marca, el valor se toma del usuario. De lo contrario dependera de calculos " & _
            "del Salario-Empleado"
        ToolTipTitleItem14.LeftIndent = 6
        ToolTipTitleItem14.Text = "Ver la Ayuda para más información"
        SuperToolTip7.Items.Add(ToolTipTitleItem13)
        SuperToolTip7.Items.Add(ToolTipItem7)
        SuperToolTip7.Items.Add(ToolTipSeparatorItem7)
        SuperToolTip7.Items.Add(ToolTipTitleItem14)
        Me.chkValorFijo.SuperTip = SuperToolTip7
        Me.chkValorFijo.TabIndex = 145
        '
        'txtCodigo
        '
        Me.txtCodigo.EditValue = ""
        Me.txtCodigo.Location = New System.Drawing.Point(238, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(91, 20)
        Me.txtCodigo.StyleController = Me.frmAgregarTIngresoConvertedLayout
        ToolTipTitleItem15.Text = "Sts.Nomina"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Código Autogenerado para el nuevo Tipo de Ingreso en Nómina"
        ToolTipTitleItem16.LeftIndent = 6
        ToolTipTitleItem16.Text = "Ver la Ayuda para más información"
        SuperToolTip8.Items.Add(ToolTipTitleItem15)
        SuperToolTip8.Items.Add(ToolTipItem8)
        SuperToolTip8.Items.Add(ToolTipSeparatorItem8)
        SuperToolTip8.Items.Add(ToolTipTitleItem16)
        Me.txtCodigo.SuperTip = SuperToolTip8
        Me.txtCodigo.TabIndex = 142
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem2, Me.EmptySpaceItem4, Me.LayoutControlItem10, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.SplitterItem1, Me.LayoutControlItem5, Me.lcFactor})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(578, 416)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.chkIndemnizacion
        Me.LayoutControlItem1.CustomizationFormText = "chkIndemnizacionitem"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(123, 118)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(289, 23)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(289, 23)
        Me.LayoutControlItem1.Name = "chkIndemnizacionitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(289, 23)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "chkIndemnizacionitem"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ckbINSS
        Me.LayoutControlItem2.CustomizationFormText = "ckbINSSitem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 118)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem2.Name = "ckbINSSitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "ckbINSSitem"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtDescripcion
        Me.LayoutControlItem3.CustomizationFormText = "Descripción:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "txtDescripcionitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(558, 24)
        Me.LayoutControlItem3.Text = "Descripción:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(222, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ChkVacaciones
        Me.LayoutControlItem4.CustomizationFormText = "ChkVacacionesitem"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(123, 95)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(289, 23)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(289, 23)
        Me.LayoutControlItem4.Name = "ChkVacacionesitem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(289, 23)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "ChkVacacionesitem"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ckbGravable
        Me.LayoutControlItem6.CustomizationFormText = "ckbGravableitem"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 95)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem6.Name = "ckbGravableitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "ckbGravableitem"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.chkValorFijo
        Me.LayoutControlItem7.CustomizationFormText = "chkValorFijoitem"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem7.Name = "chkValorFijoitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(123, 23)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "chkValorFijoitem"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbTipo
        Me.LayoutControlItem8.CustomizationFormText = "Tipo de Movimiento:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem8.Name = "cbTipoitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(558, 24)
        Me.LayoutControlItem8.Text = "Tipo de Movimiento:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(222, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtCodigo
        Me.LayoutControlItem9.CustomizationFormText = "Codigo"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem9.Name = "txtCodigoitem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Codigo"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(222, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdCancelar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(466, 370)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(92, 26)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(92, 26)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(92, 26)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdAceptar
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(374, 370)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(92, 26)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(92, 26)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(92, 26)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "LayoutControlItem12"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextToControlDistance = 0
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 370)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(374, 26)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 213)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(412, 10)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.GridControl1
        Me.LayoutControlItem10.CustomizationFormText = "Deducciones que Afecta este Tipo de Ingreso:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 228)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(558, 142)
        Me.LayoutControlItem10.Text = "Deducciones que Afecta este Tipo de Ingreso:"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(222, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtprefijo
        Me.LayoutControlItem13.CustomizationFormText = "Prefijo para Cuentas Detalle:"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 141)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(412, 24)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(412, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(412, 24)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "Prefijo para Cuentas Detalle:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(222, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtsufijo
        Me.LayoutControlItem14.CustomizationFormText = "Sufijo para Centro de Costo:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 165)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(412, 24)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(412, 24)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(412, 24)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "Sufijo para Centro de Costo:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(222, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(321, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(237, 24)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(412, 72)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(146, 151)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(0, 223)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(558, 5)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.ChkAguinaldo
        Me.LayoutControlItem5.CustomizationFormText = "ChkAguinaldoitem"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(123, 72)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(289, 23)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(289, 23)
        Me.LayoutControlItem5.Name = "ChkAguinaldoitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(289, 23)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "ChkAguinaldoitem"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'lcFactor
        '
        Me.lcFactor.Control = Me.CalcEdit1
        Me.lcFactor.CustomizationFormText = "Factor:"
        Me.lcFactor.Location = New System.Drawing.Point(0, 189)
        Me.lcFactor.Name = "lcFactor"
        Me.lcFactor.Size = New System.Drawing.Size(412, 24)
        Me.lcFactor.Text = "Factor:"
        Me.lcFactor.TextSize = New System.Drawing.Size(222, 13)
        '
        'frmAgregarTIngreso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(578, 416)
        Me.Controls.Add(Me.frmAgregarTIngresoConvertedLayout)
        Me.Name = "frmAgregarTIngreso"
        Me.Text = "Tipos de Ingreso"
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmAgregarTIngresoConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAgregarTIngresoConvertedLayout.ResumeLayout(False)
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsufijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprefijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIndemnizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckbINSS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkVacaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAguinaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckbGravable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkValorFijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcFactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarTIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Detalles = VB.SysContab.TipoIngresoDB.GetDetails(Registro)

        cbTipo.Properties.DataSource = VB.SysContab.TipoMovimientoDB.GetList("%").Tables("TiposMovimientos")
        cbTipo.Properties.ValueMember = "Codigo"
        Me.cbTipo.Properties.DisplayMember = "Descripcion"


        Me.cbTIngreso.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables("TipoIngreso")
        Me.cbTIngreso.ValueMember = "Codigo"
        Me.cbTIngreso.DisplayMember = "Descripcion"

        Me.cbTDeduccion.DataSource = VB.SysContab.TipoDeduccionDB.GetList("%")
        Me.cbTDeduccion.ValueMember = "Codigo"
        Me.cbTDeduccion.DisplayMember = "Descripcion"

        Me.txtprefijo.EditValue = ""
        Me.txtsufijo.EditValue = ""
        If Nuevo = "NO" Then
            Me.txtCodigo.Text = ""
            Me.txtDescripcion.Text = ""


            Me.Text = "Editar Tipo de Ingreso"

            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtDescripcion.Text = Detalles.Descripcion
            Me.cbTipo.EditValue = Detalles.Tipo
            Me.ckbGravable.Checked = Detalles.Gravable
            Me.ckbINSS.Checked = Detalles.GINSS
            Me.ChkAguinaldo.Checked = Detalles.Aguinaldo
            Me.ChkVacaciones.Checked = Detalles.Vacaciones
            Me.chkValorFijo.Checked = Detalles.Valor_Fijo
            Me.chkIndemnizacion.Checked = Detalles.Indemnizacion
            Me.txtprefijo.EditValue = Detalles.Prefijo_Detalle
            Me.txtsufijo.EditValue = Detalles.Sufijo_CCosto
            Me.CalcEdit1.EditValue = Detalles.Factor
            If Detalles.Tipo <> 7 Then
                Me.lcFactor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Me.CalcEdit1.EditValue = 0
            Else
                Me.lcFactor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.CalcEdit1.EditValue = Detalles.Factor
            End If

            Me.GridControl1.DataSource = VB.SysContab.TipoIngresoDB.Deduccion_Afecta(Detalles.Codigo, "%")
            Me.vLista.PopulateColumns()
            Me.vLista.Columns("empr_codigo").Visible = False
            Me.vLista.Columns("tdi_codigo").ColumnEdit = Me.cbTIngreso
            Me.vLista.Columns("tdi_codigo").Caption = "Tipo de Ingreso"
            Me.vLista.Columns("tdi_codigo").Visible = False
            Me.vLista.Columns("tde_codigo").ColumnEdit = Me.cbTDeduccion
            Me.vLista.Columns("tde_codigo").Caption = "Tipo de Deduccion"
            Me.vLista.Columns("tde_codigo").Visible = True
        Else
            Me.Text = "Agregar Tipo de Ingreso"
            Me.txtCodigo.Text = VB.SysContab.TipoIngresoDB.GetListCodigoNvo() ' Acordarme de agregar los ceros a la izquierda, no me gusta dejarlo asi
            Me.txtDescripcion.Text = ""
            Me.GridControl1.Enabled = False
            Me.GridControl1.DataSource = Nothing
        End If

        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim ds As DataSet
        Dim CodigoNvo As String


        If IsDBNull(Me.cbTipo.EditValue) Or IsNothing(Me.cbTipo.EditValue) Then
            MsgBox("Se debe seleccionar el Tipo de Ingreso que esta agregando/editando", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error.-")
            Exit Sub
        End If

        Try
            If Nuevo = "SI" Then
                ds = VB.SysContab.TipoIngresoDB.GetListCodigo(Me.txtCodigo.Text)
                If ds.Tables("TipoIngreso").Rows.Count <> 0 Then
                    MsgBox("Ese Tipo de Ingreso ya ha sido definido anteriormente, favor revisar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Codigo ya Existe")
                    Exit Sub
                Else
                    CodigoNvo = VB.SysContab.TipoIngresoDB.GetListCodigoNvo() ' Acordarme de agregar los ceros a la izquierda, no me gusta dejarlo asi
                    VB.SysContab.TipoIngresoDB.Additem(CodigoNvo, Me.txtDescripcion.Text, Me.cbTipo.EditValue, True, True, _
                        Me.ckbGravable.Checked, Me.ckbINSS.Checked, "", _
                        Me.ChkAguinaldo.Checked, Me.ChkVacaciones.Checked, Me.chkValorFijo.Checked, _
                        Me.chkIndemnizacion.Checked, Me.txtprefijo.EditValue, Me.txtsufijo.EditValue, _
                        Me.CalcEdit1.EditValue)
                    Me.Close()
                End If
            Else
                VB.SysContab.TipoIngresoDB.Update(Me.txtCodigo.Text, Me.txtDescripcion.Text, Me.cbTipo.EditValue, _
                        Me.ckbGravable.Checked, Me.ckbINSS.Checked, Detalles.CtaContable, Me.ChkAguinaldo.Checked, _
                        Me.ChkVacaciones.Checked, Me.chkValorFijo.Checked, Me.chkIndemnizacion.Checked, _
                        Me.txtprefijo.EditValue, Me.txtsufijo.EditValue, Me.CalcEdit1.EditValue)
                Me.Close()

            End If

            If Not Me.GridControl1.DataSource Is Nothing Then
                ''CAMPOS DINAMICOS
                Dim tempDt As New DataTable
                'Los Deleted
                tempDt = Me.GridControl1.DataSource.getchanges(DataRowState.Deleted)
                If Not tempDt Is Nothing Then
                    tempDt.RejectChanges()
                    For i As Integer = 0 To tempDt.Rows.Count - 1
                        If Not tempDt.Rows(i)("tde_codigo") Is DBNull.Value Then
                            VB.SysContab.TipoIngresoDB.Deduccion_Afecta_ADD(Me.txtCodigo.Text, _
                                tempDt.Rows(i)("tde_codigo"), False)
                        End If
                    Next

                End If

                'Los Modificados
                tempDt = Me.GridControl1.DataSource.getchanges(DataRowState.Modified)
                If Not tempDt Is Nothing Then
                    For i As Integer = 0 To tempDt.Rows.Count - 1
                        If Not tempDt.Rows(i)("tde_codigo") Is DBNull.Value Then
                            VB.SysContab.TipoIngresoDB.Deduccion_Afecta_ADD(Me.txtCodigo.Text, _
                                 tempDt.Rows(i)("tde_codigo"), tempDt.Rows(i)("activo"))
                        End If
                    Next

                End If

                'Los agregados
                tempDt = Me.GridControl1.DataSource.getchanges(DataRowState.Added)
                If Not tempDt Is Nothing Then
                    For i As Integer = 0 To tempDt.Rows.Count - 1
                        If Not tempDt.Rows(i)("tde_codigo") Is DBNull.Value Then
                            VB.SysContab.TipoIngresoDB.Deduccion_Afecta_ADD(Me.txtCodigo.Text, _
                                tempDt.Rows(i)("tde_codigo"), True)
                        End If
                    Next

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

        Me.Close()
    End Sub

    Private Sub cbTipo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipo.EditValueChanged
        'Lo quito para ver como funcionaria para todos.
        'If sender.editvalue = 5 Or sender.editvalue = 6 Then
        '    Me.chkValorFijo.Enabled = True
        'Else
        '    Me.chkValorFijo.Enabled = False
        '    Me.chkValorFijo.Checked = True
        'End If
        If Me.cbTipo.EditValue <> 7 Then
            Me.lcFactor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.CalcEdit1.EditValue = 0
        Else
            Me.lcFactor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Me.CalcEdit1.EditValue = Detalles.Factor
        End If
    End Sub
    Dim clone2 As DataView
    Private Sub vListaOrganigrama_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vLista.HiddenEditor
        If Not clone2 Is Nothing Then
            clone2.Dispose()
            clone2 = Nothing
        End If
    End Sub

    Private Sub vListaOrganigrama_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles vLista.ShownEditor
        Dim Vista As DevExpress.XtraGrid.Views.Grid.GridView
        Vista = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If Vista.FocusedColumn.FieldName = "tde_codigo" AndAlso TypeOf Vista.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
            If Vista.GetFocusedRowCellValue("tdi_codigo") Is Nothing Then
                Exit Sub
            End If
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim tabla As DataTable
            Dim row As DataRow
            edit = CType(Vista.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            tabla = CType(edit.Properties.DataSource, DataTable)
            clone2 = New DataView(tabla)
            row = Vista.GetDataRow(Vista.FocusedRowHandle)
            clone2.RowFilter = "[tde_codigo]= " & row("tde_codigo").ToString
            edit.Properties.DataSource = clone2
        End If
    End Sub

    Private Sub vListaOrganigrama_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vLista.ValidatingEditor
        If sender.focusedcolumn.fieldname = "tde_codigo" Then
            If Not e.Value Is Nothing Then
                Dim c As Integer
                c = Me.GridControl1.DataSource.Compute("Count(tde_codigo)", "tde_codigo = '" & e.Value & "'")
                If c >= 1 Then
                    MsgBox("Ya existe ese Campo en la lista", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    e.Valid = False
                Else
                    e.Valid = True
                    If e.Value Is Nothing Then Exit Sub
                End If
            End If
        End If
        If sender.focusedcolumn.fieldname = "activo" Then
            If e.Value Is Nothing Then
                MsgBox("No se puede dejar vacio el valor del campo", , "Sts.Nomina")
                e.Valid = False
            End If
            'Me.Grabando = False
        End If

    End Sub

    Private Sub dgOrganigramaD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vLista.DeleteRow(Me.vLista.FocusedRowHandle)
        End If
    End Sub

    Private Sub vListaOrganigrama_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vLista.CellValueChanged
        If e.Column.FieldName = "tde_codigo" Then
            Me.vLista.Columns("activo").OptionsColumn.ReadOnly = False
        End If
    End Sub

    Private Sub vListaOrganigrama_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vLista.InitNewRow
        Me.vLista.Columns("activo").OptionsColumn.ReadOnly = True
        'Me.Grabando = True
    End Sub

End Class
