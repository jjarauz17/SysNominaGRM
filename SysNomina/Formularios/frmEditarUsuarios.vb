Imports System.Data.SqlClient
Public Class frmEditarUsuarios

#Region "Variables"
    Public txtUsuario As String
#End Region

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub frmEditarUsuarios__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DsUser As DataSet = VB.SysContab.SeguridadDB.GetUsuario(txtUsuario)

        txtNombre.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_NombreCompleto")
        txtLogin.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_Login")
        txtPwd.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_Password")
        txtPwd2.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_Password")
        txtCorreo.Text = DsUser.Tables("Usuarios").Rows(0).Item("Usr_email")
        chkHabilitado.Checked = DsUser.Tables("Usuarios").Rows(0).Item("Usr_Habilitado")

        Me.gcRoles.DataSource = VB.SysContab.SeguridadDB.Usuario_Rol(txtUsuario)
        If Not Me.gcRoles.DataSource Is Nothing Then
            For i As Integer = 0 To Me.vRoles.Columns.Count - 2
                Me.vRoles.Columns(i).OptionsColumn.ReadOnly = True
                Me.vRoles.Columns(i).OptionsColumn.AllowFocus = False
            Next
            Me.vRoles.BestFitColumns()
            Me.vRoles.Columns("Codigo").Visible = False
            Me.vRoles.Columns("Usuario").Visible = False
        End If
        Me.gcEmpresas.DataSource = VB.SysContab.SeguridadDB.Usuario_Empresa(txtUsuario)
        If Not Me.gcEmpresas.DataSource Is Nothing Then
            For i As Integer = 0 To Me.vEmpresas.Columns.Count - 2
                Me.vEmpresas.Columns(i).OptionsColumn.ReadOnly = True
                Me.vEmpresas.Columns(i).OptionsColumn.AllowFocus = False
            Next
            Me.vEmpresas.BestFitColumns()
            Me.vEmpresas.Columns("Codigo").Visible = False
            Me.vEmpresas.Columns("Usuario").Visible = False

        End If

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim DBConn As SqlConnection

        DBConn = New SqlConnection(VB.SysContab.Conexion.AbrirConexion())
        Dim Transaccion As SqlTransaction = Nothing

        Try

            DBConn.Open()
            Transaccion = DBConn.BeginTransaction
            VB.SysContab.SeguridadDB.UsuariosUpdate(txtUsuario, txtNombre.Text, txtLogin.Text, txtPwd.Text, txtCorreo.Text, chkHabilitado.Checked, DBConn, Transaccion)
            VB.SysContab.SeguridadDB.UsuariosRolesBorrar(txtUsuario, DBConn, Transaccion)
            VB.SysContab.SeguridadDB.UsuariosEmpresasBorrar(txtUsuario, DBConn, Transaccion)

            For j As Integer = 0 To Me.vRoles.RowCount - 1
                If Me.vRoles.GetRowCellValue(j, "Asignado") = True Then
                    VB.SysContab.SeguridadDB.UsuariosRolesAdd(Me.vRoles.GetRowCellValue(j, "Codigo"), txtUsuario, DBConn, Transaccion)
                End If
            Next

            For j As Integer = 0 To Me.vEmpresas.RowCount - 1
                If Me.vEmpresas.GetRowCellValue(j, "Asignada") = True Then
                    VB.SysContab.SeguridadDB.UsuarioEmpresasAdd(txtUsuario, Me.vEmpresas.GetRowCellValue(j, "Codigo"), DBConn, Transaccion)
                End If
            Next


            Transaccion.Commit()
            DBConn.Close()
            Me.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Transaccion.Rollback()
            DBConn.Close()
        End Try

        ''Dim dsSeguridad As DataSet
        ''dsSeguridad = VB.SysContab.SeguridadDB.UsuarioRecursos(Usuario_ID)

        ''VB.SysContab.Rutinas.UsuariosRecursos(dsSeguridad)
        ' ''Menu Personal
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.cmdPersonal)
        ' ''Menu Catalogo
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.menuCatalogos)
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.menuMovimientos)
        ' ''Menu Procesos
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.menuProcesos)
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.menuPHorarios)
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.MenuPHorasExtras)
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.menuPMovimientos)
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.menuPlanilla)
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.menuVacaciones)
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.cmdPeriodos)

        ' ''Menu Reportes
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.MenuReportes)

        ' ''Menu Herramientas
        ''VB.SysContab.Rutinas.DesabilitarRecursos(FormPrincipal.menuHerramientas)


        ''VB.SysContab.Rutinas.UsuariosRecursos(dsSeguridad)
    End Sub
End Class
