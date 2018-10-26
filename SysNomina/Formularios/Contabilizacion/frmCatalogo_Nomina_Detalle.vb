Public Class frmCatalogo_Nomina_Detalle 

#Region "Variables"
    Public Cuenta As String = ""
    Public Descripcion As String = ""
#End Region


    Private Sub frmCatalogo_Nomina_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCuenta.EditValue = Me.Cuenta
        If Me.Cuenta = "" Then
            Me.txtDescripcion.EditValue = ""
        Else
            Me.txtDescripcion.EditValue = Me.Descripcion.Substring(Me.Cuenta.Length + 1, Me.Descripcion.Length - Me.Cuenta.Length - 1)
        End If

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        VB.SysContab.CatalogoDB.Mantenimiento_RH_Catalogo(Me.txtCuenta.EditValue, Me.txtDescripcion.EditValue, False)
        Me.Close()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

End Class