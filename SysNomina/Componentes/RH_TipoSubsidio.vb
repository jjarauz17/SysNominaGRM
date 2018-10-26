Imports DbConnect
Public Class RH_TipoSubsidio
    Public Shared Function RH_GetList(ByVal id As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

        Try
            Return v.EjecutarComando("_RH_GetTipoSubsidio")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Shared Sub RH_TipoSubsidioADD(ByVal id As Integer, ByVal tds_descripcion As String, _
        ByVal emp_porcentaje As Decimal, ByVal tdi_emp As String, ByVal empr_porcentaje As Decimal, _
        ByVal tdi_empr As String, ByVal EMPRESA As Integer, ByVal borrar As Boolean)

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("tds_descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, tds_descripcion)
        v.AddParameter("emp_porcentaje", SqlDbType.Float, 5, ParameterDirection.Input, emp_porcentaje)
        v.AddParameter("tdi_emp", SqlDbType.NVarChar, 5, ParameterDirection.Input, tdi_emp)
        v.AddParameter("empr_porcentaje", SqlDbType.Float, 5, ParameterDirection.Input, empr_porcentaje)
        v.AddParameter("tdi_empr", SqlDbType.NVarChar, 5, ParameterDirection.Input, tdi_empr)
        v.AddParameter("borrar", SqlDbType.Bit, 5, ParameterDirection.Input, borrar)
        v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, EMPRESA)
        Try
            v.EjecutarComando("_RH_TipoSubsidio")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
