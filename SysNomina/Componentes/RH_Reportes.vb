﻿Imports DbConnect

Public Class RH_ReportesLight

End Class
Public Class RH_Reportes
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

    Public Shared Function _RH_DetalleIngresos(ByVal Desde As String, ByVal Hasta As String, ByVal Activo As String) As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Desde", SqlDbType.NVarChar, 8, ParameterDirection.Input, Desde)
        v.AddParameter("Hasta", SqlDbType.NVarChar, 8, ParameterDirection.Input, Hasta)
        v.AddParameter("emp_activo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Activo)

        Try
            Return v.EjecutarComando("_RH_Reporte_Ingresos", "Detalle")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function _RH_List() As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        Try
            Return v.EjecutarComando("_RH_ReportesList", "Reportes")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Shared Function _RH_DetalleRubros(ByVal Filtro As String, ByVal Tipo_Movimiento As String) As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Filtro", SqlDbType.NVarChar, 9, ParameterDirection.Input, Filtro)
        v.AddParameter("TMovimiento", SqlDbType.NVarChar, 4, ParameterDirection.Input, Tipo_Movimiento)

        Try
            Return v.EjecutarComando("_RH_DetalleRubros", "Detalle")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function _RH_GetListRubros() As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

        Try
            Return v.EjecutarComando("_RH_TiposMovimientos", "Rubros")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

End Class
