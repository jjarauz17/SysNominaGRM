Imports System.IO
Public Class frmGMovimientos

#Region "Variables"
    Dim TDeducciones, TDetDeducciones As DataTable
    Dim TIngresos, TDetIngresos As DataTable

    Dim D As New VB.SysContab.DeduccionDB(), DD As New VB.SysContab.DetalleDeduccionDB()
    Dim Ing As New VB.SysContab.IngresoDB(), DIng As New VB.SysContab.DetalleIngresoDB()
    Dim Permisos As New VB.SysContab.PermisosDB(), DPermisos As New VB.SysContab.PermisosDetails()
    Dim PeriodoNomina As New VB.SysContab.PeriodoNominaDB(), DPN As New VB.SysContab.PeriodoNominaDetails()
    Dim cEmpleado As String, cMovimiento As String
    Dim Tabla As DataTable
    Dim ds As DataSet, ds2 As DataSet, ds3 As DataSet
    Dim ED As New VB.SysContab.EmpresasDetails
    Friend WithEvents PBar As DevExpress.XtraEditors.MarqueeProgressBarControl
#End Region

    Private Sub frmGenMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refrescar()
        '
        If Me.VPeriodos.DataRowCount <> 0 Then
            Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
            Me.cmdGenDef.Enabled = True
        Else
            Registro = "Vacio"
            Me.cmdGenDef.Enabled = False
        End If
        '
        Me.Text = "Periodos de Nomina" & IIf(QuincenaTrabajo = "", "", "Periodo de Trabajo: " & Microsoft.VisualBasic.Right(QuincenaTrabajo, 8))
        Me.Refresh()
    End Sub

    Private Sub refrescar()
        ED = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        dgPeriodoNomina.DataSource = VB.SysContab.PeriodoNominaDB.GetListFiltro("%", "0", "0").Tables("PeriodoNomina")
        Me.VPeriodos.Columns("per_codigo").Caption = "Periodo"
        Me.VPeriodos.Columns("per_descripcion").Caption = "Descripción"
        Me.VPeriodos.Columns("per_finicio").Caption = "Fecha Inicio"
        Me.VPeriodos.Columns("per_ffinal").Caption = "Fecha Final"

        Me.VPeriodos.Columns(0).Width = 50
        Me.VPeriodos.Columns(1).Width = 250
        Me.VPeriodos.Columns(2).Width = 80
        Me.VPeriodos.Columns(3).Width = 80
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdGenDef_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGenDef.Click
        If Me.VPeriodos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        'Me.Cursor = Cursors.WaitCursor
        ShowSplash()
        Dim i As Integer
        Dim myds As DataSet, MCS As DataSet
        Dim Actualizados, Agregados As Integer, sPeriodo As String


        Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")

        sPeriodo = Registro.Substring(0, 1) & "-" & Registro.Substring(1, 8)
        DPN = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        'Ver si se van a deshacer los movimientos
        'o lo busco en dpn o en el check de la pantalla
        If DPN.Procesado Then
            MsgBox("Este periodo ya tiene generada la planilla. No se pueden deshacer sus movimientos", MsgBoxStyle.Critical, "STS-Nomina")
            'Me.Cursor = Cursors.Default
            HideSplash()
            Exit Sub
        Else
            If DPN.MovGen Then
                If MsgBox("Los movimientos de este periodo ya fueron generados, desea revertir este proceso?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "STS-Nomina") = MsgBoxResult.Yes Then
                    'Deshacer movimientos de Permisos
                    'PBar.Enabled = True
                    'PBar.Visible = True
                    'PBar.Properties.Stopped = False
                    'Refresh()
                    VB.SysContab.PeriodoNominaDB.Movimientos_Produccion(Registro.Substring(1, 8), Registro.Substring(0, 1), True)
                    VB.SysContab.PermisosDB.Aplicar_Undo(Registro.Substring(1, 8), Registro.Substring(0, 1))
                    VB.SysContab.PeriodoNominaDB.Movimientos_Undo(Registro.Substring(1, 8), Registro.Substring(0, 1))

                    VB.SysContab.PermisosDB.Undo_Subsidios(Registro.Substring(1, 8), Registro.Substring(0, 1))

                    VB.SysContab.MCS_DB.AplicarTransaccion("%", False, Registro, "", "")

                    VB.SysContab.MCS_DB.SnackBar_AplicarTransaccion(Registro.Substring(0, 1), _
                        Registro.Substring(1, 8), "%", "", False)

                    PeriodoNomina.MovGen(Registro.Substring(1, 8), Registro.Substring(0, 1), False)
                    Me.VPeriodos.SetFocusedRowCellValue(Me.VPeriodos.Columns("Movimientos Generados"), False)
                    MsgBox("Movimientos Revertidos", MsgBoxStyle.Information, "STS-Nomina")
                    GoTo Final
                Else
                    'Me.Cursor = Cursors.Default
                    HideSplash()
                    Exit Sub
                End If
            Else
                'PBar.Enabled = True
                'PBar.Visible = True
                'PBar.Properties.Stopped = False
                'Refresh()

                'Paso 0: Procesar la comida si la empresa tiene configurado el modulo de comida
                If ED.MCS And Registro.Substring(0, 1) = "Q" Then
                    Dim nTransaccion As String = ""
                    Dim nTransaccion2 As String = ""

                    myds = VB.SysContab.MCS_DB.GetList(False, Registro.Substring(1, 8), Registro.Substring(0, 1))
                    'MsgBox("Comida" & myds.Tables(0).Rows.Count)
                    MCS = VB.SysContab.MCS_DB.GetConfiguracion
                    If MCS Is Nothing Then
                        MsgBox("No se han configurado las cuentas para las deducciones el modulo MCS", MsgBoxStyle.Critical, "STS-Nomina")
                        GoTo Final
                        'Exit Sub
                    End If
                    If Registro.Substring(0, 1) = "A" Or Registro.Substring(0, 1) = "E" Or Registro.Substring(0, 1) = "V" Then
                        GoTo continuar
                    End If
                    For i = 0 To myds.Tables(0).Rows.Count - 1
                        Try

                            If myds.Tables(0).Rows(i)("Empleado") > 0 Then
                                cMovimiento = VB.SysContab.DeduccionDB.GetListCodigoNvo()
                                nTransaccion = cMovimiento
                                'Agregar la Deduccion del empleado
                                If VB.SysContab.DeduccionDB.Additem(cMovimiento, myds.Tables(0).Rows(i)("emp_codigo"), _
                                                    CDate(Format(Now.Date, "dd/MM/yyyy")), _
                                                    DPN.FFinal, _
                                                    myds.Tables(0).Rows(i)("Empleado"), _
                                                    myds.Tables(0).Rows(i)("Empleado"), _
                                                    1, _
                                                    myds.Tables(0).Rows(i)("Empleado"), _
                                                    0.0, _
                                                    MCS.Tables(0).Rows(0)("emp_deduccion"), _
                                                    True, _
                                                    False, _
                                                    False, _
                                                    ED.MONEDABASE, _
                                                    True, _
                                                    True, False, 0, 0, nTransaccion, "Deduccion Automatica MCS") = False Then
                                    Exit For
                                End If
                            End If

                            If myds.Tables(0).Rows(i)("Iva_Empleado") > 0 Then
                                cMovimiento = VB.SysContab.DeduccionDB.GetListCodigoNvo()
                                nTransaccion2 = cMovimiento
                                'Agregar la Deduccion del IVA empleado
                                If VB.SysContab.DeduccionDB.Additem(cMovimiento, myds.Tables(0).Rows(i)("emp_codigo"), _
                                                        CDate(Format(Now.Date, "dd/MM/yyyy")), _
                                                        DPN.FFinal, _
                                                        myds.Tables(0).Rows(i)("Iva_Empleado"), _
                                                        myds.Tables(0).Rows(i)("Iva_Empleado"), _
                                                        1, _
                                                        myds.Tables(0).Rows(i)("Iva_Empleado"), _
                                                        0.0, _
                                                        MCS.Tables(0).Rows(0)("emp_deduccion_iva"), _
                                                        True, _
                                                        False, _
                                                        False, _
                                                        ED.MONEDABASE, _
                                                        True, _
                                                        True, False, 0, 0, nTransaccion2, "Deduccion automatica MCS") = False Then
                                    Exit For
                                End If

                            End If
                            VB.SysContab.MCS_DB.AplicarTransaccion(myds.Tables(0).Rows(i)("emp_codigo"), _
                                                                              True, Registro, _
                                                                              nTransaccion, nTransaccion2)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Try
                        End Try


                    Next
                    myds.Clear()
                End If
                'Paso 0.1: Snack Bar
                Dim nTSnack As String = ""
                Dim mydt As New DataTable
                If Registro.Substring(0, 1) = "Q" Then
                    mydt = VB.SysContab.MCS_DB.SnackBar_GetList(Registro.Substring(1, 8), Registro.Substring(0, 1))
                Else : mydt = Nothing
                End If

                If Not mydt Is Nothing Then
                    'MsgBox("Comida" & mydt.Rows.Count)
                    For i = 0 To mydt.Rows.Count - 1
                        Try
                            cMovimiento = ""
                            If mydt.Rows(i)("total") > 0 Then
                                cMovimiento = VB.SysContab.DeduccionDB.GetListCodigoNvo()
                                nTSnack = cMovimiento
                                'Agregar la Deduccion del empleado
                                If VB.SysContab.DeduccionDB.Additem(cMovimiento, _
                                        mydt.Rows(i)("emp_codigo"), _
                                        CDate(Format(Now.Date, "dd/MM/yyyy")), _
                                        DPN.FFinal, _
                                        mydt.Rows(i)("total"), _
                                        mydt.Rows(i)("total"), _
                                        1, _
                                        mydt.Rows(i)("total"), _
                                        0.0, _
                                        mydt.Rows(i)("Codigo_Deduccion"), _
                                        True, _
                                        False, _
                                        False, _
                                        ED.MONEDABASE, _
                                        True, _
                                        True, False, 0, 0, nTSnack, "Deduccion automatica SNACKBAR") = False Then
                                    Exit For
                                End If
                            End If

                            VB.SysContab.MCS_DB.SnackBar_AplicarTransaccion(Registro.Substring(0, 1), _
                            Registro.Substring(1, 8), mydt.Rows(i)("emp_codigo"), nTSnack, True)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Try
                        End Try
                    Next
                    mydt.Clear()
                End If

                'Paso 1: Procesar los permisos
Continuar:      myds = VB.SysContab.PermisosDB.GetList_Aplicar(Registro.Substring(1, 8), Registro.Substring(0, 1))
                For i = 0 To myds.Tables(0).Rows.Count - 1
                    VB.SysContab.PermisosDB.Add(myds.Tables(0).Rows(i)("prm_codigo"), _
                        Registro.Substring(1, 8), _
                        Registro.Substring(0, 1), _
                        myds.Tables(0).Rows(i)("prm_cantidad"), myds.Tables(0).Rows(i)("prm_sextodia"), _
                        myds.Tables(0).Rows(i)("prm_septimodia"), myds.Tables(0).Rows(i)("prm_hasta"))

                    VB.SysContab.PermisosDB.UpdateSaldo(myds.Tables(0).Rows(i)("prm_codigo"), myds.Tables(0).Rows(i)("prm_cantidad"))
                Next

                If DPN.Tipo = "S" Then
                    Agregados += VB.SysContab.PeriodoNominaDB.Movimientos_Produccion(Registro.Substring(1, 8), Registro.Substring(0, 1), False)
                End If

                VB.SysContab.PermisosDB.Do_Subsidios(Registro.Substring(1, 8), Registro.Substring(0, 1))

                'DEDUCCIONES 
                Agregados += VB.SysContab.DeduccionDB.GenerarDeducciones(Registro.Substring(1, 8), Registro.Substring(0, 1))
                Agregados += VB.SysContab.IngresoDB.GenerarIngresos(Registro.Substring(1, 8), Registro.Substring(0, 1))



                'PBar.Properties.Stopped = True
                'PBar.Enabled = False
                'PBar.Visible = False

                PeriodoNomina.MovGen(Registro.Substring(1, 8), Registro.Substring(0, 1), True)
                Me.VPeriodos.SetFocusedRowCellValue(Me.VPeriodos.Columns("Movimientos Generados"), True)
                MsgBox("Se han Agregado " & Agregados.ToString & " registro(s) y Actualizado " & Actualizados.ToString & " registro(s)", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                ''''Aca termina el proceso de Generar Movimientos
                'Me.Cursor = Cursors.Default
                HideSplash()
                Exit Sub
            End If

        End If
Final:
        'Me.Cursor = Cursors.Default
        HideSplash()
        'PBar.Properties.Stopped = True
        'PBar.Enabled = False
        'PBar.Visible = False
    End Sub
    Private Sub VPeriodos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VPeriodos.FocusedRowChanged
        If VPeriodos.FocusedRowHandle < 0 Then Exit Sub

        'Guarda el código nomina seleccionado en el grid
        Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")

        If Registro = "Vacio" Then
            DPN = Nothing
            Me.cmdGenDef.Enabled = False
        Else
            DPN = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
            Me.cmdGenDef.Enabled = True

        End If
    End Sub

    Private Sub dgPeriodoNomina_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgPeriodoNomina.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.refrescar()
        End If
    End Sub
    Private Sub frmGMovimientos_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refrescar()
        End If
    End Sub
End Class