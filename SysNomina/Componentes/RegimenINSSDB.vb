Imports DbConnect
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class RH_RegimenDetails
    Public reg_codigo As Integer
    Public reg_descripcion As String
    Public reg_insslaboral As Decimal
    Public reg_insspatronal As Decimal
    Public reg_minimo As Decimal
    Public reg_maximo As Decimal
    Public reg_subsidioINSS As Decimal
    Public reg_patronal As String
    Public reg_nominaINSS As String
End Class


Public Class RegimenINSSDetails
    Public Codigo As String
    Public Descripcion As String
    Public Laboral As Double
    Public Patronal As Double
End Class

Public Class RegimenINSSDB

    Public Shared Function Details(ByVal reg_codigo As Integer) As RH_RegimenDetails
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("reg_codigo", SqlDbType.Int, 5, ParameterDirection.Input, reg_codigo)

        Try
            Dim dt As New DataTable
            dt = v.EjecutarComando("_RH_RegimenINSS_List", "Tabla")
            If dt.Rows.Count >= 1 Then
                Dim d As RH_RegimenDetails
                d.reg_codigo = dt.Rows(0)("reg_codigo")
                d.reg_descripcion = dt.Rows(0)("reg_descripcion")
                d.reg_insslaboral = dt.Rows(0)("reg_insslaboral")
                d.reg_insspatronal = dt.Rows(0)("reg_insspatronal")
                d.reg_minimo = dt.Rows(0)("reg_minimo")
                d.reg_maximo = dt.Rows(0)("reg_maximo")
                d.reg_subsidioINSS = dt.Rows(0)("reg_subsidioINSS")
                d.reg_patronal = dt.Rows(0)("reg_patronal")
                d.reg_nominaINSS = dt.Rows(0)("reg_nominaINSS")
                Return d
            Else : Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Shared Function GetList(ByVal reg_codigo As Integer) As DataTable
        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("reg_codigo", SqlDbType.Int, 5, ParameterDirection.Input, reg_codigo)
        Try
            Return v.EjecutarComando("_RH_RegimenINSS_List", "Tabla")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function ADD(ByVal reg_codigo As Integer, ByVal reg_descripcion As String, ByVal reg_insslaboral As Decimal, _
                            ByVal reg_insspatronal As Decimal, ByVal reg_minimo As Decimal, ByVal reg_maximo As Decimal, _
                            ByVal SubsidioINSS As Decimal, ByVal reg_Patronal As String, ByVal reg_nominaINSS As String, ByVal Borrar As Boolean) As DataTable

        Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        v.AddParameter("reg_codigo", SqlDbType.Int, 5, ParameterDirection.Input, reg_codigo)
        v.AddParameter("reg_descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, reg_descripcion)
        v.AddParameter("reg_insslaboral", SqlDbType.Float, 5, ParameterDirection.Input, reg_insslaboral)
        v.AddParameter("reg_insspatronal", SqlDbType.Float, 5, ParameterDirection.Input, reg_insspatronal)
        v.AddParameter("reg_minimo", SqlDbType.Float, 5, ParameterDirection.Input, reg_minimo)
        v.AddParameter("reg_maximo", SqlDbType.Float, 5, ParameterDirection.Input, reg_maximo)
        v.AddParameter("reg_subsidioINSS", SqlDbType.Float, 5, ParameterDirection.Input, SubsidioINSS)
        v.AddParameter("borrar", SqlDbType.Bit, 5, ParameterDirection.Input, Borrar)
        v.AddParameter("reg_Patronal", SqlDbType.NVarChar, 50, ParameterDirection.Input, reg_Patronal)
        v.AddParameter("reg_nominaINSS", SqlDbType.NVarChar, 50, ParameterDirection.Input, reg_nominaINSS)

        Try
            Return v.EjecutarComando("_RH_RegimenINSS_ADD", "Tabla")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



    'Public Shared Function GetDetails(ByVal Codigo As String) As RegimenINSSDetails

    '    Dim DBConn As SqlConnection
    '    Dim DBCommand As SqlDataAdapter
    '    Dim dsFicha As New DataSet()
    '    Dim Details As New RegimenINSSDetails()

    '    DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

    '    DBCommand = New SqlDataAdapter("_GetList_RegimenINSSDetail", DBConn)
    '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

    '    Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)

    '    pIdent.Value = Codigo
    '    DBCommand.SelectCommand.Parameters.Add(pIdent)

    '    DBCommand.Fill(dsFicha, "RegimenINSS")

    '    If dsFicha.Tables("RegimenINSS").Rows.Count = 1 Then

    '        Details.Codigo = dsFicha.Tables("TiposMovimientos").Rows(0).Item("reg_codigo")
    '        Details.Descripcion = dsFicha.Tables("TiposMovimientos").Rows(0).Item("reg_descripcion")
    '        Details.Laboral = dsFicha.Tables("TiposMovimientos").Rows(0).Item("reg_laboral")
    '        Details.Patronal = dsFicha.Tables("TiposMovimientos").Rows(0).Item("reg_patronal")

    '    End If

    '    Return Details

    'End Function

    Public Shared Function GetList(ByVal filtro As String) As DataSet

        Dim DBConn As SqlConnection
        Dim DBCommand As SqlDataAdapter
        Dim dsFicha As New DataSet()


        DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        DBCommand = New SqlDataAdapter("_GetList_RegimenINSS", DBConn)
        DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim pIdent2 As New SqlParameter("@Filtro", SqlDbType.NVarChar)

        pIdent2.Value = filtro

        DBCommand.SelectCommand.Parameters.Add(pIdent2)


        Try
            DBCommand.Fill(dsFicha, "RegimenINSS")
            DBConn.Close()
            Return dsFicha

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Sts-Nomina")
            Return Nothing
        End Try

    End Function



End Class

