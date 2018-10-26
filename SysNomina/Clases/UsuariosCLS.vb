Imports System.Drawing
Imports DbConnect
Imports DevExpress.XtraEditors

Public Class UsuariosCLS
    Implements IDisposable

#Region " Private variables "
    Private _IdUsuario As Integer
    Private _Nombre As String
    Private _Login As String
    Private _IdRol As Integer
    Private _Cargo As String
    Private _Activo As Boolean
#End Region

    Private Funcion As New Functions
    Private Conn As Connect
    Private Cadena As New Conection

#Region " Properties "
    Public ReadOnly Property IdUsuario() As Integer
        Get
            Return _IdUsuario
        End Get
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal Value As String)
            _Nombre = Value
        End Set
    End Property

    Public Property Login() As String
        Get
            Return _Login
        End Get
        Set(ByVal Value As String)
            _Login = Value
        End Set
    End Property

    Public Property IdRol() As Integer
        Get
            Return _IdRol
        End Get
        Set(ByVal Value As Integer)
            _IdRol = Value
        End Set
    End Property

    Public Property Cargo() As String
        Get
            Return _Cargo
        End Get
        Set(ByVal Value As String)
            _Cargo = Value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal Value As Boolean)
            _Activo = Value
        End Set
    End Property

#End Region

    Sub New()
        MyBase.New()
        _IdUsuario = 0
        _Nombre = String.Empty
        _Login = String.Empty
        _IdRol = 0
        _Cargo = String.Empty
        _Activo = False
    End Sub

    Public Function List() As DataTable
        _IdUsuario = 0
        Conn = New Connect(Cadena.ConectionString)
        Conn.AddParameter("IdUsuario", SqlDbType.Int, 4, ParameterDirection.Input, IdUsuario)
        Return (Conn.EjecutarComando("Get_Usuarios"))
    End Function

    Public Function UserData() As DataTable
        Conn = New Connect(Cadena.ConectionString)
        Return (Conn.EjecutarComando("Get_UserData"))
    End Function

    Public Sub Load(ByVal vIdUsuario As Integer)
        _IdUsuario = vIdUsuario
        If IdUsuario = 0 Then Exit Sub
        Conn = New Connect(Cadena.ConectionString)
        Conn.AddParameter("IdUsuario", SqlDbType.Int, 4, ParameterDirection.Input, IdUsuario)
        Dim Tabla As DataTable = Conn.EjecutarComando("Get_Usuarios")
        If Tabla.Rows.Count = 0 Then Exit Sub
        _IdUsuario = Tabla.Rows(0).Item("Codigo")
        _Nombre = Tabla.Rows(0).Item("Nombre")
        _Login = Tabla.Rows(0).Item("Login")
        _IdRol = Tabla.Rows(0).Item("IdRol")
        _Cargo = Tabla.Rows(0).Item("Cargo")
        _Activo = Tabla.Rows(0).Item("Activo")
    End Sub

    Public Sub FillCombo(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = List()
        Combo.Properties.DisplayMember = ""
        Combo.Properties.ValueMember = "IdUsuario"
        Combo.Properties.NullText = "[Seleccione el IdUsuario]"
        Combo.Properties.ShowFooter = False
        Combo.Properties.ShowHeader = False
        Combo.Properties.ForceInitialize()
        Combo.Properties.PopulateColumns()
        For i As Integer = 0 To Combo.Properties.Columns.Count - 1
            If i <> 1 Then Combo.Properties.Columns(i).Visible = False
        Next
    End Sub

    Public Function Save() As Boolean
        Dim Conn As New DbConnect.Connect(Cadena.ConectionString)
        Conn.AddParameter("IdUsuario", SqlDbType.Int, 4, ParameterDirection.InputOutput, IdUsuario)
        Conn.AddParameter("DBName", SqlDbType.VarChar, 20, ParameterDirection.Input, Cadena.Base)
        Conn.AddParameter("Login", SqlDbType.VarChar, 120, ParameterDirection.Input, Login)
        Conn.AddParameter("User", SqlDbType.VarChar, 120, ParameterDirection.Input, Nombre)
        Conn.AddParameter("IdRol", SqlDbType.Int, 4, ParameterDirection.Input, IdRol)
        Conn.AddParameter("Cargo", SqlDbType.NVarChar, 250, ParameterDirection.Input, Cargo)
        Conn.AddParameter("Activo", SqlDbType.Bit, 1, ParameterDirection.Input, 1)
        Conn.IniciarTransaccion()
        Try
            Conn.EjecutarComando("PROC_Usuarios")
            Conn.CompletarTransaccion()
            _IdUsuario = Conn.GetParameter("IdUsuario").Valor
            Return True
        Catch ex As Exception
            Conn.AnularTransaccion()
            XtraMessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function Save_Empresa(ByVal empresa As Integer, ByVal activo As Boolean) As Boolean
        Dim Conn As New DbConnect.Connect(Cadena.ConectionString)
        Conn.AddParameter("IdUsuario", SqlDbType.Int, 4, ParameterDirection.Input, IdUsuario)
        Conn.AddParameter("empresa", SqlDbType.Int, 4, ParameterDirection.Input, empresa)
        Conn.AddParameter("Activo", SqlDbType.Bit, 1, ParameterDirection.Input, activo)
        Conn.IniciarTransaccion()
        Try
            Conn.EjecutarComando("_RH_UsuariosEmpresa")
            Conn.CompletarTransaccion()
            Return True
        Catch ex As Exception
            Conn.AnularTransaccion()
            XtraMessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function ChangePass(ByVal User As String, ByVal Old As String, ByVal Pass As String) As Boolean
        Dim Conn As New DbConnect.Connect(Cadena.ConectionString)
        Conn.AddParameter("User", SqlDbType.NVarChar, 250, ParameterDirection.Input, User)
        Conn.AddParameter("Old", SqlDbType.NVarChar, 250, ParameterDirection.Input, Old)
        Conn.AddParameter("Pass", SqlDbType.NVarChar, 250, ParameterDirection.Input, Pass)
        Try
            Conn.EjecutarComando("Proc_ChangePass")
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                MyBase.Finalize()
                ' TODO: free other state (managed objects).
            End If

            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class