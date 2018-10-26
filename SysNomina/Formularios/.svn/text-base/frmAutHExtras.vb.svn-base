Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmAutHExtras
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAutHExtras = Nothing

    Public Shared Function Instance() As frmAutHExtras
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAutHExtras()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Dim ChkTodas As Boolean

#Region "Calaches"

#End Region
#Region "Variables"
    Friend WithEvents ItemSpinEdit As New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents dgHExtras As DevExpress.XtraGrid.GridControl
    Friend WithEvents VHorasExtras As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBDepartamento = New System.Windows.Forms.ComboBox
        Me.dgHExtras = New DevExpress.XtraGrid.GridControl
        Me.VHorasExtras = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgHExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(573, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 348)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Autorizar Todas"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 76)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(94, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 16)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(94, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Autorizar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Departamento:"
        '
        'CBDepartamento
        '
        Me.CBDepartamento.Location = New System.Drawing.Point(130, 8)
        Me.CBDepartamento.Name = "CBDepartamento"
        Me.CBDepartamento.Size = New System.Drawing.Size(438, 21)
        Me.CBDepartamento.TabIndex = 12
        '
        'dgHExtras
        '
        Me.dgHExtras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgHExtras.EmbeddedNavigator.Name = ""
        Me.dgHExtras.Location = New System.Drawing.Point(11, 36)
        Me.dgHExtras.MainView = Me.VHorasExtras
        Me.dgHExtras.Name = "dgHExtras"
        Me.dgHExtras.Size = New System.Drawing.Size(557, 348)
        Me.dgHExtras.TabIndex = 14
        Me.dgHExtras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VHorasExtras})
        '
        'VHorasExtras
        '
        Me.VHorasExtras.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VHorasExtras.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VHorasExtras.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VHorasExtras.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VHorasExtras.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VHorasExtras.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VHorasExtras.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VHorasExtras.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VHorasExtras.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VHorasExtras.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VHorasExtras.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VHorasExtras.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VHorasExtras.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VHorasExtras.Appearance.Empty.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VHorasExtras.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VHorasExtras.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VHorasExtras.Appearance.EvenRow.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VHorasExtras.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VHorasExtras.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VHorasExtras.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VHorasExtras.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VHorasExtras.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VHorasExtras.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VHorasExtras.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VHorasExtras.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VHorasExtras.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VHorasExtras.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VHorasExtras.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VHorasExtras.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VHorasExtras.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VHorasExtras.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VHorasExtras.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VHorasExtras.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VHorasExtras.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VHorasExtras.Appearance.GroupButton.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VHorasExtras.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VHorasExtras.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VHorasExtras.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VHorasExtras.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VHorasExtras.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VHorasExtras.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VHorasExtras.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VHorasExtras.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VHorasExtras.Appearance.GroupRow.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.GroupRow.Options.UseFont = True
        Me.VHorasExtras.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VHorasExtras.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VHorasExtras.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VHorasExtras.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VHorasExtras.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VHorasExtras.Appearance.HorzLine.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VHorasExtras.Appearance.OddRow.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VHorasExtras.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VHorasExtras.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VHorasExtras.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VHorasExtras.Appearance.Preview.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.Preview.Options.UseFont = True
        Me.VHorasExtras.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VHorasExtras.Appearance.Row.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VHorasExtras.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VHorasExtras.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VHorasExtras.Appearance.VertLine.Options.UseBackColor = True
        Me.VHorasExtras.GridControl = Me.dgHExtras
        Me.VHorasExtras.Name = "VHorasExtras"
        Me.VHorasExtras.OptionsView.EnableAppearanceEvenRow = True
        Me.VHorasExtras.OptionsView.EnableAppearanceOddRow = True
        Me.VHorasExtras.OptionsView.ShowAutoFilterRow = True
        Me.VHorasExtras.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VHorasExtras.OptionsView.ShowFooter = True
        Me.VHorasExtras.OptionsView.ShowGroupPanel = False
        '
        'frmAutHExtras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(689, 395)
        Me.Controls.Add(Me.dgHExtras)
        Me.Controls.Add(Me.CBDepartamento)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAutHExtras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgHExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAutHExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Departamentos As New VB.SysContab.DepartamentosDB()

        CBDepartamento.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
        CBDepartamento.ValueMember = "Codigo"
        CBDepartamento.DisplayMember = "Nombre"

        'Restringir la edicion de horas extras, para los periodos que aun no han tenido planilla generada.

        'buscar por cada empleado la forma de pago, para ver como se van a generar las horas extras,
        'el campo de hex_quincena realmente llevara el identificador del perido de pago segun las formas de pago activas.

        Me.dgHExtras.DataSource = VB.SysContab.HorasExtrasDB.GetListDepto("%", "%", QuincenaTrabajo).Tables(0)
        Me.VHorasExtras.PopulateColumns()
        Me.VHorasExtras.Columns("Empleado").OptionsColumn.ReadOnly = True
        Me.VHorasExtras.Columns("Empleado").Visible = False
        Me.VHorasExtras.Columns("Nombre").OptionsColumn.ReadOnly = True
        Me.VHorasExtras.Columns("Quincena").OptionsColumn.ReadOnly = True

        Me.VHorasExtras.Columns("Solicitadas").OptionsColumn.ReadOnly = True
        Me.VHorasExtras.Columns("Solicitadas").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VHorasExtras.Columns("Solicitadas").DisplayFormat.FormatString = "n2"
        Me.VHorasExtras.Columns("Solicitadas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VHorasExtras.Columns("Solicitadas").SummaryItem.DisplayFormat = "{0:n2}"

        Me.ItemSpinEdit.MinValue = 0
        Me.ItemSpinEdit.Increment = 0.5
        Me.VHorasExtras.Columns("Autorizadas").ColumnEdit = Me.ItemSpinEdit

        If Me.VHorasExtras.DataRowCount <> 0 Then
            Registro = Me.VHorasExtras.GetFocusedRowCellValue("Empleado")
        Else
            Registro = "Vacio"
        End If

        Me.Text = "Autorización de Horas Extras por Departamento"
        Me.ChkTodas = False
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub CBDepartamento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CBDepartamento.Validating
        Me.dgHExtras.DataSource = VB.SysContab.HorasExtrasDB.GetListDepto(Me.CBDepartamento.SelectedValue, "%", QuincenaTrabajo).Tables(0)

        If Me.VHorasExtras.DataRowCount = 0 Then
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VHorasExtras.GetFocusedRowCellValue("Empleado")
        End If

        Me.ChkTodas = False
    End Sub


    Private Sub dgHExtras_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'editar las horas extras
        Dim f As New frmEditarHExtras()
        Registro = Me.VHorasExtras.GetFocusedRowCellValue("Empleado")
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub



    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim i As Integer
        If Me.CBDepartamento.SelectedValue <> "%" Then
            For i = 0 To Me.VHorasExtras.DataRowCount - 1
                'If Me.dgHExtras.Item(i, 4) <> 0 Then
                'If Me.dgHExtras.Item(i, 4) = Me.dgHExtras.Item(i, 3) Or Me.dgHExtras.Item(i, 4) = 0 Then
                VB.SysContab.HorasExtrasDB.AutoEmpleadoDepto(QuincenaTrabajo, Me.CBDepartamento.SelectedValue, _
                    "00000000", _
                    IIf(Me.VHorasExtras.GetRowCellValue(i, "Autorizadas") = 0, False, True), _
                    Me.VHorasExtras.GetRowCellValue(i, "Empleado"), _
                    Me.VHorasExtras.GetRowCellValue(i, "Autorizadas"))
                'End If
            Next
            MsgBox("Proceso terminado", MsgBoxStyle.Information, "SysNomina")
        End If
    End Sub

    Private Sub CBDepartamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBDepartamento.SelectedIndexChanged
        'If IsNumeric(CBDepartamento.SelectedValue) Then
        If Me.CBDepartamento.SelectedValue.GetType.Name <> "DataRowView" Then
            Me.dgHExtras.DataSource = Nothing
            Me.dgHExtras.DataSource = VB.SysContab.HorasExtrasDB.GetListDepto(Me.CBDepartamento.SelectedValue, "%", QuincenaTrabajo).Tables(0)
            'IIf(Val(Me.CBDepartamento.SelectedValue) <> 0, Me.CBDepartamento.SelectedValue, "%"), QuincenaTrabajo)
            If Me.VHorasExtras.DataRowCount = 0 Then
                Registro = "Vacio"
                Exit Sub
            Else
                Registro = Me.VHorasExtras.GetFocusedRowCellValue("Codigo")
            End If
        End If
        'End If
    End Sub


    Private Sub ItemSpinEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemSpinEdit.EditValueChanged
        If Me.VHorasExtras.DataRowCount > 0 Then
            If sender.value < 0 Then
                MsgBox("No se puede ingresar valores negativos", MsgBoxStyle.Critical, "Sts.Nomina")
                Me.VHorasExtras.SetFocusedRowCellValue(Me.VHorasExtras.Columns("Autorizadas"), 0)
                Exit Sub
            End If
            If sender.value > _
                Me.VHorasExtras.GetFocusedRowCellValue("Solicitadas") Then
                MsgBox("No puede autorizar mas horas que las solicitadas", MsgBoxStyle.Critical, "Sts.Nomina")
                Me.VHorasExtras.SetFocusedRowCellValue(Me.VHorasExtras.Columns("Autorizadas"), _
                    Me.VHorasExtras.GetFocusedRowCellValue(Me.VHorasExtras.Columns("Solicitadas")))
                Exit Sub

            End If
        End If
    End Sub

    Private Sub VHorasExtras_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)

        If Not (Me.VHorasExtras.GetFocusedRowCellValue("Empleado") Is Nothing) And _
            Not IsDBNull(Me.VHorasExtras.GetFocusedRowCellValue("Empleado")) Then
            Registro = Me.VHorasExtras.GetFocusedRowCellValue("Empleado")
        Else
            Registro = "Vacio"
        End If

    End Sub

    Private Sub VHorasExtras_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VHorasExtras.CellValueChanged
        If e.Column.FieldName = "Autorizadas" Then
            If Me.VHorasExtras.DataRowCount > 0 Then
                If Me.VHorasExtras.GetFocusedRowCellValue("Autorizadas") < 0 Then
                    MsgBox("No se puede ingresar valores negativos", MsgBoxStyle.Critical, "Sts.Nomina")
                    Me.VHorasExtras.SetFocusedRowCellValue(Me.VHorasExtras.Columns("Autorizadas"), 0)
                    Exit Sub
                End If
                If Me.VHorasExtras.GetFocusedRowCellValue("Autorizadas") > _
                    Me.VHorasExtras.GetFocusedRowCellValue("Solicitadas") Then
                    MsgBox("No puede autorizar mas horas que las solicitadas", MsgBoxStyle.Critical, "Sts.Nomina")
                    Me.VHorasExtras.SetFocusedRowCellValue(Me.VHorasExtras.Columns("Autorizadas"), _
                        Me.VHorasExtras.GetFocusedRowCellValue(Me.VHorasExtras.Columns("Solicitadas")))
                    Exit Sub

                End If

            End If
        End If

    End Sub

    Private Sub Planilla_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles VHorasExtras.MasterRowExpanded

        If Me.dgHExtras.Views.Count > 1 Then
            'Ver el detalle
            For i As Integer = 1 To Me.dgHExtras.Views.Count - 1
                If Me.dgHExtras.Views(i).DetailLevel = 1 Then
                    Dim xcosa As New DevExpress.XtraGrid.Views.Grid.GridView
                    xcosa = Me.dgHExtras.Views(i)
                    xcosa.OptionsBehavior.Editable = False
                    xcosa.Columns(0).Visible = False
                    xcosa.Columns("Fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    xcosa.Columns("Fecha").DisplayFormat.FormatString = "dd/MM/yyyy (ddd)"

                    xcosa.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    xcosa.Columns(5).DisplayFormat.FormatString = "{0:n2}"
                    xcosa.Columns(5).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    xcosa.Columns(5).SummaryItem.DisplayFormat = "{0:n2}"

                    xcosa.Columns(6).Visible = True
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
                    xcosa.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black 'FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
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
                    xcosa.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ChkTodas = False Then
            If MsgBox("Esta seguro de AUTORIZAR todas las horas extras de este departamento?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Horas Extras") = MsgBoxResult.Ok Then
                If Me.CBDepartamento.SelectedValue <> "%" Then
                    VB.SysContab.HorasExtrasDB.AutoTodasDepto(QuincenaTrabajo, Me.CBDepartamento.SelectedValue, "00000000", True)
                    Me.ChkTodas = True
                End If
            End If
        Else
            If MsgBox("Esta seguro de DES-AUTORIZAR todas las horas extras de este departamento?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Horas Extras") = MsgBoxResult.Ok Then
                If Me.CBDepartamento.SelectedValue <> "%" Then
                    VB.SysContab.HorasExtrasDB.AutoTodasDepto(QuincenaTrabajo, Me.CBDepartamento.SelectedValue, "00000000", False)
                    Me.ChkTodas = True
                End If
            End If

        End If

        Me.dgHExtras.DataSource = VB.SysContab.HorasExtrasDB.GetListDepto(Me.CBDepartamento.SelectedValue, "%", QuincenaTrabajo).Tables(0)
        If Me.VHorasExtras.DataRowCount = 0 Then
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VHorasExtras.GetFocusedRowCellValue("Empleado")
        End If

    End Sub

   
End Class
