Imports DevExpress.XtraBars
Imports Clases
Public Class frmPrincipal
    Private rOL As RolesCLS


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Cadena.Tipo <> 1 Then GetRol()
        'Me.RibbonControl.Minimized = True
        Me.RibbonControl.ApplicationCaption = "Sts.Nomina v3.01 - " & NombreEmpresaActual

        Dim pinicio As New DevExpress.XtraBars.Ribbon.RibbonPage
        pinicio = Catalogo
        Me.RibbonControl.SelectedPage = pinicio
    End Sub
    Private Sub GetRol()
        Rol = New RolesCLS
        Dim DT As DataTable = Rol.ListDetalles(Cadena.Rol)
        Rol.Dispose()
        If DT.Rows.Count - 1 > 0 Then
            For Each Pagina As Ribbon.RibbonPage In RibbonControl.Pages
                For i As Integer = 0 To DT.Rows.Count - 1
                    If DT.Rows(i)("Nombre") = Pagina.Name Then
                        Pagina.Visible = DT.Rows(i)("Activo")
                    End If
                Next
                For Each Grupo As Ribbon.RibbonPageGroup In Pagina.Groups
                    For i As Integer = 0 To DT.Rows.Count - 1
                        If DT.Rows(i)("Nombre") = Grupo.Name Then
                            Grupo.Visible = DT.Rows(i)("Activo")
                        End If
                    Next
                    For Each Opcion As Object In Grupo.ItemLinks
                        If TypeOf Opcion Is BarButtonItemLink Then
                            For i As Integer = 0 To DT.Rows.Count - 1
                                If DT.Rows(i)("Nombre") = CType(Opcion, BarButtonItemLink).Item.Name Then
                                    CType(Opcion, BarButtonItemLink).Item.Visibility = IIf(DT.Rows(i)("Activo"), BarItemVisibility.Always, BarItemVisibility.Never)
                                End If
                            Next

                        End If
                    Next
                Next
            Next
        End If

        DT.Clear()
        'Verificar los servidores configurados para la aplicacion
        dt = RH_ConfiguracionesDB.RH_VerificaServidores(1)
        cmdCatalogo.Visibility = IIf(dt.Rows.Count = 0, BarItemVisibility.Always, BarItemVisibility.Never)

    End Sub


    Private Sub cmdLocalidad_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) _
        Handles cmdLocalidad.ItemClick, cmdDepartamentos.ItemClick, cmdAreas.ItemClick, cmdCargos.ItemClick, _
        cmdFunciones.ItemClick, cmdProfesiones.ItemClick, cmdHorarios.ItemClick, cmdMonedas.ItemClick, _
        cmdFeriados.ItemClick, cmdConstancias.ItemClick, cmdRubrosEmpresa.ItemClick, cmdTIngresos.ItemClick, _
        cmdTDeducciones.ItemClick, cmdEmpleados.ItemClick, cmdPeriodos.ItemClick, cmdGenerarMovimientos.ItemClick, _
        cmdGenerarPlanilla.ItemClick, cmdReferencias.ItemClick, cmdPeriodoFiscal.ItemClick, cmdOrganigrama.ItemClick, _
        cmdRevAut.ItemClick, cmdRHConfiguraciones.ItemClick, cmdEmpleadosLight.ItemClick, cmdTipoAsistencias.ItemClick


        Select Case e.Item.Name.ToLower
            Case "cmdlocalidad"
                Dim frmChildInstance As New frmLocalidad
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmddepartamentos"
                Dim frmChildInstance As New frmDepartamentos
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdareas"
                Dim frmChildInstance As New frmAreas
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdcargos"
                Dim frmChildInstance As New frmCargos
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdfunciones"
                Dim frmChildInstance As New frmFunciones
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdprofesiones"
                Dim frmChildInstance As New frmProfesion
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdhorarios"
                Dim frmChildInstance As New frmHorarios
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdmonedas"
                Dim frmChildInstance As New frmMonedas
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdferiados"
                Dim frmChildInstance As New frmFeriados
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdconstancias"
                Dim frmChildInstance As New frmConstancias
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdrubrosempresa"
                Dim frmChildInstance As New frmTiposRubrosEmpresa
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdtingresos"
                Dim frmChildInstance As New frmTipoIngreso
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdtdeducciones"
                Dim frmChildInstance As New frmTipoDeduccion
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdempleados"
                Dim frmChildInstance As New Object
                frmEmpleados.Dispose()
                frmChildInstance = New frmEmpleados
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdperiodos"
                Dim frmChildInstance As New frmPeriodoNomina
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdperiodofiscal"
                Dim frmChildInstance As New frmPeriodoFiscalNomina
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdgenerarmovimientos"
                Dim frmChildInstance As New frmGMovimientos
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdgenerarplanilla"
                Dim frmChildInstance As New frmGPlanilla
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdorganigrama"
                Dim frmChildInstance As New frmOrganigrama
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdrevaut"
                Dim frmChildInstance As New frmAprobacionRevision_Nomina
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdrhconfiguraciones"
                Dim frmChildInstance As New frmConfiguraciones
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdtipoasistencias"
                Dim frmChildInstance As New frmTipoAsistencias
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()

        End Select

    End Sub

    Private Sub cmdGenerarHExtras_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) _
        Handles cmdGenerarHExtras.ItemClick, cmdAutorizarHE.ItemClick, cmdReportesHE.ItemClick, _
        cmdPermisos.ItemClick, cmdIngresos.ItemClick, cmdDeducciones.ItemClick, _
        cmdPagoVacaciones.ItemClick, cmdPagoAguinaldo.ItemClick, cmdPanelMovimientos.ItemClick, _
        cmdSalarioMinimo.ItemClick

        Select Case e.Item.Name.ToLower
            Case "cmdgenerarhextras"
                If QuincenaTrabajo = "" Then
                    Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
                    g.StartPosition = FormStartPosition.CenterScreen
                    g.ShowDialog()
                    g.Dispose()
                    g = Nothing
                    If QuincenaTrabajo = "" Then
                        Exit Sub
                    End If
                End If

                Dim frmChildInstance As frmGenerarHExtras = frmGenerarHExtras.Instance
                frmChildInstance.MdiParent = Me
                frmChildInstance.StartPosition = FormStartPosition.CenterScreen
                frmChildInstance.Show()
            Case "cmdautorizarhe"
                If QuincenaTrabajo = "" Then

                    Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
                    g.StartPosition = FormStartPosition.CenterScreen
                    g.ShowDialog()
                    g.Dispose()
                    g = Nothing
                    If QuincenaTrabajo = "" Then
                        Exit Sub
                    End If
                End If

                Dim frmChildInstance As frmAutHExtras = frmAutHExtras.Instance
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdreporteshe"
                Dim frmChildInstance As frmReporteHE = frmReporteHE.Instance
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdpermisos"
                If QuincenaTrabajo = "" Then
                    Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
                    g.StartPosition = FormStartPosition.CenterScreen
                    g.ShowDialog()
                    g.Dispose()
                    g = Nothing
                    If QuincenaTrabajo = "" Then
                        'Exit Sub
                    End If
                End If

                Dim frmChildInstance As New frmPermisos
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdingresos"
                Dim frmChildInstance As New frmIngresos
                frmChildInstance.Tipo = ""
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmddeducciones"
                Dim frmChildInstance As New frmDeducciones
                frmChildInstance.Tipo = ""
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()

            Case "cmdpagovacaciones"
                If QuincenaTrabajo = "" Then
                    Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
                    g.StartPosition = FormStartPosition.CenterScreen
                    g.ShowDialog()
                    g.Dispose()
                    g = Nothing
                    If QuincenaTrabajo = "" Then
                    Else
                        Dim QD As New VB.SysContab.PeriodoNominaDetails()
                        QD = VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo)
                        If QD.Procesado Then
                            MsgBox("No se puede trabajar las vacaciones con un periodo de nomina ya generado", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                    End If
                End If
                Dim frmChildInstance As New frmVacaciones
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdpagoaguinaldo"
                Dim frmChildInstance As New frmPagoAguinaldo
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdsalariominimo"
                If QuincenaTrabajo = "" Then
                    Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
                    g.StartPosition = FormStartPosition.CenterScreen
                    g.ShowDialog()
                    g.Dispose()
                    g = Nothing
                    If QuincenaTrabajo = "" Then
                    Else
                        Dim QD As New VB.SysContab.PeriodoNominaDetails()
                        QD = VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo)
                        If QD.Procesado Then
                            QuincenaTrabajo = ""
                        End If
                    End If
                End If
                Dim frmChildInstance As New frmEmpleados_CambioSalario
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
        End Select
    End Sub

    Private Sub cmdRevisionL_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) _
        Handles cmdRevisionL.ItemClick, cmdAprobacionL.ItemClick, cmdLiquidacion.ItemClick, _
        cmdReportesL.ItemClick, cmdReportePlanilla.ItemClick, cmdReporteComparativo.ItemClick, _
        cmdReporteHorasExtras.ItemClick, cmdReporteECDeducciones.ItemClick, cmdSolicitudes.ItemClick, _
        cmdCambiarEmpresa.ItemClick, cmdImportar.ItemClick, cmdAyuda.ItemClick, _
        cmdRoles.ItemClick, cmdUsuarios.ItemClick
        Select Case e.Item.Name.ToLower
            Case "cmdrevisionl"
                Dim f As frmRevisionEmpleados_Baja = frmRevisionEmpleados_Baja.Instance
                f.MdiParent = Me
                f.Show()
                f.WindowState = FormWindowState.Maximized
            Case "cmdaprobacionl"
                Dim f As frmAprobacionEmpleados_Baja = frmAprobacionEmpleados_Baja.Instance
                f.MdiParent = Me
                f.Show()
                f.WindowState = FormWindowState.Maximized
            Case "cmdliquidacion"
                Dim f As frmEmpleados_Baja_Liquidar = frmEmpleados_Baja_Liquidar.Instance
                f.MdiParent = Me
                f.Show()
                f.WindowState = FormWindowState.Maximized
            Case "cmdreportesl"
                Dim frmChildInstance As New frmReporteLiquidacion
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdreporteplanilla"
                Dim frmChildInstance As New frmRptPlanilla
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdreportecomparativo"
                Dim frmChildInstance As New frmRptPlanillaComparativo
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdreportehorasextras"
                Dim frmChildInstance As frmReporteHE = frmReporteHE.Instance
                frmChildInstance.MdiParent = Me
                frmChildInstance.Show()
            Case "cmdreporteecdeducciones"
                Dim frmChildInstance As New frmECDeduccion
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdsolicitudes"
                Dim frmChildInstance As New frmPanelSolicitudes
                frmChildInstance.MdiParent = Me
                frmChildInstance.WindowState = FormWindowState.Maximized
                frmChildInstance.Show()
            Case "cmdcambiarempresa"
                'Dim cambiarEmpresa As New frmCambiarEmpresa()
                'cambiarEmpresa.ShowDialog()
                'cambiarEmpresa.Dispose()
                'cambiarEmpresa = Nothing
                Dim se As New frmSeleccionarEmpresa
                se.ShowDialog()
                DialogResult = Windows.Forms.DialogResult.OK
            Case "cmdimportar"
                If QuincenaTrabajo = "" Then
                    Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
                    g.StartPosition = FormStartPosition.CenterScreen
                    g.ShowDialog()
                    g.Dispose()
                    g = Nothing
                    If QuincenaTrabajo = "" Then
                        MsgBox("Algunas opciones de la Importación de Archivos estarán deshabilitadas", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SysNomina")
                    End If
                End If
                Dim f As New frmImportacion
                f.MdiParent = Me
                f.Show()
                f.WindowState = FormWindowState.Maximized
            Case "cmdayuda"
                'Falta
            Case "cmdroles"
                Dim f As FrmRolesListar = FrmRolesListar.Instance
                f.MdiParent = Me
                f.Show()
                f.WindowState = FormWindowState.Maximized
            Case "cmdusuarios"
                Dim f As FrmUsuariosListar = FrmUsuariosListar.Instance
                f.MdiParent = Me
                f.Show()
                f.WindowState = FormWindowState.Maximized
        End Select
    End Sub




    'Private Sub cmdReporte_Borrador_ItemClick(ByVal sender As System.Object, _
    '    ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    '    Select Case e.Item.Name.ToLower
    '        Case "cmdreporte_borrador"
    '            frmRpt_Planilla.Dispose()
    '            frmRpt_Planilla.Reporte = 1
    '            frmRpt_Planilla.Text = frmRpt_Planilla.Text & " Planilla Borrador"
    '            frmRpt_Planilla.ShowDialog()
    '        Case "cmdreporte_alfabetico"

    '            frmRpt_Planilla.Dispose()
    '            frmRpt_Planilla.Reporte = 2
    '            frmRpt_Planilla.Text = "Reporte Alfabetico"
    '            frmRpt_Planilla.ShowDialog()


    '        Case "cmdreporte_numerico"
    '            frmRpt_Planilla.Dispose()
    '            frmRpt_Planilla.Reporte = 3
    '            frmRpt_Planilla.Text = "Reporte Numerico"
    '            frmRpt_Planilla.ShowDialog()

    '        Case "cmdfirmasplanilla"
    '            frmRpt_Planilla.Dispose()
    '            frmRpt_Planilla.Reporte = 4
    '            frmRpt_Planilla.Text = "Firmas Planilla"
    '            frmRpt_Planilla.ShowDialog()
    '        Case "cmddbfindemnizacion"
    '            frmRpt_Planilla.Dispose()
    '            frmRpt_Planilla.Reporte = 100
    '            frmRpt_Planilla.Text = "Generar Archivo Indemnizacion"
    '            frmRpt_Planilla.ShowDialog()
    '        Case "cmdirmes"
    '            frmRpt_Planilla.Dispose()
    '            frmRpt_Planilla.Reporte = 101
    '            frmRpt_Planilla.Text = "Retencion Mensual Impuesto sobre la Renta"
    '            frmRpt_Planilla.ShowDialog()
    '        Case "cmdinssmes"
    '            frmRpt_Planilla.Dispose()
    '            frmRpt_Planilla.Reporte = 102
    '            frmRpt_Planilla.Text = "Informe de Cotizacion del INSS"
    '            frmRpt_Planilla.ShowDialog()
    '    End Select

    'End Sub

    'Private Sub cmdColillas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    frmImp_ColillasPago.Dispose()
    '    frmImp_ColillasPago.Planilla = "%"
    '    frmImp_ColillasPago.ShowDialog()
    'End Sub


    'Private Sub cmdListadoReportes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdListadoReportes.ItemClick
    '    frmRpt_Planilla.Dispose()
    '    frmRpt_Planilla.Text = "Listado de Reportes de Planilla"
    '    frmRpt_Planilla.ShowDialog()
    'End Sub

    'Private Sub cmdHDeducciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdHDeducciones.ItemClick
    '    Dim frmChildInstance As New frmDeducciones
    '    frmChildInstance.Tipo = ""
    '    frmChildInstance.Historico = True
    '    frmChildInstance.MdiParent = Me
    '    frmChildInstance.WindowState = FormWindowState.Maximized
    '    frmChildInstance.Show()
    'End Sub

    'Private Sub cmdHIngreso_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdHIngreso.ItemClick
    '    Dim frmChildInstance As New frmIngresos
    '    frmChildInstance.Tipo = ""
    '    frmChildInstance.Historico = True
    '    frmChildInstance.MdiParent = Me
    '    frmChildInstance.WindowState = FormWindowState.Maximized
    '    frmChildInstance.Show()
    'End Sub

    Private Sub cmdAreasProduccion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAreasProduccion.ItemClick, _
        cmdCatProduccion.ItemClick, cmdEmpleadosCat.ItemClick, cmdProduccion.ItemClick, cmdAntiguedad.ItemClick, _
        cmdListadoReportes.ItemClick, cmdConsultas.ItemClick
        Select Case e.Item.Name.ToLower
            Case "cmdareasproduccion"
                frmDptoProduccionSemanal.Dispose()
                frmDptoProduccionSemanal.ShowDialog()
            Case "cmdcatproduccion"
                frmCat_Produccion.Dispose()
                frmCat_Produccion.MdiParent = Me
                frmCat_Produccion.Show()
            Case "cmdempleadoscat"
                frmEmpleados_Categorias.Dispose()
                frmEmpleados_Categorias.MdiParent = Me
                frmEmpleados_Categorias.Show()
            Case "cmdproduccion"
                frmProduccion.Dispose()
                frmProduccion.MdiParent = Me
                frmProduccion.Show()
            Case "cmdantiguedad"
                frmAntiguedad.Dispose()
                frmAntiguedad.MdiParent = Me
                frmAntiguedad.Show()
            Case "cmdconsultas"
                frmCatalogos.Dispose()
                frmCatalogos.Tabla = Nothing
                frmCatalogos.StartPosition = FormStartPosition.CenterScreen
                frmCatalogos.ShowDialog()
            Case "cmdlistadoreportes"
                frmRpt_Planilla.Dispose()
                frmRpt_Planilla.Text = "Listado de Reportes de Planilla"
                frmRpt_Planilla.StartPosition = FormStartPosition.CenterScreen
                frmRpt_Planilla.ShowDialog()
        End Select

    End Sub



    Private Sub cmdUsuariosNueva_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdUsuariosNueva.ItemClick
        frmAdmonUsuario.MdiParent = Me
        frmAdmonUsuario.WindowState = FormWindowState.Maximized
        frmAdmonUsuario.Show()
    End Sub

    Private Sub Roles_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Roles.ItemClick
        FrmAgregarRol.MdiParent = Me
        FrmAgregarRol.WindowState = FormWindowState.Maximized
        FrmAgregarRol.M = Me.RibbonControl
        FrmAgregarRol.Show()
    End Sub

    Private Sub cmdContraseña_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdContraseña.ItemClick
        FrmContraseña.ShowDialog()
    End Sub

    Private Sub cmdNivelAcademico_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNivelAcademico.ItemClick
        frmNivelAcademico.Dispose()
        frmNivelAcademico.MdiParent = Me
        frmNivelAcademico.WindowState = FormWindowState.Maximized
        frmNivelAcademico.Show()
    End Sub

    Private Sub cmdCatalogo_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCatalogo.ItemClick
        frmCatalogo_Nomina.Dispose()
        frmCatalogo_Nomina.MdiParent = Me
        frmCatalogo_Nomina.WindowState = FormWindowState.Maximized
        frmCatalogo_Nomina.Show()
    End Sub

    Private Sub cmdFacultades_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdFacultades.ItemClick, _
        cmdCarreras.ItemClick, cmdAsignaturas.ItemClick, cmdTurnos.ItemClick, cmdEduAsistencias.ItemClick, cmdContratos.ItemClick, cmdConfig.ItemClick, _
        cmdEDU_VerArchivos.ItemClick

        Select Case e.Item.Name.ToLower
            Case "cmdfacultades"
                frmFacultad.Dispose()
                frmFacultad.MdiParent = Me
                frmFacultad.WindowState = FormWindowState.Maximized
                frmFacultad.Show()
            Case "cmdcarreras"
                frmCarrera.Dispose()
                frmCarrera.MdiParent = Me
                frmCarrera.WindowState = FormWindowState.Maximized
                frmCarrera.Show()
            Case "cmdasignaturas"
                frmAsignaturas.Dispose()
                frmAsignaturas.MdiParent = Me
                frmAsignaturas.WindowState = FormWindowState.Maximized
                frmAsignaturas.Show()
            Case "cmdturnos"
                frmTurno.Dispose()
                frmTurno.MdiParent = Me
                frmTurno.WindowState = FormWindowState.Maximized
                frmTurno.Show()
            Case "cmdeduasistencias"
                If QuincenaTrabajo = "" Then
                    Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
                    g.StartPosition = FormStartPosition.CenterScreen
                    g.ShowDialog()
                    g.Dispose()
                    g = Nothing
                    If QuincenaTrabajo = "" Then
                        Exit Sub
                    End If
                End If
                frmAsistencias.Dispose()
                frmAsistencias.MdiParent = Me
                frmAsistencias.WindowState = FormWindowState.Maximized
                frmAsistencias.Show()

            Case "cmdcontratos"
                frmContratos.Dispose()
                frmContratos.MdiParent = Me
                frmContratos.WindowState = FormWindowState.Maximized
                frmContratos.Show()

            Case "cmdconfig"

                frmEDU_Configuraciones.Dispose()
                frmEDU_Configuraciones.MdiParent = Me
                frmEDU_Configuraciones.WindowState = FormWindowState.Maximized
                frmEDU_Configuraciones.Show()

            Case "cmdedu_verarchivos"

                frmVer_Archivos.Dispose()
                frmVer_Archivos.MdiParent = Me
                frmVer_Archivos.WindowState = FormWindowState.Maximized
                frmVer_Archivos.Show()
        End Select

    End Sub

    
    Private Sub cmdProcesar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdProcesar.ItemClick
        If QuincenaTrabajo = "" Then
            Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
            g.StartPosition = FormStartPosition.CenterScreen
            g.ShowDialog()
            g.Dispose()
            g = Nothing
            If QuincenaTrabajo = "" Then
                Exit Sub
            End If
        End If
        frmProcesar_Asistencias.Dispose()
        frmProcesar_Asistencias.MdiParent = Me
        frmProcesar_Asistencias.WindowState = FormWindowState.Maximized
        frmProcesar_Asistencias.Show()
    End Sub

    Private Sub cmdTasacambio_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdTasacambio.ItemClick
        frmTasaCambio.Dispose()
        frmTasaCambio.MdiParent = Me
        frmTasaCambio.WindowState = FormWindowState.Maximized
        frmTasaCambio.Show()
    End Sub

    Private Sub cmdPaises_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPaises.ItemClick
        frmPaises.Dispose()
        frmPaises.MdiParent = Me
        frmPaises.WindowState = FormWindowState.Maximized
        frmPaises.Show()
    End Sub

    Private Sub cmdMotivos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdMotivos.ItemClick
        frmMotivosBaja.Dispose()
        frmMotivosBaja.MdiParent = Me
        frmMotivosBaja.WindowState = FormWindowState.Maximized
        frmMotivosBaja.Show()
    End Sub

    Private Sub cmdBancos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdBancos.ItemClick
        frmBancos.Dispose()
        frmBancos.MdiParent = Me
        frmBancos.WindowState = FormWindowState.Maximized
        frmBancos.Show()
    End Sub

    Private Sub cmdEmpresasServidores_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdEmpresasServidores.ItemClick
        frmEmpresasServidores.Dispose()
        frmEmpresasServidores.MdiParent = Me
        frmEmpresasServidores.WindowState = FormWindowState.Maximized
        frmEmpresasServidores.Show()
    End Sub
End Class