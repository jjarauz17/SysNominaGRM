Imports System.IO

Public Class frmAgregarPermisos
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAgregarPermisos = Nothing

    Public Shared Function Instance() As frmAgregarPermisos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarPermisos()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#Region "Variables"

    Dim detEmpleados As New VB.SysContab.EmpleadosDetails()

    Dim FPEmpl As String
    Dim inicio, final As Date
    Dim Iniciado As Boolean = False
    Friend WithEvents dgDetallePermisos As DevExpress.XtraGrid.GridControl
    Friend WithEvents VPermisos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtVacacionesDisponibles As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFactorDia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCarencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNota As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkSubsidio As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents frmAgregarPermisosConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cbTSubsidio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdcancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lcTS As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTP As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
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
    Friend WithEvents dtpFInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPHFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPHInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtprm_codigo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtFactorDia = New DevExpress.XtraEditors.TextEdit()
        Me.frmAgregarPermisosConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cbTSubsidio = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdcancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNota = New DevExpress.XtraEditors.MemoEdit()
        Me.DTPHFinal = New System.Windows.Forms.DateTimePicker()
        Me.chkSubsidio = New DevExpress.XtraEditors.CheckEdit()
        Me.DTPHInicio = New System.Windows.Forms.DateTimePicker()
        Me.dgDetallePermisos = New DevExpress.XtraGrid.GridControl()
        Me.VPermisos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dtpFFinal = New System.Windows.Forms.DateTimePicker()
        Me.txtCarencia = New DevExpress.XtraEditors.TextEdit()
        Me.dtpFInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtprm_codigo = New System.Windows.Forms.TextBox()
        Me.CBTipo = New System.Windows.Forms.ComboBox()
        Me.txtVacacionesDisponibles = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lcTS = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.txtFactorDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmAgregarPermisosConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAgregarPermisosConvertedLayout.SuspendLayout()
        CType(Me.cbTSubsidio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSubsidio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetallePermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCarencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVacacionesDisponibles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFactorDia
        '
        Me.txtFactorDia.Location = New System.Drawing.Point(570, 36)
        Me.txtFactorDia.Name = "txtFactorDia"
        Me.txtFactorDia.Size = New System.Drawing.Size(112, 20)
        Me.txtFactorDia.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.txtFactorDia.TabIndex = 177
        '
        'frmAgregarPermisosConvertedLayout
        '
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.cbTSubsidio)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.cmdcancelar)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.cmdBorrar)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.cmdAceptar)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.cmdNuevo)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.txtNota)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.DTPHFinal)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.chkSubsidio)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.txtFactorDia)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.DTPHInicio)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.dgDetallePermisos)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.dtpFFinal)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.txtCarencia)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.dtpFInicio)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.txtprm_codigo)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.CBTipo)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.txtVacacionesDisponibles)
        Me.frmAgregarPermisosConvertedLayout.Controls.Add(Me.txtNombre)
        Me.frmAgregarPermisosConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAgregarPermisosConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAgregarPermisosConvertedLayout.Name = "frmAgregarPermisosConvertedLayout"
        Me.frmAgregarPermisosConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1095, 257, 250, 350)
        Me.frmAgregarPermisosConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAgregarPermisosConvertedLayout.Size = New System.Drawing.Size(816, 510)
        Me.frmAgregarPermisosConvertedLayout.TabIndex = 178
        '
        'cbTSubsidio
        '
        Me.cbTSubsidio.Location = New System.Drawing.Point(681, 70)
        Me.cbTSubsidio.Name = "cbTSubsidio"
        Me.cbTSubsidio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTSubsidio.Properties.NullText = "[Seleccione un Tipo]"
        Me.cbTSubsidio.Size = New System.Drawing.Size(123, 20)
        Me.cbTSubsidio.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.cbTSubsidio.TabIndex = 182
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Location = New System.Drawing.Point(725, 476)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(79, 22)
        Me.cmdcancelar.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.cmdcancelar.TabIndex = 181
        Me.cmdcancelar.Text = "&Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(642, 476)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(79, 22)
        Me.cmdBorrar.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.cmdBorrar.TabIndex = 180
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(559, 476)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(79, 22)
        Me.cmdAceptar.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.cmdAceptar.TabIndex = 179
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(476, 476)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(79, 22)
        Me.cmdNuevo.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.cmdNuevo.TabIndex = 178
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(128, 143)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Properties.MaxLength = 400
        Me.txtNota.Size = New System.Drawing.Size(433, 19)
        Me.txtNota.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.txtNota.TabIndex = 165
        '
        'DTPHFinal
        '
        Me.DTPHFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPHFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPHFinal.Location = New System.Drawing.Point(347, 119)
        Me.DTPHFinal.Name = "DTPHFinal"
        Me.DTPHFinal.Size = New System.Drawing.Size(114, 20)
        Me.DTPHFinal.TabIndex = 159
        '
        'chkSubsidio
        '
        Me.chkSubsidio.Location = New System.Drawing.Point(686, 36)
        Me.chkSubsidio.Name = "chkSubsidio"
        Me.chkSubsidio.Properties.Caption = "Asumir Subsidio"
        Me.chkSubsidio.Size = New System.Drawing.Size(118, 19)
        Me.chkSubsidio.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.chkSubsidio.TabIndex = 167
        '
        'DTPHInicio
        '
        Me.DTPHInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPHInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPHInicio.Location = New System.Drawing.Point(347, 95)
        Me.DTPHInicio.Name = "DTPHInicio"
        Me.DTPHInicio.Size = New System.Drawing.Size(114, 20)
        Me.DTPHInicio.TabIndex = 157
        '
        'dgDetallePermisos
        '
        Me.dgDetallePermisos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetallePermisos.Location = New System.Drawing.Point(12, 166)
        Me.dgDetallePermisos.MainView = Me.VPermisos
        Me.dgDetallePermisos.Name = "dgDetallePermisos"
        Me.dgDetallePermisos.Size = New System.Drawing.Size(792, 306)
        Me.dgDetallePermisos.TabIndex = 161
        Me.dgDetallePermisos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VPermisos})
        '
        'VPermisos
        '
        Me.VPermisos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VPermisos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VPermisos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VPermisos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VPermisos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VPermisos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VPermisos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VPermisos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VPermisos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VPermisos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VPermisos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VPermisos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VPermisos.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VPermisos.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VPermisos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VPermisos.Appearance.Empty.Options.UseBackColor = True
        Me.VPermisos.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VPermisos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VPermisos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VPermisos.Appearance.EvenRow.Options.UseBackColor = True
        Me.VPermisos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VPermisos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VPermisos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VPermisos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VPermisos.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VPermisos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VPermisos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VPermisos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VPermisos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VPermisos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VPermisos.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VPermisos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VPermisos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VPermisos.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VPermisos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VPermisos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VPermisos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VPermisos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VPermisos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VPermisos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VPermisos.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VPermisos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VPermisos.Appearance.GroupButton.Options.UseBackColor = True
        Me.VPermisos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VPermisos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VPermisos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VPermisos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VPermisos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VPermisos.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VPermisos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VPermisos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VPermisos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VPermisos.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VPermisos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VPermisos.Appearance.GroupRow.Options.UseBackColor = True
        Me.VPermisos.Appearance.GroupRow.Options.UseFont = True
        Me.VPermisos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VPermisos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VPermisos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VPermisos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VPermisos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VPermisos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VPermisos.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VPermisos.Appearance.HorzLine.Options.UseBackColor = True
        Me.VPermisos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VPermisos.Appearance.OddRow.Options.UseBackColor = True
        Me.VPermisos.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VPermisos.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VPermisos.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VPermisos.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VPermisos.Appearance.Preview.Options.UseBackColor = True
        Me.VPermisos.Appearance.Preview.Options.UseFont = True
        Me.VPermisos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VPermisos.Appearance.Row.Options.UseBackColor = True
        Me.VPermisos.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VPermisos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VPermisos.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VPermisos.Appearance.VertLine.Options.UseBackColor = True
        Me.VPermisos.GridControl = Me.dgDetallePermisos
        Me.VPermisos.Name = "VPermisos"
        Me.VPermisos.OptionsBehavior.Editable = False
        Me.VPermisos.OptionsView.EnableAppearanceEvenRow = True
        Me.VPermisos.OptionsView.EnableAppearanceOddRow = True
        Me.VPermisos.OptionsView.ShowAutoFilterRow = True
        Me.VPermisos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VPermisos.OptionsView.ShowFooter = True
        Me.VPermisos.OptionsView.ShowGroupPanel = False
        '
        'dtpFFinal
        '
        Me.dtpFFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFFinal.Location = New System.Drawing.Point(128, 118)
        Me.dtpFFinal.Name = "dtpFFinal"
        Me.dtpFFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtpFFinal.TabIndex = 155
        '
        'txtCarencia
        '
        Me.txtCarencia.Location = New System.Drawing.Point(348, 36)
        Me.txtCarencia.Name = "txtCarencia"
        Me.txtCarencia.Size = New System.Drawing.Size(102, 20)
        Me.txtCarencia.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.txtCarencia.TabIndex = 176
        '
        'dtpFInicio
        '
        Me.dtpFInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFInicio.Location = New System.Drawing.Point(128, 94)
        Me.dtpFInicio.Name = "dtpFInicio"
        Me.dtpFInicio.Size = New System.Drawing.Size(99, 20)
        Me.dtpFInicio.TabIndex = 153
        '
        'txtprm_codigo
        '
        Me.txtprm_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprm_codigo.Enabled = False
        Me.txtprm_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprm_codigo.Location = New System.Drawing.Point(128, 70)
        Me.txtprm_codigo.MaxLength = 8
        Me.txtprm_codigo.Name = "txtprm_codigo"
        Me.txtprm_codigo.Size = New System.Drawing.Size(99, 20)
        Me.txtprm_codigo.TabIndex = 163
        '
        'CBTipo
        '
        Me.CBTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTipo.ItemHeight = 13
        Me.CBTipo.Location = New System.Drawing.Point(347, 70)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(214, 21)
        Me.CBTipo.TabIndex = 161
        '
        'txtVacacionesDisponibles
        '
        Me.txtVacacionesDisponibles.Location = New System.Drawing.Point(128, 36)
        Me.txtVacacionesDisponibles.Name = "txtVacacionesDisponibles"
        Me.txtVacacionesDisponibles.Size = New System.Drawing.Size(100, 20)
        Me.txtVacacionesDisponibles.StyleController = Me.frmAgregarPermisosConvertedLayout
        Me.txtVacacionesDisponibles.TabIndex = 175
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(128, 12)
        Me.txtNombre.MaxLength = 8
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(676, 20)
        Me.txtNombre.TabIndex = 171
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.lcTS, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(816, 510)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.DTPHFinal
        Me.LayoutControlItem6.CustomizationFormText = "DTPHFinalitem"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(219, 107)
        Me.LayoutControlItem6.Name = "DTPHFinalitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(234, 24)
        Me.LayoutControlItem6.Text = "Hora Final:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtFactorDia
        Me.LayoutControlItem8.CustomizationFormText = "Factor x Dia:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(442, 24)
        Me.LayoutControlItem8.Name = "txtFactorDiaitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(232, 24)
        Me.LayoutControlItem8.Text = "Factor x Dia:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.DTPHInicio
        Me.LayoutControlItem9.CustomizationFormText = "DTPHInicioitem"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(219, 83)
        Me.LayoutControlItem9.Name = "DTPHInicioitem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(234, 24)
        Me.LayoutControlItem9.Text = "Hora Inicio:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.dgDetallePermisos
        Me.LayoutControlItem10.CustomizationFormText = "dgDetallePermisositem"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 154)
        Me.LayoutControlItem10.Name = "dgDetallePermisositem"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(796, 310)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.dtpFFinal
        Me.LayoutControlItem11.CustomizationFormText = "dtpFFinalitem"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 106)
        Me.LayoutControlItem11.Name = "dtpFFinalitem"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(219, 25)
        Me.LayoutControlItem11.Text = "Fecha Final:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtCarencia
        Me.LayoutControlItem12.CustomizationFormText = "Carencia Disponible:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(220, 24)
        Me.LayoutControlItem12.Name = "txtCarenciaitem"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem12.Text = "Carencia Disponible:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.dtpFInicio
        Me.LayoutControlItem13.CustomizationFormText = "dtpFInicioitem"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem13.Name = "dtpFInicioitem"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(219, 24)
        Me.LayoutControlItem13.Text = "Fecha Inicio:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtprm_codigo
        Me.LayoutControlItem14.CustomizationFormText = "Codigo:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem14.Name = "txtprm_codigoitem"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(219, 24)
        Me.LayoutControlItem14.Text = "Codigo:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.CBTipo
        Me.LayoutControlItem15.CustomizationFormText = "Tipo de Permiso:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(219, 58)
        Me.LayoutControlItem15.Name = "CBTipoitem"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(334, 25)
        Me.LayoutControlItem15.Text = "Tipo de Permiso:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtVacacionesDisponibles
        Me.LayoutControlItem16.CustomizationFormText = "Vacaciones Disponibles:"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem16.Name = "txtVacacionesDisponiblesitem"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem16.Text = "Vacaciones Disponibles:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtNombre
        Me.LayoutControlItem17.CustomizationFormText = "Empleado:"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem17.Name = "txtNombreitem"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(796, 24)
        Me.LayoutControlItem17.Text = "Empleado:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(113, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 48)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(796, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtNota
        Me.LayoutControlItem3.CustomizationFormText = "txtNotaitem"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 131)
        Me.LayoutControlItem3.Name = "txtNotaitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(553, 23)
        Me.LayoutControlItem3.Text = "Nota:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(113, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 464)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(464, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdNuevo
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(464, 464)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cmdAceptar
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(547, 464)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cmdBorrar
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(630, 464)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cmdcancelar
        Me.LayoutControlItem21.CustomizationFormText = "LayoutControlItem21"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(713, 464)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(553, 82)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(243, 72)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(453, 83)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(100, 48)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'lcTS
        '
        Me.lcTS.Control = Me.cbTSubsidio
        Me.lcTS.CustomizationFormText = "Tipo Subsidio:"
        Me.lcTS.Location = New System.Drawing.Point(553, 58)
        Me.lcTS.Name = "lcTS"
        Me.lcTS.Size = New System.Drawing.Size(243, 24)
        Me.lcTS.Text = "Tipo Subsidio:"
        Me.lcTS.TextSize = New System.Drawing.Size(113, 13)
        Me.lcTS.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.chkSubsidio
        Me.LayoutControlItem7.CustomizationFormText = "chkSubsidioitem"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(674, 24)
        Me.LayoutControlItem7.Name = "chkSubsidioitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        Me.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'frmAgregarPermisos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 510)
        Me.Controls.Add(Me.frmAgregarPermisosConvertedLayout)
        Me.Name = "frmAgregarPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtFactorDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmAgregarPermisosConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAgregarPermisosConvertedLayout.ResumeLayout(False)
        CType(Me.cbTSubsidio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSubsidio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetallePermisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCarencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVacacionesDisponibles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Permisos de Empleado"

        inicio = Now.Date
        final = Now.Date


        VB.SysContab.PeriodoNominaDB.GetListFechaMinima_Nominas(inicio, final)

        Me.CBTipo.DataSource = VB.SysContab.TiposPermisosDB.GetList(False).Tables("TiposPermisos")
        Me.CBTipo.ValueMember = "Codigo"
        Me.CBTipo.DisplayMember = "Descripcion"

        Me.cbTSubsidio.Properties.DataSource = RH_TipoSubsidio.RH_GetList(0)
        Me.cbTSubsidio.Properties.PopulateColumns()
        Me.cbTSubsidio.Properties.ValueMember = "id"
        Me.cbTSubsidio.Properties.DisplayMember = "tds_descripcion"

        Me.cbTP.DataSource = VB.SysContab.TiposPermisosDB.GetList(False).Tables("TiposPermisos")
        Me.cbTP.ValueMember = "Codigo"
        Me.cbTP.DisplayMember = "Descripcion"
        Me.cbTP.PopulateColumns()
        Me.cbTP.Columns("Codigo").Visible = False

        Me.dgDetallePermisos.Enabled = True

        detEmpleados = VB.SysContab.EmpleadosDB.GetDetails(Registro)
        Me.txtNombre.Text = detEmpleados.Nombre
        Me.txtVacacionesDisponibles.Text = Math.Round(CDbl(detEmpleados.AcumVac), 2)

        FPEmpl = detEmpleados.FormaPago
        Me.dtpFFinal.MaxDate = DateTimePicker.MaximumDateTime
        Me.dtpFInicio.MaxDate = DateTimePicker.MaximumDateTime
        Me.dtpFFinal.MinDate = DateTimePicker.MinimumDateTime
        Me.dtpFInicio.MinDate = DateTimePicker.MinimumDateTime
        'buscar el detalle de permisos del empleado
        Me.cargar()

        If Me.VPermisos.DataRowCount > 0 Then
            Me.VPermisos.SelectRow(0)
            Nuevo = "NO"
            Me.txtprm_codigo.Text = Me.VPermisos.GetFocusedRowCellValue("Codigo")
            Me.dtpFInicio.Value = Me.VPermisos.GetFocusedRowCellValue("HoraInicio").date
            Me.dtpFFinal.Value = Me.VPermisos.GetFocusedRowCellValue("HoraFinal").date
            Me.DTPHInicio.Value = Me.VPermisos.GetFocusedRowCellValue("HoraInicio")
            Me.DTPHFinal.Value = Me.VPermisos.GetFocusedRowCellValue("HoraFinal")

        Else
            Nuevo = "SI"
            Me.txtprm_codigo.Text = VB.SysContab.PermisosDB.GetListCodigoNvo()

            Me.dtpFInicio.Value = inicio
            Me.dtpFFinal.Value = final

            Me.DTPHInicio.Value = Now
            Me.DTPHFinal.Value = Now

        End If




        'Checar empleados liquidados
        If detEmpleados.Liquidado = True Then
            Me.cmdNuevo.Enabled = False
            Me.cmdAceptar.Enabled = False
            Me.cmdBorrar.Enabled = False
        Else
            Me.cmdNuevo.Enabled = True
            Me.cmdAceptar.Enabled = True
            Me.cmdBorrar.Enabled = True
        End If

        Me.dtpFFinal.Enabled = False
        Me.dtpFInicio.Enabled = False
        Me.DTPHFinal.Enabled = False
        Me.DTPHInicio.Enabled = False

        If QuincenaTrabajo = "" Then
            Me.cmdNuevo.Enabled = False
            Me.cmdAceptar.Enabled = False
            Me.cmdBorrar.Enabled = False
        Else
            Me.cmdNuevo.Enabled = True
            Me.cmdAceptar.Enabled = True
            Me.cmdBorrar.Enabled = True

        End If
        Iniciado = True
        Me.Refresh()
    End Sub

    Private Sub cargar()
        Dim ds As DataSet

        ds = VB.SysContab.PermisosDB.GetList(Registro, False, False)
        ds.Relations.Add("Detalle", ds.Tables("Permisos").Columns("Codigo"), ds.Tables("PermisosDetalles").Columns("Codigo"))

        Me.dgDetallePermisos.DataSource = ds.Tables("Permisos")
        Me.VPermisos.Columns("Empleado").Visible = False
        Me.VPermisos.Columns("Tipo").ColumnEdit = Me.cbTP
        Me.VPermisos.Columns("Dias Solicitados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VPermisos.Columns("Dias Solicitados").DisplayFormat.FormatString = "n2"
        Me.VPermisos.Columns("Dias Solicitados").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VPermisos.Columns("Dias Solicitados").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VPermisos.Columns("Dias Procesados").Visible = True
        Me.VPermisos.Columns("Dias Procesados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VPermisos.Columns("Dias Procesados").DisplayFormat.FormatString = "n2"
        Me.VPermisos.Columns("Dias Procesados").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VPermisos.Columns("Dias Procesados").SummaryItem.DisplayFormat = "{0:n2}"

        Dim factores As New VB.SysContab.Factores_Permisos
        factores = VB.SysContab.PermisosDB.GetFactores(Registro, Now.Date)
        Me.txtCarencia.Text = factores.Carencias
        Me.txtFactorDia.Text = factores.FactorxDia

    End Sub
    


    Private Sub CBTipo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBTipo.SelectedValueChanged
        'If IsNumeric(Me.CBTipo.SelectedValue) Then
        '    'Si el empleado esta activo
        '    If detEmpleados.Fecha_FinContrato = "" Then
        '        Me.dtpFInicio.Value = Today.Date
        '        Me.dtpFFinal.Value = Today.Date
        '        Me.DTPHInicio.Value = Now
        '        Me.DTPHFinal.Value = Now

        '        If Nuevo = "SI" Then
        '            Me.dtpFInicio.MaxDate = inicio
        '            Me.dtpFFinal.MinDate = final
        '            Me.dtpFFinal.MaxDate = IIf(Me.CBTipo.SelectedValue = "1", DateTimePicker.MaximumDateTime, final)
        '        End If
        '    Else
        '        Me.dtpFInicio.Value = detEmpleados.Fecha_FinContrato
        '        Me.dtpFFinal.Value = detEmpleados.Fecha_FinContrato
        '        Me.DTPHInicio.Value = Now
        '        Me.DTPHFinal.Value = Now
        '        If Nuevo = "SI" Then
        '            Me.dtpFInicio.MinDate = inicio
        '            Me.dtpFInicio.MaxDate = detEmpleados.Fecha_FinContrato
        '            Me.dtpFFinal.MinDate = inicio
        '            Me.dtpFFinal.MaxDate = detEmpleados.Fecha_FinContrato
        '        End If
        '    End If
        'End If
        If Nuevo = "SI" Then
            Me.dtpFFinal.Enabled = True
            Me.dtpFInicio.Enabled = True
            Me.DTPHFinal.Enabled = True
            Me.DTPHInicio.Enabled = True
        Else
            Me.dtpFFinal.Enabled = False
            Me.dtpFInicio.Enabled = False
            Me.DTPHFinal.Enabled = False
            Me.DTPHInicio.Enabled = False
        End If

    End Sub

    Private Sub VPermisos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VPermisos.FocusedRowChanged
        If Not (Me.VPermisos.GetFocusedRowCellValue("Tipo") Is Nothing Or Me.VPermisos.GetFocusedRowCellValue("Tipo") Is DBNull.Value) Then
            Me.CBTipo.SelectedValue = Me.VPermisos.GetFocusedRowCellValue("Tipo")
            Me.txtprm_codigo.Text = Me.VPermisos.GetFocusedRowCellValue("Codigo")
            Me.dtpFInicio.Value = Me.VPermisos.GetFocusedRowCellValue("HoraInicio")
            Me.dtpFFinal.Value = Me.VPermisos.GetFocusedRowCellValue("HoraFinal")
            Me.DTPHInicio.Value = Me.VPermisos.GetFocusedRowCellValue("HoraInicio")
            Me.DTPHFinal.Value = Me.VPermisos.GetFocusedRowCellValue("HoraFinal")
            Me.txtNota.Text = Me.VPermisos.GetFocusedRowCellValue("Nota")
        Else
            Me.CBTipo.SelectedValue = -1
            Me.txtprm_codigo.Text = ""
            Me.dtpFInicio.Value = Now.Date
            Me.dtpFFinal.Value = Me.dtpFInicio.Value
            Me.DTPHInicio.Value = Me.dtpFInicio.Value
            Me.DTPHFinal.Value = Me.dtpFInicio.Value
            Me.txtNota.Text = ""
        End If
    End Sub

    Private Sub VPermisos_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles VPermisos.MasterRowExpanded

        If Me.dgDetallePermisos.Views.Count > 1 Then
            'Ver el detalle
            For i As Integer = 1 To Me.dgDetallePermisos.Views.Count - 1
                If Me.dgDetallePermisos.Views(i).DetailLevel = 1 Then
                    Dim xcosa As New DevExpress.XtraGrid.Views.Grid.GridView
                    xcosa = Me.dgDetallePermisos.Views(i)
                    xcosa.OptionsBehavior.Editable = False
                    xcosa.Columns(0).Width = 100
                    xcosa.Columns(1).Width = 100
                    xcosa.Columns(2).Width = 100
                    xcosa.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    xcosa.Columns(3).DisplayFormat.FormatString = "{0:n2}"
                    xcosa.Columns(3).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    xcosa.Columns(3).SummaryItem.DisplayFormat = "{0:n2}"

                    xcosa.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    xcosa.Columns(4).DisplayFormat.FormatString = "{0:n2}"
                    xcosa.Columns(4).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    xcosa.Columns(4).SummaryItem.DisplayFormat = "{0:n2}"

                    xcosa.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    xcosa.Columns(5).DisplayFormat.FormatString = "{0:n2}"
                    xcosa.Columns(5).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    xcosa.Columns(5).SummaryItem.DisplayFormat = "{0:n2}"

                    xcosa.OptionsView.ShowAutoFilterRow = True
                    xcosa.OptionsView.ShowFooter = True

                    'Apariencia
                    xcosa.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButton.Options.UseBackColor = True
                    xcosa.Appearance.ColumnFilterButton.Options.UseBorderColor = True
                    xcosa.Appearance.ColumnFilterButton.Options.UseForeColor = True
                    xcosa.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
                    xcosa.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
                    xcosa.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
                    xcosa.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.Empty.BackColor2 = System.Drawing.Color.White
                    xcosa.Appearance.Empty.Options.UseBackColor = True
                    xcosa.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
                    xcosa.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.EvenRow.Options.UseBackColor = True
                    xcosa.Appearance.EvenRow.Options.UseForeColor = True
                    xcosa.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.FilterCloseButton.Options.UseBackColor = True
                    xcosa.Appearance.FilterCloseButton.Options.UseBorderColor = True
                    xcosa.Appearance.FilterCloseButton.Options.UseForeColor = True
                    xcosa.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
                    xcosa.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FilterPanel.Options.UseBackColor = True
                    xcosa.Appearance.FilterPanel.Options.UseForeColor = True
                    xcosa.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
                    xcosa.Appearance.FixedLine.Options.UseBackColor = True
                    xcosa.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
                    xcosa.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.FocusedCell.Options.UseBackColor = True
                    xcosa.Appearance.FocusedCell.Options.UseForeColor = True
                    xcosa.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
                    xcosa.Appearance.FocusedRow.Options.UseBackColor = True
                    xcosa.Appearance.FocusedRow.Options.UseForeColor = True
                    xcosa.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black 'System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.FooterPanel.Options.UseBackColor = True
                    xcosa.Appearance.FooterPanel.Options.UseBorderColor = True
                    xcosa.Appearance.FooterPanel.Options.UseForeColor = True
                    xcosa.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.GroupButton.Options.UseBackColor = True
                    xcosa.Appearance.GroupButton.Options.UseBorderColor = True
                    xcosa.Appearance.GroupButton.Options.UseForeColor = True
                    xcosa.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.GroupFooter.Options.UseBackColor = True
                    xcosa.Appearance.GroupFooter.Options.UseBorderColor = True
                    xcosa.Appearance.GroupFooter.Options.UseForeColor = True
                    xcosa.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
                    xcosa.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.GroupPanel.Options.UseBackColor = True
                    xcosa.Appearance.GroupPanel.Options.UseForeColor = True
                    xcosa.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.GroupRow.Options.UseBackColor = True
                    xcosa.Appearance.GroupRow.Options.UseBorderColor = True
                    xcosa.Appearance.GroupRow.Options.UseForeColor = True
                    xcosa.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
                    xcosa.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    xcosa.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.HeaderPanel.Options.UseBackColor = True
                    xcosa.Appearance.HeaderPanel.Options.UseBorderColor = True
                    xcosa.Appearance.HeaderPanel.Options.UseFont = True
                    xcosa.Appearance.HeaderPanel.Options.UseForeColor = True
                    xcosa.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
                    xcosa.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.HideSelectionRow.Options.UseBackColor = True
                    xcosa.Appearance.HideSelectionRow.Options.UseForeColor = True
                    xcosa.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
                    xcosa.Appearance.HorzLine.Options.UseBackColor = True
                    xcosa.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
                    xcosa.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.OddRow.Options.UseBackColor = True
                    xcosa.Appearance.OddRow.Options.UseForeColor = True
                    xcosa.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
                    xcosa.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
                    xcosa.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
                    xcosa.Appearance.Preview.Options.UseBackColor = True
                    xcosa.Appearance.Preview.Options.UseFont = True
                    xcosa.Appearance.Preview.Options.UseForeColor = True
                    xcosa.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
                    xcosa.Appearance.Row.ForeColor = System.Drawing.Color.Black
                    xcosa.Appearance.Row.Options.UseBackColor = True
                    xcosa.Appearance.Row.Options.UseForeColor = True
                    xcosa.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
                    xcosa.Appearance.RowSeparator.Options.UseBackColor = True
                    xcosa.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
                    xcosa.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
                    xcosa.Appearance.SelectedRow.Options.UseBackColor = True
                    xcosa.Appearance.SelectedRow.Options.UseForeColor = True
                    xcosa.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
                    xcosa.Appearance.TopNewRow.Options.UseBackColor = True
                    xcosa.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
                    xcosa.Appearance.VertLine.Options.UseBackColor = True

                End If

            Next
        End If
    End Sub

    Private Sub Vista_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles VPermisos.GridMenuItemClick
        Dim sumFormat As String
        Dim subSumFormat As Integer
        sumFormat = e.SummaryFormat
        subSumFormat = sumFormat.IndexOf("0")
        If subSumFormat > 0 Then sumFormat = sumFormat.Substring(0, subSumFormat) + "0:n2}"
        e.SummaryFormat = sumFormat

    End Sub

    Private Sub CBTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTipo.SelectedIndexChanged
        If Iniciado Then
            Me.cbTSubsidio.EditValue = Nothing
            If Me.CBTipo.SelectedValue = 1 Then
                'Subsidio
                'Me.chkSubsidio.Visible = True
                Me.lcTS.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Else
                'Me.chkSubsidio.Visible = False
                Me.lcTS.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        If detEmpleados.Liquidado Then
            MsgBox("No se puede ingresar permisos de un empleado que esta liquidado", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        Else
            Me.dgDetallePermisos.Enabled = True
        End If
        'If detEmpleados.Fecha_FinContrato = "" Then
        '    Me.dtpFInicio.Value = Today.Date
        '    Me.dtpFInicio.MinDate = inicio
        '    Me.dtpFInicio.MaxDate = final

        '    Me.dtpFFinal.Value = Today.Date
        '    Me.dtpFFinal.MinDate = inicio
        '    Me.dtpFFinal.MaxDate = final

        '    'Me.dtpFFinal.Enabled = True
        '    'Me.dtpFInicio.Enabled = True
        '    Me.DTPHInicio.Value = Now
        '    Me.DTPHFinal.Value = Now
        'Else
        '    Me.dtpFInicio.Value = detEmpleados.Fecha_FinContrato
        '    Me.dtpFInicio.MinDate = inicio
        '    Me.dtpFInicio.MaxDate = detEmpleados.Fecha_FinContrato

        '    Me.dtpFFinal.Value = detEmpleados.Fecha_FinContrato
        '    Me.dtpFFinal.MinDate = inicio
        '    Me.dtpFFinal.MaxDate = detEmpleados.Fecha_FinContrato

        '    'Me.dtpFFinal.Enabled = False
        '    'Me.dtpFInicio.Enabled = False

        '    Me.DTPHInicio.Value = Now
        '    Me.DTPHFinal.Value = Now
        'End If

        Me.txtprm_codigo.Text = VB.SysContab.PermisosDB.GetListCodigoNvo()
        Me.cmdAceptar.Enabled = True
        Me.cmdAceptar.Focus()
        Me.cmdNuevo.Enabled = False
        Nuevo = "SI"
        Me.dgDetallePermisos.Enabled = False
        Me.txtNota.Text = ""

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim PInicio, PFinal As DateTime
        Dim Permisos As New VB.SysContab.PermisosDB()

        Dim PeriodoDetails As New VB.SysContab.PeriodoNominaDetails()

        PInicio = Format(Me.dtpFInicio.Value, "d") & " " & Format(Me.DTPHInicio.Value, "hh:mm tt")
        PFinal = Format(Me.dtpFFinal.Value, "d") & " " & Format(Me.DTPHFinal.Value, "hh:mm tt")

        'Carencias con goce de salario
        If DateDiff(DateInterval.Day, PInicio, PFinal) > Me.txtCarencia.Text And Me.CBTipo.SelectedValue = 10 Then
            MsgBox("No tiene suficiente dias Carencia para solicitar este permiso", MsgBoxStyle.Critical, "sts.Nomina")
            Exit Sub
        End If

        PeriodoDetails = VB.SysContab.PeriodoNominaDB.GetListBuscarFInicio(CDate(Format(PInicio, "d")), FPEmpl)
        If PeriodoDetails.Codigo Is Nothing Then
            MsgBox("No existe Periodo de Nomina que abarque el periodo del permiso", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If Me.CBTipo.SelectedIndex = 0 Then
            If Me.cbTSubsidio.EditValue Is Nothing Then
                MsgBox("Seleccione un tipo de Subsidio", MsgBoxStyle.Critical, "Sts.Nomina")
                Exit Sub
            End If
            If IsDBNull(Me.cbTSubsidio.EditValue) Then
                MsgBox("Seleccione un tipo de Subsidio", MsgBoxStyle.Critical, "Sts.Nomina")
                Exit Sub
            End If
        Else
            Me.cbTSubsidio.EditValue = 0
        End If
        If Nuevo = "SI" Then

            'Calcular el nuevo codigo
            Me.txtprm_codigo.Text = VB.SysContab.PermisosDB.GetListCodigoNvo()
            VB.SysContab.PermisosDB.Additem(Me.txtprm_codigo.Text, Registro, PInicio, PFinal, _
            Me.CBTipo.SelectedValue, PeriodoDetails.Tipo, PeriodoDetails.Codigo, Me.txtNota.Text, _
            Me.chkSubsidio.Checked, Me.cbTSubsidio.EditValue)
        Else ' EDICION

            If Me.VPermisos.DataRowCount = 0 Then
                MsgBox("No hay nada que actualizar", MsgBoxStyle.OkOnly)
            Else
                VB.SysContab.PermisosDB.Update(Me.txtprm_codigo.Text, Registro, PInicio, PFinal, Me.CBTipo.SelectedValue, PeriodoDetails.Tipo, PeriodoDetails.Codigo, Me.txtNota.Text)
            End If
        End If
        Me.cmdAceptar.Enabled = False
        Me.cmdNuevo.Enabled = True
        Me.cmdNuevo.Focus()
        Me.dgDetallePermisos.Enabled = True

        'buscar el detalle de permisos del empleado
        Me.cargar()
        Nuevo = "NO"

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        Dim detalle As New VB.SysContab.PermisosDetails()

        If Me.VPermisos.DataRowCount = 0 Then
            MsgBox("No hay nada que borrar", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If Me.VPermisos.GetFocusedRowCellValue("Tipo") Is Nothing Or _
            Me.VPermisos.GetFocusedRowCellValue("Tipo") Is DBNull.Value Then
            MsgBox("No hay registros que borrar", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        'Ver si ya tiene generados detalles 
        detalle = VB.SysContab.PermisosDB.GetDetails(Me.VPermisos.GetFocusedRowCellValue("Codigo"))
        If detalle.Codigo Is DBNull.Value Or detalle.Codigo Is Nothing Then
            MsgBox("No se ha seleccionado correctamente el registro", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If detalle.Aplicado = False And detalle.Dias_Procesados = 0 Then
            VB.SysContab.PermisosDB.delete(detalle.Codigo)
            Me.cargar()
            Me.Refresh()
        Else
            MsgBox("Este permiso ya ha sido aplicado en la Nomina del Periodo " & detalle.TPeriodo & "-" & detalle.Periodo, MsgBoxStyle.OkOnly)
            detalle = Nothing
            Exit Sub
        End If
        detalle = Nothing
    End Sub
End Class
