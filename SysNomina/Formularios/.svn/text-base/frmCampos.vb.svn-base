Public Class frmCampos

    Sub cargar()
        Me.dgCampos.DataSource = VB.SysContab.CamposDB.GetList()

    End Sub

    Private Sub frmCampos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar()
        Me.vCampos.Columns("empr_codigo").Visible = False
        Me.vCampos.Columns("nombre_campo").Caption = "Nombre del Campo"
        Me.vCampos.Columns("tipo_campo").Caption = "Tipo del Campo"
        Me.vCampos.Columns("long_campo").Caption = "Longitud del Campo"
        Me.vCampos.BestFitColumns()

    End Sub

    Private Sub vCampos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vCampos.FocusedRowChanged
        Registro = Me.vCampos.GetFocusedRowCellValue("id")
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As New frmCampos_Agregar
        Nuevo = "SI"
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim f As New frmCampos_Agregar
        Nuevo = "NO"
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vCampos.DataRowCount = 0 Then
            MsgBox("No hay datos en la lista", MsgBoxStyle.Exclamation, "Sts.Nomina")
            Exit Sub
        End If

        If Not VB.SysContab.CamposDB.Delete(Me.vCampos.GetFocusedRowCellValue("id")) Then
            MsgBox("Hubo un error al intentar borrar el registro", MsgBoxStyle.Critical, "Sts.Nomina")
        End If
        Me.cargar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDatos.Click
        Dim f As New frmCampos_Datos
        f.Text = "Catalogo de " & Me.vCampos.GetFocusedRowCellValue("nombre_campo")
        f.ShowDialog()
    End Sub
End Class