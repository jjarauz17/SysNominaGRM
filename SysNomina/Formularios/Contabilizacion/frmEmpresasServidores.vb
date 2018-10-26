Public Class frmEmpresasServidores
    Private id As Integer = 0

    Private Sub frmEmpresasServidores_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar()
    End Sub

    Sub Cargar()
        Dim dt As New DataTable
        dt = Empresas_Servidores.GetList(0)

        If dt.Rows.Count >= 1 Then
            Me.id = dt.Rows(0)("id")
            Me.txtServidor.EditValue = dt.Rows(0)("nombreservidor")
            Me.txtBasedatos.EditValue = dt.Rows(0)("basedatos")
        Else
            Me.id = 0
            Me.txtServidor.EditValue = ""
            Me.txtBasedatos.EditValue = ""
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Empresas_Servidores.Agregar(Me.id, Me.txtServidor.EditValue, Me.txtBasedatos.EditValue, _
                                    False)
        XtraMsg("Datos Guardados con Exito!")
        Cargar()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class