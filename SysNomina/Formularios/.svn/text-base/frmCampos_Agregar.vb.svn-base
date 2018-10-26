Public Class frmCampos_Agregar
#Region "Variables"
    Dim d As New VB.SysContab.CamposDetails
#End Region

    Private Sub frmCampos_Agregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Nuevo = "SI" Then
            Me.Text = "Agregando un Nuevo Campo Dinámico"
            Me.txtNombre.Text = ""
            Me.spSize.EditValue = 0
            Me.cmdGuardar.Enabled = True
        Else

            d = VB.SysContab.CamposDB.GetDetails(Registro)
            Me.txtNombre.Text = d.Nombre
            Me.cbTipoDatos.EditValue = d.Tipo
            Me.spSize.EditValue = d.Longitud
            Me.Text = "Editanto Campo Dinámico: [" & d.Nombre & "]"
            Me.cmdGuardar.Enabled = False
        End If

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Nuevo = "SI" Then
            VB.SysContab.CamposDB.Add(Me.txtNombre.Text, Me.cbTipoDatos.EditValue, Me.spSize.EditValue)
        Else
        End If

        Me.Close()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class