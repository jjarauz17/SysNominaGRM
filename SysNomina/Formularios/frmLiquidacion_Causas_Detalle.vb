Public Class frmLiquidacion_Causas_Detalle 

#Region "variables"
    Public ID As Integer = 0
#End Region

    Private Sub frmLiquidacion_Causas_Detalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim detalles As New VB.SysContab.Causas_Liquidacion
        If Me.ID = 0 Then
            Me.TextEdit1.Text = ""
            Me.CheckEdit1.EditValue = False
            Me.CheckEdit2.EditValue = False
            Me.CheckEdit3.EditValue = False
        Else
            detalles = VB.SysContab.LiquidacionDB.Liquidacion_Causas_Detalle(ID)
            If Not detalles Is Nothing Then
                Me.TextEdit1.Text = detalles.Descripcion
                Me.CheckEdit1.EditValue = detalles.Vacaciones
                Me.CheckEdit2.EditValue = detalles.Aguinaldo
                Me.CheckEdit3.EditValue = detalles.Indemnizacion
            End If

        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        VB.SysContab.LiquidacionDB.Liquidacion_Causas_Add(ID, _
            Me.TextEdit1.Text, Me.CheckEdit1.EditValue, Me.CheckEdit2.EditValue, _
            Me.CheckEdit3.EditValue, "F", 0)
        Me.Close()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class