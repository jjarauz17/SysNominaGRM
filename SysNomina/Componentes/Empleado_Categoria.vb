Imports DbConnect
Public Class Empleado_Categoria_Details
    Public id As Integer
    Public empr_codigo As Integer
    Public emp_codigo As String
    Public cat_codigo As Integer
End Class
Public Class Empleado_Categoria


    Public Shared Function Listar(ByVal Empresa As Integer, ByVal Categoria As Integer, ByVal FILTRO As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)
        v.AddParameter("cat_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Categoria)
        v.AddParameter("filtro", SqlDbType.NVarChar, 1, ParameterDirection.Input, FILTRO)

        Try
            Return v.EjecutarComando("_RH_Empleado_Cat_Produccion_List", "Tabla")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub Agregar_Editar(ByVal id As Integer, ByVal empresa As Integer, ByVal empleado As String, ByVal categoria As Integer)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, empresa)
        v.AddParameter("emp_codigo", SqlDbType.NVarChar, 8, ParameterDirection.Input, empleado)
        v.AddParameter("cat_codigo", SqlDbType.Int, 5, ParameterDirection.Input, categoria)

        Try
            v.EjecutarComando("_RH_Empleado_Cat_Produccion")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
