Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab

    Public Class DepartamentosDetails
        Public Codigo As String
        Public Nombre As String
        Public Email As String
        Public Supervisor As String
        Public OrdenReportes As String

    End Class

    Public Class Departamentos_MurohsDetails
        Public Codigo As String
        Public Nombre As String
    End Class

    Public Class DepartamentosDB

        Public Shared Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDepartamentosReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "DEPARTAMENTOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetDetails(ByVal Codigo As String) As DepartamentosDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsDepartamentos As New DataSet()
            Dim Details As New DepartamentosDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDepartamentosDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsDepartamentos, "Departamentos")

            If dsDepartamentos.Tables("Departamentos").Rows.Count = 1 Then
                Details.Codigo = dsDepartamentos.Tables("Departamentos").Rows(0).Item("Dep_codigo")
                Details.Nombre = dsDepartamentos.Tables("Departamentos").Rows(0).Item("Dep_Nombre")
                Details.Email = dsDepartamentos.Tables("Departamentos").Rows(0).Item("Dep_email")
                Details.Supervisor = dsDepartamentos.Tables("Departamentos").Rows(0).Item("Supervisor")
                Details.OrdenReportes = dsDepartamentos.Tables("Departamentos").Rows(0).Item("orden")

            End If

            Return Details

        End Function

        Public Shared Function GetListGrid() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDepartamentos_Grid", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)


            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Departamentos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListNuevo() As String
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

            Dim dt As New DataTable
            Try
                dt = v.EjecutarComando("_GetListDepartamentosNuevo", "Departamentos")
                Return dt.Rows(0)("codigo")
            Catch ex As Exception
                Return "0001"
            End Try

        End Function

        Public Shared Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDepartamentosBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Departamentos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListBuscarCombo(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDepartamentosBuscarCombo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Departamentos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListNombre(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDepartamentosBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Departamentos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub Additem(ByVal Codigo As String, ByVal Nombre As String, ByVal Orden As String, _
            Optional ByVal Email As String = "", Optional ByVal Supervisor As Integer = 0)


            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 4, ParameterDirection.Input, Codigo)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Nombre)
            v.AddParameter("Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, Email)
            v.AddParameter("Supervisor", SqlDbType.Int, 5, ParameterDirection.Input, Supervisor)
            v.AddParameter("Orden", SqlDbType.NVarChar, 10, ParameterDirection.Input, Orden)
            Try
                v.EjecutarComando("_DepartamentoAdd")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Orden As String, _
            Optional ByVal Email As String = "", Optional ByVal Supervisor As Integer = 0)

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 4, ParameterDirection.Input, Codigo)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Nombre)
            v.AddParameter("Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, Email)
            v.AddParameter("Supervisor", SqlDbType.Int, 5, ParameterDirection.Input, Supervisor)
            v.AddParameter("Orden", SqlDbType.NVarChar, 10, ParameterDirection.Input, Orden)
            Try
                v.EjecutarComando("_DepartamentoUpdate")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub Delete(ByVal Codigo As String)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 4, ParameterDirection.Input, Codigo)
            Try
                v.EjecutarComando("_DepartamentoDelete")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        ''Murohs
        Public Shared Function GetListGrid_Murohs() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_RH_GetListDepMurohs_Grid", "Departamentos")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Sub Delete_Murohs(ByVal Codigo As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            Try
                v.EjecutarComando("_RH_DepMurohs_Delete")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub Update_Murohs(ByVal Codigo As Integer, ByVal Nombre As String)

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input, Nombre)
            Try
                v.EjecutarComando("_RH_DepMurohs_Update")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Sub Additem_Murohs(ByVal Codigo As Integer, ByVal Nombre As String)

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 100, ParameterDirection.Input, Nombre)
            Try
                v.EjecutarComando("_RH_DepMurohsAdd")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Function GetDetails_Murohs(ByVal Codigo As Integer) As Departamentos_MurohsDetails

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Dim Details As New Departamentos_MurohsDetails
            Dim dt As New DataTable

            Try
                dt = v.EjecutarComando("_RH_GetListDepMurohsDetails", "Departamentos")
                If dt.Rows.Count = 1 Then
                    Details.Codigo = dt.Rows(0).Item("Dep_codigo")
                    Details.Nombre = dt.Rows(0).Item("Dep_Descripcion")
                    Return Details
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Shared Function GetListNuevo_Murohs() As Integer
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

            Dim dt As New DataTable
            Try
                dt = v.EjecutarComando("_RH_GetDepMurohs_Nuevo", "Departamentos")
                Return dt.Rows(0)("codigo")
            Catch ex As Exception
                Return 1
            End Try

        End Function

        Public Shared Function GetListBuscarCombo_Murohs() As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

            Dim dt As New DataTable
            Try
                dt = v.EjecutarComando("_Rh_GetListDepMurohsrCombo", "Departamentos")
                Return dt
            Catch ex As Exception
                Return Nothing
            End Try

        End Function
    End Class

End Namespace
