
Public Class frmProcesar_Asistencias

    Private Sub frmProcesar_Asistencias_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.cbPeriodoNomina.Properties.DataSource = VB.SysContab.PeriodoNominaDB.GetList_Activos().Tables(0)
        Me.cbPeriodoNomina.Properties.DisplayMember = "per_descripcion"
        Me.cbPeriodoNomina.Properties.ValueMember = "per_codigo"

        cbPeriodoNomina.Properties.NullText = "[Seleccione el Periodo de Nomina]"
        cbPeriodoNomina.Properties.ShowFooter = False
        cbPeriodoNomina.Properties.PopulateViewColumns()


        For i As Integer = 0 To cbPeriodoNomina.Properties.View.Columns.Count - 1
            If cbPeriodoNomina.Properties.View.Columns.Item(i).FieldName <> cbPeriodoNomina.Properties.DisplayMember Then cbPeriodoNomina.Properties.View.Columns.Item(i).Visible = False
        Next
        cbPeriodoNomina.Properties.View.Columns("per_finicio").Visible = True
        cbPeriodoNomina.Properties.View.Columns("per_ffinal").Visible = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim errores As Integer = 0
        If Me.cbPeriodoNomina.EditValue Is Nothing Then
            Exit Sub
        End If
        If Me.cbPeriodoNomina.EditValue Is DBNull.Value Then
            Exit Sub
        End If
        Me.vLista.Columns.Clear()
        Me.dgProcesar.DataSource = Catalogos.EDU_Procesar_Asistencias(Me.cbPeriodoNomina.EditValue, errores)
        If errores > 0 Then
            MsgBox("Hay " & errores.ToString & " registros con errores, los cuales no se procesaran. Por favor revisar.")
        End If
        For i As Integer = 0 To Me.vLista.Columns.Count - 2
            Me.vLista.Columns(i).OptionsColumn.ReadOnly = True
            Me.vLista.Columns(i).OptionsColumn.AllowFocus = False
        Next

    End Sub

    Private Sub chkMarcarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarcarTodos.CheckedChanged
        For i As Integer = 0 To Me.vLista.DataRowCount - 1
            Me.vLista.SetRowCellValue(i, "Procesar", Me.chkMarcarTodos.EditValue)
        Next
    End Sub

    Private Sub cmdProcesar_Click(sender As Object, e As EventArgs) Handles cmdProcesar.Click

        Dim dt As New DataTable
        dt = Catalogos.EDU_Configuraciones()
        If dt.Rows.Count = 0 Then
            MsgBox("No hay registro de configuracion para las transacciones de tipo EDU")
            Return
        End If

        Dim detalle As New VB.SysContab.PeriodoNominaDetails
        detalle = VB.SysContab.PeriodoNominaDB.GetDetails(QuincenaTrabajo)

        ADORNOS.ShowSplash()
        For i As Integer = 0 To Me.vLista.DataRowCount - 1
            If Me.vLista.GetRowCellValue(i, "Error") = False Then
                If Me.vLista.GetRowCellValue(i, "Procesar") = True Then
                    If Me.vLista.GetRowCellValue(i, "Procesado") = False Then
                        If VB.SysContab.IngresoDB.Additem_EDU(Me.vLista.GetRowCellValue(i, "id"), _
                        Me.vLista.GetRowCellValue(i, "Empleado"), Date.Now, detalle.FFinal, _
                        Me.vLista.GetRowCellValue(i, "Monto"), Me.vLista.GetRowCellValue(i, "tdi"), False, _
                        Me.vLista.GetRowCellValue(i, "Moneda"), True, True, False, _
                        Me.vLista.GetRowCellValue(i, "Horas"), 0,
                        Me.vLista.GetRowCellValue(i, "Descripcion")) = True Then
                            Me.vLista.SetRowCellValue(i, "Procesado", True)
                        End If
                    End If
                End If
            End If
        Next
        ADORNOS.HideSplash()
    End Sub
End Class