Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class CargosDetails
        Public Codigo As String
        Public Nombre As String

    End Class

    Public Class CargosDB

        Public Shared Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "CARGOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetDetails(ByVal Codigo As String) As CargosDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsCargos As New DataSet()
            Dim Details As New CargosDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            DBCommand.Fill(dsCargos, "CARGOS")

            If dsCargos.Tables("CARGOS").Rows.Count = 1 Then
                Details.Codigo = dsCargos.Tables("CARGOS").Rows(0).Item("Codigo")
                Details.Nombre = dsCargos.Tables("CARGOS").Rows(0).Item("Nombre")
            End If

            Return Details

        End Function

        Public Shared Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()
            Return dsFicha

        End Function

        Public Shared Function GetListNuevo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosNuevo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()
            'If IsDBNull(dsFicha.Tables("Cargos").Rows(0).Item("Codigo")) Then
            '    Return "1"
            'Else
            Return dsFicha.Tables("Cargos").Rows(0).Item("Codigo")
            'End If
        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListBuscarCombo(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosBuscarCombo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListNombre(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCargosBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cargos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function Additem(ByVal Codigo As String, ByVal Nombre As String) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CargosAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Nombre", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Nombre

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                Return -1
            End Try
            Return 0

        End Function

        Public Shared Sub Update(ByVal Codigo As String, ByVal Nombre As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CargosUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Nombre

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub delete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CargosDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

    End Class

End Namespace
