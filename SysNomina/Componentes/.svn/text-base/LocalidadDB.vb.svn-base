Imports DbConnect
Namespace VB.SysContab
    Public Class LocalidadDetails
        Public Codigo As Integer
        Public Descripcion As String
        Public Empleados As Integer
    End Class
    Public Class LocalidadDB

        Public Shared Function Detalles(ByVal Codigo As Integer, ByVal Grid As Boolean) As LocalidadDetails
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            v.AddParameter("Grid", SqlDbType.Bit, 1, ParameterDirection.Input, Grid)
            Dim dt As DataTable
            dt = v.EjecutarComando("_Localidad_List", "Localidad")
            v = Nothing
            If dt.Rows.Count = 1 Then
                Dim ld As New LocalidadDetails
                ld.Codigo = dt.Rows(0)("Codigo")
                ld.Descripcion = dt.Rows(0)("Descripcion")
                ld.Empleados = dt.Rows(0)("Empleados")

                Return (ld)
            Else
                Return Nothing
            End If
        End Function

        Public Shared Function Lista(ByVal Codigo As Integer, ByVal Grid As Boolean) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            v.AddParameter("Grid", SqlDbType.Bit, 1, ParameterDirection.Input, Grid)
            Return v.EjecutarComando("_Localidad_List", "Localidad")
            v = Nothing
        End Function
    End Class
End Namespace
