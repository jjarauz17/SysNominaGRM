Imports System.IO
Imports System.Data.SqlClient
Public Class frmImportacion

#Region "Variables"
    Dim unico As Boolean
    Dim inicio, final As Date
    Dim Rinicio, Rfinal As Date
    Dim Importar As Boolean
    Dim xmlds As DataSet

    Dim r As New VB.SysContab.RutinasNomina()
    Dim Ingreso As New VB.SysContab.IngresoDB()
    Dim Egreso As New VB.SysContab.DeduccionDB()
    Dim PN As New VB.SysContab.PeriodoNominaDB()
    Dim Reloj As New VB.SysContab.RelojDB()
    Dim DEmpresa As New VB.SysContab.EmpresasDetails()
    Dim DPeriodo As New VB.SysContab.PeriodoNominaDetails()
    Dim Periodo As New VB.SysContab.PeriodoNominaDB()
    Dim TC As New VB.SysContab.Tasa_CambioDB()
    Dim dTC As New VB.SysContab.Tasa_CambioDetails()
    Dim custDV As DataView
    Dim MonedaBase As String = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MONEDABASE
    Dim MonedaAnterior As String = ""

    Dim nArchivo As String
    Dim myStream As Stream = Nothing
    Dim Documentos As New VB.SysContab.DocumentosDB()
    Dim fArchivo() As Byte


    Enum FuenteReloj
        Archivo = 0
        Conexion = 1
    End Enum

#End Region
    Private Sub frmImportacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.AutoScroll = True
        DEmpresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        If QuincenaTrabajo <> "" Then
            DPeriodo = VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo)

            Dim lds As New VB.SysContab.PeriodoNominaDetails()
            lds = VB.SysContab.PeriodoNominaDB.GetListBuscarFInicio(DateAdd(DateInterval.Day, -1, DPeriodo.FInicio), Microsoft.VisualBasic.Left(QuincenaTrabajo, 1))
            If Not (lds.Codigo Is Nothing Or lds.Codigo = "") Then
                Rinicio = lds.FInicio
            Else
                Rinicio = DPeriodo.FInicio
            End If
            Rfinal = DPeriodo.FFinal
        End If


        Me.unico = True
        Me.NCuotas.Value = 1
        Me.cbBuscarPor.EditValue = "Cedula"

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetLists().Tables(0)
        Me.cbEmpleados.DisplayMember = "nombre"
        Me.cbEmpleados.ValueMember = "emp_codigo"

        Me.cbTipoMovimiento.Properties.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables(0) 'VB.SysContab.TipoIngresoDB.GetList(IIf(Me.unico, "U", "P")).Tables("TipoIngreso")
        Me.cbTipoMovimiento.Properties.ValueMember = "Codigo"
        Me.cbTipoMovimiento.Properties.DisplayMember = "Descripcion"

        cbMoneda.Properties.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbMoneda.Properties.ValueMember = "Codigo"
        cbMoneda.Properties.DisplayMember = "Descripcion"

        cbMonedaTC.Properties.DataSource = VB.SysContab.MonedaDB.GetListBuscarCombo("%").Tables("Monedas")
        cbMonedaTC.Properties.ValueMember = "Codigo"
        cbMonedaTC.Properties.DisplayMember = "Descripcion"

        Me.chkNRegular.Checked = True
        Me.chkNRegular.Enabled = Me.unico

        VB.SysContab.PeriodoNominaDB.GetListFechaMinima_Nominas(inicio, final)

        Me.dtpFechaInicio.Properties.MinValue = inicio
        Me.dtpFechaInicio.Properties.MaxValue = final
        Me.dtpFechaInicio.EditValue = inicio

        Me.Text = "Importación de Archivos "

        Me.dtpFechaInicio.EditValue = IIf(Me.dtpFechaInicio.Properties.MinValue = Me.dtpFechaInicio.Properties.MaxValue, Me.dtpFechaInicio.Properties.MinValue, Me.dtpFechaInicio.Properties.MaxValue)
        If QuincenaTrabajo = "" Then
            Me.cbTipo.SelectedIndex = 3
            Me.cbTipo.Enabled = False
        Else
            Me.cbTipo.SelectedIndex = 0
            Me.cbTipo.Enabled = True
        End If

        Importar = False
        Me.cmdAceptar.Text = "Aceptar"
        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim i As Integer
        Dim DEmpleado As New VB.SysContab.EmpleadosDetails()
        Dim Empleado As New VB.SysContab.EmpleadosDB()
        Dim cEmpleado As String = ""
        Dim cLiquidado As Boolean = False
        Dim cFecha_FinContrato As String = ""
        Dim cMovimiento As String = ""


        Select Case Microsoft.VisualBasic.Left(Me.cbTipo.SelectedItem, 1)
            Case "I"
                If Importar = False Then
                    'Leer el archivo de Ingresos, analizar los datos del empleado y hacer los calculos correspondientes
                    'para cuando sean tipos de ingreso por hora / dia.
                    myStream = Nothing
                    Me.OFD.InitialDirectory = Application.StartupPath()

                    Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
                    Me.OFD.FilterIndex = 1
                    'Me.OFD.RestoreDirectory = True

                    If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Try
                            myStream = Me.OFD.OpenFile()
                        Catch Ex As Exception
                            MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                            Exit Sub
                        Finally
                            If Not IsNothing(myStream) Then
                                nArchivo = Me.OFD.FileName
                                'myStream.Close()
                                xmlds = New DataSet()
                                If Documentos.Leer_Archivo(nArchivo, xmlds) = -1 Then
                                    MsgBox("Error al cargar el archivo")
                                End If
                            End If
                        End Try
                    End If
                    If IsNothing(myStream) Then
                        Exit Sub
                    End If
                    ShowSplash()
                    If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "id" Then
                        MsgBox("El nombre del primer campo debe ser <ID>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "monto" Then
                        MsgBox("El nombre del segundo campo debe ser <Monto>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If

                    Dim Errores As New DataSet()
                    Dim Importar As New DataTable
                    Errores = xmlds.Clone()
                    Errores.Tables(0).Columns.Add("TError")
                    Errores.Tables(0).Columns.Add("Nombre")

                    Importar.Columns.Add("ID", System.Type.GetType("System.String"))
                    Importar.Columns.Add("Empleado", System.Type.GetType("System.String"))
                    Importar.Columns.Add("Valor Importado", System.Type.GetType("System.Decimal"))
                    Importar.Columns.Add("Valor Hora/Dia", System.Type.GetType("System.Decimal"))
                    Importar.Columns.Add("Valor a Importar", System.Type.GetType("System.Decimal"))
                    Importar.Columns.Add("Monto Original", System.Type.GetType("System.Decimal"))
                    Importar.Columns.Add("Importado", System.Type.GetType("System.Boolean"))
                    Importar.Columns.Add("Importar", System.Type.GetType("System.Boolean"))



                    For i = 0 To xmlds.Tables(0).Rows.Count - 1
                        If Me.cbBuscarPor.EditValue.tolower = "cedula" Then
                            DEmpleado = VB.SysContab.EmpleadosDB.GetDetails_cedula(xmlds.Tables(0).Rows(i)("ID"))
                        ElseIf Me.cbBuscarPor.EditValue.tolower = "inss" Then
                            DEmpleado = VB.SysContab.EmpleadosDB.GetDetails_inss(xmlds.Tables(0).Rows(i)("ID"))
                        Else
                            DEmpleado = VB.SysContab.EmpleadosDB.GetDetails(xmlds.Tables(0).Rows(i)("ID"))
                        End If

                        If DEmpleado.Codigo Is Nothing Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("Nombre") = ""
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "No se encontro el ID."
                            GoTo [Continue]
                        End If
                        If DEmpleado.Liquidado Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("Nombre") = DEmpleado.Nombre
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Empleado ha sido liquidado."
                            GoTo [Continue]
                        End If
                        If DEmpleado.Fecha_FinContrato <> "" Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("Nombre") = DEmpleado.Nombre
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "El empleado esta dado de baja, no se puede ingresar movimientos desde esta herramienta"
                            GoTo [Continue]
                        End If



                        Dim fila As DataRow = Importar.NewRow
                        fila("ID") = xmlds.Tables(0).Rows(i)("ID") ' DEmpleado.Cedula
                        fila("Empleado") = DEmpleado.Codigo
                        fila("Valor Importado") = xmlds.Tables(0).Rows(i)("Monto")
                        fila("Valor Hora/Dia") = 0
                        fila("Valor a Importar") = 0
                        fila("Monto Original") = xmlds.Tables(0).Rows(i)("Monto")
                        fila("Importar") = True
                        fila("Importado") = False

                        Importar.Rows.Add(fila)
                        fila = Nothing

                        'No hay errores
                        Dim Monto, Valor As Double
                        Valor = 1
                        Monto = 0
                        Dim tc, tc2 As Double
                        tc = VB.SysContab.Tasa_CambioDB.TasaCambioDia( _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Day, _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Month, _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Year, _
                                MonedaBase, _
                                DEmpleado.Moneda)

                        tc2 = VB.SysContab.Tasa_CambioDB.TasaCambioDia( _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Day, _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Month, _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Year, _
                                MonedaBase, _
                                Me.cbMoneda.EditValue)

                        Select Case Me.cbTipoMovimiento.GetColumnValue("Tipo")
                            Case 5, 6
                                Monto = xmlds.Tables(0).Rows(i)("Monto")
                                If Me.cbTipoMovimiento.GetColumnValue("Tipo") = 5 Then
                                    'If Me.cbTipoMovimiento.GetColumnValue("Valor Fijo") = False Then
                                    Valor = (tc) * DEmpleado.SalarioxDia
                                    Valor = Math.Round((1 / tc2) * Valor, 2)
                                    'End If
                                Else
                                    'If Me.cbTipoMovimiento.GetColumnValue("Valor Fijo") = False Then
                                    Valor = (tc) * DEmpleado.SalarioxHora
                                    Valor = Math.Round((1 / tc2) * Valor, 2)
                                    'End If
                                End If
                                Valor *= IIf(Me.cbTipoMovimiento.GetColumnValue("Doble") = True, 2, 1)
                                Monto *= Valor
                            Case Else
                                Monto = xmlds.Tables(0).Rows(i)("Monto")
                                Importar.Rows(Importar.Rows.Count - 1)("Monto Original") = 0
                        End Select

                        Importar.Rows(Importar.Rows.Count - 1)("Valor Hora/Dia") = Valor
                        Importar.Rows(Importar.Rows.Count - 1)("Valor a Importar") = Monto


[Continue]:         Next

                    If Errores.Tables(0).Rows.Count <> 0 Then
                        VB.SysContab.RutinasNomina.Exportar_Archivo(Errores.Tables(0), "Errores")
                        dgDetalle.DataSource = Errores.Tables(0)
                        Me.vMensajes.OptionsBehavior.Editable = False

                    End If
                    If Importar.Rows.Count <> 0 Then
                        dgImportar.DataSource = Importar
                        Me.vImportar.Columns("Empleado").ColumnEdit = Me.cbEmpleados
                        Me.vImportar.Columns("Monto Original").Visible = False

                        For z As Integer = 0 To Me.vImportar.Columns.Count - 2
                            Me.vImportar.Columns(z).OptionsColumn.AllowEdit = False
                            Me.vImportar.Columns(z).OptionsColumn.AllowFocus = False
                        Next

                        Select Case Me.cbTipoMovimiento.GetColumnValue("Tipo")
                            Case 5, 6
                                Me.vImportar.Columns("Valor Importado").Visible = True
                                Me.vImportar.Columns("Valor Hora/Dia").Visible = True
                                Me.vImportar.Columns("Valor Importado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                Me.vImportar.Columns("Valor Importado").SummaryItem.DisplayFormat = "{0:n2}"
                                Me.vImportar.Columns("Valor Importado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                                Me.vImportar.Columns("Valor Importado").DisplayFormat.FormatString = "{0:n2}"

                                Me.vImportar.Columns("Valor Hora/Dia").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                Me.vImportar.Columns("Valor Hora/Dia").SummaryItem.DisplayFormat = "{0:n2}"
                                Me.vImportar.Columns("Valor Hora/Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                                Me.vImportar.Columns("Valor Hora/Dia").DisplayFormat.FormatString = "{0:n2}"
                            Case Else
                                Me.vImportar.Columns("Valor Importado").Visible = False
                                Me.vImportar.Columns("Valor Hora/Dia").Visible = False

                        End Select


                        Me.vImportar.Columns("Valor a Importar").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                        Me.vImportar.Columns("Valor a Importar").SummaryItem.DisplayFormat = "{0:n2}"
                        Me.vImportar.Columns("Valor a Importar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        Me.vImportar.Columns("Valor a Importar").DisplayFormat.FormatString = "{0:n2}"

                        Me.vImportar.Columns("ID").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                        Me.vImportar.Columns("ID").SummaryItem.DisplayFormat = "{0:n0}"
                        Me.vImportar.BestFitColumns()
                    End If
                    Me.Importar = True
                    Me.cmdAceptar.Text = "Procesar"
                    Me.cmdLimpiar.Enabled = True
                    Me.Refresh()
                Else
                    'Postear el contenido del grid a los ingresos
                    Dim Importados As Integer = 0
                    For x As Integer = 0 To Me.vImportar.DataRowCount - 1
                        If Me.vImportar.GetRowCellValue(x, "Importar") = True Then
                            If VB.SysContab.IngresoDB.Additem("0", _
                                Me.vImportar.GetRowCellValue(x, "Empleado"), _
                                Now.Date, _
                                Me.dtpFechaInicio.EditValue.Date, _
                                Math.Round(Me.vImportar.GetRowCellValue(x, "Valor a Importar"), 2), _
                                Me.cbTipoMovimiento.EditValue, _
                                False, _
                                Me.cbMoneda.EditValue, _
                                IIf(Me.cbTipoMovimiento.GetColumnValue("Tipo") = 2, False, True), _
                                Me.chkNRegular.Checked, _
                                False, _
                                Me.vImportar.GetRowCellValue(x, "Monto Original"), _
                                Me.vImportar.GetRowCellValue(x, "Valor Hora/Dia"), "") = True Then

                                'Si no hubo error al ingresar el registro, marcarlo en la lista
                                Me.vImportar.SetRowCellValue(x, "Importado", True)
                                Me.vImportar.SetRowCellValue(x, "Importar", False)
                                Importados += 1
                            Else
                                Me.vImportar.SetRowCellValue(x, "Importado", False)
                                Me.vImportar.SetRowCellValue(x, "Importar", True)

                            End If
                        End If

                    Next

                    If Importados <> Me.vImportar.DataRowCount Then
                        MsgBox("No se importaron todos los registros. Favor revise los datos", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    Else
                        Me.Importar = False
                        Me.cmdLimpiar.Enabled = False
                        Me.cmdAceptar.Text = "Aceptar"
                        Me.dgDetalle.DataSource = Nothing
                        Me.dgImportar.DataSource = Nothing
                    End If
                    Dim fArchivo(myStream.Length) As Byte
                    myStream.Read(fArchivo, 0, myStream.Length)
                    VB.SysContab.DocumentosDB.Postear_Archivo(fArchivo, nArchivo, "I", _
                        Me.cbTipoMovimiento.EditValue, Me.cbMoneda.EditValue, Me.dtpDesde.Value, _
                        Me.NCuotas.EditValue, Me.chkNRegular.Checked, False)
                    myStream.Close()
                End If

            Case "D"

                If Importar = False Then
                    'Deducciones
                    myStream = Nothing
                    Me.OFD.InitialDirectory = Application.StartupPath()

                    Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
                    Me.OFD.FilterIndex = 1
                    'Me.OFD.RestoreDirectory = True

                    If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Try
                            myStream = Me.OFD.OpenFile()
                        Catch Ex As Exception
                            MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                            Exit Sub
                        Finally
                            If Not IsNothing(myStream) Then
                                nArchivo = Me.OFD.FileName
                                'myStream.Close()
                                xmlds = New DataSet()
                                If Documentos.Leer_Archivo(nArchivo, xmlds) = -1 Then
                                    MsgBox("Error al cargar el archivo")
                                End If
                            End If
                        End Try
                    End If
                    If IsNothing(myStream) Then
                        Exit Sub
                    End If
                    ShowSplash()
                    If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "id" Then
                        MsgBox("El nombre del primer campo debe ser <ID>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "monto" Then
                        MsgBox("El nombre del segundo campo debe ser <Monto>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns.Count = 3 Then
                        If xmlds.Tables(0).Columns(2).ColumnName.ToLower <> "cuotas" Then
                            MsgBox("El nombre del tercer campo debe ser <Cuotas>", MsgBoxStyle.Critical, "SysNomina")
                            Exit Sub
                        End If
                    End If

                    Dim Errores As New DataSet()
                    Dim Importar As New DataTable
                    Errores = xmlds.Clone()
                    Errores.Tables(0).Columns.Add("TError")
                    Errores.Tables(0).Columns.Add("Nombre")

                    Importar.Columns.Add("ID", System.Type.GetType("System.String"))
                    Importar.Columns.Add("Empleado", System.Type.GetType("System.String"))
                    Importar.Columns.Add("Valor Importado", System.Type.GetType("System.Decimal"))
                    Importar.Columns.Add("Valor Hora/Dia", System.Type.GetType("System.Decimal"))
                    Importar.Columns.Add("Valor a Importar", System.Type.GetType("System.Decimal"))
                    Importar.Columns.Add("Monto Original", System.Type.GetType("System.Decimal"))
                    Importar.Columns.Add("Valor Cuota", System.Type.GetType("System.Decimal"))
                    Importar.Columns.Add("Cuotas", System.Type.GetType("System.Int32"))
                    Importar.Columns.Add("Importar", System.Type.GetType("System.Boolean"))
                    Importar.Columns.Add("Importado", System.Type.GetType("System.Boolean"))



                    For i = 0 To xmlds.Tables(0).Rows.Count - 1
                        If Me.cbBuscarPor.EditValue.tolower = "cedula" Then
                            DEmpleado = VB.SysContab.EmpleadosDB.GetDetails_cedula(xmlds.Tables(0).Rows(i)("ID"))
                        ElseIf Me.cbBuscarPor.EditValue.tolower = "inss" Then
                            DEmpleado = VB.SysContab.EmpleadosDB.GetDetails_inss(xmlds.Tables(0).Rows(i)("ID"))
                        Else
                            DEmpleado = VB.SysContab.EmpleadosDB.GetDetails(xmlds.Tables(0).Rows(i)("ID"))
                        End If
                        If DEmpleado.Codigo Is Nothing Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("Nombre") = ""
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "No se encontro el ID."
                            GoTo [Continued]
                        End If
                        If DEmpleado.Liquidado Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("Nombre") = DEmpleado.Nombre
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Empleado ha sido liquidado."
                            GoTo [Continued]
                        End If
                        If DEmpleado.Fecha_FinContrato <> "" Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("Nombre") = DEmpleado.Nombre
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "El empleado esta dado de baja, no se puede ingresar movimientos desde esta herramienta"
                            GoTo [Continued]
                        End If



                        Dim fila As DataRow = Importar.NewRow
                        fila("ID") = xmlds.Tables(0).Rows(i)("ID") 'DEmpleado.Cedula
                        fila("Empleado") = DEmpleado.Codigo
                        fila("Valor Importado") = xmlds.Tables(0).Rows(i)("Monto")
                        fila("Valor Hora/Dia") = 0
                        fila("Valor a Importar") = 0

                        If xmlds.Tables(0).Columns.Count = 3 Then
                            fila("Cuotas") = xmlds.Tables(0).Rows(i)("Cuotas")
                        Else
                            fila("Cuotas") = Me.NCuotas.EditValue
                        End If

                        fila("Valor Cuota") = 0
                        fila("Importar") = True
                        fila("Importado") = False
                        fila("Monto Original") = xmlds.Tables(0).Rows(i)("Monto")
                        Importar.Rows.Add(fila)
                        fila = Nothing

                        'No hay errores
                        Dim Monto, Valor As Double
                        Valor = 1
                        Monto = 0
                        Dim tc, tc2 As Double
                        tc = VB.SysContab.Tasa_CambioDB.TasaCambioDia( _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Day, _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Month, _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Year, _
                                MonedaBase, _
                                DEmpleado.Moneda)

                        tc2 = VB.SysContab.Tasa_CambioDB.TasaCambioDia( _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Day, _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Month, _
                                VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Year, _
                                MonedaBase, _
                                Me.cbMoneda.EditValue)

                        Select Case Me.cbTipoMovimiento.GetColumnValue("Tipo")
                            Case 5, 6
                                Monto = xmlds.Tables(0).Rows(i)("Monto")
                                If Me.cbTipoMovimiento.GetColumnValue("Tipo") = 5 Then
                                    'If Me.cbTipoMovimiento.GetColumnValue("Valor Fijo") = False Then
                                    Valor = (tc) * DEmpleado.SalarioxDia
                                    Valor = Math.Round((1 / tc2) * Valor, 2)
                                    'End If
                                Else
                                    'If Me.cbTipoMovimiento.GetColumnValue("Valor Fijo") = False Then
                                    Valor = (tc) * DEmpleado.SalarioxHora
                                    Valor = Math.Round((1 / tc2) * Valor, 2)
                                    'End If
                                End If

                                Valor *= IIf(Me.cbTipoMovimiento.GetColumnValue("Doble") = True, 2, 1)
                                Monto *= Valor
                            Case Else
                                Monto = xmlds.Tables(0).Rows(i)("Monto")
                                Importar.Rows(Importar.Rows.Count - 1)("Monto Original") = 0
                        End Select

                        Importar.Rows(Importar.Rows.Count - 1)("Valor Hora/Dia") = Valor
                        Importar.Rows(Importar.Rows.Count - 1)("Valor a Importar") = Monto
                        Importar.Rows(Importar.Rows.Count - 1)("Valor Cuota") = Math.Round(Monto / Importar.Rows(Importar.Rows.Count - 1)("Cuotas"), 2)


ContinueD:          Next
                    If Errores.Tables(0).Rows.Count <> 0 Then
                        VB.SysContab.RutinasNomina.Exportar_Archivo(Errores.Tables(0), "Errores")
                        dgDetalle.DataSource = Errores.Tables(0)
                        Me.vMensajes.OptionsBehavior.Editable = False

                    End If
                    If Importar.Rows.Count <> 0 Then
                        dgImportar.DataSource = Importar
                        Me.vImportar.Columns("Empleado").ColumnEdit = Me.cbEmpleados
                        Me.vImportar.Columns("Monto Original").Visible = False

                        For z As Integer = 0 To Me.vImportar.Columns.Count - 4
                            Me.vImportar.Columns(z).OptionsColumn.AllowEdit = False
                            Me.vImportar.Columns(z).OptionsColumn.AllowFocus = False
                        Next
                        Me.vImportar.Columns("Importado").OptionsColumn.AllowEdit = False
                        Me.vImportar.Columns("Importado").OptionsColumn.AllowFocus = False

                        Me.vImportar.Columns("Cuotas").ColumnEdit = Me.spCuotas
                        Select Case Me.cbTipoMovimiento.GetColumnValue("Tipo")
                            Case 5, 6
                                Me.vImportar.Columns("Valor Importado").Visible = True
                                Me.vImportar.Columns("Valor Hora/Dia").Visible = True
                                Me.vImportar.Columns("Valor Importado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                Me.vImportar.Columns("Valor Importado").SummaryItem.DisplayFormat = "{0:n2}"
                                Me.vImportar.Columns("Valor Importado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                                Me.vImportar.Columns("Valor Importado").DisplayFormat.FormatString = "{0:n2}"

                                Me.vImportar.Columns("Valor Hora/Dia").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                Me.vImportar.Columns("Valor Hora/Dia").SummaryItem.DisplayFormat = "{0:n2}"
                                Me.vImportar.Columns("Valor Hora/Dia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                                Me.vImportar.Columns("Valor Hora/Dia").DisplayFormat.FormatString = "{0:n2}"

                            Case Else
                                Me.vImportar.Columns("Valor Importado").Visible = False
                                Me.vImportar.Columns("Valor Hora/Dia").Visible = False

                        End Select


                        Me.vImportar.Columns("Valor a Importar").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                        Me.vImportar.Columns("Valor a Importar").SummaryItem.DisplayFormat = "{0:n2}"
                        Me.vImportar.Columns("Valor a Importar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                        Me.vImportar.Columns("Valor a Importar").DisplayFormat.FormatString = "{0:n2}"

                        Me.vImportar.Columns("ID").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                        Me.vImportar.Columns("ID").SummaryItem.DisplayFormat = "{0:n0}"
                        Me.vImportar.BestFitColumns()
                    End If
                    Me.Importar = True
                    Me.cmdLimpiar.Enabled = True
                    Me.cmdAceptar.Text = "Procesar"
                    Me.Refresh()
                Else
                    'Postear el contenido del grid a los ingresos
                    Dim nvoCodigo As String = ""
                    Dim Importados As Integer = 0
                    For x As Integer = 0 To Me.vImportar.DataRowCount - 1
                        If Me.vImportar.GetRowCellValue(x, "Importar") = True Then
                            If VB.SysContab.DeduccionDB.Additem("0", Me.vImportar.GetRowCellValue(x, "Empleado"), _
                                 Now.Date, _
                                 VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal, _
                                 Me.vImportar.GetRowCellValue(x, "Valor a Importar"), _
                                 Me.vImportar.GetRowCellValue(x, "Valor a Importar"), _
                                 IIf(Me.cbTipoMovimiento.GetColumnValue("Tipo") = 2, 1, Me.vImportar.GetRowCellValue(x, "Cuotas")), _
                                 Me.vImportar.GetRowCellValue(x, "Valor Cuota"), _
                                 0.0, _
                                 Me.cbTipoMovimiento.EditValue, _
                                 True, _
                                 IIf(Me.cbTipoMovimiento.GetColumnValue("Tipo") = 2, True, False), _
                                 False, _
                                 Me.cbMoneda.EditValue, _
                                 IIf(Me.cbTipoMovimiento.GetColumnValue("Tipo") = 1, True, False), _
                                 Me.chkNRegular.Checked, _
                                 Me.chkMantenimiento.Checked, _
                                 Me.vImportar.GetRowCellValue(x, "Monto Original"), _
                                 Me.vImportar.GetRowCellValue(x, "Valor Hora/Dia"), _
                                 nvoCodigo, "Origen: Importacion de Archivos") = True Then

                                'Si no hubo error al ingresar el registro, marcarlo en la lista
                                Me.vImportar.SetRowCellValue(x, "Importado", True)
                                Me.vImportar.SetRowCellValue(x, "Importar", False)
                                Importados += 1
                            Else
                                Me.vImportar.SetRowCellValue(x, "Importado", False)
                                Me.vImportar.SetRowCellValue(x, "Importar", True)

                            End If
                        End If
                    Next
                    If Importados <> Me.vImportar.DataRowCount Then
                        MsgBox("No se importaron todos los registros. Favor revise los datos", MsgBoxStyle.Exclamation, "Sts.Nomina")
                    Else
                        Me.Importar = False
                        Me.cmdLimpiar.Enabled = False
                        Me.cmdAceptar.Text = "Aceptar"
                        Me.dgDetalle.DataSource = Nothing
                        Me.dgImportar.DataSource = Nothing
                    End If
                    Dim fArchivo(myStream.Length) As Byte
                    myStream.Read(fArchivo, 0, myStream.Length)
                    VB.SysContab.DocumentosDB.Postear_Archivo(fArchivo, nArchivo, "D", _
                        Me.cbTipoMovimiento.EditValue, Me.cbMoneda.EditValue, Me.dtpDesde.Value, _
                        Me.NCuotas.EditValue, Me.chkNRegular.Checked, Me.chkMantenimiento.Checked)
                    myStream.Close()
                End If


            Case "M"
                'Marcadas de Reloj
                'Dim nArchivo As String
                'Dim myStream As Stream = Nothing
                'Dim Documentos As New VB.SysContab.DocumentosDB()
                Dim UltimoConsecutivo As Integer
                Dim Horas, HExtra As Double
                If Not Importar Then
                    myStream = Nothing
                    Me.OFD.InitialDirectory = Application.StartupPath()

                    Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml"
                    Me.OFD.FilterIndex = 1
                    'Me.OFD.RestoreDirectory = True
                    Select Case Me.cbOrigenReloj.SelectedIndex
                        Case FuenteReloj.Archivo
                            If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                                Try
                                    myStream = Me.OFD.OpenFile()
                                Catch Ex As Exception
                                    MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                                    Exit Sub
                                Finally
                                    ' Check this again, since we need to make sure we didn't throw an exception on open.
                                    If Not IsNothing(myStream) Then
                                        nArchivo = Me.OFD.FileName
                                        'myStream.Close()
                                        xmlds = New DataSet()
                                        Try
                                            If Documentos.Leer_Archivo_Reloj_2(nArchivo, xmlds) = -1 Then
                                                MsgBox("Error al cargar el archivo")
                                            End If
                                        Catch ex1 As Exception
                                            MsgBox(ex1.Message)
                                            Exit Try
                                        End Try

                                        ' Esto lo dejare pendiente para leer desde el xml
                                        'xmlds.ReadXml(narchivo, XmlReadMode.InferSchema)
                                        'Dim relaciones As DataRelationCollection
                                        'relaciones = xmlds.Relations
                                    End If
                                End Try
                            End If
                            If IsNothing(myStream) Then
                                Exit Sub
                            End If
                            ShowSplash()
                        Case FuenteReloj.Conexion
                            '    If Me.txtLogin.Text = "" Then
                            '        MsgBox("Digite su Login para comunicarse con el Servidor del Reloj", MsgBoxStyle.OKOnly, "SysNomina- Login Name error")
                            '        Exit Sub
                            '    End If
                            '    If Me.txtPassword.Text = "" Then
                            '        MsgBox("Digite su Password para comunicarse con el Servidor del Reloj", MsgBoxStyle.OKOnly, "SysNomina- Login Name error")
                            '        Exit Sub
                            '    End If
                            '    xmlds = New DataSet()
                            '    documentos.Reloj(Me.txtLogin.Text, Me.dtpDesde.Value.Date, Me.dtphasta.Value.Date, Me.txtPassword.Text, xmlds)
                        Case Else
                            MsgBox("Seleccione la fuente de registros para las marcas del reloj", MsgBoxStyle.OkOnly, "SysNomina - Error")
                            Exit Sub
                    End Select

                    If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "inss" Then
                        MsgBox("El nombre del campo debe ser <INSS>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "date" Then
                        MsgBox("El nombre del campo debe ser <DATE>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(2).ColumnName.ToLower <> "in" Then
                        MsgBox("El nombre del campo debe ser <IN>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(3).ColumnName.ToLower <> "out" Then
                        MsgBox("El nombre del campo debe ser <OUT>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(4).ColumnName.ToLower <> "lunch" Then
                        MsgBox("El nombre del campo debe ser <LUNCH>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(5).ColumnName.ToLower <> "reghrs" Then
                        MsgBox("El nombre del campo debe ser <REGHRS>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(6).ColumnName.ToLower <> "othrs" Then
                        MsgBox("El nombre del campo debe ser <OTHRS>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                End If
                'Preparar Errores
                Dim Errores As New DataSet()
                Errores = xmlds.Clone()
                If Not Importar Then
                    Errores.Tables(0).Columns.Add("TError")
                    Errores.Tables(0).Columns.Item("TError").DefaultValue = ""
                    xmlds.Tables(0).Columns.Add("TError")
                    xmlds.Tables(0).Columns.Item("TError").DefaultValue = ""
                End If
                Rinicio = CDate(Reloj.GetList_UltimoDomingoProcesado(QuincenaTrabajo, False))
                Rfinal = DateAdd(DateInterval.Day, -1, CDate(Reloj.GetList_DomingoInicioQuincena(QuincenaTrabajo)))
                MsgBox(Rinicio & "-" & Rfinal)
                Me.dtpDesde.Value = Rinicio
                Me.dtphasta.Value = Rfinal
                Dim dsEmpleados As New DataSet()
                Dim Empleados As New VB.SysContab.EmpleadosDB()
                Dim indice As Integer
                dsEmpleados = VB.SysContab.EmpleadosDB.GetLists()
                custDV = New DataView(dsEmpleados.Tables(0), "", "emp_inss", DataViewRowState.CurrentRows)
                Me.Refresh()
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                For i = 0 To xmlds.Tables(0).Rows.Count - 1
                    indice = custDV.Find(xmlds.Tables(0).Rows(i)("inss"))
                    If indice >= 0 Then
                        cEmpleado = custDV.Item(indice).Row.Item("emp_codigo")
                        cLiquidado = custDV.Item(indice).Row.Item("liquidado")
                        cFecha_FinContrato = custDV.Item(indice).Row.Item("emp_ffincontrato").ToString
                    Else
                        cEmpleado = Nothing
                        cLiquidado = Nothing
                        cFecha_FinContrato = Nothing
                    End If
                    'DEmpleado = Empleado.GetDetails_inss(xmlds.Tables(0).Rows(i)("inss"))
                    'cEmpleado = DEmpleado.Codigo
                    If Not Importar Then
                        xmlds.Tables(0).Rows(i)("TError") = "0"
                    End If
                    If cEmpleado Is Nothing Then
                        If Not Importar Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "No se encontro el numero de INSS."
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                        End If
                        GoTo ContinueM
                    End If
                    'Buscar el ultimo registro de reloj para esa fecha
                    UltimoConsecutivo = Reloj.GetList_UltimoReloj(cEmpleado, xmlds.Tables(0).Rows(i)("date"))

                    If Importar Then
                        If xmlds.Tables(0).Rows(i)("TError") = "1" Then
                            GoTo ContinueM
                        End If
                    Else
                        If Not (CDate(xmlds.Tables(0).Rows(i)("date")).Date >= Rinicio And CDate(xmlds.Tables(0).Rows(i)("date")).Date <= Rfinal) Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "La fecha no corresponde al rango permitido"
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                            GoTo ContinueM

                        End If
                        If cLiquidado Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Empleado ha sido liquidado."
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                            GoTo ContinueM
                        End If
                        If cFecha_FinContrato <> "" Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "El empleado esta dado de baja, no se puede ingresar movimientos desde esta herramienta"
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                            GoTo ContinueM
                        End If
                        If Reloj.GetList_BuscarRegistro(cEmpleado, CDate(xmlds.Tables(0).Rows(i)("date")).Date, xmlds.Tables(0).Rows(i)("in"), xmlds.Tables(0).Rows(i)("out")) Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "El registro ya ha sido importado con anterioridad"
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                            GoTo ContinueM
                        End If
                        If UltimoConsecutivo = DEmpresa.CantidadMarcaReloj Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Ya se ingresaro el máximo de registros para este dia y este empleado"
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                            GoTo ContinueM
                        End If
                    End If

                    If Importar Then
                        UltimoConsecutivo += 1
                        Horas = 0.0
                        If xmlds.Tables(0).Rows(i)("reghrs") <> "" And IsNumeric(xmlds.Tables(0).Rows(i)("reghrs")) Then
                            Horas = Horas + CDbl(IIf(xmlds.Tables(0).Rows(i)("reghrs") = "", "0", xmlds.Tables(0).Rows(i)("reghrs")))
                        End If
                        If xmlds.Tables(0).Rows(i)("othrs") <> "" And IsNumeric(xmlds.Tables(0).Rows(i)("othrs")) Then
                            Horas = Horas + CDbl(IIf(xmlds.Tables(0).Rows(i)("othrs") = "", "0", xmlds.Tables(0).Rows(i)("othrs")))
                            HExtra = CDbl(IIf(xmlds.Tables(0).Rows(i)("othrs") = "", "0", xmlds.Tables(0).Rows(i)("othrs")))
                        End If

                        'If Not (xmlds.Tables(0).Rows(i)("in").tolower = "sick" Or _
                        '    xmlds.Tables(0).Rows(i)("out").tolower = "sick" Or _
                        '    xmlds.Tables(0).Rows(i)("in").tolower = "vacation" Or _
                        '    xmlds.Tables(0).Rows(i)("out").tolower = "vacation") Then
                        Reloj.Additem(cEmpleado, _
                            UltimoConsecutivo, _
                            xmlds.Tables(0).Rows(i)("date"), _
                            xmlds.Tables(0).Rows(i)("inss"), _
                            xmlds.Tables(0).Rows(i)("in"), _
                            xmlds.Tables(0).Rows(i)("out"), _
                            Horas, _
                            QuincenaTrabajo, _
                            False, HExtra)

                        'End If
                    End If
                    Me.lblAvance.Text = "Registro " & i & " de " & xmlds.Tables(0).Rows.Count
                    Me.lblAvance.Refresh()
ContinueM:      Next
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                If Importar Then

                    MsgBox("Archivo Importado", MsgBoxStyle.OkOnly, "SysNomina")
                    Me.cmdLimpiar.Enabled = False
                    Me.dgDetalle.DataSource = Nothing
                    Dim fArchivo(myStream.Length) As Byte
                    myStream.Read(fArchivo, 0, myStream.Length)
                    VB.SysContab.DocumentosDB.Postear_Archivo(fArchivo, nArchivo, "M", "", "", Now.Date, _
                        0, False, False)
                    myStream.Close()

                End If
                If Not Importar Then
                    If Errores.Tables(0).Rows.Count <> 0 Then
                        MsgBox("Se han encontrado errores al importar el archivo." & vbCrLf & _
                                "Si desea volver a importar un archivo diferente," & vbCrLf & _
                                "haga click en el botón <Limpiar>, de lo contrario," & vbCrLf & _
                                "haga click en el botón <Importar>, se obviarán los" & vbCrLf & _
                                "registros erroneos", MsgBoxStyle.Information, "SysNomina")
                        VB.SysContab.RutinasNomina.Exportar_Archivo(Errores.Tables(0), "Errores")
                        Me.cmdLimpiar.Enabled = True
                        dgDetalle.DataSource = Errores.Tables(0)

                        ' dgDetalle.CaptionText = "Errores de Importación de Archivos"
                        Me.Refresh()
                    End If
                End If
                Me.cmdAceptar.Text = IIf(Importar, "Analizar", "Importar")
                Importar = Not Importar

            Case "A"

                'Marcadas de Reloj
                'Dim nArchivo As String
                'Dim myStream As Stream = Nothing
                'Dim Documentos As New VB.SysContab.DocumentosDB()
                Dim UltimoConsecutivo As Integer
                Dim Horas, HExtra As Double

                If Not Importar Then

                    myStream = Nothing
                    Me.OFD.InitialDirectory = Application.StartupPath()

                    Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml"
                    Me.OFD.FilterIndex = 1
                    'Me.OFD.RestoreDirectory = True
                    Select Case Me.cbOrigenReloj.SelectedIndex
                        Case FuenteReloj.Archivo
                            If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                                Try
                                    myStream = Me.OFD.OpenFile()
                                Catch Ex As Exception
                                    MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                                    Exit Sub
                                Finally
                                    ' Check this again, since we need to make sure we didn't throw an exception on open.
                                    If Not IsNothing(myStream) Then
                                        nArchivo = Me.OFD.FileName
                                        'myStream.Close()
                                        xmlds = New DataSet()
                                        If Documentos.Leer_Archivo_Reloj(nArchivo, xmlds) = -1 Then
                                            MsgBox("Error al cargar el archivo")
                                        End If
                                        ' Esto lo dejare pendiente para leer desde el xml
                                        'xmlds.ReadXml(narchivo, XmlReadMode.InferSchema)
                                        'Dim relaciones As DataRelationCollection
                                        'relaciones = xmlds.Relations
                                    End If
                                End Try
                            End If
                            If IsNothing(myStream) Then
                                Exit Sub
                            End If
                        Case FuenteReloj.Conexion
                            'Verificar si hay horas extras generadas para deshacerlas
                            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
                            DBConnexion.Open()
                            transaccion = DBConnexion.BeginTransaction

                            Try

                                VB.SysContab.RelojDB.Asistencias_Importar_Reloj(QuincenaTrabajo, True)
                                VB.SysContab.RelojDB.Asistencias_Importar_Reloj(QuincenaTrabajo, False)
                                MsgBox("Archivo Importado", MsgBoxStyle.OkOnly, "SysNomina")
                                VB.SysContab.Rutinas.okTransaccion()

                            Catch ex As Exception

                                VB.SysContab.Rutinas.ErrorTransaccion()
                                MsgBox(ex.Message)

                            End Try
                            Exit Sub
                        Case Else
                            MsgBox("Seleccione la fuente de registros para las marcas del reloj", MsgBoxStyle.OkOnly, "SysNomina - Error")
                            Exit Sub
                    End Select

                    ShowSplash()
                    If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "inss" Then
                        MsgBox("El nombre del campo debe ser <INSS>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "fecha" Then
                        MsgBox("El nombre del campo debe ser <Fecha>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(2).ColumnName.ToLower <> "hr" Then
                        MsgBox("El nombre del campo debe ser <HR>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                    If xmlds.Tables(0).Columns(3).ColumnName.ToLower <> "he" Then
                        MsgBox("El nombre del campo debe ser <HE>", MsgBoxStyle.Critical, "SysNomina")
                        Exit Sub
                    End If
                End If
                'Preparar Errores
                Dim Errores As New DataSet()
                Errores = xmlds.Clone()
                If Not Importar Then
                    Errores.Tables(0).Columns.Add("TError")
                    Errores.Tables(0).Columns.Item("TError").DefaultValue = ""
                    xmlds.Tables(0).Columns.Add("TError")
                    xmlds.Tables(0).Columns.Item("TError").DefaultValue = ""
                End If
                Me.dtpDesde.Value = Rinicio
                Me.dtphasta.Value = Rfinal
                Dim dsEmpleados As New DataSet()
                Dim Empleados As New VB.SysContab.EmpleadosDB()
                Dim indice As Integer
                dsEmpleados = VB.SysContab.EmpleadosDB.GetLists()
                custDV = New DataView(dsEmpleados.Tables(0), "", "emp_inss", DataViewRowState.CurrentRows)
                Me.Refresh()
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                For i = 0 To xmlds.Tables(0).Rows.Count - 1
                    indice = custDV.Find(xmlds.Tables(0).Rows(i)("inss"))
                    If indice >= 0 Then
                        cEmpleado = custDV.Item(indice).Row.Item("emp_codigo")
                        cLiquidado = custDV.Item(indice).Row.Item("liquidado")
                        cFecha_FinContrato = custDV.Item(indice).Row.Item("emp_ffincontrato").ToString
                    Else
                        cEmpleado = Nothing
                        cLiquidado = Nothing
                        cFecha_FinContrato = Nothing
                    End If
                    If Not Importar Then
                        xmlds.Tables(0).Rows(i)("TError") = "0"
                    End If
                    If cEmpleado Is Nothing Then
                        If Not Importar Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "No se encontro el numero de INSS."
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                        End If
                        GoTo ContinueA
                    End If
                    'Buscar el ultimo registro de reloj para esa fecha
                    UltimoConsecutivo = 1 'Reloj.GetList_UltimoReloj(cEmpleado, xmlds.Tables(0).Rows(i)("date"))

                    If Importar Then
                        If xmlds.Tables(0).Rows(i)("TError") = "1" Then
                            GoTo ContinueA
                        End If
                    Else
                        If Not (CDate(xmlds.Tables(0).Rows(i)("fecha")).Date >= Rinicio And CDate(xmlds.Tables(0).Rows(i)("fecha")).Date <= Rfinal) Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "La fecha no corresponde al rango permitido"
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                            GoTo ContinueA

                        End If
                        If cLiquidado Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Empleado ha sido liquidado."
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                            GoTo ContinueA
                        End If
                        If cFecha_FinContrato <> "" Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "El empleado esta dado de baja, no se puede ingresar movimientos desde esta herramienta"
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                            GoTo ContinueA
                        End If
                        If Reloj.GetList_BuscarRegistro(cEmpleado, CDate(xmlds.Tables(0).Rows(i)("fecha")).Date, "", "") Then
                            Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                            Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "El registro ya ha sido importado con anterioridad"
                            xmlds.Tables(0).Rows(i)("TError") = "1"
                            GoTo ContinueA
                        End If
                        'If UltimoConsecutivo = DEmpresa.CantidadMarcaReloj Then
                        '    Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                        '    Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Ya se ingresaro el máximo de registros para este dia y este empleado"
                        '    xmlds.Tables(0).Rows(i)("TError") = "1"
                        '    GoTo ContinueA
                        'End If
                    End If

                    If Importar Then
                        UltimoConsecutivo += 1
                        Horas = 0.0
                        HExtra = 0.0
                        If xmlds.Tables(0).Rows(i)("hr") <> "" And IsNumeric(xmlds.Tables(0).Rows(i)("hr")) Then
                            Horas = Horas + CDbl(IIf(xmlds.Tables(0).Rows(i)("hr") = "", "0", xmlds.Tables(0).Rows(i)("hr")))
                        End If
                        If xmlds.Tables(0).Rows(i)("he") <> "" And IsNumeric(xmlds.Tables(0).Rows(i)("he")) Then
                            'Horas = Horas + CDbl(IIf(xmlds.Tables(0).Rows(i)("he") = "", "0", xmlds.Tables(0).Rows(i)("he")))
                            HExtra = HExtra + CDbl(IIf(xmlds.Tables(0).Rows(i)("he") = "", "0", xmlds.Tables(0).Rows(i)("he")))
                        End If

                        'If Not (xmlds.Tables(0).Rows(i)("in").tolower = "sick" Or _
                        '    xmlds.Tables(0).Rows(i)("out").tolower = "sick" Or _
                        '    xmlds.Tables(0).Rows(i)("in").tolower = "vacation" Or _
                        '    xmlds.Tables(0).Rows(i)("out").tolower = "vacation") Then

                        ''xmlds.Tables(0).Rows(i)("hr"), 
                        ''xmlds.Tables(0).Rows(i)("he"), 
                        Reloj.Additem(cEmpleado, _
                            UltimoConsecutivo, _
                            xmlds.Tables(0).Rows(i)("fecha"), _
                            xmlds.Tables(0).Rows(i)("inss"), _
                            "", _
                            "", _
                            Horas, _
                            QuincenaTrabajo, _
                            False, HExtra)

                        'End If
                    End If
                    Me.lblAvance.Text = "Registro " & i & " de " & xmlds.Tables(0).Rows.Count
                    Me.lblAvance.Refresh()
ContinueA:      Next
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                If Importar Then
                    MsgBox("Archivo Importado", MsgBoxStyle.OkOnly, "SysNomina")
                    Me.cmdLimpiar.Enabled = False
                    Me.dgDetalle.DataSource = Nothing
                    Dim fArchivo(myStream.Length) As Byte
                    myStream.Read(fArchivo, 0, myStream.Length)
                    VB.SysContab.DocumentosDB.Postear_Archivo(fArchivo, nArchivo, "A", "", "", Now.Date, 0, False, False)
                    myStream.Close()
                End If
                If Not Importar Then
                    If Errores.Tables(0).Rows.Count <> 0 Then
                        MsgBox("Se han encontrado errores al importar el archivo." & vbCrLf & _
                                "Si desea volver a importar un archivo diferente," & vbCrLf & _
                                "haga click en el botón <Limpiar>, de lo contrario," & vbCrLf & _
                                "haga click en el botón <Importar>, se obviarán los" & vbCrLf & _
                                "registros erroneos", MsgBoxStyle.Information, "SysNomina")
                        VB.SysContab.RutinasNomina.Exportar_Archivo(Errores.Tables(0), "Errores")
                        Me.cmdLimpiar.Enabled = True
                        dgDetalle.DataSource = Errores.Tables(0)
                        'dgDetalle.CaptionText = "Errores de Importación de Archivos"
                        Me.Refresh()
                    End If
                End If
                Me.cmdAceptar.Text = IIf(Importar, "Analizar", "Importar")
                Importar = Not Importar

            Case "T"
                ''Tasa de Cambio
                'Dim nArchivo As String
                'Dim myStream As Stream = Nothing
                'Dim Documentos As New VB.SysContab.DocumentosDB()
                myStream = Nothing
                Me.OFD.InitialDirectory = Application.StartupPath()

                Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
                Me.OFD.FilterIndex = 1
                'Me.OFD.RestoreDirectory = True

                If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Try
                        myStream = Me.OFD.OpenFile()
                    Catch Ex As Exception
                        MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                        Exit Sub
                    Finally
                        ' Check this again, since we need to make sure we didn't throw an exception on open.
                        If Not IsNothing(myStream) Then
                            nArchivo = Me.OFD.FileName
                            'myStream.Close()
                            xmlds = New DataSet()
                            If Documentos.Leer_Archivo(nArchivo, xmlds) = -1 Then  'xmlds =VB.SysContab.RutinasNomina.LeerXML(nArchivo)
                                MsgBox("Error al cargar el archivo")
                            End If
                        End If
                    End Try
                End If
                If IsNothing(myStream) Then
                    Exit Sub
                End If
                ShowSplash()
                If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "fecha" Then
                    MsgBox("El nombre del primer campo debe ser <Fecha>", MsgBoxStyle.Critical, "SysNomina")
                    Exit Sub
                End If
                If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "valor" Then
                    MsgBox("El nombre del segundo campo debe ser <Valor>", MsgBoxStyle.Critical, "SysNomina")
                    Exit Sub
                End If

                Dim Errores As New DataSet()
                Errores = xmlds.Clone()
                Errores.Tables(0).Columns.Add("TError")
                For i = 0 To xmlds.Tables(0).Rows.Count - 1
                    If Not IsDate(xmlds.Tables(0).Rows(i)("fecha")) Then
                        Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                        Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Fecha Inválida"
                        GoTo ContinueT
                    End If
                    If Not IsNumeric(xmlds.Tables(0).Rows(i)("valor")) Then
                        Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                        Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Numero de formato inválido"
                        GoTo ContinueT
                    End If
                    dTC = TC.GetDetails(DEmpresa.MONEDABASE, Me.cbMonedaTC.EditValue, _
                             DatePart(DateInterval.Day, xmlds.Tables(0).Rows(i)("fecha")), _
                             DatePart(DateInterval.Month, xmlds.Tables(0).Rows(i)("fecha")), _
                             DatePart(DateInterval.Year, xmlds.Tables(0).Rows(i)("fecha")))
                    If dTC.MonedaBase Is Nothing Then
                        'no lo encontro
                        TC.Additem(DEmpresa.MONEDABASE, Me.cbMonedaTC.EditValue, _
                             DatePart(DateInterval.Day, xmlds.Tables(0).Rows(i)("fecha")), _
                             DatePart(DateInterval.Month, xmlds.Tables(0).Rows(i)("fecha")), _
                             DatePart(DateInterval.Year, xmlds.Tables(0).Rows(i)("fecha")), _
                             xmlds.Tables(0).Rows(i)("valor"))
                    Else
                        Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                        Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "La tasa de cambio ya ha sido ingresada para este dia"
                        GoTo ContinueT
                    End If

ContinueT:      Next
                MsgBox("Archivo Importado", MsgBoxStyle.OkOnly, "SysNomina")
                Dim fArchivo(myStream.Length) As Byte
                myStream.Read(fArchivo, 0, myStream.Length)
                VB.SysContab.DocumentosDB.Postear_Archivo(fArchivo, nArchivo, "T", "", _
                    Me.cbMonedaTC.EditValue, _
                    New Date(Me.cbAños.EditValue, Me.cbMeses.SelectedIndex + 1, 1), _
                    0, False, False)
                myStream.Close()
                If Errores.Tables(0).Rows.Count <> 0 Then
                    VB.SysContab.RutinasNomina.Exportar_Archivo(Errores.Tables(0), "Errores")

                    dgDetalle.DataSource = Errores.Tables(0).DefaultView
                    'dgDetalle.CaptionText = "Errores de Importación de Archivos"
                    Me.Refresh()

                End If
            Case Else

        End Select
        HideSplash()
    End Sub

    Private Sub cbTipo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipo.EditValueChanged
        Me.dgDetalle.DataSource = Nothing
        Me.dgImportar.DataSource = Nothing

        Select Case Microsoft.VisualBasic.Left(Me.cbTipo.SelectedItem, 1)

            Case "I" 'ingresos del empleado
                Me.etTipoMov.Text = "Tipos de Ingresos"
                Me.cbTipoMovimiento.Properties.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables(0)
                Me.cbTipoMovimiento.Properties.ValueMember = "Codigo"
                Me.cbTipoMovimiento.Properties.DisplayMember = "Descripcion"

                Me.etCuotas.Visible = False
                Me.NCuotas.Visible = False

                Me.lblOrigenReloj.Visible = False
                Me.cbOrigenReloj.Visible = False

                Me.cmdAceptar.Text = "Aceptar"
                Me.Importar = False
                Me.cmdLimpiar.Enabled = False

                Me.gbTasaCambio.Visible = False
                Me.mytimeweb.Visible = False
                Me.gbIngresos.Visible = True
                Me.cmdAceptar.Text = "Analizar"

                Me.chkMantenimiento.Visible = False
                Me.chkMantenimiento.Checked = False

            Case "D" 'deducciones / egresos del empleado
                Me.etTipoMov.Text = "Tipos de Deducciones"

                Me.cbTipoMovimiento.Properties.DataSource = VB.SysContab.TipoDeduccionDB.GetList(IIf(Me.NCuotas.Value = 1, "U", "P"))
                Me.cbTipoMovimiento.Properties.ValueMember = "Codigo"
                Me.cbTipoMovimiento.Properties.DisplayMember = "Descripcion"

                Me.etCuotas.Visible = True
                Me.NCuotas.Visible = True

                Me.cbOrigenReloj.Visible = False
                Me.lblOrigenReloj.Visible = False

                Me.cmdAceptar.Text = "Analizar"
                Me.Importar = False
                Me.cmdLimpiar.Enabled = False

                Me.gbTasaCambio.Visible = False
                Me.mytimeweb.Visible = False
                Me.gbIngresos.Visible = True

                Me.chkMantenimiento.Visible = True
                Me.chkMantenimiento.Checked = False


            Case "M"  'Marcadas de Reloj
                'Me.gbIngresos.Enabled = False
                Me.lblOrigenReloj.Visible = True
                Me.cbOrigenReloj.Visible = True

                Importar = False
                Me.cmdAceptar.Text = "Analizar"
                Me.cmdLimpiar.Enabled = False
                Me.gbTasaCambio.Visible = False

                Me.mytimeweb.Visible = True
                Me.gbIngresos.Visible = False
                Me.mytimeweb.Enabled = False

            Case "A" 'Marcadas de Reloj EPPA
                'Me.gbIngresos.Enabled = False
                Me.lblOrigenReloj.Visible = True
                Me.cbOrigenReloj.Visible = True
                Me.mytimeweb.Visible = True
                Me.mytimeweb.Enabled = False
                Importar = False
                Me.cmdAceptar.Text = "Analizar"
                Me.cmdLimpiar.Enabled = False
                Me.gbTasaCambio.Visible = False
                Me.gbIngresos.Visible = False
            Case "T" 'Tasas de Cambio
                Me.mytimeweb.Visible = False
                Me.gbIngresos.Visible = False
                Me.cbOrigenReloj.Visible = False
                Me.lblOrigenReloj.Visible = False
                Me.gbTasaCambio.Visible = True
                Me.cbMeses.SelectedIndex = Month(Now.Date) - 1
                Me.cbAños.EditValue = Year(Now.Date).ToString
            Case Else
        End Select
    End Sub

    Private Sub NCuotas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NCuotas.ValueChanged
        Select Case Microsoft.VisualBasic.Left(Me.cbTipo.SelectedItem, 1)
            Case "I"
                Me.etTipoMov.Text = "Tipos de Ingresos"
                Me.cbTipoMovimiento.Properties.DataSource = VB.SysContab.TipoIngresoDB.GetList(IIf(Me.NCuotas.Value = 1, "U", "P")).Tables("TipoIngreso")
                Me.cbTipoMovimiento.Properties.ValueMember = "Codigo"
                Me.cbTipoMovimiento.Properties.DisplayMember = "Descripcion"
                Me.etCuotas.Visible = False
                Me.NCuotas.Visible = False
            Case "D"
                Me.etTipoMov.Text = "Tipos de Deducciones"
                Me.cbTipoMovimiento.Properties.DataSource = VB.SysContab.TipoDeduccionDB.GetList(IIf(Me.NCuotas.Value = 1, "U", "P"))
                Me.cbTipoMovimiento.Properties.ValueMember = "Codigo"
                Me.cbTipoMovimiento.Properties.DisplayMember = "Descripcion"
                Me.etCuotas.Visible = True
                Me.NCuotas.Visible = True
            Case "M"
            Case Else
        End Select
    End Sub

    Private Sub cbOrigenReloj_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbOrigenReloj.SelectedIndexChanged
        If Me.cbOrigenReloj.SelectedIndex = FuenteReloj.Conexion Then
            Me.mytimeweb.Enabled = True
        Else
            Me.mytimeweb.Enabled = False
        End If
    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        Importar = False
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdLimpiar.Enabled = False
        dgDetalle.DataSource = Nothing
        Me.dgImportar.DataSource = Nothing
        Me.Refresh()
    End Sub

    Private Sub cbMoneda_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMoneda.EditValueChanged
        Dim tc As Double
        If Me.MonedaAnterior = "" Then
            Me.MonedaAnterior = Me.cbMoneda.EditValue
        End If
        tc = VB.SysContab.Tasa_CambioDB.TasaCambioDia( _
           VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Day, _
           VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Month, _
           VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Year, _
           Me.MonedaBase, _
           IIf(MonedaAnterior <> MonedaBase, MonedaAnterior, Me.cbMoneda.EditValue))

        Dim factor As Double
        factor = IIf(MonedaAnterior <> MonedaBase, tc, (1 / tc))
        For i As Integer = 0 To Me.vImportar.DataRowCount - 1
            Me.vImportar.SetRowCellValue(i, "Valor", Math.Round(Me.vImportar.GetRowCellValue(i, "Valor") * factor, 2))
            Me.vImportar.SetRowCellValue(i, "Monto", Math.Round(Me.vImportar.GetRowCellValue(i, "Monto") * factor, 2))
            If Microsoft.VisualBasic.Left(Me.cbTipo.SelectedItem, 1) = "D" Then
                Me.vImportar.SetRowCellValue(i, "Monto", Math.Round(Me.vImportar.GetRowCellValue(i, "Valor Cuota") * factor, 2))
            End If
        Next
        MonedaAnterior = Me.cbMoneda.EditValue
    End Sub

    Private Sub NCuotas_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NCuotas.EditValueChanged

        If Me.NCuotas.EditValue <= 0 Then
            Me.NCuotas.EditValue = 1
            Exit Sub
        End If
        For i As Integer = 0 To Me.vImportar.DataRowCount - 1
            Me.vImportar.SetRowCellValue(i, "Cuotas", Me.NCuotas.EditValue)
        Next
    End Sub

    Private Sub cbTipoMovimiento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoMovimiento.EditValueChanged
        Me.dgImportar.DataSource = Nothing
        Me.dgDetalle.DataSource = Nothing

        Select Case Microsoft.VisualBasic.Left(Me.cbTipo.SelectedItem, 1)

            Case "I" 'ingresos del empleado
                Me.etTipoMov.Text = "Tipos de Ingresos"
                Me.cbTipoMovimiento.Properties.DataSource = VB.SysContab.TipoIngresoDB.GetList("%").Tables(0)
                Me.cbTipoMovimiento.Properties.ValueMember = "Codigo"
                Me.cbTipoMovimiento.Properties.DisplayMember = "Descripcion"

                Me.etCuotas.Visible = False
                Me.NCuotas.Visible = False

                Me.lblOrigenReloj.Visible = False
                Me.cbOrigenReloj.Visible = False

                Me.cmdAceptar.Text = "Aceptar"
                Me.Importar = False
                Me.cmdLimpiar.Enabled = False

                Me.gbTasaCambio.Visible = False
                Me.mytimeweb.Visible = False
                Me.gbIngresos.Visible = True
                Me.cmdAceptar.Text = "Analizar"

                Me.chkMantenimiento.Visible = False
                Me.chkMantenimiento.Checked = False


            Case "D" 'deducciones / egresos del empleado
                Me.etTipoMov.Text = "Tipos de Deducciones"

                Me.cbTipoMovimiento.Properties.DataSource = VB.SysContab.TipoDeduccionDB.GetList(IIf(Me.NCuotas.Value = 1, "U", "P"))
                Me.cbTipoMovimiento.Properties.ValueMember = "Codigo"
                Me.cbTipoMovimiento.Properties.DisplayMember = "Descripcion"

                Me.etCuotas.Visible = True
                Me.NCuotas.Visible = True

                Me.cbOrigenReloj.Visible = False
                Me.lblOrigenReloj.Visible = False

                Me.cmdAceptar.Text = "Analizar"
                Me.Importar = False
                Me.cmdLimpiar.Enabled = False

                Me.gbTasaCambio.Visible = False
                Me.mytimeweb.Visible = False
                Me.gbIngresos.Visible = True

                Me.chkMantenimiento.Visible = True
                Me.chkMantenimiento.Checked = False

        End Select

    End Sub

    Private Sub vImportar_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vImportar.CellValueChanged

        Select Case Microsoft.VisualBasic.Left(Me.cbTipo.SelectedItem, 1)
            Case "D" 'ingresos del empleado
                If e.Column.FieldName = "Cuotas" Then
                    Me.vImportar.SetRowCellValue(e.RowHandle, Me.vImportar.Columns("Valor Cuota"), _
                        Math.Round(Me.vImportar.GetRowCellValue(e.RowHandle, Me.vImportar.Columns("Valor a Importar")) / _
                         e.Value, 2))

                End If
        End Select

    End Sub

    
    Private Sub cmdVerHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerHistorico.Click
        Dim f As New frmImportacion_Archivos
        f.ShowDialog()
    End Sub
End Class