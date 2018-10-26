Public Class frmCatalogo_Nomina 

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.close()
    End Sub
    Private Sub cargar()
        Dim Local As Boolean = True
        Me.GridControl1.DataSource = VB.SysContab.CatalogoDB.Listar_RH_Catalogo(True, Local, "%")
        Me.vLista.Columns("empr_codigo").Visible = False
        Me.vLista.Columns("Cuenta").Caption = "Código de Cuenta"
        Me.vLista.Columns("Nombre").Caption = "Nombre de la Cuenta"
        Me.vLista.BestFitColumns()

        Me.cmdNuevo.Enabled = Local
        Me.cmdEditar.Enabled = Local
        Me.cmdBorrar.Enabled = Local
        Me.Text = Me.Text & IIf(Local, "", " -- Catalogo de cuentas leido desde SysContab -- ")
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        frmCatalogo_Nomina_Detalle.Dispose()
        frmCatalogo_Nomina_Detalle.Cuenta = Me.vLista.GetFocusedRowCellValue("Cuenta")
        frmCatalogo_Nomina_Detalle.Descripcion = Me.vLista.GetFocusedRowCellValue("Nombre")
        frmCatalogo_Nomina_Detalle.StartPosition = FormStartPosition.CenterParent
        frmCatalogo_Nomina_Detalle.ShowDialog()
        Me.cargar()

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        VB.SysContab.CatalogoDB.Mantenimiento_RH_Catalogo(Me.vLista.GetFocusedRowCellValue("Cuenta"), "", True)
        Me.cargar()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        frmCatalogo_Nomina_Detalle.Dispose()
        frmCatalogo_Nomina_Detalle.Cuenta = ""
        frmCatalogo_Nomina_Detalle.Descripcion = ""
        frmCatalogo_Nomina_Detalle.StartPosition = FormStartPosition.CenterParent
        frmCatalogo_Nomina_Detalle.ShowDialog()
        Me.cargar()

    End Sub

    Private Sub frmCatalogo_Nomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar()
    End Sub
End Class