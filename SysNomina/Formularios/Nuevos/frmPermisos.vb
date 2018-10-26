Public Class frmPermisos 
    Private Sub frmEmpleadosPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Liquidado] = False and FechaFin is null")

        dgEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables("Empleados")
        Me.Empleados.Columns(0).Width = 80
        Me.Empleados.Columns(1).Width = 250
        Me.Empleados.Columns(2).Width = 300
        Me.Empleados.Columns(3).Width = 50

        Me.Empleados.Columns("Liquidado").Visible = False
        Me.Empleados.Columns("Liquidado").OptionsColumn.ShowInCustomizationForm = False
        'Me.Empleados.Columns("Liquidado").FilterInfo = Filtro

        Me.Empleados.Columns("Email").Visible = False
        Me.Empleados.Columns("Usuario").Visible = False
        Me.Empleados.Columns("Acumula Prestaciones").Visible = False
        Me.Empleados.Columns("Forma de Pago").Visible = False
        Me.Empleados.Columns("INSS").Visible = False
        Me.Empleados.Columns("Cédula").Visible = False
        Me.Empleados.Columns("FechaFin").Visible = False
        Me.Empleados.Columns("SalarioxDia").Visible = False
        Me.Empleados.Columns("SalarioxHora").Visible = False

        If Me.Empleados.DataRowCount <> 0 Then
            Registro = Me.Empleados.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If
        Me.Text = "Mantenimiento de Permisos de Empleados"
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        If Me.Empleados.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "STS.Nomina")
            Exit Sub
        End If

        Dim f As frmAgregarPermisos = frmAgregarPermisos.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub Empleados_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Empleados.FocusedRowChanged
        Registro = Me.Empleados.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
        Dim f As New frmPermisosConsulta
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub
End Class