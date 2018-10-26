Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.Utils
Imports DevExpress.Utils.Frames
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
'Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraTabbedMdi

Public Class frmMain

    Private Rol As RolesCLS

    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(GetSetting(Application.CompanyName, Application.ProductName, "Skin"))
    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Private Sub rcMain_ShowCustomizationMenu(ByVal sender As Object, ByVal e As RibbonCustomizationMenuEventArgs) Handles ribbonControl.ShowCustomizationMenu
        e.CustomizationMenu.InitializeMenu()
        If Object.Equals(e.Link, Nothing) OrElse (Not "AllowQuickAccess".Equals(e.Link.Item.Tag)) Then
            e.CustomizationMenu.RemoveLink(e.CustomizationMenu.ItemLinks(0))
        End If
    End Sub

#Region "Paginas"

    'Private Sub XtraTabbedMdiManager1_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XtraTabbedMdiManager1.SelectedPageChanged
    '    FormularioActual = XtraTabbedMdiManager1.SelectedPage.Text
    '    Opciones(XtraTabbedMdiManager1.SelectedPage.Text)
    'End Sub

    'Private Sub RibbonControl_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ribbonControl.SelectedPageChanged
    '    If ribbonControl.SelectedPage.Name <> "rbAcciones" Then
    '        rbOptions.Visible = False
    '    End If
    'End Sub

    Private Sub xtraTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded


        If Trim(e.Page.Text) = "Movimientos Contables" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.pivot_16x16)
        End If


        If Trim(e.Page.Text) = "Partidas" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.alignverticalcenter_16x16)
        End If

        If Trim(e.Page.Text) = "Tipo Cuentas" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.sendbehindtext_16x16)
        End If

        If Trim(e.Page.Text) = "Tipo Documentos" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.bringtofront_16x16)
        End If

        If Trim(e.Page.Text) = "Documentos Fuentes" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.article_16x16)
        End If

        If Trim(e.Page.Text) = "Periodos Contables" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.article_16x16)
        End If

        If Trim(e.Page.Text) = "Valores Relativos" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.groupfieldcollection_16x16)
        End If

        ''/****************  MENU CATALOGOS ***********************************

        If Trim(e.Page.Text) = "Catalogo de Cuentas" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.alignverticalcenter_16x16)
        End If

        If Trim(e.Page.Text) = "Monedas" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.currency_16x16)
        End If

        If Trim(e.Page.Text) = "Tipos Cuentas" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.sendbehindtext_16x16)
        End If

        If Trim(e.Page.Text) = "Tipos Documentos" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.bringtofront_16x16)
        End If

        If Trim(e.Page.Text) = "Documentos Fuentes" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.article_16x16)
        End If

        If Trim(e.Page.Text) = "Periodos Contables" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.Scheduler_16x16)
        End If

        If Trim(e.Page.Text) = "Tipos de Plantillas" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.article_16x16)
        End If

        If Trim(e.Page.Text) = "Cierres de Mes" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.clip_16x16)
        End If

        ''***********************************************************************

        If Trim(e.Page.Text) = "Cuentas Costos" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.cellsautoheight__32x32)
        End If

        If Trim(e.Page.Text) = "Reporte Auxiliar" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.preview_32x32)
        End If

        If Trim(e.Page.Text) = "Anexos" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.preview_32x32)
        End If

        If Trim(e.Page.Text) = "Balanza de Comprobacion" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.preview_32x32)
        End If

        If Trim(e.Page.Text) = "Balance General" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.preview_32x32)
        End If

        If Trim(e.Page.Text) = "Estado de Resultado" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.preview_32x32)
        End If
        If Trim(e.Page.Text) = "Presupuesto" Then
            UpdateMdiPictureFormPreview(e.Page, SysNominav3.My.Resources.kpi_32x32)
        End If
    End Sub

    Private Sub UpdateMdiPictureFormPreview(ByVal page As XtraMdiTabPage, ByVal img As Image)
        If page Is Nothing Then
            Return
        End If
        Dim preview As Image = Nothing
        Const previewHeight As Integer = 20
        Const previewWidthMax As Integer = 20
        'int previewHeight = this.imageList3.ImageSize.Height;
        If img IsNot Nothing AndAlso img.Height > 0 AndAlso previewHeight > 0 Then
            Dim previewWidth As Integer = previewHeight * img.Width \ img.Height
            If previewWidth > 0 Then
                If previewWidth > previewWidthMax Then
                    previewWidth = previewWidthMax
                End If
                preview = New Bitmap(img, previewWidth, previewHeight)
            End If
        End If
        page.Image = preview
    End Sub

#End Region

    Private Sub rgbiSkins_GalleryItemCheckedChanged(sender As Object, e As GalleryItemEventArgs) Handles rgbiSkins.GalleryItemCheckedChanged
        SaveSetting(Application.CompanyName, Application.ProductName, "Skin", e.Item.Caption)
        lblEstilo.Caption = e.Item.Caption
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If XtraMsg2("Esta Seguro de Cerrar la Sistema: " & My.Application.Info.ProductName.ToString & " ?") Then
            End
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''************   VALIDAR SOLO PARA LOS USUARIO QUE NO SON ADMIN EN LA TABLA DE USUARIOS *****************************
        If Cadena.Tipo <> 1 Then GetRol()
        'Me.RibbonControl.Minimized = True        

        lblVersion.Caption = GetVersion(ProductVersion)
        lblEstilo.Caption = GetSetting(Application.CompanyName, Application.ProductName, "Skin")

        siStatus.Caption = "Servidor: " & Cadena.Servidor.ToString.ToUpper & " Base de Datos: " & Cadena.Base.ToString.ToUpper
        siInfo.Caption = "Sistema: " & My.Application.Info.ProductName.ToString
        lblUsuario.Caption = "Usuario Conectado: " & Cadena.Usuario.ToString

        Dim pinicio As New DevExpress.XtraBars.Ribbon.RibbonPage
        pinicio = rCatalogo
        Me.ribbonControl.SelectedPage = pinicio

        Me.ribbonControl.ApplicationCaption = "Sts.Nomina v3.01 - " & NombreEmpresaActual
    End Sub

    Private Sub GetRol()
        Rol = New RolesCLS
        Dim DT As DataTable = Rol.ListDetalles(Cadena.Rol)
        Rol.Dispose()
        If DT.Rows.Count - 1 > 0 Then
            For Each Pagina As Ribbon.RibbonPage In ribbonControl.Pages
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

        'DT.Clear()
        'Verificar los servidores configurados para la aplicacion
        'DT = RH_ConfiguracionesDB.RH_VerificaServidores(1)
        'cmdCatalogo.Visibility = IIf(DT.Rows.Count = 0, BarItemVisibility.Always, BarItemVisibility.Never)

    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Dim f As frmPagoAguinaldo = frmPagoAguinaldo.Instance
        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub iExit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iExit.ItemClick
        If XtraMsg2("Esta Seguro de Cerrar la Sistema: " & My.Application.Info.ProductName.ToString & " ?") Then
            End
        End If
    End Sub

    Private Sub bUsuario_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bUsuario.ItemClick
        frmAdmonUsuario.Dispose()
        frmAdmonUsuario.MdiParent = Me
        frmAdmonUsuario.Show()
        frmAdmonUsuario.Text = e.Item.Caption
        frmAdmonUsuario.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        FrmAgregarRol.Dispose()
        FrmAgregarRol.MdiParent = Me
        FrmAgregarRol.M = Me.ribbonControl
        FrmAgregarRol.Show()
        FrmAgregarRol.Text = e.Item.Caption
        FrmAgregarRol.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bCambiarPass_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bCambiarPass.ItemClick
        FrmContraseña.ShowDialog()
        FrmContraseña.Dispose()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frmLocalidad.Dispose()
        frmLocalidad.MdiParent = Me
        frmLocalidad.Show()
        frmLocalidad.Text = e.Item.Caption
        frmLocalidad.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        frmDepartamentos.Dispose()
        frmDepartamentos.MdiParent = Me
        frmDepartamentos.Show()
        frmDepartamentos.Text = e.Item.Caption
        frmDepartamentos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        frmAreas.Dispose()
        frmAreas.MdiParent = Me
        frmAreas.Show()
        frmAreas.Text = e.Item.Caption
        frmAreas.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        frmCargos.Dispose()
        frmCargos.MdiParent = Me
        frmCargos.Show()
        frmCargos.Text = e.Item.Caption
        frmCargos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bDocumentosFuentes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bDocumentosFuentes.ItemClick
        frmFunciones.Dispose()
        frmFunciones.MdiParent = Me
        frmFunciones.Show()
        frmFunciones.Text = e.Item.Caption
        frmFunciones.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bTasa_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bTasa.ItemClick
        frmProfesion.Dispose()
        frmProfesion.MdiParent = Me
        frmProfesion.Show()
        frmProfesion.Text = e.Item.Caption
        frmProfesion.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem29_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        ShowSplash("Cargando Organigrama")
        frmOrganigrama.Dispose()
        frmOrganigrama.MdiParent = Me
        frmOrganigrama.Show()
        frmOrganigrama.Text = e.Item.Caption
        frmOrganigrama.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem56_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem56.ItemClick
        frmPaises.Dispose()
        frmPaises.MdiParent = Me
        frmPaises.Show()
        frmPaises.Text = e.Item.Caption
        frmPaises.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem50_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem50.ItemClick
        frmNivelAcademico.Dispose()
        frmNivelAcademico.MdiParent = Me
        frmNivelAcademico.Show()
        frmNivelAcademico.Text = e.Item.Caption
        frmNivelAcademico.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bCierreMes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bCierreMes.ItemClick
        frmAntiguedad.Dispose()
        frmAntiguedad.MdiParent = Me
        frmAntiguedad.Show()
        frmAntiguedad.Text = e.Item.Caption
        frmAntiguedad.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem55_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem55.ItemClick
        frmCatalogo_Nomina.Dispose()
        frmCatalogo_Nomina.MdiParent = Me
        frmCatalogo_Nomina.Show()
        frmCatalogo_Nomina.Text = e.Item.Caption
        frmCatalogo_Nomina.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem34_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        frmMonedas.Dispose()
        frmMonedas.MdiParent = Me
        frmMonedas.Show()
        frmMonedas.Text = e.Item.Caption
        frmMonedas.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem38_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        frmHorarios.Dispose()
        frmHorarios.MdiParent = Me
        frmHorarios.Show()
        frmHorarios.Text = e.Item.Caption
        frmHorarios.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem54_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem54.ItemClick
        frmFeriados.Dispose()
        frmFeriados.MdiParent = Me
        frmFeriados.Show()
        frmFeriados.Text = e.Item.Caption
        frmFeriados.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem57_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem57.ItemClick
        frmConstancias.Dispose()
        frmConstancias.MdiParent = Me
        frmConstancias.Show()
        frmConstancias.Text = e.Item.Caption
        frmConstancias.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem66_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem66.ItemClick
        frmTipoIngreso.Dispose()
        frmTipoIngreso.MdiParent = Me
        frmTipoIngreso.Show()
        frmTipoIngreso.Text = e.Item.Caption
        frmTipoIngreso.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem67_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem67.ItemClick
        frmTipoDeduccion.Dispose()
        frmTipoDeduccion.MdiParent = Me
        frmTipoDeduccion.Show()
        frmTipoDeduccion.Text = e.Item.Caption
        frmTipoDeduccion.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem58_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem58.ItemClick
        frmEmpleados.Dispose()
        frmEmpleados.MdiParent = Me
        frmEmpleados.Show()
        frmEmpleados.Text = e.Item.Caption
        frmEmpleados.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem59_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem59.ItemClick
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

        frmEmpleados_CambioSalario.Dispose()
        frmEmpleados_CambioSalario.MdiParent = Me
        frmEmpleados_CambioSalario.Show()
        frmEmpleados_CambioSalario.Text = e.Item.Caption
        frmEmpleados_CambioSalario.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem79_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem79.ItemClick
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

        frmPermisos.Dispose()
        frmPermisos.MdiParent = Me
        frmPermisos.Show()
        frmPermisos.Text = e.Item.Caption
        frmPermisos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem69_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem69.ItemClick
        frmBancos.Dispose()
        frmBancos.MdiParent = Me
        frmBancos.Show()
        frmBancos.Text = e.Item.Caption
        frmBancos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem33_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        frmTasaCambio.Dispose()
        frmTasaCambio.MdiParent = Me
        frmTasaCambio.Show()
        frmTasaCambio.Text = e.Item.Caption
        frmTasaCambio.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem70_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem70.ItemClick
        frmTiposRubrosEmpresa.Dispose()
        frmTiposRubrosEmpresa.MdiParent = Me
        frmTiposRubrosEmpresa.Show()
        frmTiposRubrosEmpresa.Text = e.Item.Caption
        frmTiposRubrosEmpresa.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem65_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem65.ItemClick
        frmMotivosBaja.Dispose()
        frmMotivosBaja.MdiParent = Me
        frmMotivosBaja.Show()
        frmMotivosBaja.Text = e.Item.Caption
        frmMotivosBaja.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem35_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        frmConfiguraciones.Dispose()
        frmConfiguraciones.MdiParent = Me
        frmConfiguraciones.Show()
        frmConfiguraciones.Text = e.Item.Caption
        frmConfiguraciones.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem48_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        Dim f As New frmSeleccionarEmpresa
        f.ShowDialog()
        DialogResult = Windows.Forms.DialogResult.OK
        f.Dispose()
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        frmEmpresasServidores.Text = e.Item.Caption        
        frmEmpresasServidores.ShowDialog()
        frmEmpresasServidores.Dispose()
    End Sub

    Private Sub bConfigurarBalance_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bConfigurarBalance.ItemClick
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
        '
        frmImportacion.Dispose()
        frmImportacion.MdiParent = Me
        frmImportacion.Show()
        frmImportacion.Text = e.Item.Caption
        frmImportacion.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem30_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        frmRptPlanilla.Dispose()
        frmRptPlanilla.MdiParent = Me
        frmRptPlanilla.Show()
        frmRptPlanilla.Text = e.Item.Caption
        frmRptPlanilla.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bAnexos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bAnexos.ItemClick
        frmRptPlanillaComparativo.Dispose()
        frmRptPlanillaComparativo.MdiParent = Me
        frmRptPlanillaComparativo.Show()
        frmRptPlanillaComparativo.Text = e.Item.Caption
        frmRptPlanillaComparativo.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bBalanza_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bBalanza.ItemClick        
        Dim frm As frmReporteHE = frmReporteHE.Instance()
        frm.MdiParent = Me
        frm.Show()
        frm.Text = e.Item.Caption
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bBalance_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bBalance.ItemClick
        frmECDeduccion.Dispose()
        frmECDeduccion.MdiParent = Me
        frmECDeduccion.Show()
        frmECDeduccion.Text = e.Item.Caption
        frmECDeduccion.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bEstadoResultado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bEstadoResultado.ItemClick
        frmCatalogos.Dispose()
        frmCatalogos.MdiParent = Me
        frmCatalogos.Show()
        frmCatalogos.Text = e.Item.Caption
        frmCatalogos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bRazonesFinancieras_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bRazonesFinancieras.ItemClick
        frmRpt_Planilla.Dispose()
        frmRpt_Planilla.MdiParent = Me
        frmRpt_Planilla.Show()
        frmRpt_Planilla.Text = e.Item.Caption
        frmRpt_Planilla.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bMovimientosContables_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bMovimientosContables.ItemClick
        frmPanelSolicitudes.Dispose()
        frmPanelSolicitudes.MdiParent = Me
        frmPanelSolicitudes.Show()
        frmPanelSolicitudes.Text = e.Item.Caption
        frmPanelSolicitudes.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem73_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem73.ItemClick
        frmIngresos.Dispose()
        frmIngresos.MdiParent = Me
        frmIngresos.Show()
        frmIngresos.Text = e.Item.Caption
        frmIngresos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem75_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem75.ItemClick
        frmDeducciones.Dispose()
        frmDeducciones.MdiParent = Me
        frmDeducciones.Show()
        frmDeducciones.Text = e.Item.Caption
        frmDeducciones.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem60_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem60.ItemClick
        frmPeriodoNomina.Dispose()
        frmPeriodoNomina.MdiParent = Me
        frmPeriodoNomina.Show()
        frmPeriodoNomina.Text = e.Item.Caption
        frmPeriodoNomina.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem61_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem61.ItemClick
        frmPeriodoFiscalNomina.Dispose()
        frmPeriodoFiscalNomina.MdiParent = Me
        frmPeriodoFiscalNomina.Show()
        frmPeriodoFiscalNomina.Text = e.Item.Caption
        frmPeriodoFiscalNomina.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem62_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem62.ItemClick
        frmGMovimientos.Dispose()
        frmGMovimientos.MdiParent = Me
        frmGMovimientos.Show()
        frmGMovimientos.Text = e.Item.Caption
        frmGMovimientos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem63_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem63.ItemClick
        frmGPlanilla.Dispose()
        frmGPlanilla.MdiParent = Me
        frmGPlanilla.Show()
        frmGPlanilla.Text = e.Item.Caption
        frmGPlanilla.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem64_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem64.ItemClick
        frmAprobacionRevision_Nomina.Dispose()
        frmAprobacionRevision_Nomina.MdiParent = Me
        frmAprobacionRevision_Nomina.Show()
        frmAprobacionRevision_Nomina.Text = e.Item.Caption
        frmAprobacionRevision_Nomina.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem71_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem71.ItemClick
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
        '
        Dim frm As frmGenerarHExtras = frmGenerarHExtras.Instance
        frm.Dispose()

        Dim frmChildInstance As frmGenerarHExtras = frmGenerarHExtras.Instance
        frmChildInstance.MdiParent = Me
        frmChildInstance.Show()
        frmChildInstance.Text = e.Item.Caption
        frmChildInstance.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem72_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem72.ItemClick
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

        Dim frm As frmAutHExtras = frmAutHExtras.Instance
        frm.Dispose()

        Dim frmChildInstance As frmAutHExtras = frmAutHExtras.Instance
        frmChildInstance.MdiParent = Me
        frmChildInstance.Show()
        frmChildInstance.Text = e.Item.Caption
        frmChildInstance.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem32_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem32.ItemClick
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
                    XtraMsg("No se puede trabajar las vacaciones con un periodo de nomina ya generado", MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If

        frmVacaciones.Dispose()
        frmVacaciones.MdiParent = Me
        frmVacaciones.Show()
        frmVacaciones.Text = e.Item.Caption
        frmVacaciones.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem76_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem76.ItemClick
        Dim frm As frmRevisionEmpleados_Baja = frmRevisionEmpleados_Baja.Instance
        frm.Dispose()

        Dim frmChildInstance As frmRevisionEmpleados_Baja = frmRevisionEmpleados_Baja.Instance
        frmChildInstance.MdiParent = Me
        frmChildInstance.Show()
        frmChildInstance.Text = e.Item.Caption
        frmChildInstance.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem77_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem77.ItemClick
        Dim frm As frmAprobacionEmpleados_Baja = frmAprobacionEmpleados_Baja.Instance
        frm.Dispose()

        Dim frmChildInstance As frmAprobacionEmpleados_Baja = frmAprobacionEmpleados_Baja.Instance
        frmChildInstance.MdiParent = Me
        frmChildInstance.Show()
        frmChildInstance.Text = e.Item.Caption
        frmChildInstance.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem78_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem78.ItemClick
        Dim frm As frmEmpleados_Baja_Liquidar = frmEmpleados_Baja_Liquidar.Instance
        frm.Dispose()

        Dim frmChildInstance As frmEmpleados_Baja_Liquidar = frmEmpleados_Baja_Liquidar.Instance
        frmChildInstance.MdiParent = Me
        frmChildInstance.Show()
        frmChildInstance.Text = e.Item.Caption
        frmChildInstance.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem80_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem80.ItemClick
        frmReporteLiquidacion.Dispose()
        frmReporteLiquidacion.MdiParent = Me
        frmReporteLiquidacion.Show()
        frmReporteLiquidacion.Text = e.Item.Caption
        frmReporteLiquidacion.WindowState = FormWindowState.Maximized
    End Sub
End Class
