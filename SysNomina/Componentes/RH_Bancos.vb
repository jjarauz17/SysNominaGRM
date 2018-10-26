Imports DbConnect

Public Class RH_Bancos

    Public Shared Function GetListSIB() As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        Try
            Return v.EjecutarComando("_GetList_InsBanc", "SIB")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Shared Function GetList(ByVal Banco As Integer) As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("bco_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Banco)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

        Try
            Return v.EjecutarComando("_RH_Bancos_List", "Tabla")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Shared Sub Add(Banco As Integer, Descripcion As String, SIB As Integer, Cuenta As String, Borrar As Boolean, CtaPlanilla As String, Consecutivo As String)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("bco_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Banco)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("descripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input, Descripcion)
        v.AddParameter("SIB", SqlDbType.Int, 5, ParameterDirection.Input, SIB)
        v.AddParameter("cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cuenta)
        v.AddParameter("borrar", SqlDbType.Bit, 5, ParameterDirection.Input, Borrar)
        v.AddParameter("ctaplanilla", SqlDbType.NVarChar, 10, ParameterDirection.Input, CtaPlanilla)
        v.AddParameter("consecutivo", SqlDbType.NVarChar, 10, ParameterDirection.Input, Consecutivo)

        Try
            v.EjecutarComando("_RH_BancosAdd")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Function GetList_Formatos(ByVal id As Integer, ByVal Banco As Integer) As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("bco_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Banco)


        Try
            Return v.EjecutarComando("_RH_Bancos_Formato_List", "Tabla")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Shared Sub AddFormato(id As Integer, Banco As Integer, id_muestra As Integer, Borrar As Boolean)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("bco_codigo", SqlDbType.Int, 5, ParameterDirection.Input, Banco)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("id_muestra", SqlDbType.Int, 5, ParameterDirection.Input, id_muestra)
        v.AddParameter("borrar", SqlDbType.Bit, 5, ParameterDirection.Input, Borrar)

        Try
            v.EjecutarComando("_RH_Bancos_Formato")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Function GetList_Muestras(ByVal id As Integer) As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id_muestra", SqlDbType.Int, 5, ParameterDirection.Input, id)

        Try
            Return v.EjecutarComando("_RH_Bancos_Muestra_List", "Tabla")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

End Class
