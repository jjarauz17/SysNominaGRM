Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmAreas
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAreas = Nothing

    Public Shared Function Instance() As frmAreas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAreas()
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
    Friend WithEvents dgAreas As DevExpress.XtraGrid.GridControl
    Friend WithEvents VAreas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdProduccion As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdProduccion = New System.Windows.Forms.Button
        Me.cmdAyuda = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgAreas = New DevExpress.XtraGrid.GridControl
        Me.VAreas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdProduccion)
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 48)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'cmdProduccion
        '
        Me.cmdProduccion.Location = New System.Drawing.Point(320, 16)
        Me.cmdProduccion.Name = "cmdProduccion"
        Me.cmdProduccion.Size = New System.Drawing.Size(118, 24)
        Me.cmdProduccion.TabIndex = 8
        Me.cmdProduccion.Text = "Produccion Semanal"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(524, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 24)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(602, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(164, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 24)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(242, 16)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(86, 16)
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
        'dgAreas
        '
        Me.dgAreas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAreas.Location = New System.Drawing.Point(12, 12)
        Me.dgAreas.MainView = Me.VAreas
        Me.dgAreas.Name = "dgAreas"
        Me.dgAreas.Size = New System.Drawing.Size(680, 267)
        Me.dgAreas.TabIndex = 9
        Me.dgAreas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VAreas})
        '
        'VAreas
        '
        Me.VAreas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.VAreas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.VAreas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.VAreas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VAreas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VAreas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VAreas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.VAreas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.VAreas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.VAreas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VAreas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VAreas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VAreas.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VAreas.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.VAreas.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VAreas.Appearance.Empty.Options.UseBackColor = True
        Me.VAreas.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.VAreas.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.VAreas.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.VAreas.Appearance.EvenRow.Options.UseBackColor = True
        Me.VAreas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.VAreas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.VAreas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VAreas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VAreas.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.VAreas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.VAreas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.VAreas.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VAreas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VAreas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VAreas.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.VAreas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VAreas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VAreas.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VAreas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VAreas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VAreas.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.VAreas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.VAreas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VAreas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VAreas.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.VAreas.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.VAreas.Appearance.GroupButton.Options.UseBackColor = True
        Me.VAreas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VAreas.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.VAreas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.VAreas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VAreas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VAreas.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.VAreas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.VAreas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VAreas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VAreas.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.VAreas.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VAreas.Appearance.GroupRow.Options.UseBackColor = True
        Me.VAreas.Appearance.GroupRow.Options.UseFont = True
        Me.VAreas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.VAreas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.VAreas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VAreas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VAreas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.VAreas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VAreas.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.VAreas.Appearance.HorzLine.Options.UseBackColor = True
        Me.VAreas.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VAreas.Appearance.OddRow.Options.UseBackColor = True
        Me.VAreas.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.VAreas.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.VAreas.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.VAreas.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.VAreas.Appearance.Preview.Options.UseBackColor = True
        Me.VAreas.Appearance.Preview.Options.UseFont = True
        Me.VAreas.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VAreas.Appearance.Row.Options.UseBackColor = True
        Me.VAreas.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VAreas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VAreas.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.VAreas.Appearance.VertLine.Options.UseBackColor = True
        Me.VAreas.GridControl = Me.dgAreas
        Me.VAreas.Name = "VAreas"
        Me.VAreas.OptionsBehavior.Editable = False
        Me.VAreas.OptionsView.EnableAppearanceEvenRow = True
        Me.VAreas.OptionsView.EnableAppearanceOddRow = True
        Me.VAreas.OptionsView.ShowAutoFilterRow = True
        Me.VAreas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VAreas.OptionsView.ShowFooter = True
        Me.VAreas.OptionsView.ShowGroupPanel = False
        '
        'frmAreas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(704, 345)
        Me.Controls.Add(Me.dgAreas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAreas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgAreas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAreas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgAreas.DataSource = VB.SysContab.AreaDB.GetListGrid().Tables("Areas").DefaultView
        Me.VAreas.Columns("Depto").Visible = False
        Me.VAreas.Columns("cArea").Visible = False
        If VAreas.DataRowCount = 0 Then
            Registro = "Vacio"
            Registro1 = "Vacio"
        Else
            Registro = VAreas.GetFocusedRowCellValue("Depto")
            Registro1 = VAreas.GetFocusedRowCellValue("cArea")
        End If
        Me.Text = "Mantenimiento de Areas"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarArea = frmAgregarArea.Instance
        Nuevo = "SI"
        z.MdiParent = Me.MdiParent
        z.Show()

    End Sub


    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.VAreas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = VAreas.GetFocusedRowCellValue("Depto")
        Registro1 = VAreas.GetFocusedRowCellValue("cArea")

        Dim f As frmAgregarArea = frmAgregarArea.Instance
        Nuevo = "NO"
        If Registro = "Vacio" Then
            MsgBox("Seleccione el Area que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub



    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VAreas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = VAreas.GetFocusedRowCellValue("Depto")
        Registro1 = VAreas.GetFocusedRowCellValue("cArea")

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Area que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Esta seguro que dese borrar el Area: " & _
            VAreas.GetFocusedRowCellValue("Depto") & " - " & _
            VAreas.GetFocusedRowCellValue("cArea"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            VB.SysContab.AreaDB.delete(VAreas.GetFocusedRowCellValue("Depto"), VAreas.GetFocusedRowCellValue("cArea"))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try


        dgAreas.DataSource = VB.SysContab.AreaDB.GetListGrid.Tables("areas")

        If Me.VAreas.DataRowCount = 0 Then
            Registro = "Vacio"
            Registro1 = "Vacio"
        Else
            Registro = VAreas.GetFocusedRowCellValue("Depto")
            Registro1 = VAreas.GetFocusedRowCellValue("cArea")

        End If

    End Sub



    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        Dim fReportes As New frmReportes()
        'Dim rDepartamentos As New rptDepartamentos()
        Dim rDepartamentos As New Object
        rDepartamentos = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptDepartamentos.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptDepartamentos.rpt")
            Exit Sub
        End If

        rDepartamentos.load(Application.StartupPath & "\reportes\rptDepartamentos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim Ds As New DataSet
        Ds = VB.SysContab.DepartamentosDB.GetListReporte("%", EmpresaActual)
        Ds.WriteXml(Application.StartupPath & "\exportfiles\rDepartamentos.xml", XmlWriteMode.WriteSchema)

        rDepartamentos.Database.Tables("Departamentos").Location = Application.StartupPath & "\exportfiles\rDepartamentos.xml"
        rDepartamentos.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        '   rDepartamentos.SetDataSource(Departamentos.GetListReporte(txtBuscar.Text, EmpresaActual))
        fReportes.crvReportes.ReportSource = rDepartamentos
        fReportes.ShowDialog()

    End Sub

    Private Sub VAreas_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VAreas.FocusedRowChanged
        Registro = VAreas.GetFocusedRowCellValue("Depto")
        Registro1 = VAreas.GetFocusedRowCellValue("cArea")
    End Sub

    Private Sub cmdProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProduccion.Click
        frmDptoProduccionSemanal.Dispose()
        frmDptoProduccionSemanal.ShowDialog()
    End Sub
End Class
