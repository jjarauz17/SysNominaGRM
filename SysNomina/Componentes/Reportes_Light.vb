Imports DbConnect
Public Class Reportes_Light
    Public Shared Function ListaReportes() As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        Try
            Return v.EjecutarComando("_RH_GetReportes", "Reportes")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Shared Function Planilla(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_Planilla_borrador", "Planilla_Borrador")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function PlanillaNumerico(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_Planilla_Numerico", "Planilla_Numerico")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Shared Function IRMes(ByVal fecha As Date) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("fecha", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, fecha)

        Try
            Return v.EjecutarComando("_RH_IRmes", "IRMes")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function INSSMes(ByVal fecha As Date) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("fecha", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, fecha)

        Try
            Return v.EjecutarComando("_RH_Inssmes", "InssMes")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function ConsolidadoPlanilla(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_rptconsolidadoNomina", "Consolidado_Planilla")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function DedEmbargo(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_DedEmbargo", "DEDEMBARGO")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function DedCREDICOMPRAS(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_CREDICOMPRAS", "CREDICOMPRAS")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function DedJUDICIAL(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_JUDICIAL", "JUDICIAL")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function DEGLOSE(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_DEGLOSERPT", "DEGLOSE")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function tdebitos(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_tdebitos", "TDEBITOS")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function Deducciones(ByVal Periodo As String, ByVal TPeriodo As String, _
            ByVal Tde_codigo As String, ByVal Agrupar As Boolean, _
            ByVal loc_codigo As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        v.AddParameter("tde_codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, Tde_codigo)
        v.AddParameter("agrupar", SqlDbType.Bit, 1, ParameterDirection.Input, Agrupar)
        v.AddParameter("loc_codigo", SqlDbType.Int, 5, ParameterDirection.Input, loc_codigo)
        Try
            Return v.EjecutarComando("_RH_DEDUCCIONES", "DEDUCCIONES")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function Ingresos(ByVal Periodo As String, ByVal TPeriodo As String, _
            ByVal Tdi_codigo As String, ByVal Agrupar As Boolean, _
            ByVal loc_codigo As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        v.AddParameter("tdi_codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, Tdi_codigo)
        v.AddParameter("agrupar", SqlDbType.Bit, 1, ParameterDirection.Input, Agrupar)
        v.AddParameter("loc_codigo", SqlDbType.Int, 5, ParameterDirection.Input, loc_codigo)
        Try
            Return v.EjecutarComando("_RH_INGRESOS", "INGRESOS")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function BAJAS(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_Bajas", "BAJAS")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function COLILLAS_INSS(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_COLILLASINSS", "COLILLAS_INSS")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function PLANILLA_DETALLE(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_CP1", "PLANILLA_DETALLE")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function PLANILLA_ENCABEZADO(ByVal Periodo As String, ByVal TPeriodo As String) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
        Try
            Return v.EjecutarComando("_RH_CP2", "PLANILLA_ENCABEZADO")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


End Class
