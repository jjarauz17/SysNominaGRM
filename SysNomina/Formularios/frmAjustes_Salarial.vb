Imports System.Data
Imports System.Data.SqlClient

Public Class frmAjustes_Salarial
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAjustes_Salarial = Nothing

    Public Shared Function Instance() As frmAjustes_Salarial
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAjustes_Salarial()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAprobar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRevisar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbPeriodosN As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSalario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnIngresar As DevExpress.XtraEditors.SimpleButton


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
    Friend WithEvents dgEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents vEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgEmpleados = New DevExpress.XtraGrid.GridControl
        Me.vEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtSalario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.cbMoneda = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton
        Me.btnAprobar = New DevExpress.XtraEditors.SimpleButton
        Me.btnRevisar = New DevExpress.XtraEditors.SimpleButton
        Me.btnIngresar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cbPeriodosN = New DevExpress.XtraEditors.LookUpEdit
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cbPeriodosN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgEmpleados
        '
        Me.dgEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpleados.EmbeddedNavigator.Name = ""
        Me.dgEmpleados.Location = New System.Drawing.Point(12, 63)
        Me.dgEmpleados.MainView = Me.vEmpleados
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtSalario, Me.cbMoneda})
        Me.dgEmpleados.Size = New System.Drawing.Size(643, 199)
        Me.dgEmpleados.TabIndex = 15
        Me.dgEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vEmpleados})
        '
        'vEmpleados
        '
        Me.vEmpleados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vEmpleados.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vEmpleados.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vEmpleados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vEmpleados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vEmpleados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vEmpleados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vEmpleados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vEmpleados.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.vEmpleados.Appearance.Empty.Options.UseBackColor = True
        Me.vEmpleados.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.vEmpleados.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.vEmpleados.Appearance.EvenRow.Options.UseBackColor = True
        Me.vEmpleados.Appearance.EvenRow.Options.UseForeColor = True
        Me.vEmpleados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vEmpleados.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vEmpleados.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.vEmpleados.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.vEmpleados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vEmpleados.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vEmpleados.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vEmpleados.Appearance.FixedLine.Options.UseBackColor = True
        Me.vEmpleados.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vEmpleados.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vEmpleados.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vEmpleados.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vEmpleados.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vEmpleados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vEmpleados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vEmpleados.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.vEmpleados.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.vEmpleados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vEmpleados.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vEmpleados.Appearance.FooterPanel.Options.UseFont = True
        Me.vEmpleados.Appearance.FooterPanel.Options.UseForeColor = True
        Me.vEmpleados.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.GroupButton.Options.UseBackColor = True
        Me.vEmpleados.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vEmpleados.Appearance.GroupButton.Options.UseForeColor = True
        Me.vEmpleados.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vEmpleados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vEmpleados.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vEmpleados.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vEmpleados.Appearance.GroupFooter.Options.UseForeColor = True
        Me.vEmpleados.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.vEmpleados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.vEmpleados.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vEmpleados.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vEmpleados.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vEmpleados.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vEmpleados.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.GroupRow.Options.UseBackColor = True
        Me.vEmpleados.Appearance.GroupRow.Options.UseBorderColor = True
        Me.vEmpleados.Appearance.GroupRow.Options.UseForeColor = True
        Me.vEmpleados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vEmpleados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vEmpleados.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.vEmpleados.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vEmpleados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.vEmpleados.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.vEmpleados.Appearance.HeaderPanel.Options.UseFont = True
        Me.vEmpleados.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.vEmpleados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.vEmpleados.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vEmpleados.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vEmpleados.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vEmpleados.Appearance.HorzLine.Options.UseBackColor = True
        Me.vEmpleados.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.vEmpleados.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.vEmpleados.Appearance.OddRow.Options.UseBackColor = True
        Me.vEmpleados.Appearance.OddRow.Options.UseForeColor = True
        Me.vEmpleados.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.vEmpleados.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.vEmpleados.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vEmpleados.Appearance.Preview.Options.UseBackColor = True
        Me.vEmpleados.Appearance.Preview.Options.UseFont = True
        Me.vEmpleados.Appearance.Preview.Options.UseForeColor = True
        Me.vEmpleados.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.vEmpleados.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.vEmpleados.Appearance.Row.Options.UseBackColor = True
        Me.vEmpleados.Appearance.Row.Options.UseForeColor = True
        Me.vEmpleados.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.vEmpleados.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vEmpleados.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.vEmpleados.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vEmpleados.Appearance.SelectedRow.Options.UseBackColor = True
        Me.vEmpleados.Appearance.SelectedRow.Options.UseForeColor = True
        Me.vEmpleados.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.vEmpleados.Appearance.TopNewRow.Options.UseBackColor = True
        Me.vEmpleados.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vEmpleados.Appearance.VertLine.Options.UseBackColor = True
        Me.vEmpleados.GridControl = Me.dgEmpleados
        Me.vEmpleados.Name = "vEmpleados"
        Me.vEmpleados.OptionsSelection.MultiSelect = True
        Me.vEmpleados.OptionsView.EnableAppearanceEvenRow = True
        Me.vEmpleados.OptionsView.EnableAppearanceOddRow = True
        Me.vEmpleados.OptionsView.ShowAutoFilterRow = True
        Me.vEmpleados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vEmpleados.OptionsView.ShowFooter = True
        Me.vEmpleados.OptionsView.ShowGroupedColumns = True
        Me.vEmpleados.OptionsView.ShowGroupPanel = False
        '
        'txtSalario
        '
        Me.txtSalario.AutoHeight = False
        Me.txtSalario.Mask.EditMask = "n2"
        Me.txtSalario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSalario.Mask.UseMaskAsDisplayFormat = True
        Me.txtSalario.Name = "txtSalario"
        '
        'cbMoneda
        '
        Me.cbMoneda.AutoHeight = False
        Me.cbMoneda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.ShowFooter = False
        Me.cbMoneda.ShowHeader = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btnGuardar)
        Me.PanelControl1.Controls.Add(Me.btnQuit)
        Me.PanelControl1.Controls.Add(Me.btnAprobar)
        Me.PanelControl1.Controls.Add(Me.btnRevisar)
        Me.PanelControl1.Controls.Add(Me.btnIngresar)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 268)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(643, 52)
        Me.PanelControl1.TabIndex = 16
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(128, 11)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(116, 30)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar Cambios"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Appearance.Options.UseFont = True
        Me.btnQuit.Location = New System.Drawing.Point(519, 11)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(100, 30)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "&Salir"
        '
        'btnAprobar
        '
        Me.btnAprobar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.Appearance.Options.UseFont = True
        Me.btnAprobar.Location = New System.Drawing.Point(375, 11)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(100, 30)
        Me.btnAprobar.TabIndex = 0
        Me.btnAprobar.Text = "&Aprobar"
        '
        'btnRevisar
        '
        Me.btnRevisar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevisar.Appearance.Options.UseFont = True
        Me.btnRevisar.Location = New System.Drawing.Point(250, 11)
        Me.btnRevisar.Name = "btnRevisar"
        Me.btnRevisar.Size = New System.Drawing.Size(119, 30)
        Me.btnRevisar.TabIndex = 0
        Me.btnRevisar.Text = "&Guardar Revisión"
        '
        'btnIngresar
        '
        Me.btnIngresar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Appearance.Options.UseFont = True
        Me.btnIngresar.Location = New System.Drawing.Point(21, 11)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(101, 30)
        Me.btnIngresar.TabIndex = 0
        Me.btnIngresar.Text = "&Ingresar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Peridodo Nomina:"
        '
        'cbPeriodosN
        '
        Me.cbPeriodosN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPeriodosN.Location = New System.Drawing.Point(116, 16)
        Me.cbPeriodosN.Name = "cbPeriodosN"
        Me.cbPeriodosN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodosN.Properties.Appearance.Options.UseFont = True
        Me.cbPeriodosN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodosN.Properties.ShowFooter = False
        Me.cbPeriodosN.Properties.ShowHeader = False
        Me.cbPeriodosN.Size = New System.Drawing.Size(539, 22)
        Me.cbPeriodosN.TabIndex = 18
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(10, 41)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Mostrador de Datos"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(168, 22)
        Me.CheckEdit1.TabIndex = 19
        '
        'frmAjustes_Salarial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(667, 332)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.cbPeriodosN)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Name = "frmAjustes_Salarial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.cbPeriodosN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim DT As DataTable

    Private Sub frmAjustes_Salarial_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.CheckEdit1.Checked = False
    End Sub

    Private Sub frmAjustes_Salarial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbPeriodosN.Properties.DataSource = ObtieneData("sp_GetPeriodoNominaList " & EmpresaActual)
        Me.cbPeriodosN.Properties.ValueMember = "Per_codigo"
        Me.cbPeriodosN.Properties.DisplayMember = "Nombre"
        Me.cbPeriodosN.Properties.PopulateColumns()
        Me.cbPeriodosN.Properties.Columns(0).Visible = False
        Me.cbPeriodosN.ItemIndex = 0

        Me.cbMoneda.DataSource = ObtieneData("SELECT m.mon_codigo,m.mon_simbolo + ' - ' + m.mon_descripcion Nombre,m.mon_simbolo Display" _
                                             + " FROM Monedas m WHERE m.empr_codigo = " & EmpresaActual)
        Me.cbMoneda.ValueMember = "mon_codigo"
        Me.cbMoneda.DisplayMember = "Display"
        Me.cbMoneda.PopulateColumns()
        Me.cbMoneda.Columns("mon_codigo").Visible = False
        Me.cbMoneda.Columns("Display").Visible = False

        Me.Text = "Ajuste Salarial Empleados"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        If EmpresaActual <> 14 Then 'Validar Para Cafe Don Paco.
            Dim dtS As DataTable = ObtieneDatos("SELECT * FROM TablaSalarial ts WHERE ts.Empresa = " & EmpresaActual)

            If dtS.Rows.Count = 0 Then
                MsgBox("No se ha Creado la Tabla Salarial Para la Empresa Seleccionada," & vbCrLf & _
                       "Favor Crear Tablas Salariales para Realizar Cambios al Salario de los empleados", MsgBoxStyle.Exclamation)
                DeshabilitarBotones()
            Else
                If dtS.Rows.Item(0)("Estado") = 0 Then
                    MsgBox("La Tabla Salarial no ha sido aprobada aún," & vbCrLf & _
                       "Favor Aprobar Tablas Salariales para Realizar Cambios al Salario de los empleados", MsgBoxStyle.Exclamation)
                    DeshabilitarBotones()
                End If
            End If
        End If

        Me.Refresh()
    End Sub

    Sub DeshabilitarBotones()
        Me.btnIngresar.Enabled = False
        Me.btnGuardar.Enabled = False
        Me.btnRevisar.Enabled = False
        Me.btnAprobar.Enabled = False
    End Sub

    Public Sub Cargar()
        Try
            DT = ObtieneData("sp_GetListEmpleadosAjuste '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual)

            dgEmpleados.DataSource = DT.DefaultView
            Me.vEmpleados.PopulateColumns()
            FormatoGrid(Me.vEmpleados)

            If EmpresaActual = 14 Then
                Me.vEmpleados.Columns("S.Mínimo").Visible = False
                Me.vEmpleados.Columns("S.Máximo").Visible = False
            End If

            Me.vEmpleados.Columns("Codigo").BestFit()
            Me.vEmpleados.Columns("Nombre").BestFit()
            Me.vEmpleados.Columns("Cargo").BestFit()

            Me.vEmpleados.Columns("Liquidado").Visible = False
            Me.vEmpleados.Columns("FormaPago").Visible = False
            Me.vEmpleados.Columns("F.Ingreso").Visible = False
            Me.vEmpleados.Columns("Sexo").Visible = False
            Me.vEmpleados.Columns("Per_Codigo").Visible = False
            Me.vEmpleados.Columns("A Partir de").Visible = False
            Me.vEmpleados.Columns("SalarioA").Visible = False
            Me.vEmpleados.Columns("SalarioB").Visible = False
            Me.vEmpleados.Columns("SalarioC").Visible = False

            Me.vEmpleados.Columns("Liquidado").OptionsColumn.ShowInCustomizationForm = False
            Me.vEmpleados.Columns("FormaPago").OptionsColumn.ShowInCustomizationForm = False
            Me.vEmpleados.Columns("Per_Codigo").OptionsColumn.ShowInCustomizationForm = False
            Me.vEmpleados.Columns("A Partir de").OptionsColumn.ShowInCustomizationForm = False
            Me.vEmpleados.Columns("SalarioA").OptionsColumn.ShowInCustomizationForm = False
            Me.vEmpleados.Columns("SalarioB").OptionsColumn.ShowInCustomizationForm = False
            Me.vEmpleados.Columns("SalarioC").OptionsColumn.ShowInCustomizationForm = False

            Me.vEmpleados.Columns("S.Mensual").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vEmpleados.Columns("S.Mensual").DisplayFormat.FormatString = "{0:n2}"
            Me.vEmpleados.Columns("S.Mensual").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vEmpleados.Columns("S.Mensual").SummaryItem.DisplayFormat = "{0:n2}"

            Me.vEmpleados.Columns("S.Aprobar").ColumnEdit = Me.txtSalario
            Me.vEmpleados.Columns("S.Aprobar").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vEmpleados.Columns("S.Aprobar").SummaryItem.DisplayFormat = "{0:n2}"
            Me.vEmpleados.Columns("Moneda").ColumnEdit = Me.cbMoneda

            Me.vEmpleados.Columns("S.Mínimo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vEmpleados.Columns("S.Mínimo").DisplayFormat.FormatString = "{0:n2}"
            Me.vEmpleados.Columns("S.Mínimo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vEmpleados.Columns("S.Mínimo").SummaryItem.DisplayFormat = "{0:n2}"

            Me.vEmpleados.Columns("S.Máximo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vEmpleados.Columns("S.Máximo").DisplayFormat.FormatString = "{0:n2}"
            Me.vEmpleados.Columns("S.Máximo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vEmpleados.Columns("S.Máximo").SummaryItem.DisplayFormat = "{0:n2}"

            For i As Integer = 0 To Me.vEmpleados.Columns.Count - 1
                Me.vEmpleados.Columns(i).OptionsColumn.AllowEdit = False
                Me.vEmpleados.Columns(i).OptionsColumn.AllowFocus = False
            Next

            Me.vEmpleados.Columns("S.Aprobar").OptionsColumn.AllowEdit = True
            Me.vEmpleados.Columns("Moneda").OptionsColumn.AllowEdit = True
            Me.vEmpleados.Columns("Cambiar").OptionsColumn.AllowEdit = True
            'Me.Empleados.Columns("A Partir de").OptionsColumn.AllowEdit = True

            Me.vEmpleados.Columns("S.Aprobar").OptionsColumn.AllowFocus = True
            Me.vEmpleados.Columns("Moneda").OptionsColumn.AllowFocus = True
            Me.vEmpleados.Columns("Cambiar").OptionsColumn.AllowFocus = True
            ''Me.Empleados.Columns("A Partir de").OptionsColumn.AllowFocus = True

            If ObtieneDatos("sp_GetEstado '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual).Rows.Count > 0 Then
                If ObtieneDatos("sp_GetEstado '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual).Rows.Item(0)("Estado") = "APROBADO" Then
                    Me.vEmpleados.Columns("S.Aprobar").OptionsColumn.AllowEdit = False
                    Me.vEmpleados.Columns("Moneda").OptionsColumn.AllowEdit = False
                    Me.vEmpleados.Columns("Cambiar").OptionsColumn.AllowEdit = False
                    'Me.Empleados.Columns("A Partir de").OptionsColumn.AllowEdit = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Sub ValidarBotones()
    '    If Empleados.DataRowCount = 0 Then
    '        Me.btnIngresar.Enabled = True
    '        Me.btnRevisar.Enabled = False
    '        Me.btnAprobar.Enabled = False
    '        Me.btnGuardar.Enabled = False
    '    ElseIf Me.Empleados.GetRowCellValue(0, "Estado") = "INGRESADO" Then
    '        Me.btnIngresar.Enabled = False
    '        Me.btnRevisar.Enabled = True
    '        Me.btnAprobar.Enabled = False
    '        Me.btnGuardar.Enabled = True
    '    ElseIf Me.Empleados.GetRowCellValue(0, "Estado") = "REVISADO" Then
    '        Me.btnIngresar.Enabled = False
    '        Me.btnRevisar.Enabled = False
    '        Me.btnAprobar.Enabled = True
    '        Me.btnGuardar.Enabled = True
    '    ElseIf Me.Empleados.GetRowCellValue(0, "Estado") = "APROBADO" Then
    '        Me.btnIngresar.Enabled = False
    '        Me.btnRevisar.Enabled = False
    '        Me.btnAprobar.Enabled = False
    '        Me.btnGuardar.Enabled = False
    '    End If
    'End Sub

    Private Sub Empleados_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vEmpleados.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Cargar()
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub cbPeriodosN_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPeriodosN.EditValueChanged
        Cargar()
        'ValidarBotones()
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        If ObtieneDatos("sp_GetEstado '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual).Rows.Count > 0 Then
            MsgBox("La Información ya ha sido Ingresada", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim ban As Boolean = False

        For i As Integer = 0 To Me.vEmpleados.DataRowCount - 1
            If Me.vEmpleados.GetRowCellValue(i, "Cambiar") Then
                ban = True
            End If
        Next

        If Not ban Then
            MsgBox("Seleccione al Menos 1 Empleado para Registrar el Ingreso", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Guardar()
            GuardaDatos("sp_UsuariosAccion '" & Me.cbPeriodosN.EditValue & "'," & Usuario_ID & ",1," & EmpresaActual)
            '
            Cargar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        'If GuardaDatos("sp_GuardarIngresoAjuste '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual) Then
        '    GuardaDatos("sp_UsuariosAccion '" & Me.cbPeriodosN.EditValue & "'," & Usuario_ID & ",1," & EmpresaActual)
        '    Cargar()
        'End If
        'ValidarBotones()
    End Sub

    Sub Guardar()

        Dim EstadoActual As String = "SIN PROCESAR"
        Try
            EstadoActual = ObtieneDatos("sp_GetEstado '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual).Rows.Item(0)("Estado")
        Catch ex As Exception
        End Try

        Dim Estado1 As Integer = 0, Estado2 As Integer = 0, Estado3 As Integer = 0
        Dim SalarioA As Double = 0, SalarioB As Double = 0, SalarioC As Double = 0
        Dim Dividir As Integer = 1

        For i As Integer = 0 To Me.vEmpleados.DataRowCount - 1
            If Me.vEmpleados.GetRowCellValue(i, "Cambiar") Then
                'Validar Forma de Pago del Empleado
                If Me.vEmpleados.GetRowCellValue(i, "FormaPago") = "Q" Then
                    Dividir = 2
                ElseIf Me.vEmpleados.GetRowCellValue(i, "FormaPago") = "S" Then
                    Dividir = 4
                ElseIf Me.vEmpleados.GetRowCellValue(i, "FormaPago") = "M" Then
                    Dividir = 1
                Else
                    Dividir = 2
                End If

                'Validar el Estado Actual del Proceso
                If EstadoActual = "APROBADO" Then   'cuando se le da al boton aprobar
                    Estado1 = 1 : Estado2 = 1 : Estado3 = 1
                    SalarioA = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "SalarioA")), 2)
                    SalarioB = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "SalarioB")), 2)
                    SalarioC = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                    'La Primera Vez, Cuando se le da Ingresar
                ElseIf Me.vEmpleados.GetRowCellValue(i, "Estado") = "SIN PROCESAR" And _
                    (EstadoActual = "SIN PROCESAR" Or EstadoActual = "INGRESADO") Then
                    Estado1 = 1 : Estado2 = 0 : Estado3 = 0
                    SalarioA = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                    SalarioB = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                    SalarioC = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                ElseIf Me.vEmpleados.GetRowCellValue(i, "Estado") = "SIN PROCESAR" And EstadoActual = "REVISADO" Then
                    Estado1 = 1 : Estado2 = 1 : Estado3 = 0
                    SalarioA = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "SalarioA")), 2)
                    SalarioB = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                    SalarioC = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                ElseIf Me.vEmpleados.GetRowCellValue(i, "Estado") = "INGRESADO" Then
                    Estado1 = 1 : Estado2 = 0 : Estado3 = 0
                    SalarioA = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                    SalarioB = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                    SalarioC = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                ElseIf Me.vEmpleados.GetRowCellValue(i, "Estado") = "REVISADO" Then
                    Estado1 = 1 : Estado2 = 1 : Estado3 = 0
                    SalarioA = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "SalarioA")), 2)
                    SalarioB = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                    SalarioC = Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / Dividir), 2)
                End If

                Dim Datos As New ArrayList
                Dim Variables As New ArrayList

                Variables.Add("@Per_Codigo")
                Variables.Add("@Emp_Codigo")
                Variables.Add("@FormaPago")
                Variables.Add("@Ingresado")
                Variables.Add("@Revisado")
                Variables.Add("@Aprobado")
                Variables.Add("@Salario")
                Variables.Add("@SalarioA")
                Variables.Add("@SalarioB")
                Variables.Add("@SalarioC")
                Variables.Add("@mon_Codigo")
                Variables.Add("@Fecha")
                Variables.Add("@Empresa")

                Datos.Add(Me.vEmpleados.GetRowCellValue(i, "Per_Codigo"))
                Datos.Add(Me.vEmpleados.GetRowCellValue(i, "Codigo"))
                Datos.Add(Me.vEmpleados.GetRowCellValue(i, "FormaPago"))
                Datos.Add(Estado1)
                Datos.Add(Estado2)
                Datos.Add(Estado3)
                Datos.Add(Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Mensual") / Dividir), 2))
                Datos.Add(SalarioA)
                Datos.Add(SalarioB)
                Datos.Add(SalarioC)
                Datos.Add(Me.vEmpleados.GetRowCellValue(i, "Moneda"))
                Datos.Add(CDate(Me.vEmpleados.GetRowCellValue(i, "A Partir de")))
                Datos.Add(EmpresaActual)

                ProcedureSave(Datos, Variables, "sp_ActualizarSalario")
            End If
        Next
    End Sub

    Private Sub btnRevisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevisar.Click
        If Me.vEmpleados.DataRowCount = 0 Then Exit Sub
        Dim dtEstado As DataTable = ObtieneDatos("sp_GetEstado '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual)

        If dtEstado.Rows.Count = 0 Then
            MsgBox("Debe Ingresar primiero la Información", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If dtEstado.Rows.Count > 0 Then
            If dtEstado.Rows.Item(0)("Estado") = "REVISADO" Then
                MsgBox("Los Datos ya han Sido Revisados", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If dtEstado.Rows.Item(0)("Estado") = "APROBADO" Then
                MsgBox("Los Datos ya han Sido Aprobados", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If MessageBox.Show("La revisión de los Datos ha sido Completada," & vbCrLf & "¿ Guardar Revisión ?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            GuardaDatos("UPDATE SalariosAprobar SET Revisado = 1 WHERE Per_Codigo = '" & Me.vEmpleados.GetRowCellValue(0, "Per_Codigo") & "' AND Empresa = " & EmpresaActual)
            '
            GuardaDatos("sp_UsuariosAccion '" & Me.vEmpleados.GetRowCellValue(0, "Per_Codigo") & "'," & Usuario_ID & ",2," & EmpresaActual)
            '
            MsgBox("Operación Exitosa !!!", MsgBoxStyle.Information)

            Cargar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        'ValidarBotones()
    End Sub

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        If Me.vEmpleados.DataRowCount = 0 Then Exit Sub
        Dim dtEstado As DataTable = ObtieneDatos("sp_GetEstado '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual)

        If dtEstado.Rows.Count = 0 Then
            MsgBox("Debe Ingresar primiero la Información", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If dtEstado.Rows.Count > 0 Then
            If dtEstado.Rows.Item(0)("Estado") = "INGRESADO" Then
                MsgBox("Los Datos deben de ser revisado para realizar aprobación.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If dtEstado.Rows.Item(0)("Estado") = "APROBADO" Then
                MsgBox("Los Datos ya han Sido Aprobados", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If MessageBox.Show("Este Proceso realizará Cambios al Salario de los empleados Seleccionados" & vbCrLf & "¿ Realizar Aprobación de los Cambios Solicitados?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            GuardaDatos("UPDATE SalariosAprobar SET Aprobado = 1 WHERE Per_Codigo = '" & Me.vEmpleados.GetRowCellValue(0, "Per_Codigo") & "' AND Empresa = " & EmpresaActual)
            '
            Guardar()
            'ActualizarDatos(1)
            '
            GuardaDatos("sp_UsuariosAccion '" & Me.vEmpleados.GetRowCellValue(0, "Per_Codigo") & "'," & Usuario_ID & ",3," & EmpresaActual)
            MsgBox("Operación Exitosa !!!", MsgBoxStyle.Information)

            Cargar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'ValidarBotones()
    End Sub

    Sub ActualizarDatos(Optional ByVal op As Integer = 0)

        If op = 1 Then  'Actualizar Tabla de Empleados
            For i As Integer = 0 To Me.vEmpleados.DataRowCount - 1
                'If Not Me.vEmpleados.GetRowCellValue(i, "A Partir de") Is DBNull.Value Then
                If Me.vEmpleados.GetRowCellValue(i, "Cambiar") Then
                    Dim Datos As New ArrayList
                    Dim Variables As New ArrayList

                    Variables.Add("@Emp_Codigo")
                    Variables.Add("@Salario")
                    Variables.Add("@mon_Codigo")
                    Variables.Add("@Fecha")
                    Variables.Add("@Empresa")

                    Datos.Add(Me.vEmpleados.GetRowCellValue(i, "Codigo"))
                    Datos.Add(Math.Round(CDbl(Me.vEmpleados.GetRowCellValue(i, "S.Aprobar") / 2), 2))
                    Datos.Add(Me.vEmpleados.GetRowCellValue(i, "Moneda"))
                    Datos.Add(CDate(Me.vEmpleados.GetRowCellValue(i, "A Partir de")))
                    Datos.Add(EmpresaActual)

                    ProcedureSave(Datos, Variables, "sp_SalarioEmpleado")
                End If
            Next
        End If

        'Guardar Cambios a Salario y Moneda
        '
        Dim DTCambios As DataTable = DT.GetChanges(DataRowState.Modified)

        If DTCambios Is Nothing Then
            Exit Sub
        End If

        For i As Integer = 0 To DTCambios.Rows.Count - 1
            'If Not DTCambios.Rows.Item(i)("A Partir de") Is DBNull.Value Then
            Dim Datos As New ArrayList
            Dim Variables As New ArrayList

            Variables.Add("@Per_Codigo")
            Variables.Add("@Emp_Codigo")
            Variables.Add("@Salario")
            Variables.Add("@mon_Codigo")
            Variables.Add("@Fecha")
            Variables.Add("@Empresa")

            Datos.Add(DTCambios.Rows.Item(i)("Per_Codigo"))
            Datos.Add(DTCambios.Rows.Item(i)("Codigo"))
            Datos.Add(Math.Round(CDbl(DTCambios.Rows.Item(i)("S.Aprobar") / 2), 2))
            Datos.Add(DTCambios.Rows.Item(i)("Moneda"))
            Datos.Add(IsNull(DTCambios.Rows.Item(i)("A Partir de"), ""))
            Datos.Add(EmpresaActual)

            ProcedureSave(Datos, Variables, "sp_ActualizarSalario")
            'End If
        Next
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ObtieneDatos("sp_GetEstado '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual).Rows.Count = 0 Then
            MsgBox("Debe Ingresar primiero la Información", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If ObtieneDatos("sp_GetEstado '" & Me.cbPeriodosN.EditValue & "'," & EmpresaActual).Rows.Item(0)("Estado") = "APROBADO" Then
            MsgBox("Los Datos ya han sido Aprobados no se pueden Modificar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Guardar()
        Cargar()
    End Sub

    Private Sub vEmpleados_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vEmpleados.ShowingEditor
        'If Me.vEmpleados.GetRowCellValue(Me.vEmpleados.FocusedRowHandle, "Estado") <> "SIN PROCESAR" Then e.Cancel = True
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If Me.CheckEdit1.Checked Then Me.vEmpleados.ColumnsCustomization()
        If Not Me.CheckEdit1.Checked Then Me.vEmpleados.DestroyCustomization()
    End Sub

    Private Sub vEmpleados_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vEmpleados.ValidateRow
        If EmpresaActual <> 14 Then 'Para Todas Las Empresas
            If (Me.vEmpleados.GetRowCellValue(e.RowHandle, "S.Aprobar") < Me.vEmpleados.GetRowCellValue(e.RowHandle, "S.Mínimo")) Or _
            (Me.vEmpleados.GetRowCellValue(e.RowHandle, "S.Aprobar") > Me.vEmpleados.GetRowCellValue(e.RowHandle, "S.Máximo")) Then
                e.ErrorText = "El Salario del Empleado Debe estar Comprendido entre la Tabla Salarial (" & CDbl(IsNull(Me.vEmpleados.GetRowCellValue(e.RowHandle, "S.Mínimo"), 0)).ToString("n2") & " - " & CDbl(IsNull(Me.vEmpleados.GetRowCellValue(e.RowHandle, "S.Máximo"), 0)).ToString("n2") & "). Según el Cargo que desempeña" & vbCrLf
                e.Valid = False
            End If
        Else    'Para Cafe Don Paco
            If Me.vEmpleados.GetRowCellValue(e.RowHandle, "S.Aprobar") < 0 Then
                e.ErrorText = "El Salario del Empleado Debe ser Mayor que Cero(0)." & vbCrLf
                e.Valid = False
            End If
        End If
    End Sub
End Class
