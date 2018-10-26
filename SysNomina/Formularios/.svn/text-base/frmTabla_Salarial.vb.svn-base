Imports System.Data
Imports System.Data.SqlClient

Public Class frmTabla_Salarial
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmTabla_Salarial = Nothing

    Public Shared Function Instance() As frmTabla_Salarial
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmTabla_Salarial()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSMin As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAprobar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSMax As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit


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
    Friend WithEvents dgTablaS As DevExpress.XtraGrid.GridControl
    Friend WithEvents vTablaS As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgTablaS = New DevExpress.XtraGrid.GridControl
        Me.vTablaS = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtSMin = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.txtSMax = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton
        Me.btnAprobar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dgTablaS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vTablaS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgTablaS
        '
        Me.dgTablaS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTablaS.EmbeddedNavigator.Name = ""
        Me.dgTablaS.Location = New System.Drawing.Point(12, 12)
        Me.dgTablaS.MainView = Me.vTablaS
        Me.dgTablaS.Name = "dgTablaS"
        Me.dgTablaS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtSMin, Me.txtSMax})
        Me.dgTablaS.Size = New System.Drawing.Size(643, 250)
        Me.dgTablaS.TabIndex = 15
        Me.dgTablaS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vTablaS})
        '
        'vTablaS
        '
        Me.vTablaS.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vTablaS.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vTablaS.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vTablaS.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vTablaS.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vTablaS.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vTablaS.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vTablaS.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vTablaS.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.vTablaS.Appearance.Empty.Options.UseBackColor = True
        Me.vTablaS.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.vTablaS.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.vTablaS.Appearance.EvenRow.Options.UseBackColor = True
        Me.vTablaS.Appearance.EvenRow.Options.UseForeColor = True
        Me.vTablaS.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vTablaS.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vTablaS.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.vTablaS.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.vTablaS.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vTablaS.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vTablaS.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vTablaS.Appearance.FixedLine.Options.UseBackColor = True
        Me.vTablaS.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vTablaS.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vTablaS.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vTablaS.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vTablaS.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vTablaS.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vTablaS.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vTablaS.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.vTablaS.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.vTablaS.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vTablaS.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vTablaS.Appearance.FooterPanel.Options.UseFont = True
        Me.vTablaS.Appearance.FooterPanel.Options.UseForeColor = True
        Me.vTablaS.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.GroupButton.Options.UseBackColor = True
        Me.vTablaS.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vTablaS.Appearance.GroupButton.Options.UseForeColor = True
        Me.vTablaS.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vTablaS.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vTablaS.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vTablaS.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vTablaS.Appearance.GroupFooter.Options.UseForeColor = True
        Me.vTablaS.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.vTablaS.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.vTablaS.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vTablaS.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vTablaS.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vTablaS.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vTablaS.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.GroupRow.Options.UseBackColor = True
        Me.vTablaS.Appearance.GroupRow.Options.UseBorderColor = True
        Me.vTablaS.Appearance.GroupRow.Options.UseForeColor = True
        Me.vTablaS.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vTablaS.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.vTablaS.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.vTablaS.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vTablaS.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.vTablaS.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.vTablaS.Appearance.HeaderPanel.Options.UseFont = True
        Me.vTablaS.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.vTablaS.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.vTablaS.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vTablaS.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vTablaS.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vTablaS.Appearance.HorzLine.Options.UseBackColor = True
        Me.vTablaS.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.vTablaS.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.vTablaS.Appearance.OddRow.Options.UseBackColor = True
        Me.vTablaS.Appearance.OddRow.Options.UseForeColor = True
        Me.vTablaS.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.vTablaS.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.vTablaS.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.vTablaS.Appearance.Preview.Options.UseBackColor = True
        Me.vTablaS.Appearance.Preview.Options.UseFont = True
        Me.vTablaS.Appearance.Preview.Options.UseForeColor = True
        Me.vTablaS.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.vTablaS.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.vTablaS.Appearance.Row.Options.UseBackColor = True
        Me.vTablaS.Appearance.Row.Options.UseForeColor = True
        Me.vTablaS.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.vTablaS.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vTablaS.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.vTablaS.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.vTablaS.Appearance.SelectedRow.Options.UseBackColor = True
        Me.vTablaS.Appearance.SelectedRow.Options.UseForeColor = True
        Me.vTablaS.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.vTablaS.Appearance.TopNewRow.Options.UseBackColor = True
        Me.vTablaS.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vTablaS.Appearance.VertLine.Options.UseBackColor = True
        Me.vTablaS.GridControl = Me.dgTablaS
        Me.vTablaS.Name = "vTablaS"
        Me.vTablaS.OptionsSelection.MultiSelect = True
        Me.vTablaS.OptionsView.EnableAppearanceEvenRow = True
        Me.vTablaS.OptionsView.EnableAppearanceOddRow = True
        Me.vTablaS.OptionsView.ShowAutoFilterRow = True
        Me.vTablaS.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vTablaS.OptionsView.ShowFooter = True
        Me.vTablaS.OptionsView.ShowGroupedColumns = True
        Me.vTablaS.OptionsView.ShowGroupPanel = False
        '
        'txtSMin
        '
        Me.txtSMin.AutoHeight = False
        Me.txtSMin.Mask.EditMask = "n2"
        Me.txtSMin.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSMin.Mask.UseMaskAsDisplayFormat = True
        Me.txtSMin.Name = "txtSMin"
        '
        'txtSMax
        '
        Me.txtSMax.AutoHeight = False
        Me.txtSMax.Mask.EditMask = "n2"
        Me.txtSMax.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSMax.Mask.UseMaskAsDisplayFormat = True
        Me.txtSMax.Name = "txtSMax"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btnGuardar)
        Me.PanelControl1.Controls.Add(Me.btnQuit)
        Me.PanelControl1.Controls.Add(Me.btnAprobar)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 268)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(643, 52)
        Me.PanelControl1.TabIndex = 16
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(16, 11)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(97, 30)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Appearance.Options.UseFont = True
        Me.btnQuit.Location = New System.Drawing.Point(527, 11)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(100, 30)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "&Salir"
        '
        'btnAprobar
        '
        Me.btnAprobar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.Appearance.Options.UseFont = True
        Me.btnAprobar.Location = New System.Drawing.Point(119, 11)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(97, 30)
        Me.btnAprobar.TabIndex = 0
        Me.btnAprobar.Text = "&Aprobar"
        '
        'frmTabla_Salarial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(667, 332)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgTablaS)
        Me.Name = "frmTabla_Salarial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgTablaS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vTablaS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim DT As DataTable

    Private Sub frmTabla_Salarial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Tablas Salariales según Cargo"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Cargar()
        Me.Refresh()
    End Sub

    Public Sub Cargar()
        Try
            DT = ObtieneData("sp_GetTablaSalarial " & EmpresaActual)

            dgTablaS.DataSource = DT.DefaultView
            Me.vTablaS.PopulateColumns()
            FormatoGrid(Me.vTablaS)

            Me.vTablaS.Columns("IdDetalle").Visible = False
            Me.vTablaS.Columns("Cargo").BestFit()

            Me.vTablaS.Columns("Salario Mínimo").ColumnEdit = Me.txtSMin
            Me.vTablaS.Columns("Salario Mínimo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vTablaS.Columns("Salario Mínimo").SummaryItem.DisplayFormat = "{0:n2}"

            Me.vTablaS.Columns("Salario Máximo").ColumnEdit = Me.txtSMax
            Me.vTablaS.Columns("Salario Máximo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vTablaS.Columns("Salario Máximo").SummaryItem.DisplayFormat = "{0:n2}"

            For i As Integer = 0 To Me.vTablaS.Columns.Count - 1
                Me.vTablaS.Columns(i).OptionsColumn.AllowEdit = False
                Me.vTablaS.Columns(i).OptionsColumn.AllowFocus = False
            Next

            Me.vTablaS.Columns("Salario Mínimo").OptionsColumn.AllowEdit = True
            Me.vTablaS.Columns("Salario Máximo").OptionsColumn.AllowEdit = True

            Me.vTablaS.Columns("Salario Mínimo").OptionsColumn.AllowFocus = True
            Me.vTablaS.Columns("Salario Máximo").OptionsColumn.AllowFocus = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Empleados_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vTablaS.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Cargar()
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub Guardar()
        For i As Integer = 0 To Me.vTablaS.DataRowCount - 1

            Dim Datos As New ArrayList
            Dim Variables As New ArrayList

            Variables.Add("@IdDetalle")
            Variables.Add("@Empresa")
            Variables.Add("@Cargo")
            Variables.Add("@Minimo")
            Variables.Add("@Maximo")

            Datos.Add(Me.vTablaS.GetRowCellValue(i, "IdDetalle"))
            Datos.Add(EmpresaActual)
            Datos.Add(Me.vTablaS.GetRowCellValue(i, "Codigo"))
            Datos.Add(Me.vTablaS.GetRowCellValue(i, "Salario Mínimo"))
            Datos.Add(Me.vTablaS.GetRowCellValue(i, "Salario Máximo"))

            ProcedureSave(Datos, Variables, "sp_GuardarTablaSalarial")
        Next
    End Sub

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        If ObtieneDatos("SELECT * FROM TablaSalarial ts WHERE ts.Empresa = " & EmpresaActual).Rows.Count = 0 Then
            MsgBox("Debe Guardar Primero la Tabla Salarial que desea Aprobar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Me.vTablaS.GetFocusedRowCellValue("Estado") = "APROBADO" Then
            MsgBox("La Tabla Salarial ya Esta Aprobada.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿ Desea Aprobar la Tabla Salarial con los Datos Solicitado ?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        If GuardaDatos("UPDATE TablaSalarial SET Estado = 1" _
                       + " WHERE Empresa = " & EmpresaActual) Then
            Cargar()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        'Validando Datos
        Dim Min As Integer = 0, Max As Integer = 0

        For i As Integer = 0 To Me.vTablaS.DataRowCount - 1
            If Me.vTablaS.GetRowCellValue(i, "Salario Mínimo") = 0.0 Then Min += 1
            If Me.vTablaS.GetRowCellValue(i, "Salario Máximo") = 0.0 Then Max += 1
        Next

        If Min > 0 Then
            MsgBox("Exiten: " & Min.ToString & " Salarios Mínimos con Valor igual a Cero (0)," & vbCrLf & _
                   "Favor corregir para Guardar Tabla Salarial", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        If Max > 0 Then
            MsgBox("Exiten: " & Max.ToString & " Salarios Máximos con Valor igual a Cero (0)," & vbCrLf & _
                   "Favor corregir para Guardar Tabla Salarial", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Me.vTablaS.GetFocusedRowCellValue("Estado") = "APROBADO" Then
            If MessageBox.Show("La Tabla Salarial ya ha sido Aprobada," & vbCrLf & _
                                "¿ Desea Guardar los Cambios Solicitados ?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        Guardar()
        Cargar()
    End Sub

    Private Sub vTablaS_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vTablaS.CellValueChanged
        If e.Column.FieldName = "Salario Mínimo" Then
            If e.Value < 0 Then
                Me.vTablaS.SetRowCellValue(e.RowHandle, "Salario Mínimo", 0.0)
            End If
        End If

        If e.Column.FieldName = "Salario Máximo" Then
            If e.Value < 0 Then
                Me.vTablaS.SetRowCellValue(e.RowHandle, "Salario Máximo", 0.0)
            End If
        End If
    End Sub

    Private Sub vTablaS_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vTablaS.ValidateRow
        If Me.vTablaS.GetRowCellValue(e.RowHandle, "Salario Mínimo") < 0 Or Me.vTablaS.GetRowCellValue(e.RowHandle, "Salario Máximo") < 0 Then
            e.ErrorText = "El Valor debe ser Mayor que Cero (0)" & vbCrLf
            e.Valid = False
        End If
    End Sub
End Class
