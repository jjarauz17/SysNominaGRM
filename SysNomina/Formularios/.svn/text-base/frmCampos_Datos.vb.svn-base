Public Class frmCampos_Datos

#Region "Variables"
    Dim Detalles As New VB.SysContab.CamposDetails
#End Region

    Private Sub frmCampos_Datos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar()
        Detalles = VB.SysContab.CamposDB.GetDetails(Registro)
    End Sub

    Sub cargar()
        Me.dgDatos.DataSource = VB.SysContab.CamposDB.GetDatos(Registro)
        Me.vDatos.Columns("id_valor").Visible = False
        Me.vDatos.Columns("id").Visible = False
        Me.vDatos.Columns("valor").Caption = "Descripción"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As New frmCampos_Datos_Agregar
        f.Detalles = Me.Detalles
        f.ID_Valor = 0
        Nuevo = "SI"
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If Me.vDatos.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim f As New frmCampos_Datos_Agregar
        f.Detalles = Me.Detalles
        f.ID_Valor = Me.vDatos.GetFocusedRowCellValue("id_valor")
        f.Valor = Me.vDatos.GetFocusedRowCellValue("valor")
        Nuevo = "NO"
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vDatos.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        VB.SysContab.CamposDB.DatosDelete(Me.vDatos.GetFocusedRowCellValue("id_valor"))
        Me.cargar()
    End Sub
End Class