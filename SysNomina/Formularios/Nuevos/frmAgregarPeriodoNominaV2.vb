Public Class frmAgregarPeriodoNominaV2
#Region "Variables"
    Dim iniciado As Boolean = False
    Private Rango As SelectionRange
    Dim Sufijo As String
#End Region

    Private Sub frmAgregarPeriodoNominaV2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim PNomina As New VB.SysContab.PeriodoNominaDB()

        Me.Mes.Enabled = False
        If Nuevo = "NO" Then
            Rango = New SelectionRange
            Me.Text = "Editar Periodo de Nomina"

            Dim Detalles As VB.SysContab.PeriodoNominaDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
            Me.dgFechas.DataSource = Detalles.Calendario
            Me.Vista.Columns("Fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Vista.Columns("Fecha").DisplayFormat.FormatString = "D" 'DD, dd MMM yyyy"

            If Detalles.Calendario Is Nothing Then
                Me.dgFechas.Visible = False
                Me.cmdCerrarDia.Visible = False
            Else
                If Detalles.Calendario.Rows.Count = 0 Then
                    Me.dgFechas.Visible = False
                    Me.cmdCerrarDia.Visible = False
                Else
                    Me.dgFechas.Visible = True
                    Me.cmdCerrarDia.Visible = True
                End If
            End If
            Rango.Start = Detalles.FInicio
            Rango.End = Detalles.FFinal
            Me.dtFechaPago.EditValue = Detalles.FechaPago

            If Detalles.Tipo = "S" Then Me.dtFechaPago.Properties.ReadOnly = True

            Me.Mes.MinDate = Rango.Start
            Me.Mes.MaxDate = Rango.End
            Me.Mes.MaxSelectionCount = IIf(Detalles.Tipo = "D" Or Detalles.Tipo = "U", 3, 1) * (DateDiff(DateInterval.Day, Rango.Start, Rango.End) + IIf(Detalles.Tipo = "C", 0, 1))
            Me.Mes.SelectionStart = Rango.Start
            Me.Mes.SelectionEnd = Rango.End

            Me.Mes.Refresh()

            Me.txtCodigo.EditValue = Detalles.Codigo
            Me.txtDescripcion.EditValue = Detalles.Descripcion
            Me.txtComentarios.EditValue = Detalles.Comentarios
            Select Case Detalles.Tipo.ToUpper
                Case "S"
                    Me.cbTipo.SelectedText = "SEMANAL"
                Case "Q"
                    Me.cbTipo.SelectedText = "QUINCENAL"
                Case "M"
                    Me.cbTipo.SelectedText = "MENSUAL"
                Case "D"
                    Me.cbTipo.SelectedText = "DESTAJO"
                    'Case "L"
                    '    Me.cbTipo.SelectedText = "LIQUIDACION"
                Case "V"
                    Me.cbTipo.SelectedText = "VACACIONES"
                Case "E"
                    Me.cbTipo.SelectedText = "EXTRA"
                Case "U"
                    Me.cbTipo.SelectedText = "UNIDAD DE TRABAJO(CORTE)"
            End Select
            Me.chkGenIndemnizacion.Checked = Detalles.GenerarIndemnizacion
            Me.txtMinHextra.Text = Detalles.MinHoraExtra
            Me.cbOrigen.SelectedIndex = IIf(Microsoft.VisualBasic.Left(Detalles.Origen, 1) = "P", 0, 1)
            Me.cmdAceptar.Enabled = IIf(Detalles.Revisado = True Or Detalles.Aprobado = True Or Detalles.Contabilizado = True, False, True)
            ' Si el periodo es de destajo
            If Detalles.Tipo = "D" Or Detalles.Tipo = "U" Then
                Me.txtMinHextra.Enabled = True
                Me.chkGenIndemnizacion.Enabled = True
            Else
                Me.txtMinHextra.Enabled = False
                Me.chkGenIndemnizacion.Enabled = False
            End If
            Me.cbTipo.Enabled = False
            Me.cbOrigen.Enabled = False
            Me.dtpMCS.EditValue = Detalles.Fecha_MCS
            Me.dtpSnack.EditValue = Detalles.Fecha_SnackBar

        Else
            Me.Text = "Agregar Periodo de Nomina"
            Me.txtCodigo.EditValue = ""
            Me.txtDescripcion.EditValue = ""
            Me.cbTipo.SelectedText = "QUINCENAL"
            Me.cbTipo.Enabled = True
            Me.Mes.MaxSelectionCount = 15
            Me.cmdAceptar.Enabled = True
            Me.txtComentarios.EditValue = ""
            Me.cbOrigen.SelectedIndex = 0
            Me.cbOrigen.Enabled = False
            Me.txtMinHextra.Text = "-1"
            Me.txtMinHextra.Enabled = False
            Me.chkGenIndemnizacion.Checked = True
            Me.chkGenIndemnizacion.Enabled = False

        End If

        iniciado = True
        Me.Refresh()

    End Sub

    Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click

        Dim em As New VB.SysContab.EmpresasDB(), Empresa As New VB.SysContab.EmpresasDetails()
        Empresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        Dim AFiscal As String ', cadena1 As String

        Dim FInicio, Ffinal As Date

        If Me.cbTipo.EditValue.Substring(0, 1) = "V" Then
            If Not (VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionEnd.Date.AddDays(1)) Is Nothing Or VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date.AddDays(1)) = 0) Then
                FInicio = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date.AddDays(1))).Inicio
                Ffinal = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date.AddDays(1))).Final
            Else
                MsgBox("No hay Periodo Fiscal definido para la empresa", MsgBoxStyle.Critical, "STS-Nomina")
                Exit Sub
            End If
        Else
            If Not (VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date) Is Nothing Or VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date) = 0) Then
                FInicio = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date)).Inicio
                Ffinal = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo(Me.Mes.SelectionStart.Date)).Final
            Else
                MsgBox("No hay Periodo Fiscal definido para la empresa", MsgBoxStyle.Critical, "STS-Nomina")
                Exit Sub
            End If
        End If

       

        If Me.Mes.SelectionStart.Date >= FInicio.Date And _
            Me.Mes.SelectionStart <= Ffinal.Date Then
            AFiscal = DatePart(DateInterval.Year, FInicio.Date) & "-" & _
                    DatePart(DateInterval.Year, Ffinal.Date)
        Else
            MsgBox("Esta intentando generar un Periodo de Nomina que esta fuera del año fiscal actual de la empresa", MsgBoxStyle.OkOnly)
            AFiscal = DatePart(DateInterval.Year, FInicio.Date) & "-" & _
                    DatePart(DateInterval.Year, Ffinal.Date)
            'Exit Sub
        End If

        If Me.dtpMCS.EditValue Is Nothing Then
            MsgBox("Seleccione la fecha de Corte del MCS por favor", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Me.dtpSnack.EditValue Is Nothing Then
            MsgBox("Seleccione la fecha de Corte del Snack Bar por favor", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Me.Mes.SelectionEnd < Me.dtpMCS.EditValue Then
            MsgBox("La fecha de cierre del MCS no debe ser mayor que la fecha de fin del periodo de nomina")
            Exit Sub
        End If
        If Me.Mes.SelectionEnd < Me.dtpSnack.EditValue Then
            MsgBox("La fecha de cierre del SNACK BAR no debe ser mayor que la fecha de fin del periodo de nomina")
            Exit Sub
        End If

        Dim cAFiscal As Int16
        cAFiscal = VB.SysContab.PeriodosDB.Activo(Me.dtFechaPago.EditValue)

        If Nuevo = "SI" Then

            VB.SysContab.PeriodoNominaDB.Additem(Me.txtCodigo.EditValue, Me.txtDescripcion.EditValue, _
                Me.Mes.SelectionStart, Me.Mes.SelectionEnd, _
                Me.cbTipo.EditValue.Substring(0, 1), AFiscal, _
                Me.txtSemanas.EditValue, Me.txtComentarios.EditValue, Microsoft.VisualBasic.Left(Me.cbOrigen.EditValue, 1), _
                Me.txtMinHextra.EditValue, Me.chkGenIndemnizacion.Checked, cAFiscal, Me.dtpMCS.EditValue, _
                Me.dtpSnack.EditValue, Me.dtFechaPago.EditValue)

        Else
            'Modificar solo el comentario
            VB.SysContab.PeriodoNominaDB.Update_Comentario(Me.txtCodigo.EditValue, _
                    Me.cbTipo.EditValue.Substring(0, 1), _
                    Me.txtComentarios.EditValue, _
                    Me.dtpMCS.EditValue, Me.dtpSnack.EditValue)
        End If
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub Validacion()

        If Not iniciado Then Exit Sub

        Dim EmpresaDetail As New VB.SysContab.EmpresasDetails()
        Dim Rango As New SelectionRange()
        Dim Inicial As Boolean

        Sufijo = ""

        EmpresaDetail = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)


        If Me.cbTipo.EditValue.Substring(0, 1) <> "V" Then
            'Para Nominas Regulares
            Rango = VB.SysContab.PeriodoNominaDB.GetListNuevo(Me.cbTipo.EditValue.Substring(0, 1), Sufijo, Inicial, Me.dtFechaPago.EditValue)
            If Me.cbTipo.EditValue.substring(0, 1) <> "S" Then
                Me.dtFechaPago.EditValue = Rango.End
                Me.dtFechaPago.Properties.ReadOnly = True

            Else
                Me.dtFechaPago.Properties.ReadOnly = False
            End If
        ElseIf Me.cbTipo.EditValue.Substring(0, 1) = "E" Then
            'Nominas Extras
            Rango = VB.SysContab.PeriodoNominaDB.GetListNuevo(Me.cbTipo.EditValue.Substring(0, 1), Sufijo, Inicial, Me.dtFechaPago.EditValue)
        Else
            'Para Vacaciones
            Rango.Start = DateAdd(DateInterval.Day, 1, CDate(Meses(Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) - 1).ToString & "/" & Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) & "/" & Microsoft.VisualBasic.Left(EmpresaDetail.UMESPAGOVAC, 4)))
            Rango.End = CDate(Meses(Microsoft.VisualBasic.Mid(DateAdd(DateInterval.Month, 6, CDate(Meses(Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) - 1).ToString & "/" & Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) & "/" & Microsoft.VisualBasic.Left(EmpresaDetail.UMESPAGOVAC, 4))).ToShortDateString, 4, 2) - 1).ToString & "/" & _
                Microsoft.VisualBasic.Mid(DateAdd(DateInterval.Month, 6, CDate(Meses(Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) - 1).ToString & "/" & Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) & "/" & Microsoft.VisualBasic.Left(EmpresaDetail.UMESPAGOVAC, 4))).ToShortDateString, 4, 2) & "/" & _
                Microsoft.VisualBasic.Mid(DateAdd(DateInterval.Month, 6, CDate(Meses(Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) - 1).ToString & "/" & Microsoft.VisualBasic.Right(EmpresaDetail.UMESPAGOVAC, 2) & "/" & Microsoft.VisualBasic.Left(EmpresaDetail.UMESPAGOVAC, 4))).ToShortDateString, 7, 4))
            Sufijo = "01"
        End If

        If Rango Is Nothing Then 'Se devuelve Nothing cuando el periodo de nomina anterior no ha sido cerrado
            MsgBox("La Planilla del periodo anterior no ha sido procesada", MsgBoxStyle.OkOnly)
            Me.cmdAceptar.Enabled = False
            Exit Sub
        Else
            Me.cmdAceptar.Enabled = True
        End If

        If Sufijo Is DBNull.Value Then  'Se paso de las dos cifras
            MsgBox("Ya se ha pasado del maximo de 99 Nominas disponibles para este mes", MsgBoxStyle.Critical, "SysNomina")
            Exit Sub
        End If
        
        'Buscar el siguiente periodo  correspondiente al tipo que se ha seleccionado
        Me.Mes.MinDate = Rango.Start
        Me.Mes.MaxDate = Rango.End 'IIf(Me.cbTipo.Text.Substring(0, 1) = "U", DateAdd(DateInterval.Day, 21, Rango.Start), Rango.End)
        Me.Mes.MaxSelectionCount = IIf(Me.cbTipo.EditValue.Substring(0, 1) = "D" Or Me.cbTipo.EditValue.Substring(0, 1) = "U", 3, 1) * (DateDiff(DateInterval.Day, Rango.Start, Rango.End) + IIf(Me.cbTipo.EditValue.Substring(0, 1) = "C", 0, 1))
        'Me.Mes.SelectionRange = Rango
        Me.Mes.SelectionStart = Rango.Start
        Me.Mes.SelectionEnd = Rango.End

        Me.Mes.Refresh()
        If Me.cbTipo.EditValue.Substring(0, 1) <> "E" And _
            Me.cbTipo.EditValue.Substring(0, 1) <> "C" And _
            Me.cbTipo.EditValue.Substring(0, 1) <> "D" And _
            Me.cbTipo.EditValue.Substring(0, 1) <> "U" And _
            Me.cbTipo.EditValue.Substring(0, 1) <> "S" Then
            Me.Mes.Enabled = Inicial
        Else
            Me.Mes.Enabled = True
            Me.Mes.MaxDate = IIf(Me.cbTipo.EditValue.Substring(0, 1) = "C" Or _
                Me.cbTipo.EditValue.Substring(0, 1) = "D" Or _
                Me.cbTipo.EditValue.Substring(0, 1) = "U", DateTimePicker.MaximumDateTime, Rango.End)
        End If
        'Sufijo
        If Sufijo <> "" And (Me.cbTipo.EditValue.Substring(0, 1) <> "V" And _
            Me.cbTipo.EditValue.Substring(0, 1) <> "E") Then
            Select Case Sufijo
                Case "01"
                    Me.txtDescripcion.EditValue = IIf(Me.cbTipo.EditValue.Substring(0, 1) = "M", "1er", "1era")

                Case "02"
                    Me.txtDescripcion.EditValue = IIf(Me.cbTipo.EditValue.Substring(0, 1) = "M", "2do", "2da")

                Case "03"
                    Me.txtDescripcion.EditValue = IIf(Me.cbTipo.EditValue.Substring(0, 1) <> "S" And Me.cbTipo.EditValue.Substring(0, 1) <> "D" And Me.cbTipo.EditValue.Substring(0, 1) <> "U", "Error-", "3ra")

                Case "04"
                    Me.txtDescripcion.EditValue = IIf(Me.cbTipo.EditValue.Substring(0, 1) <> "S", "Error-", "4ta")
            End Select

            Select Case Me.cbTipo.EditValue
                Case "SEMANAL"
                    'Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & "Semana " & Format(Rango.End, "MMM") & "-" & Format(Rango.End, "yyyy")
                    Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & "Semana " & Format(Me.dtFechaPago.EditValue, "MMM") & "-" & Format(Me.dtFechaPago.EditValue, "yyyy")
                Case "CATORCENAL"
                    Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & "Catorcena " & Format(Rango.End, "MMM") & "-" & Format(Rango.End, "yyyy")
                Case "QUINCENAL"
                    Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & "Quincena " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy")
                Case "MENSUAL"
                    Me.txtDescripcion.EditValue = "Mes de " & Format(Rango.Start, "MMMM") & "-" & Format(Rango.Start, "yyyy")
                Case "DESTAJO"
                    Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & " Destajo de " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy")
                Case "UNIDAD DE TRABAJO(CORTE)"
                    Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & Me.cbTipo.EditValue & " " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy")
                    'Case "LIQUIDACION"
                    '    Me.txtDescripcion.Text = "Liquidación Quincena " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy") 'Me.txtDescripcion.Text & " " & 
            End Select
            Me.txtCodigo.EditValue = Format(IIf(Me.cbTipo.EditValue = "CATORCENAL", Rango.End, IIf(Me.cbTipo.EditValue = "SEMANAL", dtFechaPago.EditValue, Rango.Start)), "yyyyMM") & Sufijo
            Me.txtSemanas.EditValue = VB.SysContab.RutinasNomina.BuscarSabados(Rango.Start, Rango.End)
            Me.txtDescripcion.Enabled = False
        ElseIf Me.cbTipo.EditValue.Substring(0, 1) = "V" Then
            Me.txtDescripcion.EditValue = "Pago de Vacaciones desde " & Rango.Start.ToShortDateString & " hasta " & Rango.End.ToShortDateString
            Me.txtCodigo.EditValue = Format(DateAdd(DateInterval.Day, 1, Rango.End), "yyyyMM") & Sufijo
            Me.txtDescripcion.Enabled = False
            Me.txtSemanas.EditValue = 0
        ElseIf Me.cbTipo.EditValue.Substring(0, 1) = "E" Then
            Me.txtDescripcion.EditValue = "Pago de Nómina Extra desde " & Rango.Start.ToShortDateString & " hasta " & Rango.End.ToShortDateString
            Me.txtDescripcion.Enabled = True
            Me.txtCodigo.EditValue = Format(Rango.End, "yyyyMM") & Sufijo
            Me.txtSemanas.EditValue = 0
        End If
        If Me.cbTipo.EditValue.Substring(0, 1) = "D" Or Me.cbTipo.EditValue.Substring(0, 1) = "U" Then
            Me.cbOrigen.SelectedIndex = 1
            Me.cbOrigen.Enabled = False 'Por el momento dejar que solo cambie el concepto sin que el usuario lo cambie. Por el momento
        Else
            Me.cbOrigen.SelectedIndex = 0
            Me.cbOrigen.Enabled = False
        End If

        If Me.cbTipo.EditValue.Substring(0, 1) = "D" Or Me.cbTipo.EditValue.Substring(0, 1) = "U" Then
            Me.txtMinHextra.Enabled = True
            Me.chkGenIndemnizacion.Enabled = True
        Else
            Me.txtMinHextra.Enabled = False
            Me.chkGenIndemnizacion.Enabled = False
        End If

        Me.dtpMCS.EditValue = Mes.MaxDate
        Me.dtpSnack.EditValue = Mes.MaxDate

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Dejar este codigo para el caso de que se resuelva si la seleccion es permitida al usuario.'
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '   Me.Mes.Enabled = True
        '   Select Case cbTipo.SelectedText
        '    Case "SEMANAL"
        '        Me.Mes.MaxSelectionCount = 7
        '        Me.Mes.MinDate = IIf(Weekday(CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))) = 1, _
        '               Me.Mes.TodayDate, _
        '               DateAdd(DateInterval.Day, 2 + Weekday(CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))), _
        '                   CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))))
        '        Me.Mes.MaxDate = DateAdd(DateInterval.Day, 27, Me.Mes.MinDate)
        '    Case "QUINCENAL"
        '        Me.Mes.MaxSelectionCount = 15
        '        Me.Mes.MinDate = CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '        Me.Mes.MaxDate = CDate(Trim(Str(Meses(Month(Me.Mes.TodayDate) - 1))) + "/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '    Case "MENSUAL"
        '        Me.Mes.MaxSelectionCount = Meses(Month(Me.Mes.TodayDate))
        '        Me.Mes.MinDate = CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '        Me.Mes.MaxDate = CDate(Trim(Str(Meses(Month(Me.Mes.TodayDate) - 1))) + "/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '    Case "DESTAJO"
        '        Me.Mes.MaxSelectionCount = Meses(Month(Me.Mes.TodayDate))
        '        Me.Mes.MinDate = CDate("01/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))
        '        Me.Mes.MaxDate = CDate(Trim(Str(Meses(Month(Me.Mes.TodayDate) - 1))) + "/" + Format(Me.Mes.TodayDate, "MM") + "/" + Format(Me.Mes.TodayDate, "yyyy"))

        'End Select
    End Sub

    Private Sub cbTipo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbTipo.Validating
        Validacion()
    End Sub

    Private Sub Mes_DateChanged(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles Mes.DateChanged
        If iniciado Then
            If (Me.cbTipo.EditValue.Substring(0, 1) = "D" Or Me.cbTipo.EditValue.Substring(0, 1) = "U") Then
                If (DateDiff(DateInterval.Day, Me.Mes.SelectionStart, Me.Mes.SelectionEnd) + 1) Mod 7 <> 0 Then
                    Me.Mes.SelectionEnd = DateAdd(DateInterval.Day, ((((DateDiff(DateInterval.Day, Me.Mes.SelectionStart, Me.Mes.SelectionEnd) + 1) \ 7) + 1) * 7) - 1, Me.Mes.SelectionStart)
                End If


                If Sufijo <> "" And (Me.cbTipo.EditValue.Substring(0, 1) <> "V" And _
                    Me.cbTipo.EditValue.Substring(0, 1) <> "E") Then
                    Select Case Sufijo
                        Case "01"
                            Me.txtDescripcion.EditValue = IIf(Me.cbTipo.EditValue.Substring(0, 1) = "M", "1er", "1era")

                        Case "02"
                            Me.txtDescripcion.EditValue = IIf(Me.cbTipo.EditValue.Substring(0, 1) = "M", "2do", "2da")

                        Case "03"
                            Me.txtDescripcion.EditValue = IIf(Me.cbTipo.EditValue.Substring(0, 1) <> "S" And Me.cbTipo.EditValue.Substring(0, 1) <> "D" And Me.cbTipo.EditValue.Substring(0, 1) <> "U", "Error-", "3ra")

                        Case "04"
                            Me.txtDescripcion.EditValue = IIf(Me.cbTipo.EditValue.Substring(0, 1) <> "S", "Error-", "4ta")
                    End Select

                    Select Case Me.cbTipo.EditValue
                        Case "SEMANAL"
                            Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & "Semana " & Format(Me.Mes.SelectionEnd, "MMM") & "-" & Format(Me.Mes.SelectionEnd, "yyyy")
                        Case "CATORCENAL"
                            Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & "Catorcena " & Format(Me.Mes.SelectionEnd, "MMM") & "-" & Format(Me.Mes.SelectionEnd, "yyyy")
                        Case "QUINCENAL"
                            Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & "Quincena " & Format(Me.Mes.SelectionStart, "MMM") & "-" & Format(Me.Mes.SelectionStart, "yyyy")
                        Case "MENSUAL"
                            Me.txtDescripcion.EditValue = "Mes de " & Format(Rango.Start, "MMMM") & "-" & Format(Me.Mes.SelectionStart, "yyyy")
                        Case "DESTAJO"
                            Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & " Destajo de " & Format(Me.Mes.SelectionStart, "MMM") & "-" & Format(Me.Mes.SelectionStart, "yyyy")
                        Case "UNIDAD DE TRABAJO(CORTE)"
                            Me.txtDescripcion.EditValue = Me.txtDescripcion.EditValue & " " & Me.cbTipo.EditValue & " " & Format(Me.Mes.SelectionStart, "MMM") & "-" & Format(Me.Mes.SelectionStart, "yyyy")
                            'Case "LIQUIDACION"
                            '    Me.txtDescripcion.Text = "Liquidación Quincena " & Format(Rango.Start, "MMM") & "-" & Format(Rango.Start, "yyyy") 'Me.txtDescripcion.Text & " " & 
                    End Select
                End If
                Me.txtCodigo.EditValue = Format(IIf(Me.cbTipo.EditValue = "CATORCENAL" Or Me.cbTipo.EditValue = "SEMANAL", Me.Mes.SelectionEnd, Me.Mes.SelectionStart), "yyyyMM") & Sufijo
                Me.txtSemanas.EditValue = VB.SysContab.RutinasNomina.BuscarSabados(Me.Mes.SelectionStart, Me.Mes.SelectionEnd)
            End If
        End If
    End Sub

    Private Sub cmdCerrarDia_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrarDia.Click
        If Me.dgFechas.Visible = True Then
            If Me.Vista.DataRowCount = 0 Then
                MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
                Exit Sub
            Else
                If Me.Vista.GetFocusedRowCellValue("Cerrado") = True Then
                    If MsgBox("Este Dia ya esta cerrado, desea re-abrirlo para edición?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sts.Nomina") = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        VB.SysContab.PeriodoNominaDB.PeriodoNomina_Fecha_Cerrar(Me.txtCodigo.EditValue.Substring(0, 8), _
                            Me.cbTipo.EditValue.Substring(0, 1), Me.Vista.GetFocusedRowCellValue("Fecha"), False)
                        Me.Vista.SetFocusedRowCellValue(Me.Vista.Columns("Cerrado"), False)
                    End If
                Else
                    MsgBox("No se puede cerrar un dia desde la Nomina, favor comunicarse" & vbCrLf & _
                        "con el administrador de SysAsistencias", MsgBoxStyle.Critical, "Sts.Nomina")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub dtFechaPago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaPago.EditValueChanged
        If Not Me.cbTipo.EditValue Is Nothing Then
        ElseIf Not Me.cbTipo.EditValue Is DBNull.Value Then
            Validacion()
        End If
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged

    End Sub
End Class