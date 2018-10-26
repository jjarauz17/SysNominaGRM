Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab
    Public Class Empleado_AhorroDetailDB
        Public Empleado As String
        Public TipoAhorro As String
        Public Cuota As Double
        Public Activo As Boolean
        Public Moneda As String
        Public Desde As DateTime
    End Class

    Public Class Empleado_AhorroDB

        Public Shared Function Retiro(ByVal Empleado As String, ByVal V_Empleado As Double, ByVal V_Empresa As Double, _
            ByVal Periodo As String, ByVal TPeriodo As String, ByVal TDI_Empleado As String, _
            ByVal TDI_Empresa As String, ByVal Moneda As String, ByVal Fecha_pago As Date, ByVal Forma_Pago As String) As Boolean

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("V_Empleado", SqlDbType.Money, 10, ParameterDirection.Input, V_Empleado)
            v.AddParameter("V_Empresa", SqlDbType.Money, 10, ParameterDirection.Input, V_Empresa)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
            v.AddParameter("TPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
            v.AddParameter("TDI_Empleado", SqlDbType.NVarChar, 10, ParameterDirection.Input, TDI_Empleado)
            v.AddParameter("TDI_Empresa", SqlDbType.NVarChar, 10, ParameterDirection.Input, TDI_Empresa)
            v.AddParameter("Moneda", SqlDbType.NVarChar, 10, ParameterDirection.Input, Moneda)
            v.AddParameter("FormaPago", SqlDbType.NVarChar, 1, ParameterDirection.Input, Forma_Pago)
            v.AddParameter("FechaPago", SqlDbType.SmallDateTime, 100, ParameterDirection.Input, Fecha_pago)

            Try
                v.IniciarTransaccion()
                v.EjecutarComando("_RetiroAdd", "")
                v.CompletarTransaccion()
                Return True
            Catch ex As Exception
                v.AnularTransaccion()
                MsgBox(ex.Message)
                Return False
            End Try

            v = Nothing
        End Function

        Public Shared Function Transferencia(ByVal Empleado As String, ByVal Valor As Double, _
         ByVal Periodo As String, ByVal TPeriodo As String, ByVal TDI_Empleado As String, _
         ByVal TDI_Empresa As String, ByVal Moneda As String, ByVal Fecha_pago As Date) As Boolean

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("Valor", SqlDbType.Money, 10, ParameterDirection.Input, Valor)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
            v.AddParameter("TPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
            v.AddParameter("TDI_Empleado", SqlDbType.NVarChar, 10, ParameterDirection.Input, TDI_Empleado)
            v.AddParameter("TDI_Empresa", SqlDbType.NVarChar, 10, ParameterDirection.Input, TDI_Empresa)
            v.AddParameter("Moneda", SqlDbType.NVarChar, 10, ParameterDirection.Input, Moneda)
            v.AddParameter("FechaPago", SqlDbType.SmallDateTime, 100, ParameterDirection.Input, Fecha_pago)

            Try
                v.IniciarTransaccion()
                v.EjecutarComando("_Ahorro_Transferencia")
                v.CompletarTransaccion()
                Return True
            Catch ex As Exception
                v.AnularTransaccion()
                MsgBox(ex.Message)
                Return False
            End Try

            v = Nothing

        End Function
        Public Shared Function GetListAhorro_Disponible(ByVal Empleado As String) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            Try
                Return v.EjecutarComando("_GetListAhorro_Disponible", "Empleado_Ahorro")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return Nothing
        End Function

        Public Shared Function GetListEmpleado_Ahorro(ByVal Empleado As String) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            Return v.EjecutarComando("_GetListEmpleado_Ahorro_Detalle", "Empleado_Ahorro")

        End Function

        Public Shared Function GetListReporteEcAhorro(ByVal Empleado As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListReporteEcAhorro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            pident3.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pident3)
            DBCommand.Fill(dsFicha, "ECAhorro")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Shared Function ImprimirEmpleado_Ahorro(ByVal Empleado As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ReporteAhorro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            pident3.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pident3)
            DBCommand.Fill(dsFicha, "Empleado_Ahorro")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Shared Function GetListEmpleado_Ahorro_Grid(ByVal Empleado As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleado_Ahorro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            pident3.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pident3)
            DBCommand.Fill(dsFicha, "Empleado_Ahorro")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Shared Function GetListEmpleado_AhorroBuscar(ByVal Filtro As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleado_AhorroBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident3 As New SqlParameter("@Filtro", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            pident3.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pident3)
            DBCommand.Fill(dsFicha, "Empleado_Ahorro")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Shared Function GetDetailsEmpleado_Ahorro(ByVal Empleado As String) As Empleado_AhorroDetailDB
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim detalle As New VB.SysContab.Empleado_AhorroDetailDB()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetDetailsEmpleado_Ahorro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            pIdent3.Value = Empleado

            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "Empleado_Ahorro")
            DBConn.Close()

            If dsFicha.Tables(0).Rows.Count = 1 Then
                detalle.Empleado = dsFicha.Tables(0).Rows(0)("emp_codigo")
                detalle.TipoAhorro = dsFicha.Tables(0).Rows(0)("tah_codigo")
                detalle.Cuota = dsFicha.Tables(0).Rows(0)("tah_cuota")
                detalle.Activo = dsFicha.Tables(0).Rows(0)("tah_activo")
                detalle.Moneda = dsFicha.Tables(0).Rows(0)("mon_codigo")
                detalle.Desde = dsFicha.Tables(0).Rows(0)("tah_fecha")
            End If

            Return detalle


        End Function

        Public Shared Sub Add(ByVal Empleado As String, _
                    ByVal TipoAhorro As String, _
                    ByVal Cuota As Double, _
                    ByVal Fecha As DateTime, ByVal Moneda As String)
            'Agregar la definicion del tanque de ahorro para el empleado
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Empleado_Ahorro_Add", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TipoAhorro", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Cuota", SqlDbType.Float)
            Dim pIdent6 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pmoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = TipoAhorro
            pIdent5.Value = Cuota
            pIdent6.Value = Fecha
            pmoneda.Value = Moneda


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pmoneda)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub

        Public Shared Sub Update(ByVal Empleado As String, ByVal TipoAhorro As String, ByVal Cuota As Double, _
            ByVal Activo As Boolean, ByVal Fecha As DateTime, ByVal Moneda As String)
            'Agregar la definicion del tanque de ahorro para el empleado
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Empleado_Ahorro_Update", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TipoAhorro", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Cuota", SqlDbType.Float)
            Dim pIdent6 As New SqlParameter("@Activo", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pmoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = TipoAhorro
            pIdent5.Value = Cuota
            pIdent6.Value = Activo
            pIdent7.Value = Fecha
            pmoneda.Value = Moneda

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pmoneda)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub

        Public Shared Sub delete(ByVal Empleado As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Empleado_Ahorro_Delete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado

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

    Public Class Ahorro_DetalleDB

        Public Shared Sub delete(ByVal Codigo As String, ByVal Tipo As String, ByVal Empleado As String)

            'Borrar el Detalle Generado en la Tabla Ahorro_Detalle, Luego de actualizar los acumulados de ahorros 
            'en la tabla de Emplados


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AHORROdetalle_delete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Empleado", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent5.Value = Empleado


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
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
    End Class
    Public Class TipoAhorroDetailDB
        Public Codigo As String
        Public Tipo As String
        Public Empleado_Minimo As Double
        Public Empleado_Maximo As Double
        Public Empresa_Minimo As Double
        Public Empresa_Maximo As Double
        Public Capitalizar As Integer
        Public Moneda As String
    End Class

    Public Class TipoAhorroDB

        Public Shared Function GetDetailsTipoAhorro(ByVal Codigo As String) As TipoAhorroDetailDB

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim detalle As New VB.SysContab.TipoAhorroDetailDB()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetDetailsTipoAhorro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Codigo", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            pIdent3.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "TipoAhorro")
            DBConn.Close()
            If dsFicha.Tables("TipoAhorro").Rows.Count = 1 Then
                detalle.Codigo = dsFicha.Tables("TipoAhorro").Rows(0)("tah_codigo")
                detalle.Tipo = dsFicha.Tables("TipoAhorro").Rows(0)("tah_tipo")
                detalle.Empleado_Minimo = dsFicha.Tables("TipoAhorro").Rows(0)("tah_emp_min")
                detalle.Empleado_Maximo = dsFicha.Tables("TipoAhorro").Rows(0)("tah_emp_max")
                detalle.Empresa_Minimo = dsFicha.Tables("TipoAhorro").Rows(0)("tah_empr_min")
                detalle.Empresa_Maximo = dsFicha.Tables("TipoAhorro").Rows(0)("tah_empr_max")
                detalle.Capitalizar = dsFicha.Tables("TipoAhorro").Rows(0)("tah_capitalizar")
                detalle.Moneda = dsFicha.Tables("TipoAhorro").Rows(0)("mon_codigo")
            End If

            Return detalle


        End Function

        Public Shared Function GetListTipoAhorro() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoAhorroCombo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.Fill(dsFicha, "TipoAhorro")

            DBConn.Close()

            Return dsFicha


        End Function
    End Class

End Namespace

