<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmonUsuario
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtnombre = New DevExpress.XtraEditors.TextEdit()
        Me.frmAdmonUsuarioConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.dgEmpresas = New DevExpress.XtraGrid.GridControl()
        Me.vempresas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Roles = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtcargo = New DevExpress.XtraEditors.TextEdit()
        Me.txtlogin = New DevExpress.XtraEditors.TextEdit()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdnuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdeditar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.txtnombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmAdmonUsuarioConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAdmonUsuarioConvertedLayout.SuspendLayout()
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vempresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(65, 12)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(663, 22)
        Me.txtnombre.StyleController = Me.frmAdmonUsuarioConvertedLayout
        Me.txtnombre.TabIndex = 0
        '
        'frmAdmonUsuarioConvertedLayout
        '
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.dgEmpresas)
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.Roles)
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.txtcargo)
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.txtlogin)
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.txtnombre)
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.GridDetalle)
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.cmdnuevo)
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.CmdGuardar)
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.cmdeditar)
        Me.frmAdmonUsuarioConvertedLayout.Controls.Add(Me.cmdsalir)
        Me.frmAdmonUsuarioConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAdmonUsuarioConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAdmonUsuarioConvertedLayout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.frmAdmonUsuarioConvertedLayout.Name = "frmAdmonUsuarioConvertedLayout"
        Me.frmAdmonUsuarioConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(860, 164, 250, 350)
        Me.frmAdmonUsuarioConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAdmonUsuarioConvertedLayout.Size = New System.Drawing.Size(740, 482)
        Me.frmAdmonUsuarioConvertedLayout.TabIndex = 10
        '
        'dgEmpresas
        '
        Me.dgEmpresas.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgEmpresas.Location = New System.Drawing.Point(444, 116)
        Me.dgEmpresas.MainView = Me.vempresas
        Me.dgEmpresas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgEmpresas.Name = "dgEmpresas"
        Me.dgEmpresas.Size = New System.Drawing.Size(284, 328)
        Me.dgEmpresas.TabIndex = 10
        Me.dgEmpresas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vempresas})
        '
        'vempresas
        '
        Me.vempresas.GridControl = Me.dgEmpresas
        Me.vempresas.Name = "vempresas"
        Me.vempresas.OptionsView.ShowAutoFilterRow = True
        Me.vempresas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vempresas.OptionsView.ShowFooter = True
        Me.vempresas.OptionsView.ShowGroupPanel = False
        '
        'Roles
        '
        Me.Roles.Location = New System.Drawing.Point(65, 90)
        Me.Roles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Roles.Name = "Roles"
        Me.Roles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Roles.Size = New System.Drawing.Size(663, 22)
        Me.Roles.StyleController = Me.frmAdmonUsuarioConvertedLayout
        Me.Roles.TabIndex = 9
        '
        'txtcargo
        '
        Me.txtcargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcargo.Enabled = False
        Me.txtcargo.Location = New System.Drawing.Point(65, 64)
        Me.txtcargo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.Size = New System.Drawing.Size(663, 22)
        Me.txtcargo.StyleController = Me.frmAdmonUsuarioConvertedLayout
        Me.txtcargo.TabIndex = 2
        '
        'txtlogin
        '
        Me.txtlogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlogin.Enabled = False
        Me.txtlogin.Location = New System.Drawing.Point(65, 38)
        Me.txtlogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(280, 22)
        Me.txtlogin.StyleController = Me.frmAdmonUsuarioConvertedLayout
        Me.txtlogin.TabIndex = 1
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 116)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(423, 328)
        Me.GridDetalle.TabIndex = 4
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmdnuevo
        '
        Me.cmdnuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdnuevo.Location = New System.Drawing.Point(497, 448)
        Me.cmdnuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(56, 22)
        Me.cmdnuevo.StyleController = Me.frmAdmonUsuarioConvertedLayout
        Me.cmdnuevo.TabIndex = 5
        Me.cmdnuevo.Text = "&Nuevo"
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdGuardar.Enabled = False
        Me.CmdGuardar.Location = New System.Drawing.Point(611, 448)
        Me.CmdGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(57, 22)
        Me.CmdGuardar.StyleController = Me.frmAdmonUsuarioConvertedLayout
        Me.CmdGuardar.TabIndex = 7
        Me.CmdGuardar.Text = "&Guardar"
        '
        'cmdeditar
        '
        Me.cmdeditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdeditar.Enabled = False
        Me.cmdeditar.Location = New System.Drawing.Point(557, 448)
        Me.cmdeditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdeditar.Name = "cmdeditar"
        Me.cmdeditar.Size = New System.Drawing.Size(50, 22)
        Me.cmdeditar.StyleController = Me.frmAdmonUsuarioConvertedLayout
        Me.cmdeditar.TabIndex = 6
        Me.cmdeditar.Text = "E&ditar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdsalir.Location = New System.Drawing.Point(672, 448)
        Me.cmdsalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(56, 22)
        Me.cmdsalir.StyleController = Me.frmAdmonUsuarioConvertedLayout
        Me.cmdsalir.TabIndex = 8
        Me.cmdsalir.Text = "&Salir"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.LayoutControlItem10, Me.SplitterItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(740, 482)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Roles
        Me.LayoutControlItem1.CustomizationFormText = "Rol:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem1.Name = "Rolesitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(720, 26)
        Me.LayoutControlItem1.Text = "Rol:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(50, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtcargo
        Me.LayoutControlItem2.CustomizationFormText = "Cargo:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem2.Name = "txtcargoitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(720, 26)
        Me.LayoutControlItem2.Text = "Cargo:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtlogin
        Me.LayoutControlItem3.CustomizationFormText = "Login:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(337, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(337, 26)
        Me.LayoutControlItem3.Name = "txtloginitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(337, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Login:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtnombre
        Me.LayoutControlItem4.CustomizationFormText = "Nombre:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "txtnombreitem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(720, 26)
        Me.LayoutControlItem4.Text = "Nombre:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(50, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridDetalle
        Me.LayoutControlItem5.CustomizationFormText = "GridDetalleitem"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem5.Name = "GridDetalleitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(427, 332)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "GridDetalleitem"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdnuevo
        Me.LayoutControlItem6.CustomizationFormText = "cmdnuevoitem"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(485, 436)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(60, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(60, 26)
        Me.LayoutControlItem6.Name = "cmdnuevoitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(60, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "cmdnuevoitem"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.CmdGuardar
        Me.LayoutControlItem7.CustomizationFormText = "CmdGuardaritem"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(599, 436)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(61, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(61, 26)
        Me.LayoutControlItem7.Name = "CmdGuardaritem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(61, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "CmdGuardaritem"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdeditar
        Me.LayoutControlItem8.CustomizationFormText = "cmdeditaritem"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(545, 436)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(54, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(54, 26)
        Me.LayoutControlItem8.Name = "cmdeditaritem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(54, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "cmdeditaritem"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdsalir
        Me.LayoutControlItem9.CustomizationFormText = "cmdsaliritem"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(660, 436)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(60, 26)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(60, 26)
        Me.LayoutControlItem9.Name = "cmdsaliritem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(60, 26)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "cmdsaliritem"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 436)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(485, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.dgEmpresas
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(432, 104)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(288, 332)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(427, 104)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(5, 332)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(337, 26)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(383, 26)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmAdmonUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.frmAdmonUsuarioConvertedLayout)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAdmonUsuario"
        Me.Text = "Administracion de Usuario"
        CType(Me.txtnombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmAdmonUsuarioConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAdmonUsuarioConvertedLayout.ResumeLayout(False)
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vempresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtnombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtlogin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdnuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdeditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtcargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Roles As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents frmAdmonUsuarioConvertedLayout As DevExpress.XtraLayout.LayoutControl
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
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dgEmpresas As DevExpress.XtraGrid.GridControl
    Friend WithEvents vempresas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
