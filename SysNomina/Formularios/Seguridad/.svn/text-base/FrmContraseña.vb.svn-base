Imports Clases
Imports DevExpress.XtraEditors

Public Class FrmContraseña

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusuario.Text = Cadena.Usuario
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        If Trim(txtactual.Text) = Nothing Or Trim(txtnueva.Text) = Nothing Or Trim(txtrepetir.Text) = Nothing Then Exit Sub
        If txtactual.Text = txtnueva.Text Then
            DxError.SetError(txtnueva, "La contraseña anterior y la nueva no deben ser iguales")
            DxError.SetError(txtactual, "La contraseña anterior y la nueva no deben ser iguales")
            Exit Sub
        End If
        If txtnueva.Text <> txtrepetir.Text Then
            DxError.SetError(txtnueva, "No coinciden las contraseñas")
            DxError.SetError(txtrepetir, "No coinciden las contraseñas")
            Exit Sub
        End If
        Dim vUsuario As New UsuariosCLS
        If vUsuario.ChangePass(txtusuario.Text, txtactual.Text, txtnueva.Text) Then
            XtraMessageBox.Show("Contraseña cambiada")
            Dim TempUser As String = Cadena.Usuario
            Cadena = Nothing
            Cadena = New Conection(TempUser, txtnueva.Text)
        Else
            XtraMessageBox.Show("Error al cambiar la contraseña, intente nuevamente")
        End If
        Close()
    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged, txtactual.TextChanged, txtnueva.TextChanged, txtrepetir.TextChanged
        DxError.Clear()
    End Sub
End Class