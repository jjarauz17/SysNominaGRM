Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class MarcaRelojDetails
        Public Empresa As String
        Public Empleado As String
        Public DiaHora As String
        Public Tipo As String
    End Class

    Public Class MarcaRelojDB


        Public Function GetDetails(ByVal Empleado As String, ByVal Fecha As DateTime, ByVal Tipo As String) As MarcaRelojDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsMarcaReloj As New DataSet()
            Dim Details As New MarcaRelojDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListMarcaRelojDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent4 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent.Value = Empleado
            pIdent2.Value = Fecha
            pIdent3.Value = EmpresaActual
            pIdent4.Value = Tipo
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            DBCommand.Fill(dsMarcaReloj, "MarcaReloj")

            If dsMarcaReloj.Tables("MarcaReloj").Rows.Count = 1 Then

                Details.Empleado = dsMarcaReloj.Tables("MarcaReloj").Rows(0).Item("emp_codigo")
                Details.Tipo = dsMarcaReloj.Tables("MarcaReloj").Rows(0).Item("mrj_tipo")
                Details.DiaHora = dsMarcaReloj.Tables("MarcaReloj").Rows(0).Item("mrj_fechahora")
                Details.Empresa = dsMarcaReloj.Tables("MarcaReloj").Rows(0).Item("empr_codigo")

            End If

            Return Details

        End Function

        Public Function GetEntradas(ByVal Empleado As String, ByVal Fecha As DateTime) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEntradasEmpleado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Empleado
            pIdent2.Value = Fecha
            pIdent3.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "MarcaReloj")


            Return dsFicha

        End Function
        Public Function GetSalidas(ByVal Empleado As String, ByVal Fecha As DateTime) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListSalidasEmpleado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Empleado
            pIdent2.Value = Fecha
            pIdent3.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "MarcaReloj")


            Return dsFicha

        End Function

        Public Function GetListFechaEntrada(ByVal Fecha As DateTime) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFecha", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = Fecha
            pIdent3.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "MarcaReloj")


            Return dsFicha

        End Function

        Public Shared Function GetListMarcadas(ByVal Empleado As String, ByVal Departamento As String, ByVal FInicio As DateTime, ByVal Ffinal As DateTime) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListMarcadas", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@FInicio", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@FFinal", SqlDbType.DateTime)

            pIdent.Value = EmpresaActual
            pident2.Value = Empleado
            pIdent3.Value = Departamento
            pIdent4.Value = FInicio
            pIdent5.Value = Ffinal

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pident2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            DBCommand.Fill(dsFicha, "Marcadas")

            Return dsFicha

        End Function

        Public Sub delete(ByVal Empleado As String, ByVal Fecha As DateTime)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_MarcaRelojDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Empleado
            pIdent2.Value = Fecha
            pIdent3.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Additem(ByVal Empleado As String, ByVal Fecha As DateTime, _
                                ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_MarcaRelojAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub



        Public Sub Update(ByVal Empleado As String, ByVal Fecha As DateTime, _
                                ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_MarcaRelojUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub


        'Public Function GetListMarcadasDeptoFecha(ByVal Departamento As String, ByVal Fecha As DateTime) As DataSet

        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()

        '     
        '    DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_GetListRegEntSalDeptoFecha", DBConn)
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pident2 As New SqlParameter("@Depto", SqlDbType.NVarChar)
        '    Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)


        '    pIdent.Value = EmpresaActual
        '    pident2.Value = Departamento
        '    pIdent4.Value = Fecha


        '    DBCommand.SelectCommand.Parameters.Add(pIdent)
        '    DBCommand.SelectCommand.Parameters.Add(pident2)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent4)


        '    DBCommand.Fill(dsFicha, "RegEntSal")

        '    Return dsFicha

        'End Function

    End Class

End Namespace
