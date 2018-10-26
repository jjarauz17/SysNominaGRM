Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Activo_FijosDetails
        Public Codigo As String
        Public Descripcion As String
        Public Codigo_Barra As String
        Public Unidad As String
        Public Precio As String
        Public Grupo_Depreciacion As String
        Public Cuenta_Gastos As String
        Public Cuenta_Depreciacion As String
        Public Empleado As String
        Public Fecha_Entrada As String
        Public Estado As String

    End Class

    Public Class Activo_FijosDB

        Public Function GeneradorReportes(ByVal Empleado As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Estado As String, ByVal Orden As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesActivos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pCargo As New SqlParameter("@Cargo", SqlDbType.NVarChar)
            Dim pEstatus As New SqlParameter("@Estatus", SqlDbType.Int)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpleado.Value = Empleado
            pDepartamento.Value = Departamento
            pCargo.Value = Cargo
            pEstatus.Value = Estado
            pOrden.Value = Orden
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpleado)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pCargo)
            DBCommand.SelectCommand.Parameters.Add(pEstatus)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Activo_Fijos")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetListReporte(ByVal Empleado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListActivosEmpleadoReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Empleado
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EMPLEADOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String) As Activo_FijosDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsActivo_Fijos As New DataSet()
            Dim Details As New Activo_FijosDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListActivoDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.NVarChar)
            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            DBCommand.Fill(dsActivo_Fijos, "Activo_Fijos")

            If dsActivo_Fijos.Tables("Activo_Fijos").Rows.Count = 1 Then
                Details.Codigo = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Codigo_Activo").ToString
                Details.Descripcion = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("DESCRIPCION").ToString
                Details.Codigo_Barra = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("CODIGO_BARRA").ToString
                Details.Unidad = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("UNIDAD").ToString
                Details.Precio = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("PRECIO").ToString
                Details.Grupo_Depreciacion = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("GRUPO_DEPRECIACION").ToString
                Details.Cuenta_Depreciacion = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("CUENTA_DEPRECIACION").ToString
                Details.Cuenta_Gastos = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("CUENTA_GASTOS").ToString
                Details.Empleado = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("codigo_empleado").ToString
                Details.Fecha_Entrada = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("Fecha_Entrada").ToString
                Details.Estado = dsActivo_Fijos.Tables("Activo_Fijos").Rows(0).Item("estado").ToString


            End If
            DBConn.Close()
            Return Details

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Codigo_Activo as [CODIGO ], DESCRIPCION FROM Activo_Fijos WHERE Empresa = '" & EmpresaActual & "' AND ESTADO = 'P'", DBConn)
            DBCommand = New SqlDataAdapter("_GetListActivos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            DBCommand.Fill(dsFicha, "Activo_Fijos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Codigo_Activo as [CODIGO ], DESCRIPCION FROM Activo_Fijos WHERE Descripcion Like '%" & Filtro & "%' And Empresa = '" & EmpresaActual & "' AND ESTADO = 'P'", DBConn)
            DBCommand = New SqlDataAdapter("_GetListActivoBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Activo_Fijos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListActivoEmpleado(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListActivoEmpleado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Activo_Fijos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'DBCommand = New SqlDataAdapter("Select CodGrup as [Código], Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND CodGrup ='" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand = New SqlDataAdapter("_GetListActivoCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Activos_Fijos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            'cmd.CommandType = CommandType.Text
            'cmd.CommandText = "DELETE FROM Activo_Fijos WHERE Codigo_Activo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"
            DBCommand = New SqlDataAdapter("_ActivoFijoDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Sub Additem(ByVal Codigo As String, ByVal Descripcion As String, ByVal Codigo_Barra As String, _
            ByVal Unidad As String, ByVal Precio As String, ByVal Grupo_Depreciacion As String, _
            ByVal Cuenta_Gastos As String, ByVal Cuenta_Depreciacion As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_ActivoFijoAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Codigo_barra", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Unidad", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Fecha_Entrada", SqlDbType.DateTime)
            Dim pIdent6 As New SqlParameter("@Precio", SqlDbType.Float)
            Dim pIdent7 As New SqlParameter("@Grupo_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Codigo_Empleado", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Cuenta_Gastos", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Cuenta_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = Descripcion
            pIdent3.Value = Codigo_Barra
            pIdent4.Value = Unidad
            pIdent5.Value = Today
            pIdent6.Value = Precio
            pIdent7.Value = Grupo_Depreciacion
            pIdent8.Value = DBNull.Value
            pIdent9.Value = Cuenta_Gastos
            pIdent10.Value = Cuenta_Depreciacion
            pIdent11.Value = "P"
            pIdent12.Value = EmpresaActual

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
            DBCommand.SelectCommand.Parameters.Add(pIdent12)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Update(ByVal Codigo As String, ByVal Descripcion As String, ByVal Codigo_Barra As String, _
            ByVal Unidad As String, ByVal Fecha_Entrada As String, ByVal Precio As String, ByVal Grupo_Depreciacion As String, _
            ByVal Cuenta_Gastos As String, ByVal Cuenta_Depreciacion As String, ByVal Estado As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            DBCommand = New SqlDataAdapter("_ActivoFijoUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Codigo_barra", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Unidad", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Fecha_Entrada", SqlDbType.DateTime)
            Dim pIdent6 As New SqlParameter("@Precio", SqlDbType.Float)
            Dim pIdent7 As New SqlParameter("@Grupo_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Codigo_Empleado", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Cuenta_Gastos", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Cuenta_Depreciacion", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = Descripcion
            pIdent3.Value = Codigo_Barra
            pIdent4.Value = Unidad
            pIdent5.Value = Fecha_Entrada
            pIdent6.Value = Precio
            pIdent7.Value = Grupo_Depreciacion
            pIdent8.Value = DBNull.Value
            pIdent9.Value = Cuenta_Gastos
            pIdent10.Value = Cuenta_Depreciacion
            pIdent11.Value = Estado
            pIdent12.Value = EmpresaActual

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
            DBCommand.SelectCommand.Parameters.Add(pIdent12)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Function AsignarActivo(ByVal Empleado As String, ByVal Codigo As String) As Integer


            ' cmd.CommandText = "UPDATE Activo_Fijos SET CODIGO_EMPLEADO = '" & Empleado & "', ESTADO = 'A' WHERE CODIGO_ACTIVO = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AsignarActivoFijo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pident2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pident2.Value = Empleado
            pIdent3.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pident2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Function

        Public Function TrasladarActivo(ByVal EmpleadoAnterior As String, ByVal EmpleadoNuevo As String, ByVal Codigo As String) As Integer

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Activo_Fijos SET CODIGO_EMPLEADO = '" & EmpleadoNuevo & "', ESTADO = 'A' WHERE CODIGO_ACTIVO = '" & Codigo & "' AND CODIGO_EMPLEADO ='" & EmpleadoAnterior & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

    End Class

End Namespace