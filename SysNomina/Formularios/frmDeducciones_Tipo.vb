Public Class frmDeducciones_Tipo
#Region "Variables"
    Dim DT As New DataTable
#End Region
    Private Sub frmDeducciones_Tipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ceMontoGeneral.EditValue = 0.0
        Me.ceCuotas.EditValue = 1
        DT.Columns.Add("Empleado", System.Type.GetType("System.String"), "")

        Dim Valor As New DataColumn
        Valor.ColumnName = "Valor"
        Valor.DataType = System.Type.GetType("System.Double")
        Valor.AllowDBNull = False
        Valor.DefaultValue = 0.0
        DT.Columns.Add(Valor)

        DT.Columns.Add("Monto", System.Type.GetType("System.Double"), "")

        Dim Cuota As New DataColumn
        Cuota.ColumnName = "Cuota"
        Cuota.DataType = System.Type.GetType("System.Int32")
        Cuota.AllowDBNull = False
        Cuota.DefaultValue = 1
        DT.Columns.Add(Cuota)

        Dim Comentarios As New DataColumn
        Comentarios.ColumnName = "ptm_comentarios"
        Comentarios.DataType = System.Type.GetType("System.String")
        Comentarios.AllowDBNull = False
        Comentarios.DefaultValue = ""
        DT.Columns.Add(Comentarios)

        
        Me.cbFormaPago.Properties.DataSource = VB.SysContab.EmpleadosDB.GetFormaPagoEmpleados
        Me.cbFormaPago.Properties.DisplayMember = "descripcion"
        Me.cbFormaPago.Properties.ValueMember = "codigo"
        Me.cbFormaPago.EditValue = QuincenaTrabajo.Substring(0, 1)

        Me.dgDeducciones.DataSource = DT
        Me.VDeducciones.Columns("Empleado").Width = 250
        Me.VDeducciones.Columns("Monto").Width = 150
        Me.VDeducciones.Columns("Cuota").Width = 100
        Me.VDeducciones.Columns("Valor").Width = 100
        Me.VDeducciones.Columns("Valor").Visible = False

        Me.VDeducciones.Columns("Empleado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.VDeducciones.Columns("Empleado").SummaryItem.DisplayFormat = "{0:n0}"

        Me.VDeducciones.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VDeducciones.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"
        Me.VDeducciones.Columns("Monto").DisplayFormat.FormatString = "n2"
        Me.VDeducciones.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        Me.VDeducciones.Columns("Valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VDeducciones.Columns("Valor").SummaryItem.DisplayFormat = "{0:n2}"
        Me.VDeducciones.Columns("Valor").DisplayFormat.FormatString = "n2"
        Me.VDeducciones.Columns("Valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric


        Me.cbTipoDeduccion.Properties.DataSource = VB.SysContab.TipoDeduccionDB.GetList("%")
        Me.cbTipoDeduccion.Properties.DisplayMember = "Descripcion"
        Me.cbTipoDeduccion.Properties.ValueMember = "Codigo"

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetLists().Tables(0)
        Me.cbEmpleados.DisplayMember = "nombre"
        Me.cbEmpleados.ValueMember = "emp_codigo"

        Me.cbMoneda.Properties.DataSource = VB.SysContab.MonedaDB.GetList().Tables(0)
        Me.cbMoneda.Properties.DisplayMember = "Descripcion"
        Me.cbMoneda.Properties.ValueMember = "Codigo"

        Me.chkMantenimiento.Visible = Mantenimiento_Deduccion
        Me.lblMantenimiento.Visible = Mantenimiento_Deduccion


        Me.dgDeducciones.Enabled = False
        Me.chkRegular.EditValue = True
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.cbTipoDeduccion.EditValue = "" Or Me.cbTipoDeduccion.EditValue Is Nothing Then
            MsgBox("Seleccione el tipo de deducci�n", MsgBoxStyle.Exclamation, "Sts.Nomina")
            Exit Sub
        End If
        If Me.cbMoneda.EditValue = "" Or Me.cbMoneda.EditValue Is Nothing Then
            MsgBox("Seleccione la moneda", MsgBoxStyle.Exclamation, "Sts.Nomina")
            Exit Sub
        End If
        'Tipo 1: Valor se pone en Nomina (Unico)
        'Tipo 2: Valor se pone en Fijo (Cuota Fija)
        'Tipo 3: Valor se resta de Monto (# de Cuotas)
        'Tipo 4: Porcentaje de Ingresos --No se usa
        'Tipo 5: Depende de pago por Dia
        'Tipo 6: Depende de pago por Hora
        'Tipo 7: Depende del factor/formula
        Dim Monto, Valor As Double
        Dim nvoCodigo As String = ""
        For i As Integer = 0 To Me.VDeducciones.DataRowCount - 1
            Valor = 1
            Monto = 0
            Select Case Me.cbTipoDeduccion.GetColumnValue("Tipo")
                Case 5, 6, 7
                    If Me.cbTipoDeduccion.GetColumnValue("Tipo") = 5 Then
                        Monto = Me.VDeducciones.GetRowCellValue(i, "Monto")
                        If Me.cbTipoDeduccion.GetColumnValue("Valor Fijo") = False Then
                            Valor = Math.Round(Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("SalarioxDia"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetRowCellValue(i, "Empleado"))) * _
                                    VB.SysContab.Tasa_CambioDB.TasaCambioDia( _
                                        VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Day, _
                                        VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Month, _
                                        VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Year, _
                                        Me.cbMoneda.EditValue, _
                                        Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("mon_codigo"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetRowCellValue(i, "Empleado")))), 2)
                        Else
                            Valor = Me.VDeducciones.GetRowCellValue(i, "Valor")
                        End If
                    ElseIf Me.cbTipoDeduccion.GetColumnValue("Tipo") = 6 Then
                        Monto = Me.VDeducciones.GetRowCellValue(i, "Monto")
                        If Me.cbTipoDeduccion.GetColumnValue("Valor Fijo") = False Then
                            Valor = Math.Round(Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("SalarioxHora"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetRowCellValue(i, "Empleado"))) * _
                                    VB.SysContab.Tasa_CambioDB.TasaCambioDia( _
                                        VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Day, _
                                        VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Month, _
                                        VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Year, _
                                        Me.cbMoneda.EditValue, _
                                        Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("mon_codigo"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetRowCellValue(i, "Empleado")))), 2)
                        Else
                            Valor = Me.VDeducciones.GetRowCellValue(i, "Valor")
                        End If
                    Else
                        Monto = Me.VDeducciones.GetRowCellValue(i, "Monto")
                        Valor = Me.VDeducciones.GetRowCellValue(i, "Valor")

                    End If
                    Monto *= Valor
                    If Monto > 0 Then
                        VB.SysContab.DeduccionDB.Additem("0", Me.VDeducciones.GetRowCellValue(i, "Empleado"), _
                                               Now.Date, _
                                               VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal, _
                                               Math.Round(Monto, 2), _
                                               Math.Round(Monto, 2), _
                                               IIf(Me.cbTipoDeduccion.GetColumnValue("Tipo") = 2, 1, Me.VDeducciones.GetRowCellValue(i, "Cuota")), _
                                               Math.Round(Math.Round(Monto, 2) / Me.VDeducciones.GetRowCellValue(i, "Cuota"), 2), _
                                               0.0, _
                                               Me.cbTipoDeduccion.EditValue, _
                                               True, _
                                               IIf(Me.cbTipoDeduccion.GetColumnValue("Tipo") = 2, True, False), _
                                               False, _
                                                Me.cbMoneda.EditValue, _
                                               IIf(Me.cbTipoDeduccion.GetColumnValue("Tipo") = 1, True, False), _
                                                Me.chkRegular.EditValue, _
                                               Me.chkMantenimiento.Checked, _
                                               Me.VDeducciones.GetRowCellValue(i, "Monto"), _
                                               Valor, _
                                               nvoCodigo,
                                               Me.VDeducciones.GetRowCellValue(i, "ptm_comentarios"))
                    End If


                Case Else
                    Monto = Me.VDeducciones.GetRowCellValue(i, "Monto")
                    If Monto > 0 Then
                        VB.SysContab.DeduccionDB.Additem("0", Me.VDeducciones.GetRowCellValue(i, "Empleado"), _
                                                    Now.Date, _
                                                    VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal, _
                                                    Monto, _
                                                    Monto, _
                                                    IIf(Me.cbTipoDeduccion.GetColumnValue("Tipo") = 2, 1, Me.VDeducciones.GetRowCellValue(i, "Cuota")), _
                                                    Math.Round(Monto / Me.VDeducciones.GetRowCellValue(i, "Cuota"), 2), _
                                                    0.0, _
                                                    Me.cbTipoDeduccion.EditValue, _
                                                    True, _
                                                    IIf(Me.cbTipoDeduccion.GetColumnValue("Tipo") = 2, True, False), _
                                                    False, _
                                                    Me.cbMoneda.EditValue, _
                                                    IIf(Me.cbTipoDeduccion.GetColumnValue("Tipo") = 1, True, False), _
                                                    True, _
                                                    Me.chkMantenimiento.Checked, _
                                                    0, 0, _
                                                    nvoCodigo, _
                                                    Me.VDeducciones.GetRowCellValue(i, "ptm_comentarios"))
                    End If

            End Select
        Next
        Me.Close()
    End Sub

    Private Sub cbTipoDeduccion_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoDeduccion.EditValueChanged
        If Me.cbTipoDeduccion.Properties.DataSource Is DBNull.Value Then
            Me.dgDeducciones.Enabled = False
            Exit Sub
        Else

            If Me.cbTipoDeduccion.GetColumnValue("Valor Fijo") = True Then
                Me.VDeducciones.Columns("Valor").Visible = True
            Else
                If Me.cbTipoDeduccion.GetColumnValue("Tipo") = 7 Then
                    Me.VDeducciones.Columns("Valor").Visible = True
                Else
                    Me.VDeducciones.Columns("Valor").Visible = False
                End If

            End If
            For i As Integer = 0 To Me.VDeducciones.DataRowCount - 1
                If Me.cbTipoDeduccion.GetColumnValue("Tipo") <> 3 Then
                    Me.VDeducciones.SetFocusedRowCellValue(Me.VDeducciones.Columns("Cuota"), 1)
                End If
            Next



            Select Case Me.cbTipoDeduccion.GetColumnValue("Tipo")
                Case 3
                    Me.spCuotas.MaxValue = 120
                    Me.spCuotas.ReadOnly = False
                    Me.VDeducciones.Columns("Monto").Caption = "Monto"
                Case 5
                    Me.spCuotas.MaxValue = 1
                    Me.spCuotas.ReadOnly = True
                    Me.VDeducciones.Columns("Monto").Caption = "Salario por Dia"
                Case 6
                    Me.spCuotas.MaxValue = 1
                    Me.spCuotas.ReadOnly = True
                    Me.VDeducciones.Columns("Monto").Caption = "Salario por Hora"
                Case 7
                    Me.spCuotas.MaxValue = 1
                    Me.spCuotas.ReadOnly = True
                    Me.VDeducciones.Columns("Valor").Caption = "Factor"
                Case Else
                    Me.spCuotas.MaxValue = 1
                    Me.spCuotas.ReadOnly = True
                    Me.VDeducciones.Columns("Monto").Caption = "Monto"
            End Select
            Me.dgDeducciones.Enabled = True

        End If
    End Sub

    Private Sub VDeducciones_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles VDeducciones.BeforeLeaveRow
        If Me.VDeducciones.GetFocusedRowCellValue("Empleado") Is DBNull.Value Then
            Me.VDeducciones.DeleteRow(Me.VDeducciones.FocusedRowHandle)
        Else
            If Me.VDeducciones.GetFocusedRowCellValue("Empleado") = "" Or Me.VDeducciones.GetFocusedRowCellValue("Empleado") Is Nothing Then
                Me.VDeducciones.DeleteRow(Me.VDeducciones.FocusedRowHandle)
            End If

        End If
    End Sub

    Private Sub VDeducciones_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VDeducciones.CellValueChanged
        If e.Column.FieldName = "Empleado" Then
            'Buscar el empleado en la tabla
            If DT.Compute("Count(Empleado)", "Empleado = '" & Me.VDeducciones.GetFocusedRowCellValue("Empleado") & "'") >= 1 Then
                MsgBox("Ya esta en la lista el empleado", MsgBoxStyle.Critical, "Sts.Nomina")
                Me.VDeducciones.DeleteRow(Me.VDeducciones.FocusedRowHandle)
            End If
            If Me.cbTipoDeduccion.GetColumnValue("Tipo") = 5 Then
                Me.VDeducciones.SetFocusedRowCellValue(Me.VDeducciones.Columns("Valor"), _
                    Math.Round(Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("SalarioxDia"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetFocusedRowCellValue("Empleado"))) * _
                    VB.SysContab.Tasa_CambioDB.TasaCambioDia( _
                    VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Day, _
                    VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Month, _
                    VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Year, _
                    Me.cbMoneda.EditValue, _
                    Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("mon_codigo"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetFocusedRowCellValue("Empleado")))) _
                    , 2))
                Me.VDeducciones.Columns("Valor").OptionsColumn.AllowEdit = True
            ElseIf Me.cbTipoDeduccion.GetColumnValue("Tipo") = 6 Then
                Me.VDeducciones.SetFocusedRowCellValue(Me.VDeducciones.Columns("Valor"), _
                    Math.Round(Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("SalarioxHora"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetFocusedRowCellValue("Empleado"))) * _
                    VB.SysContab.Tasa_CambioDB.TasaCambioDia( _
                    VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Day, _
                    VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Month, _
                    VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo).FFinal.Year, _
                    Me.cbMoneda.EditValue, _
                    Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("mon_codigo"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetFocusedRowCellValue("Empleado")))) _
                    , 2))
                Me.VDeducciones.Columns("Valor").OptionsColumn.AllowEdit = True
            ElseIf Me.cbTipoDeduccion.GetColumnValue("Tipo") = 7 Then
                Me.VDeducciones.SetFocusedRowCellValue(Me.VDeducciones.Columns("Valor"), _
                   Me.cbTipoDeduccion.GetColumnValue("Factor"))
                Me.VDeducciones.Columns("Valor").OptionsColumn.AllowEdit = True
            Else
                Me.VDeducciones.SetFocusedRowCellValue(Me.VDeducciones.Columns("Valor"), 0.0)
                Me.VDeducciones.Columns("Valor").OptionsColumn.AllowEdit = False
            End If
        End If
    End Sub


    Private Sub dgDeducciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDeducciones.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.VDeducciones.DeleteRow(Me.VDeducciones.FocusedRowHandle)
        End If

    End Sub


    Private Sub cbMoneda_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMoneda.EditValueChanged
        If Me.cbMoneda.EditValue <> VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MONEDABASE Then
            Me.chkMantenimiento.Enabled = True
        Else
            Me.chkMantenimiento.Enabled = False
            Me.chkMantenimiento.Checked = False
        End If
    End Sub

  
    'Private Sub cbEmpleados_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEmpleados.EditValueChanged
    '    If Me.cbTipoDeduccion.GetColumnValue("Tipo") = 5 Then
    '        Me.VDeducciones.SetFocusedRowCellValue(Me.VDeducciones.Columns("Valor"), _
    '            Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("SalarioxDia"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetFocusedRowCellValue("Empleado"))))
    '        Me.VDeducciones.Columns("Valor").OptionsColumn.AllowEdit = True
    '    ElseIf Me.cbTipoDeduccion.GetColumnValue("Tipo") = 6 Then
    '        Me.VDeducciones.SetFocusedRowCellValue(Me.VDeducciones.Columns("Valor"), _
    '            Me.cbEmpleados.GetDataSourceValue(Me.cbEmpleados.Columns("SalarioxHora"), Me.cbEmpleados.GetDataSourceRowIndex("emp_codigo", Me.VDeducciones.GetFocusedRowCellValue("Empleado"))))
    '        Me.VDeducciones.Columns("Valor").OptionsColumn.AllowEdit = True
    '    Else
    '        Me.VDeducciones.SetFocusedRowCellValue(Me.VDeducciones.Columns("Valor"), 0.0)
    '        Me.VDeducciones.Columns("Valor").OptionsColumn.AllowEdit = False
    '    End If
    'End Sub

    Private Sub chkEmpleados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmpleados.CheckedChanged
        If Me.chkEmpleados.EditValue = True And Me.dgDeducciones.Enabled = True Then
            Select Case Me.cbTipoDeduccion.GetColumnValue("Tipo")
                Case 4, 5, 6
                    MsgBox("Esta herramienta no funciona para ingresos que dependan del salario del empleado.")
                    Exit Sub
            End Select

            If Me.ceCuotas.EditValue = 0 Then
                MsgBox("Digite el numero de cuotas por favor")
                Exit Sub
            End If

            DT.Clear()
            Dim fila As DataRow = DT.NewRow
            For i As Integer = 0 To Me.cbEmpleados.DataSource.rows.count - 1
                If Me.cbEmpleados.DataSource.rows(i)("emp_ffincontrato") Is DBNull.Value Then
                    If Me.cbEmpleados.DataSource.rows(i)("emp_formapago") = IIf(Me.cbFormaPago.EditValue = "%", Me.cbEmpleados.DataSource.rows(i)("emp_formapago"), Me.cbFormaPago.EditValue) Then
                        fila("Empleado") = Me.cbEmpleados.DataSource.rows(i)("emp_codigo")
                        fila("Valor") = IIf(Me.cbTipoDeduccion.GetColumnValue("Tipo") = 7, Me.cbTipoDeduccion.GetColumnValue("Factor"), Me.ceMontoGeneral.EditValue)
                        fila("Monto") = Me.ceMontoGeneral.EditValue
                        fila("Cuota") = Me.ceCuotas.EditValue
                        DT.Rows.Add(fila)
                        fila = DT.NewRow
                    End If
                End If
            Next
            fila = Nothing

        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        DT.Clear()
    End Sub
End Class