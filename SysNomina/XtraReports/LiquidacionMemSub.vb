Public Class LiquidacionMemSub

    Private Sub Tipo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tipo.TextChanged
        If Me.Tipo.Text = "I" Then
            Me.Nombre.Text = "Indemnización"
        ElseIf Me.Tipo.Text = "V" Then
            Me.Nombre.Text = "Vacaciones"
        ElseIf Me.Tipo.Text = "A" Then
            Me.Nombre.Text = "Aguinaldo"
        Else
            Me.Nombre.Text = "Sin  Nombre"
        End If
    End Sub
End Class