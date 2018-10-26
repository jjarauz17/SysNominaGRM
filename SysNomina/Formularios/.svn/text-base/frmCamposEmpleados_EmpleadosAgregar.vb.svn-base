Public Class frmCamposEmpleados_EmpleadosAgregar
#Region "Variables"
    Public Empleado As String
#End Region

    Private Sub frmCamposEmpleados_EmpleadosAgregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbCampo.Properties.DataSource = VB.SysContab.CamposDB.GetList(Empleado)
        Me.cbCampo.Properties.ValueMember = "id"
        Me.cbCampo.Properties.DisplayMember = "nombre_campo"

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cbCampo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCampo.EditValueChanged
        Me.cbValores.Properties.DataSource = VB.SysContab.CamposDB.GetDatos(Me.cbCampo.EditValue)
        Me.cbValores.Properties.DisplayMember = "valor"
        Me.cbValores.Properties.ValueMember = "id_valor"
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.cbCampo.EditValue Is Nothing Then
            MsgBox("Seleccione un Campo", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        If Me.cbValores.EditValue Is Nothing Then
            MsgBox("Seleccione un Valor", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim forma As frmAgregarEmpleado = frmAgregarEmpleado.Instance
        Dim arreglo() As String = {Me.cbCampo.EditValue, Me.cbValores.EditValue, Me.cbValores.Text}
        forma.dgCamposDinamicos.DataSource.rows.add(arreglo)
        'VB.SysContab.CamposDB.DatosEmpleados_ADDDEL(Empleado, Me.cbValores.EditValue, 0)
        Me.Close()
    End Sub
End Class