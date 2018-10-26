Imports System
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmAhorro
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmAhorro = Nothing

    Public Shared Function Instance() As frmAhorro
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAhorro()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region "Variables"
    Public Estado As String
    Public Unico As Boolean
#End Region

#Region "Calaches"
    Friend WithEvents dgAhorro As DevExpress.XtraGrid.GridControl
    Friend WithEvents Vahorro As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdEmail As System.Windows.Forms.Button
    Friend WithEvents chkLiquidados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMarcar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdEmail = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.dgAhorro = New DevExpress.XtraGrid.GridControl
        Me.Vahorro = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.chkLiquidados = New DevExpress.XtraEditors.CheckEdit
        Me.chkMarcar = New DevExpress.XtraEditors.CheckEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgAhorro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vahorro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLiquidados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMarcar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdEmail)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 355)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 48)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdEmail
        '
        Me.cmdEmail.Location = New System.Drawing.Point(320, 16)
        Me.cmdEmail.Name = "cmdEmail"
        Me.cmdEmail.Size = New System.Drawing.Size(92, 24)
        Me.cmdEmail.TabIndex = 7
        Me.cmdEmail.Text = "Enviar correo"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(448, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
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
        'dgAhorro
        '
        Me.dgAhorro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAhorro.EmbeddedNavigator.Name = ""
        Me.dgAhorro.Location = New System.Drawing.Point(12, 51)
        Me.dgAhorro.MainView = Me.Vahorro
        Me.dgAhorro.Name = "dgAhorro"
        Me.dgAhorro.Size = New System.Drawing.Size(526, 298)
        Me.dgAhorro.TabIndex = 12
        Me.dgAhorro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vahorro, Me.GridView2})
        '
        'Vahorro
        '
        Me.Vahorro.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.Vahorro.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.Vahorro.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.Vahorro.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.Vahorro.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.Vahorro.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.Vahorro.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.Vahorro.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.Vahorro.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.Vahorro.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.Vahorro.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.Vahorro.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.Vahorro.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Vahorro.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.Vahorro.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Vahorro.Appearance.Empty.Options.UseBackColor = True
        Me.Vahorro.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.Vahorro.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.Vahorro.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Vahorro.Appearance.EvenRow.Options.UseBackColor = True
        Me.Vahorro.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.Vahorro.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.Vahorro.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.Vahorro.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.Vahorro.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.Vahorro.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.Vahorro.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.Vahorro.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Vahorro.Appearance.FilterPanel.Options.UseBackColor = True
        Me.Vahorro.Appearance.FilterPanel.Options.UseForeColor = True
        Me.Vahorro.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.Vahorro.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Vahorro.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.Vahorro.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Vahorro.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Vahorro.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Vahorro.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.Vahorro.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.Vahorro.Appearance.FooterPanel.Options.UseBackColor = True
        Me.Vahorro.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.Vahorro.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.Vahorro.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.Vahorro.Appearance.GroupButton.Options.UseBackColor = True
        Me.Vahorro.Appearance.GroupButton.Options.UseBorderColor = True
        Me.Vahorro.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.Vahorro.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.Vahorro.Appearance.GroupFooter.Options.UseBackColor = True
        Me.Vahorro.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.Vahorro.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.Vahorro.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.Vahorro.Appearance.GroupPanel.Options.UseBackColor = True
        Me.Vahorro.Appearance.GroupPanel.Options.UseForeColor = True
        Me.Vahorro.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.Vahorro.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Vahorro.Appearance.GroupRow.Options.UseBackColor = True
        Me.Vahorro.Appearance.GroupRow.Options.UseFont = True
        Me.Vahorro.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.Vahorro.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.Vahorro.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.Vahorro.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.Vahorro.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.Vahorro.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.Vahorro.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.Vahorro.Appearance.HorzLine.Options.UseBackColor = True
        Me.Vahorro.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.Vahorro.Appearance.OddRow.Options.UseBackColor = True
        Me.Vahorro.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.Vahorro.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.Vahorro.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.Vahorro.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Vahorro.Appearance.Preview.Options.UseBackColor = True
        Me.Vahorro.Appearance.Preview.Options.UseFont = True
        Me.Vahorro.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.Vahorro.Appearance.Row.Options.UseBackColor = True
        Me.Vahorro.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Vahorro.Appearance.RowSeparator.Options.UseBackColor = True
        Me.Vahorro.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.Vahorro.Appearance.VertLine.Options.UseBackColor = True
        Me.Vahorro.GridControl = Me.dgAhorro
        Me.Vahorro.Name = "Vahorro"
        Me.Vahorro.OptionsView.EnableAppearanceEvenRow = True
        Me.Vahorro.OptionsView.EnableAppearanceOddRow = True
        Me.Vahorro.OptionsView.ShowAutoFilterRow = True
        Me.Vahorro.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vahorro.OptionsView.ShowFooter = True
        Me.Vahorro.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.dgAhorro
        Me.GridView2.Name = "GridView2"
        '
        'chkLiquidados
        '
        Me.chkLiquidados.Location = New System.Drawing.Point(10, 26)
        Me.chkLiquidados.Name = "chkLiquidados"
        Me.chkLiquidados.Properties.Caption = "Incluir Liquidados"
        Me.chkLiquidados.Size = New System.Drawing.Size(127, 19)
        Me.chkLiquidados.TabIndex = 13
        '
        'chkMarcar
        '
        Me.chkMarcar.Location = New System.Drawing.Point(10, 1)
        Me.chkMarcar.Name = "chkMarcar"
        Me.chkMarcar.Properties.Caption = "Marcar Todos"
        Me.chkMarcar.Size = New System.Drawing.Size(127, 19)
        Me.chkMarcar.TabIndex = 14
        '
        'frmAhorro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(599, 415)
        Me.Controls.Add(Me.chkMarcar)
        Me.Controls.Add(Me.chkLiquidados)
        Me.Controls.Add(Me.dgAhorro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAhorro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgAhorro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vahorro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLiquidados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMarcar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAhorro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgAhorro.DataSource = VB.SysContab.Empleado_AhorroDB.GetListEmpleado_Ahorro_Grid("%").Tables("Empleado_Ahorro")
        Me.Vahorro.Columns("TAhorro").Visible = False
        Me.Vahorro.Columns("Empleado").OptionsColumn.ReadOnly = True
        Me.Vahorro.Columns("Nombre").OptionsColumn.ReadOnly = True
        Me.Vahorro.Columns("Tipo de Ahorro").OptionsColumn.ReadOnly = True
        Me.Vahorro.Columns("Liquidado").OptionsColumn.ReadOnly = True


        If Me.Vahorro.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.Vahorro.GetFocusedRowCellValue("Empleado") & Me.Vahorro.GetFocusedRowCellValue("TAhorro")
        End If

        Me.Text = "Mantenimiento de Tanque de Ahorro de Empleados de Empleados"
        VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarAhorro = frmAgregarAhorro.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.Vahorro.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.Vahorro.GetFocusedRowCellValue("Empleado") & Me.Vahorro.GetFocusedRowCellValue("TAhorro")

        Dim f As frmAgregarAhorro = frmAgregarAhorro.Instance
        Nuevo = "NO"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.Vahorro.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.Vahorro.GetFocusedRowCellValue("Empleado") & Me.Vahorro.GetFocusedRowCellValue("TAhorro")

        Dim EAhorro As New VB.SysContab.Empleado_AhorroDB()
        Dim ds As New DataTable

        ds = VB.SysContab.Empleado_AhorroDB.GetListEmpleado_Ahorro(Me.Vahorro.GetFocusedRowCellValue("Empleado"))

        If ds.Rows.Count > 0 Then
            MsgBox("No se puede borrar este registro porque tiene detalle de deduccion por Ahorro", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Esta seguro que dese borrar el Registro ", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        VB.SysContab.Empleado_AhorroDB.delete(Me.Vahorro.GetFocusedRowCellValue("Empleado"))
        ds.Dispose()
        dgAhorro.DataSource = VB.SysContab.Empleado_AhorroDB.GetListEmpleado_Ahorro_Grid("%").Tables("Empleado_Ahorro")
        If Me.Vahorro.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.Vahorro.GetFocusedRowCellValue("Empleado") & Me.Vahorro.GetFocusedRowCellValue("TAhorro")
        End If


    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
       
        Dim fReportes As New frmReportes()
        'Dim Reporte As New ReporteAhorro()
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\ReporteAhorro.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\ReporteAhorro.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\ReporteAhorro.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim ahorro As New VB.SysContab.Empleado_AhorroDB()

        Dim Ds As New DataSet
        Ds = VB.SysContab.Empleado_AhorroDB.ImprimirEmpleado_Ahorro("%")

        Ds.WriteXml(Application.StartupPath & "\exportfiles\rReporteAhorro.xml", XmlWriteMode.WriteSchema)
        Reporte.Database.Tables("ReporteAhorro").Location = Application.StartupPath & "\exportfiles\rReporteAhorro.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        fReportes.crvReportes.ReportSource = Reporte
        fReportes.ShowDialog()
    End Sub


    Private Sub Vahorro_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Vahorro.FocusedRowChanged
        Registro = Me.Vahorro.GetFocusedRowCellValue("Empleado") & Me.Vahorro.GetFocusedRowCellValue("TAhorro")
    End Sub

    Private Sub cmdEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmail.Click
        If Me.Vahorro.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Dim detEmpleados As New VB.SysContab.EmpleadosDetails()
        Dim lds As New DataSet

        For i As Integer = 0 To Me.Vahorro.DataRowCount - 1
            If Me.Vahorro.GetRowCellValue(i, "Seleccionar") = True Then
                If Not Me.chkLiquidados.Checked Then
                    If Me.Vahorro.GetRowCellValue(i, "Liquidado") = True Then
                        GoTo seguir
                    End If
                End If

                'Dim rColilla As New rptECAhorro()
                Dim rColilla As New Object
                rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If Not File.Exists(Application.StartupPath & "\reportes\rptECAhorro.rpt") Then
                    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECAhorro.rpt")
                    Exit Sub
                End If

                rColilla.load(Application.StartupPath & "\reportes\rptECAhorro.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                lds.Clear()
                detEmpleados = VB.SysContab.EmpleadosDB.GetDetails(Me.Vahorro.GetRowCellValue(i, "Empleado"))
                lds = VB.SysContab.Empleado_AhorroDB.GetListReporteEcAhorro(Me.Vahorro.GetRowCellValue(i, "Empleado"))

                lds.WriteXml(Application.StartupPath & "\exportfiles\ECAhorro.xml", XmlWriteMode.WriteSchema)
                rColilla.Database.Tables("vAhorro").Location = Application.StartupPath & "\exportfiles\ECAhorro.xml"
                rColilla.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"


                Dim crExportOptions As CrystalDecisions.Shared.ExportOptions
                Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
                Dim fname As String

                If detEmpleados.Email <> "" And Not (detEmpleados.Email Is DBNull.Value) Then

                    fname = Application.StartupPath() & "\exportfiles\Ahorro_" & Me.Vahorro.GetRowCellValue(i, "Empleado") & ".pdf"
                    crDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions()
                    crDiskFileDestinationOptions.DiskFileName = fname
                    crExportOptions = rColilla.ExportOptions
                    With crExportOptions
                        .DestinationOptions = crDiskFileDestinationOptions
                        .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                        .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                    End With
                    rColilla.Export()
                    VB.SysContab.Email.Enviar_Mail_Outlook(detEmpleados.Email, "Estado de Cuenta de Ahorro", _
                        "Sírvase revisar el estado de Cuenta de Ahorro en archivo Adjunto", fname)
                    rColilla.Dispose()

                End If
            End If
seguir: Next

    End Sub

    Private Sub chkMarcar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMarcar.CheckedChanged
        If Me.Vahorro.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        For i As Integer = 0 To Me.Vahorro.DataRowCount - 1
            Me.Vahorro.SetRowCellValue(i, "Seleccionar", Me.chkMarcar.Checked)
        Next
    End Sub
End Class
