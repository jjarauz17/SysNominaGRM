﻿Public Class frmIngresos
    Private Shared ChildInstance As frmIngresos = Nothing
    Public Estado As String
    Public Tipo As String

#Region "Variables"
    Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Cancelado] = False")
#End Region

    Private Sub frmIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cargar()
        Me.Text = "Mantenimiento de Ingresos de Empleados"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name & Tipo)
        Me.Refresh()
    End Sub
    Sub cargar()
        dgIngreso.DataSource = VB.SysContab.IngresoDB.GetList().Tables("Ingreso")
        Me.VIngresos.Columns("Forma Pago").Visible = True
        Me.VIngresos.Columns("Codigo").Width = 30
        Me.VIngresos.Columns("Empleado").Width = 250

        Me.VIngresos.Columns("Cancelado").FilterInfo = Filtro
        Me.VIngresos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VIngresos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"
        Me.VIngresos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VIngresos.Columns("Monto").DisplayFormat.FormatString = "n2"

        Me.VIngresos.Columns("Codigo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.VIngresos.Columns("Codigo").SummaryItem.DisplayFormat = "{0:n0}"

        Me.VIngresos.BestFitColumns()
        If Me.VIngresos.DataRowCount <> 0 Then
            Registro = Me.VIngresos.GetRowCellValue(0, "Codigo")
        Else
            Registro = "Vacio"
        End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Using f As frmAgregarIngreso = frmAgregarIngreso.Instance()
            Nuevo = "SI"
            f.ShowDialog()
            Me.cargar()
        End Using
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.VIngresos.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.VIngresos.GetFocusedRowCellValue("Codigo") Is DBNull.Value Then
            MsgBox("Seleccione el Registro que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If
        Registro = Me.VIngresos.GetFocusedRowCellValue("Codigo")
        Using  f As frmAgregarIngreso = frmAgregarIngreso.Instance
        Nuevo = "NO"
        f.ShowDialog()
            Me.cargar()
        End Using
    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        Dim Detalle As New VB.SysContab.IngresoDetails()


        Detalle = VB.SysContab.IngresoDB.GetDetails(Me.VIngresos.GetFocusedRowCellValue("Codigo"))
        If Detalle.Cancelado Then
            MsgBox("No se puede elminar este registro porque ya esta cancelado")
            Exit Sub
        End If


        If VB.SysContab.DetalleIngresoDB.GetList(Me.VIngresos.GetFocusedRowCellValue("Codigo")).Tables(0).Rows.Count > 1 Then
            MsgBox("No de puede borrar el registro porque tiene detalles generados")
            Exit Sub
        End If

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Registro que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Esta seguro que dese borrar el Registro: ", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If


        VB.SysContab.IngresoDB.Delete(Me.VIngresos.GetFocusedRowCellValue("Codigo"))
        dgIngreso.DataSource = VB.SysContab.IngresoDB.GetList().Tables("Ingreso")
        If Me.VIngresos.DataRowCount = 0 Then
            Registro = "Vacio"
        End If


    End Sub

    Private Sub VIngresos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VIngresos.FocusedRowChanged
        Registro = Me.VIngresos.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub cmdLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLote.Click
        If QuincenaTrabajo = "" Then
            Dim g As frmSeleccionarPeriodo = frmSeleccionarPeriodo.Instance
            g.ShowDialog()
            If QuincenaTrabajo = "" Then
                Exit Sub
            End If
        End If
        Dim f As New frmIngresos_Tipo
        f.StartPosition = FormStartPosition.CenterScreen
        f.WindowState = FormWindowState.Maximized
        Nuevo = "SI"
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked Then
            Me.VIngresos.Columns("Cancelado").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "")
        Else : Me.VIngresos.Columns("Cancelado").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Cancelado] = False")
        End If
        Me.VIngresos.BestFitColumns()
    End Sub
    Private Sub VDeduccion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VIngresos.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.cargar()
        End If
    End Sub
End Class