Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect


Namespace VB.SysContab

    Public Class PermisosDetails
        Public Codigo As String
        Public Empleado As String
        Public Inicio As DateTime
        Public Final As DateTime
        Public Tipo As Integer
        Public Aplicado As Boolean
        Public Periodo As String
        Public TPeriodo As String
        Public Dias_Solicitados As Double
        Public Dias_Procesados As Double
    End Class

    Public Class Factores_Permisos
        Public Empleado As String
        Public DiasLaborales As Integer
        Public FactorxDia As Double
        Public Carencias As Double
    End Class

    Public Class PermisosDB

        Public Shared Sub Do_Subsidios(ByVal Periodo As String, ByVal TPeriodo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RH_ISubsidios_Generar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)


            pIdent.Value = Periodo
            pIdent2.Value = EmpresaActual
            pIdent3.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub


        Public Shared Sub Undo_Subsidios(ByVal Periodo As String, ByVal TPeriodo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RH_ISubsidios_Deshacer", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)


            pIdent.Value = Periodo
            pIdent2.Value = EmpresaActual
            pIdent3.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub


        Public Shared Function GetFactores(ByVal empleado As String, ByVal Fecha As Date) As Factores_Permisos
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, empleado)
            v.AddParameter("DiasLaborales", SqlDbType.Int, 5, ParameterDirection.Output, 0)
            v.AddParameter("FactorxDia", SqlDbType.Float, 5, ParameterDirection.Output, 0)
            v.AddParameter("Carencia", SqlDbType.Float, 5, ParameterDirection.Output, 0)
            v.AddParameter("Fecha", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Fecha)
            Dim variable As New Factores_Permisos

            Try
                v.EjecutarComando("RH_GetEmpleado_FactorVacaciones")
                variable.DiasLaborales = v.GetParameter("DiasLaborales").Valor
                variable.Carencias = v.GetParameter("Carencia").Valor
                variable.FactorxDia = v.GetParameter("FactorxDia").Valor
            Catch ex As Exception
                MsgBox(ex.Message)
                variable.DiasLaborales = 0
                variable.Carencias = 0
                variable.FactorxDia = 0
            End Try
            Return variable
        End Function
        Public Shared Function GetDetails(ByVal Codigo As String) As PermisosDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Details As New PermisosDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPermisosDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Permisos")
            If dsFicha.Tables("Permisos").Rows.Count = 1 Then
                Details.Codigo = dsFicha.Tables("Permisos").Rows(0).Item("prm_codigo")
                Details.Empleado = dsFicha.Tables("Permisos").Rows(0).Item("emp_codigo")
                Details.Inicio = dsFicha.Tables("Permisos").Rows(0).Item("prm_hinicio")
                Details.Final = dsFicha.Tables("Permisos").Rows(0).Item("prm_hfinal")
                Details.Tipo = dsFicha.Tables("Permisos").Rows(0).Item("prm_tipo")
                Details.Aplicado = dsFicha.Tables("Permisos").Rows(0).Item("prm_Aplicado")
                Details.Periodo = dsFicha.Tables("Permisos").Rows(0).Item("per_codigo")
                Details.TPeriodo = dsFicha.Tables("Permisos").Rows(0).Item("per_tipo")
                Details.Dias_Solicitados = dsFicha.Tables("Permisos").Rows(0).Item("prm_dsolicitados")
                Details.Dias_Procesados = dsFicha.Tables("Permisos").Rows(0).Item("prm_dprocesados")
            End If
            Return Details
        End Function
        Public Shared Function GetList(ByVal Empleado As String, _
            ByVal Activos As Boolean, _
            ByVal PeriodoActual As Boolean, ByVal al As Date) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            'Buscar el encabezado
            DBCommand = New SqlDataAdapter("_GetListPermisos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            pIdent.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Dim pactivos As New SqlParameter("@Activos", SqlDbType.Bit)
            pactivos.Value = Activos
            DBCommand.SelectCommand.Parameters.Add(pactivos)

            Dim pPeriodoActual As New SqlParameter("@PeriodoActual", SqlDbType.Bit)
            pPeriodoActual.Value = PeriodoActual
            DBCommand.SelectCommand.Parameters.Add(pPeriodoActual)

            Dim pAl As New SqlParameter("@Al", SqlDbType.SmallDateTime)
            pAl.Value = Al
            DBCommand.SelectCommand.Parameters.Add(pAl)

            DBCommand.Fill(dsFicha, "Permisos")

            'Buscar los detalles
            DBCommand = New SqlDataAdapter("_GetListPermisosDetalles", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            pIdent3.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Dim pIdent4 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent4.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Dim pactivos2 As New SqlParameter("@Activos", SqlDbType.Bit)
            pactivos2.Value = Activos
            DBCommand.SelectCommand.Parameters.Add(pactivos2)

            Dim pPeriodoActual2 As New SqlParameter("@PeriodoActual", SqlDbType.Bit)
            pPeriodoActual2.Value = PeriodoActual
            DBCommand.SelectCommand.Parameters.Add(pPeriodoActual2)

            Dim pAl2 As New SqlParameter("@Al", SqlDbType.SmallDateTime)
            pAl2.Value = al
            DBCommand.SelectCommand.Parameters.Add(pAl2)

            DBCommand.Fill(dsFicha, "PermisosDetalles")

            Return dsFicha
            DBConn.Close()

        End Function
        Public Shared Function GetList(ByVal Empleado As String, _
           ByVal Activos As Boolean, _
           ByVal PeriodoActual As Boolean) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            'Buscar el encabezado
            DBCommand = New SqlDataAdapter("_GetListPermisos_V2", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            pIdent.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Dim pactivos As New SqlParameter("@Activos", SqlDbType.Bit)
            pactivos.Value = Activos
            DBCommand.SelectCommand.Parameters.Add(pactivos)

            Dim pPeriodoActual As New SqlParameter("@PeriodoActual", SqlDbType.Bit)
            pPeriodoActual.Value = PeriodoActual
            DBCommand.SelectCommand.Parameters.Add(pPeriodoActual)

            DBCommand.Fill(dsFicha, "Permisos")

            'Buscar los detalles
            DBCommand = New SqlDataAdapter("_GetListPermisosDetalles_V2", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            pIdent3.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Dim pIdent4 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent4.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Dim pactivos2 As New SqlParameter("@Activos", SqlDbType.Bit)
            pactivos2.Value = Activos
            DBCommand.SelectCommand.Parameters.Add(pactivos2)

            Dim pPeriodoActual2 As New SqlParameter("@PeriodoActual", SqlDbType.Bit)
            pPeriodoActual2.Value = PeriodoActual
            DBCommand.SelectCommand.Parameters.Add(pPeriodoActual2)



            DBCommand.Fill(dsFicha, "PermisosDetalles")

            Return dsFicha
            DBConn.Close()

        End Function
        Public Shared Function GetList_Aplicar(ByVal Periodo As String, ByVal TPeriodo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AplicarPermisos_Get", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)


            pIdent.Value = Periodo
            pIdent2.Value = EmpresaActual
            pIdent3.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "Permisos")

            Return dsFicha

        End Function
        Public Shared Sub Aplicar_Undo(ByVal Periodo As String, ByVal TPeriodo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AplicarPermisos_Undo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)


            pIdent.Value = Periodo
            pIdent2.Value = EmpresaActual
            pIdent3.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub
        Public Shared Sub Add(ByVal Codigo As String, ByVal Periodo As String, ByVal TPeriodo As String, _
            ByVal Cantidad As Double, ByVal SextoDia As Double, ByVal SeptimoDia As Double, ByVal Hasta As DateTime)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DetallePermisos_Add", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Cantidad", SqlDbType.Float)
            Dim pIdent5 As New SqlParameter("@SextoDia", SqlDbType.Float)
            Dim pIdent6 As New SqlParameter("@SeptimoDia", SqlDbType.Float)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.DateTime)
            Dim pIdent8 As New SqlParameter("@Codigo", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Periodo
            pIdent3.Value = TPeriodo
            pIdent4.Value = Cantidad
            pIdent5.Value = SextoDia
            pIdent6.Value = SeptimoDia
            pIdent7.Value = Hasta
            pIdent8.Value = Codigo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub
        Public Shared Sub UpdateSaldo(ByVal Codigo As String, ByVal Cantidad As Double)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Permisos_UpdateSaldo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Cantidad", SqlDbType.Float)


            pIdent.Value = EmpresaActual
            pIdent1.Value = Codigo
            pIdent4.Value = Cantidad

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub
        Public Shared Function GetListCodigoNvo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPermisosCodigoNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)


            DBCommand.Fill(dsFicha, "Permisos")

            DBConn.Close()
            Return dsFicha.Tables("Permisos").Rows(0).Item("CODIGO")
            'If dsFicha.Tables("Permisos").Rows(0).Item("CODIGO") Is DBNull.Value Then
            '    Return "1"
            'Else
            '    Return Trim(Str(Val(dsFicha.Tables("Permisos").Rows(0).Item("CODIGO")) + 1))
            'End If


        End Function
        Public Shared Sub delete(ByVal Codigo As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PermisosDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub
        Public Shared Function Delete_Dia(ByVal Dia As Date, _
           ByVal Periodo As String, _
           ByVal TPeriodo As String, _
           ByVal Todos As Boolean, _
           ByVal Empleado As String, _
           ByVal ParteDia As Integer) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PermisosDelete_Dia", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Dia", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Todos", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Partedia", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Dia
            pIdent5.Value = Periodo
            pIdent6.Value = TPeriodo
            pIdent7.Value = Todos
            pIdent8.Value = Empleado
            pIdent9.Value = ParteDia

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Function
        Public Shared Function Delete_Feriados(ByVal Dia As Date, _
            ByVal Periodo As String, _
            ByVal TPeriodo As String, _
            ByVal Todos As Boolean, _
            ByVal Empleado As String) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PermisosDelete_Feriados", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Dia", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Todos", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Dia
            pIdent5.Value = Periodo
            pIdent6.Value = TPeriodo
            pIdent7.Value = Todos
            pIdent8.Value = Empleado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Function
        Public Shared Function Add_Dia(ByVal Dia As Date, _
           ByVal Periodo As String, _
           ByVal TPeriodo As String, _
           ByVal Todos As Boolean, _
           ByVal Empleado As String, _
           ByVal ParteDia As Integer) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PermisosAdd_Dia", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Dia", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Todos", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@ParteDia", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Dia
            pIdent5.Value = Periodo
            pIdent6.Value = TPeriodo
            pIdent7.Value = Todos
            pIdent8.Value = Empleado
            pIdent9.Value = ParteDia

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
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
            End Try

        End Function
        'Public Shared Function Add_Feriados(ByVal Dia As Date, _
        '    ByVal Periodo As String, _
        '    ByVal TPeriodo As String, _
        '    ByVal Todos As Boolean, _
        '    ByVal Empleado As String) As Integer

        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()


        '    DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_PermisosAdd_Feriados", DBConn)
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pIdent2 As New SqlParameter("@Dia", SqlDbType.SmallDateTime)
        '    Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
        '    Dim pIdent6 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
        '    Dim pIdent7 As New SqlParameter("@Todos", SqlDbType.Bit)
        '    Dim pIdent8 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

        '    pIdent.Value = EmpresaActual
        '    pIdent2.Value = Dia
        '    pIdent5.Value = Periodo
        '    pIdent6.Value = TPeriodo
        '    pIdent7.Value = Todos
        '    pIdent8.Value = Empleado

        '    DBCommand.SelectCommand.Parameters.Add(pIdent)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent2)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent5)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent6)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent7)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent8)

        '    Try
        '        'Se asigna conexion al comando y se abre conexion 
        '        DBConn.Open()
        '        DBCommand.SelectCommand.ExecuteNonQuery()
        '        DBConn.Close()

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End Function

        Public Shared Sub Additem(ByVal Codigo As String, ByVal Empleado As String, ByVal Inicio As DateTime, _
                ByVal Final As DateTime, ByVal Tipo As Integer, ByVal TPeriodo As String, _
                ByVal Periodo As String, ByVal Nota As String, ByVal Subsidio As Boolean, _
                ByVal TipoSubsidio As Integer)


            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("Inicio", SqlDbType.DateTime, 20, ParameterDirection.Input, Inicio)
            v.AddParameter("Final", SqlDbType.DateTime, 20, ParameterDirection.Input, Final)
            v.AddParameter("Tipo", SqlDbType.Int, 5, ParameterDirection.Input, Tipo)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 10, ParameterDirection.Input, Codigo)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
            v.AddParameter("Tperiodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
            v.AddParameter("Nota", SqlDbType.NVarChar, 400, ParameterDirection.Input, Nota)
            v.AddParameter("Subsidio", SqlDbType.Bit, 1, ParameterDirection.Input, Subsidio)
            v.AddParameter("TipoSubsidio", SqlDbType.Int, 5, ParameterDirection.Input, TipoSubsidio)

            Try
                v.EjecutarComando("_PermisosAdd")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub Update(ByVal Codigo As String, ByVal Empleado As String, ByVal Inicio As DateTime, _
                ByVal Final As DateTime, ByVal Tipo As Integer, ByVal TPeriodo As String, _
                ByVal Periodo As String, ByVal Nota As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PermisosUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Inicio", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Final", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Nota", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Inicio
            pIdent4.Value = Final
            pIdent5.Value = Tipo
            pIdent6.Value = Codigo
            pIdent7.Value = Periodo
            pIdent8.Value = TPeriodo
            pIdent9.Value = Nota

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
            End Try
        End Sub
        Public Shared Sub Aplicar(ByVal Periodo As String, ByVal TPeriodo As String, ByVal Afecta As String, ByVal Undo As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PermisosAplicar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent7 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Afecta", SqlDbType.NVarChar)
            Dim pIdent1 As New SqlParameter("@UNDO", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent7.Value = Periodo
            pIdent8.Value = TPeriodo
            pIdent9.Value = Afecta
            pIdent1.Value = Undo


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
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
        Public Shared Sub AplicarVacaciones(ByVal Empleado As String, _
            ByVal Desde As String, ByVal Hasta As String, _
            ByVal Afecta As String)


            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("Desde", SqlDbType.NVarChar, 20, ParameterDirection.Input, Desde)
            v.AddParameter("Hasta", SqlDbType.NVarChar, 20, ParameterDirection.Input, Hasta)
            v.AddParameter("Afecta", SqlDbType.NVarChar, 10, ParameterDirection.Input, Afecta)

            Try
                v.EjecutarComando("_PermisosVacacionesAplicar")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End Sub

        Public Shared Function Disponibilidad(ByVal Fecha As Date) As Boolean
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Fecha", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, Fecha)
            v.AddParameter("Disponible", SqlDbType.Bit, 1, ParameterDirection.Output, False)
            Try
                v.EjecutarComando("_RH_Fecha_Permiso_Disponibilidad")
            Catch ex As Exception
                Return False
            End Try
            Return v.GetParameter("Disponible").Valor
        End Function

        'Public Shared Sub Additem_RH(ByVal Codigo As String, ByVal Empleado As String, ByVal Inicio As DateTime, _
        '      ByVal Final As DateTime, ByVal Tipo As Integer, ByVal TPeriodo As String, ByVal Periodo As String)
        '    Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        '    v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        '    v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
        '    v.AddParameter("Inicio", SqlDbType.DateTime, 20, ParameterDirection.Input, Inicio)
        '    v.AddParameter("Final", SqlDbType.DateTime, 20, ParameterDirection.Input, Final)
        '    v.AddParameter("Tipo", SqlDbType.Int, 2, ParameterDirection.Input, Tipo)
        '    v.AddParameter("Codigo", SqlDbType.NVarChar, 10, ParameterDirection.Input, Codigo)
        '    v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
        '    v.AddParameter("Tperiodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)

        '    Try
        '        v.EjecutarComando("_RH_PermisosAdd")
        '    Catch ex As Exception
        '        MsgBox(ex.Message)

        '    End Try

        'End Sub

        Public Shared Function GetList_RH(ByVal Estado As String) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Estado", SqlDbType.NVarChar, 1, ParameterDirection.Input, Estado)

            Try
                Return v.EjecutarComando("_RH_GetListPermisos")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Shared Function Permisos_GetDetalle(ByVal Empleado As String, ByVal Inicio As DateTime, _
               ByVal Final As DateTime, ByVal Tipo As Integer) As DataTable


            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("Desde", SqlDbType.DateTime, 20, ParameterDirection.Input, Inicio)
            v.AddParameter("Hasta", SqlDbType.DateTime, 20, ParameterDirection.Input, Final)
            v.AddParameter("TipoPermiso", SqlDbType.Int, 5, ParameterDirection.Input, Tipo)

            Try
                Return v.EjecutarComando("_Permisos_GetDetalle", "Permisos")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return New DataTable
            End Try

        End Function


    End Class

End Namespace
