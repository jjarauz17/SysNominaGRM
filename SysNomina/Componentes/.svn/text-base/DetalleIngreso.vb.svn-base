Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class DetalleIngresoDetails

        Public Codigo As String
        Public NCuota As Integer
        Public ValorCuota As Double
        Public Aplicado As Boolean
        Public Periodo As String
        Public TipoPeriodo As String
        Public Fecha As Date

    End Class

    Public Class DetalleIngresoDB

      

        Public Function GetDetails(ByVal Codigo As String, ByVal NCuota As String) As DetalleIngresoDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Details As New DetalleIngresoDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDetalleIngresoDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Cuota", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            pIdent3.Value = NCuota
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "DetalleDeduccion")

            If dsFicha.Tables("Deduccion").Rows.Count = 1 Then

                Details.Codigo = dsFicha.Tables("DetalleIngreso").Rows(0).Item("ing_codigo")
                Details.NCuota = dsFicha.Tables("DetalleIngreso").Rows(0).Item("ing_numcta")
                Details.ValorCuota = dsFicha.Tables("DetalleIngreso").Rows(0).Item("ing_valorcta")
                Details.Aplicado = dsFicha.Tables("DetalleIngreso").Rows(0).Item("ing_aplicado")
                Details.Fecha = dsFicha.Tables("DetalleIngreso").Rows(0).Item("ing_fecha")
                Details.Periodo = dsFicha.Tables("DetalleIngreso").Rows(0).Item("per_codigo")
                Details.TipoPeriodo = dsFicha.Tables("DetalleIngreso").Rows(0).Item("per_tipo")

            End If

            Return Details

        End Function

        Public Shared Function GetList(ByVal Codigo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDetalleIngreso", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)


            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "DetalleIngreso")


            Return dsFicha

        End Function



        Public Function GetListCodigoNvo(ByVal Codigo As String) As Integer
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDetalleIngresoNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)


            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            DBCommand.Fill(dsFicha, "DetalleIngreso")

            If dsFicha.Tables("DetalleIngreso").Rows(0)("Codigo") Is DBNull.Value Then
                Return 1
            Else
                Return dsFicha.Tables("DetalleIngreso").Rows(0)("Codigo")
            End If
        End Function

        Public Sub UpdateCtaFecha(ByVal Codigo As String, _
            ByVal NCuota As Integer, _
            ByVal Fecha As DateTime, _
            ByVal Monto As Double)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DetalleIngresoUpdateCtaFecha", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Ncuota", SqlDbType.Int)
            Dim pIdent4 As New SqlParameter("@Monto", SqlDbType.Money)
            Dim pIdent5 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = NCuota
            pIdent4.Value = Monto
            pIdent5.Value = Fecha

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

        Public Sub Aplicar(ByVal Codigo As String, ByVal NCuota As Integer)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DetalleIngresoAplicar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Ncuota", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = NCuota

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

        Public Sub delete(ByVal Codigo As String)
        End Sub

        Public Sub Additem(ByVal Codigo As String, _
                ByVal NCuota As Integer, _
                ByVal ValorCuota As Double, ByVal Fecha As DateTime, _
                ByVal Periodo As String, _
                ByVal TPeriodo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DetalleIngresoAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Ncuota", SqlDbType.Int)
            Dim pIdent4 As New SqlParameter("@ValorCuota", SqlDbType.Money)
            Dim pIdent5 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent6 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = NCuota
            pIdent4.Value = ValorCuota
            pIdent5.Value = Fecha
            pIdent6.Value = Periodo
            pIdent7.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
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



        Public Sub Update(ByVal Codigo As String, ByVal Empleado As String, _
                ByVal Fecha As DateTime, ByVal FInicio As DateTime, _
                ByVal Monto As Double, ByVal Saldo As Double, _
                ByVal NCuotas As Integer, ByVal ValorCuota As Double, _
                ByVal TipoDeduccion As String, ByVal Deducir As Boolean, _
                ByVal CtaFija As Boolean, ByVal Cancelado As Boolean, _
                ByVal Moneda As String)


        End Sub

    End Class

End Namespace
