Imports DbConnect
Imports System.IO


Public Class frmECDeduccion
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmECDeduccion = Nothing

    Public Shared Function Instance() As frmECDeduccion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmECDeduccion()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Private Sub frmECDeduccion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbEmpleados.Properties.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables(0)
        Me.cbEmpleados.Properties.DisplayMember = "Nombre"
        Me.cbEmpleados.Properties.ValueMember = "Codigo"

        Me.cbTDeduccion.Properties.DataSource = VB.SysContab.TipoDeduccionDB.GetList("%")
        Me.cbTDeduccion.Properties.DisplayMember = "Descripcion"
        Me.cbTDeduccion.Properties.ValueMember = "Codigo"

        Me.cbPeriodo.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList(False)
        Me.cbPeriodo.Properties.ValueMember = "per_codigo"
        Me.cbPeriodo.Properties.DisplayMember = "per_descripcion"

        Me.dtpHasta.EditValue = Now.Date

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim visor As New frmReportes
        'Dim Reporte As New rptECDeducciones
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptECDeducciones.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECDeducciones.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptECDeducciones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim lds As New DataSet
        lds = VB.SysContab.DeduccionDB.GetEstadoCuenta_Encabezado(IIf(Me.cbEmpleados.EditValue Is DBNull.Value Or Me.cbEmpleados.EditValue Is Nothing, "%", Me.cbEmpleados.EditValue), _
            IIf(Me.cbTDeduccion.EditValue Is DBNull.Value Or Me.cbTDeduccion.EditValue Is Nothing, "%", Me.cbTDeduccion.EditValue))
        lds.WriteXml(Application.StartupPath & "\exportfiles\ECD_Enc.xml", XmlWriteMode.WriteSchema)
        lds.Clear()
        lds = VB.SysContab.DeduccionDB.GetEstadoCuenta_Detalle(IIf(Me.cbEmpleados.EditValue Is DBNull.Value Or Me.cbEmpleados.EditValue Is Nothing, "%", Me.cbEmpleados.EditValue), _
            IIf(Me.cbTDeduccion.EditValue Is DBNull.Value Or Me.cbTDeduccion.EditValue Is Nothing, "%", Me.cbTDeduccion.EditValue))
        lds.WriteXml(Application.StartupPath & "\exportfiles\ECD_Det.xml", XmlWriteMode.WriteSchema)


        Reporte.Database.Tables("_Deduccion_EstadoCuenta_Det;1").Location = Application.StartupPath & "\exportfiles\ECD_Det.xml"
        Reporte.Database.Tables("_Deduccion_EstadoCuenta_Enc;1").Location = Application.StartupPath & "\exportfiles\ECD_Enc.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        visor.crvReportes.ReportSource = Reporte
        visor.ShowDialog()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdImprimirRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirRes.Click
        Dim visor As New frmReportes
        'Dim Reporte As New rptECDeducciones_Resumen
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptECDeducciones_Resumen.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECDeducciones_Resumen.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptECDeducciones_Resumen.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim lds As New DataSet
        lds = VB.SysContab.DeduccionDB.GetEstadoCuenta_Resumen(IIf(Me.cbEmpleados.EditValue Is DBNull.Value Or Me.cbEmpleados.EditValue Is Nothing, "%", Me.cbEmpleados.EditValue), _
            IIf(Me.cbTDeduccion.EditValue Is DBNull.Value Or Me.cbTDeduccion.EditValue Is Nothing, "%", Me.cbTDeduccion.EditValue), _
            IIf(Me.cbPeriodo.EditValue Is DBNull.Value Or Me.cbPeriodo.EditValue Is Nothing, "%", Me.cbPeriodo.EditValue))
        lds.WriteXml(Application.StartupPath & "\exportfiles\ECD_Res.xml", XmlWriteMode.WriteSchema)

        Reporte.Database.Tables("ECD_Res").Location = Application.StartupPath & "\exportfiles\ECD_Res.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        visor.crvReportes.ReportSource = Reporte
        visor.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim visor As New frmReportes
        'Dim Reporte As New rptECDeducciones_ResumenxEmpleado
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptECDeducciones_ResumenxEmpleado.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECDeducciones_ResumenxEmpleado.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptECDeducciones_ResumenxEmpleado.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim lds As New DataSet
        lds = VB.SysContab.DeduccionDB.GetEstadoCuenta_Encabezado(IIf(Me.cbEmpleados.EditValue Is DBNull.Value Or Me.cbEmpleados.EditValue Is Nothing, "%", Me.cbEmpleados.EditValue), _
            IIf(Me.cbTDeduccion.EditValue Is DBNull.Value Or Me.cbTDeduccion.EditValue Is Nothing, "%", Me.cbTDeduccion.EditValue))
        lds.WriteXml(Application.StartupPath & "\exportfiles\ECD_Enc.xml", XmlWriteMode.WriteSchema)
        lds.Clear()
        lds = VB.SysContab.DeduccionDB.GetEstadoCuenta_Detalle(IIf(Me.cbEmpleados.EditValue Is DBNull.Value Or Me.cbEmpleados.EditValue Is Nothing, "%", Me.cbEmpleados.EditValue), _
            IIf(Me.cbTDeduccion.EditValue Is DBNull.Value Or Me.cbTDeduccion.EditValue Is Nothing, "%", Me.cbTDeduccion.EditValue))
        lds.WriteXml(Application.StartupPath & "\exportfiles\ECD_Det.xml", XmlWriteMode.WriteSchema)


        Reporte.Database.Tables("_Deduccion_EstadoCuenta_Det;1").Location = Application.StartupPath & "\exportfiles\ECD_Det.xml"
        Reporte.Database.Tables("_Deduccion_EstadoCuenta_Enc;1").Location = Application.StartupPath & "\exportfiles\ECD_Enc.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

        visor.crvReportes.ReportSource = Reporte
        visor.ShowDialog()
    End Sub

    Private Sub cmdalafecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdalafecha.Click
        Dim visor As New frmReportes
        'Dim Reporte As New rptECDeducciones_Al
        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptECDeducciones_Al.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECDeducciones_Al.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptECDeducciones_Al.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)



        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, IIf(Me.cbEmpleados.EditValue Is DBNull.Value Or Me.cbEmpleados.EditValue Is Nothing, "%", Me.cbEmpleados.EditValue))
        v.AddParameter("Deduccion", SqlDbType.NVarChar, 3, ParameterDirection.Input, IIf(Me.cbTDeduccion.EditValue Is DBNull.Value Or Me.cbTDeduccion.EditValue Is Nothing, "%", Me.cbTDeduccion.EditValue))
        v.AddParameter("Hasta", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Me.dtpHasta.DateTime.Date)

        Try
            v.EjecutarComando("_EC_Deduccion_All", "ECR").WriteXml(Application.StartupPath & "\ECR.xml", XmlWriteMode.WriteSchema)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        v = Nothing

        Reporte.Database.Tables(0).Location = Application.StartupPath & "\ECR.xml"
        visor.crvReportes.ReportSource = Reporte
        visor.ShowDialog()

    End Sub

    Private Sub cmdRubros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRubros.Click
        frmECMovimientos.Dispose()
        frmECMovimientos.ShowDialog()
    End Sub
End Class