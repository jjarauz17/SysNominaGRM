Public Class frmPeriodoFiscalNomina

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmPeriodoFiscalNomina_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar()

    End Sub

    Sub cargar()
        Me.dgLista.DataSource = VB.SysContab.PeriodosDB.GetList()
        Me.vLista.PopulateColumns()
        Me.vLista.Columns("empr_codigo").Visible = False
        Me.vLista.Columns("per_id").Visible = False
        Me.vLista.Columns("per_inicio").Caption = "Inicio"
        Me.vLista.Columns("per_final").Caption = "Final"
        Me.vLista.Columns("per_descripcion").Caption = "Descripción"
        Me.vLista.Columns("per_activo").Caption = "Activo"
        Me.vLista.Columns("per_accion").Caption = "Accion"
        Me.vLista.Columns("per_estado").Caption = "Estado"
        Me.vLista.Columns("per_actual").Visible = False
        Me.vLista.BestFitColumns()
    End Sub
    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        VB.SysContab.PeriodosDB.Borrar(Me.vLista.GetFocusedRowCellValue("per_id"))
        cargar()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As New frmAgregarPeriodoFiscal
        f.Modo = False
        f.ShowDialog()
        f.Dispose()
        Me.cargar()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As New frmAgregarPeriodoFiscal
        f.Modo = True
        f.ID = Me.vLista.GetFocusedRowCellValue("per_id")
        f.ShowDialog()
        f.Dispose()
        Me.cargar()
    End Sub
End Class