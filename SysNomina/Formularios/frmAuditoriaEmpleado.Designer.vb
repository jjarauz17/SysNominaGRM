<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditoriaEmpleado
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
        Me.dgAuditoria = New DevExpress.XtraGrid.GridControl
        Me.vAuditoria = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Empleado = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cbLocalidad = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cbDepartamento = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cbArea = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdExportar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cbempleado = New DevExpress.XtraEditors.GridLookUpEdit
        Me.VistaEmpleado = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.chkSelector = New DevExpress.XtraEditors.CheckEdit
        CType(Me.dgAuditoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vAuditoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbempleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAuditoria
        '
        Me.dgAuditoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAuditoria.EmbeddedNavigator.Name = ""
        Me.dgAuditoria.Location = New System.Drawing.Point(12, 53)
        Me.dgAuditoria.MainView = Me.vAuditoria
        Me.dgAuditoria.Name = "dgAuditoria"
        Me.dgAuditoria.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Empleado, Me.cbLocalidad, Me.cbDepartamento, Me.cbArea})
        Me.dgAuditoria.Size = New System.Drawing.Size(507, 206)
        Me.dgAuditoria.TabIndex = 0
        Me.dgAuditoria.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vAuditoria})
        '
        'vAuditoria
        '
        Me.vAuditoria.GridControl = Me.dgAuditoria
        Me.vAuditoria.Name = "vAuditoria"
        Me.vAuditoria.OptionsBehavior.Editable = False
        Me.vAuditoria.OptionsSelection.MultiSelect = True
        Me.vAuditoria.OptionsView.ShowAutoFilterRow = True
        Me.vAuditoria.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vAuditoria.OptionsView.ShowFooter = True
        Me.vAuditoria.OptionsView.ShowGroupPanel = False
        '
        'Empleado
        '
        Me.Empleado.AutoHeight = False
        Me.Empleado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Empleado.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Name3", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 150)})
        Me.Empleado.Name = "Empleado"
        Me.Empleado.NullText = ""
        '
        'cbLocalidad
        '
        Me.cbLocalidad.AutoHeight = False
        Me.cbLocalidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLocalidad.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 150)})
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.NullText = ""
        '
        'cbDepartamento
        '
        Me.cbDepartamento.AutoHeight = False
        Me.cbDepartamento.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDepartamento.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Name5", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 150)})
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.NullText = ""
        '
        'cbArea
        '
        Me.cbArea.AutoHeight = False
        Me.cbArea.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbArea.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Area", "Name7", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 150)})
        Me.cbArea.Name = "cbArea"
        Me.cbArea.NullText = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdExportar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 54)
        Me.GroupBox1.TabIndex = 173
        Me.GroupBox1.TabStop = False
        '
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(88, 19)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(75, 23)
        Me.cmdExportar.TabIndex = 170
        Me.cmdExportar.Text = "Exportar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(6, 19)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 168
        Me.cmdAceptar.Text = "Consultar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(426, 19)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 169
        Me.cmdSalir.Text = "Salir"
        '
        'cbempleado
        '
        Me.cbempleado.EditValue = ""
        Me.cbempleado.Location = New System.Drawing.Point(68, 5)
        Me.cbempleado.Name = "cbempleado"
        Me.cbempleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbempleado.Properties.NullText = ""
        Me.cbempleado.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cbempleado.Properties.PopupSizeable = False
        Me.cbempleado.Properties.ShowFooter = False
        Me.cbempleado.Properties.View = Me.VistaEmpleado
        Me.cbempleado.Size = New System.Drawing.Size(333, 20)
        Me.cbempleado.TabIndex = 172
        '
        'VistaEmpleado
        '
        Me.VistaEmpleado.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.Empty.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.VistaEmpleado.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.EvenRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.EvenRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VistaEmpleado.Appearance.FixedLine.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.FocusedCell.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FocusedCell.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.FooterPanel.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupButton.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.GroupButton.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.GroupFooter.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.GroupRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.GroupRow.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.GroupRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaEmpleado.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VistaEmpleado.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VistaEmpleado.Appearance.HeaderPanel.Options.UseFont = True
        Me.VistaEmpleado.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.VistaEmpleado.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VistaEmpleado.Appearance.HorzLine.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.VistaEmpleado.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.OddRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.OddRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.VistaEmpleado.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.VistaEmpleado.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VistaEmpleado.Appearance.Preview.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.Preview.Options.UseFont = True
        Me.VistaEmpleado.Appearance.Preview.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.VistaEmpleado.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.VistaEmpleado.Appearance.Row.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.Row.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.VistaEmpleado.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VistaEmpleado.Appearance.SelectedRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.SelectedRow.Options.UseForeColor = True
        Me.VistaEmpleado.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.VistaEmpleado.Appearance.TopNewRow.Options.UseBackColor = True
        Me.VistaEmpleado.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VistaEmpleado.Appearance.VertLine.Options.UseBackColor = True
        Me.VistaEmpleado.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Codigo, Me.Nombre})
        Me.VistaEmpleado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.VistaEmpleado.Name = "VistaEmpleado"
        Me.VistaEmpleado.OptionsBehavior.Editable = False
        Me.VistaEmpleado.OptionsCustomization.AllowColumnMoving = False
        Me.VistaEmpleado.OptionsCustomization.AllowColumnResizing = False
        Me.VistaEmpleado.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.VistaEmpleado.OptionsView.EnableAppearanceEvenRow = True
        Me.VistaEmpleado.OptionsView.EnableAppearanceOddRow = True
        Me.VistaEmpleado.OptionsView.ShowAutoFilterRow = True
        Me.VistaEmpleado.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VistaEmpleado.OptionsView.ShowGroupPanel = False
        '
        'Codigo
        '
        Me.Codigo.Caption = "Código"
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 0
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 171
        Me.LabelControl1.Text = "Empleado:"
        '
        'chkSelector
        '
        Me.chkSelector.Location = New System.Drawing.Point(10, 31)
        Me.chkSelector.Name = "chkSelector"
        Me.chkSelector.Properties.Caption = "Mostrar Selector de Campos"
        Me.chkSelector.Size = New System.Drawing.Size(162, 19)
        Me.chkSelector.TabIndex = 174
        '
        'frmAuditoriaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 324)
        Me.Controls.Add(Me.chkSelector)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbempleado)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.dgAuditoria)
        Me.Name = "frmAuditoriaEmpleado"
        Me.Text = "Auditoría Cambio de Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgAuditoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vAuditoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cbempleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgAuditoria As DevExpress.XtraGrid.GridControl
    Friend WithEvents vAuditoria As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbempleado As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents VistaEmpleado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSelector As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Empleado As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbLocalidad As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbDepartamento As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbArea As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
