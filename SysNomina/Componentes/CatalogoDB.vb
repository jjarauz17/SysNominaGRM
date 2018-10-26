Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab

    Public Class CatalogoDetails
        Public Cuenta As String
        Public Nombre As String
        Public Tipo As String
        Public Cuenta_De As String
        Public Saldo_Inicial As String
        Public Presupuesto_Anual As String
        Public Grupo As String
        Public Clase As String
        Public SubCuenta As String

    End Class

    Public Class CatalogoDB

        Public Shared Function Listar_RH_Catalogo(ByVal Grid As Boolean, ByRef Local As Boolean, Optional ByVal cuenta As String = "%")
            Dim dt As New DataTable

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, cuenta)
            v.AddParameter("grid", SqlDbType.Bit, 1, ParameterDirection.Input, Grid)
            v.AddParameter("local", SqlDbType.Bit, 1, ParameterDirection.InputOutput, Local)
            Try

                dt = v.EjecutarComando("_RH_Catalogo_List", "Tabla")
                Local = v.GetParameter("local").Valor
                Return dt
            Catch ex As Exception
                Return dt
            End Try
        End Function

        Public Shared Function Listar_RH_Rubros(ByVal Grid As Boolean, Optional ByVal Rubro As Integer = 0)

            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("rubro", SqlDbType.Int, 5, ParameterDirection.Input, Rubro)
            v.AddParameter("grid", SqlDbType.Bit, 1, ParameterDirection.Input, Grid)
            Try
                Return v.EjecutarComando("_RH_Rubros_List", "Tabla")
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Shared Sub Mantenimiento_RH_Catalogo(ByVal Cuenta As String, ByVal Nombre As String, Optional ByVal Borrar As Boolean = False)
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, Cuenta)
            v.AddParameter("nombre", SqlDbType.NVarChar, 500, ParameterDirection.Input, Nombre)
            v.AddParameter("borrar", SqlDbType.Bit, 1, ParameterDirection.Input, Borrar)
            Try
                v.EjecutarComando("_RH_Catalogo_Add")
            Catch ex As Exception

            End Try
        End Sub


        'Public Shared Function Listar(Optional ByVal cuenta As String = "%")

        '    Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        '    v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        '    v.AddParameter("cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, cuenta)
        '    Try
        '        Return v.EjecutarComando("_RH_Catalogo_Nomina", "Tabla")
        '    Catch ex As Exception
        '        Return Nothing
        '    End Try
        'End Function

        'Public Shared Sub Mantenimiento(ByVal Cuenta As String, ByVal Nombre As String, Optional ByVal Borrar As Boolean = False)
        '    Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)
        '    v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        '    v.AddParameter("cuenta", SqlDbType.NVarChar, 64, ParameterDirection.Input, Cuenta)
        '    v.AddParameter("nombre", SqlDbType.NVarChar, 100, ParameterDirection.Input, Nombre)
        '    v.AddParameter("borrar", SqlDbType.Bit, 1, ParameterDirection.Input, Borrar)
        '    Try
        '        v.EjecutarComando("_RH_Catalogo_Nomina_ADD")
        '    Catch ex As Exception

        '    End Try
        'End Sub


        '*******************************************************
        '-- FECHA: 21/DIC/2005
        '--AUTOR: BERNARDO ROBELO
        '--OBJETIVO: Lista los Acumulados del Catalogo: Por Cuenta
        '*******************************************************

        Public Function GetListMayores(ByVal Cuenta As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoMayoresListBusqueda", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        '-- FECHA: 21/DIC/2005
        '--AUTOR: BERNARDO ROBELO
        '--OBJETIVO: Lista los Acumulados del Catalogo
        '*******************************************************

        Public Function GetListMayores() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoMayoresList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetList_SP(ByVal filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCC", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            pIdent2.Value = EmpresaActual
            pIdent3.Value = filtro
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBCommand.Fill(dsFicha, "Catalogo")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()
            Return dsFicha
        End Function

        '*******************************************************
        '-- FECHA: 21/DIC/2005
        '--AUTOR: BERNARDO ROBELO
        '--OBJETIVO: Lista los Acumulados del Catalogo
        '*******************************************************

        Public Function GetListAcumulados(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())


            DBCommand = New SqlDataAdapter("_CatalogoAcumulados", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Codigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            _Codigo.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(_Codigo)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            Try
                DBCommand.Fill(dsFicha, "CATALOGO")
            Catch m As Exception
                MsgBox(m.Message)
            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigoBuscar(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CUENTA, NOMBRE, SUBCUENTA, SALDO_INICIAL, TIPO FROM CATALOGO WHERE CUENTA Like '%" & Filtro & "%' And Empresa = '" & Empresa & "'", DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        '-- FECHA: 17/NOV/2005
        '--AUTOR: BERNARDO ROBELO
        '--OBJETIVO: ACTUALIZAR EL CATALOGO DE CUENTAS
        '--DESCRIPCION: A partir de un numero de cuenta auxliar, un monto y una operacion (+ -) actualizar las subcuentas y principal
        '*******************************************************

        'Public Function ActualizarCuentas(ByVal Cuenta As String, ByVal Monto As String, _
        '                                    ByVal Operacion As Integer)

        '    ' Create Instance of Connection and Command Object
        '    Dim cmd As SqlCommand = New SqlCommand("_CatalogoActualizarCuentas", DBConnFacturas)

        '    ' Mark the Command as a SPROC
        '    cmd.CommandType = CommandType.StoredProcedure


        '    ' Add Parameters to SPROC
        '    Dim _UPCuenta As SqlParameter = New SqlParameter("@UPCuenta", SqlDbType.NVarChar)
        '    _UPCuenta.Value = Cuenta
        '    cmd.Parameters.Add(_UPCuenta)

        '    Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float)
        '    _Monto.Value = Monto
        '    cmd.Parameters.Add(_Monto)

        '    'OPERACION: 1 + SUMAR 2 - RESTAR
        '    Dim _Operacion As New SqlParameter("@Operacion", SqlDbType.Int)
        '    _Operacion.Value = Operacion
        '    cmd.Parameters.Add(_Operacion)

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    cmd.Parameters.Add(pEmpresa)

        '    ' Open the connection and execute the Command

        '    cmd.Connection = DBConnFacturas
        '    cmd.Transaction = transaccionFacturas
        '    cmd.ExecuteNonQuery()



        'End Function

        Public Function CatalogoList(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListAcumuladosCuenta(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListAcumuladosCuentaReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCodigo As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)


            pCodigo.Value = Codigo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Function GetListAcumulados(ByVal Codigo As String) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()

        '     
        '    DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        '    'DBCommand = New SqlDataAdapter("SELECT NOMBRE_MES AS MES, SUM(MONTO) AS MONTO, MES AS NUMERO_MES FROM ACUMULADOS WHERE CODIGO_CP ='" & Codigo & "' AND TIPO = '" & Tipo & "' AND EMPRESA = '" & EmpresaActual & "' GROUP BY CODIGO_CP, NOMBRE_MES, MES ORDER BY MES", DBConn)
        '    DBCommand = New SqlDataAdapter("SELECT MESES.MES, PRESUPUESTO, SUM(CATALOGO_ACUMULADOS.DEBE) AS DEBE, SUM(CATALOGO_ACUMULADOS.HABER) AS HABER, (SUM(CATALOGO_ACUMULADOS.DEBE) -  SUM(CATALOGO_ACUMULADOS.HABER)) AS SALDO, Catalogo.Cuenta, Catalogo.Nombre FROM MESES LEFT OUTER JOIN CATALOGO_ACUMULADOS ON MESES.MES = CATALOGO_ACUMULADOS.NOMBRE_MES INNER JOIN Catalogo ON CATALOGO_ACUMULADOS.Cuenta = Catalogo.Cuenta WHERE Catalogo.Cuenta = '" & Codigo & "' AND Catalogo.Empresa = '" & EmpresaActual & "' GROUP BY MESES.MES, MESES.NUMERO, PRESUPUESTO, Catalogo.Nombre, Catalogo.Cuenta ORDER BY Meses.Numero", DBConn)
        '    DBCommand.Fill(dsFicha, "CATALOGO_ACUMULADOS")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function


        Public Function GetListGeneradorReportes(ByVal Grupo As String, ByVal Mayor As String, ByVal SubCuenta As String, ByVal Auxiliar As String, ByVal Ordenar As String, ByVal Saldo As Integer, ByVal Mes As Integer, ByVal Moneda As Integer, ByVal TipoCambio As Double) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCatalogoGeneradorReportes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pGrupo As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pMayor As New SqlParameter("@Mayor", SqlDbType.NVarChar)
            Dim pSubCuenta As New SqlParameter("@SubCuenta", SqlDbType.NVarChar)
            Dim pAuxiliar As New SqlParameter("@Auxiliar", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pOrdenar As New SqlParameter("@Ordenar", SqlDbType.Int)
            Dim pSaldo As New SqlParameter("@Saldo", SqlDbType.Int)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.Int)
            Dim pTipoCambio As New SqlParameter("@TipoCambio", SqlDbType.Float)

            pGrupo.Value = Grupo
            pMayor.Value = Mayor
            pSubCuenta.Value = SubCuenta
            pAuxiliar.Value = Auxiliar
            pEmpresa.Value = EmpresaActual
            pOrdenar.Value = Ordenar
            pSaldo.Value = Saldo
            pMes.Value = Mes
            pMoneda.Value = Moneda
            pTipoCambio.Value = TipoCambio

            DBCommand.SelectCommand.Parameters.Add(pGrupo)
            DBCommand.SelectCommand.Parameters.Add(pMayor)
            DBCommand.SelectCommand.Parameters.Add(pSubCuenta)
            DBCommand.SelectCommand.Parameters.Add(pAuxiliar)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pOrdenar)
            DBCommand.SelectCommand.Parameters.Add(pSaldo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pMoneda)
            DBCommand.SelectCommand.Parameters.Add(pTipoCambio)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetDetails(ByVal Codigo As String) As CatalogoDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsCatalogo As New DataSet()
            Dim Details As New CatalogoDetails()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT * FROM Clientes WHERE Codigo = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT * FROM Catalogo WHERE Cuenta = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsCatalogo, "Catalogo")

            If dsCatalogo.Tables("Catalogo").Rows.Count = 1 Then
                Details.Cuenta = dsCatalogo.Tables("Catalogo").Rows(0).Item("Cuenta").ToString
                Details.Nombre = dsCatalogo.Tables("Catalogo").Rows(0).Item("Nombre").ToString
                Details.Tipo = dsCatalogo.Tables("Catalogo").Rows(0).Item("Tipo").ToString
                Details.Cuenta_De = dsCatalogo.Tables("Catalogo").Rows(0).Item("Cuenta_De").ToString
                Details.Grupo = dsCatalogo.Tables("Catalogo").Rows(0).Item("Grupo").ToString
                Details.Saldo_Inicial = dsCatalogo.Tables("Catalogo").Rows(0).Item("Saldo_Inicial").ToString
                Details.Presupuesto_Anual = dsCatalogo.Tables("Catalogo").Rows(0).Item("Presupuesto_Anual").ToString
                Details.Clase = dsCatalogo.Tables("Catalogo").Rows(0).Item("Clase").ToString
                Details.SubCuenta = dsCatalogo.Tables("Catalogo").Rows(0).Item("SubCuenta").ToString

            End If

            Return Details

        End Function

        Public Shared Function GetList(ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select '' as Cuenta, '--Seleccione--' as Nombre union all SELECT CATALOGO.CUENTA AS Cuenta, CATALOGO.CUENTA + '-' + CATALOGO.NOMBRE AS Nombre " & _
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO Where EMPRESAS.CODIGO = '" & Empresa & "' ORDER BY CUENTA", DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha


        End Function

        ''''Public Function GetList() As DataSet

        ''''    ' Create Instance of Connection and Command Object
        ''''    Dim DBConn As SqlConnection
        ''''     

        ''''    DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

        ''''    'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionPagos"))
        ''''    'Dim cmd As SqlCommand = New SqlCommand("_CatalogoGetList", DBConn)

        ''''    ' Mark the Command as a SPROC
        ''''    'cmd.CommandType = CommandType.StoredProcedure

        ''''    ' Execute the command
        ''''    DBConn.Open()
        ''''    'Dim result As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        ''''    Dim dsCatalogo As New DataSet()

        ''''    Dim DBCommand As SqlDataAdapter
        ''''    DBCommand = New SqlDataAdapter("_CatalogoGetList", DBConn)
        ''''    DBCommand.Fill(dsCatalogo, "Catalogo")

        ''''    DBConn.Close()

        ''''    ' Return the datareader result
        ''''    'Return result
        ''''    Return dsCatalogo

        ''''End Function

        Public Function GetListBuscar(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA, CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " & _
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.NOMBRE LIKE '%" & Filtro & "%' AND EMPRESAS.CODIGO = '" & Empresa & "' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA AS CUENTA, CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " & _
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.TIPO = CATALOGO.BALRES AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.NOMBRE LIKE '" & Filtro & "%' AND EMPRESAS.CODIGO = '" & Empresa & "' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarComboMayor(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA AS CUENTA, CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " & _
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.NOMBRE LIKE '" & Filtro & "%' AND CATALOGO.TIPO = 'M' AND EMPRESAS.CODIGO = '" & Empresa & "' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarComboAuxiliar(ByVal Filtro As String, ByVal SubCuenta As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA AS CUENTA, CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " & _
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.NOMBRE LIKE '" & Filtro & "%' AND CATALOGO.TIPO = 'A' AND CATALOGO.SUBCUENTA = '" & SubCuenta & "' AND EMPRESAS.CODIGO = '" & Empresa & "' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function



        Public Function GetListCodigo(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CUENTA, NOMBRE, SUBCUENTA, SALDO_INICIAL, TIPO, CLASE FROM CATALOGO WHERE CUENTA ='" & Filtro & "' And Empresa = '" & Empresa & "'", DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigoBorrar(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CUENTA, NOMBRE, SALDO_INICIAL FROM CATALOGO WHERE CUENTA LIKE '" & Filtro & "%' AND CUENTA <> '" & Filtro & "' AND  Empresa = '" & Empresa & "'", DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListSubCuenta(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()



            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CUENTA, NOMBRE, SALDO_INICIAL FROM CATALOGO WHERE SUBCUENTA = '" & Filtro & "' AND Empresa = '" & Empresa & "'", DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub Additem(ByVal Cuenta As String, ByVal Nombre As String, ByVal Tipo As String, ByVal Cuenta_De As String, ByVal Saldo_Inicial As String, _
                                ByVal Presupuesto_Anual As String, ByVal Grupo As String, ByVal Empresa As String, ByVal SubCuenta As String, ByVal Clase As String, ByVal Debito As String, ByVal Credito As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando

            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Catalogo(Cuenta, Nombre, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual, Grupo, Clase, Empresa, Debito, Credito, SubCuenta) " & _
                        "Values(" & "'" & Cuenta & "','" & Nombre & "','" & Tipo & "','" & Cuenta_De & "','" & Saldo_Inicial & "','" & Presupuesto_Anual & "','" & Grupo & "','" & Clase & "','" & Empresa & "','" & Debito & "','" & Credito & "','" & SubCuenta & "')"
            'Try
            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

        End Sub


        Public Sub Update(ByVal Cuenta As String, ByVal Nombre As String, ByVal Tipo As String, ByVal Cuenta_De As String, ByVal Saldo_Inicial As String, _
                                ByVal Presupuesto_Anual As String, ByVal Grupo As String, ByVal Empresa As String, ByVal Clase As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Catalogo SET Nombre = '" & Nombre & "', " & _
                  "Tipo = '" & Tipo & "', " & _
                  "Cuenta_De = '" & Cuenta_De & "', " & _
                  "Saldo_Inicial = '" & Saldo_Inicial & "', " & _
                  "Presupuesto_Anual = '" & Presupuesto_Anual & "', " & _
                  "Grupo = '" & Grupo & "', " & _
                  "Clase = '" & Clase & "' " & _
                  "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub


        Public Function UpdateSaldos(ByVal Cuenta As String, ByVal Saldo_Actual As String, ByVal Saldo_Nuevo As String, ByVal Empresa As String) As Integer

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Catalogo SET Saldo_Inicial = '" & CInt(Saldo_Actual) + CInt(Saldo_Nuevo) & "' " & _
                              "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        'Esta funcion se utiliza cuando se modifica una cuenta
        Public Function UpdateSaldosEdit(ByVal Cuenta As String, ByVal Saldo As String, ByVal Tipo As Integer) As Integer

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            If Tipo = 1 Then
                cmd.CommandText = "UPDATE Catalogo SET Saldo_Inicial = '" & Saldo & "', " & _
                                  "Debito = '" & Saldo & "' " & _
                                  "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"
            Else
                cmd.CommandText = "UPDATE Catalogo SET Saldo_Inicial = '" & Saldo & "', " & _
                                  "Credito = '" & Saldo & "' " & _
                                  "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"
            End If

            'cmd.CommandText = "UPDATE Catalogo SET Saldo_Inicial = '" & Saldo & "', " & _
            '                  "Debito = '" & Saldo & "' " & _
            '                  "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Sub delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Catalogo WHERE Cuenta = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub


        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCatalogoReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

    End Class
End Namespace