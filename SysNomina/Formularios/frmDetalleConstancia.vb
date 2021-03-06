Public Class frmDetalleConstancia

#Region "Variables"
    Public Firma As String
    Public Descripcion As String
#End Region

    Private Sub frmDetalleConstancia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbEmpleado.Properties.DataSource = VB.SysContab.DepartamentosDB.GetListBuscar("%").Tables(0)
        Me.cbEmpleado.Properties.PopulateColumns()

        Me.cbEmpleado.Properties.DisplayMember = "Nombre"
        Me.cbEmpleado.Properties.ValueMember = "Codigo"
        If Me.Firma = "0" Then
            Me.rgFirmas.EditValue = 0
            Me.cbEmpleado.Visible = False
        Else
            Me.rgFirmas.EditValue = 1
            Me.cbEmpleado.Visible = True
            Me.cbEmpleado.EditValue = Firma
        End If
        Me.txtDescripcion.Text = Me.Descripcion
    End Sub

    Private Sub cmdContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContinuar.Click

        If Me.rgFirmas.EditValue = 1 Then
            If Me.cbEmpleado.EditValue Is Nothing Then
                MsgBox("Seleccione un empleado por favor")
                Exit Sub
                If Me.cbEmpleado.EditValue = vbNull Then
                    MsgBox("Seleccione un empleado por favor")
                    Exit Sub
                End If
            End If
        End If

        frmConstancias.Cerrar = False
        frmConstancias.Descripcion = Me.txtDescripcion.Text
        frmConstancias.Departamento = IIf(Me.rgFirmas.EditValue = 0, "0", Me.cbEmpleado.EditValue)
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        frmConstancias.Cerrar = True
        Me.Close()
    End Sub

    Private Sub rgFirmas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgFirmas.SelectedIndexChanged
        If Me.rgFirmas.EditValue = 0 Then Me.cbEmpleado.Visible = False Else Me.cbEmpleado.Visible = True
    End Sub
End Class