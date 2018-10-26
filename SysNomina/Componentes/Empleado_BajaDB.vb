Imports DbConnect
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Namespace VB.SysContab
    Public Class CausasDespidoDetails
        Public Codigo As Integer
        Public Descripcion As String
        Public Vacaciones As Boolean
        Public Aguinaldo As Boolean
        Public Indemnizacion As Boolean
        Public Tipo_Contrato As String
    End Class

    Public Class CausasDespidoDB
        Public Shared Function Lista(ByVal Codigo As Integer, ByVal TipoContrato As String) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            v.AddParameter("tipocontrato", SqlDbType.NVarChar, 1, ParameterDirection.Input, TipoContrato)
            Try
                Return v.EjecutarComando("_RH_CausasDepidoList", "Tabla")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function Detalles(ByVal Codigo As Integer, ByVal tipoContrato As String) As CausasDespidoDetails
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("codigo", SqlDbType.Int, 5, ParameterDirection.Input, Codigo)
            v.AddParameter("tipocontrato", SqlDbType.NVarChar, 1, ParameterDirection.Input, tipoContrato)

            Try
                Dim dt As New DataTable
                dt = v.EjecutarComando("_RH_CausasDepidoList", "Tabla")
                If Not dt Is Nothing Then
                    If dt.Rows.Count = 1 Then
                        Dim d As New CausasDespidoDetails
                        d.Codigo = dt.Rows(0)("id")
                        d.Descripcion = dt.Rows(0)("descripcion")
                        d.Vacaciones = dt.Rows(0)("vacaciones")
                        d.Aguinaldo = dt.Rows(0)("aguinaldo")
                        d.Indemnizacion = dt.Rows(0)("indemnizacion")
                        d.Tipo_Contrato = dt.Rows(0)("tipo_contrato")
                        Return d
                    Else
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return Nothing
        End Function

    End Class

    Public Class Empleado_Baja
        Public Empresa As String
        Public Empleado As String
        Public Fecha_Baja As Date
        Public Razon_Baja As String
        Public FormaPago As String
        Public Ingresado As Boolean
        Public Razon_Ingreso As String
        Public Revisado As Boolean
        Public Revisado_Denegado As Boolean
        Public Razon_Revisado As String
        Public Aprobado As Boolean
        Public Aprobado_Denegado As Boolean
        Public Razon_Aprobado As String
        Public Fecha_Liquidacion As String
        Public Indemnizacion As Boolean
        Public Causa As Boolean ''Si se paga la indemnizacion o no
        Public Motivo As Integer
    End Class

    Public Class Empleado_BajaDB

        Public Function GetList(ByVal Ingresado As Boolean, ByVal Revisado As String, _
            ByVal DRevisado As String, ByVal Aprobado As String, ByVal DAprobado As String, _
            ByVal Liquidado As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_Empleado_Baja", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@Ingresado", SqlDbType.Bit)
            Dim pIdent2 As New SqlParameter("@Revisado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@DRevisado", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Aprobado", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@DAprobado", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Liquidado", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent1.Value = Ingresado
            pIdent2.Value = Revisado
            pIdent3.Value = DRevisado
            pIdent4.Value = Aprobado
            pIdent5.Value = DAprobado
            pIdent6.Value = Liquidado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            Try
                DBCommand.Fill(dsFicha, "Empleado_Baja")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Empleado As String, ByVal Fecha As Date) As Empleado_Baja
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Detalle As New VB.SysContab.Empleado_Baja()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetDetails_Empleado_Baja", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent1.Value = Empleado
            pIdent2.Value = Fecha

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBCommand.Fill(dsFicha, "Empleado_Baja")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
                Exit Function
            End Try
            DBConn.Close()

            If dsFicha.Tables("Empleado_baja").Rows.Count = 1 Then
                Detalle.Empresa = dsFicha.Tables("Empleado_baja").Rows(0)("empr_codigo")
                Detalle.Empleado = dsFicha.Tables("Empleado_baja").Rows(0)("emp_codigo")
                Detalle.Fecha_Baja = dsFicha.Tables("Empleado_baja").Rows(0)("baj_fecha")
                Detalle.Razon_Baja = dsFicha.Tables("Empleado_baja").Rows(0)("baj_razon")
                Detalle.FormaPago = dsFicha.Tables("Empleado_baja").Rows(0)("baj_formapago")
                Detalle.Ingresado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_ingresado")
                Detalle.Razon_Ingreso = dsFicha.Tables("Empleado_baja").Rows(0)("baj_razoningreso")
                Detalle.Revisado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_revisado")
                Detalle.Revisado_Denegado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_revisadodenegado")
                Detalle.Razon_Revisado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_razonrevisado")
                Detalle.Aprobado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_aprobado")
                Detalle.Aprobado_Denegado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_aprobadodenegado")
                Detalle.Razon_Aprobado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_razonaprobado")
                Detalle.Fecha_Liquidacion = dsFicha.Tables("Empleado_baja").Rows(0)("baj_fliquidacion").ToString
                Detalle.Indemnizacion = dsFicha.Tables("Empleado_baja").Rows(0)("Indemnizacion")
                Detalle.Causa = dsFicha.Tables("Empleado_baja").Rows(0)("Causa")
                Detalle.Motivo = dsFicha.Tables("Empleado_baja").Rows(0)("Motivo")
            End If
            Return Detalle
        End Function

        Public Function GetDetails_last(ByVal Empleado As String) As Empleado_Baja
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Detalle As New VB.SysContab.Empleado_Baja()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetDetails_Empleado_BajaLast", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent1 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent1.Value = Empleado

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Try
                DBCommand.Fill(dsFicha, "Empleado_Baja")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
                Exit Function
            End Try
            DBConn.Close()

            If dsFicha.Tables("Empleado_baja").Rows.Count = 1 Then
                Detalle.Empresa = dsFicha.Tables("Empleado_baja").Rows(0)("empr_codigo")
                Detalle.Empleado = dsFicha.Tables("Empleado_baja").Rows(0)("emp_codigo")
                Detalle.Fecha_Baja = dsFicha.Tables("Empleado_baja").Rows(0)("baj_fecha")
                Detalle.Razon_Baja = dsFicha.Tables("Empleado_baja").Rows(0)("baj_razon")
                Detalle.FormaPago = dsFicha.Tables("Empleado_baja").Rows(0)("baj_formapago")
                Detalle.Ingresado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_ingresado")
                Detalle.Razon_Ingreso = dsFicha.Tables("Empleado_baja").Rows(0)("baj_razoningreso")
                Detalle.Revisado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_revisado")
                Detalle.Revisado_Denegado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_revisadodenegado")
                Detalle.Razon_Revisado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_razonrevisado")
                Detalle.Aprobado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_aprobado")
                Detalle.Aprobado_Denegado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_aprobadodenegado")
                Detalle.Razon_Aprobado = dsFicha.Tables("Empleado_baja").Rows(0)("baj_razonaprobado")
                Detalle.Fecha_Liquidacion = dsFicha.Tables("Empleado_baja").Rows(0)("baj_fliquidacion").ToString
                Detalle.Indemnizacion = dsFicha.Tables("Empleado_baja").Rows(0)("Indemnizacion")
                Detalle.Causa = dsFicha.Tables("Empleado_baja").Rows(0)("Causa")
                Detalle.Motivo = dsFicha.Tables("Empleado_baja").Rows(0)("Motivo")
            End If
            Return Detalle
        End Function
        Public Shared Sub Additem(ByVal Codigo As String, ByVal Fecha As Date, _
            ByVal RazonBaja As String, ByVal FormaPago As String, _
            ByVal RazonIngreso As String, ByVal Indemnizacion As Boolean, _
            ByVal Causa As Boolean, ByVal Motivo As Integer)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_Empleado_BajaAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@RazonBaja", SqlDbType.Text)
            Dim pIdent5 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@RazonIngreso", SqlDbType.Text)
            Dim pIdent7 As New SqlParameter("@Indemnizacion", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Causa", SqlDbType.Int)
            pIdent8.Value = Causa
            DBCommand.SelectCommand.Parameters.Add(pIdent8)

            Dim pIdent9 As New SqlParameter("@Motivo", SqlDbType.Int)
            pIdent9.Value = Motivo
            DBCommand.SelectCommand.Parameters.Add(pIdent9)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Fecha
            pIdent4.Value = RazonBaja
            pIdent5.Value = FormaPago
            pIdent6.Value = RazonIngreso
            pIdent7.Value = Indemnizacion

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

        Public Sub UpdateItem(ByVal Codigo As String, ByVal Fecha As Date, _
           ByVal RazonBaja As String, ByVal FormaPago As String, _
           ByVal RazonIngreso As String, ByVal Indemnizacion As Boolean, _
           ByVal Causa As Boolean, ByVal Motivo As Integer)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_Empleado_BajaUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@RazonBaja", SqlDbType.Text)
            Dim pIdent5 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@RazonIngreso", SqlDbType.Text)
            Dim pIdent7 As New SqlParameter("@Indemnizacion", SqlDbType.Bit)

            Dim pIdent8 As New SqlParameter("@Causa", SqlDbType.Int)
            pIdent8.Value = Causa
            DBCommand.SelectCommand.Parameters.Add(pIdent8)

            Dim pIdent9 As New SqlParameter("@Motivo", SqlDbType.Int)
            pIdent9.Value = Motivo
            DBCommand.SelectCommand.Parameters.Add(pIdent9)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Fecha
            pIdent4.Value = RazonBaja
            pIdent5.Value = FormaPago
            pIdent6.Value = RazonIngreso
            pIdent7.Value = Indemnizacion

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
        Public Shared Sub Revision(ByVal Codigo As String, ByVal Fecha As Date, _
           ByVal RazonRevision As String, ByVal Aprobado As Boolean, ByVal Denegado As Boolean, _
        ByVal Indemnizacion As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_Empleado_BajaRevision", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@RazonRevision", SqlDbType.Text)
            Dim pIdent5 As New SqlParameter("@Revisado", SqlDbType.Bit)
            Dim pIdent6 As New SqlParameter("@DRevisado", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@Indemnizacion", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Fecha
            pIdent4.Value = RazonRevision
            pIdent5.Value = Aprobado
            pIdent6.Value = Denegado
            pIdent7.Value = Indemnizacion

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

        Public Shared Sub Aprobacion(ByVal Codigo As String, ByVal Fecha As Date, _
           ByVal RazonAprobacion As String, ByVal Aprobado As Boolean, _
           ByVal Denegado As Boolean, ByVal Indemnizacion As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_Empleado_BajaAprobacion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@RazonAprobacion", SqlDbType.Text)
            Dim pIdent5 As New SqlParameter("@Aprobado", SqlDbType.Bit)
            Dim pIdent6 As New SqlParameter("@DAprobado", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@Indemnizacion", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Fecha
            pIdent4.Value = RazonAprobacion
            pIdent5.Value = Aprobado
            pIdent6.Value = Denegado
            pIdent7.Value = Indemnizacion

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
        Public Sub delete(ByVal Codigo As String, ByVal FEcha As Date)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_Empleado_BajaDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)

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
    End Class
End Namespace

