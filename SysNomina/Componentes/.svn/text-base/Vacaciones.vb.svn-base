Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Namespace VB.SysContab
    Public Class VacacionesDetails
        Public Empleado As String
        Public Nombre As String
        Public Acumulado As Long
        Public Dias As Long
        Public APagar As Long
    End Class

    Public Class VacacionesDB


        Public Function GetList(ByVal Empleado As String, ByVal Desde As DateTime, _
            ByVal Hasta As DateTime, ByVal Todos As Boolean, ByVal Periodo As String, ByVal TPeriodo As String, _
            ByVal Ultimo As Boolean, ByVal DiasDigitados As Decimal) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListVacaciones", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@_Desde", SqlDbType.DateTime)
            Dim pIdent4 As New SqlParameter("@_Hasta", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@Todos", SqlDbType.Bit)
            Dim pident6 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pident7 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Ultimo", SqlDbType.Bit)
            Dim pIdent9 As New SqlParameter("@DiasDigitados", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Desde
            pIdent4.Value = Hasta
            pIdent5.Value = Todos
            pident6.Value = Periodo
            pident7.Value = TPeriodo
            pIdent8.Value = Ultimo
            pIdent9.Value = DiasDigitados

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pident6)
            DBCommand.SelectCommand.Parameters.Add(pident7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)

            Try
                DBCommand.Fill(dsFicha, "Vacaciones")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            Return dsFicha

        End Function

        'Public Function GetDetails(ByVal Empleado As String, ByVal Desde As String, _
        '    ByVal Hasta As String) As VacacionesDetails
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()
        '    Dim Details As New VB.SysContab.VacacionesDetails()



        '    DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_GetListVacaciones", DBConn)
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
        '    Dim pIdent3 As New SqlParameter("@Desde", SqlDbType.NVarChar)
        '    Dim pIdent4 As New SqlParameter("@Hasta", SqlDbType.NVarChar)
        '    Dim pIdent5 As New SqlParameter("@Todos", SqlDbType.Bit)

        '    pIdent.Value = EmpresaActual
        '    pIdent2.Value = Empleado
        '    pIdent3.Value = Desde
        '    pIdent4.Value = Hasta
        '    pIdent5.Value = 0

        '    DBCommand.SelectCommand.Parameters.Add(pIdent)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent2)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent3)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent4)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent5)

        '    DBCommand.Fill(dsFicha, "Vacaciones")

        '    If dsFicha.Tables("Vacaciones").Rows.Count = 1 Then
        '        Details.Empleado = dsFicha.Tables("Vacaciones").Rows(0).Item("Codigo")
        '        Details.Nombre = dsFicha.Tables("Vacaciones").Rows(0).Item("Nombre")
        '        Details.Acumulado = dsFicha.Tables("Vacaciones").Rows(0).Item("Acumulado")
        '        Details.Dias = dsFicha.Tables("Vacaciones").Rows(0).Item("Dias")
        '        Details.APagar = dsFicha.Tables("Vacaciones").Rows(0).Item("APagar")
        '    End If
        '    Return Details
        'End Function

        Public Sub AddVacaciones(ByVal Empleado As String, _
            ByVal Periodo As String, ByVal TPeriodo As String, _
            ByVal Desde As String, ByVal Hasta As String, _
            ByVal Acumulado As Double, ByVal Dias As Double, ByVal vDias As Double, _
            ByVal APagar As Double, ByVal VAPagar As Double, ByVal VacPago As Boolean)


            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            'DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_VacacionesAdd", DBConnexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Desde", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Hasta", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Acumulado", SqlDbType.Float)
            Dim pIdent8 As New SqlParameter("@Dias", SqlDbType.Float)
            Dim pIdent11 As New SqlParameter("@VDias", SqlDbType.Money)
            Dim pIdent9 As New SqlParameter("@APagar", SqlDbType.Float)
            Dim pIdent10 As New SqlParameter("@VAPagar", SqlDbType.Money)
            Dim pIdent12 As New SqlParameter("@vac_Pago", SqlDbType.Bit)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Periodo
            pIdent4.Value = TPeriodo
            pIdent5.Value = Desde
            pIdent6.Value = Hasta
            pIdent7.Value = Math.Round(Acumulado, 2)
            pIdent8.Value = Math.Round(Dias, 2)
            pIdent11.Value = Math.Round(vDias, 2)
            pIdent9.Value = Math.Round(APagar, 2)
            pIdent10.Value = Math.Round(VAPagar, 2)
            pIdent12.Value = VacPago

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)

            DBCommand.SelectCommand.Transaction = transaccion
            DBCommand.SelectCommand.ExecuteNonQuery()

            'Try
            '    'Se asigna conexion al comando y se abre conexion 
            '    DBConn.Open()
            '    DBCommand.SelectCommand.ExecuteNonQuery()
            '    DBConn.Close()

            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

        End Sub

        Public Sub Aplicar(ByVal Periodo As String, ByVal TPeriodo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_VacacionesAplicar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent3.Value = Periodo
            pIdent4.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
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
    End Class
End Namespace

