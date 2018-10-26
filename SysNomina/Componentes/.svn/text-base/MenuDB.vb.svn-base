Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration

Namespace VB.SysContab

    Public Class MenuDB

        Public Function GetList() As DataSet

            Dim DBConn As OleDbConnection
            Dim cmd As New OleDbCommand()
            Dim DBCommand As OleDbDataAdapter
            Dim dsPartidos As New DataSet()

            DBConn = New OleDbConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New OleDbDataAdapter("Select * From Menus ORDER BY Menu_Id", DBConn)
            DBCommand.Fill(dsPartidos, "Menus")

            ' Retorna los resultados de DataSet
            Return dsPartidos

        End Function

        Public Function GetListFormulario(ByVal Codigo As String) As DataSet

            Dim DBConn As OleDbConnection
            Dim cmd As New OleDbCommand()
            Dim DBCommand As OleDbDataAdapter
            Dim dsPartidos As New DataSet()

            DBConn = New OleDbConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New OleDbDataAdapter("Select * From Formularios WHERE Cod_Menu = '" & Codigo & "'", DBConn)
            DBCommand.Fill(dsPartidos, "Formularios")

            ' Retorna los resultados de DataSet
            Return dsPartidos

        End Function


        Public Function GetListSubMenu(ByVal Codigo As String) As DataSet

            Dim DBConn As OleDbConnection
            Dim cmd As New OleDbCommand()
            Dim DBCommand As OleDbDataAdapter
            Dim dsPartidos As New DataSet()

            DBConn = New OleDbConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New OleDbDataAdapter("Select * From SubMenu WHERE Cod_Menu = " & Codigo & "", DBConn)
            DBCommand.Fill(dsPartidos, "SubMenu")

            ' Retorna los resultados de DataSet
            Return dsPartidos

        End Function


        Public Function aaaGetList() As DataSet

            Dim DBConn As OleDbConnection
            Dim cmd As New OleDbCommand()
            Dim DBCommand As OleDbDataAdapter
            Dim dsPartidos As New DataSet()

          
            DBConn = New OleDbConnection(VB.SysContab.Conexion.AbrirConexion())

            DBCommand = New OleDbDataAdapter("Select * From Menus", DBConn)
            DBCommand.Fill(dsPartidos, "Menus")

            ' Retorna los resultados de DataSet
            Return dsPartidos

        End Function


        Public Function GetListUsr(ByVal CodUsr As String) As DataSet

            Dim DBConn As OleDbConnection
            Dim cmd As New OleDbCommand()
            Dim DBCommand As OleDbDataAdapter
            Dim dsPartidos As New DataSet()

            If CodUsr <> "" Then


                DBConn = New OleDbConnection(VB.SysContab.Conexion.AbrirConexion())

                DBCommand = New OleDbDataAdapter("SELECT DISTINCT Menus.* FROM Usuarios INNER JOIN ((Roles INNER JOIN (Menus INNER JOIN Permisos ON Menus.Menu_ID = Permisos.Res_ID) ON Roles.Rol_ID = Permisos.Rol_ID) INNER JOIN UsuariosRoles ON Roles.Rol_ID = UsuariosRoles.Rol_ID) ON Usuarios.Cod_Usr = UsuariosRoles.Cod_Usr WHERE Usuarios.Cod_Usr = Cint('" & CodUsr & "') ORDER BY  Menu_ID ", DBConn)
                DBCommand.Fill(dsPartidos, "Menus")

            End If
            ' Retorna los resultados de DataSet
            Return dsPartidos

        End Function


        Public Function GetListCentral(ByVal CodUsr As String) As DataSet

            Dim DBConn As OleDbConnection
            Dim cmd As New OleDbCommand()
            Dim DBCommand As OleDbDataAdapter
            Dim dsPartidos As New DataSet()

            If CodUsr <> "" Then

                DBConn = New OleDbConnection(VB.SysContab.Conexion.AbrirConexion())

                DBCommand = New OleDbDataAdapter("SELECT DISTINCT Menus.* FROM Usuarios INNER JOIN ((Roles INNER JOIN (Menus INNER JOIN Permisos ON Menus.Menu_ID = Permisos.Res_ID) ON Roles.Rol_ID = Permisos.Rol_ID) INNER JOIN UsuariosRoles ON Roles.Rol_ID = UsuariosRoles.Rol_ID) ON Usuarios.Cod_Usr = UsuariosRoles.Cod_Usr WHERE Usuarios.Cod_Usr = Cint('" & CodUsr & "') ORDER BY  Menu_ID ", DBConn)
                DBCommand.Fill(dsPartidos, "Menus")

            End If
            ' Retorna los resultados de DataSet
            Return dsPartidos

        End Function

    End Class

End Namespace

