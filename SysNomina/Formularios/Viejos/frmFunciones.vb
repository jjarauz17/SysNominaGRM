Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmFunciones
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmFunciones = Nothing

    Public Shared Function Instance() As frmFunciones
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFunciones()
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
    Friend WithEvents cmdAyuda As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents dgFunciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents VFunciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgFunciones = New DevExpress.XtraGrid.GridControl
        Me.VFunciones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFunciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VFunciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 48)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(392, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 24)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(488, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(200, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 24)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(296, 16)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(104, 16)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 24)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 16)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'dgFunciones
        '
        Me.dgFunciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFunciones.Location = New System.Drawing.Point(12, 12)
        Me.dgFunciones.MainView = Me.VFunciones
        Me.dgFunciones.Name = "dgFunciones"
        Me.dgFunciones.Size = New System.Drawing.Size(588, 223)
        Me.dgFunciones.TabIndex = 13
        Me.dgFunciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VFunciones})
        '
        'VFunciones
        '
        Me.VFunciones.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VFunciones.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VFunciones.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VFunciones.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VFunciones.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VFunciones.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VFunciones.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VFunciones.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VFunciones.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VFunciones.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VFunciones.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VFunciones.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFunciones.Appearance.Empty.Options.UseBackColor = True
        Me.VFunciones.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VFunciones.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VFunciones.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VFunciones.Appearance.EvenRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VFunciones.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VFunciones.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VFunciones.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VFunciones.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFunciones.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VFunciones.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VFunciones.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VFunciones.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VFunciones.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VFunciones.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VFunciones.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VFunciones.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VFunciones.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupButton.Options.UseBackColor = True
        Me.VFunciones.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VFunciones.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VFunciones.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VFunciones.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VFunciones.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VFunciones.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VFunciones.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VFunciones.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VFunciones.Appearance.GroupRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.GroupRow.Options.UseFont = True
        Me.VFunciones.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VFunciones.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VFunciones.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VFunciones.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VFunciones.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VFunciones.Appearance.HorzLine.Options.UseBackColor = True
        Me.VFunciones.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.OddRow.Options.UseBackColor = True
        Me.VFunciones.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VFunciones.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VFunciones.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VFunciones.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VFunciones.Appearance.Preview.Options.UseBackColor = True
        Me.VFunciones.Appearance.Preview.Options.UseFont = True
        Me.VFunciones.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VFunciones.Appearance.Row.Options.UseBackColor = True
        Me.VFunciones.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VFunciones.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VFunciones.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VFunciones.Appearance.VertLine.Options.UseBackColor = True
        Me.VFunciones.GridControl = Me.dgFunciones
        Me.VFunciones.Name = "VFunciones"
        Me.VFunciones.OptionsBehavior.Editable = False
        Me.VFunciones.OptionsView.EnableAppearanceEvenRow = True
        Me.VFunciones.OptionsView.EnableAppearanceOddRow = True
        Me.VFunciones.OptionsView.ShowAutoFilterRow = True
        Me.VFunciones.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VFunciones.OptionsView.ShowFooter = True
        Me.VFunciones.OptionsView.ShowGroupPanel = False
        '
        'frmFunciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 301)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgFunciones)
        Me.Name = "frmFunciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFunciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VFunciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFunciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgFunciones.DataSource = VB.SysContab.FuncionesDB.GetList().Tables("Funciones")

        If Me.VFunciones.DataRowCount <> 0 Then
            Registro = Me.VFunciones.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If

        Me.Text = "Mantenimiento de Funciones"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarFuncion = frmAgregarFuncion.Instance
        Nuevo = "SI"
        z.MdiParent = Me.MdiParent
        z.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VFunciones.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Registro = Me.VFunciones.GetFocusedRowCellValue("Codigo")
        Dim f As frmAgregarFuncion = frmAgregarFuncion.Instance
        Nuevo = "NO"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

   
    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VFunciones.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        If MsgBox("Esta seguro que dese borrar la Función: " & _
            Me.VFunciones.GetFocusedRowCellValue("Codigo") & " - " & _
            Me.VFunciones.GetFocusedRowCellValue("Nombre"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            VB.SysContab.FuncionesDB.delete(Me.VFunciones.GetFocusedRowCellValue("Codigo"))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try
        dgFunciones.DataSource = VB.SysContab.FuncionesDB.GetList().Tables("Funciones")
        If Me.VFunciones.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VFunciones.GetFocusedRowCellValue("Codigo")
        End If



    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        Dim fReportes As New frmReportes()
        'Dim rFunciones As New rptFunciones()
        Dim rFunciones As New Object
        rFunciones = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptFunciones.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptFunciones.rpt")
            Exit Sub
        End If

        rFunciones.load(Application.StartupPath & "\reportes\rptFunciones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim Funciones As New VB.SysContab.FuncionesDB()

        Dim Ds As New DataSet
        Ds = Funciones.GetListReporte("%", EmpresaActual)
        Ds.WriteXml(Application.StartupPath & "\exportfiles\rFunciones.xml", XmlWriteMode.WriteSchema)

        rFunciones.Database.Tables("Funciones").Location = Application.StartupPath & "\exportfiles\rFunciones.xml"
        rFunciones.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        fReportes.crvReportes.ReportSource = rFunciones
        fReportes.ShowDialog()

    End Sub

    Private Sub VFunciones_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VFunciones.FocusedRowChanged
        Registro = Me.VFunciones.GetFocusedRowCellValue("Codigo")
    End Sub
End Class
