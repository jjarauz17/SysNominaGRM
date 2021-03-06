﻿Imports System.IO
Public Class frmMonedas
    Private Sub frmMonedas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()
        Me.Text = "Mantenimiento de Monedas"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()
    End Sub
    Private Sub cargar()
        dgMonedas.DataSource = VB.SysContab.MonedaDB.GetList().Tables("Monedas")
        Me.VMonedas.Columns("Codigo").Width = 80
        Me.VMonedas.Columns("Descripcion").Width = 300
        Me.VMonedas.Columns("Simbolo").Width = 80

        If Me.VMonedas.DataRowCount <> 0 Then
            Registro = Me.VMonedas.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If

    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarMoneda = frmAgregarMoneda.Instance
        Nuevo = "SI"
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VMonedas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim f As frmAgregarMoneda = frmAgregarMoneda.Instance
        Nuevo = "NO"
        Registro = Me.VMonedas.GetFocusedRowCellValue("Codigo")
        f.ShowDialog()
        Me.cargar()
    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.VMonedas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.VMonedas.GetFocusedRowCellValue("Codigo")
        Dim Monedas As New VB.SysContab.MonedaDB()

        If MsgBox("Esta seguro que dese borrar la Moneda: " & Me.VMonedas.GetFocusedRowCellValue("Descripcion"), _
            MsgBoxStyle.YesNo + MsgBoxStyle.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        VB.SysContab.MonedaDB.delete(Me.VMonedas.GetFocusedRowCellValue("Codigo"))

        cargar()
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VMonedas_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VMonedas.FocusedRowChanged
        Registro = Me.VMonedas.GetFocusedRowCellValue("Codigo")
    End Sub
End Class