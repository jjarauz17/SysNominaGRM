Imports DbConnect
Public Class Empresas_Servidores

    Public Shared Function GetList(id As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

        Try
            Return v.EjecutarComando("_RH_Empresas_Servidores_List", "Servidores")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub Agregar(id As Integer, nombreservidor As String, basedatos As String, borrar As Boolean)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("nombreservidor", SqlDbType.NVarChar, 100, ParameterDirection.Input, nombreservidor)
        v.AddParameter("basedatos", SqlDbType.NVarChar, 100, ParameterDirection.Input, basedatos)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("borrar", SqlDbType.Bit, 5, ParameterDirection.Input, borrar)

        Try
            v.EjecutarComando("_RH_Empresas_Servidores_Add")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
