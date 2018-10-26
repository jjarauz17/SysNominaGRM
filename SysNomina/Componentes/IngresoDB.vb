Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class IngresoDetails

        Public Codigo As String
        Public Empleado As String
        Public Fecha As String
        Public FInicio As String
        Public Monto As String
        Public TipoIngreso As String
        Public Cancelado As Boolean
        Public Moneda As String
        Public Unico As Boolean
        Public NRegular As Boolean
        Public Mantenimiento As Boolean
        Public DiaHora As Double
        Public Valor As Double
        Public Comentarios As String

    End Class

    Public Class IngresoDB

        Public Shared Function GenerarIngresos(ByVal Periodo As String, ByVal TPeriodo As String) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListIngreso_PendientesGeneracion_V2", DBConn)
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
        Public Shared Function GetDetails(ByVal Codigo As String) As IngresoDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet()
            Dim Details As New IngresoDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListIngresoDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            pIdent.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            DBCommand.Fill(dsHorario, "Ingreso")

            If dsHorario.Tables("Ingreso").Rows.Count = 1 Then

                Details.Codigo = dsHorario.Tables("Ingreso").Rows(0).Item("ing_codigo")
                Details.Empleado = dsHorario.Tables("Ingreso").Rows(0).Item("emp_codigo")
                Details.Fecha = dsHorario.Tables("Ingreso").Rows(0).Item("ing_fecha")
                Details.FInicio = dsHorario.Tables("Ingreso").Rows(0).Item("ing_fechaInicio")
                Details.Monto = dsHorario.Tables("Ingreso").Rows(0).Item("ing_monto")
                Details.TipoIngreso = dsHorario.Tables("Ingreso").Rows(0).Item("tdi_codigo")
                Details.Cancelado = dsHorario.Tables("Ingreso").Rows(0).Item("ing_cancelado")
                Details.Moneda = dsHorario.Tables("Ingreso").Rows(0).Item("mon_codigo")
                Details.Unico = dsHorario.Tables("Ingreso").Rows(0).Item("ing_unico")
                Details.NRegular = dsHorario.Tables("Ingreso").Rows(0).Item("ing_nregular")
                Details.Mantenimiento = dsHorario.Tables("Ingreso").Rows(0).Item("ing_mantenimiento")
                Details.DiaHora = dsHorario.Tables("Ingreso").Rows(0).Item("ing_DiaHora")
                Details.Valor = dsHorario.Tables("Ingreso").Rows(0).Item("ing_Valor")
                Details.Comentarios = dsHorario.Tables("Ingreso").Rows(0).Item("ing_comentarios")

            End If

            Return Details

        End Function

        Public Shared Function GetList() As DataSet
            '
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListIngreso", DBConn)
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

            DBCommand.Fill(dsFicha, "Ingreso")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListPendientes_Generacion(ByVal Estado As String, ByVal Unico As Boolean, _
        ByVal Periodo As String, ByVal TPeriodo As String) As DataSet
            '
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListIngreso_PendientesGeneracion", DBConn)
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
            pIdent5.Value = Tperiodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            DBCommand.Fill(dsFicha, "Ingreso")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListBuscar(ByVal Filtro As String, ByVal Estado As String, ByVal Unico As Boolean) As DataSet
            '
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListIngresoBuscar", DBConn)
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

            DBCommand.Fill(dsFicha, "Ingreso")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetListCodigoNvo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListIngresoCodigoNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)


            DBCommand.Fill(dsFicha, "Ingreso")

            DBConn.Close()

            If dsFicha.Tables("Ingreso").Rows(0).Item("CODIGO") Is DBNull.Value Then
                Return "000001"
            Else
                Return dsFicha.Tables("Ingreso").Rows(0).Item("CODIGO") 'Trim(Str(Val(dsFicha.Tables("Ingreso").Rows(0).Item("CODIGO")) + 1))
            End If


        End Function

        Public Shared Sub Delete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_IngresoDelete", DBConn)
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
                ByVal Monto As Double, ByVal TipoIngreso As String, ByVal Cancelado As Boolean, _
                ByVal Moneda As String, ByVal Unico As Boolean, ByVal NRegular As Boolean, _
                ByVal Mantenimiento As Boolean, ByVal DiasHoras As Double, ByVal Valor As Double, _
                ByVal Comentarios As String) As Boolean

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_IngresoAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            pIdent2.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Dim pIdent3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            pIdent3.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            pIdent4.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Dim pIdent5 As New SqlParameter("@FInicio", SqlDbType.DateTime)
            pIdent5.Value = FInicio
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Dim pIdent6 As New SqlParameter("@Monto", SqlDbType.Money)
            pIdent6.Value = Monto
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            Dim pIdent10 As New SqlParameter("@TipoIngreso", SqlDbType.NVarChar)
            pIdent10.Value = TipoIngreso
            DBCommand.SelectCommand.Parameters.Add(pIdent10)

            Dim pIdent13 As New SqlParameter("@Cancelado", SqlDbType.Bit)
            pIdent13.Value = Cancelado
            DBCommand.SelectCommand.Parameters.Add(pIdent13)

            Dim pIdent14 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            pIdent14.Value = Moneda
            DBCommand.SelectCommand.Parameters.Add(pIdent14)

            Dim pIdent15 As New SqlParameter("@Unico", SqlDbType.Bit)
            pIdent15.Value = Unico
            DBCommand.SelectCommand.Parameters.Add(pIdent15)

            Dim pIdent16 As New SqlParameter("@NRegular", SqlDbType.Bit)
            pIdent16.Value = NRegular
            DBCommand.SelectCommand.Parameters.Add(pIdent16)

            Dim pIdent17 As New SqlParameter("@Mantenimiento", SqlDbType.Bit)
            pIdent17.Value = Mantenimiento
            DBCommand.SelectCommand.Parameters.Add(pIdent17)

            Dim pIdent18 As New SqlParameter("@DiaHora", SqlDbType.Float)
            pIdent18.Value = DiasHoras
            DBCommand.SelectCommand.Parameters.Add(pIdent18)

            Dim pIdent19 As New SqlParameter("@Valor", SqlDbType.Float)
            pIdent19.Value = Valor
            DBCommand.SelectCommand.Parameters.Add(pIdent19)

            Dim pIdent20 As New SqlParameter("@Comentarios", SqlDbType.NVarChar)
            pIdent20.Value = Comentarios
            DBCommand.SelectCommand.Parameters.Add(pIdent20)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

        End Function

        Public Shared Function Additem_EDU(ByVal id As Integer, ByVal Empleado As String, _
               ByVal Fecha As DateTime, ByVal FInicio As DateTime, _
               ByVal Monto As Double, ByVal TipoIngreso As String, ByVal Cancelado As Boolean, _
               ByVal Moneda As String, ByVal Unico As Boolean, ByVal NRegular As Boolean, _
               ByVal Mantenimiento As Boolean, ByVal DiasHoras As Double, ByVal Valor As Double, _
               ByVal Comentarios As String) As Boolean

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EDU_IngresoAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Dim pIdent2 As New SqlParameter("@ID", SqlDbType.Int)
            pIdent2.Value = id
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Dim pIdent3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            pIdent3.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            pIdent4.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Dim pIdent5 As New SqlParameter("@FInicio", SqlDbType.DateTime)
            pIdent5.Value = FInicio
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Dim pIdent6 As New SqlParameter("@Monto", SqlDbType.Money)
            pIdent6.Value = Monto
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            Dim pIdent10 As New SqlParameter("@TipoIngreso", SqlDbType.NVarChar)
            pIdent10.Value = TipoIngreso
            DBCommand.SelectCommand.Parameters.Add(pIdent10)

            Dim pIdent13 As New SqlParameter("@Cancelado", SqlDbType.Bit)
            pIdent13.Value = Cancelado
            DBCommand.SelectCommand.Parameters.Add(pIdent13)

            Dim pIdent14 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            pIdent14.Value = Moneda
            DBCommand.SelectCommand.Parameters.Add(pIdent14)

            Dim pIdent15 As New SqlParameter("@Unico", SqlDbType.Bit)
            pIdent15.Value = Unico
            DBCommand.SelectCommand.Parameters.Add(pIdent15)

            Dim pIdent16 As New SqlParameter("@NRegular", SqlDbType.Bit)
            pIdent16.Value = NRegular
            DBCommand.SelectCommand.Parameters.Add(pIdent16)

            Dim pIdent17 As New SqlParameter("@Mantenimiento", SqlDbType.Bit)
            pIdent17.Value = Mantenimiento
            DBCommand.SelectCommand.Parameters.Add(pIdent17)

            Dim pIdent18 As New SqlParameter("@DiaHora", SqlDbType.Float)
            pIdent18.Value = DiasHoras
            DBCommand.SelectCommand.Parameters.Add(pIdent18)

            Dim pIdent19 As New SqlParameter("@Valor", SqlDbType.Float)
            pIdent19.Value = Valor
            DBCommand.SelectCommand.Parameters.Add(pIdent19)

            Dim pIdent20 As New SqlParameter("@Comentarios", SqlDbType.NVarChar)
            pIdent20.Value = Comentarios
            DBCommand.SelectCommand.Parameters.Add(pIdent20)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

        End Function

        Public Shared Sub Update(ByVal Codigo As String, ByVal Empleado As String, _
                ByVal Fecha As DateTime, ByVal FInicio As DateTime, _
                ByVal Monto As Double, ByVal TipoIngreso As String, ByVal Cancelado As Boolean, _
                ByVal Moneda As String, ByVal Unico As Boolean, ByVal NRegular As Boolean, _
                ByVal Mantenimiento As Boolean, ByVal DiasHoras As Double, ByVal Valor As Double, _
                ByVal Comentarios As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_IngresoUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            pIdent2.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Dim pIdent3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            pIdent3.Value = Empleado
            DBCommand.SelectCommand.Parameters.Add(pIdent3)


            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            pIdent4.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Dim pIdent5 As New SqlParameter("@FInicio", SqlDbType.DateTime)
            pIdent5.Value = FInicio
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Dim pIdent6 As New SqlParameter("@Monto", SqlDbType.Money)
            pIdent6.Value = Monto
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            Dim pIdent10 As New SqlParameter("@TipoIngreso", SqlDbType.NVarChar)
            pIdent10.Value = TipoIngreso
            DBCommand.SelectCommand.Parameters.Add(pIdent10)

            Dim pIdent13 As New SqlParameter("@Cancelado", SqlDbType.Bit)
            pIdent13.Value = Cancelado
            DBCommand.SelectCommand.Parameters.Add(pIdent13)

            Dim pIdent14 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            pIdent14.Value = Moneda
            DBCommand.SelectCommand.Parameters.Add(pIdent14)

            Dim pIdent15 As New SqlParameter("@Unico", SqlDbType.Bit)
            pIdent15.Value = Unico
            DBCommand.SelectCommand.Parameters.Add(pIdent15)

            Dim pIdent16 As New SqlParameter("@NRegular", SqlDbType.Bit)
            pIdent16.Value = NRegular
            DBCommand.SelectCommand.Parameters.Add(pIdent16)

            Dim pIdent17 As New SqlParameter("@Mantenimiento", SqlDbType.Bit)
            pIdent17.Value = Mantenimiento
            DBCommand.SelectCommand.Parameters.Add(pIdent17)

            Dim pIdent18 As New SqlParameter("@DiaHora", SqlDbType.Float)
            pIdent18.Value = DiasHoras
            DBCommand.SelectCommand.Parameters.Add(pIdent18)

            Dim pIdent19 As New SqlParameter("@Valor", SqlDbType.Float)
            pIdent19.Value = Valor
            DBCommand.SelectCommand.Parameters.Add(pIdent19)

            Dim pIdent20 As New SqlParameter("@Comentarios", SqlDbType.NVarChar)
            pIdent20.Value = Comentarios
            DBCommand.SelectCommand.Parameters.Add(pIdent20)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub Cancelar(ByVal Codigo As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_IngresoCancelar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo

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

        Public Shared Sub IngresoAguinaldo(ByVal Codigo As String, ByVal Empleado As String, _
               ByVal Fecha As DateTime, ByVal FInicio As DateTime, ByVal Dias As Double, _
               ByVal Monto As Double, ByVal TipoIngreso As String, ByVal Cancelado As Boolean, _
               ByVal Moneda As String, ByVal Unico As Boolean, ByVal Periodo As String, _
               ByVal TPeriodo As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_IngresoAguinaldoAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@FechaInicio", SqlDbType.DateTime)
            Dim pIdent13 As New SqlParameter("@Dias", SqlDbType.Float)
            Dim pIdent6 As New SqlParameter("@Monto", SqlDbType.Money)
            Dim pIdent7 As New SqlParameter("@TipoIngreso", SqlDbType.NVarChar)
            'Dim pIdent8 As New SqlParameter("@Cancelado", SqlDbType.Bit)
            Dim pIdent9 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            'Dim pIdent10 As New SqlParameter("@Unico", SqlDbType.Bit)
            Dim pIdent11 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Empleado
            pIdent4.Value = Fecha
            pIdent5.Value = FInicio
            pIdent6.Value = Monto
            pIdent7.Value = TipoIngreso
            'pIdent8.Value = Cancelado
            pIdent9.Value = Moneda
            'pIdent10.Value = Unico
            pIdent11.Value = Periodo
            pIdent12.Value = TPeriodo
            pIdent13.Value = Dias

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            'DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            'DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)

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

