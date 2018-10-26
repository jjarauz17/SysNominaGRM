Imports DbConnect
Namespace VB.SysContab
    Public Class SolicitudDB

        '''Guarda una solicitud de constancia realizada por un empleado
        Public Shared Function Guardar(ByVal Tipo As Integer, ByVal Descripcion As String, _
            ByVal Fecha As Date, ByVal Constancia As Integer, ByVal Contrato As Integer) As Integer


            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            Dim noSolicitud As Integer = 0
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Tipo", SqlDbType.Int, 5, ParameterDirection.Input, Tipo)
            v.AddParameter("Descripcion", SqlDbType.Text, 400, ParameterDirection.Input, Descripcion)
            v.AddParameter("Fecha", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Fecha)
            v.AddParameter("Constancia", SqlDbType.Int, 5, ParameterDirection.Input, Constancia)
            v.AddParameter("Contrato", SqlDbType.Int, 5, ParameterDirection.Input, Contrato)
            v.AddParameter("Solicitud", SqlDbType.Int, 5, ParameterDirection.Output, 0)
            Try
                v.EjecutarComando("_RH_Solicitud_Add")
                noSolicitud = v.GetParameter("Solicitud").Valor
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            v = Nothing
            Return noSolicitud
        End Function

        '''Lista las solicitudes de constancias
        Public Shared Function Listar(ByVal Solicitud As Integer, ByVal Empleado As String, _
            ByVal Estado As Integer) As DataTable

            Dim l As New DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Solicitud", SqlDbType.Int, 5, ParameterDirection.Input, 0)
            v.AddParameter("Empleado", SqlDbType.Int, 5, ParameterDirection.Input, Empleado)
            v.AddParameter("Estado", SqlDbType.Int, 5, ParameterDirection.Input, Estado)
            Try
                l = v.EjecutarComando("RH_GetListSolicitud")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            v = Nothing
            Return l
        End Function

        '''Actualizar el estado de una solicitud de constancias
        Public Shared Function Actualizar_Estado(ByVal Solicitud As Integer, _
            ByVal Estado As Integer, Optional ByVal Mensaje As String = "") As Boolean
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Solicitud", SqlDbType.Int, 5, ParameterDirection.Input, Solicitud)
            v.AddParameter("Estado", SqlDbType.Int, 5, ParameterDirection.Input, Estado)
            v.AddParameter("Fecha", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Now.Date)
            v.AddParameter("Mensaje", SqlDbType.Text, 400, ParameterDirection.Input, Mensaje)

            Try
                v.EjecutarComando("_RH_Solictud_UpdateEstado")

            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function
    End Class

End Namespace
