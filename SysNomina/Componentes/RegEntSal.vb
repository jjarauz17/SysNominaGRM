Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class RegEntSalDetails

        Public Empleado As String
        Public Fecha As String
        Public HEntrada As String
        Public HSalida As String

    End Class

    Public Class RegEntSalDB


        Public Function GetDetails(ByVal Codigo As String, ByVal Fecha As Date) As RegEntSalDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet()
            Dim Details As New RegEntSalDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListRegEntSalDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsHorario, "RegEntSal")

            If dsHorario.Tables("RegEntSal").Rows.Count = 1 Then

                Details.Empleado = dsHorario.Tables("RegEntSal").Rows(0).Item("emp_codigo")
                Details.Fecha = dsHorario.Tables("RegEntSal").Rows(0).Item("res_fecha")
                Details.HEntrada = dsHorario.Tables("RegEntSal").Rows(0).Item("res_hent")
                Details.HSalida = dsHorario.Tables("RegEntSal").Rows(0).Item("res_hsal")

            End If

            Return Details

        End Function

        Public Function GetListEmpleado(ByVal Empleado As String, ByVal Fecha As Date) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListRegEntSalEmpleado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@EMPLEADO", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            DBCommand.Fill(dsFicha, "RegEntSal")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListFecha(ByVal Fecha As Date, ByVal Quincena As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListRegEntSalFecha", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent2 As New SqlParameter("@empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Quincena", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            pIdent3.Value = Fecha
            pIdent4.Value = Quincena

            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            'DBCommand.SelectCommand.Parameters.Add(pIdent4)

            DBCommand.Fill(dsFicha, "RegEntSal")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Sub delete(ByVal Empleado As String, ByVal Fecha As Date)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RegEntSalDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = Empleado
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub DeleteFecha(ByVal Fecha As Date, ByVal Depto As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RegEntSalDeleteFecha", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Depto", SqlDbType.NVarChar)


            pIdent2.Value = EmpresaActual
            pIdent3.Value = Fecha
            pIdent4.Value = Depto

            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Additem(ByVal Empleado As String, _
            ByVal Fecha As Date, _
            ByVal HEntrada As DateTime, _
            ByVal HSalida As DateTime, _
            ByVal Quincena As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RegEntSalAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@HEntrada", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@HSalida", SqlDbType.DateTime)
            Dim pIdent6 As New SqlParameter("@Quincena", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = HEntrada
            pIdent5.Value = HSalida
            pIdent6.Value = Quincena


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub


        Public Sub Aplicar(ByVal Empleado As String, _
                    ByVal Fecha As Date)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RegEntSal_Aplicar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha


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

        Public Sub Update(ByVal Empleado As String, _
            ByVal Fecha As Date, _
            ByVal HEntrada As DateTime, _
            ByVal HSalida As DateTime)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RegEntSalUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@HEntrada", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@HSalida", SqlDbType.DateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Fecha
            pIdent4.Value = HEntrada
            pIdent5.Value = HSalida


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub
        Public Function GetListMarcadasDeptoFecha(ByVal Departamento As String, ByVal Fecha As DateTime) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListRegEntSalDeptoFecha", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident2 As New SqlParameter("@Depto", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)


            pIdent.Value = EmpresaActual
            pident2.Value = Departamento
            pIdent4.Value = Fecha


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pident2)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                DBCommand.Fill(dsFicha, "RegEntSal")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha

        End Function
    End Class

End Namespace

