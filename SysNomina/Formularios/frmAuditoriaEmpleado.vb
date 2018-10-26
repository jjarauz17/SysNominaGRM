Public Class frmAuditoriaEmpleado

    Private Sub frmAuditoriaEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cbempleado.Properties.DataSource = VB.SysContab.EmpleadosDB.GetListBuscarCombo("%").Tables("EMPLEADOS")
        Me.VistaEmpleado.Columns("Codigo").Width = 100
        Me.VistaEmpleado.Columns("Nombre").Width = 250
        Me.cbempleado.Properties.DisplayMember = "Nombre"
        Me.cbempleado.Properties.ValueMember = "Codigo"

        Me.Empleado.DataSource = VB.SysContab.EmpleadosDB.GetList().Tables(0)
        Me.Empleado.DisplayMember = "Nombre"
        Me.Empleado.ValueMember = "Codigo"

        cbLocalidad.DataSource = VB.SysContab.LocalidadDB.Lista(0, False)
        cbLocalidad.ValueMember = "Codigo"
        cbLocalidad.DisplayMember = "Descripcion"

        Me.cbDepartamento.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("Departamentos")
        Me.cbDepartamento.ValueMember = "Codigo"
        Me.cbDepartamento.DisplayMember = "Nombre"

        Me.cbArea.DataSource = VB.SysContab.AreaDB.GetListDepto("%").Tables("Areas")
        Me.cbArea.ValueMember = "Area"
        Me.cbArea.DisplayMember = "Descripcion"

        Me.cbempleado.EditValue = "%"
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        Dim forma As New frmexportaciongrid
        forma.Mostrar(Me.dgAuditoria)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.dgAuditoria.DataSource = VB.SysContab.AuditoriaDB.Auditoria_Empleados(Me.cbempleado.EditValue)
        Me.vAuditoria.PopulateColumns()

        Me.vAuditoria.Columns("emp_codigo").Caption = "Empleado"
        Me.vAuditoria.Columns("emp_codigo").ColumnEdit = Me.Empleado

        Me.vAuditoria.Columns("loc_codigo").Caption = "Localidad"
        Me.vAuditoria.Columns("loc_codigo").ColumnEdit = Me.cbLocalidad

        Me.vAuditoria.Columns("dep_codigo").Caption = "Departamento"
        Me.vAuditoria.Columns("dep_codigo").ColumnEdit = Me.cbDepartamento


        Me.vAuditoria.Columns("are_codigo").OptionsColumn.ShowInCustomizationForm = False
        Me.vAuditoria.Columns("carea").VisibleIndex = Me.vAuditoria.Columns("are_codigo").VisibleIndex
        Me.vAuditoria.Columns("are_codigo").Visible = False

        Me.vAuditoria.Columns("carea").Caption = "Area"
        Me.vAuditoria.Columns("carea").ColumnEdit = Me.cbArea

        Me.vAuditoria.Columns("id").Visible = False
        Me.vAuditoria.Columns("empr_codigo").Visible = False
        Me.vAuditoria.Columns("empr_codigo").Caption = "Empresa"

        Me.vAuditoria.Columns("fun_codigo").Visible = False
        Me.vAuditoria.Columns("fun_codigo").Caption = "Funcion"

        Me.vAuditoria.Columns("cgo_codigo").Visible = False
        Me.vAuditoria.Columns("cgo_codigo").Caption = "Cargo"

        Me.vAuditoria.Columns("mon_codigo").Visible = False
        Me.vAuditoria.Columns("mon_codigo").Caption = "Moneda de Pago"

        Me.vAuditoria.Columns("emp_estado").Visible = False
        Me.vAuditoria.Columns("emp_estado").Caption = "Tipo de Contrato"

        Me.vAuditoria.Columns("emp_salario").Visible = False
        Me.vAuditoria.Columns("emp_salario").Caption = "Salario"

        Me.vAuditoria.Columns("emp_fingreso").Visible = False
        Me.vAuditoria.Columns("emp_fingreso").Caption = "Fecha de Ingreso"

        Me.vAuditoria.Columns("emp_ffincontrato").Visible = False
        Me.vAuditoria.Columns("emp_ffincontrato").Caption = "Fin de Contrato"

        Me.vAuditoria.Columns("emp_hastacontrato").Visible = False
        Me.vAuditoria.Columns("emp_hastacontrato").Caption = "Fin de Contrato (SP)"

        Me.vAuditoria.Columns("emp_cedula").Visible = False
        Me.vAuditoria.Columns("emp_cedula").Caption = "Cedula"

        Me.vAuditoria.Columns("emp_inss").Visible = False
        Me.vAuditoria.Columns("emp_inss").Caption = "INSS"

        Me.vAuditoria.Columns("banco").Visible = False
        Me.vAuditoria.Columns("banco").Caption = "Banco"

        Me.vAuditoria.Columns("idcuenta").Visible = False
        Me.vAuditoria.Columns("idcuenta").Caption = "Cuenta/ID"

        Me.vAuditoria.Columns("emp_formapago").Caption = "Tipo de Nomina"
        Me.vAuditoria.Columns("emp_pago").Caption = "Forma de Pago"

        Me.vAuditoria.Columns("fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.vAuditoria.Columns("fecha").DisplayFormat.FormatString = "dd/MMM/yyyy HH:mm"
        Me.vAuditoria.BestFitColumns()
    End Sub

    Private Sub chkSelector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelector.CheckedChanged
        If Me.chkSelector.Checked Then Me.vAuditoria.ColumnsCustomization() Else Me.vAuditoria.DestroyCustomization()
    End Sub

    Private Sub vAuditoria_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles vAuditoria.HideCustomizationForm
        Me.chkSelector.Checked = False
    End Sub
End Class