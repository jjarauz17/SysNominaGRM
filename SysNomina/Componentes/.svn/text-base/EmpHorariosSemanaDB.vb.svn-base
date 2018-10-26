Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class EmpHorarioSemanaDetails
        Public Empresa As String
        Public Empleado As String
        Public Semana As Date
        Public Domingo As String
        Public Lunes As String
        Public Martes As String
        Public Miercoles As String
        Public Jueves As String
        Public Viernes As String
        Public Sabado As String
    End Class

    Public Class EmpHorarioSemanaDB


        Public Function GetDetails(ByVal Empleado As String, ByVal Semana As DateTime) As EmpHorarioSemanaDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet()
            Dim Details As New EmpHorarioSemanaDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpHorariosSemanaDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Semana", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Empleado
            pIdent2.Value = Semana
            pIdent3.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsHorario, "EmpHorarioSemana")

            If dsHorario.Tables("EmpHorarioSemana").Rows.Count = 1 Then

                Details.Empresa = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Empr_Codigo")
                Details.Empleado = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Emp_Codigo")
                Details.Semana = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Semana")
                Details.Domingo = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Domingo")
                Details.Lunes = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Lunes")
                Details.Martes = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Martes")
                Details.Miercoles = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Miercoles")
                Details.Jueves = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Jueves")
                Details.Viernes = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Viernes")
                Details.Sabado = dsHorario.Tables("EmpHorarioSemana").Rows(0).Item("Sabado")
            End If

            Return Details

        End Function

        Public Function GetListSemana(ByVal Semana As DateTime) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpHorariosSemana", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Semana", SqlDbType.DateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Semana
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EmpHorarioSemana")

            DBConn.Close()

            Return dsFicha


        End Function


        Public Function GetListEmpleado(ByVal Empleado As String, ByVal Semana As DateTime) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpHorariosSemanaEmpleado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Semana", SqlDbType.DateTime)

            pIdent.Value = Empleado
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Semana
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "EmpHorarioSemana")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub delete(ByVal Empleado As String, ByVal Semana As DateTime)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpHorarioSemanaDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Semana", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Empleado
            pIdent2.Value = Semana
            pIdent3.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Additem(ByVal Codigo As String, ByVal Semana As DateTime, ByVal Domingo As String, _
                    ByVal Lunes As String, ByVal Martes As String, ByVal Miercoles As String, _
                    ByVal Jueves As String, ByVal Viernes As String, ByVal Sabado As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpHorarioSemanaAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Domingo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Lunes", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Martes", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Miercoles", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Jueves", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Viernes", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Sabado", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Semana", SqlDbType.DateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Domingo
            pIdent4.Value = Lunes
            pIdent5.Value = Martes
            pIdent6.Value = Miercoles
            pIdent7.Value = Jueves
            pIdent8.Value = Viernes
            pIdent9.Value = Sabado
            pIdent10.Value = Semana

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



            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub



        Public Sub Update(ByVal Codigo As String, ByVal Semana As DateTime, ByVal Domingo As String, _
                    ByVal Lunes As String, ByVal Martes As String, ByVal Miercoles As String, _
                    ByVal Jueves As String, ByVal Viernes As String, ByVal Sabado As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpHorarioSemanaUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Domingo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Lunes", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Martes", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Miercoles", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Jueves", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Viernes", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Sabado", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Semana", SqlDbType.DateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Domingo
            pIdent4.Value = Lunes
            pIdent5.Value = Martes
            pIdent6.Value = Miercoles
            pIdent7.Value = Jueves
            pIdent8.Value = Viernes
            pIdent9.Value = Sabado
            pIdent10.Value = Semana

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
