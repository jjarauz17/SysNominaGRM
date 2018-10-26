Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class HorasExtrasDetails
        Public Empresa As String
        Public Empleado As String
        Public HexQuincena As String
        Public CantSolicitada As String
        Public CantAutorizada As String
        Public Autorizada As String
        Public EmpleadoAutoriza As String
        Public Aplicada As Boolean
    End Class

    Public Class HorasExtrasDB
        Public Shared Function HorasExtras(ByVal Moneda As String, _
                                                          ByVal Desde As String, ByVal Hasta As String) As DataSet

            ' Create Instance of Connection and Command Object
            Dim Conn As New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            Dim DBCommand As SqlDataAdapter = New SqlDataAdapter("_WPlanillaHorasExtras", Conn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(Empresa)

            Dim _Desde As SqlParameter = New SqlParameter("@desde", SqlDbType.NVarChar)
            _Desde.Value = Desde
            DBCommand.SelectCommand.Parameters.Add(_Desde)

            'If MesAnno = "0" Then
            Dim _Hasta As SqlParameter = New SqlParameter("@hasta", SqlDbType.NVarChar)
            _Hasta.Value = Hasta
            DBCommand.SelectCommand.Parameters.Add(_Hasta)

            Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar)
            _Moneda.Value = Moneda
            DBCommand.SelectCommand.Parameters.Add(_Moneda)

            Dim dsFicha As New DataSet

            DBCommand.Fill(dsFicha, "Tabla")

            Conn.Close()
            ' Return the datareader result
            Return dsFicha

        End Function
        Public Shared Function GetListReporte(ByVal Empleado As String, ByVal Quincena As String, _
            ByVal Departamento As String, ByVal Area As String, ByRef Moneda As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListHorasExtras_Reporte", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Hex_Quincena", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Area", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Moneda", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = IIf(Departamento = "", "%", Departamento)
            pIdent3.Value = IIf(Quincena = "", "%", Quincena)
            pIdent4.Value = IIf(Empleado = "", "%", Empleado)
            pIdent5.Value = IIf(Area = "", "%", Area)
            pIdent6.Value = Moneda

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)

            DBCommand.Fill(dsFicha, "RHorasExtras")

            Return dsFicha
        End Function

        Public Shared Function GetDetails(ByVal Empleado As String, ByVal HexQuincena As String) As HorasExtrasDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Details As New HorasExtrasDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListHorasExtrasDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@HexQuincena", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = HexQuincena

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "HorasExtras")

            If dsFicha.Tables("HorasExtras").Rows.Count = 1 Then
                Details.Empresa = dsFicha.Tables("HorasExtras").Rows(0).Item("empr_codigo")
                Details.Empleado = dsFicha.Tables("HorasExtras").Rows(0).Item("emp_codigo")
                Details.HexQuincena = dsFicha.Tables("HorasExtras").Rows(0).Item("hex_quincena")
                Details.CantSolicitada = dsFicha.Tables("HorasExtras").Rows(0).Item("hex_cantsolic")
                Details.CantAutorizada = dsFicha.Tables("HorasExtras").Rows(0).Item("hex_cantauto")
                Details.Autorizada = dsFicha.Tables("HorasExtras").Rows(0).Item("hex_autorizada")
                Details.EmpleadoAutoriza = dsFicha.Tables("HorasExtras").Rows(0).Item("hex_empauto")
                Details.Aplicada = dsFicha.Tables("HorasExtras").Rows(0).Item("hex_aplicada")
            End If

            Return Details

        End Function

        Public Shared Function GetListDepto(ByVal Departamento As String, ByVal Empleado As String, ByVal HexQuincena As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Details As New HorasExtrasDetails()

            'Encabezado
            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListHEDepto", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@HexQuincena", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = IIf(Departamento = "", "%", Departamento)
            pIdent3.Value = HexQuincena

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "HorasExtras")

            'Detalle
            DBCommand = New SqlDataAdapter("_GetListHEDepto_Detalle", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pEmpleado As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pQuincena As New SqlParameter("@Quincena", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pEmpleado.Value = Empleado
            pDepartamento.Value = Departamento
            pQuincena.Value = HexQuincena

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pEmpleado)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pQuincena)

            DBCommand.Fill(dsFicha, "DetalleHorasExtras")

            dsFicha.Relations.Add("Detalle", dsFicha.Tables("HorasExtras").Columns("Empleado"), _
                dsFicha.Tables("DetalleHorasExtras").Columns("Empleado"))
            Return dsFicha

        End Function


        Public Shared Sub delete(ByVal Empleado As String, ByVal HexQuincena As String, ByVal prueba As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_HorasExtrasDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@HexQuincena", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = HexQuincena
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Shared Sub DeleteQuincena(ByVal HexQuincena As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_HorasExtrasQuincenaDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@HexQuincena", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent3.Value = HexQuincena
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Sub
        Public Shared Sub Additem(ByVal Empleado As String, ByVal HexQuincena As String, _
                                ByVal CantSolicitada As String, ByVal Desde As String, ByVal Hasta As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_HorasExtrasAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Hexquincena", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@CantSolicitada", SqlDbType.Float)
            Dim pIdent5 As New SqlParameter("@CantAutorizada", SqlDbType.Float)
            Dim pIdent6 As New SqlParameter("@Autorizada", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@EmpleadoAutoriza", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@hex_desde", SqlDbType.SmallDateTime)
            Dim pIdent9 As New SqlParameter("@hex_hasta", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = HexQuincena
            pIdent4.Value = CantSolicitada
            pIdent5.Value = 0
            pIdent6.Value = False
            pIdent7.Value = ""
            pIdent8.Value = Desde
            pIdent9.Value = Hasta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub




        Public Shared Sub Update(ByVal Empleado As String, ByVal HexQuincena As String, _
                                ByVal CantSolicitada As String, ByVal CantAutorizada As String, _
                                ByVal EmpleadoAutoriza As String, ByVal prueba As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_HorasExtrasUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Hexquincena", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@CantSolicitada", SqlDbType.Float)
            Dim pIdent5 As New SqlParameter("@CantAutorizada", SqlDbType.Float)
            Dim pIdent6 As New SqlParameter("@Autorizada", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@EmpleadoAutoriza", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = HexQuincena
            pIdent4.Value = CantSolicitada
            pIdent5.Value = CantAutorizada
            pIdent6.Value = True
            pIdent7.Value = EmpleadoAutoriza

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

        Public Shared Sub Aplicar(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_HorasExtrasAplicar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Hexquincena", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent3.Value = Codigo


            DBCommand.SelectCommand.Parameters.Add(pIdent)
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
        Public Shared Sub AutoTodasDepto(ByVal HexQuincena As String, ByVal Departamento As String, ByVal EmpleadoAutoriza As String, ByVal Autorizar As Boolean)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_HorasExtrasAutTodasDepto", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Hexquincena", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Autorizar", SqlDbType.Bit)
            Dim pIdent5 As New SqlParameter("@EmpAutoriza", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = HexQuincena
            pIdent4.Value = Autorizar
            pIdent5.Value = EmpleadoAutoriza

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

        Public Shared Sub AutoEmpleadoDepto(ByVal HexQuincena As String, _
            ByVal Departamento As String, ByVal EmpleadoAutoriza As String, _
            ByVal Autorizar As Boolean, ByVal Empleado As String, ByVal CAutorizada As Double)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_HorasExtrasAut", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Hexquincena", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Autorizar", SqlDbType.Bit)
            Dim pIdent5 As New SqlParameter("@EmpAutoriza", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@cAutorizada", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Departamento
            pIdent3.Value = HexQuincena
            pIdent4.Value = Autorizar
            pIdent5.Value = EmpleadoAutoriza
            pIdent6.Value = Empleado
            pIdent7.Value = CAutorizada

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

        Public Shared Sub UpdateSuma(ByVal Empleado As String, ByVal HexQuincena As String, _
                                ByVal Cantidad As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_HorasExtrasSum", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Hexquincena", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Cantidad", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = HexQuincena
            pIdent4.Value = Cantidad

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

    End Class

End Namespace
