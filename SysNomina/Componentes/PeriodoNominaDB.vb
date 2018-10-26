Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab

    Public Class PeriodoNominaDetails
        Public Empresa As String
        Public Codigo As String
        Public Tipo As String
        Public Descripcion As String
        Public FProceso As String
        Public UProceso As String
        Public FInicio As Date
        Public FFinal As Date
        Public AFiscal As String
        Public Semanas As Integer

        Public Procesado As Boolean
        Public Revisado As Boolean
        Public Aprobado As Boolean
        Public Contabilizado As Boolean
        Public MovGen As Boolean

        Public Comentarios As String
        Public CodigoServicio As String
        Public ConsecutivoServicio As String
        Public CtaBanco As String
        Public Origen As String
        Public MinHoraExtra As Double
        Public GenerarIndemnizacion As Boolean

        Public Calendario As DataTable

        Public EmpresaReferencia As Integer

        Public Codigo_AFiscal As Integer

        Public Fecha_MCS As Date
        Public Fecha_SnackBar As Date
        Public FechaPago As Date

    End Class

    Public Class PeriodoNominaDB

        Public Shared Function PeriodoNomina_UltimaProcesada() As String
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 9, ParameterDirection.InputOutput, "Q")
            Try
                v.EjecutarComando("_RH_UltimaPlanilla")
                Return v.GetParameter("Codigo").Valor
            Catch ex As Exception
                MsgBox(ex.Message)
                Return ""
            End Try

        End Function


        Public Shared Function Movimientos_Produccion(ByVal Periodo As String, ByVal TPeriodo As String, ByVal Undo As Boolean) As Integer
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
            v.AddParameter("tperiodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
            v.AddParameter("undo", SqlDbType.Bit, 5, ParameterDirection.Input, Undo)
            v.AddParameter("movimientos", SqlDbType.Int, 5, ParameterDirection.InputOutput, 0)


            Try
                v.EjecutarComando("_RH_Semanal_GenerarIngresos")
                Return v.GetParameter("movimientos").Valor
                v = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                Return v.GetParameter("movimientos").Valor
                v = Nothing
            End Try
        End Function

        Public Shared Function RH_TipoNomina() As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)


            Try
                Return v.EjecutarComando("_RH_TipoNomina_Lista", "TipoNomina")
                v = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                v = Nothing
                Return Nothing
            End Try
        End Function

        Public Shared Function GetList_Fechas(ByVal Periodo As String, ByVal idArea As Integer) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empr_codigo", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("per_codigo", SqlDbType.NVarChar, 9, ParameterDirection.Input, Periodo)
            v.AddParameter("id_area", SqlDbType.NVarChar, 9, ParameterDirection.Input, idArea)

            Try
                Return v.EjecutarComando("_RH_ProduccionEncabezado_List", "PeriodoNomina")
                v = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                v = Nothing
                Return Nothing
            End Try
        End Function

        Public Shared Sub PeriodoNomina_Fecha_Cerrar(ByVal Periodo As String, ByVal TPeriodo As String, ByVal Fecha As Date, ByVal Cerrado As Boolean)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("per_codigo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
            v.AddParameter("per_tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
            v.AddParameter("fecha", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Fecha)
            v.AddParameter("cerrar", SqlDbType.Bit, 5, ParameterDirection.Input, Cerrado)
            v.EjecutarComando("_PeriodoNomina_Fecha_Cerrar")

        End Sub

        Public Shared Sub Movimientos_Undo(ByVal Periodo As String, ByVal TPeriodo As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DeshacerMovimientos ", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent1.Value = Periodo
            pIdent2.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                DBConn.Close()
            End Try

        End Sub

        Public Shared Sub Feriados(ByVal Año As Integer)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DP_Marzo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Año
            pIdent1.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)


            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                DBConn.Close()
            End Try

        End Sub

        Public Shared Sub GetListFechaMinima_Nominas(ByRef Inicio As Date, ByRef Final As Date)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFechaMinima_Nominas", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@FInicio", SqlDbType.SmallDateTime)
            Dim pIdent2 As New SqlParameter("@FFinal", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent1.Direction = ParameterDirection.Output
            pIdent2.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                DBConn.Close()
            End Try
            Inicio = pIdent1.Value
            Final = pIdent2.Value
        End Sub

        Public Shared Function GetDetails(ByVal Codigo As String) As PeriodoNominaDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet()
            Dim Details As New PeriodoNominaDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBConn.Open()
                DBCommand.Fill(dsHorario, "PeriodoNomina")
                DBConn.Close()
                If dsHorario.Tables("PeriodoNomina").Rows.Count = 1 Then
                    Details.Empresa = dsHorario.Tables("PeriodoNomina").Rows(0).Item("empr_codigo")
                    Details.Codigo = dsHorario.Tables("PeriodoNomina").Rows(0).Item("Per_Codigo")
                    Details.Tipo = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_tipo")
                    Details.Descripcion = dsHorario.Tables("PeriodoNomina").Rows(0).Item("Per_descripcion")
                    Details.Procesado = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_procesado")
                    Details.FProceso = IIf(IsDBNull(dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_fproceso")), "", dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_fproceso"))
                    Details.UProceso = IIf(IsDBNull(dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_uproceso")), "", dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_uproceso"))
                    Details.FInicio = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_finicio")
                    Details.FFinal = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_ffinal")
                    Details.AFiscal = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_aniofiscal")
                    Details.MovGen = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_movgen")
                    Details.Semanas = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_semanas")
                    Details.Revisado = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_revisado")
                    Details.Aprobado = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_aprobado")
                    Details.Contabilizado = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_contabilizado")
                    Details.Comentarios = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_comentarios")
                    Details.CodigoServicio = dsHorario.Tables("PeriodoNomina").Rows(0).Item("cod_serv_planilla")
                    Details.ConsecutivoServicio = dsHorario.Tables("PeriodoNomina").Rows(0).Item("con_serv_planilla")
                    Details.CtaBanco = dsHorario.Tables("PeriodoNomina").Rows(0).Item("cta_banco")
                    Details.Origen = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_origen")
                    Details.MinHoraExtra = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_minhextra")
                    Details.GenerarIndemnizacion = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_genIndemnizacion")
                    Details.EmpresaReferencia = dsHorario.Tables("PeriodoNomina").Rows(0).Item("empr_ref")
                    Details.Codigo_AFiscal = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_afiscal")
                    Details.Fecha_MCS = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_fecha_mcs")
                    Details.Fecha_SnackBar = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_fecha_snackbar")
                    Details.FechaPago = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_fechapago")
                End If
                If Codigo.Length = 9 Then
                    Dim x As New Connect(VB.SysContab.Conexion.AbrirConexion)
                    x.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    x.AddParameter("per_codigo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Codigo.Substring(1, 8))
                    x.AddParameter("per_tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Codigo.Substring(0, 1))
                    Details.Calendario = x.EjecutarComando("_GetListPeriodoNomina_Fecha", "Fechas")
                    x = Nothing
                End If

                Return Details
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                DBConn.Close()
                Return Nothing
            End Try


        End Function

        Public Shared Function GetList(Optional ByVal Grid As Boolean = True) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Grid", SqlDbType.Bit, 1, ParameterDirection.Input, Grid)

            Try
                Return v.EjecutarComando("_GetListPeriodoNomina_Mes", "PeriodoNomina")
                v = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                v = Nothing
                Return Nothing
            End Try
        End Function


        Public Shared Function GetList_Activos() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNomina_Activos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBConn.Open()
                DBConn.Close()
                DBCommand.Fill(dsFicha, "PeriodoNomina")
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                Return Nothing
            End Try

        End Function
        Public Shared Function GetList_AfiscalBuscar(ByVal Afiscal As Integer) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNomina_AFiscal", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@aFiscal", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            pIdent3.Value = Afiscal
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBConn.Open()
                DBCommand.Fill(dsFicha, "PeriodoNomina_AFiscal")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                'EscribeLog(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function GetList_AfiscalBuscarMes(ByVal Afiscal As Integer) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListMeses_AFiscal", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@aFiscal", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            pIdent3.Value = Afiscal
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBConn.Open()
                DBConn.Close()
                DBCommand.Fill(dsFicha, "Meses_AFiscal")
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                Return Nothing
            End Try


        End Function

        Public Shared Function GetListFiltro(ByVal Procesado As String, ByVal Aprobado As String, ByVal contabilizado As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaFiltro", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Procesado", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Aprobado", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Contabilizado", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            pIdent3.Value = Procesado
            pIdent4.Value = Aprobado
            pIdent5.Value = contabilizado
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)


            Try
                DBConn.Open()
                DBCommand.Fill(dsFicha, "PeriodoNomina")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                DBConn.Close()
                Return Nothing
            End Try


        End Function
        Public Shared Function GetListFiltro(ByVal Periodo As String, ByVal TPeriodo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_EmpleadosConMovimientos ", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim PIdent3 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim PIdent4 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            PIdent3.Value = Periodo
            PIdent4.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(PIdent3)
            DBCommand.SelectCommand.Parameters.Add(PIdent4)

            Try
                DBConn.Open()
                DBConn.Close()
                DBCommand.Fill(dsFicha, "EmpleadosConMovimientos")
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                Return Nothing
            End Try

        End Function
        Public Shared Function GetListFiltro(ByVal Periodo As String, ByVal TPeriodo As String, ByVal Empleado As String, ByVal Relleno As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_Empleado_Movimientos ", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim PIdent3 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim PIdent4 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim PIdent5 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            PIdent3.Value = Periodo
            PIdent4.Value = TPeriodo
            PIdent5.Value = Empleado

            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(PIdent3)
            DBCommand.SelectCommand.Parameters.Add(PIdent4)
            DBCommand.SelectCommand.Parameters.Add(PIdent5)

            Try
                DBConn.Open()
                DBConn.Close()
                DBCommand.Fill(dsFicha, "Empleados_Movimientos")
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                Return Nothing
            End Try

        End Function
        'Public Shared Function GetListAFiscal() As DataSet

        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()



        '    DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_GetListAFiscalPNomina", DBConn)
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)


        '    pIdent2.Value = EmpresaActual

        '    DBCommand.SelectCommand.Parameters.Add(pIdent2)
        '    Try
        '        DBConn.Open()
        '        DBCommand.Fill(dsFicha, "PeriodoNomina")
        '        DBConn.Close()
        '        Return dsFicha
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
        '        DBConn.Close()
        '        Return Nothing
        '    End Try
        'End Function

        Public Shared Function GetListAFiscal(ByVal Combo As Boolean) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Combo", SqlDbType.Bit, 1, ParameterDirection.Input, Combo)

            Try
                Return v.EjecutarComando("_RH_GetListPeriodoFiscal", "PeriodoNomina")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Function GetListBuscar(ByVal Periodo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPNominaBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Periodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            Try
                DBConn.Open()
                DBCommand.Fill(dsFicha, "PeriodoNomina")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                DBConn.Close()
                Return Nothing
            End Try

        End Function
        Public Shared Function GetlistSufijoExtra(ByVal Mes As String) As String

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_SufijoExtra_Nvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pident3 As New SqlParameter("@Sufijo", SqlDbType.NVarChar, 2)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Mes
            pident3.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pident3)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return pident3.Value
        End Function

        Public Shared Function GetListBuscarFInicio(ByVal Inicio As Date, ByVal FPEmpl As String) As PeriodoNominaDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim details As New PeriodoNominaDetails()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPNominaBuscarFInicio", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Inicio", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@FPEmpl", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Inicio
            pIdent3.Value = FPEmpl

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            Try
                DBConn.Open()
                DBCommand.Fill(dsFicha, "PeriodoNomina")
                DBConn.Close()
                If dsFicha.Tables("PeriodoNomina").Rows.Count = 1 Then

                    details.Empresa = dsFicha.Tables("PeriodoNomina").Rows(0).Item("empr_codigo")
                    details.Codigo = dsFicha.Tables("PeriodoNomina").Rows(0).Item("Per_Codigo")
                    details.Tipo = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_tipo")
                    details.Descripcion = dsFicha.Tables("PeriodoNomina").Rows(0).Item("Per_descripcion")
                    details.Procesado = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_procesado")
                    details.FProceso = IIf(IsDBNull(dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_fproceso")), "", dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_fproceso"))
                    details.UProceso = IIf(IsDBNull(dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_uproceso")), "", dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_uproceso"))
                    details.FInicio = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_finicio")
                    details.FFinal = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_ffinal")
                    details.AFiscal = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_aniofiscal")
                    details.MovGen = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_movgen")
                    details.Semanas = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_semanas")
                    details.Revisado = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_revisado")
                    details.Contabilizado = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_contabilizado")
                    details.Aprobado = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_aprobado")
                    details.Comentarios = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_comentarios")

                    details.CodigoServicio = dsFicha.Tables("PeriodoNomina").Rows(0).Item("cod_serv_planilla")
                    details.ConsecutivoServicio = dsFicha.Tables("PeriodoNomina").Rows(0).Item("con_serv_planilla")
                    details.CtaBanco = dsFicha.Tables("PeriodoNomina").Rows(0).Item("cta_banco")
                    details.Origen = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_origen")
                    details.MinHoraExtra = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_minhextra")
                    details.GenerarIndemnizacion = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_genIndemnizacion")
                    details.EmpresaReferencia = dsFicha.Tables("PeriodoNomina").Rows(0).Item("empr_ref")
                    details.Codigo_AFiscal = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_afiscal")
                    details.Fecha_MCS = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_fecha_mcs")
                    details.Fecha_SnackBar = dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_fecha_snackbar")

                End If

                Return details
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                DBConn.Close()
                Return Nothing
            End Try



        End Function

        Public Shared Function GetListNuevo(ByVal Tipo As String, ByRef Sufijo As String, ByRef Inicial As Boolean, ByRef FechaPago As Date) As SelectionRange

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim PNomina As New VB.SysContab.PeriodoNominaDB()
            Dim Inicio As DateTime
            Dim Final As DateTime

            Dim Rango As New SelectionRange()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaMaxTipo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Tipo
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBConn.Open()
                DBCommand.Fill(dsFicha, "PeriodoNomina")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                DBConn.Close()
                Return Nothing
            End Try

            If dsFicha.Tables("periodonomina").Rows.Count <> 0 Then
                If dsFicha.Tables("PeriodoNomina").Rows(0)("per_procesado") = False Then
                    Rango = Nothing
                    Return Nothing
                    Exit Function
                End If
                'Si no hay periodos registrados.
                If dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_ffinal") Is DBNull.Value Then
                    Select Case Tipo.ToUpper
                        Case "S"
                            Inicio = IIf(Weekday(CDate("01/" + Format(Today, "MM") + _
                                                        "/" + Format(Today, "yyyy"))) = 1, _
                                        Today, DateAdd(DateInterval.Day, 2 + Weekday(CDate("01/" + _
                                                    Format(Today, "MM") + "/" + Format(Today, "yyyy"))), _
                                                      CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))))
                            Final = DateAdd(DateInterval.Day, 6, Inicio)
                            Sufijo = "01"
                        Case "C"
                            Inicio = IIf(Weekday(CDate("01/" + Format(Today, "MM") + _
                                                        "/" + Format(Today, "yyyy"))) = 1, _
                                        Today, DateAdd(DateInterval.Day, 2 + Weekday(CDate("01/" + _
                                                    Format(Today, "MM") + "/" + Format(Today, "yyyy"))), _
                                                      CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))))
                            Final = DateAdd(DateInterval.Day, 13, Inicio)
                            Sufijo = "01"
                        Case "Q"
                            Inicio = CDate(IIf(Today.Day >= 16, "16/", "01/") + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                            Final = DateAdd(DateInterval.Day, IIf(Today.Day >= 16, Date.DaysInMonth(Today.Year, Today.Month) - 16, 14), Inicio)
                            If Today.Day >= 16 Then
                                Sufijo = "02"
                            Else
                                Sufijo = "01"
                            End If

                        Case "M"
                            Inicio = CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                            Final = CDate(Trim(Str(Meses(Month(Inicio) - 1))) & "/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                            Sufijo = "01"
                        Case "D", "U"
                            'Averiguar como se haria para el Destajo
                            Inicio = IIf(Weekday(CDate("01/" + Format(Today, "MM") + _
                                                        "/" + Format(Today, "yyyy"))) = 1, _
                                        Today, DateAdd(DateInterval.Day, 2 + Weekday(CDate("01/" + _
                                                    Format(DateAdd(DateInterval.Day, -14, Today), "MM") + "/" + Format(DateAdd(DateInterval.Day, -14, Today), "yyyy"))), _
                                                      CDate("01/" + Format(DateAdd(DateInterval.Day, -14, Today), "MM") + "/" + Format(DateAdd(DateInterval.Day, -14, Today), "yyyy"))))
                            Final = DateAdd(DateInterval.Day, 6, Inicio)
                            Sufijo = "01"
                        Case "E"
                            Inicio = CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                            Final = CDate(Trim(Str(Meses(Month(Inicio) - 1))) & "/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                            Sufijo = "01"
                    End Select
                    'PNomina.AddItem(Codigo, Descripcion, Inicio, Final, Tipo)
                    Rango.Start = Inicio
                    Rango.End = Final

                    Inicial = True

                Else
                    Inicial = False
                    If Tipo <> "E" Then
                        Rango.Start = DateAdd(DateInterval.Day, 1, dsFicha.Tables("PeriodoNomina").Rows(0).Item("per_ffinal"))
                    Else
                        Rango.Start = CDate("01/" & Format(Now.Date, "MM/yyyy"))
                    End If

                    Select Case Tipo
                        Case "S" 'Semanal
                            Rango.End = DateAdd(DateInterval.Day, 6, Rango.Start)
                            FechaPago = DateAdd(DateInterval.Day, 6, Rango.End)
                            'Buscar el sabado de la semana
                            Dim sat As Date
                            sat = VB.SysContab.RutinasNomina.BuscarunSabado(Rango.Start, IIf(FechaPago >= Rango.End, FechaPago, Rango.End), 2)
                            Sufijo = VB.SysContab.RutinasNomina.BuscarSabadodelMes(sat).ToString.PadLeft(2, "0")
                            'Select Case DatePart(DateInterval.Day, Rango.Start)
                            '    Case 1 To 7
                            '        Sufijo = "01"
                            '    Case 8 To 14
                            '        Sufijo = "02"
                            '    Case 15 To 21
                            '        Sufijo = "03"
                            '    Case Else
                            '        Sufijo = "04"
                            'End Select
                        Case "C" 'Catorcenal
                            Rango.End = DateAdd(DateInterval.Day, 14, Rango.Start)
                            Select Case DatePart(DateInterval.Day, Rango.Start)
                                Case 1 To 14
                                    Sufijo = "01"
                                Case Else
                                    Sufijo = "03"
                            End Select
                        Case "Q" 'Quincenal
                            If DatePart(DateInterval.Day, Rango.Start) = 1 Then
                                Rango.End = DateAdd(DateInterval.Day, 14, Rango.Start)
                            Else
                                '  Rango.End = New Date(Rango.Start.Year, Rango.Start.Month, Meses(Month(Rango.Start) - 1))
                                Rango.End = New Date(Rango.Start.Year, Rango.Start.Month, UltimoDiaDelMes(Rango.Start.Date).Day)
                                '+ "/" + Format(Rango.Start, "MM/yyyy"))
                            End If
                            If DatePart(DateInterval.Day, Rango.Start) = 1 Then
                                Sufijo = "01"
                            Else
                                Sufijo = "02"
                            End If
                        Case "M" 'Mensual
                            Rango.End = CDate(Trim(Str(Meses(Month(Rango.Start) - 1))) + "/" + Format(Rango.Start, "MM/yyyy"))
                            Sufijo = "01"
                        Case "D", "U" 'Destajo
                            'Rango.End = Rango.Start
                            'Sufijo = "*"
                            Rango.End = DateAdd(DateInterval.Day, 6, Rango.Start)
                            Select Case DatePart(DateInterval.Day, Rango.Start)
                                Case 1 To 14
                                    Sufijo = "01"
                                Case 15 To 28
                                    Sufijo = "02"
                                Case Else
                                    Sufijo = "03"
                            End Select
                        Case "E"
                            Rango.End = CDate(Trim(Str(Meses(Month(Rango.Start) - 1))) + "/" + Format(Rango.Start, "MM/yyyy"))
                            Sufijo = VB.SysContab.PeriodoNominaDB.GetlistSufijoExtra(Rango.Start.Date.Year & Rango.Start.Date.Month.ToString.PadLeft(2, "0"))

                    End Select

                End If
            Else
                Select Case Tipo.ToUpper
                    Case "S"
                        Inicio = IIf(Weekday(CDate("01/" + Format(Today, "MM") + _
                                                    "/" + Format(Today, "yyyy"))) = 1, _
                                    Today, DateAdd(DateInterval.Day, 2 + Weekday(CDate("01/" + _
                                                Format(Today, "MM") + "/" + Format(Today, "yyyy"))), _
                                                  CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))))
                        Final = DateAdd(DateInterval.Day, 6, Inicio)
                        Sufijo = "01"
                    Case "C"
                        Inicio = IIf(Weekday(CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))) = 1, _
                                    CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy")), _
                                    DateAdd(DateInterval.Day, -1 * (Weekday(CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))) - 1), _
                                                  CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))))
                        Final = DateAdd(DateInterval.Day, 13, Inicio)
                        Sufijo = "01"
                    Case "Q"
                        Inicio = CDate(IIf(Today.Day >= 16, "16/", "01/") + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                        Final = DateAdd(DateInterval.Day, IIf(Today.Day >= 16, Date.DaysInMonth(Today.Year, Today.Month) - 16, 14), Inicio)
                        If Today.Day >= 16 Then
                            Sufijo = "02"
                        Else
                            Sufijo = "01"
                        End If
                    Case "M"
                        Inicio = CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                        Final = New Date(Year(Today), Month(Inicio), Date.DaysInMonth(Year(Inicio), Month(Inicio))) ' CDate(Trim(Str(Meses(Month(Inicio) - 1))) & "/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                        Sufijo = "01"
                    Case "D", "U"
                        'Averiguar como se haria para el Destajo
                        Inicio = IIf(Weekday(CDate("01/" + Format(Today, "MM") + _
                                                         "/" + Format(Today, "yyyy"))) = 1, _
                                         Today, DateAdd(DateInterval.Day, 2 + Weekday(CDate("01/" + _
                                                     Format(DateAdd(DateInterval.Day, -14, Today), "MM") + "/" + Format(DateAdd(DateInterval.Day, -14, Today), "yyyy"))), _
                                                       CDate("01/" + Format(DateAdd(DateInterval.Day, -14, Today), "MM") + "/" + Format(DateAdd(DateInterval.Day, -14, Today), "yyyy"))))
                        Final = DateAdd(DateInterval.Day, 6, Inicio)
                        Sufijo = "01"
                    Case "E"
                        Inicio = CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                        Final = CDate(Trim(Str(Meses(Month(Inicio) - 1))) & "/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                        Sufijo = "01"
                End Select
                'PNomina.AddItem(Codigo, Descripcion, Inicio, Final, Tipo)
                Rango.Start = Inicio
                Rango.End = Final
                Inicial = True
            End If
            'Revisar el año fiscal del rango generado.
            Return Rango

        End Function

        Public Shared Sub Additem(ByVal Codigo As String, ByVal Descripcion As String, _
            ByVal FInicio As DateTime, ByVal FFinal As DateTime, ByVal Tipo As String, _
            ByVal AFiscal As String, ByVal Semanas As Integer, ByVal Comentarios As String, _
            ByVal Origen As String, ByVal MinHextra As Double, ByVal GenIndemnizacion As Boolean, _
            ByVal cAFiscal As Integer, ByVal Fecha_MCS As Date, ByVal Fecha_SnackBar As Date, _
            ByVal FechaPago As Date)

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Codigo)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input, Descripcion)
            v.AddParameter("FInicio", SqlDbType.SmallDateTime, 1, ParameterDirection.Input, FInicio)
            v.AddParameter("FFinal", SqlDbType.SmallDateTime, 1, ParameterDirection.Input, FFinal)
            v.AddParameter("Tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo)
            v.AddParameter("AFiscal", SqlDbType.NVarChar, 9, ParameterDirection.Input, AFiscal)
            v.AddParameter("Semanas", SqlDbType.Int, 5, ParameterDirection.Input, Semanas)
            v.AddParameter("Comentarios", SqlDbType.Text, 400, ParameterDirection.Input, Comentarios)
            v.AddParameter("Origen", SqlDbType.NVarChar, 1, ParameterDirection.Input, Origen)
            v.AddParameter("MinHextra", SqlDbType.Float, 5, ParameterDirection.Input, MinHextra)
            v.AddParameter("GenIndemnizacion", SqlDbType.Bit, 1, ParameterDirection.Input, GenIndemnizacion)
            v.AddParameter("cAfiscal", SqlDbType.Int, 5, ParameterDirection.Input, cAFiscal)
            v.AddParameter("per_fecha_mcs", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, Fecha_MCS)
            v.AddParameter("per_fecha_snackbar", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, Fecha_SnackBar)
            v.AddParameter("per_fechapago", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, FechaPago)

            Try
                v.IniciarTransaccion()
                v.EjecutarComando("_PeriodoNominaAdd")
                v.CompletarTransaccion()

            Catch ex As Exception
                MsgBox(ex.Message)
                v.AnularTransaccion()
            End Try

            v = Nothing


        End Sub

        Public Shared Sub Procesado(ByVal Codigo As String, ByVal Tipo As String, ByVal Fecha As DateTime, ByVal Undo As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PeriodoNominaProcesado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@Undo", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Fecha
            pIdent5.Value = Undo

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
        Public Sub Update_Servicio(ByVal Codigo As String, ByVal Tipo As String, _
            ByVal Servicio As String, ByVal Consecutivo As String, _
            ByVal CtaBanco As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Update_Servicio_Planilla", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Servicio", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Consecutivo", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Ctabanco", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Servicio
            pIdent5.Value = Consecutivo
            pIdent6.Value = CtaBanco

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

        Public Sub MovGen(ByVal Codigo As String, ByVal Tipo As String, ByVal Generados As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PeriodoNominaMovGen", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@MovGen", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Generados

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
        Public Shared Sub Update_Comentario(ByVal Codigo As String, ByVal Tipo As String, _
            ByVal Comentario As String, ByVal fmcs As Date, ByVal fsb As Date)

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("tperiodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo)
            v.AddParameter("periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Codigo)
            v.AddParameter("comentario", SqlDbType.NVarChar, 400, ParameterDirection.Input, Comentario)
            v.AddParameter("fechamcs", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, fmcs)
            v.AddParameter("fechasb", SqlDbType.SmallDateTime, 10, ParameterDirection.Input, fsb)

            Try
                v.EjecutarComando("_RH_PeriodoNomina_Update")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '' Crea una instancia de conexion y un comando SQL
            'Dim cmd As New SqlCommand
            'Dim DBConn As SqlConnection

            'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            '' Se define el tipo de comando
            'cmd.CommandType = CommandType.Text
            'cmd.CommandText = "UPDATE PeriodoNomina SET per_comentarios = '" & Comentario & _
            '    "' WHERE per_codigo = '" & Codigo & "' AND per_Tipo = '" & Tipo & "' AND Empr_codigo ='" & EmpresaActual & "'"

            ''Se asigna conexion al comando y se abre conexion 
            'cmd.Connection = DBConn
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

        End Sub

        Public Shared Function Ultima_Nomina_Procesada(ByVal Tipo As String) As String
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("TPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 10, ParameterDirection.Output, "")
            Try
                v.EjecutarComando("_RH_Ultima_Nomina_Procesada", "Datos")
                Return v.GetParameter("Periodo").Valor
            Catch ex As Exception
                MsgBox(ex.Message)
                Return ""
            End Try
        End Function
    End Class
End Namespace