Imports DbConnect

Public Class RH_IR

    Public Shared Function Tablas() As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        Try
            Return v.EjecutarComando("_IR_Tablas", "IR_Tablas")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Shared Function List(ByVal ir_codigo As Integer, ByVal Fecha As Date, ByRef UltimaTabla As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("ir_codigo", SqlDbType.Int, 5, ParameterDirection.Input, ir_codigo)
        v.AddParameter("EMPRESA", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("fecha", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Fecha)
        v.AddParameter("UltimaTabla", SqlDbType.Int, 5, ParameterDirection.InputOutput, UltimaTabla)
        Try
            Dim dt As DataTable
            dt = v.EjecutarComando("_IR_List", "IR")
            UltimaTabla = v.GetParameter("UltimaTabla").Valor
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            UltimaTabla = 1
            Return Nothing
        End Try
    End Function

    Public Shared Function Tipo() As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        Try
            Return v.EjecutarComando("_RH_IR_Tipos", "Tipos_IR")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub ADD(ByVal ir_codigo As Integer, ByVal ir_desde As Decimal, ByVal ir_hasta As Decimal, ByVal ir_tipo As Integer, _
            ByVal ir_porcentaje As Decimal, ByVal ir_base As Decimal, ByVal ir_exceso As Decimal, ByVal Borrar As Boolean, _
            Tabla As Integer)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("ir_codigo", SqlDbType.Int, 5, ParameterDirection.Input, ir_codigo)
        v.AddParameter("ir_desde", SqlDbType.Float, 5, ParameterDirection.Input, ir_desde)
        v.AddParameter("ir_hasta", SqlDbType.Float, 5, ParameterDirection.Input, ir_hasta)
        v.AddParameter("ir_tipo", SqlDbType.Int, 5, ParameterDirection.Input, ir_tipo)
        v.AddParameter("ir_porcentaje", SqlDbType.Float, 5, ParameterDirection.Input, ir_porcentaje)
        v.AddParameter("ir_base", SqlDbType.Float, 5, ParameterDirection.Input, ir_base)
        v.AddParameter("ir_exceso", SqlDbType.Float, 5, ParameterDirection.Input, ir_exceso)
        v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, Tabla)
        v.AddParameter("Borrar", SqlDbType.Int, 5, ParameterDirection.Input, Borrar)

        Try
            v.EjecutarComando("_RH_IR_ADD")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
