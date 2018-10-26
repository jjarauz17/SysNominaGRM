Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab

    Public Class Tasa_CambioDetails
        Public MonedaBase As String
        Public MonedaCambio As String
        Public Dia As Integer
        Public Mes As Integer
        Public Año As Integer
        Public Fecha As Date
        Public Valor As Double
    End Class

    Public Class Tasa_CambioDB

        Public Shared Function GetAnios() As DataTable
            Dim v As New Connect(Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

            Try
                Return v.EjecutarComando("_RH_GetAnios", "Anios")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Shared Function TasaCambioDia(ByVal Dia As Integer, ByVal Mes As Integer, ByVal Anio As Integer, ByVal Moneda1 As String, ByVal Moneda2 As String) As Double
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TasaCambioDia", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Dia As New SqlParameter("@Dia", SqlDbType.Int)
            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim _Anio As New SqlParameter("@Anio", SqlDbType.Int)
            Dim _Moneda1 As New SqlParameter("@Moneda1", SqlDbType.Int)
            Dim _Moneda2 As New SqlParameter("@Moneda2", SqlDbType.Int)
            Dim _Cambio As New SqlParameter("@Cambio", SqlDbType.Float)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Dia.Value = Dia
            _Mes.Value = Mes
            _Anio.Value = Anio
            _Moneda1.Value = Moneda1
            _Moneda2.Value = Moneda2
            _Cambio.Direction = ParameterDirection.Output
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Dia)
            DBCommand.SelectCommand.Parameters.Add(_Mes)
            DBCommand.SelectCommand.Parameters.Add(_Anio)
            DBCommand.SelectCommand.Parameters.Add(_Moneda1)
            DBCommand.SelectCommand.Parameters.Add(_Moneda2)
            DBCommand.SelectCommand.Parameters.Add(_Cambio)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tasa_Cambio")

            DBConn.Close()

            If _Cambio.Value Is DBNull.Value Then
                Return 1
            Else
                Return _Cambio.Value
            End If

        End Function

        Public Shared Function GetTasaCambioMes(ByVal Mes As String, ByVal Anio As String, ByVal Moneda1 As String, ByVal Moneda2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetTasaCambioMes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Moneda1", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Moneda2", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Mes
            pIdent2.Value = Anio
            pIdent3.Value = Moneda1
            pIdent4.Value = Moneda2
            pIdent5.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            DBCommand.Fill(dsFicha, "Tasa_Cambio")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetTasaCambio(ByVal MonedaBase As String, ByVal MonedaCambio As String, _
            ByVal Fecha As Date) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetTasaCambio", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = MonedaBase
            pIdent3.Value = MonedaCambio
            pIdent4.Value = Fecha

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                DBCommand.Fill(dsFicha, "TCambio")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha
        End Function

        Public Function GetTasaCambioDia(ByVal Mes As String, ByVal Anio As String, ByVal Dia As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetTasaCambioDia", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Dia", SqlDbType.Int)

            pIdent.Value = Mes
            pIdent2.Value = Anio
            pIdent3.Value = Dia

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "Tasa_Cambio")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetListTasaCambioDisponibles() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTasaCambioDisponibles", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            DBCommand.Fill(dsFicha, "Tasa_Cambio")

            DBConn.Close()

            Return dsFicha
        End Function


        Public Function GetListReporte(ByVal Mes As String, ByVal Anio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTasaCambioReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Anio", SqlDbType.Int)

            pIdent.Value = Mes
            pIdent2.Value = Anio
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "DEPARTAMENTOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function GetDetails(ByVal MonedaBase As String, _
            ByVal MonedaCambio As String, _
            ByVal Dia As Integer, ByVal Mes As Integer, ByVal Año As Integer) As Tasa_CambioDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Details As New Tasa_CambioDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTasaCambioDetails", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Moneda1", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Moneda2", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Dia", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Anio", SqlDbType.Int)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = MonedaBase
            pIdent3.Value = MonedaCambio
            pIdent4.Value = Dia
            pIdent5.Value = Mes
            pIdent6.Value = Año

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            DBCommand.Fill(dsFicha, "TC")
            DBConn.Close()

            If dsFicha.Tables("TC").Rows.Count = 1 Then
                Details.MonedaBase = dsFicha.Tables("TC").Rows(0).Item("Mon_codigo")
                Details.MonedaCambio = dsFicha.Tables("TC").Rows(0).Item("Mon_codigo2")
                Details.Dia = dsFicha.Tables("TC").Rows(0).Item("Dia")
                Details.Mes = dsFicha.Tables("TC").Rows(0).Item("Mes")
                Details.Año = dsFicha.Tables("TC").Rows(0).Item("Anio")
                Details.Fecha = dsFicha.Tables("TC").Rows(0).Item("Fecha")
                Details.Valor = dsFicha.Tables("TC").Rows(0).Item("tasa_cambio")
            End If

            Return Details

        End Function


        'Public Function GetList(ByVal Mes As String, ByVal Anio As String) As DataSet
        'Dim DBConn As SqlConnection
        'Dim DBCommand As SqlDataAdapter
        'Dim dsFicha As New DataSet()

        ' 
        'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        'DBCommand = New SqlDataAdapter("SELECT DIA, TASA_CAMBIO AS [TASA DE CAMBIO] FROM TASA_CAMBIO WHERE MES = '" & Mes & "' AND ANIO = '" & Anio & "'", DBConn)
        'DBCommand.Fill(dsFicha, "TASA_CAMBIO")

        'DBConn.Close()

        'Return dsFicha


        'End Function


        Public Function GetList(ByVal MonedaBase As String, ByVal MonedaCambio As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTasaCambio", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Moneda1", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Moneda2", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = MonedaBase
            pIdent3.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "TC")
            DBConn.Close()
            Return dsFicha
        End Function



        Public Shared Sub Additem(ByVal MonedaBase As String, ByVal MonedaCambio As String, _
            ByVal Dia As String, ByVal Mes As String, ByVal Año As String, ByVal Tasa_Cambio As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TasaCambioAdd", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Moneda1", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Moneda2", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Dia", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pIdent7 As New SqlParameter("@Tasa_Cambio", SqlDbType.Money)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = MonedaBase
            pIdent3.Value = MonedaCambio
            pIdent4.Value = Dia
            pIdent5.Value = Mes
            pIdent6.Value = Año
            pIdent7.Value = Tasa_Cambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

            'Se asigna conexion al comando y se abre conexion 
            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub Update(ByVal MonedaBase As String, ByVal MonedaCambio As String, _
            ByVal Dia As String, ByVal Mes As String, ByVal Año As String, ByVal Tasa_Cambio As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TasaCambioUpdate", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Moneda1", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Moneda2", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Dia", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pIdent7 As New SqlParameter("@Tasa_Cambio", SqlDbType.Money)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = MonedaBase
            pIdent3.Value = MonedaCambio
            pIdent4.Value = Dia
            pIdent5.Value = Mes
            pIdent6.Value = Año
            pIdent7.Value = Tasa_Cambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

            'Se asigna conexion al comando y se abre conexion 
            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub delete(ByVal MonedaBase As String, ByVal MonedaCambio As String, _
            ByVal Dia As String, ByVal Mes As String, ByVal Año As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TasaCambioDelete", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Moneda1", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Moneda2", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Dia", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Anio", SqlDbType.Int)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = MonedaBase
            pIdent3.Value = MonedaCambio
            pIdent4.Value = Dia
            pIdent5.Value = Mes
            pIdent6.Value = Año


            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)


            'Se asigna conexion al comando y se abre conexion 
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
