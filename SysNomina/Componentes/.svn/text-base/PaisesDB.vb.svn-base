
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class PaisesDetails
        Public Codigo As String
        Public Nombre As String
    End Class

    Public Class PaisesDB


        Public Shared Function GetDetails(ByVal Codigo As String) As PaisesDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim ds As New DataSet
            Dim Details As New PaisesDetails

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("GetDetailsPais", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@codigo", SqlDbType.Int)

            pIdent.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            DBCommand.Fill(ds, "Pais")

            If ds.Tables("pais").Rows.Count = 1 Then
                Details.Codigo = ds.Tables("pais").Rows(0).Item("pais_id")
                Details.Nombre = ds.Tables("pais").Rows(0).Item("pais_Nombre")
            End If

            Return Details

        End Function

        Public Shared Function GetList(ByVal GRID As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPaises", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Grid As New SqlParameter("@Grid", SqlDbType.Bit)
            _Grid.Value = GRID

            DBCommand.SelectCommand.Parameters.Add(_Grid)

            DBCommand.Fill(dsFicha, "Paises")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListNuevo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPaisesNuevo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Paises")
            DBConn.Close()

            Return dsFicha.Tables("Paises").Rows(0).Item("codigo")

        End Function

        Public Shared Sub AddItem(ByVal Codigo As String, ByVal Nombre As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PaisADD", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@Nombre", SqlDbType.NVarChar)

            pIdent.Value = Codigo
            pIdent1.Value = Nombre

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub



        Public Shared Sub Update(ByVal Codigo As String, ByVal Nombre As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PaisUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@Nombre", SqlDbType.NVarChar)

            pIdent.Value = Codigo
            pIdent1.Value = Nombre

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub Delete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PaisDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.Int)


            pIdent.Value = Codigo

            DBCommand.SelectCommand.Parameters.Add(pIdent)

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
