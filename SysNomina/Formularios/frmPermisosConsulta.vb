Public Class frmPermisosConsulta

    Private Sub frmPermisosConsulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cbEmpleados.Properties.DataSource = VB.SysContab.EmpleadosDB.GetListBuscarCombo("%").Tables(0)
        Me.cbEmpleados.Properties.DisplayMember = "Nombre"
        Me.cbEmpleados.Properties.ValueMember = "Codigo"

        Me.cbTipoPermiso.Properties.DataSource = VB.SysContab.TiposPermisosDB.GetList(True).Tables("TiposPermisos")
        Me.cbTipoPermiso.Properties.ValueMember = "Codigo"
        Me.cbTipoPermiso.Properties.DisplayMember = "Descripcion"

        Me.dtpDesde.EditValue = Now.Date
        Me.dtpHasta.EditValue = Now.Date

        Me.cbLocalidad.DataSource = VB.SysContab.LocalidadDB.Lista(0, False)
        Me.cbLocalidad.DisplayMember = "Descripcion"
        Me.cbLocalidad.ValueMember = "Codigo"

        Me.cbDepartamento.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
        Me.cbDepartamento.ValueMember = "Codigo"
        Me.cbDepartamento.DisplayMember = "Nombre"

        Me.cbEmpleado.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables(0)
        Me.cbEmpleado.DisplayMember = "Nombre"
        Me.cbEmpleado.ValueMember = "Codigo"

        Me.cbArea.DataSource = VB.SysContab.AreaDB.GetListDepto("%").Tables("Areas")
        Me.cbArea.ValueMember = "Area"
        Me.cbArea.DisplayMember = "Descripcion"

        Me.cbTipo.DataSource = VB.SysContab.TiposPermisosDB.GetList(False).Tables("TiposPermisos")
        Me.cbTipo.ValueMember = "Codigo"
        Me.cbTipo.DisplayMember = "Descripcion"

        Me.cbEmpleados.EditValue = "%"
        Me.cbTipoPermiso.EditValue = 0
        Me.cargar()
    End Sub

    Private Sub cargar()
        Me.vPermisos.GroupPanelText = "Coloque aca los campos por los cuales desea agrupar su informacion"
        Dim columnas As New DevExpress.XtraGrid.Columns.GridColumnCollection(Me.vPermisos)
        For i As Integer = 0 To Me.vPermisos.GroupedColumns.Count - 1
            columnas.Add(Me.vPermisos.GroupedColumns(i))
        Next

        Me.dgPermisos.DataSource = VB.SysContab.PermisosDB.Permisos_GetDetalle(Me.cbEmpleados.EditValue, _
            Me.dtpDesde.EditValue, _
            Me.dtpHasta.EditValue, _
            Me.cbTipoPermiso.EditValue)
        Me.vPermisos.PopulateColumns()
        Me.vPermisos.Columns("loc_codigo").ColumnEdit = Me.cbLocalidad
        Me.vPermisos.Columns("loc_codigo").Caption = "Localidad"
        Me.vPermisos.Columns("dep_codigo").ColumnEdit = Me.cbDepartamento
        Me.vPermisos.Columns("dep_codigo").Caption = "Departamento"
        Me.vPermisos.Columns("are_codigo").ColumnEdit = Me.cbArea
        Me.vPermisos.Columns("are_codigo").Caption = "Area"
        Me.vPermisos.Columns("emp_codigo").ColumnEdit = Me.cbEmpleado
        Me.vPermisos.Columns("emp_codigo").Caption = "Empleado"
        Me.vPermisos.Columns("prm_tipo").ColumnEdit = Me.cbTipo
        Me.vPermisos.Columns("prm_tipo").Caption = "Tipo Permiso"
        Me.vPermisos.Columns("Promedio por Día").Caption = "Salario Promedio x Dia"
        Me.vPermisos.Columns("Valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vPermisos.Columns("Valor").DisplayFormat.FormatString = "n2"
        Me.vPermisos.Columns("Valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vPermisos.Columns("Valor").SummaryItem.DisplayFormat = "{0:n2}"


        For i As Integer = 0 To columnas.Count - 1
            Me.vPermisos.Columns.Item(columnas(i).FieldName).Group()
        Next

        Dim RegistrosAgrupados As Integer

        Dim dv As New DataView(Me.dgPermisos.DataSource)
        Dim dt As DataTable
        dt = dv.ToTable(True, "emp_codigo")
        RegistrosAgrupados = dt.Rows.Count
        Me.empleados.Text = RegistrosAgrupados
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Me.cargar()
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        Dim forma As New frmExportarImprimir
        forma.Mostrar(Me.dgPermisos)
    End Sub

    Private Sub vPermisos_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vPermisos.RowCountChanged
        Dim RegistrosAgrupados As Integer

        Dim dv As New DataView(Me.dgPermisos.DataSource)
        Dim dt As DataTable
        dt = Me.vPermisos.DataSource.ToTable(True, "emp_codigo")
        RegistrosAgrupados = dt.Rows.Count
        Me.empleados.Text = RegistrosAgrupados
    End Sub
End Class