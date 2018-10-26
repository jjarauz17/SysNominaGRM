Imports DbConnect

Public Class RH_Produccion

    Public Shared Sub RH_ProduccionDetalle_Add_Update(prod_id As Integer, ByVal dia As Date, ByVal empleado As String, _
                                                      ByVal produccion As Double, ByVal categoria As Integer, ByVal tipoausencia As Integer)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("prod_id", SqlDbType.Int, 5, ParameterDirection.Input, prod_id)
        v.AddParameter("dia", SqlDbType.SmallDateTime, 1, ParameterDirection.Input, dia)
        v.AddParameter("emp_codigo", SqlDbType.NVarChar, 8, ParameterDirection.Input, empleado)
        v.AddParameter("produccion", SqlDbType.Float, 20, ParameterDirection.Input, produccion)
        v.AddParameter("categoria", SqlDbType.Int, 5, ParameterDirection.Input, categoria)
        v.AddParameter("tipoausencia", SqlDbType.Int, 5, ParameterDirection.Input, tipoausencia)

        Try
            v.EjecutarComando("_RH_ProduccionDetalleAdd_Update")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Function RH_TipoAsistencia_List(ByVal asi_codigo As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("asi_codigo", SqlDbType.Int, 5, ParameterDirection.Input, asi_codigo)
        Try
            Return v.EjecutarComando("_RH_TipoAsistencia_List", "TiposAsistencias")

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub RH_Produccion_Add(ByVal id As Integer, ByVal empr_codigo As Integer, _
            ByVal per_tipo As String, ByVal per_codigo As String, ByVal produccion As Double, _
            ByVal procesado As Boolean, ByVal idArea As Integer, ByVal Minimo As Double, _
            ByVal p_d1 As Decimal, ByVal p_d2 As Decimal, ByVal p_d3 As Decimal, ByVal p_d4 As Decimal, _
            ByVal p_d5 As Decimal, ByVal p_d6 As Decimal, ByVal p_d7 As Decimal)

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, empr_codigo)
        v.AddParameter("per_tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, per_tipo)
        v.AddParameter("per_codigo", SqlDbType.NVarChar, 8, ParameterDirection.Input, per_codigo)
        v.AddParameter("id_area", SqlDbType.Int, 5, ParameterDirection.Input, idArea)
        v.AddParameter("produccion", SqlDbType.Float, 20, ParameterDirection.Input, produccion)
        v.AddParameter("procesado", SqlDbType.Bit, 5, ParameterDirection.Input, procesado)
        v.AddParameter("minimo", SqlDbType.Float, 20, ParameterDirection.Input, Minimo)

        v.AddParameter("p_d1", SqlDbType.Float, 20, ParameterDirection.Input, p_d1)
        v.AddParameter("p_d2", SqlDbType.Float, 20, ParameterDirection.Input, p_d2)
        v.AddParameter("p_d3", SqlDbType.Float, 20, ParameterDirection.Input, p_d3)
        v.AddParameter("p_d4", SqlDbType.Float, 20, ParameterDirection.Input, p_d4)
        v.AddParameter("p_d5", SqlDbType.Float, 20, ParameterDirection.Input, p_d5)
        v.AddParameter("p_d6", SqlDbType.Float, 20, ParameterDirection.Input, p_d6)
        v.AddParameter("p_d7", SqlDbType.Float, 20, ParameterDirection.Input, p_d7)

        Try
            v.EjecutarComando("_RH_Produccion_Add")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Sub RH_Produccion_Delete(ByVal id As Integer)

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
        Try
            v.EjecutarComando("_RH_Produccion_Delete")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Shared Function RH_ProduccionDetalle_List(ByVal Prod_id As Integer, _
            ByVal empr_codigo As Integer, _
            ByVal fecha As Date, ByVal fecha2 As Date, ByVal idArea As Integer)

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("prod_id", SqlDbType.Int, 5, ParameterDirection.Input, Prod_id)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, empr_codigo)
        v.AddParameter("fecha", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, fecha)
        v.AddParameter("fecha2", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, fecha2)
        v.AddParameter("idarea", SqlDbType.Int, 5, ParameterDirection.Input, idArea)
        Try
            Return v.EjecutarComando("_RH_Producciondetalle_List")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Function RH_ProduccionDetalle_List_Pivot(ByVal Prod_id As Integer, _
            ByVal empr_codigo As Integer, ByVal idArea As Integer, ByVal per_codigo As String, _
            ByVal per_tipo As String) As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, empr_codigo)
        v.AddParameter("per_codigo", SqlDbType.NVarChar, 8, ParameterDirection.Input, per_codigo)
        v.AddParameter("per_tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, per_tipo)
        v.AddParameter("prod_id", SqlDbType.Int, 5, ParameterDirection.Input, Prod_id)
        v.AddParameter("idarea", SqlDbType.Int, 5, ParameterDirection.Input, idArea)
        Try
            Return v.EjecutarComando("_RH_Producciondetalle_List_pivot")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Shared Function RH_Produccion_Promedio(ByVal Empleado As String, ByVal Fecha As Date) As Decimal

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
        v.AddParameter("fecha", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Fecha)
        v.AddParameter("PP", SqlDbType.Int, 5, ParameterDirection.InputOutput, 1)
        Try
            v.EjecutarComando("_RH_ProduccionPromedio")
            Return v.GetParameter("PP").Valor
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 1
        End Try

    End Function
End Class
