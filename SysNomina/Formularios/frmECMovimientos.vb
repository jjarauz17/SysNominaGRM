Imports System.IO
Public Class frmECMovimientos

    Private Sub frmECMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbTmovimientos.Properties.DataSource = RH_Reportes._RH_GetListRubros()
        Me.cbTmovimientos.Properties.DisplayMember = "Descripcion"
        Me.cbTmovimientos.Properties.ValueMember = "Codigo"

        Me.cbPlanillas.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList(False)
        Me.cbPlanillas.Properties.DisplayMember = "per_descripcion"
        Me.cbPlanillas.Properties.ValueMember = "per_codigo"

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Me.GridControl1.DataSource = RH_Reportes._RH_DetalleRubros(Me.cbPlanillas.EditValue, Me.cbTmovimientos.EditValue)
        If Not Me.GridControl1.DataSource Is Nothing Then
            Me.vLista.Columns("Filtro").Visible = False
            Me.vLista.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vLista.Columns("Monto").DisplayFormat.FormatString = "n2"
            Me.vLista.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vLista.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"


        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If Not Me.GridControl1.DataSource Is Nothing Then
            Me.GridControl1.DataSource.writexml(Application.StartupPath & "\d.xml", XmlWriteMode.WriteSchema)
            Dim f As New frmReportes
            'Dim reporte As New rptECMovimientos
            Dim Reporte As New Object
            Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

            If Not File.Exists(Application.StartupPath & "\reportes\rptECMovimientos.rpt") Then
                MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptECMovimientos.rpt")
                Exit Sub
            End If

            Reporte.load(Application.StartupPath & "\reportes\rptECMovimientos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"
            Reporte.Database.Tables("Detalle").Location = Application.StartupPath & "\d.xml"

            f.crvReportes.ReportSource = Reporte
            f.ShowDialog()

        End If
    End Sub
End Class