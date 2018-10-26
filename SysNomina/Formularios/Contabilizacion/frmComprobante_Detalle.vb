Public Class frmComprobante_Detalle 

#Region "Variables"
    Public rubro As String
    Public periodo As String
    Public organigrama As Integer
#End Region

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmComprobante_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.Lista_Combo("0")
        Me.cbEmpleados.DisplayMember = "nombre"
        Me.cbEmpleados.ValueMember = "emp_codigo"
        Me.GridControl1.DataSource = VB.SysContab.RH_OrganigramaDB.RH_PlanillaContabilizar_Detalle(rubro, periodo, organigrama)
        If Not Me.GridControl1.DataSource Is Nothing Then
            Me.GridView1.Columns("emp_codigo").ColumnEdit = Me.cbEmpleados
            Me.GridView1.Columns("emp_codigo").Caption = "Empleado"
            Me.GridView1.Columns("mov_codigo").Caption = "Codigo"
            Me.GridView1.Columns("mov_concepto").Caption = "Concepto"
            Me.GridView1.Columns("mov_cantidad").Caption = "Cantidad"
            Me.GridView1.Columns("mov_cantidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridView1.Columns("mov_cantidad").DisplayFormat.FormatString = "n2"
            Me.GridView1.Columns("mov_valor").Caption = "Valor"
            Me.GridView1.Columns("mov_valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridView1.Columns("mov_valor").DisplayFormat.FormatString = "n2"
            Me.GridView1.Columns("mov_valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridView1.Columns("mov_valor").SummaryItem.DisplayFormat = "{0:n2}"
            Me.GridView1.Columns("porcentaje").Caption = "Porcentaje"
        End If
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        Dim forma As New frmExportarImprimir
        forma.Mostrar(Me.GridControl1)
    End Sub
End Class