Public Class frmEmpleados_Categorias 

    Public Cargado As Boolean = False
    Private Sub frmEmpleados_Categorias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbTipoPago.Properties.DataSource = VB.SysContab.PeriodoNominaDB.RH_TipoNomina()
        Me.cbTipoPago.Properties.DisplayMember = "tpa_descripcion"
        Me.cbTipoPago.Properties.ValueMember = "tpa_ID"
        Me.cbTipoPago.EditValue = "%"

        Me.Cargar()
        Cargado = True
    End Sub

    Private Sub Cargar()
        Me.cbCategorias.DataSource = Cat_ProdDB.Lista(EmpresaActual, 0, False)
        Me.cbCategorias.DisplayMember = "cat_descripcion"
        Me.cbCategorias.ValueMember = "cat_codigo"

        Me.cbCategoria_2.Properties.DataSource = Cat_ProdDB.Lista(EmpresaActual, 0, False)
        Me.cbCategoria_2.Properties.DisplayMember = "cat_descripcion"
        Me.cbCategoria_2.Properties.ValueMember = "cat_codigo"

        Me.dgDatos.DataSource = Empleado_Categoria.Listar(EmpresaActual, 0, Me.cbTipoPago.EditValue)
        Me.vLista.PopulateColumns()
        For i As Integer = 0 To vLista.Columns.Count - 2
            vLista.Columns(i).OptionsColumn.AllowEdit = False
            vLista.Columns(i).OptionsColumn.AllowFocus = False
        Next

        Me.vLista.Columns("emp_codigo").Caption = "Codigo"
        Me.vLista.Columns("nombre").Caption = "Nombre"
        Me.vLista.Columns("dep_codigo").Visible = False
        Me.vLista.Columns("are_codigo").Visible = False
        Me.vLista.Columns("area").Caption = "Area"
        Me.vLista.Columns("cgo_nombre").Caption = "Cargo"
        Me.vLista.Columns("cat_codigo").Caption = "Categoria"
        Me.vLista.Columns("cat_codigo").ColumnEdit = Me.cbCategorias
        Me.vLista.Columns("id").Visible = False
        Me.vLista.Columns("emp_formapago").Caption = "Forma Pago"
        Me.vLista.Columns("emp_codigo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.vLista.Columns("emp_codigo").SummaryItem.DisplayFormat = "{0:n0}"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        For i As Integer = 0 To vLista.DataRowCount - 1
            Empleado_Categoria.Agregar_Editar(vLista.GetRowCellValue(i, "id"), _
                EmpresaActual, _
                vLista.GetRowCellValue(i, "emp_codigo"), _
                Me.vLista.GetRowCellValue(i, "cat_codigo"))
        Next
        Me.Cargar()
    End Sub

    Private Sub cmdAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAplicar.Click
        For i As Integer = 0 To vLista.DataRowCount - 1
            Me.vLista.SetRowCellValue(i, "cat_codigo", Me.cbCategoria_2.EditValue)
        Next
    End Sub

    Private Sub vLista_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vLista.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Cargar()
        End If
    End Sub

    Private Sub cbTipoPago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoPago.EditValueChanged
        If Cargado Then
            Me.Cargar()
        End If
    End Sub
End Class