Imports System.IO
Public Class frmCargos
    Private Sub frmCargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cargar()
        Me.Text = "Mantenimiento de Cargos"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cargar()
        dgCargos.DataSource = VB.SysContab.CargosDB.GetList().Tables("Cargos")
        Me.vCargos.OptionsBehavior.Editable = False
        Me.vCargos.Columns("Codigo").Visible = True
        If Me.vCargos.DataRowCount <> 0 Then
            Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarCargo = frmAgregarCargo.Instance
        Nuevo = "SI"
        z.WindowState = FormWindowState.Normal
        z.StartPosition = FormStartPosition.CenterParent
        z.ShowDialog()
        cargar()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.vCargos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Information, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")

        Dim f As frmAgregarCargo = frmAgregarCargo.Instance
        Dim Cargos As New VB.SysContab.CargosDB()

        Nuevo = "NO"
        If Registro = "Vacio" Then
            MsgBox("Seleccione el Cargo que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If
        f.WindowState = FormWindowState.Normal
        f.StartPosition = FormStartPosition.CenterParent
        f.ShowDialog()
        cargar()
    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vCargos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Information, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")
        If MsgBox("Esta seguro que dese borrar el Cargo: " & Me.vCargos.GetFocusedRowCellValue("Codigo") & " - " & Me.vCargos.GetFocusedRowCellValue("Nomina"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            VB.SysContab.CargosDB.delete(Me.vCargos.GetFocusedRowCellValue("Codigo"))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        dgCargos.DataSource = VB.SysContab.CargosDB.GetList().Tables("Cargos")
        If Me.vCargos.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")
        End If

    End Sub


    'Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    '    Dim fReportes As New frmReportes()
    '    Dim rCargos As New Object
    '    rCargos = New CrystalDecisions.CrystalReports.Engine.ReportDocument

    '    If Not File.Exists(Application.StartupPath & "\reportes\rptCargos.rpt") Then
    '        MsgBox("No existe el reporte " & Application.StartupPath & "\reportes\rptCargos.rpt")
    '        Exit Sub
    '    End If

    '    rCargos.load(Application.StartupPath & "\reportes\rptCargos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


    '    Dim Ds As New DataSet
    '    Ds = VB.SysContab.CargosDB.GetListReporte("%", EmpresaActual)
    '    Ds.WriteXml(Application.StartupPath & "\exportfiles\rCargos.xml", XmlWriteMode.WriteSchema)

    '    rCargos.Database.Tables("Cargos").Location = Application.StartupPath & "\exportfiles\rCargos.xml"
    '    rCargos.Database.Tables("Empresa").Location = Application.StartupPath & "\exportfiles\logoempresa.xml"
    '    fReportes.crvReportes.ReportSource = rCargos
    '    fReportes.ShowDialog()

    'End Sub


    Private Sub vCargos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vCargos.FocusedRowChanged
        Registro = Me.vCargos.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub vCargos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vCargos.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.cargar()
        End If
    End Sub
End Class