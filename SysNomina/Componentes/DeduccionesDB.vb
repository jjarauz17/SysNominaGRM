Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab

    Public Class DeduccionDetails

        Public Codigo As String
        Public Empleado As String
        Public Fecha As String
        Public FInicio As String
        Public Monto As String
        Public Saldo As String
        Public NCuotas As String
        Public ValorCuota As String
        Public AporteEmpresa As String
        Public TipoDeduccion As String
        Public Deducir As Boolean
        Public CuotaFija As Boolean
        Public Cancelado As Boolean
        Public Moneda As String
        Public Unico As Boolean
        Public NRegular As Boolean
        Public Mantenimiento As Boolean
        Public DiaHora As Double
        Public Valor As Double
        Public Comentarios As String

    End Class

    Public Class DeduccionDB

        'Public Function GetDetalle(ByVal Deduccion As String) As Integer

        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()


        '    DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_GetListDeduccionDetalle", DBConn)
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)


        '    pIdent.Value = EmpresaActual
        '    pIdent2.Value = Deduccion

        '    DBCommand.SelectCommand.Parameters.Add(pIdent)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent2)

        '    DBCommand.Fill(dsFicha, "Deduccion")

        '    DBConn.Close()

        '    Return dsFicha.Tables("Deduccion").Rows(0)("Cantidad")

        'End Function
        'Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet

        'End Function

        Public Shared Function GetDetails(ByVal Codigo As String) As VB.SysContab.DeduccionDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet()
            Dim Details As New DeduccionDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDeduccionDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            ' Dim pIdent3 As New SqlParameter("@Unico", SqlDbType.Bit)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            ' pIdent3.Value = Unico
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            ' DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsHorario, "Deduccion")

            If dsHorario.Tables("Deduccion").Rows.Count = 1 Then

                Details.Codigo = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_codigo")
                Details.Empleado = dsHorario.Tables("Deduccion").Rows(0).Item("emp_codigo")
                Details.Fecha = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_fecha")
                Details.FInicio = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_fechaInicio")
                Details.Monto = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_monto")
                Details.Saldo = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_saldo")
                Details.NCuotas = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_ncuotas")
                Details.ValorCuota = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_valorcuota")
                Details.AporteEmpresa = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_aporteempresa")
                Details.TipoDeduccion = dsHorario.Tables("Deduccion").Rows(0).Item("tde_codigo")
                Details.Deducir = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_deducir")
                Details.CuotaFija = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_Ctafija")
                Details.Cancelado = dsHorario.Tables("Deduccion").Rows(0).Item("ptm_cancelado")
                Details.Moneda = dsHorario.Tables("DEduccion").Rows(0).Item("mon_codigo")
                Details.Unico = dsHorario.Tables("DEduccion").Rows(0).Item("ptm_unico")
                Details.NRegular = dsHorario.Tables("DEduccion").Rows(0).Item("ptm_nregular")
                Details.Mantenimiento = dsHorario.Tables("DEduccion").Rows(0).Item("ptm_mantenimiento")
                Details.DiaHora = dsHorario.Tables("DEduccion").Rows(0).Item("ptm_diahora")
                Details.Valor = dsHorario.Tables("DEduccion").Rows(0).Item("ptm_valor")
                Details.Comentarios = dsHorario.Tables("DEduccion").Rows(0).Item("ptm_comentarios")
            End If

            Return Details

        End Function

        Public Shared Function GetList() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDeduccion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            'Dim pIdent3 As New SqlParameter("@Unico", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            'pIdent2.Value = Estado
            'pIdent3.Value = Unico
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)
            'DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "Deduccion")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListPendientes_Generacion(ByVal Estado As String, ByVal Unico As Boolean, _
           ByVal Periodo As String, ByVal TPeriodo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDeduccion_PendientesGeneracion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Unico", SqlDbType.Bit)
            Dim pIdent4 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Estado
            pIdent3.Value = Unico
            pIdent4.Value = Periodo
            pIdent5.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.Fill(dsFicha, "Deduccion")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String, ByVal Estado As String, ByVal Unico As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDeduccionBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Unico", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Filtro
            pIdent3.Value = Estado
            pIdent4.Value = Unico
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            DBCommand.Fill(dsFicha, "Deduccion")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetListCodigoNvo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDeduccionCodigoNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)


            DBCommand.Fill(dsFicha, "Deduccion")

            DBConn.Close()

            If dsFicha.Tables("Deduccion").Rows(0).Item("CODIGO") Is DBNull.Value Then
                Return "1"
            Else
                Return dsFicha.Tables("Deduccion").Rows(0).Item("CODIGO")
            End If


        End Function

        Public Shared Function GenerarDeducciones(ByVal Periodo As String, ByVal TPeriodo As String) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDeduccion_PendientesGeneracion_V2", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            pPeriodo.Value = Periodo
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)

            Dim pTPeriodo As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            pTPeriodo.Value = TPeriodo
            DBCommand.SelectCommand.Parameters.Add(pTPeriodo)

            Dim pMovimientos As New SqlParameter("@Movimientos", SqlDbType.Int)
            pMovimientos.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(pMovimientos)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

            Return pMovimientos.Value
        End Function


        Public Shared Sub delete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DeduccionDelete", DBConn)
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

        Public Shared Function Additem(ByVal Codigo As String, ByVal Empleado As String, _
                ByVal Fecha As DateTime, ByVal FInicio As DateTime, _
                ByVal Monto As Double, ByVal Saldo As Double, _
                ByVal NCuotas As Integer, ByVal ValorCuota As Double, ByVal AporteEmpresa As Double, _
                ByVal TipoDeduccion As String, ByVal Deducir As Boolean, _
                ByVal CtaFija As Boolean, ByVal Cancelado As Boolean, _
                ByVal Moneda As String, ByVal Unico As Boolean, ByVal NRegular As Boolean, _
                ByVal Mantenimiento As Boolean, ByVal DiaHora As Double, ByVal Valor As Double, _
                ByRef nvoCodigo As String, ByVal Comentarios As String) As Boolean

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DeduccionAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@FInicio", SqlDbType.DateTime)
            Dim pIdent6 As New SqlParameter("@Monto", SqlDbType.Money)
            Dim pIdent7 As New SqlParameter("@Saldo", SqlDbType.Money)
            Dim pIdent8 As New SqlParameter("@NCuotas", SqlDbType.Int)
            Dim pIdent9 As New SqlParameter("@ValorCuota", SqlDbType.Money)
            Dim pIdent16 As New SqlParameter("@AporteEmpresa", SqlDbType.Money)
            Dim pIdent10 As New SqlParameter("@TipoDeduccion", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Deducir", SqlDbType.Bit)
            Dim pIdent12 As New SqlParameter("@CtaFija", SqlDbType.Bit)
            Dim pIdent13 As New SqlParameter("@Cancelado", SqlDbType.Bit)
            Dim pIdent14 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Unico", SqlDbType.Bit)
            Dim pIdent17 As New SqlParameter("@NREgular", SqlDbType.Bit)
            Dim pIdent18 As New SqlParameter("@Mantenimiento", SqlDbType.Bit)
            Dim pIdent19 As New SqlParameter("@DiaHora", SqlDbType.Float)
            Dim pIdent20 As New SqlParameter("@Valor", SqlDbType.Money)
            Dim pIdent21 As New SqlParameter("@Codigo2", SqlDbType.NVarChar, 6)
            Dim pIdent22 As New SqlParameter("@Comentarios", SqlDbType.NVarChar, 250)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Empleado
            pIdent4.Value = Fecha
            pIdent5.Value = FInicio
            pIdent6.Value = Monto
            pIdent7.Value = Saldo
            pIdent8.Value = NCuotas
            pIdent9.Value = ValorCuota
            pIdent10.Value = TipoDeduccion
            pIdent11.Value = Deducir
            pIdent12.Value = CtaFija
            pIdent13.Value = Cancelado
            pIdent14.Value = Moneda
            pIdent15.Value = Unico
            pIdent16.Value = AporteEmpresa
            pIdent17.Value = NRegular
            pIdent18.Value = Mantenimiento
            pIdent19.Value = DiaHora
            pIdent20.Value = Valor
            pIdent21.Direction = ParameterDirection.Output
            pIdent22.Value = Comentarios

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
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)
            DBCommand.SelectCommand.Parameters.Add(pIdent20)
            DBCommand.SelectCommand.Parameters.Add(pIdent21)
            DBCommand.SelectCommand.Parameters.Add(pIdent22)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
                nvoCodigo = pIdent21.Value
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                nvoCodigo = ""
                Return False
            End Try

        End Function



        Public Shared Sub Update(ByVal Codigo As String, ByVal Empleado As String, _
                ByVal Fecha As DateTime, ByVal FInicio As DateTime, _
                ByVal Monto As Double, ByVal Saldo As Double, _
                ByVal NCuotas As Integer, ByVal ValorCuota As Double, ByVal AporteEmpresa As Double, _
                ByVal TipoDeduccion As String, ByVal Deducir As Boolean, _
                ByVal CtaFija As Boolean, ByVal Cancelado As Boolean, _
                ByVal Moneda As String, ByVal Unico As Boolean, ByVal NRegular As Boolean, _
                ByVal Mantenimiento As Boolean, ByVal DiaHora As Double, ByVal Valor As Double, _
                ByVal Comentarios As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DeduccionUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@FInicio", SqlDbType.DateTime)
            Dim pIdent6 As New SqlParameter("@Monto", SqlDbType.Money)
            Dim pIdent7 As New SqlParameter("@Saldo", SqlDbType.Money)
            Dim pIdent8 As New SqlParameter("@NCuotas", SqlDbType.Int)
            Dim pIdent9 As New SqlParameter("@ValorCuota", SqlDbType.Money)
            Dim pIdent16 As New SqlParameter("@AporteEmpresa", SqlDbType.Money)
            Dim pIdent10 As New SqlParameter("@TipoDeduccion", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Deducir", SqlDbType.Bit)
            Dim pIdent12 As New SqlParameter("@CtaFija", SqlDbType.Bit)
            Dim pIdent13 As New SqlParameter("@Cancelado", SqlDbType.Bit)
            Dim pIdent14 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Unico", SqlDbType.Bit)
            Dim pIdent17 As New SqlParameter("@NRegular", SqlDbType.Bit)
            Dim pIdent18 As New SqlParameter("@Mantenimiento", SqlDbType.Bit)
            Dim pIdent19 As New SqlParameter("@DiaHora", SqlDbType.Float)
            Dim pIdent20 As New SqlParameter("@Valor", SqlDbType.Money)
            Dim pIdent21 As New SqlParameter("@Comentarios", SqlDbType.NVarChar, 250)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Empleado
            pIdent4.Value = Fecha
            pIdent5.Value = FInicio
            pIdent6.Value = Monto
            pIdent7.Value = Saldo
            pIdent8.Value = NCuotas
            pIdent9.Value = ValorCuota
            pIdent10.Value = TipoDeduccion
            pIdent11.Value = Deducir
            pIdent12.Value = CtaFija
            pIdent13.Value = Cancelado
            pIdent14.Value = Moneda
            pIdent15.Value = Unico
            pIdent16.Value = AporteEmpresa
            pIdent17.Value = NRegular
            pIdent18.Value = Mantenimiento
            pIdent19.Value = DiaHora
            pIdent20.Value = Valor
            pIdent21.Value = Comentarios

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
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)
            DBCommand.SelectCommand.Parameters.Add(pIdent20)
            DBCommand.SelectCommand.Parameters.Add(pIdent21)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub
        Public Function UpdateSaldo(ByVal Codigo As String, ByVal Monto As Double) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DeduccionUpdateSaldo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Monto", SqlDbType.Money)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent6.Value = Monto


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
        Public Shared Function GetEstadoCuenta_Encabezado(ByVal Empleado As String, ByVal TDeduccion As String) As DataSet
            Dim lds As New DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Deduccion_EstadoCuenta_Enc", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Deduccion", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = TDeduccion
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBCommand.Fill(lds, "ECD_Enc")
            Catch ex As Exception
                MsgBox(ex.Message)
                DBConn.Close()
                Return lds
                Exit Function
            End Try
            DBConn.Close()
            Return lds
        End Function
        Public Shared Function GetEstadoCuenta_Detalle(ByVal Empleado As String, ByVal TDeduccion As String) As DataSet
            Dim lds As New DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Deduccion_EstadoCuenta_Det", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Deduccion", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = TDeduccion
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            Try
                DBCommand.Fill(lds, "ECD_Det")
            Catch ex As Exception
                MsgBox(ex.Message)
                DBConn.Close()
                Return lds
                Exit Function
            End Try
            DBConn.Close()
            Return lds
        End Function

        Public Shared Function GetEstadoCuenta_Resumen(ByVal Empleado As String, ByVal TDeduccion As String, ByVal Nomina As String) As DataSet
            Dim lds As New DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Deduccion_EstadoCuenta_Res", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Deduccion", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Nomina", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = TDeduccion
            pIdent4.Value = Nomina
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                DBCommand.Fill(lds, "ECD_Res")
            Catch ex As Exception
                MsgBox(ex.Message)
                DBConn.Close()
                Return lds
                Exit Function
            End Try
            DBConn.Close()
            Return lds
        End Function

        Public Shared Function Exportar_Pagos(ByVal Hasta As Date) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Hasta", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, Hasta)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_RH_Exportar_a_Pagos", "Exportar_Pagos")

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function
    End Class

End Namespace

