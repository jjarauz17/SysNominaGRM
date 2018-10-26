Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Namespace VB.SysContab
    Public Class Novedades_INSSDetails
        Public Empleado As String
        Public Nombre As String
        Public Acumulado As Long
        Public Dias As Long
        Public APagar As Long
    End Class

    Public Class Novedades_INSSDB
        'Public Function GetList(ByVal Empleado As String, ByVal Desde As DateTime, _
        '   ByVal Hasta As DateTime, ByVal Todos As Boolean)
        'Dim DBConn As SqlConnection
        'Dim DBCommand As SqlDataAdapter
        'Dim dsFicha As New DataSet()


        ' 
        'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        'DBCommand = New SqlDataAdapter("_GetListVacaciones", DBConn)
        'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        'Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
        'Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
        'Dim pIdent3 As New SqlParameter("@_Desde", SqlDbType.DateTime)
        'Dim pIdent4 As New SqlParameter("@_Hasta", SqlDbType.DateTime)
        'Dim pIdent5 As New SqlParameter("@Todos", SqlDbType.Bit)

        'pIdent.Value = EmpresaActual
        'pIdent2.Value = Empleado
        'pIdent3.Value = Desde
        'pIdent4.Value = Hasta
        'pIdent5.Value = Todos

        'DBCommand.SelectCommand.Parameters.Add(pIdent)
        'DBCommand.SelectCommand.Parameters.Add(pIdent2)
        'DBCommand.SelectCommand.Parameters.Add(pIdent3)
        'DBCommand.SelectCommand.Parameters.Add(pIdent4)
        'DBCommand.SelectCommand.Parameters.Add(pIdent5)

        'DBCommand.Fill(dsFicha, "Vacaciones")

        'Return dsFicha

        'End Function

        'Public Function GetDetails(ByVal Empleado As String, ByVal Desde As String, _
        '   ByVal Hasta As String)
        'Dim DBConn As SqlConnection
        'Dim DBCommand As SqlDataAdapter
        'Dim dsFicha As New DataSet()
        'Dim Details As New VB.SysContab.VacacionesDetails()


        ' 
        'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        'DBCommand = New SqlDataAdapter("_GetListVacaciones", DBConn)
        'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        'Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
        'Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
        'Dim pIdent3 As New SqlParameter("@Desde", SqlDbType.NVarChar)
        'Dim pIdent4 As New SqlParameter("@Hasta", SqlDbType.NVarChar)
        'Dim pIdent5 As New SqlParameter("@Todos", SqlDbType.Bit)

        'pIdent.Value = EmpresaActual
        'pIdent2.Value = Empleado
        'pIdent3.Value = Desde
        'pIdent4.Value = Hasta
        'pIdent5.Value = 0

        'DBCommand.SelectCommand.Parameters.Add(pIdent)
        'DBCommand.SelectCommand.Parameters.Add(pIdent2)
        'DBCommand.SelectCommand.Parameters.Add(pIdent3)
        'DBCommand.SelectCommand.Parameters.Add(pIdent4)
        'DBCommand.SelectCommand.Parameters.Add(pIdent5)

        'DBCommand.Fill(dsFicha, "Vacaciones")

        'If dsFicha.Tables("Vacaciones").Rows.Count = 1 Then
        '    Details.Empleado = dsFicha.Tables("Vacaciones").Rows(0).Item("Codigo")
        '    Details.Nombre = dsFicha.Tables("Vacaciones").Rows(0).Item("Nombre")
        '    Details.Acumulado = dsFicha.Tables("Vacaciones").Rows(0).Item("Acumulado")
        '    Details.Dias = dsFicha.Tables("Vacaciones").Rows(0).Item("Dias")
        '    Details.APagar = dsFicha.Tables("Vacaciones").Rows(0).Item("APagar")
        'End If
        'Return Details
        'End Function

        Public Sub Additem(ByVal Empleado As String, _
            ByVal Mes As String, ByVal Novedad As String, _
            ByVal Fecha As String, ByVal Devengado As String, _
            ByVal Salario As String, ByVal Aportes As String, _
            ByVal Semanas As String, ByVal CCosto As String, _
            ByVal TipoEmpleo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Novedades_INSSAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Novedad", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent6 As New SqlParameter("@Devengado", SqlDbType.Money)
            Dim pIdent7 As New SqlParameter("@Salario", SqlDbType.Money)
            Dim pIdent8 As New SqlParameter("@Aportes", SqlDbType.Money)
            Dim pIdent9 As New SqlParameter("@Semanas", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@CCosto", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@TipoEmpleo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Mes
            pIdent4.Value = Novedad
            pIdent5.Value = Fecha
            pIdent6.Value = Devengado
            pIdent7.Value = Salario
            pIdent8.Value = Aportes
            pIdent9.Value = Semanas
            pIdent10.Value = CCosto
            pIdent11.Value = TipoEmpleo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Sub UpdateReportado(ByVal Empleado As String, _
            ByVal Mes As String, ByVal Novedad As String, _
            ByVal Fecha As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Novedades_INSSReportar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Novedad", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Mes
            pIdent4.Value = Novedad
            pIdent5.Value = Fecha

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

        Public Sub delete(ByVal Empleado As String, _
           ByVal Mes As String, ByVal Novedad As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Novedades_INSSDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Novedad", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Mes
            pIdent4.Value = Novedad

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
    End Class
End Namespace

