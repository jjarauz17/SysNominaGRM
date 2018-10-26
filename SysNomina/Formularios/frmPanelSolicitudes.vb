Imports DbConnect
Imports System.IO
Imports System
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class frmPanelSolicitudes

#Region "Variables"
    Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[sEstado] = 0 ")
    Dim sFiltro As String = "Pendientes"
#End Region

    Private Sub frmPanelSolicitudes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarSolicitudes()
        impresoras()
    End Sub

    Sub cargarPermisos()

    End Sub

    Sub cargarSolicitudes()

        Me.dgSolicitudes.DataSource = VB.SysContab.SolicitudDB.Listar(0, 0, -1)
        Me.vSolicitudes.PopulateColumns()


        Dim a As New Connect(VB.SysContab.Conexion.AbrirConexion)
        Try
            Me.cbTS_1.DataSource = a.EjecutarComando("_Get_TS", "Tipo_Solicitud")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        a = Nothing
        Me.cbTS_1.PopulateColumns()
        Me.cbTS_1.DisplayMember = "Descripcion"
        Me.cbTS_1.ValueMember = "Codigo"
        Me.cbTS_1.Columns("Mail").Visible = False

        Me.vSolicitudes.Columns("# Solicitud").Width = 30
        Me.vSolicitudes.Columns("Tipo").ColumnEdit = Me.cbTS_1
        Me.vSolicitudes.Columns("cons_codigo").Visible = False
        Me.vSolicitudes.Columns("Fecha Revisión").Visible = False
        Me.vSolicitudes.Columns("Fecha Revisión").OptionsColumn.ShowInCustomizationForm = True
        Me.vSolicitudes.Columns("Fecha Solución").Visible = False
        Me.vSolicitudes.Columns("Fecha Solución").OptionsColumn.ShowInCustomizationForm = True
        Me.vSolicitudes.Columns("Nombre_Firma").Visible = False
        Me.vSolicitudes.Columns("Cedula_Firma").Visible = False
        Me.vSolicitudes.Columns("Cargo_Firma").Visible = False
        Me.vSolicitudes.Columns("Re-Imprimir").Visible = False
        Me.vSolicitudes.Columns("sEstado").Visible = False
        Me.vSolicitudes.Columns("Email").Visible = False
        Me.vSolicitudes.Columns("Email").OptionsColumn.ShowInCustomizationForm = True
        Me.vSolicitudes.Columns("Imprimir").Caption = "Seleccionar"

        For i As Integer = 0 To Me.vSolicitudes.Columns.Count - 1
            If Me.vSolicitudes.Columns(i).FieldName = "Imprimir" Then
                GoTo continuar2
            End If
            Me.vSolicitudes.Columns(i).OptionsColumn.ReadOnly = True
continuar2: Next
        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetLists().Tables(0)
        Me.cbEmpleados.DisplayMember = "nombre"
        Me.cbEmpleados.ValueMember = "emp_codigo"
        For i As Integer = 0 To Me.cbEmpleados.Columns.Count - 1
            If Me.cbEmpleados.Columns(i).FieldName = "nombre" Or Me.cbEmpleados.Columns(i).FieldName = "emp_codigo" Then
                GoTo continuar
            End If
            Me.cbEmpleados.Columns(i).Visible = False
continuar: Next

        Me.vSolicitudes.Columns("Empleado").ColumnEdit = Me.cbEmpleados
        Me.cbEstado.EditValue = sFiltro
        Me.vSolicitudes.Columns("sEstado").FilterInfo = Filtro


    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdImprimirConstancias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirConstancias.Click
        If Me.vSolicitudes.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        If Me.chkPreview.Checked Then
            ImprimeConstancia(Me.vSolicitudes.GetFocusedRowCellValue("Tipo"))
            Dim Rep As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile(Application.StartupPath & "\Reporte.repx", True)
            Dim Texto As String = ""

            Dim ed As VB.SysContab.EmpresasDetails
            ed = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

            'Texto = "A solicitud de parte interasada y para los fines que estime conveniente, se extiende la presente en la ciudad de " & _
            '        ObtieneData("Select ciudad as Ciudad from Empresas Where codigo = " & EmpresaActual.ToString).Rows(0)("Ciudad")
            'Texto = Texto & " a los " & Funciones.Letras(Now.Day, False).ToLower & " del mes de " & Format(Now.Date, "MMMM").Substring(0, 1).ToUpper & Format(Now.Date, "MMMM").Substring(1, Format(Now.Date, "MMMM").Length - 1) & " del año " & Funciones.Letras(Now.Year, False).Trim.ToLower
            'Texto = Texto.Substring(0, Texto.Length - 4) & "."

            Texto = "A solicitud de parte interasada y para los fines que estime conveniente, se extiende la presente en la ciudad de " & _
                   ed.Ciudad
            Texto = Texto & " a los " & Funciones.Letras(Now.Day, False).ToLower & " del mes de " & Format(Now.Date, "MMMM").Substring(0, 1).ToUpper & Format(Now.Date, "MMMM").Substring(1, Format(Now.Date, "MMMM").Length - 1) & " del año " & Funciones.Letras(Now.Year, False).Trim.ToLower
            Texto = Texto.Substring(0, Texto.Length - 4) & "."

            Rep.XmlDataPath = Application.StartupPath & "\logoempresa.xml"
            Rep.DataSource = VB.SysContab.EmpleadosDB.Empleado_Constancia(EmpresaActual, _
                    Me.vSolicitudes.GetFocusedRowCellValue("Empleado"), Texto, _
                    Me.vSolicitudes.GetFocusedRowCellValue("Nombre_Firma"), _
                    Me.vSolicitudes.GetFocusedRowCellValue("Cargo_Firma"))

            'Rep.DataSource = ObtieneData("Select E.nombre as Empresa, ve.nombre as Nombre, ve.emp_fingreso as Ingreso, " & _
            '   "c.cgo_nombre as Cargo,  m.mon_simbolo + ' ' + cast(ve.emp_salario * round(30.00 / nfp.dias,2) AS nvarchar) as Salario, d.dep_nombre as Departamento, a.are_descripcion as Area, " & _
            '   "'" & Texto & "' as Texto, '" & Me.vSolicitudes.GetFocusedRowCellValue("Nombre_Firma") & "' as NombreGerente " & _
            '   ",'" & Me.vSolicitudes.GetFocusedRowCellValue("Cargo_Firma") & "' as CargoGerente, " & _
            '   " Case When ve.emp_estado = 'C' Then 'Honorarios Profesionales: ' Else 'Salario: ' End as FormaPago " & _
            '   "from empresas e inner join vEmpleados ve on e.codigo = ve.empr_codigo inner join Cargos C on " & _
            '   "ve.empr_codigo = c.empr_codigo and ve.cgo_codigo = c.cgo_codigo inner join Areas A on " & _
            '   "ve.empr_codigo = a.empr_codigo and ve.are_codigo = a.are_codigo and " & _
            '   "ve.dep_codigo = a.dep_codigo inner join monedas m on ve.empr_codigo = m.empr_codigo and " & _
            '   "ve.mon_codigo = m.mon_codigo  inner join nomina_formapago nfp on ve.emp_formapago = nfp.empr_formapago  " & _
            '   "inner join Departamentos D on ve.empr_codigo = d.empr_codigo and ve.dep_codigo = d.dep_codigo " & _
            '   " where e.codigo = " & EmpresaActual & _
            '   "and ve.emp_codigo = '" & Me.vSolicitudes.GetFocusedRowCellValue("Empleado") & "'")

            Rep.CreateDocument()
            Dim Forma As New FrmManejadorReporte
            Forma.PrintControl1.PrintingSystem = Rep.PrintingSystem
            Forma.WindowState = FormWindowState.Maximized
            Forma.ShowDialog()
            Forma = Nothing
            Rep = Nothing
            Exit Sub
        End If

        Dim cantidad As Integer
        cantidad = Me.vSolicitudes.DataSource.table.Compute("Count(Empleado)", "Imprimir = 1")
        If MsgBox("Se imprimira" & IIf(cantidad = 1, " (", "n (") & cantidad & ") constancia" & IIf(cantidad = 1, "", "s ") & ", esta lista la impresora para este trabajo?", MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim lTable As New DataTable
        lTable = Me.vSolicitudes.DataSource.table.clone
        For i As Integer = 0 To Me.vSolicitudes.DataRowCount - 1
            If Me.vSolicitudes.GetRowCellValue(i, "sEstado") <> 0 Then
                Me.vSolicitudes.SetRowCellValue(i, "Imprimir", False)
                GoTo continuar
            End If
            If Me.vSolicitudes.GetRowCellValue(i, "Imprimir") = False Then
                GoTo continuar
            End If
            ImprimeConstancia(Me.vSolicitudes.GetRowCellValue(i, "Tipo"))
            Dim Rep As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile(Application.StartupPath & "\Reporte.repx", True)
            'Dim rep As Constancias
            'Rep = DevExpress.XtraReports.UI.XtraReport.FromFile(Application.StartupPath & "\Reporte.repx", True)
            'Dim Forma As New FrmManejadorReporte
            Dim Texto As String = ""
            Texto = "A solicitud de parte interasada y para los fines que estime conveniente, se extiende la presente en la ciudad de " & _
                    ObtieneData("Select ciudad as Ciudad from Empresas Where codigo = " & EmpresaActual.ToString).Rows(0)("Ciudad")
            Texto = Texto & " a los " & Funciones.Letras(Now.Day, False).ToLower & " del mes de " & Format(Now.Date, "MMMM").Substring(0, 1).ToUpper & Format(Now.Date, "MMMM").Substring(1, Format(Now.Date, "MMMM").Length - 1) & " del año " & Funciones.Letras(Now.Year, False).Trim.ToLower
            Texto = Texto.Substring(0, Texto.Length - 4) & "."
            'Forma.PrintControl1.PrintingSystem = Rep.PrintingSystem
            Rep.XmlDataPath = Application.StartupPath & "\logoempresa.xml"
            Rep.DataSource = ObtieneData("Select E.nombre as Empresa, ve.nombre as Nombre, ve.emp_fingreso as Ingreso, " & _
              "c.cgo_nombre as Cargo,  m.mon_simbolo + ' ' + cast(ve.emp_salario * round(30.00 / nfp.dias,2) AS nvarchar) as Salario, d.dep_nombre as Departamento, a.are_descripcion as Area, " & _
              "'" & Texto & "' as Texto, '" & Me.vSolicitudes.GetRowCellValue(i, "Nombre_Firma") & "' as NombreGerente " & _
              ",'" & Me.vSolicitudes.GetRowCellValue(i, "Cargo_Firma") & "' as CargoGerente, " & _
              " Case When ve.emp_estado = 'C' Then 'Honorarios Profesionales: ' Else 'Salario: ' End as FormaPago " & _
              "from empresas e inner join vEmpleados ve on e.codigo = ve.empr_codigo inner join Cargos C on " & _
              "ve.empr_codigo = c.empr_codigo and ve.cgo_codigo = c.cgo_codigo inner join Areas A on " & _
              "ve.empr_codigo = a.empr_codigo and ve.are_codigo = a.are_codigo and " & _
              "ve.dep_codigo = a.dep_codigo inner join monedas m on ve.empr_codigo = m.empr_codigo and " & _
              "ve.mon_codigo = m.mon_codigo  inner join nomina_formapago nfp on ve.emp_formapago = nfp.empr_formapago  " & _
              "inner join Departamentos D on ve.empr_codigo = d.empr_codigo and ve.dep_codigo = d.dep_codigo " & _
              " where e.codigo = " & EmpresaActual & _
              "and ve.emp_codigo = '" & Me.vSolicitudes.GetRowCellValue(i, "Empleado") & "'")
            Rep.CreateDocument()
            Rep.Print(Me.cbImpresoras.EditValue)
            'Forma.WindowState = FormWindowState.Maximized
            'Forma.ShowDialog()
            'Forma = Nothing
            Rep = Nothing
            lTable.LoadDataRow(Me.vSolicitudes.GetRow(i).row.itemarray, False)


continuar: Next
        Dim f As New frmPanelSolicitudes_Impresion
        frmPanelSolicitudes_Impresion.Tabla = lTable
        f.ShowDialog()

        Me.cargarSolicitudes()
    End Sub

    Public Sub ImprimeConstancia(ByVal Codigo_Constancia As Integer)
        Dim Cadena As String
        Try
            Dim Data() As Byte = CType(ObtieneData("SELECT cons_formato FROM rh_Constancias WHERE cons_codigo = " & _
                Codigo_Constancia & " and empr_codigo = " & EmpresaActual).Rows(0).Item(0), Byte())
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\Reporte.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        If Me.vSolicitudes.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Dim cantidad As Integer
        cantidad = Me.vSolicitudes.DataSource.table.Compute("Count(Empleado)", "Imprimir = 1")
        If MsgBox("Se anularan" & IIf(cantidad = 1, " (", "n (") & cantidad & ") constancia" & IIf(cantidad = 1, "", "s ") & ", esta seguro de realizar este proceso?", MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.No Then
            Exit Sub
        End If

        For i As Integer = 0 To Me.vSolicitudes.DataRowCount - 1
            If Me.vSolicitudes.GetRowCellValue(i, "sEstado") >= 2 Then
                Me.vSolicitudes.SetRowCellValue(i, "Imprimir", False)
                GoTo continuar
            End If
            If Me.vSolicitudes.GetRowCellValue(i, "Imprimir") = False Then
                GoTo continuar
            End If

            VB.SysContab.SolicitudDB.Actualizar_Estado(Me.vSolicitudes.GetRowCellValue(i, "# Solicitud"), -1)
continuar: Next
        Me.cargarSolicitudes()
    End Sub

    Private Sub cbEstado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEstado.EditValueChanged, ComboBoxEdit1.EditValueChanged
        sFiltro = Me.cbEstado.EditValue
        Select Case Me.cbEstado.EditValue
            Case "Todos"
                Filtro = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "")
            Case "Anulados"
                Filtro = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[sEstado] = -1 ")
            Case "Pendientes"
                Filtro = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[sEstado] = 0 ")
            Case "Revisados"
                Filtro = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[sEstado] = 1 ")
            Case "Solucionados"
                Filtro = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[sEstado] = 2 ")
            Case "Entregados"
                Filtro = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[sEstado] = 3 ")
            Case Else
                Filtro = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "")
        End Select
        Me.vSolicitudes.Columns("sEstado").FilterInfo = Filtro
    End Sub

    Private Sub dgSolicitudes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgSolicitudes.KeyUp, dgPermisos.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.cargarSolicitudes()
        End If
    End Sub

    Private Sub cmdEntregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntregar.Click
        If Me.vSolicitudes.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Dim cantidad As Integer
        cantidad = Me.vSolicitudes.DataSource.table.Compute("Count(Empleado)", "Imprimir = 1")
        If MsgBox("Se marcaran como ENTREGADAS " & IIf(cantidad = 1, " (", "n (") & cantidad & ") constancia" & IIf(cantidad = 1, "", "s ") & ", esta seguro de realizar este proceso?", MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.No Then
            Exit Sub
        End If

        For i As Integer = 0 To Me.vSolicitudes.DataRowCount - 1
            If Me.vSolicitudes.GetRowCellValue(i, "sEstado") <> 2 Then
                Me.vSolicitudes.SetRowCellValue(i, "Imprimir", False)
                GoTo continuar
            End If
            If Me.vSolicitudes.GetRowCellValue(i, "Imprimir") = False Then
                GoTo continuar
            End If

            VB.SysContab.SolicitudDB.Actualizar_Estado(Me.vSolicitudes.GetRowCellValue(i, "# Solicitud"), 3)
continuar: Next
        Me.cargarSolicitudes()
    End Sub

    Private Sub Impresoras()

        Dim pd As New PrintDocument
        Dim Impresoras As String
        ' Default printer       
        Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName

        ' recorre las impresoras instaladas   
        For Each Impresoras In PrinterSettings.InstalledPrinters
            Me.cbImpresoras.Properties.Items.Add(Impresoras.ToString)
        Next
        ' selecciona la impresora predeterminada   
        Me.cbImpresoras.EditValue = s_Default_Printer

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim f As New frmSolictudConstancia
        f.ShowDialog()

    End Sub

    Private Sub cmdNuevoPermiso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevoPermiso.Click
        'Dim f As New frmAgregarPermisos_Empleado
        'f.ShowDialog()
    End Sub
End Class