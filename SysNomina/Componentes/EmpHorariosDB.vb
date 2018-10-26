Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class EmpHorarioDetails
        Public Empresa As String
        Public Empleado As String
        Public Domingo As String
        Public Lunes As String
        Public Martes As String
        Public Miercoles As String
        Public Jueves As String
        Public Viernes As String
        Public Sabado As String
    End Class

    Public Class EmpHorarioDB

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpHorarioReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EmpHorario")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String) As EmpHorarioDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsEmpHorario As New DataSet()
            Dim Details As New EmpHorarioDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpHorarioDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsEmpHorario, "EmpHorario")

            If dsEmpHorario.Tables("EmpHorario").Rows.Count = 1 Then

                Details.Empresa = dsEmpHorario.Tables("EmpHorario").Rows(0).Item("Empr_Codigo")
                Details.Empleado = dsEmpHorario.Tables("EmpHorario").Rows(0).Item("Emp_Codigo")
                Details.Domingo = dsEmpHorario.Tables("EmpHorario").Rows(0).Item("Domingo")
                Details.Lunes = dsEmpHorario.Tables("EmpHorario").Rows(0).Item("Lunes")
                Details.Martes = dsEmpHorario.Tables("EmpHorario").Rows(0).Item("Martes")
                Details.Miercoles = dsEmpHorario.Tables("EmpHorario").Rows(0).Item("Miercoles")
                Details.Jueves = dsEmpHorario.Tables("EmpHorario").Rows(0).Item("Jueves")
                Details.Viernes = dsEmpHorario.Tables("EmpHorario").Rows(0).Item("Viernes")
                Details.Sabado = dsEmpHorario.Tables("EmpHorario").Rows(0).Item("Sabado")

            End If

            Return Details

        End Function

        Public Function GetList() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpHorario", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            DBCommand.Fill(dsFicha, "EmpHorario")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Function GetListBuscar(ByVal Filtro As String, ByVal Empresa As String) As DataSet

            'Revisar los datos de busqueda y donde se utilizan.
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpHorarioBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EmpHorario")

            DBConn.Close()

            Return dsFicha

        End Function

        '        Public Function GetListBuscarCombo(ByVal Filtro As String) As DataSet
        '           Dim DBConn As SqlConnection
        '          Dim DBCommand As SqlDataAdapter
        '         Dim dsFicha As New DataSet()
        '         

        '        
        '      DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        '     DBCommand = New SqlDataAdapter("_GetListHorarioBuscarCombo", DBConn)
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '   Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
        '  Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

        ' pIdent.Value = Filtro
        'pIdent2.Value = EmpresaActual
        '            DBCommand.SelectCommand.Parameters.Add(pIdent)
        '           DBCommand.SelectCommand.Parameters.Add(pIdent2)
        '
        '           DBCommand.Fill(dsFicha, "Horario")

        '          DBConn.Close()

        '         Return dsFicha

        '    End Function

        Public Function GetListCodigo(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpHorarioCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EmpHorario")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub delete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpHorarioDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Function Additem(ByVal Codigo As String, ByVal Domingo As String, _
                    ByVal Lunes As String, ByVal Martes As String, ByVal Miercoles As String, _
                    ByVal Jueves As String, ByVal Viernes As String, ByVal Sabado As String) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpHorarioAdd", DBConn)
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

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Domingo
            pIdent4.Value = Lunes
            pIdent5.Value = Martes
            pIdent6.Value = Miercoles
            pIdent7.Value = Jueves
            pIdent8.Value = Viernes
            pIdent9.Value = Sabado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)



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



        Public Function Update(ByVal Codigo As String, ByVal Domingo As String, _
                    ByVal Lunes As String, ByVal Martes As String, ByVal Miercoles As String, _
                    ByVal Jueves As String, ByVal Viernes As String, ByVal Sabado As String) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpHorarioUpdate", DBConn)
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

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Domingo
            pIdent4.Value = Lunes
            pIdent5.Value = Martes
            pIdent6.Value = Miercoles
            pIdent7.Value = Jueves
            pIdent8.Value = Viernes
            pIdent9.Value = Sabado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)



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

    End Class

End Namespace
