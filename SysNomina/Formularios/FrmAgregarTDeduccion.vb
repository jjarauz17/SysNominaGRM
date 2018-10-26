Public Class frmAgregarTDeduccion
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarTDeduccion = Nothing

    Public Shared Function Instance() As frmAgregarTDeduccion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarTDeduccion()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#Region "Variables"
    Private HEnt As String, HSal As String, LCodigo As String
    Dim Detalles As VB.SysContab.TipoDeduccionDetails
#End Region
#Region "Calaches"
    Friend WithEvents chkValorFijo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkAguinaldo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents frmAgregarTDeduccionConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lc_daguinaldo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lc_descripcion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lc_Codigo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lc_tipo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lc_vdigitado As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtsufijo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtprefijo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents vLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lc_grid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbTIngreso As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbTDeduccion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lcFactor As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
#End Region



#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem5 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
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
        Me.chkValorFijo = New DevExpress.XtraEditors.CheckEdit()
        Me.frmAgregarTDeduccionConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.vLista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbTIngreso = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbTDeduccion = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.txtsufijo = New DevExpress.XtraEditors.TextEdit()
        Me.txtprefijo = New DevExpress.XtraEditors.TextEdit()
        Me.chkAguinaldo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.cbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lc_daguinaldo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lc_Codigo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lc_vdigitado = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lc_grid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lc_descripcion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lc_tipo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcFactor = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.chkValorFijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmAgregarTDeduccionConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAgregarTDeduccionConvertedLayout.SuspendLayout()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTDeduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsufijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprefijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAguinaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lc_daguinaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lc_Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lc_vdigitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lc_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lc_descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lc_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkValorFijo
        '
        Me.chkValorFijo.Location = New System.Drawing.Point(12, 84)
        Me.chkValorFijo.Name = "chkValorFijo"
        Me.chkValorFijo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.chkValorFijo.Properties.Appearance.Options.UseFont = True
        Me.chkValorFijo.Properties.Caption = "Valor Digitado"
        Me.chkValorFijo.Size = New System.Drawing.Size(359, 19)
        Me.chkValorFijo.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        ToolTipTitleItem9.Text = "Sts.Nomina"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Si se marca, el valor se toma del usuario. De lo contrario dependera de calculos " & _
            "del Salario-Empleado"
        ToolTipTitleItem10.LeftIndent = 6
        ToolTipTitleItem10.Text = "Ver la Ayuda para m�s informaci�n"
        SuperToolTip5.Items.Add(ToolTipTitleItem9)
        SuperToolTip5.Items.Add(ToolTipItem5)
        SuperToolTip5.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip5.Items.Add(ToolTipTitleItem10)
        Me.chkValorFijo.SuperTip = SuperToolTip5
        Me.chkValorFijo.TabIndex = 129
        '
        'frmAgregarTDeduccionConvertedLayout
        '
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.CalcEdit1)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.cmdCancelar)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.cmdAceptar)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.GridControl1)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.txtsufijo)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.txtprefijo)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.chkAguinaldo)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.txtDescripcion)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.txtCodigo)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.cbTipo)
        Me.frmAgregarTDeduccionConvertedLayout.Controls.Add(Me.chkValorFijo)
        Me.frmAgregarTDeduccionConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAgregarTDeduccionConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAgregarTDeduccionConvertedLayout.Name = "frmAgregarTDeduccionConvertedLayout"
        Me.frmAgregarTDeduccionConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAgregarTDeduccionConvertedLayout.Size = New System.Drawing.Size(590, 379)
        Me.frmAgregarTDeduccionConvertedLayout.TabIndex = 138
        '
        'CalcEdit1
        '
        Me.CalcEdit1.Location = New System.Drawing.Point(200, 178)
        Me.CalcEdit1.Name = "CalcEdit1"
        Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit1.Size = New System.Drawing.Size(171, 20)
        Me.CalcEdit1.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        Me.CalcEdit1.TabIndex = 143
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(499, 345)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(79, 22)
        Me.cmdCancelar.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        Me.cmdCancelar.TabIndex = 142
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(416, 345)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(79, 22)
        Me.cmdAceptar.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        Me.cmdAceptar.TabIndex = 141
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 237)
        Me.GridControl1.MainView = Me.vLista
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbTIngreso, Me.cbTDeduccion})
        Me.GridControl1.Size = New System.Drawing.Size(566, 104)
        Me.GridControl1.TabIndex = 140
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
        Me.cbTIngreso.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tipo de Ingreso")})
        Me.cbTIngreso.Name = "cbTIngreso"
        '
        'cbTDeduccion
        '
        Me.cbTDeduccion.AutoHeight = False
        Me.cbTDeduccion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTDeduccion.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tipo de Deduccion")})
        Me.cbTDeduccion.Name = "cbTDeduccion"
        '
        'txtsufijo
        '
        Me.txtsufijo.Location = New System.Drawing.Point(200, 154)
        Me.txtsufijo.Name = "txtsufijo"
        Me.txtsufijo.Size = New System.Drawing.Size(171, 20)
        Me.txtsufijo.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        Me.txtsufijo.TabIndex = 139
        '
        'txtprefijo
        '
        Me.txtprefijo.Location = New System.Drawing.Point(200, 130)
        Me.txtprefijo.Name = "txtprefijo"
        Me.txtprefijo.Size = New System.Drawing.Size(171, 20)
        Me.txtprefijo.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        Me.txtprefijo.TabIndex = 138
        '
        'chkAguinaldo
        '
        Me.chkAguinaldo.Location = New System.Drawing.Point(12, 107)
        Me.chkAguinaldo.Name = "chkAguinaldo"
        Me.chkAguinaldo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.chkAguinaldo.Properties.Appearance.Options.UseFont = True
        Me.chkAguinaldo.Properties.Caption = "Deducir en Aguinaldo"
        Me.chkAguinaldo.Size = New System.Drawing.Size(359, 19)
        Me.chkAguinaldo.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        ToolTipTitleItem1.Text = "Sts.Nomina"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Si se marca, el valor se toma del usuario. De lo contrario dependera de calculos " & _
            "del Salario-Empleado"
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "Ver la Ayuda para m�s informaci�n"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.chkAguinaldo.SuperTip = SuperToolTip1
        Me.chkAguinaldo.TabIndex = 137
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(200, 36)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.MaxLength = 50
        Me.txtDescripcion.Size = New System.Drawing.Size(378, 20)
        Me.txtDescripcion.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        ToolTipTitleItem3.Text = "Sts.Nomina"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Descripci�n del nuevo Tipo de Deducci�n en N�mina"
        ToolTipTitleItem4.LeftIndent = 6
        ToolTipTitleItem4.Text = "Ver la Ayuda para m�s informaci�n"
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        SuperToolTip2.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip2.Items.Add(ToolTipTitleItem4)
        Me.txtDescripcion.SuperTip = SuperToolTip2
        Me.txtDescripcion.TabIndex = 135
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(200, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(93, 20)
        Me.txtCodigo.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        ToolTipTitleItem5.Text = "Sts.Nomina"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "C�digo autogenerado para el nuevo Tipo de Deducci�n en N�mina"
        ToolTipTitleItem6.LeftIndent = 6
        ToolTipTitleItem6.Text = "Ver la Ayuda para m�s informaci�n"
        SuperToolTip3.Items.Add(ToolTipTitleItem5)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem3)
        SuperToolTip3.Items.Add(ToolTipTitleItem6)
        Me.txtCodigo.SuperTip = SuperToolTip3
        Me.txtCodigo.TabIndex = 134
        '
        'cbTipo
        '
        Me.cbTipo.Location = New System.Drawing.Point(200, 60)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo.Properties.NullText = ""
        Me.cbTipo.Size = New System.Drawing.Size(378, 20)
        Me.cbTipo.StyleController = Me.frmAgregarTDeduccionConvertedLayout
        ToolTipTitleItem7.Text = "Sts.Nomina"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Forma de Calcular las Cuotas y/o Valores de las Deducciones"
        ToolTipTitleItem8.LeftIndent = 6
        ToolTipTitleItem8.Text = "Ver la Ayuda para m�s informaci�n"
        SuperToolTip4.Items.Add(ToolTipTitleItem7)
        SuperToolTip4.Items.Add(ToolTipItem4)
        SuperToolTip4.Items.Add(ToolTipSeparatorItem4)
        SuperToolTip4.Items.Add(ToolTipTitleItem8)
        Me.cbTipo.SuperTip = SuperToolTip4
        Me.cbTipo.TabIndex = 136
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lc_daguinaldo, Me.lc_Codigo, Me.lc_vdigitado, Me.EmptySpaceItem2, Me.lc_grid, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem3, Me.SplitterItem1, Me.EmptySpaceItem1, Me.EmptySpaceItem5, Me.lc_descripcion, Me.lc_tipo, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.lcFactor})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(590, 379)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lc_daguinaldo
        '
        Me.lc_daguinaldo.Control = Me.chkAguinaldo
        Me.lc_daguinaldo.CustomizationFormText = "Tipo"
        Me.lc_daguinaldo.Location = New System.Drawing.Point(0, 95)
        Me.lc_daguinaldo.MaxSize = New System.Drawing.Size(363, 23)
        Me.lc_daguinaldo.MinSize = New System.Drawing.Size(363, 23)
        Me.lc_daguinaldo.Name = "lc_daguinaldo"
        Me.lc_daguinaldo.Size = New System.Drawing.Size(363, 23)
        Me.lc_daguinaldo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lc_daguinaldo.Text = "Tipo"
        Me.lc_daguinaldo.TextLocation = DevExpress.Utils.Locations.Top
        Me.lc_daguinaldo.TextSize = New System.Drawing.Size(0, 0)
        Me.lc_daguinaldo.TextToControlDistance = 0
        Me.lc_daguinaldo.TextVisible = False
        '
        'lc_Codigo
        '
        Me.lc_Codigo.Control = Me.txtCodigo
        Me.lc_Codigo.CustomizationFormText = "C�digo"
        Me.lc_Codigo.Location = New System.Drawing.Point(0, 0)
        Me.lc_Codigo.MaxSize = New System.Drawing.Size(285, 24)
        Me.lc_Codigo.MinSize = New System.Drawing.Size(285, 24)
        Me.lc_Codigo.Name = "lc_Codigo"
        Me.lc_Codigo.Size = New System.Drawing.Size(285, 24)
        Me.lc_Codigo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lc_Codigo.Text = "C�digo"
        Me.lc_Codigo.TextSize = New System.Drawing.Size(184, 13)
        '
        'lc_vdigitado
        '
        Me.lc_vdigitado.Control = Me.chkValorFijo
        Me.lc_vdigitado.CustomizationFormText = "chkValorFijoitem"
        Me.lc_vdigitado.Location = New System.Drawing.Point(0, 72)
        Me.lc_vdigitado.MaxSize = New System.Drawing.Size(363, 23)
        Me.lc_vdigitado.MinSize = New System.Drawing.Size(363, 23)
        Me.lc_vdigitado.Name = "lc_vdigitado"
        Me.lc_vdigitado.Size = New System.Drawing.Size(363, 23)
        Me.lc_vdigitado.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lc_vdigitado.Text = "lc_vdigitado"
        Me.lc_vdigitado.TextSize = New System.Drawing.Size(0, 0)
        Me.lc_vdigitado.TextToControlDistance = 0
        Me.lc_vdigitado.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 190)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(363, 14)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'lc_grid
        '
        Me.lc_grid.Control = Me.GridControl1
        Me.lc_grid.CustomizationFormText = "Ingresos que Afectan esta Deduccion:"
        Me.lc_grid.Location = New System.Drawing.Point(0, 209)
        Me.lc_grid.Name = "lc_grid"
        Me.lc_grid.Size = New System.Drawing.Size(570, 124)
        Me.lc_grid.Text = "Ingresos que Afectan esta Deduccion:"
        Me.lc_grid.TextLocation = DevExpress.Utils.Locations.Top
        Me.lc_grid.TextSize = New System.Drawing.Size(184, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdAceptar
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(404, 333)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdCancelar
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(487, 333)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 333)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(404, 26)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(0, 204)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(570, 5)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(285, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(285, 24)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(363, 72)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(207, 132)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'lc_descripcion
        '
        Me.lc_descripcion.Control = Me.txtDescripcion
        Me.lc_descripcion.CustomizationFormText = "Descripci�n"
        Me.lc_descripcion.Location = New System.Drawing.Point(0, 24)
        Me.lc_descripcion.Name = "lc_descripcion"
        Me.lc_descripcion.Size = New System.Drawing.Size(570, 24)
        Me.lc_descripcion.Text = "Descripci�n"
        Me.lc_descripcion.TextSize = New System.Drawing.Size(184, 13)
        '
        'lc_tipo
        '
        Me.lc_tipo.Control = Me.cbTipo
        Me.lc_tipo.CustomizationFormText = "Tipo"
        Me.lc_tipo.Location = New System.Drawing.Point(0, 48)
        Me.lc_tipo.Name = "lc_tipo"
        Me.lc_tipo.Size = New System.Drawing.Size(570, 24)
        Me.lc_tipo.Text = "Tipo"
        Me.lc_tipo.TextSize = New System.Drawing.Size(184, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtprefijo
        Me.LayoutControlItem6.CustomizationFormText = "Prefijo para Cuentas Detalle:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 118)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Prefijo para Cuentas Detalle:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(184, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtsufijo
        Me.LayoutControlItem7.CustomizationFormText = "Sufijo para Centro de Costo:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 142)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(363, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Sufijo para Centro de Costo:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(184, 13)
        '
        'lcFactor
        '
        Me.lcFactor.Control = Me.CalcEdit1
        Me.lcFactor.CustomizationFormText = "Factor:"
        Me.lcFactor.Location = New System.Drawing.Point(0, 166)
        Me.lcFactor.Name = "lcFactor"
        Me.lcFactor.Size = New System.Drawing.Size(363, 24)
        Me.lcFactor.Text = "Factor:"
        Me.lcFactor.TextSize = New System.Drawing.Size(184, 13)
        '
        'frmAgregarTDeduccion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(590, 379)
        Me.Controls.Add(Me.frmAgregarTDeduccionConvertedLayout)
        Me.Name = "frmAgregarTDeduccion"
        Me.Text = "Tipos de Deducci�n"
        CType(Me.chkValorFijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmAgregarTDeduccionConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAgregarTDeduccionConvertedLayout.ResumeLayout(False)
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTDeduccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsufijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprefijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAguinaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lc_daguinaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lc_Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lc_vdigitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lc_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lc_descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lc_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcFactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarTDeduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Detalles = VB.SysContab.TipoDeduccionDB.GetDetails(Registro)

        Me.cbTipo.Properties.DataSource = VB.SysContab.TipoMovimientoDB.GetList("%").Tables("TiposMovimientos")
        Me.cbTipo.Properties.ValueMember = "Codigo"
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

            Me.Text = "Editar Tipo de Deducci�n"

            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtDescripcion.Text = Detalles.Descripcion
            Me.cbTipo.EditValue = Detalles.Tipo
            Me.chkValorFijo.Checked = Detalles.Valor_Fijo
            Me.chkAguinaldo.Checked = Detalles.Aguinaldo

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
            Me.GridControl1.DataSource = VB.SysContab.TipoIngresoDB.Deduccion_Afecta("%", Detalles.Codigo)
            Me.vLista.PopulateColumns()
            Me.vLista.Columns("empr_codigo").Visible = False
            Me.vLista.Columns("tdi_codigo").ColumnEdit = Me.cbTIngreso
            Me.vLista.Columns("tdi_codigo").Caption = "Tipo de Ingreso"
            Me.vLista.Columns("tdi_codigo").Visible = True
            Me.vLista.Columns("tde_codigo").ColumnEdit = Me.cbTDeduccion
            Me.vLista.Columns("tde_codigo").Caption = "Tipo de Deduccion"
            Me.vLista.Columns("tde_codigo").Visible = False

        Else
            Me.Text = "Agregar Tipo de Deducci�n"
            Me.txtCodigo.Text = VB.SysContab.TipoDeduccionDB.GetListCodigoNvo() ' Acordarme de agregar los ceros a la izquierda, no me gusta dejarlo asi
            Me.txtDescripcion.Text = ""
            Me.chkValorFijo.Checked = False
            Me.chkAguinaldo.Checked = False
            Me.GridControl1.DataSource = Nothing
        End If


        Me.Refresh()


    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim ds As DataTable
        Dim CodigoNvo As String

        If IsDBNull(Me.cbTipo.EditValue) Or IsNothing(Me.cbTipo.EditValue) Then
            MsgBox("Se debe seleccionar el Tipo de Deduccion que esta agregando/editando", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error.-")
            Exit Sub
        End If

        Try
            If Nuevo = "SI" Then
                ds = VB.SysContab.TipoDeduccionDB.GetListCodigo(Me.txtCodigo.Text)
                If ds.Rows.Count <> 0 Then
                    MsgBox("Ese Tipo de Deduccion ya ha sido definida anteriormente, favor revisar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Codigo ya Existe")
                    Exit Sub
                Else
                    CodigoNvo = VB.SysContab.TipoDeduccionDB.GetListCodigoNvo() ' Acordarme de agregar los ceros a la izquierda, no me gusta dejarlo asi
                    VB.SysContab.TipoDeduccionDB.Additem(CodigoNvo, _
                        Me.txtDescripcion.Text, _
                        Me.cbTipo.EditValue, _
                        True, _
                        True, _
                        "", _
                        Me.chkValorFijo.Checked, _
                        Me.chkAguinaldo.Checked, _
                        Me.txtprefijo.EditValue, _
                        Me.txtsufijo.EditValue, _
                        Me.CalcEdit1.EditValue)
                End If
            Else
                If Detalles.Editable Then
                    VB.SysContab.TipoDeduccionDB.Update(Me.txtCodigo.Text, _
                        Me.txtDescripcion.Text, _
                        Me.cbTipo.EditValue, _
                        Detalles.CtaContable, _
                        Me.chkValorFijo.Checked, _
                        Me.chkAguinaldo.Checked, _
                        Me.txtprefijo.EditValue, _
                        Me.txtsufijo.EditValue, _
                        Me.CalcEdit1.EditValue)
                Else
                    VB.SysContab.TipoDeduccionDB.Update(Me.Detalles.Codigo, _
                        Me.Detalles.Descripcion, _
                        Me.Detalles.Tipo, _
                        Detalles.CtaContable, _
                        Me.Detalles.Valor_Fijo, _
                        Me.Detalles.Aguinaldo, _
                        Me.txtprefijo.EditValue, _
                        Me.txtsufijo.EditValue, _
                        Me.CalcEdit1.EditValue)
                End If


            End If

            ''
            If Not Me.GridControl1.DataSource Is Nothing Then
                Dim tempDt As New DataTable
                'Los Deleted
                tempDt = Me.GridControl1.DataSource.getchanges(DataRowState.Deleted)
                If Not tempDt Is Nothing Then
                    tempDt.RejectChanges()
                    For i As Integer = 0 To tempDt.Rows.Count - 1
                        If Not tempDt.Rows(i)("tdi_codigo") Is DBNull.Value Then
                            VB.SysContab.TipoIngresoDB.Deduccion_Afecta_ADD(tempDt.Rows(i)("tdi_codigo"), _
                                  Me.txtCodigo.Text, _
                                  False)
                        End If
                    Next

                End If

                'Los Modificados
                tempDt = Me.GridControl1.DataSource.getchanges(DataRowState.Modified)
                If Not tempDt Is Nothing Then
                    For i As Integer = 0 To tempDt.Rows.Count - 1
                        If Not tempDt.Rows(i)("tdi_codigo") Is DBNull.Value Then
                            VB.SysContab.TipoIngresoDB.Deduccion_Afecta_ADD(tempDt.Rows(i)("tdi_codigo"), _
                                  Me.txtCodigo.Text, _
                                  tempDt.Rows(i)("activo"))
                        End If
                    Next

                End If

                'Los agregados
                tempDt = Me.GridControl1.DataSource.getchanges(DataRowState.Added)
                If Not tempDt Is Nothing Then
                    For i As Integer = 0 To tempDt.Rows.Count - 1
                        If Not tempDt.Rows(i)("tdi_codigo") Is DBNull.Value Then
                            VB.SysContab.TipoIngresoDB.Deduccion_Afecta_ADD(tempDt.Rows(i)("tdi_codigo"), _
                                  Me.txtCodigo.Text, _
                                  True)
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
        If Vista.FocusedColumn.FieldName = "tdi_codigo" AndAlso TypeOf Vista.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
            If Vista.GetFocusedRowCellValue("tde_codigo") Is Nothing Then
                Exit Sub
            End If
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim tabla As DataTable
            Dim row As DataRow
            edit = CType(Vista.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            tabla = CType(edit.Properties.DataSource, DataTable)
            clone2 = New DataView(tabla)
            row = Vista.GetDataRow(Vista.FocusedRowHandle)
            clone2.RowFilter = "[tdi_codigo]= " & row("tdi_codigo").ToString
            edit.Properties.DataSource = clone2
        End If
    End Sub

    Private Sub vListaOrganigrama_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles vLista.ValidatingEditor
        If sender.focusedcolumn.fieldname = "tdi_codigo" Then
            If Not e.Value Is Nothing Then
                Dim c As Integer
                c = Me.GridControl1.DataSource.Compute("Count(tdi_codigo)", "tdi_codigo = '" & e.Value & "'")
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
        If e.Column.FieldName = "tdi_codigo" Then
            Me.vLista.Columns("activo").OptionsColumn.ReadOnly = False
        End If
    End Sub

    Private Sub vListaOrganigrama_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles vLista.InitNewRow
        Me.vLista.Columns("activo").OptionsColumn.ReadOnly = True
        'Me.Grabando = True
    End Sub

End Class
