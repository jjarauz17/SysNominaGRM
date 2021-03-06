Public Class frmEmpleados_ExportarDatos_Grid

    Private Sub frmEmpleados_ExportarDatos_Grid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid.DataSource = VB.SysContab.EmpleadosDB.GetList_Empleados_Exportar().Tables("Empleados")
        With GridView1
            .PopulateColumns()
            .Columns("FormaPago").GroupIndex = 0
            .Columns("CodigoEmpleado").Visible = False
            .Columns("CodigoEmpleado").OptionsColumn.ShowInCustomizationForm = True
            .Columns("Empresa").Visible = False
            .Columns("Departamento").Visible = False
            .Columns("Area").Visible = False
            .Columns("Cargo").Visible = False
            .Columns("Email").Visible = False
            .Columns("Funcion").Visible = False
            .Columns("Salario").Visible = False
            .Columns("NombreCompleto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            .Columns("NombreCompleto").SummaryItem.DisplayFormat = "{0:n0}"
        End With

    End Sub


    Private Sub chkselector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselector.CheckedChanged
        If chkselector.Checked Then GridView1.ColumnsCustomization() Else GridView1.DestroyCustomization()
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        Dim forma As New frmExportarImprimir
        forma.Mostrar(Grid)
    End Sub

    Private Sub cmdcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancelar.Click
        Close()
    End Sub
End Class