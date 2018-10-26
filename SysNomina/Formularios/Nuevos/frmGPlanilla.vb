Imports System.IO
Imports System.Net.Mail.SmtpClient
Imports System.Xml
Imports System.Net.Mail.MailMessage
Imports DevExpress.XtraReports.UI
Imports System.Collections

Public Class frmGPlanilla

#Region "Variables"
    Public cEmpleado, cDepartamento, cArea, cOrden As String
    Public cLocalidad As Integer = 0
    Public ChkSalario As Boolean = True
    Public Cancelar As Boolean
    Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[per_codigo] like '_" & Now.Year.ToString & "%'")

#End Region

    Private Sub frmGPlanilla_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refrescar()
        End If
    End Sub

    Private Sub frmGenPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cEmpleado = ""
        cDepartamento = ""
        cArea = ""
        cOrden = ""

        Me.Refrescar()

        Me.Text = "Periodos de Nomina" & IIf(QuincenaTrabajo = "", "", "Periodo de Trabajo: " & Microsoft.VisualBasic.Right(QuincenaTrabajo, 8))
        'Me.cmdVisor.Enabled = IIf(Registro <> "Vacio" And Me.cmdVisor.Enabled = True, True, False)
        Me.txtEnvio.Visible = False
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub vPlanillas_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vPlanillas.FocusedRowChanged
        If vPlanillas.FocusedRowHandle < 0 Then Exit Sub

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        'And _
        '       Me.btnBAC.Enabled = True,
        Registro = Me.vPlanillas.GetFocusedRowCellValue("per_codigo")
        Me.btnBAC.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
               Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
               Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
               Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado"), True, False)

        'Me.btnXMLINSS.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
        '    Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
        '    Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
        '    Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
        '    Me.btnXMLINSS.Enabled = True, True, False)

        ''And _
        ''Me.cmdGenFirme.Enabled = True
        Me.cmdGenFirme.Enabled = IIf(Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado"), True, False)
    End Sub


    Private Sub cmdGenFirme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub cmdVisor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cmdVerFichas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ImpresionColilla_MediaPagina(ByRef Documento As Object, ByVal Empleado_Codigo As String, _
        ByVal Localidad As Integer, ByVal Departamento As String, _
        ByVal Area As String, ByVal Orden As String)

        Dim lds As DataSet
        Dim EncDS As DataTable
        Dim IngrDS As DataSet
        Dim Periodo As String, TPeriodo As String

        'Documento = New rptColilla_MediaPagina
        Documento = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt")
            Exit Sub
        End If

        Documento.load(Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)



        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro = "Vacio" Then
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing
        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, Empleado_Codigo, Localidad, Departamento, Area, Orden, 0, 0) '.Tables("_ReportePlanillaEnc;1")
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)

        IngrDS = VB.SysContab.PlanillaDB.ImprimirColilla_Detalle(Periodo, TPeriodo, Empleado_Codigo, Departamento, Area)
        IngrDS.WriteXml(Application.StartupPath & "\Detalle.xml", XmlWriteMode.WriteSchema)
        IngrDS = Nothing

        Documento.Database.Tables("Empresa").Location = Application.StartupPath & "\logoempresa_ref.xml"
        Documento.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"
        Documento.Database.Tables("ColillaDetalle").Location = Application.StartupPath & "\Detalle.xml"

        Documento.subreports.item("Ingresos").database.tables(0).location = Application.StartupPath & "\Detalle.xml"
        Documento.subreports.item("Deducciones").database.tables(0).location = Application.StartupPath & "\Detalle.xml"

    End Sub

    Private Sub ImpresionColilla(ByRef Documento As Object, ByVal Empleado_Codigo As String, _
        ByVal Departamento As String, _
        ByVal Area As String, ByVal Orden As String)

        Dim lds As DataSet
        Dim EncDS As DataTable
        Dim IngrDS As DataSet
        Dim EgrDS As DataSet
        Dim VacDS As DataSet

        Dim Empleado As String, Periodo As String, TPeriodo As String

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro <> "Vacio" Then
            Empleado = "%"
        Else
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Empleado = ""
            Exit Sub
        End If

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\exportfiles\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing
        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, Empleado, 0, Departamento, Area, Orden, 0, 0) '.Tables("_ReportePlanillaEnc;1")
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)

        'Dim VDS As New DataSet
        'Dim ff As Date
        'ff = VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FFinal
        'VDS.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(ff, Empleado_Codigo))
        'VDS.WriteXml(Application.StartupPath & "\v.xml", XmlWriteMode.WriteSchema)
        'ff = Nothing


        'CalDS = Planilla.ImprimirColilla_Asistencias(Periodo, TPeriodo, Empleado, Departamento, Area)
        'CalDS.WriteXml(Application.StartupPath & "\CalPla.xml", XmlWriteMode.WriteSchema)

        'LatDS = Planilla.ImprimirColilla_Latas(Periodo, TPeriodo, Empleado, Departamento, Area)
        'LatDS.WriteXml(Application.StartupPath & "\LatPla.xml", XmlWriteMode.WriteSchema)

        IngrDS = VB.SysContab.PlanillaDB.ImprimirColillaIng(Periodo, TPeriodo, Empleado, Departamento, Area)
        IngrDS.WriteXml(Application.StartupPath & "\IngrPla.xml", XmlWriteMode.WriteSchema)
        EgrDS = VB.SysContab.PlanillaDB.ImprimirColillaEgr(Periodo, TPeriodo, Empleado, Departamento, Area)
        EgrDS.WriteXml(Application.StartupPath & "\EgrPla.xml", XmlWriteMode.WriteSchema)
        VacDS = VB.SysContab.PlanillaDB.ImprimirColillaEgrVD(Periodo, TPeriodo, Empleado, Departamento, Area)
        VacDS.WriteXml(Application.StartupPath & "\VacPla.xml", XmlWriteMode.WriteSchema)
        Documento.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa_ref.xml"
        Documento.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"
        Documento.Subreports.Item("Ingresos").Database.Tables(0).Location = Application.StartupPath & "\IngrPla.xml" '.SetDataSource()
        Documento.Subreports.Item("Egresos").Database.Tables(0).Location = Application.StartupPath & "\EgrPla.xml" '.SetDataSource()

        Documento.Subreports.Item("rptVDescansadas").Database.Tables(0).Location = Application.StartupPath & "\VacPla.xml" '.SetDataSource()
        'Documento.subreports.item("V").Database.Tables("Empleados").Location = Application.StartupPath & "\V.xml"
        'If Registro.Substring(0, 1) = "U" Then
        '    Documento.Subreports.Item("semana1").Database.Tables("Calendario").Location = Application.StartupPath & "\LatPla.xml" '.SetDataSource()
        '    Documento.Subreports.Item("semana2").Database.Tables(0).Location = Application.StartupPath & "\LatPla.xml" '.SetDataSource()
        'End If
        'If Registro.Substring(0, 1) = "D" Then
        '    Documento.Subreports.Item("Semana1").Database.Tables(0).Location = Application.StartupPath & "\calPla.xml" '.SetDataSource()
        '    Documento.Subreports.Item("Semana2").Database.Tables(0).Location = Application.StartupPath & "\calPla.xml" '.SetDataSource()

        'End If

    End Sub

    Private Sub ImpresionColilla_Xerox(ByRef Documento As Object, ByVal Empleado_Codigo As String, _
        ByVal Departamento As String, _
        ByVal Area As String, ByVal Orden As String)

        Dim lds As DataSet
        Dim EncDS As DataTable
        Dim IngrDS As DataSet
        Dim EgrDS As DataSet
        'Dim VacDS As DataSet
        Dim VDS As New DataSet
        Dim Empleado As String, Periodo As String, TPeriodo As String

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro <> "Vacio" Then
            Empleado = "%"
        Else
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Empleado = ""
            Exit Sub
        End If

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\exportfiles\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing
        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, Empleado, 0, Departamento, Area, Orden, 0, 0) '.Tables("_ReportePlanillaEnc;1")
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)

        Dim ff As Date
        ff = VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FFinal
        VDS.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(ff, Empleado_Codigo))
        VDS.WriteXml(Application.StartupPath & "\v.xml", XmlWriteMode.WriteSchema)
        ff = Nothing



        IngrDS = VB.SysContab.PlanillaDB.ImprimirColillaIng(Periodo, TPeriodo, Empleado, Departamento, Area)
        IngrDS.WriteXml(Application.StartupPath & "\IngrPla.xml", XmlWriteMode.WriteSchema)
        EgrDS = VB.SysContab.PlanillaDB.ImprimirColillaEgr(Periodo, TPeriodo, Empleado, Departamento, Area)
        EgrDS.WriteXml(Application.StartupPath & "\EgrPla.xml", XmlWriteMode.WriteSchema)

        Documento.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa_ref.xml"
        Documento.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"
        Documento.Subreports.Item("Ingresos").Database.Tables(0).Location = Application.StartupPath & "\IngrPla.xml" '.SetDataSource()
        Documento.Subreports.Item("Egresos").Database.Tables(0).Location = Application.StartupPath & "\EgrPla.xml" '.SetDataSource()
        Documento.subreports.item("V").Database.Tables(0).Location = Application.StartupPath & "\V.xml"

    End Sub

    Private Sub ImpresionColilla(ByRef Documento As Object, ByVal empleado As String, _
            ByVal Periodo As String, ByVal TPeriodo As String, ByVal Departamento As String, _
            ByVal Area As String, _
            ByVal Orden As String)


        Dim lds As DataSet
        Dim EncDS As DataTable
        Dim IngrDS As DataSet
        Dim EgrDS As DataSet
        Dim VacDS As DataSet

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia


        Documento = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptColilla.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla.rpt")
            Exit Sub
        End If

        Documento.load(Application.StartupPath & "\reportes\rptColilla.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\exportfiles\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing

        EncDS = VB.SysContab.PlanillaDB.ImprimirColilla(Periodo, TPeriodo, empleado, 0, Departamento, Area, Orden, 0, 0) '.Tables("_ReportePlanillaEnc;1")
        EncDS.WriteXml(Application.StartupPath & "\EncPla.xml", XmlWriteMode.WriteSchema)
        'Dim VDS As New DataSet

        'VDS = Nothing
        'VDS.Tables.Add(VB.SysContab.EmpleadosDB.GetListVacaciones(VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FFinal, empleado))
        'VDS.WriteXml(Application.StartupPath & "\v.xml", XmlWriteMode.WriteSchema)


        IngrDS = VB.SysContab.PlanillaDB.ImprimirColillaIng(Periodo, TPeriodo, empleado, Departamento, Area)
        IngrDS.WriteXml(Application.StartupPath & "\IngrPla.xml", XmlWriteMode.WriteSchema)
        EgrDS = VB.SysContab.PlanillaDB.ImprimirColillaEgr(Periodo, TPeriodo, empleado, Departamento, Area)
        EgrDS.WriteXml(Application.StartupPath & "\EgrPla.xml", XmlWriteMode.WriteSchema)
        VacDS = VB.SysContab.PlanillaDB.ImprimirColillaEgrVD(Periodo, TPeriodo, empleado, Departamento, Area)
        VacDS.WriteXml(Application.StartupPath & "\VacPla.xml", XmlWriteMode.WriteSchema)

        Documento.Database.Tables("Empresa").Location = Application.StartupPath & "\logoempresa_ref.xml"
        Documento.Database.Tables("_ReportePlanillaEnc;1").Location = Application.StartupPath & "\EncPla.xml"
        Documento.Subreports.Item("Ingresos").Database.Tables(0).Location = Application.StartupPath & "\IngrPla.xml" '.SetDataSource()
        Documento.Subreports.Item("Egresos").Database.Tables(0).Location = Application.StartupPath & "\EgrPla.xml" '.SetDataSource()
        Documento.Subreports.Item("rptVDescansadas").Database.Tables(0).Location = Application.StartupPath & "\VacPla.xml" '.SetDataSource()
        'Documento.Subreports.Item("V").Database.Tables("Empleados").Location = Application.StartupPath & "\V.xml"

    End Sub

    Private Sub cmdIRSairi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        'ds = VB.SysContab.PlanillaDB.IRSairi(Microsoft.VisualBasic.Right(Registro, 8), Microsoft.VisualBasic.Left(Registro, 1))
        'Me.SFD.InitialDirectory = Application.StartupPath()

        'Me.SFD.Filter = "Text Files (*.txt)|*.txt"
        'Me.SFD.FilterIndex = 1
        'Me.SFD.RestoreDirectory = True
        'Me.SFD.FileName = Application.StartupPath() & "\exportfiles\" & Microsoft.VisualBasic.Left(Registro, 1) & Microsoft.VisualBasic.Right(Registro, 8) & ".txt"
        'If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Try
        '        If VB.SysContab.RutinasNomina.ExportarTXT(ds.Tables("Ir"), Me.SFD.FileName, Longitud_Linea_Archivos.SAIRI) Then
        '            MsgBox("Archivo generado satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        '        Else
        '            MsgBox("El archivo no pudo ser generado. Consulte con al Administrador del Sistema", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        '        End If
        '    Catch Ex As Exception
        '        MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
        '        Exit Sub
        '    Finally

        '    End Try
        'End If



    End Sub

    Private Sub btnBAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Refrescar()
        dgPeriodoNomina.DataSource = VB.SysContab.PeriodoNominaDB.GetList(True)

        Me.vPlanillas.Columns("per_codigo").Caption = "Periodo de Nomina" '0

        Me.vPlanillas.Columns("per_descripcion").Caption = "Descripción" '1
        Me.vPlanillas.Columns("per_descripcion").Width = 250

        Me.vPlanillas.Columns("per_procesado").Caption = "Procesada?"  '2
        Me.vPlanillas.Columns("per_revisado").Caption = "Revisada?"  '3
        Me.vPlanillas.Columns("per_aprobado").Caption = "Aprobada?" '4
        Me.vPlanillas.Columns("per_contabilizado").Caption = "Contabilizada?" '5
        Me.vPlanillas.Columns("per_finicio").Caption = "Desde"
        Me.vPlanillas.Columns("per_codigo").FilterInfo = Filtro
        Me.vPlanillas.Columns("per_ffinal").Caption = "Hasta"


        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        If Me.vPlanillas.DataRowCount > 0 Then
            Registro = Me.vPlanillas.GetFocusedRowCellValue("per_codigo") 'dgPeriodoNomina.Item(0, 0)
            ' And _
            'Me.btnBAC.Enabled = True
            Me.btnBAC.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
                Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
                Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
                Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado"), True, False)

            'Me.btnXMLINSS.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
            '    Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
            '    Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
            '    Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
            '    Me.btnXMLINSS.Enabled = True, True, False)
            Me.btnEmail.Enabled = IIf(Me.vPlanillas.GetFocusedRowCellValue("per_procesado") And _
                Me.vPlanillas.GetFocusedRowCellValue("per_revisado") And _
                Me.vPlanillas.GetFocusedRowCellValue("per_aprobado") And _
                Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
                Me.btnEmail.Enabled = True, True, False)
            Me.cmdGenFirme.Enabled = IIf(Not Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado") And _
                Me.cmdGenFirme.Enabled = True, True, False)

            'Me.btnBAC.Enabled = IIf(dgPeriodoNomina.Item(0, 2) And dgPeriodoNomina.Item(0, 3) And dgPeriodoNomina.Item(0, 4) And Not dgPeriodoNomina.Item(0, 5) And Me.btnBAC.Enabled = True, True, False)
            'Me.btnXMLINSS.Enabled = IIf(dgPeriodoNomina.Item(0, 2) And dgPeriodoNomina.Item(0, 3) And dgPeriodoNomina.Item(0, 4) And Not dgPeriodoNomina.Item(0, 5) And Me.btnXMLINSS.Enabled = True, True, False)
            'Me.btnEmail.Enabled = IIf(dgPeriodoNomina.Item(0, 2) And dgPeriodoNomina.Item(0, 3) And dgPeriodoNomina.Item(0, 4) And Not dgPeriodoNomina.Item(0, 5) And Me.btnEmail.Enabled = True, True, False)
            'Me.cmdGenFirme.Enabled = IIf(Not dgPeriodoNomina.Item(0, 5) And Me.cmdGenFirme.Enabled = True, True, False)
        Else
            Registro = "Vacio"
        End If
    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnFirmasPlanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim fReportes As New frmReportes()
        ''Dim reporte As New rptFirmasPlanillaXML_Digital
        'Dim reporte As New Object
        'reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        'If Not File.Exists(Application.StartupPath & "\reportes\rptFirmasPlanillaXML_Digital.rpt") Then
        '    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptFirmasPlanillaXML_Digital.rpt")
        '    Exit Sub
        'End If

        'reporte.load(Application.StartupPath & "\reportes\rptFirmasPlanillaXML_Digital.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)



    End Sub

    Private Sub btnXMLINSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub btnConsolidado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'End If

    End Sub


    Private Sub cmdCaldera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked Then
            Me.vPlanillas.Columns("per_codigo").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "")
        Else : Me.vPlanillas.Columns("per_codigo").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, " [per_codigo] like '_" & Now.Year.ToString & "%'")
        End If
        Me.vPlanillas.BestFitColumns()
    End Sub
    Private Sub vPlanillas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vPlanillas.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refrescar()
        End If
    End Sub



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdGenFirme.Click
        If vPlanillas.FocusedRowHandle < 0 Then Exit Sub

        Dim Periodo As New VB.SysContab.PeriodoNominaDetails()


        If Me.vPlanillas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        Else
            Registro = Me.vPlanillas.GetFocusedRowCellValue("per_codigo")
        End If

        Periodo = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        If Periodo.Tipo = "A" Then
            MsgBox("Esta planilla es de Aguinaldo, no puede generarse desde esta opción", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Periodo.MovGen = False And Periodo.Tipo <> "V" And Periodo.Tipo <> "U" Then
            MsgBox("No se han generado los movimientos de esta planilla", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Periodo.Aprobado Then
            MsgBox("Esta planilla ya ha sido aprobada, no puede volver a generarse.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        'Falta agregar la opcion de deshacer planilla para cuando el periodo de nomina ya ha sido revisado, que 
        'solamente lo haga el supervisor o el contador, usando el Rol mas alto para deshacerla.RMPR 13/04/2007
        ShowSplash()
        If Periodo.Procesado = True And Periodo.Aprobado = False Then
            If MsgBox("Esta Nomina Ya fue procesada, Desea Desaplicarla?", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Select Case Periodo.Tipo
                    Case "V"
                        If VB.SysContab.PlanillaDB.Planilla_unDo_Vacaciones(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                            VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, True)
                        End If
                        Me.Refrescar()
                        HideSplash()
                        Exit Sub
                    Case "E"
                        If VB.SysContab.PlanillaDB.Planilla_unDo_Extra(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                            VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, True)
                        End If
                        Me.Refrescar()
                        HideSplash()
                        Exit Sub
                    Case "U"
                        If VB.SysContab.PlanillaDB.Planilla_unDo_Corte(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                            VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, True)
                        End If
                        Me.Refrescar()
                        HideSplash()
                        Exit Sub
                    Case Else
                        If VB.SysContab.PlanillaDB.Planilla_unDo(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                            VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, True)
                        End If
                        Me.Refrescar()
                        HideSplash()
                        Exit Sub
                End Select
            Else
                Exit Sub
            End If
        End If
        Select Case Periodo.Tipo
            Case "V"
                If Not VB.SysContab.PlanillaDB.Planilla_Do_Vacaciones(Registro.Substring(1, 8), Registro.Substring(0, 1), False) Then
                    MsgBox("La planilla no pudo ser generada, revise sus datos por favor", MsgBoxStyle.Critical)
                    HideSplash()
                    Return
                End If
            Case "E"
                If Not VB.SysContab.PlanillaDB.Planilla_Do_Extra(Registro.Substring(1, 8), Registro.Substring(0, 1), False) Then
                    MsgBox("La planilla no pudo ser generada, revise sus datos por favor", MsgBoxStyle.Critical)
                    HideSplash()
                    Return
                End If
            Case "U"
                If Not VB.SysContab.PlanillaDB.Planilla_Do_Corte(Registro.Substring(1, 8), Registro.Substring(0, 1)) Then
                    MsgBox("La planilla no pudo ser generada, revise sus datos por favor", MsgBoxStyle.Critical)
                    HideSplash()
                    Return
                End If
            Case Else
                If Not VB.SysContab.PlanillaDB.Planilla_Do(Registro.Substring(1, 8), Registro.Substring(0, 1), False) Then
                    MsgBox("La planilla no pudo ser generada, revise sus datos por favor", MsgBoxStyle.Critical)
                    HideSplash()
                    Return
                End If
        End Select

        VB.SysContab.PeriodoNominaDB.Procesado(Registro.Substring(1, 8), Registro.Substring(0, 1), Today, False)
        MsgBox("Planilla Generada Satisfactoriamente", MsgBoxStyle.OkOnly)

        Me.Refrescar()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdVisor.Click
        If vPlanillas.FocusedRowHandle < 0 Then Exit Sub

        If Me.vPlanillas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        Else
            Registro = Me.vPlanillas.GetFocusedRowCellValue("per_codigo")
        End If


        frmVerPlanilla.Dispose()
        Dim f As frmVerPlanilla = frmVerPlanilla.Instance

        Nuevo = "SI"
        frmVerPlanilla.Contabilizado = Me.vPlanillas.GetFocusedRowCellValue("per_contabilizado")
        frmVerPlanilla.Revisado = Me.vPlanillas.GetFocusedRowCellValue("per_revisado")
        frmVerPlanilla.Aprobado = Me.vPlanillas.GetFocusedRowCellValue("per_aprobado")
        f.WindowState = FormWindowState.Maximized
        f.ShowDialog()
        Me.Refrescar()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles cmdIRSairi.Click
        Dim ds As New DataTable

        If Microsoft.VisualBasic.Left(Registro, 1) = "A" Then
            MsgBox("Esta planilla es de Aguinaldo, no lleva retención de IR", MsgBoxStyle.Critical)
            Exit Sub
        End If
        ds = VB.SysContab.PlanillaDB.IR_2013(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(Registro, 7), 6))
        Me.GridControl1.DataSource = ds
        Try
            Dim forma As New frmExportarImprimir
            forma.Mostrar(Me.GridControl1)
        Catch Ex As Exception
            MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
            Exit Sub
        Finally

        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        If vPlanillas.FocusedRowHandle < 0 Then Exit Sub

        Dim Empleados As New VB.SysContab.EmpleadosDetails()
        Dim emp As New VB.SysContab.EmpleadosDB()
        Dim Empleado As String, Periodo As String, TPeriodo As String
        Dim ds As New DataSet()

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        Dim lds As New DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)
        lds.WriteXml(Application.StartupPath & "\exportfiles\logoempresa_Ref.xml", XmlWriteMode.WriteSchema)

        lds = Nothing

        If Registro = "Vacio" Then
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Me.txtEnvio.Visible = True
        ds = VB.SysContab.PlanillaDB.GetListPlanilla(Periodo, TPeriodo, "%")
        'Dim crExportOptions As CrystalDecisions.Shared.ExportOptions
        'Dim crDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dim fname As String
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1

            'rColilla = New rptColilla
            Empleado = ds.Tables(0).Rows(i)("emp_codigo")
            Empleados = VB.SysContab.EmpleadosDB.GetDetails(Empleado)

            If Empleados.Email.Trim <> "" And Not (Empleados.Email Is DBNull.Value) Then
                'Me.ImpresionColilla(rColilla, Empleado, Periodo, TPeriodo)

                'fname = Application.StartupPath() & "\exportfiles\" & ds.Tables(0).Rows(i)("pla_tipo") & ds.Tables(0).Rows(i)("pla_codigo") & "_" & EmpresaActual.ToString.PadLeft(2, "0") & "_" & ds.Tables(0).Rows(i)("emp_codigo") & ".pdf"
                'crDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions()
                'crDiskFileDestinationOptions.DiskFileName = fname
                'crExportOptions = rColilla.ExportOptions
                'With crExportOptions
                '.DestinationOptions = crDiskFileDestinationOptions
                '.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                '.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                'End With
                'rColilla.Export()
                Me.txtEnvio.Text = "Enviando Correo al Empleado:" & Empleado
                'Me.Enviar_Mail(Empleados.Email, TPeriodo, Periodo)
                VB.SysContab.Email.Enviar_Mail_Outlook(Empleados.Email, "Planilla " & TPeriodo & Periodo, _
                "Sírvase revisar la colilla de pago. " & vbCrLf & _
                Direccion_WebSite)
                'rColilla = Nothing
            End If

        Next
        MsgBox("Colillas Enviadas", MsgBoxStyle.Information, "SysNomina")
        Me.txtEnvio.Visible = False
        ''''''''''''''''''''''''''''''''
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles cmdVerFichas.Click
        If vPlanillas.FocusedRowHandle < 0 Then Exit Sub

        Dim Empleado As String, Periodo As String, TPeriodo As String

        Periodo = Microsoft.VisualBasic.Right(Registro, 8)
        TPeriodo = Microsoft.VisualBasic.Left(Registro, 1)

        If Registro <> "Vacio" Then
            Empleado = "%"
        Else
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Empleado = ""
            Exit Sub
        End If

        Dim g As frmImp_colillas = frmImp_colillas.Instance

        g.ShowDialog()
        If g.cancel = True Then
            Exit Sub
        End If

        Me.cEmpleado = g.cbEmpleados.SelectedValue
        Me.cDepartamento = g.cbDepartamentos.SelectedValue
        Me.cArea = g.cbAreas.SelectedValue.ToString.Substring(5, 3).Trim
        Me.cOrden = g.rbOrden.EditValue 'IIf(Me.rbAlfabetico.Checked, "A", "C")
        Me.ChkSalario = g.chkSalario.EditValue
        Me.Cancelar = False

        If bColilla = True Then

            Dim Variables As New ArrayList
            Dim Datos As New ArrayList
            Variables.Clear()
            Datos.Clear()
            Variables.Add("Empresa")
            Variables.Add("Periodo")
            Variables.Add("TPeriodo")
            Variables.Add("Empleado")
            Variables.Add("Departamento")
            Variables.Add("Area")
            Variables.Add("Orden")
            Variables.Add("Desde")
            Variables.Add("Hasta")
            Datos.Add(EmpresaActual)
            Datos.Add(Periodo)
            Datos.Add(TPeriodo)
            Datos.Add(Me.cEmpleado)
            Datos.Add(Me.cDepartamento)
            Datos.Add(Me.cArea)
            Datos.Add(Me.cOrden)
            Datos.Add(0)
            Datos.Add(0)

            Dim DT As New DataTable("Encabezado")
            DT = VB.SysContab.FuncionesDB.ProcedureParameters(Datos, Variables, "_Colilla_Encabezado")
            DT.TableName = "Encabezado"
            DT.WriteXml(Application.StartupPath & "\exportfiles\Enc.xml")
            Dim rpt As New Colilla
            rpt.Periodo = Periodo
            rpt.TPeriodo = TPeriodo
            rpt.Departamento = Me.cDepartamento
            rpt.Area = Me.cArea
            rpt.NombreEmpresa.Text = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).Nombre
            rpt.PeriodoNomina.Text = VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FInicio.ToShortDateString & "-" & VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).FFinal.ToShortDateString & "-" & VB.SysContab.PeriodoNominaDB.GetDetails(TPeriodo + Periodo).Descripcion
            rpt.DataSource = DT
            rpt.ShowPreview()
        Else
            Dim fReportes As New frmReportes()
            If MsgBox("Desea imprimir en media pagina las colillas?", MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.Yes Then
                'esta es la de media pagina con el reporte de la colonia
                'Dim rColilla As New rptColilla_MediaPagina
                Dim rColilla As New Object
                rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If Not File.Exists(Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt") Then
                    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt")
                    Exit Sub
                End If

                rColilla.load(Application.StartupPath & "\reportes\rptColilla_MediaPagina.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                ImpresionColilla_MediaPagina(rColilla, Me.cEmpleado, 0, Me.cDepartamento, Me.cArea, Me.cOrden)
                fReportes.crvReportes.ReportSource = rColilla

                'Dim rColilla As New rptColilla_MP
                'ImpresionColilla_Xerox(rColilla, Me.cEmpleado, Me.cDepartamento, Me.cArea, Me.cOrden)
                'fReportes.crvReportes.ReportSource = rColilla

            Else
                'Dim rColilla As New rptColilla()
                Dim rColilla As New Object
                rColilla = New CrystalDecisions.CrystalReports.Engine.ReportDocument

                If Not File.Exists(Application.StartupPath & "\reportes\rptColilla.rpt") Then
                    MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptColilla.rpt")
                    Exit Sub
                End If

                rColilla.load(Application.StartupPath & "\reportes\rptColilla.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                ImpresionColilla(rColilla, Me.cEmpleado, Me.cDepartamento, Me.cArea, Me.cOrden)
                fReportes.crvReportes.ReportSource = rColilla

            End If
            fReportes.ShowDialog()
        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles btnBAC.Click
        If vPlanillas.FocusedRowHandle < 0 Then Exit Sub

        Dim f As frmGenPagoNominaElectronica = frmGenPagoNominaElectronica.Instance

        f.Text = "Generar Archivo de Pago"
        f.Periodo = Registro.Substring(1, 8)
        f.TPeriodo = Registro.Substring(0, 1)
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles btnFirmasPlanilla.Click
        If vPlanillas.FocusedRowHandle < 0 Then Exit Sub

        Dim digital As Boolean

        Dim g As frmImp_colillas = frmImp_colillas.Instance

        g.ShowDialog()
        If Me.Cancelar = True Then
            Exit Sub
        End If


        digital = True

        If Registro = "Vacio" Then
            MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim EmpresaReferencia As Integer
        EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).EmpresaReferencia

        Dim lds, ds As DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)


        Me.cEmpleado = g.cbEmpleados.SelectedValue
        Me.cDepartamento = g.cbDepartamentos.SelectedValue
        Me.cArea = g.cbAreas.SelectedValue.ToString.Substring(5, 3).Trim
        Me.cOrden = g.rbOrden.EditValue
        Me.ChkSalario = g.chkSalario.Checked



        lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)
        ds = VB.SysContab.PlanillaDB.FirmasPlanilla(Registro.Substring(1, 8), Registro.Substring(0, 1), _
            True, Me.cEmpleado, Me.cLocalidad, Me.cDepartamento, Me.cArea, Me.cOrden, Me.ChkSalario)
        ds.WriteXml(Application.StartupPath & "\Firmas.xml", XmlWriteMode.WriteSchema)

        Dim r As New FirmasPlanilla

        r.txtEmpresa.Text = lds.Tables(0).Rows(0)("nombre")
        r.txtPlanilla.Text = VB.SysContab.PeriodoNominaDB.GetDetails(Registro).Descripcion
        r.txtSalario.Visible = Me.ChkSalario
        r.lblSalario.Visible = Me.ChkSalario
        r.DataSource = ds.Tables(0)
        r.ShowPreviewDialog()
        'reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\logoempresa.xml"
        'reporte.Database.Tables("_GetListFirmasPlanilla").Location = Application.StartupPath & "\Firmas.xml"

        'fReportes.crvReportes.ReportSource = reporte
        'fReportes.ShowDialog()

        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)
        lds = Nothing
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles btnXMLINSS.Click
        If vPlanillas.FocusedRowHandle < 0 Then Exit Sub


        Me.FBD.SelectedPath = Application.StartupPath() & "\exportfiles\"
        If Me.FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                VB.SysContab.RutinasNomina.INSSXML(Registro.Substring(1, 6), Me.FBD.SelectedPath)
            Catch Ex As Exception
                MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                Exit Sub
            Finally
            End Try
        End If

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles btnConsolidado.Click
        If Me.vPlanillas.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.vPlanillas.GetFocusedRowCellValue("per_codigo")
        End If

        Dim f As frmRptPlanillaConsolidado = frmRptPlanillaConsolidado.Instance
        Nuevo = "SI"
        f.ShowDialog()
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles cmdCaldera.Click
        Dim f As frmRptPlanillaConsolidado_New = frmRptPlanillaConsolidado_New.Instance
        Nuevo = "SI"
        f.ShowDialog()
    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        frmExportarImprimir.Mostrar(dgPeriodoNomina, "Listado de Planillas")
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        Close()
    End Sub
End Class