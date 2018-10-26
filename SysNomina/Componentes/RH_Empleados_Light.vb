Imports DbConnect

Public Class RH_Empleados_Light
    Public Shared Sub Bonificar_Empleado(ByVal Empleado As String, _
                   ByVal FechaFin As Date, ByVal FechaInicio As Date, ByVal Salario As Decimal, _
                   ByVal Ubicacion As Integer, ByVal Cargo As String)
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
        v.AddParameter("FechaFin", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, FechaFin)
        v.AddParameter("FechaInicio", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, FechaInicio)
        v.AddParameter("Salario", SqlDbType.Money, 8, ParameterDirection.Input, Salario)
        v.AddParameter("Ubicacion", SqlDbType.Int, 8, ParameterDirection.Input, Ubicacion)
        v.AddParameter("Cargo", SqlDbType.NVarChar, 3, ParameterDirection.Input, Cargo)

        Try
            v.EjecutarComando("_RH_Bonificar_Empleados")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
