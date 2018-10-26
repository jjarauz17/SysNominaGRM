Imports DbConnect

Public Class frmLocalidad

    Private Sub frmLocalidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cargar()
    End Sub
    Public Sub cargar()
        Me.dgLocalidades.DataSource = VB.SysContab.LocalidadDB.Lista(0, True)
        Me.VLocalidades.Columns("Codigo").Width = 50
        Me.VLocalidades.Columns("Descripcion").Width = 350
        Me.VLocalidades.Columns("Empleados").Width = 50
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As New frmAgregarLocalidad
        f.Codigo = 0
        f.Text = "Agregar Sucursal"
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If Me.VLocalidades.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim f As New frmAgregarLocalidad
        f.Codigo = Me.VLocalidades.GetFocusedRowCellValue("Codigo")
        f.Text = "Editar Sucursal"
        f.ShowDialog()
        Me.cargar()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.VLocalidades.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Nomina")
            Exit Sub
        End If
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion())
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Me.VLocalidades.GetFocusedRowCellValue("Codigo"))
        v.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
        v.AddParameter("Accion", SqlDbType.NVarChar, 1, ParameterDirection.Input, "D")
        Try
            v.EjecutarComando("_Localidad_Add_Update", "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        v = Nothing
        Me.cargar()
    End Sub
End Class