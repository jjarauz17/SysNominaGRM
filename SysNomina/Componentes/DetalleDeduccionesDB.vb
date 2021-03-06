Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab

    Public Class DetalleDeduccionDetails

        Public Codigo As String
        Public NCuota As Integer
        Public ValorCuota As Double
        Public Aplicado As Boolean
        Public Periodo As String
        Public TipoPeriodo As String
        Public Fecha As Date

    End Class

    Public Class DetalleDeduccionDB

        'Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet

        'End Function

        Public Function GetDetails(ByVal Codigo As String, ByVal NCuota As String) As VB.SysContab.DetalleDeduccionDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Details As New DetalleDeduccionDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDetalleDeduccionDetails", DBConn)
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

                Details.Codigo = dsFicha.Tables("DetalleDeduccion").Rows(0).Item("ptm_codigo")
                Details.NCuota = dsFicha.Tables("DetalleDeduccion").Rows(0).Item("ptm_numcta")
                Details.ValorCuota = dsFicha.Tables("DetalleDeduccion").Rows(0).Item("ptm_valorcta")
                Details.Aplicado = dsFicha.Tables("DetalleDeduccion").Rows(0).Item("ptm_aplicado")
                Details.Periodo = dsFicha.Tables("DetalleDeduccion").Rows(0).Item("per_codigo")
                Details.Fecha = dsFicha.Tables("DetalleDeduccion").Rows(0).Item("ptm_fecha")
                Details.TipoPeriodo = dsFicha.Tables("DetalleDeduccion").Rows(0).Item("per_tipo")

            End If

            Return Details

        End Function

        Public Shared Function GetList(ByVal Codigo As String) As DataSet

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()



            'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_GetListDetalleDeduccion", DBConn)
            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)


            'pIdent.Value = Codigo
            'pIdent2.Value = EmpresaActual

            'DBCommand.SelectCommand.Parameters.Add(pIdent)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)
            'Try
            '    DBCommand.Fill(dsFicha, "DetalleDeduccion")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try



            'Return dsFicha

            Dim Tabla As New DataTable
            Dim dsFicha As New DataSet

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("Codigo", SqlDbType.NVarChar, 6, ParameterDirection.Input, Codigo)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Tabla = v.EjecutarComando("_GetListDetalleDeduccion", "DetalleDeduccion")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            v = Nothing
            dsFicha.Tables.Add(Tabla.Copy)
            Dim t As New Connect(VB.SysContab.Conexion.AbrirConexion)
            t.AddParameter("Codigo", SqlDbType.NVarChar, 6, ParameterDirection.Input, Codigo)
            t.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Tabla = t.EjecutarComando("_GetListDeduccion_Notas", "DetalleNotas")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            t = Nothing
            dsFicha.Tables.Add(Tabla.Copy)
            Tabla = Nothing
            dsFicha.Relations.Add("Notas", dsFicha.Tables("DetalleDeduccion").Columns("Codigo"), _
                dsFicha.Tables("DetalleNotas").Columns("Codigo"))

            Return dsFicha

        End Function

        Public Function GetListFiltro(ByVal Filtro As String, ByVal Unico As Boolean) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDetalleDeduccionFiltro", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Unico", SqlDbType.Bit)


            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            pIdent3.Value = Unico

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "DetalleDeduccion")


            Return dsFicha

        End Function



        Public Function GetListCodigoNvo(ByVal Codigo As String) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListDetalleDeduccionNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)


            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            DBCommand.Fill(dsFicha, "DetalleDeduccion")

            If dsFicha.Tables("DetalleDeduccion").Rows(0)("Codigo") Is DBNull.Value Then
                Return 1
            Else
                Return dsFicha.Tables("DetalleDeduccion").Rows(0)("Codigo")
            End If
        End Function


        'public sub delete(ByVal Codigo As String)
        'End Function

        Public Sub Additem(ByVal Codigo As String, _
                ByVal NCuota As Integer, _
                ByVal ValorCuota As Double, ByVal Fecha As DateTime, _
                ByVal Periodo As String, _
                ByVal TPeriodo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DetalleDeduccionAdd", DBConn)
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



        'public sub Update(ByVal Codigo As String, ByVal Empleado As String, _
        '        ByVal Fecha As DateTime, ByVal FInicio As DateTime, _
        '        ByVal Monto As Double, ByVal Saldo As Double, _
        '        ByVal NCuotas As Integer, ByVal ValorCuota As Double, _
        '        ByVal TipoDeduccion As String, ByVal Deducir As Boolean, _
        '        ByVal CtaFija As Boolean, ByVal Cancelado As Boolean, _
        '        ByVal Moneda As String) As Integer


        'End Function

        Public Function UpdateCtaFecha(ByVal Codigo As String, ByVal NCuota As Integer, _
                    ByVal Fecha As DateTime, ByVal ValorCuota As Double) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())


            DBCommand = New SqlDataAdapter("_DetalleDeduccionUpdateCtaFecha", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Ncuota", SqlDbType.Int)
            Dim pIdent4 As New SqlParameter("@ValorCuota", SqlDbType.Money)
            Dim pIdent5 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = NCuota
            pIdent4.Value = ValorCuota
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

        End Function

        Public Function Aplicar(ByVal Codigo As String, ByVal NCuota As Integer) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DetalleDeduccionAplicar", DBConn)
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

        End Function
    End Class

End Namespace
