Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab
    Public Class AuditoriaDB

        Public Shared Function Auditoria_Empleados(ByVal Empleado As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            Try
                Return v.EjecutarComando("_RH_GetAuditoria", "Auditoria")
            Catch ex As Exception
                Return New DataTable
            End Try
        End Function

        Public Shared Function UsuariosList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AuditoriaUsuariosList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.Fill(dsFicha, "Auditoria")
            DBConn.Close()
            DBConn.Dispose()
            Return dsFicha
        End Function

        Public Shared Function AuditoriaList(ByVal Usuario As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Evento As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AuditoriaList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Usuario As New SqlParameter("@Usuario", SqlDbType.NVarChar)
            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim _Evento As New SqlParameter("@Evento", SqlDbType.VarChar)

            _Empresa.Value = EmpresaActual
            _Usuario.Value = Usuario
            _Fecha1.Value = Fecha1
            _Fecha2.Value = Fecha2
            _Evento.Value = Evento

            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Usuario)
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)
            DBCommand.SelectCommand.Parameters.Add(_Evento)

            'Try
            DBCommand.Fill(dsFicha, "Auditoria")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
            DBConn.Close()
            DBConn.Dispose()
            Return dsFicha

        End Function
        Public Shared Sub AuditoriaSelEmpresa(ByVal Modulo As String, ByVal Tipo As Integer)

            Dim DBConn As SqlConnection

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            Dim cmd As SqlCommand = New SqlCommand("_AuditoriaEmpresa", DBConn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.NVarChar)
            pModulo.Value = Modulo
            cmd.Parameters.Add(pModulo)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            pTipo.Value = Tipo
            cmd.Parameters.Add(pTipo)

            Dim p1 As New SqlParameter("@EmpresaNombre", SqlDbType.NVarChar)
            p1.Value = ""
            cmd.Parameters.Add(p1)

            Dim p2 As New SqlParameter("@Selection", SqlDbType.NVarChar)
            p2.Value = ""
            cmd.Parameters.Add(p2)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
            DBConn.Dispose()

        End Sub

        Public Shared Function Auditoria_Nomina(ByVal Empresa As Integer, ByVal Empleado As String) As DataTable

            'Dim DBConn As SqlConnection

            'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            'Dim cmd As SqlCommand = New SqlCommand("_AuditoriaEmpresa", DBConn)
            'cmd.CommandType = CommandType.StoredProcedure

            'Dim pModulo As New SqlParameter("@Modulo", SqlDbType.NVarChar)
            'pModulo.Value = Modulo
            'cmd.Parameters.Add(pModulo)

            'Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'pEmpresa.Value = EmpresaActual
            'cmd.Parameters.Add(pEmpresa)

            'Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            'pTipo.Value = Tipo
            'cmd.Parameters.Add(pTipo)

            'Dim p1 As New SqlParameter("@EmpresaNombre", SqlDbType.NVarChar)
            'p1.Value = ""
            'cmd.Parameters.Add(p1)

            'Dim p2 As New SqlParameter("@Selection", SqlDbType.NVarChar)
            'p2.Value = ""
            'cmd.Parameters.Add(p2)

            'cmd.Connection = DBConn
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()
            'DBConn.Dispose()
            Return Nothing
        End Function


    End Class
End Namespace
