Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmCargos
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmCargos = Nothing

    Public Shared Function Instance() As frmCargos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCargos()
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
    Friend WithEvents dgCargos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vCargos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgCargos = New DevExpress.XtraGrid.GridControl
        Me.vCargos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCargos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 259)
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
        'dgCargos
        '
        Me.dgCargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCargos.Location = New System.Drawing.Point(12, 12)
        Me.dgCargos.MainView = Me.vCargos
        Me.dgCargos.Name = "dgCargos"
        Me.dgCargos.Size = New System.Drawing.Size(588, 241)
        Me.dgCargos.TabIndex = 13
        Me.dgCargos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vCargos})
        '
        'vCargos
        '
        Me.vCargos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.vCargos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vCargos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vCargos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vCargos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.vCargos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.vCargos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.vCargos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vCargos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vCargos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vCargos.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.vCargos.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.vCargos.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vCargos.Appearance.Empty.Options.UseBackColor = True
        Me.vCargos.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.vCargos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.vCargos.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.vCargos.Appearance.EvenRow.Options.UseBackColor = True
        Me.vCargos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vCargos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vCargos.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.vCargos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.vCargos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vCargos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vCargos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vCargos.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.vCargos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.vCargos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vCargos.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vCargos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vCargos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vCargos.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vCargos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vCargos.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupButton.Options.UseBackColor = True
        Me.vCargos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vCargos.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vCargos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vCargos.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.vCargos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.vCargos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vCargos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vCargos.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.vCargos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vCargos.Appearance.GroupRow.Options.UseBackColor = True
        Me.vCargos.Appearance.GroupRow.Options.UseFont = True
        Me.vCargos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.vCargos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.vCargos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.vCargos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.vCargos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vCargos.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.vCargos.Appearance.HorzLine.Options.UseBackColor = True
        Me.vCargos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.vCargos.Appearance.OddRow.Options.UseBackColor = True
        Me.vCargos.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.vCargos.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.vCargos.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.vCargos.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.vCargos.Appearance.Preview.Options.UseBackColor = True
        Me.vCargos.Appearance.Preview.Options.UseFont = True
        Me.vCargos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.vCargos.Appearance.Row.Options.UseBackColor = True
        Me.vCargos.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.vCargos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vCargos.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.vCargos.Appearance.VertLine.Options.UseBackColor = True
        Me.vCargos.GridControl = Me.dgCargos
        Me.vCargos.Name = "vCargos"
        Me.vCargos.OptionsBehavior.Editable = False
        Me.vCargos.OptionsView.EnableAppearanceEvenRow = True
        Me.vCargos.OptionsView.EnableAppearanceOddRow = True
        Me.vCargos.OptionsView.ShowAutoFilterRow = True
        Me.vCargos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vCargos.OptionsView.ShowFooter = True
        Me.vCargos.OptionsView.ShowGroupPanel = False
        '
        'frmCargos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(625, 312)
        Me.Controls.Add(Me.dgCargos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgCargos.DataSource = VB.SysContab.CargosDB.GetList().Tables("Cargos")
        Me.vCargos.Columns("Codigo").Visible = False
        If Me.vCargos.DataRowCount <> 0 Then
            Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If

        Me.Text = "Mantenimiento de Cargos"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarCargo = frmAgregarCargo.Instance
        Nuevo = "SI"
        z.MdiParent = Me.MdiParent
        z.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.vCargos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Information, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")

        Dim f As frmAgregarCargo = frmAgregarCargo.Instance
        Dim Cargos As New VB.SysContab.CargosDB()

        Nuevo = "NO"
        If Registro = "Vacio" Then
            MsgBox("Seleccione el Cargo que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    
    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vCargos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Information, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")
        If MsgBox("Esta seguro que dese borrar el Cargo: " & Me.vCargos.GetFocusedRowCellValue("Codigo") & " - " & Me.vCargos.GetFocusedRowCellValue("Nomina"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            VB.SysContab.CargosDB.delete(Me.vCargos.GetFocusedRowCellValue("Codigo"))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        dgCargos.DataSource = VB.SysContab.CargosDB.GetList().Tables("Cargos")
        If Me.vCargos.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")
        End If

    End Sub

  

   

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        Dim fReportes As New frmReportes()
        'Dim rCargos As New rptCargos()
        Dim rCargos As New Object
        rCargos = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptCargos.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptCargos.rpt")
            Exit Sub
        End If

        rCargos.load(Application.StartupPath & "\reportes\rptCargos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim Ds As New DataSet
        Ds = VB.SysContab.CargosDB.GetListReporte("%", EmpresaActual)
        Ds.WriteXml(Application.StartupPath & "\exportfiles\rCargos.xml", XmlWriteMode.WriteSchema)

        rCargos.Database.Tables("Cargos").Location = Application.StartupPath & "\exportfiles\rCargos.xml"
        rCargos.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"
        fReportes.crvReportes.ReportSource = rCargos
        fReportes.ShowDialog()

    End Sub


    Private Sub vCargos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vCargos.FocusedRowChanged
        Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")
    End Sub
End Class
