Public Class frmEDU_Configuraciones 

    Private Sub frmEDU_Configuraciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.cbMonedas.Properties.DataSource = VB.SysContab.MonedaDB.GetList().Tables(0)
        Me.cbMonedas.Properties.DisplayMember = "Descripcion"
        Me.cbMonedas.Properties.ValueMember = "Codigo"

        VB.SysContab.TipoIngresoDB.Llenar_SLookUpEdit(Me.SearchLookUpEdit1, "Descripcion", "Codigo", "[Seleccione el tipo de Ingreso]")

        Dim dt As New DataTable
        dt = Catalogos.EDU_Configuraciones()

        If dt.Rows.Count >= 1 Then
            Me.cbMonedas.EditValue = dt.Rows(0)("mon_contratos")
            Me.SearchLookUpEdit1.EditValue = dt.Rows(0)("tdi_codigo")
        Else
            Me.cbMonedas.EditValue = 0
            Me.SearchLookUpEdit1.EditValue = 0
        End If
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Catalogos.EDU_Configuraciones_Add(Me.cbMonedas.EditValue, Me.SearchLookUpEdit1.EditValue)
        Me.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class