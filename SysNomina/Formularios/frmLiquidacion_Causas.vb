Public Class frmLiquidacion_Causas 

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        frmLiquidacion_Causas_Detalle.Dispose()
        frmLiquidacion_Causas_Detalle.ID = 0
        frmLiquidacion_Causas_Detalle.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click

        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista")
            Exit Sub
        End If
        frmLiquidacion_Causas_Detalle.Dispose()
        frmLiquidacion_Causas_Detalle.ID = Me.vLista.GetFocusedRowCellValue("id")
        frmLiquidacion_Causas_Detalle.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista")
            Exit Sub
        End If

        VB.SysContab.LiquidacionDB.Liquidacion_Causas_Add(Me.vLista.GetFocusedRowCellValue("id"), _
            "", False, False, False, "F", 1)
        Me.cargar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmLiquidacion_Causas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cargar()
    End Sub

    Sub cargar()
        Me.dgDatos.DataSource = VB.SysContab.LiquidacionDB.Liquidacion_Causas("0", "%")
        Me.vLista.Columns("id").Caption = "ID"
        Me.vLista.Columns("descripcion").Caption = "Descripción"
        Me.vLista.Columns("vacaciones").Visible = False
        Me.vLista.Columns("aguinaldo").Visible = False
        Me.vLista.Columns("indemnizacion").Visible = False
        Me.vLista.Columns("tipo_contrato").Visible = False
        Me.vLista.BestFitColumns()
    End Sub

End Class