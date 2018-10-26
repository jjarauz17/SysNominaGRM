Imports System.IO
Imports System
Imports System.Data

Public Class frmComprobante
#Region "Variables"
    Public dt As New DataTable
    Public Cargado As Boolean = False
    Public CuentasVacias As Integer = 0
#End Region

    Private Sub frmComprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbPlanillas.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList(False)
        Me.cbPlanillas.Properties.DisplayMember = "per_descripcion"
        Me.cbPlanillas.Properties.ValueMember = "per_codigo"

        cbmoneda.Properties.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbmoneda.Properties.ValueMember = "Codigo"
        cbmoneda.Properties.DisplayMember = "Descripcion"

        Me.txtXe7.Properties.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Catalogo(False, False)
        Me.txtXe7.Properties.DisplayMember = "Nombre"
        Me.txtXe7.Properties.ValueMember = "Cuenta"

        Me.cbmoneda.EditValue = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MONEDABASE

        Me.RG.EditValue = 3
        Cargado = True
    End Sub

    Private Sub Cargar()
        Dim filtro As String
        If Me.chkAgrupar.EditValue = True Then
            filtro = "TIPO = '2'"
        Else
            filtro = "TIPO = '1'"
        End If
        If Me.cbPlanillas.EditValue = "%" Then
            Exit Sub
        End If

        Me.cbGastos.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Rubros(False)
        Me.cbGastos.DisplayMember = "Nombre"
        Me.cbGastos.ValueMember = "Rubro"


        Try

            dt = VB.SysContab.RH_OrganigramaDB.Plantilla(CuentasVacias, _
                Me.cbPlanillas.EditValue.substring(1, 8), _
                Me.cbPlanillas.EditValue.substring(0, 1), _
                Me.cbmoneda.EditValue, Me.chkAgrupar.EditValue)

            Me.dgComprobante.DataSource = VB.SysContab.RH_OrganigramaDB.SelectDataTable(dt, filtro)
            Me.vLista.PopulateColumns()

            Me.vLista.Columns("cuenta").Visible = True
            Me.vLista.Columns("cuenta").Caption = "Cuenta"
            Me.vLista.Columns("subcuenta").Caption = "Nombre/Cuenta"
            Me.vLista.Columns("rubro").Caption = "Rubro Nómina"
            Me.vLista.Columns("mov_concepto").Caption = "Concepto"
            Me.vLista.Columns("debito").Caption = "Debito"
            Me.vLista.Columns("credito").Caption = "Crédito"

            Me.vLista.Columns("area").Visible = False
            Me.vLista.Columns("mov_concepto2").Visible = False
            Me.vLista.Columns("Linea").Visible = False
            Me.vLista.Columns("org_codigo").Visible = False
            Me.vLista.Columns("TIPO").Visible = False
            Me.vLista.Columns("DC").Visible = False

            Me.vLista.Columns("rub_gasto").Visible = Not Me.chkAgrupar.Checked
            Me.vLista.Columns("rub_gasto").Caption = "Rubro Gasto"
            Me.vLista.Columns("rub_gasto").ColumnEdit = Me.cbGastos
            Me.vLista.Columns("idsubcentro").Visible = Not Me.chkAgrupar.Checked


            Me.vLista.Columns("rubro").Visible = Not Me.chkAgrupar.Checked


            Me.vLista.Columns("debito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vLista.Columns("debito").DisplayFormat.FormatString = "n2"

            Me.vLista.Columns("debito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vLista.Columns("debito").SummaryItem.DisplayFormat = "{0:n2}"

            Me.vLista.Columns("credito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vLista.Columns("credito").DisplayFormat.FormatString = "n2"

            Me.vLista.Columns("credito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vLista.Columns("credito").SummaryItem.DisplayFormat = "{0:n2}"

            Me.vLista.BestFitColumns()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Exportar As Boolean
    Private Function Validar(Optional ByVal Contab As Boolean = 0) As Boolean

        Dim Erro As Boolean = True
        If CuentasVacias <> 0 Then
            XtraMsg("Hay Rubros de Nomina a los que aun no se han asignado cuentas contables." + vbCrLf + "Favor revisar la plantilla", MessageBoxIcon.Warning)
            Erro = False
            If Not XtraMsg2("Aun así desea exportar el archivo?") Then
                Exportar = True
            Else
                Erro = True
            End If
        End If
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Exclamation)
            Erro = False
        End If
        If Me.vLista.Columns("debito").SummaryItem.SummaryValue <> Me.vLista.Columns("credito").SummaryItem.SummaryValue Then
            If Contab = True Then
                If Me.txtXe7.EditValue Is Nothing Then
                    MsgBox("Seleccione la cuenta contable para registrar el descuadre")
                    Erro = False
                Else
                    If Me.txtXe7.EditValue Is DBNull.Value Then
                        MsgBox("Seleccione la cuenta contable para registrar el descuadre")
                        Erro = False
                    End If
                End If
            Else
                MsgBox("El comprobante no esta cuadrado, favor revisar", MsgBoxStyle.Exclamation)
                Erro = False
                If MsgBox("Aun así desea exportar el archivo?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.Yes Then
                    Erro = True
                    Exportar = True
                End If
            End If
        End If
        'If vLista.DataSource.table.Compute("Count(rub_codigo)", "rub_codigo= 0 and left(cuenta,1) >= 4") >= 1 Then
        '    MsgBox("Hay lineas del comprobante sin rubro de gastos asignados")
        '    Erro = False
        '    Exportar = False
        'End If
        'If vLista.DataSource.table.Compute("Count(idsubcentro)", "idsubcentro= 0 and left(cuenta,1) >= 4") >= 1 Then
        '    MsgBox("Hay lineas del comprobante cuyo centro de costo contable es la raiz del arbol.")
        '    Erro = False
        '    Exportar = False
        'End If

        Return Erro
    End Function
    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click

        Validar()

        If Exportar = True Then
            Select Case RG.EditValue
                Case 1
                    Me.SFD.InitialDirectory = Application.StartupPath()
                    Me.SFD.Filter = "Text Files (*.csv)|*.csv"
                    Me.SFD.FilterIndex = 1
                    Me.SFD.RestoreDirectory = True
                    Me.SFD.FileName = Application.StartupPath() & "\exportfiles\CD_" & Me.cbPlanillas.EditValue & ".csv"
                    If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Try
                            Dim dt1 As DataTable
                            dt1 = dt.Copy
                            dt1.Columns.Remove("Id")
                            '                        dt1.Columns.Remove("Cuenta")
                            dt1.Columns.Remove("rubro")
                            dt1.Columns.Remove("Linea")
                            dt1.Columns.Remove("area")
                            dt1.Columns.Remove("mov_concepto2")
                            dt1.Columns("SubCuenta").SetOrdinal(0)
                            dt1.Columns("debito").SetOrdinal(1)
                            dt1.Columns("credito").SetOrdinal(2)
                            dt1.Columns("mov_concepto").SetOrdinal(3)


                            VB.SysContab.RutinasNomina.Exportar_Archivo_TXT(dt1, Me.SFD.FileName, "")

                        Catch Ex As Exception
                            MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                            Exit Sub
                        Finally

                        End Try
                    End If
                Case 2
                    Me.SFD.InitialDirectory = Application.StartupPath()
                    Me.SFD.Filter = "Text Files (*.txt)|*.txt"
                    Me.SFD.FilterIndex = 1
                    Me.SFD.RestoreDirectory = True
                    Me.SFD.FileName = Application.StartupPath() & "\exportfiles\CD_" & Me.cbPlanillas.EditValue & ".txt"
                    If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Try
                            VB.SysContab.RutinasNomina.ExportarTXT(dt, Me.SFD.FileName, 180)
                        Catch Ex As Exception
                            MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                            Exit Sub
                        Finally

                        End Try
                    End If
                Case 3
                    Me.SFD.InitialDirectory = Application.StartupPath()
                    Me.SFD.Filter = "Text Files (*.xml)|*.xml"
                    Me.SFD.FilterIndex = 1
                    Me.SFD.RestoreDirectory = True
                    Me.SFD.FileName = Application.StartupPath() & "\exportfiles\CD_" & Me.cbPlanillas.EditValue & ".xml"
                    If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Try
                            Dim dt1 As DataTable
                            dt1 = dt.Copy
                            dt1.Columns.Remove("Id")
                            dt1.Columns.Remove("rubro")
                            dt1.Columns.Remove("Linea")
                            dt1.Columns.Remove("mov_concepto")

                            dt1.Columns("SubCuenta").ColumnName = "Nombre Cuenta"
                            dt1.Columns("mov_concepto2").SetOrdinal(1)
                            dt1.Columns("mov_concepto2").ColumnName = "Concepto"
                            dt1.Columns("debito").ColumnName = "Debito"
                            dt1.Columns("debito").SetOrdinal(2)
                            dt1.Columns("credito").ColumnName = "Credito"
                            dt1.Columns("credito").SetOrdinal(3)
                            dt1.Columns("area").SetOrdinal(0)
                            dt1.WriteXml(Me.SFD.FileName, XmlWriteMode.WriteSchema)

                        Catch Ex As Exception
                            MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                            Exit Sub
                        Finally

                        End Try
                    End If
                Case 4
                    Me.SFD.InitialDirectory = Application.StartupPath()
                    Me.SFD.Filter = "Text Files (*.dbf)|*.dbf"
                    Me.SFD.FilterIndex = 1
                    Me.SFD.RestoreDirectory = True
                    Me.SFD.FileName = Application.StartupPath() & "\exportfiles\CD" & Me.cbPlanillas.EditValue.substring(3, 6) & ".dbf"
                    If SFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Try
                            VB.SysContab.RutinasNomina.Exportar_DBF(Me.SFD.FileName.Substring(0, Me.SFD.FileName.Length - 12), "CD" & Me.cbPlanillas.EditValue.substring(3, 6), dt)
                        Catch Ex As Exception
                            MessageBox.Show("No se puede escribir el archivo. Error original: " & Ex.Message)
                            Exit Sub
                        Finally
                        End Try
                    End If
                Case 5
                    frmExportarImprimir.Mostrar(dgComprobante)
                    'Dim forma As New frmExportarImprimir
                    'forma.Mostrar(Me.dgComprobante)
            End Select
        End If
    End Sub

    

    Function CrearTabla() As DataTable
        Dim Tabla As New DataTable("Detalle")

        Tabla.Columns.Add("NumerodeCuenta", Type.GetType("System.String"))
        Tabla.Columns.Add("Debito", Type.GetType("System.Decimal"))
        Tabla.Columns.Add("Credito", Type.GetType("System.Decimal"))

        Dim dr As DataRow = Nothing

        For i As Integer = 0 To dt.Rows.Count - 1
            dr = Tabla.NewRow

            dr("NumerodeCuenta") = dt.Rows.Item(i)("cuenta")
            dr("Debito") = dt.Rows.Item(i)("debito")
            dr("Credito") = dt.Rows.Item(i)("credito")

            Tabla.Rows.Add(dr)
        Next

        Return Tabla
    End Function

    Private Sub cbPlanillas_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbPlanillas.Validating
        If Cargado Then
            Me.Cargar()
        End If
    End Sub

    Private Sub cbmoneda_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmoneda.EditValueChanged
        If Cargado Then
            Me.Cargar()
        End If
    End Sub

    Private Sub chkAgrupar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgrupar.CheckedChanged
        If Cargado Then
            Me.Cargar()
        End If
    End Sub

    Private Sub cmdReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReporte.Click

        Dim dt1 As DataTable
        dt1 = dt.Copy
        dt1.Columns.Remove("Id")
        dt1.Columns.Remove("rubro")
        dt1.Columns.Remove("Linea")
        dt1.Columns.Remove("mov_concepto")

        dt1.Columns("SubCuenta").ColumnName = "Nombre Cuenta"
        dt1.Columns("mov_concepto2").SetOrdinal(1)
        dt1.Columns("mov_concepto2").ColumnName = "Concepto"
        dt1.Columns("debito").ColumnName = "Debito"
        dt1.Columns("debito").SetOrdinal(2)
        dt1.Columns("credito").ColumnName = "Credito"
        dt1.Columns("credito").SetOrdinal(3)
        dt1.Columns("area").SetOrdinal(0)
        dt1.WriteXml(Application.StartupPath & "\cd.xml", XmlWriteMode.WriteSchema)

        Dim dt2 As New DataTable("Encabezado")
        dt2.Columns.Add("quincena", Type.GetType("System.String"))
        dt2.Columns.Add("titulo", Type.GetType("System.String"))
        Dim dr As DataRow = Nothing
        dr = dt2.NewRow

        dr("quincena") = Me.cbPlanillas.EditValue
        dr("titulo") = Me.cbPlanillas.Text & " desde " & Me.cbPlanillas.GetColumnValue("per_finicio").ToString.Substring(0, 10) & " hasta " & Me.cbPlanillas.GetColumnValue("per_ffinal").ToString.Substring(0, 10)
        dt2.Rows.Add(dr)
        dr = Nothing
        dt2.WriteXml(Application.StartupPath & "\ecd.xml", XmlWriteMode.WriteSchema)

        Dim Reporte As New Object
        Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not File.Exists(Application.StartupPath & "\reportes\rptCD.rpt") Then
            MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptCD.rpt")
            Exit Sub
        End If

        Reporte.load(Application.StartupPath & "\reportes\rptCD.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Reporte.Database.Tables("Tabla").Location = Application.StartupPath & "\cd.xml"
        Reporte.Database.Tables("Encabezado").Location = Application.StartupPath & "\ecd.xml"

        Dim f As New frmReportes
        f.crvReportes.ReportSource = Reporte
        f.ShowDialog()


    End Sub

    Private Sub dgComprobante_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgComprobante.DoubleClick
        If Me.vLista.DataRowCount = 0 Then
            Exit Sub
        End If
        If Me.chkAgrupar.EditValue = True Then
            Exit Sub
        End If

        frmComprobante_Detalle.Dispose()
        frmComprobante_Detalle.rubro = Me.vLista.GetFocusedRowCellValue("rubro")
        frmComprobante_Detalle.organigrama = Me.vLista.GetFocusedRowCellValue("org_codigo")
        frmComprobante_Detalle.periodo = Me.cbPlanillas.EditValue
        frmComprobante_Detalle.WindowState = FormWindowState.Maximized
        frmComprobante_Detalle.ShowDialog()
    End Sub

    
    Private Sub cmdSysContab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSysContab.Click
        If Not Validar(True) Then Exit Sub
        'ADORNOS.ShowSplash()
        ShowSplash()

        If Not VB.SysContab.RH_OrganigramaDB.EnviarComprobante(Me.cbPlanillas.EditValue, Now.Date, _
                "Contabilizando Planilla", Usuario, "", 0, dt, Me.txtXe7.EditValue, _
                Me.vLista.Columns("debito").SummaryItem.SummaryValue - Me.vLista.Columns("credito").SummaryItem.SummaryValue, Me.chkAgrupar.Checked) Then
            MsgBox("No se pudo enviar el documento a la Contabilidad")
            Exit Sub
        End If
        HideSplash()
        'ADORNOS.HideSplash()
    End Sub

   
    Private Sub cbPlanillas_EditValueChanged(sender As Object, e As EventArgs) Handles cbPlanillas.EditValueChanged

    End Sub

    Private Sub dgComprobante_Click(sender As Object, e As EventArgs) Handles dgComprobante.Click

    End Sub

    Private Sub btnDataSet_Click(sender As Object, e As EventArgs) Handles btnDataSet.Click

    End Sub
End Class