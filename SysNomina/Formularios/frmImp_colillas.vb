Public Class frmImp_colillas
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmImp_colillas = Nothing
    Public cancel As Boolean = False

    Public Shared Function Instance() As frmImp_colillas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmImp_colillas()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
    Private Iniciado As Boolean = False

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        'Dim forma As frmGenPlanilla = frmGenPlanilla.Instance
        'forma.Cancelar = True
        frmGPlanilla.Cancelar = True
        frmRpt_Planilla.Cancelar = True
        cancel = True
        Me.Close()
    End Sub

    Private Sub frmImp_colillas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.cargar()
        End If
    End Sub

    Private Sub frmImp_colillas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cargar()
        Iniciado = True
        Me.rbOrden.EditValue = "A"
        Me.rbFormato.EditValue = "C"
    End Sub
    Private Sub cargar()
        cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetListBuscarCombo("%").Tables("EMPLEADOS")
        cbEmpleados.ValueMember = "Codigo"
        cbEmpleados.DisplayMember = "Nombre"

        cbDepartamentos.DataSource = VB.SysContab.DepartamentosDB.GetListBuscarCombo("%").Tables("DEPARTAMENTOS")
        cbDepartamentos.ValueMember = "Codigo"
        cbDepartamentos.DisplayMember = "Nombre"

        cbAreas.DataSource = VB.SysContab.AreaDB.GetListDepto("%").Tables("Areas")
        cbAreas.ValueMember = "Area"
        cbAreas.DisplayMember = "Descripcion"
    End Sub

    Private Sub cbDepartamentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDepartamentos.SelectedIndexChanged

        If Not Iniciado Then
            Exit Sub
        End If

        cbAreas.DataSource = VB.SysContab.AreaDB.GetListDepto(cbDepartamentos.SelectedValue).Tables("Areas")
        cbAreas.ValueMember = "Area"
        cbAreas.DisplayMember = "Descripcion"

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Dim forma As frmGPlanilla ''= frmGenPlanilla.Instance
        If Me.rbFormato.EditValue = "M" Then
            bColilla = False
        Else
            bColilla = True
        End If

        frmGPlanilla.cEmpleado = Me.cbEmpleados.SelectedValue
        frmGPlanilla.cDepartamento = Me.cbDepartamentos.SelectedValue
        frmGPlanilla.cArea = Me.cbAreas.SelectedValue.ToString.Substring(5, 2).Trim
        frmGPlanilla.cOrden = Me.rbOrden.EditValue 'IIf(Me.rbAlfabetico.Checked, "A", "C")
        frmGPlanilla.ChkSalario = Me.chkSalario.EditValue
        frmGPlanilla.Cancelar = False

        frmRpt_Planilla.cEmpleado = Me.cbEmpleados.SelectedValue
        frmRpt_Planilla.cDepartamento = Me.cbDepartamentos.SelectedValue
        frmRpt_Planilla.cArea = Me.cbAreas.SelectedValue.ToString.Substring(5, 2).Trim
        frmRpt_Planilla.cOrden = Me.rbOrden.EditValue 'IIf(Me.rbAlfabetico.Checked, "A", "C")
        frmRpt_Planilla.ChkSalario = Me.chkSalario.EditValue
        frmRpt_Planilla.Cancelar = False

        Me.Close()
    End Sub
End Class