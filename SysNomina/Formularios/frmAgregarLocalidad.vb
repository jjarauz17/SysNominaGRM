Imports DbConnect
Public Class frmAgregarLocalidad
    Public Codigo As Integer

    Private Sub frmAgregarLocalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Codigo = 0 Then
            Nuevo = "SI"
            Me.txtCodigo.Text = Me.Codigo
            Me.txtDescripcion.Text = ""
            Me.Text = "Agregando Nueva Sucursal"
        Else
            Nuevo = "NO"
            Dim ld As VB.SysContab.LocalidadDetails
            ld = VB.SysContab.LocalidadDB.Detalles(Me.Codigo, True)
            Me.txtCodigo.Text = ld.Codigo
            Me.txtDescripcion.Text = ld.Descripcion
            Me.Text = "Editando Sucursal"
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion())
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Me.txtCodigo.Text)
        v.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Me.txtDescripcion.Text)
        v.AddParameter("Accion", SqlDbType.NVarChar, 1, ParameterDirection.Input, IIf(Me.Codigo = 0, "A", "U"))
        v.EjecutarComando("_Localidad_Add_Update", "")
        v = Nothing
        Me.Close()
    End Sub
End Class