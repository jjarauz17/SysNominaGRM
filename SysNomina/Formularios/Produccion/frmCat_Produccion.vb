Public Class frmCat_Produccion 

    Private Sub frmCat_Produccion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cargar()
    End Sub
    Private Sub cargar()
        Me.dgDatos.DataSource = Cat_ProdDB.Lista(EmpresaActual, 0, True)
        Me.vLista.PopulateColumns()
        Me.vLista.Columns("cat_codigo").Visible = 0
        Me.vLista.Columns("empr_codigo").Visible = 0

        Me.vLista.Columns("cat_desccorta").Caption = "Descripcion Corta"
        Me.vLista.Columns("cat_descripcion").Caption = "Descripcion"
        Me.vLista.Columns("cat_valor").Caption = "Valor"
        Me.vLista.Columns("cat_valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("cat_valor").DisplayFormat.FormatString = "n2"
        Me.vLista.Columns("cat_dias").Caption = "Dias"
        Me.vLista.Columns("cat_dias").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("cat_dias").DisplayFormat.FormatString = "n0"
        Me.vLista.Columns("cat_salarioxdia").Caption = "Salario por Dia"
        Me.vLista.Columns("cat_salarioxdia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("cat_salarioxdia").DisplayFormat.FormatString = "n2"
        Me.vLista.Columns("cat_minimo").Caption = "Unidades Minimas"
        Me.vLista.Columns("cat_minimo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("cat_minimo").DisplayFormat.FormatString = "n0"
        Me.vLista.Columns("cat_factor").Caption = "Factor"
        Me.vLista.Columns("cat_factor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("cat_factor").DisplayFormat.FormatString = "n4"
        Me.vLista.Columns("cat_activo").Caption = "Activo?"

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        frmCat_Produccion_Detalle.Dispose()
        frmCat_Produccion_Detalle.ID = 0
        frmCat_Produccion_Detalle.StartPosition = FormStartPosition.CenterScreen
        frmCat_Produccion_Detalle.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos que editar")
            Exit Sub
        End If

        frmCat_Produccion_Detalle.Dispose()
        frmCat_Produccion_Detalle.ID = Me.vLista.GetFocusedRowCellValue("cat_codigo")
        frmCat_Produccion_Detalle.StartPosition = FormStartPosition.CenterScreen
        frmCat_Produccion_Detalle.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class