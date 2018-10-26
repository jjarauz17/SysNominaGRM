
Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmSeleccionarPeriodo
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmSeleccionarPeriodo = Nothing

    Public Shared Function Instance() As frmSeleccionarPeriodo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmSeleccionarPeriodo()
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
    Friend WithEvents cmdSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dgPeriodoNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents VSPeriodo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSeleccionar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.dgPeriodoNomina = New DevExpress.XtraGrid.GridControl
        Me.VSPeriodo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdSeleccionar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(603, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 205)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Location = New System.Drawing.Point(8, 8)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(112, 24)
        Me.cmdSeleccionar.TabIndex = 8
        Me.cmdSeleccionar.Text = "Seleccionar"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdSalir.Location = New System.Drawing.Point(8, 32)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(112, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Cancelar"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'dgPeriodoNomina
        '
        Me.dgPeriodoNomina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPeriodoNomina.EmbeddedNavigator.Name = ""
        Me.dgPeriodoNomina.Location = New System.Drawing.Point(12, 1)
        Me.dgPeriodoNomina.MainView = Me.VSPeriodo
        Me.dgPeriodoNomina.Name = "dgPeriodoNomina"
        Me.dgPeriodoNomina.Size = New System.Drawing.Size(587, 200)
        Me.dgPeriodoNomina.TabIndex = 12
        Me.dgPeriodoNomina.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VSPeriodo})
        '
        'VSPeriodo
        '
        Me.VSPeriodo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VSPeriodo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VSPeriodo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VSPeriodo.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VSPeriodo.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VSPeriodo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VSPeriodo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VSPeriodo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VSPeriodo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VSPeriodo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VSPeriodo.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VSPeriodo.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VSPeriodo.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VSPeriodo.Appearance.Empty.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VSPeriodo.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VSPeriodo.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VSPeriodo.Appearance.EvenRow.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VSPeriodo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VSPeriodo.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VSPeriodo.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VSPeriodo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VSPeriodo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VSPeriodo.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VSPeriodo.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VSPeriodo.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VSPeriodo.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VSPeriodo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VSPeriodo.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VSPeriodo.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VSPeriodo.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VSPeriodo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VSPeriodo.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VSPeriodo.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VSPeriodo.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VSPeriodo.Appearance.GroupButton.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VSPeriodo.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VSPeriodo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VSPeriodo.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VSPeriodo.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VSPeriodo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VSPeriodo.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VSPeriodo.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VSPeriodo.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VSPeriodo.Appearance.GroupRow.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.GroupRow.Options.UseFont = True
        Me.VSPeriodo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VSPeriodo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VSPeriodo.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VSPeriodo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VSPeriodo.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VSPeriodo.Appearance.HorzLine.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VSPeriodo.Appearance.OddRow.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VSPeriodo.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VSPeriodo.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VSPeriodo.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VSPeriodo.Appearance.Preview.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.Preview.Options.UseFont = True
        Me.VSPeriodo.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VSPeriodo.Appearance.Row.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VSPeriodo.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VSPeriodo.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VSPeriodo.Appearance.VertLine.Options.UseBackColor = True
        Me.VSPeriodo.GridControl = Me.dgPeriodoNomina
        Me.VSPeriodo.Name = "VSPeriodo"
        Me.VSPeriodo.OptionsBehavior.Editable = False
        Me.VSPeriodo.OptionsView.EnableAppearanceEvenRow = True
        Me.VSPeriodo.OptionsView.EnableAppearanceOddRow = True
        Me.VSPeriodo.OptionsView.ShowAutoFilterRow = True
        Me.VSPeriodo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VSPeriodo.OptionsView.ShowFooter = True
        Me.VSPeriodo.OptionsView.ShowGroupPanel = False
        '
        'frmSeleccionarPeriodo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(735, 213)
        Me.Controls.Add(Me.dgPeriodoNomina)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSeleccionarPeriodo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPeriodoNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSeleccionarPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgPeriodoNomina.DataSource = VB.SysContab.PeriodoNominaDB.GetList_Activos().Tables("PeriodoNomina")
        Me.VSPeriodo.Columns(0).Width = 50
        Me.VSPeriodo.Columns(1).Width = 200
        Me.VSPeriodo.Columns(2).Width = 80
        Me.VSPeriodo.Columns(3).Width = 80
        Me.VSPeriodo.Columns("per_codigo").Caption = "Periodo"
        Me.VSPeriodo.Columns("per_descripcion").Caption = "Descripcion"
        Me.VSPeriodo.Columns("per_finicio").Caption = "Fecha Inicio"
        Me.VSPeriodo.Columns("per_ffinal").Caption = "Fecha Final"
        If Me.VSPeriodo.DataRowCount <> 0 Then
            Registro = Me.VSPeriodo.GetFocusedRowCellValue("per_codigo")
        Else
            Registro = "Vacio"
        End If
        Me.Text = "PERIODOS DE NOMINA DISPONIBLES"
        Me.Refresh()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If Me.VSPeriodo.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VSPeriodo.GetFocusedRowCellValue("per_codigo")
        End If

        Dim PNominaDetails As New VB.SysContab.PeriodoNominaDetails()

        If Registro = "Vacio" Then
            QuincenaTrabajo = ""
            GoTo Salir
        End If
        PNominaDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        If PNominaDetails.Tipo = "A" Then
            MsgBox("Esta es una planilla de Aguinaldo, no puede seleccionarse como Periodo de Nomina de Trabajo", MsgBoxStyle.Critical)
            QuincenaTrabajo = ""
            Exit Sub
        End If

        If PNominaDetails.Procesado = True Then
            MsgBox("Este periodo de Nomina ya ha sido procesado, no puede ser seleccionado", MsgBoxStyle.OkOnly, "Error-")
            QuincenaTrabajo = ""
            Exit Sub
        End If

        QuincenaTrabajo = Registro
        'Ver los feriados de semana santa del año de la quincena de trabajo
        VB.SysContab.PeriodoNominaDB.Feriados(Mid(QuincenaTrabajo, 2, 4))

Salir:  Me.Close()
    End Sub

    Private Sub VSPeriodo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VSPeriodo.DoubleClick
        If Me.VSPeriodo.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VSPeriodo.GetFocusedRowCellValue("per_codigo")
        End If

        Dim PNominaDetails As New VB.SysContab.PeriodoNominaDetails()

        If Registro = "Vacio" Then
            QuincenaTrabajo = ""
            GoTo Salir
        End If
        PNominaDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        If PNominaDetails.Tipo = "A" Then
            MsgBox("Esta es una planilla de Aguinaldo, no puede seleccionarse como Periodo de Nomina de Trabajo", MsgBoxStyle.Critical)
            QuincenaTrabajo = ""
            Exit Sub
        End If

        If PNominaDetails.Procesado = True Then
            MsgBox("Este periodo de Nomina ya ha sido procesado, no puede ser seleccionado", MsgBoxStyle.OkOnly, "Error-")
            QuincenaTrabajo = ""
            Exit Sub
        End If

        QuincenaTrabajo = Registro
        'Ver los feriados de semana santa del año de la quincena de trabajo
        VB.SysContab.PeriodoNominaDB.Feriados(Mid(QuincenaTrabajo, 2, 4))

Salir:  Me.Close()
    End Sub


    Private Sub VSPeriodo_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VSPeriodo.FocusedRowChanged
        Registro = Me.VSPeriodo.GetFocusedRowCellValue("per_codigo")
    End Sub
End Class
