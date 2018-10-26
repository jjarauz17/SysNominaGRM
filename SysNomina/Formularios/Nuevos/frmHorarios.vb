﻿Imports System.IO
Public Class frmHorarios
    Private Sub frmHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()

        Me.Text = "Mantenimiento de Horarios"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub
    Private Sub Cargar()
        dgHorarios.DataSource = VB.SysContab.HorarioDB.GetList().Tables("Horario")
        Me.VHorarios.Columns("Entrada").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.VHorarios.Columns("Entrada").DisplayFormat.FormatString = "hh:mm tt"
        Me.VHorarios.Columns("Salida").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.VHorarios.Columns("Salida").DisplayFormat.FormatString = "hh:mm tt"

        If Me.VHorarios.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.VHorarios.GetFocusedRowCellValue("Codigo")
        End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarHorario = frmAgregarHorario.Instance
        Nuevo = "SI"
        f.ShowDialog()
        Me.Cargar()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.VHorarios.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim f As frmAgregarHorario = frmAgregarHorario.Instance
        Nuevo = "NO"
        Registro = Me.VHorarios.GetFocusedRowCellValue("Codigo")
        f.cmdAceptar.Enabled = IIf(Registro = "000", False, True)
        f.ShowDialog()
        Me.Cargar()

    End Sub



    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VHorarios.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        Registro = Me.VHorarios.GetFocusedRowCellValue("Codigo")
        If Registro = "000" Then
            MsgBox("Este registro no se debe borrar", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("Esta seguro que dese borrar el Horario: " & Me.VHorarios.GetFocusedRowCellValue("Descripcion"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        VB.SysContab.HorarioDB.Delete(Registro)
        Cargar()

    End Sub



    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub VHorarios_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VHorarios.FocusedRowChanged
        Registro = Me.VHorarios.GetFocusedRowCellValue("Codigo")
    End Sub
End Class