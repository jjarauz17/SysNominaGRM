Public Class frmEmpleado_FechaBaja 
#Region "Variables"
    Public Codigo As String
#End Region
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.deFechaBaja.EditValue Is Nothing Then
            MsgBox("Seleccione la fecha de baja por favor")
            Exit Sub
        End If

        If Me.deFechaBaja.EditValue Is DBNull.Value Then
            MsgBox("Seleccione la fecha de baja por favor")
            Exit Sub
        End If

        If cbMotivos.EditValue Is Nothing Then
            MsgBox("Por favor seleccione un motivo para la baja")
            Exit Sub
        End If

        If cbMotivos.EditValue Is DBNull.Value Then
            MsgBox("Por favor seleccione un motivo para la baja")
            Exit Sub
        End If
        VB.SysContab.Empleado_BajaDB.Additem(Codigo, Me.deFechaBaja.EditValue, "Arto 45", "J", "", True, True, Me.cbMotivos.EditValue)
        VB.SysContab.Empleado_BajaDB.Revision(Codigo, deFechaBaja.EditValue, "", True, False, True)
        VB.SysContab.Empleado_BajaDB.Aprobacion(Codigo, deFechaBaja.EditValue, Me.txtNotas.EditValue, True, False, True)
        Me.Close()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmEmpleado_FechaBaja_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.cbMotivos.Properties.DataSource = VB.SysContab.LiquidacionDB.Liquidacion_Causas("0", "F")
        Me.cbMotivos.Properties.DisplayMember = "Descripcion"
        Me.cbMotivos.Properties.ValueMember = "id"

    End Sub
End Class