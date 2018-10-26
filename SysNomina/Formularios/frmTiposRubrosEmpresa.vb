
Public Class frmTiposRubrosEmpresa

    Private Sub frmTiposRubroEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()

    End Sub

    Public Sub cargar()
        Me.dgRubros.DataSource = VB.SysContab.RubrosEmpresaDB.GetList()
        Me.vLista.Columns("Cuenta Debito").Visible = False
        Me.vLista.Columns("Cuenta Credito").Visible = False
        Me.vLista.Columns("Factor").Visible = False
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.vLista.GetFocusedRowCellValue("Sistema") = True Then
            MsgBox("No se pueden editar los rubros del sistema", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Registro = Me.vLista.GetFocusedRowCellValue("Codigo")
        Nuevo = "NO"
        Dim f As New frmAgregar_TipoRubrosEmpresa
        f.MdiParent = Me.MdiParent
        f.Show()
        Me.cargar()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Nuevo = "SI"
        Dim f As New frmAgregar_TipoRubrosEmpresa
        'f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Normal
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        If Me.vLista.GetFocusedRowCellValue("Sistema") = True Then
            MsgBox("No se pueden borrar los rubros del sistema", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If

        cargar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class