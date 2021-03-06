﻿Imports System.IO

Public Class frmAreas
    Private Sub frmAreas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cargar()
        Me.Text = "Mantenimiento de Areas"
        Me.Refresh()

    End Sub

    Private Sub cargar()
        dgAreas.DataSource = VB.SysContab.AreaDB.GetListGrid().Tables("Areas").DefaultView
        Me.VAreas.Columns("Depto").Visible = False
        Me.VAreas.Columns("cArea").Visible = False
        If VAreas.DataRowCount = 0 Then
            Registro = "Vacio"
            Registro1 = "Vacio"
        Else
            Registro = VAreas.GetFocusedRowCellValue("Depto")
            Registro1 = VAreas.GetFocusedRowCellValue("cArea")
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarArea = frmAgregarArea.Instance
        Nuevo = "SI"
        z.ShowDialog()
        Me.cargar()
    End Sub


    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.VAreas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = VAreas.GetFocusedRowCellValue("Depto")
        Registro1 = VAreas.GetFocusedRowCellValue("cArea")

        Dim f As frmAgregarArea = frmAgregarArea.Instance
        Nuevo = "NO"
        If Registro = "Vacio" Then
            MsgBox("Seleccione el Area que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If
        f.ShowDialog()
        Me.cargar()
    End Sub



    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.VAreas.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = VAreas.GetFocusedRowCellValue("Depto")
        Registro1 = VAreas.GetFocusedRowCellValue("cArea")

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Area que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Esta seguro que dese borrar el Area: " & _
            VAreas.GetFocusedRowCellValue("Depto") & " - " & _
            VAreas.GetFocusedRowCellValue("cArea"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            VB.SysContab.AreaDB.delete(VAreas.GetFocusedRowCellValue("Depto"), VAreas.GetFocusedRowCellValue("cArea"))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try


        dgAreas.DataSource = VB.SysContab.AreaDB.GetListGrid.Tables("areas")

        If Me.VAreas.DataRowCount = 0 Then
            Registro = "Vacio"
            Registro1 = "Vacio"
        Else
            Registro = VAreas.GetFocusedRowCellValue("Depto")
            Registro1 = VAreas.GetFocusedRowCellValue("cArea")

        End If

    End Sub



    'Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    '    Dim fReportes As New frmReportes()
    '    Dim rDepartamentos As New Object
    '    rDepartamentos = New CrystalDecisions.CrystalReports.Engine.ReportDocument

    '    If Not File.Exists(Application.StartupPath & "\reportes\rptDepartamentos.rpt") Then
    '        MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptDepartamentos.rpt")
    '        Exit Sub
    '    End If

    '    rDepartamentos.load(Application.StartupPath & "\reportes\rptDepartamentos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


    '    Dim Ds As New DataSet
    '    Ds = VB.SysContab.DepartamentosDB.GetListReporte("%", EmpresaActual)
    '    Ds.WriteXml(Application.StartupPath & "\exportfiles\rDepartamentos.xml", XmlWriteMode.WriteSchema)

    '    rDepartamentos.Database.Tables("Departamentos").Location = Application.StartupPath & "\exportfiles\rDepartamentos.xml"
    '    rDepartamentos.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"

    '    '   rDepartamentos.SetDataSource(Departamentos.GetListReporte(txtBuscar.Text, EmpresaActual))
    '    fReportes.crvReportes.ReportSource = rDepartamentos
    '    fReportes.ShowDialog()

    'End Sub

    Private Sub VAreas_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VAreas.FocusedRowChanged
        Registro = VAreas.GetFocusedRowCellValue("Depto")
        Registro1 = VAreas.GetFocusedRowCellValue("cArea")
    End Sub

End Class