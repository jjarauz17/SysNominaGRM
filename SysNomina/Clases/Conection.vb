Imports System.Data.SqlClient

Public Class Conection
    Private _Tipo As Integer
    Private _Rol As Integer
    Private _Ruta As String
    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(ByVal value As String)
            _Ruta = value
        End Set
    End Property

    Public Property Tipo() As Integer
        Get
            Return _Tipo
        End Get
        Set(ByVal value As Integer)
            _Tipo = value
        End Set
    End Property

    Public Property Rol() As Integer
        Get
            Return _Rol
        End Get
        Set(ByVal value As Integer)
            _Rol = value
        End Set
    End Property

    ReadOnly Property Base()
        Get
            Base = GetSetting("Simtesis", "SysNomina2014", "BaseDatos")
        End Get
    End Property

    ReadOnly Property Servidor()
        Get
            Servidor = GetSetting("Simtesis", "SysNomina2014", "Server")
        End Get
    End Property

    ReadOnly Property Usuario()
        Get
            Usuario = sUsuario
        End Get
    End Property

    ReadOnly Property Contrasena()
        Get
            Contrasena = sContrasena
        End Get
    End Property

    ReadOnly Property ConectionString()
        Get
            ConectionString = "Server = " & Servidor & "; Failover Partner = 192.168.0.6; Initial Catalog = " & Base & ";User Id=" & sUsuario & ";Password = " & sContrasena
        End Get
    End Property

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal vUsuario As String, ByVal vContrasena As String)
        MyBase.New()
        sUsuario = vUsuario
        sContrasena = vContrasena
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Function Test() As Boolean
        Dim Con As New SqlConnection
        Con.ConnectionString = "Server = " & Servidor & ";Failover Partner = 192.168.0.6; User Id=" & sUsuario & ";Password = " & sContrasena & ";Initial Catalog = " & Base
        Try
            Con.Open()
            Return True
            Con.Close()
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
