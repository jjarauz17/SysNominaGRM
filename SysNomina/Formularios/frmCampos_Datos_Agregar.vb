Public Class frmCampos_Datos_Agregar

#Region "Variables"
    Public Detalles As New VB.SysContab.CamposDetails
    Public Valor As String = ""
    Public ID_Valor As Integer = 0
#End Region
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmCampos_Datos_Agregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Detalles.Tipo = "Cadena" Then
            Me.txtCadena.Visible = True
            Me.txtCadena.Text = ""
            Me.spValor.Visible = False
            Me.spValor.EditValue = 0
            If Nuevo = "NO" Then
                Me.txtCadena.Text = Me.Valor
            End If
        Else
            Me.txtCadena.Visible = False
            Me.txtCadena.Text = ""
            Me.spValor.Visible = True
            Me.spValor.EditValue = 0
            If Me.Detalles.Tipo = "Entero" Then
                Me.spValor.Properties.EditMask = "N00"
                Me.spValor.Properties.IsFloatValue = False
            Else
                Me.spValor.Properties.EditMask = ""
                Me.spValor.Properties.IsFloatValue = True
            End If
            If Nuevo = "NO" Then
                Me.spValor.EditValue = Me.Valor
            End If

        End If
        

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        VB.SysContab.CamposDB.DatosAdd(Detalles.ID, IIf(Me.Detalles.Tipo = "Cadena", Me.txtCadena.Text, Me.spValor.EditValue), Me.ID_Valor)
        Me.Close()
    End Sub
End Class