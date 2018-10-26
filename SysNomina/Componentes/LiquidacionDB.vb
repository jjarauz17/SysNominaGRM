Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab

    Public Class LiquidacionDetails

        Public Codigo As String
        Public Empleado As String
        Public Fecha As String
        Public Baja_FormaPago As String
        Public SBasico As Double
        Public IR As Double
        Public INSS As Double
        Public INSSPATRONAL As Double
        Public Aplicada As Boolean
        Public GrvIR As Double
        Public GrvINSS As Double
        Public TotalIngresos As Double
        Public TotalEgresos As Double
        Public Inatec As Double
        Public Vacaciones As Double
        Public Aguinaldo As Double
        Public TasaCambio As Double
        Public Moneda As String
        Public FormaPago As String
        Public Cancelada As Boolean

    End Class

    Public Class Causas_Liquidacion
        Public ID As Integer
        Public Descripcion As String
        Public Vacaciones As Boolean
        Public Aguinaldo As Boolean
        Public Indemnizacion As Boolean
        Public Tipo_Contrato As String
    End Class

    Public Class LiquidacionDB

        Public Shared Function Liquidacion_Causas(ByVal Codigo As Integer, ByVal tipocontrato As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            v.AddParameter("tipocontrato", SqlDbType.NVarChar, 1, ParameterDirection.Input, tipocontrato)
            Try
                Return v.EjecutarComando("_RH_CausasDepidoList", "Tabla")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return New DataTable
            End Try
        End Function
        Public Shared Function Liquidacion_Causas_Detalle(ByVal id As Integer) As Causas_Liquidacion
            Dim cl As New Causas_Liquidacion
            Dim dt As New DataTable
            dt = VB.SysContab.LiquidacionDB.Liquidacion_Causas(id, "%")
            If dt.Rows.Count = 1 Then
                cl.ID = dt.Rows(0)("id")
                cl.Descripcion = dt.Rows(0)("descripcion")
                cl.Vacaciones = dt.Rows(0)("vacaciones")
                cl.Aguinaldo = dt.Rows(0)("aguinaldo")
                cl.Indemnizacion = dt.Rows(0)("indemnizacion")
                cl.Tipo_Contrato = dt.Rows(0)("tipo_contrato")
            Else
                cl.ID = 0
                cl.Descripcion = ""
                cl.Vacaciones = False
                cl.Aguinaldo = False
                cl.Indemnizacion = False
                cl.Tipo_Contrato = "F"
            End If
            Return cl
        End Function

        Public Shared Sub Liquidacion_Causas_Add(ByVal id As Integer, _
            ByVal descripcion As String, ByVal vacaciones As Boolean, ByVal aguinaldo As Boolean, _
            ByVal indemnizacion As Boolean, ByVal tipocontrato As String, ByVal accion As Integer)


            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("id", SqlDbType.Int, 5, ParameterDirection.Input, id)
            v.AddParameter("Descripcion", SqlDbType.NVarChar, 200, ParameterDirection.Input, descripcion)
            v.AddParameter("Vacaciones", SqlDbType.Bit, 1, ParameterDirection.Input, vacaciones)
            v.AddParameter("Aguinaldo", SqlDbType.Bit, 1, ParameterDirection.Input, aguinaldo)
            v.AddParameter("Indemnizacion", SqlDbType.Bit, 1, ParameterDirection.Input, indemnizacion)
            v.AddParameter("tipocontrato", SqlDbType.NVarChar, 1, ParameterDirection.Input, tipocontrato)
            v.AddParameter("accion", SqlDbType.Int, 5, ParameterDirection.Input, accion)
            Try
                v.EjecutarComando("_RH_CTC_Add")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub
        Public Function Liquidacion_Memoria(ByVal Empleado As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_Liquidacion_Memoria", "Memoria")
            Catch ex As Exception
                MsgBox(ex.Message)
                Dim dt As New DataTable
                dt.TableName = "Memoria"
                dt.Columns.Add("empr_codigo", System.Type.GetType("System.Int32"), "")
                dt.Columns("empr_codigo").DefaultValue = 1

                dt.Columns.Add("empleado", System.Type.GetType("System.String"), "")
                dt.Columns("empleado").DefaultValue = ""

                dt.Columns.Add("mes", System.Type.GetType("System.String"), "")
                dt.Columns("mes").DefaultValue = ""

                dt.Columns.Add("salario", System.Type.GetType("System.Double"), "")
                dt.Columns("salario").DefaultValue = 0
                dt.Columns.Add("tingresos", System.Type.GetType("System.Double"), "")
                dt.Columns("tingresos").DefaultValue = 0
                dt.Columns.Add("factor", System.Type.GetType("System.Double"), "")
                dt.Columns("factor").DefaultValue = 0
                dt.Columns.Add("tipo", System.Type.GetType("System.string"), "")
                dt.Columns("tipo").DefaultValue = ""
                Return dt
            End Try


        End Function

        Public Shared Function GetLiquidaciones(ByVal Empleado As String, ByVal Localidad As Integer, _
            ByVal Departamento As String, ByVal Al As Date, ByVal Al_ As Date) As DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("Localidad", SqlDbType.Int, 5, ParameterDirection.Input, Localidad)
            v.AddParameter("Departamento", SqlDbType.NVarChar, 4, ParameterDirection.Input, Departamento)
            v.AddParameter("Al", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Al)
            v.AddParameter("_Al", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Al_)
            Try
                Return v.EjecutarComando("Liquidacion_Global")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Function GetListReporte_Encabezado(ByVal Empleado As String, ByVal Definitiva As Boolean) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RptLiquidacion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Definitiva", SqlDbType.Bit)

            pIdent.Value = Empleado
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Definitiva
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBCommand.Fill(dsFicha, "LiqEncabezado")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return dsFicha

        End Function
        Public Function GetListReporte_Detalle(ByVal Empleado As String, ByVal Liquidacion As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RptLiquidacion_Det", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Liquidacion", SqlDbType.NVarChar)

            pIdent.Value = Empleado
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Liquidacion
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBCommand.Fill(dsFicha, "LiqDetalle")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return dsFicha

        End Function
        Public Function GetDetails(ByVal Codigo As String) As LiquidacionDetails
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim dLiq As New VB.SysContab.LiquidacionDetails()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetLiquidacionDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Liquidacion", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)


            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            Try
                DBCommand.Fill(dsFicha, "LiqDetalle")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If dsFicha.Tables(0).Rows.Count = 1 Then
                dLiq.Aguinaldo = dsFicha.Tables(0).Rows(0)("liq_aguinaldo")
                dLiq.Aplicada = dsFicha.Tables(0).Rows(0)("liq_aplicada")
                dLiq.Baja_FormaPago = dsFicha.Tables(0).Rows(0)("baj_formapago")
                dLiq.Cancelada = dsFicha.Tables(0).Rows(0)("liq_cancelada")
                dLiq.Codigo = dsFicha.Tables(0).Rows(0)("liq_codigo")
                dLiq.Empleado = dsFicha.Tables(0).Rows(0)("emp_codigo")
                dLiq.Fecha = dsFicha.Tables(0).Rows(0)("liq_fecha")
                dLiq.FormaPago = dsFicha.Tables(0).Rows(0)("liq_formapago")
                dLiq.GrvINSS = dsFicha.Tables(0).Rows(0)("liq_ingrgrvinss")
                dLiq.GrvIR = dsFicha.Tables(0).Rows(0)("liq_ingrgrvIR")
                dLiq.Inatec = dsFicha.Tables(0).Rows(0)("liq_inatec")
                dLiq.INSS = dsFicha.Tables(0).Rows(0)("liq_inss")
                dLiq.INSSPATRONAL = dsFicha.Tables(0).Rows(0)("liq_insspatronal")
                dLiq.IR = dsFicha.Tables(0).Rows(0)("liq_ir")
                dLiq.Moneda = dsFicha.Tables(0).Rows(0)("mon_codigo")
                dLiq.SBasico = dsFicha.Tables(0).Rows(0)("liq_sbasico")
                dLiq.TasaCambio = dsFicha.Tables(0).Rows(0)("liq_tc")
                dLiq.TotalEgresos = dsFicha.Tables(0).Rows(0)("liq_tegresos")
                dLiq.TotalIngresos = dsFicha.Tables(0).Rows(0)("liq_tingresos")
                dLiq.Vacaciones = dsFicha.Tables(0).Rows(0)("liq_vacaciones")
            End If
            Return dLiq
        End Function


        Public Function Additem(ByVal Empleado As String, ByVal FechaFin As Date, _
                ByVal Depto As String, ByVal Moneda As String, _
                ByVal FormaPago As String, ByVal Definitiva As Boolean) As Boolean



            Dim DBCommand As SqlDataAdapter



            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBConnexion.Open()


            DBCommand = New SqlDataAdapter("_Liquidacion_Liquidacion_Calculos", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            transaccion = DBConnexion.BeginTransaction

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fechafin", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@Depto", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@OK", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Definitiva", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = FechaFin
            pIdent4.Value = Depto
            pIdent5.Value = Moneda
            pIdent6.Value = FormaPago
            pIdent7.Direction = ParameterDirection.Output
            pIdent8.Value = Definitiva

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            Try
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()
                DBConnexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

            Return pIdent7.Value



        End Function


        Public Function Update_FormaPago(ByVal Empleado As String, ByVal FormaPago As String, ByVal Pagada As Boolean) As Boolean



            Dim DBCommand As SqlDataAdapter



            DBConnexion = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBConnexion.Open()


            DBCommand = New SqlDataAdapter("_Liquidacion_Update_FormaPago", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            transaccion = DBConnexion.BeginTransaction

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Formapago", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Pagada", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = FormaPago
            pIdent4.Value = Pagada

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                DBCommand.SelectCommand.Transaction = transaccion
                DBCommand.SelectCommand.ExecuteNonQuery()
                transaccion.Commit()
                DBConnexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

            Return True

        End Function

        Public Function BcoBac(ByVal Liquidacion As String, _
                                ByVal Consecutivo As String, ByVal FechaPago As Date) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_BcoBAC_liquidacion", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Liquidacion", SqlDbType.NVarChar)

            Dim pConsecutivo As New SqlParameter("@Consecutivo", SqlDbType.NVarChar)
            Dim pFechaPago As New SqlParameter("@FechaPago", SqlDbType.SmallDateTime)

            pPeriodo.Value = Liquidacion
            pEmpresa.Value = EmpresaActual
            pConsecutivo.Value = Consecutivo
            pFechaPago.Value = FechaPago

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pConsecutivo)
            DBCommand.SelectCommand.Parameters.Add(pFechaPago)

            Try
                DBCommand.Fill(dsFicha, "BcoBac_Liquidacion")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function
    End Class

End Namespace

