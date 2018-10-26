Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmProduccion

#Region "Variables"
    Dim PNDetails As VB.SysContab.PeriodoNominaDetails
#End Region
    Private Sub frmProduccion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cargar()
    End Sub

    Private Sub cargar()
        'Me.calc_Produccion.EditValue = 0.0
        Me.cbFechas.Properties.DataSource = Nothing

        Me.cbPlanillas.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList_Activos().Tables(0)
        Me.cbPlanillas.Properties.DisplayMember = "per_descripcion"
        Me.cbPlanillas.Properties.ValueMember = "per_codigo"

        Me.cbempleados.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables(0)
        Me.cbempleados.DisplayMember = "Nombre"
        Me.cbempleados.ValueMember = "Codigo"

        Me.cbcategorias.DataSource = Cat_ProdDB.Lista(EmpresaActual, 0, False)
        Me.cbcategorias.DisplayMember = "cat_desccorta"
        Me.cbcategorias.ValueMember = "cat_codigo"

        Me.cbcategoriaOriginal.DataSource = Cat_ProdDB.Lista(EmpresaActual, 0, False)
        Me.cbcategoriaOriginal.DisplayMember = "cat_desccorta"
        Me.cbcategoriaOriginal.ValueMember = "cat_codigo"

        Me.cbTipoAsistencia.DataSource = RH_Produccion.RH_TipoAsistencia_List(0)
        Me.cbTipoAsistencia.DisplayMember = "asi_descripcion"
        Me.cbTipoAsistencia.ValueMember = "asi_codigo"

        Me.cbAreas.Properties.DataSource = VB.SysContab.AreaDB.RH_Prod_Area(0)
        Me.cbAreas.Properties.DisplayMember = "are_descripcion"
        Me.cbAreas.Properties.ValueMember = "id"

        Me.cbDia1.Properties.DataSource = RH_Produccion.RH_TipoAsistencia_List(0)
        Me.cbDia1.Properties.DisplayMember = "asi_descripcion"
        Me.cbDia1.Properties.ValueMember = "asi_codigo"

        Me.cbDia2.Properties.DataSource = RH_Produccion.RH_TipoAsistencia_List(0)
        Me.cbDia2.Properties.DisplayMember = "asi_descripcion"
        Me.cbDia2.Properties.ValueMember = "asi_codigo"

        Me.cbDia3.Properties.DataSource = RH_Produccion.RH_TipoAsistencia_List(0)
        Me.cbDia3.Properties.DisplayMember = "asi_descripcion"
        Me.cbDia3.Properties.ValueMember = "asi_codigo"

        Me.cbDia4.Properties.DataSource = RH_Produccion.RH_TipoAsistencia_List(0)
        Me.cbDia4.Properties.DisplayMember = "asi_descripcion"
        Me.cbDia4.Properties.ValueMember = "asi_codigo"

        Me.cbDia5.Properties.DataSource = RH_Produccion.RH_TipoAsistencia_List(0)
        Me.cbDia5.Properties.DisplayMember = "asi_descripcion"
        Me.cbDia5.Properties.ValueMember = "asi_codigo"

        Me.cbDia6.Properties.DataSource = RH_Produccion.RH_TipoAsistencia_List(0)
        Me.cbDia6.Properties.DisplayMember = "asi_descripcion"
        Me.cbDia6.Properties.ValueMember = "asi_codigo"

        Me.cbDia7.Properties.DataSource = RH_Produccion.RH_TipoAsistencia_List(0)
        Me.cbDia7.Properties.DisplayMember = "asi_descripcion"
        Me.cbDia7.Properties.ValueMember = "asi_codigo"

    End Sub


    Private Sub Refrescar()
        Dim h As Integer
        Dim i As String
        Dim j As Date
        'Dim k As Decimal

        h = Me.cbAreas.EditValue
        i = Me.cbPlanillas.EditValue
        j = Me.cbPlanillas.GetColumnValue("per_finicio")
        'k = Me.calc_Produccion.EditValue

        Me.cbPlanillas.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList_Activos().Tables(0)
        Me.cbPlanillas.Properties.DisplayMember = "per_descripcion"
        Me.cbPlanillas.Properties.ValueMember = "per_codigo"

        Me.cbPlanillas.EditValue = i
        validar_Planillas()
        If Me.cbFechas.Properties.DataSource Is Nothing Then
            Me.calc_Minimo.EditValue = 0
            Me.cePD1.EditValue = 0
            Me.cePD2.EditValue = 0
            Me.cePD3.EditValue = 0
            Me.cePD4.EditValue = 0
            Me.cePD5.EditValue = 0
            Me.cePD6.EditValue = 0
            Me.cePD7.EditValue = 0


            Me.BandedView.OptionsBehavior.ReadOnly = True
        Else
            Me.cbFechas.EditValue = j
            If Me.cbFechas.Properties.DataSource.rows.count = 0 Then
                Me.calc_Minimo.EditValue = 0
                Me.cePD1.EditValue = 0
                Me.cePD2.EditValue = 0
                Me.cePD3.EditValue = 0
                Me.cePD4.EditValue = 0
                Me.cePD5.EditValue = 0
                Me.cePD6.EditValue = 0
                Me.cePD7.EditValue = 0
                Exit Sub
            End If
            'Me.calc_Produccion.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("produccion")
            Me.calc_Minimo.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("minimo")

            Me.cePD1.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("p_d1")
            Me.cePD2.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("p_d2")
            Me.cePD3.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("p_d3")
            Me.cePD4.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("p_d4")
            Me.cePD5.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("p_d5")
            Me.cePD6.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("p_d6")
            Me.cePD7.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("p_d7")

            Me.Pivot()

            Me.BandedView.OptionsBehavior.ReadOnly = VB.SysContab.PeriodoNominaDB.GetDetails(Me.cbPlanillas.EditValue).MovGen
        End If


    End Sub

    Private Sub Pivot()
        ADORNOS.ShowSplash()
        Try
            Me.dgProduccion.DataSource = Nothing

            Me.dgProduccion.DataSource = RH_Produccion.RH_ProduccionDetalle_List_Pivot(Me.cbFechas.Properties.DataSource.rows(0)("prod_id"), _
              EmpresaActual, Me.cbAreas.EditValue, cbPlanillas.GetColumnValue("per_codigo").ToString.Substring(1, 8), _
              cbPlanillas.GetColumnValue("per_codigo").ToString.Substring(0, 1))

            For i As Integer = 3 To Me.BandedView.Bands.Count - 1
                Me.BandedView.Bands(i).Caption = WeekdayName(Weekday(Me.cbFechas.Properties.DataSource.rows(i - 3)("per_fecha"))).ToUpper & "-" &
                        Format(Me.cbFechas.Properties.DataSource.rows(i - 3)("per_fecha"), " dd/MMM/yyyy")
            Next

            Me.lcPD1.Text = "Prod " & Me.BandedView.Bands(3).Caption
            Me.lcPD2.Text = "Prod " & Me.BandedView.Bands(4).Caption
            Me.lcPD3.Text = "Prod " & Me.BandedView.Bands(5).Caption
            Me.lcPD4.Text = "Prod " & Me.BandedView.Bands(6).Caption
            Me.lcPD5.Text = "Prod " & Me.BandedView.Bands(7).Caption
            Me.lcPD6.Text = "Prod " & Me.BandedView.Bands(8).Caption
            Me.lcPD7.Text = "Prod " & Me.BandedView.Bands(9).Caption

            For i As Integer = 0 To Me.BandedView.Columns.Count - 1
                If Me.BandedView.Columns(i).Name = "BCemp_codigo" Then
                    Me.BandedView.Columns(i).FieldName = "emp_codigo"
                    Me.BandedView.Columns(i).OptionsColumn.ReadOnly = True

                ElseIf Me.BandedView.Columns(i).Name = "BCemp_ccodigo" Then
                    Me.BandedView.Columns(i).FieldName = "emp_codigo"
                    Me.BandedView.Columns(i).OptionsColumn.ReadOnly = True

                ElseIf Me.BandedView.Columns(i).Name = "cat_codigo" Then
                    Me.BandedView.Columns(i).FieldName = "cat_codigo"
                    Me.BandedView.Columns(i).OptionsColumn.ReadOnly = True
                Else
                    Me.BandedView.Columns(i).FieldName = Me.BandedView.Columns(i).Name.Substring(2, 7)
                    Me.BandedView.Columns(i).Caption = IIf(Me.BandedView.Columns(i).Name.Substring(8, 1) = "P", "Produccion", IIf(Me.BandedView.Columns(i).Name.Substring(8, 1) = "C", "Categoria", "Asistencia"))
                    Me.BandedView.Columns(i).ColumnEdit = IIf(Me.BandedView.Columns(i).Name.Substring(8, 1) = "P", Nothing, IIf(Me.BandedView.Columns(i).Name.Substring(8, 1) = "C", Me.cbcategorias, Me.cbTipoAsistencia))
                End If

            Next

            Me.BandedView.BestFitColumns()

        Catch ex As Exception

        End Try
        ADORNOS.HideSplash()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub validar_Planillas()

        Me.cbFechas.Properties.DataSource = Nothing
        If Me.cbPlanillas.EditValue Is Nothing Then
            Me.cbFechas.Enabled = False
            'Me.calc_Produccion.Enabled = False
            Me.cmdCrearEncabezado.Enabled = False
            Me.cmdBorrarEncabezado.Enabled = False

            Me.cePD1.Properties.ReadOnly = True
            Me.cePD2.Properties.ReadOnly = True
            Me.cePD3.Properties.ReadOnly = True
            Me.cePD4.Properties.ReadOnly = True
            Me.cePD5.Properties.ReadOnly = True
            Me.cePD6.Properties.ReadOnly = True
            Me.cePD7.Properties.ReadOnly = True
            Exit Sub
        Else

            Me.cmdCrearEncabezado.Enabled = Not PNDetails.MovGen
            Me.cmdBorrarEncabezado.Enabled = Not PNDetails.MovGen

            Me.cePD1.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD2.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD3.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD4.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD5.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD6.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD7.Properties.ReadOnly = PNDetails.MovGen

            Me.cbFechas.Enabled = True
            Me.cbFechas.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList_Fechas(Me.cbPlanillas.EditValue, Me.cbAreas.EditValue)
            Me.cbFechas.Properties.DisplayMember = "per_fecha"
            Me.cbFechas.Properties.ValueMember = "per_fecha"
        End If
    End Sub
    Private Sub cbPlanillas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPlanillas.EditValueChanged

        PNDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Me.cbPlanillas.EditValue)
        validar_Planillas()

    End Sub

    Private Sub cbPlanillas_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbPlanillas.Validating
        If Me.cbPlanillas.EditValue Is Nothing Then
            Me.cbFechas.Enabled = False
            Me.cmdCrearEncabezado.Enabled = False
            Me.cmdBorrarEncabezado.Enabled = False

            Me.cePD1.Properties.ReadOnly = True
            Me.cePD2.Properties.ReadOnly = True
            Me.cePD3.Properties.ReadOnly = True
            Me.cePD4.Properties.ReadOnly = True
            Me.cePD5.Properties.ReadOnly = True
            Me.cePD6.Properties.ReadOnly = True
            Me.cePD7.Properties.ReadOnly = True

            PNDetails = Nothing
            Exit Sub
        Else
            PNDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Me.cbPlanillas.EditValue)
            Me.cmdCrearEncabezado.Enabled = Not PNDetails.MovGen
            Me.cmdBorrarEncabezado.Enabled = Not PNDetails.MovGen

            Me.cePD1.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD2.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD3.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD4.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD5.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD6.Properties.ReadOnly = PNDetails.MovGen
            Me.cePD7.Properties.ReadOnly = PNDetails.MovGen

            Me.cbFechas.Enabled = True
            Me.cbFechas.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList_Fechas(Me.cbPlanillas.EditValue, Me.cbAreas.EditValue)
            Me.cbFechas.Properties.DisplayMember = "per_fecha"
            Me.cbFechas.Properties.ValueMember = "per_fecha"
        End If

    End Sub


    Private Sub cbFechas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFechas.EditValueChanged
        If Me.cbFechas.Properties.DataSource Is Nothing Then
            Exit Sub
        End If
        Me.cmdCrearEncabezado.Enabled = Not PNDetails.MovGen
        Me.cmdBorrarEncabezado.Enabled = Not PNDetails.MovGen
        Me.cePD1.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD2.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD3.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD4.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD5.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD6.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD7.Properties.ReadOnly = PNDetails.MovGen

        If Me.cbFechas.Properties.DataSource.rows.count = 0 Then
            Me.cmdGuardar.Enabled = True
            Exit Sub
        End If
        If Me.cbFechas.Properties.DataSource.rows(0)("prod_id") = 0 Then
            'Si no existe el encabezado de Produccion para la Nomina, Pedir el dato de produccion del Dia.
            Me.cmdGuardar.Enabled = False

        Else
            'Me.calc_Produccion.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("produccion")
            Me.cmdGuardar.Enabled = True
            Me.Refrescar()
        End If
    End Sub

    Private Sub cbFechas_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbFechas.Validating
        'Me.calc_Produccion.Enabled = True
        Me.cmdCrearEncabezado.Enabled = Not PNDetails.MovGen
        Me.cmdBorrarEncabezado.Enabled = Not PNDetails.MovGen
        Me.cePD1.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD2.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD3.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD4.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD5.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD6.Properties.ReadOnly = PNDetails.MovGen
        Me.cePD7.Properties.ReadOnly = PNDetails.MovGen

        If Me.cbFechas.Properties.DataSource.rows(0)("prod_id") = 0 Then
            'Si no existe el encabezado de Produccion para la Nomina, Pedir el dato de produccion del Dia.
            Me.cmdGuardar.Enabled = False
            'Me.calc_Produccion.Focus()
        Else
            'Me.calc_Produccion.EditValue = Me.cbFechas.Properties.DataSource.rows(0)("produccion")
            Me.cmdGuardar.Enabled = True
            Me.Refrescar()
        End If
    End Sub


    Private Sub cmdCrearEncabezado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrearEncabezado.Click
        'Me.calc_Produccion.EditValue

        Dim prod_id As Integer = 0, procesado As Boolean = False
        If Not Me.cbFechas.Properties.DataSource.rows.count = 0 Then
            prod_id = Me.cbFechas.Properties.DataSource.rows(0)("prod_id")
            procesado = Me.cbFechas.GetColumnValue("procesado")
        End If

        RH_Produccion.RH_Produccion_Add(prod_id, _
            EmpresaActual, Me.cbPlanillas.EditValue.ToString.Substring(0, 1), _
            Me.cbPlanillas.EditValue.ToString.Substring(1, 8), _
            0, procesado, Me.cbAreas.EditValue, Me.calc_Minimo.EditValue, _
            Me.cePD1.EditValue, _
            Me.cePD2.EditValue, _
            Me.cePD3.EditValue, _
            Me.cePD4.EditValue, _
            Me.cePD5.EditValue, _
            Me.cePD6.EditValue, _
            Me.cePD7.EditValue)

        Me.Refrescar()
        Me.cmdGuardar.Enabled = True
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        Me.cargar()
        Me.Refrescar()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        If Me.BandedView.DataRowCount = 0 Then
            MsgBox("NO hay datos que guardar", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If

        ADORNOS.ShowSplash()
        Dim Empleado As String
        Dim Fecha As DateTime
        Dim Produccion As Double
        Dim Categoria, Asistencia As Integer
        'Ciclo de los Empleados
        For i As Integer = 0 To Me.BandedView.DataRowCount - 1
            Empleado = Me.BandedView.GetRowCellValue(i, "emp_codigo")
            For j As Integer = 3 To Me.BandedView.Bands.Count - 1
                Fecha = Me.cbFechas.Properties.DataSource.rows(j - 3)("per_fecha")
                For k As Integer = 0 To Me.BandedView.Bands(j).Columns.Count - 1
                    If Me.BandedView.Bands(j).Columns(k).FieldName.Substring(6, 1) = "P" Then
                        Produccion = Me.BandedView.GetRowCellValue(i, Me.BandedView.Bands(j).Columns(k).FieldName)
                    ElseIf Me.BandedView.Bands(j).Columns(k).FieldName.Substring(6, 1) = "C" Then
                        Categoria = Me.BandedView.GetRowCellValue(i, Me.BandedView.Bands(j).Columns(k).FieldName)
                    Else
                        Asistencia = Me.BandedView.GetRowCellValue(i, Me.BandedView.Bands(j).Columns(k).FieldName)
                    End If
                Next
                'Guardar el registro
                RH_Produccion.RH_ProduccionDetalle_Add_Update(Me.cbFechas.Properties.DataSource.rows(0)("prod_id"), _
                    Fecha, Empleado, Produccion, Categoria, Asistencia)
            Next
        Next
        ADORNOS.HideSplash()
    End Sub

    Private Sub cbAreas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAreas.EditValueChanged
        Me.Refrescar()
    End Sub

    Private Sub cmdBorrarEncabezado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrarEncabezado.Click
        If MsgBox("Esta seguro de borrar la produccion de la semana para " & Me.cbAreas.Text & " ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.Yes Then
            RH_Produccion.RH_Produccion_Delete(Me.cbFechas.Properties.DataSource.rows(0)("prod_id"))
        End If
    End Sub

    Private Sub cbDia1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDia1.EditValueChanged, _
        cbDia2.EditValueChanged, cbDia3.EditValueChanged, cbDia4.EditValueChanged, cbDia5.EditValueChanged, cbDia6.EditValueChanged, _
        cbDia7.EditValueChanged

        Dim j As Integer = sender.name.substring(5, 1) + 2 '3
        If sender.EditValue Is Nothing Then
            Exit Sub
        End If
        If sender.EditValue Is DBNull.Value Then
            Exit Sub
        End If
        For i As Integer = 0 To Me.BandedView.DataRowCount - 1
            For k As Integer = 0 To Me.BandedView.Bands(j).Columns.Count - 1
                If Me.BandedView.Bands(j).Columns(k).FieldName.Substring(6, 1) = "A" Then
                    Me.BandedView.SetRowCellValue(i, Me.BandedView.Bands(j).Columns(k).FieldName, sender.EditValue)
                    Validar_Asistencia(i, Me.BandedView.Bands(j).Columns(k).FieldName, sender.EditValue)
                End If
            Next
        Next


    End Sub


    Private Sub cePD1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cePD1.EditValueChanged, _
            cePD2.EditValueChanged, cePD3.EditValueChanged, cePD4.EditValueChanged, cePD5.EditValueChanged, cePD6.EditValueChanged, _
            cePD7.EditValueChanged

        Dim j As Integer = sender.name.substring(4, 1) + 2 '3
        If sender.EditValue Is Nothing Then
            Exit Sub
        End If
        If sender.EditValue Is DBNull.Value Then
            Exit Sub
        End If
        For i As Integer = 0 To Me.BandedView.DataRowCount - 1
            For k As Integer = 0 To Me.BandedView.Bands(j).Columns.Count - 1
                If Me.BandedView.Bands(j).Columns(k).FieldName.Substring(6, 1) = "P" Then
                    Me.BandedView.SetRowCellValue(i, Me.BandedView.Bands(j).Columns(k).FieldName, sender.EditValue)
                End If
            Next
        Next
    End Sub

    Private Sub BandedView_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles BandedView.CustomColumnDisplayText

    End Sub

    Private Sub BandedView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles BandedView.ValidatingEditor
        'Dim antes As Decimal
        If sender.focusedcolumn.fieldname.Substring(6, 1) = "A" Then
            'antes = BandedView.GetFocusedRowCellValue(sender.focusedcolumn.fieldname.substring(0, 6) & "P")
            Validar_Asistencia(BandedView.FocusedRowHandle, sender.focusedcolumn.FieldName, e.Value)
            'If antes <> BandedView.GetFocusedRowCellValue(sender.focusedcolumn.fieldname.substring(0, 6) & "P") Then
            '    'sender.focusedcolumn.appearancecell.backcolor = Color.BlueViolet 'esto es para la columna completa
            '    'BandedView.Appearance.FocusedCell.BackColor = Color.BlueViolet
            'End If
        End If
    End Sub

    Private Sub Validar_Asistencia(ByVal Indice As Integer, ByVal Campo As String, ByVal Asistencia As Decimal)
        Dim valor As Integer = 0
        Select Case Asistencia
            Case 1, 4, 8
                valor = 0
            Case 2, 6
                valor = Me.BandedView.GetRowCellValue(Indice, Campo.Substring(0, 6) & "P")
            Case 3, 5, 7, 9 'Vacaciones, Subsidio Pre/PostNatal, Subsidio Comun
                valor = RH_Produccion.RH_Produccion_Promedio(Me.BandedView.GetRowCellValue(Indice, "emp_codigo"), Me.cbFechas.Properties.DataSource.rows(Campo.Substring(4, 1) - 1)("per_fecha"))
            Case Else
                valor = 0
        End Select
        Me.BandedView.SetRowCellValue(Indice, Campo.Substring(0, 6) & "P", valor)

    End Sub


    Private Sub BandedView_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs) Handles BandedView.CustomDrawCell

        
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.dgProduccion.FormsUseDefaultLookAndFeel = True
        Me.dgProduccion.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

    End Sub

    Private Sub BandedView_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles BandedView.RowCellStyle
        Dim currentView As GridView = CType(sender, GridView)
        If currentView.DataSource Is Nothing Then Exit Sub
        If e.CellValue Is Nothing Then Exit Sub
        If (e.RowHandle = currentView.FocusedRowHandle) Then Return
        'Dim r As Rectangle = e.Bounds
        If e.Column.FieldName.Substring(6, 1) = "A" Then
            If e.CellValue Is Nothing Then
                'e.Handled = False
                Exit Sub
            ElseIf e.CellValue Is DBNull.Value Then
                'e.Handled = False
                Exit Sub
            ElseIf e.CellValue <> 2 Then 'PRESENTE
                'Dim ellipseBrush As Brush = Brushes.LightSkyBlue
                'ellipseBrush = Brushes.Yellow

                e.Appearance.BackColor = Color.Yellow

                'e.Graphics.FillEllipse(ellipseBrush, r)
                'r.Width -= 12
                'Draw the cell value
                'e.Appearance.DrawString(e.Cache, e.DisplayText, r)
                'Set e.Handled to true to prevent default painting
                'e.Handled = True
            End If
        ElseIf e.Column.FieldName.Substring(6, 1) = "P" Then
            If e.CellValue Is Nothing Then
                'e.Handled = False
                Exit Sub
            ElseIf e.CellValue Is DBNull.Value Then
                'e.Handled = False
                Exit Sub
            Else
                Dim ellipseBrush As Brush = Brushes.LightSkyBlue
                Dim Valor As Decimal = 0
                Select Case e.Column.FieldName.Substring(4, 1)
                    Case 1
                        Valor = Me.cePD1.Value
                    Case 2
                        Valor = Me.cePD2.Value
                    Case 3
                        Valor = Me.cePD3.Value
                    Case 4
                        Valor = Me.cePD4.Value
                    Case 5
                        Valor = Me.cePD5.Value
                    Case 6
                        Valor = Me.cePD6.Value
                    Case 7
                        Valor = Me.cePD7.Value

                End Select

                If e.CellValue <> Valor Then
                    If e.CellValue < Valor Then
                        e.Appearance.BackColor = Color.LightPink
                        'ellipseBrush = Brushes.LightPink
                    Else
                        e.Appearance.BackColor = Color.LightGreen
                        'ellipseBrush = Brushes.LightGreen
                    End If

                    'Draw an ellipse within the cell
                    'e.Graphics.FillEllipse(ellipseBrush, r)
                    'r.Width -= 12
                    'Draw the cell value
                    'e.Appearance.DrawString(e.Cache, e.DisplayText, r)
                    'Set e.Handled to true to prevent default painting
                    'e.Handled = True
                End If

            End If
        ElseIf e.Column.FieldName.Substring(6, 1) = "C" Then
            If e.CellValue Is Nothing Then
                'e.Handled = False
                Exit Sub
            ElseIf e.CellValue Is DBNull.Value Then
                'e.Handled = False
                Exit Sub
            ElseIf sender.GetRowCellValue(e.RowHandle, "cat_codigo") <> e.CellValue Then
                e.Appearance.BackColor = Color.LightSkyBlue
                'Dim ellipseBrush As Brush = Brushes.LightSkyBlue
                'ellipseBrush = Brushes.LightSkyBlue
                'e.Graphics.FillEllipse(ellipseBrush, r)
                'r.Width -= 12
                'Draw the cell value
                'e.Appearance.DrawString(e.Cache, e.DisplayText, r)
                'Set e.Handled to true to prevent default painting
                'e.Handled = True
            End If


        End If
    End Sub
End Class