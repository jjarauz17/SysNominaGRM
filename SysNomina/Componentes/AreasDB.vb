Imports DbConnect

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class AreaDetails
        Public Departamento As String
        Public Area As String
        Public Descripcion As String
        Public Empleado As String
        Public Dias_Laborales As Integer
        Public OrdenReportes As String
    End Class

    Public Class AreaDB

        Public Shared Function RH_Prod_Area(ByVal id As Integer) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
            Try
                Return v.EjecutarComando("_RH_Prod_Area", "Areas")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Sub RH_Prod_Area_Del(ByVal id As Integer)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
            Try
                v.EjecutarComando("_RH_Prod_Area_Del")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Sub
        Public Shared Sub RH_Prod_Area_Add(ByVal id As Integer, ByVal empr_codigo As Integer, _
                ByVal dep_codigo As String, ByVal are_codigo As String, ByVal minimo As Decimal, _
                ByVal maximo As Decimal)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
            v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, empr_codigo)
            v.AddParameter("dep_codigo", SqlDbType.NVarChar, 4, ParameterDirection.Input, dep_codigo)
            v.AddParameter("are_codigo", SqlDbType.NVarChar, 3, ParameterDirection.Input, are_codigo)
            v.AddParameter("min_produccion", SqlDbType.Int, 8, ParameterDirection.Input, minimo)
            v.AddParameter("max_produccion", SqlDbType.Int, 8, ParameterDirection.Input, maximo)
            Try
                v.EjecutarComando("_RH_Prod_Area_Add")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Sub

        Public Shared Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListareasBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Areas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetDetails(ByVal Departamento As String, ByVal Area As String) As AreaDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim ds As New DataSet()
            Dim Details As New AreaDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListAreaDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Area", SqlDbType.NVarChar)

            pIdent.Value = Departamento
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Area
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            DBCommand.Fill(ds, "Areas")

            If ds.Tables("Areas").Rows.Count = 1 Then
                Details.Departamento = ds.Tables("Areas").Rows(0).Item("dep_codigo").ToString
                Details.Area = ds.Tables("Areas").Rows(0).Item("are_codigo").ToString
                Details.Descripcion = ds.Tables("Areas").Rows(0).Item("are_descripcion").ToString
                Details.Empleado = ds.Tables("Areas").Rows(0).Item("emp_codigo").ToString
                Details.Dias_Laborales = ds.Tables("Areas").Rows(0).Item("are_diaslaborales").ToString
                Details.OrdenReportes = ds.Tables("Areas").Rows(0).Item("orden").ToString

            End If

            Return Details

        End Function

        Public Shared Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())


            DBCommand = New SqlDataAdapter("_GetListArea", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            DBCommand.Fill(dsFicha, "Areas")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Shared Function GetListGrid() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())


            DBCommand = New SqlDataAdapter("_GetListArea_Grid", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            DBCommand.Fill(dsFicha, "Areas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListDepto(ByVal Departamento As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())


            DBCommand = New SqlDataAdapter("_GetListAreaDepto", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Areas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListNuevo(ByVal Departamento As String) As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())


            DBCommand = New SqlDataAdapter("_GetListAreaNvoCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Areas")

            DBConn.Close()

            Return dsFicha.Tables("Areas").Rows(0)("Codigo")

        End Function



        Public Shared Sub delete(ByVal Departamento As String, ByVal Area As String)

            ' Crea una instancia de conexion y un comando SQL

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            DBCommand = New SqlDataAdapter("_Area_Delete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Area", SqlDbType.NVarChar)

            pIdent.Value = Departamento
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Area
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

        Public Shared Sub Additem(ByVal Departamento As String, ByVal Area As String, _
            ByVal Descripcion As String, ByVal Empleado As String, ByVal Dias_Laborales As Integer, _
            ByVal Orden As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
            DBCommand = New SqlDataAdapter("_Area_Add", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@DiasLaborales", SqlDbType.Int)
            Dim pIdent7 As New SqlParameter("@Orden", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = Area
            pIdent4.Value = Descripcion
            pIdent5.Value = Empleado
            pIdent6.Value = Dias_Laborales
            pIdent7.Value = Orden

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Sub Update(ByVal Departamento As String, ByVal Area As String, _
            ByVal Descripcion As String, ByVal Empleado As String, ByVal Dias_Laborales As Integer, _
            ByVal Orden As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
            DBCommand = New SqlDataAdapter("_Area_Update", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@DiasLaborales", SqlDbType.Int)
            Dim pIdent7 As New SqlParameter("@Orden", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = Area
            pIdent4.Value = Descripcion
            pIdent5.Value = Empleado
            pIdent6.Value = Dias_Laborales
            pIdent7.Value = Orden

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

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