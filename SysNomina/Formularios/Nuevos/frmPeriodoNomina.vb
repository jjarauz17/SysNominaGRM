﻿Imports System.IO
Public Class frmPeriodoNomina
    Private Sub frmPeriodoNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Refrescar()
        If Me.VPeriodos.DataRowCount <> 0 Then
            Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
        Else
            Registro = "Vacio"
        End If
        Me.Text = "Periodos de Nomina" & IIf(QuincenaTrabajo = "", "", "Periodo de Trabajo: " & Microsoft.VisualBasic.Right(QuincenaTrabajo, 8))
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        Me.Refresh()
    End Sub
    Private Sub Refrescar()
        dgPeriodoNomina.DataSource = VB.SysContab.PeriodoNominaDB.GetList(True)
        Me.VPeriodos.Columns("per_codigo").Caption = "Periodo de Nomina" '0

        Me.VPeriodos.Columns("per_descripcion").Caption = "Descripción" '1
        Me.VPeriodos.Columns("per_descripcion").Width = 250

        Me.VPeriodos.Columns("per_procesado").Caption = "Procesada?"  '2
        Me.VPeriodos.Columns("per_revisado").Caption = "Revisada?"  '3
        Me.VPeriodos.Columns("per_aprobado").Caption = "Aprobada?" '4
        Me.VPeriodos.Columns("per_contabilizado").Caption = "Contabilizada?" '5
        Me.VPeriodos.Columns("per_finicio").Caption = "Desde"
        Me.VPeriodos.Columns("per_ffinal").Caption = "Hasta"
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub VPeriodos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VPeriodos.FocusedRowChanged
        Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        Dim PNominaDetails As New VB.SysContab.PeriodoNominaDetails()

        If Me.VPeriodos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        PNominaDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        If PNominaDetails.Tipo = "A" Then
            MsgBox("Esta es una planilla de Aguinaldo, no puede seleccionarse como Periodo de Nomina de Trabajo", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If PNominaDetails.Procesado = True Then
            MsgBox("Este periodo de Nomina ya ha sido procesado, no puede ser seleccionado", MsgBoxStyle.OkOnly, "Error-")
            Exit Sub
        End If

        QuincenaTrabajo = Registro
        'Ver los feriados de semana santa del año de la quincena de trabajo
        VB.SysContab.PeriodoNominaDB.Feriados(Mid(QuincenaTrabajo, 2, 4))
        Me.Text = "Periodos de Nomina - Periodo Actual: " + QuincenaTrabajo

        PNominaDetails = Nothing

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        If Me.VPeriodos.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
        End If
        Nuevo = "SI"
        frmAgregarPeriodoNominaV2.Dispose()
        frmAgregarPeriodoNominaV2.ShowDialog()
        
        'Dim F As New frmAgregarPeriodoNomina()
        'F.ShowDialog()
        Me.Refrescar()
    End Sub


    Private Sub dgPeriodoNomina_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim PNominaDetails As New VB.SysContab.PeriodoNominaDetails()
        PNominaDetails = VB.SysContab.PeriodoNominaDB.GetDetails(Registro)
        If PNominaDetails.Procesado = True Then
            MsgBox("Este periodo de Nomina ya ha sido procesado, no puede ser seleccionado", MsgBoxStyle.OkOnly, "Error-")
            Exit Sub
        End If
        QuincenaTrabajo = Registro
        Me.Text = "Periodos de Nomina - Periodo Actual: " + QuincenaTrabajo
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VPeriodos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.VPeriodos.GetFocusedRowCellValue("per_codigo")
        End If
        Nuevo = "NO"
        'Dim F As New frmAgregarPeriodoNomina()
        'F.ShowDialog()
        frmAgregarPeriodoNominaV2.Dispose()
        frmAgregarPeriodoNominaV2.ShowDialog()
        Me.Refrescar()
    End Sub

End Class