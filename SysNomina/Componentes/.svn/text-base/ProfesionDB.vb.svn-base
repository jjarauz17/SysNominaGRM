Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab
    Public Class ProfesionDetailsDB
        Public Codigo As String
        Public Descripcion As String
    End Class

    Public Class ProfesionDB

        Public Shared Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListProfesion", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            Try
                DBCommand.Fill(dsFicha, "Profesion")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()
            Return dsFicha
        End Function

        Public Shared Function GetList(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListProfesionBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar, 50)
            pFiltro.Value = Filtro

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pFiltro)

            Try
                DBCommand.Fill(dsFicha, "Profesion")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
            DBConn.Close()
            Return dsFicha
        End Function
        Public Shared Function Add(ByVal Descripcion As String) As Boolean
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBCommand = New SqlDataAdapter("_Profesion_Add", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            Dim pDescripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            pDescripcion.Value = Descripcion

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pDescripcion)
            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            DBConn.Close()
            Return True
        End Function

        Public Shared Function Update(ByVal Codigo As String, ByVal Descripcion As String) As Boolean
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBCommand = New SqlDataAdapter("_Profesion_Update", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            pCodigo.Value = Codigo

            Dim pDescripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            pDescripcion.Value = Descripcion

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pDescripcion)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            DBConn.Close()
            Return True
        End Function

        Public Shared Function Delete(ByVal Codigo As String) As Boolean
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBCommand = New SqlDataAdapter("_Profesion_Delete", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            pCodigo.Value = Codigo

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)


            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            DBConn.Close()
            Return True
        End Function
    End Class
End Namespace
