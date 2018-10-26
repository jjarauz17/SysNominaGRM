Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Catalogo_BancosDetails
        Public Codigo As String
        Public Nombre As String

    End Class

    Public Class Catalogo_BancosDB
        

        Public Function CatalogoBancosXCuenta(ByVal Cuenta As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoBancosXCuenta", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            DBCommand.Fill(dsFicha, "CATALOGO_BANCOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CatalogoBancos() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoBancos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Shared Function CatalogoBancos(ByVal Nomina As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Nom_CatalogoBancos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBConn.Open()
                DBCommand.Fill(dsFicha, "Tabla")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Nomina")
                Return Nothing
            End Try
        End Function

        Public Shared Function GetCheque(ByVal Banco As String, ByVal CuentaBanco As String) As String

            ' Create Instance of Connection and Command Object
            Dim DBConn As SqlConnection
            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            Dim cmd As SqlCommand = New SqlCommand("_BancosGetCheque", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _CuentaBanco As New SqlParameter("@CuentaBanco", SqlDbType.NVarChar)
            _CuentaBanco.Value = CuentaBanco
            cmd.Parameters.Add(_CuentaBanco)

            Dim _Banco As New SqlParameter("@Banco", SqlDbType.NVarChar)
            _Banco.Value = Banco
            cmd.Parameters.Add(_Banco)

            Dim _Cheque As SqlParameter = New SqlParameter("@Cheque", SqlDbType.NVarChar, 40)
            _Cheque.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_Cheque)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            Return _Cheque.Value

        End Function


        Public Shared Function GetCuentaContable(ByVal Banco As String, ByVal CuentaBanco As String) As String

            ' Create Instance of Connection and Command Object
            Dim DBConn As SqlConnection

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            Dim cmd As SqlCommand = New SqlCommand("_BancosGetCuentaContable", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _CuentaBanco As New SqlParameter("@CuentaBanco", SqlDbType.NVarChar)
            _CuentaBanco.Value = CuentaBanco
            cmd.Parameters.Add(_CuentaBanco)

            Dim _Banco As New SqlParameter("@Banco", SqlDbType.NVarChar)
            _Banco.Value = Banco
            cmd.Parameters.Add(_Banco)

            Dim _CuentaContable As SqlParameter = New SqlParameter("@CuentaContable", SqlDbType.NVarChar, 40)
            _CuentaContable.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_CuentaContable)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            Return _CuentaContable.Value

        End Function

        Public Function GetList(ByVal Bancos As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoBancosGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Bancos As New SqlParameter("@Banco", SqlDbType.Int)
            _Bancos.Value = Bancos
            DBCommand.SelectCommand.Parameters.Add(_Bancos)

            DBCommand.Fill(dsFicha, "CATALOGO_BANCOS")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Function GetLista(ByVal Bancos As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoBancosGetLista", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Bancos As New SqlParameter("@Banco", SqlDbType.Int)
            _Bancos.Value = Bancos
            DBCommand.SelectCommand.Parameters.Add(_Bancos)

            DBCommand.Fill(dsFicha, "CATALOGO_BANCOS")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Function GetListNuevo(ByVal Banco As String, ByVal Cuenta As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM CATALOGO_BANCOS WHERE BANCO = '" & Banco & "' AND CUENTA = '" & Cuenta & "' AND EMPRESA = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO_BANCOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Zonas WHERE Nombre Like '%" & Filtro & "%'", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNombre(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Zonas WHERE Nombre = '" & Filtro & "'", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub AddItem(ByVal Cuenta As String, ByVal Banco As String, _
                               ByVal Tipo_Cuenta As String, ByVal Numero_Cuenta As String, _
                               ByVal Formato As String, ByVal Moneda As String, ByVal Cheque As String)


            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO CATALOGO_BANCOS(CUENTA, BANCO, TIPO_CUENTA, NUMERO_CUENTA, FORMATO, MONEDA ,EMPRESA, CHEQUE) " & _
                        "Values(" & "'" & Cuenta & "','" & Banco & "','" & Tipo_Cuenta & "','" & Numero_Cuenta & "','" & Formato & "','" & Moneda & "','" & EmpresaActual & "', '" & Cheque & "')"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Update_ServicioPlanilla(ByVal Codigo As String, ByVal Consecutivo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE catalogo_bancos SET  con_serv_planilla = '" & Consecutivo & "' " & "WHERE Codigo = '" & Codigo & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        Public Sub Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM CATALOGO_BANCOS WHERE Codigo ='" & Codigo & "'"

            'Se asigna conexion al comando y se abre conexion 
            Try
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
            Catch EXC As Exception
                MsgBox(EXC.Message)
            End Try
            DBConn.Close()

        End Sub

    End Class

End Namespace
