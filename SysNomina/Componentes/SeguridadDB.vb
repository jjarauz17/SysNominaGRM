Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Edanmo.Security.Cryptography
Imports DbConnect


Namespace VB.SysContab

    Public Class LoginDetailsDB

        Public Empresa As String
        Public UserID As String
        Public Role As String

    End Class


    Public Class SeguridadTerrazaDB

        Public Shared Function ComprobarUsuario(ByVal loginUsr As String, ByVal PassUsr As String) As String
            '-------------------------------------------
            'Comprobar la identidad del usuario del Sistema
            Dim Tabla As DataTable
            Dim sSQL As String = "SELECT * FROM Usuarios WHERE Usr_Login = '" & loginUsr & "' AND Usr_Password = '" & PassUsr & "'"

            'Dim AD As New SqlDataAdapter("_Micros_SeguridadLogin", VB.SysContab.Rutinas.AbrirConexion())
            'AD.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim AD As New SqlDataAdapter(sSQL, VB.SysContab.Conexion.AbrirConexion())

            'AD.SelectCommand.Parameters.Add("@login", SqlDbType.NVarChar)
            'AD.SelectCommand.Parameters.Add("@pass", SqlDbType.NVarChar)

            'AD.SelectCommand.Parameters("@login").Value = loginUsr
            'AD.SelectCommand.Parameters("@pass").Value = PassUsr

            Tabla = New DataTable

            AD.Fill(Tabla)

            If Tabla.Rows.Count = 0 Then Return "" 'Datos Incorrectos

            Return Tabla.Rows.Item(0)("Usr_Password").ToString 'Usuario Encontrado, Datos Correctos
        End Function

        Public Shared Function GetPassword_SQL(ByVal loginUsuario As String, ByVal PassUsuarioContab As String) As String

            Dim Tpass As DataTable = Funciones.ObtieneDatos("SELECT pass_SQL FROM Micros_Configuraciones")
            '**************************************************************
            'Primero Guardar Contraseña en Configuraciones y luego
            'cambiar la contraseña al usuario

            Dim DBconn As New SqlConnection(VB.SysContab.Conexion.AbrirConexion)
            DBconn.Open()

            If Tpass.Rows.Item(0)("pass_SQL").ToString.Length = 0 Then
                Dim PassCifrado As String = StringEncryption.Encrypt("simtesis2403", "simtesis2403") 'Debe de Guardarse Encripatada en la base de datos
                Dim cmd2 As New SqlCommand("UPDATE Micros_Configuraciones Set pass_SQL = '" & PassCifrado & "'", DBconn)
                cmd2.ExecuteNonQuery()
            End If

            Try
                'Cambiar la Contraseña del usuario del SQL
                Dim cmd As New SqlCommand("_Micros_ChangePassLogin", DBconn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@login", SqlDbType.NVarChar)
                cmd.Parameters.Add("@password", SqlDbType.NVarChar)

                cmd.Parameters("@login").Value = loginUsuario
                cmd.Parameters("@password").Value = PassUsuarioContab


                cmd.ExecuteNonQuery()
                DBconn.Close()
            Catch ex As Exception
            End Try

            Return StringEncryption.Decrypt(Tpass.Rows.Item(0)("pass_SQL").ToString, "simtesis2403") 'Desencriptar Password
        End Function

        Public Shared Function Login(ByVal UserName As String, _
                                        ByVal Password As String) As LoginDetailsDB

            ' Create Instance of Connection and Command Object
            Dim Conn As SqlConnection

            Conn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            Dim cmd As New SqlCommand("_UsuariosLogin", Conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Login As SqlParameter = New SqlParameter("@UsrLogin", SqlDbType.NVarChar, 50)
            _Login.Value = UserName
            cmd.Parameters.Add(_Login)

            Dim _Password As SqlParameter = New SqlParameter("@UsrPassword", SqlDbType.NVarChar, 50)
            _Password.Value = Password
            cmd.Parameters.Add(_Password)

            Dim UserID As SqlParameter = New SqlParameter("@UserID", SqlDbType.NVarChar, 50)
            UserID.Direction = ParameterDirection.Output
            cmd.Parameters.Add(UserID)

            Dim Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.NVarChar, 50)
            Empresa.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Empresa)

            Dim Rol As SqlParameter = New SqlParameter("@Rol", SqlDbType.NVarChar, 50)
            Rol.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Rol)

            Try
                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try


            Dim Det As New LoginDetailsDB()

            If UserID.Value Is DBNull.Value Then
                Det.UserID = String.Empty
            Else
                Det.UserID = CStr(UserID.Value)
            End If

            If Empresa.Value Is DBNull.Value Then
                Det.Empresa = String.Empty
            Else
                Det.Empresa = CStr(Empresa.Value)
            End If

            If Rol.Value Is DBNull.Value Then
                Det.Role = String.Empty
            Else
                Det.Role = CStr(Rol.Value)
            End If
            Return Det

        End Function

    End Class
    Public Class SeguridadDB
        ''Rtg
        Public Shared Function Usuario_Empresa(ByVal Usuario As Integer) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("UserID", SqlDbType.Int, 5, ParameterDirection.Input, Usuario)
            Try
                Return v.EjecutarComando("Rh_Usuario_Empresa", "UsuariosEmpresas")
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Shared Function Usuario_Rol(ByVal Usuario As Integer) As DataTable
            Dim v As New Connect(VB.SysContab.Conexion.AbrirConexion)

            v.AddParameter("UserID", SqlDbType.Int, 5, ParameterDirection.Input, Usuario)
            Try
                Return v.EjecutarComando("Rh_Usuario_Rol", "UsuariosRoles")
            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Shared Sub RolesAccionesAdd(ByVal RolID As Integer, ByVal AccionID As Integer, _
                                                ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_RolesAccionesAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@AccionID", SqlDbType.Int)
            Param.Value = AccionID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 1
            cmd.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()
        End Sub

        Public Shared Sub RolesAccionesBorrar(ByVal RolID As Integer, _
                                      ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)
            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_RolesAccionesDelete", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 1
            cmd.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Function UsuarioAcciones(ByVal UserID As Integer, ByVal Recurso As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuarioAcciones", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@Usuario", SqlDbType.Int)
            _Usuario.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(_Usuario)

            Dim _Recurso As New SqlParameter("@Recurso", SqlDbType.NVarChar)
            _Recurso.Value = Recurso
            DBCommand.SelectCommand.Parameters.Add(_Recurso)

            DBCommand.Fill(dsFicha, "Usuarios")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function RecursosAcciones(ByVal Nivel As Integer, ByVal Accion As Integer, ByVal Recurso As Integer, ByVal Rol As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RecursosAcciones", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Nivel As New SqlParameter("@Nivel", SqlDbType.Int)
            _Nivel.Value = Nivel
            DBCommand.SelectCommand.Parameters.Add(_Nivel)

            Dim _Accion As New SqlParameter("@Accion", SqlDbType.Int)
            _Accion.Value = Accion
            DBCommand.SelectCommand.Parameters.Add(_Accion)

            Dim _Recurso As New SqlParameter("@Recurso", SqlDbType.Int)
            _Recurso.Value = Recurso
            DBCommand.SelectCommand.Parameters.Add(_Recurso)

            Dim _Rol As New SqlParameter("@Rol", SqlDbType.Int)
            _Rol.Value = Rol
            DBCommand.SelectCommand.Parameters.Add(_Rol)

            DBCommand.Fill(dsFicha, "Usuarios")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function UsuarioRecursos(ByVal UserID As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuarioRecursos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@Usuario", SqlDbType.Int)
            _Usuario.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(_Usuario)

            DBCommand.Fill(dsFicha, "Usuarios")
            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Sub UsuariosEmpresasBorrar(ByVal UsrID As Integer, _
                                             ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)
            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosEmpresasDelete", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UsrID", SqlDbType.Int)
            Param.Value = UsrID
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Sub UsuariosRolesBorrar(ByVal UsrID As Integer, _
                                             ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosRolesDelete", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UsrID", SqlDbType.Int)
            Param.Value = UsrID
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Sub UsuariosUpdate(ByVal UsrID As Integer, ByVal Nombre As String, ByVal Login As String, _
                                              ByVal Password As String, ByVal Email As String, ByVal Habilitado As Boolean, _
                                              ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosUpdate", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UserID", SqlDbType.Int)
            Param.Value = UsrID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Param.Value = Nombre
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Login", SqlDbType.NVarChar)
            Param.Value = Login
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Password", SqlDbType.NVarChar)
            Param.Value = Password
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Email", SqlDbType.NVarChar)
            Param.Value = Email
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Habilitado", SqlDbType.Bit)
            Param.Value = Habilitado
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Function GetUsuario(ByVal UserID As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuarioGetDetalle", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pUserID As New SqlParameter("@UserID", SqlDbType.Int)
            pUserID.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(pUserID)

            DBCommand.Fill(dsFicha, "Usuarios")
            DBConn.Close()

            DBCommand = New SqlDataAdapter("_UsuariosRolesxUserID", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pRol As New SqlParameter("@UserID", SqlDbType.Int)
            pRol.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(pRol)

            DBCommand.Fill(dsFicha, "UsuariosRoles")
            DBConn.Close()


            DBCommand = New SqlDataAdapter("_UsuariosEmpresasxUserID", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmp As New SqlParameter("@UserID", SqlDbType.Int)
            pEmp.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(pEmp)

            DBCommand.Fill(dsFicha, "UsuariosEmpresas")
            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Sub UsuariosBorrar(ByVal UserID As Integer)
            Dim DBConn As SqlConnection
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosDelete", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UserID", SqlDbType.Int)
            Param.Value = UserID
            cmd.Parameters.Add(Param)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()


        End Sub


        Public Shared Function GetUsuariosList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuariosList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Function Login(ByVal UserName As String, _
                                        ByVal Password As String) As LoginDetailsDB

            ' Create Instance of Connection and Command Object
            Dim Conn As SqlConnection

            Conn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            Dim cmd As New SqlCommand("_UsuariosLoginNomina", Conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Login As SqlParameter = New SqlParameter("@UsrLogin", SqlDbType.NVarChar, 50)
            _Login.Value = UserName
            cmd.Parameters.Add(_Login)

            Dim _Password As SqlParameter = New SqlParameter("@UsrPassword", SqlDbType.NVarChar, 50)
            _Password.Value = Password
            cmd.Parameters.Add(_Password)

            Dim UserID As SqlParameter = New SqlParameter("@UserID", SqlDbType.NVarChar, 50)
            UserID.Direction = ParameterDirection.Output
            cmd.Parameters.Add(UserID)

            Dim Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.NVarChar, 50)
            Empresa.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Empresa)

            Dim Rol As SqlParameter = New SqlParameter("@Rol", SqlDbType.NVarChar, 50)
            Rol.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Rol)

            Try
                Conn.Open()
                cmd.ExecuteNonQuery()
                Conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try


            Dim Det As New LoginDetailsDB()

            If UserID.Value Is DBNull.Value Then
                Det.UserID = String.Empty
            Else
                Det.UserID = CStr(UserID.Value)
            End If

            If Empresa.Value Is DBNull.Value Then
                Det.Empresa = String.Empty
            Else
                Det.Empresa = CStr(Empresa.Value)
            End If

            If Rol.Value Is DBNull.Value Then
                Det.Role = String.Empty
            Else
                Det.Role = CStr(Rol.Value)
            End If
            Return Det

        End Function


        Public Shared Sub UsuariosRolesAdd(ByVal RolID As Integer, ByVal UsrID As Integer, _
                                               ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosRolesAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@UsrID", SqlDbType.Int)
            Param.Value = UsrID
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Sub UsuarioEmpresasAdd(ByVal UserID As Integer, ByVal EmpresaID As String, _
                               ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosEmpresasAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UserID", SqlDbType.Int)
            Param.Value = UserID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@EmpresaID", SqlDbType.Int)
            Param.Value = EmpresaID
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Function UsuariosAdd(ByVal Login As String, ByVal Nombre As String, ByVal Password As String, ByVal Email As String, ByVal Habilitado As Boolean, _
                                      ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction) As Integer

            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Param.Value = Nombre
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Login", SqlDbType.NVarChar)
            Param.Value = Login
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Password", SqlDbType.NVarChar)
            Param.Value = Password
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Email", SqlDbType.NVarChar)
            Param.Value = Email
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Habilitado", SqlDbType.Bit)
            Param.Value = Habilitado
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@UserID", SqlDbType.Int)
            Param.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

            If Not Param.Value Is DBNull.Value Then
                Return Param.Value
            Else
                Return 0
            End If


        End Function



        Public Shared Function GetRolesActivos() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RolesGetListHabilitado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Sub RolesRecursosBorrar(ByVal RolID As Integer, _
                                              ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)
            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_RolesRecurosDelete", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 1
            cmd.Parameters.Add(pModulo)
            'DBCommand.SelectCommand.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Sub RolesUpdate(ByVal RolID As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal Habilitado As Boolean, _
                                        ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)
            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_RolesUpdate", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Param.Value = Nombre
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Param.Value = Descripcion
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Habilitado", SqlDbType.Bit)
            Param.Value = Habilitado
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Function GetRol(ByVal RolID As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RolesGetRol", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pRolID As New SqlParameter("@RolID", SqlDbType.Int)
            pRolID.Value = RolID
            DBCommand.SelectCommand.Parameters.Add(pRolID)

            DBCommand.Fill(dsFicha, "Roles")
            DBConn.Close()

            DBCommand = New SqlDataAdapter("_RolesGetRolRecurso", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pRol As New SqlParameter("@RolID", SqlDbType.Int)
            pRol.Value = RolID
            DBCommand.SelectCommand.Parameters.Add(pRol)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 1
            DBCommand.SelectCommand.Parameters.Add(pModulo)

            DBCommand.Fill(dsFicha, "RolesRecursos")
            DBConn.Close()

            Return dsFicha

        End Function



        Public Shared Sub RolesBorrar(ByVal RolID As Integer)
            Dim DBConn As SqlConnection
            Dim dsFicha As New DataSet()

            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_RolesDelete", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()


        End Sub



        Public Shared Function GetLisRoles() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBCommand = New SqlDataAdapter("_RolesGetList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()
            Return dsFicha
        End Function

        Public Shared Sub RolesRecursosAdd(ByVal RolID As Integer, ByVal ResID As Integer, _
                                                ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_RolesRecursosAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@ResID", SqlDbType.Int)
            Param.Value = ResID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 1
            cmd.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()
        End Sub


        Public Shared Function RolesAdd(ByVal Nombre As String, ByVal Descripcion As String, ByVal Habilitado As Boolean, _
                                        ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction) As String
            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_RolesAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Param.Value = Nombre
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Param.Value = Descripcion
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Habilitado", SqlDbType.Bit)
            Param.Value = Habilitado
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

            If Not Param.Value Is DBNull.Value Then
                Return Param.Value
            Else
                Return 0
            End If


        End Function



        Public Shared Function GetLisRecursos() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
            DBCommand = New SqlDataAdapter("_RecursosGetList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()
            Return dsFicha
        End Function


    End Class


End Namespace