Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmVacaciones
    Inherits System.Windows.Forms.Form
    Private Shared ChildInstance As frmVacaciones = Nothing

    Public Shared Function Instance() As frmVacaciones
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmVacaciones()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region "Variables"
    Dim bMasDatos As Boolean = False
    Friend WithEvents dVista As New DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dDVista As New DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cbTiposPermisos As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Dim lds, lds2 As New DataSet
    Friend WithEvents dtpAl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spDias As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdD As DevExpress.XtraEditors.SimpleButton
    Dim cargado As Boolean = False
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
    Friend WithEvents ckbTodos As System.Windows.Forms.CheckBox
    Friend WithEvents cmdFeriados As System.Windows.Forms.Button
    Friend WithEvents cmdDias As System.Windows.Forms.Button
    Friend WithEvents dgEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents VEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents cmdMasDatos As System.Windows.Forms.Button
    Friend WithEvents cmdPagos As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdMasDatos = New System.Windows.Forms.Button
        Me.cmdExportar = New System.Windows.Forms.Button
        Me.cmdPagos = New System.Windows.Forms.Button
        Me.cmdDias = New System.Windows.Forms.Button
        Me.cmdFeriados = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.ckbTodos = New System.Windows.Forms.CheckBox
        Me.dgEmpleados = New DevExpress.XtraGrid.GridControl
        Me.VEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dtpAl = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.spDias = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cmdD = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpAl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdMasDatos)
        Me.GroupBox1.Controls.Add(Me.cmdExportar)
        Me.GroupBox1.Controls.Add(Me.cmdPagos)
        Me.GroupBox1.Controls.Add(Me.cmdDias)
        Me.GroupBox1.Controls.Add(Me.cmdFeriados)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(426, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 241)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(8, 151)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(104, 24)
        Me.cmdImprimir.TabIndex = 12
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdMasDatos
        '
        Me.cmdMasDatos.Location = New System.Drawing.Point(6, 181)
        Me.cmdMasDatos.Name = "cmdMasDatos"
        Me.cmdMasDatos.Size = New System.Drawing.Size(104, 24)
        Me.cmdMasDatos.TabIndex = 11
        Me.cmdMasDatos.Text = "Ver Mas Datos"
        '
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(8, 211)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(104, 24)
        Me.cmdExportar.TabIndex = 10
        Me.cmdExportar.Text = "Exportar"
        '
        'cmdPagos
        '
        Me.cmdPagos.Location = New System.Drawing.Point(8, 80)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(104, 24)
        Me.cmdPagos.TabIndex = 9
        Me.cmdPagos.Text = "Pago Vacaciones"
        '
        'cmdDias
        '
        Me.cmdDias.Location = New System.Drawing.Point(8, 48)
        Me.cmdDias.Name = "cmdDias"
        Me.cmdDias.Size = New System.Drawing.Size(104, 24)
        Me.cmdDias.TabIndex = 8
        Me.cmdDias.Text = "Otorgar Dias"
        '
        'cmdFeriados
        '
        Me.cmdFeriados.Location = New System.Drawing.Point(8, 16)
        Me.cmdFeriados.Name = "cmdFeriados"
        Me.cmdFeriados.Size = New System.Drawing.Size(104, 24)
        Me.cmdFeriados.TabIndex = 7
        Me.cmdFeriados.Text = "Feriados"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 110)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(104, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'ckbTodos
        '
        Me.ckbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckbTodos.Location = New System.Drawing.Point(12, 8)
        Me.ckbTodos.Name = "ckbTodos"
        Me.ckbTodos.Size = New System.Drawing.Size(72, 24)
        Me.ckbTodos.TabIndex = 12
        Me.ckbTodos.Text = "Todos"
        '
        'dgEmpleados
        '
        Me.dgEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpleados.EmbeddedNavigator.Name = ""
        Me.dgEmpleados.Location = New System.Drawing.Point(12, 38)
        Me.dgEmpleados.MainView = Me.VEmpleados
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(408, 241)
        Me.dgEmpleados.TabIndex = 13
        Me.dgEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VEmpleados})
        '
        'VEmpleados
        '
        Me.VEmpleados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VEmpleados.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VEmpleados.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VEmpleados.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VEmpleados.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VEmpleados.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VEmpleados.Appearance.Empty.Options.UseBackColor = True
        Me.VEmpleados.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VEmpleados.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VEmpleados.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VEmpleados.Appearance.EvenRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VEmpleados.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VEmpleados.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VEmpleados.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VEmpleados.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VEmpleados.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VEmpleados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VEmpleados.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VEmpleados.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VEmpleados.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupButton.Options.UseBackColor = True
        Me.VEmpleados.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VEmpleados.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VEmpleados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VEmpleados.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VEmpleados.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VEmpleados.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VEmpleados.Appearance.GroupRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.GroupRow.Options.UseFont = True
        Me.VEmpleados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VEmpleados.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VEmpleados.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VEmpleados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VEmpleados.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VEmpleados.Appearance.HorzLine.Options.UseBackColor = True
        Me.VEmpleados.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.OddRow.Options.UseBackColor = True
        Me.VEmpleados.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VEmpleados.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VEmpleados.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VEmpleados.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VEmpleados.Appearance.Preview.Options.UseBackColor = True
        Me.VEmpleados.Appearance.Preview.Options.UseFont = True
        Me.VEmpleados.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VEmpleados.Appearance.Row.Options.UseBackColor = True
        Me.VEmpleados.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VEmpleados.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VEmpleados.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VEmpleados.Appearance.VertLine.Options.UseBackColor = True
        Me.VEmpleados.GridControl = Me.dgEmpleados
        Me.VEmpleados.Name = "VEmpleados"
        Me.VEmpleados.OptionsSelection.MultiSelect = True
        Me.VEmpleados.OptionsView.EnableAppearanceEvenRow = True
        Me.VEmpleados.OptionsView.EnableAppearanceOddRow = True
        Me.VEmpleados.OptionsView.ShowAutoFilterRow = True
        Me.VEmpleados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VEmpleados.OptionsView.ShowFooter = True
        Me.VEmpleados.OptionsView.ShowGroupPanel = False
        '
        'dtpAl
        '
        Me.dtpAl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpAl.EditValue = Nothing
        Me.dtpAl.Location = New System.Drawing.Point(320, 12)
        Me.dtpAl.Name = "dtpAl"
        Me.dtpAl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpAl.Properties.Mask.EditMask = "dd/MM/yy"
        Me.dtpAl.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpAl.Size = New System.Drawing.Size(100, 20)
        Me.dtpAl.TabIndex = 14
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(301, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Al:"
        '
        'spDias
        '
        Me.spDias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spDias.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spDias.Location = New System.Drawing.Point(184, 12)
        Me.spDias.Name = "spDias"
        Me.spDias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spDias.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spDias.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spDias.Properties.IsFloatValue = False
        Me.spDias.Properties.Mask.EditMask = "N00"
        Me.spDias.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.spDias.Size = New System.Drawing.Size(62, 20)
        Me.spDias.TabIndex = 16
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(101, 19)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Aplicar a Todos:"
        '
        'cmdD
        '
        Me.cmdD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdD.Location = New System.Drawing.Point(252, 9)
        Me.cmdD.Name = "cmdD"
        Me.cmdD.Size = New System.Drawing.Size(43, 23)
        Me.cmdD.TabIndex = 18
        Me.cmdD.Text = "OK"
        '
        'frmVacaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(552, 290)
        Me.Controls.Add(Me.cmdD)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.spDias)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.dtpAl)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.ckbTodos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmVacaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAl.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpAl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    

    Private Sub frmVacaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Empleados As New VB.SysContab.EmpleadosDB()
        Me.dtpAl.EditValue = Now.Date

        Me.Cargar()
        Me.cargado = True
        Me.Text = "Vacaciones de Empleados"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        If QuincenaTrabajo = "" Then
            Me.cmdDias.Enabled = False
            Me.cmdFeriados.Enabled = False
            Me.cmdPagos.Enabled = False
        End If
        Me.Refresh()

    End Sub
    Public Sub Cargar()

        lds = New DataSet
        lds.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(Me.dtpAl.DateTime.Date)) 'Esta es la lista de empleados
        lds2 = VB.SysContab.PermisosDB.GetList("%", True, True, Me.dtpAl.DateTime.Date) 'Esta funcion devuelve dos tablas
        lds.Tables.Add(lds2.Tables(0).Copy) 'Copio la tabla 1 (Permisos) en el dataset lds 
        lds.Tables.Add(lds2.Tables(1).Copy) 'Copio la tabla 2 (Detalle de Permisos) en el dataset lds 
        lds2.Dispose()
        'Agrego la relacion Empleado Permisos
        lds.Relations.Add("Permisos", _
            lds.Tables("Empleados").Columns("Codigo"), _
            lds.Tables("Permisos").Columns("Empleado"))

        'Agrego la relacion Permisos - Detalle Permisos
        lds.Relations.Add("PermisosDetalles", _
                    lds.Tables("Permisos").Columns("Codigo"), _
                    lds.Tables("PermisosDetalles").Columns("Codigo"))


        dgEmpleados.DataSource = lds.Tables("Empleados")
        Me.VEmpleados.Columns("Departamento").OptionsColumn.ShowInCustomizationForm = True
        Me.VEmpleados.Columns("Departamento").Visible = False
        Me.VEmpleados.Columns("Direccion").Visible = False
        Me.VEmpleados.Columns("Telefono").Visible = False
        'Me.VEmpleados.Columns("Codigo").Width = 80
        'Me.VEmpleados.Columns("Nombre").Width = 250
        'Me.VEmpleados.Columns("Vacaciones").Width = 100
        'Me.VEmpleados.Columns("Dias Solicitados").Width = 100
        'Me.VEmpleados.Columns("Dias Procesados").Width = 100
        'Me.VEmpleados.Columns("Disponibles").Width = 100
        'Me.VEmpleados.Columns("Salario Promedio").Width = 100
        Me.VEmpleados.Columns("Salario Promedio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Salario Promedio").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Salario Promedio").Visible = False
        Me.VEmpleados.Columns("Salario Promedio").OptionsColumn.ShowInCustomizationForm = True

        Me.VEmpleados.Columns("Vacaciones").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Vacaciones").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Pendientes de Acumular").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Pendientes de Acumular").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Dias Solicitados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Dias Solicitados").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Dias Procesados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Dias Procesados").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Sexto Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Sexto Dia").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Septimo Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Septimo Dia").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Dias Descansados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Dias Descansados").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Vac. Pagadas").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Vac. Pagadas").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("Disponibles").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("Disponibles").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("ValorDia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("ValorDia").DisplayFormat.FormatString = "n2"
        Me.VEmpleados.Columns("A Pagar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VEmpleados.Columns("A Pagar").DisplayFormat.FormatString = "n2"


        Me.VEmpleados.Columns("Desde").Visible = False
        Me.VEmpleados.Columns("Desde").OptionsColumn.ShowInCustomizationForm = True
        Me.VEmpleados.Columns("Hasta").Visible = False
        Me.VEmpleados.Columns("Hasta").OptionsColumn.ShowInCustomizationForm = True
        Me.VEmpleados.Columns("Fin de Periodo").Visible = False
        Me.VEmpleados.Columns("Fin de Periodo").OptionsColumn.ShowInCustomizationForm = True


        If Me.VEmpleados.DataRowCount <> 0 Then
            Registro = Me.VEmpleados.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If
        Me.cbTiposPermisos.DataSource = VB.SysContab.TiposPermisosDB.GetList(False).Tables(0)
        Me.cbTiposPermisos.DisplayMember = "Descripcion"
        Me.cbTiposPermisos.ValueMember = "Codigo"

        For i As Integer = 0 To Me.VEmpleados.Columns.Count - 2
            Me.VEmpleados.Columns(i).OptionsColumn.ReadOnly = True
            Me.VEmpleados.Columns(i).OptionsColumn.AllowFocus = False
        Next

        Me.VEmpleados.BestFitColumns()

    End Sub
    

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdFeriados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFeriados.Click
        Dim forma As frmDarFeriados = frmDarFeriados.Instance
        frmDarFeriados.Todos = Me.ckbTodos.Checked
        forma.MdiParent = Me.MdiParent
        forma.Show()
    End Sub

    Private Sub cmdDias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDias.Click
        Dim forma As frmDarDias = frmDarDias.Instance
        frmDarDias.Todos = Me.ckbTodos.Checked
        forma.MdiParent = Me.MdiParent
        forma.Show()
    End Sub

    Private Sub cmdPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagos.Click
        If Me.ckbTodos.Checked Then
            If Me.VEmpleados.ActiveFilterString <> "" Then
                Dim llds As New DataSet
                llds = lds.Clone

                Dim a, b, c As DataRow()
                a = lds.Tables("Empleados").Select(Me.VEmpleados.ActiveFilterString)
                For i As Integer = 0 To a.GetUpperBound(0)
                    llds.Tables("Empleados").Rows.Add(a(i).ItemArray)
                    b = lds.Tables("Permisos").Select("[Empleado] = '" & a(i)("Codigo") & "'")
                    For j As Integer = 0 To b.GetUpperBound(0)
                        llds.Tables("Permisos").Rows.Add(b(j).ItemArray)
                        c = lds.Tables("PermisosDetalles").Select("[Codigo] = '" & b(j)("Codigo") & "'")
                        For k As Integer = 0 To c.GetUpperBound(0)
                            llds.Tables("PermisosDetalles").Rows.Add(c(k).ItemArray)
                        Next
                    Next
                Next

                Dim forma As frmPagoVacaciones = frmPagoVacaciones.Instance
                frmPagoVacaciones.Todos = Me.ckbTodos.Checked
                frmPagoVacaciones.Cantidad = IIf(Me.ckbTodos.Checked = True, 0, Me.VEmpleados.GetFocusedRowCellValue("Disponibles"))
                frmPagoVacaciones.Datos = llds.Tables("Empleados")
                forma.MdiParent = Me.MdiParent
                forma.Show()
            Else
                Dim forma As frmPagoVacaciones = frmPagoVacaciones.Instance
                frmPagoVacaciones.Todos = Me.ckbTodos.Checked
                frmPagoVacaciones.Cantidad = IIf(Me.ckbTodos.Checked = True, 0, Me.VEmpleados.GetFocusedRowCellValue("Disponibles"))
                frmPagoVacaciones.Datos = Me.VEmpleados.DataSource.table
                forma.MdiParent = Me.MdiParent
                forma.Show()
            End If
        Else

            Dim llds As New DataSet
            llds = lds.Clone

            Dim a, b, c As DataRow()
            a = lds.Tables("Empleados").Select("[Codigo]='" & Me.VEmpleados.GetFocusedRowCellValue("Codigo") & "'")
            For i As Integer = 0 To a.GetUpperBound(0)
                llds.Tables("Empleados").Rows.Add(a(i).ItemArray)
                b = lds.Tables("Permisos").Select("[Empleado] = '" & a(i)("Codigo") & "'")
                For j As Integer = 0 To b.GetUpperBound(0)
                    llds.Tables("Permisos").Rows.Add(b(j).ItemArray)
                    c = lds.Tables("PermisosDetalles").Select("[Codigo] = '" & b(j)("Codigo") & "'")
                    For k As Integer = 0 To c.GetUpperBound(0)
                        llds.Tables("PermisosDetalles").Rows.Add(c(k).ItemArray)
                    Next
                Next
            Next

            Dim forma As frmPagoVacaciones = frmPagoVacaciones.Instance
            frmPagoVacaciones.Todos = Me.ckbTodos.Checked
            frmPagoVacaciones.Cantidad = IIf(Me.ckbTodos.Checked = True, 0, Me.VEmpleados.GetFocusedRowCellValue("A Pagar"))
            frmPagoVacaciones.Datos = llds.Tables("Empleados")
            forma.MdiParent = Me.MdiParent
            forma.Show()

            End If

    End Sub

    Private Sub VEmpleados_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VEmpleados.CellValueChanged
        ''se lo quite a xerox, configurar mas tarde
        'If e.Column.FieldName = "A Pagar" Then
        '    If Me.VEmpleados.GetRowCellValue(e.RowHandle, "Disponibles") < 0 And Me.VEmpleados.GetRowCellValue(e.RowHandle, "A Pagar") <> 0 Then
        '        Me.VEmpleados.SetRowCellValue(e.RowHandle, "A Pagar", 0)
        '    ElseIf Me.VEmpleados.GetRowCellValue(e.RowHandle, "Disponibles") <= e.Value And Me.VEmpleados.GetRowCellValue(e.RowHandle, "Disponibles") <> Me.VEmpleados.GetRowCellValue(e.RowHandle, "A Pagar") And Me.VEmpleados.GetRowCellValue(e.RowHandle, "A Pagar") <> 0 Then
        '        Me.VEmpleados.SetRowCellValue(e.RowHandle, "A Pagar", Me.VEmpleados.GetRowCellValue(e.RowHandle, "Disponibles"))
        '    End If
        'End If
    End Sub



    Private Sub VEmpleados_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VEmpleados.FocusedRowChanged
        Registro = Me.VEmpleados.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        Dim forma As New frmexportaciongrid
        forma.Mostrar(Me.dgEmpleados)
    End Sub

    Private Sub cmdMasDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMasDatos.Click
        If Me.bMasDatos = False Then
            Me.VEmpleados.ColumnsCustomization()
            Me.bMasDatos = True
        Else
            Me.VEmpleados.DestroyCustomization()
            Me.bMasDatos = False
        End If
    End Sub

    Private Sub VEmpleados_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VEmpleados.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Cargar()
        End If
    End Sub


    Private Sub VEmpleados_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles VEmpleados.MasterRowExpanded
        If sender.FocusedRowHandle >= 0 Then
            dVista = sender.GetVisibleDetailView(sender.FocusedRowHandle)
            If Not dVista Is Nothing Then
                dVista.Columns("Codigo").Width = 100
                dVista.Columns("Codigo").OptionsColumn.ReadOnly = True

                dVista.Columns("Empleado").Visible = False

                dVista.Columns("HoraInicio").Width = 150
                dVista.Columns("HoraInicio").OptionsColumn.ReadOnly = True
                dVista.Columns("HoraInicio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                dVista.Columns("HoraInicio").DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"


                dVista.Columns("HoraFinal").Width = 150
                dVista.Columns("HoraFinal").OptionsColumn.ReadOnly = True
                dVista.Columns("HoraFinal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                dVista.Columns("HoraFinal").DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"

                dVista.Columns("Tipo").Width = 150
                dVista.Columns("Tipo").OptionsColumn.ReadOnly = True
                dVista.Columns("Tipo").ColumnEdit = Me.cbTiposPermisos

                dVista.Columns("Aplicado").Width = 80
                dVista.Columns("Aplicado").OptionsColumn.ReadOnly = True

                dVista.Columns("Periodo").Visible = False

                dVista.Columns("Dias Solicitados").Width = 80
                dVista.Columns("Dias Solicitados").OptionsColumn.ReadOnly = True
                dVista.Columns("Dias Solicitados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dVista.Columns("Dias Solicitados").DisplayFormat.FormatString = "n2"

                dVista.Columns("Dias Procesados").Width = 80
                dVista.Columns("Dias Procesados").OptionsColumn.ReadOnly = True
                dVista.Columns("Dias Procesados").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dVista.Columns("Dias Procesados").DisplayFormat.FormatString = "n2"

            End If
        End If
    End Sub

    Private Sub dVista_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles dVista.MasterRowExpanded
        If sender.FocusedRowHandle >= 0 Then
            dDVista = sender.GetVisibleDetailView(sender.FocusedRowHandle)
            If Not dDVista Is Nothing Then
                dDVista.Columns("Codigo").Width = 100
                dDVista.Columns("Codigo").OptionsColumn.ReadOnly = True

                dDVista.Columns("Periodo").Width = 100
                dDVista.Columns("Periodo").OptionsColumn.ReadOnly = True

                dDVista.Columns("Aplicado").Width = 100
                dDVista.Columns("Aplicado").OptionsColumn.ReadOnly = True

                dDVista.Columns("Cantidad").Width = 80
                dDVista.Columns("Cantidad").OptionsColumn.ReadOnly = True
                dDVista.Columns("Cantidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dDVista.Columns("Cantidad").DisplayFormat.FormatString = "n2"

                dDVista.Columns("Sexto Dia").Width = 80
                dDVista.Columns("Sexto Dia").OptionsColumn.ReadOnly = True
                dDVista.Columns("Sexto Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dDVista.Columns("Sexto Dia").DisplayFormat.FormatString = "n2"

                dDVista.Columns("Septimo Dia").Width = 80
                dDVista.Columns("Septimo Dia").OptionsColumn.ReadOnly = True
                dDVista.Columns("Septimo Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dDVista.Columns("Septimo Dia").DisplayFormat.FormatString = "n2"

                dDVista.Columns("Hasta").Width = 150
                dDVista.Columns("Hasta").OptionsColumn.ReadOnly = True
                dDVista.Columns("Hasta").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                dDVista.Columns("Hasta").DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt"

            End If
        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If Me.ckbTodos.Checked Then
            If Me.VEmpleados.ActiveFilterString = "" Then
                lds.WriteXml(Application.StartupPath & "\Vacaciones.xml", XmlWriteMode.WriteSchema)
                Me.cbTiposPermisos.DataSource.WriteXml(Application.StartupPath & "\TiposPermisos.xml", XmlWriteMode.WriteSchema)

                Dim visor As New frmReportes
                'Dim reporte As New rptVacaciones
                Dim reporte As Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If Not File.Exists(Application.StartupPath & "\reportes\rptVacaciones.rpt") Then
                    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptVacaciones.rpt")
                    Exit Sub
                End If
                reporte.load(Application.StartupPath & "\reportes\rptVacaciones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                reporte.Database.Tables("Empleados").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("Permisos").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("PermisosDetalles").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("tipospermisos").Location = Application.StartupPath & "\TiposPermisos.xml"

                visor.crvReportes.ReportSource = reporte
                visor.ShowDialog()
            Else
                Dim llds As New DataSet
                llds = lds.Clone

                Dim a, b, c As DataRow()
                a = lds.Tables("Empleados").Select(Me.VEmpleados.ActiveFilterString)
                For i As Integer = 0 To a.GetUpperBound(0)
                    llds.Tables("Empleados").Rows.Add(a(i).ItemArray)
                    b = lds.Tables("Permisos").Select("[Empleado] = '" & a(i)("Codigo") & "'")
                    For j As Integer = 0 To b.GetUpperBound(0)
                        llds.Tables("Permisos").Rows.Add(b(j).ItemArray)
                        c = lds.Tables("PermisosDetalles").Select("[Codigo] = '" & b(j)("Codigo") & "'")
                        For k As Integer = 0 To c.GetUpperBound(0)
                            llds.Tables("PermisosDetalles").Rows.Add(c(k).ItemArray)
                        Next
                    Next
                Next

                llds.WriteXml(Application.StartupPath & "\Vacaciones.xml", XmlWriteMode.WriteSchema)
                Me.cbTiposPermisos.DataSource.WriteXml(Application.StartupPath & "\TiposPermisos.xml", XmlWriteMode.WriteSchema)

                Dim visor As New frmReportes
                'Dim reporte As New rptVacaciones
                Dim reporte As Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If Not File.Exists(Application.StartupPath & "\reportes\rptVacaciones.rpt") Then
                    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptVacaciones.rpt")
                    Exit Sub
                End If
                reporte.load(Application.StartupPath & "\reportes\rptVacaciones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                reporte.Database.Tables("Empleados").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("Permisos").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("PermisosDetalles").Location = Application.StartupPath & "\Vacaciones.xml"
                reporte.Database.Tables("tipospermisos").Location = Application.StartupPath & "\TiposPermisos.xml"

                visor.crvReportes.ReportSource = reporte
                visor.ShowDialog()

            End If
        Else
            Dim ds, ds2 As New DataSet
            ds.Clear()
            ds.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(Me.dtpAl.EditValue, Me.VEmpleados.GetFocusedRowCellValue("Codigo")))
            ds2 = VB.SysContab.PermisosDB.GetList(Me.VEmpleados.GetFocusedRowCellValue("Codigo"), True, True, Me.dtpAl.DateTime.Date)
            ds.Tables.Add(ds2.Tables(0).Copy)
            ds.Tables.Add(ds2.Tables(1).Copy)
            ds2.Dispose()
            ds.Relations.Add("Permisos", _
                ds.Tables("Empleados").Columns("Codigo"), _
                ds.Tables("Permisos").Columns("Empleado"))
            ds.Relations.Add("PermisosDetalles", _
                        ds.Tables("Permisos").Columns("Codigo"), _
                        ds.Tables("PermisosDetalles").Columns("Codigo"))
            ds2 = Nothing
            ds.WriteXml(Application.StartupPath & "\Vacaciones.xml", XmlWriteMode.WriteSchema)
            Me.cbTiposPermisos.DataSource.WriteXml(Application.StartupPath & "\TiposPermisos.xml", XmlWriteMode.WriteSchema)

            Dim visor As New frmReportes
            'Dim reporte As New rptVacaciones
            Dim reporte As Object
            reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

            If Not File.Exists(Application.StartupPath & "\reportes\rptVacaciones.rpt") Then
                MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptVacaciones.rpt")
                Exit Sub
            End If
            reporte.load(Application.StartupPath & "\reportes\rptVacaciones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            reporte.Database.Tables("Empleados").Location = Application.StartupPath & "\Vacaciones.xml"
            reporte.Database.Tables("Permisos").Location = Application.StartupPath & "\Vacaciones.xml"
            reporte.Database.Tables("PermisosDetalles").Location = Application.StartupPath & "\Vacaciones.xml"
            reporte.Database.Tables("tipospermisos").Location = Application.StartupPath & "\TiposPermisos.xml"

            visor.crvReportes.ReportSource = reporte
            visor.ShowDialog()
        End If

    End Sub

    Private Sub dtpAl_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpAl.EditValueChanged
        If Me.cargado = True Then
            Me.Cargar()
        End If
    End Sub

    Private Sub cmdD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdD.Click
        For i As Integer = 0 To Me.VEmpleados.DataRowCount - 1
            If Me.VEmpleados.GetRowCellValue(i, "Disponibles") < 0 Then
                Me.VEmpleados.SetRowCellValue(i, "A Pagar", 0)
            ElseIf Me.VEmpleados.GetRowCellValue(i, "Disponibles") <= Me.spDias.EditValue Then
                Me.VEmpleados.SetRowCellValue(i, "A Pagar", Me.VEmpleados.GetRowCellValue(i, "Disponibles"))
            Else
                Me.VEmpleados.SetRowCellValue(i, "A Pagar", Me.spDias.EditValue)
            End If

        Next
    End Sub
End Class
