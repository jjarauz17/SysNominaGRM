Imports System
Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class frmPanelSolicitudes_Impresion
    Public Shared Tabla As DataTable

    Private Sub frmPanelSolicitudes_Impresion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated


    End Sub

    Private Sub frmPanelSolicitudes_Impresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim cAgregar As DataColumn
        'cAgregar = New DataColumn("Re-Imprimir", GetType(System.Boolean))
        'cAgregar.DefaultValue = False
        'Tabla.Columns.Add(cAgregar)

        Me.dgLista.DataSource = Tabla
        Me.vLista.PopulateColumns()
        'For i As Integer = 0 To Me.vLista.Columns.Count - 1
        '    Me.vLista.Columns(i).Visible = 0
        'Next
        Me.vLista.Columns("# Solicitud").Visible = False
        Me.vLista.Columns("Tipo").Visible = False
        Me.vLista.Columns("Empleado").Visible = True
        Me.vLista.Columns("Descripcion").Visible = False
        Me.vLista.Columns("Fecha").Visible = True
        Me.vLista.Columns("Fecha Revisi�n").Visible = False
        Me.vLista.Columns("Fecha Soluci�n").Visible = False
        Me.vLista.Columns("cons_codigo").Visible = False
        Me.vLista.Columns("Estado").Visible = False
        Me.vLista.Columns("Imprimir").Visible = False
        Me.vLista.Columns("Nombre_Firma").Visible = False
        Me.vLista.Columns("Cedula_Firma").Visible = False
        Me.vLista.Columns("Cargo_Firma").Visible = False
        Me.vLista.Columns("Re-Imprimir").Visible = True
        Me.vLista.Columns("sEstado").Visible = False
        Me.vLista.Columns("Email").Visible = False

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetLists().Tables(0)
        Me.cbEmpleados.DisplayMember = "nombre"
        Me.cbEmpleados.ValueMember = "emp_codigo"

        Me.vLista.Columns("Empleado").ColumnEdit = Me.cbEmpleados

        Me.dtpEntregarEl.Properties.MinValue = Now.Date
        Me.dtpEntregarEl.EditValue = Now.Date
        Me.txtEntregaren.Text = "Recursos Humanos"

        Me.Impresoras()
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
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmPanelSolicitudes_Impresion_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If MsgBox("De la lista de constancias seleccionadas a imprimir (en pantalla), " & vbCrLf & _
            "hubo alguna que no se imprimi� o presenta alg�n error de impresi�n? ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Sts.Nomina") = MsgBoxResult.Yes Then
            MsgBox("Por favor seleccione la(s) constancia(s) que desea re-imprimir", MsgBoxStyle.OkOnly, "Sts.Nomina")
        Else
            MsgBox("Cuando este listo(a), presione el bot�n """" Enviar Emails """" " & vbCrLf & _
            "para notificar a los empleados de la impresi�n de sus constancias", MsgBoxStyle.OkOnly, "Sts.Nomina")
        End If
    End Sub

    Private Sub cmdReImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReImprimir.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Dim cantidad As Integer
        cantidad = Me.vLista.DataSource.table.Compute("Count(Empleado)", "[Re-Imprimir] = 1")
        If MsgBox("Se imprimira" & IIf(cantidad = 1, " (", "n (") & cantidad & ") constancia" & IIf(cantidad = 1, "", "s ") & ", esta lista la impresora para este trabajo?", MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.No Then
            Exit Sub
        End If

        For i As Integer = 0 To Me.vLista.DataRowCount - 1
            If Me.vLista.GetRowCellValue(i, "sEstado") <> 0 Then
                Me.vLista.SetRowCellValue(i, "Re-Imprimir", False)
                GoTo continuar
            End If
            If Me.vLista.GetRowCellValue(i, "Re-Imprimir") = False Then
                GoTo continuar
            End If
            ImprimeConstancia(Me.vLista.GetRowCellValue(i, "Tipo"))
            Dim Rep As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile(Application.StartupPath & "\Reporte.repx", True)

            Dim Texto As String = ""
            Texto = "A solicitud de parte interasada y para los fines que estime conveniente, se extiende la presente en la ciudad de " & _
                    ObtieneData("Select ciudad as Ciudad from Empresas Where codigo = " & EmpresaActual.ToString).Rows(0)("Ciudad")
            Texto = Texto & " a los " & Funciones.Letras(Now.Day, False).ToLower & " del mes de " & Format(Now.Date, "MMMM").Substring(0, 1).ToUpper & Format(Now.Date, "MMMM").Substring(1, Format(Now.Date, "MMMM").Length - 1) & " del a�o " & Funciones.Letras(Now.Year, False).Trim.ToLower
            Texto = Texto.Substring(0, Texto.Length - 4) & "."
            'Forma.PrintControl1.PrintingSystem = Rep.PrintingSystem
            Rep.XmlDataPath = Application.StartupPath & "\logoempresa.xml"
            Rep.DataSource = ObtieneData("Select E.nombre as Empresa, ve.nombre as Nombre, ve.emp_fingreso as Ingreso, " & _
              "c.cgo_nombre as Cargo,  m.mon_simbolo + ' ' + cast(ve.emp_salario * round(30.00 / nfp.dias,2) AS nvarchar) as Salario, d.dep_nombre as Departamento, a.are_descripcion as Area, " & _
              "'" & Texto & "' as Texto, '" & Me.vLista.GetRowCellValue(i, "Nombre_Firma") & "' as NombreGerente " & _
              ",'" & Me.vLista.GetRowCellValue(i, "Cargo_Firma") & "' as CargoGerente, " & _
              " Case When ve.emp_estado = 'C' Then 'Honorarios Profesionales: ' Else 'Salario: ' End as FormaPago " & _
              "from empresas e inner join vEmpleados ve on e.codigo = ve.empr_codigo inner join Cargos C on " & _
              "ve.empr_codigo = c.empr_codigo and ve.cgo_codigo = c.cgo_codigo inner join Areas A on " & _
              "ve.empr_codigo = a.empr_codigo and ve.are_codigo = a.are_codigo and " & _
              "ve.dep_codigo = a.dep_codigo inner join monedas m on ve.empr_codigo = m.empr_codigo and " & _
              "ve.mon_codigo = m.mon_codigo  inner join nomina_formapago nfp on ve.emp_formapago = nfp.empr_formapago  " & _
              "inner join Departamentos D on ve.empr_codigo = d.empr_codigo and ve.dep_codigo = d.dep_codigo " & _
              " where e.codigo = " & EmpresaActual & _
              "and ve.emp_codigo = '" & Me.vLista.GetRowCellValue(i, "Empleado") & "'")
            Rep.CreateDocument()
            Rep.Print(Me.cbImpresoras.EditValue)
            'Forma.WindowState = FormWindowState.Maximized
            'Forma.ShowDialog()
            'Forma = Nothing
            Rep = Nothing
continuar: Next
        MsgBox("Cuando este listo(a), presione el bot�n """" Enviar Emails """" " & vbCrLf & _
           "para notificar a los empleados de la impresi�n de sus constancias", MsgBoxStyle.OkOnly, "Sts.Nomina")
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

    Private Sub cmdEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnviarEmail.Click
        If Me.txtEntregaren.Text = "" Then
            MsgBox("Favor indicar el lugar donde estar�n las constancias para su debida entrega", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        For i As Integer = 0 To Me.vLista.DataRowCount - 1
            If Me.vLista.GetRowCellValue(i, "sEstado") <> 0 Then
                GoTo continuar
            End If

            If Me.vLista.GetRowCellValue(i, "Email") Is DBNull.Value Then
                GoTo continuar
            End If
            VB.SysContab.Email.Enviar_Mail_Outlook(Me.vLista.GetRowCellValue(i, "Email"), _
                "Solicitud de Constancia #" & Me.vLista.GetRowCellValue(i, "# Solicitud"), _
                "Favor pasar retirando su constancia por " & Me.txtEntregaren.Text & " el dia " & Me.dtpEntregarEl.DateTime.Date.ToString)
            VB.SysContab.SolicitudDB.Actualizar_Estado(Me.vLista.GetRowCellValue(i, "# Solicitud"), 2, _
            "Favor pasar retirando su constancia por " & Me.txtEntregaren.Text & " el dia " & Me.dtpEntregarEl.DateTime.Date.ToString)
continuar: Next
    End Sub
End Class