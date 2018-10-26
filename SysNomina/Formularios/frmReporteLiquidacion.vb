Public Class frmReporteLiquidacion

    Private Sub frmReporteLiquidacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LUE_Empleado.Properties.DataSource = VB.SysContab.EmpleadosDB.GetListBuscar()
        Me.LUE_Empleado.Properties.PopulateColumns()
        Me.LUE_Empleado.Properties.Columns("Codigo").Visible = False
        Me.LUE_Empleado.Properties.DisplayMember = "Nombre"
        Me.LUE_Empleado.Properties.ValueMember = "Codigo"
        Me.LUE_Empleado.EditValue = "%"

        Me.LUE_Departamento.Properties.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables(0)
        Me.LUE_Departamento.Properties.PopulateColumns()
        Me.LUE_Departamento.Properties.Columns("Codigo").Visible = False
        Me.LUE_Departamento.Properties.DisplayMember = "Nombre"
        Me.LUE_Departamento.Properties.ValueMember = "Codigo"
        Me.LUE_Departamento.EditValue = "%"

        Me.LUE_Localidad.Properties.DataSource = VB.SysContab.LocalidadDB.Lista(0, False)
        Me.LUE_Localidad.Properties.PopulateColumns()
        Me.LUE_Localidad.Properties.Columns("Codigo").Visible = False
        Me.LUE_Localidad.Properties.Columns("Empleados").Visible = False
        Me.LUE_Localidad.Properties.DisplayMember = "Descripcion"
        Me.LUE_Localidad.Properties.ValueMember = "Codigo"
        Me.LUE_Localidad.EditValue = 0
        Me.dtpAl.EditValue = Today.Date
        Me.Cargar()

    End Sub
    Public Sub Cargar()
        Me.Cursor = Cursors.WaitCursor
        Me.dgLiquidaciones.DataSource = VB.SysContab.LiquidacionDB.GetLiquidaciones(Me.LUE_Empleado.EditValue, _
            Me.LUE_Localidad.EditValue, Me.LUE_Departamento.EditValue, Me.dtpAl.EditValue, _
            IIf(Me.dtpAl.DateTime.Day = 31, DateAdd(DateInterval.Day, -1, Me.dtpAl.EditValue), Me.dtpAl.EditValue))
        If Not (Me.dgLiquidaciones.DataSource Is Nothing) Then
            Me.Vista.Columns("emp_codigo").Caption = "Codigo"
            Me.Vista.Columns("nombre").Caption = "Nombre del Empleado"
            Me.Vista.Columns("mov_tipo").Caption = "Tipo de Movimiento"
            Me.Vista.Columns("mov_cantidad").Visible = False
            Me.Vista.Columns("mov_valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.Vista.Columns("mov_valor").DisplayFormat.FormatString = "n2"
            Me.Vista.Columns("mov_valor").Caption = "Valor en C$"

            Me.Vista.Columns("mov_valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.Vista.Columns("mov_valor").SummaryItem.DisplayFormat = "{0:n2}"
        End If
      
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Cargar()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim forma As New frmExportarImprimir
        forma.Mostrar(Me.dgLiquidaciones)
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Dim f As New frmGridDatos
        Dim ds As New DataSet
        ds.Tables.Add(Me.dgLiquidaciones.DataSource.copy)
        ds.Tables(0).TableName = "Liquidacion_Global"
        f.Origen = ds
        f.MdiParent = Me.MdiParent
        f.Show()
        ds = Nothing
    End Sub
End Class