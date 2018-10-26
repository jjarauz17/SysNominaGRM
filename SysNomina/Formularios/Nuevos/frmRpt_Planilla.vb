Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class frmRpt_Planilla
#Region "Variables"
    Public Reporte As Integer = 1
#End Region

#Region "Variables2"
    Public cEmpleado, cDepartamento, cArea, cOrden As String
    Public cLocalidad As Integer = 0
    Public ChkSalario As Boolean = True
    Public Cancelar As Boolean
#End Region

    Private Sub frmRpt_Planilla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.dgreportes.DataSource = Reportes_Light.ListaReportes()
        Me.vLista.PopulateColumns()
        Me.vLista.Columns("reporte").Visible = False
        Me.vLista.BestFitColumns()

        Me.cbPlanillas.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList(False)
        Me.cbPlanillas.Properties.DisplayMember = "per_descripcion"
        Me.cbPlanillas.Properties.ValueMember = "per_codigo"

        Me.cbTDeduccion.Properties.DataSource = VB.SysContab.TipoDeduccionDB.GetList("%")
        Me.cbTDeduccion.Properties.DisplayMember = "Descripcion"
        Me.cbTDeduccion.Properties.ValueMember = "Codigo"

        Me.cbTIngreso.Properties.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables(0)
        Me.cbTIngreso.Properties.DisplayMember = "Descripcion"
        Me.cbTIngreso.Properties.ValueMember = "Codigo"

        cbLocalidad.Properties.DataSource = VB.SysContab.LocalidadDB.Lista(0, False)
        cbLocalidad.Properties.ValueMember = "Codigo"
        cbLocalidad.Properties.DisplayMember = "Descripcion"


        Me.cbPlanillas.EditValue = VB.SysContab.PeriodoNominaDB.PeriodoNomina_UltimaProcesada()
        Dim dp As New VB.SysContab.PeriodoNominaDetails
        dp = VB.SysContab.PeriodoNominaDB.GetDetails(Me.cbPlanillas.EditValue)

        Me.dtfecha.EditValue = dp.FFinal
        Me.lci_fecha.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Me.lci_planilla.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always


        'If Me.Reporte = 100 Then
        '    Me.SimpleButton1.Text = "Exportar"
        'End If
        'If Me.Reporte <> 101 And Me.Reporte <> 102 Then
        '    Me.LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'End If
        'If Me.Reporte = 101 Or Me.Reporte = 102 Then
        '    Me.LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If vLista.DataRowCount = 0 Then
            Exit Sub
        End If
        Select Case Me.vLista.GetFocusedRowCellValue("id")
            Case 5
                Try

                    If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_PlanillaBorrador.rpt") Then
                        MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_PlanillaBorrador.rpt")
                        Exit Sub
                    End If
                    Dim reporte As New Object
                    reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    reporte.Load(Application.StartupPath & "\REPORTES\rpt_PlanillaBorrador.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                    Dim fReportes As New frmReportes()

                    If Me.cbPlanillas.EditValue Is Nothing Then
                        MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If


                    Dim dt As New DataTable
                    dt = Reportes_Light.Planilla(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                                                 Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                    dt.WriteXml(Application.StartupPath & "\PBorrador.xml", XmlWriteMode.WriteSchema)
                    dt = Nothing

                    reporte.Database.Tables("Planilla_Borrador").Location = Application.StartupPath & "\PBorrador.xml"

                    reporte.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                    reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

                    fReportes.crvReportes.ReportSource = reporte

                    fReportes.ShowDialog()
                Catch ex As Exception

                End Try

            Case 6
                Try
                    If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_PlanillaAlfabetico.rpt") Then
                        MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_PlanillaAlfabetico.rpt")
                        Exit Sub
                    End If
                    Dim reporte As New Object
                    reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    reporte.Load(Application.StartupPath & "\REPORTES\rpt_PlanillaAlfabetico.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                    Dim fReportes As New frmReportes()

                    If Me.cbPlanillas.EditValue Is Nothing Then
                        MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If


                    Dim dt As New DataTable
                    dt = Reportes_Light.PlanillaNumerico(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                                                 Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                    dt.WriteXml(Application.StartupPath & "\PNumerico.xml", XmlWriteMode.WriteSchema)
                    dt = Nothing
                    dt = VB.SysContab.LocalidadDB.Lista(0, True)
                    dt.WriteXml(Application.StartupPath & "\Localidad.xml", XmlWriteMode.WriteSchema)
                    dt = Nothing


                    reporte.Database.Tables("Localidad").Location = Application.StartupPath & "\Localidad.xml"
                    reporte.Database.Tables("Planilla_Numerico").Location = Application.StartupPath & "\PNumerico.xml"

                    reporte.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                    reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

                    fReportes.crvReportes.ReportSource = reporte
                    fReportes.ShowDialog()
                Catch ex As Exception

                End Try
            Case 7
                Try
                    If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_PlanillaNumerico.rpt") Then
                        MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_PlanillaNumerico.rpt")
                        Exit Sub
                    End If
                    Dim reporte As New Object
                    reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    reporte.Load(Application.StartupPath & "\REPORTES\rpt_PlanillaNumerico.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                    Dim fReportes As New frmReportes()

                    If Me.cbPlanillas.EditValue Is Nothing Then
                        MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If


                    Dim dt As New DataTable
                    dt = Reportes_Light.PlanillaNumerico(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                                                 Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                    dt.WriteXml(Application.StartupPath & "\PNumerico.xml", XmlWriteMode.WriteSchema)
                    dt = Nothing
                    dt = VB.SysContab.LocalidadDB.Lista(0, True)
                    dt.WriteXml(Application.StartupPath & "\Localidad.xml", XmlWriteMode.WriteSchema)
                    dt = Nothing


                    reporte.Database.Tables("Localidad").Location = Application.StartupPath & "\Localidad.xml"
                    reporte.Database.Tables("Planilla_Numerico").Location = Application.StartupPath & "\PNumerico.xml"

                    reporte.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                    reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

                    fReportes.crvReportes.ReportSource = reporte
                    fReportes.ShowDialog()
                Catch ex As Exception

                End Try
            Case 8
                Try
                    Dim digital As Boolean
                    Dim g As frmImp_colillas = frmImp_colillas.Instance
                    g.ShowDialog()

                    If Cancelar = True Then
                        Exit Sub
                    End If


                    digital = True

                    If Me.cbPlanillas.EditValue Is Nothing Then
                        MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If
                    If Me.cbPlanillas.EditValue Is DBNull.Value Then
                        MsgBox("No se ha seleccionado la Planilla a Imprimir", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If

                    Dim EmpresaReferencia As Integer
                    EmpresaReferencia = VB.SysContab.PeriodoNominaDB.GetDetails(Me.cbPlanillas.EditValue).EmpresaReferencia

                    Dim lds, ds As DataSet
                    lds = VB.SysContab.EmpresasDB.GetLogoEmpresa(EmpresaReferencia)


                    Me.cEmpleado = g.cbEmpleados.SelectedValue
                    Me.cDepartamento = g.cbDepartamentos.SelectedValue
                    Me.cArea = g.cbAreas.SelectedValue.ToString.Substring(5, 3).Trim
                    Me.cOrden = g.rbOrden.EditValue
                    Me.ChkSalario = g.chkSalario.Checked


                    lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)
                    ds = VB.SysContab.PlanillaDB.FirmasPlanilla(Me.cbPlanillas.EditValue.Substring(1, 8), Me.cbPlanillas.EditValue.Substring(0, 1), _
                        True, Me.cEmpleado, Me.cLocalidad, Me.cDepartamento, Me.cArea, Me.cOrden, Me.ChkSalario)
                    ds.WriteXml(Application.StartupPath & "\Firmas.xml", XmlWriteMode.WriteSchema)

                    Dim r As New FirmasPlanilla

                    r.txtEmpresa.Text = lds.Tables(0).Rows(0)("nombre")
                    r.txtPlanilla.Text = VB.SysContab.PeriodoNominaDB.GetDetails(Me.cbPlanillas.EditValue).Descripcion
                    r.txtSalario.Visible = Me.ChkSalario
                    r.lblSalario.Visible = Me.ChkSalario
                    r.DataSource = ds.Tables(0)
                    r.ShowPreviewDialog()
                    lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
                    lds.WriteXml(Application.StartupPath & "\logoempresa.xml", XmlWriteMode.WriteSchema)
                    lds = Nothing
                Catch ex As Exception

                End Try

            Case 9

                Try
                    If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_consolidadonomina.rpt") Then
                        MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_consolidadonomina.rpt")
                        Exit Sub
                    End If
                    Dim reporte As New Object
                    reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    reporte.Load(Application.StartupPath & "\REPORTES\rpt_consolidadonomina.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                    Dim fReportes As New frmReportes()


                    Dim dt As New DataTable
                    dt = Reportes_Light.ConsolidadoPlanilla(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                    dt.WriteXml(Application.StartupPath & "\CP.xml", XmlWriteMode.WriteSchema)


                    reporte.Database.Tables("Consolidado_Planilla").Location = Application.StartupPath & "\CP.xml"

                    fReportes.crvReportes.ReportSource = reporte
                    fReportes.ShowDialog()
                    fReportes.Dispose()
                    fReportes = Nothing

                Catch ex As Exception

                End Try
            Case 10
                frmImp_ColillasPago.Dispose()
                frmImp_ColillasPago.Planilla = Me.cbPlanillas.EditValue
                frmImp_ColillasPago.ShowDialog()
            Case 11
                Try
                    If Not File.Exists(Application.StartupPath & "\REPORTES\rptIRMes.rpt") Then
                        MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rptIRMes.rpt")
                        Exit Sub
                    End If
                    Dim reporte As New Object
                    reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    reporte.Load(Application.StartupPath & "\REPORTES\rptIRMes.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                    Dim fReportes As New frmReportes()


                    Dim dt As New DataTable
                    dt = Reportes_Light.IRMes(Me.dtfecha.EditValue)

                    dt.WriteXml(Application.StartupPath & "\IRmes.xml", XmlWriteMode.WriteSchema)

                    reporte.Database.Tables("IRMes").Location = Application.StartupPath & "\IRmes.xml"

                    fReportes.crvReportes.ReportSource = reporte
                    fReportes.ShowDialog()
                    fReportes.Dispose()
                    fReportes = Nothing
                Catch ex As Exception

                End Try

            Case 12
                Try
                    If Not File.Exists(Application.StartupPath & "\REPORTES\rptINSSMes.rpt") Then
                        MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rptINSSMes.rpt")
                        Exit Sub
                    End If
                    Dim reporte As New Object
                    reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    reporte.Load(Application.StartupPath & "\REPORTES\rptINSSMes.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                    Dim fReportes As New frmReportes()


                    Dim dt As New DataTable
                    dt = Reportes_Light.INSSMes(Me.dtfecha.EditValue)

                    dt.WriteXml(Application.StartupPath & "\Inssmes.xml", XmlWriteMode.WriteSchema)

                    reporte.Database.Tables("InssMes").Location = Application.StartupPath & "\Inssmes.xml"

                    fReportes.crvReportes.ReportSource = reporte
                    fReportes.ShowDialog()
                    fReportes.Dispose()
                    fReportes = Nothing
                Catch ex As Exception

                End Try


            Case 13
                If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_dedembargo.rpt") Then
                    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_dedembargo.rpt")
                    Exit Sub
                End If
                Dim reporte As New Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                reporte.Load(Application.StartupPath & "\REPORTES\rpt_dedembargo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                Dim fReportes As New frmReportes()

                Dim dt As New DataTable
                dt = Reportes_Light.DedEmbargo(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                dt.WriteXml(Application.StartupPath & "\de.xml", XmlWriteMode.WriteSchema)

                reporte.Database.Tables("DEDEMBARGO").Location = Application.StartupPath & "\de.xml"

                fReportes.crvReportes.ReportSource = reporte
                fReportes.ShowDialog()
                fReportes.Dispose()
                fReportes = Nothing

                'Case 10
                'If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_dedembargo_credicompras.rpt") Then
                '    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_dedembargo_credicompras.rpt")
                '    Exit Sub
                'End If
                'Dim reporte As New Object
                'reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                'reporte.Load(Application.StartupPath & "\REPORTES\rpt_dedembargo_credicompras.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                'Dim fReportes As New frmReportes()

                'Dim dt As New DataTable
                'dt = Reportes_Light.DedCREDICOMPRAS(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                '            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                'dt.WriteXml(Application.StartupPath & "\Credicompras.xml", XmlWriteMode.WriteSchema)

                'reporte.Database.Tables("CREDICOMPRAS").Location = Application.StartupPath & "\Credicompras.xml"

                'fReportes.crvReportes.ReportSource = reporte
                'fReportes.ShowDialog()
                'fReportes.Dispose()
                'fReportes = Nothing

                'Case 11
                'If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_dedembargo_JUDICIAL.rpt") Then
                '    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_dedembargo_JUDICIAL.rpt")
                '    Exit Sub
                'End If
                'Dim reporte As New Object
                'reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                'reporte.Load(Application.StartupPath & "\REPORTES\rpt_dedembargo_JUDICIAL.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                'Dim fReportes As New frmReportes()

                'Dim dt As New DataTable
                'dt = Reportes_Light.DedJUDICIAL(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                '            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                'dt.WriteXml(Application.StartupPath & "\JUDICIAL.xml", XmlWriteMode.WriteSchema)

                'reporte.Database.Tables("JUDICIAL").Location = Application.StartupPath & "\JUDICIAL.xml"

                'fReportes.crvReportes.ReportSource = reporte
                'fReportes.ShowDialog()
                'fReportes.Dispose()
                'fReportes = Nothing

            Case 16
                If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_DEGLOSE.rpt") Then
                    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_DEGLOSE.rpt")
                    Exit Sub
                End If
                Dim reporte As New Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                reporte.Load(Application.StartupPath & "\REPORTES\rpt_DEGLOSE.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                Dim fReportes As New frmReportes()

                Dim dt As New DataTable
                dt = Reportes_Light.DEGLOSE(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                dt.WriteXml(Application.StartupPath & "\DEGLOSE.xml", XmlWriteMode.WriteSchema)

                reporte.Database.Tables("DEGLOSE").Location = Application.StartupPath & "\DEGLOSE.xml"

                fReportes.crvReportes.ReportSource = reporte
                fReportes.ShowDialog()
                fReportes.Dispose()
                fReportes = Nothing

            Case 17
                If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_empleadosTdebito.rpt") Then
                    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_empleadosTdebito.rpt")
                    Exit Sub
                End If
                Dim reporte As New Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                reporte.Load(Application.StartupPath & "\REPORTES\rpt_empleadosTdebito.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                Dim fReportes As New frmReportes()

                Dim dt As New DataTable
                dt = Reportes_Light.tdebitos(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                dt.WriteXml(Application.StartupPath & "\TDEBITOS.xml", XmlWriteMode.WriteSchema)

                reporte.Database.Tables("TDEBITOS").Location = Application.StartupPath & "\TDEBITOS.xml"

                fReportes.crvReportes.ReportSource = reporte
                fReportes.ShowDialog()
                fReportes.Dispose()
                fReportes = Nothing

            Case 3
                If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_dedUCCIONES.rpt") Then
                    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_dedUCCIONES.rpt")
                    Exit Sub
                End If
                Dim reporte As New Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                reporte.Load(Application.StartupPath & "\REPORTES\rpt_dedUCCIONES.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                Dim fReportes As New frmReportes()

                Dim dt As New DataTable
                Dim tde_codigo As String = ""

                If Me.cbTDeduccion.EditValue Is Nothing Then
                    tde_codigo = "%"
                ElseIf Me.cbTDeduccion.EditValue Is DBNull.Value Then
                    tde_codigo = "%"
                Else
                    tde_codigo = Me.cbTDeduccion.EditValue
                End If

                dt = Reportes_Light.Deducciones(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                            Me.cbPlanillas.EditValue.ToString.Substring(0, 1), _
                            tde_codigo, Me.chkAgrupar.EditValue, Me.cbLocalidad.EditValue)

                If dt.Rows.Count = 0 Then
                    MsgBox("No se han recuperado registros que cumplan su criterio")
                    Exit Sub
                End If
                dt.WriteXml(Application.StartupPath & "\de.xml", XmlWriteMode.WriteSchema)

                reporte.Database.Tables("DEDUCCIONES").Location = Application.StartupPath & "\de.xml"

                fReportes.crvReportes.ReportSource = reporte
                fReportes.ShowDialog()
                fReportes.Dispose()
                fReportes = Nothing

            Case 4
                If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_INGRESOS.rpt") Then
                    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_INGRESOS.rpt")
                    Exit Sub
                End If
                Dim reporte As New Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                reporte.Load(Application.StartupPath & "\REPORTES\rpt_INGRESOS.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                Dim fReportes As New frmReportes()

                Dim dt As New DataTable
                Dim tdi_codigo As String = ""

                If Me.cbTIngreso.EditValue Is Nothing Then
                    tdi_codigo = "%"
                ElseIf Me.cbTIngreso.EditValue Is DBNull.Value Then
                    tdi_codigo = "%"
                Else
                    tdi_codigo = Me.cbTIngreso.EditValue
                End If

                dt = Reportes_Light.Ingresos(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                            Me.cbPlanillas.EditValue.ToString.Substring(0, 1), _
                            tdi_codigo, Me.chkAgrupar.EditValue, Me.cbLocalidad.EditValue)

                If dt.Rows.Count = 0 Then
                    MsgBox("No se han recuperado registros que cumplan su criterio")
                    Exit Sub
                End If
                dt.WriteXml(Application.StartupPath & "\dI.xml", XmlWriteMode.WriteSchema)

                reporte.Database.Tables("INGRESOS").Location = Application.StartupPath & "\di.xml"

                fReportes.crvReportes.ReportSource = reporte
                fReportes.ShowDialog()
                fReportes.Dispose()
                fReportes = Nothing

            Case 20
                If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_COLILLASINSS.rpt") Then
                    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_COLILLASINSS.rpt")
                    Exit Sub
                End If
                Dim reporte As New Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                reporte.Load(Application.StartupPath & "\REPORTES\rpt_COLILLASINSS.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                Dim fReportes As New frmReportes()

                Dim dt As New DataTable

                dt = Reportes_Light.COLILLAS_INSS(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                dt.WriteXml(Application.StartupPath & "\CI.xml", XmlWriteMode.WriteSchema)

                reporte.Database.Tables("COLILLAS_INSS").Location = Application.StartupPath & "\CI.xml"

                fReportes.crvReportes.ReportSource = reporte
                fReportes.ShowDialog()
                fReportes.Dispose()
                fReportes = Nothing

            Case 21
                'If Not File.Exists(Application.StartupPath & "\REPORTES\rptplanilla.rpt") Then
                '    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rptplanilla.rpt")
                '    Exit Sub
                'End If
                'Dim reporte As New Object
                'reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                'reporte.Load(Application.StartupPath & "\REPORTES\rptplanilla.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                'Dim fReportes As New frmReportes()

                'Dim dt As New DataTable

                'dt = Reportes_Light.PLANILLA_ENCABEZADO(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                '            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                'dt.WriteXml(Application.StartupPath & "\PE.xml", XmlWriteMode.WriteSchema)
                'dt = Nothing
                'dt = Reportes_Light.PLANILLA_DETALLE(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                '            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                'dt.WriteXml(Application.StartupPath & "\PD.xml", XmlWriteMode.WriteSchema)

                'reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"
                'reporte.Database.Tables("PLANILLA_ENCABEZADO").Location = Application.StartupPath & "\PE.xml"
                'reporte.Database.Tables("PLANILLA_DETALLE").Location = Application.StartupPath & "\PD.xml"

                'fReportes.crvReportes.ReportSource = reporte
                'fReportes.ShowDialog()
                'fReportes.Dispose()
                'fReportes = Nothing

                'Case 18 'ARCHIVO DE INDEMNIZACION
                '    Dim dt As New DataTable

                '    dt = VB.SysContab.RutinasNomina._RH_Indemnizacion(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                '                Me.cbPlanillas.EditValue.ToString.Substring(0, 1))
                '    Me.SFD.InitialDirectory = Application.StartupPath()
                '    Me.SFD.Filter = "DBF Files (*.dbf)|*.dbf"
                '    Me.SFD.FilterIndex = 1
                '    Me.SFD.RestoreDirectory = True
                '    Me.SFD.FileName = Application.StartupPath() & "\exportfiles\Indemnic" & ".dbf"
                '    If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                '        Dim directorio = "", nombrearchivo As String

                '        For i As Integer = Me.SFD.FileName.Length - 1 To 0 Step -1
                '            If Me.SFD.FileName(i) = "\" Then
                '                directorio = Me.SFD.FileName.Substring(0, i + 1)

                '                Exit For
                '            End If
                '        Next
                '        nombrearchivo = Me.SFD.FileName.Substring(directorio.Length, Me.SFD.FileName.Length - directorio.Length)

                '        Try
                '            VB.SysContab.RutinasNomina.Exportar_DBF_Indemnizacion(directorio, _
                '                nombrearchivo, dt)
                '        Catch Ex As Exception
                '            MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                '            Exit Sub
                '        Finally

                '        End Try
                '    End If
            Case 23 ' ARCHIVO ELECTRONICO DEL BAC
                frmGenPagoElectronico.Dispose()
                frmGenPagoElectronico.Periodo = Me.cbPlanillas.EditValue.ToString.Substring(1, 8)
                frmGenPagoElectronico.TPeriodo = Me.cbPlanillas.EditValue.ToString.Substring(0, 1)
                frmGenPagoElectronico.ShowDialog()
            Case 24 ' ARCHIVO XML INSS
                Me.FBD.SelectedPath = Application.StartupPath() & "\exportfiles\"

                If Me.FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Try
                        VB.SysContab.RutinasNomina.INSSXML(Me.cbPlanillas.EditValue.ToString.Substring(1, 6), Me.FBD.SelectedPath)
                    Catch Ex As Exception
                        MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                        Exit Sub
                    Finally

                    End Try
                End If
            Case 25 ' ARCHIVO TXT SAIRI

                Dim ds As New DataSet()

                If Me.cbPlanillas.EditValue.ToString.Substring(0, 1) = "A" Then
                    MsgBox("Esta planilla es de Aguinaldo, no lleva retención de IR", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                ds = VB.SysContab.PlanillaDB.IRSairi(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                        Me.cbPlanillas.EditValue.ToString.Substring(0, 1))
                Me.SFD.InitialDirectory = Application.StartupPath()

                Me.SFD.Filter = "Text Files (*.txt)|*.txt"
                Me.SFD.FilterIndex = 1
                Me.SFD.RestoreDirectory = True
                Me.SFD.FileName = Application.StartupPath() & "\exportfiles\" & Me.cbPlanillas.EditValue.ToString & ".txt"
                If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Try
                        If VB.SysContab.RutinasNomina.ExportarTXT_sairi(ds.Tables("Ir"), Me.SFD.FileName, Longitud_Linea_Archivos.SAIRI) Then
                            MsgBox("Archivo generado satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        Else
                            MsgBox("El archivo no pudo ser generado. Consulte con al Administrador del Sistema", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        End If
                    Catch Ex As Exception
                        MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                        Exit Sub
                    Finally

                    End Try
                End If

            Case 26 'comprobante de diario
                Dim f As New frmComprobante
                f.cbPlanillas.EditValue = Me.cbPlanillas.EditValue
                f.ShowDialog()

            Case 27 'Reporte de Bajas de Empleados por mes
                If Not File.Exists(Application.StartupPath & "\REPORTES\rpt_BAJAS.rpt") Then
                    MsgBox("No se encuentra el reporte: " & Application.StartupPath & "\REPORTES\rpt_BAJAS.rpt")
                    Exit Sub
                End If
                Dim reporte As New Object
                reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                reporte.Load(Application.StartupPath & "\REPORTES\rpt_BAJAS.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                Dim fReportes As New frmReportes()

                Dim dt As New DataTable

                dt = Reportes_Light.BAJAS(Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
                            Me.cbPlanillas.EditValue.ToString.Substring(0, 1))

                dt.WriteXml(Application.StartupPath & "\BAJAS.xml", XmlWriteMode.WriteSchema)

                reporte.Database.Tables("BAJAS").Location = Application.StartupPath & "\BAJAS.xml"

                fReportes.crvReportes.ReportSource = reporte
                fReportes.ShowDialog()
                fReportes.Dispose()
                fReportes = Nothing

        End Select

    End Sub

    Private Sub vLista_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vLista.FocusedRowChanged
        Me.lci_fecha.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Me.lci_planilla.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Me.lci_tdeduccion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Me.lci_tingreso.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Me.lci_agrupar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Me.lci_localidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Me.SimpleButton1.Text = "Imprimir"

        Select Case Me.vLista.GetFocusedRowCellValue("id")
            Case 23, 24, 25, 26
                Me.SimpleButton1.Text = "Exportar"
            Case 11, 12
                Me.lci_fecha.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.lci_planilla.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Case 3
                Me.lci_fecha.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Me.lci_planilla.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.lci_tdeduccion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.lci_tingreso.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Me.lci_agrupar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.lci_localidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Case 4
                Me.lci_fecha.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Me.lci_planilla.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.lci_tdeduccion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Me.lci_tingreso.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.lci_agrupar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Me.lci_localidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        End Select
    End Sub
End Class