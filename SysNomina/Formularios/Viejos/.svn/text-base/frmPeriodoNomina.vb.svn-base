Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmPeriodoNomina
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmPeriodoNomina = Nothing

    Public Shared Function Instance() As frmPeriodoNomina
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPeriodoNomina()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents cmdSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dgPeriodoNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents VPeriodos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdSeleccionar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgPeriodoNomina = New DevExpress.XtraGrid.GridControl
        Me.VPeriodos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdSeleccionar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(801, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 467)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(8, 46)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(112, 24)
        Me.cmdModificar.TabIndex = 9
        Me.cmdModificar.Text = "Modificar"
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Location = New System.Drawing.Point(8, 76)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(112, 24)
        Me.cmdSeleccionar.TabIndex = 8
        Me.cmdSeleccionar.Text = "Seleccionar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 106)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 16)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(112, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'dgPeriodoNomina
        '
        Me.dgPeriodoNomina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPeriodoNomina.EmbeddedNavigator.Name = ""
        Me.dgPeriodoNomina.Location = New System.Drawing.Point(12, 12)
        Me.dgPeriodoNomina.MainView = Me.VPeriodos
        Me.dgPeriodoNomina.Name = "dgPeriodoNomina"
        Me.dgPeriodoNomina.Size = New System.Drawing.Size(783, 460)
        Me.dgPeriodoNomina.TabIndex = 115
        Me.dgPeriodoNomina.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VPeriodos, Me.GridView2})
        '
        'VPeriodos
        '
        Me.VPeriodos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VPeriodos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VPeriodos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VPeriodos.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VPeriodos.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VPeriodos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VPeriodos.Appearance.Empty.Options.UseBackColor = True
        Me.VPeriodos.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VPeriodos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VPeriodos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VPeriodos.Appearance.EvenRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VPeriodos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VPeriodos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VPeriodos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VPeriodos.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VPeriodos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VPeriodos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VPeriodos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VPeriodos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VPeriodos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupButton.Options.UseBackColor = True
        Me.VPeriodos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VPeriodos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VPeriodos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VPeriodos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VPeriodos.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VPeriodos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VPeriodos.Appearance.GroupRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.GroupRow.Options.UseFont = True
        Me.VPeriodos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VPeriodos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VPeriodos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VPeriodos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VPeriodos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VPeriodos.Appearance.HorzLine.Options.UseBackColor = True
        Me.VPeriodos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.OddRow.Options.UseBackColor = True
        Me.VPeriodos.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VPeriodos.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VPeriodos.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VPeriodos.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VPeriodos.Appearance.Preview.Options.UseBackColor = True
        Me.VPeriodos.Appearance.Preview.Options.UseFont = True
        Me.VPeriodos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VPeriodos.Appearance.Row.Options.UseBackColor = True
        Me.VPeriodos.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VPeriodos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VPeriodos.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VPeriodos.Appearance.VertLine.Options.UseBackColor = True
        Me.VPeriodos.GridControl = Me.dgPeriodoNomina
        Me.VPeriodos.Name = "VPeriodos"
        Me.VPeriodos.OptionsBehavior.Editable = False
        Me.VPeriodos.OptionsView.EnableAppearanceEvenRow = True
        Me.VPeriodos.OptionsView.EnableAppearanceOddRow = True
        Me.VPeriodos.OptionsView.ShowAutoFilterRow = True
        Me.VPeriodos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VPeriodos.OptionsView.ShowFooter = True
        Me.VPeriodos.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.dgPeriodoNomina
        Me.GridView2.Name = "GridView2"
        '
        'frmPeriodoNomina
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 542)
        Me.Controls.Add(Me.dgPeriodoNomina)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPeriodoNomina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPeriodoNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.Refrescar()
        If Me.VPeriodos.DataRowCount <> 0 Then
            Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
        Else
            Registro = "Vacio"
        End If
        Me.Text = "Periodos de Nomina" & IIf(QuincenaTrabajo = "", "", "Periodo de Trabajo: " & Microsoft.VisualBasic.Right(QuincenaTrabajo, 8))
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        Me.Refresh()
    End Sub
    Private Sub Refrescar()
        dgPeriodoNomina.DataSource = VB.SysContab.PeriodoNominaDB.GetList(True)
        Me.VPeriodos.Columns("per_codigo").Caption = "Periodo de Nomina" '0

        Me.VPeriodos.Columns("per_descripcion").Caption = "Descripción" '1
        Me.VPeriodos.Columns("per_descripcion").Width = 250

        Me.VPeriodos.Columns("per_procesado").Caption = "Procesada?"  '2
        Me.VPeriodos.Columns("per_revisado").Caption = "Revisada?"  '3
        Me.VPeriodos.Columns("per_aprobado").Caption = "Aprobada?" '4
        Me.VPeriodos.Columns("per_contabilizado").Caption = "Contabilizada?" '5
        Me.VPeriodos.Columns("per_finicio").Caption = "Desde"
        Me.VPeriodos.Columns("per_ffinal").Caption = "Hasta"
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub VPeriodos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VPeriodos.FocusedRowChanged
        Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        Dim PNominaDetails As New VB.SysContab.PeriodoNominaDetails()

        If Me.VPeriodos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        PNominaDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        If PNominaDetails.Tipo = "A" Then
            MsgBox("Esta es una planilla de Aguinaldo, no puede seleccionarse como Periodo de Nomina de Trabajo", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If PNominaDetails.Procesado = True Then
            MsgBox("Este periodo de Nomina ya ha sido procesado, no puede ser seleccionado", MsgBoxStyle.OkOnly, "Error-")
            Exit Sub
        End If

        QuincenaTrabajo = Registro
        'Ver los feriados de semana santa del año de la quincena de trabajo
        VB.SysContab.PeriodoNominaDB.Feriados(Mid(QuincenaTrabajo, 2, 4))
        Me.Text = "Periodos de Nomina - Periodo Actual: " + QuincenaTrabajo

        PNominaDetails = Nothing

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        If Me.VPeriodos.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
        End If
        Dim F As New frmAgregarPeriodoNomina()
        Nuevo = "SI"
        F.MdiParent = Me.MdiParent
        F.Show()
    End Sub


    Private Sub dgPeriodoNomina_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim PNominaDetails As New VB.SysContab.PeriodoNominaDetails()
        PNominaDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        If PNominaDetails.Procesado = True Then
            MsgBox("Este periodo de Nomina ya ha sido procesado, no puede ser seleccionado", MsgBoxStyle.OkOnly, "Error-")
            Exit Sub
        End If
        QuincenaTrabajo = Registro
        Me.Text = "Periodos de Nomina - Periodo Actual: " + QuincenaTrabajo
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VPeriodos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
        End If

        Dim F As New frmAgregarPeriodoNomina()
        Nuevo = "NO"
        F.MdiParent = Me.MdiParent
        F.Show()
    End Sub

   
End Class
