Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect


Namespace VB.SysContab

    Public Class PlanillaDetails
        Public Codigo As String
        Public Tipo As String
        Public Empleado As String
        Public Fecha As DateTime
        Public Departamento As String
        Public SalarioBasico As Double
        Public Antiguedad As Double
        Public IR As Double
        Public INSS As Double
        Public INSSPatronal As Double
        Public Aplicada As Boolean
        Public TIngresos As Double
        Public TEgresos As Double
        Public Temporal As Boolean
        Public FormaPago As String
        Public Moneda As String
        Public Aprobada As Boolean
        Public hAprobada As DateTime
    End Class

    Public Class PlanillaDetalle
        Public Codigo As String
        Public Tipo As String
        Public Empleado As String
        Public MCodigo As String
        Public MCuota As Integer
        Public MValor As Double
        Public MFecha As DateTime
        Public MTipo As String
    End Class

    Public Class PlanillaDB

        Public Shared Function IR_2013(ByVal Mes As String) As DataTable
            Dim v As New DbConnect.Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("mes", SqlDbType.NVarChar, 10, ParameterDirection.Input, Mes)


            Try
                Return v.EjecutarComando("_RH_IR_Empleados", "Ir_2013")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function BcoBanpro(ByVal Periodo As String, _
               ByVal TPeriodo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_BcoBAnpro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Quincena", SqlDbType.NVarChar)


            pPeriodo.Value = TPeriodo & Periodo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)

            Try
                DBCommand.Fill(dsFicha, "BcoBanpro")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function Rubros_Planilla() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListRubrosPlanilla", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Rubros")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()
            Return dsFicha

        End Function
        Public Shared Function RhConsolidado(ByVal Desde As String, ByVal Hasta As String, _
            ByVal Moneda As String, ByVal CamposDinamicos As Boolean, ByVal _Liquidados As Boolean) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RH_ConsolidadoNomina", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBCommand.SelectCommand.CommandTimeout = 0

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Desde", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@Hasta", SqlDbType.NVarChar)
            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pCamposDinamicos As New SqlParameter("@CamposDinamicos", SqlDbType.Bit)
            Dim pLiquidados As New SqlParameter("@Liq", SqlDbType.Bit)

            pPeriodo.Value = Desde
            pTPeriodo.Value = Hasta
            pEmpresa.Value = EmpresaActual
            pMoneda.Value = Moneda
            pCamposDinamicos.Value = CamposDinamicos
            pLiquidados.Value = _Liquidados

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pMoneda)
            DBCommand.SelectCommand.Parameters.Add(pCamposDinamicos)
            DBCommand.SelectCommand.Parameters.Add(pLiquidados)

            Try
                DBCommand.Fill(dsFicha, "Planilla_Consolidado_RH")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

            Return dsFicha
        End Function
        '28/07/2010
        Public Shared Function RhDeglose(ByVal Periodo As String, ByVal TPeriodo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RH_DegloseGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBCommand.SelectCommand.CommandTimeout = 0

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@per_codigo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@per_tipo", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)

            Try
                DBCommand.Fill(dsFicha, "RH_Deglose")
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
            DBConn.Close()

        End Function

        Public Shared Function Consolidado(ByVal Afiscal As Integer, ByVal Periodo As String, ByVal TPeriodo As String, _
            ByVal Mes As String, ByVal Moneda As String, ByVal Departamento As String, ByVal Empleado As String, _
            ByVal Rubro As String, ByVal Localidad As Integer, ByVal CamposDinamicos As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_DConsolidado_Rubro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBCommand.SelectCommand.CommandTimeout = 0

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pDepartamento As New SqlParameter("@Depto", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pAfiscal As New SqlParameter("@AFiscal", SqlDbType.Int)
            Dim pRubro As New SqlParameter("@Rubro", SqlDbType.NVarChar)
            Dim pLocalidad As New SqlParameter("@Localidad", SqlDbType.Int)
            Dim pCD As New SqlParameter("@CamposDinamicos", SqlDbType.Bit)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpresa.Value = EmpresaActual
            pMes.Value = Mes
            pMoneda.Value = Moneda
            pDepartamento.Value = Departamento
            pEmpleado.Value = Empleado
            pAfiscal.Value = Afiscal
            pRubro.Value = Rubro
            pLocalidad.Value = Localidad
            pCD.Value = CamposDinamicos

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pMoneda)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)
            DBCommand.SelectCommand.Parameters.Add(pAfiscal)
            DBCommand.SelectCommand.Parameters.Add(pRubro)
            DBCommand.SelectCommand.Parameters.Add(pLocalidad)
            DBCommand.SelectCommand.Parameters.Add(pCD)


            Try
                DBCommand.Fill(dsFicha, "Planilla_Consolidado")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

            Return dsFicha
        End Function
        Public Shared Function Consolidado(ByVal Empleado As String, ByVal Moneda As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Empleado_Dconsolidado", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pMoneda.Value = Moneda
            pEmpleado.Value = Empleado

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pMoneda)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)

            Try
                DBCommand.Fill(dsFicha, "Planilla_Consolidado")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function Consolidado_Comparativo_Encabezado(ByVal Rubro As String, ByVal Afiscal As String, _
        ByVal Periodo As String, ByVal TPeriodo As String, ByVal Mes As String, _
        ByVal Moneda As String, ByVal Departamento As String, ByVal Empleado As String, _
        ByVal Afiscal2 As String, ByVal Periodo2 As String, ByVal TPeriodo2 As String, _
        ByVal Mes2 As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_DConsolidado_Comparativo_Enc", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pDepartamento As New SqlParameter("@Depto", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pAfiscal As New SqlParameter("@AFiscal", SqlDbType.NVarChar)
            Dim pRubro As New SqlParameter("@Rubro", SqlDbType.NVarChar)
            ''Segunda Parte
            Dim pPeriodo2 As New SqlParameter("@Periodo2", SqlDbType.NVarChar)
            Dim pTPeriodo2 As New SqlParameter("@TPeriodo2", SqlDbType.NVarChar)
            Dim pMes2 As New SqlParameter("@Mes2", SqlDbType.NVarChar)
            Dim pAfiscal2 As New SqlParameter("@AFiscal2", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpresa.Value = EmpresaActual
            pMes.Value = Mes
            pMoneda.Value = Moneda
            pDepartamento.Value = Departamento
            pEmpleado.Value = Empleado
            pAfiscal.Value = Afiscal
            pRubro.Value = Rubro
            pPeriodo2.Value = Periodo2
            pTPeriodo2.Value = TPeriodo2
            pMes2.Value = Mes2
            pAfiscal2.Value = Afiscal2


            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pMoneda)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)
            DBCommand.SelectCommand.Parameters.Add(pAfiscal)
            DBCommand.SelectCommand.Parameters.Add(pRubro)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo2)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo2)
            DBCommand.SelectCommand.Parameters.Add(pMes2)
            DBCommand.SelectCommand.Parameters.Add(pAfiscal2)


            Try
                DBCommand.Fill(dsFicha, "Planilla_Consolidado_Comparativo_Encabezado")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function Consolidado_Comparativo_Detallado(ByVal Rubro As String, ByVal Afiscal As String, _
        ByVal Periodo As String, ByVal TPeriodo As String, ByVal Mes As String, _
        ByVal Moneda As String, ByVal Departamento As String, ByVal Empleado As String, _
        ByVal Afiscal2 As String, ByVal Periodo2 As String, ByVal TPeriodo2 As String, _
        ByVal Mes2 As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_DConsolidado_Comparativo_Detallado", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pDepartamento As New SqlParameter("@Depto", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pAfiscal As New SqlParameter("@AFiscal", SqlDbType.NVarChar)
            Dim pRubro As New SqlParameter("@Rubro", SqlDbType.NVarChar)
            ''Segunda Parte
            Dim pPeriodo2 As New SqlParameter("@Periodo2", SqlDbType.NVarChar)
            Dim pTPeriodo2 As New SqlParameter("@TPeriodo2", SqlDbType.NVarChar)
            Dim pMes2 As New SqlParameter("@Mes2", SqlDbType.NVarChar)
            Dim pAfiscal2 As New SqlParameter("@AFiscal2", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpresa.Value = EmpresaActual
            pMes.Value = Mes
            pMoneda.Value = Moneda
            pDepartamento.Value = Departamento
            pEmpleado.Value = Empleado
            pAfiscal.Value = Afiscal
            pRubro.Value = Rubro
            pPeriodo2.Value = Periodo2
            pTPeriodo2.Value = TPeriodo2
            pMes2.Value = Mes2
            pAfiscal2.Value = Afiscal2


            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pMoneda)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)
            DBCommand.SelectCommand.Parameters.Add(pAfiscal)
            DBCommand.SelectCommand.Parameters.Add(pRubro)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo2)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo2)
            DBCommand.SelectCommand.Parameters.Add(pMes2)
            DBCommand.SelectCommand.Parameters.Add(pAfiscal2)


            Try
                DBCommand.Fill(dsFicha, "Planilla_Consolidado_Comparativo_Detallado")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

            Return dsFicha
        End Function
        Public Shared Function Consolidado_Comparativo(ByVal Rubro As String, ByVal Afiscal As String, ByVal Periodo As String, ByVal TPeriodo As String, _
    ByVal Mes As String, ByVal Moneda As String, ByVal Departamento As String, ByVal Empleado As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_DConsolidado_Comparativo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pDepartamento As New SqlParameter("@Depto", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pAfiscal As New SqlParameter("@AFiscal", SqlDbType.NVarChar)
            Dim pRubro As New SqlParameter("@Rubro", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpresa.Value = EmpresaActual
            pMes.Value = Mes
            pMoneda.Value = Moneda
            pDepartamento.Value = Departamento
            pEmpleado.Value = Empleado
            pAfiscal.Value = Afiscal
            pRubro.Value = Rubro

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pMoneda)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)
            DBCommand.SelectCommand.Parameters.Add(pAfiscal)
            DBCommand.SelectCommand.Parameters.Add(pRubro)


            Try
                DBCommand.Fill(dsFicha, "Planilla_Consolidado_Comparativo")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function Depto_Mes(ByVal AFiscal As String, ByVal Mes As String, ByVal Periodo As String, ByVal TPeriodo As String, _
                  ByVal Moneda As String, ByVal Departamento As String, ByVal Empleado As String, _
                  ByVal nTabla As String, ByVal Nomina As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPlanilla_Depto_Empleado", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pDepartamento As New SqlParameter("@Dpto", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pAfiscal As New SqlParameter("@AFiscal", SqlDbType.NVarChar)
            Dim pNomina As New SqlParameter("@Nomina", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpresa.Value = EmpresaActual
            pMoneda.Value = Moneda
            pDepartamento.Value = Departamento
            pEmpleado.Value = Empleado
            pMes.Value = Mes
            pAfiscal.Value = AFiscal
            pNomina.Value = Nomina

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pMoneda)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pAfiscal)
            DBCommand.SelectCommand.Parameters.Add(pNomina)

            Try
                DBCommand.Fill(dsFicha, nTabla)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Sub UpdateComentarios(ByVal Periodo As String, ByVal TPeriodo As String, _
            ByVal Empleado As String, ByVal Comentario As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlanillaUpdateComentarios", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent1 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Comentario", SqlDbType.Text)
            Dim pIdent4 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Empleado
            pIdent1.Value = Periodo
            pIdent2.Value = TPeriodo
            pIdent3.Value = Comentario
            pIdent4.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)
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


        Public Shared Function INSSXML_DS(ByVal Mes As String, ByVal Empresa As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListINSSXML", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pEmpresaREf As New SqlParameter("@EmpresaRef", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@mes", SqlDbType.NVarChar)

            pPeriodo.Value = Mes
            pEmpresaREf.Value = Empresa
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pEmpresaREf)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)

            Try
                DBCommand.Fill(dsFicha, "INSSXML")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function INSSXML_DT(ByVal Mes As String, ByVal Empresa As Integer) As DataTable
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListINSSXML_V2", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pEmpresaREf As New SqlParameter("@EmpresaRef", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@mes", SqlDbType.NVarChar)

            pPeriodo.Value = Mes
            pEmpresaREf.Value = Empresa
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pEmpresaREf)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)

            Try
                DBCommand.Fill(dsFicha, "novedad")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()

            Return dsFicha.Tables(0)

        End Function
        Public Shared Function IRSairi(ByVal Periodo As String, _
                                ByVal TPeriodo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_IRSAIRI", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)

            Try
                DBCommand.Fill(dsFicha, "Ir")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Sub AgregarImagen(ByVal Imagen As Object, ByVal empleado As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UpdateImagen", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent1 As New SqlParameter("@Imagen", SqlDbType.Image)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = empleado
            pIdent1.Value = Imagen
            pIdent2.Value = EmpresaActual
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
            End Try

        End Sub

        Public Shared Function FirmasPlanilla(ByVal Periodo As String, _
           ByVal Tipo As String, ByVal Digital As Boolean, ByVal Empleado As String, _
           ByVal Localidad As Integer, ByVal Departamento As String, ByVal Area As String, _
           ByVal Orden As String, ByVal chkSalario As Boolean) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFirmasPlanilla", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent1 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Digital", SqlDbType.Bit)
            Dim pIdent4 As New SqlParameter("@empleado", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@localidad", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@departamento", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@area", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@orden", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@chkSalario", SqlDbType.Bit)


            pIdent.Value = Periodo
            pIdent1.Value = Tipo
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Digital
            pIdent4.Value = Empleado
            pIdent5.Value = Departamento
            pIdent6.Value = Area
            pIdent7.Value = Orden
            pIdent8.Value = Localidad
            pIdent9.value = chkSalario

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            Try
                DBCommand.Fill(dsFicha, "FirmasPlanilla")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If Digital = False Then
                'Agregar la foto a cada registro en el campo temporal de imagen
                Dim i As Integer, Archivo As String, oImagen As Image
                Dim ms As New MemoryStream()
                Dim arrImage() As Byte

                For i = 0 To dsFicha.Tables("FirmasPlanilla").Rows.Count - 1
                    If dsFicha.Tables("FirmasPlanilla").Rows(i).Item("emp_firma") <> "" Then
                        Archivo = dsFicha.Tables("FirmasPlanilla").Rows(i).Item("emp_firma")
                        oImagen = New Bitmap(Archivo)
                        oImagen.Save(ms, oImagen.RawFormat)
                        arrImage = ms.GetBuffer
                        dsFicha.Tables("firmasplanilla").Rows(i)("Imagen") = arrImage
                        'Me.AgregarImagen(arrImage, dsFicha.Tables("FirmasPlanilla").Rows(0)("emp_codigo"))
                    End If
                Next
            End If
            DBConn.Close()
            Return dsFicha
        End Function
        Public Shared Function BcoBac(ByVal Periodo As String, _
                ByVal TPeriodo As String, ByVal Consecutivo As String, _
                ByVal FechaPago As Date, _
                ByVal CODIGOPLAN As String, _
                ByVal Cuenta As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_BcoBAC", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pConsecutivo As New SqlParameter("@Consecutivo", SqlDbType.NVarChar)
            Dim pFechaPago As New SqlParameter("@FechaPago", SqlDbType.SmallDateTime)
            Dim pCodPlan As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pCuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpresa.Value = EmpresaActual
            pConsecutivo.Value = Consecutivo
            pFechaPago.Value = FechaPago
            pCodPlan.Value = CODIGOPLAN
            pCuenta.Value = Cuenta

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pConsecutivo)
            DBCommand.SelectCommand.Parameters.Add(pFechaPago)
            DBCommand.SelectCommand.Parameters.Add(pCodPlan)
            DBCommand.SelectCommand.Parameters.Add(pCuenta)

            Try
                DBCommand.Fill(dsFicha, "BcoBac")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function BcoBancentro(ByVal Periodo As String, _
                                ByVal TPeriodo As String, ByVal Consecutivo As String, ByVal FechaPago As Date, _
                                ByVal CODIGOPLAN As String, ByVal Cuenta As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_BcoBancentro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pConsecutivo As New SqlParameter("@Consecutivo", SqlDbType.NVarChar)
            Dim pFechaPago As New SqlParameter("@FechaPago", SqlDbType.SmallDateTime)
            Dim pCodPlan As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pCuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpresa.Value = EmpresaActual
            pConsecutivo.Value = Consecutivo
            pFechaPago.Value = FechaPago
            pCodPlan.Value = CODIGOPLAN
            pCuenta.Value = Cuenta

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pConsecutivo)
            DBCommand.SelectCommand.Parameters.Add(pFechaPago)
            DBCommand.SelectCommand.Parameters.Add(pCodPlan)
            DBCommand.SelectCommand.Parameters.Add(pCuenta)

            Try
                DBCommand.Fill(dsFicha, "BcoBancentro")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function ImprimirColilla(ByVal Periodo As String, _
                                        ByVal TPeriodo As String, _
                                        ByVal Empleado As String, _
                                        ByVal Localidad As Integer, _
                                        ByVal Departamento As String, _
                                        ByVal Area As String, _
                                        ByVal Orden As String, _
                                        ByVal Desde As Integer, _
                                        ByVal hasta As Integer) As DataTable

            Dim lds As New DataSet()

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Periodo", SqlDbType.NVarChar, 8, ParameterDirection.Input, Periodo)
            v.AddParameter("tPeriodo", SqlDbType.NVarChar, 1, ParameterDirection.Input, TPeriodo)
            v.AddParameter("empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("Localidad", SqlDbType.Int, 5, ParameterDirection.Input, Localidad)
            v.AddParameter("Departamento", SqlDbType.NVarChar, 10, ParameterDirection.Input, Departamento)
            v.AddParameter("Area", SqlDbType.NVarChar, 10, ParameterDirection.Input, Area)
            v.AddParameter("Orden", SqlDbType.NVarChar, 1, ParameterDirection.Input, Orden)
            v.AddParameter("Desde", SqlDbType.Int, 5, ParameterDirection.Input, Desde)
            v.AddParameter("Hasta", SqlDbType.Int, 5, ParameterDirection.Input, hasta)



            Try
                Return v.EjecutarComando("_ReportePlanillaEnc", "_ReportePlanillaEnc;1")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function ImprimirColilla_Detalle(ByVal Periodo As String, _
                       ByVal TPeriodo As String, _
                       ByVal Empleado As String, _
                       ByVal Departamento As String, _
                       ByVal Area As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim lds As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RptColillaDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpleado.Value = Empleado
            pEmpresa.Value = EmpresaActual

            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pArea As New SqlParameter("@Area", SqlDbType.NVarChar)
            pDepartamento.Value = Departamento
            pArea.Value = Area
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pArea)

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)



            Try
                DBCommand.Fill(dsFicha, "ColillaDetalle")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function ImprimirColilla_Asistencias(ByVal Periodo As String, _
                      ByVal TPeriodo As String, _
                      ByVal Empleado As String, _
                      ByVal Departamento As String, _
                      ByVal Area As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim lds As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Destajo_Calendario", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpleado.Value = Empleado
            pEmpresa.Value = EmpresaActual

            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pArea As New SqlParameter("@Area", SqlDbType.NVarChar)
            pDepartamento.Value = Departamento
            pArea.Value = Area
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pArea)

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)



            Try
                DBCommand.Fill(dsFicha, "Calendario")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function
        Public Shared Function ImprimirColilla_Latas(ByVal Periodo As String, _
                   ByVal TPeriodo As String, _
                   ByVal Empleado As String, _
                   ByVal Departamento As String, _
                   ByVal Area As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim lds As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Latas_Calendario", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpleado.Value = Empleado
            pEmpresa.Value = EmpresaActual

            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pArea As New SqlParameter("@Area", SqlDbType.NVarChar)
            pDepartamento.Value = Departamento
            pArea.Value = Area
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pArea)

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)



            Try
                DBCommand.Fill(dsFicha, "Latas")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function ImprimirColillaIng(ByVal Periodo As String, _
                                ByVal TPeriodo As String, _
                                ByVal Empleado As String, _
                                ByVal Departamento As String, _
                                ByVal Area As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RptColillaDetIngresos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpleado.Value = Empleado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)

            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pArea As New SqlParameter("@Area", SqlDbType.NVarChar)
            pDepartamento.Value = Departamento
            pArea.Value = Area
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pArea)


            Try
                DBCommand.Fill(dsFicha, "Ingresos")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function ImprimirColillaEgr(ByVal Periodo As String, _
                               ByVal TPeriodo As String, _
                               ByVal Empleado As String, _
                                ByVal Departamento As String, _
                                ByVal Area As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RptColillaDetEgresos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpleado.Value = Empleado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)

            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pArea As New SqlParameter("@Area", SqlDbType.NVarChar)
            pDepartamento.Value = Departamento
            pArea.Value = Area
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pArea)


            Try
                DBCommand.Fill(dsFicha, "Ingresos")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function
        Public Shared Function ImprimirColillaEgrVD(ByVal Periodo As String, _
                                       ByVal TPeriodo As String, _
                                       ByVal Empleado As String, _
                                        ByVal Departamento As String, _
                                        ByVal Area As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RptColillaDetEgresosVD", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pPeriodo.Value = Periodo
            pTPeriodo.Value = TPeriodo
            pEmpleado.Value = Empleado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)

            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pArea As New SqlParameter("@Area", SqlDbType.NVarChar)
            pDepartamento.Value = Departamento
            pArea.Value = Area
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pArea)

            Try
                DBCommand.Fill(dsFicha, "EgresosVD")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function
        Public Shared Function GetDetails(ByVal Codigo As String, ByVal Tipo As String, ByVal Empleado As String) As PlanillaDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Details As New PlanillaDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPlanillaDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent4 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pIdent.Value = Codigo
            pIdent2.Value = Tipo
            pIdent3.Value = EmpresaActual
            pIdent4.Value = Empleado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            DBCommand.Fill(dsFicha, "Planilla")

            If dsFicha.Tables("Planilla").Rows.Count = 1 Then
                Details.Codigo = dsFicha.Tables("Planilla").Rows(0).Item("pla_codigo")
                Details.Tipo = dsFicha.Tables("Planilla").Rows(0).Item("pla_tipo")
                Details.Empleado = dsFicha.Tables("Planilla").Rows(0).Item("emp_codigo")
                Details.Fecha = dsFicha.Tables("Planilla").Rows(0).Item("pla_fecha")
                Details.Departamento = dsFicha.Tables("Planilla").Rows(0).Item("dep_codigo")
                Details.SalarioBasico = dsFicha.Tables("Planilla").Rows(0).Item("pla_sbasico")
                Details.Antiguedad = dsFicha.Tables("Planilla").Rows(0).Item("pla_antiguedad")
                Details.IR = dsFicha.Tables("Planilla").Rows(0).Item("pla_ir")
                Details.INSS = dsFicha.Tables("Planilla").Rows(0).Item("pla_inss")
                Details.INSSPatronal = dsFicha.Tables("Planilla").Rows(0).Item("pla_insspatronal")
                Details.Aplicada = dsFicha.Tables("Planilla").Rows(0).Item("pla_aplicada")
                Details.TIngresos = dsFicha.Tables("Planilla").Rows(0).Item("pla_tingresos")
                Details.TEgresos = dsFicha.Tables("Planilla").Rows(0).Item("pla_tegresos")
                Details.Temporal = dsFicha.Tables("Planilla").Rows(0).Item("pla_temporal")
                Details.FormaPago = dsFicha.Tables("Planilla").Rows(0).Item("emp_formapago")
                Details.Moneda = dsFicha.Tables("Planilla").Rows(0).Item("mon_codigo")
                Details.Aprobada = dsFicha.Tables("Planilla").Rows(0).Item("per_aprobada")
                Details.hAprobada = dsFicha.Tables("Planilla").Rows(0).Item("per_haprobada")
            End If

            Return Details

        End Function

        Public Shared Function GetListPlanilla(ByVal Codigo As String, ByVal Tipo As String, ByVal Empleado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPlanilla", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident4 As New SqlParameter("@Empleado", SqlDbType.NVarChar)


            pIdent.Value = Codigo
            pIdent2.Value = Tipo
            pIdent3.Value = EmpresaActual
            pident4.Value = Empleado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pident4)

            DBCommand.Fill(dsFicha, "Planilla")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListPlanilla_Journal(ByVal Codigo As String, ByVal Tipo As String, _
            ByVal Moneda As String, ByVal DebCred As String, _
            ByVal Procedimiento As String, ByVal Tabla As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter(Procedimiento, DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@periodo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Tperiodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident4 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pident5 As New SqlParameter("@DebCred", SqlDbType.NVarChar)



            pIdent.Value = Codigo
            pIdent2.Value = Tipo
            pIdent3.Value = EmpresaActual
            pident4.Value = Moneda
            pident5.Value = DebCred


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pident4)
            DBCommand.SelectCommand.Parameters.Add(pident5)

            Try
                DBCommand.Fill(dsFicha, Tabla)
                DBConn.Close()
            Catch EX As Exception
                MsgBox(EX.Message)
            End Try

            Return dsFicha

        End Function

        Public Shared Function GetListPlanilla_Caldera(ByVal Mes As String, ByVal Moneda As String, _
            ByVal Todos As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListNCaldera", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident4 As New SqlParameter("@Todos", SqlDbType.NVarChar)

            pIdent.Value = Mes
            pIdent2.Value = Moneda
            pIdent3.Value = EmpresaActual
            pident4.Value = Todos

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pident4)

            DBCommand.Fill(dsFicha, "Caldera")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function Planilla_Do(ByVal Codigo As String, ByVal Tipo As String, ByVal Temporal As Boolean) As Boolean

            ' Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBConnexion.Open()

            DBCommand = New SqlDataAdapter("_Planilla_Do", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBCommand.SelectCommand.CommandTimeout = 0
            transaccion = DBConnexion.BeginTransaction



            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pident5 As New SqlParameter("@Temporal", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Today
            pident5.Value = Temporal


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pident5)

            Try
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()

                DBConnexion.Close()

            Catch ex As Exception
                transaccion.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
            Return True

        End Function
        Public Shared Function Planilla_Do_Vacaciones(ByVal Codigo As String, ByVal Tipo As String, ByVal Temporal As Boolean) As Boolean

            ' Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBConnexion.Open()

            DBCommand = New SqlDataAdapter("_Planilla_Do_Vacaciones", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            transaccion = DBConnexion.BeginTransaction



            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pident5 As New SqlParameter("@Temporal", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Today
            pident5.Value = Temporal


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pident5)

            Try
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()

                DBConnexion.Close()

            Catch ex As Exception
                transaccion.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
            Return True

        End Function
        Public Shared Function Planilla_Do_Extra(ByVal Codigo As String, ByVal Tipo As String, ByVal Temporal As Boolean) As Boolean

            ' Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBConnexion.Open()

            DBCommand = New SqlDataAdapter("_Planilla_Do_Extra", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBCommand.SelectCommand.CommandTimeout = 0
            transaccion = DBConnexion.BeginTransaction




            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pident5 As New SqlParameter("@Temporal", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Today
            pident5.Value = Temporal


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pident5)

            Try
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()

                DBConnexion.Close()

            Catch ex As Exception
                transaccion.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
            Return True

        End Function
        Public Shared Function Planilla_Do_Corte(ByVal Codigo As String, ByVal Tipo As String) As Boolean

            ' Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBConnexion.Open()

            DBCommand = New SqlDataAdapter("_Planilla_Do_Corte", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            transaccion = DBConnexion.BeginTransaction

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            Try
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()

                DBConnexion.Close()

            Catch ex As Exception
                transaccion.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
            Return True

        End Function
        Public Shared Function Planilla_unDo(ByVal Codigo As String, ByVal Tipo As String) As Boolean

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim Transaccion As SqlTransaction = Nothing


            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_UnDo", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBConnexion.Open()
            transaccion = DBConnexion.BeginTransaction()

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Today

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()
                DBConnexion.Close()

            Catch ex As Exception
                transaccion.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
            Return True

        End Function
        Public Shared Function Planilla_unDo_Vacaciones(ByVal Codigo As String, ByVal Tipo As String) As Boolean

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim Transaccion As SqlTransaction = Nothing


            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_UnDo_Vacaciones", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBConnexion.Open()
            transaccion = DBConnexion.BeginTransaction()

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Today

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()
                DBConnexion.Close()

            Catch ex As Exception
                transaccion.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
            Return True

        End Function
        Public Shared Function Planilla_unDo_Extra(ByVal Codigo As String, ByVal Tipo As String) As Boolean


            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim Transaccion As SqlTransaction = Nothing


            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_UnDo_Extra", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBConnexion.Open()
            transaccion = DBConnexion.BeginTransaction()

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Today

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()
                DBConnexion.Close()

            Catch ex As Exception
                transaccion.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
            Return True

        End Function
        Public Shared Function Planilla_unDo_Corte(ByVal Codigo As String, ByVal Tipo As String) As Boolean


            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            'Dim Transaccion As SqlTransaction = Nothing


            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_Undo_Corte", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBConnexion.Open()
            transaccion = DBConnexion.BeginTransaction()

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Today

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()
                DBConnexion.Close()

            Catch ex As Exception
                transaccion.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
            Return True

        End Function
        Public Shared Sub Additem(ByVal Codigo As String, ByVal Tipo As String, ByVal Temporal As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlanillaAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pident5 As New SqlParameter("@Temporal", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Today
            pident5.Value = Temporal

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pident5)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub

        Public Shared Sub Update_IR_INSS(ByVal Codigo As String, ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_IR_INSS_Update", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Now.Date

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

        Public Shared Sub Update_Moneda(ByVal Codigo As String, ByVal Tipo As String, ByVal Fecha As Date)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Planilla_Moneda_Update", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Fecha

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
        Public Shared Sub Update_IR_INSS_Empleado(ByVal Codigo As String, ByVal Tipo As String, ByVal Undo As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Empleado_IR_INSS_Update", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim Pident4 As New SqlParameter("@Undo", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            Pident4.Value = Undo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
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
        Public Shared Sub delete(ByVal Codigo As String, ByVal Tipo As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlanillaDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            'Dim pIdent4 As New SqlParameter("@Temporal", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            'pIdent4.Value = Temporal

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            'DBCommand.SelectCommand.Parameters.Add(pIdent4)

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


    Public Class PlanillaDDB

        Public Shared Function GetPlanillaCompleta(ByVal Codigo As String, ByVal Tipo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter, dbc As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPlanillaV", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)


            pIdent.Value = Codigo
            pIdent2.Value = Tipo
            pIdent3.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "Planilla")

            dbc = New SqlDataAdapter("_GetListPlanillaDetalleV", DBConn)
            dbc.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim dpIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim dpIdent2 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim dpIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)


            dpIdent.Value = Codigo
            dpIdent2.Value = Tipo
            dpIdent3.Value = EmpresaActual

            dbc.SelectCommand.Parameters.Add(dpIdent)
            dbc.SelectCommand.Parameters.Add(dpIdent2)
            dbc.SelectCommand.Parameters.Add(dpIdent3)

            dbc.Fill(dsFicha, "PlanillaDetalle")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Shared Function GetListPlanillaD(ByVal Codigo As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPlanillaDetalle", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)


            pIdent.Value = Codigo
            pIdent2.Value = Tipo
            pIdent3.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "PlanillaDetalle")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub AddDI(ByVal Codigo As String, ByVal Tipo As String, ByVal Temporal As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DI_PlanillaAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Temporal", SqlDbType.Bit)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Temporal


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
        Public Shared Sub AddDD(ByVal Codigo As String, ByVal Tipo As String, ByVal Temporal As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DE_PlanillaAdd_Aguinaldo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Temporal", SqlDbType.Bit)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            pIdent4.Value = Temporal


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

        Public Sub delete(ByVal Codigo As String, ByVal Tipo As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlanillaDDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            'Dim pIdent4 As New SqlParameter("@Temporal", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Tipo
            'pIdent4.Value = Temporal

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            'DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Shared Function Colillas(ByVal Codigo As String, ByVal Tipo As String, _
            ByVal Departamento As String, ByVal Area As String, ByVal Empleado As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter, dbc As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Colilla_Encabezado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure



            DBCommand.Fill(dsFicha, "Planilla")

            dbc = New SqlDataAdapter("_GetListPlanillaDetalleV", DBConn)
            dbc.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim dpIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim dpIdent2 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim dpIdent3 As New SqlParameter("@Empresa", SqlDbType.Int)


            dpIdent.Value = Codigo
            dpIdent2.Value = Tipo
            dpIdent3.Value = EmpresaActual

            dbc.SelectCommand.Parameters.Add(dpIdent)
            dbc.SelectCommand.Parameters.Add(dpIdent2)
            dbc.SelectCommand.Parameters.Add(dpIdent3)

            dbc.Fill(dsFicha, "PlanillaDetalle")

            DBConn.Close()

            Return dsFicha


        End Function
       
    End Class
End Namespace

